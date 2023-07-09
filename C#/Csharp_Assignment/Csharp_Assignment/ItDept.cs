using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Assignment
{
    internal class ItDept:Employee
    {
        double salary;
        static double bonus=15;

        public ItDept(double salary, string company_name, string emp_name, int emp_id):base(company_name, emp_name, emp_id) 
        {
            this.Salary = salary;
           
        }

        public double Salary { get => salary; set => salary = value; }
       

        public double newsalary()
        {
            
            return Salary * (bonus / 100); ;
        }
    }
}
