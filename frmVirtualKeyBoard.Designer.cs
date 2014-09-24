namespace VMMK
{
	partial class frmVirtualKeyBoard
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVirtualKeyBoard));
			this.btnClose = new System.Windows.Forms.Button();
			this.btnPrevious = new System.Windows.Forms.Button();
			this.btnPlay = new System.Windows.Forms.Button();
			this.btnStop = new System.Windows.Forms.Button();
			this.btnNext = new System.Windows.Forms.Button();
			this.btnMute = new System.Windows.Forms.Button();
			this.tmrMousePosition = new System.Windows.Forms.Timer(this.components);
			this.btnVolumeUp = new System.Windows.Forms.Button();
			this.btnVolumeDown = new System.Windows.Forms.Button();
			this.niTray = new System.Windows.Forms.NotifyIcon(this.components);
			this.cmsTrayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmiShow = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
			this.cmsTrayMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.Black;
			this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
			this.btnClose.FlatAppearance.BorderSize = 2;
			this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.ForeColor = System.Drawing.Color.White;
			this.btnClose.Location = new System.Drawing.Point(5, 12);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(31, 32);
			this.btnClose.TabIndex = 0;
			this.btnClose.Text = "7";
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnPrevious
			// 
			this.btnPrevious.BackColor = System.Drawing.Color.Black;
			this.btnPrevious.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
			this.btnPrevious.FlatAppearance.BorderSize = 2;
			this.btnPrevious.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
			this.btnPrevious.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
			this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPrevious.ForeColor = System.Drawing.Color.White;
			this.btnPrevious.Location = new System.Drawing.Point(5, 50);
			this.btnPrevious.Name = "btnPrevious";
			this.btnPrevious.Size = new System.Drawing.Size(51, 38);
			this.btnPrevious.TabIndex = 2;
			this.btnPrevious.Text = "Pre&v (<- 4)";
			this.btnPrevious.UseVisualStyleBackColor = false;
			this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
			// 
			// btnPlay
			// 
			this.btnPlay.BackColor = System.Drawing.Color.Black;
			this.btnPlay.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
			this.btnPlay.FlatAppearance.BorderSize = 2;
			this.btnPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
			this.btnPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
			this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPlay.ForeColor = System.Drawing.Color.White;
			this.btnPlay.Location = new System.Drawing.Point(60, 50);
			this.btnPlay.Name = "btnPlay";
			this.btnPlay.Size = new System.Drawing.Size(74, 38);
			this.btnPlay.TabIndex = 3;
			this.btnPlay.Text = "&Play/Pause (5)";
			this.btnPlay.UseVisualStyleBackColor = false;
			this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
			// 
			// btnStop
			// 
			this.btnStop.BackColor = System.Drawing.Color.Black;
			this.btnStop.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
			this.btnStop.FlatAppearance.BorderSize = 2;
			this.btnStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
			this.btnStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
			this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStop.ForeColor = System.Drawing.Color.White;
			this.btnStop.Location = new System.Drawing.Point(138, 94);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(50, 38);
			this.btnStop.TabIndex = 6;
			this.btnStop.Text = "&Stop (3)";
			this.btnStop.UseVisualStyleBackColor = false;
			this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
			// 
			// btnNext
			// 
			this.btnNext.BackColor = System.Drawing.Color.Black;
			this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
			this.btnNext.FlatAppearance.BorderSize = 2;
			this.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
			this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
			this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNext.ForeColor = System.Drawing.Color.White;
			this.btnNext.Location = new System.Drawing.Point(138, 50);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(50, 38);
			this.btnNext.TabIndex = 4;
			this.btnNext.Text = "&Next (6 ->)";
			this.btnNext.UseVisualStyleBackColor = false;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// btnMute
			// 
			this.btnMute.BackColor = System.Drawing.Color.Black;
			this.btnMute.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
			this.btnMute.FlatAppearance.BorderSize = 2;
			this.btnMute.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
			this.btnMute.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
			this.btnMute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMute.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMute.ForeColor = System.Drawing.Color.White;
			this.btnMute.Location = new System.Drawing.Point(5, 95);
			this.btnMute.Name = "btnMute";
			this.btnMute.Size = new System.Drawing.Size(51, 38);
			this.btnMute.TabIndex = 7;
			this.btnMute.Text = "&Mute (1)";
			this.btnMute.UseVisualStyleBackColor = false;
			this.btnMute.Click += new System.EventHandler(this.btnMute_Click);
			// 
			// tmrMousePosition
			// 
			this.tmrMousePosition.Tick += new System.EventHandler(this.tmrMousePosition_Tick);
			// 
			// btnVolumeUp
			// 
			this.btnVolumeUp.BackColor = System.Drawing.Color.Black;
			this.btnVolumeUp.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
			this.btnVolumeUp.FlatAppearance.BorderSize = 2;
			this.btnVolumeUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
			this.btnVolumeUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
			this.btnVolumeUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnVolumeUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVolumeUp.ForeColor = System.Drawing.Color.White;
			this.btnVolumeUp.Location = new System.Drawing.Point(60, 12);
			this.btnVolumeUp.Name = "btnVolumeUp";
			this.btnVolumeUp.Size = new System.Drawing.Size(74, 38);
			this.btnVolumeUp.TabIndex = 1;
			this.btnVolumeUp.Text = "Volume Up (/\\ 8)";
			this.btnVolumeUp.UseVisualStyleBackColor = false;
			this.btnVolumeUp.Click += new System.EventHandler(this.btnVolumeUp_Click);
			// 
			// btnVolumeDown
			// 
			this.btnVolumeDown.BackColor = System.Drawing.Color.Black;
			this.btnVolumeDown.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
			this.btnVolumeDown.FlatAppearance.BorderSize = 2;
			this.btnVolumeDown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
			this.btnVolumeDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
			this.btnVolumeDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnVolumeDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVolumeDown.ForeColor = System.Drawing.Color.White;
			this.btnVolumeDown.Location = new System.Drawing.Point(60, 94);
			this.btnVolumeDown.Name = "btnVolumeDown";
			this.btnVolumeDown.Size = new System.Drawing.Size(74, 38);
			this.btnVolumeDown.TabIndex = 5;
			this.btnVolumeDown.Text = "Vol Down (\\/ 2)";
			this.btnVolumeDown.UseVisualStyleBackColor = false;
			this.btnVolumeDown.Click += new System.EventHandler(this.btnVolumeDown_Click);
			// 
			// niTray
			// 
			this.niTray.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.niTray.BalloonTipText = "Press WIN+Num Pad 5 to activate";
			this.niTray.BalloonTipTitle = "Virtual Multimedia Keys";
			this.niTray.ContextMenuStrip = this.cmsTrayMenu;
			this.niTray.Icon = ((System.Drawing.Icon)(resources.GetObject("niTray.Icon")));
			this.niTray.Text = "Virtual Multimedia Keys";
			this.niTray.Visible = true;
			this.niTray.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.niTray_MouseDoubleClick);
			// 
			// cmsTrayMenu
			// 
			this.cmsTrayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiShow,
            this.tsmiExit});
			this.cmsTrayMenu.Name = "cmsTrayMenu";
			this.cmsTrayMenu.Size = new System.Drawing.Size(153, 70);
			// 
			// tsmiShow
			// 
			this.tsmiShow.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.tsmiShow.Name = "tsmiShow";
			this.tsmiShow.Size = new System.Drawing.Size(152, 22);
			this.tsmiShow.Text = "&Show";
			this.tsmiShow.Click += new System.EventHandler(this.tsmiShow_Click);
			// 
			// tsmiExit
			// 
			this.tsmiExit.Name = "tsmiExit";
			this.tsmiExit.Size = new System.Drawing.Size(152, 22);
			this.tsmiExit.Text = "E&xit";
			this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
			// 
			// frmVirtualKeyBoard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.ClientSize = new System.Drawing.Size(197, 145);
			this.Controls.Add(this.btnNext);
			this.Controls.Add(this.btnMute);
			this.Controls.Add(this.btnStop);
			this.Controls.Add(this.btnPlay);
			this.Controls.Add(this.btnPrevious);
			this.Controls.Add(this.btnVolumeDown);
			this.Controls.Add(this.btnVolumeUp);
			this.Controls.Add(this.btnClose);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.Name = "frmVirtualKeyBoard";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.TopMost = true;
			this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.Deactivate += new System.EventHandler(this.frmVirtualKeyBoard_Deactivate);
			this.cmsTrayMenu.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnPrevious;
		private System.Windows.Forms.Button btnPlay;
		private System.Windows.Forms.Button btnStop;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Button btnMute;
		private System.Windows.Forms.Timer tmrMousePosition;
		private System.Windows.Forms.Button btnVolumeUp;
		private System.Windows.Forms.Button btnVolumeDown;
		private System.Windows.Forms.NotifyIcon niTray;
		private System.Windows.Forms.ContextMenuStrip cmsTrayMenu;
		private System.Windows.Forms.ToolStripMenuItem tsmiExit;
		private System.Windows.Forms.ToolStripMenuItem tsmiShow;
	}
}

