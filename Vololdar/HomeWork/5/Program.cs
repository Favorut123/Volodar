using System;

namespace lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] weekDays = ("");
            //for (int i = 0; i < weekDays.length; i++)

            //}
            //Console.WriteLine("weekDays[i]");
            //foreach(string weekDay in weekDays)
            //{
            //    Console.WriteLine
            //}
            //{ -4, -3, 0, 1, 2, -2, -1, 3, 4 };

            int[] numbers = { 1, 2, 3, 4 };

            int l = numbers.Length;
            int n = l / 2;
            int result;


            for (int i = 0; i < n; i++)
            {
                result = numbers[i];
                numbers[i] = numbers[l - i - 1];
                numbers[l - i - 1] = result;
            }
            
            foreach (int i in numbers)
            {
                Console.WriteLine($"{i} \n");
            }
            


        }
    }
    
}