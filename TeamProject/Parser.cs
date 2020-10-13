using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.ExceptionServices;
using System.Text;

namespace TeamProject


/* TODO 
 * Få en string input T.ex: "two plus two" och översätta till både integers samt operator och sedan skriva ut vad summan blir.
 * - Vi behöver bryta isär stringen i Tokens, där varje token är ett ord/siffra i stringen.  ---- > CHECK
 * - Få datorn att förstå att + och - är operatörer och resten är sifffror/values.  ---- > 
 * -  Lägg ihop Tokens och få ut ett svar T.ex: "two plus two" och svaret i console blir: " 4 "   ---- > 
 * Skapa UnitTests som ger "godkänt" när man har lyckats fixa ihop tillräcklig med kod för att få det att fungera.  ---- > 
 * */
{
    public static class Parser

    {

        public static double Parse(string text) //Startar med att skapa en metod som returnerar 0, sedan skapar vi X antal tests och startar kodningen därefter.
        {
             //return 0; //används för få metoden att funka.


            var tokens = new List<Token>();
            foreach (var word in text.Split(" "))
            {
                if (Operator.OperatorFigureOut(word))
                    tokens.Add(new Operator(word));
                else
                    tokens.Add(new Value(word));
            }

            for(int i = 1; i < tokens.Count; i++)
            {
                Token First = tokens[0]; //första loop ger första value (första loop)
                Token Second = tokens[1]; //skall vara operatör (andra loop)
                Token third = tokens[2]; //value (tredje loop)

                if(First is Value && Second is Operator && third is Value)
                {
                  // Kan man lägga ihop det redan här? :/ 
                }

                else
                {
                    Console.WriteLine("Please write something as following: two plus two. \nYou can choose between 1 - 10 and plus and minus as your operator.");
                }
            }




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
        
        class Operator : Token  //Får ut plus samt minus från token.
        {   
            public Operator(string text) : base(text) { }
            
            public static bool OperatorFigureOut(string text) //Switch statement för att kunna slänga in flera cases om ifall den skall utvecklas.
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

        }
        class Value : Token //Går genom 1 - 10 och ändrar om från string till nummer i token.
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
                    }
                }
            }        
       
    }
}

