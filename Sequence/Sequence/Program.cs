using System;
using Serilog;

namespace Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            FibbonacciSequenceApp _sequenceApp = new FibbonacciSequenceApp();

            Log.Logger = new LoggerConfiguration().MinimumLevel.Debug().WriteTo.File("log.txt").CreateLogger();

            _sequenceApp.Start(args);
        }
    }
}
