//-----------------------------------------------------------------------
// <copyright file="Address.cs">
//     Copyright (c) 2016 Jacob Ferm, All rights Reserved
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace Faker
{
    /// <summary>
    /// Static class for addresses
    /// </summary>
    public static class Address
    {
        private static List<string> stateAbbreviations;
        private static List<string> streetName;
        private static List<string> states;
        private static List<string> provinceAbbreviations;
        private static List<string> provinces;
        private static List<string> country;
        private static List<string> cityPrefix;
        private static List<string> citySuffix;
        private static List<string> secondaryAddress;
        private static List<string> streetSuffix;
        private static List<string> usZipCode;
        private static List<string> usCity;
        private static List<string> usCounty;

        /// <summary>
        /// Gets a random state
        /// </summary>
        /// <returns>String of a state</returns>
        public static string State()
        {
            if (states == null)
            {
                states = XML.GetListString("Address", "States");
            }

            return states[Number.RandomNumber(0, states.Count - 1)];
        }

        /// <summary>
        /// Gets a random state abbreviation
        /// </summary>
        /// <returns>String of state abbreviation</returns>
        public static string StateAbbreviation()
        {
            if (stateAbbreviations == null)
            {
                stateAbbreviations = XML.GetListString("Address", "StateAbbreviations");
            }

            return stateAbbreviations[Number.RandomNumber(0, stateAbbreviations.Count - 1)];
        }

        /// <summary>
        /// Gets a random province
        /// </summary>
        /// <returns>A string value</returns>
        public static string Province()
        {
            if (provinces == null)
            {
                provinces = XML.GetListString("Provinces");
            }

            return provinces[Number.RandomNumber(0, provinces.Count - 1)];
        }

        /// <summary>
        /// Gets a random province abbreviation
        /// </summary>
        /// <returns>A string value</returns>
        public static string ProvinceAbbreviation()
        {
            if (provinceAbbreviations == null)
            {
                provinceAbbreviations = XML.GetListString("ProvinceAbbreviations");
            }

            return provinceAbbreviations[Number.RandomNumber(0, provinceAbbreviations.Count - 1)];
        }

        /// <summary>
        /// Gets a random street name
        /// </summary>
        /// <returns>A string value</returns>
        public static string StreetName()
        {
            if (streetName == null)
            {
                streetName = XML.GetListString("StreetName");
            }

            return streetName[Number.RandomNumber(0, streetName.Count - 1)];
        }

        /// <summary>
        /// Gets a random Canadian zip
        /// </summary>
        /// <returns>A string value</returns>
        public static string CanadianZipCode()
        {
            List<string> alpha = new List<string>
            {
                "A", "B", "C", "E", "G", "H", "J", "K", "L", "M", "N", "P", "R", "S", "T", "V", "W", "X", "Y", "Z"
            };
            List<int> numeric = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            List<string> alphaFirst = new List<string>
            {
                "A", "B", "C", "E", "G", "H", "J", "K", "L", "M", "N", "P", "R", "S", "T", "V", "X", "Y"
            };
            StringBuilder newZip = new StringBuilder();

            for (int i = 0; i <= 5; i++)
            {
                if (i == 0)
                {
                    newZip.Append(alphaFirst[Number.RandomNumber(0, alphaFirst.Count - 1)]);
                }
                else if ((i % 2) == 0)
                {
                    newZip.Append(alpha[Number.RandomNumber(0, alpha.Count - 1)]);
                }
                else
                {
                    newZip.Append(numeric[Number.RandomNumber(0, numeric.Count - 1)]);
                }
            }

            return newZip.ToString();
        }

        /// <summary>
        /// Gets a random country
        /// </summary>
        /// <returns>A string value</returns>
        public static string Country()
        {
            if (country == null)
            {
                country = XML.GetListString("Country");
            }

            return country[Number.RandomNumber(0, country.Count - 1)];
        }

        /// <summary>
        /// Gets a random city prefix
        /// </summary>
        /// <returns>A string value</returns>
        public static string CityPrefix()
        {
            if (cityPrefix == null)
            {
                cityPrefix = XML.GetListString("CityPrefix");
            }
        
            return cityPrefix[Number.RandomNumber(0, cityPrefix.Count - 1)];
        }

        /// <summary>
        /// Gets a random city suffix
        /// </summary>
        /// <returns>A string value</returns>
        public static string CitySuffix()
        {
            if (citySuffix == null)
            {
                citySuffix = XML.GetListString("CitySuffix");
            }

            return citySuffix[Number.RandomNumber(0, citySuffix.Count - 1)];
        }

        /// <summary>
        /// Gets a random secondary address
        /// </summary>
        /// <returns>A string value</returns>
        public static string SecondaryAddress()
        {
            if (secondaryAddress == null)
            {
                secondaryAddress = XML.GetListString("SecondaryAddress");
            }

            return secondaryAddress[Number.RandomNumber(0, secondaryAddress.Count - 1)] + Number.RandomNumber(0, 1000);
        }

        /// <summary>
        /// Gets a random street suffix
        /// </summary>
        /// <returns>A string value</returns>
        public static string StreetSuffix()
        {
            if (streetSuffix == null)
            {
                streetSuffix = XML.GetListString("StreetSuffix");
            }

            return streetSuffix[Number.RandomNumber(0, streetSuffix.Count - 1)];
        }

        /// <summary>
        /// Gets a random united states zip code
        /// </summary>
        /// <returns>A string value</returns>
        public static string USZipCode()
        {
            if (usZipCode == null)
            {
                usZipCode = XML.GetListString("USZipCode");
            }

            return usZipCode[Number.RandomNumber(0, usZipCode.Count - 1)];
        }

        /// <summary>
        /// Gets a random United States city
        /// </summary>
        /// <returns>A string value</returns>
        public static string USCity()
        {
            if (usCity == null)
            {
                usCity = XML.GetListString("USCity");
            }

            return usCity[Number.RandomNumber(0, usCity.Count - 1)];
        }

        /// <summary>
        /// Gets a random United States county
        /// </summary>
        /// <returns>A string value</returns>
        public static string USCounty()
        {
            if (usCounty == null)
            {
                usCounty = XML.GetListString("USCounty");
            }

            return usCounty[Number.RandomNumber(0, usCounty.Count - 1)];
        }
    }
}
