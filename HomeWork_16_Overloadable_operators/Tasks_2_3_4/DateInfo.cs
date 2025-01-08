using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_2_3_4
{
    internal class DateInfo
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public DateInfo(int day, int month, int year)
        {
            if (!IsValidDate(day, month, year))
                throw new ArgumentException("Невалідна дата!");
            Day = day;
            Month = month;
            Year = year;
        }

        private static bool IsValidDate(int day, int month, int year)
        {
            try
            {
                DateTime tempDate = new DateTime(year, month, day);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static int operator -(DateInfo d1, DateInfo d2)
        {
            DateTime date1 = new DateTime(d1.Year, d1.Month, d1.Day);
            DateTime date2 = new DateTime(d2.Year, d2.Month, d2.Day);

            return (date1 - date2).Days;
        }

        public static DateInfo operator +(DateInfo d, int daysToAdd)
        {
            DateTime date = new DateTime(d.Year, d.Month, d.Day);
            date = date.AddDays(daysToAdd);

            return new DateInfo(date.Day, date.Month, date.Year);
        }

        public static DateInfo operator +(DateInfo d, DateInfo daysToAdd)
        {
            DateTime date = new DateTime(d.Year, d.Month, d.Day);
            date = date.AddDays(daysToAdd.Day);
            return new DateInfo(date.Day, date.Month, date.Year);
        }
        public override string ToString()
        {
            return $"{Day:D2}/{Month:D2}/{Year}";
        }
    }
}