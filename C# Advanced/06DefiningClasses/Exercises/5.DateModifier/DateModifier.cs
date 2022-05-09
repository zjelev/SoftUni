using System;

namespace DefiningClasses
{
    public static class DateModifier
    {
        public static double DayDiff(string dateOne, string dateTwo)
        {
            DateTime firstDate = DateTime.Parse(dateOne);
            DateTime secondDate = DateTime.Parse(dateTwo);

            return Math.Abs((firstDate - secondDate).TotalDays);
        }
    }
}