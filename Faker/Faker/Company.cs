using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker
{
    public static class Company
    {
        private static List<string> name;
        private static List<string> catchPhrase;
        private static List<string> suffix;
        private static List<string> sector;
        private static List<string> industry;

        // Logo


        private static string Name()
        {
            if (name == null)
            {
                name = XML.GetListString("Company","Name");
            }

            return name[Number.RandomNumber(0, name.Count - 1)];
        }

        private static string CatchPhrase()
        {
            if (catchPhrase == null)
            {
                catchPhrase = XML.GetListString("Company", "CatchPhrase");
            }

            return catchPhrase[Number.RandomNumber(0, catchPhrase.Count - 1)];
        }

        public static string Suffix()
        {
            if (suffix == null)
            {
                suffix = XML.GetListString("Company", "Suffix");
            }

            return suffix[Number.RandomNumber(0, suffix.Count - 1)];
        }

        public static string Sector()
        {
            if (sector == null)
            {
                sector = XML.GetListString("Company", "Sector");
            }

            return sector[Number.RandomNumber(0, sector.Count - 1)];
        }

        public static string Industry()
        {
            if (industry == null)
            {
                industry = XML.GetListString("Company", "Industry");
            }

            return industry[Number.RandomNumber(0, industry.Count - 1)];
        }

        public static string Symbol()
        {
            return string.Empty;
        }

    }
}
