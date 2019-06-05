using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_156_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print the current date and time to the console using the System.DateTime struct
            DateTime now = DateTime.Now;
            Console.WriteLine("The current date and time is {0}", now);

            // Ask user for a number
            Console.Write("\nEnter a number to determine what the time will be in that many hours: ");
            string input = Console.ReadLine();

            // reformat string so it can be parsed into hours 
            string reformatted = input + ":00";

            // create TimeSpan struct by parsinng reformatted string into hours
            TimeSpan ts = TimeSpan.Parse(reformatted);

            // Use DateTime.Add(TimeSpan value) to add to original time and print to console
            Console.WriteLine(now.Add(ts));

            Console.ReadLine();

        }
    }
}
