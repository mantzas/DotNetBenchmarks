using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace ETravel.Benchmarks.XML
{
    [MemoryDiagnoser]
    public class XmlDeserializeVsXmlReaderBenchmark
    {
        private readonly static XmlSerializer _deserializer = new XmlSerializer(typeof(FlightSegmentList));

        [Benchmark(Baseline = true, Description = "XmlSerializer")]
        public FlightSegmentList Deserialize()
        {
            using (var stream = File.OpenRead("XML\\BenchmarkTest.xml"))
            {
                return (FlightSegmentList)_deserializer.Deserialize(stream);
            }
        }

        [Benchmark(Description = "XmlReader")]
        public FlightSegmentList Read()
        {
            var list = new FlightSegmentList
            {
                FlightSegment = new List<FlightSegmentListFlightSegment>()
            };

            using (XmlReader reader = XmlReader.Create("XML\\BenchmarkTest.xml"))
            {
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "FlightSegment")
                    {
                        list.FlightSegment.Add(GetSegment(reader));
                    }
                }
            }

            return list;
        }

        private static FlightSegmentListFlightSegment GetSegment(XmlReader reader)
        {
            var segment = new FlightSegmentListFlightSegment();
            reader.Read(); //Departure
            segment.Departure = ParseDeparture(reader);
            reader.Read();
            reader.Read();
            reader.Read(); // Arrival
            segment.Arrival = ParseArrival(reader);
            reader.Read();
            reader.Read();
            reader.Read(); // MarketingCarrier
            segment.MarketingCarrier = ParseMarketingCarrier(reader);
            reader.Read();
            reader.Read();
            reader.Read(); // OperatingCarrier
            segment.OperatingCarrier = ParseOperatingCarrier(reader);
            reader.Read();
            reader.Read();
            reader.Read(); // Equipment
            segment.Equipment = ParseEquipment(reader);
            reader.Read();
            reader.Read();
            reader.Read(); // FlightDetail
            segment.FlightDetail = ParseFlightDetail(reader);
            return segment;
        }

        private static FlightSegmentListFlightSegmentFlightDetail ParseFlightDetail(XmlReader reader)
        {
            var detail = new FlightSegmentListFlightSegmentFlightDetail()
            {
                FlightDuration = new FlightSegmentListFlightSegmentFlightDetailFlightDuration()
            };
            reader.Read();
            reader.Read();
            reader.Read();
            detail.FlightDuration.Value = reader.Value;

            return detail;
        }

        private static FlightSegmentListFlightSegmentEquipment ParseEquipment(XmlReader reader)
        {
            var equipment = new FlightSegmentListFlightSegmentEquipment();
            reader.Read();
            reader.Read();
            equipment.AircraftCode = Convert.ToUInt16(reader.Value);
            reader.Read();
            reader.Read();
            reader.Read();
            equipment.Name = reader.Value;
            return equipment;
        }

        private static FlightSegmentListFlightSegmentOperatingCarrier ParseOperatingCarrier(XmlReader reader)
        {
            var carrier = new FlightSegmentListFlightSegmentOperatingCarrier();
            reader.Read();
            reader.Read();
            carrier.AirlineID = reader.Value;
            reader.Read();
            reader.Read();
            reader.Read();
            carrier.Name = reader.Value;
            return carrier;
        }

        private static FlightSegmentListFlightSegmentMarketingCarrier ParseMarketingCarrier(XmlReader reader)
        {
            var carrier = new FlightSegmentListFlightSegmentMarketingCarrier();
            reader.Read();
            reader.Read();
            carrier.AirlineID = reader.Value;
            reader.Read();
            reader.Read();
            reader.Read();
            carrier.FlightNumber = Convert.ToByte(reader.Value);
            return carrier;
        }

        private static FlightSegmentListFlightSegmentArrival ParseArrival(XmlReader reader)
        {
            var arrival = new FlightSegmentListFlightSegmentArrival();
            reader.Read();
            reader.Read();
            arrival.AirportCode = reader.Value;
            reader.Read();
            reader.Read();
            reader.Read();
            arrival.Date = DateTime.ParseExact(reader.Value, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
            reader.Read();
            reader.Read();
            reader.Read();
            arrival.Time = reader.Value;
            return arrival;
        }

        private static FlightSegmentListFlightSegmentDeparture ParseDeparture(XmlReader reader)
        {
            var departure = new FlightSegmentListFlightSegmentDeparture();
            reader.Read();
            reader.Read();
            departure.AirportCode = reader.Value;
            reader.Read();
            reader.Read();
            reader.Read();
            departure.Date = DateTime.ParseExact(reader.Value, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
            reader.Read();
            reader.Read();
            reader.Read();
            departure.Time = reader.Value;
            return departure;
        }
    }
}
