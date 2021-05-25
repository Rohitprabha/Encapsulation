using System;

namespace Protected_Access_Specifier
{
    class Rectangle
    {
        protected double length;
        protected double width;

        double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("Area: {0}", GetArea());
        }
    }
    class Program : Rectangle
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.length = 4.5;
            p.width = 3.5;
            p.Display();
            Console.ReadLine();
        }
    }
}
