using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_126
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            Console.Write("Enter your first name: ");
            employee.FirstName = Console.ReadLine();

            Console.Write("\nEnter your last name: ");
            employee.LastName = Console.ReadLine();

            employee.SayName();

            IQuittable quittable = new Employee();
            quittable.Quit();
            Console.ReadLine();
        }
    }
}
