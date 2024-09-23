using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6
{
    class Distance
    {
        public int feet, inch;
        public Distance() { }
        public Distance(int feet, int inch)
        {
            this.feet = feet;
            this.inch = inch;
        }
        public void display()
        {
            Console.WriteLine(feet + "ft " + inch + "inches");
        }
        public static bool operator ==(Distance d1, Distance d2)
        {
            bool status = false;
            int dt1 = d1.feet * 12 + d1.inch;
            int dt2 = d2.feet * 12 + d2.inch;

            if (dt1 == dt2)
            {
                status = true;
            }
            else
            {
                status = false;
            }
            return status;

        }
        public static bool operator !=(Distance d1, Distance d2)
        {
            bool status = false;
            int dt1 = d1.feet * 12 + d1.inch;
            int dt2 = d2.feet * 12 + d2.inch;

            if (dt1 != dt2)
            {
                status = true;
            }
            else
            {
                status = false;
            }
            return status;

        }
    }
    internal class RelationalOperator
    {
        public static void Main(string[] args)
        {
            Distance d1 = new Distance(115, 18);
            Distance d2 = new Distance(115, 18); d1.display(); d2.display();
            if (d1 == d2)
            {
                Console.WriteLine("Both distance are equal");
            }
            else
            {
                Console.WriteLine("Both distance are not equal");
            }
            Console.ReadKey();
        }
    }
}
