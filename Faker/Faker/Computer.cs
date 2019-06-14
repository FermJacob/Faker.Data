//-----------------------------------------------------------------------
// <copyright file="Computer.cs">
//     Copyright (c) 2019 Jacob Ferm, All rights Reserved
// </copyright>
//-----------------------------------------------------------------------
using Faker.Extensions;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker
{
    /// <summary>
    /// Static class for computer generation
    /// </summary>
    public static class Computer
    {
        private static JObject mimes;
        private static string[] exts;
        private static string[] types;
        private static string[] mimeKeys;

        /// <summary>
        /// Get a random file name
        /// </summary>
        /// <param name="ext">An extension</param>
        /// <returns>A <see cref="string"/></returns>
        public static string FileName(string ext = null)
        {
            var filename = $"{Lorem.Words()}.{ext ?? FileExt()}";
            filename = filename.Replace(" ", "_");
            filename = filename.Replace(",", "_");
            filename = filename.Replace("-", "_");
            filename = filename.Replace(@"\", "_");
            filename = filename.ToLower().Trim();
            return filename;
        }

        /// <summary>
        /// Gets a common filename
        /// </summary>
        /// <param name="ext">An extension</param>
        /// <returns>A <see cref="string"/></returns>
        public static string CommonFileName(string ext = null)
        {
            var filename = $"{Lorem.Words()}.{ext ?? CommonFileExt()}";
            filename = filename.Replace(" ", "_");
            filename = filename.Replace(",", "_");
            filename = filename.Replace("-", "_");
            filename = filename.Replace(@"\", "_");
            filename = filename.ToLower().Trim();
            return filename;
        }

        ///// <summary>
        ///// Get a random mime type
        ///// </summary>
        ////public static string MimeType()
        ////{
        ////    return Random.ArrayElement(mimeKeys);
        ////}

        /// <summary>
        /// Returns a commonly used file type
        /// </summary>
        /// <returns>A <see cref="string"/></returns>
        public static string CommonFileType()
        {
            var types = new[] { "video", "audio", "image", "text", "application" };
            return types[Number.RandomNumber(0, types.Length - 1)];
        }

        /// <summary>
        /// Returns a commonly used file extension
        /// </summary>
        /// <returns>A <see cref="string"/></returns>
        public static string CommonFileExt()
        {
            var types = new[]
                {
                    "application/pdf",
                    "audio/mpeg",
                    "audio/wav",
                    "image/png",
                    "image/jpeg",
                    "image/gif",
                    "video/mp4",
                    "video/mpeg",
                    "text/html"
                };

            return FileExt(types[Number.RandomNumber(0, types.Length - 1)]);
        }

        /// <summary>
        /// Returns any file type available as mime-type
        /// </summary>
        /// <returns>A <see cref="string"/></returns>
        public static string FileType()
        {
            return types[Number.RandomNumber(0, types.Length - 1)];
        }

        /// <summary>
        /// Gets a random extension for the given mime type.
        /// </summary>
        /// <param name="mimeType">A meme type</param>
        /// <returns>A <see cref="string"/></returns>
        public static string FileExt(string mimeType = null)
        {
            JToken mime;
            if (mimeType != null && mimes.TryGetValue(mimeType, out mime) && mime.Type == JTokenType.Object)
            {
                var mimeObject = mime as JObject;
                var temp = mimeObject["extensions"] as JArray;
                return temp.ToArray().ArrayElement().ToString();
            }

            return exts.ArrayElement();
        }

        /// <summary>
        /// Get a random Semantic Version version string.
        /// </summary>
        /// <returns>A <see cref="string"/></returns>
        public static string SemanticVersion()
        {
            return $"{Number.RandomNumber(9)}.{Number.RandomNumber(9)}.{Number.RandomNumber(9)}";
        }

        /// <summary>
        /// Get a random `System.Version`
        /// </summary>
        /// <returns>A <see cref="Version"/></returns>
        public static Version Version()
        {
            return new Version(Number.RandomNumber(9), Number.RandomNumber(9), Number.RandomNumber(9), Number.RandomNumber(9));
        }

        /// <summary>
        /// Get a random `Exception` with a fake stack trace.
        /// </summary>
        /// <returns>A <see cref="Exception"/></returns>
        public static Exception Exception()
        {
            Exception exe = null;
            switch (Number.RandomNumber(11))
            {
                case 0:
                    try
                    {
                        throw new ArgumentException(Lorem.Sentence(), Lorem.Word());
                    }
                    catch (Exception e)
                    {
                        exe = e;
                    }

                    break;
                case 1:
                    try
                    {
                        throw new ArgumentNullException(Lorem.Word(), Lorem.Sentence());
                    }
                    catch (Exception e)
                    {
                        exe = e;
                    }

                    break;
                case 2:
                    try
                    {
                        throw new BadImageFormatException(Lorem.Sentence(), Lorem.Word());
                    }
                    catch (Exception e)
                    {
                        exe = e;
                    }

                    break;
                case 3:
                    try
                    {
                        throw new IndexOutOfRangeException(Lorem.Sentence());
                    }
                    catch (Exception e)
                    {
                        exe = e;
                    }

                    break;
                case 4:
                    try
                    {
                        throw new ArithmeticException(Lorem.Sentence());
                    }
                    catch (Exception e)
                    {
                        exe = e;
                    }

                    break;
                case 5:
                    try
                    {
                        throw new OutOfMemoryException(Lorem.Sentence());
                    }
                    catch (Exception e)
                    {
                        exe = e;
                    }

                    break;
                case 6:
                    try
                    {
                        throw new FormatException(Lorem.Sentence());
                    }
                    catch (Exception e)
                    {
                        exe = e;
                    }

                    break;
                case 7:
                    try
                    {
                        throw new DivideByZeroException();
                    }
                    catch (Exception e)
                    {
                        exe = e;
                    }

                    break;
                case 8:
                    try
                    {
                        throw new EndOfStreamException(Lorem.Sentence());
                    }
                    catch (Exception e)
                    {
                        exe = e;
                    }

                    break;
                case 9:
                    try
                    {
                        throw new FileNotFoundException("File not found...", Path.GetRandomFileName());
                    }
                    catch (Exception e)
                    {
                        exe = e;
                    }

                    break;
                case 10:
                    try
                    {
                        throw new NotImplementedException();
                    }
                    catch (Exception e)
                    {
                        exe = e;
                    }

                    break;
                case 11:
                    try
                    {
                        throw new UnauthorizedAccessException();
                    }
                    catch (Exception e)
                    {
                        exe = e;
                    }

                    break;
            }

            return exe;
        }
    }
}
