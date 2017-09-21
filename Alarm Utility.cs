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
    public partial class Alarm_Utility : Form
    {
        Timer t = new Timer();
        public Alarm_Utility()
        {
            InitializeComponent();
        }

        private void btalarm_Click(object sender, EventArgs e)
        {
            AlarmSettingsForm f1 = new AlarmSettingsForm();
            f1.Show();
            this.Hide();
        }

        private void btcountdown_Click(object sender, EventArgs e)
        {
            countdown f2 = new countdown();
            f2.Show();
            this.Hide();

        }

        private void btStopwatch_Click(object sender, EventArgs e)
        {
            StopWatch f3 = new StopWatch();
            f3.Show();
           // this.Hide();
        }

        private void Alarm_Utility_Load(object sender, EventArgs e)
        {
            t.Interval = 1000;
            t.Tick += new EventHandler(t_Tick);
            t.Start();
        }

        private void t_Tick(Object sender, EventArgs e)
        {
            int hr = DateTime.Now.Hour;
            int min = DateTime.Now.Minute;
            int sec = DateTime.Now.Second;

            string time = "";

            if (hr < 10)
            {
                time += "0" + hr;
            }
            else
            {
                time += hr;
            }

            time += ":";

            if (min < 10)
            {
                time += "0" + min;
            }
            else
            {
                time += min;
            }
            time += ":";

            if (sec < 10)
            {
                time += "0" + sec;
            }
            else
            {
                time += sec;
            }

            lbltime.Text = time;
            DateTime thisday = DateTime.Today;
            lbldatetime.Text = thisday.ToString("dd/MM/yyyy");
        }
    }
}
