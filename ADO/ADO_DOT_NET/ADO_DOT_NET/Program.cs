// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Security.Cryptography.X509Certificates;

namespace ADO_DOT_NET
{
    internal class Program
    {

        public static void Main(string[] args)
        {
            //Restaurant restaurant = new Restaurant();
            // restaurant.OpenConn();
            /*            int cust_id;
                        string cus_name;
                        DateTime date;
                        int points;
                        int invoice_no;
                        int product_id;
                        DateTime date_of_purchase;
                        int total_amount;

                        string method;
                        Console.WriteLine("choose either member or sales");
                        method= Console.ReadLine();

                        switch (method) 
                        {
                            case("member" or " MEMBER"):
                                Console.WriteLine("enter cust id,cys name,date");
                                cust_id=Convert.ToInt32(Console.ReadLine());
                                cus_name=Console.ReadLine();
                                //date=DateTime.Parse(Console.ReadLine());
                                Restaurant  restaurant =new Restaurant(cust_id, cus_name);
                                restaurant.OpenConn();
                                restaurant.Add_member_data();
                                break;

                        }*/

            db d = new db();
            d.openconn();
            d.readtable();

        }

    }
}

