# DotNetBenchmarks

These are various benchmarks in order to see the performance impact.

The following things hold true for these benchmarks

- These benchmark are not conducted in order to make certain libraries look good or bad
- Please create a issue or better make a PR if you think that the benchmark methodology is wrong or the setup is wrong
- Do not take the results as granted and conduct your own benchmarks to see if in the context of your application the results differ

## File Logging Benchmark Results

The following benchmark tries to evaluate various logging frameworks when logging to a file.

[File Logging Results](https://github.com/mantzas/DotNetBenchmarks/blob/master/DotNetBenchmarks/bin/Release/BenchmarkDotNet.Artifacts/results/FileLoggingBenchmark-report-github.md)

## DateTime ToString Benchmarks

The following benchmark tries to evaluate various ToString methods on a DateTime.

[DateTime ToString Results](https://github.com/mantzas/DotNetBenchmarks/blob/master/DotNetBenchmarks/bin/Release/BenchmarkDotNet.Artifacts/results/DateTimeToStringBenchmark-report-github.md)

## For vs ForEach Benchmarks

The following benchmark tries to evaluate the cost of for vs foreach loops.

[For vs Foreach Results](https://github.com/mantzas/DotNetBenchmarks/blob/master/DotNetBenchmarks/bin/Release/BenchmarkDotNet.Artifacts/results/ForVsForeachBenchmark-report-github.md)

## String Concatenation Benchmarks

The following benchmark tries to evaluate various methods of string concatenation.

[String ConcatenationForeach Results](https://github.com/mantzas/DotNetBenchmarks/blob/master/DotNetBenchmarks/bin/Release/BenchmarkDotNet.Artifacts/results/StringConcatenationBenchmark-report-github.md)

## Throw vs Not Throw Benchmarks

The following benchmark tries to evaluate the cost of throwing exceptions.

[Throw vs Not Throw Results](https://github.com/mantzas/DotNetBenchmarks/blob/master/DotNetBenchmarks/bin/Release/BenchmarkDotNet.Artifacts/results/ThrowVsNotThrowBenchmark-report-github.md)

## IEnumerable vs ToArray and ToList Conversion Benchmark

The following benchmark tries to evaluate the cost of using IEnumerable Linq vs ToArray or ToList conversions.

[IEnumerable vs ToArray and ToList Conversion Results](https://github.com/mantzas/DotNetBenchmarks/blob/master/DotNetBenchmarks/bin/Release/BenchmarkDotNet.Artifacts/results/ToArrayVsIEnumerableVsToListBenchmark-report-github.md)

## Xml Deserialize Vs Xml Reader Benchmark

The following benchmark tries to evaluate the cost deserializing with XmlSerializer vs XmlReader.

[Xml Deserialize Vs Xml Reader Benchmark Results](https://github.com/mantzas/DotNetBenchmarks/blob/master/DotNetBenchmarks/bin/Release/BenchmarkDotNet.Artifacts/results/XmlDeserializeVsXmlReaderBenchmark-report-github.md)
