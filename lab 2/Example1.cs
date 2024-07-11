using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Example1
    {
        // Q.N 1 Write C# program to test input number is odd or Even.
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Any Number");
            int num = int.Parse(Console.ReadLine());
            if(num %2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
            Console.ReadKey();
        }
    }
}
