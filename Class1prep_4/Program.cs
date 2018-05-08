using System;

namespace Class1prep_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string story;
            string input;
            int search;
            story="Alice was beginning to get very tired of sitting by her sister on the bank, " +
                "and of having nothing to do: once or twice she had peeped into the book her " +
                "sister was reading, but it had no pictures or conversations in it, " +
                "'and what is the use of a book,' thought Alice 'without pictures or conversation?";
            story = story.ToLower();
            Console.WriteLine("What would you like to search within the story for? Returns a True or False answer.");
            input = Console.ReadLine();
            input = input.ToLower();
            search = story.IndexOf(input);
            Console.WriteLine(search);
            if (search.Equals(0))
            {
                Console.WriteLine("The term, "+ input +" is not found within the story");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("The term, " + input + " is found within the story");
                Console.ReadLine();
            }
        }
    }
}
