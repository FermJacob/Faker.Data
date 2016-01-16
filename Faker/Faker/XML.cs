//-----------------------------------------------------------------------
// <copyright file="XML.cs">
//     Copyright (c) 2016 Jacob Ferm, All rights Reserved
// </copyright>
//-----------------------------------------------------------------------
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
        private static XDocument doc;

        /// <summary>
        /// Gets the XDocument to use
        /// </summary>
        private static XDocument Doc
        {
            get
            {
                if (doc == null)
                {
                    doc = XDocument.Load(new StreamReader(Assembly.GetExecutingAssembly().GetManifestResourceStream("Faker.Data.xml")));
                    return doc;
                }
                else
                {
                    return doc;
                }
            }
        }

        /// <summary>
        /// Gets the list of the data
        /// </summary>
        /// <param name="node">Which node to select</param>
        /// <returns>A list of strings</returns>
        public static List<string> GetListString(XName node)
        {
            return Doc.Descendants(node).Elements("Value").Select(item => (string)item).ToList();
        }

        /// <summary>
        /// Gets the list of the data
        /// </summary>
        /// <param name="topNode">Which top node to select</param>
        /// <param name="node">Which node to select</param>
        /// <returns>A list of strings</returns>
        public static List<string> GetListString(XName topNode, XName node)
        {
            return Doc.Descendants(topNode).Descendants(node).Elements("Value").Select(item => (string)item).ToList();
        }
    }
}
