using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Payment
    {
        private DataBaseManeger DataBase ;
        private SqlConnection conn ;
        private Customer customer ;
        private Settings settings ;
        private double PIDnumaricValue;

        public Payment()
        {
            DataBase = new DataBaseManeger();
            customer = new Customer();
            settings = new Settings();
            conn = DataBase.getSqlConnection();
            formatPID();
            

        }
        public int getfirstRecordYear()
        {
            int year = -1;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select top 1 Date from Payment order by Date DESC",conn);
                DateTime dateTime = Convert.ToDateTime(cmd.ExecuteScalar());
                year = Convert.ToInt32(dateTime.Year);
            }
            finally { conn.Close(); }
            return year;
        }
        private void formatPID()
        {
            string Value = null;
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select top 1 PID from Payment order by PID DESC", conn);
            object LCID = cmd.ExecuteScalar();
            conn.Close();

            if (LCID != null && LCID != DBNull.Value)
            {
                String temp = Convert.ToString(LCID);
                Value = temp.Substring(1);
            }
            else
            {
                Value = "0";
            }
            PIDnumaricValue = Convert.ToDouble(Value);

        }
        public int addRecordPayment(String CID,int price,String type)
        {
            PIDnumaricValue++;
            String PID = "P" + PIDnumaricValue.ToString("000000");
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into Payment values('" + PID + "',getDate(),'" +price+ "','" + CID + "','"+type+"')",conn);
                cmd.ExecuteNonQuery();
                return 1;
            }
            catch
            {
                return -1;
            }
            finally { conn.Close(); }
     
        }

        public int addRegisterPayment(String CID)
        {
            int result = addRecordPayment(CID,settings.getRegisterFee(),"R");
            return result;
        }

        public int addMonthlyPayment(String Data,int value)
        {
            String CID = customer.getCIDByCIDorPno(Data);
            return addRecordPayment(CID, value,"M");
        }

        public int setMonthlyPayment(String Data,int month)
        {
            String PID = "P" + PIDnumaricValue.ToString("000000");
            
            try
            {
                String CID = customer.getCIDByCIDorPno(Data);
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into MonthlyPayment values('" + PID + "','" + CID + "','" + month + "')",conn);
                cmd.ExecuteNonQuery();

            }
            catch
            {
                return -1;
            }
            finally { conn.Close(); }   
            return 1;

        }

        public int addOverduePayment(String Data, int value,String RID )
        { 
            try
            {
                String CID = customer.getCIDByCIDorPno(Data);
                int result = addRecordPayment(CID, value, "O");
                if (result == 1)
                {
                    conn.Open();
                    String PID = "P" + PIDnumaricValue.ToString("000000");
                    SqlCommand cmd = new SqlCommand("Update Reservation set PID = '"+PID+"' where RID = '"+RID+"'", conn);
                    cmd.ExecuteNonQuery();
                }
                return 1;

            }
            catch
            {
                return -1;
            }
            finally { conn.Close(); }
            

        }

        public int checkMonthlyPaymentByCID(String CID)
        {
            DateTime date = DateTime.Now;
            int month = date.Month;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from MonthlyPayment where CID = '" + CID + "' and Month = '" + month + "' ", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    return 1;
                }
            }
            finally
            {
                conn.Close();
            }
            return -1;
        }

        public DataTable getMonthlyPaymentTableByCID(String CID)
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select Mp.PID,Mp.CID,co.FName,Mp.Month from MonthlyPayment Mp inner join Customer co on Mp.CID = co.CID where Mp.CID = '"+CID+"'", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd); 
                adapter.Fill(dt);
                
            }
            catch { return null; }
            finally { conn.Close(); }
            return dt;
        }

        public DataTable getAllMonthlyPayment()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * from MonthlyPayment", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);

            }
            catch { return null; }
            finally { conn.Close(); }
            return dt;
        }

        public DataTable getAllPayment()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * from Payment", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);  
                adapter.Fill(dt);
                
            }
            catch { return null; }
            finally { conn.Close(); }
            return dt;
        }
        
        public object[] getPaymentReport(int year,int month,String type)
        {
            try
            {
                double total = 0;
                DataTable table = new DataTable();
                DataTable relativeData = new DataTable();
                relativeData.Columns.Add("PID", typeof(String));
                relativeData.Columns.Add("Date", typeof(String));
                relativeData.Columns.Add("Amount", typeof(String));
                relativeData.Columns.Add("CID", typeof(String));
            
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from Payment where Type = '"+type+"'",conn);
                conn.Close();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(table);
                table.Columns.Remove("Type");
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        DateTime dateTime = Convert.ToDateTime(row[1]);
                        if (year == Convert.ToInt32(dateTime.Year) && month == Convert.ToInt32(dateTime.Month))
                        {
                            relativeData.ImportRow(row);
                        }

                    }
                }

                if (relativeData.Rows.Count > 0)
                {
                    foreach (DataRow row in relativeData.Rows)
                    {
                        double price = Convert.ToDouble(row[2]);
                        total += price;
                    }
                }

                object[] arr = new object[2];
                arr[0] = total;
                arr[1] = relativeData;

                return arr;

            }
            catch
            {
                object[] arr = new object[1];
                arr[0] = -1;
                return arr;
            }

        }

    }


}
