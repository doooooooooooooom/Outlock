using System;
using System.Diagnostics;
using System.Management;
using System.Windows.Forms;

namespace Outlock
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Thread t = new Thread(KillOutlookLoop);
            t.IsBackground = true;
            t.Start();

            Application.Run(); // keep alive
        }

        static void KillOutlookLoop()
        {
            while (true)
            {
                try
                {
                    var procs = Process.GetProcessesByName("OUTLOOK");
                    foreach (var p in procs)
                    {
                        p.Kill();
                    }
                }
                catch { }

                Thread.Sleep(500); // 🔥 ปรับความเร็วได้ (ms)
            }
        }
    }
}