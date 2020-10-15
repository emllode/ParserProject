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
