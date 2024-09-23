using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_7
{
    internal class Example6
    {

        static void Main()
        {
            try
            {
                Console.Write("Enter your name: ");
                string name = Console.ReadLine();

                if (name.Length > 15)
                {
                    throw new ArgumentException("Name cannot be more than 15 characters long.");
                }
                Console.WriteLine($"Your name is: {name}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred: " + ex.Message);
            }

            Console.ReadLine();
        }
    }
}

