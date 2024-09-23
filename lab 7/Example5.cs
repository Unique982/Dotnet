using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_7
{
    internal class Example5
    {
        static void Main()
        {
            try
            {

                Console.Write("Enter your balance: ");
                int balance = int.Parse(Console.ReadLine());

                Console.Write("Enter the amount to withdraw: ");
                int withdrawAmount = int.Parse(Console.ReadLine());

                if (withdrawAmount > balance)
                {
                    throw new InvalidOperationException("Insufficient balance to make this withdrawal.");
                }
                balance -= withdrawAmount;
                Console.WriteLine($"Withdrawal successful. Your remaining balance is: {balance:C}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter a valid number.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred: " + ex.Message);
            }

            Console.ReadLine();
        }
    }
}