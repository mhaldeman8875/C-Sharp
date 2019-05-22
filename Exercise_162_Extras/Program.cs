using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_162_Extras
{
    class Program
    {
        static void Main(string[] args)
        {
            // create constant variable
            const string constant = "This is a constant variable that cannot be changed\n\n";
            Console.WriteLine(constant);

            // create a variable using the keyword var AND chain two constructors together
            var musicians = new List<Musician>
            {
                new Musician ("Liquid Stranger", "Freeform Bass"),
                new Musician ("Alien Bass"),
                new Musician (),
            };

            foreach (Musician musician in musicians)
            {
                Console.WriteLine("Name: {0} \nGenre: {1}\n", musician.name, musician.genre);
            }

            Console.ReadLine();
        }
    }
}
