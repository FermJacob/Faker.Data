//-----------------------------------------------------------------------
// <copyright file="YearAdjustable51JSON.cs">
//     Copyright (c) 2019 Jacob Ferm, All rights Reserved
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.Models
{
    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "*", Justification = "Supressing stylecop to allow for parsing")]
    [SuppressMessage("StyleCop.CSharp.NamingRules", "*", Justification = "Supressing stylecop to allow for parsing")]
    public class YearAdjustable51JSON
    {
        public Dataset DataSet { get; set; }

        public class Dataset
        {
            public int Id { get; set; }

            public string dataset_code { get; set; }

            public string database_code { get; set; }

            public string name { get; set; }

            public string description { get; set; }

            public string refreshed_at { get; set; }

            public string newest_available_date { get; set; }

            public string oldest_available_date { get; set; }

            public List<string> column_names { get; set; }

            public string frequency { get; set; }

            public string type { get; set; }

            public bool premium { get; set; }

            public object limit { get; set; }

            public object transform { get; set; }

            public object column_index { get; set; }

            public string start_date { get; set; }

            public string end_date { get; set; }

            public List<List<string>> data { get; set; }

            public object collapse { get; set; }

            public string order { get; set; }

            public int database_id { get; set; }
        }
    }
}