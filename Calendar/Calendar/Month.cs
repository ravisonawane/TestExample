using System.Collections.Generic;

namespace Calendar
{
    class Month
    {
        public Month(WeekDay startday, int totalDays)
        {
            this.WeekDates = new Dictionary<WeekDay, List<int>>();
            this.TotalDays = totalDays;

            for (int index = 1 ; index <= totalDays; index++)
            {

                if(this.WeekDates.ContainsKey(startday))
                {
                    this.WeekDates[startday].Add(index);
                }
                else
                {
                    this.WeekDates.Add(startday, new List<int> { index });
                }

                startday = startday == WeekDay.Sat ? WeekDay.Sun : startday + 1;
            }
            this.NextMonthStartDay = startday;
        }

        public WeekDay NextMonthStartDay { get; set; }
        public int TotalDays { get; set; }
        public Dictionary<WeekDay, List<int>> WeekDates { get; set; }

    }
}
