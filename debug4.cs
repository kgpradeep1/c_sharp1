using System;
delegate int NumberChanger(int n);
namespace c_sharp1
{
    class TestDelegate
    {
        static int num = 1;
        public static int AddNum(int p)
        {
            num += p;
            return num;
        }
        public static int MultNum(int q)
        {
            num *= q;
            return num;
        }
        public static int getNum()
        {
            return num;
        }
        static void Main(string[] args)
        {
            //create delegate instances
            NumberChanger nc1 = new NumberChanger(AddNum);
            NumberChanger nc2 = new NumberChanger(MultNum);



            //calling the methods using the delegate objects
            nc1(25);
            Console.WriteLine("Value of Num: {0}", getNum());
            Console.WriteLine("Value of Num: {0}", getNum());
            Console.ReadKey();
        }

    }
}

