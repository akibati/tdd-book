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
            Assert.That(five.Times(2), Is.EqualTo(new Dollar(10)));
            Assert.That(five.Times(3), Is.EqualTo(new Dollar(15)));
        }

        [Test]
        public void Equality()
        {
            Assert.That(new Dollar(5).Equals(new Dollar(5)), Is.True);
            Assert.That(new Dollar(5).Equals(new Dollar(6)), Is.False);
            Assert.That(new Franc(5).Equals(new Franc(5)), Is.True);
            Assert.That(new Franc(5).Equals(new Franc(6)), Is.False);
        }

        [Test]
        public void FrancMultiplication()
        {
            Franc five = new Franc(5);
            Assert.That(five.Times(2), Is.EqualTo(new Franc(10)));
            Assert.That(five.Times(3), Is.EqualTo(new Franc(15)));
        }
    }
}