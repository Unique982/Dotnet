using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Pipes;

using System.Threading.Tasks;

namespace lab_7
{
    internal class Example3A
    {
        public class person
        {
            public void message(string name, double op, double np)
            {
                Console.WriteLine("The price of " + name + " is changed from " + op + " to " + np);
            }

            public delegate void pricechanged(string name, double op, double np);

            public class stockticker
            {
                public event pricechanged pc;
                public string name { get; set; }
                private double nprice;

                public double price
                {
                    get { return nprice; }
                    set
                    {
                        double op = nprice;
                        nprice = value;
                        if (pc != null)
                        {
                            pc.Invoke(name, op, nprice);
                        }
                    }
                }
            }

            public class eventex
            {
                public static void Main()
                {
                    person p = new person();
                    stockticker st = new stockticker { name = "Java", price = 5000 };
                    st.pc += p.message;
                    st.price = 60000;
                    Console.ReadLine();
                }
            }
        }
    }
}
 