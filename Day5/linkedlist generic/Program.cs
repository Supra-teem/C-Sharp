using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace linkedlist_generic
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            LinkedList<int> ll = new LinkedList<int>(arr);
            List<int> l1= ll.ToList<int>();
            l1.Reverse();
            foreach (int item in l1)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
