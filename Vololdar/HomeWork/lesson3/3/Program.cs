using System;

namespace homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            double distance;
            double hour, min, sec;
            double timeSec;
            double mps;
            double kmph, mph;

            try
            {
                Console.WriteLine("Input distance(meters): ");
                distance = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input timeSec(hour): ");
                hour = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input timeSec(minutes): ");
                min = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input timeSec(seconds): ");
                sec = Convert.ToInt32(Console.ReadLine());
            }

            catch (FormatException)
            {
                Console.WriteLine("Sorry, all input data must be a digits.");
                return;
            }

            timeSec = (hour * 3600) + (min * 60) + sec;
            mps = distance / timeSec;
            kmph = distance / 1000 / (timeSec / 3600);
            mph = kmph / timeSec;

            Console.WriteLine("Your speed in meters/sec is {0}", mps);
            Console.WriteLine("Your speed in km/h is {0}", kmph);
            Console.WriteLine("Your speed in miles/h is {0}", mph);

            Console.ReadLine();
        }
    }
}
