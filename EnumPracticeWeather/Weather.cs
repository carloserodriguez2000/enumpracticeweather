using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumPracticeWeather
{
    class Weather
    {
        public enum Days { Sun, Mon, tue, Wed, thu, Fri, Sat };
        public enum Forecast { Sunny, Overcast, Rain };
        private Random rnd1 = new Random();
        private Forecast[] weekForcast = new Forecast[7];

        public void GetWeatherWeek()
        {
            Array forcastNums = Enum.GetValues(typeof(Forecast));
            int rndDayForcastIndex = rnd1.Next(forcastNums.Length);
            Array weekNums = Enum.GetValues(typeof(Days));

            for (int i = 0; i < weekNums.Length; i++)
            {
                rndDayForcastIndex = rnd1.Next(forcastNums.Length);
                weekForcast[i] = (Forecast)forcastNums.GetValue(rndDayForcastIndex);
            }
        }
        public Forecast GetForecast(Days thisday)  // change this touse the ENUM "Days"
        {
            Forecast dayWeather = weekForcast[(int)thisday];
            return dayWeather;
        }

        public string GetWeekName(Days thisday)
        {
            return Enum.GetName(typeof(Weather.Days), thisday);
        }
    } //END OF CLASS

}
