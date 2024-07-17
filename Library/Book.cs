using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Book
    {
        private DataBaseManeger baseManeger;
        private Settings settings;
        private SqlConnection conn;
        public Book()
        { 
            baseManeger = new DataBaseManeger();
            settings = new Settings();
            conn = baseManeger.getSqlConnection();
        }

        public int addBook(String BID,String name,String price,String copy)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into Book values('" + BID + "','" + name + "','" + int.Parse(price) + "','" + copy + "','" + copy + "')", conn);
                cmd.ExecuteNonQuery();
            }
            catch { return -1; }  
            finally { conn.Close(); }
            return 1;
        }

        public int updateBook(String BID, String name, String price, String copy)
        {
            try
            {
                conn.Open();
                int activeCopyCount = 1000;
                int oldcopyCont = 0;
                SqlCommand getCopyOldCount = new SqlCommand("Select NoCopy from Book where BID = '" + BID + "'", conn);
                SqlCommand getActiveOldCount = new SqlCommand("Select NoActiveCopys from Book where BID = '" + BID + "'", conn);

                oldcopyCont = Convert.ToInt32(getCopyOldCount.ExecuteScalar());
                activeCopyCount = Convert.ToInt32(getActiveOldCount.ExecuteScalar());
                if (Convert.ToInt32(copy) >= oldcopyCont)
                {
                    int upValue = Convert.ToInt32(copy) - oldcopyCont;
                    activeCopyCount = activeCopyCount + upValue;
                }
                else
                {
                    int downValue = oldcopyCont - int.Parse(copy);
                    activeCopyCount = activeCopyCount - downValue;
                }

                if (activeCopyCount > 0)
                {
                    SqlCommand updateBookCmd = new SqlCommand("update Book set Name = '" + name + "',Price = '" + int.Parse(price) + "',NoCopy = '" + int.Parse(copy) + "',NoActiveCopys = '" + activeCopyCount + "' where BID = '" + BID + "'", conn);
                    updateBookCmd.ExecuteNonQuery();
                }
            }
            catch { return -1; }
            finally { conn.Close(); }

            return 1;

        }

        public DataTable searchByName(String name)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from Book where Name = '" + name + "'", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;
            }
            catch (Exception ex) { return null; }
            finally { conn.Close(); }

        }

        public int checkBookAvilabilityByBID(String BID)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select NoActiveCopys from Book where BID = '" + BID + "'", conn);
                object result = cmd.ExecuteScalar();
                int copyCount = Convert.ToInt32(result);
                int minimumBookLimit = settings.getMinimumBookLimit();
                if (copyCount > minimumBookLimit)
                {
                    return 1;
                }
            }
            finally { conn.Close(); }
            return -1;
        }

        public int decreaseByOne(String BID)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("update Book set NoActiveCopys = NoActiveCopys - 1 where BID = '" + BID + "' ", conn);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                return -1;
            }
            finally { conn.Close(); }
            return 1;
        }

        public int increaseByOne(String BID)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("update Book set NoActiveCopys = NoActiveCopys + 1 where BID = '" + BID + "' ", conn);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                return -1;
            }
            finally { conn.Close(); }
            return 1;
        }

        public DataTable getAllData()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * from Book", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch { return null; }
            finally { conn.Close();}
            
        }
    }
}
