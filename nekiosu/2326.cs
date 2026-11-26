using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

// Token: 0x0200064A RID: 1610
public sealed partial class 2326 : 1488
{
	// Token: 0x06003147 RID: 12615 RVA: 0x00126DC7 File Offset: 0x00124FC7
	public 2326()
	{
		this.14();
	}

	// Token: 0x06003148 RID: 12616 RVA: 0x00126DD8 File Offset: 0x00124FD8
	protected override void OnShown(EventArgs 1)
	{
		this.7.Value = 1226.38.6();
		this.12.Value = 1226.36.6();
		this.9.Text = 1226.38.6().ToString();
		this.10.Text = 1226.36.6().ToString();
		base.OnShown(1);
	}

	// Token: 0x06003149 RID: 12617 RVA: 0x00126E50 File Offset: 0x00125050
	private void 13(object 1, EventArgs 2)
	{
		this.10.Text = this.12.Value.ToString();
		1226.36.7(this.12.Value);
	}

	// Token: 0x0600314B RID: 12619 RVA: 0x00126EB0 File Offset: 0x001250B0
	private void 14()
	{
		this.7 = new TrackBar();
		this.8 = new Label();
		this.9 = new Label();
		this.10 = new Label();
		this.11 = new Label();
		this.12 = new TrackBar();
		((ISupportInitialize)this.7).BeginInit();
		((ISupportInitialize)this.12).BeginInit();
		base.SuspendLayout();
		this.7.Location = new Point(51, 12);
		this.7.Maximum = 100;
		this.7.Name = "tr_music";
		this.7.Size = new Size(240, 45);
		this.7.TabIndex = 0;
		this.7.TickStyle = TickStyle.None;
		this.7.Scroll += delegate(object 1, EventArgs 2)
		{
			this.9.Text = this.7.Value.ToString();
			1226.38.7(this.7.Value);
		};
		this.8.AutoSize = true;
		this.8.Location = new Point(8, 17);
		this.8.Name = "label1";
		this.8.Size = new Size(35, 12);
		this.8.TabIndex = 1;
		this.8.Text = "Music";
		this.9.AutoSize = true;
		this.9.Location = new Point(296, 17);
		this.9.Name = "lb_music";
		this.9.Size = new Size(11, 12);
		this.9.TabIndex = 2;
		this.9.Text = "0";
		this.10.AutoSize = true;
		this.10.Location = new Point(296, 52);
		this.10.Name = "lb_sample";
		this.10.Size = new Size(11, 12);
		this.10.TabIndex = 5;
		this.10.Text = "0";
		this.11.AutoSize = true;
		this.11.Location = new Point(7, 52);
		this.11.Name = "label4";
		this.11.Size = new Size(41, 12);
		this.11.TabIndex = 4;
		this.11.Text = "Sample";
		this.12.Location = new Point(51, 47);
		this.12.Maximum = 100;
		this.12.Name = "tr_sample";
		this.12.Size = new Size(240, 45);
		this.12.TabIndex = 3;
		this.12.TickStyle = TickStyle.None;
		this.12.Scroll += this.13;
		base.AutoScaleDimensions = new SizeF(96f, 96f);
		base.AutoScaleMode = AutoScaleMode.Dpi;
		base.ClientSize = new Size(324, 89);
		base.Controls.Add(this.10);
		base.Controls.Add(this.11);
		base.Controls.Add(this.12);
		base.Controls.Add(this.9);
		base.Controls.Add(this.8);
		base.Controls.Add(this.7);
		base.FormBorderStyle = FormBorderStyle.FixedSingle;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "VolumeDialog";
		base.ShowIcon = false;
		base.ShowInTaskbar = false;
		base.StartPosition = FormStartPosition.CenterParent;
		this.Text = "Volume";
		((ISupportInitialize)this.7).EndInit();
		((ISupportInitialize)this.12).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	// Token: 0x04002453 RID: 9299
	private new TrackBar 7;

	// Token: 0x04002454 RID: 9300
	private new Label 8;

	// Token: 0x04002455 RID: 9301
	private Label 9;

	// Token: 0x04002456 RID: 9302
	private Label 10;

	// Token: 0x04002457 RID: 9303
	private new Label 11;

	// Token: 0x04002458 RID: 9304
	private new TrackBar 12;
}
