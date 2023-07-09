/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class demo2
    {
    }
}*/

using System;
using System.Globalization;

class Demo2
{
    public void Big3num()
    {
        int num1, num2,num3;

        Console.WriteLine("enter 3 numbers");
        num1 = Convert.ToInt32(Console.ReadLine());
        num2 = Convert.ToInt32(Console.ReadLine());
        num3 = Convert.ToInt32(Console.ReadLine());

        if ((num1 == num2) && (num2 == num3))
            Console.WriteLine("All are equal");
        else if ((num1 > num2) && (num1 > num3))
            Console.WriteLine(num1 + " is big");
        else if ((num2 > num1) && (num2 > num3))
            Console.WriteLine(num2 + " is big");
        else
            Console.WriteLine(num3 + "is big");

    }
    public void Big2num()
    {
        int num1, num2;

        Console.WriteLine("enter 3 numbers");
        num1 = Convert.ToInt32(Console.ReadLine());
        num2 = Convert.ToInt32(Console.ReadLine());
      

        if (num1 == num2) 
            Console.WriteLine("All are equal");
        else if (num1 > num2) 
            Console.WriteLine(num1 + " is big");
        
        else
            Console.WriteLine(num2 + "is big");

    }
    public int loopfunction(int max)
    {
        int sum = 0, count = 0;
        
        do
        {
            sum = sum + count;
            count++;
        } while (count <=max);
       // Console.WriteLine("Total : " + sum);
       return(sum);
    }
    public void foreachfn(string s1)
    {
        //string s1 = "hello world !";
        foreach(char s in s1)
        {
            Console.WriteLine(s);
        }
    }
    public void arrdisp()
    {
        //int[] nums= new int[10];
        int[] nums = { 40, 30, 20, 10 };
        Array.Sort(nums);
        /*for(int i=0;i<nums.Length;i++) 
        {
            Console.WriteLine(nums[i]);
        }*/
        foreach(int n in nums)
        {
            Console.WriteLine(n);
        }
    }
}


