using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_8
{
    internal class Example1
    {
        static void Main(string[] args)
        {
            int[] arr2 = new int[] { 1,5,15, 17, 19, 21, 25, 30, 33, 50,57};
            IEnumerable<int> result = from num in arr2 where num % 2 != 0 && num % 3 == 0 select num;
            Console.Write("Odd number which are divisible by 3 are:");
            foreach (int num in result)
                Console.WriteLine(num);
            Console.ReadKey();

        }
    }
}
