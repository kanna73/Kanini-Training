using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class EnumDemo
    {
        enum Colors {red,blue,green };

        public void display()
        {
            Console.WriteLine(Colors.red);
        }
    }
}
