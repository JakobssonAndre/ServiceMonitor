using System.Runtime.InteropServices;
using Log = Monitor.MonitorLog;

namespace Monitor.Actions
{
    [MonitorAction("LockDevice")]
    public class ALockDevice : IMonitorAction
    {
        [DllImport("User32")]
        private static extern void LockWorkStation();

        public void Execute(object sender)
        {
            Log.Info("LockDevice.Execute");
            LockWorkStation();
        }
    }
}
