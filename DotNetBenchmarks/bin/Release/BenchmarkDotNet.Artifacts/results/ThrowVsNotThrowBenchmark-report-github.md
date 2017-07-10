``` ini

BenchmarkDotNet=v0.10.8, OS=Windows 10 Redstone 2 (10.0.15063)
Processor=Intel Core i7-4700MQ CPU 2.40GHz (Haswell), ProcessorCount=8
Frequency=2338339 Hz, Resolution=427.6540 ns, Timer=TSC
  [Host]     : Clr 4.0.30319.42000, 32bit LegacyJIT-v4.7.2098.0
  DefaultJob : Clr 4.0.30319.42000, 32bit LegacyJIT-v4.7.2098.0


```
 |          Method |          Mean |      Error |     StdDev |   Scaled | ScaledSD |  Gen 0 | Allocated |
 |---------------- |--------------:|-----------:|-----------:|---------:|---------:|-------:|----------:|
 | 'Without Throw' |      2.479 ns |  0.0142 ns |  0.0126 ns |     1.00 |     0.00 |      - |       0 B |
 |    'With Throw' | 10,149.846 ns | 41.7597 ns | 34.8713 ns | 4,094.61 |    24.21 | 0.0458 |     148 B |
