using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

// Token: 0x02000640 RID: 1600
public sealed partial class 2318 : 1488
{
	// Token: 0x06003088 RID: 12424 RVA: 0x001164B8 File Offset: 0x001146B8
	public 2318()
	{
		this.14();
	}

	// Token: 0x06003089 RID: 12425 RVA: 0x001164C8 File Offset: 0x001146C8
	protected override void OnShown(EventArgs 1)
	{
		this.6 = 2263.4;
		foreach (2654 2 in this.6.6.15)
		{
			this.8.Items.Add(2);
			if (2.8 == 1226.16)
			{
				this.8.SetSelected(this.8.Items.Count - 1, true);
			}
		}
		base.OnShown(1);
	}

	// Token: 0x0600308A RID: 12426 RVA: 0x00110789 File Offset: 0x0010E989
	private void 13(object 1, EventArgs 2)
	{
		base.Close();
	}

	// Token: 0x0600308C RID: 12428 RVA: 0x00116590 File Offset: 0x00114790
	private void 14()
	{
		this.8 = new ListBox();
		this.9 = new Button();
		this.10 = new Button();
		base.SuspendLayout();
		this.8.FormattingEnabled = true;
		this.8.ItemHeight = 12;
		this.8.Location = new Point(12, 12);
		this.8.Name = "lb_sample";
		this.8.SelectionMode = SelectionMode.MultiExtended;
		this.8.Size = new Size(262, 328);
		this.8.TabIndex = 17;
		this.9.DialogResult = DialogResult.Cancel;
		this.9.Location = new Point(187, 350);
		this.9.Name = "b_close";
		this.9.Size = new Size(87, 30);
		this.9.TabIndex = 18;
		this.9.Text = "Close";
		this.9.UseVisualStyleBackColor = true;
		this.9.Click += this.13;
		this.10.DialogResult = DialogResult.Cancel;
		this.10.Location = new Point(12, 350);
		this.10.Name = "b_del";
		this.10.Size = new Size(159, 30);
		this.10.TabIndex = 19;
		this.10.Text = "Delete";
		this.10.UseVisualStyleBackColor = true;
		this.10.Click += delegate(object 1, EventArgs 2)
		{
			if (this.8.SelectedItems != null && this.8.SelectedItems.Count != 0)
			{
				this.6.8.15((2452)2, (2451)9, null);
				foreach (object obj in this.8.SelectedItems)
				{
					2654 3 = (2654)obj;
					this.6.8.23(3, false);
					this.6.6.12(3);
				}
				this.6.8.20(false, false);
			}
		};
		base.AutoScaleDimensions = new SizeF(96f, 96f);
		base.AutoScaleMode = AutoScaleMode.Dpi;
		base.CancelButton = this.9;
		base.ClientSize = new Size(286, 392);
		base.Controls.Add(this.10);
		base.Controls.Add(this.9);
		base.Controls.Add(this.8);
		base.FormBorderStyle = FormBorderStyle.FixedSingle;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "SampleList";
		base.ShowIcon = false;
		base.ShowInTaskbar = false;
		base.StartPosition = FormStartPosition.CenterParent;
		this.Text = "Sample events list";
		base.ResumeLayout(false);
	}

	// Token: 0x0400231D RID: 8989
	private 2263 6;

	// Token: 0x0400231F RID: 8991
	private new ListBox 8;

	// Token: 0x04002320 RID: 8992
	private Button 9;

	// Token: 0x04002321 RID: 8993
	private Button 10;
}
