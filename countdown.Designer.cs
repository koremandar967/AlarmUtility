namespace AlarmClockSystemTray
{
    partial class countdown
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(countdown));
            this.gbactivity = new System.Windows.Forms.GroupBox();
            this.tbsec = new System.Windows.Forms.TextBox();
            this.tbmin = new System.Windows.Forms.TextBox();
            this.tbmsg = new System.Windows.Forms.TextBox();
            this.lbsec = new System.Windows.Forms.Label();
            this.tbhrs = new System.Windows.Forms.TextBox();
            this.lbmin = new System.Windows.Forms.Label();
            this.lbmessage = new System.Windows.Forms.Label();
            this.lbhrs = new System.Windows.Forms.Label();
            this.lbsettime = new System.Windows.Forms.Label();
            this.btstart = new System.Windows.Forms.Button();
            this.btpause = new System.Windows.Forms.Button();
            this.btstop = new System.Windows.Forms.Button();
            this.gbbuttons = new System.Windows.Forms.GroupBox();
            this.gbtime = new System.Windows.Forms.GroupBox();
            this.lblSec = new System.Windows.Forms.Label();
            this.lbcolon2 = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lbcolon1 = new System.Windows.Forms.Label();
            this.lblHr = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gbactivity.SuspendLayout();
            this.gbbuttons.SuspendLayout();
            this.gbtime.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbactivity
            // 
            this.gbactivity.BackColor = System.Drawing.Color.Transparent;
            this.gbactivity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gbactivity.Controls.Add(this.tbsec);
            this.gbactivity.Controls.Add(this.tbmin);
            this.gbactivity.Controls.Add(this.tbmsg);
            this.gbactivity.Controls.Add(this.lbsec);
            this.gbactivity.Controls.Add(this.tbhrs);
            this.gbactivity.Controls.Add(this.lbmin);
            this.gbactivity.Controls.Add(this.lbmessage);
            this.gbactivity.Controls.Add(this.lbhrs);
            this.gbactivity.Controls.Add(this.lbsettime);
            this.gbactivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbactivity.Location = new System.Drawing.Point(12, 23);
            this.gbactivity.Name = "gbactivity";
            this.gbactivity.Size = new System.Drawing.Size(200, 100);
            this.gbactivity.TabIndex = 0;
            this.gbactivity.TabStop = false;
            this.gbactivity.Text = "Activity";
            // 
            // tbsec
            // 
            this.tbsec.Location = new System.Drawing.Point(148, 24);
            this.tbsec.Name = "tbsec";
            this.tbsec.Size = new System.Drawing.Size(27, 20);
            this.tbsec.TabIndex = 4;
            // 
            // tbmin
            // 
            this.tbmin.Location = new System.Drawing.Point(113, 24);
            this.tbmin.Name = "tbmin";
            this.tbmin.Size = new System.Drawing.Size(27, 20);
            this.tbmin.TabIndex = 4;
            // 
            // tbmsg
            // 
            this.tbmsg.Location = new System.Drawing.Point(81, 69);
            this.tbmsg.Name = "tbmsg";
            this.tbmsg.Size = new System.Drawing.Size(109, 20);
            this.tbmsg.TabIndex = 2;
            // 
            // lbsec
            // 
            this.lbsec.AutoSize = true;
            this.lbsec.BackColor = System.Drawing.Color.Transparent;
            this.lbsec.Location = new System.Drawing.Point(145, 46);
            this.lbsec.Name = "lbsec";
            this.lbsec.Size = new System.Drawing.Size(29, 13);
            this.lbsec.TabIndex = 6;
            this.lbsec.Text = "Sec";
            // 
            // tbhrs
            // 
            this.tbhrs.Location = new System.Drawing.Point(80, 24);
            this.tbhrs.Name = "tbhrs";
            this.tbhrs.Size = new System.Drawing.Size(27, 20);
            this.tbhrs.TabIndex = 3;
            // 
            // lbmin
            // 
            this.lbmin.AutoSize = true;
            this.lbmin.BackColor = System.Drawing.Color.Transparent;
            this.lbmin.Location = new System.Drawing.Point(113, 46);
            this.lbmin.Name = "lbmin";
            this.lbmin.Size = new System.Drawing.Size(27, 13);
            this.lbmin.TabIndex = 5;
            this.lbmin.Text = "Min";
            // 
            // lbmessage
            // 
            this.lbmessage.AutoSize = true;
            this.lbmessage.BackColor = System.Drawing.Color.Transparent;
            this.lbmessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmessage.Location = new System.Drawing.Point(6, 72);
            this.lbmessage.Name = "lbmessage";
            this.lbmessage.Size = new System.Drawing.Size(65, 13);
            this.lbmessage.TabIndex = 4;
            this.lbmessage.Text = "Message :";
            // 
            // lbhrs
            // 
            this.lbhrs.AutoSize = true;
            this.lbhrs.BackColor = System.Drawing.Color.Transparent;
            this.lbhrs.Location = new System.Drawing.Point(81, 46);
            this.lbhrs.Name = "lbhrs";
            this.lbhrs.Size = new System.Drawing.Size(26, 13);
            this.lbhrs.TabIndex = 3;
            this.lbhrs.Text = "Hrs";
            // 
            // lbsettime
            // 
            this.lbsettime.AutoSize = true;
            this.lbsettime.BackColor = System.Drawing.Color.Transparent;
            this.lbsettime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsettime.Location = new System.Drawing.Point(6, 24);
            this.lbsettime.Name = "lbsettime";
            this.lbsettime.Size = new System.Drawing.Size(65, 13);
            this.lbsettime.TabIndex = 2;
            this.lbsettime.Text = "Set Time :";
            // 
            // btstart
            // 
            this.btstart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btstart.Location = new System.Drawing.Point(7, 20);
            this.btstart.Name = "btstart";
            this.btstart.Size = new System.Drawing.Size(75, 20);
            this.btstart.TabIndex = 0;
            this.btstart.Text = "START";
            this.btstart.UseVisualStyleBackColor = true;
            this.btstart.Click += new System.EventHandler(this.btstart_Click);
            // 
            // btpause
            // 
            this.btpause.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btpause.Location = new System.Drawing.Point(7, 46);
            this.btpause.Name = "btpause";
            this.btpause.Size = new System.Drawing.Size(75, 20);
            this.btpause.TabIndex = 1;
            this.btpause.Text = "PAUSE";
            this.btpause.UseVisualStyleBackColor = true;
            this.btpause.Click += new System.EventHandler(this.btpause_Click);
            // 
            // btstop
            // 
            this.btstop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btstop.Location = new System.Drawing.Point(7, 72);
            this.btstop.Name = "btstop";
            this.btstop.Size = new System.Drawing.Size(75, 20);
            this.btstop.TabIndex = 2;
            this.btstop.Text = "STOP";
            this.btstop.UseVisualStyleBackColor = true;
            this.btstop.Click += new System.EventHandler(this.btstop_Click);
            // 
            // gbbuttons
            // 
            this.gbbuttons.BackColor = System.Drawing.Color.Transparent;
            this.gbbuttons.Controls.Add(this.btstop);
            this.gbbuttons.Controls.Add(this.btpause);
            this.gbbuttons.Controls.Add(this.btstart);
            this.gbbuttons.Location = new System.Drawing.Point(227, 23);
            this.gbbuttons.Name = "gbbuttons";
            this.gbbuttons.Size = new System.Drawing.Size(97, 100);
            this.gbbuttons.TabIndex = 1;
            this.gbbuttons.TabStop = false;
            // 
            // gbtime
            // 
            this.gbtime.BackColor = System.Drawing.Color.Transparent;
            this.gbtime.Controls.Add(this.lblSec);
            this.gbtime.Controls.Add(this.lbcolon2);
            this.gbtime.Controls.Add(this.lblMin);
            this.gbtime.Controls.Add(this.lbcolon1);
            this.gbtime.Controls.Add(this.lblHr);
            this.gbtime.Location = new System.Drawing.Point(23, 151);
            this.gbtime.Name = "gbtime";
            this.gbtime.Size = new System.Drawing.Size(286, 98);
            this.gbtime.TabIndex = 2;
            this.gbtime.TabStop = false;
            // 
            // lblSec
            // 
            this.lblSec.AutoSize = true;
            this.lblSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSec.Location = new System.Drawing.Point(212, 34);
            this.lblSec.Name = "lblSec";
            this.lblSec.Size = new System.Drawing.Size(49, 33);
            this.lblSec.TabIndex = 4;
            this.lblSec.Text = "00";
            // 
            // lbcolon2
            // 
            this.lbcolon2.AutoSize = true;
            this.lbcolon2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcolon2.Location = new System.Drawing.Point(182, 34);
            this.lbcolon2.Name = "lbcolon2";
            this.lbcolon2.Size = new System.Drawing.Size(24, 33);
            this.lbcolon2.TabIndex = 3;
            this.lbcolon2.Text = ":";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.Location = new System.Drawing.Point(117, 34);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(49, 33);
            this.lblMin.TabIndex = 2;
            this.lblMin.Text = "00";
            // 
            // lbcolon1
            // 
            this.lbcolon1.AutoSize = true;
            this.lbcolon1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcolon1.Location = new System.Drawing.Point(67, 34);
            this.lbcolon1.Name = "lbcolon1";
            this.lbcolon1.Size = new System.Drawing.Size(24, 33);
            this.lbcolon1.TabIndex = 1;
            this.lbcolon1.Text = ":";
            // 
            // lblHr
            // 
            this.lblHr.AutoSize = true;
            this.lblHr.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHr.Location = new System.Drawing.Point(12, 33);
            this.lblHr.Name = "lblHr";
            this.lblHr.Size = new System.Drawing.Size(49, 33);
            this.lblHr.TabIndex = 0;
            this.lblHr.Text = "00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // countdown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(335, 261);
            this.Controls.Add(this.gbtime);
            this.Controls.Add(this.gbbuttons);
            this.Controls.Add(this.gbactivity);
            this.Name = "countdown";
            this.Text = "countdown";
            this.Load += new System.EventHandler(this.countdown_Load);
            this.gbactivity.ResumeLayout(false);
            this.gbactivity.PerformLayout();
            this.gbbuttons.ResumeLayout(false);
            this.gbtime.ResumeLayout(false);
            this.gbtime.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbactivity;
        private System.Windows.Forms.TextBox tbsec;
        private System.Windows.Forms.TextBox tbmin;
        private System.Windows.Forms.TextBox tbmsg;
        private System.Windows.Forms.Label lbsec;
        private System.Windows.Forms.TextBox tbhrs;
        private System.Windows.Forms.Label lbmin;
        private System.Windows.Forms.Label lbmessage;
        private System.Windows.Forms.Label lbhrs;
        private System.Windows.Forms.Label lbsettime;
        private System.Windows.Forms.Button btstart;
        private System.Windows.Forms.Button btpause;
        private System.Windows.Forms.Button btstop;
        private System.Windows.Forms.GroupBox gbbuttons;
        private System.Windows.Forms.GroupBox gbtime;
        private System.Windows.Forms.Label lblSec;
        private System.Windows.Forms.Label lbcolon2;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lbcolon1;
        private System.Windows.Forms.Label lblHr;
        private System.Windows.Forms.Timer timer1;
    }
}