using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

// Token: 0x02000632 RID: 1586
public sealed partial class 2306 : 1488
{
	// Token: 0x06003009 RID: 12297 RVA: 0x00110540 File Offset: 0x0010E740
	internal 2306(2123 1)
	{
		this.6 = 2263.4;
		this.6.57();
		this.25();
		this.7 = 1;
		this.8 = true;
		int num = this.6.96();
		if (num == 3 || num == 6)
		{
			this.19.SelectedIndex = 2;
		}
		else
		{
			this.19.SelectedIndex = 3;
		}
		this.8 = false;
	}

	// Token: 0x0600300A RID: 12298 RVA: 0x001105B4 File Offset: 0x0010E7B4
	protected override void OnShown(EventArgs 1)
	{
		this.6 = 2263.4;
		this.6.8.18((2452)0, (2451)9, this.7);
		this.6.31();
		this.6.7.29(this.7, false);
		this.20();
		base.OnShown(1);
	}

	// Token: 0x0600300B RID: 12299 RVA: 0x00110618 File Offset: 0x0010E818
	private void 13(object 1, EventArgs 2)
	{
		if (this.12.Checked)
		{
			this.11.Checked = false;
			this.13.Enabled = false;
			this.15.Enabled = false;
			this.14.Enabled = true;
			this.16.Enabled = true;
			this.20();
		}
	}

	// Token: 0x0600300C RID: 12300 RVA: 0x00110674 File Offset: 0x0010E874
	private void 14(TrackBar 1, int 2)
	{
		if (2 <= 1.Minimum)
		{
			1.Value = 1.Minimum;
			return;
		}
		if (2 >= 1.Maximum)
		{
			1.Value = 1.Maximum;
			return;
		}
		1.Value = 2;
	}

	// Token: 0x0600300D RID: 12301 RVA: 0x001106A9 File Offset: 0x0010E8A9
	private void 15(NumericUpDown 1, decimal 2)
	{
		if (2 <= 1.Minimum)
		{
			1.Value = 1.Minimum;
			return;
		}
		if (2 >= 1.Maximum)
		{
			1.Value = 1.Maximum;
			return;
		}
		1.Value = 2;
	}

	// Token: 0x0600300E RID: 12302 RVA: 0x001106E8 File Offset: 0x0010E8E8
	private void 16(object 1, EventArgs 2)
	{
		if (!this.8)
		{
			this.8 = true;
			this.15(this.15, this.13.Value);
			this.8 = false;
			this.20();
		}
	}

	// Token: 0x0600300F RID: 12303 RVA: 0x00110724 File Offset: 0x0010E924
	private void 17(object 1, EventArgs 2)
	{
		if (!this.8)
		{
			this.8 = true;
			this.14(this.14, (int)(this.16.Value * 100.0m));
			this.8 = false;
			this.20();
			this.6.13(true, false);
		}
	}

	// Token: 0x06003010 RID: 12304 RVA: 0x00110789 File Offset: 0x0010E989
	private void 18(object 1, EventArgs 2)
	{
		base.Close();
	}

	// Token: 0x06003011 RID: 12305 RVA: 0x00110791 File Offset: 0x0010E991
	private void 19(object 1, EventArgs 2)
	{
		this.6.8.20(true, true);
	}

	// Token: 0x06003012 RID: 12306 RVA: 0x001107A8 File Offset: 0x0010E9A8
	private void 20()
	{
		int <<EMPTY_NAME>> = this.7.1;
		double num = this.7.6;
		double num2 = (double)this.21();
		int num3;
		double num4;
		if (this.11.Checked)
		{
			num3 = (int)this.15.Value;
			num4 = num / (double)Math.Max(1, num3 - 1);
		}
		else
		{
			num4 = this.7.87 * 1226.88((double)<<EMPTY_NAME>>, false) * (double)this.16.Value / (num2 * 1000.0);
			num3 = (int)((num + 1.0) / num4) + 1;
		}
		if (num4 != this.9 && num3 != 0)
		{
			double num5 = 0.0;
			double num6 = 1226.88((double)<<EMPTY_NAME>>, false) / num2;
			double num7 = (double)<<EMPTY_NAME>>;
			this.6.8.17 = false;
			this.6.74.DeleteSelection();
			this.6.2(false);
			this.6.8.17 = true;
			this.6.8.14((2452)0, (2451)8, (2450)0);
			bool 2 = true;
			for (int i = 0; i < num3; i++)
			{
				208 3 = this.7.29((float)num5);
				2033 4 = new 2033(this.6.7, 3, (int)num7, i == 0 && this.7.IsNewCombo(), false, false, false, 0);
				this.6.7.AddHitObject(4, true, true);
				this.6.74.SelectObject(4);
				this.6.8.23(4, 2);
				2 = false;
				num7 += num6;
				num5 += num4;
			}
			this.6.8.26<2034>(this.6.7.37, (2450)65536, false);
			this.6.7.37.Clear();
			this.6.7.2(true);
			this.6.85 = true;
		}
	}

	// Token: 0x06003013 RID: 12307 RVA: 0x001109C4 File Offset: 0x0010EBC4
	private int 21()
	{
		int result;
		switch (this.19.SelectedIndex)
		{
		case 0:
			result = 1;
			break;
		case 1:
			result = 2;
			break;
		case 2:
			result = 3;
			break;
		case 3:
			result = 4;
			break;
		case 4:
			result = 6;
			break;
		case 5:
			result = 8;
			break;
		default:
			result = 1;
			break;
		}
		return result;
	}

	// Token: 0x06003014 RID: 12308 RVA: 0x00110A18 File Offset: 0x0010EC18
	private void 22(object 1, EventArgs 2)
	{
		if (!this.8)
		{
			this.20();
		}
	}

	// Token: 0x06003015 RID: 12309 RVA: 0x00110A28 File Offset: 0x0010EC28
	private void 23(object 1, FormClosingEventArgs 2)
	{
		this.6.8.20(false, false);
	}

	// Token: 0x06003016 RID: 12310 RVA: 0x00110A3C File Offset: 0x0010EC3C
	private void 24(object 1, EventArgs 2)
	{
		this.6.13(true, false);
	}

	// Token: 0x06003018 RID: 12312 RVA: 0x00110A6C File Offset: 0x0010EC6C
	private void 25()
	{
		this.20 = new Button();
		this.21 = new Button();
		this.19 = new DomainUpDown();
		this.18 = new Label();
		this.17 = new Label();
		this.16 = new NumericUpDown();
		this.11 = new RadioButton();
		this.15 = new NumericUpDown();
		this.12 = new RadioButton();
		this.14 = new TrackBar();
		this.13 = new TrackBar();
		((ISupportInitialize)this.16).BeginInit();
		((ISupportInitialize)this.15).BeginInit();
		((ISupportInitialize)this.14).BeginInit();
		((ISupportInitialize)this.13).BeginInit();
		base.SuspendLayout();
		this.20.DialogResult = DialogResult.OK;
		this.20.FlatStyle = FlatStyle.System;
		this.20.Location = new Point(12, 138);
		this.20.Name = "btnOk";
		this.20.Size = new Size(170, 34);
		this.20.TabIndex = 8;
		this.20.Text = "OK";
		this.20.UseVisualStyleBackColor = true;
		this.20.Click += this.18;
		this.21.DialogResult = DialogResult.Cancel;
		this.21.FlatStyle = FlatStyle.System;
		this.21.Location = new Point(188, 138);
		this.21.Name = "btnCancel";
		this.21.Size = new Size(110, 34);
		this.21.TabIndex = 9;
		this.21.Text = "Cancel";
		this.21.UseVisualStyleBackColor = true;
		this.21.Click += this.19;
		this.19.Items.Add("1/1");
		this.19.Items.Add("1/2");
		this.19.Items.Add("1/3");
		this.19.Items.Add("1/4");
		this.19.Items.Add("1/6");
		this.19.Items.Add("1/8");
		this.19.Location = new Point(236, 102);
		this.19.Name = "domainBeatSnap";
		this.19.Size = new Size(50, 20);
		this.19.TabIndex = 7;
		this.19.Text = "fixme";
		this.19.SelectedItemChanged += this.22;
		this.18.AutoSize = true;
		this.18.Location = new Point(130, 104);
		this.18.Name = "label2";
		this.18.Size = new Size(99, 15);
		this.18.TabIndex = 8;
		this.18.Text = "Beat snap divisor:";
		this.17.AutoSize = true;
		this.17.Location = new Point(286, 54);
		this.17.Name = "label1";
		this.17.Size = new Size(12, 15);
		this.17.TabIndex = 7;
		this.17.Text = "x";
		this.16.DecimalPlaces = 2;
		this.16.Increment = new decimal(new int[]
		{
			1,
			0,
			0,
			65536
		});
		this.16.Location = new Point(236, 57);
		NumericUpDown numericUpDown = this.16;
		int[] array = new int[4];
		array[0] = 9;
		numericUpDown.Maximum = new decimal(array);
		this.16.Minimum = new decimal(new int[]
		{
			1,
			0,
			0,
			65536
		});
		this.16.Name = "numericDistanceSnap";
		this.16.Size = new Size(50, 20);
		this.16.TabIndex = 6;
		this.16.Value = new decimal(new int[]
		{
			10,
			0,
			0,
			65536
		});
		this.16.ValueChanged += this.17;
		this.16.MouseCaptureChanged += this.24;
		this.11.AutoSize = true;
		this.11.FlatStyle = FlatStyle.System;
		this.11.Location = new Point(12, 12);
		this.11.Name = "radCount";
		this.11.Size = new Size(114, 20);
		this.11.TabIndex = 0;
		this.11.Text = "By object count";
		this.11.UseVisualStyleBackColor = true;
		this.11.CheckedChanged += delegate(object 1, EventArgs 2)
		{
			if (this.11.Checked)
			{
				this.12.Checked = false;
				this.13.Enabled = true;
				this.15.Enabled = true;
				this.14.Enabled = false;
				this.16.Enabled = false;
				this.20();
			}
		};
		this.15.Enabled = false;
		this.15.Location = new Point(236, 12);
		NumericUpDown numericUpDown2 = this.15;
		int[] array2 = new int[4];
		array2[0] = 1;
		numericUpDown2.Minimum = new decimal(array2);
		this.15.Name = "numericCount";
		this.15.Size = new Size(50, 20);
		this.15.TabIndex = 4;
		NumericUpDown numericUpDown3 = this.15;
		int[] array3 = new int[4];
		array3[0] = 5;
		numericUpDown3.Value = new decimal(array3);
		this.15.ValueChanged += delegate(object 1, EventArgs 2)
		{
			if (!this.8)
			{
				this.8 = true;
				this.14(this.13, (int)this.15.Value);
				this.8 = false;
				this.20();
				this.6.13(true, false);
			}
		};
		this.15.MouseCaptureChanged += this.24;
		this.12.AutoSize = true;
		this.12.Checked = true;
		this.12.FlatStyle = FlatStyle.System;
		this.12.Location = new Point(12, 57);
		this.12.Name = "radDistanceSnap";
		this.12.Size = new Size(119, 20);
		this.12.TabIndex = 1;
		this.12.TabStop = true;
		this.12.Text = "By distance snap";
		this.12.UseVisualStyleBackColor = true;
		this.12.CheckedChanged += this.13;
		this.14.Location = new Point(125, 52);
		this.14.Maximum = 500;
		this.14.Minimum = 10;
		this.14.Name = "trackDistanceSnap";
		this.14.Size = new Size(104, 45);
		this.14.TabIndex = 5;
		this.14.TickFrequency = 50;
		this.14.Value = 100;
		this.14.Scroll += delegate(object 1, EventArgs 2)
		{
			if (!this.8)
			{
				this.8 = true;
				this.15(this.16, this.14.Value * 0.01m);
				this.8 = false;
				this.20();
			}
		};
		this.14.MouseCaptureChanged += this.24;
		this.13.Enabled = false;
		this.13.LargeChange = 4;
		this.13.Location = new Point(125, 7);
		this.13.Maximum = 17;
		this.13.Minimum = 1;
		this.13.Name = "trackCount";
		this.13.Size = new Size(104, 45);
		this.13.TabIndex = 3;
		this.13.TickFrequency = 4;
		this.13.Value = 5;
		this.13.ValueChanged += this.16;
		this.13.MouseCaptureChanged += this.24;
		base.AcceptButton = this.20;
		base.AutoScaleDimensions = new SizeF(96f, 96f);
		base.AutoScaleMode = AutoScaleMode.Dpi;
		base.CancelButton = this.21;
		base.ClientSize = new Size(310, 184);
		base.Controls.Add(this.21);
		base.Controls.Add(this.20);
		base.Controls.Add(this.19);
		base.Controls.Add(this.18);
		base.Controls.Add(this.17);
		base.Controls.Add(this.16);
		base.Controls.Add(this.11);
		base.Controls.Add(this.15);
		base.Controls.Add(this.12);
		base.Controls.Add(this.14);
		base.Controls.Add(this.13);
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "ConvertToStream";
		base.Opacity = 1.0;
		this.Text = "Convert slider to stream";
		base.FormClosing += this.23;
		((ISupportInitialize)this.16).EndInit();
		((ISupportInitialize)this.15).EndInit();
		((ISupportInitialize)this.14).EndInit();
		((ISupportInitialize)this.13).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	// Token: 0x0400229B RID: 8859
	private 2263 6;

	// Token: 0x0400229C RID: 8860
	private new 2123 7;

	// Token: 0x0400229D RID: 8861
	private new bool 8;

	// Token: 0x0400229E RID: 8862
	private double 9;

	// Token: 0x040022A0 RID: 8864
	private new RadioButton 11;

	// Token: 0x040022A1 RID: 8865
	private new RadioButton 12;

	// Token: 0x040022A2 RID: 8866
	private TrackBar 13;

	// Token: 0x040022A3 RID: 8867
	private TrackBar 14;

	// Token: 0x040022A4 RID: 8868
	private NumericUpDown 15;

	// Token: 0x040022A5 RID: 8869
	private NumericUpDown 16;

	// Token: 0x040022A6 RID: 8870
	private Label 17;

	// Token: 0x040022A7 RID: 8871
	private Label 18;

	// Token: 0x040022A8 RID: 8872
	private DomainUpDown 19;

	// Token: 0x040022A9 RID: 8873
	private Button 20;

	// Token: 0x040022AA RID: 8874
	private Button 21;
}
