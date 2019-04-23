using System;


namespace Exersize_37
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program \n");

            Console.WriteLine("\nPerson 1:");
            int hr1 = 15;
            int weeklyHours1 = 40;
            int salary1 = hr1 * weeklyHours1 * 52;
            Console.WriteLine("Hourly Rate: " + hr1);
            Console.WriteLine("Hours Worked Per Week: " + weeklyHours1);

            Console.WriteLine("\nPerson 2:");
            int hr2 = 45;
            int weeklyHours2 = 52;
            int salary2 = hr2 * weeklyHours2 * 52;
            Console.WriteLine("Hourly Rate: " + hr2);
            Console.WriteLine("Hours Worked Per Week: " + weeklyHours2);

            Console.WriteLine("\nAnnual Salary of Person 1: " + salary1);
            Console.WriteLine("\nAnnual Salary of Person 2: " + salary2);

            Console.WriteLine("\nDoes Person 1 make more than Person 2? ");
            Console.WriteLine("false");
            Console.ReadLine();



        }
    }
}
