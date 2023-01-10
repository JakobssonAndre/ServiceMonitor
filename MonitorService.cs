using System.ServiceProcess;
using Log = Monitor.MonitorLog;

namespace Monitor
{
    public partial class MonitorService : ServiceBase
    {
        private static MonitorJob Job;

        public MonitorService()
        {
            InitializeComponent();

            Log.Info("Initializing");
            Job = new MonitorJob();
            Job.Interval = MonitorSettings.GetDelayTimeMS();
        }

        protected override void OnStart(string[] args)
        {
            Log.Info("Start");
            Job.Start();
        }

        protected override void OnStop()
        {
            Log.Info("Stop");
            Job.Dispose();
        }
    }
}
