using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

// Token: 0x02000634 RID: 1588
public sealed partial class 2308 : 1488
{
	// Token: 0x06003029 RID: 12329 RVA: 0x00111D60 File Offset: 0x0010FF60
	public 2308(string 1)
	{
		this.15();
		this.7.Text = 1;
		this.7.SelectAll();
		if (1143.2())
		{
			base.7(new EventHandler<2354>(this.13));
			this.Text = string.Empty;
			return;
		}
		base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
		this.8.Visible = false;
		this.7.Location = new Point(12, 12);
		base.ClientSize = new Size(base.ClientSize.Width, this.7.Height + 24);
		if (!Application.RenderWithVisualStyles)
		{
			this.BackColor = SystemColors.Control;
		}
	}

	// Token: 0x0600302A RID: 12330 RVA: 0x00111E15 File Offset: 0x00110015
	private void 13(object 1, 2354 2)
	{
		2.1 = (2355)1;
	}

	// Token: 0x0600302B RID: 12331 RVA: 0x00111E1E File Offset: 0x0011001E
	private void 14(object 1, KeyPressEventArgs 2)
	{
		if ((short)2.KeyChar == 27 || (short)2.KeyChar == 13)
		{
			base.Close();
		}
	}

	// Token: 0x0600302D RID: 12333 RVA: 0x00111E5C File Offset: 0x0011005C
	private void 15()
	{
		this.8 = new Label();
		this.7 = new TextBox();
		base.SuspendLayout();
		this.8.AutoSize = true;
		this.8.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
		this.8.Location = new Point(12, 10);
		this.8.Name = "label1";
		this.8.Size = new Size(259, 15);
		this.8.TabIndex = 5;
		this.8.Text = "Jump to time: [mm:ss:ms] (combonumbers,...)";
		this.7.Location = new Point(12, 30);
		this.7.Name = "time";
		this.7.Size = new Size(287, 20);
		this.7.TabIndex = 0;
		this.7.TextChanged += delegate(object 1, EventArgs 2)
		{
			2263.90(this.7.Text.Trim());
		};
		this.7.KeyPress += this.14;
		base.AutoScaleDimensions = new SizeF(96f, 96f);
		base.AutoScaleMode = AutoScaleMode.Dpi;
		this.BackColor = SystemColors.ControlLightLight;
		base.ClientSize = new Size(311, 43);
		base.ControlBox = false;
		base.Controls.Add(this.7);
		base.Controls.Add(this.8);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "GotoTime";
		base.ShowIcon = false;
		base.ShowInTaskbar = false;
		base.SizeGripStyle = SizeGripStyle.Hide;
		base.StartPosition = FormStartPosition.Manual;
		this.Text = "Jump to time: [mm:ss:ms] (combonumbers,...)";
		base.KeyPress += this.14;
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	// Token: 0x040022B7 RID: 8887
	private new TextBox 7;

	// Token: 0x040022B8 RID: 8888
	private new Label 8;
}
