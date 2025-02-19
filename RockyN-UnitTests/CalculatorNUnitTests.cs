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

        //[Test]
        //[TestCase(1)]
        //[TestCase(3)]
        //[TestCase(5)]
        //public void IsOdd_WhenValueIsOdd_ReturnsTrue(int value)
        //{
        //    // Arrange
        //    var calculator = new Calculator();
        //    // Act
        //    bool result = calculator.IsOdd(value);
        //    // Assert
        //    Assert.That(result, Is.True);
        //}

        //[Test]
        //[TestCase(2)]
        //[TestCase(4)]

        //public void IsOdd_WhenValueIsEven_ReturnsFalse(int value)
        //{
        //    // Arrange
        //    var calculator = new Calculator();
        //    // Act
        //    bool result = calculator.IsOdd(value);
        //    // Assert
        //    Assert.That(result, Is.False);
        //}

        // writing a siggle test for the IsOdd method
        [Test]
        [TestCase(3, ExpectedResult = true)]
        [TestCase(4, ExpectedResult = false)]
        public bool IsOdd_Input_ReturnsTrue(int value)
        {
            // Arrange
            var calculator = new Calculator();
            // Act
            return calculator.IsOdd(value);
        }
    }
}
