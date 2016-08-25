//-----------------------------------------------------------------------
// <copyright file="Person.cs">
//     Copyright (c) 2016 Jacob Ferm, All rights Reserved
// </copyright>
//-----------------------------------------------------------------------

namespace Faker
{
    /// <summary>
    /// Static person class
    /// </summary>
    public static class Person
    {
        /// <summary>
        /// Gets a random SSN
        /// </summary>
        /// <returns>A <see cref="string"/></returns>
        public static string Ssn()
        {
            return "###-##-####".Numerify();
        }
    }
}
