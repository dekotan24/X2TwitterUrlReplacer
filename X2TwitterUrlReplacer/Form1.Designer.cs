namespace X2TwitterUrlReplacer
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.urlText = new System.Windows.Forms.TextBox();
			this.replaceButton = new System.Windows.Forms.Button();
			this.resultFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.frontWindowCheck = new System.Windows.Forms.CheckBox();
			this.autoOpenCheck = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// urlText
			// 
			this.urlText.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.urlText.Location = new System.Drawing.Point(12, 12);
			this.urlText.Name = "urlText";
			this.urlText.Size = new System.Drawing.Size(485, 29);
			this.urlText.TabIndex = 0;
			// 
			// replaceButton
			// 
			this.replaceButton.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.replaceButton.Location = new System.Drawing.Point(12, 47);
			this.replaceButton.Name = "replaceButton";
			this.replaceButton.Size = new System.Drawing.Size(485, 72);
			this.replaceButton.TabIndex = 1;
			this.replaceButton.Text = "■ 置換 ■\r\n（URLが空欄の場合はクリップボードから読込）";
			this.replaceButton.UseVisualStyleBackColor = true;
			this.replaceButton.Click += new System.EventHandler(this.replaceButton_Click);
			// 
			// resultFlowLayoutPanel
			// 
			this.resultFlowLayoutPanel.Location = new System.Drawing.Point(12, 154);
			this.resultFlowLayoutPanel.Name = "resultFlowLayoutPanel";
			this.resultFlowLayoutPanel.Size = new System.Drawing.Size(485, 190);
			this.resultFlowLayoutPanel.TabIndex = 2;
			// 
			// frontWindowCheck
			// 
			this.frontWindowCheck.AutoSize = true;
			this.frontWindowCheck.Checked = true;
			this.frontWindowCheck.CheckState = System.Windows.Forms.CheckState.Checked;
			this.frontWindowCheck.Location = new System.Drawing.Point(12, 128);
			this.frontWindowCheck.Name = "frontWindowCheck";
			this.frontWindowCheck.Size = new System.Drawing.Size(86, 19);
			this.frontWindowCheck.TabIndex = 3;
			this.frontWindowCheck.Text = "最前面表示";
			this.frontWindowCheck.UseVisualStyleBackColor = true;
			this.frontWindowCheck.CheckedChanged += new System.EventHandler(this.frontWindowCheck_CheckedChanged);
			// 
			// autoOpenCheck
			// 
			this.autoOpenCheck.AutoSize = true;
			this.autoOpenCheck.Checked = true;
			this.autoOpenCheck.CheckState = System.Windows.Forms.CheckState.Checked;
			this.autoOpenCheck.Location = new System.Drawing.Point(104, 129);
			this.autoOpenCheck.Name = "autoOpenCheck";
			this.autoOpenCheck.Size = new System.Drawing.Size(159, 19);
			this.autoOpenCheck.TabIndex = 5;
			this.autoOpenCheck.Text = "置換後に自動でリンクを開く";
			this.autoOpenCheck.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(509, 356);
			this.Controls.Add(this.autoOpenCheck);
			this.Controls.Add(this.frontWindowCheck);
			this.Controls.Add(this.resultFlowLayoutPanel);
			this.Controls.Add(this.replaceButton);
			this.Controls.Add(this.urlText);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "X.com→Twitter.com URL Replacer";
			this.TopMost = true;
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private TextBox urlText;
		private Button replaceButton;
		private FlowLayoutPanel resultFlowLayoutPanel;
		private CheckBox frontWindowCheck;
		private CheckBox autoOpenCheck;
	}
}