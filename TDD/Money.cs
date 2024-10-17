namespace TDD
{
    public class Money
    {
        protected int _amount;
        protected string _currency;

        public Money(int amount, string currency)
        {
            _amount = amount;
            _currency = currency;
        }

        public int Amount { get { return _amount; } }
        public string Currency { get { return _currency; } }

        public Money Times(int multiplier)
        {
            return new Money(multiplier * _amount, _currency);
        }

        public override Boolean Equals(Object? obj)
        {
            if (obj is Money money)
            {
                return _amount == money.Amount && _currency.Equals(money.Currency);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return _amount.GetHashCode();
        }

        public static Money Dollar(int amount)
        {
            return new Dollar(amount, "USD");
        }

        public static Money Franc(int amount)
        {
            return new Franc(amount, "CHF");
        }
    }
}
