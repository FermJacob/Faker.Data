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
        private static Random random = new Random();
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

        public static string State()
        {
            if (states == null)
            {
                states = XML.GetListString("States");
            }

            return states[random.Next(0, states.Count - 1)];
        }

        public static string StateAbbreviation()
        {
            if (stateAbbreviations == null)
            {
                stateAbbreviations = XML.GetListString("StateAbbreviations");
            }

            return stateAbbreviations[random.Next(0, stateAbbreviations.Count - 1)];
        }

        public static string Province()
        {
            if (provinces == null)
            {
                provinces = XML.GetListString("Provinces");
            }

            return provinces[random.Next(0, provinces.Count - 1)];
        }

        public static string ProvinceAbbreviation()
        {
            if (provinceAbbreviations == null)
            {
                provinceAbbreviations = XML.GetListString("ProvinceAbbreviations");
            }

            return provinceAbbreviations[random.Next(0, provinceAbbreviations.Count - 1)];
        }

        public static string StreetName()
        {
            if (streetName == null)
            {
                streetName = XML.GetListString("StreetName");
            }

            return streetName[random.Next(0, streetName.Count - 1)];
        }

        public static string CanadianZipCode()
        {
            Random rand = new Random();
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
                    newZip.Append(alphaFirst[rand.Next(0, alphaFirst.Count - 1)]);
                }
                else if ((i % 2) == 0)
                {
                    newZip.Append(alpha[rand.Next(0, alpha.Count - 1)]);
                }
                else
                {
                    newZip.Append(numeric[rand.Next(0, numeric.Count - 1)]);
                }
            }

            return newZip.ToString();
        }

        public static string Country()
        {
            if (country == null)
            {
                country = XML.GetListString("Country");
            }

            return country[random.Next(0, country.Count - 1)];
        }

        public static string CityPrefix()
        {
            if (cityPrefix == null)
            {
                cityPrefix = XML.GetListString("CityPrefix");
            }
        
            return cityPrefix[random.Next(0, cityPrefix.Count - 1)];
        }

        public static string CitySuffix()
        {
            if (citySuffix == null)
            {
                citySuffix = XML.GetListString("CitySuffix");
            }

            return citySuffix[random.Next(0, citySuffix.Count - 1)];
        }

        public static string SecondaryAddress()
        {
            if (secondaryAddress == null)
            {
                secondaryAddress = XML.GetListString("SecondaryAddress");
            }

            return secondaryAddress[random.Next(0, secondaryAddress.Count - 1)] + random.Next(1000);
        }

        public static string StreetSuffix()
        {
            if (streetSuffix == null)
            {
                streetSuffix = XML.GetListString("StreetSuffix");
            }

            return streetSuffix[random.Next(0, streetSuffix.Count - 1)];
        }

        public static string USZipCode()
        {
            if (usZipCode == null)
            {
                usZipCode = XML.GetListString("USZipCode");
            }

            return usZipCode[random.Next(0, usZipCode.Count - 1)];
        }

        public static string USCity()
        {
            if (usCity == null)
            {
                usCity = XML.GetListString("USCity");
            }

            return usCity[random.Next(0, usCity.Count - 1)];
        }

        public static string USCounty()
        {
            if (usCounty == null)
            {
                usCounty = XML.GetListString("USCounty");
            }

            return usCounty[random.Next(0, usCounty.Count - 1)];
        }
    }
}
