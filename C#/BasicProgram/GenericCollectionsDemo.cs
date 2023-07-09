using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class GenericCollectionsDemo
    {
        public void listelements()
        {
             List<int> numbers= new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            foreach(int number in numbers)
            {
                Console.WriteLine(number);

            }
            List<int> numbers2= new List<int>();    
          // numbers2= numbers.Append(4);
        }
    }
}
