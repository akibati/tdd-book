namespace TDD
{
    public abstract class Money
    {
        protected int _amount;
        public abstract Money Times(int multiplier);

        public int Amount
        {
            get { return _amount; }
        }

        public override Boolean Equals(Object? obj)
        {
            if (obj is Money money)
            {
                return _amount == money.Amount && GetType() == money.GetType();
            }
            return false;
        }

        public override int GetHashCode()
        {
            return _amount.GetHashCode();
        }

        public static Money Dollar(int amount)
        {
            return new Dollar(amount);
        }

        public static Money Franc(int amount)
        {
            return new Franc(amount);
        }
    }
}
