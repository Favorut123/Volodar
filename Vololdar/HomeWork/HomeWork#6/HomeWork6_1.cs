using System;


namespace homework6
{
    class Array
    {
        //Вивести кожен елемент масиву в консоль в наступному форматі "{подія} on {день}” застосовуючи наступні правила
        //    Якщо в стрічці більше 10 символів, то обрізати перших десять і вставити ...
        //      Всі літери мають бути маленькими
        //      В другій позиції масиву цифру заміняти за наступним принципом: 1 - monday,...7- sunday
        static void Main(string[] args)
        {


            string[] dayNames = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            string[][] input = new string[][] {
                new string [] {"John and Mary have a discussion","1"},
                new string [] {"John and Mary interview","3"},
                new string [] {"F2F","4"},
                new string [] {"General meeting","7"}
                  };
            for (int i = 0; i < input.Length; i++)
            {
                
                input[i][0] = input[i][0].ToLower();
                if (input[i][0].Length > 10)
                {
                    string subString = input[i][0].Substring(0, 10);
                    
                    input[i][0] = subString + "...";
                }
                int index = int.Parse(input[i][1]) - 1;
                string day = dayNames[index];
                Console.WriteLine($"{input[i][0]} on {day}");
            }
            Console.ReadKey();


        }
    }
}