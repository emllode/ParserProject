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
 * - Gör Tokens där du använder inheritance för bryta ner till sub-tokens för operatör samt siffror. (OOP) ---- > CHECK
 * - Få datorn att förstå att + och - är operatörer och resten är sifffror/values.  ---- >  1/2
 * -  Lägg ihop Tokens och få ut ett svar T.ex: "two plus two" och svaret i console blir: " 4 "   ---- >  1/2
 * Skapa UnitTests som ger "godkänt" när man har lyckats fixa ihop tillräcklig med kod för att få det att fungera.  ---- > 
 * */
{
    public static class Parser

        
    {
        public static string PrettyParse(string text) //Ger ut lite resultat på consolen direkt copy av Björns intro. 
        {
            return $"{text} = {Parse(text)}";
        }

    
        public static double Parse(string text)
        {

            var tokens = new List<Token>();
            foreach (string word in text.Split(" "))
            {
                if (Operator.OperatorFigureOut(word))  //Vi får reda på ifall de är en operator eller siffra.
                    tokens.Add(new Operator(word));
                else
                    tokens.Add(new Value(word));
            }
            var results = 0;
            for (int i = 1; i < tokens.Count; i++)
            {
                Token First = tokens[0]; //första loop ger första value (först
                Token Second = tokens[1]; //skall vara operatör (andra loop)
                Token Third = tokens[2]; //value (tredje loop)

     
                /*if (First is Value && Second is Operator && Third is Value)
                {
                    if (Operator == "plus")
                    {
                        results = Value + Value;
                    }
                    else if (Operator == "minus")
                    {
                        results = Value - Value;
                    }
                    else
                        return 0;
                
                   //Calculate Value + Value or Value - Value, beroende på om operatören är plus eller minus
                } */
            }
            return results; //Programmet funkar tack vare detta.
        }


         class Token
        {
            public string token;
            public Token(string text) //Förklarar vad token är, dvs stringen/texten.
            {
                token = text;
            }
        }

        class Operator : Token  //Får ut plus samt minus från token.
        {
            public Token First, Third;
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
            public double Equate() //få ihop ett resultat som lägger ihop Values antigen plus eller minus.
            {
                if (OperatorFigureOut = "plus") //plus
                {   
                    return (First as Value).value + (Third as Value).value;
                }
                else if(OperatorFigureOut = "minus") // minus
                {
                    return (First as Value).value - (Third as Value).value;
                }
                return 0;
            }

                

        }
        class Value : Token //Går genom 1 - 10 och ändrar om från string till nummer i token.
        {
            public double value;

            public Value(string text) : base(text)
            {
                switch (text)
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


