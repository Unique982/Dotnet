using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_7
{
    internal class Example4C
    {
        public static void Main()
        {
            try
            {
                string n = "Unique Neupane";

                Console.WriteLine(n);
                int x = (int)(object)n;
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine();
                Console.ReadLine();
            }
        }
    }
}