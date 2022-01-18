using System;

namespace Task_07
{
    public class Position
    {
        public string Title { get; private set; }
        public DateTime From { get; private set; }
        public DateTime? To { get; private set; }

        public Position(string title, DateTime from, DateTime? to)
        {
            Title = title;
            From = from;
            To = to;
        }

        public int GetWorkDays()
        {
            DateTime to = To is null ? DateTime.Now : (DateTime)To;
            TimeSpan workTime = (to - From);

            int days = (int)workTime.TotalDays;
            return days;
        }
    }
}
