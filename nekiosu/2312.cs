using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

// Token: 0x02000638 RID: 1592
public sealed partial class 2312 : 1488
{
	// Token: 0x06003049 RID: 12361 RVA: 0x001133EC File Offset: 0x001115EC
	internal 2312(bool 1)
	{
		this.6 = 2263.4;
		this.16();
		this.8 = 4;
		if (4)
		{
			this.12.Visible = false;
		}
		base.TopLevel = true;
		this.7 = new List<1270>();
		List<string> list = new List<string>(1272.5().61 ? 1272.5().55().25() : Directory.GetFiles(1272.5().44(), "*.osu"));
		if (1272.5().53() != null)
		{
			string[] files = Directory.GetFiles(1272.5().53(), "*.osu");
			for (int i = 0; i < files.Length; i++)
			{
				2312.2314 openDialogClosure = new 2312.2314
				{
					1 = files[i]
				};
				if (!list.Exists((string 1) => 1.EndsWith(Path.GetFileName(openDialogClosure.1))))
				{
					list.Add(openDialogClosure.1);
				}
			}
		}
		if (1272.5().53() != null)
		{
			1272.36(1272.5().53());
		}
		foreach (string path in list)
		{
			1270 2 = new 1270();
			1262 3 = 1272.7(Path.GetFileName(path));
			if (3 == null)
			{
				2.3 = "?NEW? " + Path.GetFileName(path);
				2.2 = Path.GetFileName(path);
				2.4 = 10.0;
			}
			else
			{
				2.1 = 3;
				2.2 = 3.58;
				2.3 = string.Format("{0}", 3.89);
				2.4 = 3.34();
			}
			this.7.Method11157(2);
		}
		foreach (1270 item in this.7)
		{
			this.10.Items.Add(item);
		}
		if (!4)
		{
			this.13(1272.5());
			return;
		}
		1270 item2 = new 1270
		{
			3 = "None"
		};
		this.7.Insert(0, item2);
		this.10.Items.Insert(0, item2);
		if (this.6.74.74 == null)
		{
			this.10.SelectedIndex = 0;
			return;
		}
		this.13(this.6.74.74.21);
	}

	// Token: 0x0600304A RID: 12362 RVA: 0x001136A4 File Offset: 0x001118A4
	private void 13(1262 1)
	{
		2312.2313 2 = new 2312.2313();
		2.1 = 1;
		int num = this.7.FindIndex(new Predicate<1270>(2.1));
		if (num >= 0)
		{
			this.10.SelectedIndex = num;
		}
	}

	// Token: 0x0600304B RID: 12363 RVA: 0x001136E6 File Offset: 0x001118E6
	internal string 14()
	{
		return ((1270)this.10.SelectedItem).2;
	}

	// Token: 0x0600304C RID: 12364 RVA: 0x001136FD File Offset: 0x001118FD
	private void 15(object 1, KeyEventArgs 2)
	{
		if (2.KeyCode == Keys.Escape)
		{
			base.Close();
		}
	}

	// Token: 0x0600304E RID: 12366 RVA: 0x00113730 File Offset: 0x00111930
	private void 16()
	{
		this.10 = new ListBox();
		this.11 = new Label();
		this.12 = new CheckBox();
		this.13 = new Panel();
		this.13.SuspendLayout();
		base.SuspendLayout();
		this.10.Dock = DockStyle.Fill;
		this.10.FormattingEnabled = true;
		this.10.Location = new Point(0, 0);
		this.10.Margin = new Padding(0);
		this.10.Name = "listBox1";
		this.10.Size = new Size(165, 116);
		this.10.TabIndex = 0;
		this.10.SelectedIndexChanged += delegate(object 1, EventArgs 2)
		{
			string 3 = 1272.5().58;
			string fileName = Path.GetFileName(this.14());
			if (!(3 == fileName))
			{
				if (this.8)
				{
					if (fileName == null)
					{
						this.6.67(null);
						return;
					}
					1262 4 = 1272.7(fileName);
					if (4 != null && 4 != 1272.5() && 4.3() == 2147.OsuMania && !this.6.67(4))
					{
						MessageBox.Show("Cannot load this file!");
						return;
					}
				}
				else
				{
					if (this.12.Checked)
					{
						this.6.69(false);
					}
					else if (!this.6.69(true))
					{
						this.13(1272.5());
						return;
					}
					if (!1272.6(fileName, true))
					{
						1272.33(false);
						1272.6(fileName, true);
					}
					1262 5 = 1272.5();
					if (5 != null)
					{
						if (5.58 != 3)
						{
							this.6.34(5, false, false);
							this.6.8.34();
							return;
						}
					}
					else
					{
						1272.6(3, true);
						MessageBox.Show("Cannot load this file!");
					}
				}
			}
		};
		this.11.Location = new Point(4, 2);
		this.11.Name = "label1";
		this.11.Size = new Size(159, 18);
		this.11.TabIndex = 1;
		this.11.Text = "Available Difficulties:";
		this.12.AutoSize = true;
		this.12.FlatStyle = FlatStyle.System;
		this.12.Location = new Point(7, 142);
		this.12.Name = "checkBoxAutosave";
		this.12.Size = new Size(160, 20);
		this.12.TabIndex = 1;
		this.12.Text = "Save without prompting";
		this.12.UseVisualStyleBackColor = true;
		this.13.Controls.Add(this.10);
		this.13.Location = new Point(7, 20);
		this.13.Name = "panel1";
		this.13.Size = new Size(165, 116);
		this.13.TabIndex = 0;
		base.AutoScaleDimensions = new SizeF(96f, 96f);
		base.AutoScaleMode = AutoScaleMode.Dpi;
		base.ClientSize = new Size(179, 166);
		base.Controls.Add(this.13);
		base.Controls.Add(this.11);
		base.Controls.Add(this.12);
		base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "OpenDialog";
		base.ShowIcon = false;
		base.ShowInTaskbar = false;
		base.StartPosition = FormStartPosition.Manual;
		this.Text = "Difficulty Selection";
		base.KeyDown += this.15;
		this.13.ResumeLayout(false);
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	// Token: 0x040022D8 RID: 8920
	private 2263 6;

	// Token: 0x040022D9 RID: 8921
	private new List<1270> 7;

	// Token: 0x040022DA RID: 8922
	private new bool 8;

	// Token: 0x040022DC RID: 8924
	private ListBox 10;

	// Token: 0x040022DD RID: 8925
	private new Label 11;

	// Token: 0x040022DE RID: 8926
	private new CheckBox 12;

	// Token: 0x040022DF RID: 8927
	private Panel 13;

	// Token: 0x02000639 RID: 1593
	public sealed class 2313
	{
		// Token: 0x06003050 RID: 12368 RVA: 0x00113B25 File Offset: 0x00111D25
		internal bool 1(1270 1)
		{
			return 1.2 == this.1.58;
		}

		// Token: 0x040022E0 RID: 8928
		public 1262 1;
	}

	// Token: 0x0200063A RID: 1594
	public sealed class 2314
	{
		// Token: 0x040022E1 RID: 8929
		public string 1;
	}
}
