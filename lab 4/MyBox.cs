using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    internal class MyBox
    {
        public class Box
        {


            private int length, width, height;

            public Box()
            {

            }

            public Box(int l, int w, int h)
            {
                length = l;
                width = w;
                height = h;
            }

            public float findVolume()
            {
                return (length * width * height);
            }

            public float findSArea()
            {
                return (2 * ((length * width) + (width * height) + (length * height)));
            }

        }
        static void Main(string[] args)
        {
            float a, c;
            Box c1 = new Box();
            Box c2 = new Box(18, 12, 14);
            a = c1.findSArea();
            c = c1.findVolume();
            Console.WriteLine("Using Default Constructor, Surface area=" + a + "Volume=" + c);
            a = c2.findSArea();
            c = c2.findVolume();
            Console.WriteLine("Using Parameterized Constructor, Surface area=" + a + "Volume=" + c);
            Console.ReadLine();
        }
    }
}