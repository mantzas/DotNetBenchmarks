``` ini

BenchmarkDotNet=v0.10.8, OS=Windows 10 Redstone 2 (10.0.15063)
Processor=Intel Core i7-4700MQ CPU 2.40GHz (Haswell), ProcessorCount=8
Frequency=2338339 Hz, Resolution=427.6540 ns, Timer=TSC
  [Host]     : Clr 4.0.30319.42000, 32bit LegacyJIT-v4.7.2098.0
  DefaultJob : Clr 4.0.30319.42000, 32bit LegacyJIT-v4.7.2098.0


```
 |      Method |       Mean |     Error |    StdDev | Scaled |   Gen 0 | Allocated |
 |------------ |-----------:|----------:|----------:|-------:|--------:|----------:|
 |     ToArray | 288.149 us | 2.0802 us | 1.9458 us |   1.00 | 54.6875 | 170.12 KB |
 | IEnumerable |   9.369 us | 0.0293 us | 0.0260 us |   0.03 |  0.7324 |   2.29 KB |
 |      ToList | 232.170 us | 1.6818 us | 1.5731 us |   0.81 | 41.9922 | 130.56 KB |
