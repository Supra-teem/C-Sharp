using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary
{
    class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public int salary { get; set; }

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
            Dictionary<string,Employee> employees = new Dictionary<string,Employee>();
            employees.Add(employee1.name, employee1);
            employees.Add(employee2.name, employee2);
            employees.Add(employee3.name, employee3);
            
            foreach(KeyValuePair<string, Employee> employeeKeyValuePair in employees)
            {
                Console.WriteLine("Key = " + employeeKeyValuePair.Key);
                Employee emp = employeeKeyValuePair.Value;
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}",
                               emp.id, emp.name, emp.salary);
            }

            Console.WriteLine("After Sorting: \n");
            //foreach (KeyValuePair<string, Employee> a in employees.OrderBy(key => key.Value))
            //{
            //    Console.WriteLine("Key = " + a.Key);
            //    Employee emp = a.Value;
            //    Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}",
            //                   emp.id, emp.name, emp.salary); ;
            //}

            //employees.Sort(); Console.WriteLine();
            //Console.WriteLine("After Sort: ");
            //foreach (var emp in employees)
            //{
            //    Console.WriteLine("Employee ID: {0}", emp.id);
            //    Console.WriteLine("Employee Name: {0}", emp.name);
            //    Console.WriteLine("Employee Salary: {0}", emp.salary);
            //    Console.WriteLine();
            //}
        }
    }
}

