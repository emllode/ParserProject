using System;

namespace TeamProject
{
    // Skapar separat "main" där vi har så vi kan få UnitTests att fungera.
   public static class Program
    { 

        static void Main(string[] args)
        {
            Console.WriteLine(Parser.PrettyParse("text")); //random för att få unitTests att funka, de krävs en static main.
        }

    }   
}
 