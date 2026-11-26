using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

// Token: 0x02000637 RID: 1591
public sealed partial class 2311 : 1488
{
	// Token: 0x06003040 RID: 12352 RVA: 0x00112E8A File Offset: 0x0011108A
	public 2311()
	{
		this.18();
	}

	// Token: 0x06003041 RID: 12353 RVA: 0x00112E98 File Offset: 0x00111098
	protected override void OnShown(EventArgs 1)
	{
		this.6 = 2263.4;
		this.10.SelectAll();
		base.OnShown(1);
	}

	// Token: 0x06003042 RID: 12354 RVA: 0x00112EB8 File Offset: 0x001110B8
	private void 13()
	{
		int <<EMPTY_NAME>>;
		if (int.TryParse(this.10.Text, out <<EMPTY_NAME>>))
		{
			this.6.76.24(<<EMPTY_NAME>>);
		}
	}

	// Token: 0x06003043 RID: 12355 RVA: 0x00112EEC File Offset: 0x001110EC
	private void 14(object 1, EventArgs 2)
	{
		int val = 0;
		bool flag = int.TryParse(this.10.Text, out val);
		this.12.Enabled = flag;
		if (flag)
		{
			this.11.Value = Math.Max(-60000, Math.Min(60000, val));
		}
	}

	// Token: 0x06003044 RID: 12356 RVA: 0x00112F40 File Offset: 0x00111140
	private void 15(object 1, EventArgs 2)
	{
		this.10.Text = this.11.Value.ToString();
	}

	// Token: 0x06003045 RID: 12357 RVA: 0x00112F6B File Offset: 0x0011116B
	private void 16(object 1, EventArgs 2)
	{
		this.13();
		base.Close();
	}

	// Token: 0x06003046 RID: 12358 RVA: 0x00005ADD File Offset: 0x00003CDD
	private void 17(object 1, EventArgs 2)
	{
	}

	// Token: 0x06003048 RID: 12360 RVA: 0x00112F98 File Offset: 0x00111198
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
		this.9.Size = new Size(265, 17);
		this.9.TabIndex = 5;
		this.9.Text = "Enter the number of milliseconds to shift by:";
		this.10.Location = new Point(187, 29);
		this.10.Name = "amount";
		this.10.Size = new Size(83, 21);
		this.10.TabIndex = 0;
		this.10.Text = "0";
		this.10.TextChanged += this.14;
		this.11.LargeChange = 45;
		this.11.Location = new Point(7, 28);
		this.11.Maximum = 60000;
		this.11.Minimum = -60000;
		this.11.Name = "trOffset";
		this.11.Size = new Size(174, 45);
		this.11.TabIndex = 12;
		this.11.TickFrequency = 5000;
		this.11.Scroll += this.15;
		this.12.FlatStyle = FlatStyle.System;
		this.12.Location = new Point(12, 81);
		this.12.Name = "btnOk";
		this.12.Size = new Size(169, 34);
		this.12.TabIndex = 1;
		this.12.Text = "OK";
		this.12.UseVisualStyleBackColor = true;
		this.12.Click += this.16;
		this.13.DialogResult = DialogResult.Cancel;
		this.13.FlatStyle = FlatStyle.System;
		this.13.Location = new Point(187, 81);
		this.13.Name = "btnCancel";
		this.13.Size = new Size(110, 34);
		this.13.TabIndex = 2;
		this.13.Text = "Cancel";
		this.13.UseVisualStyleBackColor = true;
		this.13.Click += this.17;
		this.14.AutoSize = true;
		this.14.Location = new Point(274, 33);
		this.14.Name = "label2";
		this.14.Size = new Size(25, 17);
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
		base.Name = "MoveNotes";
		base.ShowIcon = false;
		base.ShowInTaskbar = false;
		base.SizeGripStyle = SizeGripStyle.Hide;
		base.StartPosition = FormStartPosition.CenterParent;
		this.Text = "Move all notes...";
		((ISupportInitialize)this.11).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	// Token: 0x040022CF RID: 8911
	private 2263 6;

	// Token: 0x040022D0 RID: 8912
	private new int 7;

	// Token: 0x040022D2 RID: 8914
	private Label 9;

	// Token: 0x040022D3 RID: 8915
	private TextBox 10;

	// Token: 0x040022D4 RID: 8916
	private new TrackBar 11;

	// Token: 0x040022D5 RID: 8917
	private new Button 12;

	// Token: 0x040022D6 RID: 8918
	private Button 13;

	// Token: 0x040022D7 RID: 8919
	private Label 14;
}
