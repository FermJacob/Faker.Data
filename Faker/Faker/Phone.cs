//-----------------------------------------------------------------------
// <copyright file="Phone.cs">
//     Copyright (c) 2019 Jacob Ferm, All rights Reserved
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
            switch (Number.RandomNumber(20))
            {
                case 0: return "###-###-#### x#####";
                case 1: return "###-###-#### x####";
                case 2: return "###-###-#### x###";
                case 3:
                case 4: return "###-###-####";
                case 5: return "###.###.#### x#####";
                case 6: return "###.###.#### x####";
                case 7: return "###.###.#### x###";
                case 8:
                case 9: return "###.###.####";
                case 10: return "(###)###-#### x#####";
                case 11: return "(###)###-#### x####";
                case 12: return "(###)###-#### x###";
                case 13:
                case 14: return "(###)###-####";
                case 15: return "1-###-###-#### x#####";
                case 16: return "1-###-###-#### x####";
                case 17: return "1-###-###-#### x###";
                case 18:
                case 19: return "1-###-###-####";
                default: throw new ApplicationException();
            }
        }
    }
}
