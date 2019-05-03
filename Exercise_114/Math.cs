using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_114
{
    class Math
    {
        //  method that takes an integer and finds out if it is even or odd
        public int evenOdd (int input)
        {
            int result = input % 2;

            //if (result == 0)
            //{
            //    Console.WriteLine("This number is even");
            //}
            //else
            //{
            //    Console.WriteLine("This number is odd");
            //}
            return result;
            
        }

        public int evenOdd (int input, decimal dec)
        {
            decimal result = input + dec;
            int resultInt = Decimal.ToInt32(result);
            return resultInt;
        }

        public int evenOdd (string str)
        {
            int resultInt = Convert.ToInt32(str);
            int result = resultInt / 4;
            return result;
        }
    }
}
