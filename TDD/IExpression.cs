using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    public interface IExpression
    {
        IExpression Times(int multiplier);
        IExpression Plus(IExpression addend);
        Money Reduce(Bank bank, string to);
    }
}
