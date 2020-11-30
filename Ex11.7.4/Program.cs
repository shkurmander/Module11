using System;

namespace Ex11._7._4
{
    class Program
    {
        enum DayOfWeek
        {
            Monday = 1,
            Tuesday =2,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            var name = Console.ReadLine();
            Console.Write("Enter your age: ");
            var age = Console.ReadLine();
            Console.WriteLine($"Your name is {name} and age is {age}");
            Console.Write("What is your favorite day of week? ");

            //DayOfWeek favoriteDay = (DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(Convert.ToInt32(Console.ReadLine())-1);
            DayOfWeek favoriteDay = (DayOfWeek)Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Your favorite day is {favoriteDay} ");

            Console.ReadKey();
        }
    }
}
