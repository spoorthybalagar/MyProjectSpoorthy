using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace batch7_Spoorthy
{
    internal class LinqtoXML
    {
        static void Main(string[] args)
        {
            XDocument xdoc = XDocument.Load("D:\\country.xml");
            var countries = from country in xdoc.Descendants("countries").Elements("country").Attributes("name")
                            select country.Value;
            foreach (var country in countries)
            {
                Console.WriteLine(country);
            }
        }
    }
}
