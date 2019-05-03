using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_113
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate Math class
            Math Math = new Math();

            // Create two local variables from user input
            Console.WriteLine("Enter a number:\n");
            int first = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n\nEnter another number:\n");
            int second = Convert.ToInt32(Console.ReadLine());

            // Call the METHOD in the CLASS, passing in user input and specifying the parameters by name
            Math.integers(first: first, second: second);

            Console.ReadLine();
        }
    }
}
