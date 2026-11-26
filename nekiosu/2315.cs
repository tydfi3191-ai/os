using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

// Token: 0x0200063C RID: 1596
public sealed partial class 2315 : 1488
{
	// Token: 0x06003055 RID: 12373 RVA: 0x00113B55 File Offset: 0x00111D55
	public 2315()
	{
		this.26();
	}

	// Token: 0x06003056 RID: 12374 RVA: 0x00113B74 File Offset: 0x00111D74
	private double 13()
	{
		double <<EMPTY_NAME>> = (double)this.12.Value / 10.0;
		int num = (int)this.22.Value;
		float num2 = 1052.15((float)this.16.Value);
		double 2 = 1226.88((double)this.6.104(), false) / (double)this.6.96();
		double sliderVelocityAt = this.6.74.4.GetSliderVelocityAt(1226.16);
		double 3 = 2263.91(<<EMPTY_NAME>>, sliderVelocityAt, 2);
		double num3 = 1052.29(3, num);
		208 4 = this.6.74.81(true);
		for (int i = 0; i < num; i++)
		{
			208 5 = 1052.31(num3, num, 4, (double)num2, i);
			if (!1662.69.24(5))
			{
				double num4 = (double)208.Distance(this.16(5, 4), 4);
				if (num4 < num3)
				{
					num3 = num4;
					3 = 1052.30(num3, num);
				}
			}
		}
		return 2263.92(3, sliderVelocityAt, 2);
	}

	// Token: 0x06003057 RID: 12375 RVA: 0x00113C7C File Offset: 0x00111E7C
	private bool 14()
	{
		double <<EMPTY_NAME>> = (double)this.12.Value / 10.0;
		int num = (int)this.22.Value;
		float num2 = 1052.15((float)this.16.Value);
		double 2 = 1226.88((double)this.6.104(), false) / (double)this.6.96();
		double sliderVelocityAt = this.6.74.4.GetSliderVelocityAt(1226.16);
		double 3 = 1052.29(2263.91(<<EMPTY_NAME>>, sliderVelocityAt, 2), num);
		208 4 = this.6.74.81(true);
		for (int i = 0; i < num; i++)
		{
			208 5 = 1052.31(3, num, 4, (double)num2, i);
			if (!1662.69.24(5))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06003058 RID: 12376 RVA: 0x00113D50 File Offset: 0x00111F50
	protected override void OnShown(EventArgs 1)
	{
		this.6 = 2263.4;
		this.6.57();
		this.6.8.19((2452)0, null);
		this.6.8.17 = false;
		this.22.Select();
		this.7 = 1304.138.GetValue();
		this.25();
		this.7 = -1.0;
		this.6.74.ClearSelection();
		this.6.74.63((2255.2257)0);
		this.6.2(false);
		this.6.8.17 = true;
		base.OnShown(1);
		this.17();
		if (this.6.85)
		{
			this.6.87 = true;
		}
	}

	// Token: 0x06003059 RID: 12377 RVA: 0x00113E32 File Offset: 0x00112032
	private double 15(TrackBar 1, double 2)
	{
		return 1052.20(2, (double)1.Minimum, (double)1.Maximum);
	}

	// Token: 0x0600305A RID: 12378 RVA: 0x00113E48 File Offset: 0x00112048
	private 208 16(208 1, 208 2)
	{
		1051 3 = new 1051(1, 2);
		1051 4;
		if (1.X < 0f)
		{
			4 = new 1051(208.Zero, new 208(0f, 384f));
		}
		else if (1.X > 512f)
		{
			4 = new 1051(new 208(512f, 0f), new 208(512f, 384f));
		}
		else if (1.Y < 0f)
		{
			4 = new 1051(208.Zero, new 208(512f, 0f));
		}
		else
		{
			if (1.Y <= 384f)
			{
				return 1;
			}
			4 = new 1051(new 208(0f, 384f), new 208(512f, 384f));
		}
		return 1052.32(3, 4);
	}

	// Token: 0x0600305B RID: 12379 RVA: 0x00113F20 File Offset: 0x00112120
	private void 17()
	{
		this.8 = this.22.Value;
		this.6.74.61((int)this.22.Value, (int)this.21.Value, (double)1052.15((float)this.16.Value), (double)this.12.Value / 10.0);
	}

	// Token: 0x0600305C RID: 12380 RVA: 0x00110789 File Offset: 0x0010E989
	private void 18(object 1, EventArgs 2)
	{
		base.Close();
	}

	// Token: 0x0600305D RID: 12381 RVA: 0x00113F97 File Offset: 0x00112197
	private void 19(object 1, EventArgs 2)
	{
		this.6.8.20(true, true);
	}

	// Token: 0x0600305E RID: 12382 RVA: 0x00113FAC File Offset: 0x001121AC
	private void 20(object 1, EventArgs 2)
	{
		if (!this.9)
		{
			this.12.Value = (int)this.15(this.12, Math.Min(this.13() * 10.0, (double)this.12.Value));
			this.17();
		}
	}

	// Token: 0x0600305F RID: 12383 RVA: 0x00114000 File Offset: 0x00112200
	private void 21(object 1, EventArgs 2)
	{
		this.17.Text = string.Format("{0:0.0#}×", (double)this.12.Value / 10.0);
	}

	// Token: 0x06003060 RID: 12384 RVA: 0x00114032 File Offset: 0x00112232
	private void 22(object 1, EventArgs 2)
	{
		this.7 = -1.0;
	}

	// Token: 0x06003061 RID: 12385 RVA: 0x00114043 File Offset: 0x00112243
	private void 23(object 1, EventArgs 2)
	{
		this.17();
		this.6.87 = true;
	}

	// Token: 0x06003062 RID: 12386 RVA: 0x00114058 File Offset: 0x00112258
	private void 24(object 1, EventArgs 2)
	{
		if (!this.9)
		{
			if (!this.14())
			{
				this.9 = true;
				this.22.Value = this.8;
				this.9 = false;
				return;
			}
			this.17();
			this.6.87 = true;
		}
	}

	// Token: 0x06003063 RID: 12387 RVA: 0x001140A8 File Offset: 0x001122A8
	private void 25()
	{
		if (this.7 == -1.0)
		{
			this.7 = (double)this.12.Value / 10.0;
		}
		else
		{
			this.12.Value = (int)(this.7 * 10.0);
		}
		this.12.Value = (int)this.15(this.12, Math.Min(this.13() * 10.0, (double)this.12.Value));
	}

	// Token: 0x06003065 RID: 12389 RVA: 0x00114158 File Offset: 0x00112358
	private void 26()
	{
		this.11 = new Button();
		this.12 = new TrackBar();
		base.AcceptButton = (this.13 = new Button());
		this.14 = new Label();
		this.15 = new Label();
		this.16 = new TrackBar();
		this.17 = new Label();
		this.18 = new Label();
		this.19 = new Label();
		this.20 = new Label();
		this.21 = new NumericUpDown();
		this.22 = new NumericUpDown();
		this.23 = new Label();
		((ISupportInitialize)this.12).BeginInit();
		((ISupportInitialize)this.16).BeginInit();
		((ISupportInitialize)this.21).BeginInit();
		((ISupportInitialize)this.22).BeginInit();
		base.SuspendLayout();
		this.11.DialogResult = DialogResult.Cancel;
		this.11.Location = new Point(242, 163);
		this.11.Name = "btnCancel";
		this.11.Size = new Size(95, 34);
		this.11.TabIndex = 15;
		this.11.Text = "Cancel";
		this.11.UseVisualStyleBackColor = true;
		this.11.Click += this.19;
		this.12.Location = new Point(138, 40);
		this.12.Maximum = (int)1304.138.3() * 10;
		this.12.Minimum = 1;
		this.12.Name = "trDS";
		this.12.Size = new Size(205, 45);
		this.12.TabIndex = 1;
		this.12.Value = 1;
		this.12.ValueChanged += this.21;
		this.12.Scroll += this.20;
		this.13.Location = new Point(10, 163);
		this.13.Name = "btnOk";
		this.13.Size = new Size(226, 34);
		this.13.TabIndex = 14;
		this.13.Text = "OK";
		this.13.UseVisualStyleBackColor = true;
		this.13.Click += this.18;
		this.14.AutoSize = true;
		this.14.Location = new Point(12, 45);
		this.14.Name = "lblDS";
		this.14.Size = new Size(89, 17);
		this.14.TabIndex = 22;
		this.14.Text = "Distance snap";
		this.15.AutoSize = true;
		this.15.Location = new Point(12, 81);
		this.15.Name = "lblOffset";
		this.15.Size = new Size(79, 17);
		this.15.TabIndex = 23;
		this.15.Text = "Offset angle";
		this.16.Location = new Point(138, 77);
		this.16.Maximum = 180;
		this.16.Name = "trAngle";
		this.16.Size = new Size(205, 45);
		this.16.TabIndex = 24;
		this.16.TickFrequency = 45;
		this.16.Scroll += delegate(object 1, EventArgs 2)
		{
			if (!this.9)
			{
				this.25();
				this.18.Text = string.Format("{0}°", this.16.Value);
				this.17();
			}
		};
		this.16.MouseUp += new MouseEventHandler(this.22);
		this.17.AutoSize = true;
		this.17.Location = new Point(110, 46);
		this.17.Name = "lblDSVal";
		this.17.Size = new Size(15, 17);
		this.17.TabIndex = 25;
		this.17.Text = string.Format("{0:0.0#}×", (double)this.12.Value / 10.0);
		this.18.AutoSize = true;
		this.18.Location = new Point(110, 81);
		this.18.Name = "lblAngleVal";
		this.18.Size = new Size(20, 17);
		this.18.TabIndex = 26;
		this.18.Text = "0°";
		this.19.AutoSize = true;
		this.19.Location = new Point(27, 127);
		this.19.Name = "lblRepeat";
		this.19.Size = new Size(49, 17);
		this.19.TabIndex = 27;
		this.19.Text = "Repeat";
		this.20.AutoSize = true;
		this.20.Location = new Point(186, 127);
		this.20.Name = "lblEdge";
		this.20.Size = new Size(43, 17);
		this.20.TabIndex = 28;
		this.20.Text = "Points";
		this.21.Location = new Point(76, 124);
		NumericUpDown numericUpDown = this.21;
		int[] array = new int[4];
		array[0] = 10;
		numericUpDown.Maximum = new decimal(array);
		NumericUpDown numericUpDown2 = this.21;
		int[] array2 = new int[4];
		array2[0] = 1;
		numericUpDown2.Minimum = new decimal(array2);
		this.21.Name = "nudRepeat";
		this.21.Size = new Size(62, 21);
		this.21.TabIndex = 29;
		this.21.TextAlign = HorizontalAlignment.Center;
		NumericUpDown numericUpDown3 = this.21;
		int[] array3 = new int[4];
		array3[0] = 1;
		numericUpDown3.Value = new decimal(array3);
		this.21.ValueChanged += this.23;
		this.22.Location = new Point(253, 125);
		this.22.Minimum = 3m;
		this.22.Name = "nudCount";
		this.22.Size = new Size(77, 21);
		this.22.TabIndex = 30;
		this.22.TextAlign = HorizontalAlignment.Center;
		NumericUpDown numericUpDown4 = this.22;
		int[] array4 = new int[4];
		array4[0] = 3;
		numericUpDown4.Value = new decimal(array4);
		this.22.ValueChanged += this.24;
		this.23.AutoSize = true;
		this.23.Location = new Point(15, 13);
		this.23.Name = "label1";
		this.23.Size = new Size(300, 17);
		this.23.TabIndex = 31;
		this.23.Text = "Try smaller distance snap if you need more points";
		base.AutoScaleDimensions = new SizeF(96f, 96f);
		base.AutoScaleMode = AutoScaleMode.Dpi;
		base.ClientSize = new Size(349, 213);
		base.Controls.Add(this.23);
		base.Controls.Add(this.22);
		base.Controls.Add(this.21);
		base.Controls.Add(this.20);
		base.Controls.Add(this.19);
		base.Controls.Add(this.18);
		base.Controls.Add(this.17);
		base.Controls.Add(this.15);
		base.Controls.Add(this.14);
		base.Controls.Add(this.11);
		base.Controls.Add(this.13);
		base.Controls.Add(this.16);
		base.Controls.Add(this.12);
		base.FormBorderStyle = FormBorderStyle.FixedSingle;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "Polygon";
		base.ShowIcon = false;
		base.ShowInTaskbar = false;
		base.SizeGripStyle = SizeGripStyle.Hide;
		base.StartPosition = FormStartPosition.CenterParent;
		this.Text = "Polygonal Circle Creation";
		base.TopMost = true;
		base.FormClosing += delegate(object 1, FormClosingEventArgs 2)
		{
			if (this.6.85)
			{
				this.6.87 = true;
				this.6.2(true);
				return;
			}
			this.6.8.20(false, false);
		};
		((ISupportInitialize)this.12).EndInit();
		((ISupportInitialize)this.16).EndInit();
		((ISupportInitialize)this.21).EndInit();
		((ISupportInitialize)this.22).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	// Token: 0x040022E3 RID: 8931
	private 2263 6;

	// Token: 0x040022E4 RID: 8932
	private new double 7 = -1.0;

	// Token: 0x040022E5 RID: 8933
	private new decimal 8;

	// Token: 0x040022E6 RID: 8934
	private bool 9;

	// Token: 0x040022E8 RID: 8936
	private new Button 11;

	// Token: 0x040022E9 RID: 8937
	private new TrackBar 12;

	// Token: 0x040022EA RID: 8938
	private Button 13;

	// Token: 0x040022EB RID: 8939
	private Label 14;

	// Token: 0x040022EC RID: 8940
	private Label 15;

	// Token: 0x040022ED RID: 8941
	private TrackBar 16;

	// Token: 0x040022EE RID: 8942
	private Label 17;

	// Token: 0x040022EF RID: 8943
	private Label 18;

	// Token: 0x040022F0 RID: 8944
	private Label 19;

	// Token: 0x040022F1 RID: 8945
	private Label 20;

	// Token: 0x040022F2 RID: 8946
	private NumericUpDown 21;

	// Token: 0x040022F3 RID: 8947
	private NumericUpDown 22;

	// Token: 0x040022F4 RID: 8948
	private Label 23;
}
