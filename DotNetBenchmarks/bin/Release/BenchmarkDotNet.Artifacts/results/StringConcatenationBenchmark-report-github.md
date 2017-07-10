``` ini

BenchmarkDotNet=v0.10.8, OS=Windows 10 Redstone 2 (10.0.15063)
Processor=Intel Core i7-4700MQ CPU 2.40GHz (Haswell), ProcessorCount=8
Frequency=2338339 Hz, Resolution=427.6540 ns, Timer=TSC
  [Host]     : Clr 4.0.30319.42000, 32bit LegacyJIT-v4.7.2098.0
  DefaultJob : Clr 4.0.30319.42000, 32bit LegacyJIT-v4.7.2098.0


```
 |                     Method |        Mean |      Error |     StdDev |      Median | Scaled | ScaledSD |  Gen 0 | Allocated |
 |--------------------------- |------------:|-----------:|-----------:|------------:|-------:|---------:|-------:|----------:|
 |  'Plain Concatenate Small' |    95.18 ns |  0.5673 ns |  0.4737 ns |    94.98 ns |   1.00 |     0.00 | 0.0508 |     160 B |
 |               'Join Small' |    66.80 ns |  1.6542 ns |  2.2643 ns |    65.81 ns |   0.70 |     0.02 | 0.0165 |      52 B |
 |        'Concatenate Small' |    77.14 ns |  1.6241 ns |  1.5192 ns |    76.36 ns |   0.81 |     0.02 | 0.0266 |      84 B |
 |            'Builder Small' |   140.22 ns |  1.3065 ns |  0.8642 ns |   140.15 ns |   1.47 |     0.01 | 0.0622 |     196 B |
 |             'Format Small' |   196.52 ns |  3.5169 ns |  3.2897 ns |   194.77 ns |   2.06 |     0.03 | 0.0165 |      52 B |
 |      'Interpolation Small' |   220.62 ns |  1.3002 ns |  1.2162 ns |   220.68 ns |   2.32 |     0.02 | 0.0265 |      84 B |
 | 'Plain Concatenate Medium' |   233.53 ns |  2.5965 ns |  2.1682 ns |   233.20 ns |   2.45 |     0.02 | 0.1740 |     548 B |
 |              'Join Medium' |   170.04 ns |  3.4637 ns |  3.5570 ns |   169.97 ns |   1.79 |     0.04 | 0.0291 |      92 B |
 |       'Concatenate Medium' |   146.28 ns |  0.6359 ns |  0.5948 ns |   146.21 ns |   1.54 |     0.01 | 0.0455 |     144 B |
 |           'Builder Medium' |   219.94 ns |  0.9303 ns |  0.7769 ns |   220.13 ns |   2.31 |     0.01 | 0.1080 |     340 B |
 |            'Format Medium' |   374.73 ns |  1.6072 ns |  1.3421 ns |   374.48 ns |   3.94 |     0.02 | 0.0291 |      92 B |
 |     'Interpolation Medium' |   507.56 ns | 11.3591 ns | 10.0696 ns |   502.15 ns |   5.33 |     0.11 | 0.0601 |     192 B |
 |  'Plain Concatenate Large' |   646.77 ns | 14.1949 ns | 16.3469 ns |   641.69 ns |   6.80 |     0.17 | 0.7191 |    2264 B |
 |               'Join Large' |   326.71 ns |  1.8846 ns |  1.5737 ns |   326.73 ns |   3.43 |     0.02 | 0.0758 |     240 B |
 |        'Concatenate Large' |   296.82 ns |  5.1276 ns |  4.7963 ns |   294.08 ns |   3.12 |     0.05 | 0.1054 |     332 B |
 |            'Builder Large' |   386.33 ns |  7.7333 ns |  6.8553 ns |   383.38 ns |   4.06 |     0.07 | 0.2084 |     656 B |
 |             'Format Large' |   766.28 ns | 17.8032 ns | 26.0957 ns |   752.31 ns |   8.05 |     0.27 | 0.0753 |     240 B |
 |      'Interpolation Large' | 1,068.02 ns | 10.2849 ns |  9.6205 ns | 1,067.48 ns |  11.22 |     0.11 | 0.1507 |     476 B |
