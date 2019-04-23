using System;

namespace Exersize_66
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("\nEnter a number greater than zero");
            string strInput1 = Console.ReadLine();
            long input1 = Convert.ToInt64(strInput1);
            long total1 = input1 * 50;
            Console.WriteLine(input1 + " x 50 = " + total1);

            Console.WriteLine("\nEnter another number greater than zero");
            string strInput2 = Console.ReadLine();
            long input2 = Convert.ToInt64(strInput2);
            long total2 = input2 + 25;
            Console.WriteLine(input2 + " + 25 = " + total2);

            Console.WriteLine("\nEnter a number greater than zero that is not a decimal");
            string strInput3 = Console.ReadLine();
            int input3 = Convert.ToInt32(strInput3);
            decimal num1 = 12.5m;
            decimal total3 = input3 / num1;
            Console.WriteLine(input3 + " / 12.5 = " + total3);

            Console.WriteLine("\nEnter another number greater than zero");
            string strInput4 = Console.ReadLine();
            long input4 = Convert.ToInt64(strInput2);
            int num2 = 50;
            if (input4 > num2)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

            Console.WriteLine("\nEnter another number to find the remainder when divided by 7");
            string strInput5 = Console.ReadLine();
            int input5 = Convert.ToInt32(strInput5);
            int num3 = 7;
            decimal total5 = input5 % num3;
            Console.WriteLine(total5);
            Console.ReadLine();

        }
    }
}
