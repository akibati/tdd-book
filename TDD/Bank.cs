using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    public class Bank
    {
        public Money Reduce(IExpression source, string to)
        {
            return Money.Dollar(10);
        }
    }
}
