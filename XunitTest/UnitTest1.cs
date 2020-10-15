using System;
using Xunit;
using TeamProject;


namespace XunitTest
{
    public class UnitTest1
    {
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
