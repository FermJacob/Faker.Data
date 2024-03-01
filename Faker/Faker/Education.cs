//-----------------------------------------------------------------------
// <copyright file="Education.cs">
//     Copyright (c) 2024 Jacob Ferm, All rights Reserved
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
        private static readonly object majorLock = new();
        private static List<string> major;

        /// <summary>
        /// Gets a random major
        /// </summary>
        /// <returns>A string value</returns>
        public static string Major()
        {
            lock (majorLock)
            {
                major ??= XML.GetListString("Education", "Majors");

                return major[Number.RandomNumber(0, major.Count - 1)];
            }
        }
    }
}
