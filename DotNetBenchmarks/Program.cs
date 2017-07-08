using BenchmarkDotNet.Running;
using System.Reflection;

namespace DotNetBenchmarks
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkSwitcher.FromAssembly(typeof(Program).GetTypeInfo().Assembly).Run(args);
        }
    }
}
