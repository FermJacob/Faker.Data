using System;
using System.Collections.Generic;
using System.Text;

namespace Faker
{
    public static class Address
    {
        private static Random random = new Random();
        private static List<string> stateAbbreviations;
        private static List<string> streetName;
        private static List<string> states = null;
        private static List<string> provinceAbbreviations;
        private static List<string> provinces = null;

        public static string State1()
        {
            List<string> state = XML.GetListString("States");
            return state[random.Next(0, state.Count - 1)];
        }

        public static string State()
        {

            if (states == null)
            {
                states = XML.GetListString("States");

            }
            return states[random.Next(0, states.Count - 1)];
        }

        public static string StateAbbreviations()
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

        public static string ProvinceAbbreviations()
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
            List<string> alpha = new List<string>{"A", "B", "C", "E", "G", "H", "J", "K", "L", "M", "N",
            "P", "R", "S", "T", "V", "W", "X", "Y", "Z" };
            List<int> numeric = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            List<string> alphaFirst = new List<string>{"A", "B", "C", "E", "G", "H", "J", "K", "L", "M", "N",
            "P", "R", "S", "T", "V", "X", "Y" };
            StringBuilder newZip = new StringBuilder("");

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
    }
}
