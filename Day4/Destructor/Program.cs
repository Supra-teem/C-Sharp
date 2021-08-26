using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestClass;
using testlib2;

namespace Destructor
{
    //class test : IDisposable
    //{
    //    public test()
    //    {
    //        Console.WriteLine("Object created");
    //    }
    //    ~test()
    //    {
    //        Console.WriteLine("Destructor called!!");
    //    }

    //    public void Dispose()
    //    {
    //        GC.SuppressFinalize(true);
    //        Console.WriteLine("Dispose called!!");
    //    }
    //}

    //Example of linking .dll from different solutions and same solution as well.
    class Program
    {

        static void Main(string[] args)
        {
            //int i;
            //for (i = 0; i < 10; i++)
            //{
            //    test t = new test();
            //    t.Dispose();
            //}
            Class1 c = new Class1();
            c.welcome();
            test t = new test();
            t.welcome();
            
        }
    }
}
