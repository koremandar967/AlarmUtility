namespace AlarmClockSystemTray
{
    partial class StopWatch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StopWatch));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbltimer = new System.Windows.Forms.Label();
            this.btstart = new System.Windows.Forms.Button();
            this.btstop = new System.Windows.Forms.Button();
            this.btreset = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lbltimer);
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lbltimer
            // 
            this.lbltimer.AutoSize = true;
            this.lbltimer.BackColor = System.Drawing.Color.Transparent;
            this.lbltimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltimer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbltimer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbltimer.Location = new System.Drawing.Point(6, 35);
            this.lbltimer.Name = "lbltimer";
            this.lbltimer.Size = new System.Drawing.Size(232, 33);
            this.lbltimer.TabIndex = 0;
            this.lbltimer.Text = "00 : 00 : 00 : 00";
            // 
            // btstart
            // 
            this.btstart.AutoSize = true;
            this.btstart.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btstart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btstart.Location = new System.Drawing.Point(12, 154);
            this.btstart.Name = "btstart";
            this.btstart.Size = new System.Drawing.Size(75, 42);
            this.btstart.TabIndex = 1;
            this.btstart.Text = "START";
            this.btstart.UseVisualStyleBackColor = false;
            this.btstart.Click += new System.EventHandler(this.btstart_Click);
            // 
            // btstop
            // 
            this.btstop.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btstop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btstop.Location = new System.Drawing.Point(105, 154);
            this.btstop.Name = "btstop";
            this.btstop.Size = new System.Drawing.Size(75, 42);
            this.btstop.TabIndex = 2;
            this.btstop.Text = "STOP";
            this.btstop.UseVisualStyleBackColor = false;
            this.btstop.Click += new System.EventHandler(this.btstop_Click);
            // 
            // btreset
            // 
            this.btreset.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btreset.Location = new System.Drawing.Point(197, 154);
            this.btreset.Name = "btreset";
            this.btreset.Size = new System.Drawing.Size(75, 42);
            this.btreset.TabIndex = 3;
            this.btreset.Text = "RESET";
            this.btreset.UseVisualStyleBackColor = false;
            this.btreset.Click += new System.EventHandler(this.btreset_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // StopWatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(284, 220);
            this.Controls.Add(this.btreset);
            this.Controls.Add(this.btstop);
            this.Controls.Add(this.btstart);
            this.Controls.Add(this.groupBox1);
            this.Name = "StopWatch";
            this.Text = "StopWatch";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btstart;
        private System.Windows.Forms.Button btstop;
        private System.Windows.Forms.Button btreset;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbltimer;
    }
}