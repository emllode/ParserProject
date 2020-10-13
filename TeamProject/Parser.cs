using System;
using System.Collections.Generic;
using System.ComponentModel;
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


        // Gör klass för token vilket är varje ord i en string. Därefter behöver vi även göra sub-klasser för både operatören samt siffrorna/values. - > Inheritance (OOP)
        // Behöver även skapa en loop som går genom stringen för att få ut varje token, lättast är nog split function med parse strings. (Behövs googla/youtuba)

        class Token
        {
            string token;
            public Token(string text) //Förklarar vad token är, dvs stringen/texten.
            {
                token = text;
            }
        }       
        
        class Operator : Token  //Vill få ut plus och minus o så fall låta de vara kvar.
        {   
            public  Operator(string text) : base(text) { }
            
            public bool OperatorFigureOut(string text) //Switch statement för att kunna slänga in flera cases om ifall den skall utvecklas.
            {
                switch (text)
                {
                    case "plus":
                    case "minus":
                        return true;
                    default:
                        return false;

                }
            }

            class Value : Token //Går genom 1 - 10 och ändrar om från string till nummer.
            {
                public double value;

                public Value(string text) : base(text)
                {
                    switch(text)
                    {
                        case "one":
                            value = 1;
                            break;
                        case "two":
                            value = 2;
                            break;
                        case "three":
                            value = 3;
                            break;
                        case "four":
                            value = 4;
                            break;
                        case "five":
                            value = 5;
                            break;
                        case "six":
                            value = 6;
                            break;
                        case "seven":
                            value = 7;
                            break;
                        case "eight":
                            value = 8;
                            break;
                        case "nine":
                            value = 9;
                            break;
                        case "ten":
                            value = 10;
                            break;

                        default:
                            throw new Exception();
                    }
                }
            }        
        }
    }
}

