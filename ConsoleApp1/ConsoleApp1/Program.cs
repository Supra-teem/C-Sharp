using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to get factorial: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            if(n == 0)
            {
                fact = 1;
                Console.WriteLine("Factorial of " + n + " is " + fact);
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    fact = fact * i;


                }
                Console.WriteLine("Factorial of " + n + " is " + fact);
            }
        
        }
    }
}
