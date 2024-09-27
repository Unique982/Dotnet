using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_8
{
    class Eemployee
    {


        internal class Employee
        {
            public int id { get; set; }
            public string name { get; set; }
            public string address { get; set; }

            static void Main(string[] args)
            {
                List<Employee> employees = new List<Employee>
                {
                    new Employee { id = 1, name ="Ram" , address = "KTM" },
                    new Employee { id = 2, name =" Hari" , address = "Dang" },
                    new Employee { id = 3, name ="Sita" , address = "KTM" },
                    new Employee { id = 4, name =" Gita" , address = "PRK" },
                    new Employee { id = 5, name =" Khem" , address = "Dhangadhi" }
                };
                 var sortedEmployees = employees.OrderByDescending(e => e.name).ToList();
                Console.WriteLine("Employee Record display by name in descending Order");
                foreach (var employee in sortedEmployees) {
                    Console.WriteLine($"ID: {employee.id}, Name:{employee.name}, Address:{employee.address}");
                    }
                Console.ReadKey();


            }
        }
    }

}