using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    internal class Example4
    {

        static class College
        {
            public static string college;

            static College()
            {
                college = "Ratna Rajyalaxmi Campus";
            }


        }

        public class Student
        {
            string name;
            int roll;


            public Student(string n, int r)
            {
                name = n;
                roll = r;
            }

            public void display()
            {
                Console.WriteLine("Name:" + name + " roll=" + roll + " college:" + College.college);
                Console.ReadLine();
            }
        }

        static void Main(string[] args)
        {
            Student s1 = new Student("Unique Neupane", 19);
            s1.display();
        }
    }
}

