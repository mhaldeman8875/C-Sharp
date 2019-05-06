using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_120
{
    // Employee class must inheret from Person class and has a public property for ID
    public class Employee : Person 
    {
        public int ID { get; set; }
    }
}
