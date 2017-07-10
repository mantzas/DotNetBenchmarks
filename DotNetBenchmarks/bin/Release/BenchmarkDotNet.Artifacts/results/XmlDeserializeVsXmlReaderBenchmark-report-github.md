``` ini

BenchmarkDotNet=v0.10.8, OS=Windows 10 Redstone 2 (10.0.15063)
Processor=Intel Core i7-4700MQ CPU 2.40GHz (Haswell), ProcessorCount=8
Frequency=2338339 Hz, Resolution=427.6540 ns, Timer=TSC
  [Host]     : Clr 4.0.30319.42000, 32bit LegacyJIT-v4.7.2098.0
  DefaultJob : Clr 4.0.30319.42000, 32bit LegacyJIT-v4.7.2098.0


```
 |        Method |     Mean |     Error |    StdDev | Scaled |    Gen 0 |    Gen 1 |    Gen 2 | Allocated |
 |-------------- |---------:|----------:|----------:|-------:|---------:|---------:|---------:|----------:|
 | XmlSerializer | 74.83 ms | 0.4180 ms | 0.3706 ms |   1.00 | 875.0000 | 687.5000 | 250.0000 |    4.2 MB |
 |     XmlReader | 34.89 ms | 0.4235 ms | 0.3754 ms |   0.47 | 500.0000 | 437.5000 |        - |   2.95 MB |
