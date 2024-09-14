using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    internal class Example3
    {
        public class MyDistance
        {
            private int feet;
            private int inches;

            public MyDistance()
            {

            }

            public MyDistance(int f, int i)
            {
                feet = f;

                while (i >= 12)
                {
                    feet++;
                    i = i - 12;
                }
                inches = i;
            }

            public void addDistance(MyDistance sd)
            {
                feet += sd.feet;
                inches += sd.inches;
                while (inches > 12)
                {
                    feet++;
                    inches = inches - 12;
                }
            }

            public void displayDistance()
            {
                Console.WriteLine("Feet:" + feet + " Inces:" + inches);

                Console.ReadLine();

            }

        }

        static void Main(string[] args)
        {
            MyDistance c1 = new MyDistance(119, 17);
            MyDistance c2 = new MyDistance(12, 111);
            c1.displayDistance();
            c2.displayDistance();
            c1.addDistance(c2);
            c1.displayDistance();


        }


    }
}


