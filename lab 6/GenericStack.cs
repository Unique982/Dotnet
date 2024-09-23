using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6
{
    internal class GenericStack
    {
        public static void Main(string[] args)
        {
            Stack<string> students = new Stack<string>();
            students.Push("Testing");
            students.Push("Ram");
            students.Push("Pradip");
            foreach (var item in students)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
