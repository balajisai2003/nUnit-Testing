using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rocky
{
    [TestFixture]
    public class CalculatorNUnitTests
    {
        [Test]
        public void AddNumbers_WhenCalled_ReturnsSumOfArguments()
        {
            // Arrange
            var calculator = new Calculator();
            int a = 1;
            int b = 2;
            // Act
            int result = calculator.AddNumbers(a, b);
            // Assert
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void IsOdd_WhenValueIsOdd_ReturnsTrue()
        {
            // Arrange
            var calculator = new Calculator();
            int value = 1;
            // Act
            bool result = calculator.IsOdd(value);
            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsOdd_WhenValueIsEven_ReturnsFalse()
        {
            // Arrange
            var calculator = new Calculator();
            int value = 2;
            // Act
            bool result = calculator.IsOdd(value);
            // Assert
            Assert.That(result, Is.False);
        }
    }
}
