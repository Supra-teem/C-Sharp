using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeArea
{
    public class Area
    {
        public void circleArea(double r)
        {
            Console.WriteLine("The area of the circle is " + (Math.PI * r * r));
        
        }
        public void rhombusArea(double p, double q)
        {
            Console.WriteLine("The area of the Rhombus is " + (p*q)/2);

        }

    }
}
