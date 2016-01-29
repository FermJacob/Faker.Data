//-----------------------------------------------------------------------
// <copyright file="Utilities.cs">
//     Copyright (c) 2016 Jacob Ferm, All rights Reserved
// </copyright>
//-----------------------------------------------------------------------
using System.Text.RegularExpressions;

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
    }
}
