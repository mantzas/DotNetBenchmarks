``` ini

BenchmarkDotNet=v0.10.8, OS=Windows 10 Redstone 2 (10.0.15063)
Processor=Intel Core i7-4700MQ CPU 2.40GHz (Haswell), ProcessorCount=8
Frequency=2338339 Hz, Resolution=427.6540 ns, Timer=TSC
  [Host]     : Clr 4.0.30319.42000, 32bit LegacyJIT-v4.7.2098.0
  DefaultJob : Clr 4.0.30319.42000, 32bit LegacyJIT-v4.7.2098.0


```
 |               Method |       Mean |     Error |    StdDev | Scaled | ScaledSD |   Gen 0 | Allocated |
 |--------------------- |-----------:|----------:|----------:|-------:|---------:|--------:|----------:|
 | 'Console Write Line' |   2.069 us | 0.0147 us | 0.0130 us |   1.00 |     0.00 |  0.1602 |     516 B |
 |                 NLog | 176.848 us | 3.3117 us | 2.7654 us |  85.49 |     1.38 | 10.7422 |   33850 B |
 |              Log4Net | 163.314 us | 3.2249 us | 5.0207 us |  78.95 |     2.44 |  1.7090 |    5489 B |
 |              Serilog |  10.618 us | 0.0629 us | 0.0558 us |   5.13 |     0.04 |  0.3052 |     976 B |
