//-----------------------------------------------------------------------
// <copyright file="Number.cs">
//     Copyright (c) 2016 Jacob Ferm, All rights Reserved
// </copyright>
//-----------------------------------------------------------------------
using System;

namespace Faker
{
    /// <summary>
    /// Number class used to generate random numbers
    /// </summary>
    public static class Number
    {
        private static Random random = new Random();

        /// <summary>
        /// Gets a random number
        /// </summary>
        /// <param name="min">Minimum value</param>
        /// <param name="max">Maximum value</param>
        /// <returns>Integer of the random number</returns>
        public static int RandomNumber(int min, int max)
        {
            if (max < min)
            {
                throw new ArgumentException("Max number must be greater than min");
            }

            return random.Next(min, max);
        }

        /// <summary>
        /// Gets a random number from 0 to max variable
        /// </summary>
        /// <param name="max">Max integer to use</param>
        /// <returns>Integer number</returns>
        public static int RandomNumber(int max)
        {
            return random.Next(Math.Abs(max));
        }

        /// <summary>
        /// Gets a random number from 0 to any
        /// </summary>
        /// <returns>Integer number</returns>
        public static int RandomNumber()
        {
            return random.Next();
        }

        /// <summary>
        /// Gets a random negative number.  Pass in a positive value
        /// </summary>
        /// <param name="max">Max number positive</param>
        /// <returns>A negative integer</returns>
        public static int NegativeNumber(int max)
        {
            return random.Next(Math.Abs(max)) * -1;
        }

        /// <summary>
        /// Gets the next even number
        /// </summary>
        /// <param name="min">Minimum value</param>
        /// <param name="max">Maximum value</param>
        /// <returns>Integer of even number</returns>
        public static int Even(int min, int max)
        {
            var result = 0;
            do
            {
                result = RandomNumber(min, max);
            }
            while (result % 2 == 1);
            return result;
        }

        /// <summary>
        /// Gets the next odd number
        /// </summary>
        /// <param name="min">Minimum value</param>
        /// <param name="max">Maximum value</param>
        /// <returns>Integer of old number</returns>
        public static int Odd(int min = 0, int max = 1)
        {
            int result = 0;
            do
            {
                result = RandomNumber(min, max);
            }
            while (result % 2 == 0);
            return result;
        }

        /// <summary>
        /// Gets the next double
        /// </summary>
        /// <returns>Random double value</returns>
        public static double Double()
        {
            return random.NextDouble();
        }

        /// <summary>
        /// Gets a random boolean value
        /// </summary>
        /// <returns>Boolean of true or false</returns>
        public static bool Bool()
        {
            return RandomNumber(0, 1) == 0;
        }
    }
}
