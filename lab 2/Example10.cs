using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Example10
    {
        // Q.N 10: Write a C# program to compute cube of first number n natural number uisng goto statement.
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter any number");
            int num = int.Parse(Console.ReadLine());
            int num1 = 1;

        label:
            if (num1 > num)
                goto end;
                int sum = num1 * num1*num1;
                Console.WriteLine("Cube of " + num1 + " " +"is = " + sum);
                num1++;
                goto label;
                end:
                Console.WriteLine("Completed computing cubes.");
                Console.ReadKey();
            
        }
    }
}
