//-----------------------------------------------------------------------
// <copyright file="NameTests.cs">
//     Copyright (c) 2016 Jacob Ferm, All rights Reserved
// </copyright>
//-----------------------------------------------------------------------
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics.CodeAnalysis;

namespace Faker.Tests
{
    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "*", Justification = "Reviewed")]
    [TestClass]
    public class NameTests
    {
        [TestMethod]
        public void MaleFirstName()
        {
            Assert.IsNotNull(Name.MaleFirstName());
        }

        [TestMethod]
        public void FemaleFirstName()
        {
            Assert.IsNotNull(Name.FemaleFirstName());
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
        public void LastName()
        {
            Assert.IsNotNull(Name.LastName());
        }

        [TestMethod]
        public void Gender()
        {
            var name = Name.Gender();
            Assert.IsTrue(name.Equals("Male") || name.Equals("Female"));
        }

        [TestMethod]
        public void Ethnicity()
        {
            Assert.IsNotNull(Name.Ethnicity());
        }
    }
}
