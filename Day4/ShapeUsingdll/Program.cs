using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeArea;
namespace ShapeUsingdll
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, p, q;
            Console.Write("Enter the radius of the circle: ");
            Area a = new Area();
            r = Convert.ToDouble(Console.ReadLine());
            a.circleArea(r);
            Console.WriteLine();
            Console.WriteLine("Enter the value of P and Q of Rhombus: ");
            p = Convert.ToDouble(Console.ReadLine());
            q = Convert.ToDouble(Console.ReadLine());
            a.rhombusArea(p, q);
        }
    }
}
