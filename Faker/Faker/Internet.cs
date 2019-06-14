//-----------------------------------------------------------------------
// <copyright file="Internet.cs">
//     Copyright (c) 2019 Jacob Ferm, All rights Reserved
// </copyright>
//-----------------------------------------------------------------------
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Faker
{
    /// <summary>
    /// Static internet class
    /// </summary>
    public static class Internet
    {
        // Domain name
        // Url
        private static object topDomainSuffixLock = new object();
        private static List<string> topDomainSuffix;
        private static object hostsLock = new object();
        private static List<string> hosts;
        private static object topCountryDomainSuffixLock = new object();
        private static List<string> topCountryDomainSuffix;
        private static object domainSuffixLock = new object();
        private static List<string> domainSuffix;

        /// <summary>
        /// Gets a random host
        /// </summary>
        /// <returns>Host as string</returns>
        public static string Host()
        {
            lock (hostsLock)
            {
                if (hosts == null)
                {
                    hosts = XML.GetListString("Internet", "Host");
                }

                return hosts[Number.RandomNumber(0, hosts.Count - 1)];
            }
        }

        /// <summary>
        /// Gets a random IP v4 address
        /// </summary>
        /// <returns>IP v4 address as string</returns>
        public static string IPv4()
        {
            return string.Format("{0}.{1}.{2}.{3}", Number.RandomNumber(255), Number.RandomNumber(255), Number.RandomNumber(255), Number.RandomNumber(255));
        }

        /// <summary>
        /// Gets a random top domain suffix
        /// </summary>
        /// <returns>Top domain suffix as string</returns>
        public static string TopDomainSuffix()
        {
            lock (topDomainSuffixLock)
            {
                if (topDomainSuffix == null)
                {
                    topDomainSuffix = XML.GetListString("Internet", "TopDomainSuffix");
                }

                return topDomainSuffix[Number.RandomNumber(0, topDomainSuffix.Count - 1)];
            }
        }

        /// <summary>
        /// Gets a random top country domain suffix
        /// </summary>
        /// <returns>Top country domain suffix as string</returns>
        public static string TopCountryDomainSuffix()
        {
            lock (topCountryDomainSuffixLock)
            {
                if (topCountryDomainSuffix == null)
                {
                    topCountryDomainSuffix = XML.GetListString("Internet", "CountryDomainSuffix");
                }

                return topCountryDomainSuffix[Number.RandomNumber(0, topCountryDomainSuffix.Count - 1)];
            }
        }

        /// <summary>
        /// Gets a random  domain suffix
        /// </summary>
        /// <returns>Domain suffix as string</returns>
        public static string DomainSuffix()
        {
            lock (domainSuffixLock)
            {
                if (domainSuffix == null)
                {
                    domainSuffix = XML.GetListString("Internet", "DomainSuffix");
                }

                return domainSuffix[Number.RandomNumber(0, domainSuffix.Count - 1)];
            }
        }

        /// <summary>
        /// Gets a random IP v6 address
        /// </summary>
        /// <returns>IP v6 address as string</returns>
        public static string IPv6()
        {
            int max = 65536;
            string[] parts = new string[]
            {
                Number.RandomNumber(max).ToString("x"),
                Number.RandomNumber(max).ToString("x"),
                Number.RandomNumber(max).ToString("x"),
                Number.RandomNumber(max).ToString("x"),
                Number.RandomNumber(max).ToString("x"),
                Number.RandomNumber(max).ToString("x"),
                Number.RandomNumber(max).ToString("x"),
                Number.RandomNumber(max).ToString("x"),
            };

            return string.Join(":", parts);
        }

        /// <summary>
        /// Gets a random MAC address
        /// </summary>
        /// <returns>MAC address as string</returns>
        public static string Mac()
        {
            string[] arr = new string[]
            {
                Number.RandomNumber(0, 255).ToString("x2"),
                Number.RandomNumber(0, 255).ToString("x2"),
                Number.RandomNumber(0, 255).ToString("x2"),
                Number.RandomNumber(0, 255).ToString("x2"),
                Number.RandomNumber(0, 255).ToString("x2"),
                Number.RandomNumber(0, 255).ToString("x2")
            };
            
            return string.Join(":", arr);
        }

        /// <summary>
        /// Gets the local host address
        /// </summary>
        /// <returns>Local host address as string</returns>
        public static string LocalHost()
        {
            return "127.0.0.1";
        }

        /// <summary>
        /// Gets a random protocol
        /// </summary>
        /// <returns>Protocol as string</returns>
        public static string Protocol()
        {
            string[] protocols = new string[] { "http", "https", "ftp", "ssh" };

            return protocols[Number.RandomNumber(protocols.Count())];
        }

        /// <summary>
        /// Gets a random browser protocol
        /// </summary>
        /// <returns>Browser protocol as a string</returns>
        public static string BrowserProtocol()
        {
            string[] protocols = new string[] { "http", "https" };

            return protocols[Number.RandomNumber(protocols.Count())];
        }

        /// <summary>
        /// Gets a random domain url
        /// </summary>
        /// <returns>Domain url as a string</returns>
        public static string DomainUrl()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(BrowserProtocol());
            sb.Append("://");
            sb.Append(Company.CatchPhrase());
            sb.Append(TopDomainSuffix());
            return sb.ToString();
        }
    }
}
