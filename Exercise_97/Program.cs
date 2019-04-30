using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_97
{
    class Program
    {
        static void Main(string[] args)
        {
            //Concatenate three strings.

            string str1 = "Coding in C# ";
            string str2 = "is fun ";
            string str3 = "but I might like Python more.";
            string str4 = str1 + str2 + str3;
            Console.WriteLine(str4);

            //Convert a string to uppercase.
            Console.WriteLine("\n What is your favorite language?");
            string ans = Console.ReadLine();
            string upper = ans.ToUpper();

            //Create a Stringbuilder and build a paragraph of text, one sentence at a time.
            StringBuilder sb = new StringBuilder(str4);
            sb.Append(" However, I'm also interested in Typescript. ");
            sb.Append(" I think I plan on learning that after this program");
            sb.Replace("Python", upper);

            string para = sb.ToString();
            Console.WriteLine(para);
            Console.ReadLine();
            
        }
    }
}
