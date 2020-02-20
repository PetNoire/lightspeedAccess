using System;
using System.Xml.Serialization;

namespace lightspeedAccess.Models.Common
{
    public class TaxClass
    {
        [XmlElement("taxClassID")]
        public int TaxClassID { get; set; }
        [XmlElement("name")]
        public string Name { get; set; }
        [XmlElement("SaleLines")]
        public string SaleLines { get; set; }
        [XmlElement("Items")]
        public string Items { get; set; }
        [XmlElement("timeStamp")]
        public DateTime TimeStamp { get; set; }
}
}
