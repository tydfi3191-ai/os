using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

// Token: 0x02000633 RID: 1587
public sealed partial class 2307 : 1488
{
	// Token: 0x0600301C RID: 12316 RVA: 0x001114E8 File Offset: 0x0010F6E8
	public 2307()
	{
		this.21();
	}

	// Token: 0x0600301D RID: 12317 RVA: 0x001114F8 File Offset: 0x0010F6F8
	protected override void OnShown(EventArgs 1)
	{
		this.6 = 2263.4;
		if (this.6.74.44.Count == 1)
		{
			2034 2 = this.6.74.44[0];
			float value = 1052.19(2.18.X, (float)this.11.Minimum, (float)this.11.Maximum);
			float value2 = 1052.19(2.18.Y, (float)this.12.Minimum, (float)this.12.Maximum);
			this.12.Value = (decimal)value2;
			this.11.Value = (decimal)value;
			this.14.Checked = false;
		}
		else
		{
			this.14.Checked = true;
			this.7 = default(208);
		}
		base.OnShown(1);
	}

	// Token: 0x0600301E RID: 12318 RVA: 0x00110789 File Offset: 0x0010E989
	private void 13(object 1, EventArgs 2)
	{
		base.Close();
	}

	// Token: 0x0600301F RID: 12319 RVA: 0x001115F8 File Offset: 0x0010F7F8
	private void 14()
	{
		this.6.8.17 = true;
		this.6.8.20(false, false);
		this.6.8.17 = false;
		int num = (int)this.11.Value;
		int num2 = (int)this.12.Value;
		bool @checked = this.14.Checked;
		if (@checked)
		{
			this.6.74.80(num - (int)this.7.X, num2 - (int)this.7.Y, @checked);
		}
		else
		{
			this.6.74.80(num, num2, @checked);
		}
		this.7.X = (float)num;
		this.7.Y = (float)num2;
	}

	// Token: 0x06003020 RID: 12320 RVA: 0x001116C6 File Offset: 0x0010F8C6
	private void 15(object 1, EventArgs 2)
	{
		this.14();
	}

	// Token: 0x06003021 RID: 12321 RVA: 0x001116C6 File Offset: 0x0010F8C6
	private void 16(object 1, EventArgs 2)
	{
		this.14();
	}

	// Token: 0x06003022 RID: 12322 RVA: 0x001116D0 File Offset: 0x0010F8D0
	private void 17(object 1, EventArgs 2)
	{
		if (this.14.Checked)
		{
			this.11.Minimum = -512m;
			this.12.Minimum = -384m;
			return;
		}
		this.11.Minimum = 0m;
		this.12.Minimum = 0m;
	}

	// Token: 0x06003023 RID: 12323 RVA: 0x001116C6 File Offset: 0x0010F8C6
	private void 18(object 1, KeyEventArgs 2)
	{
		this.14();
	}

	// Token: 0x06003024 RID: 12324 RVA: 0x001116C6 File Offset: 0x0010F8C6
	private void 19(object 1, KeyEventArgs 2)
	{
		this.14();
	}

	// Token: 0x06003025 RID: 12325 RVA: 0x00111735 File Offset: 0x0010F935
	private void 20(object 1, FormClosingEventArgs 2)
	{
		this.6.8.17 = true;
		this.6.8.20(false, false);
	}

	// Token: 0x06003027 RID: 12327 RVA: 0x0011177C File Offset: 0x0010F97C
	private void 21()
	{
		this.9 = new Label();
		this.10 = new Label();
		this.11 = new NumericUpDown();
		this.12 = new NumericUpDown();
		this.13 = new Label();
		this.14 = new CheckBox();
		this.15 = new Button();
		this.16 = new Button();
		((ISupportInitialize)this.11).BeginInit();
		((ISupportInitialize)this.12).BeginInit();
		base.SuspendLayout();
		this.9.AutoSize = true;
		this.9.Location = new Point(12, 9);
		this.9.Name = "label1";
		this.9.Size = new Size(109, 15);
		this.9.TabIndex = 0;
		this.9.Text = "Move note(s) to...";
		this.10.AutoSize = true;
		this.10.Location = new Point(12, 35);
		this.10.Name = "label2";
		this.10.Size = new Size(18, 15);
		this.10.TabIndex = 1;
		this.10.Text = "X:";
		this.11.BorderStyle = BorderStyle.FixedSingle;
		this.11.Location = new Point(33, 33);
		NumericUpDown numericUpDown = this.11;
		int[] array = new int[4];
		array[0] = 512;
		numericUpDown.Maximum = new decimal(array);
		this.11.Name = "nud_x";
		this.11.Size = new Size(98, 21);
		this.11.TabIndex = 2;
		this.11.TextAlign = HorizontalAlignment.Center;
		this.11.ValueChanged += this.15;
		this.11.KeyUp += this.18;
		this.12.BorderStyle = BorderStyle.FixedSingle;
		this.12.Location = new Point(171, 33);
		NumericUpDown numericUpDown2 = this.12;
		int[] array2 = new int[4];
		array2[0] = 384;
		numericUpDown2.Maximum = new decimal(array2);
		this.12.Name = "nud_y";
		this.12.Size = new Size(98, 21);
		this.12.TabIndex = 4;
		this.12.TextAlign = HorizontalAlignment.Center;
		this.12.ValueChanged += this.16;
		this.12.KeyUp += this.19;
		this.13.AutoSize = true;
		this.13.Location = new Point(150, 35);
		this.13.Name = "label3";
		this.13.Size = new Size(17, 15);
		this.13.TabIndex = 3;
		this.13.Text = "Y:";
		this.14.AutoSize = true;
		this.14.Location = new Point(15, 63);
		this.14.Name = "cb_relative";
		this.14.Size = new Size(136, 19);
		this.14.TabIndex = 5;
		this.14.Text = "Relative movement";
		this.14.UseVisualStyleBackColor = true;
		this.14.CheckedChanged += this.17;
		this.15.Location = new Point(13, 90);
		this.15.Name = "bt_ok";
		this.15.Size = new Size(152, 32);
		this.15.TabIndex = 6;
		this.15.Text = "OK";
		this.15.UseVisualStyleBackColor = true;
		this.15.Click += this.13;
		this.16.DialogResult = DialogResult.Cancel;
		this.16.Location = new Point(171, 90);
		this.16.Name = "bt_cancel";
		this.16.Size = new Size(98, 32);
		this.16.TabIndex = 7;
		this.16.Text = "Cancel";
		this.16.UseVisualStyleBackColor = true;
		this.16.Click += delegate(object 1, EventArgs 2)
		{
			this.6.8.20(true, true);
			base.Close();
		};
		base.AcceptButton = this.15;
		base.AutoScaleDimensions = new SizeF(96f, 96f);
		base.AutoScaleMode = AutoScaleMode.Dpi;
		base.CancelButton = this.16;
		base.ClientSize = new Size(282, 128);
		base.Controls.Add(this.16);
		base.Controls.Add(this.15);
		base.Controls.Add(this.14);
		base.Controls.Add(this.12);
		base.Controls.Add(this.13);
		base.Controls.Add(this.11);
		base.Controls.Add(this.10);
		base.Controls.Add(this.9);
		base.FormBorderStyle = FormBorderStyle.FixedSingle;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "CoordinateForm";
		base.ShowIcon = false;
		base.ShowInTaskbar = false;
		base.StartPosition = FormStartPosition.CenterScreen;
		this.Text = "Coordinate ";
		base.TopMost = true;
		base.FormClosing += this.20;
		((ISupportInitialize)this.11).EndInit();
		((ISupportInitialize)this.12).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	// Token: 0x040022AB RID: 8875
	private 2263 6;

	// Token: 0x040022AC RID: 8876
	private new 208 7;

	// Token: 0x040022AE RID: 8878
	private Label 9;

	// Token: 0x040022AF RID: 8879
	private Label 10;

	// Token: 0x040022B0 RID: 8880
	private new NumericUpDown 11;

	// Token: 0x040022B1 RID: 8881
	private new NumericUpDown 12;

	// Token: 0x040022B2 RID: 8882
	private Label 13;

	// Token: 0x040022B3 RID: 8883
	private CheckBox 14;

	// Token: 0x040022B4 RID: 8884
	private Button 15;

	// Token: 0x040022B5 RID: 8885
	private Button 16;
}
