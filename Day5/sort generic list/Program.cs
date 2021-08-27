using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_generic_list
{
    
        class Employee : IComparable<Employee>
        {
            public int id { get; set; }
            public string name { get; set; }
            public double salary { get; set; }
            public int CompareTo(Employee e)
            {
                if (this.salary > e.salary) { return 1; }
                else if (this.salary < e.salary) { return -1; }
                else return 0;
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Employee employee1 = new Employee()
                {
                    id = 101,
                    name = "John",
                    salary = 50000
                };
                Employee employee2 = new Employee()
                {
                    id = 102,
                    name = "Kelvin",
                    salary = 10000
                };
                Employee employee3 = new Employee()
                {
                    id = 103,
                    name = "Smith",
                    salary = 30000
                };
                List<Employee> employees = new List<Employee>();
                employees.Add(employee1);
                employees.Add(employee2);
                employees.Add(employee3); foreach (var emp in employees)
                {
                    Console.WriteLine("Employee ID: {0}", emp.id);
                    Console.WriteLine("Employee Name: {0}", emp.name);
                    Console.WriteLine("Employee Salary: {0}", emp.salary);
                    Console.WriteLine();
                }
                employees.Sort(); Console.WriteLine();
                Console.WriteLine("After Sort: ");
                foreach (var emp in employees)
                {
                    Console.WriteLine("Employee ID: {0}", emp.id);
                    Console.WriteLine("Employee Name: {0}", emp.name);
                    Console.WriteLine("Employee Salary: {0}", emp.salary);
                    Console.WriteLine();
                }
            }
        }
    }

