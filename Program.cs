using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();
            string message = MakeGreeting(name);
            Console.WriteLine(message);

            Console.WriteLine("Enter your last name");
            string lastName = Console.ReadLine();
            FullName(name, lastName, out string fullname);
            Console.WriteLine("Your full name is " + fullname);


            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
        static string MakeGreeting(string name)
        {
            return "hello " + name + "!ame!";
        }
        static void FullName(string firstName, string lastName, out string fullName)
        {
            fullName = firstName + " " + lastName;
        }
    }
}
