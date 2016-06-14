using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumPracticeWeather
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loopMore;
            Weather myWeather = new Weather();

            do
            {
                myWeather.GetWeatherWeek();
                Console.WriteLine("Weather for {0} IS {1}", myWeather.GetWeekName(Weather.Days.Mon), myWeather.GetForecast(Weather.Days.Mon));
                Console.WriteLine("Weather for {0} IS {1}", Enum.GetName(typeof(Weather.Days), Weather.Days.tue), myWeather.GetForecast(Weather.Days.tue));
                Console.WriteLine("Weather for {0} IS {1}", Enum.GetName(typeof(Weather.Days), Weather.Days.Wed), myWeather.GetForecast(Weather.Days.Wed));
                Console.WriteLine("Weather for {0} IS {1}", Enum.GetName(typeof(Weather.Days), Weather.Days.thu), myWeather.GetForecast(Weather.Days.thu));
                Console.WriteLine("Weather for {0} IS {1}", Enum.GetName(typeof(Weather.Days), Weather.Days.Fri), myWeather.GetForecast(Weather.Days.Fri));
                Console.WriteLine("Weather for {0} IS {1}", Enum.GetName(typeof(Weather.Days), Weather.Days.Sat), myWeather.GetForecast(Weather.Days.Sat));
                Console.WriteLine("Weather for {0} IS {1}", Enum.GetName(typeof(Weather.Days), Weather.Days.Sun), myWeather.GetForecast(Weather.Days.Sun));
                Console.WriteLine("Press Y to re-print forcast:");
                char keyIn = Console.ReadKey().KeyChar;
                if (keyIn == 'y' || keyIn == 'Y')
                    loopMore = true;
                else
                    loopMore = false;
            }
            while (loopMore == true);
        }// END OF MAIN
    } // END OF cLASS
} //END OF NAMESPACE
