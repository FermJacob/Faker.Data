//-----------------------------------------------------------------------
// <copyright file="InternetTests.cs">
//     Copyright (c) 2019 Jacob Ferm, All rights Reserved
// </copyright>
//-----------------------------------------------------------------------
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Text.RegularExpressions;

namespace Faker.Tests
{
    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "*", Justification = "Reviewed")]
    [TestClass]
    public class InternetTests
    {
        [TestMethod]
        public void IPv4Test()
        {
            IPAddress ip;
            Assert.IsTrue(IPAddress.TryParse(Internet.IPv4(), out ip));
            Assert.IsTrue(ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork);
            Assert.IsTrue(Regex.IsMatch(Internet.IPv4(), @"^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$"));
        }

        [TestMethod]
        public void IPv6Test()
        {
            IPAddress ip;
            Assert.IsTrue(IPAddress.TryParse(Internet.IPv6(), out ip));
            Assert.IsTrue(ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetworkV6);
        }

        [TestMethod]
        public void HostTest()
        {
            Assert.IsNotNull(Internet.Host());
        }

        [TestMethod]
        public void TopDomainSuffixTest()
        {
            Assert.IsNotNull(Internet.TopDomainSuffix());
        }

        [TestMethod]
        public void TopCountryDomainSuffix()
        {
            Assert.IsNotNull(Internet.TopCountryDomainSuffix());
        }

        [TestMethod]
        public void DomainSuffix()
        {
            Assert.IsNotNull(Internet.DomainSuffix());
        }

        [TestMethod]
        public void Mac()
        {
            Assert.IsTrue(Regex.IsMatch(Internet.Mac(), "^(?:[0-9a-fA-F]{2}:){5}[0-9a-fA-F]{2}|(?:[0-9a-fA-F]{2}-){5}[0-9a-fA-F]{2}|(?:[0-9a-fA-F]{2}){5}[0-9a-fA-F]{2}$"));
        }

        [TestMethod]
        public void LocalHost()
        {
            Assert.IsTrue(Internet.LocalHost().Equals("127.0.0.1"));
        }

        [TestMethod]
        public void Protocol()
        {
            Assert.IsNotNull(Internet.Protocol());
        }

        [TestMethod]
        public void DomainUrl()
        {
            Assert.IsTrue(Regex.IsMatch(Internet.DomainUrl(), @"^(?:http(s)?:\/\/)?[\w.-]+(?:\.[\w\.-]+)+[\w\-\._~:/?#[\]@!\$&'\(\)\*\+,;=.]+$"));
        }

        [TestMethod]
        public void SubDomainUrl()
        {
            var url = Internet.SubDomainUrl();
            Console.WriteLine(url);
            Assert.IsTrue(Regex.IsMatch(url, @"^(?:http(s)?:\/\/)?[\w.-]+(?:\.[\w\.-]+)+[\w\-\._~:/?#[\]@!\$&'\(\)\*\+,;=.]+$"));
        }

        [TestMethod]
        public void DomainUrlCountry()
        {
            Assert.IsTrue(Regex.IsMatch(Internet.DomainUrl(true), @"^(?:http(s)?:\/\/)?[\w.-]+(?:\.[\w\.-]+)+[\w\-\._~:/?#[\]@!\$&'\(\)\*\+,;=.]+$"));
        }

        [TestMethod]
        public void SubDomainUrlCountry()
        {
            var url = Internet.SubDomainUrl(true);
            Console.WriteLine(url);
            Assert.IsTrue(Regex.IsMatch(url, @"^(?:http(s)?:\/\/)?[\w.-]+(?:\.[\w\.-]+)+[\w\-\._~:/?#[\]@!\$&'\(\)\*\+,;=.]+$"));
        }

        [TestMethod]
        public void BrowserProtocol()
        {
            Assert.IsNotNull(Internet.BrowserProtocol());
        }

        [TestMethod]
        public void UrlWithPath()
        {
            var url = Internet.UrlWithPath();
            Console.WriteLine(url);
            Assert.IsTrue(Regex.IsMatch(url, @"^(?:http(s)?:\/\/)?[\w.-]+(?:\.[\w\.-]+)+[\w\-\._~:/?#[\]@!\$&'\(\)\*\+,;=.]+$"));
        }
    }
}
