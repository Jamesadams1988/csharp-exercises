using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string userinput;
            Console.WriteLine("Hello World");
            Console.WriteLine("What is your name?");
            userinput = Console.ReadLine();
            Console.WriteLine("Your name is: " + userinput);
            Console.ReadLine();

        }
    }
}
