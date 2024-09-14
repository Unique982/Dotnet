using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    internal class Example2C
    {
        public class Monkey
        {
            public void Eat()
            {
                Console.WriteLine("The Monkey Eats Food.");
            }
        }

        public class Cheetah : Monkey
        {
            public void RunFast()
            {
                Console.WriteLine("The Cheetah Runs Very Fast.");
            }
        }

        public class Boy : Monkey
        {
            public void Play()
            {
                Console.WriteLine("The Boy Play Video Game.");
            }
        }

        public static class HierarcialInheritance
        {
            public static void Main(string[] args)
            {
               Cheetah c1 = new Cheetah();
                c1.Eat();
                c1.RunFast();
                Console.WriteLine("---------------------------------------------------");
             Boy b1 = new Boy();
               b1.Eat();
                b1.Play();
                Console.ReadKey();
            }
        }
    }

}
