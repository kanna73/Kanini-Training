using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class GenericsUsage<T> where T : Exception
    {
        // private T number;
        private T exceptObj;
        public GenericsUsage(T exceptObj)
        {
            this.exceptObj = exceptObj;
        }

        public T disp()
        {
            return exceptObj;
        }

        /*        public GenericsUsage(T number)
                {
                    this.Number = number;
                }

                public T Number { get => number; set => number = value; }

                    private T[] arr;
                    public GenericsUsage(int size)
                    {
                        arr = new T[size];
                    }
                    public void setval(int index, T value)
                    {
                        arr[index] = value;
                    }
                    public T getarr(int index)
                    {
                        return arr[index];
                    }
                    public void print()
                    {
                       Console.WriteLine("hi");
                    }
                }*/
    }
}
