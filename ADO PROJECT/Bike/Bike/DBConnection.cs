using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Bike
{
    internal class DBConnection:ConfigurationSection
    {
        public  string connectionstring = ConfigurationManager.ConnectionStrings["join"].ConnectionString;

       


            public SqlConnection conn;


            public void openconn()
            {

           /* conn = new SqlConnection("data source=DESKTOP-4H18AAA\\SQLEXPRESS;" +
            "database=Bike;" +
            "integrated security=SSPI;");
*/
            conn = new SqlConnection(connectionstring);

            try
            {
                    conn.Open();
                    Console.WriteLine("Opened");
                }
                catch (SqlException ex)
                {

                    Console.WriteLine("Connection not established");
                }
            }



     }


}



