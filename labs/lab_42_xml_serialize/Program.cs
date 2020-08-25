using System;
using System.Collections.Generic;
using lab_42_xml_serialize.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Xml.Linq;
using System.IO;
using System.Xml.Serialization;

namespace lab_42_xml_serialize
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            // read some northwind products
            using (var db = new NorthwindContext())
            {
                products = db.Products.ToList();
            }
            products.ForEach(p => Console.WriteLine($"{p.ProductId,-10}{p.ProductName}"));

            // imagine someone created this xml file in brazil and emailed it to us
            var xmlProducts = new XElement(

                "Products",

                   from p in products
                   select new XElement("Product",
                        new XElement("ProductId", p.ProductId),
                        new XElement("ProductName", p.ProductName),
                        new XElement("UnitPrice", p.UnitPrice)
                   )
            );

            // save document
            var xmlProductsDocument = new XDocument(xmlProducts);
            xmlProductsDocument.Save("Products.xml");

            // print
            Console.WriteLine(xmlProductsDocument);

            // assume data being sent to us over the internet - it can be very large so 
            // safest to 'STREAM' data from internet

            var XMLProducts = new Products();

            using (var reader = new StreamReader("Products.xml"))
            {
                // deserialize from xml to Northwind Products
                var serializer = new XmlSerializer(typeof(Products));
                XMLProducts = (Products)serializer.Deserialize(reader);
            }

            Console.WriteLine("\n\nProducts Deserialized");
            XMLProducts.ProductList.ForEach(p => Console.WriteLine($"{p.ProductId,-15}{p.ProductName,-40}{p.UnitPrice}"));



        }
    }


}
