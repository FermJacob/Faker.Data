//-----------------------------------------------------------------------
// <copyright file="StringExtensions.cs">
//     Copyright (c) 2024 Jacob Ferm, All rights Reserved
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.Extensions
{
    /// <summary>
    /// Static string extension class
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Method to replace a string with an item
        /// </summary>
        /// <param name="str">A <see cref="string"/> to use</param>
        /// <param name="item">A <see cref="char"/></param>
        /// <param name="character">Function to use</param>
        /// <returns>A <see cref="string"/></returns>
        public static string Replace(this string str, char item, Func<char> character)
        {
            StringBuilder builder = new(str.Length);

            foreach (char c in str)
            {
                builder.Append(c == item ? character() : c);
            }

            return builder.ToString();
        }

        /// <summary>
        /// Creates a number based on pound signs
        /// </summary>
        /// <param name="numberString">Number string</param>
        /// <returns>A <see cref="string"/> from specified format</returns>
        public static string Numerify(this string numberString)
        {
            return numberString.Replace('#', () => Number.RandomNumber(10).ToString()[0]);
        }

        /// <summary>
        /// Creates a number based on question marks
        /// </summary>
        /// <param name="letterString">Number string</param>
        /// <returns>A <see cref="string"/> from specified format</returns>
        public static string Letterify(this string letterString)
        {
            return letterString.Replace('?', () => 'a'.To('z').Rand());
        }

        /// <summary>
        /// Combines format
        /// </summary>
        /// <param name="str">A <see cref="string"/></param>
        /// <returns>A <see cref="string"/> from specified format</returns>
        public static string Bothify(this string str)
        {
            return Letterify(Numerify(str));
        }

        /// <summary>
        /// Method to get a list a characters to and from
        /// </summary>
        /// <param name="from">From <see cref="char"/></param>
        /// <param name="to">To <see cref="char"/></param>
        /// <returns>An <see cref="IEnumerable{T}"/> list of characters</returns>
        public static IEnumerable<char> To(this char from, char to)
        {
            for (char i = from; i <= to; i++)
            {
                yield return i;
            }
        }

        /// <summary>
        /// A string extension method that removes the diacritics character from the strings.
        /// </summary>
        /// <param name="str">String to use</param>
        /// <returns>String without diacritices</returns>
        public static string RemoveDiacritics(this string str)
        {
            var normalizedString = str.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();

            foreach (var c in normalizedString)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }
    }
}
