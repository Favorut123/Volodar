using System;


namespace homework6
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {

    //        string text = @"Learn C# by stepping through the basics with Bob: get the tools, see how to write code, debug features, explore customizations, and much more ! Search for and focus on the information you need, in this C# for beginners course, which has topics separated out into individual videos. Get to know the grammar, create and use methods, manipulate strings, and see how to handle events. Plus, get a look at next steps as you learn to develop Windows and web applications.";

    //        Console.WriteLine(text.Substring(text.IndexOf('!')).Replace("cs", "c's"));


    //    }
    //}

    //Завдання було; output the string starting from ! sign, with next modification: cs=> c's



    class Array
    {
        //Вивести кожен елемент масиву в консоль в наступному форматі "{подія} on {день}” застосовуючи наступні правила
        //    Якщо в стрічці більше 10 символів, то обрізати перших десять і вставити ...
        //      Всі літери мають бути маленькими
        //      В другій позиції масиву цифру заміняти за наступним принципом: 1 - monday,...7- sunday
        static void Main(string[] args)
        {

            string[][] input = new string[][] {
                new string [] {"John and Mary have a discussion","1"},
                new string [] {"John and Mary interview","3"},
                new string [] {"F2F","4"},
                new string [] {"General meeting","7"}
                  };

            //string[][] daysNumbers = { "1", "Monday" },
            //                         { "2", "Tuesday"}

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input[i].Length; j++)
                {
                    if (j < input[i].Length)
                    {
                        input[i][j] = input[i][j].ToLower();

                        if (input[i][j].Length > 10)
                        {
                            string subString = input[i][j].Substring(0, 10);
                            input[i][j].Insert(1, subString);
                        }
                    }
                  
                  
                    Console.WriteLine(input[i][j]);
                    Console.ReadKey();
                }
            }



        }
    }
}