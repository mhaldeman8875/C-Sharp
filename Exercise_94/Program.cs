using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1. Do a boolean comparison using a while statement.

//2. Do a boolean comparison using a do while statement.

namespace Exercise_94
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("guess a letter\n");
            string str = Console.ReadLine();
            bool guessed = str == "e";

            do
            {
                switch (str)
                {
                    case "e":
                        Console.WriteLine("That is correct!");
                        guessed = true;
                        break;
                    default:
                        Console.WriteLine("You are Wrong");
                        Console.WriteLine("Guess a letter");
                        str = Console.ReadLine();
                        break;
                }
            }
            while (!guessed);
            Console.Read();
        }
    }
}
