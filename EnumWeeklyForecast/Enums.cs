using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumWeeklyForecast
{
    class Enums
    {
        enum Days { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }
        enum Conditions { Thunderstorm, Rain, Drizzle, Cloudy, Sunny, Hot, Heatwave }

        public string setCondition()
        {
            string[] possibleConditions = Enum.GetNames(typeof(Conditions));
            Random choice = new Random();
            string condition = possibleConditions[choice.Next(possibleConditions.Length)];
            return condition;
        }

        public string[] fillConditions()
        {
            int i;
            string[] actualConditions = new string[7];
            for (i = 0; i < 7; i++)
            {
                actualConditions[i] = setCondition();
                System.Threading.Thread.Sleep(50);
            }
            return actualConditions;
        }

        public void printForecast()
        {
            int i;
            string[] weeklyForecasts = fillConditions();
            Console.WriteLine("Weekly weather forecast");
            for (i = 0; i < 7; i++)
            {
                Console.WriteLine("{0}: {1}", Enum.GetName(typeof(Days), i), weeklyForecasts[i]);
            }
        }
    }
}
