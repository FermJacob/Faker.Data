//-----------------------------------------------------------------------
// <copyright file="ColorTests.cs">
//     Copyright (c) 2016 Jacob Ferm, All rights Reserved
// </copyright>
//-----------------------------------------------------------------------
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;

namespace Faker.Tests
{
    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "*", Justification = "Reviewed")]
    [TestClass]
    public class ColorTests
    {
        [TestMethod]
        public void ColorRgb()
        {
            int i = 0;
            int[] rgb = Colors.RGB();
            foreach (int code in rgb)
            {
                i++;
                Assert.IsTrue(code >= 0 && code <= 255);
            }

            Assert.AreEqual(3, i);
        }

        [TestMethod]
        public void ColorHex()
        {
            string hex = Colors.Hex();
            Assert.IsTrue(Regex.IsMatch(hex, @"[A-F0-9]+"), "Hex color is: {0}", hex);
            Assert.AreEqual(hex.Length, 6);
        }

        [TestMethod]
        public void SystemColor()
        {
            Assert.IsNotNull(Colors.SystemColor());
        }

        [TestMethod]
        public void ColorString()
        {
            Assert.IsNotNull(Colors.ColorString());
        }
    }
}
