﻿using Microsoft.Build.Utilities;
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
            processInfo.RedirectStandardInput = true;
            processInfo.UseShellExecute = false;
            processInfo.WorkingDirectory = Location;

            var a = Process.Start(processInfo);

            a.StandardInput.WriteLine("exit");

            return true;
        }

        public string Location { get; set; }
    }

    class Root
    {
        public string Name { get; set; }
    }
}


