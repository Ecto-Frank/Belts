using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Belts
{
    public static class DateExtensions
    {
        public static DayOfWeek DefaultFirstDayOfWeek = DayOfWeek.Monday; //qualnet uses monday for first day of week //System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.FirstDayOfWeek;

        public static bool HasTime(this DateTime dt)
        {
            return dt.TimeOfDay.TotalSeconds > 0;
        }
        public static bool HasTime(this DateTimeOffset dt)
        {
            return dt.TimeOfDay.TotalSeconds > 0;
        }

        public static DateTime EndOfDay(this DateTime dt)
        {
            return dt.AddDays(1).Date.AddSeconds(-1);
        }


        public static bool IsWeekend(this DateTime dt)
        {
            return dt.DayOfWeek == DayOfWeek.Saturday || dt.DayOfWeek == DayOfWeek.Sunday;
        }
        public static bool IsWeekday(this DateTime dt)
        {
            return !dt.IsWeekend();
        }

        #region week

        public static DateTime FirstDayOfWeek(this DateTime dt, DayOfWeek? weekStartsOn = null)
        {
            weekStartsOn ??= DefaultFirstDayOfWeek;

            var diff = dt.DayOfWeek - weekStartsOn.Value;

            if (diff < 0)
            {
                diff += 7;
            }

            return dt.AddDays(-diff).Date;
        }

        public static DateTime LastDayOfWeek(this DateTime dt, DayOfWeek? weekStartsOn = null) =>
            dt.FirstDayOfWeek(weekStartsOn).AddDays(6);
        public static DateTime FirstDayOfPreviousWeek(this DateTime dt, DayOfWeek? weekStartsOn = null) =>
            dt.FirstDayOfWeek(weekStartsOn).AddDays(-7);

        public static DateTime LastDayOfPreviousWeek(this DateTime dt, DayOfWeek? weekStartsOn = null) =>
           dt.FirstDayOfWeek(weekStartsOn).AddDays(-1);

        public static DateTime FirstDayOfNextWeek(this DateTime dt, DayOfWeek? weekStartsOn = null) =>
           dt.FirstDayOfWeek(weekStartsOn).AddDays(7);

        public static DateTime LastDayOfNextWeek(this DateTime dt, DayOfWeek? weekStartsOn = null) =>
           dt.LastDayOfWeek(weekStartsOn).AddDays(7);

        #endregion

        #region Month

        public static DateTime FirstDayOfMonth(this DateTime dt) =>
           new DateTime(month: dt.Month, day: 1, year: dt.Year);

        public static DateTime LastDayOfMonth(this DateTime dt) =>
            dt.FirstDayOfMonth().AddMonths(1).AddDays(-1);

        public static DateTime FirstDayOfPreviousMonth(this DateTime dt) =>
            dt.FirstDayOfMonth().AddMonths(-1);
        public static DateTime LastDayOfPreviousMonth(this DateTime dt) =>
            dt.FirstDayOfMonth().AddDays(-1);

        public static DateTime FirstDayOfNextMonth(this DateTime dt) =>
            dt.LastDayOfMonth().AddDays(1);
        public static DateTime LastDayOfNextMonth(this DateTime dt) =>
            dt.FirstDayOfNextMonth().LastDayOfMonth();

        #endregion

        #region Year

        public static DateTime FirstDayOfYear(this DateTime dt) =>
           new DateTime(month: 1, day: 1, year: dt.Year);

        public static DateTime LastDayOfYear(this DateTime dt) =>
           new DateTime(month: 12, day: 31, year: dt.Year);


        public static DateTime FirstDayOfPreviousYear(this DateTime dt) =>
           new DateTime(month: 1, day: 1, year: dt.Year - 1);

        public static DateTime LastDayOfPreviousYear(this DateTime dt) =>
           new DateTime(month: 12, day: 31, year: dt.Year - 1);


        public static DateTime FirstDayOfNextYear(this DateTime dt) =>
           new DateTime(month: 1, day: 1, year: dt.Year + 1);

        public static DateTime LastDayOfNextYear(this DateTime dt) =>
           new DateTime(month: 12, day: 31, year: dt.Year + 1);

        #endregion
    }
}
