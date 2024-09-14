using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    internal class Example4
    {
        public class Employee
        {
            private int eid;
            private string name;
            private int salary;
            public object this[int index]
            {
                set
                {
                    if (index == 0)
                    {
                        eid = (int)value;
                    }

                    else if (index == 1)
                    {
                        name = (string)value;
                    }
                    else if (index == 2)
                    {
                        salary = (int)value;
                    }
                }
                get
                {
                    if (index == 0)
                    {
                        return eid;
                    }
                    else if (index == 1)
                    {
                        return name;
                    }
                    else if (index == 2)
                    {
                        return salary;
                    }
                    else
                    {
                        return null;
                    }
                }
            }

            public class Index
            {
                public static void Main(string[] args)
                {
                    Employee e1 = new Employee();
                    e1[0] = 101;
                    e1[1] = "Unique Neupane";
                    e1[2] = 200000;
                    Console.WriteLine("Employee Id=" + e1[0]);
                    Console.WriteLine("Employee Name=" + e1[1]);
                    Console.WriteLine("Employee Salary=" + e1[2]);
                    Console.ReadKey();
                }

            }
        }
    }
}