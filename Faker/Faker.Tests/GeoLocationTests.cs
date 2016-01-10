//-----------------------------------------------------------------------
// <copyright file="GeoLocationTests.cs">
//     Copyright (c) 2016 Jacob Ferm, All rights Reserved
// </copyright>
//-----------------------------------------------------------------------
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics.CodeAnalysis;

namespace Faker.Tests
{
    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "*", Justification = "Reviewed")]
    [TestClass]
    public class GeoLocationTests
    {
        [TestMethod]
        public void Lat()
        {
            double lat = GeoLocation.Latitude();
            Assert.IsTrue(lat.ToString().Length <= 9, "Value was not 9 or less characters");
            Assert.IsTrue(lat <= 90 && lat >= -90, "Longitude value was: {0}", lat);
        }

        [TestMethod]
        public void Long()
        {
            double lon = GeoLocation.Longitude();
            Assert.IsTrue(lon.ToString().Length <= 9, "Value was not 9 or less characters");
            Assert.IsTrue(lon <= 180 && lon >= -180, "Longitude value was: {0}", lon);
        }
    }
}
