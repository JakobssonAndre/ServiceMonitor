using Monitor.Actions;
using Monitor.Properties;

namespace Monitor
{
    public sealed class MonitorSettings
    {
        private MonitorSettings()
        {
        }

        public static string GetServiceName()
        {
            return Settings.Default.ServiceName;
        }

        public static long GetDelayTimeMS()
        {
            return Settings.Default.DelayTimeMS;
        }

        public static IMonitorAction GetAction()
        {
            switch (Settings.Default.ActionClass)
            {
                case "LockDevice":
                    return new ALockDevice();
                case "StartService":
                    return new AStartService();
            }

            return null;
        }
    }
}
