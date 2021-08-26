using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Override2
{
    class Transport
    {
        public void carHello()
        {
            Console.WriteLine("I'm a Car");
        }
        public virtual void carType()
        {
            Console.WriteLine("I'm A normal Car");
        }
    }

    class Twowheeler : Transport
    {
        public override void carType()
        {
            Console.WriteLine("I'm a Two wheeler Car");
        }
    }
    class Fourwheeler : Transport
    {
        public override void carType()
        {
            Console.WriteLine("I'm a Four wheeler Car");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Twowheeler c1 = new Twowheeler();
            c1.carHello();
            c1.carType();
            Fourwheeler c2 = new Fourwheeler();
            c2.carHello();
            c2.carType();
            Transport t = new Transport();
            t.carHello();
            t.carType();




        }
    }
}
