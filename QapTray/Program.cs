﻿using NLog.LayoutRenderers;
using Qap;
using System;
using System.Windows.Forms;
using QapShared;

namespace QapTray
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            LayoutRenderer.Register<ProcessStartTimeLayoutRenderer>("process_start_time");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TrayForm());
        }
    }
}
