``` ini

BenchmarkDotNet=v0.10.8, OS=Windows 10 Redstone 2 (10.0.15063)
Processor=Intel Core i7-4700MQ CPU 2.40GHz (Haswell), ProcessorCount=8
Frequency=2338339 Hz, Resolution=427.6540 ns, Timer=TSC
  [Host]     : Clr 4.0.30319.42000, 32bit LegacyJIT-v4.7.2098.0
  DefaultJob : Clr 4.0.30319.42000, 32bit LegacyJIT-v4.7.2098.0


```
 |               Method |       Mean |     Error |    StdDev | Scaled | ScaledSD |   Gen 0 | Allocated |
 |--------------------- |-----------:|----------:|----------:|-------:|---------:|--------:|----------:|
 | 'File Stream Writer' |   2.104 us | 0.0359 us | 0.0336 us |   1.00 |     0.00 |  0.1602 |     516 B |
 |                 NLog | 186.640 us | 3.6601 us | 6.9637 us |  88.73 |     3.55 | 10.7422 |   33850 B |
 |              Log4Net | 172.830 us | 3.4218 us | 6.7544 us |  82.17 |     3.43 |  1.7090 |    5489 B |
 |              Serilog |  11.747 us | 0.1219 us | 0.1018 us |   5.58 |     0.10 |  0.3052 |     976 B |
