using System;
namespace c_sharp1
{
    public abstract class Plan
    {
        protected double rate;
        public abstract void getRate();
        public void calculation(int units)
        {
            Console.Write("BILL AMOUNT FOR " + units + " UNITS is: Rs.");
            Console.WriteLine(rate * units);
        }
    }

    class CommercialPlan : Plan
    {
        public override void getRate()
        {
            rate = 5.00;
        }
    }
    class DomesticlPlan : Plan
    {
        public override void getRate()
        {
            rate = 2.50;
        }
    }

    class Program
    {
        static void Main()
        {
            Plan p;
            Console.WriteLine("COMMERCIAL CONNECTION");
            p = new CommercialPlan();
            p.getRate();
            p.calculation(250);
            Console.WriteLine("DOMESTIC CONNECTION");
            p = new DomesticlPlan();
            p.getRate();
            p.calculation(150);

        }
    }
}
