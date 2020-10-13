using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace TeamProject


/* TODO 
 * Få en string input T.ex: "two plus two" och översätta till både integers samt operator och sedan skriva ut vad summan blir.
 * - Vi behöver bryta isär stringen i Tokens, där varje token är ett ord/siffra i stringen.
 * - Få datorn att förstå att + och - är operatörer och resten är sifffror/values.
 * -  Lägg ihop Tokens och få ut ett svar T.ex: "two plus two" och svaret i console blir: " 4 " 
 * Skapa UnitTests som ger "godkänt" när man har lyckats fixa ihop tillräcklig med kod för att få det att fungera.
 * */
{
    public static class Parser
        
    {
        public static string PrettyParse(string text) //Kopierad från Björns lektion, oklart om denna behövs egentligen?
        {
            return $"{text} = {Parse(text)}";
        }


        public static double Parse(string text) //Startar med att skapa en metod som returnerar 0, sedan skapar vi X antal tests och startar kodningen därefter.
        {
            return 0;
        }


        // Gör klass för token vilket är varje ord i en string. Därefter behöver vi även göra så operatörerna plockas ut i token. Antagligen genom inheritance.
        // Behöver även skapa en loop som går genom stringen för att få ut varje token, lättast är nog split function med parse strings. (Behövs googla/youtuba)
        class Token
        {
            string token;
            public Token(string text) //Förklarar vad token är, dvs stringen/texten.
            {
                token = text;
            }
        }
    }
}
