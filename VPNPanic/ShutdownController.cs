using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPNPanic
{
    class ShutdownController
    {
        public void ShutdownComputer()
        {
            var pi = new System.Diagnostics.ProcessStartInfo();
            pi.FileName = GetPathToShutdownExe();
            pi.Arguments = @"/f /s /t 10";
            System.Diagnostics.Process.Start(pi);
        }

        private static string GetPathToShutdownExe()
        {
            return System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Windows), "system32\\shutdown.exe");
        }

        public bool CanShutdown()
        {
            return System.IO.File.Exists(GetPathToShutdownExe());
        }

    }
}
