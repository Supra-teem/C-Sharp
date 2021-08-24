using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding
{
    class Rectangle : Area
    {
        public int l, d;

        public Rectangle(int l, int d)
        {
            this.l = l;
            this.d = d;
        }
        public override void area()
        {
            base.area();
            Console.WriteLine("The area of the Rectangle is " + (l * d));
        }
    }
    class Square : Area
    {
        public int s;
        public Square(int s)
        {
            this.s = s;
        }
        public override void area()
        {
            base.area();
            Console.WriteLine("The area of the Square is " + (s*s));

        }

    }
    class Area
    {
        public virtual void area()
        {
            Console.WriteLine("This Is the base Area Function");
        }
        static void Main(string[] args)
        {
            Area a1 = new Rectangle(5,10);
            Area a2 = new Square(12);
            a1.area();
            a2.area();

        }
    }


}
