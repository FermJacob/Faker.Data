//-----------------------------------------------------------------------
// <copyright file="CreditCardTests.cs">
//     Copyright (c) 2019 Jacob Ferm, All rights Reserved
// </copyright>
//-----------------------------------------------------------------------
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Faker.Tests
{
    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "*", Justification = "Reviewed")]
    [TestClass]
    public class CreditCardTests
    {
        [TestMethod]
        public void CreditCardType()
        {
            List<string> cards = new List<string>()
            {
                "VISA",
                "MasterCard",
                "American Express"
            };
            Assert.IsTrue(cards.Contains(CreditCard.CreditCardType()));
        }
    }
}
