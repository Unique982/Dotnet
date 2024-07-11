using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Example3
    {
        // Q.N 3: Write a C# program to find largest number among three input number uisng nested if statement.
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter any number");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int largest;
            if (num1 < num2)
            {
                if (num2 < num3)
                {
                    largest = num3;
                }

            }
            else
            {
                if (num1 < num3)
                {
                    largest = num3;
                }
                else
                {
                    largest = num1;
                }
                Console.WriteLine("Largest Number = " + largest);

                Console.ReadLine();
            }



        }
    }
}