using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_114
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();

            Console.Write("Enter a whole number: ");
            int input = Convert.ToInt32(Console.ReadLine());
            int returns = math.evenOdd(input);
            if (returns == 0)
            {
                Console.WriteLine(input + " is an even number");
            }
            else
            {
                Console.WriteLine(input + " is an odd number");
            }

            Console.Write("\nEnter a decimal: ");
            decimal dec = Convert.ToDecimal(Console.ReadLine());
            int returns2 = math.evenOdd(input, dec);
            if (returns2 % 2 == 0)
            {
                Console.WriteLine(input + " + " + dec + " = " + returns2 + " , which is an even number");
            }
            else
            {
                Console.WriteLine(input + " + " + dec + " = " + returns2 + " , which is an odd number");
            }

            Console.Write("\nFinally, enter one last number: ");
            string str = Console.ReadLine();
            int returns3 = math.evenOdd(str);
            if (returns3 % 2 == 0)
            {
                Console.WriteLine(str + " / 4 = " + returns3 + " , which is an even number");
            }
            else
            {
                Console.WriteLine(str + " / 4 = " + returns3 + " , which is an odd number");
            }

            Console.ReadLine();

        }

    }
}
