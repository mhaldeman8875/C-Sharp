using System;

namespace Exersize_75
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age?");
            string strAge = Console.ReadLine();
            int age = Convert.ToInt32(strAge);
            //Console.WriteLine(age + "\n");

            Console.WriteLine("Have you ever had a DUI? (true/false)");
            string strDui = Console.ReadLine();
            bool dui = Convert.ToBoolean(strDui);
            //Console.WriteLine(dui + "\n");

            Console.WriteLine("How many tickets do you have?");
            string strTicket = Console.ReadLine();
            int ticket = Convert.ToInt32(strTicket);
            //Console.WriteLine(ticket + "\n");

            Console.WriteLine("Qualified?");
            bool qualified = (age > 15 && dui == false && ticket <= 3);
            Console.WriteLine(qualified);
            Console.ReadLine();
        }
    }
}
