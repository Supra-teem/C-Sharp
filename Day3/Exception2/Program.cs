using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception2
{
    public delegate void transactions(int s);

    class bank
    {
        public int amount=5000;
        public string user;
        int c = 2;
        public void credit(int s)
        {
            if (c != 0)
            {
                amount += s;
                Console.WriteLine("Your total Balance is: " + amount);
                c--;
            }
            else
            {
                throw (new myexcep("Your todays limit is over. Come Tomorrow!\n"));
            }
            
        }
        public void debit(int s)
        {
            if (s <= amount)
            {
                amount -= s;
                Console.WriteLine("Your balance is: " + amount);
            }
            else
            {
                throw (new myexcep("Your Balance is low!!"));

            }

        }
       
    }

    class myexcep : Exception
    {
        public myexcep(string Msg) : base(Msg)
        {

        }

    }
    //class myexcep1 : Exception
    //{
    //    public myexcep1(string Msg) : base(Msg)
    //    {

    //    }

    //}
    class Program
    {
        static void Main(string[] args)
        {
            bank b = new bank();
            try
            {
                transactions t = new transactions(b.credit);
                t(100);
                t(100);
                t(100);


                b.user = "Suresh";
                //b.credit(100);
                //b.credit(100);
                //b.credit(100);
            }
            catch (myexcep e)
            {
                Console.WriteLine(e.Message);
            }
            try {
                transactions t = new transactions(b.debit);
                t(1000);
                t(5000);
                //b.debit(1000);
                //b.debit(5000);
            }
                catch (myexcep e1)
            {
                Console.WriteLine(e1.Message);
            }
            

            
        }
    }
}
