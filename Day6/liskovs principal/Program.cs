using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace liskovs_principal
{
    public abstract class fruit
    {
        public abstract void color();
    }
    class apple : fruit
    {
        public override void color()
        {
            Console.WriteLine("Color is red");
        }

    }
    class orange : fruit
    {
        public override void color()
        {
            Console.WriteLine("Color is orange");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //apple ap = new apple();
            //ap.color();
            //apple or = new orange();
            //or.color();
            fruit ap = new apple();
            ap.color();
            fruit or = new orange();
            or.color();
        }
    }
}
