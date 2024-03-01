//-----------------------------------------------------------------------
// <copyright file="AddressTests.cs">
//     Copyright (c) 2024 Jacob Ferm, All rights Reserved
// </copyright>
//-----------------------------------------------------------------------
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;

namespace Faker.Tests
{
    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "*", Justification = "Reviewed")]
    [TestClass]
    public class AddressTests
    {
        [TestMethod]
        public void StateAbbr()
        {
            Assert.IsTrue(Address.StateAbbreviation().Length == 2);
        }

        [TestMethod]
        public void State()
        {
            Assert.IsNotNull(Address.State());
        }

        [TestMethod]
        public void ProvinceAbbr()
        {
            Assert.IsTrue(Address.ProvinceAbbreviation().Length == 2);
        }

        [TestMethod]
        public void Province()
        {
            Assert.IsNotNull(Address.Province());
        }

        [TestMethod]
        public void StreetName()
        {
            Assert.IsNotNull(Address.StreetName());
            Assert.IsTrue(Regex.IsMatch(Address.StreetName(), @"[A - Za - z0 - 9'\.\-\s\,]"));
        }

        [TestMethod]
        public void CanadianZip()
        {
            string canadianZip = Address.CanadianZipCode();
            Assert.IsTrue(canadianZip.Length == 6);

            for (int i = 0; i <= 5; i++)
            {
                if (i == 0)
                {
                    Assert.IsFalse(Regex.IsMatch(canadianZip[i].ToString(), "[WZ]"));
                }
                else if ((i % 2) == 0)
                {
                    Assert.IsTrue(Regex.IsMatch(canadianZip[i].ToString(), "[ABCEGHJKLMNPRSTVWXYZ]"));
                }
                else
                {
                    Assert.IsTrue(Regex.IsMatch(canadianZip[i].ToString(), "[0-9]"));
                }
            }
        }

        [TestMethod]
        public void Country()
        {
            Assert.IsNotNull(Address.Country());
        }

        [TestMethod]
        public void CityPrefix()
        {
            Assert.IsNotNull(Address.CityPrefix());
        }

        [TestMethod]
        public void CitySuffix()
        {
            Assert.IsNotNull(Address.CitySuffix());
        }

        [TestMethod]
        public void SecAddress()
        {
            Assert.IsNotNull(Address.SecondaryAddress());
        }

        [TestMethod]
        public void StreetSuffix()
        {
            Assert.IsNotNull(Address.StreetSuffix());
        }

        [TestMethod]
        public void USZip()
        {
            Assert.IsNotNull(Address.USZipCode());
            Assert.IsTrue(Address.USZipCode().Length > 2);
        }

        [TestMethod]
        public void USCity()
        {
            Assert.IsNotNull(Address.USCity());
        }

        [TestMethod]
        public void USCounty()
        {
            Assert.IsNotNull(Address.USCounty());
        }
    }
}
