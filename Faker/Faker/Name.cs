//-----------------------------------------------------------------------
// <copyright file="Name.cs">
//     Copyright (c) 2016 Jacob Ferm, All rights Reserved
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace Faker
{
    /// <summary>
    /// Static name class
    /// </summary>
    public static class Name
    {
        private static List<string> maleFirstName;
        private static List<string> femaleFirstName;
        private static List<string> firstName;
        private static List<string> lastName;
        private static List<string> ethnicity;

        /// <summary>
        /// Gets a random male first name
        /// </summary>
        /// <returns>A string value</returns>
        public static string MaleFirstName()
        {
            if (maleFirstName == null)
            {
                maleFirstName = XML.GetListString("MaleFirstName");
            }

            return maleFirstName[Number.RandomNumber(0, maleFirstName.Count - 1)];
        }

        /// <summary>
        /// Gets a random female first name
        /// </summary>
        /// <returns>A string value</returns>
        public static string FemaleFirstName()
        {
            if (femaleFirstName == null)
            {
                femaleFirstName = XML.GetListString("FemaleFirstName");
            }

            return femaleFirstName[Number.RandomNumber(0, femaleFirstName.Count - 1)];
        }

        /// <summary>
        /// Gets a random last name
        /// </summary>
        /// <returns>A string value</returns>
        public static string LastName()
        {
            if (lastName == null)
            {
                lastName = XML.GetListString("LastName");
            }

            return lastName[Number.RandomNumber(0, lastName.Count - 1)];
        }

        /// <summary>
        /// Gets a random full name
        /// </summary>
        /// <returns>A string value</returns>
        public static string FullName()
        {
            return FirstName() + LastName();
        }

        /// <summary>
        /// Gets a random first name
        /// </summary>
        /// <returns>A string value</returns>
        public static string FirstName()
        {
            if (firstName == null)
            {
                firstName = new List<string>();
                firstName.AddRange(XML.GetListString("FemaleFirstName"));
                firstName.AddRange(XML.GetListString("MaleFirstName"));
            }

            return firstName[Number.RandomNumber(0, firstName.Count - 1)];
        }

        /// <summary>
        /// Gets a random gender
        /// </summary>
        /// <returns>A string value</returns>
        public static string Gender()
        {
            if (Number.Bool())
            {
                return "Male";
            }

            return "Female";
        }

        /// <summary>
        /// Gets a random ethnicity
        /// </summary>
        /// <returns>A string value</returns>
        public static string Ethnicity()
        {
            if (ethnicity == null)
            {
                ethnicity = XML.GetListString("Person", "Ethnicity");
            }

            return ethnicity[Number.RandomNumber(0, ethnicity.Count - 1)];
        }
    }
}
