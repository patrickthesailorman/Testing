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
        }
    }
}
