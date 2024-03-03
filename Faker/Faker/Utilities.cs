//-----------------------------------------------------------------------
// <copyright file="Utilities.cs">
//     Copyright (c) 2024 Jacob Ferm, All rights Reserved
// </copyright>
//-----------------------------------------------------------------------
using Faker.Extensions;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Faker
{
    /// <summary>
    /// Static utilities class
    /// </summary>
    public static class Utilities
    {
        private static readonly string allowedChars = "abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNOPQRSTUVWXYZ0123456789";
        private static readonly Regex numerifyRegex = new Regex("#", RegexOptions.Compiled);
        private static readonly Regex slugifyRegex = new Regex(@"[^a-zA-Z0-9\.\-_]+", RegexOptions.Compiled);

        /// <summary>
        /// Gets a random alpha character
        /// </summary>
        /// <returns>Character to use</returns>
        public static char Character()
        {
            int num = Number.RandomNumber(0, 26); // Zero to 25
            char val = (char)('a' + num);
            return val;
        }

        /// <summary>
        /// Gets a random alpha numeric char
        /// </summary>
        /// <returns>A random char</returns>
        public static char AlphaNumeric()
        {
            return allowedChars[Number.RandomNumber(allowedChars.Length)];
        }

        /// <summary>
        /// Method not implemented
        /// </summary>
        /// <param name="s">String to use</param>
        /// <returns>String numbered</returns>
        public static string Numerify(this string s)
        {
            return numerifyRegex.Replace(s, m => Number.RandomNumber(0, 9).ToString());
        }

        /// <summary>
        /// Slugifies the string text as valid URLs -- IE: "Hello World" -> "Hello-World".
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string Slugify(string text)
        {
            var str = text.Replace(" ", "-").RemoveDiacritics();
            return slugifyRegex.Replace(str, "");
        }

        /// <summary>
        /// Takes a list of strings and adds separator between the works
        /// </summary>
        /// <param name="parts">List of parts</param>
        /// <param name="separator">Separator to use</param>
        /// <returns>String of slashified items from list</returns>
        public static string Slashify(IEnumerable<string> parts, string separator = "/")
        {
            return string.Join(separator, parts);
        }
    }
}
