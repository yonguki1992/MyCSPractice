using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceEx
{
    public class DerivedA : PureBase
    {
        private int no = 1;

        public override int GetFirst()
        {
            return no;
        }

        public override int GetNext()
        {
            return ++no;
        }
    }
}
