using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamespaceEx.subNameSpace
{
    class NamespaceEx2
    {
        public int Calculate(int a, int b)
        {
            int abs_Sum = System.Math.Abs(a) + Math.Abs(b);
            return abs_Sum;
        }
    }
}
