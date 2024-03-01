//-----------------------------------------------------------------------
// <copyright file="ImageTests.cs">
//     Copyright (c) 2024 Jacob Ferm, All rights Reserved
// </copyright>
//-----------------------------------------------------------------------
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics.CodeAnalysis;
using System.Drawing.Imaging;
using System.Runtime.Versioning;

namespace Faker.Tests
{
    [TestClass]
    [SupportedOSPlatform("windows")]
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
