using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_115
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();
            Console.Write("Enter a number: ");
            int required = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter another number OR hit the enter key to skip this step: ");
            string input = Console.ReadLine();
            int optional;

            if (int.TryParse(input, out optional))
            {
                optional = Convert.ToInt32(input);
                int returns = math.operation(required, optional);
                Console.WriteLine(required + " / " + optional + " = " + returns);
            }
            else
            {
                int returns = math.operation(required);
                Console.WriteLine(required + " / 10 = " + returns);
            }

            Console.ReadLine();
        }
    }
}
