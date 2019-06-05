using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_117_2
{
    // Create a class
    public class Math
    {
        // Create a void method that outputs an integer.Have the method divide the data passed to it by 2.
        public void DivideByTwo(int input)
        {
            // cannot return any integer values from a void method, rest of code concerning this method must be here
            int result = input / 2;
            Console.WriteLine("\n      Your number / 2 = " + result);
        }

        public void MultiplyBy12(int input, out int r)
        {
            int result = input * 12;
            r = result;
        }
    }
}
