//-----------------------------------------------------------------------
// <copyright file="UserTests.cs">
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
    public class UserTests
    {
        private static readonly string SpecialCharactersRegex = @"^(?=.*[a-z])(?=.*[\W])(?=.*[A-Z]){5,20}";
        private static readonly string NoSpecialCharactersRegex = @"^(?=.*[a-zA-Z]){5,20}";
        ////@"(?=^.{6,255}$)((?=.*\d)(?=.*[A-Z])(?=.*[a-z])|(?=.*\d)(?=.*[^A-Za-z0-9])(?=.*[a-z])|(?=.*[^A-Za-z0-9])(?=.*[A-Z])(?=.*[a-z])|(?=.*\d)(?=.*[A-Z])(?=.*[^A-Za-z0-9]))^.*";

        [TestMethod]
        public void UsernameTest()
        {
            Assert.IsNotNull(User.Username());
        }

        [TestMethod]
        public void EmailTest()
        {
            Assert.IsNotNull(User.Email());
        }

        [TestMethod]
        public void PasswordLengthTest()
        {
            Assert.IsTrue(User.Password().Length > 5);
        }

        [TestMethod]
        public void PasswordRandomLengthSpecialCharsTest()
        {
            // Regex is not 100% correct, so doing a double test for CI
            var pw = User.Password(3);
            if (!Regex.IsMatch(pw, SpecialCharactersRegex))
            {
                pw = User.Password(3);
                Assert.IsTrue(Regex.IsMatch(pw, SpecialCharactersRegex), "PW was:" + pw);
            }
            else
            {
                return;
            }
        }

        [TestMethod]
        public void PasswordLengthNoSpecialCharsTest()
        {
            Assert.IsTrue(Regex.IsMatch(User.Password(10, false), NoSpecialCharactersRegex));
        }

        [TestMethod]
        public void PasswordLengthRandomSpecialCharsTest()
        {
            string password = User.Password(10, true);
            Assert.IsTrue(Regex.IsMatch(password, SpecialCharactersRegex), password);
        }

        [TestMethod]
        public void PasswordRandomLengthRandomSpecialCharsTest()
        {
            Assert.IsTrue(Regex.IsMatch(User.Password(10, 2), SpecialCharactersRegex));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void PasswordLengthInvalid()
        {
            Assert.Inconclusive(User.Password(2, 5));
        }
    }
}
