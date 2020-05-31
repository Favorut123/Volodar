using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Timers;

namespace Delegates
{
    class Program
    {       
        public static InputHandler handler = new InputHandler();       

        static void Main(string[] args)
        {
            DisplayMessage();       
           
            Console.ReadLine();
        }
        public static void DisplayMessage()
        {
            Console.WriteLine("Enter string: ");
            string text = Console.ReadLine();
            handler.HandleText(text);
        }
    }
}

