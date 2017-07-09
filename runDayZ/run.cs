using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;
using System.Diagnostics;
using System.Runtime.InteropServices;
using InputManager;

namespace runDayZ
{
    class run
    {
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        string procName = "DayZ";
        string procName64 = "DayZ_x64";

        Process[] procs;
        Process[] procs64;

        public bool isRunning;
        public int dell;
        Thread runT;

        private void rThread()
        {
            RunManager(dell);
        }

        public void RunManager(int _del)
        {
            procs = Process.GetProcessesByName(procName);
            procs64 = Process.GetProcessesByName(procName64);

            if (procs != null)
            {
                foreach (Process c in procs)
                {
                    SetForegroundWindow(c.MainWindowHandle);
                }
            }

            if (procs != null)
            {
                foreach (Process c in procs64)
                {
                    SetForegroundWindow(c.MainWindowHandle);
                }
            }

            while (isRunning)
            {
                doRun();
            }
        }

        private void doRun()
        {
            Keyboard.KeyDown(Keys.W);
            Keyboard.KeyDown(Keys.ShiftKey);
            Thread.Sleep(dell);
            Keyboard.KeyUp(Keys.W);
            Keyboard.KeyUp(Keys.ShiftKey);
        }

        public void setStatus(Label ll, bool status, int _del = 16)
        {
            dell = _del;

            if (status)
            {
                isRunning = true;
                ll.Text = "Active";
                ll.ForeColor = Color.Green;
                runT = new Thread(rThread);
                runT.Start();
            }
            else
            {
                isRunning = false;
                ll.Text = "Inactive";
                ll.ForeColor = Color.Red;
            }
        }
    }
}
