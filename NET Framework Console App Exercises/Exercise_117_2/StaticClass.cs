using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_117_2
{
    // Declare a class to be static.
    static class StaticClass
    {
        // create static method
        public static int ops(int input2)
        {
            int returns = input2 * 15;
            return returns;
        }
        // overload static method 
        public static int ops(int input2, int returns)
        {
            int result = returns / input2;
            return result;
        }
    }
}
