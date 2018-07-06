using System;
using System.Collections.Generic;
using System.Linq;

namespace Calendar
{
    class Program
    {
        static void Main(string[] args)
        {
            int startYear = 2015;
            int LastYear = 2018;
            List<Year> years = new List<Year>();
            WeekDay startDay = WeekDay.Thu;
            for (int year = startYear; year <= LastYear; year++)
            {
                var yearData = new Year(year, startDay);
                startDay = yearData.NextYearDay;
                years.Add(yearData);
            }
            var dateOnJanSunday = years.SelectMany(i => i.Months[0].WeekDates[WeekDay.Sun]);
            Console.WriteLine(dateOnJanSunday.Sum());
            Console.ReadKey();   
        }
    }
}
