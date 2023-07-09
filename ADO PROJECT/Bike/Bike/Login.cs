using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bike
{
    internal class Login: DBConnection
    {
        string username;
        string password;
        string phone_no;
        string user_status = "invalied";
        string filter_choice = "no";
        int decider = 0;
        List<string> column_precedence = new List<string>();
        List<string> column_value_precedence = new List<string>();
        List<string> column_name=new List<string>()
        {
            "Bike_Name",
            "Category",
            "Brands",
            "Budget",
            "Displacement",
            "Power",
            "Mileage",
            "Bike_Type"
        };

        public Login(string username, string password,string phone_no)
        {
            this.Username = username;
            this.Password = password;
            this.Phone_no = phone_no;
        }
        public Login(string username,string password)
        {
            this.Username = username;
            this.Password = password;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Phone_no { get => phone_no; set => phone_no = value; }

        public void insert()
        {
            string query = string.Format("insert into User_Table values('{0}','{1}','{2}')",username, password,phone_no);
            SqlCommand cmd = new SqlCommand(query,conn);
            if (conn != null)
            {
               // cmd.ExecuteNonQuery();
                int n = cmd.ExecuteNonQuery();
                Console.WriteLine("inserted {0} ", n);
            }
            conn.Close();
        }
        public string check_user()
        {
            //string query = string.Format("select username password from User_Table where(username='{0}' and password='{1}')");
            SqlCommand cmd = new SqlCommand("select username,password from User_Table", conn);

            if (conn != null)
            {
                SqlDataReader s = cmd.ExecuteReader();
                while (s.Read())
                {
                    if (s[0].ToString()== Username && s[1].ToString()==Password)
                    {
                        Console.WriteLine("Welcome to our Application {0}",s[0]);
                        user_status = "valied";


                    }
                }
            }
            else
            {
                Console.WriteLine("Table is empty");
            }

            conn.Close();
            return user_status;
        }
        public string search()
        {
           
            string query_column_name = string.Format("select name from sys.columns where object_id = OBJECT_ID('Bike_table')");
            SqlCommand cmd =  new SqlCommand(query_column_name, conn);
            if (conn != null) 
            {
                SqlDataReader s= cmd.ExecuteReader();
                while (s.Read()) 
                {
                    Console.WriteLine(s[0].ToString());
                }
                s.Close();
            }
            else
            {
                Console.WriteLine("Table is empty");
            }
            Console.WriteLine("enter the factors from the above to search your bike");
            column_precedence.Add(Console.ReadLine());
            string query_column_value = string.Format("select distinct {0} from Bike_table", column_precedence[0]);
            SqlCommand cmd1=new SqlCommand(query_column_value, conn);   
            if (conn != null) 
            {
                SqlDataReader s1= cmd1.ExecuteReader();
                while (s1.Read()) 
                {
                    Console.WriteLine(s1[0].ToString());
                }
                s1.Close();
            }
            else
            {
                Console.WriteLine("Table is empty");
            }
            Console.WriteLine("select the {0} from the above following", column_precedence[0]);
            column_value_precedence.Add(Console.ReadLine());
            string first_search_query = string.Format("select * from Bike_table where {0} ='{1}'", column_precedence[0], column_value_precedence[0]);
            SqlCommand cmd2 = new SqlCommand(first_search_query, conn); 
            if (conn != null) 
            {
                SqlDataReader s2= cmd2.ExecuteReader();
                while (s2.Read()) 
                {
                    for(int i=0; i<8;i++)
                    {
                        Console.Write(s2[i].ToString()+"  ");

                    }
                    decider++;
                    Console.WriteLine();
                }
                s2.Close();
            }
            else
            {
                Console.WriteLine("Table is empty");
            }
            conn.Close();
            if(decider> 1)
            {
                Console.WriteLine("do you want to filter this further");
                filter_choice = Console.ReadLine().ToLower();
            }
            
            return filter_choice;
            
        }
        public int filter()
        {
            int filter_decider = 0;
            var difference = column_name.Except(column_precedence);
            foreach(var diff in difference)
            {
                Console.WriteLine(diff.ToString());
            }
           /* for(int i=0;i<column_name.Count();i++)
            {
                for (int j= 0;j<column_precedence.Count();j++)
                {
                    if(column_name[i] != column_precedence[j])
                    {
                        Console.WriteLine("this is column name  "+ column_name[i]);
                        break;
                        //Console.WriteLine("this is column precedence  "+ele);
                    }
                }
            }*/
            Console.WriteLine("select a factor from the above on which you want futher filter");
            column_precedence.Add(Console.ReadLine());
            if (column_precedence.Count() == 2)
            {
                string query = string.Format("select distinct {0} from Bike_table where {1}='{2}'", column_precedence[1], column_precedence[0], column_value_precedence[0]);
                SqlCommand cmd = new SqlCommand(query, conn);
                if (conn != null)
                {
                    SqlDataReader s = cmd.ExecuteReader();
                    while (s.Read())
                    {
                        Console.Write(s[0].ToString() + "  ");
                    }
                    Console.WriteLine();
                    s.Close();
                }
                else
                {
                    Console.WriteLine("Table is empty");
                }
                Console.WriteLine("select a factor from the above on which you want futher filter");
                column_value_precedence.Add(Console.ReadLine());
                string filter_query = string.Format("select * from Bike_table where {0} = '{1}' and {2}='{3}'", column_precedence[0], column_value_precedence[0],
                   column_precedence[1], column_value_precedence[1]);
                SqlCommand cmd1 = new SqlCommand(filter_query, conn);
                if (conn != null)
                {
                    SqlDataReader s = cmd1.ExecuteReader();
                    while (s.Read())
                    {
                        for (int i = 0; i < 8; i++)
                        {
                            Console.Write(s[i].ToString() + "  ");

                        }
                        filter_decider++;
                        Console.WriteLine();
                    }
                }
                conn.Close();
                return filter_decider;
            }
            else if (column_precedence.Count() == 3)
            {
                string query = string.Format("select distinct {0} from Bike_table where {1}='{2}' and {3}='{4}'"
                    , column_precedence[2], column_precedence[0], column_value_precedence[0], column_precedence[1], column_value_precedence[1]);
                SqlCommand cmd = new SqlCommand(query, conn);
                if (conn != null)
                {
                    SqlDataReader s = cmd.ExecuteReader();
                    while (s.Read())
                    {
                        Console.Write(s[0].ToString() + "  ");
                    }
                    Console.WriteLine();
                    s.Close();
                }
                else
                {
                    Console.WriteLine("Table is empty");
                }
                Console.WriteLine("select a factor from the above on which you want futher filter");
                column_value_precedence.Add(Console.ReadLine());
                string filter_query = string.Format("select * from Bike_table where {0} = '{1}' and {2}='{3}'and {4}='{5}' ", column_precedence[0], column_value_precedence[0],
                   column_precedence[1], column_value_precedence[1], column_precedence[2], column_value_precedence[2]);
                SqlCommand cmd1 = new SqlCommand(filter_query, conn);
                if (conn != null)
                {
                    SqlDataReader s = cmd1.ExecuteReader();
                    while (s.Read())
                    {
                        for (int i = 0; i < 8; i++)
                        {
                            Console.Write(s[i].ToString() + "  ");

                        }
                        filter_decider++;
                        Console.WriteLine();
                    }
                }
                conn.Close();
                return filter_decider;
            }
            else if (column_precedence.Count() == 4)
            {
                string query = string.Format("select distinct {0} from Bike_table where {1}='{2}' and {3}='{4}' and {5}='{6}'"
                   , column_precedence[3], column_precedence[0], column_value_precedence[0], column_precedence[1], column_value_precedence[1],
                   column_precedence[2], column_value_precedence[2]);
                SqlCommand cmd = new SqlCommand(query, conn);
                if (conn != null)
                {
                    SqlDataReader s = cmd.ExecuteReader();
                    while (s.Read())
                    {
                        Console.Write(s[0].ToString() + "  ");
                    }
                    Console.WriteLine();
                    s.Close();
                }
                else
                {
                    Console.WriteLine("Table is empty");
                }
                Console.WriteLine("select a factor from the above on which you want futher filter");
                column_value_precedence.Add(Console.ReadLine());
                string filter_query = string.Format("select * from Bike_table where {0} = '{1}' and {2}='{3}'and {4}='{5}' and {6}='{7}' ", column_precedence[0], column_value_precedence[0],
                   column_precedence[1], column_value_precedence[1], column_precedence[2], column_value_precedence[2], column_precedence[3], column_value_precedence[3]);
                SqlCommand cmd1 = new SqlCommand(filter_query, conn);
                if (conn != null)
                {
                    SqlDataReader s = cmd1.ExecuteReader();
                    while (s.Read())
                    {
                        for (int i = 0; i < 8; i++)
                        {
                            Console.Write(s[i].ToString() + "  ");

                        }
                        filter_decider++;
                        Console.WriteLine();
                    }
                }
                conn.Close();
                return filter_decider;
            }
            else if (column_precedence.Count() == 5)
            {
                string query = string.Format("select distinct {0} from Bike_table where {1}='{2}' and {3}='{4}' and {5}='{6}' and {7}='{8}'"
                   , column_precedence[4], column_precedence[0], column_value_precedence[0], column_precedence[1], column_value_precedence[1],
                   column_precedence[2], column_value_precedence[2], column_precedence[3], column_value_precedence[3]);
                SqlCommand cmd = new SqlCommand(query, conn);
                if (conn != null)
                {
                    SqlDataReader s = cmd.ExecuteReader();
                    while (s.Read())
                    {
                        Console.Write(s[0].ToString() + "  ");
                    }
                    Console.WriteLine();
                    s.Close();
                }
                else
                {
                    Console.WriteLine("Table is empty");
                }
                Console.WriteLine("select a factor from the above on which you want futher filter");
                column_value_precedence.Add(Console.ReadLine());
                string filter_query = string.Format("select * from Bike_table where {0} = '{1}' and {2}='{3}'and {4}='{5}' and {6}='{7}' and {8}='{9}' "
                    , column_precedence[0], column_value_precedence[0], column_precedence[1], column_value_precedence[1],
                    column_precedence[2], column_value_precedence[2], column_precedence[3], column_value_precedence[3], column_precedence[4], column_value_precedence[4]);
                SqlCommand cmd1 = new SqlCommand(filter_query, conn);
                if (conn != null)
                {
                    SqlDataReader s = cmd1.ExecuteReader();
                    while (s.Read())
                    {
                        for (int i = 0; i < 8; i++)
                        {
                            Console.Write(s[i].ToString() + "  ");

                        }
                        filter_decider++;
                        Console.WriteLine();
                    }
                }
                conn.Close();
                return filter_decider;
            }
            else if (column_precedence.Count() == 6)
            {
                string query = string.Format("select distinct {0} from Bike_table where {1}='{2}' and {3}='{4}' and {5}='{6}' and {7}='{8}' and {9}='{10}'"
                   , column_precedence[5], column_precedence[0], column_value_precedence[0], column_precedence[1], column_value_precedence[1],
                   column_precedence[2], column_value_precedence[2], column_precedence[3], column_value_precedence[3], column_precedence[4], column_value_precedence[4]);
                SqlCommand cmd = new SqlCommand(query, conn);
                if (conn != null)
                {
                    SqlDataReader s = cmd.ExecuteReader();
                    while (s.Read())
                    {
                        Console.Write(s[0].ToString() + "  ");
                    }
                    Console.WriteLine();
                    s.Close();
                }
                else
                {
                    Console.WriteLine("Table is empty");
                }
                Console.WriteLine("select a factor from the above on which you want futher filter");
                column_value_precedence.Add(Console.ReadLine());
                string filter_query = string.Format("select * from Bike_table where {0} = '{1}' and {2}='{3}'and {4}='{5}' and {6}='{7}' and {8}='{9}' and {10}='{11}' "
                    , column_precedence[0], column_value_precedence[0], column_precedence[1], column_value_precedence[1],
                    column_precedence[2], column_value_precedence[2], column_precedence[3], column_value_precedence[3],
                    column_precedence[4], column_value_precedence[4], column_precedence[5], column_value_precedence[5]);
                SqlCommand cmd1 = new SqlCommand(filter_query, conn);
                if (conn != null)
                {
                    SqlDataReader s = cmd1.ExecuteReader();
                    while (s.Read())
                    {
                        for (int i = 0; i < 8; i++)
                        {
                            Console.Write(s[i].ToString() + "  ");

                        }
                        filter_decider++;
                        Console.WriteLine();
                    }
                }
                conn.Close();
                return filter_decider;
            }
            else if (column_precedence.Count() == 7)
            {
                string query = string.Format("select distinct {0} from Bike_table where {1}='{2}' and {3}='{4}' and {5}='{6}' and {7}='{8}' and {9}='{10}' and {11}='{12}'"
                   , column_precedence[6], column_precedence[0], column_value_precedence[0], column_precedence[1], column_value_precedence[1],
                   column_precedence[2], column_value_precedence[2], column_precedence[3], column_value_precedence[3],
                   column_precedence[4], column_value_precedence[4], column_precedence[5], column_value_precedence[5]);
                SqlCommand cmd = new SqlCommand(query, conn);
                if (conn != null)
                {
                    SqlDataReader s = cmd.ExecuteReader();
                    while (s.Read())
                    {
                        Console.Write(s[0].ToString() + "  ");
                    }
                    Console.WriteLine();
                    s.Close();
                }
                else
                {
                    Console.WriteLine("Table is empty");
                }
                Console.WriteLine("select a factor from the above on which you want futher filter");
                column_value_precedence.Add(Console.ReadLine());
                string filter_query = string.Format("select * from Bike_table where {0} = '{1}' and {2}='{3}'and {4}='{5}' and {6}='{7}' and {8}='{9}'" +
                    " and {10}='{11}' and {12}='{13}' "
                    , column_precedence[0], column_value_precedence[0], column_precedence[1], column_value_precedence[1],
                    column_precedence[2], column_value_precedence[2], column_precedence[3], column_value_precedence[3],
                    column_precedence[4], column_value_precedence[4], column_precedence[5], column_value_precedence[5],
                    column_precedence[6], column_value_precedence[6]);
                SqlCommand cmd1 = new SqlCommand(filter_query, conn);
                if (conn != null)
                {
                    SqlDataReader s = cmd1.ExecuteReader();
                    while (s.Read())
                    {
                        for (int i = 0; i < 8; i++)
                        {
                            Console.Write(s[i].ToString() + "  ");

                        }
                        filter_decider++;
                        Console.WriteLine();
                    }
                }
                conn.Close();
                return filter_decider;
            }
            else if (column_precedence.Count() == 8)
            {
                string query = string.Format("select distinct {0} from Bike_table where {1}='{2}' and {3}='{4}' and {5}='{6}' and {7}='{8}' and {9}='{10}' " +
                    "and {11}='{12}' and {13}='{14}'"
                   , column_precedence[7], column_precedence[0], column_value_precedence[0], column_precedence[1], column_value_precedence[1],
                   column_precedence[2], column_value_precedence[2], column_precedence[3], column_value_precedence[3],
                   column_precedence[4], column_value_precedence[4], column_precedence[5], column_value_precedence[5],
                   column_precedence[6], column_value_precedence[6]);
                SqlCommand cmd = new SqlCommand(query, conn);
                if (conn != null)
                {
                    SqlDataReader s = cmd.ExecuteReader();
                    while (s.Read())
                    {
                        Console.Write(s[0].ToString() + "  ");
                    }
                    Console.WriteLine();
                    s.Close();
                }
                else
                {
                    Console.WriteLine("Table is empty");
                }
                Console.WriteLine("select a factor from the above on which you want futher filter");
                column_value_precedence.Add(Console.ReadLine());
                string filter_query = string.Format("select * from Bike_table where {0} = '{1}' and {2}='{3}'and {4}='{5}' and {6}='{7}' and {8}='{9}'" +
                    " and {10}='{11}' and {12}='{13}' and {14}='{15}' "
                    , column_precedence[0], column_value_precedence[0], column_precedence[1], column_value_precedence[1],
                    column_precedence[2], column_value_precedence[2], column_precedence[3], column_value_precedence[3],
                    column_precedence[4], column_value_precedence[4], column_precedence[5], column_value_precedence[5],
                    column_precedence[6], column_value_precedence[6], column_precedence[7], column_value_precedence[7]);
                SqlCommand cmd1 = new SqlCommand(filter_query, conn);
                if (conn != null)
                {
                    SqlDataReader s = cmd1.ExecuteReader();
                    while (s.Read())
                    {
                        for (int i = 0; i < 8; i++)
                        {
                            Console.Write(s[i].ToString() + "  ");

                        }
                        filter_decider++;
                        Console.WriteLine();
                    }
                }
                conn.Close();
                return filter_decider;
            }
            else
            {
                return filter_decider;

            }
        }
    }
}
