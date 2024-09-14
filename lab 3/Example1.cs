using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Example1
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 6, 7, 8, 5, 20, 11, 19 };

            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0) { sum += arr[i]; Console.WriteLine(arr[i]); }

            }

            Console.WriteLine("Sum of odds : " + sum);
            Console.ReadKey();
        }
      
    }
}
