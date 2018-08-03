using System;
using NUnit.Framework;

namespace FizzBuzz.Library.Tests
{
    [Test Fixture]
    public class FizzBuzzerTests
    {
        [Test]
        public void Buzzer_When1_returns1();
        {
            // Arrange
            int input = 1;

            // Act
            FizzBuzzer.GetValue(input);

            // Assert
        }
    }
}
