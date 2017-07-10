``` ini

BenchmarkDotNet=v0.10.8, OS=Windows 10 Redstone 2 (10.0.15063)
Processor=Intel Core i7-4700MQ CPU 2.40GHz (Haswell), ProcessorCount=8
Frequency=2338339 Hz, Resolution=427.6540 ns, Timer=TSC
  [Host]     : Clr 4.0.30319.42000, 32bit LegacyJIT-v4.7.2098.0
  DefaultJob : Clr 4.0.30319.42000, 32bit LegacyJIT-v4.7.2098.0


```
 |               Method |       Mean |     Error |     StdDev | Scaled | ScaledSD |   Gen 0 | Allocated |
 |--------------------- |-----------:|----------:|-----------:|-------:|---------:|--------:|----------:|
 | 'File Stream Writer' |   2.140 us | 0.0175 us |  0.0137 us |   1.00 |     0.00 |  0.1640 |     524 B |
 |                 NLog | 215.538 us | 5.5825 us | 15.7456 us | 100.71 |     7.34 | 10.7422 |   33850 B |
 |              Log4Net | 194.455 us | 4.0656 us |  8.8382 us |  90.86 |     4.13 |  1.7090 |    5489 B |
 |              Serilog |  11.702 us | 0.1012 us |  0.0947 us |   5.47 |     0.05 |  0.3052 |     976 B |
