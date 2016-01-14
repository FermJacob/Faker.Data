//-----------------------------------------------------------------------
// <copyright file="Color.cs">
//     Copyright (c) 2016 Jacob Ferm, All rights Reserved
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace Faker
{
    /// <summary>
    /// Static color class
    /// </summary>
    public static class Color
    {
        private static Random random = new Random();

        /// <summary>
        /// Get a set of RGB colors 
        /// </summary>
        /// <returns>Returns an integer array of numbers 0 - 255</returns>
        public static int[] RGB()
        {
            int[] rgbColor = new int[] { Number.RandomNumber(0, 255), Number.RandomNumber(0, 255), Number.RandomNumber(0, 255) };
            return rgbColor;
        }

        /// <summary>
        /// Get a random HEX number
        /// </summary>
        /// <returns>A HEX number as a string</returns>
        public static string Hex()
        {
            List<string> codes = new List<string> { "A", "B", "C", "D", "E", "F", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
            StringBuilder color = new StringBuilder();

            for (int i = 0; i < 6; i++)
            {
                color.Append(codes[random.Next(codes.Count - 1)]);
            }

            return color.ToString();
        }
    }
}
