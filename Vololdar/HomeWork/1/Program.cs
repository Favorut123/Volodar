using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListHW1
{
    class Program
    {

        static void Main(string[] args)
        {
            Dictionary<int, string> profession = new Dictionary<int, string>()
            {
                {1, "Driver" },
                {2, "Worker" },
                {3, "Doktorr" },
                {4, "ff" },
                {5, "Killer" },
            };
            profession.Remove(4);

            foreach (KeyValuePair<int, String>pair in profession)
            {
                Console.WriteLine("{0}, {1}",pair.Key, pair.Value);
            }

            Console.Read();

        }


    }
}


