using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6
{
    internal class GenericList
    {
        public static void Main(string[] args)
        {
            List<string> students = new List<string>();
            students.Add("Unique");
            students.Add("Arjun ");
            students.Add("Bhup");
            students.Add("Khemraj");
            foreach (var item in students)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
