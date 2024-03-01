//-----------------------------------------------------------------------
// <copyright file="NumberTests.cs">
//     Copyright (c) 2024 Jacob Ferm, All rights Reserved
// </copyright>
//-----------------------------------------------------------------------
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics.CodeAnalysis;

namespace Faker.Tests
{
    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "*", Justification = "Reviewed")]
    [TestClass]
    public class NumberTests
    {
        [TestMethod]
        public void BoolTest()
        {
            Assert.IsInstanceOfType(Number.Bool(), typeof(bool));
        }

        [TestMethod]
        public void DoubleTest()
        {
            Assert.IsInstanceOfType(Number.Double(), typeof(double));
        }

        [TestMethod]
        public void OddNumber()
        {
            Assert.IsTrue(Number.Odd(0, 14) % 2 != 0);
        }

        [TestMethod]
        public void EvenNumber()
        {
            Assert.IsTrue(Number.Even(0, 15) % 2 == 0);
        }

        [TestMethod]
        public void NegativeNumber()
        {
            int number = Number.NegativeNumber(15);
            Assert.IsTrue(number < 0, "Number was: {0}", number);
        }

        [TestMethod]
        public void RandomNumber1()
        {
            Assert.IsInstanceOfType(Number.RandomNumber(), typeof(int));
            Assert.IsTrue(Number.RandomNumber() >= 0);
        }

        [TestMethod]
        public void RandomNumber2()
        {
            Assert.IsInstanceOfType(Number.RandomNumber(10), typeof(int));
            Assert.IsTrue(Number.RandomNumber(10) >= 0);
        }

        [TestMethod]
        public void RandomNumber3()
        {
            Assert.IsInstanceOfType(Number.RandomNumber(0, 10), typeof(int));
            Assert.IsTrue(Number.RandomNumber(0, 10) >= 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void RandomNumberMinMaxFlipped()
        {
            Number.RandomNumber(10, 0);
        }
    }
}
