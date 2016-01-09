//-----------------------------------------------------------------------
// <copyright file="Tests.cs">
//     Copyright (c) 2016 Jacob Ferm, All rights Reserved
// </copyright>
//-----------------------------------------------------------------------
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;

namespace Faker.Tests
{
    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "*", Justification = "Reviewed")]
    [TestClass]
    public class Tests
    {
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
    }
}
