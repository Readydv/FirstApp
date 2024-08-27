using System;
using FirstApplication.ConsoleHelper;

namespace FirstApplicetion.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            const string MyCity = "Салават";
            const string MyName = "Даниил";
            Console.WriteLine(MyName);
            Console.WriteLine("\tМне 19 лет");
            Console.WriteLine("\tПривет всем!");
            Console.WriteLine("\tЯ живу в городе {0}", MyCity);
            Console.WriteLine(MyName);
            Console.WriteLine("\u0023");
            Console.ReadKey();
        }
    }
}
