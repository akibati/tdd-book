namespace TDD
{
    public class Money
    {
        protected int _amount;

        public int Amount
        {
            get { return _amount; }
        }

        public override Boolean Equals(Object? obj)
        {
            if (obj is Money money)
            {
                return _amount == money.Amount;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return _amount.GetHashCode();
        }
    }
}
