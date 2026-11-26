using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

// Token: 0x0200091A RID: 2330
public sealed partial class 1693 : Form
{
	// Token: 0x0600425A RID: 16986 RVA: 0x0019D254 File Offset: 0x0019B454
	public 1693(string 1, int 2, DateTime 3, string 4, int 5, DateTime 6)
	{
		this.5();
		this.12.Text = 1;
		this.10.Text = string.Format("{0} KB", 2 / 1024);
		this.9.Text = 3.ToString();
		this.19.Text = 4;
		this.17.Text = string.Format("{0} KB", 5 / 1024);
		this.16.Text = 6.ToString();
		base.DialogResult = DialogResult.Ignore;
	}

	// Token: 0x0600425B RID: 16987 RVA: 0x0019D2F4 File Offset: 0x0019B4F4
	public 1693.1694 1()
	{
		return this.1;
	}

	// Token: 0x0600425C RID: 16988 RVA: 0x0019D2FC File Offset: 0x0019B4FC
	private void 2(1693.1694 1)
	{
		this.1 = 1;
	}

	// Token: 0x0600425D RID: 16989 RVA: 0x0019D308 File Offset: 0x0019B508
	private void 3(object 1, EventArgs 2)
	{
		if (1 is Button)
		{
			if (1.Equals(this.3))
			{
				this.2((1693.1694)1);
			}
			else if (1.Equals(this.5))
			{
				this.2((1693.1694)2);
			}
			else if (1.Equals(this.4))
			{
				this.2((1693.1694)3);
			}
			else if (1.Equals(this.6))
			{
				this.2((1693.1694)4);
			}
			base.DialogResult = DialogResult.OK;
			base.Close();
		}
	}

	// Token: 0x0600425E RID: 16990 RVA: 0x00005ADD File Offset: 0x00003CDD
	private void 4(object 1, EventArgs 2)
	{
	}

	// Token: 0x06004260 RID: 16992 RVA: 0x0019D3A4 File Offset: 0x0019B5A4
	private void 5()
	{
		this.3 = new Button();
		this.4 = new Button();
		this.5 = new Button();
		this.6 = new Button();
		this.7 = new Label();
		this.8 = new Panel();
		this.9 = new Label();
		this.10 = new Label();
		this.11 = new Label();
		this.12 = new Label();
		this.13 = new Label();
		this.14 = new Label();
		this.15 = new Panel();
		this.16 = new Label();
		this.17 = new Label();
		this.18 = new Label();
		this.19 = new Label();
		this.20 = new Label();
		Label label = new Label();
		Label label2 = new Label();
		this.8.SuspendLayout();
		this.15.SuspendLayout();
		base.SuspendLayout();
		label.AutoSize = true;
		label.Location = new Point(4, 33);
		label.Name = "label4";
		label.Size = new Size(44, 13);
		label.TabIndex = 2;
		label.Text = "Filesize:";
		label2.AutoSize = true;
		label2.Location = new Point(4, 29);
		label2.Name = "label9";
		label2.Size = new Size(44, 13);
		label2.TabIndex = 2;
		label2.Text = "Filesize:";
		this.3.Location = new Point(80, 241);
		this.3.Name = "BtnYes";
		this.3.Size = new Size(75, 23);
		this.3.TabIndex = 0;
		this.3.Text = "Yes";
		this.3.UseVisualStyleBackColor = true;
		this.3.Click += this.3;
		this.4.Location = new Point(176, 241);
		this.4.Name = "BtnNo";
		this.4.Size = new Size(75, 23);
		this.4.TabIndex = 1;
		this.4.Text = "No";
		this.4.UseVisualStyleBackColor = true;
		this.4.Click += this.3;
		this.5.Location = new Point(276, 241);
		this.5.Name = "BtnYesToAll";
		this.5.Size = new Size(75, 23);
		this.5.TabIndex = 2;
		this.5.Text = "Yes to all";
		this.5.UseVisualStyleBackColor = true;
		this.5.Click += this.3;
		this.6.Location = new Point(373, 241);
		this.6.Name = "BtnNoToAll";
		this.6.Size = new Size(75, 23);
		this.6.TabIndex = 3;
		this.6.Text = "No to all";
		this.6.UseVisualStyleBackColor = true;
		this.6.Click += this.3;
		this.7.Location = new Point(34, 21);
		this.7.Name = "label1";
		this.7.Size = new Size(249, 16);
		this.7.TabIndex = 4;
		this.7.Text = "Do you want to replace the following file?";
		this.8.BorderStyle = BorderStyle.FixedSingle;
		this.8.Controls.Add(this.9);
		this.8.Controls.Add(this.10);
		this.8.Controls.Add(this.11);
		this.8.Controls.Add(label);
		this.8.Controls.Add(this.12);
		this.8.Controls.Add(this.13);
		this.8.Location = new Point(40, 45);
		this.8.Name = "panel1";
		this.8.Size = new Size(470, 66);
		this.8.TabIndex = 5;
		this.9.Location = new Point(87, 46);
		this.9.Name = "LblModifiedExtracted";
		this.9.Size = new Size(378, 13);
		this.9.TabIndex = 5;
		this.10.Location = new Point(87, 33);
		this.10.Name = "LblFilesizeExtracted";
		this.10.Size = new Size(378, 13);
		this.10.TabIndex = 4;
		this.10.Click += this.4;
		this.11.AutoSize = true;
		this.11.Location = new Point(4, 46);
		this.11.Name = "label5";
		this.11.Size = new Size(75, 13);
		this.11.TabIndex = 3;
		this.11.Text = "Date modified:";
		this.12.Location = new Point(84, 4);
		this.12.Name = "LblLocationExtracted";
		this.12.Size = new Size(381, 26);
		this.12.TabIndex = 1;
		this.13.AutoSize = true;
		this.13.Location = new Point(4, 4);
		this.13.Name = "label2";
		this.13.Size = new Size(51, 13);
		this.13.TabIndex = 0;
		this.13.Text = "Location:";
		this.14.AutoSize = true;
		this.14.Location = new Point(37, 124);
		this.14.Name = "label6";
		this.14.Size = new Size(29, 13);
		this.14.TabIndex = 6;
		this.14.Text = "With";
		this.15.BorderStyle = BorderStyle.FixedSingle;
		this.15.Controls.Add(this.16);
		this.15.Controls.Add(this.17);
		this.15.Controls.Add(this.18);
		this.15.Controls.Add(label2);
		this.15.Controls.Add(this.19);
		this.15.Controls.Add(this.20);
		this.15.Location = new Point(40, 153);
		this.15.Name = "panel2";
		this.15.Size = new Size(470, 67);
		this.15.TabIndex = 7;
		this.16.Location = new Point(87, 42);
		this.16.Name = "LblModifiedOsz2";
		this.16.Size = new Size(378, 13);
		this.16.TabIndex = 5;
		this.17.Location = new Point(87, 29);
		this.17.Name = "LblFilesizeOsz2";
		this.17.Size = new Size(382, 13);
		this.17.TabIndex = 4;
		this.18.AutoSize = true;
		this.18.Location = new Point(4, 42);
		this.18.Name = "label8";
		this.18.Size = new Size(75, 13);
		this.18.TabIndex = 3;
		this.18.Text = "Date modified:";
		this.19.Location = new Point(84, 4);
		this.19.Name = "LblLocationOsz2";
		this.19.Size = new Size(381, 25);
		this.19.TabIndex = 1;
		this.20.AutoSize = true;
		this.20.Location = new Point(4, 4);
		this.20.Name = "label11";
		this.20.Size = new Size(51, 13);
		this.20.TabIndex = 0;
		this.20.Text = "Location:";
		base.AutoScaleDimensions = new SizeF(96f, 96f);
		base.AutoScaleMode = AutoScaleMode.Dpi;
		base.ClientSize = new Size(557, 288);
		base.ControlBox = false;
		base.Controls.Add(this.15);
		base.Controls.Add(this.14);
		base.Controls.Add(this.8);
		base.Controls.Add(this.7);
		base.Controls.Add(this.6);
		base.Controls.Add(this.5);
		base.Controls.Add(this.4);
		base.Controls.Add(this.3);
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "FileColissionDialog";
		base.ShowIcon = false;
		base.ShowInTaskbar = false;
		this.Text = "Replace File?";
		this.8.ResumeLayout(false);
		this.8.PerformLayout();
		this.15.ResumeLayout(false);
		this.15.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	// Token: 0x04003073 RID: 12403
	private 1693.1694 1;

	// Token: 0x04003075 RID: 12405
	private Button 3;

	// Token: 0x04003076 RID: 12406
	private Button 4;

	// Token: 0x04003077 RID: 12407
	private Button 5;

	// Token: 0x04003078 RID: 12408
	private Button 6;

	// Token: 0x04003079 RID: 12409
	private Label 7;

	// Token: 0x0400307A RID: 12410
	private Panel 8;

	// Token: 0x0400307B RID: 12411
	private Label 9;

	// Token: 0x0400307C RID: 12412
	private Label 10;

	// Token: 0x0400307D RID: 12413
	private Label 11;

	// Token: 0x0400307E RID: 12414
	private Label 12;

	// Token: 0x0400307F RID: 12415
	private Label 13;

	// Token: 0x04003080 RID: 12416
	private Label 14;

	// Token: 0x04003081 RID: 12417
	private Panel 15;

	// Token: 0x04003082 RID: 12418
	private Label 16;

	// Token: 0x04003083 RID: 12419
	private Label 17;

	// Token: 0x04003084 RID: 12420
	private Label 18;

	// Token: 0x04003085 RID: 12421
	private Label 19;

	// Token: 0x04003086 RID: 12422
	private Label 20;

	// Token: 0x0200091B RID: 2331
	public enum 1694
	{

	}
}
