
using LlistHW1.Model;
using System;

namespace LlistHW1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Human<string> profession = new Human<string>()
            var Professions = new Human<string>();
            Professions.Add("Driver");
            Professions.Add("Worker");
            Professions.Add("Doktor");
            Professions.Add("ff");
            Professions.Add("Killer");

            Professions.Remove("ff");

            foreach (var item in Professions)
            {
                Console.WriteLine(Professions);
            }

            Console.ReadLine();
        }
    }
}
