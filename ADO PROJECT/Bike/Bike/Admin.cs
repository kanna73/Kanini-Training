using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bike
{
    internal class Admin: DBConnection
    {
        string name, password;
        string admin_status="invalied";

        string bike_name, category, brands, budget, displacement, power, mileage, bike_type;

        public Admin()
        {

        }

        public Admin(string name,string password) 
        {
            this.name = name;
            this.password = password;
        }
        public Admin(string bike_name, string category, string brands, string budget, string displacement, string power, string mileage, string bike_type)
        {
            this.Bike_name= bike_name;
            this.category = category;
            this.brands = brands;
            this.budget = budget;
            this.budget= budget;
            this.displacement= displacement;
            this.power= power;
            this.mileage= mileage;
            this.bike_type = bike_type;
        }
        public string Name { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }
        public string Bike_name { get => bike_name; set => bike_name = value; }
        public string Category { get => category; set => category = value; }
        public string Brands { get => brands; set => brands = value; }
        public string Budget { get => budget; set => budget = value; }
        public string Displacement { get => displacement; set => displacement = value; }
        public string Power { get => power; set => power = value; }
        public string Mileage { get => mileage; set => mileage = value; }
        public string Bike_type { get => bike_type; set => bike_type = value; }

        public string Check_Admin()
        {
            SqlCommand cmd = new SqlCommand("select Name,password from Admin_Table", conn);
            if(conn != null) 
            {
                SqlDataReader s = cmd.ExecuteReader();
                while(s.Read()) 
                {
                    if (s[0].ToString() == Name && s[1].ToString() == Password)
                    {
                        Console.WriteLine("Welcome Admin {0}", s[0]);
                        admin_status = "valied";

                    }
                }
            }
            else
            {
                Console.WriteLine("Incorrect admin name and user");

            }

            conn.Close();
            return admin_status;
        }
        public void insert()
        {
            string query =string.Format( "insert into Bike_table values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",Bike_name,Category,Brands,Budget,Displacement,Power,Mileage,Bike_type);
            SqlCommand cmd = new SqlCommand(query, conn);
            if(conn !=null) 
            {
                int n = cmd.ExecuteNonQuery();
                Console.WriteLine("inserted {0}", n);
            }
            else
            {
                Console.WriteLine("connection error");
            }
            conn.Close();
        }
        public void update(List<string> edit_column, List<string> edit_column_values, int n,string row) 
        {
            for(int i=0;i<n;i++)
            {

                //string query1 = string.Format("update Bike_table set '{0}'"+"="+"'{1}' where Bike_Name='{2}'",edit_column[i],edit_column_values[i],row);
                string query = string.Format("update Bike_table set {0} = '{1}' where Bike_Name ='splendor'", edit_column[i],edit_column_values[i]);
                SqlCommand cmd = new SqlCommand(query, conn);
                if (conn != null)
                {
                    int m = cmd.ExecuteNonQuery();
                    Console.WriteLine("inserted {0}", m);
                }
                else
                {
                    Console.WriteLine("connection error");
                }
            }
            conn.Close();
        }
        public void delete(string bike_name) 
        {
            string delete_query = string.Format("delete from Bike_table where Bike_Name = '{0}'", bike_name);
            SqlCommand cmd = new SqlCommand(@delete_query, conn);
            if(conn != null ) 
            {
                int n = cmd.ExecuteNonQuery();
                Console.WriteLine("deleted {0}", n);
            }
            else
            {
                Console.WriteLine("connection error");
            }
        }
    }
}
