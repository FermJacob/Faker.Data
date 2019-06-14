//-----------------------------------------------------------------------
// <copyright file="StringExtensions.cs">
//     Copyright (c) 2019 Jacob Ferm, All rights Reserved
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
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
            StringBuilder builder = new StringBuilder(str.Length);

            foreach (char c in str.ToCharArray())
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
            return numberString.Replace('#', () => Number.RandomNumber(10).ToString().ToCharArray()[0]);
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
    }
}
