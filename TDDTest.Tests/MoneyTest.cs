using System.Linq.Expressions;
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
            Assert.That(Money.Dollar(5).Equals(Money.Dollar(6)), Is.False); ;
            Assert.That(Money.Franc(5).Equals(Money.Dollar(5)), Is.False);
        }

        [Test]
        public void Currency()
        {
            Assert.That(Money.Dollar(1).Currency, Is.EqualTo("USD"));
            Assert.That(Money.Franc(1).Currency, Is.EqualTo("CHF"));
        }

        [Test]
        public void SimpleAddition()
        {
            Money five = Money.Dollar(5);
            IExpression sum = five.Plus(five);
            Bank bank = new Bank();
            Money reduced = bank.Reduce((IExpression)sum, "USD");
            Assert.That(reduced, Is.EqualTo(Money.Dollar(10)));
        }
    }
}