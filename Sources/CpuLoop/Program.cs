﻿using System;
using System.Windows.Forms;

namespace CpuLoop {

    internal static class Program {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            new FormSystray();
            Application.Run();
        }
    }
}