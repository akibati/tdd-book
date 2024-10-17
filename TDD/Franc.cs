namespace TDD
{
    public class Franc : Money
    {
        public Franc(int amount)
        {
            _amount = amount;
        }

        public override Franc Times(int multiplier)
        {
            return new Franc(_amount * multiplier);
        }
    }
}
