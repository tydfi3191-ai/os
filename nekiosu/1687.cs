using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

// Token: 0x02000912 RID: 2322
public sealed partial class 1687 : 1730
{
	// Token: 0x0600421B RID: 16923 RVA: 0x0019AD40 File Offset: 0x00198F40
	public 1687()
	{
		this.23();
		this.14();
	}

	// Token: 0x0600421C RID: 16924 RVA: 0x0019AD7C File Offset: 0x00198F7C
	protected void 14()
	{
		this.11.Checked = 1304.167.1();
		this.19.Items.Clear();
		foreach (1772 <<EMPTY_NAME>> in 1784.11())
		{
			this.19.Items.Add(<<EMPTY_NAME>>);
			if ((2667)<<EMPTY_NAME>>.2 == 1304.198.GetValue())
			{
				this.19.SelectedItem = <<EMPTY_NAME>>;
			}
		}
		this.10.Items.Clear();
		foreach (1772 2 in 1784.13())
		{
			this.10.Items.Add(2);
			if ((1303)2.2 == 1304.203.GetValue())
			{
				this.10.SelectedItem = 2;
			}
		}
		this.21.Items.Clear();
		1784.35(this.7);
		foreach (1452 3 in this.7.8)
		{
			if (!(3 is 1386))
			{
				1772 4 = new 1772(3.GetText(), 3.8);
				this.21.Items.Add(4);
				if ((string)3.8 == (string)this.7.18)
				{
					this.21.SelectedItem = 4;
				}
			}
		}
		this.22.Checked = 1304.213.1();
	}

	// Token: 0x0600421D RID: 16925 RVA: 0x0019AF68 File Offset: 0x00199168
	protected void 15(object 1, EventArgs 2)
	{
		base.DialogResult = DialogResult.OK;
		try
		{
			1304.6();
			1345.6();
		}
		catch
		{
			base.DialogResult = DialogResult.Abort;
		}
		base.Close();
	}

	// Token: 0x0600421E RID: 16926 RVA: 0x0019AFA8 File Offset: 0x001991A8
	protected void 16(object 1, EventArgs 2)
	{
		1304.203.3();
		1304.157.10();
		1304.148.10();
		1304.158.10();
		1304.149.10();
		this.14();
	}

	// Token: 0x0600421F RID: 16927 RVA: 0x0019AFE4 File Offset: 0x001991E4
	private void 17(object 1, EventArgs 2)
	{
		try
		{
			1304.6();
		}
		catch
		{
		}
		1345.15(false, null);
	}

	// Token: 0x06004220 RID: 16928 RVA: 0x0019B014 File Offset: 0x00199214
	private void 18(object 1, FormClosingEventArgs 2)
	{
		if (2.CloseReason == CloseReason.WindowsShutDown || base.DialogResult == DialogResult.Cancel)
		{
			1345.16();
		}
	}

	// Token: 0x06004221 RID: 16929 RVA: 0x0019B030 File Offset: 0x00199230
	private void 19(object 1, EventArgs 2)
	{
		1304.198.SetValue((2667)((1772)this.19.SelectedItem).2);
		this.15.Enabled = (this.6 == 1304.198.GetValue());
		this.16.Enabled = (this.6 == 1304.198.GetValue());
	}

	// Token: 0x06004222 RID: 16930 RVA: 0x0019B09B File Offset: 0x0019929B
	private void 20(object 1, EventArgs 2)
	{
		1304.203.SetValue((1303)((1772)this.10.SelectedItem).2);
	}

	// Token: 0x06004223 RID: 16931 RVA: 0x0019B0C1 File Offset: 0x001992C1
	private void 21(object 1, EventArgs 2)
	{
		1304.167.2(this.11.Checked);
		this.14();
	}

	// Token: 0x06004224 RID: 16932 RVA: 0x0019B0DE File Offset: 0x001992DE
	private void 22(object 1, EventArgs 2)
	{
		1304.213.2(this.22.Checked);
	}

	// Token: 0x06004226 RID: 16934 RVA: 0x0019B114 File Offset: 0x00199314
	private void 23()
	{
		this.17 = new GroupBox();
		this.18 = new Label();
		this.19 = new ComboBox();
		this.14 = new Panel();
		this.20 = new Button();
		this.15 = new Button();
		this.16 = new Button();
		this.13 = new GroupBox();
		this.21 = new ComboBox();
		this.11 = new CheckBox();
		this.12 = new Label();
		this.9 = new Label();
		this.10 = new ComboBox();
		this.23 = new Label();
		this.22 = new CheckBox();
		this.17.SuspendLayout();
		this.14.SuspendLayout();
		this.13.SuspendLayout();
		base.SuspendLayout();
		this.17.Controls.Add(this.18);
		this.17.Controls.Add(this.19);
		this.17.Location = new Point(13, 142);
		this.17.Name = "groupBox2";
		this.17.Size = new Size(336, 69);
		this.17.TabIndex = 4;
		this.17.TabStop = false;
		this.17.Text = "Recovery";
		this.18.AutoSize = true;
		this.18.ForeColor = Color.Black;
		this.18.Location = new Point(5, 33);
		this.18.Margin = new Padding(2, 0, 2, 0);
		this.18.Name = "label3";
		this.18.Size = new Size(89, 15);
		this.18.TabIndex = 1;
		this.18.Text = "Release Stream:";
		this.19.DropDownStyle = ComboBoxStyle.DropDownList;
		this.19.FormattingEnabled = true;
		this.19.Location = new Point(99, 30);
		this.19.Margin = new Padding(2, 3, 2, 3);
		this.19.Name = "releaseStreams";
		this.19.Size = new Size(227, 21);
		this.19.TabIndex = 0;
		this.19.SelectedIndexChanged += this.19;
		this.14.BackColor = Color.FromArgb(85, 85, 85);
		this.14.Controls.Add(this.20);
		this.14.Controls.Add(this.15);
		this.14.Controls.Add(this.16);
		this.14.Dock = DockStyle.Bottom;
		this.14.Location = new Point(0, 228);
		this.14.Name = "panel1";
		this.14.Size = new Size(361, 141);
		this.14.TabIndex = 8;
		this.20.FlatAppearance.BorderColor = Color.DimGray;
		this.20.FlatAppearance.BorderSize = 0;
		this.20.FlatAppearance.MouseDownBackColor = Color.FromArgb(205, 18, 18);
		this.20.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, 44, 44);
		this.20.FlatStyle = FlatStyle.Flat;
		this.20.Font = new Font("Segoe UI Semibold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this.20.ForeColor = Color.White;
		this.20.Location = new Point(7, 98);
		this.20.Name = "buttonRepair";
		this.20.Size = new Size(350, 35);
		this.20.TabIndex = 7;
		this.20.Text = "repair osu!";
		this.20.UseVisualStyleBackColor = true;
		this.20.Click += this.17;
		this.15.FlatAppearance.BorderColor = Color.DimGray;
		this.15.FlatAppearance.BorderSize = 0;
		this.15.FlatAppearance.MouseDownBackColor = Color.FromArgb(61, 172, 220);
		this.15.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 127, 161);
		this.15.FlatStyle = FlatStyle.Flat;
		this.15.Font = new Font("Segoe UI", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.15.ForeColor = Color.White;
		this.15.Location = new Point(7, 14);
		this.15.Name = "buttonStartOsu";
		this.15.Size = new Size(350, 35);
		this.15.TabIndex = 2;
		this.15.Text = "start osu!";
		this.15.UseVisualStyleBackColor = true;
		this.15.Click += this.15;
		this.16.FlatAppearance.BorderColor = Color.DimGray;
		this.16.FlatAppearance.BorderSize = 0;
		this.16.FlatStyle = FlatStyle.Flat;
		this.16.Font = new Font("Segoe UI", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.16.ForeColor = Color.White;
		this.16.Location = new Point(7, 57);
		this.16.Name = "buttonResetSettings";
		this.16.Size = new Size(350, 35);
		this.16.TabIndex = 6;
		this.16.Text = "reset settings";
		this.16.UseVisualStyleBackColor = true;
		this.16.Click += this.16;
		this.13.Controls.Add(this.22);
		this.13.Controls.Add(this.23);
		this.13.Controls.Add(this.21);
		this.13.Controls.Add(this.11);
		this.13.Controls.Add(this.12);
		this.13.Controls.Add(this.9);
		this.13.Controls.Add(this.10);
		this.13.Location = new Point(12, 12);
		this.13.Name = "groupBox1";
		this.13.Size = new Size(336, 122);
		this.13.TabIndex = 1;
		this.13.TabStop = false;
		this.13.Text = "Graphics";
		this.21.DropDownStyle = ComboBoxStyle.DropDownList;
		this.21.FormattingEnabled = true;
		this.21.Location = new Point(100, 25);
		this.21.Margin = new Padding(2, 3, 2, 3);
		this.21.Name = "comboBoxResolutions";
		this.21.Size = new Size(141, 21);
		this.21.TabIndex = 3;
		this.21.SelectedIndexChanged += delegate(object 1, EventArgs 2)
		{
			1772 3 = (1772)this.21.SelectedItem;
			if (3.2 == null)
			{
				if (this.21.Items.Count <= this.21.SelectedIndex + 1)
				{
					return;
				}
				3 = (1772)this.21.SelectedItem;
			}
			string[] array = ((string)3.2).Split(new char[]
			{
				'x'
			});
			int 4 = int.Parse(array[0]);
			int 5 = int.Parse(array[1]);
			if (1304.167.1())
			{
				1304.158.7(4);
				1304.149.7(5);
				return;
			}
			1304.157.7(4);
			1304.148.7(5);
		};
		this.11.AutoSize = true;
		this.11.ForeColor = Color.Black;
		this.11.Location = new Point(248, 27);
		this.11.Margin = new Padding(2, 3, 2, 3);
		this.11.Name = "checkBoxFullScreen";
		this.11.Size = new Size(83, 19);
		this.11.TabIndex = 2;
		this.11.Text = "Full Screen";
		this.11.UseVisualStyleBackColor = true;
		this.11.CheckedChanged += this.21;
		this.12.AutoSize = true;
		this.12.ForeColor = Color.Black;
		this.12.Location = new Point(5, 29);
		this.12.Margin = new Padding(2, 0, 2, 0);
		this.12.Name = "labelResolution";
		this.12.Size = new Size(63, 15);
		this.12.TabIndex = 1;
		this.12.Text = "Resolution";
		this.9.AutoSize = true;
		this.9.ForeColor = Color.Black;
		this.9.Location = new Point(5, 58);
		this.9.Margin = new Padding(2, 0, 2, 0);
		this.9.Name = "labelFrameLimiter";
		this.9.Size = new Size(80, 15);
		this.9.TabIndex = 1;
		this.9.Text = "Frame Limiter";
		this.10.DropDownStyle = ComboBoxStyle.DropDownList;
		this.10.FormattingEnabled = true;
		this.10.Location = new Point(100, 55);
		this.10.Margin = new Padding(2, 3, 2, 3);
		this.10.Name = "comboBoxFrameLimiter";
		this.10.Size = new Size(227, 21);
		this.10.TabIndex = 0;
		this.10.SelectedIndexChanged += this.20;
		this.23.AutoSize = true;
		this.23.Location = new Point(5, 87);
		this.23.Name = "labelRenderer";
		this.23.Size = new Size(54, 15);
		this.23.TabIndex = 4;
		this.23.Text = "Renderer";
		this.22.AutoSize = true;
		this.22.Location = new Point(100, 87);
		this.22.Name = "checkBoxCompatibilityMode";
		this.22.Size = new Size(132, 19);
		this.22.TabIndex = 5;
		this.22.Text = "Compatibility Mode";
		this.22.UseVisualStyleBackColor = true;
		this.22.CheckedChanged += this.22;
		base.AutoScaleDimensions = new SizeF(96f, 96f);
		base.AutoScaleMode = AutoScaleMode.Dpi;
		base.AutoSizeMode = AutoSizeMode.GrowAndShrink;
		this.BackColor = SystemColors.Control;
		base.ClientSize = new Size(361, 369);
		base.Controls.Add(this.17);
		base.Controls.Add(this.14);
		base.Controls.Add(this.13);
		this.Font = new Font("Segoe UI", 9f);
		this.ForeColor = Color.Black;
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.Margin = new Padding(2, 3, 2, 3);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "Configuration";
		base.Opacity = 1.0;
		base.StartPosition = FormStartPosition.CenterScreen;
		this.Text = "nekiosu configuration";
		base.TopMost = true;
		base.FormClosing += this.18;
		this.17.ResumeLayout(false);
		this.17.PerformLayout();
		this.14.ResumeLayout(false);
		this.13.ResumeLayout(false);
		this.13.PerformLayout();
		base.ResumeLayout(false);
	}

	// Token: 0x04003040 RID: 12352
	private 2667 6 = 1304.198.GetValue();

	// Token: 0x04003041 RID: 12353
	private new 1373 7 = new 1373(null, string.Empty, 208.Zero);

	// Token: 0x04003043 RID: 12355
	private Label 9;

	// Token: 0x04003044 RID: 12356
	private ComboBox 10;

	// Token: 0x04003045 RID: 12357
	private new CheckBox 11;

	// Token: 0x04003046 RID: 12358
	private new Label 12;

	// Token: 0x04003047 RID: 12359
	private GroupBox 13;

	// Token: 0x04003048 RID: 12360
	private Panel 14;

	// Token: 0x04003049 RID: 12361
	private Button 15;

	// Token: 0x0400304A RID: 12362
	private Button 16;

	// Token: 0x0400304B RID: 12363
	private GroupBox 17;

	// Token: 0x0400304C RID: 12364
	private Label 18;

	// Token: 0x0400304D RID: 12365
	private ComboBox 19;

	// Token: 0x0400304E RID: 12366
	private Button 20;

	// Token: 0x0400304F RID: 12367
	private ComboBox 21;

	// Token: 0x04003050 RID: 12368
	private CheckBox 22;

	// Token: 0x04003051 RID: 12369
	private Label 23;
}
