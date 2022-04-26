using System;

namespace c_sharp1
{

    public class RegularPolygon
    {

        public void calculatePerimeter(int length, int sides)
        {

            int result = length * sides;
            Console.WriteLine("Perimeter: " + result);
        }
    }

    class Square : RegularPolygon
    {

        public int length = 200;
        public int sides = 4;
        public void calculateArea()
        {

            int area = length * length;
            Console.WriteLine("Area of Square: " + area);
        }
    }

    class Rectangle : RegularPolygon
    {

        public int length = 100;
        public int breadth = 200;
        public int sides = 4;

        public void calculateArea()
        {

            int area = length * breadth;
            Console.WriteLine("Area of Rectangle: " + area);
        }
    }

    class Program
    {

        static void Main()
        {

            Square s1 = new Square();
            s1.calculateArea();
            s1.calculatePerimeter(s1.length, s1.sides);


            Rectangle t1 = new Rectangle();
            t1.calculateArea();
            t1.calculatePerimeter(t1.length, t1.sides);

        }
    }
}
