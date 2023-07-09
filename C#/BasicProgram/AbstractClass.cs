using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal abstract class AbstractClass
    {
        public void show()
        {
            Console.WriteLine("this is a non abstract method in abstract class");
        }
        public abstract void display();
    }
}
