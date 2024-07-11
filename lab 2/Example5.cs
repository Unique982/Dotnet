using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Example5
    {
        //Q.N5: Write a C# program to check input number is prime or not
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter the Number:");
            int num = int.Parse(Console.ReadLine());
            int i, count = 0;
            for (i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }

            if (count == 2)
            {
                Console.WriteLine("The Given Number is Prime.");
            }
            else
            {
                Console.WriteLine("The Given Number is not a Prime.");
            }
            Console.ReadKey();
        }
    }
}


