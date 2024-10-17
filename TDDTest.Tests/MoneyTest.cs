using System.Net.Http.Headers;
using TDD;

namespace TDDTest.Tests
{
    public class MoneyTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Multiplication()
        {
            Dollar five = new Dollar(5);
            Dollar product = five.Times(2);
            Assert.That(product.Amount, Is.EqualTo(10));
            product = five.Times(3);
            Assert.That(product.Amount, Is.EqualTo(15));
        }

        [Test]
        public void Equality()
        {
            Assert.That(new Dollar(5).Equals(new Dollar(5)), Is.True);
            Assert.That(new Dollar(5).Equals(new Dollar(6)), Is.False);
        }
    }
}