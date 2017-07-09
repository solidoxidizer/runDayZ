using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace runDayZ
{
    class config
    {
        //CONFIG DATA
        public int hotkey = 0x52;
        public int delay = 100;

        string path = AppDomain.CurrentDomain.BaseDirectory + @"\config.txt";

        public void doData()
        {
            if (File.Exists(path))
            {
                var dic = File.ReadAllLines(path);

                string hk = dic.ElementAtOrDefault(0).ToString();
                string dl = dic.ElementAtOrDefault(1).ToString();

                String[] hkS = hk.Split('=');
                String[] dlS = dl.Split('=');

                hk = hkS[1];
                dl = dlS[1];

                Debug.WriteLine(hk.ToString());
                Debug.WriteLine(dl.ToString());

                if (hk != null)
                {
                    try
                    {
                        hotkey = Convert.ToInt32(hk, 16);
                    }catch (Exception e)
                    {
                        MessageBox.Show("Wrong Hotkey format. Use Hexadecimal Number. Now using standard settings");
                    }
            }

                if (dl != null)
                {
                    try
                    {
                        delay = Int32.Parse(dl);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Wrong Delay format. Use an whole number. Now using standard settings");
                    }
                }
            }
        }

        public int getHotkey()
        {
            return hotkey;
        }

        public int getDelay()
        {
            return delay;
        }
    }
}
