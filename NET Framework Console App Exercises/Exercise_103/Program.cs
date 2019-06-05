using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_103
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a one - dimensional Array of strings.Ask the user to input some text.Create a loop that goes through each string in the Array, adding the user’s text to the string.Then create a loop that prints off each string in the Array on a separate line.
            Console.WriteLine("Enter your first name");
            string input1 = Console.ReadLine();
            string[] stringArray = { "Hey", "What are you doing", "Want to grab coffee", "Let's go to lunch" };
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine(stringArray[i] + " " + input1);
            }

            //Create an infinite loop.
            //int number = 1;
            //while(true)
            //{
            //    Console.WriteLine(number);
            //    if (Console.KeyAvailable)
            //    {
            //        break;
            //    }
            //}

            //Create a loop where the comparison used to determine whether to continue iterating the loop is a “<” operator.
            Console.WriteLine("\nEnter a number");
            string str = Console.ReadLine();
            int input2 = Convert.ToInt32(str);
            int[] numbers = new int[input2];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i;
                Console.WriteLine(i);
            }

            //5.Create a loop where the comparison used to determine whether to continue iterating the loop is a “<=” operator.
            Console.WriteLine("\nEnter another number");
            string str2 = Console.ReadLine();
            int input3 = Convert.ToInt32(str2);
            int[] numbers2 = new int[input3];
            for (int i = 0; i < numbers2.Length; i++)
            {
                if (i <= 50)
                {
                    numbers2[i] = i;
                    Console.WriteLine(i);
                }
            }


            //6.Create a List of strings where each item in the list is unique.Ask the user to select text to search for in the List.Create a loop that iterates through the list and then displays the index of the array that contains matching text on the screen.
            List<string> Movies = new List<string>() { "Kill Bill", "Pulp Fiction", "Django Unchained", "The Hateful Eight", "Reservoir Dogs" };

            Console.WriteLine("\nSearch for a Quentin Tarantino film:");
            string query = Console.ReadLine();
            int idx = Movies.IndexOf(query);
            //Console.WriteLine("index of " + query + ": " + idx);
            //for (int i=0; i<Movies.Count; i++)
            //{
            //    if(Movies.Contains(query))
            //    {
            //        int idx = Movies.IndexOf(query);
            //        Console.WriteLine("index of " + query + ": " + idx);
            //    }
            //}
            if (!Movies.Contains(query))
            {
                Console.WriteLine("Sorry, that movie isn't in our library!\n");
            }
            else
            {
                Console.WriteLine("Index of " + query + ": " + idx + "\n");
            }

            //9.Create a List of strings that has at least two identical strings in the List. Ask the user to select text to search for in the List.
            // Create a loop that iterates through the list and then displays the indices of the array that contain matching text on the screen.
            //10.Add code to that above loop that tells a user if they put in text that isn’t in the List.
            List<string> Random = new List<string>()
            { "Maddy","corgi","Haldeman","Mike","C#","Tech",
                "Academy" ,"Code","Haldeman"};

            Console.WriteLine("\n\nHere's a list of strings \n" + String.Join(", ", Random));
            for (var k = 0; k < Random.Count; k++)
            {
                Console.WriteLine("\nEnter any string to find out it's index:");
                string search = Convert.ToString(Console.ReadLine());
                int result = Random.IndexOf(search);

                if (result >= 0)
                {
                    if (search == "Haldeman")
                    {
                        var duplicates = Random
                                .Select((x, index) => new { search = x, index })
                                .Where(x => (Random
                                                .GroupBy(data => data)
                                                .Where(g => g.Count() > 1)
                                                .Select(g => g.Key).ToList()
                                              ).Contains(x.search));
                        Console.WriteLine("There are duplicates of that value in this list! Their indices are:\n");
                        foreach (var group in duplicates)
                        {
                            Console.WriteLine(group.index);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Search Result is at index " + result);
                        break;
                    }
                }

                else
                {
                    Console.WriteLine("String is not in list\n");
                    break;
                }

            }


            //11.Create a List of strings that has at least two identical strings in the List. Create a foreach loop that evaluates each item in the list, and displays a message showing the string and whether or not it has already appeared in the list.
            List<string> strList = new List<string>()
            { "dog","cat","dog","lizard","hippo"};
            Console.WriteLine("\n\n");
            foreach (string check in strList)
            {
                if (check.Contains("dog"))
                {
                    Console.WriteLine(check + " has already appeard in this list");
                }
                else
                {
                    Console.WriteLine(check + " has not appeared in the list before");
                }


            }
            Console.ReadLine();
        }
    }
}
