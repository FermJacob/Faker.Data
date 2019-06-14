//-----------------------------------------------------------------------
// <copyright file="FuelPrices.cs">
//     Copyright (c) 2019 Jacob Ferm, All rights Reserved
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Xml.Serialization;

namespace Faker
{
    /// <summary>
    /// Static fuel prices class
    /// </summary>
    public static class FuelPrices
    {
        private static object fuelPricesLock = new object();
        private static Models.FuelPricesModel fuelPrices;
        private static HttpClient client = new HttpClient();

        /// <summary>
        /// Gets a compressed natural gas on today's date
        /// </summary>
        /// <returns>A <see cref="double"/></returns>
        public static double CompressedNaturalGas()
        {
            GetFuelPriceData();
            return fuelPrices.CompressedNaturalGas;
        }

        /// <summary>
        /// Gets a E85 on today's date
        /// </summary>
        /// <returns>A <see cref="double"/></returns>
        public static double E85()
        {
            GetFuelPriceData();
            return fuelPrices.E85;
        }

        /// <summary>
        /// Gets a diesel on today's date
        /// </summary>
        /// <returns>A <see cref="double"/></returns>
        public static double Diesel()
        {
            GetFuelPriceData();
            return fuelPrices.Diesel;
        }

        /// <summary>
        /// Gets a electric on today's date
        /// </summary>
        /// <returns>A <see cref="double"/></returns>
        public static double Electric()
        {
            GetFuelPriceData();
            return fuelPrices.Electric;
        }

        /// <summary>
        /// Gets a LPG on today's date
        /// </summary>
        /// <returns>A <see cref="double"/></returns>
        public static double LPG()
        {
            GetFuelPriceData();
            return fuelPrices.LPG;
        }

        /// <summary>
        /// Gets a midgrade on today's date
        /// </summary>
        /// <returns>A <see cref="double"/></returns>
        public static double Midgrade()
        {
            GetFuelPriceData();
            return fuelPrices.Midgrade;
        }

        /// <summary>
        /// Gets a premium on today's date
        /// </summary>
        /// <returns>A <see cref="double"/></returns>
        public static double Premium()
        {
            GetFuelPriceData();
            return fuelPrices.Premium;
        }

        /// <summary>
        /// Gets a regular on today's date
        /// </summary>
        /// <returns>A <see cref="double"/></returns>
        public static double Regular()
        {
            GetFuelPriceData();
            return fuelPrices.Regular;
        }

        /// <summary>
        /// Checks to see if the data exists, if not call the API
        /// </summary>
        private static void GetFuelPriceData()
        {
            lock (fuelPricesLock)
            {
                if (fuelPrices == null)
                {
                    LoadFuelData();
                }
            }
        }

        /// <summary>
        /// Makes an API call if provided to pull data
        /// </summary>
        private static void LoadFuelData()
        {
            try
            {
                // Data from: http://www.fueleconomy.gov/feg/ws/index.shtml
                string url = "http://fueleconomy.gov/ws/rest/fuelprices";

                var result = RunRequest(url).Content.ReadAsStringAsync().Result;

                var buffer = Encoding.UTF8.GetBytes(result);
                using (var stream = new MemoryStream(buffer))
                {
                    var serializer = new XmlSerializer(typeof(Models.FuelPricesModel));
                    fuelPrices = (Models.FuelPricesModel)serializer.Deserialize(stream);
                }

                return;
            }
            catch (Exception e)
            {
                Console.WriteLine("Something happened pulling API data: {0}", e.Message);
            }
        }

        /// <summary>
        /// Runs the request
        /// </summary>
        /// <param name="url">URL to use</param>
        /// <returns>A <see cref="HttpResponseMessage"/></returns>
        private static HttpResponseMessage RunRequest(string url)
        {
            return client.GetAsync(url).Result;
        }
    }
}
