using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
    {
        //jagged
        internal class Program5
        {
            public static void Main(string[] args)
            {
                int[][] jagged = new int[][]
                                {
                               new int []{1,2,3,4},
                               new int []{5,6},
                               new int []{8,5,2 }
                                };

                Console.WriteLine("The jagged array is :");

                foreach (int[] i in jagged)
                {
                    foreach (int j in i)
                    {
                        Console.Write(j + " ");
                    }
                    Console.WriteLine();
                }


            }

        }
    }


