using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

// Token: 0x02000641 RID: 1601
public sealed partial class 2319 : Form
{
	// Token: 0x0600308E RID: 12430 RVA: 0x001168D0 File Offset: 0x00114AD0
	public 2319()
	{
		this.10();
	}

	// Token: 0x0600308F RID: 12431 RVA: 0x001168F4 File Offset: 0x00114AF4
	protected override void OnShown(EventArgs 1)
	{
		this.1 = 2263.4;
		this.1.57();
		this.1.8.17<2034>((2452)0, (2451)28, this.1.74.44);
		this.2 = 1f;
		this.4(1f, true);
		this.17.SelectAll();
		base.OnShown(1);
	}

	// Token: 0x06003090 RID: 12432 RVA: 0x00116964 File Offset: 0x00114B64
	public void 1(float 1)
	{
		int num = (int)(1 * 1000f);
		if ((float)num >= this.7 * 1000f)
		{
			throw new ArgumentOutOfRangeException();
		}
		this.6 = (float)num * 0.001f;
		this.15.Minimum = num;
	}

	// Token: 0x06003091 RID: 12433 RVA: 0x001169AC File Offset: 0x00114BAC
	public void 2(float 1)
	{
		int num = (int)(1 * 1000f);
		if ((float)num <= this.6 * 1000f)
		{
			throw new ArgumentOutOfRangeException();
		}
		this.7 = (float)num * 0.001f;
		this.15.Maximum = num;
	}

	// Token: 0x06003092 RID: 12434 RVA: 0x001169F4 File Offset: 0x00114BF4
	private void 3()
	{
		float num = (float)this.15.Value * 0.001f;
		this.1.74.79(new 208(this.4 ? (1f / this.2) : 1f, this.5 ? (1f / this.2) : 1f), this.3);
		this.2 = num;
		this.3 = this.11.Checked;
		this.4 = this.19.Checked;
		this.5 = this.20.Checked;
		this.1.74.79(new 208(this.4 ? num : 1f, this.5 ? num : 1f), this.11.Checked);
	}

	// Token: 0x06003093 RID: 12435 RVA: 0x00116AE0 File Offset: 0x00114CE0
	private void 4(float 1, bool 2)
	{
		float num = Math.Max(Math.Min(1, this.7), this.6);
		int value = (int)(num * 1000f);
		if (!this.15.Focused || 2)
		{
			this.15.Value = value;
		}
		if (!this.17.Focused || 2)
		{
			this.17.Text = num.ToString("0.000");
		}
		this.3();
	}

	// Token: 0x06003094 RID: 12436 RVA: 0x00116B5B File Offset: 0x00114D5B
	private void 5(object 1, EventArgs 2)
	{
		this.11.Checked = !this.12.Checked;
		this.3();
	}

	// Token: 0x06003095 RID: 12437 RVA: 0x00116B7C File Offset: 0x00114D7C
	private void 6(object 1, EventArgs 2)
	{
		float num = (float)this.15.Value * 0.001f;
		this.4(num, false);
	}

	// Token: 0x06003096 RID: 12438 RVA: 0x00110789 File Offset: 0x0010E989
	private void 7(object 1, EventArgs 2)
	{
		base.Close();
	}

	// Token: 0x06003097 RID: 12439 RVA: 0x00116BA4 File Offset: 0x00114DA4
	private void 8(object 1, EventArgs 2)
	{
		this.1.8.20(true, true);
		base.Close();
	}

	// Token: 0x06003098 RID: 12440 RVA: 0x00116BBE File Offset: 0x00114DBE
	private void 9(object 1, EventArgs 2)
	{
		this.3();
		this.13.Enabled = (this.19.Checked || this.20.Checked);
	}

	// Token: 0x0600309A RID: 12442 RVA: 0x00116C0C File Offset: 0x00114E0C
	private void 10()
	{
		this.9 = new GroupBox();
		this.11 = new RadioButton();
		this.12 = new RadioButton();
		this.14 = new Button();
		this.15 = new TrackBar();
		this.16 = new Label();
		this.17 = new TextBox();
		this.18 = new Label();
		base.AcceptButton = (this.13 = new Button());
		this.10 = new GroupBox();
		this.20 = new CheckBox();
		this.19 = new CheckBox();
		this.9.SuspendLayout();
		((ISupportInitialize)this.15).BeginInit();
		this.10.SuspendLayout();
		base.SuspendLayout();
		this.9.Controls.Add(this.11);
		this.9.Controls.Add(this.12);
		this.9.Location = new Point(12, 73);
		this.9.Name = "gbOrigin";
		this.9.Size = new Size(144, 73);
		this.9.TabIndex = 19;
		this.9.TabStop = false;
		this.9.Text = "Origin";
		this.11.AutoSize = true;
		this.11.Checked = true;
		this.11.Location = new Point(10, 20);
		this.11.Name = "radPlayfield";
		this.11.Size = new Size(108, 19);
		this.11.TabIndex = 8;
		this.11.TabStop = true;
		this.11.Text = "Playfield Centre";
		this.11.UseVisualStyleBackColor = true;
		this.12.AutoSize = true;
		this.12.Location = new Point(10, 41);
		this.12.Name = "radSelection";
		this.12.Size = new Size(111, 19);
		this.12.TabIndex = 9;
		this.12.Text = "Selection Centre";
		this.12.UseVisualStyleBackColor = true;
		this.12.CheckedChanged += this.5;
		this.14.DialogResult = DialogResult.Cancel;
		this.14.Location = new Point(162, 152);
		this.14.Name = "btnCancel";
		this.14.Size = new Size(95, 34);
		this.14.TabIndex = 15;
		this.14.Text = "Cancel";
		this.14.UseVisualStyleBackColor = true;
		this.14.Click += this.8;
		this.15.LargeChange = 100;
		this.15.Location = new Point(12, 28);
		this.15.Maximum = 2000;
		this.15.Minimum = 100;
		this.15.Name = "trScale";
		this.15.Size = new Size(174, 45);
		this.15.SmallChange = 10;
		this.15.TabIndex = 20;
		this.15.TickFrequency = 100;
		this.15.Value = 100;
		this.15.Scroll += this.6;
		this.15.MouseCaptureChanged += delegate(object 1, EventArgs 2)
		{
			this.1.13(true, false);
		};
		this.16.AutoSize = true;
		this.16.Location = new Point(242, 30);
		this.16.Name = "lblMul";
		this.16.Size = new Size(15, 15);
		this.16.TabIndex = 17;
		this.16.Text = "×";
		this.17.Location = new Point(192, 29);
		this.17.Name = "txtScale";
		this.17.Size = new Size(48, 23);
		this.17.TabIndex = 13;
		this.17.Text = "0";
		this.17.TextChanged += delegate(object 1, EventArgs 2)
		{
			float num;
			if (float.TryParse(this.17.Text, out num))
			{
				this.4(num, false);
			}
		};
		this.18.AutoSize = true;
		this.18.Location = new Point(14, 9);
		this.18.Name = "lblScale";
		this.18.Size = new Size(207, 15);
		this.18.TabIndex = 16;
		this.18.Text = "Scale the selected objects’ spacing by:";
		this.13.Location = new Point(12, 152);
		this.13.Name = "btnOk";
		this.13.Size = new Size(144, 34);
		this.13.TabIndex = 14;
		this.13.Text = "OK";
		this.13.UseVisualStyleBackColor = true;
		this.13.Click += this.7;
		this.10.Controls.Add(this.20);
		this.10.Controls.Add(this.19);
		this.10.Location = new Point(162, 73);
		this.10.Name = "gbApplyTo";
		this.10.Size = new Size(94, 73);
		this.10.TabIndex = 21;
		this.10.TabStop = false;
		this.10.Text = "Apply to";
		this.20.AutoSize = true;
		this.20.Checked = true;
		this.20.CheckState = CheckState.Checked;
		this.20.Location = new Point(9, 42);
		this.20.Name = "chkAxisY";
		this.20.Size = new Size(57, 19);
		this.20.TabIndex = 1;
		this.20.Text = "Y-axis";
		this.20.UseVisualStyleBackColor = true;
		this.20.CheckedChanged += delegate(object 1, EventArgs 2)
		{
			this.3();
			this.13.Enabled = (this.19.Checked || this.20.Checked);
		};
		this.19.AutoSize = true;
		this.19.Checked = true;
		this.19.CheckState = CheckState.Checked;
		this.19.Location = new Point(9, 20);
		this.19.Name = "chkAxisX";
		this.19.Size = new Size(57, 19);
		this.19.TabIndex = 0;
		this.19.Text = "X-axis";
		this.19.UseVisualStyleBackColor = true;
		this.19.CheckedChanged += this.9;
		base.AutoScaleDimensions = new SizeF(96f, 96f);
		base.AutoScaleMode = AutoScaleMode.Dpi;
		base.ClientSize = new Size(268, 198);
		base.Controls.Add(this.10);
		base.Controls.Add(this.9);
		base.Controls.Add(this.14);
		base.Controls.Add(this.15);
		base.Controls.Add(this.16);
		base.Controls.Add(this.17);
		base.Controls.Add(this.18);
		base.Controls.Add(this.13);
		this.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.FixedSingle;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "ScaleBy";
		base.ShowIcon = false;
		base.ShowInTaskbar = false;
		base.SizeGripStyle = SizeGripStyle.Hide;
		base.StartPosition = FormStartPosition.CenterParent;
		this.Text = "Scale by";
		base.TopMost = true;
		base.FormClosing += delegate(object 1, FormClosingEventArgs 2)
		{
			this.1.8.20(false, false);
		};
		this.9.ResumeLayout(false);
		this.9.PerformLayout();
		((ISupportInitialize)this.15).EndInit();
		this.10.ResumeLayout(false);
		this.10.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	// Token: 0x04002322 RID: 8994
	private 2263 1;

	// Token: 0x04002323 RID: 8995
	private float 2;

	// Token: 0x04002324 RID: 8996
	private bool 3;

	// Token: 0x04002325 RID: 8997
	private bool 4;

	// Token: 0x04002326 RID: 8998
	private bool 5;

	// Token: 0x04002327 RID: 8999
	private float 6 = 0.5f;

	// Token: 0x04002328 RID: 9000
	private float 7 = 2f;

	// Token: 0x0400232A RID: 9002
	private GroupBox 9;

	// Token: 0x0400232B RID: 9003
	private GroupBox 10;

	// Token: 0x0400232C RID: 9004
	private RadioButton 11;

	// Token: 0x0400232D RID: 9005
	private RadioButton 12;

	// Token: 0x0400232E RID: 9006
	private Button 13;

	// Token: 0x0400232F RID: 9007
	private Button 14;

	// Token: 0x04002330 RID: 9008
	private TrackBar 15;

	// Token: 0x04002331 RID: 9009
	private Label 16;

	// Token: 0x04002332 RID: 9010
	private TextBox 17;

	// Token: 0x04002333 RID: 9011
	private Label 18;

	// Token: 0x04002334 RID: 9012
	private CheckBox 19;

	// Token: 0x04002335 RID: 9013
	private CheckBox 20;
}
