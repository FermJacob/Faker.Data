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

        [TestMethod]
        public void ColorRgb()
        {
            int i = 0;
            int[] rgb = Color.RGB();
            foreach (int code in rgb)
            {
                i++;
                Assert.IsTrue(ColorCheck(code));
            }
            Assert.AreEqual(3, i);
        }

        [TestMethod]
        public void ColorHex()
        {
            string hex = Color.Hex();
            Assert.IsTrue(Regex.IsMatch(hex, @"[A-F0-9]+"), "Hex color is: {0}",hex);
            Assert.AreEqual(hex.Length, 6);
        }

        public static bool ColorCheck(int code)
        {
            if (code >= 0 && code <= 255)
            {
                return true;
            }
            return false;
        }
    }
}
