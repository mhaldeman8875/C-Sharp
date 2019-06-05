using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_100
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an array of strings. Ask the user to select an index of the Array and then display the string at that index on the screen
            string[] stringArray = {"Hey", "what's up?", "dog", "fish"};
            Console.WriteLine("Enter a number between 0 and 3 to select a word from an array and have it returned below!");
            string input = Console.ReadLine();
            int i = Convert.ToInt32(input);
            Console.WriteLine("\n" + stringArray[i]);

            //Create an array of integers.Ask the user to select an index of the Array and then display the integer at that index on the screen.
            int[] intArray = { 23, 15, 67, 20, 2739, 63, 25 };
            Console.WriteLine("Enter a numer to select a number from an array and have it returned below!");
            string input2 = Console.ReadLine();
            int index = Convert.ToInt32(input2);

            //Add in a message that displays when the user selects an index that doesn’t exist.
            if (index > intArray.Length)
            {
                Console.WriteLine("Whoops! The number you entered isn't in range of the index!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\n" + intArray[index]);
            }

            //Create a List of strings.Ask the user to select an index of the List and then display the content at that index on the screen.
            List<string> stringList = new List<string>();
            stringList.Add("My dog is cute");
            stringList.Add("Your dog is cute");
            stringList.Add("Everyone's dogs are cute");
            Console.WriteLine("Enter a number between 0 and 2 to see a message about dogs");
            string input3 = Console.ReadLine();
            int index3 = Convert.ToInt32(input3);
            Console.WriteLine("\n" + stringList[index3]);
            Console.ReadLine();

        }
    }
}
