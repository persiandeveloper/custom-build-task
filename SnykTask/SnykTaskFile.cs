using Microsoft.Build.Utilities;
using System;
using System.Diagnostics;

namespace SnykTask
{
    public class SnykTaskFile : Task
    {
        public override bool Execute()
        {
            var processInfo = new ProcessStartInfo();
            processInfo.FileName = "cmd";
            Process.Start(processInfo);

            return true;
        }
    }
}
