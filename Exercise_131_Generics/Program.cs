using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_131_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate an Employee object with type "string" as its generic parameter.Assign a list of strings as the property value of Things.

            Employee<string> employee = new Employee<string>() { things = new List<string> { "Maddy Haldeman", "Gian Lazzarini", "Maazy Haldeman", "Mike Haldeman", "Eryn Huntington", "Leo Lazzarini" } };

            // Instantiate an Employee object with type "int" as its generic parameter. Assign a list of integers as the property value of Things.
            Employee<int> employeeInt = new Employee<int>() { things = new List<int>() { 101, 201, 101, 000, 123, 123 } };

            // call the function that runs a loop to print both lists
            Console.WriteLine("Employees:\n");
            employee.print();
            Console.WriteLine("\n\nCorresponding Job IDs:\n");
            employeeInt.print();
            Console.ReadLine();
        }
    }
}




