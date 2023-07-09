// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Bike;

internal class Program
{

    public static void Main(string[] args)
    {
        string current_user;
        string filter_choice = "no";
        Console.WriteLine("if you are a user enter user or if you are a admin then enter admin");
        current_user= Console.ReadLine().ToLower();

        switch(current_user)
        {
            case ("user"):
                Console.WriteLine("if you want to login then enter login or if you want signup then enter signup");
                string user_mode=Console.ReadLine().ToLower();
                if(user_mode== "signup") 
                {
                    string username, password, phone_no;
                    Console.WriteLine("Enter the username:");
                    username = Console.ReadLine();
                    Console.WriteLine("Enter the password");
                    password = Console.ReadLine();
                    Console.WriteLine("Enter the phone_no");
                    phone_no = Console.ReadLine();
                    Login signup = new Login(username, password, phone_no);
                    signup.openconn();
                    signup.insert();
                    user_mode = "login";
                }
                if(user_mode=="login")
                {
                    string username, password;
                    Console.WriteLine("enter the username and password to access our application");
                    username = Console.ReadLine();
                    password = Console.ReadLine();
                    Login login = new Login(username, password);
                    login.openconn();
                    string user_status=login.check_user();
                    if(user_status=="valied")
                    {
                        login.openconn();
                        filter_choice=login.search();
                        while(filter_choice=="yes")
                        {
                            login.openconn();
                            int decider=login.filter();
                            if(decider>1)
                            {
                                Console.WriteLine("do you want to filter this further");
                                filter_choice = Console.ReadLine().ToLower();
                            }
                            else
                            {
                                filter_choice = "no";
                            }
                            
                        }
                    }
                    else
                    {
                        Console.WriteLine("the username and password is incorrect");
                    }

                }
                break;

            case ("admin"):
                string admin_name, admin_password;
                Console.WriteLine("Enter the admin user name");
                admin_name= Console.ReadLine();
                Console.WriteLine("Enter the password");
                admin_password= Console.ReadLine();   
                Admin admin = new Admin(admin_name, admin_password);
                admin.openconn();
                string admin_status= admin.Check_Admin();
                if (admin_status == "valied")
                {
                    string retry = "no";
                    do
                    {
                        Console.WriteLine("for insert operation enter i or for update operation enter u or for delete operation enter d");
                        string operation_mode= Console.ReadLine().ToLower();

                        if(operation_mode =="i")
                        {
                            string bike_name, category, brands, budget, displacement, power, mileage, bike_type;
                            Console.WriteLine("enter the bike name");
                            bike_name = Console.ReadLine();
                            Console.WriteLine("enter the bike category");
                            category = Console.ReadLine();
                            Console.WriteLine("enter the bike brand");
                            brands = Console.ReadLine();
                            Console.WriteLine("enter the bike budget");
                            budget = Console.ReadLine();
                            Console.WriteLine("enter the bike displacement");
                            displacement = Console.ReadLine();
                            Console.WriteLine("enter the bike power");
                            power = Console.ReadLine();
                            Console.WriteLine("enter the bike mileage");
                            mileage = Console.ReadLine();
                            Console.WriteLine("enter the bike type");
                            bike_type = Console.ReadLine();
                            Admin insertoperation = new Admin(bike_name, category, brands, budget, displacement, power, mileage, bike_type);
                            insertoperation.openconn();
                            insertoperation.insert();
                            Console.WriteLine("if you want to continue then enter yes else enter no");
                            retry = Console.ReadLine();
                        }
                        else if(operation_mode=="u")
                        {
                            Console.WriteLine("enter which row needs to be updated");
                            string row= Console.ReadLine();
                            List<string> edit_column= new List<string>();
                            List<string> edit_column_values = new List<string>();

                            Console.WriteLine("enter how many columns needs to be updated");
                            int n=Convert.ToInt32(Console.ReadLine());
                            for(int i=0;i<n;i++)
                            {
                                Console.WriteLine("enter the column name");
                                edit_column.Add(Console.ReadLine());
                            }
                            for (int i = 0; i < n; i++)
                            {
                                Console.WriteLine("enter the value that needs to be updated");
                                edit_column_values.Add(Console.ReadLine());
                            }
                            Admin updateoperation = new Admin();
                            updateoperation.openconn();
                            updateoperation.update(edit_column, edit_column_values, n,row);
                            Console.WriteLine("if you want to continue then enter yes else enter no");
                            retry = Console.ReadLine();
                        }
                        else if(operation_mode=="d")
                        {
                            Console.WriteLine("Enter the bike name which is to be deleted");
                            string bike_name= Console.ReadLine().ToLower();
                            Admin deleteoperation = new Admin();
                            deleteoperation.openconn();
                            deleteoperation.delete(bike_name);
                            Console.WriteLine("if you want to continue then enter yes else enter no");
                            retry = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("enter the correct value");
                            Console.WriteLine("if you want to continue then enter yes else enter no");
                            retry = Console.ReadLine();
                        }


                    } while (retry != "no");
                    

                }
                break;
        }


        
    }
}