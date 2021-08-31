using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_responsibility_principle
{

    public interface Itransac
    {
        void credit(int s);
        void debit(int s);
    }
    public interface IInterest
    {
        void calculate();
    }

    class Transac : Itransac
    {

        public int balance;
        public Transac()
        {
            balance = 5000;
            Console.WriteLine("Your Initial Balance is : " + balance);
        }
        public void credit(int s)
        {
            balance += s;
            Console.WriteLine("Your Current Balance is " + balance);
        }
        public void debit(int s)
        {
            if (s < balance)
            {
                balance -= s;
                Console.WriteLine("Your Current Balance is " + balance);

            }
            else
            {
                Console.WriteLine("Your Balance is low, credit first");

            }

        }
    }
    //class Calculate : IInterest
    //{ 
    //    public void calculate(int balance)
    //    {
    //        int t;
    //        Console.WriteLine("Enter the number of year: ");
    //        t = Convert.ToInt32(Console.ReadLine());
    //        //Console.WriteLine("Enter Your Balance: ");
    //        //balance = Convert.ToInt32(Console.ReadLine());
    //        double interest = (balance * t * 6) / 100;
    //        Console.WriteLine("Your Interest is: "+interest);
    //        Console.WriteLine("Your total balance would be :"+(balance+interest));

    //    }

    //}

    class SavingAcc : IInterest
    {
        public void calculate()
        {
            Console.WriteLine("Enter the principal: ");
            int p = Convert.ToInt32(Console.ReadLine());
            int r = 6;
            Console.WriteLine("Enter the time: ");
            int t = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your Amount of Interst is: " + ((p * t * r) / 100));

        }
    }
    class SalAcc : IInterest
    {
        public void calculate()
        {
            Console.WriteLine("Enter the principal: ");
            int p = Convert.ToInt32(Console.ReadLine());
            int r = 7;
            Console.WriteLine("Enter the time: ");
            int t = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your Amount of Interst is: " + ((p * t * r) / 100));

        }
    }
    class ChildAcc : IInterest
    {
        public void calculate()
        {
            Console.WriteLine("Enter the principal: ");
            int p = Convert.ToInt32(Console.ReadLine());
            int r = 4;
            Console.WriteLine("Enter the time: ");
            int t = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your Amount of Interst is: " + ((p * t * r) / 100));

        }
    }

    class Program
    {
        
        static void Main(string[] args)
        {

            //Transac t = new Transac();
            //t.credit(500);
            //t.credit(500);
            //t.debit(1000);
            //t.debit(6000);
            //Calculate c = new Calculate();
            //c.calculate(t.balance);
            SavingAcc sv = new SavingAcc();
            SalAcc sl = new SalAcc();
            ChildAcc ch = new ChildAcc();
            sv.calculate();
            sl.calculate();
            ch.calculate();

        }
    }
}
