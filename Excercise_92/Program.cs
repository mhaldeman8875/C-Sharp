using System;


namespace Excercise_92
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express.Please follow the instructions below: \n");

            //The user must then be prompted for the package weight.

            Console.WriteLine("Enter the package weight: ");
            string strWeight = Console.ReadLine();
            int weight = Convert.ToInt32(strWeight);

            if (weight > 50)
            {
                //If the weight is greater than 50, display the error message. At this point the program would end.

                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
            }
            else if (weight <= 50)

            {
                //The user must then be prompted for the package width.

                Console.WriteLine("\nEnter the package width: (inches)");
                string strWidth = Console.ReadLine();
                decimal width = Convert.ToDecimal(strWidth);

                //Then the package height.

                Console.WriteLine("\nEnter the package height: (inches)");
                string strHeight = Console.ReadLine();
                decimal height = Convert.ToDecimal(strHeight);

                //Then the package length.

                Console.WriteLine("\nEnter the package length: (inches)");
                string strLength = Console.ReadLine();
                decimal length = Convert.ToDecimal(strLength);

                if (width + height + length > 50)
                {
                    //If the sum of the dimensions is greater than 50, display the error message. At this point the program would end.

                    Console.WriteLine("\nPackage too big to be shipped via Package Express.");
                    Console.ReadLine();
                }
                else
                {
                    //The sum total of dimensions are then multiplied by the weight and divided by 100.

                    decimal sum = width + height + length;
                    decimal quote = sum / 100;

                    //The result of that calculation is the quote.

                    //Display the quote to the user as a dollar amount.

                    Console.WriteLine("\nYour shipping quote is: $" + quote);
                    Console.ReadLine();
                }
            }

        }
    }
}
