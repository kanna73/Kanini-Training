using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Assignment
{
    internal class Employee
    {
        private string emp_name;
        private int emp_id;
        private string company_name;

        public Employee(string company_name,string emp_name,int emp_id) 
        {
            this.Company_name = company_name;
            this.Emp_name = emp_name;
            this.Emp_id = emp_id;
        }

        public string Emp_name { get => emp_name; set => emp_name = value; }
        public int Emp_id { get => emp_id; set => emp_id = value; }
        public string Company_name { get => company_name; set => company_name = value; }
       
    }
}
