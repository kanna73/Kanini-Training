using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class add
    {
        static int bon;
        public add() 
        {
            bon = 6;
        }
        internal void cal(int n3,int n4, out int a, out int b)
        {
           
            a=n3+bon;
            b=n4+bon;
            
            
        }
    }
}
