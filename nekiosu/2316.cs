using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

// Token: 0x0200063D RID: 1597
public sealed partial class 2316 : 1488
{
	// Token: 0x06003068 RID: 12392 RVA: 0x00114AAC File Offset: 0x00112CAC
	public 2316()
	{
		this.19();
	}

	// Token: 0x06003069 RID: 12393 RVA: 0x00114ABC File Offset: 0x00112CBC
	protected override void OnShown(EventArgs 1)
	{
		this.6 = 2263.4;
		this.6.57();
		this.6.8.16((2452)0, (2451)25, (2450)16, null);
		this.6.8.24<2034>(this.6.74.44, false);
		this.13.SelectAll();
		base.OnShown(1);
	}

	// Token: 0x0600306A RID: 12394 RVA: 0x00114B30 File Offset: 0x00112D30
	private void 13()
	{
		int num;
		if (int.TryParse(this.13.Text, out num))
		{
			this.6.74.78(-this.7, this.8);
			this.7 = ((!this.16.Checked) ? 1 : -1) * num;
			this.8 = this.19.Checked;
			this.6.74.78(this.7, this.8);
		}
	}

	// Token: 0x0600306B RID: 12395 RVA: 0x00114BB4 File Offset: 0x00112DB4
	private void 14(object 1, EventArgs 2)
	{
		int num = 0;
		bool flag = int.TryParse(this.13.Text, out num);
		this.11.Enabled = flag;
		if (flag && num >= -180 && num <= 180)
		{
			this.21.Value = num;
		}
		this.13();
	}

	// Token: 0x0600306C RID: 12396 RVA: 0x00114C07 File Offset: 0x00112E07
	private void 15(object 1, EventArgs 2)
	{
		this.20.Checked = !this.19.Checked;
		this.13();
	}

	// Token: 0x0600306D RID: 12397 RVA: 0x00114C28 File Offset: 0x00112E28
	private void 16(object 1, EventArgs 2)
	{
		this.13();
		base.Close();
	}

	// Token: 0x0600306E RID: 12398 RVA: 0x00114C36 File Offset: 0x00112E36
	private void 17(object 1, EventArgs 2)
	{
		this.6.8.20(true, true);
	}

	// Token: 0x0600306F RID: 12399 RVA: 0x00114C4A File Offset: 0x00112E4A
	private void 18(object 1, FormClosingEventArgs 2)
	{
		this.6.8.20(false, false);
	}

	// Token: 0x06003071 RID: 12401 RVA: 0x00114C80 File Offset: 0x00112E80
	private void 19()
	{
		this.10 = new Button();
		this.11 = new Button();
		this.12 = new Label();
		this.13 = new TextBox();
		this.14 = new Label();
		this.15 = new RadioButton();
		this.16 = new RadioButton();
		this.17 = new GroupBox();
		this.18 = new GroupBox();
		this.19 = new RadioButton();
		this.20 = new RadioButton();
		this.21 = new TrackBar();
		this.17.SuspendLayout();
		this.18.SuspendLayout();
		((ISupportInitialize)this.21).BeginInit();
		base.SuspendLayout();
		this.10.DialogResult = DialogResult.Cancel;
		this.10.Location = new Point(202, 155);
		this.10.Name = "btnCancel";
		this.10.Size = new Size(86, 34);
		this.10.TabIndex = 2;
		this.10.Text = "Cancel";
		this.10.UseVisualStyleBackColor = true;
		this.10.Click += this.17;
		this.11.Location = new Point(12, 155);
		this.11.Name = "btnOk";
		this.11.Size = new Size(182, 34);
		this.11.TabIndex = 1;
		this.11.Text = "OK";
		this.11.UseVisualStyleBackColor = true;
		this.11.Click += this.16;
		this.12.AutoSize = true;
		this.12.Location = new Point(22, 11);
		this.12.Name = "lblRotate";
		this.12.Size = new Size(162, 14);
		this.12.TabIndex = 5;
		this.12.Text = "Enter an angle to rotate by:";
		this.13.Location = new Point(200, 31);
		this.13.Name = "angle";
		this.13.Size = new Size(48, 20);
		this.13.TabIndex = 0;
		this.13.Text = "0";
		this.13.TextChanged += this.14;
		this.14.AutoSize = true;
		this.14.Location = new Point(250, 32);
		this.14.Name = "lblDegree";
		this.14.Size = new Size(13, 14);
		this.14.TabIndex = 7;
		this.14.Text = "°";
		this.15.AutoSize = true;
		this.15.Checked = true;
		this.15.Location = new Point(15, 20);
		this.15.Name = "radClockwise";
		this.15.Size = new Size(77, 18);
		this.15.TabIndex = 8;
		this.15.TabStop = true;
		this.15.Text = "Clockwise";
		this.15.UseVisualStyleBackColor = true;
		this.15.CheckedChanged += delegate(object 1, EventArgs 2)
		{
			this.16.Checked = !this.15.Checked;
			this.13();
		};
		this.16.AutoSize = true;
		this.16.Location = new Point(15, 41);
		this.16.Name = "radAnticlockwise";
		this.16.Size = new Size(103, 18);
		this.16.TabIndex = 9;
		this.16.Text = "Anti-Clockwise";
		this.16.UseVisualStyleBackColor = true;
		this.17.Controls.Add(this.15);
		this.17.Controls.Add(this.16);
		this.17.Location = new Point(12, 76);
		this.17.Name = "gbDirection";
		this.17.Size = new Size(132, 73);
		this.17.TabIndex = 10;
		this.17.TabStop = false;
		this.17.Text = "Direction";
		this.18.Controls.Add(this.19);
		this.18.Controls.Add(this.20);
		this.18.Location = new Point(154, 76);
		this.18.Name = "gbOrigin";
		this.18.Size = new Size(134, 73);
		this.18.TabIndex = 11;
		this.18.TabStop = false;
		this.18.Text = "Origin";
		this.19.AutoSize = true;
		this.19.Checked = true;
		this.19.Location = new Point(15, 20);
		this.19.Name = "radPlayfield";
		this.19.Size = new Size(109, 18);
		this.19.TabIndex = 8;
		this.19.TabStop = true;
		this.19.Text = "Playfield Centre";
		this.19.UseVisualStyleBackColor = true;
		this.19.CheckedChanged += this.15;
		this.20.AutoSize = true;
		this.20.Location = new Point(15, 41);
		this.20.Name = "radSelection";
		this.20.Size = new Size(116, 18);
		this.20.TabIndex = 9;
		this.20.Text = "Selection Centre";
		this.20.UseVisualStyleBackColor = true;
		this.21.LargeChange = 45;
		this.21.Location = new Point(20, 30);
		this.21.Maximum = 180;
		this.21.Minimum = -180;
		this.21.Name = "trRotate";
		this.21.Size = new Size(174, 42);
		this.21.TabIndex = 12;
		this.21.TickFrequency = 45;
		this.21.Scroll += delegate(object 1, EventArgs 2)
		{
			this.13.Text = this.21.Value.ToString();
		};
		base.AcceptButton = this.11;
		base.AutoScaleDimensions = new SizeF(96f, 96f);
		base.AutoScaleMode = AutoScaleMode.Dpi;
		base.CancelButton = this.10;
		base.ClientSize = new Size(297, 201);
		base.Controls.Add(this.21);
		base.Controls.Add(this.18);
		base.Controls.Add(this.17);
		base.Controls.Add(this.14);
		base.Controls.Add(this.13);
		base.Controls.Add(this.12);
		base.Controls.Add(this.10);
		base.Controls.Add(this.11);
		base.FormBorderStyle = FormBorderStyle.FixedSingle;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "RotateBy";
		base.ShowIcon = false;
		base.ShowInTaskbar = false;
		base.SizeGripStyle = SizeGripStyle.Hide;
		base.StartPosition = FormStartPosition.CenterParent;
		this.Text = "Rotate by";
		base.FormClosing += this.18;
		this.17.ResumeLayout(false);
		this.17.PerformLayout();
		this.18.ResumeLayout(false);
		this.18.PerformLayout();
		((ISupportInitialize)this.21).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	// Token: 0x040022F5 RID: 8949
	private 2263 6;

	// Token: 0x040022F6 RID: 8950
	private new int 7;

	// Token: 0x040022F7 RID: 8951
	private new bool 8;

	// Token: 0x040022F9 RID: 8953
	private Button 10;

	// Token: 0x040022FA RID: 8954
	private new Button 11;

	// Token: 0x040022FB RID: 8955
	private new Label 12;

	// Token: 0x040022FC RID: 8956
	private TextBox 13;

	// Token: 0x040022FD RID: 8957
	private Label 14;

	// Token: 0x040022FE RID: 8958
	private RadioButton 15;

	// Token: 0x040022FF RID: 8959
	private RadioButton 16;

	// Token: 0x04002300 RID: 8960
	private GroupBox 17;

	// Token: 0x04002301 RID: 8961
	private GroupBox 18;

	// Token: 0x04002302 RID: 8962
	private RadioButton 19;

	// Token: 0x04002303 RID: 8963
	private RadioButton 20;

	// Token: 0x04002304 RID: 8964
	private TrackBar 21;
}
