using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class ArrayProgram
    {
       
        static int len;
        int[] arr = new int[len];





        
        
        public int Len { get => len; set => len = value; }

        public void enter()
          {
            Console.WriteLine(Len);
            for (int i=0; i<len; i++) 
            {
                Console.WriteLine("Enter the value");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter the value");

        }
        public void reverse() 
        {
            for(int j=len-1;j>=0;j--)
            {
                Console.WriteLine(arr[j]);
            }
        }
    }
}
