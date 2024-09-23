using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6
{
    public class Adder
    {
        public int add(int x, int y)
        {
            return x + y;
        }
        public int add(int x, int y, int z)
        {
            return x + y + z;
        }
        public double add(double x, double y)
        {
            return x + y;
        }

    }

    internal class MethodOverloadingEx
    {
        public static void Main(string[] args)
        {
            Adder adder = new Adder();
            Console.WriteLine("Sum of two integers: " + adder.add(22, 89));
            Console.WriteLine("Sum of three integers: " + adder.add(122, 30, 74));
            Console.WriteLine("Sum of two doubles: " + adder.add(8.8, 8.2));
            Console.ReadKey();
        }
    }
}
