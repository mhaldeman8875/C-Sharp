using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_111
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //In the Main() program, ask the user what number they want to do the math operations on.
            Console.WriteLine("Let's do some math! Enter a number below:\n");
            int input = Convert.ToInt32(Console.ReadLine());

            //Call each method in turn, passing the user input to the method.
            Number add = new Number();
            add.Addition(input);
            add.Multiply(input);
            add.Divide(input);

            //Display the returned integer to the screen.
            Console.ReadLine();

        }
    }
}
