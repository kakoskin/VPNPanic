using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace VPNPanic
{
    class NetworkConnectionController
    {
        public void DisableNetworkConnections()
        {
            SelectQuery wmiQuery = new SelectQuery("SELECT * FROM Win32_NetworkAdapter WHERE NetConnectionId != NULL");
            ManagementObjectSearcher searchProcedure = new ManagementObjectSearcher(wmiQuery);
            foreach (ManagementObject item in searchProcedure.Get())
            {
                System.Diagnostics.Debug.WriteLine(item["NetConnectionId"]);
                item.InvokeMethod("Disable", null);                
            }
        }
    }
}
