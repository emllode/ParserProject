using System;
using Xunit;
using TeamProject;


namespace XunitTest
{
    public class UnitTest1
    {
        // --- > En beskrivning p� en debug NEDANF�R <---------------

        /* Har gjort samtliga tests nedan, lyckades med tv� av tre. Det viktigaste var att f� till plus samt minus skulle fungera och ifall jag hade tid/ville s� skulle jag
         * �ven utveckla s� jag kunde ha en l�ngre string med siffror + operat�rer och ge ut svaret. Men jag t�nkte att det var b�st att klara av 2 values samt 1 operat�r
         * f�rt. S� jag valde d� helt enkelt att k�ra two plus three samt seven minus two.
         * 
         * En bugg som jag m�tte p� var att alla inputs multiplicerades med 2. dvs: "two plus two" fick ett svar som 8. Detta l�ste jag genom att i min kod s� stod det f�rst:
         * "results += calculate;" N�r jag v�l tog bort +  s� fungerade det utm�rkt. Vet inte riktigt vrf�r den ville multplicera men jag lyckades iaf "debugga" genom att ta bort/l�gga
         * enstaka grejer.
         * 
         * 
         * 
         * 
         */
        [Fact]
        public void Plus()
        {
            Assert.Equal(5, Parser.Parse("two plus three"));  //F�rsta test g�llande addition. 
        }

        [Fact]
        public void BiggerPlus() // T�nker att man �ven testar en string som har en l�ngre addition f�r att se s� att vi inte bara f�r r�tt n�r man har tv� int och en operator.
        {
            Assert.Equal(15, Parser.Parse("five plus five plus five"));
        }

        [Fact]
        public void Minus()
        {
            Assert.Equal(5, Parser.Parse("seven minus two")); //test 
        }

    }

}
