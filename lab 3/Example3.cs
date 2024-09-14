using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Example3
    {
        static void Main(string[] args)
        {
            public static void Main(string[] args)
            {
                int[,] matrix = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };
                int sum = 0;

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (i == j)
                        {
                            sum += matrix[i, j];
                        }
                    }
                }

                Console.WriteLine("Sum of diagonals : " + sum);
            }

        }
    } }

