using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using InputManager;

namespace runDayZ
{
    public partial class Form1 : Form
    {
        public bool is64 = false;

        run running = new run();
        config cfg = new config();

        int delay = 7;

        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);
        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        const int MOD_CONTROL = 0x0002;
        const int MOD_SHIFT = 0x0004;
        const int WM_HOTKEY = 0x0312;

        int rkey;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //SET HOTKEYS
            KeyboardHook.KeyDown += new KeyboardHook.KeyDownEventHandler(KeyboardHook_KeyDown);
            KeyboardHook.KeyUp += new KeyboardHook.KeyUpEventHandler(KeyboardHook_KeyUp);
            KeyboardHook.InstallHook();

            //CFG
            cfg.doData();
            rkey = cfg.getHotkey();
            running.dell = cfg.getDelay();

            //SET LABEL HOTKEY
            KeysConverter hk = new KeysConverter();
            labelHotkey.Text = "Hotkey : " + hk.ConvertToString(rkey);

            //SET LABEL DELAY
            labelDelay.Text = "Delay : " + running.dell.ToString() + "ms";
           

            running.setStatus(statusLabel, false);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnregisterHotKey(this.Handle, 1);
        }

        void KeyboardHook_KeyUp(int vkCode)
        {
            if(vkCode == rkey)
            {
                
            }
        }

        void KeyboardHook_KeyDown(int vkCode)
        {
            if (vkCode == rkey)
            {

                if (checkisActive.Checked)
                {
                    if (running.isRunning)
                    {
                        running.setStatus(statusLabel, false);
                    }
                    else
                    {
                        running.setStatus(statusLabel, true, delay);
                    }
                }
            }
        }

        private void checkisActive_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
