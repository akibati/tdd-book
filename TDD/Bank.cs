using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    public class Bank
    {
        private Dictionary<Pair, int> rates = [];

        public Money Reduce(IExpression source, string to)
        {
            return source.Reduce(this, to);
        }

        public void AddRate(string from, string to, int rate)
        {
            rates.Add(new Pair(from, to), rate);
        }

        public int Rate(string from, string to)
        {
            if (from.Equals(to)) return 1;
            return rates.TryGetValue(new Pair(from, to), out int rate) ? rate : 1;
        }
    }
}
