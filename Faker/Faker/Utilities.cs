//-----------------------------------------------------------------------
// <copyright file="Utilities.cs">
//     Copyright (c) 2019 Jacob Ferm, All rights Reserved
// </copyright>
//-----------------------------------------------------------------------
using System.Configuration;
using System.Text.RegularExpressions;
using Faker.Extensions;
using System.Collections.Generic;

namespace Faker
{
    /// <summary>
    /// Static utilities class
    /// </summary>
    public static class Utilities
    {
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
            string allowedChars = "abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNOPQRSTUVWXYZ0123456789";
            return allowedChars[Number.RandomNumber(allowedChars.Length)];
        }

        /// <summary>
        /// Method not implemented
        /// </summary>
        /// <param name="s">String to use</param>
        /// <returns>String numbered</returns>
        public static string Numerify(this string s)
        {
            return Regex.Replace(s, "#", new MatchEvaluator((m) => Number.RandomNumber(0, 9).ToString()), RegexOptions.Compiled);
        }

        /// <summary>
        /// Slugifies the string text as valid URLs -- IE: "Hello World" -> "Hello-World".
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string Slugify(string text)
        {
            var str = text.Replace(" ", "-").RemoveDiacritics();
            return Regex.Replace(str, @"[^a-zA-Z0-9\.\-_]+", "");
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
