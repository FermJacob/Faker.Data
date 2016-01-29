//-----------------------------------------------------------------------
// <copyright file="User.cs">
//     Copyright (c) 2016 Jacob Ferm, All rights Reserved
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
        /// <summary>
        /// Gets an email address
        /// </summary>
        /// <returns>An email address as a string</returns>
        public static string Email()
        {
            switch (Number.RandomNumber(2))
            {
                case 0:
                    return string.Format("{0}@{1}", Username(), Internet.Host());
                case 1:
                    return string.Format("{0}{1}@{2}", Username(), Number.RandomNumber(1, 10), Internet.Host());
                default: throw new ApplicationException();
            }
        }

        /// <summary>
        /// Gets a random username
        /// </summary>
        /// <returns>A username as a string</returns>
        public static string Username()
        {
            switch (Number.RandomNumber(5))
            {
                case 0:
                    return new Regex(@"\W").Replace(Name.FirstName(), string.Empty).ToLower();
                case 1:

                    return new Regex(@"\W").Replace(Name.FirstName() + Name.LastName(), string.Empty).ToLower();
                case 2:
                    return new Regex(@"\W").Replace(Name.LastName() + Name.FirstName(), string.Empty).ToLower();
                case 3:
                    return string.Format("{0}.{1}", Name.LastName(), Name.FirstName());
                case 4:
                    return string.Format("{0}.{1}", Name.FirstName(), Name.LastName());
                default: throw new ApplicationException();
            }
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
            if (useSpecialChars)
            {
                return Password(length, Number.RandomNumber(5));
            }

            return Password(length, 0);
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
            int[] pos = new int[length];
            int i = 0, j = 0, temp = 0;
            bool flag = false;

            // Random the position values of the pos array for the string Pass
            while (i < length - 1)
            {
                j = 0;
                flag = false;
                temp = Number.RandomNumber(0, length);
                for (j = 0; j < length; j++)
                {
                    if (temp == pos[j])
                    {
                        flag = true;
                        j = length;
                    }
                }

                if (!flag)
                {
                    pos[i] = temp;
                    i++;
                }
            }

            // Random the AlphaNumericChars
            for (i = 0; i < length - nonAlphaNumericChars; i++)
            {
                pass[i] = allowedChars[Number.RandomNumber(0, allowedChars.Length)];
            }

            // Random the NonAlphaNumericChars
            for (i = length - nonAlphaNumericChars; i < length; i++)
            {
                pass[i] = allowedNonAlphaNum[Number.RandomNumber(0, allowedNonAlphaNum.Length)];
            }

            // Set the sorted array values by the pos array for the rigth posistion
            char[] sorted = new char[length];
            for (i = 0; i < length; i++)
            {
                sorted[i] = pass[pos[i]];
            }

            string password = new string(sorted);

            return password;
        }
    }
}
