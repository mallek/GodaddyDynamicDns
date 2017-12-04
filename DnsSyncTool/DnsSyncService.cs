using System;
using System.Diagnostics;
using System.Reflection;
using System.ServiceProcess;
using System.Threading.Tasks;
using InternalJobManager;

namespace DnsSyncTool
{
    public partial class DnsSyncService : ServiceBase
    {
        private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType + " v" + Assembly.GetExecutingAssembly().GetName().Version);

        public DnsSyncService()
        {
            InitializeComponent();
        }

        public void OnDebug()
        {
           OnStart(null);
        }

        protected override void OnStart(string[] args)
        {


                Assembly assembly = Assembly.GetExecutingAssembly();
                FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
                string version = fvi.FileVersion;

                try
                {
                    Log.Debug("Job Manager Started");
                    JobManager.RunJobs();

                }
                catch (Exception ex)
                {

                    Log.Error("There was an error starting the job manager", ex);
                }

                Log.Info($"Dns Sync v{version} is alive... ;)");

           

           
        }

        protected override void OnStop()
        {
            Log.Info("Dns Sync was stopped successfully");
        }
    }
}
