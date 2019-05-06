using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_120
{
    // create class person
    public class Person
    {
        // create two properties for Person:
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //give class void method
        public void SayName()
        {
            // Print name to console
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
