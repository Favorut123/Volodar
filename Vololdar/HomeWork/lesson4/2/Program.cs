using System;

namespace hw5
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 39; i++)
            {
                if ((i % 2) == 1)
                    continue;
                Console.WriteLine(i);
            }


        }

    }
}
