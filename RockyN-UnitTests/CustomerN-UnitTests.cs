using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rocky
{
    [TestFixture]
    public class CustomerN_UnitTests
    {
        [Test]
        [TestCase("Rocky", "Balboa", ExpectedResult = "Hi Rocky Balboa")]
        [TestCase("Tom", "Jerry", ExpectedResult = "Hi Tom Jerry")]
        [TestCase("Tom", "", ExpectedResult = "Hi Tom ")]
        public string GreetAndCombineNames_WhenCalled_ReturnsGreetedFullName(string firstName, string lastName)
        {
            // Arrange
            var customer = new Customer();
            // Act
            customer.GreetAndCombineNames(firstName, lastName);
            // Assert
            return customer.GreetMessage;
        }


        [Test]
        [TestCase("Rocky", "Balboa")]
        [TestCase("Tom", "Jerry")]
        public void GreetAndCombineNames_WhenCalled_ReturnsFullNameWithNecessaryThings(string firstName, string lastName)
        {
            // Arrange
            var customer = new Customer();
            // Act
            customer.GreetAndCombineNames(firstName, lastName);
            // Assert
            Assert.That(customer.GreetMessage.Split().Length, Is.EqualTo(3));
            Assert.That(customer.GreetMessage, Does.Contain("Hi").IgnoreCase);
            Assert.That(customer.GreetMessage, Does.StartWith("Hi"));
            Assert.That(customer.GreetMessage, Does.EndWith(lastName));

        }

        [Test]
        public void CheckIfCustomerGreetMessageIsNotNull()
        {
            // Arrange
            var customer = new Customer();
            // Assert
            Assert.ByVal(customer.GreetMessage, Is.Null);
        }
    }


}
