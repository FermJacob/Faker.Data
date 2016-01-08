using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text.RegularExpressions;

namespace Faker.Tests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void StateAbbr()
        {
            Assert.IsTrue(Address.StateAbbreviations().Length == 2);
        }

        [TestMethod]
        public void State()
        {
            Assert.IsNotNull(Address.State());
        }

        [TestMethod]
        public void ProvinceAbbr()
        {
            Assert.IsTrue(Address.ProvinceAbbreviations().Length == 2);
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
        }

        [TestMethod]
        public void MaleFirst()
        {
            Assert.IsNotNull(Name.MaleFirstName());
        }

        [TestMethod]
        public void FirstName()
        {
            Assert.IsNotNull(Name.FirstName());
        }

        [TestMethod]
        public void FullName()
        {
            Assert.IsNotNull(Name.FullName());
        }

        [TestMethod]
        public void CAZip()
        {
            string CaZip = Address.CanadianZipCode();
            Assert.IsTrue(CaZip.Length == 6);
            
            for (int i = 0; i<=5; i++)
            {
                if (i == 0)
                {
                    Assert.IsFalse(Regex.IsMatch(CaZip[i].ToString(), "[WZ]"));
                }
                else if ((i % 2) == 0)
                {
                    Assert.IsTrue(Regex.IsMatch(CaZip[i].ToString(), "[ABCEGHJKLMNPRSTVWXYZ]"));
                }
                else
                {
                    Assert.IsTrue(Regex.IsMatch(CaZip[i].ToString(), "[0-9]"));
                }
            }
        }
    }
}
