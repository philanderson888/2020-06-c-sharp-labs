using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace lab_42_xml_serialize.Models
{
    [Serializable]
    public partial class Product
    {
        [XmlElement("ProductId")]
        public int ProductId { get; set; }
        [XmlElement("ProductName")]
        public string ProductName { get; set; }
        [XmlIgnore]
        public int? SupplierId { get; set; }
        [XmlIgnore]
        public int? CategoryId { get; set; }
        [XmlIgnore]
        public string QuantityPerUnit { get; set; }

        [XmlElement("UnitPrice")]
        public decimal? UnitPrice { get; set; }
        [XmlIgnore]
        public short? UnitsInStock { get; set; }
        [XmlIgnore]
        public short? UnitsOnOrder { get; set; }
        [XmlIgnore]
        public short? ReorderLevel { get; set; }
        [XmlIgnore]
        public bool Discontinued { get; set; }
    }

    [XmlRoot("Products")]
    public class Products
    {
        [XmlElement("Product")]
        public List<Product> ProductList { get; set; }

    }
}
