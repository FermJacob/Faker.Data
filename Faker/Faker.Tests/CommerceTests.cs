//-----------------------------------------------------------------------
// <copyright file="CommerceTests.cs">
//     Copyright (c) 2016 Jacob Ferm, All rights Reserved
// </copyright>
//-----------------------------------------------------------------------
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Faker.Tests
{
    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "*", Justification = "Reviewed")]
    [TestClass]
    public class CommerceTests
    {
        [TestMethod]
        public void Department()
        {
            Assert.IsNotNull(Commerce.Department());
        }

        [TestMethod]
        public void Departments()
        {
            Assert.IsTrue(Commerce.Departments().Count >= 1);
        }

        [TestMethod]
        public void Departments1()
        {
            Assert.IsTrue(Commerce.Departments(5).Count == 5);
        }

        [TestMethod]
        public void Product()
        {
            Assert.IsNotNull(Commerce.Product());
        }

        [TestMethod]
        public void Products()
        {
            Assert.IsTrue(Commerce.Products().Count >= 1);
        }

        [TestMethod]
        public void Products1()
        {
            Assert.IsTrue(Commerce.Products(12).Count == 12);
        }

        [TestMethod]
        public void ProductAdjective()
        {
            Assert.IsNotNull(Commerce.ProductAdjective());
        }

        [TestMethod]
        public void ProductAdjectives()
        {
            Assert.IsTrue(Commerce.ProductAdjectives().Count >= 1);
        }

        [TestMethod]
        public void ProductAdjectives1()
        {
            Assert.IsTrue(Commerce.ProductAdjectives(12).Count == 12);
        }

        [TestMethod]
        public void ProductMaterial()
        {
            Assert.IsNotNull(Commerce.ProductMaterial());
        }

        [TestMethod]
        public void ProductMaterials()
        {
            Assert.IsTrue(Commerce.ProductMaterials().Count >= 1);
        }

        [TestMethod]
        public void ProductMaterials1()
        {
            Assert.IsTrue(Commerce.ProductMaterials(12).Count == 12);
        }

        [TestMethod]
        public void ProductName()
        {
            Assert.IsNotNull(Commerce.ProductName());
        }

        [TestMethod]
        public void ProductNames()
        {
            Assert.IsTrue(Commerce.ProductNames().Count >= 1);
        }

        [TestMethod]
        public void ProductNames1()
        {
            Assert.IsTrue(Commerce.ProductNames(12).Count == 12);
        }

        [TestMethod]
        public void Price()
        {
            Assert.IsNotNull(Commerce.Price());
        }

        [TestMethod]
        public void Price1()
        {
            Assert.IsTrue(Commerce.Price("$").Contains("$"));
        }

        [TestMethod]
        public void Prices()
        {
            Assert.IsTrue(Commerce.Prices().Count >= 1);
        }

        [TestMethod]
        public void Prices1()
        {
            Assert.IsTrue(Commerce.Prices("$", 12).Count == 12);
            Assert.IsTrue(Commerce.Prices("$", 12)[0].Contains("$"));
        }
    }
}
