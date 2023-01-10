using Monitor.Properties;
using System.ServiceProcess;
using System.Timers;

namespace Monitor
{
    public class MonitorJob : Timer
    {
        private readonly IMonitorAction ServiceAction = null;

        public MonitorJob()
        {
            this.ServiceAction = MonitorSettings.GetAction();
            this.Elapsed += MonitorJob_Elapsed;
        }

        private void MonitorJob_Elapsed(object sender, ElapsedEventArgs e)
        {
            ServiceController Service = new ServiceController(MonitorSettings.GetServiceName());
            if (Service != null && Service.Status != ServiceControllerStatus.Running)
            {
                ServiceAction.Execute(Service as object);
            }
        }
    }
}
