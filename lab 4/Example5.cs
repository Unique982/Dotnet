using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    internal class Example5
    {
        struct Company
        {
            public string name, address;
            public double phone, salary;

        };
        static void Main(string[] args)
        {
            Company c1;
            Company c2;

            c1.name = "Dai Vai IT Solution";
            c1.address = "Kathmandu";
            c1.phone = 9809559560;
            c1.salary = 1000000;

            c2.name = "Unique IT Solution";
            c2.address = "Dang,Nepal";
            c2.phone = 9864728224;
            c2.salary = 1000000;

            Console.WriteLine("Name of c1=" + c1.name);
            Console.WriteLine("Address of c1=" + c1.address);
            Console.WriteLine("Phone of c1=" + c1.phone);
            Console.WriteLine("Salary of c1=" + c1.salary);

            Console.WriteLine("Name of c2=" + c2.name);
            Console.WriteLine("Address of c2=" + c2.address);
            Console.WriteLine("Phone of c2=" + c2.phone);
            Console.WriteLine("Salary of c2=" + c2.salary);
            Console.ReadLine();

        }

    }
}


 
