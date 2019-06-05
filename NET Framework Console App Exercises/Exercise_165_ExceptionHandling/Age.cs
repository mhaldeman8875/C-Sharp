using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_165_ExceptionHandling
{
    public class Age : Exception
    {
        // create constructor for specific exception that is triggered when the user inputs a negative number
        public Age()
            : base() { } 
    }
}
