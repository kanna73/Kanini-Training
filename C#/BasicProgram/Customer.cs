using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal  class Customer
    {
        int customerid;
        string customername,accounttype;
        public Customer(int customerid,string customername,string accounttype) 
        {
            this.Customerid= customerid;
            this.Customername= customername;
            this.Accounttype= accounttype;
        }

        public int Customerid { get => customerid; set => customerid = value; }
        public string Customername { get => customername; set => customername = value; }
        public string Accounttype { get => accounttype; set => accounttype = value; }

        public virtual void display()
        {
            Console.WriteLine("customer id " + this.Customerid +" "+this.Customername);
        }
    }
}
