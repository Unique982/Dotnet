using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Example6
    {
        // Q.N6: Write a C# program to check whether given number is Armstrong or not
        public static void Main(string[] args)
        {
            int num, rem, temp, sum = 0;
            Console.Write("Enter the Number: ");
            num = int.Parse(Console.ReadLine());

            temp = num;
            while (num != 0)
            {
                rem = num % 10;
                sum = sum + (rem * rem * rem);
                num = num / 10;
            }

            if (temp == sum)
                Console.WriteLine(" This is Armstrong Number.");
            else
                Console.WriteLine(" This is not a Armstrong Number.");

            Console.ReadKey();

        }
    }
    }
