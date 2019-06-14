//-----------------------------------------------------------------------
// <copyright file="YearAdjustable51.cs">
//     Copyright (c) 2019 Jacob Ferm, All rights Reserved
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Serialization;

namespace Faker.Models
{
    /// <summary>
    /// Model for loading from the XML file
    /// </summary>
    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "*", Justification = "Supressing stylecop to allow for parsing")]
    [SuppressMessage("StyleCop.CSharp.NamingRules", "*", Justification = "Supressing stylecop to allow for parsing")]
    [Serializable]
    [XmlRoot(ElementName = "Value")]
    public class YearAdjustable51
    {
        [XmlAttribute("date")]
        public DateTime Date { get; set; }
        [XmlAttribute("percentage")]
        public double Percentage { get; set; }
    }
}
