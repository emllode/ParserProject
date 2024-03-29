﻿using System;
using System.Collections.Generic;

namespace TeamProject


/* TODO 
 * Få en string input T.ex: "two plus two" och översätta till både integers samt operator och sedan skriva ut vad summan blir.
 * - Vi behöver bryta isär stringen i Tokens, där varje token är ett ord/siffra i stringen.  ---- > CHECK
 * - Gör Tokens där du använder inheritance för bryta ner till sub-tokens för operatör samt siffror. (OOP) ---- > CHECK
 * - Få datorn att förstå att + och - är operatörer och resten är sifffror/values.  ---- >  CHECK
 * -  Lägg ihop Tokens och få ut ett svar T.ex: "two plus two" och svaret i console blir: " 4 "   ---- >  CHECK
 * Skapa UnitTests som ger "godkänt" när man har lyckats fixa ihop tillräcklig med kod för att få det att fungera.  ---- > CHECK!!
 * */
{
    public static class Parser      
    {
        public static string PrettyParse(string text) //Denna behövs inte längre då jag skrivit egen intro kod till konsollen, men då jag har tagit in denna i min Diagram så behåller jag.
        {
            return $"{text} = {Parse(text)}";
        }

        public static double Parse(string text)
        {
            double result = 0;

            //Tar isär stringen i delar efter varje space.
            var tokens = new List<Token>(); 
            foreach (var word in text.Split(" "))
            {
                if (Operator.OperatorFigureOut(word))  //Vi får reda på ifall de är en operator eller siffra.
                    tokens.Add(new Operator(word)); 
                else
                    tokens.Add(new Value(word));
            }
            //Gör så varje loop ger en Token sitt "namn" samt ifall det sker i en viss ordning så sätts calculate igång.
            for (int i = 1; i < tokens.Count; i++)
            {
                Token First = tokens[0]; //första loop ger första value (först
                Token Second = tokens[1]; //skall vara operatör (andra loop)
                Token Third = tokens[2]; //value (tredje loop) 

                if (First is Value && Second is Operator && Third is Value)
                {
                    Operator op = Second as Operator;
                    op.First = First;
                    op.Third = Third;
                }
             
                foreach (var token in tokens)
                {
                    if (token is Operator)
                    {
                        Operator op = token as Operator;
                        result = op.Calculate();
                    }

                }
           
            }
            return result;
        }
               
           // Allt här nedan skulle man kunna skapa ett eget projekt/klass för i själva projektet och således blir de mindre kod här.

         public class Token
        {
            protected string token;
            public Token(string text) //Förklarar vad token är, dvs stringen/texten.
            {
                token = text;
            }
        }

        class Operator : Token  //Får ut plus samt minus från token.
        {
            public Token First, Third;
            public Operator(string text) : base(text) { }
            public static bool OperatorFigureOut(string text) //Switch statement för få reda på operatören. 
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
            public double Calculate() //Löser ut Value + Value samt Value - Value beroende på operatören.
            {
                if (token == "plus")
                {
                    return (First as Value).value + (Third as Value).value;
                }
                else if (token == "minus")
                {
                    return (First as Value).value - (Third as Value).value;
                }
                else
                   return 0;
            }

        }
         class Value : Token //Går genom 1 - 10 och ändrar om från string till nummer i token.
        {
            public double value;

            public Value(string text) : base(text)
            {
                switch (text) //switch statement för att ändra text siffran till ordentlig siffra. 
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


