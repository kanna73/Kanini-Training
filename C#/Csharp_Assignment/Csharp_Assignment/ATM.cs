using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Assignment
{
    internal class ATM
    {
        string name;
        int accno, withdraw,deposit;
        double balance;

        public ATM(string name, int accno, double balance)
        {
            this.Name = name;
            this.Accno = accno;
            this.Balance = balance;
        }

        public string Name { get => name; set => name = value; }
        public int Accno { get => accno; set => accno = value; }
        public int Withdraw { get => withdraw; set => withdraw = value; }
        public int Deposit { get => deposit; set => deposit = value; }
        public double Balance { get => balance; set => balance = value; }

        public void operation()
        {

            string retry = "no";
            do
            {

                Console.WriteLine("enter the withdraw amount");
                withdraw=Convert.ToInt32(Console.ReadLine());
                if (balance > withdraw)
                {
                    balance = balance - withdraw;
                    Console.WriteLine("the balance after withdrawal " + balance);
                }
                else
                {
                    Console.WriteLine("insufficent balance {0} to withdraw {1} ", balance, withdraw);
                }
                Console.WriteLine("enter the deposit amount");
                deposit = Convert.ToInt32(Console.ReadLine());
                balance = balance + deposit;
                Console.WriteLine("the balance after deposit " + balance);
                Console.WriteLine("enter yes to continue and no to eixit");
                retry = Console.ReadLine();
            } while (retry != "no");

            
        }
    }
}
