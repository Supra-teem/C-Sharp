using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace As_operator
{
    class as_is
    {
        static void Main(string[] args)
        {
            //string str1 = "Mindteck";
            //object obj1 = str1;
            //Console.WriteLine(obj1);
            //string str2 = obj1 as string;
            //Console.WriteLine(str2);

            int[] arr = new int[2] { 10, 20 };
            object obj1 = arr;
            string str = obj1 as string;
            if(str!=null)
            {
                Console.WriteLine("Successfull");

            }
            else
            {
                Console.WriteLine("Un Successfull");
            }
            Console.WriteLine("After conversion " + str);
        }
    }
}
