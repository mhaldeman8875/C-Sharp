using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_165_ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Ask the user for his age.
            Console.Write("Hey there! Please enter your age to continue: ");
            
            // create while loop to give the user the option to try again
            bool tryAgain = true;
            while(tryAgain == true)
            {
                // create try catch block for exception handling
                try
                {
                    bool tryThis = int.TryParse(Console.ReadLine(), out int input);
                    while (tryThis)
                    {
                        if (input > 0)
                        {
                            // Display the year user born
                            DateTime today = DateTime.Today;
                            DateTime dob = today.AddYears(-(input += 1));
                            Console.WriteLine("You were born in {0}", dob.Year);
                            break;

                        }
                        // if input is a neg number create new instance of Age exception
                        else if (input <= 0)
                        {
                            throw new Age();
                        }
                    }
                    // creates new exceptions every time the users input cannot be parsed into an int
                    while (!tryThis)
                    {
                        throw new Exception();
                    }

                    // Close the while loop because there are no exceptions
                    tryAgain = false;
                }
                catch (Age)
                {
                    Console.WriteLine("You entered a negative number. Please try again.");
                }
                catch (Exception)
                {
                    Console.WriteLine("You did something wrong. Try again using only whole numbers.");
                }
            }
            Console.Write("\nClick \"enter\" to exit program");
            Console.ReadLine();

        }
    }
}
