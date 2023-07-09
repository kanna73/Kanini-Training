using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal  class Loan:Customer
    {
        int loanAccno, loanAmmount, loanTen;

        public Loan(int loanAccno, int loanAmmount, int loanTen, int customerid, string customername,string accounttype)
            :base(customerid,customername,accounttype)
        {
            this.LoanAccno = loanAccno;
            this.LoanAmmount = loanAmmount;
            this.LoanTen = loanTen;
        }

        public int LoanAccno { get => loanAccno; set => loanAccno = value; }
        public int LoanAmmount { get => loanAmmount; set => loanAmmount = value; }
        public int LoanTen { get => loanTen; set => loanTen = value; }

        public override void display()
        {
            base.display();
            Console.WriteLine("Loan account "+this.LoanAccno+"loan account "+this.LoanAmmount+"loanten "+this.LoanTen);
        }
    }
}
