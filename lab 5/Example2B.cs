using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    internal class Example2B
    {
        public class Monkey
        {
            public void Eat()
            {
                Console.WriteLine("The Monkey Eat Food.");
            }
        }

        public class Cheetah : Monkey
        {
            public void RunFast()
            {
                Console.WriteLine("The Cheetah Run Very Fast.");
            }
        }

        public class Boy : Cheetah
        {
            public void Play()
            {
                Console.WriteLine("The Boy Play Video Game.");
            }
        }

        public static void Main(string[] args)
        {
            Boy b1 = new Boy();
            b1.Eat();
            b1.RunFast();
            b1.Play();
            Console.ReadKey();
        }
    }
}

