//-----------------------------------------------------------------------
// <copyright file="Education.cs">
//     Copyright (c) 2024 Jacob Ferm, All rights Reserved
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;

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
        private static readonly Lazy<List<string>> major = new(() => XML.GetListString("Education", "Majors"));

        /// <summary>
        /// Gets a random major
        /// </summary>
        /// <returns>A string value</returns>
        public static string Major()
        {
            return major.Value[Number.RandomNumber(0, major.Value.Count - 1)];
        }
    }
}
