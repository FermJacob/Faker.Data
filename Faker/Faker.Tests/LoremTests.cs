//-----------------------------------------------------------------------
// <copyright file="LoremTests.cs">
//     Copyright (c) 2016 Jacob Ferm, All rights Reserved
// </copyright>
//-----------------------------------------------------------------------
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics.CodeAnalysis;

namespace Faker.Tests
{
    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "*", Justification = "Reviewed")]
    [TestClass]
    public class LoremTests
    {
        [TestMethod]
        public void Word()
        {
            var result = Lorem.Word();
        }

        [TestMethod]
        public void Words()
        {
            var result = Lorem.Words();
        }

        [TestMethod]
        public void Words1()
        {
            var result = Lorem.Words(3);
        }

        [TestMethod]
        public void Letter()
        {
            var result = Lorem.Letter();
        }

        [TestMethod]
        public void Letters()
        {
            var result = Lorem.Letters(4);
        }

        [TestMethod]
        public void Letters1()
        {
            var result = Lorem.Letters();
        }

        [TestMethod]
        public void Sentence()
        {
            var result = Lorem.Sentence(7);
        }

        [TestMethod]
        public void Sentence1()
        {
            var result = Lorem.Sentence();
        }

        [TestMethod]
        public void Sentences()
        {
            var result = Lorem.Sentences(3);
        }

        [TestMethod]
        public void Sentences1()
        {
            var result = Lorem.Sentences();
        }

        [TestMethod]
        public void Paragraph()
        {
            var result = Lorem.Paragraph(2);
        }

        [TestMethod]
        public void Paragraph1()
        {
            var result = Lorem.Paragraph();
        }

        [TestMethod]
        public void Paragraphs()
        {
            var result = Lorem.Paragraphs();
        }

        [TestMethod]
        public void Paragraphs1()
        {
            var result = Lorem.Paragraphs(2);
        }
    }
}
