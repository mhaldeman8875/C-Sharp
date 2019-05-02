using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_106
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of integers.Ask the user for a number to divide each number in the list by.Write a loop that takes each integer in the list, divides it by the number the user entered, and displays the result to the screen.

            // Now put the loop in a try/catch block.Below and outside of the try/catch block, make the program display a message to the display to let you know the program has emerged from the try/catch block and continued on with program execution.In the catch block, display the error message to the screen.Then try various combinations of user input:

            // valid numbers, zero and a string.Ensure the proper error messages display on the screen, and that the code after the try/catch block gets executed.

            try
            {
                List<int> IntList = new List<int>() { 4843, 6987, 8245, 99876, 28, 3947, 56, 12, 45, 38, 94 };
                Console.WriteLine("Enter a number to do some math!\n");
                int entry = Convert.ToInt32(Console.ReadLine());
                
                foreach (var number in IntList)
                {
                    decimal result = number / entry;
                    Console.WriteLine("\n" + result);
                    Console.ReadLine();
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            finally
            {
                Console.ReadLine();
            }
           

        }
    }
}
