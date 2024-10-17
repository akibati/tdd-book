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
            Money five = Money.Dollar(5);
            Assert.That(five.Times(2), Is.EqualTo(Money.Dollar(10)));
            Assert.That(five.Times(3), Is.EqualTo(Money.Dollar(15)));
        }

        [Test]
        public void Equality()
        {
            Assert.That(Money.Dollar(5).Equals(Money.Dollar(5)), Is.True);
            Assert.That(Money.Dollar(5).Equals(Money.Dollar(6)), Is.False);
            Assert.That(Money.Franc(5).Equals(Money.Franc(5)), Is.True);
            Assert.That(Money.Franc(5).Equals(Money.Franc(6)), Is.False);
            Assert.That(Money.Franc(5).Equals(Money.Dollar(5)), Is.False);
        }

        [Test]
        public void FrancMultiplication()
        {
            Money five = Money.Franc(5);
            Assert.That(five.Times(2), Is.EqualTo(Money.Franc(10)));
            Assert.That(five.Times(3), Is.EqualTo(Money.Franc(15)));
        }

        [Test]
        public void Currency()
        {
            Assert.That(Money.Dollar(1).Currency, Is.EqualTo("USD"));
            Assert.That(Money.Franc(1).Currency, Is.EqualTo("CHF"));
        }
    }
}