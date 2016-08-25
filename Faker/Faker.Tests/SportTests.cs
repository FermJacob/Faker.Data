//-----------------------------------------------------------------------
// <copyright file="SportTests.cs">
//     Copyright (c) 2016 Jacob Ferm, All rights Reserved
// </copyright>
//-----------------------------------------------------------------------
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics.CodeAnalysis;

namespace Faker.Tests
{
    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "*", Justification = "Reviewed")]
    [TestClass]
    public class SportTests
    {
        [TestMethod]
        public void SportType()
        {
            Assert.IsNotNull(Sports.SportType());
        }

        [TestMethod]
        public void SportTypes()
        {
            var list = Sports.SportTypes();
            Assert.IsNotNull(list);
            Assert.IsTrue(list.Count > 0);
        }

        [TestMethod]
        public void SportTypes1()
        {
            var list = Sports.SportTypes(5);
            Assert.IsNotNull(list);
            Assert.IsTrue(list.Count == 5);
        }
    }
}
