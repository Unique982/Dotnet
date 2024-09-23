using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6
{
    internal class Queue
    {
        public static void Main(string[] args)
        {
            Queue<double> queue = new Queue<double>();
            queue.Enqueue(12.0);
            queue.Enqueue(199.2);
            queue.Enqueue(1209.3);
            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }
            
            Console.ReadKey();
        }
    }
}

   
