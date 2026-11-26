using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

// Token: 0x02000636 RID: 1590
public sealed partial class 2310 : 1488
{
	// Token: 0x06003037 RID: 12343 RVA: 0x00112926 File Offset: 0x00110B26
	public 2310()
	{
		this.18();
	}

	// Token: 0x06003038 RID: 12344 RVA: 0x00112934 File Offset: 0x00110B34
	protected override void OnShown(EventArgs 1)
	{
		this.6 = 2263.4;
		this.10.SelectAll();
		base.OnShown(1);
	}

	// Token: 0x06003039 RID: 12345 RVA: 0x00112953 File Offset: 0x00110B53
	private void 13(object 1, EventArgs 2)
	{
		this.14();
		base.Close();
	}

	// Token: 0x0600303A RID: 12346 RVA: 0x00112964 File Offset: 0x00110B64
	private void 14()
	{
		int <<EMPTY_NAME>>;
		if (int.TryParse(this.10.Text, out <<EMPTY_NAME>>))
		{
			this.6.75.26(<<EMPTY_NAME>>);
		}
	}

	// Token: 0x0600303B RID: 12347 RVA: 0x00112998 File Offset: 0x00110B98
	private void 15(object 1, EventArgs 2)
	{
		int val = 0;
		bool flag = int.TryParse(this.10.Text, out val);
		this.12.Enabled = flag;
		if (flag)
		{
			this.11.Value = Math.Max(-60000, Math.Min(60000, val));
		}
	}

	// Token: 0x0600303C RID: 12348 RVA: 0x001129EC File Offset: 0x00110BEC
	private void 16(object 1, EventArgs 2)
	{
		this.10.Text = this.11.Value.ToString();
	}

	// Token: 0x0600303D RID: 12349 RVA: 0x00005ADD File Offset: 0x00003CDD
	private void 17(object 1, EventArgs 2)
	{
	}

	// Token: 0x0600303F RID: 12351 RVA: 0x00112A38 File Offset: 0x00110C38
	private void 18()
	{
		this.9 = new Label();
		this.10 = new TextBox();
		this.11 = new TrackBar();
		this.12 = new Button();
		this.13 = new Button();
		this.14 = new Label();
		((ISupportInitialize)this.11).BeginInit();
		base.SuspendLayout();
		this.9.AutoSize = true;
		this.9.Location = new Point(9, 9);
		this.9.Name = "label1";
		this.9.Size = new Size(241, 15);
		this.9.TabIndex = 5;
		this.9.Text = "Enter the number of milliseconds to shift by:";
		this.10.Location = new Point(187, 29);
		this.10.Name = "amount";
		this.10.Size = new Size(83, 20);
		this.10.TabIndex = 0;
		this.10.Text = "0";
		this.10.TextChanged += this.15;
		this.11.LargeChange = 45;
		this.11.Location = new Point(7, 28);
		this.11.Maximum = 60000;
		this.11.Minimum = -60000;
		this.11.Name = "trackBar1";
		this.11.Size = new Size(174, 45);
		this.11.TabIndex = 12;
		this.11.TickFrequency = 5000;
		this.11.Scroll += this.16;
		this.12.FlatStyle = FlatStyle.System;
		this.12.Location = new Point(12, 81);
		this.12.Name = "button1";
		this.12.Size = new Size(169, 34);
		this.12.TabIndex = 1;
		this.12.Text = "OK";
		this.12.UseVisualStyleBackColor = true;
		this.12.Click += this.13;
		this.13.DialogResult = DialogResult.Cancel;
		this.13.FlatStyle = FlatStyle.System;
		this.13.Location = new Point(187, 81);
		this.13.Name = "button2";
		this.13.Size = new Size(110, 34);
		this.13.TabIndex = 2;
		this.13.Text = "Cancel";
		this.13.UseVisualStyleBackColor = true;
		this.13.Click += this.17;
		this.14.AutoSize = true;
		this.14.Location = new Point(274, 33);
		this.14.Name = "label2";
		this.14.Size = new Size(23, 15);
		this.14.TabIndex = 7;
		this.14.Text = "ms";
		base.AcceptButton = this.12;
		base.AutoScaleDimensions = new SizeF(96f, 96f);
		base.AutoScaleMode = AutoScaleMode.Dpi;
		base.CancelButton = this.13;
		base.ClientSize = new Size(309, 127);
		base.Controls.Add(this.11);
		base.Controls.Add(this.14);
		base.Controls.Add(this.10);
		base.Controls.Add(this.9);
		base.Controls.Add(this.13);
		base.Controls.Add(this.12);
		base.FormBorderStyle = FormBorderStyle.FixedSingle;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "MoveEvents";
		base.ShowIcon = false;
		base.ShowInTaskbar = false;
		base.SizeGripStyle = SizeGripStyle.Hide;
		base.StartPosition = FormStartPosition.CenterParent;
		this.Text = "Move all events...";
		((ISupportInitialize)this.11).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	// Token: 0x040022C6 RID: 8902
	private 2263 6;

	// Token: 0x040022C7 RID: 8903
	private new int 7;

	// Token: 0x040022C9 RID: 8905
	private Label 9;

	// Token: 0x040022CA RID: 8906
	private TextBox 10;

	// Token: 0x040022CB RID: 8907
	private new TrackBar 11;

	// Token: 0x040022CC RID: 8908
	private new Button 12;

	// Token: 0x040022CD RID: 8909
	private Button 13;

	// Token: 0x040022CE RID: 8910
	private Label 14;
}
