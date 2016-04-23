//-----------------------------------------------------------------------
// <copyright file="Date.cs">
//     Copyright (c) 2016 Jacob Ferm, All rights Reserved
// </copyright>
//-----------------------------------------------------------------------
using System;

namespace Faker
{
    /// <summary>
    /// Class for date generation
    /// </summary>
    public static class Date
    {
        /// <summary>
        /// Gets a random <see cref="DateTime"/> between two dates
        /// </summary>
        /// <param name="from">The from value</param>
        /// <param name="to">The to value</param>
        /// <returns>A <see cref="DateTime"/></returns>
        public static DateTime Between(DateTime from, DateTime to)
        {
            var randTicks = Number.RandomNumber(from.Ticks, to.Ticks + 1);
            return new DateTime(randTicks);
        }

        /// <summary>
        /// Gets a random birthday based on age
        /// </summary>
        /// <param name="minAge">Minimum age</param>
        /// <param name="maxAge">Maximum age</param>
        /// <returns>A <see cref="DateTime"/></returns>
        public static DateTime Birthday(int minAge = 18, int maxAge = 65)
        {
            var today = DateTime.Today;
            var from = today.AddYears(-maxAge);
            var to = today.AddYears(-minAge);
            return Between(from, to).Date;
        }

        /// <summary>
        /// Gets a random date and time in the future
        /// </summary>
        /// <param name="years">Years forward</param>
        /// <param name="months">Months forward</param>
        /// <param name="days">Days forward</param>
        /// <param name="hours">Hours forward</param>
        /// <param name="minutes">Minutes forward</param>
        /// <param name="seconds">Seconds forward</param>
        /// <returns>A <see cref="DateTime"/></returns>
        public static DateTime ForwardWithTime(int years = 1, int months = 0, int days = 0, int hours = 0, int minutes = 0, int seconds = 0)
        {
            var to = DateTime.Now;
            var from = to.AddYears(years).AddMonths(months).Add(new TimeSpan(days, hours, minutes, seconds));
            return Between(to, from);
        }

        /// <summary>
        /// Gets a random date and time in the future
        /// </summary>
        /// <returns>A <see cref="DateTime"/></returns>
        public static DateTime ForwardWithTime()
        {
            return ForwardWithTime(0, 0, Number.RandomNumber(1, 365));
        }

        /// <summary>
        /// Gets a random date in the future
        /// </summary>
        /// <param name="years">Years forward</param>
        /// <param name="months">Months forward</param>
        /// <param name="days">Days forward</param>
        /// <returns>A <see cref="DateTime"/></returns>
        public static DateTime Forward(int years = 1, int months = 0, int days = 0)
        {
            return ForwardWithTime(years, months, days).Date;
        }

        /// <summary>
        /// Gets a random date in the future
        /// </summary>
        /// <returns>A <see cref="DateTime"/></returns>
        public static DateTime Forward()
        {
            return ForwardWithTime(0, 0, Number.RandomNumber(1, 365)).Date;
        }

        /// <summary>
        /// Gets a random date in the past
        /// </summary>
        /// <returns>A <see cref="DateTime"/></returns>
        public static DateTime Past()
        {
            return PastWithTime(0, 0, Number.RandomNumber(1, 365)).Date;
        }

        /// <summary>
        /// Gets a random date and time in the future
        /// </summary>
        /// <returns>A <see cref="DateTime"/></returns>
        public static DateTime PastWithTime()
        {
            return PastWithTime(0, 0, Number.RandomNumber(1, 365));
        }

        /// <summary>
        /// Gets a random date and time in the past
        /// </summary>
        /// <param name="years">Years forward</param>
        /// <param name="months">Months forward</param>
        /// <param name="days">Days forward</param>
        /// <param name="hours">Hours forward</param>
        /// <param name="minutes">Minutes forward</param>
        /// <param name="seconds">Seconds forward</param>
        /// <returns>A <see cref="DateTime"/></returns>
        public static DateTime PastWithTime(int years = 1, int months = 0, int days = 0, int hours = 0, int minutes = 0, int seconds = 0)
        {
            var to = DateTime.Now;
            var from = to.AddYears(-years).AddMonths(-months).Add(new TimeSpan(-days, -hours, -minutes, -seconds));
            return Between(from, to);
        }

        /// <summary>
        /// Gets a random date and time in the past
        /// </summary>
        /// <param name="years">Years forward</param>
        /// <param name="months">Months forward</param>
        /// <param name="days">Days forward</param>
        /// <returns>A <see cref="DateTime"/></returns>
        public static DateTime Past(int years = 1, int months = 0, int days = 0)
        {
            return PastWithTime(years, months, days).Date;
        }

        /// <summary>
        /// Gets a recent date and time
        /// </summary>
        /// <param name="days">Days recent</param>
        /// <returns>A <see cref="DateTime"/></returns>
        public static DateTime Recent(int days = 5)
        {
            var to = DateTime.Today;
            var from = to.AddDays(-days);
            return Between(from, to);
        }

        /// <summary>
        /// Gets a random short month
        /// </summary>
        /// <returns>A string</returns>
        public static string MonthShort()
        {
            return DateTime.Now.AddMonths(Number.RandomNumber(1, 12)).ToString("MMM");
        }

        /// <summary>
        /// Gets a random long month
        /// </summary>
        /// <returns>A string</returns>
        public static string Month()
        {
            return DateTime.Now.AddMonths(Number.RandomNumber(1, 12)).ToString("MMMM");
        }

        /// <summary>
        /// Gets a random weekday
        /// </summary>
        /// <returns>A string</returns>
        public static string Weekday()
        {
            return Enum.GetName(typeof(DayOfWeek), Number.RandomNumber(1, 7));
        }

        /// <summary>
        /// Gets a random day
        /// </summary>
        /// <returns>An integer</returns>
        public static int Day()
        {
            return Number.RandomNumber(1, 31);
        }

        /// <summary>
        /// Gets a random year
        /// </summary>
        /// <returns>An integer</returns>
        public static int Year()
        {
            return Number.RandomNumber(1900, 3000);
        }
    }
}
