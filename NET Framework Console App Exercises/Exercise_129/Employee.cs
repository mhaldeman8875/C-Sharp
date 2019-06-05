using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_129
{
    public class Employee
    {
        // copy over code from Person class
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int JobID { get; set; }

        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName + " " + JobID);
        }
        public static bool operator ==(Employee employee, Employee employee2)
        {
            if (employee.JobID == employee2.JobID)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // == operator also needs to have != operator defined
        public static bool operator !=(Employee employee, Employee employee2)
        {
            if (employee.JobID == employee2.JobID)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
