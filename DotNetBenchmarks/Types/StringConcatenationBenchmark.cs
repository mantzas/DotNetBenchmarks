using BenchmarkDotNet.Attributes;
using System.Text;

namespace ETravel.Benchmarks.Types
{
    [MemoryDiagnoser]
    public class StringConcatenationBenchmark
    {
        private static readonly string[] _smallSample = new string[] { "One", "Two", "Three", "Four", "Five" };
        private static readonly string[] _mediumSample = new string[] { "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten" };
        private static readonly string[] _largeSample = new string[] { "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen", "Twenty" };

        [Benchmark(Baseline = true, Description = "Plain Concatenate Small")]
        public string PlainConcatenateSmall()
        {
            var result = string.Empty;

            for (int i = 0; i < _smallSample.Length; i++)
            {
                result += _smallSample[i];
            }
            return result;
        }

        [Benchmark(Description = "Join Small")]
        public string JoinSmall()
        {
            return string.Join(string.Empty, _smallSample);
        }

        [Benchmark(Description = "Concatenate Small")]
        public string ConcatSmall()
        {
            return string.Concat(_smallSample);
        }

        [Benchmark(Description = "Builder Small")]
        public string BuilderSmall()
        {
            var builder = new StringBuilder();

            for (int i = 0; i < _smallSample.Length; i++)
            {
                builder.Append(_smallSample[i]);
            }

            return builder.ToString();
        }

        [Benchmark(Description = "Format Small")]
        public string FormatSmall()
        {
            return string.Format("{0}{1}{2}{3}{4}", _smallSample);
        }

        [Benchmark(Description = "Interpolation Small")]
        public string InterpolationSmall()
        {
            return $"{_smallSample[0]}{_smallSample[1]}{_smallSample[2]}{_smallSample[3]}{_smallSample[4]}";
        }

        [Benchmark(Description = "Plain Concatenate Medium")]
        public string PlainConcatenateMedium()
        {
            var result = string.Empty;

            for (int i = 0; i < _mediumSample.Length; i++)
            {
                result += _mediumSample[i];
            }
            return result;
        }

        [Benchmark(Description = "Join Medium")]
        public string JoinMedium()
        {
            return string.Join(string.Empty, _mediumSample);
        }

        [Benchmark(Description = "Concatenate Medium")]
        public string ConcatMedium()
        {
            return string.Concat(_mediumSample);
        }

        [Benchmark(Description = "Builder Medium")]
        public string BuilderMedium()
        {
            var builder = new StringBuilder();

            for (int i = 0; i < _mediumSample.Length; i++)
            {
                builder.Append(_mediumSample[i]);
            }

            return builder.ToString();
        }

        [Benchmark(Description = "Format Medium")]
        public string FormatMedium()
        {
            return string.Format("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}", _mediumSample);
        }

        [Benchmark(Description = "Interpolation Medium")]
        public string InterpolationMedium()
        {
            return $@"{_mediumSample[0]}{_mediumSample[1]}{_mediumSample[2]}{_mediumSample[3]}{_mediumSample[4]}
                      {_mediumSample[5]}{_mediumSample[6]}{_mediumSample[7]}{_mediumSample[8]}{_mediumSample[9]}";
        }

        [Benchmark(Description = "Plain Concatenate Large")]
        public string PlainConcatenateLarge()
        {
            var result = string.Empty;

            for (int i = 0; i < _largeSample.Length; i++)
            {
                result += _largeSample[i];
            }
            return result;
        }

        [Benchmark(Description = "Join Large")]
        public string JoinLarge()
        {
            return string.Join(string.Empty, _largeSample);
        }

        [Benchmark(Description = "Concatenate Large")]
        public string ConcatLarge()
        {
            return string.Concat(_largeSample);
        }

        [Benchmark(Description = "Builder Large")]
        public string BuilderLarge()
        {
            var builder = new StringBuilder();

            for (int i = 0; i < _largeSample.Length; i++)
            {
                builder.Append(_largeSample[i]);
            }

            return builder.ToString();
        }

        [Benchmark(Description = "Format Large")]
        public string FormatLarge()
        {
            return string.Format("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}{14}{15}{16}{17}{18}{19}", _largeSample);
        }

        [Benchmark(Description = "Interpolation Large")]
        public string InterpolationLarge()
        {
            return $@"{_largeSample[0]}{_largeSample[1]}{_largeSample[2]}{_largeSample[3]}{_largeSample[4]}
                      {_largeSample[5]}{_largeSample[6]}{_largeSample[7]}{_largeSample[8]}{_largeSample[9]}
                      {_largeSample[10]}{_largeSample[11]}{_largeSample[12]}{_largeSample[13]}{_largeSample[14]}
                      {_largeSample[15]}{_largeSample[16]}{_largeSample[17]}{_largeSample[18]}{_largeSample[19]}";
        }
    }
}
