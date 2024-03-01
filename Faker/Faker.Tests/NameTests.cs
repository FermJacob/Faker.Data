//-----------------------------------------------------------------------
// <copyright file="NameTests.cs">
//     Copyright (c) 2024 Jacob Ferm, All rights Reserved
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
        public void GenderCheckRatio()
        {
            int numberOfMen = 0;
            int numberOfWomen = 0;
            for (var i = 0; i < 1000; i++)
            {
                var gender = Name.Gender();
                if (gender.Equals("Female", System.StringComparison.OrdinalIgnoreCase))
                {
                    numberOfWomen++;
                }
                else
                {
                    numberOfMen++;
                }
            }

            if (numberOfWomen < 200 || numberOfMen < 200)
            {
                Assert.Fail("Number of women: " + numberOfWomen + " Number of Men: " + numberOfMen);
            }
        }

        [TestMethod]
        public void Ethnicity()
        {
            Assert.IsNotNull(Name.Ethnicity());
        }
    }
}
