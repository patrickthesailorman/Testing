using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Library.Tests
{
    [Test Fixture]
    public class FizzBuzzerTests
    {
        [Test]
        public void Buzzer_WhenDefault_ReturnsInput([Values(1, 2, 4, 7, 8, 11, 13, 14)] int input)
        {
            // Arrange
            
            // Act
            string output = FizzBuzzer.GetValue(input);
            // Assert
            Assert.AreEqual(input.ToString(), output);
        }

        [Test]
        public void Buzzer_WhenDiv3_ReturnsFizz([Values(3, 6, 9, 12)] int input)
        {
            // Arrange
            // int input = 3;
            // Act
            string output = FizzBuzzer.GetValue(input);
            // Assert
            Assert.AreEqual("Fizz", output);
        }
        [Test]
        public void Buzzer_When5_ReturnsBuzz([Values(5, 10)] int input)
        {
            // Arrange
            // int input = 5;
            // Act
            string output = FizzBuzzer.GetValue(input);
            // Assert
            Assert.AreEqual("Buzz", output);
        }
    }
}
