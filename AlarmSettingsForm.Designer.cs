namespace AlarmClockSystemTray
{
	partial class AlarmSettingsForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlarmSettingsForm));
            this.AlarmTimer = new System.Windows.Forms.Timer(this.components);
            this.SoundBrowserDialog = new System.Windows.Forms.OpenFileDialog();
            this.AlarmNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.TrayContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EnabledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SoundBrowseButton = new System.Windows.Forms.Button();
            this.SoundFilenameTextBox = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.settingsCancelButton = new System.Windows.Forms.Button();
            this.AlarmDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.settingsOKButton = new System.Windows.Forms.Button();
            this.AlarmEnabledCheckBox = new System.Windows.Forms.CheckBox();
            this.TrayContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // AlarmTimer
            // 
            this.AlarmTimer.Interval = 1000;
            this.AlarmTimer.Tick += new System.EventHandler(this.AlarmTimer_Tick);
            // 
            // SoundBrowserDialog
            // 
            this.SoundBrowserDialog.AddExtension = false;
            this.SoundBrowserDialog.Filter = "MP3 files|*.mp3|WAV files|*.wav";
            this.SoundBrowserDialog.Title = "Please select a sound to play for alarm notification";
            // 
            // AlarmNotifyIcon
            // 
            this.AlarmNotifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.AlarmNotifyIcon.BalloonTipText = "This is your requested alarm!";
            this.AlarmNotifyIcon.BalloonTipTitle = "Alarm";
            this.AlarmNotifyIcon.ContextMenuStrip = this.TrayContextMenuStrip;
            this.AlarmNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("AlarmNotifyIcon.Icon")));
            this.AlarmNotifyIcon.Text = "Alarm Clock";
            this.AlarmNotifyIcon.Visible = true;
            this.AlarmNotifyIcon.BalloonTipClicked += new System.EventHandler(this.AlarmNotifyIcon_BalloonTipClicked);
            this.AlarmNotifyIcon.BalloonTipClosed += new System.EventHandler(this.AlarmNotifyIcon_BalloonTipClicked);
            this.AlarmNotifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AlarmNotifyIcon_MouseClick);
            this.AlarmNotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.AlarmNotifyIcon_MouseDoubleClick);
            // 
            // TrayContextMenuStrip
            // 
            this.TrayContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingsToolStripMenuItem,
            this.EnabledToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.TrayContextMenuStrip.Name = "TrayContextMenuStrip";
            this.TrayContextMenuStrip.Size = new System.Drawing.Size(126, 70);
            // 
            // SettingsToolStripMenuItem
            // 
            this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.SettingsToolStripMenuItem.Text = "Settings...";
            this.SettingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsToolStripMenuItem_Click);
            // 
            // EnabledToolStripMenuItem
            // 
            this.EnabledToolStripMenuItem.Name = "EnabledToolStripMenuItem";
            this.EnabledToolStripMenuItem.ShowShortcutKeys = false;
            this.EnabledToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.EnabledToolStripMenuItem.Text = "Enabled";
            this.EnabledToolStripMenuItem.Click += new System.EventHandler(this.EnabledToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // SoundBrowseButton
            // 
            this.SoundBrowseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoundBrowseButton.Location = new System.Drawing.Point(240, 74);
            this.SoundBrowseButton.Name = "SoundBrowseButton";
            this.SoundBrowseButton.Size = new System.Drawing.Size(37, 23);
            this.SoundBrowseButton.TabIndex = 16;
            this.SoundBrowseButton.Text = "&...";
            this.SoundBrowseButton.Click += new System.EventHandler(this.SoundBrowseButton_Click);
            // 
            // SoundFilenameTextBox
            // 
            this.SoundFilenameTextBox.Location = new System.Drawing.Point(82, 74);
            this.SoundFilenameTextBox.Name = "SoundFilenameTextBox";
            this.SoundFilenameTextBox.Size = new System.Drawing.Size(155, 23);
            this.SoundFilenameTextBox.TabIndex = 15;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Location = new System.Drawing.Point(11, 77);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(75, 17);
            this.Label3.TabIndex = 14;
            this.Label3.Text = "&Sound File";
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Location = new System.Drawing.Point(82, 42);
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(198, 23);
            this.MessageTextBox.TabIndex = 13;
            this.MessageTextBox.Text = "Attention!";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Location = new System.Drawing.Point(11, 45);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(65, 17);
            this.Label2.TabIndex = 12;
            this.Label2.Text = "&Message";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Location = new System.Drawing.Point(11, 15);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(74, 17);
            this.Label1.TabIndex = 10;
            this.Label1.Text = "Alarm &time";
            // 
            // settingsCancelButton
            // 
            this.settingsCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.settingsCancelButton.Location = new System.Drawing.Point(164, 140);
            this.settingsCancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.settingsCancelButton.Name = "settingsCancelButton";
            this.settingsCancelButton.Size = new System.Drawing.Size(100, 28);
            this.settingsCancelButton.TabIndex = 19;
            this.settingsCancelButton.Text = "&Cancel";
            this.settingsCancelButton.Click += new System.EventHandler(this.settingsCancelButton_Click);
            // 
            // AlarmDateTimePicker
            // 
            this.AlarmDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.AlarmDateTimePicker.Location = new System.Drawing.Point(82, 12);
            this.AlarmDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.AlarmDateTimePicker.Name = "AlarmDateTimePicker";
            this.AlarmDateTimePicker.Size = new System.Drawing.Size(111, 23);
            this.AlarmDateTimePicker.TabIndex = 11;
            // 
            // settingsOKButton
            // 
            this.settingsOKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.settingsOKButton.Location = new System.Drawing.Point(24, 140);
            this.settingsOKButton.Margin = new System.Windows.Forms.Padding(4);
            this.settingsOKButton.Name = "settingsOKButton";
            this.settingsOKButton.Size = new System.Drawing.Size(100, 28);
            this.settingsOKButton.TabIndex = 18;
            this.settingsOKButton.Text = "&OK";
            this.settingsOKButton.Click += new System.EventHandler(this.settingsOKButton_Click);
            // 
            // AlarmEnabledCheckBox
            // 
            this.AlarmEnabledCheckBox.AutoSize = true;
            this.AlarmEnabledCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.AlarmEnabledCheckBox.Location = new System.Drawing.Point(13, 112);
            this.AlarmEnabledCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.AlarmEnabledCheckBox.Name = "AlarmEnabledCheckBox";
            this.AlarmEnabledCheckBox.Size = new System.Drawing.Size(118, 21);
            this.AlarmEnabledCheckBox.TabIndex = 17;
            this.AlarmEnabledCheckBox.Text = "Alarm &enabled";
            this.AlarmEnabledCheckBox.UseVisualStyleBackColor = false;
            // 
            // AlarmSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(290, 180);
            this.ControlBox = false;
            this.Controls.Add(this.SoundBrowseButton);
            this.Controls.Add(this.SoundFilenameTextBox);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.settingsCancelButton);
            this.Controls.Add(this.AlarmDateTimePicker);
            this.Controls.Add(this.settingsOKButton);
            this.Controls.Add(this.AlarmEnabledCheckBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AlarmSettingsForm";
            this.Text = "Alarm Settings";
            this.Load += new System.EventHandler(this.AlarmSettingsForm_Load);
            this.TrayContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Timer AlarmTimer;
		private System.Windows.Forms.OpenFileDialog SoundBrowserDialog;
		private System.Windows.Forms.NotifyIcon AlarmNotifyIcon;
		private System.Windows.Forms.ContextMenuStrip TrayContextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem SettingsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem EnabledToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
		private System.Windows.Forms.Button SoundBrowseButton;
		private System.Windows.Forms.TextBox SoundFilenameTextBox;
		private System.Windows.Forms.Label Label3;
		private System.Windows.Forms.TextBox MessageTextBox;
		private System.Windows.Forms.Label Label2;
		private System.Windows.Forms.Label Label1;
		private System.Windows.Forms.Button settingsCancelButton;
		private System.Windows.Forms.DateTimePicker AlarmDateTimePicker;
		private System.Windows.Forms.Button settingsOKButton;
		private System.Windows.Forms.CheckBox AlarmEnabledCheckBox;
	}
}

