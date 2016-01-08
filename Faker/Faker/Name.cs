using System;
using System.Collections.Generic;

namespace Faker
{
    public static class Name
    {


        private static Random random = new Random();
        private static List<string> maleFirstName;
        private static List<string> femaleFirstName;
        private static List<string> firstName;
        private static List<string> lastName;
        public static string MaleFirstName()
        {
            if (maleFirstName == null)
            {
                maleFirstName = XML.GetListString("MaleFirstName");

            }
            return maleFirstName[random.Next(0, maleFirstName.Count - 1)];
        }

        public static string FemaleFirstName()
        {
            if (femaleFirstName == null)
            {
                femaleFirstName = XML.GetListString("FemaleFirstName");

            }
            return femaleFirstName[random.Next(0, femaleFirstName.Count - 1)];
        }

        public static string LastName()
        {
            if (lastName == null)
            {
                lastName = XML.GetListString("LastName");

            }
            return lastName[random.Next(0, lastName.Count - 1)];
        }

        public static string FullName()
        {
            return FirstName() + LastName();
        }

        public static string FirstName()
        {
            if(firstName == null)
            {
                firstName = new List<string>();
                firstName.AddRange(XML.GetListString("FemaleFirstName"));
                firstName.AddRange(XML.GetListString("MaleFirstName"));

            }
            return firstName[random.Next(0, firstName.Count - 1)];

        }



    }
}
