using System;
using System.Collections.Generic;

namespace Faker
{
    public static class Address
    {

        private static Random random = new Random();
        private static List<string> stateAbbreviations;
        private static List<string> streetName;
        private static List<string> states = null;


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

        public static string StreetName()
        {
            if (streetName == null)
            {
                streetName = XML.GetListString("StreetName");

            }
            return streetName[random.Next(0, streetName.Count - 1)];
        }












    }
}
