using System.Collections.Generic;

namespace Calendar
{
    class Year
    {
        public Year(int year, WeekDay startDay)
        {
            this.YearValue = year;
            this.IsLeapYear = ((year % 4 == 0 && (year % 100 != 0)) || year % 400 == 0) ? true : false;
            int[] monthDayCount = IsLeapYear ? new int[12] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 } : new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            this.Months = new List<Month>();

            foreach (var totalDays in monthDayCount)
            {
                var month = new Month(startDay, totalDays);
                startDay = month.NextMonthStartDay;
                this.Months.Add(month);
            }
            NextYearDay = startDay;
        }
        public int YearValue { get; set; }
        public bool IsLeapYear { get; set; }
        public WeekDay NextYearDay { get; set; }
        public List<Month> Months { get; set; }
    }
}
