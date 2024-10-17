namespace TDD
{
    public class Franc
    {
        private readonly int _amount;

        public Franc(int amount)
        {
            _amount = amount;
        }

        public int Amount
        {
            get { return _amount; }
        }

        public Franc Times(int multiplier)
        {
            return new Franc(_amount * multiplier);
        }

        public override Boolean Equals(Object? obj)
        {
            if (obj is Franc franc)
            {
                return _amount == franc.Amount;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return _amount.GetHashCode();
        }
    }
}
