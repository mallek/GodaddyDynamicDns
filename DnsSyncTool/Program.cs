using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DnsSyncTool
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static void Main()
        {
#if DEBUG

            var syncService = new DnsSyncService();
            syncService.OnDebug();
            Thread.Sleep(Timeout.Infinite);

#else
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new DnsSyncService()
            };
            ServiceBase.Run(ServicesToRun);
#endif
        }
    }


}
