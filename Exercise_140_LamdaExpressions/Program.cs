using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_140_LamdaExpressions
{
    public class Program
    {
        static void Main(string[] args)
        {
            // In the Main() method, create a list of at least 10 employees. Each employee should have a first and last name, as well as an Id.At least two employees should have the first name "Joe"

            List<Employee> employees = new List<Employee>()
            {
                new Employee { FirstName = "Joe", LastName = "Moe", Id = 01 },
                new Employee { FirstName = "Joeseph", LastName = "Meehan", Id = 02 },
                new Employee { FirstName = "Joery", LastName = "McDaniels", Id = 03 },
                new Employee { FirstName = "Maddy", LastName = "Haldeman", Id = 04 },
                new Employee { FirstName = "Mike", LastName = "Haldeman", Id = 05 },
                new Employee { FirstName = "Jimbo", LastName = "Daniels", Id = 06 },
                new Employee { FirstName = "Gian", LastName = "Lazzarini", Id = 07 },
                new Employee { FirstName = "Leo", LastName = "Lazzarini", Id = 08 },
                new Employee { FirstName = "Joe", LastName = "Smith", Id = 09 },
                new Employee { FirstName = "Jane", LastName = "Doe", Id = 10 }
            };

            // List employees
            Console.WriteLine("Employees: \n");

            foreach (var employee in employees)
            {
                Console.WriteLine("Name: {0} {1} ID: {2}", employee.FirstName, employee.LastName, employee.Id);
            }
            Console.WriteLine("\n\nClick enter to display only employees whose first name contain \"Joe\"\n");

            Console.ReadLine();

            //2.Using a foreach loop, create a new list of all employees with the first name "Joe".
            foreach (var employee in employees)
            { 
                if (employee.FirstName.Contains("Joe"))
                {
                    Console.WriteLine("     Name: {0} {1}", employee.FirstName, employee.LastName);
                    Console.WriteLine("     ID: {0}", employee.Id);
                }
            }

            //3.Do the same thing again, but this time with a lambda expression.
            List<Employee> names = employees.Where(x => x.FirstName == "Joe").ToList();

            Console.WriteLine("\n\nClick \"enter\" to list of all the employees named Joe:\n");
            Console.ReadLine();
            foreach (var name in names)
            {
                Console.WriteLine("     Name: {0} {1}", name.FirstName, name.LastName);
                Console.WriteLine("     ID: {0}\n", name.Id);

            }

            //4.Using a lambda expression, make a list of all employees with an Id number greater than 5.
            List<Employee> nameIDs = employees.Where(a => a.Id > 5).ToList();
            Console.WriteLine("\n\nClick \"enter\" to list of all the employees with an ID greater than 5:\n");
            Console.ReadLine();
            foreach (var name in nameIDs)
            {
                Console.WriteLine("     Name: {0} {1}", name.FirstName, name.LastName);
                Console.WriteLine("     ID: {0}\n", name.Id);

            }

            Console.ReadLine();

        }

    }
 
}
