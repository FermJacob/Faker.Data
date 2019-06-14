//-----------------------------------------------------------------------
// <copyright file="ImageTests.cs">
//     Copyright (c) 2019 Jacob Ferm, All rights Reserved
// </copyright>
//-----------------------------------------------------------------------
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics.CodeAnalysis;
using System.Drawing.Imaging;

namespace Faker.Tests
{
    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "*", Justification = "Reviewed")]
    [TestClass]
    public class ImageTests
    {
        [TestMethod]
        public void PNGTest()
        {
            Assert.IsTrue(Images.PNG().RawFormat.Equals(ImageFormat.Png));
        }

        [TestMethod]
        public void BMPTest()
        {
            Assert.IsTrue(Images.BMP().RawFormat.Equals(ImageFormat.Bmp));
        }

        [TestMethod]
        public void JPEGTest()
        {
            Assert.IsTrue(Images.JPEG().RawFormat.Equals(ImageFormat.Jpeg));
        }
    }
}
