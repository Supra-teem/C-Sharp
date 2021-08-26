using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_Readonly_Const
{
    class Program
    {
        int a;
        static int b = 200;
        const float pi = 3.14f;
        readonly bool flag;
        public Program(int a, bool flag)
        {
            this.a = a;
            this.flag = flag;


        }
        public void incrementor()
        {
            a = a + 10;
            b += 100;
            //pi =3.12f;
            //if (flag == true)
            //{
            //    flag = false;
            //}
            //else
            //    flag = true;
        }

        static void Main(string[] args)
        {
            
            Program p = new Program(50, true);
            Program p1 = new Program(100, false);
            Console.WriteLine(p.a + " " + p.flag+" "+b+ " "+pi);
            p.incrementor();
            Console.WriteLine(p.a + " " + p.flag+" "+b+ " "+pi);
            Console.WriteLine(p1.a + " " + p1.flag + " " + b + " " + pi);
            p1.incrementor();
            Console.WriteLine(p1.a + " " + p1.flag + " " + b + " " + pi);
            

        }
    }
}
