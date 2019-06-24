using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Faker.Extensions;

namespace Faker.Tests
{
    [TestClass]
    public class ExtensionTests
    {
        [TestMethod]
        public void GetRandomElement()
        {
            var list = new List<int>()
            {
                1,3,5,9
            };
            var result = list.GetRandomElements<int>(2);
            Assert.AreEqual(2, result.Count, "2 items were not returned");

        }

        [TestMethod]
        public void GetRandomElementInt()
        {
            var list = new List<int>()
            {
                1,3,5,9
            };
            var result = list.GetRandomIntFromList(new List<int>() { 1, 3, 5 });
            Assert.AreEqual(9, result, "9 was not returned");

        }
    }
}
