using System;

namespace Class1prep_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double Gas;
            double Miles;
            double MPG;
            string input;
            Console.WriteLine("MPG Estimator Program Initiated");
            Console.WriteLine("_____________________________________");
            Console.WriteLine("How many gallons of gas have you used?");
            input = Console.ReadLine();
            Gas = double.Parse(input);
            Console.WriteLine("How many miles have you driven since your last refill?");
            input = Console.ReadLine();
            Miles = double.Parse(input);
            Console.WriteLine("Calculating...");
            MPG = (Miles / Gas);
            Console.WriteLine("The Miles per Gallon is: " + MPG + "/MPG");
            Console.ReadLine();
        }
    }
}
