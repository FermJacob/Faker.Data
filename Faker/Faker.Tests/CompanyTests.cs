//-----------------------------------------------------------------------
// <copyright file="CompanyTests.cs">
//     Copyright (c) 2019 Jacob Ferm, All rights Reserved
// </copyright>
//-----------------------------------------------------------------------
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics.CodeAnalysis;

namespace Faker.Tests
{
    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "*", Justification = "Reviewed")]
    [TestClass]
    public class CompanyTests
    {
        ////[TestMethod]
        ////public void CompanyName()
        ////{
        ////    //Assert.IsNotNull(Company.Name());
        ////}

        [TestMethod]
        public void CompanyIndustry()
        {
            Assert.IsNotNull(Company.Industry());
        }

        [TestMethod]
        public void CompanySector()
        {
            Assert.IsNotNull(Company.Sector());
        }

        [TestMethod]
        public void CompanySymbol()
        {
            Assert.IsNotNull(Company.Symbol());
        }

        ////[TestMethod]
        ////public void CompanySlogan()
        ////{
        ////    //Assert.IsNotNull(Company.Slogan());
        ////}

        [TestMethod]
        public void CompanySuffix()
        {
            Assert.IsNotNull(Company.Suffix());
        }

        [TestMethod]
        public void CompanyPhrase()
        {
            Assert.IsNotNull(Company.CatchPhrase());
        }

        [TestMethod]
        public void CompanyPre()
        {
            Assert.IsNotNull(Company.CatchPhrasePre());
        }

        [TestMethod]
        public void CompanyMid()
        {
            Assert.IsNotNull(Company.CatchPhraseMid());
        }

        [TestMethod]
        public void CompanyPos()
        {
            Assert.IsNotNull(Company.CatchPhrasePos());
        }
    }
}
