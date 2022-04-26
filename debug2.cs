using System;
namespace c_sharp1
{
    class swap
    {
        public static void Main()
        {
            int a = 1, b = 2;
            Console.WriteLine("Before swap a= " + a + " b= " + b);
            a = a * b;
            a = a / b;
            a = a / b;
            Console.Write("After swap a= " + b + " b= " + a);
        }
    }
}