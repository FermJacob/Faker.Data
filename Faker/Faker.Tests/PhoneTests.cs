//-----------------------------------------------------------------------
// <copyright file="PhoneTests.cs">
//     Copyright (c) 2019 Jacob Ferm, All rights Reserved
// </copyright>
//-----------------------------------------------------------------------
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics.CodeAnalysis;

namespace Faker.Tests
{
    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "*", Justification = "Reviewed")]
    [TestClass]
    public class PhoneTests
    {
        [TestMethod]
        public void ShortPhone()
        {
            var temp = Phone.GetShortPhoneNumber();
        }
    }
}
