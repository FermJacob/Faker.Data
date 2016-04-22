using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Faker.Tests
{
    /// <summary>
    /// TODO
    /// </summary>
    [TestClass]
    public class DateTests
    {


        [TestMethod]
        public void Forward()
        {
            var result = Date.Forward(1, 1, 50);
        }

        [TestMethod]
        public void Past()
        {
            var result = Date.Past(1);
        }

        [TestMethod]
        public void PastWithTime()
        {
            var result = Date.PastWithTime();
        }

        [TestMethod]
        public void PastWithTime1()
        {
            var result = Date.PastWithTime(1, 1, 1);
        }

        [TestMethod]
        public void ShortMonth()
        {
            var result = Date.MonthShort();
        }

        [TestMethod]
        public void Month()
        {
            var result = Date.Month();
        }

        [TestMethod]
        public void Weekday()
        {
            var result = Date.Weekday();
        }
    }
}
