using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Library
{
    internal class Settings
    {
        SqlConnection conn;
        DataBaseManeger DataBaseManeger;
        public Settings()
        {
            DataBaseManeger = new DataBaseManeger();
            conn = DataBaseManeger.getSqlConnection();
        }

        public int updateOverDueFee(String price)
        {
            try
            {
                int fee = Convert.ToInt32(price);
                conn.Open();
                SqlCommand cmd = new SqlCommand("update setting set value = '" + fee + "' where name = 'overdue'", conn);
                cmd.ExecuteNonQuery();
                return 1;
            }
            catch { return -1; }
            finally { conn.Close(); }
        }

        public int updateRegisterFee(String price)
        {
            try
            {
                int fee = Convert.ToInt32(price);
                conn.Open();
                SqlCommand cmd = new SqlCommand("update setting set value = '" + fee + "' where name = 'register'", conn);
                cmd.ExecuteNonQuery();
                return 1;
            }
            catch { return -1; }
            finally { conn.Close(); }


        }

        public int updateMonthlyFee(String price)
        {
            try
            {
                int fee = Convert.ToInt32(price);
                conn.Open();
                SqlCommand cmd = new SqlCommand("update setting set value = '" + fee + "' where name = 'Monthlyfee'", conn);
                cmd.ExecuteNonQuery();
                return 1;
            }
            catch
            {
                return -1;
            }
            finally { conn.Close(); }
        }

        public int UpdateOverDueLimit(String limit)
        {
            try
            {
                int fee = Convert.ToInt32(limit);
                conn.Open();
                SqlCommand cmd = new SqlCommand("update setting set value = '" + fee + "' where name = 'overDueDayLimit'", conn);
                cmd.ExecuteNonQueryAsync();
                return 1;
            }
            catch { return -1; }
            finally { conn.Close(); }
        }

        public int UpdateOverDueBookLimit(String limit)
        {
            try
            {
                int value = Convert.ToInt32(limit);
                conn.Open();
                SqlCommand cmd = new SqlCommand("update setting set value = '" + value + "' where name = 'overDueBookLimit'", conn);
                cmd.ExecuteNonQueryAsync();
                return 1;
            }
            catch { return -1; }
            finally { conn.Close(); }
        }

        public int UpdateMinimumBookLimit(String limit)
        {
            try
            {
                int value = Convert.ToInt32(limit);
                conn.Open();
                SqlCommand cmd = new SqlCommand("update setting set value = '" + value + "' where name = 'minimumBookLimit'", conn);
                cmd.ExecuteNonQueryAsync();
                return 1;
            }
            catch { return -1; }
            finally { conn.Close(); }
        }

        public int getRegisterFee()
        {
            int registerFee = 0;
            try
            {
                conn.Open();
                SqlCommand register = new SqlCommand("select value from setting where name = 'register'", conn);
                registerFee = Convert.ToInt32(register.ExecuteScalar());
                return registerFee;
            }
            catch { return -1; }
            finally { conn.Close(); }

            
        }


        public int getOverDueFee()
        {
            int overdue = 0;
            try
            {
                conn.Open();
                SqlCommand cmdoverdue = new SqlCommand("select value from setting where name = 'overdue'", conn);
                overdue = Convert.ToInt32(cmdoverdue.ExecuteScalar());
                return overdue;
            }
            catch { return -1; }
            finally { conn.Close(); }

            
        }

        public int getMonthlyFee()
        {
            int MonthlyFee = 0;
            try
            {
                conn.Open();
                SqlCommand cmdoverdue = new SqlCommand("select value from setting where name = 'Monthlyfee'", conn);
                MonthlyFee = Convert.ToInt32(cmdoverdue.ExecuteScalar());
                return MonthlyFee;
            }
            catch { return -1; }
            finally { conn.Close(); }

            
        }

        public int getOverDueLimit()
        {
            int limit = 0;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select value from setting where name = 'overDueDayLimit'", conn);
                limit = Convert.ToInt32(cmd.ExecuteScalar());
                return limit;
            }
            catch { return -1; }
            finally { conn.Close(); }

            
        }

        public int getOverDueBookLimit()
        {
            int limit = 0;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select value from setting where name = 'overDueBookLimit'", conn);
                limit = Convert.ToInt32(cmd.ExecuteScalar());
                return limit;
            }
            catch { return -1; }
            finally { conn.Close(); }


        }

        public int getMinimumBookLimit()
        {
            int limit = 0;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select value from setting where name = 'minimumBookLimit'", conn);
                limit = Convert.ToInt32(cmd.ExecuteScalar());
                return limit;
            }
            catch { return -1; }
            finally { conn.Close(); }


        }


    }
}
