using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab_4
{
    internal class Cricle
    {
        public class Circle
        {
            private float radius;
            public Circle(float radius)
            {
                this.radius = radius;
            }
            public float FindArea()
            {
                return (float)Math.PI * radius * radius;
            }
            public float FindCricumference()
            {
                return (float)(2 * Math.PI * radius * radius);
            }

            public class MyCircle
            {

            }
        }
        public static void Main(string[] args)
        {

            Circle circle = new Circle(8.0f);
            Console.WriteLine("Area:" + circle.FindArea());
            Console.WriteLine("Cricumference:" + circle.FindCricumference());
            Console.ReadKey();

        }
    }
}



