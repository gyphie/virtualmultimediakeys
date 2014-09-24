using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WindowsInput;

namespace VMMK
{
	public partial class frmVirtualKeyBoard : Form
	{
		KeyboardHook hotKeyHook = new KeyboardHook();
		private bool allowVisible = false;

		public frmVirtualKeyBoard()
		{
			InitializeComponent();
			this.hotKeyHook.KeyPressed += new EventHandler<KeyPressedEventArgs>(hotKeyHook_KeyPressed);
			this.hotKeyHook.RegisterHotKey(VMMK.ModifierKeys.Win, Keys.NumPad7);
			this.hotKeyHook.RegisterHotKey(VMMK.ModifierKeys.Win, Keys.NumPad8);
			this.hotKeyHook.RegisterHotKey(VMMK.ModifierKeys.Win, Keys.NumPad2);
			this.hotKeyHook.RegisterHotKey(VMMK.ModifierKeys.Win, Keys.NumPad4);
			this.hotKeyHook.RegisterHotKey(VMMK.ModifierKeys.Win, Keys.NumPad6);
			this.hotKeyHook.RegisterHotKey(VMMK.ModifierKeys.Win, Keys.NumPad5);
			this.hotKeyHook.RegisterHotKey(VMMK.ModifierKeys.Win, Keys.NumPad3);
			this.hotKeyHook.RegisterHotKey(VMMK.ModifierKeys.Win, Keys.NumPad1);
		}

		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			switch (keyData)
			{
				case Keys.NumPad4:
					this.btnPrevious.PerformClick();
					break;
				case Keys.NumPad6:
					this.btnNext.PerformClick();
					break;
				case Keys.NumPad5:
					this.btnPlay.PerformClick();
					break;
				case Keys.NumPad3:
					this.btnStop.PerformClick();
					break;
				case Keys.Enter:
					this.btnMute.PerformClick();
					break;
				case Keys.Escape:
					this.hotKeyHook_KeyPressed(this, null);
					break;
				case Keys.X:
					this.btnClose.PerformClick();
					break;
				case Keys.NumPad2:
					this.btnVolumeDown.PerformClick();
					break;
				case Keys.NumPad8:
					this.btnVolumeUp.PerformClick();
					break;
				default:
					return base.ProcessCmdKey(ref msg, keyData);
			}

			return true;
		}

		protected override void SetVisibleCore(bool value)
		{
			if (!this.allowVisible)
			{
				value = false;
			}
			base.SetVisibleCore(value);
		}

		private void ShowForm()
		{
			this.SuspendLayout();
			this.allowVisible = true;
			this.Show();
			this.Activate();
			this.btnPlay.Focus();
			this.tmrMousePosition_Tick(null, null);
			this.tmrMousePosition.Start();
			this.ResumeLayout();
		}
		private void HideForm()
		{
			this.Hide();
			this.tmrMousePosition.Stop();
		}

		private void hotKeyHook_KeyPressed(object sender, KeyPressedEventArgs e)
		{
			switch (e.Key)
			{
				case Keys.NumPad1:
					this.btnMute_Click(sender, null);
					break;
				case Keys.NumPad2:
					this.btnVolumeDown_Click(sender, null);
					break;
				case Keys.NumPad3:
					this.btnStop_Click(sender, null);
					break;
				case Keys.NumPad4:
					this.btnPrevious_Click(sender, null);
					break;
				case Keys.NumPad5:
					this.btnPlay_Click(sender, null);
					break;
				case Keys.NumPad6:
					this.btnNext_Click(sender, null);
					break;
				case Keys.NumPad7:
						if (this.Visible)
						{
							this.HideForm();
						}
						else
						{
							this.ShowForm();
						}
					break;
				case Keys.NumPad8:
					this.btnVolumeUp_Click(sender, null);
					break;
				default:
					break;
			}
		}

		private void SendKeyPress(VirtualKeyCode keyCode)
		{
			InputSimulator.SimulateKeyPress(keyCode);
		}
		
		private void btnClose_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to exit?", "Exit Virtual MultiMedia Keys", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				Application.Exit();
			}
		}

		private void btnPrevious_Click(object sender, EventArgs e)
		{
			this.SendKeyPress(VirtualKeyCode.MEDIA_PREV_TRACK);
		}

		private void btnPlay_Click(object sender, EventArgs e)
		{
			this.SendKeyPress(VirtualKeyCode.MEDIA_PLAY_PAUSE);
		}

		private void btnStop_Click(object sender, EventArgs e)
		{
			this.SendKeyPress(VirtualKeyCode.MEDIA_STOP);
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			this.SendKeyPress(VirtualKeyCode.MEDIA_NEXT_TRACK);

		}

		private void btnMute_Click(object sender, EventArgs e)
		{
			this.SendKeyPress(VirtualKeyCode.VOLUME_MUTE);
		}

		private void btnVolumeUp_Click(object sender, EventArgs e)
		{
			this.SendKeyPress(VirtualKeyCode.VOLUME_UP);
		}

		private void btnVolumeDown_Click(object sender, EventArgs e)
		{
			this.SendKeyPress(VirtualKeyCode.VOLUME_DOWN);
		}

		private void tmrMousePosition_Tick(object sender, EventArgs e)
		{
			Screen mouseScreen = Screen.FromPoint(Cursor.Position);
			if (mouseScreen != null)
			{
				this.Left = mouseScreen.Bounds.X + mouseScreen.Bounds.Width / 2 - this.Width / 2;
				this.Top = mouseScreen.Bounds.Y + mouseScreen.Bounds.Height / 2 - this.Height / 2;
			}
		}

		private void frmVirtualKeyBoard_Deactivate(object sender, EventArgs e)
		{
			this.HideForm();
		}

		private void tsmiExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void niTray_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			this.ShowForm();
		}

		private void tsmiShow_Click(object sender, EventArgs e)
		{
			this.niTray_MouseDoubleClick(null, null);
		}

	}
}
