using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Example4
    {
        // Q.N:4: Write c# program to read any digit(0-9) and display in respective word using switch case statement.
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter any number");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 0:
                    Console.WriteLine("Zero");
                    break;
                    case 1:
                    Console.WriteLine("One");
                    break;
                    case 2:
                    Console.WriteLine("two");
                    break;
                    case 3:
                    Console.WriteLine("Three");
                    break;
                    case 4:
                    Console.WriteLine("four");
                    break;
                case 5:
                    Console.WriteLine("five");
                    break;
                    case 6:
                    Console.WriteLine("Six");
                    break;
                    case 7:
                    Console.WriteLine("Seven");
                    break;
                    case 8:
                    Console.WriteLine("Eight");
                    break;
                    case 9:
                    Console.WriteLine("Nine");
                    break;
                default:
                    Console.WriteLine("Enter valid number");
                    break;

            }
            Console.ReadKey();
        }
    }
}
