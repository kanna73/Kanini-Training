using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class InterestCal:BankDetails
    {
        double intpercent;
        public InterestCal(int intpercent, int accno, string accname, double balance, double interest):base( accno,accname, balance,interest)
        {
            this.Intpercent = intpercent;
        }

        public double Intpercent { get => intpercent; set => intpercent = value; }

        public override double CalculateInterest()
        {
            return Balance*1*(Intpercent/100);
        }
    }
}
