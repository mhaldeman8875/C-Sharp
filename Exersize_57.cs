using System;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");

            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();

            Console.WriteLine("What page number are you on?");
            string page = Console.ReadLine();
            int intPage = Convert.ToInt32(page);

            Console.WriteLine("Do you need help with anything? (true/false)");
            string help = Console.ReadLine();
            bool boolHelp = Convert.ToBoolean(help);

            Console.WriteLine("Were there any experiences you'd like to share? Please give specifics");
            string exp = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string time = Console.ReadLine();
            int intTime = Convert.ToInt32(time);

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}