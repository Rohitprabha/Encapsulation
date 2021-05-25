using System;

namespace Private_Access_Specifier
{
    class Rectangle
    {
        private double length;              //access specifier defines the scope and visibility of a class member.
        private double width;

        public void details(double length, double width)
        {
            this.length = length;
            this.width = width;
        }
        public double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("Area: {0}", GetArea());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.details(4.4, 3.3);
            r.Display();
            Console.ReadLine();
        }
    }
}
