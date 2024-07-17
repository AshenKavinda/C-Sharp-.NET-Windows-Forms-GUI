using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class DataBaseManeger
    {
        static SqlConnection conn;

        public DataBaseManeger()
        {
            //conn = new SqlConnection("Data Source=sql.bsite.net\\MSSQL2016;User ID=guicwnibm_;Password=guicw ");
            //conn = new SqlConnection("Data Source=ASHEN;Initial Catalog=Library;Integrated Security=True ");
            conn = new SqlConnection("Data Source=PC-1;Initial Catalog=LibraryDB;Integrated Security=True ");
        }
       
        public SqlConnection getSqlConnection()
        {
            return conn;
        }
    }
}
