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
            five.Times(2);
            Assert.That(five._amount, Is.EqualTo(10));
        }
    }
}