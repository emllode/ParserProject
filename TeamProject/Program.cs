using System;

namespace TeamProject
{
    // Skapar separat "main" där vi har bör fixa en main som kan lösa UniTests.
   public static class Program
    { 

        static void Main(string[] args)
        {
            Console.WriteLine(Parser.PrettyParse("text"));
        }

    }   
}
 