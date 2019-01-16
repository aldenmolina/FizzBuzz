using System;
using Xunit;

namespace FizzBuzz.Tests
{
    public class FizzBuzzTests
    {
        [Fact]
        public void Get_Returns_1_for_1()
        {
            //Arrange
            FizzBuzz underTest = new FizzBuzz();

            //Act
            string result = underTest.Get(1);

            //Assert
            Assert.Equal("1", result);
        }
    }
}
