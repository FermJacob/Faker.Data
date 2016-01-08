using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Reflection;
using System.IO;

namespace Faker
{
    public static class XML
    {

        public static XDocument doc;



        public static XDocument Doc
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

        public static List<string> GetListString(XName node)
        {
            return Doc.Descendants(node).Elements("Value").Select(item => (string)item).ToList();

        }


    }
}
