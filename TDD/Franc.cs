namespace TDD
{
    public class Franc : Money
    {
        public Franc(int amount, string currency) : base(amount, currency) { }

        public override Franc Times(int multiplier)
        {
            return new Franc(_amount * multiplier, _currency);
        }
    }
}
