﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    public interface IExpression
    {
        Money Reduce(string to);
    }
}
