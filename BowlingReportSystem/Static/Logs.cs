using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;
using Serilog.Sinks.File;
using System.Configuration;
using Serilog.Settings.AppSettings;

namespace BowlingReportSystem
{
    static class Logs
    {
        public static void saveToLogFile(string message)
        {
            Log.Logger = new LoggerConfiguration().ReadFrom.AppSettings().CreateLogger();
            Log.Logger.Fatal(message);
        }
    }
}
