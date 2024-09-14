using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    internal class Example3
    {
        public class Student
        {
            private string name;
            private int roll_no;


            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public int Age
            {
                get { return roll_no; }
                set { roll_no = value; }
            }


            public string this[int index]
            {
                get { return "Student " + index; }
                set { Console.WriteLine("Setting student " + index + " to " + value); }
            }

            public static void Main(string[] args)
            {
                Student s1 = new Student();
                s1.Name = "Unique Neupane";
                s1.roll_no = 19;

                Console.WriteLine("Student Name =" + s1.Name);
                Console.WriteLine("Student Roll No = " + s1.roll_no);

                Console.WriteLine("Indexer: " + s1[0]);
                s1[1] = "Romeo";
                Console.WriteLine("Indexer: " + s1[1]);
                Console.ReadKey();
            }
        }
    }
}