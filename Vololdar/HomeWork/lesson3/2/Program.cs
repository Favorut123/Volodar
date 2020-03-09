using System;

namespace homework2
{
    class Student
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Points in Math: ");
            int math = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Points in Phisics: ");
            int phis = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Points in Chemistry: ");
            int chem = Convert.ToInt32(Console.ReadLine());

            if (math + phis + chem >= 180 || math + phis >= 140 || math + chem >= 140)
                    {
                Console.WriteLine("Студент допущений!");
            }
            else if (math < 65 || phis < 55 || chem < 50)
            {
                Console.WriteLine("Студент не допущений!");
            }
            Console.ReadKey();
        }
    }
}
