using System.ComponentModel;
using System.Configuration.Install;
using System.ServiceProcess;

namespace Monitor
{
    [RunInstaller(true)]
    public class MonitorInstaller : Installer
    {
        public const string ServiceName = "ServiceMonitor";

        private ServiceProcessInstaller ServiceProcessInstaller;
        private ServiceInstaller ServiceInstaller;

        public MonitorInstaller()
        {
            ServiceProcessInstaller = new ServiceProcessInstaller();
            ServiceProcessInstaller.Account = ServiceAccount.LocalSystem;
            ServiceInstaller = new ServiceInstaller();
            ServiceInstaller.ServiceName = ServiceName;
            Installers.Add(ServiceProcessInstaller);
            Installers.Add(ServiceInstaller);
        }
    }
}
