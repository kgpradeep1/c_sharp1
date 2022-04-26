using System;
using System.Dynamic;
using System.Collections.Generic;

namespace c_sharp1
{
    public class Calculator<T>   //Generic Class:
    {
        private T result;  //variable of type T to show result:
        public T add(T x, T y) //Receive two Parameters of type T:
        {
            //we will discuss "Dynamic" keyword in same tutorial:
            dynamic a = x;
            dynamic b = y;
            result = a + b;
            return result;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Calculator<int> integer = new Calculator<int>();
            Console.WriteLine("Generic Class for Integer: " + integer.add(20, 10));

            Calculator<float> _float = new Calculator<float>();
            Console.WriteLine("Generic Class for float: " + _float.add(3.5F, 2.0F));

            Calculator<double> _double = new Calculator<double>();
            Console.WriteLine("Generic Class for Double: " + _double.add(2.22, 1.25));

            Console.ReadKey();

        }
    }
}

