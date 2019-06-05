using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_134_Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. Wrap the above statement in a try/catch block and have it print "Please enter an actual day of the week." to the console if an error occurs.
            Start:
            try
            {
                //2. Prompt the user to enter the current day of the week.
                Console.WriteLine("Please enter the current day of the week: \n");

                //3. Assign the value to a variable of that enum data type you just created.
                string input = Convert.ToString(Console.ReadLine().ToLower());

                // parse enum and user input
                WeekDay weekday = (WeekDay)Enum.Parse(typeof(WeekDay), input);

                Console.WriteLine("Good job! Press enter to quit!");
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("\n\nError! Please enter an actual day of the week!");
                Console.Write("Would you like to retry? Enter \"yes\" to continue or click \"enter\" on your keyboard to quit: ");
                string response = Console.ReadLine();
                if (response == "yes" || response == "Yes" || response == "YES")
                {
                    goto Start;
                }
            }
            


            

            //Note - In the last video, we explained the underlying concepts behinds enums.Nobody knows everything about a programming language and its features, so it's our job as programmers to do research on how to work with various data types, classes and libraries. For this drill, you'll need to do some additional research on how to parse enums.
        }
        //1.Create an enum for the days of the week (put below main method)
        public enum WeekDay
        {
            sunday,
            monday,
            tuesday,
            wednesday,
            thursday,
            friday,
            saturday
        }

    }
}
