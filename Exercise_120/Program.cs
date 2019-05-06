using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_120
{
    class Program
    {
        static void Main(string[] args)
        {
            //inside of the Main method instatiate and init an Employee object with a first name "Sample" and last name "student"
            Person person = new Person();
            person.FirstName = "Sample";
            person.LastName = "Student";
            person.SayName();
            Console.ReadLine();

        }
    }
}
