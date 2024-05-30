/* 
 * X To Twitter URL Replacer
 *					Coding by FAN
 * 
 * 
 * twitter.comの頃に動いていたメディアDL拡張機能が動かなくなったので
 * x.comをtwitter.comに置き換えるツールを作りました。
 * 
 * 
 * おのれイーロンマスクめ、許せぬ。
 * 
 * 絵師さんmisskeyでも絵を上げてほしいです。
 * そうすればtwitterやめられるので。
 * 
 */

namespace X2TwitterUrlReplacer
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void replaceButton_Click(object sender, EventArgs e)
		{
			string replaceTarget = urlText.Text.Trim();
			// get text
			if (replaceTarget.Length < 1)
			{
				string clip = Clipboard.GetText();
				if (clip.Trim().Length < 1)
				{
					urlText.Clear();
					return;
				}
				replaceTarget = clip;

				if (!(replaceTarget.Contains("x.com") || replaceTarget.Contains("twitter.com")))
				{
					urlText.Clear();
					return;
				}
			}

			// replace
			replaceTarget = replaceTarget.Replace("x.com", "twitter.com");
			var length = replaceTarget.IndexOf("?");
			if (length > 0)
			{
				replaceTarget = replaceTarget.Substring(0, length);
			}

			replaceTarget = (replaceTarget + "/?mx=1").Replace("//?mx=1", "/?mx=1");

			// linkLabel create
			LinkLabel lnk = new LinkLabel();
			lnk.Text = replaceTarget;
			lnk.Width = 500;
			lnk.LinkClicked += (s, args) =>
			{
				var startInfo = new System.Diagnostics.ProcessStartInfo(replaceTarget);
				startInfo.UseShellExecute = true;
				System.Diagnostics.Process.Start(startInfo);
			};
			resultFlowLayoutPanel.Controls.Add(lnk);
			resultFlowLayoutPanel.Controls.SetChildIndex(lnk, 0);

			if (autoOpenCheck.Checked)
			{
				var startInfo = new System.Diagnostics.ProcessStartInfo(replaceTarget);
				startInfo.UseShellExecute = true;
				System.Diagnostics.Process.Start(startInfo);
			}

			urlText.Clear();
			return;
		}

		private void frontWindowCheck_CheckedChanged(object sender, EventArgs e)
		{
			if (frontWindowCheck.Checked)
			{
				this.TopMost = true;
			}
			else
			{
				this.TopMost = false;
			}
		}
	}
}