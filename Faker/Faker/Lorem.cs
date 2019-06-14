//-----------------------------------------------------------------------
// <copyright file="Lorem.cs">
//     Copyright (c) 2019 Jacob Ferm, All rights Reserved
// </copyright>
//-----------------------------------------------------------------------
using Faker.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Faker
{
    /// <summary>
    /// Static word class
    /// </summary>
    public static class Lorem
    {
        private static object loremLock = new object();
        private static List<string> lorem;

        /// <summary>
        /// Gets a sentence with a number of words
        /// </summary>
        /// <param name="numberOfWords">Number of words</param>
        /// <returns>A <see cref="string"/></returns>
        public static string Sentence(int numberOfWords)
        {
            if (numberOfWords < 3)
            {
                throw new ArgumentException("Need more than 3 words.");
            }

            return FirstCharToUpper(string.Join(" ", Words(numberOfWords)) + ".");
        }

        /// <summary>
        /// Gets a sentence with a random number of words
        /// </summary>
        /// <returns>A <see cref="string"/></returns>
        public static string Sentence()
        {
            return Sentence(Number.RandomNumber(3, 15));
        }

        /// <summary>
        /// Gets a number of sentences
        /// </summary>
        /// <param name="number">Number of sentences</param>
        /// <returns>A list of <see cref="string"/></returns>
        public static List<string> Sentences(int number)
        {
            if (number < 1)
            {
                throw new ArgumentException("Number has to be more than 1");
            }

            return number.Times(x => Sentence()).ToList();
        }

        /// <summary>
        /// Gets a random number of sentences
        /// </summary>
        /// <returns>A list of <see cref="string"/></returns>
        public static List<string> Sentences()
        {
            int number = Number.RandomNumber(1, 10);
            return number.Times(x => Sentence()).ToList();
        }

        /// <summary>
        /// Gets a random word from the list
        /// </summary>
        /// <returns>A <see cref="string"/></returns>
        public static string Word()
        {
            lock (loremLock)
            {
                if (lorem == null)
                {
                    lorem = XML.GetListString("Lorem");
                }

                return lorem[Number.RandomNumber(0, lorem.Count - 1)];
            }
        }

        /// <summary>
        /// Gets a list of words
        /// </summary>
        /// <param name="number">Number of words</param>
        /// <returns>A list of <see cref="string"/></returns>
        public static List<string> Words(int number)
        {
            return number.Times(x => Word()).ToList();
        }

        /// <summary>
        /// Gets a random amount of words
        /// </summary>
        /// <returns>A list of <see cref="string"/></returns>
        public static List<string> Words()
        {
            int number = Number.RandomNumber(1, 10);
            return number.Times(x => Word()).ToList();
        }

        /// <summary>
        /// Gets a random letter
        /// </summary>
        /// <returns>A <see cref="char"/></returns>
        public static char Letter()
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            if (Number.Bool())
            {
                return chars[Number.RandomNumber(0, chars.Length)];
            }

            return char.ToLower(chars[Number.RandomNumber(0, chars.Length)]);
        }

        /// <summary>
        /// Gets a number of random letters
        /// </summary>
        /// <param name="number">Number of letters</param>
        /// <returns>A list of <see cref="char"/></returns>
        public static List<char> Letters(int number)
        {
            return number.Times(x => Letter()).ToList();
        }

        /// <summary>
        /// Gets a random amount of letters
        /// </summary>
        /// <returns>A list of <see cref="char"/></returns>
        public static List<char> Letters()
        {
            int number = Number.RandomNumber(1, 10);
            return number.Times(x => Letter()).ToList();
        }

        /// <summary>
        /// Method to take a string and make the first char uppercase
        /// </summary>
        /// <param name="input">String input</param>
        /// <returns>A <see cref="string"/></returns>
        public static string FirstCharToUpper(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentException("No string was inputted.");
            }

            return input.First().ToString().ToUpper() + input.Substring(1);
        }

        /// <summary>
        /// Gets a paragraph with a number of sentences
        /// </summary>
        /// <param name="numberOfSentences">Number of sentences</param>
        /// <returns>A <see cref="string"/></returns>
        public static string Paragraph(int numberOfSentences)
        {
            return string.Join(" ", Sentences(numberOfSentences));
        }

        /// <summary>
        /// Gets a paragraph with a random number of sentences
        /// </summary>
        /// <returns>A <see cref="string"/></returns>
        public static string Paragraph()
        {
            return string.Join(" ", Sentences(Number.RandomNumber(1, 10)));
        }

        /// <summary>
        /// Gets a number of paragraphs with random amount of sentences
        /// </summary>
        /// <param name="numberOfParagraphs">Number of paragraphs</param>
        /// <returns>A list of <see cref="string"/></returns>
        public static List<string> Paragraphs(int numberOfParagraphs)
        {
            return numberOfParagraphs.Times(x => Paragraph()).ToList();
        }

        /// <summary>
        /// Gets a random number of paragraphs with random amount of sentences
        /// </summary>
        /// <returns>A list of <see cref="string"/></returns>
        public static List<string> Paragraphs()
        {
            return Number.RandomNumber(1, 10).Times(x => Paragraph()).ToList();
        }
    }
}
