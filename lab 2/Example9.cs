using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Example9
    {
        // Q.N 9 : Write a C# program to find sum of integer until user input negative number. 
        public static void Main(String[] args)
        {
            
                int sum = 0;
            
                while (true)
                {
                    Console.Write("Enter the integer number: ");
                    int num = int.Parse(Console.ReadLine());

                    if (num < 0)
                        break;

                    sum = sum + num;
                }

                Console.WriteLine(" The Sum of all positive number are:" + sum);
                Console.ReadKey();
            


        }
    }
}
