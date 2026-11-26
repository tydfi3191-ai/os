using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

// Token: 0x0200063E RID: 1598
public sealed partial class 2317 : 1488
{
	// Token: 0x06003074 RID: 12404 RVA: 0x001154FB File Offset: 0x001136FB
	public 2317()
	{
		this.22();
	}

	// Token: 0x06003075 RID: 12405 RVA: 0x0011550C File Offset: 0x0011370C
	protected override void OnShown(EventArgs 1)
	{
		this.6 = 2263.4;
		this.6.57();
		if (2317.8 == null)
		{
			2317.8 = 1226.51();
		}
		this.17.Items.Add("None");
		ListBox.ObjectCollection items = this.17.Items;
		object[] array = 2317.8.ToArray();
		object[] items2 = array;
		items.AddRange(items2);
		base.OnShown(1);
	}

	// Token: 0x06003076 RID: 12406 RVA: 0x0011557B File Offset: 0x0011377B
	internal static void 13()
	{
		if (2317.8 != null)
		{
			2317.8.Clear();
		}
		2317.8 = null;
	}

	// Token: 0x06003077 RID: 12407 RVA: 0x00115594 File Offset: 0x00113794
	private void 14(object 1, EventArgs 2)
	{
		OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.Filter = "Sample file|*.wav;*.ogg;*.mp3";
		if (openFileDialog.ShowDialog(1662.13()) == DialogResult.OK)
		{
			this.16(openFileDialog.FileName);
		}
	}

	// Token: 0x06003078 RID: 12408 RVA: 0x001155CC File Offset: 0x001137CC
	private void 15(object 1, EventArgs 2)
	{
		if (this.17.SelectedItem == null)
		{
			return;
		}
		string text = this.17.SelectedItem.ToString();
		if (!(text == "None"))
		{
			if (this.10 != null)
			{
				this.10.12(true);
				this.10 = null;
			}
			int num = 1226.49(text, false, false, false);
			if (num != -1)
			{
				this.10 = 1226.29(num, (int)this.18.Value, 0f, false, 1f, false);
			}
		}
	}

	// Token: 0x06003079 RID: 12409 RVA: 0x00115658 File Offset: 0x00113858
	private void 16(string 1)
	{
		try
		{
			string text = 1.Substring(1.LastIndexOf(Path.DirectorySeparatorChar) + 1);
			string text2 = Path.Combine(1272.5().44(), text);
			if (File.Exists(text2))
			{
				File.Delete(text2);
			}
			File.Copy(1, text2);
			bool flag = 1226.49(text, false, false, true) != 0;
			MessageBox.Show("Loaded!");
			this.17.Items.Add(text);
			2317.8.Add(text);
			if (!flag)
			{
				1763.2("You have added an invaild sample", 2000, (1389)0);
			}
		}
		catch (Exception)
		{
			MessageBox.Show("An error occurred during the import process.  This could mean the wav/mp3/ogg file is unreadable by osu!");
		}
	}

	// Token: 0x0600307A RID: 12410 RVA: 0x00110789 File Offset: 0x0010E989
	private void 17(object 1, EventArgs 2)
	{
		base.Close();
	}

	// Token: 0x0600307B RID: 12411 RVA: 0x00115704 File Offset: 0x00113904
	private void 18(object 1, EventArgs 2)
	{
		if (this.23.Checked)
		{
			this.6.74.56(0, 0);
		}
		else
		{
			this.6.74.55(string.Empty, 0);
		}
		1763.2("Selected objects' hit samples have been reset.", 2000, (1389)0);
	}

	// Token: 0x0600307C RID: 12412 RVA: 0x00115758 File Offset: 0x00113958
	private void 19(object 1, EventArgs 2)
	{
		this.15(null, null);
	}

	// Token: 0x0600307D RID: 12413 RVA: 0x00115764 File Offset: 0x00113964
	private void 20(object 1, EventArgs 2)
	{
		if (this.17.SelectedItem != null)
		{
			string text = this.17.SelectedItem.ToString();
			if (!(text == "None"))
			{
				2654 3 = new 2654(1226.49(text, false, false, false), text, 1226.16, 2645.Background, (int)this.18.Value);
				3.11 = true;
				this.6.8.18((2452)2, (2451)8, 3);
				this.6.6.9(3);
				this.6.8.20(false, false);
				1763.2("Done", 1000, (1389)0);
			}
		}
	}

	// Token: 0x0600307E RID: 12414 RVA: 0x00115812 File Offset: 0x00113A12
	private void 21(object 1, FormClosingEventArgs 2)
	{
		if (this.10 != null)
		{
			this.10.12(true);
		}
		2317.7 = string.Empty;
	}

	// Token: 0x06003080 RID: 12416 RVA: 0x00115854 File Offset: 0x00113A54
	private void 22()
	{
		this.11 = new Container();
		this.12 = new Button();
		this.13 = new Button();
		this.14 = new Button();
		this.15 = new Button();
		this.16 = new Button();
		this.17 = new ListBox();
		this.18 = new NumericUpDown();
		this.19 = new Label();
		this.20 = new Button();
		this.21 = new GroupBox();
		this.22 = new NumericUpDown();
		this.23 = new CheckBox();
		this.24 = new Label();
		this.25 = new ToolTip(this.11);
		this.26 = new Button();
		this.27 = new Button();
		((ISupportInitialize)this.18).BeginInit();
		this.21.SuspendLayout();
		((ISupportInitialize)this.22).BeginInit();
		base.SuspendLayout();
		this.12.DialogResult = DialogResult.Cancel;
		this.12.Location = new Point(333, 305);
		this.12.Name = "b_cancel";
		this.12.Size = new Size(86, 30);
		this.12.TabIndex = 4;
		this.12.Text = "Cancel";
		this.12.UseVisualStyleBackColor = true;
		this.12.Click += this.17;
		this.13.Location = new Point(283, 219);
		this.13.Name = "b_apply";
		this.13.Size = new Size(86, 30);
		this.13.TabIndex = 3;
		this.13.Text = "Apply";
		this.25.SetToolTip(this.13, "Apply to selected notes");
		this.13.UseVisualStyleBackColor = true;
		this.13.Click += delegate(object 1, EventArgs 2)
		{
			if (this.23.Checked)
			{
				this.6.74.56((int)this.22.Value, (int)this.18.Value);
			}
			else
			{
				if (this.17.SelectedItem == null)
				{
					1763.2("You havn't selected a sample yet.", 2000, (1389)0);
					return;
				}
				string text = this.17.SelectedItem.ToString();
				if (text == "None")
				{
					this.6.74.55(string.Empty, (int)this.18.Value);
				}
				else
				{
					this.6.74.55(text, (int)this.18.Value);
				}
			}
			1763.2("Done", 1000, (1389)0);
		};
		this.14.Location = new Point(232, 178);
		this.14.Name = "b_open";
		this.14.Size = new Size(86, 30);
		this.14.TabIndex = 6;
		this.14.Text = "Import";
		this.14.UseVisualStyleBackColor = true;
		this.14.Click += this.14;
		this.15.Location = new Point(232, 305);
		this.15.Name = "b_reset";
		this.15.Size = new Size(86, 30);
		this.15.TabIndex = 14;
		this.15.Text = "Reset";
		this.25.SetToolTip(this.15, "Reset selected notes' sample");
		this.15.UseVisualStyleBackColor = true;
		this.15.Click += this.18;
		this.16.Location = new Point(284, 136);
		this.16.Name = "b_play";
		this.16.Size = new Size(86, 30);
		this.16.TabIndex = 15;
		this.16.Text = "Play";
		this.16.UseVisualStyleBackColor = true;
		this.16.Click += this.15;
		this.17.FormattingEnabled = true;
		this.17.ItemHeight = 12;
		this.17.Location = new Point(8, 11);
		this.17.Name = "lb_sample";
		this.17.Size = new Size(204, 328);
		this.17.TabIndex = 16;
		this.17.SelectedIndexChanged += delegate(object 1, EventArgs 2)
		{
			if (this.17.SelectedItem != null)
			{
				string a = this.17.SelectedItem.ToString();
				if (a == "None")
				{
					2317.7 = string.Empty;
					return;
				}
				2317.7 = a;
			}
		};
		this.17.DoubleClick += this.19;
		NumericUpDown numericUpDown = this.18;
		int[] array = new int[4];
		array[0] = 5;
		numericUpDown.Increment = new decimal(array);
		this.18.Location = new Point(95, 58);
		NumericUpDown numericUpDown2 = this.18;
		int[] array2 = new int[4];
		array2[0] = 8;
		numericUpDown2.Minimum = new decimal(array2);
		this.18.Name = "nud_vol";
		this.18.Size = new Size(85, 21);
		this.18.TabIndex = 17;
		this.18.TextAlign = HorizontalAlignment.Center;
		NumericUpDown numericUpDown3 = this.18;
		int[] array3 = new int[4];
		array3[0] = 70;
		numericUpDown3.Value = new decimal(array3);
		this.19.AutoSize = true;
		this.19.Location = new Point(12, 60);
		this.19.Name = "label1";
		this.19.Size = new Size(51, 15);
		this.19.TabIndex = 18;
		this.19.Text = "Volume";
		this.20.Location = new Point(334, 178);
		this.20.Name = "b_del";
		this.20.Size = new Size(85, 29);
		this.20.TabIndex = 19;
		this.20.Text = "Delete";
		this.20.UseVisualStyleBackColor = true;
		this.20.Click += delegate(object 1, EventArgs 2)
		{
			if (this.17.SelectedItem != null)
			{
				string text = this.17.SelectedItem.ToString();
				if (!(text == "None"))
				{
					1226.50(text.Substring(0, text.LastIndexOf('.')));
					this.17.Items.RemoveAt(this.17.SelectedIndex);
					2317.8.Remove(text);
					string path = Path.Combine(1272.5().44(), text);
					if (File.Exists(path))
					{
						File.Delete(path);
					}
				}
			}
		};
		this.21.Controls.Add(this.18);
		this.21.Controls.Add(this.22);
		this.21.Controls.Add(this.19);
		this.21.Controls.Add(this.23);
		this.21.Controls.Add(this.24);
		this.21.Location = new Point(232, 3);
		this.21.Name = "groupBox1";
		this.21.Size = new Size(187, 119);
		this.21.TabIndex = 20;
		this.21.TabStop = false;
		this.21.Text = "Basic";
		this.22.Location = new Point(95, 26);
		NumericUpDown numericUpDown4 = this.22;
		int[] array4 = new int[4];
		array4[0] = 1000;
		numericUpDown4.Maximum = new decimal(array4);
		this.22.Name = "nud_custom";
		this.22.Size = new Size(85, 21);
		this.22.TabIndex = 21;
		this.22.TextAlign = HorizontalAlignment.Center;
		this.25.SetToolTip(this.22, "0: Default\r\n1-1000: Custom");
		this.23.AutoSize = true;
		this.23.Location = new Point(15, 92);
		this.23.Name = "cb_basic";
		this.23.Size = new Size(128, 19);
		this.23.TabIndex = 2;
		this.23.Text = "Use basic sample";
		this.23.UseVisualStyleBackColor = true;
		this.24.AutoSize = true;
		this.24.Location = new Point(12, 28);
		this.24.Name = "label3";
		this.24.Size = new Size(69, 15);
		this.24.TabIndex = 1;
		this.24.Text = "CustomSet";
		this.26.Location = new Point(232, 262);
		this.26.Name = "b_sample";
		this.26.Size = new Size(86, 30);
		this.26.TabIndex = 21;
		this.26.Text = "Sample";
		this.25.SetToolTip(this.26, "Add as a sample event");
		this.26.UseVisualStyleBackColor = true;
		this.26.Click += this.20;
		this.27.Location = new Point(334, 262);
		this.27.Name = "b_list";
		this.27.Size = new Size(86, 30);
		this.27.TabIndex = 22;
		this.27.Text = "Sample List";
		this.27.UseVisualStyleBackColor = true;
		this.27.Click += delegate(object 1, EventArgs 2)
		{
			new 2318().ShowDialog(1662.13());
		};
		base.AcceptButton = this.13;
		base.AutoScaleDimensions = new SizeF(96f, 96f);
		base.AutoScaleMode = AutoScaleMode.Dpi;
		base.CancelButton = this.12;
		base.ClientSize = new Size(431, 351);
		base.Controls.Add(this.27);
		base.Controls.Add(this.26);
		base.Controls.Add(this.21);
		base.Controls.Add(this.20);
		base.Controls.Add(this.17);
		base.Controls.Add(this.16);
		base.Controls.Add(this.15);
		base.Controls.Add(this.14);
		base.Controls.Add(this.12);
		base.Controls.Add(this.13);
		base.FormBorderStyle = FormBorderStyle.FixedSingle;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "SampleImport";
		base.ShowIcon = false;
		base.ShowInTaskbar = false;
		base.StartPosition = FormStartPosition.CenterParent;
		this.Text = "Sample import";
		base.FormClosing += this.21;
		((ISupportInitialize)this.18).EndInit();
		this.21.ResumeLayout(false);
		this.21.PerformLayout();
		((ISupportInitialize)this.22).EndInit();
		base.ResumeLayout(false);
	}

	// Token: 0x04002305 RID: 8965
	private 2263 6;

	// Token: 0x04002306 RID: 8966
	internal new static string 7 = string.Empty;

	// Token: 0x04002307 RID: 8967
	private new static List<string> 8;

	// Token: 0x04002308 RID: 8968
	private bool 9;

	// Token: 0x04002309 RID: 8969
	private 1256 10;

	// Token: 0x0400230B RID: 8971
	private new Button 12;

	// Token: 0x0400230C RID: 8972
	private Button 13;

	// Token: 0x0400230D RID: 8973
	private Button 14;

	// Token: 0x0400230E RID: 8974
	private Button 15;

	// Token: 0x0400230F RID: 8975
	private Button 16;

	// Token: 0x04002310 RID: 8976
	private ListBox 17;

	// Token: 0x04002311 RID: 8977
	private NumericUpDown 18;

	// Token: 0x04002312 RID: 8978
	private Label 19;

	// Token: 0x04002313 RID: 8979
	private Button 20;

	// Token: 0x04002314 RID: 8980
	private GroupBox 21;

	// Token: 0x04002315 RID: 8981
	private NumericUpDown 22;

	// Token: 0x04002316 RID: 8982
	private CheckBox 23;

	// Token: 0x04002317 RID: 8983
	private Label 24;

	// Token: 0x04002318 RID: 8984
	private ToolTip 25;

	// Token: 0x04002319 RID: 8985
	private Button 26;

	// Token: 0x0400231A RID: 8986
	private Button 27;
}
