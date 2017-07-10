using BenchmarkDotNet.Attributes;
using System.Collections.Generic;
using System.Linq;

namespace ETravel.Benchmarks.Types
{
    [MemoryDiagnoser]
    public class ToArrayVsIEnumerableVsToListBenchmark
    {
        private static readonly IEnumerable<TestClass> _data;

        static ToArrayVsIEnumerableVsToListBenchmark()
        {
            var list = new List<TestClass>();

            for (int i = 0; i < 10100; i++)
            {
                list.Add(new TestClass(i));
            }

            _data = list.Where(p => p.Number >= 0);
        }

        [Benchmark(Baseline = true, Description = "ToArray")]
        public List<TestClass> ToArray()
        {
            var ar = _data.ToArray();
            var result = ar.Take(200).ToList();
            var result1 = ar.Skip(200).Take(10);
            result.AddRange(result1);
            return result;
        }

        [Benchmark(Description = "IEnumerable")]
        public List<TestClass> IEnumerable()
        {
            var result = _data.Take(200).ToList();
            var result1 = _data.Skip(200).Take(10);
            result.AddRange(result1);
            return result;
        }

        [Benchmark(Description = "ToList")]
        public List<TestClass> ToList()
        {
            var ar = _data.ToList();
            var result = ar.Take(200).ToList();
            var result1 = ar.Skip(200).Take(10);
            result.AddRange(result1);
            return result;
        }

        public class TestClass
        {
            public int Number { get; }

            public TestClass(int number)
            {
                Number = number;
            }
        }
    }
}
