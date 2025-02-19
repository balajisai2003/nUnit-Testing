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


        [Test]
        [TestCase(5.4, 10.5, ExpectedResult = 15.9)]
        [TestCase(5.1, 10.5, ExpectedResult = 15.6)]

        public double AddNumbersDouble_WhenCalled_ReturnsSumOfArguments(double a, double b)
        {
            // Arrange
            var calculator = new Calculator();
            // Act
            double result = calculator.AddNumbersDouble(a, b);
            // Assert
            return result;
        }


        [Test]
        [TestCase(1, 10, new int[] { 1, 3, 5, 7, 9 })]
        [TestCase(1, 5, new int[] { 1, 3, 5 })]
        public void GetOddRange_WhenCalled_ReturnsOddNumbersInRange(int min, int max, int[] expectedResult)
        {
            // Arrange
            var calculator = new Calculator();
            // Act
            List<int> result = calculator.GetOddRange(min, max);
            // Assert
            Assert.That(result, Is.EquivalentTo(expectedResult));
        }
    }
}
