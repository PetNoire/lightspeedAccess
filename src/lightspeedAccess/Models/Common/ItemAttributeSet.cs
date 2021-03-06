﻿using System.Xml.Serialization;

namespace lightspeedAccess.Models.Common
{
    public class ItemAttributeSet
    {
        [XmlElement("attributeName1")]
        public string AttributeName1 { get; set; }
        [XmlElement("attributeName2")]
        public string AttributeName2 { get; set; }
        [XmlElement("attributeName3")]
        public string AttributeName3 { get; set; }
        [XmlElement("itemAttribueSetID")]
        public int ItemAttributeSetID { get; set; }
        [XmlElement("name")]
        public string Name { get; set; }
    }
}