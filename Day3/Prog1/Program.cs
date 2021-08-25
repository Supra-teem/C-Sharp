using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 65, 67, 68, 69 };
            Char[] crr = new char[4];
            int i = 0;
            foreach(int item in arr)
            {
                crr[i] = (char)item;
                i++;
            }
            foreach(char ch in crr)
            {
                Console.Write(ch + " ");
            }


        }
    }
}
