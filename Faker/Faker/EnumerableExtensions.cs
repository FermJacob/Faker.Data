//-----------------------------------------------------------------------
// <copyright file="EnumerableExtensions.cs">
//     Copyright (c) 2016 Jacob Ferm, All rights Reserved
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace Faker
{
    /// <summary>
    /// Enumerable Extensions class
    /// </summary>
    public static class EnumerableExtensions
    {
        /// <summary>
        /// Gets a set number of types
        /// </summary>
        /// <typeparam name="T">Type of object</typeparam>
        /// <param name="count">Number of times</param>
        /// <param name="function">Function to use</param>
        /// <returns>An <see cref="IEnumerable{T}"/></returns>
        public static IEnumerable<T> Times<T>(this int count, Func<int, T> function)
        {
            for (var i = 0; i < count; i++)
            {
                yield return function.Invoke(i);
            }
        }
    }
}
