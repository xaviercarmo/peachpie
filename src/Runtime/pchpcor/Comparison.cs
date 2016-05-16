﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pchp.Core
{
    /// <summary>
    /// PHP comparison semantic.
    /// </summary>
    public static class Comparison
    {
        public static bool Clt(long lx, double dy) => (double)lx < dy;
        public static bool Cgt(long lx, double dy) => (double)lx > dy;
        public static bool Ceq(long lx, double dy) => (double)lx == dy;

        public static bool Ceq(long lx, bool by) => (lx != 0) == by;

        public static int Compare(long lx, PhpValue y) => Compare(PhpValue.Create(lx), y);

        public static int Compare(PhpValue x, PhpValue y) => Compare(x, y, false);

        public static int Compare(PhpValue x, PhpValue y, bool throws)
        {
            throw new NotImplementedException($"Compare({x.TypeCode}, {y.TypeCode})");
        }
    }
}
