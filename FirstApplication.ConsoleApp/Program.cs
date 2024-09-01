using System;
using FirstApplication.ConsoleHelper;

namespace FirstApplicetion.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            byte age = (byte) int.Parse(Console.ReadLine());
            Console.WriteLine("Your name is {0} and age is {1}", name, age);
            Console.Write("What os your favorite day of week?");
            DayOfWeek day = (DayOfWeek) int.Parse(Console.ReadLine());
            Console.WriteLine("Your favorite day is {0}", day);
            Console.Write("Enter your birthdate: ");
            var birthdate = Console.ReadLine();
            Console.WriteLine("Your birthdate is {0}", birthdate);
            Console.ReadKey();
        }
    }
}
