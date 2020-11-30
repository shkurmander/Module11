using System;

namespace Ex_Final
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            var name = Console.ReadLine();
            Console.Write("Enter your age: ");
            var age = Console.ReadLine();
            Console.WriteLine($"Your name is {name} and age is {age}");
            Console.Write("Enter your birthdate: ");
            var birtdate = Console.ReadLine();
            Console.Write($"Your birtdate is {birtdate}");
        }
    }
}
