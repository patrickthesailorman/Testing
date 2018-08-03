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
        public void Buzzer_When1_returns1();
        {
            // Arrange
            int input = 1;

            // Act
            FizzBuzzer.GetValue(input);

            // Assert
            Assert.AreEqual("1", output);
        }

        [Test]
        public void Buzzer_WhenDefault_ReturnsInput([Values(2)] int input)
        {
            string output = FizzBuzzer.GetValue(input);
            Assert.AreEqual(input.ToString(), output);
        }

        [Test]
        public void Buzzer_When3_ReturnsFizz()
        {
            int input = 3;
            string output = FizzBuzzer.GetValue(input);
            Assert.AreEqual("Fizz", output);
        }
    }
}
