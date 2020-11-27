using System;

namespace Ex11._3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string MyName = "Jane";
            byte MyAge = 27;
            bool HaveIAPet = true;
            double MyShoeSize = 37.5;


            Console.WriteLine($"My name is {MyName}");
            Console.WriteLine($"My age is {MyAge}");
            Console.WriteLine($"Do I have a pet? {HaveIAPet}");
            Console.WriteLine($"My shoe size is  {MyShoeSize}");

            Console.ReadKey();
        }
    }
}
