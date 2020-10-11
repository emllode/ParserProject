using System;


/* TODO 
 * Få en string input T.ex: "two plus two" och översätta till både integers samt operator och sedan skriva ut vad summan blir.
 * Skapa UnitTests som ger "godkänt" när man har lyckats fixa ihop tillräcklig med kod för att få det att fungera.
 * */

namespace TeamProject
{

   public static class Program
    { 


         public static string PrettyParse(string text)
         {
        return $"{text} = {Parse(text)}";
         }

    
        public static double Parse(string text) //Startar med att skapa en metod som returnerar 0, sedan skapar vi X antal tests och startar kodningen därefter.
        {
            return 0;
        }

    }   
}
 