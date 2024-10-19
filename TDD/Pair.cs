using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    public class Pair
    {
        private readonly string _from;
        private readonly string _to;

        public Pair(string from, string to)
        {
            _from = from;
            _to = to;
        }

        public override Boolean Equals(Object? obj)
        {
            if (obj is Pair pair)
            {
                return _from.Equals(pair._from) && _to.Equals(pair._to);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return _from.GetHashCode();
        }
    }
}
