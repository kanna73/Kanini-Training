using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dbconnect
{
    internal class DB
    {
        SqlConnection conn;

        public void OpenConn()
        {
            conn = new SqlConnection("data source =DESKTOP-4H18AAA\\SQLEXPRESS;" +
                " database = student; integrated security = SSPI");
            conn.Open();
            Console.WriteLine("Opened");
        }
        public void CreateTable()
        {


            SqlCommand cmd = new SqlCommand("create table stud_details(rno int, name nvarchar(20));", conn);
            cmd.ExecuteNonQuery();
            Console.WriteLine("Table Created");

        }

        public void InsertTable()
        {
            SqlCommand cmd = new SqlCommand("insert into stud_details values(100,'AAA')", conn);
            cmd.ExecuteNonQuery();
            Console.WriteLine("Row Inserted");
        }
        public void CloseConn()
        {
            conn.Close();
        }
    }
}
