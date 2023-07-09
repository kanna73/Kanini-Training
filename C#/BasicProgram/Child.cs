using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class Child:Parent
    {
       internal  string name1 = "this is child class";
        public Child()
        {
            Console.WriteLine("this is child constructor");
        }
        public void show()
        {
            Console.WriteLine("this is chlid method");
        }
    }
}
