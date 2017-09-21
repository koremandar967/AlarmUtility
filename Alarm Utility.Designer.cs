namespace AlarmClockSystemTray
{
    partial class Alarm_Utility
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alarm_Utility));
            this.btalarm = new System.Windows.Forms.Button();
            this.btcountdown = new System.Windows.Forms.Button();
            this.btStopwatch = new System.Windows.Forms.Button();
            this.lbltime = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbldatetime = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btalarm
            // 
            this.btalarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btalarm.Location = new System.Drawing.Point(218, 13);
            this.btalarm.Name = "btalarm";
            this.btalarm.Size = new System.Drawing.Size(131, 32);
            this.btalarm.TabIndex = 0;
            this.btalarm.Text = "ALARM";
            this.btalarm.UseVisualStyleBackColor = true;
            this.btalarm.Click += new System.EventHandler(this.btalarm_Click);
            // 
            // btcountdown
            // 
            this.btcountdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcountdown.Location = new System.Drawing.Point(218, 51);
            this.btcountdown.Name = "btcountdown";
            this.btcountdown.Size = new System.Drawing.Size(131, 39);
            this.btcountdown.TabIndex = 1;
            this.btcountdown.Text = "COUNTDOWN TIMER";
            this.btcountdown.UseVisualStyleBackColor = true;
            this.btcountdown.Click += new System.EventHandler(this.btcountdown_Click);
            // 
            // btStopwatch
            // 
            this.btStopwatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStopwatch.Location = new System.Drawing.Point(218, 96);
            this.btStopwatch.Name = "btStopwatch";
            this.btStopwatch.Size = new System.Drawing.Size(131, 36);
            this.btStopwatch.TabIndex = 2;
            this.btStopwatch.Text = "STOPWATCH";
            this.btStopwatch.UseVisualStyleBackColor = true;
            this.btStopwatch.Click += new System.EventHandler(this.btStopwatch_Click);
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.BackColor = System.Drawing.Color.Transparent;
            this.lbltime.Font = new System.Drawing.Font("Arial Narrow", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbltime.Location = new System.Drawing.Point(19, 49);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(141, 43);
            this.lbltime.TabIndex = 3;
            this.lbltime.Text = "00:00:00";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.lbldatetime);
            this.groupBox1.Controls.Add(this.lbltime);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 129);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CLOCK";
            // 
            // lbldatetime
            // 
            this.lbldatetime.AutoSize = true;
            this.lbldatetime.BackColor = System.Drawing.Color.Transparent;
            this.lbldatetime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldatetime.Location = new System.Drawing.Point(108, 107);
            this.lbldatetime.Name = "lbldatetime";
            this.lbldatetime.Size = new System.Drawing.Size(13, 20);
            this.lbldatetime.TabIndex = 4;
            this.lbldatetime.Text = ".";
            // 
            // Alarm_Utility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(376, 153);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btStopwatch);
            this.Controls.Add(this.btcountdown);
            this.Controls.Add(this.btalarm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Alarm_Utility";
            this.Text = "Alarm_Utility";
            this.Load += new System.EventHandler(this.Alarm_Utility_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btalarm;
        private System.Windows.Forms.Button btcountdown;
        private System.Windows.Forms.Button btStopwatch;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbldatetime;
    }
}