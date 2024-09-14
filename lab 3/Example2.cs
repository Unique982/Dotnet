using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Example2
    {
        public static void Main(string[] args)
        {
            int[] arr = { 19, 9, 3, 100, 900, 1, 50, 55, 90, 10 };

            int max = arr[0];
            int min = arr[1];

            foreach (int i in arr)
            {
                if (i > max)
                {
                    max = i;
                }
                if (i < min)
                {
                    min = i;
                }
            }

            Console.WriteLine("Max number : " + max);
            Console.WriteLine("Min number : " + min);
            Console.ReadKey();

        }

    }
}
    