//-----------------------------------------------------------------------
// <copyright file="GeoLocation.cs">
//     Copyright (c) 2024 Jacob Ferm, All rights Reserved
// </copyright>
//-----------------------------------------------------------------------
using System;

namespace Faker
{
    /// <summary>
    /// Geographic Location class
    /// </summary>
    public static class GeoLocation
    {
        /// <summary>
        /// Gets a random latitude between -90 to 90
        /// </summary>
        /// <returns>Double of latitude value between -90 to 90</returns>
        public static double Latitude()
        {
            // between -90 to 90
            return Math.Round((Number.Double() * 180) - 90, 4);
        }

        /// <summary>
        /// Gets a random longitude between -180 to 180
        /// </summary>
        /// <returns>Double of longitude value between -180 to 180</returns>
        public static double Longitude()
        {
            // between -180 to 180
            return Math.Round((Number.Double() * 360) - 180, 4);
        }
    }
}
