using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DemoLibrary.Tests
{
    public class DisplayMessagesTests
    {
        [Fact]
        public void GreetingShouldGoodMorningMessage()
        {
            //Arrange
            DisplayMessages messages = new DisplayMessages();
            string expected = "Good morning Pat";

            //Act
            string actual = messages.Greeting("Pat", 2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GreetingShouldGoodAfternoonMessage()
        {
            //Arrange
            DisplayMessages messages = new DisplayMessages();
            string expected = "Good afternoon Pat";

            //Act
            string actual = messages.Greeting("Pat", 14);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Pat", 5, "Good morning Pat")]
        [InlineData("Pat", 6, "Good morning Pat")]
        [InlineData("Pat", 7, "Good morning Pat")]
        [InlineData("Pat", 8, "Good morning Pat")]
        [InlineData("Pat", 9, "Good morning Pat")]
        [InlineData("Pat", 10, "Good morning Pat")]
        [InlineData("Pat", 11, "Good morning Pat")]
        [InlineData("Pat", 12, "Good afternoon Pat")]
        [InlineData("Pat", 13, "Good afternoon Pat")]
        [InlineData("Pat", 14, "Good afternoon Pat")]
        [InlineData("Pat", 15, "Good afternoon Pat")]
        [InlineData("Pat", 16, "Good afternoon Pat")]
        [InlineData("Pat", 17, "Good afternoon Pat")]
        [InlineData("Pat", 18, "Good evening Pat")]
        [InlineData("Pat", 19, "Good evening Pat")]
        [InlineData("Pat", 20, "Good evening Pat")]
        [InlineData("Pat", 21, "Good evening Pat")]
        [InlineData("Pat", 22, "Good evening Pat")]
        [InlineData("Pat", 23, "Good evening Pat")]

        public void GreetingShouldReturnExpectedValue(string firstName, int hourOfTheDay, string expected)
        {
            //Arrange
            DisplayMessages messages = new DisplayMessages();

            //Act
            string actual = messages.Greeting(firstName, hourOfTheDay);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
