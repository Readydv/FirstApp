using System;
using System.Xml.Linq;
using FirstApplication.ConsoleHelper;

namespace FirstApplicetion.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = GetUserInput();
            DisplayUserInfo(user);
        }
        static (string name, string lastname, int age, bool hasPet, string[] petNames, int favoriteColorsCount, string[] favoriteColors) GetUserInput()
        {
            (string name, string lastname, int age, bool HasPet, string[] petNames, int favoriteColorsCount, string[] favoriteColors) User;
            Console.WriteLine("Введите имя");
            User.name = Console.ReadLine();
            Console.WriteLine("Введите фамилию");
            User.lastname = Console.ReadLine();
            User.age = GetValidInput("Сколько вам лет?");
            Console.WriteLine("Есть ли у Вас домашний питомец? Да, нет?");
            var result = Console.ReadLine();
            User.petNames = new string[0];
            if (result == "Да")
            {
                if (User.HasPet = true)
                {
                    int petCount = GetValidInput("Сколько у вас питомцев?");
                    User.petNames = GetPetNames(petCount);
                }
            }
            else
            {
                User.HasPet = false;
            }
            User.favoriteColors = new string[0];
            User.favoriteColorsCount = GetValidInput("Сколько у вас любимых цветов?");
            User.favoriteColors = GetFavoriteColors(User.favoriteColorsCount);
            return User;
            
        }

                static string[] GetPetNames(int count)
                {
                    string[] petNames = new string[count];
                    for (int i = 0; i < count; i++)
                    {
                        Console.Write("Введите имя питомца {0}: ", i + 1);
                        petNames[i] = Console.ReadLine();
                    }
                    return petNames;
                }

                static string[] GetFavoriteColors(int count)
                {
                    string[] favoriteColors = new string[count];
                    for (int i = 0; i < count; i++)
                    {
                        Console.Write("Введите название любимого цвета {0}: ", i + 1);
                        favoriteColors[i] = Console.ReadLine();
                    }
                    return favoriteColors;
                }

        static int GetValidInput(string message)
        {
            int result;
            do
            {
                Console.WriteLine(message);
            }
            while (!int.TryParse(Console.ReadLine(), out result) || result <= 0);
            return result;
        }

        static void DisplayUserInfo((string name, string lastname, int age, bool HasPet, string[] petNames, int favoriteColorsCount, string[] favoriteColors) user)
        {
            Console.WriteLine("Имя: {0}", user.name);
            Console.WriteLine("Фамилия: {0}", user.lastname);
            Console.WriteLine("Возраст: {0}", user.age);
            Console.WriteLine("Наличие питомца: {0}", user.HasPet ? "Да" : "Нет");
            if (user.HasPet)
            {
                Console.WriteLine("Имена питомцев: {0}", string.Join(", ", user.petNames));
            }
            Console.WriteLine("Любимые цвета: {0}", string.Join(", ", user.favoriteColors));
        }
    }
}


