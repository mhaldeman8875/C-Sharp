using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_111
{
    //Create a class. In that class, create three methods, each of which will take one integer parameter in and return an integer.
    //The methods should do some math operation on the received parameter. Put this class in a separate.cs file in the application.
    class Number
    {

        //Create method that generates random number
        public static int RandomNumber()
        {
            Random random = new Random();
            int r = random.Next(2, 100);
            return r;
        }
        //Create method for adding two numbers
        public int Addition(int input)
        {
            int num2 = RandomNumber();
            int result = input + num2;
            Console.WriteLine(input + " + " + num2 + " = " + result);
            return result;
        }

        //Create method for multiplying two numbers
        public int Multiply(int input)
        {
            int num2 = RandomNumber();
            int result = input * num2;
            Console.WriteLine(input + " * " + num2 + " = " + result);
            return result;
        }

        //Create method for dividing two numbers
        public int Divide(int input)
        {
            int num2 = RandomNumber();
            int result = input / num2;
            Console.WriteLine(input + " / " + num2 + " = " + result);
            return result;
        }
    }
}
