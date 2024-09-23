using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6
{
    internal class LinkedList
    {
        public static void Main(string[] args)
        {

            LinkedList<char> linkedList = new LinkedList<char>();
            linkedList.AddLast('X');
            linkedList.AddLast('Y');
            linkedList.AddLast('Z');
            foreach (char c in linkedList)
            {
                Console.WriteLine(c);
            }
            Console.ReadKey();
        }
    }
}
