using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Customer
    {
        private SqlConnection conn;
        
        private double CIDnumaricValue;
        public Customer() 
        {
            DataBaseManeger dataBaseManeger = new DataBaseManeger();
            conn = dataBaseManeger.getSqlConnection();
            formatCID();
            
        }

        private void formatCID()
        {
            string Value = null;
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select top 1 CID from Customer order by CID DESC",conn);
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
            CIDnumaricValue = Convert.ToDouble(Value);
             
        }

        public String getLastCID()
        {
            String CID = "C" + CIDnumaricValue.ToString("000000");
            return CID;
        }

        public String getNextCID()
        {
            double temp = CIDnumaricValue + 1;
            String CID = "C" + temp.ToString("000000");
            return CID;
        }

        public int addCustomer(String FName, String LName, String NIC, String Pno, String Email)
        {
            CIDnumaricValue++;
            String CID = "C" + CIDnumaricValue.ToString("000000");
            
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Insert into Customer values('"+CID+"','" + FName + "','" + LName + "','" + NIC + "','" + int.Parse(Pno) + "','" + Email + "')", conn);
                cmd.ExecuteNonQuery();
                
            }
            catch
            {
                return -1;
            }
            finally
            {
                conn.Close();
            }
            return 1;
            
        }

        public DataTable searchCustomerByPno(String Pno)
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                int number = Convert.ToInt32(Pno);
                SqlCommand cmd = new SqlCommand("Select * from Customer where PNo = '" + number + "'", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);   
                
            }
            catch { }
            finally { conn.Close(); }
            return dt;
        }

        public int updateCustomerByCID(String CID,String FName,String LName,String NIC,String pno,String Email)
        {
            try
            {
                conn.Open();
                String command = "Update Customer set FName = '"+FName+"',LName = '"+LName+"',NIC = '"+NIC+"',PNo = '"+int.Parse(pno)+"', Email = '"+Email+"' where CID = '"+CID+"'" ;
                SqlCommand cmd = new SqlCommand(command,conn);
                cmd.ExecuteNonQuery();
                return 1;
            }
            catch { return -1; }
            finally { conn.Close(); }
        }

        public int removeCustomerByCID(String CID)
        {
            try
            {
                conn.Open();
                SqlCommand commandMonthlyPayment = new SqlCommand("Delete from MonthlyPayment where CID = '" + CID + "'", conn);
                SqlCommand commandPayment = new SqlCommand("Delete from Payment where CID = '" + CID + "'", conn);
                SqlCommand commandReservation = new SqlCommand("Delete from Reservation where CID = '" + CID + "'", conn);
                SqlCommand commandCustomer = new SqlCommand("Delete from Customer where CID = '" + CID + "'", conn);
                
                commandMonthlyPayment.ExecuteNonQuery();
                commandPayment.ExecuteNonQuery();
                commandReservation.ExecuteNonQuery();
                commandCustomer.ExecuteNonQuery();
                
            }
            catch { return -1; }
            finally { conn.Close(); }
            return 1;
        }

        public int validateCustomerByCIDorPno(String data)
        {
            String CID = null;
            int number = 0;
            try
            {
                number = Convert.ToInt32(data);
            }
            catch { number = 0; }
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand("Select CID from Customer where CID = '" + data + "' or PNo = '" + number + "'", conn);
            CID = Convert.ToString(sqlCommand.ExecuteScalar());
            conn.Close();
            if (String.IsNullOrEmpty(CID))
            {
                return -2;
            }
            return 2;
        }

        public String getCIDByCIDorPno(String data)
        {
            String CID = null;
            int number = 0;
            try
            {
                number = Convert.ToInt32(data);
            }
            catch { number = 0; }
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand("Select CID from Customer where CID = '" + data + "' or PNo = '" + number + "'", conn);
            CID = Convert.ToString(sqlCommand.ExecuteScalar());
            conn.Close();
            return CID;
            
        }

        public String getCNamebyCID(String CID)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select FName from Customer where CID = '"+CID+"'",conn);
                String name = Convert.ToString(cmd.ExecuteScalar());
                return name;
            }
            catch { return null; }
            finally { conn.Close(); }
        }

        public DataTable getAll()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * from Customer", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch { return null; }
            finally { conn.Close(); }
        }
    }
}
