using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6
{
    public class Shape
    {
        public double d1, d2;
        public Shape(double d1, double d2)
        {
            this.d1 = d1;
            this.d2 = d2;
        }
        public virtual double Area()
        {
            Console.WriteLine("Undefined Shape");
            return 0.0;
        }
    }
    public class Triangle : Shape
    {
        public Triangle(double h, double b) : base(h, b)
        {

        }
        public override double Area()
        {
            return 0.5 * d1 * d2;
        }
    }
    internal class MethodOverridingEx
    {
        public static void Main(string[] args)
        {
            Triangle t1 = new Triangle(7.0,11.0);
            Console.WriteLine("Area of triangle= " + t1.Area());
            Console.ReadKey();
        }
    }
}
