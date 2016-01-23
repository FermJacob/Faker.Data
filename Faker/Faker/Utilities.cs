//-----------------------------------------------------------------------
// <copyright file="Utilities.cs">
//     Copyright (c) 2016 Jacob Ferm, All rights Reserved
// </copyright>
//-----------------------------------------------------------------------

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
    }
}
