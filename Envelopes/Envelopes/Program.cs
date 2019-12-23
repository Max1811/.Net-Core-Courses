using Serilog;

namespace Envelopes
{
    class Program
    {
        static void Main(string[] args)
        {
            EnvelopesApp _envelopesApp = new EnvelopesApp();

            Log.Logger = new LoggerConfiguration().MinimumLevel.Debug().WriteTo.File("log.txt").CreateLogger();

            _envelopesApp.Start(args);
        }
    }
}
