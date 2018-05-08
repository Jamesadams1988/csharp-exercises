using System;

namespace Class1prep_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double Length;
            double Width;
            double area;
            string input;
            Console.WriteLine("Area of a Rectangle Program Initiated");
            Console.WriteLine("_____________________________________");
            Console.WriteLine("What is the Length of the rectangle?");
            input = Console.ReadLine();
            Length = double.Parse(input);
            Console.WriteLine("What is the Width of the rectangle?");
            input = Console.ReadLine();
            Width = double.Parse(input);
            Console.WriteLine("Calculating...");
            area = (Width * Length);
            Console.WriteLine("The area of the rectangle is: " + area);
            Console.ReadLine();
        }
    }
}
