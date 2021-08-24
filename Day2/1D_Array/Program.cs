using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1D_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = new string[7];
            Console.WriteLine("Enter Week Days one by one: ");
            for(int i=0;i<7;i++)
            {
                arr[i] = Console.ReadLine();
            }

            for(int i=0;i<7;i++)
            {
                Console.Write(arr[i]+" ");
            }
        }
    }
}
