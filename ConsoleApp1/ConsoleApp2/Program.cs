using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1, sum,i,n;
            Console.Write("Enter the range: ");
            n=Convert.ToInt32(Console.ReadLine());
            Console.Write(a+" "+b+" ");
            for(i=2;i<n;i++)
            {
                sum = a + b;
                Console.Write(sum + " ");
                a = b;
                b = sum;


            }
        }
    }
}
