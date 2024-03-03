//-----------------------------------------------------------------------
// <copyright file="XML.cs">
//     Copyright (c) 2024 Jacob Ferm, All rights Reserved
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml.Linq;

namespace Faker
{
    /// <summary>
    /// XML class to handle loading data.xml
    /// </summary>
    public static class XML
    {
        /// <summary>
        /// XDocument variable
        /// </summary>
        private static readonly Lazy<XDocument> doc = new(() => XDocument.Load(new StreamReader(Assembly.GetExecutingAssembly().GetManifestResourceStream("Faker.Data.xml"))));

        /// <summary>
        /// Gets the list of the data
        /// </summary>
        /// <param name="node">Which node to select</param>
        /// <returns>A list of strings</returns>
        public static List<string> GetListString(XName node)
        {
            return doc.Value.Descendants(node).Elements("Value").Select(item => (string)item).ToList();
        }

        /// <summary>
        /// Gets the list of the data
        /// </summary>
        /// <param name="topNode">Which top node to select</param>
        /// <param name="node">Which node to select</param>
        /// <returns>A list of strings</returns>
        public static List<string> GetListString(XName topNode, XName node)
        {
            return doc.Value.Descendants(topNode).Descendants(node).Elements("Value").Select(item => (string)item).ToList();
        }

        /// <summary>
        /// Gets a object for grabbing node attributes
        /// </summary>
        /// <param name="topNode">Top node name</param>
        /// <param name="node">Node name</param>
        /// <returns>A <see cref="List{T}"/></returns>
        public static List<XElement> GetListObject(XName topNode, XName node)
        {
            return doc.Value.Descendants(topNode).Descendants(node).Elements("Value").ToList();
        }
    }
}
