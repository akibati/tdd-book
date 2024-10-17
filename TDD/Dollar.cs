﻿namespace TDD
{
    public class Dollar
    {
        private readonly int _amount;

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

        public override Boolean Equals(Object? obj)
        {
            if (obj is Dollar dollar)
            {
                return _amount == dollar.Amount;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return _amount.GetHashCode();
        }
    }
}
