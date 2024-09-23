using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_7
{
    internal class Example4B
    {
        public static void Main(string[] args)
        {
            try
            {
                int[] num = new int[5] { 10, 20, 30, 40, 50 };
                Console.WriteLine(num[5]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("End a program:");
                Console.ReadKey();
            }
        }


    }
}

   