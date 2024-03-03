//-----------------------------------------------------------------------
// <copyright file="Colors.cs">
//     Copyright (c) 2024 Jacob Ferm, All rights Reserved
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Faker
{
    /// <summary>
    /// Static color class
    /// </summary>
    public static class Colors
    {
        private static readonly Lazy<List<Color>> systemColors = new(LoadSystemColors);
        private static readonly Lazy<List<string>> colors = new(() => XML.GetListString("Color"));

        /// <summary>
        /// Get a set of RGB colors
        /// </summary>
        /// <returns>Returns an integer array of numbers 0 - 255</returns>
        public static int[] RGB()
        {
            int[] rgbColor = { Number.RandomNumber(0, 255), Number.RandomNumber(0, 255), Number.RandomNumber(0, 255) };
            return rgbColor;
        }

        /// <summary>
        /// Get a random HEX number
        /// </summary>
        /// <returns>A HEX number as a string</returns>
        public static string Hex()
        {
            List<string> codes = new() { "A", "B", "C", "D", "E", "F", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
            StringBuilder color = new();

            for (int i = 0; i < 6; i++)
            {
                color.Append(codes[Number.RandomNumber(codes.Count - 1)]);
            }

            return color.ToString();
        }

        /// <summary>
        /// Gets a random system color
        /// </summary>
        /// <returns>A string value</returns>
        public static string SystemColor()
        {
            return systemColors.Value[Number.RandomNumber(0, systemColors.Value.Count - 1)].Name;
        }

        /// <summary>
        /// Gets a random color
        /// </summary>
        /// <returns>A string value</returns>
        public static string ColorString()
        {
            return colors.Value[Number.RandomNumber(0, colors.Value.Count - 1)];
        }

        private static List<Color> LoadSystemColors()
        {
            return typeof(Color).GetProperties(BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Public)
                        .Select(c => (Color)c.GetValue(null, null))
                        .ToList();
        }
    }
}
