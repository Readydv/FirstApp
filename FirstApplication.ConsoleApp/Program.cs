using System;
using FirstApplication.ConsoleHelper;

namespace FirstApplicetion.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            const byte MyShoeSize = 42;
            int MyAge = 19;
            bool MyPet = true;
            const string MyName = "Danya";
            Console.WriteLine("My name is {0}", MyName);
            Console.WriteLine("My age is {0}", MyAge);
            Console.WriteLine("Do i have a pet? {0}", MyPet);
            Console.WriteLine("My shoe size is {0}", MyShoeSize);
            Console.ReadKey();
        }
    }
}
