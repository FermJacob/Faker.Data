//-----------------------------------------------------------------------
// <copyright file="Finance.cs">
//     Copyright (c) 2019 Jacob Ferm, All rights Reserved
// </copyright>
//-----------------------------------------------------------------------
using Faker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Faker
{
    /// <summary>
    /// Static finance class
    /// </summary>
    public static class Finance
    {
        private static object yearAdjustableRateLock = new object();
        private static List<YearAdjustable51> yearAdjustable51;
        private static HttpClient client = new HttpClient();

        // Account Name
        // Amount
        // Transaction Type
        // Interest Rate
        // Type (CD, Mutual, 401k, etc)
        private static List<string> types = new List<string>()
        {
            "Checking",
            "Savings",
            "CD",
            "Money Market",
            "IRA",
            "Cash",
            "Mutual",
            "401K"
        };

        /// <summary>
        /// Gets a random type
        /// </summary>
        /// <returns>A <see cref="string"/></returns>
        public static string Type()
        {
            return types[Number.RandomNumber(0, types.Count - 1)];
        }

        /// <summary>
        /// Gets a random 5 to 1 year adjustable mortgage rate
        /// </summary>
        /// <returns>A <see cref="double"/></returns>
        public static double FiveOneYearAdjustableRateMortgage()
        {
            lock (yearAdjustableRateLock)
            {
                if (yearAdjustable51 == null)
                {
                    LoadYearAdjustable51();
                }

                return yearAdjustable51[Number.RandomNumber(0, yearAdjustable51.Count)].Percentage;
            }
        }

        /// <summary>
        /// Gets a Year adjustable rate
        /// </summary>
        /// <param name="date">A <see cref="DateTime"/> to use</param>
        /// <returns>A <see cref="double"/></returns>
        public static double YearAdjustableRate51(DateTime date)
        {
            lock (yearAdjustableRateLock)
            {
                if (yearAdjustable51 == null)
                {
                    LoadYearAdjustable51();
                }

                var closestDate = yearAdjustable51.OrderBy(t => Math.Abs((t.Date - date).Ticks)).First();

                return yearAdjustable51[yearAdjustable51.FindIndex(x => x.Date == closestDate.Date)].Percentage;
            }
        }

        /// <summary>
        /// Makes an API call if provided to pull data
        /// </summary>
        private static void LoadYearAdjustable51()
        {
            if (Config.DoesKeyExist("QuandlAPIKey"))
            {
                try
                {
                    // Fix this when moving to .Net Standard.  The version of .Net Framework being used here does not enable TLS1.2 by default
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                    string url = GetAPIString("https://www.quandl.com/api/v3/datasets/FMAC/5US.json");

                    var result = RunRequest(url).Content.ReadAsAsync<YearAdjustable51JSON>().Result;
                    yearAdjustable51 = new List<Models.YearAdjustable51>();
                    foreach (var i in result.DataSet.data)
                    {
                        yearAdjustable51.Add(new Models.YearAdjustable51()
                        {
                            Date = Convert.ToDateTime(i[0]),
                            Percentage = Convert.ToDouble(i[1])
                        });
                    }

                    return;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Something happened pulling API data: {0}", e.Message);
                }
            }

            var data = XML.GetListObject("Finance", "YearAdjustable51");
            var serializer = new XmlSerializer(typeof(YearAdjustable51));
            yearAdjustable51 = new List<Models.YearAdjustable51>();

            foreach (var i in data)
            {
                yearAdjustable51.Add((YearAdjustable51)serializer.Deserialize(i.CreateReader()));
            }
        }

        private static string GetAPIString(string url)
        {
            string apiKey = Config.GetValue("QuandlAPIKey", string.Empty);
            if (string.IsNullOrEmpty(apiKey))
            {
                return url;
            }
            else
            {
                return url + "?api_key=" + apiKey;
            }
        }

        private static HttpResponseMessage RunRequest(string url)
        {
            return client.GetAsync(url).Result;
        }
    }
}
