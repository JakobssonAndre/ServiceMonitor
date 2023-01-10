using System;
using System.Diagnostics;

namespace Monitor
{
    public sealed class MonitorLog
    {
        private static readonly EventLog Log = new EventLog();

        private MonitorLog()
        {
            //Log.Source = MonitorInstaller.ServiceName;
            //Log.Log = "Monitor";
            //Log.BeginInit();
            //if (!EventLog.SourceExists(Log.Source))
            //{
            //    EventLog.CreateEventSource(Log.Source, Log.Log);
            //}
            //Log.EndInit();
        }
        
        public static void Info(string Text)
        {
            Console.WriteLine(Text);
            //Log.WriteEntry(Text, EventLogEntryType.Information, 42);
        }

        public static void Error(string Text)
        {
            Console.Error.WriteLine(Text);
            //Log.WriteEntry(Text, EventLogEntryType.Error, 42);
        }
    }
}
