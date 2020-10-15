using System;
using Xunit;
using TeamProject;


namespace XunitTest
{
    public class UnitTest1
    {
        // --- > En beskrivning på en debug NEDANFÖR <---------------

        /* Har gjort samtliga tests nedan, lyckades med två av tre. Det viktigaste var att få till plus samt minus skulle fungera och ifall jag hade tid/ville så skulle jag
         * även utveckla så jag kunde ha en längre string med siffror + operatörer och ge ut svaret. Men jag tänkte att det var bäst att klara av 2 values samt 1 operatör
         * fört. Så jag valde då helt enkelt att köra two plus three samt seven minus two.
         * 
         * En bugg som jag mötte på var att alla inputs multiplicerades med 2. dvs: "two plus two" fick ett svar som 8. Detta löste jag genom att i min kod så stod det först:
         * "results += calculate;" När jag väl tog bort +  så fungerade det utmärkt. Vet inte riktigt vrför den ville multplicera men jag lyckades iaf "debugga" genom att ta bort/lägga
         * enstaka grejer.
         * 
         * 
         * 
         * 
         */
        [Fact]
        public void Plus()
        {
            Assert.Equal(5, Parser.Parse("two plus three"));  //Första test gällande addition. 
        }

        [Fact]
        public void BiggerPlus() // Tänker att man även testar en string som har en längre addition för att se så att vi inte bara får rätt när man har två int och en operator.
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
