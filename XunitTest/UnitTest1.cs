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
            Assert.Equal(5, TeamProject.Program.PrettyParse("Two plus Three"));  //Första test gällande addition.
        }
    }
}
