using System;

namespace TeamProject
{
    // Skapar separat "main" där vi har så vi kan få UnitTests att fungera.
   public static class Program
    { 

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, please writeout between one - ten and give us an operator plus och minus and I'll calculate it for you.");
            var Input = Console.ReadLine();
            Console.WriteLine(Parser.PrettyParse(Input)); //random för att få unitTests att funka, de krävs en static main.

        }

    }   
}
 