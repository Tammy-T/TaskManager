using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            // 启用高DPI支持
            // 启用高DPI支持
            SetProcessDpiAwareness(ProcessDpiAwareness.PerMonitorV2);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            

            Application.Run(new Form1());
        }

        // 定义 SetProcessDpiAwareness API
        [DllImport("shcore.dll")]
        private static extern int SetProcessDpiAwareness(ProcessDpiAwareness value);

        // 定义 DPI 感知模式
        private enum ProcessDpiAwareness
        {
            DpiUnaware = 0,
            SystemAware = 1,
            PerMonitorAware = 2,
            PerMonitorV2 = 3
        }
    }
}
