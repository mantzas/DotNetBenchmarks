``` ini

BenchmarkDotNet=v0.10.8, OS=Windows 10 Redstone 2 (10.0.15063)
Processor=Intel Core i7-4700MQ CPU 2.40GHz (Haswell), ProcessorCount=8
Frequency=2338339 Hz, Resolution=427.6540 ns, Timer=TSC
  [Host]     : Clr 4.0.30319.42000, 32bit LegacyJIT-v4.7.2098.0
  DefaultJob : Clr 4.0.30319.42000, 32bit LegacyJIT-v4.7.2098.0


```
 |                                 Method |     Mean |      Error |     StdDev | Scaled | ScaledSD |  Gen 0 |  Gen 1 | Allocated |
 |--------------------------------------- |---------:|-----------:|-----------:|-------:|---------:|-------:|-------:|----------:|
 |                    'DateTime ToString' | 848.8 ns |  2.8059 ns |  2.4874 ns |   1.00 |     0.00 | 0.0410 |      - |     132 B |
 |        'DateTime ToString with format' | 790.0 ns | 18.0956 ns | 16.0413 ns |   0.93 |     0.02 | 0.0391 | 0.0104 |     124 B |
 |   'DateTime ToString InvariantCulture' | 794.0 ns | 13.5455 ns | 12.0078 ns |   0.94 |     0.01 | 0.0391 | 0.0087 |     124 B |
 |   'DateTime ToString InvariantCulture' | 722.3 ns |  8.4907 ns |  7.5267 ns |   0.85 |     0.01 | 0.0372 |      - |     120 B |
 |      'String.Join 12/31/2016 23:59:59' | 198.4 ns |  0.9390 ns |  0.7331 ns |   0.23 |     0.00 | 0.0341 |      - |     108 B |
 | 'String.Join Dict 12/31/2016 23:59:59' | 267.7 ns |  5.3276 ns |  6.9274 ns |   0.32 |     0.01 | 0.0339 |      - |     108 B |
