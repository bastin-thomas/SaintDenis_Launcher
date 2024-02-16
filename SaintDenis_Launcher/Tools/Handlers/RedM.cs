﻿using SaintDenis_Launcher.Properties;
using System.Diagnostics;

namespace SaintDenis_Launcher.Tools.Handlers
{
    internal class RedM
    {
        public readonly static String ProcessName = "RedM";
        public readonly static String ExecName = "RedM.exe";
        public readonly static String Arguments = $"+connect {Settings.Default.RedmServerIP}";
        public readonly static String ProcessFolder = Settings.Default.RedmFolder;

        private static ProcessHandler _pr;

        /// <summary>
        /// All behaviors to Start RedM Properly Synchronously
        /// </summary>
        public static void Start(bool asArguments) 
        { 
            if(asArguments) 
            {
                (_pr = new ProcessHandler(ProcessName, ExecName, ProcessFolder, Arguments)).Start();
            } 
            else 
            {
                (_pr = new ProcessHandler(ProcessName, ExecName, ProcessFolder)).Start();
            }
        }

        /// <summary>
        /// All behaviors to Start RedM Properly Asynchronously
        /// </summary>
        /// 
        public static void StartAsync(bool asArguments)
        {
            if (asArguments)
            {
                (_pr = new ProcessHandler(ProcessName, ExecName, ProcessFolder, Arguments)).StartAsync();
            }
            else
            {
                (_pr = new ProcessHandler(ProcessName, ExecName, ProcessFolder)).StartAsync();
            }
        }

        /// <summary>
        /// Wait that RedM is Initialized
        /// </summary>
        public static void WaitRedMInitialized() => _pr?.WaitProcessInitialized();
    }
}
