using System.ServiceProcess;
using Log = Monitor.MonitorLog;

namespace Monitor.Actions
{
    [MonitorAction("StartService")]
    public class AStartService : IMonitorAction
    {
        public void Execute(object sender)
        {
            ServiceController Controller = sender as ServiceController;
            if (Controller != null)
            {
                Log.Info("StartService.Execute");
                Controller.Start();
            }
        }
    }
}
