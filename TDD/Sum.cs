using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    public class Sum : IExpression
    {
        public IExpression _augend;
        public IExpression _addend;

        public Sum(IExpression augend, IExpression addend)
        {
            _augend = augend;
            _addend = addend;
        }

        public IExpression Times(int multiplier)
        {
            return new Sum(_augend.Times(multiplier), _addend.Times(multiplier));
        }

        public IExpression Plus(IExpression addend)
        {
            return new Sum(this, addend);
        }

        public Money Reduce(Bank bank, string to)
        {
            int amount = _augend.Reduce(bank, to).Amount + _addend.Reduce(bank, to).Amount;
            return new Money(amount, to);
        }


    }
}
