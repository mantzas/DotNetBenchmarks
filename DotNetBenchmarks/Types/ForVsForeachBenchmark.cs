using BenchmarkDotNet.Attributes;
using System.Collections.Generic;

namespace ETravel.Benchmarks.Types
{
    [MemoryDiagnoser]
    public class ForVsForeachBenchmark
    {
        private static readonly List<TestClass> _data;

        static ForVsForeachBenchmark()
        {
            var result = new List<TestClass>();

            for (int i = 0; i < 100000; i++)
            {
                result.Add(new TestClass(i));
            }

            _data = result;
        }

        [Benchmark(Baseline = true)]
        public TestClass For()
        {
            TestClass result = null;

            for (int i = 0; i < _data.Count; i++)
            {
                result = _data[i];
            }

            return result;
        }

        [Benchmark(Description = "For each")]
        public TestClass Foreach()
        {
            TestClass result = null;

            foreach (var item in _data)
            {
                result = item;
            }

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
