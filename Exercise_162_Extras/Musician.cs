using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_162_Extras
{
    public class Musician
    {
        public string name { get; set; }
        public string genre { get; set; }
        public Musician(string Name, string Genre)
        {
            name = Name;
            genre = Genre;
        }
        public Musician(string Genre) : this("Lucii", Genre)
        {
        }
        public Musician() : this("Dr. Fresch", "House")
        {
        }
    }
}
