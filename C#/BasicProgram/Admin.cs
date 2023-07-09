using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class Admin:College
    {
        int eid;
        string name;
        double salary;

        public Admin(string collegename, string address, int pincode,int eid, string name, double salary)
        :base(collegename,address,pincode)
        {
            this.Eid = eid;
            this.Name = name;
            this.Salary = salary;
        }

        public int Eid { get => eid; set => eid = value; }
        public string Name { get => name; set => name = value; }
        public double Salary { get => salary; set => salary = value; }

        public double calculatesalary()
        {
            double da = 0.4;
            double hra = 0.2;
            double allowances = (salary * da) + (salary * hra);
            double pf = 0.25;
            double deduction = salary * pf;
            double netsal = salary + allowances - deduction;
            return netsal;
        }
    }
}
