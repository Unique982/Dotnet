using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace lab_4
{

    public class Example7
    {
        public void Display()
        {
            Console.WriteLine("This is namespace. (Unique Neupane)");
        }
    }
}

namespace RR_BCA
{
    class AnotherNameSpace
    {
        public static void Main(string[] args)
        {
      
            lab_4.Example7 myObject = new lab_4.Example7();
            myObject.Display();

            Console.ReadKey();
        }
    }
}