using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Inheritance
{
    class Employee
    {
        public string name;
        public double salary;
        
    }
    class Gross_salary : Employee
    {
        public double ta, da, hra;
        public void gross_sal()
        {
            ta=(salary* 10) / 100;
            da=(salary * 10) / 100;
            hra=(salary * 5) / 100;
            double tot =salary + ta + da + hra;
            Console.WriteLine("Gross salary of "+name+" is " + tot);
        }

    }
    class Programs
    {
        
        static void Main(string[] args)
        {
            Gross_salary e1 = new Gross_salary();
            Gross_salary e2 = new Gross_salary();
            Console.Write("1st Emoloyee name: ");
            e1.name = Console.ReadLine();
            Console.Write("1st Emoloyee Salary: ");
            e1.salary =Convert.ToDouble(Console.ReadLine());
            e1.gross_sal();
            Console.Write("2nd Emoloyee name: ");
            e2.name = Console.ReadLine();
            Console.Write("2st Emoloyee Salary: ");
            e2.salary =Convert.ToDouble(Console.ReadLine());
            e2.gross_sal();



        }
    }
}
