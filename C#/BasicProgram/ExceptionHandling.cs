using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class ExceptionHandling
    {
        int n1, n2, ans;

        public ExceptionHandling(int n1,int n2,int ans)
        {
            this.n1 = n1;
            this.n2 = n2;
            this.ans = ans;
        }
        public int add() 
        {
            this.ans=this.n1+this.n2;
            return this.ans;
        }
        public int mul() 
        {
            this.ans= this.n1*this.n2;
            return this.ans;
        }
        public int div() 
        {
            try
            {
                this.ans = this.n1 /this.n2;
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Don't give 0 in the denominator");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Done");
            }
            return this.ans;
        }
        public void CheckVal(int val)
        {
            if (val <0)
            {
                throw new ArgumentException();
            }
            else if(val<18)
            {
                throw new ArithmeticException();
            }
            else
            {
                Console.WriteLine("ok");
            }
        }
    }
}
