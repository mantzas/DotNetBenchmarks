using BenchmarkDotNet.Running;
using System.Reflection;

namespace DotNetBenchmarks
{
#pragma warning disable RCS1102 // Make class static.
    public class Program
    {
        public static void Main(string[] args)
        {
            BenchmarkSwitcher.FromAssembly(typeof(Program).GetTypeInfo().Assembly).Run(args);
        }
    }
#pragma warning restore RCS1102 // Make class static.
}
