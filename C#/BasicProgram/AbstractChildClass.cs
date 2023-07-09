using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class AbstractChildClass:AbstractClass
    {
        public override void display()
        {
            Console.WriteLine("this is overriden method in the abstract child class");
        }
    }
}
