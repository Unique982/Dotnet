using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_7
{
    internal class Example4A
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("enter the any two number:");
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                int div = num1 / num2;
                Console.WriteLine("division of two number:" + div);
            }
            catch (DivideByZeroException ex)
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
                Console.ReadLine();
            }
        }


    }
}


    
