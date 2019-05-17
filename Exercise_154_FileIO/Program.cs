using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercise_154_FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            // ask a user for a number
            Console.WriteLine("Please enter a number:\n");
            string input = Console.ReadLine();

            //Log that number to a text file
            File.WriteAllText(@"C:\Users\madel\Desktop\c-sharp\C-Sharp\Logs\log3.txt", input);

            //. Print the text file back to the user.
            string read = File.ReadAllText(@"C:\Users\madel\Desktop\c-sharp\C-Sharp\Logs\log3.txt");
            Console.WriteLine("You just successfully logged the number {0}", read);

            Console.WriteLine("Hit enter to quit");
            Console.ReadLine();
        }
    }
}
