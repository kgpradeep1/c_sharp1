using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp1
{
    internal class methodoverloading
    {
        public static int area(int a)
        {
            return a * a;
        }
        public static int area(int a, int b)
        {
            return a * b;

        }
        public static int area(int a, int b, int c)
        {
            return a * b * c;
        }
        public static void Main()
        {
            int square=area(4);
            Console.WriteLine("area of a square:{0}",square);
            int rectangle=area(4,6);
            Console.WriteLine("area of a rectangle:{0}", rectangle);
            int cube=area(4,6,8);
            Console.WriteLine("area of a cube:{0}", cube);
        }
    }
}
