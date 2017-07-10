``` ini

BenchmarkDotNet=v0.10.8, OS=Windows 10 Redstone 2 (10.0.15063)
Processor=Intel Core i7-4700MQ CPU 2.40GHz (Haswell), ProcessorCount=8
Frequency=2338339 Hz, Resolution=427.6540 ns, Timer=TSC
  [Host]     : Clr 4.0.30319.42000, 32bit LegacyJIT-v4.7.2098.0
  DefaultJob : Clr 4.0.30319.42000, 32bit LegacyJIT-v4.7.2098.0


```
 |     Method |     Mean |     Error |    StdDev | Scaled | ScaledSD | Allocated |
 |----------- |---------:|----------:|----------:|-------:|---------:|----------:|
 |        For | 135.3 us | 0.5712 us | 0.5343 us |   1.00 |     0.00 |       0 B |
 | 'For each' | 416.8 us | 2.8199 us | 2.4997 us |   3.08 |     0.02 |       0 B |
