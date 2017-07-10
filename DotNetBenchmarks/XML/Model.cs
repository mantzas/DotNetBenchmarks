using System.Collections.Generic;

namespace ETravel.Benchmarks.XML
{
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class FlightSegmentList
    {
        [System.Xml.Serialization.XmlElementAttribute("FlightSegment")]
        public List<FlightSegmentListFlightSegment> FlightSegment { get; set; }
    }

    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FlightSegmentListFlightSegment
    {
        public FlightSegmentListFlightSegmentDeparture Departure { get; set; }

        public FlightSegmentListFlightSegmentArrival Arrival { get; set; }

        public FlightSegmentListFlightSegmentMarketingCarrier MarketingCarrier { get; set; }

        public FlightSegmentListFlightSegmentOperatingCarrier OperatingCarrier { get; set; }

        public FlightSegmentListFlightSegmentEquipment Equipment { get; set; }

        public FlightSegmentListFlightSegmentFlightDetail FlightDetail { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string refs { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SegmentKey { get; set; }
    }

    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FlightSegmentListFlightSegmentDeparture
    {
        public string AirportCode { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime Date { get; set; }

        public string Time { get; set; }
    }

    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FlightSegmentListFlightSegmentArrival
    {
        public string AirportCode { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime Date { get; set; }

        public string Time { get; set; }
    }

    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FlightSegmentListFlightSegmentMarketingCarrier
    {
        public string AirlineID { get; set; }

        public byte FlightNumber { get; set; }
    }

    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FlightSegmentListFlightSegmentOperatingCarrier
    {
        public string AirlineID { get; set; }

        public string Name { get; set; }
    }

    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FlightSegmentListFlightSegmentEquipment
    {
        public ushort AircraftCode { get; set; }

        public string Name { get; set; }
    }

    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FlightSegmentListFlightSegmentFlightDetail
    {
        public FlightSegmentListFlightSegmentFlightDetailFlightDuration FlightDuration { get; set; }
    }

    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FlightSegmentListFlightSegmentFlightDetailFlightDuration
    {
        [System.Xml.Serialization.XmlElementAttribute(DataType = "duration")]
        public string Value { get; set; }
    }
}
