using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Arraylist
{
    
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList al = new ArrayList();
            //al.Add(10);
            //al.Add(50.23);
            //al.Add("Hello World");
            //al.Add('C');
            //foreach (var item in al)
            //{
            //    Console.WriteLine(item);
            //    Console.WriteLine();
            //}
            //Console.WriteLine(al.Capacity);
            //al.Add(true);
            //Console.WriteLine(al.Capacity);

            //al.Remove(10);
            //al.RemoveAt(1);

            ////al.Add(15);
            ////al.Add(15.23);
            ////al.Add(false);
            ////al.Add("Hi");
            ////al.Add("Hello");

            //foreach (var item1 in al)
            //{
            //    Console.WriteLine(item1);
            //    Console.WriteLine();

            //}
            //al.TrimToSize();
            //al.Add(69);
            //Console.WriteLine(al.Capacity);
            //Console.WriteLine(al.Count);
            int emp = 5, i, eid;
            string ename,pname;
            for (i = 0; i < emp; i++)
            {
                ArrayList al = new ArrayList();
                Console.Write("Enter the EmployeeId:");
                eid = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the Employee Name:");
                ename = Console.ReadLine();
                Console.Write("Enter the Project Name:");
                pname = Console.ReadLine();
                al.Add(eid);
                al.Add(ename);
                al.Add(pname);
                foreach(var item in al)
                {
                    Console.WriteLine(item);
                }
                if(eid>=1001 && eid<=1005)
                {
                    Console.WriteLine("Yes you are in this project");
                }
                else
                {
                    Console.WriteLine("you are not in this batch");

                }

                Console.WriteLine(al.Capacity);
            }
        }
    }
}
