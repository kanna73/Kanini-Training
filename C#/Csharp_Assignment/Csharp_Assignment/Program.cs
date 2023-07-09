using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Assignment
{
    internal class Program
    {
        public static void Main(string[] args) 
        {/*
            string Retry = "no";

            do
            {

                string company_name, emp_name;
                int emp_id;
                double salary;
                Console.WriteLine("company_name");
                company_name = Console.ReadLine();
                Console.WriteLine("emp_name");
                emp_name = Console.ReadLine();
                Console.WriteLine("emp_id");
                emp_id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("salary");
                salary = Convert.ToDouble(Console.ReadLine());





                Console.WriteLine("enter i for it department and c for cleaning department");
                char ch = Convert.ToChar(Console.ReadLine());

                switch (ch)
                {
                    case ('i' or 'I'):
                        ItDept itdept = new ItDept(salary, company_name, emp_name, emp_id);
                        Console.WriteLine("the bonus amount of {0} is {1}", itdept.Emp_name, itdept.newsalary());
                        Console.WriteLine("enter yes to continue and no to eixit");
                        Retry = Console.ReadLine();

                        break;
                    case ('c' or 'C'):
                        CleaningDept cleaningdept = new CleaningDept(salary, company_name, emp_name, emp_id);
                        Console.WriteLine("the bonus amount of {0} is {1} ", cleaningdept.Emp_name, cleaningdept.newsalary());
                        Console.WriteLine("enter yes to continue and no to eixit");
                        Retry = Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("enter the correct department name");
                        Console.WriteLine("enter yes to continue and no to eixit");
                        Retry = Console.ReadLine();
                        break;

                }

            } while (Retry != "no");
*/

            string name;
            int accno, withdraw, deposit;
            double balance;

            Console.WriteLine("enter the name , accno ,balance");
            name = Console.ReadLine();
            accno = Convert.ToInt32(Console.ReadLine());
            balance = Convert.ToDouble(Console.ReadLine());

            ATM atm = new ATM(name, accno, balance);
            atm.operation();
        }
    }
}
