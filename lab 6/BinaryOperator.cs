using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6
{
    public class complex
    {
        public int x,y;
        public complex() { }
        public complex(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void display()
        {
            Console.WriteLine(x + "+" + y + "y");
        }
        public static complex operator *(complex c1, complex c2)
        {
            complex temp = new complex();
            temp.x = c1.x * c2.x;
            temp.y = c1.y * c2.y;
            return temp;
        }
        public static complex operator /(complex c1, complex c2)
        {
            complex temp = new complex();
            temp.x = c1.x / c2.x;
            temp.y = c1.y / c2.y;
            return temp;
        }
    }
    internal class BinaryOperator
    {
        public static void Main(string[] args)
        {
            complex c1 = new complex(2, 3);
            complex c2 = new complex(4, 5);

            Console.WriteLine("The orinal complex numbers are: ");
            c1.display(); c2.display();

            complex c3 = new complex();
            c3 = c1 * c2;
            Console.WriteLine("After Multiplication: ");
            c3.display();
            Console.ReadLine();

            complex c4 = new complex(6, 7);
            complex c5 = new complex(8, 9);
            Console.WriteLine("The orinal complex numbers are: ");
            c4.display(); c5.display();

            complex c6 = new complex();
            c6 = c4 / c5;
            Console.WriteLine("After Division: ");
            c6.display();
            Console.ReadKey();
        }
    }
}
