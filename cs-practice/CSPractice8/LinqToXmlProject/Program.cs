using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinqToXmlProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // load xml file in memory
            XElement doc = XElement.Load(@"C:\Database\MyXml.xml");

            // query xml doc
            var products = from prodname in doc.Descendants() select prodname.Value;

            // display details
            foreach (var prodname in products)
            {
                Console.WriteLine("Pegawai Detail : {0}\t", prodname);
            }

            Console.ReadLine();
        }
    }
}
