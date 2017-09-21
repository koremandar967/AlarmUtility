using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AlarmClockSystemTray
{
    public partial class StopWatch : Form
    {
        public StopWatch()
        {
            InitializeComponent();
        }

        int hour, min, sec, ms = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltimer.Text = " "+hour + "  :  " + min + "  :  " + sec + "  :  " + ms.ToString();
            ms++;
            if (ms > 10)
            {
                sec++;
                ms = 00;
            }
            else
            {
                ms++;
            }

            if (sec > 60)
            {
                min++;
                sec = 00;
            }

            if (min > 60)
            {
                hour++;
                min = 00;
            }
        }

        private void btstart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btstop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void btreset_Click(object sender, EventArgs e)
        {
            ms = 00;
            sec = 00;
            min =00;
            hour = 00;
            lbltimer.Text = " "+00 + "  :  " + 00 + "  :  " + 00 + "  :  " + 00.ToString();
        }


    }
}
