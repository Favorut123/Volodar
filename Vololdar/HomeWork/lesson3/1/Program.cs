using System;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            int digit = 0;
            int digit_2 = 0;

            try
            {
                Console.WriteLine("I wanna calculate something for you, please input the first digit: ");
                digit = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Thank’s and another digit please!: ");
                digit_2 = Convert.ToInt32(Console.ReadLine());

            }
            catch (FormatException)
            {
                Console.WriteLine("Sorry, I do not now how to multiply chars :(.");
                return;
            }

            int x = digit * digit_2;


            if (x > 10 || x < 0)
            {
                Console.WriteLine("Sorry, I support only digits from 0 to 10 :(");
                return;
            }
            else
            {
                Console.WriteLine("Here you are: " + (x).ToString() + ":)");
            }



            Console.ReadKey();
        }

    }
}
