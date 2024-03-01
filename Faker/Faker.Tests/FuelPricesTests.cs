//-----------------------------------------------------------------------
// <copyright file="FuelPricesTests.cs">
//     Copyright (c) 2024 Jacob Ferm, All rights Reserved
// </copyright>
//-----------------------------------------------------------------------
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics.CodeAnalysis;

namespace Faker.Tests
{
    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "*", Justification = "Reviewed")]
    [TestClass]
    public class FuelPricesTests
    {
        [TestMethod]
        public void CompressedNaturalGas()
        {
            var result = FuelPrices.CompressedNaturalGas();
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void E85()
        {
            var result = FuelPrices.E85();
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Diesel()
        {
            var result = FuelPrices.Diesel();
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Electric()
        {
            var result = FuelPrices.Electric();
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void LPG()
        {
            var result = FuelPrices.LPG();
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Midgrade()
        {
            var result = FuelPrices.Midgrade();
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Premium()
        {
            var result = FuelPrices.Premium();
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Regular()
        {
            var result = FuelPrices.Regular();
            Assert.IsNotNull(result);
        }
    }
}
