using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public class Subject
    {
        private string[] subjects = new string[5];
        public string this[int index]
        {
            get { return subjects[index]; }
            set { subjects[index] = value; }
        }
    }

    public class Example5
    {
        static void Main()
        {

            Subject s1 = new Subject();
            s1[0] = "Computer Network";
            s1[1] = "Introduction To Management";
            s1[2] = "Computer Graphics";
            s1[3] = "DotNet Technology";
            s1[4] = "MIS And E-Business";

            Console.WriteLine("BCA Fifth Semester Subjects Are:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine((i + 1) + ") " + s1[i]);
            }
            Console.ReadKey();
        }
    }
}
