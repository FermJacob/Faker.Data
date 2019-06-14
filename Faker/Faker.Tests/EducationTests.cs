//-----------------------------------------------------------------------
// <copyright file="EducationTests.cs">
//     Copyright (c) 2019 Jacob Ferm, All rights Reserved
// </copyright>
//-----------------------------------------------------------------------
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics.CodeAnalysis;

namespace Faker.Tests
{
    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "*", Justification = "Reviewed")]
    [TestClass]
    public class EducationTests
    {
        [TestMethod]
        public void Major()
        {
            Assert.IsNotNull(Education.Major());
        }
    }
}
