//-----------------------------------------------------------------------
// <copyright file="Images.cs">
//     Copyright (c) 2024 Jacob Ferm, All rights Reserved
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.Versioning;

namespace Faker
{
    /// <summary>
    /// Static images class
    /// </summary>
    [SupportedOSPlatform("windows")]
    public static class Images
    {
        /// <summary>
        /// Gets a PNG image
        /// </summary>
        /// <returns>An image of format PNG</returns>
        public static Image PNG()
        {
            return GetImage(ImageFormat.Png);
        }

        /// <summary>
        /// Gets an JPEG image
        /// </summary>
        /// <returns>An image of format JPEG</returns>
        public static Image JPEG()
        {
            return GetImage(ImageFormat.Jpeg);
        }

        /// <summary>
        /// Gets a BMP image
        /// </summary>
        /// <returns>An image of format BMP</returns>
        public static Image BMP()
        {
            return GetImage(ImageFormat.Bmp);
        }

        /// <summary>
        /// Gets the image
        /// </summary>
        /// <param name="format">Format to implement</param>
        /// <returns>An image of specified image format</returns>
        private static Image GetImage(ImageFormat format)
        {
            Image image;
            Color color = Color.FromName(Colors.SystemColor());
            if (color.A == 0 && color.B == 0 && color.G == 0 && color.R == 0)
            {
                throw new ArgumentException("Error generating color");
            }

            using (var bmp = new Bitmap(200, 200))
            {
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    Rectangle rect = new(0, 0, 200, 200);
                    g.FillRectangle(new SolidBrush(color), rect);
                }

                MemoryStream ms = new();

                bmp.Save(ms, format);
                image = new Bitmap(ms);
            }

            return image;
        }
    }
}
