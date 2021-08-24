using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_variables
{
    class Program
    {
        public static int a, b;
        public static void add(int a, int b)
        {
            Console.WriteLine("The addition of two numbers is: " + (a + b));
        }
        public static void multi(int a, int b)
        {
            Console.WriteLine("The multi of two numbers is: " + (a * b));
        }
        public static void sub(int a, int b)
        {
            Console.WriteLine("The subtract of two numbers is: " + (a - b));
        }
        public static void div(int a, int b)
        {
            Console.WriteLine("The division of two numbers is: " + (a / b));
        }
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Enter two number: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            add(a, b);
            sub(a, b);
            multi(a, b);
            div(a, b);
        }
    }
}
