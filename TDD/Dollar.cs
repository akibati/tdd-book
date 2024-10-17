namespace TDD
{
    public class Dollar
    {
        public int _amount;

        public Dollar(int amount)
        {
            _amount = amount;
        }

        public int Amount
        {
            get { return _amount; }
        }

        public Dollar Times(int multiplier)
        {
            return new Dollar(_amount * multiplier);
        }

        public new Boolean Equals(Object obj)
        {
            Dollar dollar = (Dollar)obj;
            return _amount == dollar.Amount;
        }
    }
}
