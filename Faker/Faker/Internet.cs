//-----------------------------------------------------------------------
// <copyright file="Internet.cs">
//     Copyright (c) 2016 Jacob Ferm, All rights Reserved
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker
{
    /// <summary>
    /// Static internet class
    /// </summary>
    public static class Internet
    {
        // Domain name
        // Domain suffix
        // IPv4 address
        // IPv6 address
        // Mac address
        // Protocol
        // Url
        private static object hostsLock = new object();
        private static List<string> hosts;

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
                    hosts = XML.GetListString("User", "Host");
                }

                return hosts[Number.RandomNumber(0, hosts.Count - 1)];
            }
        }
    }
}
