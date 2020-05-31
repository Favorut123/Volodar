using System;
using System.Linq;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace hw3_linq
{
    public class Player
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime birthdate { get; set; }   
        
    }
    public class Time
    {
        public int Minutes { get; set; }
        public int Seconds { get; set; }
    }

    class Program 
    {
        static void Main(string[] args)
        {
            /*На вхід є стрічка "Davis, Clyne, Fonte, Hooiveld, Shaw, Davis, Schneiderlin, Cork, Lallana,
              Rodriguez, Lambert" Кожному гравцеві надайте номер, починаючи з 1, щоб вийшла стрічка
              подібна : "1. Davis, 2. Clyne, 3. Fonte" ...*/
            
            string inputString = "Davis, Clyne, Fonte, Hooiveld, Shaw, Davis, Schneiderlin, Cork, Lallana, Rodriguez, Lambert";
            var inputCollection = inputString.Split(' ').Select((item, i) => $"{i + 1}. {item}");

            Console.WriteLine(string.Join(' ', inputCollection));             

              /*3*/              
             /*Візьміть стрічку "4:12,2:43,3:51,4:29,3:24,3:14,4:46,3:25,4:52,3:27", яка відображає довжину
             пісень в хвилинах і секундаx і обрахуйте загальну довжину всіх пісень.*/   

             string inputString = "4:12,2:43,3:51,4:29,3:24,3:14,4:46,3:25,4:52,3:27";
             string[] input = inputString.Split(',');
             List<Time> duration = new List<Time>();
             int totalDuration = input.Select(item =>
             {
                string[] splitTime = item.Split(':');
                return new Time { Minutes = int.Parse(splitTime[0]), Seconds = int.Parse(splitTime[1]) };
             }).Sum(td => td.Minutes * 60 + td.Seconds);

             Console.WriteLine($"{totalDuration / 60}:{totalDuration % 60}");
            


            Console.ReadLine();
        }        
    }
}
