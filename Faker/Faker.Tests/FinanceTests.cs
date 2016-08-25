//-----------------------------------------------------------------------
// <copyright file="FinanceTests.cs">
//     Copyright (c) 2016 Jacob Ferm, All rights Reserved
// </copyright>
//-----------------------------------------------------------------------
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics.CodeAnalysis;

namespace Faker.Tests
{
    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "*", Justification = "Reviewed")]
    [TestClass]
    public class FinanceTests
    {
        [TestMethod]
        public void FiveOneYearAdjustableRateMortgage()
        {
            var temp = Finance.FiveOneYearAdjustableRateMortgage();
        }

        [TestMethod]
        public void Year51ClosestDate()
        {
            var temp = Finance.YearAdjustableRate51(new DateTime(2007, 6, 3));
        }
    }
}
