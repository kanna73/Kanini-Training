using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
       internal abstract class BankDetails
    {
        int accno;
        string accname;
        double balance;
        double interest;

        public BankDetails(int accno, string accname, double balance,double interest)
        {
            this.Accno = accno;    
            this.Accname = accname;
            this.Balance = balance;
            this.Interest = interest;

        }

        public int Accno { get => accno; set => accno = value; }
        public string Accname { get => accname; set => accname = value; }
        public double Balance { get => balance; set => balance = value; }
        public double Interest { get => interest; set => interest = value; }

         public abstract double CalculateInterest();
    }
}
