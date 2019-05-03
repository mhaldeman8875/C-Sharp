using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_115
{
    class Math
    {
        public int operation(int required, int optional = 10)
        {
            int result = required / optional;
            return result;
        }
    }
}
