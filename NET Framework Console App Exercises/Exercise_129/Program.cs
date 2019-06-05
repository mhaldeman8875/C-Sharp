using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_129
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Overload the "==" operator so it checks if two Employee objects are equal by comparing their Id property.

            Console.WriteLine("This program will let you enter some information about two employees and notify you with either 'true' if they have the same job id number and 'false' if not. \n Press ENTER to continue\n");
            Console.ReadLine();


            // have user enter values for first employee
            Console.Write("Enter an employee's first name: ");
            string FirstName = Console.ReadLine();
            Console.Write("Enter an employee's last name: ");
            string LastName = Console.ReadLine();
            Console.Write("Enter a number for the employee's job code: ");
            int JobID = Convert.ToInt32(Console.ReadLine());

            // have user enter values for second employee
            Console.Write("\n\nEnter an employee's first name: ");
            string FirstName2 = Console.ReadLine();
            Console.Write("Enter an employee's last name: ");
            string LastName2 = Console.ReadLine();
            Console.Write("Enter a number: ");
            int JobID2 = Convert.ToInt32(Console.ReadLine());

            // instantiate
            Employee employee = new Employee() { FirstName = FirstName, LastName = LastName, JobID = JobID };
            Employee employee2 = new Employee() { FirstName = FirstName2, LastName = LastName2, JobID = JobID2 };

            // print true or false depending on if the ID's match
            Console.WriteLine("\n" + Convert.ToString(employee == employee2));
            Console.ReadLine();
        }
    }
}
