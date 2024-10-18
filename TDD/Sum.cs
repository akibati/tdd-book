using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    public class Sum : IExpression
    {
        public Money _augend;
        public Money _addend;

        public Sum(Money augend, Money addend)
        {
            _augend = augend;
            _addend = addend;
        }

        public Money Reduce(string to)
        {
            int amount = _augend.Amount + _addend.Amount;
            return new Money(amount, to);
        }
    }
}
