using BenchmarkDotNet.Running;
using System;
using System.Reflection;

namespace DotNetBenchmarks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var switcher = BenchmarkSwitcher.FromAssembly(typeof(Program).GetTypeInfo().Assembly);

            while (true)
            {
                Console.WriteLine("[S]elect benchmarks, run [A]ll or [ESC] to exit?");

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.A:
                        switcher.RunAll();
                        return;

                    case ConsoleKey.S:
                        switcher.Run(args);
                        return;

                    case ConsoleKey.Escape:
                        Console.WriteLine("Exiting...");
                        return;

                    default:
                        Console.WriteLine("Invalid selection!");
                        break;
                }
            }
        }
    }
}
