using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Example2
    {
        // Q.N 2 Write a C# program to test whether given number is positive or negative and Zero.
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Any Number");
            int num = int.Parse(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine("Positive");
            }
            else if (num < 0)
            {
                Console.WriteLine("Negative");

            }
            else
            {
                Console.WriteLine("Zero");
            }
            Console.ReadKey();
        }
    }
}