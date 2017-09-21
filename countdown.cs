using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AlarmClockSystemTray
{
    public partial class countdown : Form
    {
        public int seconds; 
        public int minutes; 
        public int hours;   
        public bool paused; 
        [DllImport("user32")]
        public static extern void LockWorkStation();

        
        public countdown()
        {
            InitializeComponent();
        }

        

        private void btstart_Click(object sender, EventArgs e)
        {
            if (paused != true)
            {
                if ((tbhrs.Text != string.Empty) && (tbmin.Text != string.Empty) && (tbsec.Text != string.Empty))
                {
                    timer1.Enabled = true;
                    btpause.Enabled = true;
                    btstart.Enabled = false;
                    btstop.Enabled = true;
                    tbhrs.Enabled = false;
                    tbmin.Enabled = false;
                    tbsec.Enabled = false;
                    tbmsg.Enabled = false;

                    try
                    {
                        minutes = System.Convert.ToInt32(tbmin.Text);
                        seconds = System.Convert.ToInt32(tbsec.Text);
                        hours = System.Convert.ToInt32(tbhrs.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Incomplete settings!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                timer1.Enabled = true;
                paused = false;
                btstart.Enabled = false;
                btpause.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if ((minutes == 0) && (hours == 0) && (seconds == 0))
            {

                timer1.Enabled = false;
                Console.Beep();
                MessageBox.Show(tbmsg.Text, "Warnning");
                btpause.Enabled = false;
                btstop.Enabled = false;
                btstart.Enabled = true;
                tbmsg.Clear();
                tbhrs.Text = Convert.ToString(0);
                tbmin.Text = Convert.ToString(0);
                tbsec.Text = Convert.ToString(0);
                LockWorkStation();
                tbhrs.Enabled = true;
                tbmsg.Enabled = true;
                tbsec.Enabled = true;
                tbmin.Enabled = true;
                tbhrs.Enabled = true;
                lblHr.Text = "00";
                lblMin.Text = "00";
                lblSec.Text = "00";
            }
            else
            {
                
                if (seconds < 1)
                {
                    seconds = 59;
                    if (minutes == 0)
                    {
                        minutes = 59;
                        if (hours != 0)
                            hours -= 1;

                    }
                    else
                    {
                        minutes -= 1;
                    }
                }
                else
                    seconds -= 1;
                
                lblHr.Text = hours.ToString();
                lblMin.Text = minutes.ToString();
                lblSec.Text = seconds.ToString();
            }
            if ((minutes == 5) && (hours == 0) && (seconds == 0))
            {
                
                MessageBox.Show("Five minutes left.\n Please make sure that you save your work so that you won't  loss it. ", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            if ((minutes == 10) && (hours == 0) && (seconds == 0))
            {
                
                MessageBox.Show("Ten minutes left.\n Please make sure that you save your work so that you won't  loss it. ", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btpause_Click(object sender, EventArgs e)
        {
           
            if (MessageBox.Show("Are you sure you want to pause the time?\n Be are ware that if you click Yes the computer will be locked.\n I advice you to click No if you not sure what you are doing.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                timer1.Enabled = false;
                paused = true;
                btpause.Enabled = false;
                btstart.Enabled = true;
                LockWorkStation();
            }
        }

        private void btstop_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to stop the time?\n Be are ware that if you click Yes the computer will be locked.\n I advice you to click No if you not sure what you are doing.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                
                paused = false;
                timer1.Enabled = false;
                btpause.Enabled = false;
                btstop.Enabled = false;
                btstart.Enabled = true;
                tbmsg.Clear();
                tbhrs.Text = Convert.ToString(0);
                tbmin.Text = Convert.ToString(0);
                tbsec.Text = Convert.ToString(0);
                tbhrs.Enabled = true;
                tbmin.Enabled = true;
                tbsec.Enabled = true;
                tbmin.Enabled = true;
                tbhrs.Enabled = true;
                lblHr.Text = "00";
                lblMin.Text = "00";
                lblSec.Text = "00";
                LockWorkStation();
            }
        }

        private void countdown_Load(object sender, EventArgs e)
        {
            tbhrs.Focus();
            tbhrs.Text = Convert.ToString(0);
            tbmin.Text = Convert.ToString(0);
            tbsec.Text = Convert.ToString(0);
            
        }
    }
}
