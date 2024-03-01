//-----------------------------------------------------------------------
// <copyright file="DateTests.cs">
//     Copyright (c) 2024 Jacob Ferm, All rights Reserved
// </copyright>
//-----------------------------------------------------------------------
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Faker.Tests
{
    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "*", Justification = "Reviewed")]
    [TestClass]
    public class DateTests
    {
        private DateTime date = DateTime.Now;

        [TestMethod]
        public void Between()
        {
            var result = Date.Between(this.date, this.date.AddDays(1));
            Assert.IsTrue(result > this.date && result < this.date.AddDays(1));
        }

        [TestMethod]
        public void Birthday()
        {
            var result = Date.Birthday(18, 20);
            Assert.IsTrue(this.date.Year - 20 <= result.Year && this.date.Year - 18 >= result.Year);
        }

        [TestMethod]
        public void ForwardWithTime()
        {
            var result = Date.ForwardWithTime(1, 1, 1);
            Assert.IsTrue(result >= this.date);
            Assert.IsTrue(result < this.date.AddYears(1).AddMonths(1).AddDays(1));
        }

        [TestMethod]
        public void ForwardWithTime1()
        {
            var result = Date.ForwardWithTime();
            Assert.IsTrue(result >= this.date);
            Assert.IsTrue(result < this.date.AddDays(365));
        }

        [TestMethod]
        public void Forward()
        {
            var result = Date.Forward(1, 1, 50);
            Assert.IsTrue(result >= this.date);
            Assert.IsTrue(result < this.date.AddYears(1).AddMonths(1).AddDays(50));
        }

        [TestMethod]
        public void Forward1()
        {
            var result = Date.Forward();
            Assert.IsTrue(result >= this.date);
            Assert.IsTrue(result < this.date.AddDays(365));
        }

        [TestMethod]
        public void Past()
        {
            var result = Date.Past(1, 1, 1);
            Assert.IsTrue(result <= this.date);
            Assert.IsTrue(result >= this.date.AddYears(-1).AddMonths(-1).AddDays(-1));
        }

        [TestMethod]
        public void Past1()
        {
            var result = Date.Past();
            Assert.IsTrue(result <= this.date);
            Assert.IsTrue(result >= this.date.AddDays(-365), result.ToString());
        }

        [TestMethod]
        public void PastWithTime()
        {
            var result = Date.PastWithTime();
            Assert.IsTrue(result <= this.date);
            Assert.IsTrue(result >= this.date.AddDays(-365), result.ToString());
        }

        [TestMethod]
        public void PastWithTime1()
        {
            var result = Date.PastWithTime(1, 1, 1);
            Assert.IsTrue(result <= this.date);
            Assert.IsTrue(result >= this.date.AddYears(-1).AddMonths(-1).AddDays(-1));
        }

        [TestMethod]
        public void Recent()
        {
            var result = Date.Recent(5);
            Assert.IsTrue(result <= this.date);
            Assert.IsTrue(result >= this.date.AddDays(-6), result.ToString());
        }

        [TestMethod]
        public void ShortMonth()
        {
            var result = Date.MonthShort();
            Assert.IsTrue(result.Length == 3);
        }

        [TestMethod]
        public void Month()
        {
            var result = Date.Month();
            Assert.IsTrue(result.Length >= 3, result);
        }

        [TestMethod]
        public void Weekday()
        {
            var result = Date.Weekday();
            Assert.IsTrue(result.Length > 5);
        }

        [TestMethod]
        public void Day()
        {
            Assert.IsTrue(Date.Day() <= 31);
        }

        [TestMethod]
        public void Year()
        {
            int year = Date.Year();
            Assert.IsTrue(year <= 3000);
            Assert.IsTrue(year >= 1900);
        }
    }
}
