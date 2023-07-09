using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_DOT_NET
{
    internal class db:DBConnection
    {
       

        public void createtable()
        {

            SqlCommand cmd = new SqlCommand("create table Members(Cus_id int Primary Key, Cus_name nvarchar(25)Not null, Date_of_Joining date not null, Points int Default 0);", conn);
            SqlCommand cmd1 = new SqlCommand("create table Menu(Product_id int Primary Key, Product_name nvarchar(25) not null, Price int not null);", conn);
            SqlCommand cmd2 = new SqlCommand("create table Sales(Invoice_no int primary key, Cus_id int Foreign Key references Members(Cus_id),Product_id int foreign key references Menu(Product_id),Date_of_purchase date not null, TotalAmount int not null);", conn);

            if (conn != null)
            {
                cmd.ExecuteNonQuery();
                Console.WriteLine("Table Created");
            }

        }

        public void inserttable()
        {
            SqlCommand cmd = new SqlCommand("insert into Members Values(100,'Abi','2022/10/05',0),(101, 'Anu', '2022/05/11', 0),(102, 'Abinaya', '2023/01/01', 0),(103, 'Akshaya', '2023/02/06', 0),(104, 'Jothika', '2023/04/05', 0);", conn);
            SqlCommand cmd1 = new SqlCommand("insert into Menu values(10,'Chicken Briyani',110), (11, 'Mutton Briyani', 150), (12, 'French Fries', 50), (13, 'Noodles', 70), (40, 'Fried Rice', 80);", conn);
            SqlCommand cmd2 = new SqlCommand("insert into Sales Values(1000,100,10,'2022/10/10',110), (1001, 101, 10, '2022/10/12', 110), (1002, 103, 13, '2022/11/05', 70), (1003, 104, 10, '2022/11/11', 110), (1004, 102, 11, '2022/11/15', 150), (1005, 100, 40, '2023/01/01', 80);", conn);
            if (conn != null)
            {
                cmd.ExecuteNonQuery();
                Console.WriteLine("Rows Inserted");
            }
        }



        public void readtable()
        {
            String Retry ="no";
            Console.WriteLine("Enter Which one to Execute");
            Console.WriteLine("1. Display the total amount each customer spent at the restaurant?");
            Console.WriteLine("2. Display the number of days each customer has visited the restaurant?");
            Console.WriteLine("3. Display the most purchased item on the menu");
            Console.WriteLine("4. Display the total items and amount spent by each member?");
            Console.WriteLine("5. If each $1 spent equates to 10 points display the points each customer has earned.");

            do
            {

                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        base.openconn();
                        Ques1();
                        Console.WriteLine("enter yes to continue or no to exit") ;
                        Retry = Console.ReadLine();

                        break;

                    case 2:
                        base.openconn();
                        
                        Ques2();
                        Console.WriteLine("enter yes to continue or no to exit");
                        Retry = Console.ReadLine();

                        break;

                    case 3:
                        base.openconn();
                        Ques3();
                        Console.WriteLine("enter yes to continue or no to exit");
                        Retry = Console.ReadLine();

                        break;
                    case 4:
                        base.openconn();
                        Ques4();
                        Console.WriteLine("enter yes to continue or no to exit");
                        Retry = Console.ReadLine();

                        break;
                    case 5:
                        base.openconn();
                        Ques5();
                        Console.WriteLine("enter yes to continue or no to exit");
                        Retry = Console.ReadLine();

                        break;
                    default:
                        Console.WriteLine("Enter correct choice");
                        Console.WriteLine("enter yes to continue or no to exit");
                        Retry = Console.ReadLine();
                        break;

                }
                
            } while (Retry !="no");


        }

        public void Ques1()
        {
            SqlCommand cmd = new SqlCommand("select Cus_name, SUM(TotalAmount) as 'Total Amount Spend' from Members join Sales on Members.Cus_id=Sales.Cus_id group by Cus_name;", conn);
            if (conn != null)
            {
                SqlDataReader s = cmd.ExecuteReader();
                while (s.Read())
                {
                    Console.WriteLine(s[0] + " " + s[1]);
                }
            }
            else
            {
                Console.WriteLine("Table is empty");
            }

            conn.Close();
        }

        public void Ques2()
        {

            SqlCommand cmd1 = new SqlCommand("select Cus_name, count(distinct Invoice_no) as 'Days Visited' from Sales join Members on Members.Cus_id=Sales.Cus_id group by Cus_name;", conn);
            if (conn != null)
            {
                SqlDataReader s = cmd1.ExecuteReader();
                while (s.Read())
                {

                    Console.WriteLine(s[0] + " " + s[1]);
                }
            }
            conn.Close();
        }

        public void Ques3()
        {
            //conn.Open();

            SqlCommand cmd2 = new SqlCommand("select Top 1 Product_name, Sum(TotalAmount) as 'Top Sale' from Sales join Menu on Menu.Product_id=Sales.Product_id group by Product_name ;", conn);
            if (conn != null)
            {
                SqlDataReader s = cmd2.ExecuteReader();
                while (s.Read())
                {

                    Console.WriteLine(s[0] + " " + s[1]);
                }
            }
            conn.Close();

        }


        public void Ques4()
        {
            // conn.Open();
            SqlCommand cmd3 = new SqlCommand("select Cus_name, COUNT(Invoice_no) as 'Total Items', SUM(TotalAmount) as 'Total Amount' FROM Members JOIN Sales ON Members.Cus_id = Sales.Cus_id group by Cus_name;", conn);
            if (conn != null)
            {
                SqlDataReader s = cmd3.ExecuteReader();
                while (s.Read())
                {

                    Console.WriteLine(s[0] + " " + s[1]);
                }

            }
            conn.Close();
        }


        public void Ques5()
        {
            //conn.Open();
            SqlCommand cmd4 = new SqlCommand("select Cus_name, Sum(TotalAmount * 10) as 'Total Earned Points' from Sales join Members on Sales.Cus_id=Members.Cus_id group by Cus_name;", conn);
            if (conn != null)
            {
                SqlDataReader s = cmd4.ExecuteReader();

                while (s.Read())
                {

                    Console.WriteLine(s[0] + " " + s[1]);
                }
            }
            conn.Close();
        }



    }
}
