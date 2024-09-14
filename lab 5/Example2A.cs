using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public class Example2A
    {
        public class Monkey
        {
            public void Eat()
            {
                Console.WriteLine("The Monkey Eat Food.");
            }
        }

        public class Cheetah :Monkey
        {
            public void RunFast()
            {
                Console.WriteLine("The Cheetah Run very Fast.");
            }
        }

        public static void Main(string[] args)
        {
            Cheetah c1 = new Cheetah();
            c1.Eat();
            c1.RunFast();
            Console.ReadKey();
        }
    }
}