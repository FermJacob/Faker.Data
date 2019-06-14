//-----------------------------------------------------------------------
// <copyright file="EnumerableExtensions.cs">
//     Copyright (c) 2019 Jacob Ferm, All rights Reserved
// </copyright>
//-----------------------------------------------------------------------
using System.Collections.Generic;
using System.Linq;

namespace Faker.Extensions
{
    /// <summary>
    /// Enumerable Extensions class
    /// </summary>
    public static class EnumerableExtensions
    {
        /// <summary>
        /// Join method of list to string
        /// </summary>
        /// <typeparam name="T">Any type</typeparam>
        /// <param name="items">Item list</param>
        /// <param name="separator">Separator string</param>
        /// <returns>A <see cref="string"/></returns>
        public static string Join<T>(this IEnumerable<T> items, string separator)
        {
            return items.Select(i => i.ToString())
                        .Aggregate((acc, next) => string.Concat(acc, separator, next));
        }

        /// <summary>
        /// Picks a random type from the list
        /// </summary>
        /// <typeparam name="T">Any type</typeparam>
        /// <param name="items">List of items</param>
        /// <returns>A <see cref="T"/></returns>
        public static T Rand<T>(this IEnumerable<T> items)
        {
            IList<T> list;
            if (items is IList<T>)
            {
                list = (IList<T>)items;
            }
            else
            {
                list = items.ToList();
            }

            return list[Number.RandomNumber(list.Count)];
        }

        /// <summary>
        /// Randomly picks a number of elements from a list
        /// </summary>
        /// <typeparam name="T">Any type</typeparam>
        /// <param name="items">List of items</param>
        /// <param name="itemsToTake">Number of items to take</param>
        /// <returns>A <see cref="IEnumerable{T}"/> with the specified number</returns>
        public static IEnumerable<T> RandPick<T>(this IEnumerable<T> items, int itemsToTake)
        {
            IList<T> list;
            if (items is IList<T>)
            {
                list = (IList<T>)items;
            }
            else
            {
                list = items.ToList();
            }

            for (int i = 0; i < itemsToTake; i++)
            {
                yield return list[Number.RandomNumber(list.Count)];
            }
        }

        /// <summary>
        /// Shuffles a list
        /// </summary>
        /// <typeparam name="T">A type</typeparam>
        /// <param name="list">A list</param>
        /// <returns>A <see cref="IList{T}"/></returns>
        public static IList<T> Shuffle<T>(this IList<T> list)
        {
            T[] retArray = new T[list.Count];
            list.CopyTo(retArray, 0);

            for (int i = 0; i < list.Count; i += 1)
            {
                int swapIndex = Number.RandomNumber(i, list.Count);
                if (swapIndex != i)
                {
                    T temp = retArray[i];
                    retArray[i] = retArray[swapIndex];
                    retArray[swapIndex] = temp;
                }
            }

            return retArray;
        }

        /// <summary>
        /// Gets a random array element
        /// </summary>
        /// <typeparam name="T">A type</typeparam>
        /// <param name="array">The array</param>
        /// <returns>A random Type</returns>
        public static T ArrayElement<T>(this T[] array)
        {
            int num = Number.RandomNumber(0, array.Length - 1);
            return array[num];
        }
    }
}
