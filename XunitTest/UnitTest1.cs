using System;
using Xunit;
using TeamProject;


namespace XunitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Addition()
        {
            Assert.Equal(5, TeamProject.Program.Parse("two plus three"));  //Första test gällande addition. 
        }

        [Fact]
        public void BiggerAddition() // Tänker att man även testar en string som har en längre addition för att se så att vi inte bara får rätt när man har två int och en operator.
        {
            Assert.Equal(15, TeamProject.Program.Parse("five plus five plus five"));
        }
    }
}
