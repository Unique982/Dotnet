using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_7
{
    internal class EventHandling
    {
        public class person
        {
            public void message(string name, double op, double np)
            {
                Console.WriteLine("Th price of" + name + " is changed from " + op + "to" + np);
            }
        }
        public delegate void PriceChanged(string name, double op, double np);
        public class StockTicker
        {
            public event PriceChanged pc;
            public string name { get; set; }
            private double price;
            public double Price
            {
                get
                {
                    return price;
                }


                set
                {
                    double op = Price;
                    price = value;
                    if (pc != null)
                    {
                        pc.Invoke(name, op, Price);

                    }

                }
            }



            public class EventHandlling
            {
                private static string name;

                public static int Price { get; private set; }

                public static void Main(string[] args)
                {
                    person person = new person();
                    StockTicker t = new StockTicker();
                    {
                        name = "Nabil"; Price = 475;
                    }
                    t.pc += person.message;
                    t.Price = 500;
                    t.Price = 700;
                    Console.ReadKey();
                }
            }
        }
    }
}
    
