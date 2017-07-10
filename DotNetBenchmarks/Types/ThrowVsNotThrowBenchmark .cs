using BenchmarkDotNet.Attributes;
using System;

namespace ETravel.Benchmarks.Types
{
    [MemoryDiagnoser]
    public class ThrowVsNotThrowBenchmark
    {
        [Benchmark(Baseline = true, Description = "Without Throw")]
        public Exception WithoutThrow()
        {
            return Test();
        }

        [Benchmark(Description = "With Throw")]
        public Exception WithThrow()
        {
            return TestWithExcetption();
        }

        private Exception Test()
        {
            try
            {
                return null;
            }
            catch (Exception exception)
            {
                return exception;
            }
        }

        private Exception TestWithExcetption()
        {
            try
            {
                throw new Exception("TEST");
            }
            catch (Exception exception)
            {
                return exception;
            }
        }
    }
}
