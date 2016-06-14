using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumWeeklyForecast
{
    class Program
    {
        static void Main(string[] args)
        {
            Enums weeklyForecast = new Enums();
            weeklyForecast.printForecast();
            Console.ReadKey();
        }
    }
}
