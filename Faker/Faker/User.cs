//-----------------------------------------------------------------------
// <copyright file="User.cs">
//     Copyright (c) 2024 Jacob Ferm, All rights Reserved
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Text.RegularExpressions;

namespace Faker
{
    /// <summary>
    /// Static user class
    /// </summary>
    public static class User
    {
        private static readonly Regex nonWordCharacterRegex = new Regex(@"\W", RegexOptions.Compiled);

        /// <summary>
        /// Gets an email address
        /// </summary>
        /// <returns>An email address as a string</returns>
        public static string Email()
        {
            return Number.RandomNumber(2) switch
            {
                0 => $"{Username()}@{Internet.Host()}",
                1 => $"{Username()}{Number.RandomNumber(1, 10)}@{Internet.Host()}",
                _ => throw new ApplicationException(),
            };
        }

        /// <summary>
        /// Gets a random username
        /// </summary>
        /// <returns>A username as a string</returns>
        public static string Username()
        {
            return Number.RandomNumber(5) switch
            {
                0 => nonWordCharacterRegex.Replace(Name.FirstName(), string.Empty).ToLower(),
                1 => nonWordCharacterRegex.Replace($"{Name.FirstName()}{Name.LastName()}", string.Empty).ToLower(),
                2 => nonWordCharacterRegex.Replace($"{Name.LastName()}{Name.FirstName()}", string.Empty).ToLower(),
                3 => $"{Name.LastName()}.{Name.FirstName()}",
                4 => $"{Name.FirstName()}.{Name.LastName()}",
                _ => throw new ApplicationException(),
            };
        }

        /// <summary>
        /// Gets a random password
        /// </summary>
        /// <param name="length">Length of password</param>
        /// <param name="numberOfSpecialChars">Number of special characters to use</param>
        /// <returns>String of password</returns>
        public static string Password(int length, int numberOfSpecialChars)
        {
            return GeneratePassword(length, numberOfSpecialChars);
        }

        /// <summary>
        /// Gets a random password
        /// </summary>
        /// <param name="length">Length of password</param>
        /// <param name="useSpecialChars">Use special characters.  If true, random number of characters</param>
        /// <returns>Password as string</returns>
        public static string Password(int length, bool useSpecialChars)
        {
            return Password(length, useSpecialChars ? Number.RandomNumber(1, 5) : 0);
        }

        /// <summary>
        /// Gets a random password.  Will create a password 5 - 20 characters
        /// </summary>
        /// <param name="numberOfSpecialChars">Number of special characters</param>
        /// <returns>Password as string</returns>
        public static string Password(int numberOfSpecialChars)
        {
            return Password(Number.RandomNumber(6, 20), numberOfSpecialChars);
        }

        /// <summary>
        /// Gets a random password
        /// Random length and number of special characters
        /// </summary>
        /// <returns>Password as string</returns>
        public static string Password()
        {
            return Password(Number.RandomNumber(6, 20), Number.RandomNumber(5));
        }

        /// <summary>
        /// Generate password method
        /// </summary>
        /// <param name="length">Length to use</param>
        /// <param name="nonAlphaNumericChars">Number of special characters</param>
        /// <returns>Password as string</returns>
        private static string GeneratePassword(int length, int nonAlphaNumericChars)
        {
            string allowedChars = "abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNOPQRSTUVWXYZ0123456789";
            string allowedNonAlphaNum = "!@#$%^&*()_-+=[{]};:<>|./?";

            if (nonAlphaNumericChars > length || length <= 0 || nonAlphaNumericChars < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            char[] pass = new char[length];
            Random rand = new Random();

            for (int i = 0; i < length - nonAlphaNumericChars; i++)
            {
                pass[i] = allowedChars[rand.Next(allowedChars.Length)];
            }

            for (int i = length - nonAlphaNumericChars; i < length; i++)
            {
                pass[i] = allowedNonAlphaNum[rand.Next(allowedNonAlphaNum.Length)];
            }

            // Shuffle the array
            for (int i = 0; i < pass.Length; i++)
            {
                int j = rand.Next(i, pass.Length);
                char temp = pass[i];
                pass[i] = pass[j];
                pass[j] = temp;
            }

            return new string(pass);
        }
    }
}
