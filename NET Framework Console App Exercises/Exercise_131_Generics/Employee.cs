using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Exercise_131_Generics
{
    // Make Employee class take a generic type parameter
    public class Employee<GenParam>
    {
        // add property called "things" make it a list and match the generic type of class
        public List<GenParam> things;

        // Create a loop that prints all of the Things to the Console
        public void print()
        {
            for (int i = 0; i < things.Count; i++)
            Console.WriteLine(things[i]);
        }
    }
}
