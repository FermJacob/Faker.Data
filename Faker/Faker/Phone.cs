//-----------------------------------------------------------------------
// <copyright file="Phone.cs">
//     Copyright (c) 2024 Jacob Ferm, All rights Reserved
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker
{
    /// <summary>
    /// Static phone class
    /// </summary>
    public static class Phone
    {
        /// <summary>
        /// Gets a random phone number
        /// </summary>
        /// <returns>A <see cref="string"/> of a random phone number</returns>
        public static string GetPhoneNumber()
        {
            return FormatPhoneNumber().Numerify();
        }

        /// <summary>
        /// Gets a short phone number
        /// </summary>
        /// <returns>A <see cref="string"/> of a short phone number</returns>
        public static string GetShortPhoneNumber()
        {
            return "###-###-####".Numerify();
        }

        /// <summary>
        /// Gets a random phone number format
        /// </summary>
        /// <returns>A <see cref="string"/> of a random format</returns>
        private static string FormatPhoneNumber()
        {
            return Number.RandomNumber(20) switch
            {
                0 => "###-###-#### x#####",
                1 => "###-###-#### x####",
                2 => "###-###-#### x###",
                3 or 4 => "###-###-####",
                5 => "###.###.#### x#####",
                6 => "###.###.#### x####",
                7 => "###.###.#### x###",
                8 or 9 => "###.###.####",
                10 => "(###)###-#### x#####",
                11 => "(###)###-#### x####",
                12 => "(###)###-#### x###",
                13 or 14 => "(###)###-####",
                15 => "1-###-###-#### x#####",
                16 => "1-###-###-#### x####",
                17 => "1-###-###-#### x###",
                18 or 19 => "1-###-###-####",
                _ => throw new NotSupportedException("This error should not return, but handling a default edge case.  Please report to GitHub"),
            };
        }
    }
}
