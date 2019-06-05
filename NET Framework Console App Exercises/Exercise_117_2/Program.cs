using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_117_2
{
    class Program
    {

        static void Main(string[] args)
        {
            // In the Math() method, instantiate Math class
            Math equation = new Math();            
            // Have user enter a nummber
            Console.Write("Please enter a whole number: ");
            int input = Convert.ToInt32(Console.ReadLine());
            // Call the method "DivideByTwo" to execute that code
            equation.DivideByTwo(input: input);


            // Call the method that declares and returns an output parameter
            Console.Write("\nPress enter to continue:");
            Console.ReadLine();
            equation.MultiplyBy12(input, out int r);
            Console.WriteLine("     The output of your number * 12 is " + r);


            // DO NOT call static class like above - use actual naming convention to reference Class
            Console.Write("\n\nPlease enter another whole number:");
            int input2 = Convert.ToInt32(Console.ReadLine());
            int returns = StaticClass.ops(input2: input2);
            Console.WriteLine("\n     Your number * 15 = " + returns);
            int result = StaticClass.ops(input2: input2, returns: returns);

            Console.WriteLine("\n     Your number / " + returns + " = " + result);
            Console.ReadLine();
        }

    }
}
