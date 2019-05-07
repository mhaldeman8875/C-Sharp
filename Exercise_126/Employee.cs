using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_126
{
    class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            base.SayName();
        }
        public void Quit()
        {
            Console.WriteLine("Ur cool. Press enter to quit.");
            Console.ReadLine();
        }
    }
}
