using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Your height: ");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Name: {name} Age: {age} Height: {height}");

            Console.ReadKey();
        }
    }
}
