namespace TDD
{
    public class Dollar : Money
    {
        public Dollar(int amount, string currency) : base(amount, currency) { }

        public override Dollar Times(int multiplier)
        {
            return new Dollar(_amount * multiplier, _currency);
        }
    }
}
