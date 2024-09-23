using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_7
{
    internal class SingleCast
    {
        public delegate int mathoperation(int a, int b);

        class Program
        {
            public static int add(int a, int b)
            {
                int result = a + b;
                Console.WriteLine("Addition: " + result);
                return result;
            }
            public static int subtract(int a, int b)
            {
                int result = a - b;
                Console.WriteLine("Subtraction: " + result);
                return result;
            }
            public static int multiply(int a, int b)
            {
                int result = a * b;
                Console.WriteLine("Multiplication: " + result);
                return result;
            }
            static void Main(string[] args)
            {
                mathoperation singleOperation = new mathoperation(add);
                Console.WriteLine("Singlecast Delegate:");
                singleOperation(16, 15);

                Console.WriteLine();

                mathoperation multiOperation = null;
                multiOperation += add;
                multiOperation += subtract;
                multiOperation += multiply;

                Console.WriteLine("Multicast Delegate:");
                multiOperation(5, 19);

                Console.ReadLine();
            }
        }
    }
}

