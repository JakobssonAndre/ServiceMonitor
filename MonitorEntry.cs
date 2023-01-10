using System;
using System.Configuration.Install;
using System.Reflection;
using System.ServiceProcess;
using Log = Monitor.MonitorLog;

namespace Monitor
{
    public static class MonitorEntry
    {
        public static void Main(string[] args)
        {
            if (Environment.UserInteractive)
            {
                var parameter = string.Concat(args);
                switch (parameter)
                {
                    case "--install":
                        ManagedInstallerClass.InstallHelper(new[] { Assembly.GetExecutingAssembly().Location });
                        break;
                    case "--uninstall":
                        ManagedInstallerClass.InstallHelper(new[] { "/u", Assembly.GetExecutingAssembly().Location });
                        break;
                }
                return;
            }

            Log.Info("Starting");
            ServiceBase[] ServicesToRun = new ServiceBase[]
            {
                new MonitorService()
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
