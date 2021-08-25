using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            int r, c,i,j,k=0;
            try
            {
                Console.WriteLine("Enter the values of rows and columns: ");
                r = Convert.ToInt32(Console.ReadLine());
                c = Convert.ToInt32(Console.ReadLine());
                int[,] a = new int[r, c];
                int[] b = new int[r * c];
                Console.WriteLine("Enter 2-D array elements: ");
                for(i=0;i<r;i++)
                {
                    for(j=0;j<c;j++)
                    {
                        Console.Write("[{0}] [{1}]: ", i, j);
                        a[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                for(i=0;i<r;i++)
                {
                    for(j=0;j<c;j++)
                    {

                        b[k++] = a[i, j];
                    }
                }
                Console.WriteLine("Your 1-D array is: ");
                for(i=0;i<(r*c);i++)
                {
                    Console.Write(b[i] + " ");

                }
                Console.WriteLine();
                Console.WriteLine(b[10]);
                Console.WriteLine();
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);

            }
            finally
            {
                Console.WriteLine("Thank you ");
            }
        }
    }
}
