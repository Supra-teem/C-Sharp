using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace As_operator
{
    class class1
    {

    }
    class class2
    {

    }
    class as_is
    {
        public static void Test(object o)
        {
            class1 a;
            class2 b;
            if (o is class1)
            {
                Console.WriteLine("o is Class1");
                a = (class1)o;
            }
            else if (o is class2)
            {
                Console.WriteLine("o is Class2");
                b = (class2)o;
            }
            else
            {
                Console.WriteLine("o is neither Class1 nor Class2.");
            }
        }

        static void Main(string[] args)
        {
            // As operator
            //string str1 = "Mindteck";
            //object obj1 = str1;
            //Console.WriteLine(obj1);
            //string str2 = obj1 as string;
            //Console.WriteLine(str2);

            // As operator
            //int[] arr = new int[2] { 10, 20 };
            //object obj1 = arr;
            //string str = obj1 as string;
            //if(str!=null)
            //{
            //    Console.WriteLine("Successfull");

            //}
            //else
            //{
            //    Console.WriteLine("Un Successfull");
            //}
            //Console.WriteLine("After conversion " + str);

            class1 c1 = new class1();
            class2 c2 = new class2();
            Test(c1);
            Test(c2);
            Test("Passing String Value instead of class");


        }
    }
}
