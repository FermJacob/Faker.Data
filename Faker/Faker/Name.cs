//-----------------------------------------------------------------------
// <copyright file="Name.cs">
//     Copyright (c) 2024 Jacob Ferm, All rights Reserved
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace Faker
{
    /// <summary>
    /// Static name class
    /// </summary>
    public static class Name
    {
        private static readonly Lazy<List<string>> maleFirstName = new(() => XML.GetListString("MaleFirstName"));
        private static readonly Lazy<List<string>> femaleFirstName = new(() => XML.GetListString("FemaleFirstName"));
        private static readonly Lazy<List<string>> lastName = new(() => XML.GetListString("LastName"));
        private static readonly Lazy<List<string>> ethnicity = new(() => XML.GetListString("Person", "Ethnicity"));
        private static readonly Lazy<List<string>> firstName = new(() =>
        {
            var names = new List<string>();
            names.AddRange(femaleFirstName.Value);
            names.AddRange(maleFirstName.Value);
            return names;
        });

        public static string MaleFirstName() => maleFirstName.Value[Number.RandomNumber(0, maleFirstName.Value.Count - 1)];

        public static string FemaleFirstName() => femaleFirstName.Value[Number.RandomNumber(0, femaleFirstName.Value.Count - 1)];

        public static string LastName() => lastName.Value[Number.RandomNumber(0, lastName.Value.Count - 1)];

        public static string FullName() => $"{FirstName()} {LastName()}";

        public static string FirstName() => firstName.Value[Number.RandomNumber(0, firstName.Value.Count - 1)];

        public static string Gender() => Number.Bool() ? "Male" : "Female";

        public static string Ethnicity() => ethnicity.Value[Number.RandomNumber(0, ethnicity.Value.Count - 1)];
    }
}