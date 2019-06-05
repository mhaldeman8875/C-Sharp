using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_137_Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an object of data type Number and assign an amount to it
            Number number = new Number() { Amount = 761.82676m };

            // print that number to console
            Console.WriteLine(number.Amount);
            Console.ReadLine();
        }
    }
    //create a struct called number OUTSIDE OF CLASS (because structs are value types)
    struct Number
    {
        //give the property "AMOUNT" as decimal
        public decimal Amount { get; set; }
    }

}