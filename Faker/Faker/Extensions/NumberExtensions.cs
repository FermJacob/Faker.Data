//-----------------------------------------------------------------------
// <copyright file="NumberExtensions.cs">
//     Copyright (c) 2019 Jacob Ferm, All rights Reserved
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.Extensions
{
    /// <summary>
    /// Static number extensions class
    /// </summary>
    public static class NumberExtensions 
    {
        /// <summary>
        /// Method from one number to another
        /// </summary>
        /// <param name="from">From <see cref="int"/></param>
        /// <param name="to">To <see cref="int"/></param>
        /// <returns>An <see cref="IEnumerable{T}"/> list</returns>
        public static IEnumerable<int> To(this int from, int to)
        {
            if (to >= from)
            {
                for (int i = from; i <= to; i++)
                {
                    yield return i;
                }
            }
            else
            {
                for (int i = from; i >= to; i--)
                {
                    yield return i;
                }
            }
        }

        /// <summary>
        /// Gets a set number of times for a type
        /// </summary>
        /// <typeparam name="T">Any Type</typeparam>
        /// <param name="num">An <see cref="int"/></param>
        /// <param name="toReturn"><see cref="T"/> to return</param>
        /// <returns>An <see cref="IEnumerable{T}"/> list</returns>
        public static IEnumerable<T> Times<T>(this int num, T toReturn)
        {
            for (int i = 0; i < num; i++)
            {
                yield return toReturn;
            }
        }

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
