using System;
using System.Collections.Generic;


namespace lab_6
{
    public class Complex
    {
        public int real, img;
        public Complex() { }
        public Complex(int real, int img)
        {
            this.real = real;
            this.img = img;
        }
        public void display()
        {
            Console.WriteLine(real + "+" + img + "i");
        }
        public static Complex operator -(Complex C1)
        {
            Complex temp = new Complex();
            temp.real = -C1.real;
            temp.img = -C1.img;
            return temp;
        }
    }
    internal class UniaryMnus
    {
        public static void Main(string[] args)
        {
            Complex c1 = new Complex(4, 9);
            Console.WriteLine("Complex number:");
            c1.display();
            Complex c2 = -c1;
            Console.WriteLine("Negative Complex number");
            c2.display();
            Console.ReadKey();

        }
   

    }
}
  
