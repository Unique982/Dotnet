using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Example7
    {
        // Q.N 7: Write a C# program to check input number is prefect or not.
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter the Number:");
            int num = int.Parse(Console.ReadLine());
            int i = 1;
            long sum = 0;
            while (i <= num / 2)
            {
                if (num % i == 0)
                {

                    sum = sum + i;
                }

                i++;
            }

            if (sum == num)
            {
                Console.WriteLine("This is Perfect Number.");
            }
            else
            {
                Console.WriteLine("This is not a Perfect Number. ");
            }
            Console.ReadKey();
        }
    }
}