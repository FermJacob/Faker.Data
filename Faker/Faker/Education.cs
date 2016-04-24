//-----------------------------------------------------------------------
// <copyright file="Education.cs">
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
    /// Static education class
    /// </summary>
    public static class Education
    {
        // Degree short
        // Degree
        // Major
        // School College
        // School HS
        // US School Generic
        private static object majorLock = new object();
        private static List<string> major;

        /// <summary>
        /// Gets a random major
        /// </summary>
        /// <returns>A string value</returns>
        public static string Major()
        {
            lock (majorLock)
            {
                if (major == null)
                {
                    major = XML.GetListString("Education", "Majors");
                }

                return major[Number.RandomNumber(0, major.Count - 1)];
            }
        }
    }
}
