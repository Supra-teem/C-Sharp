using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace hashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable h = new Hashtable();
            h.Add("ID", 1001);
            h.Add("name", "Deepti");
            h.Add("salary", 200);
            h.Add("dept", "IT");
            foreach (object o in h.Keys)
            {
                Console.WriteLine(h[o]);
            }
            Console.WriteLine("Salary= " + h["salary"]);

        }
    }
}
