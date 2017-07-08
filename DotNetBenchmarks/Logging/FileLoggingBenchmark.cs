using BenchmarkDotNet.Attributes;
using Serilog;
using System;
using System.IO;

namespace DotNetBenchmarks.Logging
{
    [MemoryDiagnoser]
    public class FileLoggingBenchmark
    {
        private static readonly NLog.ILogger nlogLogger;
        private static readonly log4net.ILog log4NetLogger;
        private static readonly Serilog.ILogger serilogLogger;
        private static readonly StreamWriter streamWriter;
        private const string message = "this is a test message {0}";

        static FileLoggingBenchmark()
        {
            serilogLogger = CreateSerilogLogger();
            nlogLogger = CreateNLogLogger();
            log4NetLogger = CreateLog4NetLogger();
            streamWriter = CreateStreamWriter();
        }

        [Benchmark(Baseline = true, Description = "Console Write Line")]
        public string ConsoleMethod()
        {         
            streamWriter.WriteLine(message, DateTime.Now);
            return message;
        }

        [Benchmark(Description = "NLog")]
        public string NLogMethod()
        {
            nlogLogger.Info(message, DateTime.Now);
            return message;
        }

        [Benchmark(Description = "Log4Net")]
        public string Log4NetMethod()
        {
            log4NetLogger.InfoFormat(message, DateTime.Now);
            return message;
        }

        [Benchmark(Description = "Serilog")]
        public string SerilogMethod()
        {
            serilogLogger.Information(message, DateTime.Now);
            return message;
        }

        private static StreamWriter CreateStreamWriter()
        {
            return File.AppendText("append.log");
        }

        private static ILogger CreateSerilogLogger()
        {
            return new LoggerConfiguration().WriteTo.File("serilog.log", shared: true).CreateLogger();
        }

        private static NLog.Logger CreateNLogLogger()
        {
            var config = new NLog.Config.LoggingConfiguration();

            var target = new NLog.Targets.FileTarget
            {
                FileName = "nlog.log",
                ConcurrentWrites = true
            };

            config.AddTarget("logfile", target);

            
            var rule = new NLog.Config.LoggingRule("*", NLog.LogLevel.Debug, target);

            config.LoggingRules.Add(rule);

            
            NLog.LogManager.Configuration = config;
            return NLog.LogManager.GetCurrentClassLogger();
        }

        private static log4net.ILog CreateLog4NetLogger()
        {
            var hierarchy = (log4net.Repository.Hierarchy.Hierarchy)log4net.LogManager.GetRepository();
            var patternLayout = new log4net.Layout.PatternLayout()
            {
                ConversionPattern = "%date %-5level %logger %message%newline"
            };
            patternLayout.ActivateOptions();

            var roller = new log4net.Appender.FileAppender
            {
                File = "log4net.txt",
                Layout = patternLayout,
                LockingModel = new log4net.Appender.FileAppender.MinimalLock()
            };
            roller.ActivateOptions();
            hierarchy.Root.AddAppender(roller);
            
            hierarchy.Root.Level = log4net.Core.Level.Info;
            hierarchy.Configured = true;
            return log4net.LogManager.GetLogger(typeof(FileLoggingBenchmark));
        }
    }
}
