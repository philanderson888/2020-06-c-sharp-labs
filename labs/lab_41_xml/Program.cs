using System;
using System.Xml;
using System.Xml.Linq;

namespace lab_41_xml
{
    class Program
    {
        static void Main(string[] args)
        {
            // create some XML
            var xml01 = new XElement("test", 1);
            Console.WriteLine(xml01);

            // sub element
            var xml02 = new XElement("root",
                new XElement("level1",
                    new XAttribute("width",22),
                    new XElement("level2",400),
                    new XElement("level2",400)
                ),
                new XElement("level1",
                    new XAttribute("width", 33),
                    new XElement("level2", 400),
                    new XElement("level2", 400)
                ),
                new XElement("level1",
                    new XAttribute("width", 44),
                    new XElement("level2", 500),
                    new XElement("level2", 600)
                )
            );
            Console.WriteLine(xml02);

            // write data to disk 
            var doc02 = new XDocument(xml02);
            doc02.Save("XMLdoc02.xml");

            // read back data
            var readDoc02 = new XmlDocument();
            readDoc02.Load("XMLdoc02.xml");
            // print
            Console.WriteLine(readDoc02.InnerXml);
        }


    }
}
