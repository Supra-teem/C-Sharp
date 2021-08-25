using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface odd
    {
        void Odd();
        void One();
        void Three();
        void Five();
        

    }

    interface even
    {
        void Even();
        void Two();
        void Four();

    }
    class Program : odd, even
    {
        public void Odd()
        {
            Console.WriteLine("This Is Odd");
        }
        public void Even()
        {
            Console.WriteLine("This Is Even");
        }
        public void One()
        {
            Console.WriteLine("This Is One");
        }
        public void Two()
        {
            Console.WriteLine("This Is Two");
        }
        public void Three()
        {
            Console.WriteLine("This Is Three");
        }
        public void Four()
        {
            Console.WriteLine("This Is Four");
        }
        public void Five()
        {
            Console.WriteLine("This Is Five");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Odd();
            p.One();
            p.Three();
            p.Five();
            p.Even();
            p.Two();
            p.Five();
        }
    }
}
