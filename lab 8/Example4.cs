using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_8
{
    internal class Example4
    {
        public static void Main()
        {
            int[] data = { 19, 31, 50, 13, 2 };
           
            int min = data.Min();
            int max = data.Max();
            int sum = data.Sum();
            double avg = data.Average();
            int count = data.Count();
     
            Console.WriteLine("Minimum=" + min);
            Console.WriteLine("Maximun=" + max);
            Console.WriteLine("sum=" + sum);
            Console.WriteLine("Average=" + avg);
            Console.WriteLine("Count=" + count);
            Console.ReadKey();
        }
    }
}
   