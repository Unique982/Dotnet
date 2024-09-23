using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_7
{
    internal class Example2
    {
        public delegate double simple(double p, double t, double r);
        public delegate double compund(double p1, double t1, double r1);
        static void Main(string[] args)
        {
            simple s = delegate (double p, double t, double r)
            {
                return (p * t * r) / 100;
            };
            compund c = (p1, t1, r1) =>
            {
                return p1 * (Math.Pow(1 + (r1 / 100), t1) - 1);
            };
            Console.WriteLine("Simple interest is: " + s(10000, 2, 5));
            Console.WriteLine("Compound interest is: " + c(2000, 2,14));
            Console.ReadLine();
        }
    }
}
 
