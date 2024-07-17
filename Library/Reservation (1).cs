using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Reservation
    {
        private SqlConnection conn;
        private Payment payment;
        private Book book;
        private Settings settings;
        private double RIDNumaricValue ;
        private DataTable table;

        public Reservation() {
            DataBaseManeger dataBaseManeger = new DataBaseManeger();
            conn = dataBaseManeger.getSqlConnection();
            payment = new Payment();
            settings = new Settings();
            book = new Book();
            formatRID();
        }

        private void formatRID()
        {
            string Value = null;
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select top 1 RID from Reservation order by RID DESC", conn);
            object LRID = cmd.ExecuteScalar();
            conn.Close();

            if (LRID != null && LRID != DBNull.Value)
            {
                String temp = Convert.ToString(LRID);
                Value = temp.Substring(1);
            }
            else
            {
                Value = "0";
            }
            RIDNumaricValue = Convert.ToDouble(Value);

        }

        private int getDefferenceOfDates(DateTime lastDate)
        {
            DateTime toDate = DateTime.Now;
            TimeSpan timeSpan = lastDate - toDate;
            int differenceInDays = Math.Abs((int)timeSpan.TotalDays);

            return differenceInDays;

        }

        private DataTable checkOldReservationDataByCID(String CID)
        {      
            DataTable overDueData = new DataTable();

            overDueData.Columns.Add("RID", typeof(String));
            overDueData.Columns.Add("CID", typeof(String));
            overDueData.Columns.Add("BID", typeof(String));
            overDueData.Columns.Add("Book_Name", typeof(String));
            overDueData.Columns.Add("Date", typeof(String));
            overDueData.Columns.Add("over_Due_Days", typeof(String));

            try
            {
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand("Select * from Reservation where CID = '" + CID + "'", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                DataTable table = new DataTable();
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        DateTime resevedDate = Convert.ToDateTime(row[3]);
                        int differenceInDays = getDefferenceOfDates(resevedDate);

                        if (differenceInDays > 21)
                        {

                            SqlCommand bookName = new SqlCommand("Select Name from Book where BID = '" + row[2] + "'", conn);
                            object result = bookName.ExecuteScalar();
                            DataRow dataRow = overDueData.NewRow();
                            dataRow[0] = row[0];
                            dataRow[1] = row[1];
                            dataRow[2] = row[2];
                            dataRow[3] = result;
                            dataRow[4] = row[3];
                            dataRow[5] = differenceInDays;

                            overDueData.Rows.Add(dataRow);
                        }


                    }
                }
                
                
            }
            catch
            {
                return overDueData;
            }
            finally { conn.Close(); }
            return overDueData;
        }

        public int[] checkEligibilityOfCustomerByCIDandBID(String CID,String BID)
        {
            //arr - (book avilability,monthly payament,Old reservations)
            int[] eligibility = new int[3];

            eligibility[0] = book.checkBookAvilabilityByBID(BID); //Book avilability OK(1)
            eligibility[1] = payment.checkMonthlyPaymentByCID(CID); //this month payment OK(1)
            DataTable table = checkOldReservationDataByCID(CID);
            eligibility[2] = 1; //overDue Book OK
            if (table.Rows.Count > 2) //overDue Book Limit
            {
                eligibility[2] = -1;
            }
            
            return eligibility;

        }

        public int addReservation(String CID,String BID)
        {
            RIDNumaricValue++;
            String RID = "R" + RIDNumaricValue.ToString("000000");

            try
            {
                int[] arr = checkEligibilityOfCustomerByCIDandBID(CID, BID);
                if (arr[0] == 1 && arr[1] == 1 && arr[2] == 1)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("insert into Reservation(RID,CID,BID,Date,Status) values('" + RID + "','" + CID + "','" + BID + "',getdate(),'"+1+"')", conn);
                    cmd.ExecuteNonQuery();
                    book.decreaseByOne(BID);
                    return 1;
                }
            }
            finally { conn.Close(); }
            return -1; 
            
        }



        public int getOverDueFee(String RID)
        {
            int fee = 0;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select Date from Reservation where RID = '" + RID + "' ", conn);
                int overDueFee = Convert.ToInt32(settings.getOverDueFee());
                DateTime dateTime = Convert.ToDateTime(cmd.ExecuteScalar());
                int difDays = getDefferenceOfDates(dateTime);
                int limit = settings.getOverDueLimit();
                if (difDays > limit) 
                {
                    fee = (difDays - limit) * overDueFee;
                }
                

            }
            catch { return -1; }
            finally { conn.Close(); }

            return fee;
            
        }

        public DataTable getAll()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * from Reservation where Status = '"+1+"'", conn); 
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dt.Columns.Remove("Status");
                dt.Columns.Remove("PID");
                return dt;
            }
            catch { return null; }
            finally { conn.Close(); }
        }

        public DataTable getReservationTableByCID(String CID)
        {
            DataTable table = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select Re.RID,Re.CID,Bo.BID,Bo.Name,Re.Date from Reservation Re inner join Book Bo on Bo.BID = Re.BID where Re.CID = '"+CID+"' and Re.Status = '"+1+"' ", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);               
                adapter.Fill(table);
            }
            catch {  }
            finally { conn.Close(); }
            return table;
        }

        public int removeReservation(String RID)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("update Reservation set Status = '"+0+"' where RID = '"+RID+"'",conn);
                cmd.ExecuteNonQuery();
            }
            catch
            {  return -1; }
            finally { conn.Close(); }
            return 1;

            
        }

        public DataTable getAllReservationByCID(String CID)
        {
            DataTable Table = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select re.RID, re.BID, bo.name ,re.Date,pa.Amount,re.Status from Reservation re left join Book bo on bo.BID = re.BID left join Payment pa on pa.PID = re.PID where re.CID = '"+CID+"'", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(Table);
            }
            finally { conn.Close(); }
            return table;
        }
    }
}
