using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
     public class BankTranscation
    {
        int custid;
        long accno;
        string accname, status;
        decimal balance, creditamt, debitamt;

        public BankTranscation(int custid, long accno, string accname, decimal balance)
        {
            this.Custid = custid; 
            this.Accno = accno;  
            this.Accname= accname;
            this.Balance= balance;
            this.Status = "InActive";
            this.Creditamt = 0;
            this.Debitamt = 0;
        }

        public int Custid { get => custid; set => custid = value; }
        public long Accno { get => accno; set => accno = value; }
        public string Accname { get => accname; set => accname = value; }
        public string Status { get => status; set => status = value; }
        public decimal Balance { get => balance; set => balance = value; }
        public decimal Creditamt { get => creditamt; set => creditamt = value; }
        public decimal Debitamt { get => debitamt; set => debitamt = value; }

        internal decimal PerformTransaction()
        {
     
            Console.WriteLine("1. Credit");
            Console.WriteLine("2. debit");


            int ch =Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Console.WriteLine("enter Credit amt");
                    this.Creditamt =Convert.ToDecimal(Console.ReadLine());
                    this.Balance += this.Creditamt;
                    this.Status = "Active";
                    break;
                case 2:
                    Console.WriteLine("enter debit amt");
                    this.Debitamt = Convert.ToDecimal(Console.ReadLine());
                    this.Balance -=this.Debitamt;
                    this.Status = "Active";
                    break;
                default:
                    Console.WriteLine("enter 1 or 2 only");
                    break;


            }
            return this.Balance;

        }
      

    }
    
}
