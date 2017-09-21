using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AlarmClockSystemTray
{
	public partial class AlarmSettingsForm : Form
	{
		private DateTime alarmTime;
		private bool alarmEnabled;
		private string alarmSound;
		private string alarmMessage;

		private System.Media.SoundPlayer player = new System.Media.SoundPlayer();

		public AlarmSettingsForm()
		{
			InitializeComponent();
		}

		private void AlarmSettingsForm_Load(object sender, EventArgs e)
		{
			alarmEnabled = false;
			AlarmNotifyIcon.Visible = true;

			// Initialize the various values for consistency
			alarmTime = DateTime.Now;
			AlarmDateTimePicker.Value = alarmTime;
			alarmMessage = MessageTextBox.Text;

			// Set the sound dialog to My Music folder
			SoundBrowserDialog.InitialDirectory = Environment.SpecialFolder.MyMusic.ToString();
		}
		
		private void RolloverTime()
		{
			// If the user selects a time already passed, it must be for tomorrow
			if( DateTime.Now.TimeOfDay.CompareTo(alarmTime.TimeOfDay) > 0 )
			{
				alarmTime = new DateTime(DateTime.Now.Year, 
					DateTime.Now.Month, DateTime.Now.Day + 1, 
					alarmTime.Hour, alarmTime.Minute, alarmTime.Second);
			}
			// Otherwise, set it for today
			else
			{
				alarmTime = new DateTime(DateTime.Now.Year, 
					DateTime.Now.Month, DateTime.Now.Day, 
					alarmTime.Hour, alarmTime.Minute, alarmTime.Second);
			}
		}

		private void SoundBrowseButton_Click(object sender, EventArgs e)
		{
			if( SoundBrowserDialog.ShowDialog() == DialogResult.OK )
			{
				alarmSound = SoundBrowserDialog.FileName;
				SoundFilenameTextBox.Text = alarmSound;
			}
		}

		private void settingsOKButton_Click(object sender, EventArgs e)
		{
			this.Hide();

			alarmSound = SoundFilenameTextBox.Text;
			if (alarmSound.Length > 0)
			{
				player.SoundLocation = alarmSound;
				player.Load();
			}
			
			alarmMessage = MessageTextBox.Text;

			alarmEnabled = AlarmEnabledCheckBox.Checked;
			EnabledToolStripMenuItem.Checked = alarmEnabled;

			if( alarmEnabled )
			{
				alarmTime = AlarmDateTimePicker.Value;
				RolloverTime();
			}

			AlarmTimer.Enabled = alarmEnabled;
		}

		private void settingsCancelButton_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			TrayContextMenuStrip.Hide();
			this.Show();
		}

		private void EnabledToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Toggle the checkbox on the menu item
			alarmEnabled = ! EnabledToolStripMenuItem.Checked;
			EnabledToolStripMenuItem.Checked = alarmEnabled;
			AlarmEnabledCheckBox.Checked = alarmEnabled;

			// Set the time for the current or next day accordingly
			RolloverTime();

			// Activate/deactive the timer
			AlarmTimer.Enabled = alarmEnabled;

			TrayContextMenuStrip.Hide();
		}

		private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AlarmNotifyIcon.Visible = false;
			Application.Exit();
		}

		private void AlarmNotifyIcon_BalloonTipClicked(object sender, EventArgs e)
		{
			// When the user stops the alarm...
			player.Stop();
			RolloverTime();
		}

		private void AlarmNotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			this.Show();
		}

		private void AlarmNotifyIcon_MouseClick(object sender, MouseEventArgs e)
		{
			if( e.Button == MouseButtons.Right )
			{
	            TrayContextMenuStrip.Show();
		    }
		}

		private void AlarmTimer_Tick(object sender, EventArgs e)
		{
			if( DateTime.Now.CompareTo(alarmTime) >= 0 )
			{
				// Add a day to the alarm to reset it for the next day
				RolloverTime();

				// Show the notification for up to a minute.
				// After that, no one must be paying attention!
				AlarmNotifyIcon.BalloonTipText = 
					(alarmMessage.Length > 0?alarmMessage:"Attention!");
				AlarmNotifyIcon.ShowBalloonTip(60000);

				// Play the alarm sound
				if( alarmSound.Length > 0 )
				{
					player.PlayLooping();
				}
			}
		}

	}
}