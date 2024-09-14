using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
   
        public class Example
        {
            private string name;
            private float salary;
            private string position;

            public void SetDetails(string empName, float empsalary, string position)
            {
                name = empName;
                salary = empsalary;
                this.position = position;
            }

            public void DisplayDetails()
            {
                Console.WriteLine($"Name: {name}");
                Console.WriteLine($"Salary: {salary}");
                Console.WriteLine($"Position: {position}");
            }

            public void EmployeeMember()
            {
                Console.WriteLine($"The Employee {name} is a Web Developer.");
            }
        }

        public class Emp
        {
            public static void Main()
            {
                Example emp = new Example();

                emp.SetDetails("Unique Neupane", 100000, "Web Developer");
                emp.DisplayDetails();
                emp.EmployeeMember();
                Console.ReadKey();
            }
        }
    }
