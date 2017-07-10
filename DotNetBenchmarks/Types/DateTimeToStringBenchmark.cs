using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ETravel.Benchmarks.Types
{
    [MemoryDiagnoser]
    public class DateTimeToStringBenchmark
    {
        private static readonly DateTime _dateTime = new DateTime(2016, 12, 31, 23, 59, 59, 999);
        public static readonly Dictionary<int, string> _intMap;

        static DateTimeToStringBenchmark()
        {
            _intMap = Enumerable.Range(0, 1000000).ToDictionary(p => p, k => k.ToString());
        }

        [Benchmark(Baseline = true, Description = "DateTime ToString")]
        public string DateTimeToString()
        {
            return _dateTime.ToString();
        }

        [Benchmark(Description = "DateTime ToString with format")]
        public string DateTimeToStringFormat()
        {
            return _dateTime.ToString("g");
        }

        [Benchmark(Description = "DateTime ToString InvariantCulture")]
        public string DateTimeToStringInvariantCulture()
        {
            return _dateTime.ToString(CultureInfo.InvariantCulture);
        }

        [Benchmark(Description = "DateTime ToString InvariantCulture")]
        public string DateTimeToStringFormatInvariantCulture()
        {
            return _dateTime.ToString("g", CultureInfo.InvariantCulture);
        }

        [Benchmark(Description = "String.Join 12/31/2016 23:59:59")]
        public string DateTimeStringJoin()
        {
            return string.Join(string.Empty, new string[] { IntText(11), "/", IntText(31), "/", YearText(2016), " ", IntText(23), ":", IntText(59), ":", IntText(59) });
        }

        [Benchmark(Description = "String.Join Dict 12/31/2016 23:59:59")]
        public string DateTimeStringJoinWithDictionary()
        {
            return string.Join(string.Empty, new string[] { _intMap[11], "/", _intMap[31], "/", _intMap[2016], " ", _intMap[23], ":", _intMap[59], ":", _intMap[59] });
        }

        private static string IntText(int value)
        {
            switch (value)
            {
                case 0:
                    return "0";
                case 1:
                    return "1";
                case 2:
                    return "2";
                case 3:
                    return "3";
                case 4:
                    return "4";
                case 5:
                    return "5";
                case 6:
                    return "6";
                case 7:
                    return "7";
                case 8:
                    return "8";
                case 9:
                    return "9";
                case 10:
                    return "10";
                case 11:
                    return "11";
                case 12:
                    return "12";
                case 13:
                    return "13";
                case 14:
                    return "14";
                case 15:
                    return "15";
                case 16:
                    return "16";
                case 17:
                    return "17";
                case 18:
                    return "18";
                case 19:
                    return "19";
                case 20:
                    return "20";
                case 21:
                    return "21";
                case 22:
                    return "22";
                case 23:
                    return "23";
                case 24:
                    return "24";
                case 25:
                    return "25";
                case 26:
                    return "26";
                case 27:
                    return "27";
                case 28:
                    return "28";
                case 29:
                    return "29";
                case 30:
                    return "30";
                case 31:
                    return "31";
                case 32:
                    return "32";
                case 33:
                    return "33";
                case 34:
                    return "34";
                case 35:
                    return "35";
                case 36:
                    return "36";
                case 37:
                    return "37";
                case 38:
                    return "38";
                case 39:
                    return "39";
                case 40:
                    return "40";
                case 41:
                    return "41";
                case 42:
                    return "42";
                case 43:
                    return "43";
                case 44:
                    return "44";
                case 45:
                    return "45";
                case 46:
                    return "46";
                case 47:
                    return "47";
                case 48:
                    return "48";
                case 49:
                    return "49";
                case 50:
                    return "50";
                case 51:
                    return "51";
                case 52:
                    return "52";
                case 53:
                    return "53";
                case 54:
                    return "54";
                case 55:
                    return "55";
                case 56:
                    return "56";
                case 57:
                    return "57";
                case 58:
                    return "58";
                case 59:
                    return "59";
                case 60:
                    return "60";
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private static string YearText(int year)
        {
            switch (year)
            {
                case 2016:
                    return "2016";
                case 2017:
                    return "2017";
                case 2018:
                    return "2018";
                case 2019:
                    return "2019";
                case 2020:
                    return "2020";
                case 2021:
                    return "2021";
                case 2022:
                    return "2022";
                case 2023:
                    return "2023";
                case 2024:
                    return "2024";
                case 2025:
                    return "2025";
                case 2026:
                    return "2026";
                case 2027:
                    return "2027";
                case 2028:
                    return "2028";
                case 2029:
                    return "2029";
                case 2030:
                    return "2030";
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
