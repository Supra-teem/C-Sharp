using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transpose__Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int r, c, i, j;
            Console.Write("Enter the number of rows: ");
            r = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of Columns: ");
            c = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[r, c];
            Console.WriteLine("Enter the elements: ");
            for(i=0;i<r;i++)
            {
                for(j=0;j<c;j++)
                {
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("After transposing the array will be: ");
            int[,] trans = new int[c, r];
            for (i = 0; i < r; i++)
            {
                for (j = 0; j < c; j++)
                {
                    trans[j, i] = arr[i,j];
                }
            }
            
            for (i = 0; i < c; i++)
            {
                for (j = 0; j < r; j++)
                {
                    Console.Write(trans[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
