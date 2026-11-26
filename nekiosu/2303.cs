using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

// Token: 0x0200062F RID: 1583
public sealed partial class 2303 : 1488
{
	// Token: 0x06002FED RID: 12269 RVA: 0x0010E62C File Offset: 0x0010C82C
	internal 2303(2263 1)
	{
		this.6 = 3;
		this.7 = new 2280();
		this.22();
		base.StartPosition = FormStartPosition.CenterScreen;
		base.7(delegate(object 1, 2354 2)
		{
			if (base.PointToClient(2.2).Y < this.27.Height && 2.1 == (2355)1)
			{
				2.1 = (2355)2;
			}
		});
		this.27.1(true);
		this.19.ColumnHeadersHeight = (int)(23f * 2328.1(this, false) / 96f);
	}

	// Token: 0x06002FEE RID: 12270 RVA: 0x0010E6DF File Offset: 0x0010C8DF
	internal void 13()
	{
		this.11 = true;
		base.Close();
	}

	// Token: 0x06002FEF RID: 12271 RVA: 0x0010E6F0 File Offset: 0x0010C8F0
	protected override void OnClosing(CancelEventArgs 1)
	{
		1662.89.Schedule(new 1189(this.23), false);
		1.Cancel = !this.11;
		this.8.Dispose();
		base.Hide();
		base.OnClosing(1);
	}

	// Token: 0x06002FF0 RID: 12272 RVA: 0x0010E73C File Offset: 0x0010C93C
	protected override void OnClosed(EventArgs 1)
	{
		base.OnClosed(1);
	}

	// Token: 0x06002FF1 RID: 12273 RVA: 0x0010E745 File Offset: 0x0010C945
	internal void 14()
	{
		this.19(null, null);
	}

	// Token: 0x06002FF2 RID: 12274 RVA: 0x0010E750 File Offset: 0x0010C950
	private void 15(List<2278> 1)
	{
		this.13 = true;
		DataGridViewRow[] array = new DataGridViewRow[1.Count];
		this.19.Rows.Clear();
		int num = 0;
		foreach (2278 2 in 1)
		{
			DataGridViewRow dataGridViewRow = (DataGridViewRow)this.19.RowTemplate.Clone();
			DataGridViewImageCell dataGridViewImageCell = new DataGridViewImageCell();
			switch (2.2)
			{
			case (2341)0:
				dataGridViewImageCell.Value = 277.GetAimodInfoImage();
				break;
			case (2341)1:
				dataGridViewImageCell.Value = 277.GetAimodWarningImage();
				break;
			case (2341)2:
				dataGridViewImageCell.Value = 277.GetAimodErrorImage();
				break;
			}
			dataGridViewRow.Cells.Add(dataGridViewImageCell);
			dataGridViewRow.Cells.Add(new DataGridViewTextBoxCell());
			dataGridViewRow.Cells.Add(new DataGridViewLinkCell());
			dataGridViewRow.Cells[2].Value = ((2.3 != -1) ? string.Format("{0:00}:{1:00}:{2:000}", 2.3 / 60000, 2.3 % 60000 / 1000, Math.Max(0, 2.3) % 1000) : string.Empty);
			dataGridViewRow.Cells[1].Value = 2.1;
			dataGridViewRow.Tag = 2;
			array[num++] = dataGridViewRow;
		}
		this.19.Rows.AddRange(array);
		this.19.ClearSelection();
		this.13 = false;
	}

	// Token: 0x06002FF3 RID: 12275 RVA: 0x0010E91C File Offset: 0x0010CB1C
	private void 16(object 1, EventArgs 2)
	{
		if (this.19.SelectedRows.Count == 0 || this.13 || !this.14)
		{
			this.12 = null;
			return;
		}
		this.12 = (this.19.SelectedRows[0].Tag as 2278);
		if (this.12.5.Count > 0)
		{
			this.6.74.SelectObjects(this.12.5.ToArray());
		}
		if (this.12.3 != -1)
		{
			1226.4(this.12.3, false, false);
		}
	}

	// Token: 0x06002FF4 RID: 12276 RVA: 0x0010E9C8 File Offset: 0x0010CBC8
	internal void 17()
	{
		if (!base.Visible)
		{
			return;
		}
		if (!this.14)
		{
			this.14 = true;
			this.19.ClearSelection();
		}
		if (this.12 == null)
		{
			return;
		}
		2338 <<EMPTY_NAME>> = this.12 as 2338;
		2356 2 = this.12 as 2356;
		this.12._0008_200A_200B_2000_2005_200B_200B_2000_2000_200B_200B_2002_2008_200B();
		2034 3 = null;
		2034 4 = null;
		this.12._0002_2002_2003_2006_200A_2006_2002_200B_2008_2007_2004_200A_2000_2004_2008_2006_2004_2004();
		if (2 != null)
		{
			3 = this.18(2.7);
			4 = this.18(2.8);
		}
		else if (<<EMPTY_NAME>> != null)
		{
			3 = this.18(<<EMPTY_NAME>>.7);
		}
		if (3 != null && 4 != null)
		{
			if (3.IsActive() && 4.IsActive())
			{
				1051 5 = new 1051(1662.69.17(3.GetEndPosition()), 1662.69.17(4.8));
				bool flag = 2._0002_2002_2003_2006_200A_2006_2002_200B_2008_2007_2004_200A_2000_2004_2008_2006_2004_2004();
				1662.13.DrawPath(5, 8f, (1662.33 % 1000 > 500 || flag) ? 198.Black : 198.White);
				1662.13.DrawPath(5, 5f, flag ? 198.YellowGreen : 198.Red);
				return;
			}
		}
		else if (3 != null && 3.IsActive())
		{
			3.OnSelected();
		}
	}

	// Token: 0x06002FF5 RID: 12277 RVA: 0x0010EB1C File Offset: 0x0010CD1C
	private 2034 18(2036 1)
	{
		2303.2304 2 = new 2303.2304();
		2.1 = 1;
		return this.6.7.34.Find(new Predicate<2034>(2.1));
	}

	// Token: 0x06002FF6 RID: 12278 RVA: 0x0010EB58 File Offset: 0x0010CD58
	private void 19(object 1, EventArgs 2)
	{
		this.19.Rows.Clear();
		2039 3 = this.6.7;
		if (this.6.8.13)
		{
			3.21.30();
		}
		this.7.4(3);
		foreach (KeyValuePair<2277, List<2278>> keyValuePair in this.7.1)
		{
			this.21.TabPages[(int)keyValuePair.Key].Text = string.Format("{0} ({1})", keyValuePair.Key.ToString(), keyValuePair.Value.Count);
		}
		this.20(null, null);
		this.21();
	}

	// Token: 0x06002FF7 RID: 12279 RVA: 0x0010EC48 File Offset: 0x0010CE48
	private void 20(object 1, EventArgs 2)
	{
		this.15(this.7.1[(2277)this.21.SelectedIndex]);
	}

	// Token: 0x06002FF8 RID: 12280 RVA: 0x0010EC6C File Offset: 0x0010CE6C
	private void 21()
	{
		if (this.7.1.Count != 0)
		{
			int count = this.7.6(2277.All, (2341)2).Count;
			int count2 = this.7.6(2277.All, (2341)1).Count;
			this.34.Text = this.7.1().ToString();
			this.32.Text = count2.ToString();
			this.30.Text = count.ToString();
			this.41.Text = this.7.1().ToString();
			this.39.Text = count2.ToString();
			this.37.Text = count.ToString();
			this.32.ForeColor = ((count2 > 0) ? this.16 : Color.Black);
			this.30.ForeColor = ((count > 0) ? this.17 : Color.Black);
			this.39.ForeColor = ((count2 > 0) ? this.16 : Color.Black);
			this.37.ForeColor = ((count > 0) ? this.17 : Color.Black);
		}
	}

	// Token: 0x06002FFA RID: 12282 RVA: 0x0010EDD4 File Offset: 0x0010CFD4
	private void 22()
	{
		DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
		this.19 = new DataGridView();
		this.27 = new 1487();
		this.45 = new CheckBox();
		this.43 = new Panel();
		this.21 = new TabControl();
		this.22 = new TabPage();
		this.23 = new TabPage();
		this.24 = new TabPage();
		this.25 = new TabPage();
		this.26 = new TabPage();
		this.44 = new TabPage();
		this.28 = new Panel();
		this.36 = new GroupBox();
		this.37 = new Label();
		this.38 = new Label();
		this.39 = new Label();
		this.40 = new Label();
		this.41 = new Label();
		this.42 = new Label();
		this.29 = new 1471();
		this.30 = new 754();
		this.31 = new 754();
		this.32 = new 754();
		this.33 = new 754();
		this.34 = new 754();
		this.35 = new 754();
		this.20 = new Button();
		this.46 = new DataGridViewImageColumn();
		this.47 = new DataGridViewTextBoxColumn();
		this.48 = new DataGridViewLinkColumn();
		((ISupportInitialize)this.19).BeginInit();
		this.27.SuspendLayout();
		this.43.SuspendLayout();
		this.21.SuspendLayout();
		this.28.SuspendLayout();
		this.36.SuspendLayout();
		this.29.SuspendLayout();
		base.SuspendLayout();
		this.19.AllowUserToAddRows = false;
		this.19.AllowUserToDeleteRows = false;
		this.19.AllowUserToResizeColumns = false;
		this.19.AllowUserToResizeRows = false;
		dataGridViewCellStyle.BackColor = Color.WhiteSmoke;
		this.19.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
		this.19.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		this.19.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
		this.19.BackgroundColor = SystemColors.ControlLightLight;
		this.19.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
		this.19.Columns.AddRange(new DataGridViewColumn[]
		{
			this.46,
			this.47,
			this.48
		});
		dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle2.BackColor = SystemColors.Window;
		dataGridViewCellStyle2.Font = new Font("Microsoft YaHei UI", 9f);
		dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
		dataGridViewCellStyle2.SelectionBackColor = Color.NavajoWhite;
		dataGridViewCellStyle2.SelectionForeColor = Color.Black;
		dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
		this.19.DefaultCellStyle = dataGridViewCellStyle2;
		this.19.Dock = DockStyle.Fill;
		this.19.Location = new Point(0, 103);
		this.19.MultiSelect = false;
		this.19.Name = "dataGridView1";
		this.19.RowHeadersVisible = false;
		this.19.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
		this.19.ScrollBars = ScrollBars.Vertical;
		this.19.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		this.19.ShowCellErrors = false;
		this.19.ShowEditingIcon = false;
		this.19.ShowRowErrors = false;
		this.19.Size = new Size(424, 343);
		this.19.TabIndex = 3;
		this.19.SelectionChanged += this.16;
		this.27.1(false);
		this.27.Controls.Add(this.45);
		this.27.Controls.Add(this.43);
		this.27.Controls.Add(this.28);
		this.27.Controls.Add(this.20);
		this.27.Dock = DockStyle.Top;
		this.27.Location = new Point(0, 0);
		this.27.Name = "pnlTop";
		this.27.Padding = new Padding(1);
		this.27.Size = new Size(424, 103);
		this.27.TabIndex = 0;
		this.45.AutoSize = true;
		this.45.Location = new Point(116, 13);
		this.45.Name = "cb_ds";
		this.45.Size = new Size(145, 19);
		this.45.TabIndex = 13;
		this.45.Text = "Check distance snap";
		this.45.UseVisualStyleBackColor = true;
		this.45.CheckedChanged += delegate(object 1, EventArgs 2)
		{
			this.7.2(this.45.Checked);
			this.19(null, null);
		};
		this.43.Controls.Add(this.21);
		this.43.Location = new Point(2, 83);
		this.43.Name = "panel2";
		this.43.Size = new Size(440, 31);
		this.43.TabIndex = 12;
		this.21.Controls.Add(this.22);
		this.21.Controls.Add(this.23);
		this.21.Controls.Add(this.24);
		this.21.Controls.Add(this.25);
		this.21.Controls.Add(this.26);
		this.21.Controls.Add(this.44);
		this.21.Dock = DockStyle.Fill;
		this.21.Font = new Font("Segoe UI", 8f);
		this.21.Location = new Point(0, 0);
		this.21.Name = "tabControl1";
		this.21.SelectedIndex = 0;
		this.21.Size = new Size(440, 31);
		this.21.TabIndex = 10;
		this.21.SelectedIndexChanged += delegate(object 1, EventArgs 2)
		{
			this.15(this.7.1[(2277)this.21.SelectedIndex]);
		};
		this.22.Location = new Point(4, 22);
		this.22.Name = "tabPage1";
		this.22.Padding = new Padding(3);
		this.22.Size = new Size(432, 5);
		this.22.TabIndex = 0;
		this.22.Text = "All";
		this.22.UseVisualStyleBackColor = true;
		this.23.Location = new Point(4, 22);
		this.23.Name = "tabPage2";
		this.23.Padding = new Padding(3);
		this.23.Size = new Size(432, 5);
		this.23.TabIndex = 1;
		this.23.Text = "Compose";
		this.23.UseVisualStyleBackColor = true;
		this.24.Location = new Point(4, 22);
		this.24.Name = "tabPage3";
		this.24.Size = new Size(432, 5);
		this.24.TabIndex = 2;
		this.24.Text = "Design";
		this.24.UseVisualStyleBackColor = true;
		this.25.Location = new Point(4, 22);
		this.25.Name = "tabPage4";
		this.25.Size = new Size(432, 5);
		this.25.TabIndex = 3;
		this.25.Text = "Timing";
		this.25.UseVisualStyleBackColor = true;
		this.26.Location = new Point(4, 22);
		this.26.Name = "tabPage5";
		this.26.Size = new Size(432, 5);
		this.26.TabIndex = 4;
		this.26.Text = "Meta";
		this.26.UseVisualStyleBackColor = true;
		this.44.Location = new Point(4, 22);
		this.44.Name = "tabPage6";
		this.44.Padding = new Padding(3);
		this.44.Size = new Size(432, 5);
		this.44.TabIndex = 5;
		this.44.Text = "Mapset";
		this.44.UseVisualStyleBackColor = true;
		this.28.Controls.Add(this.36);
		this.28.Controls.Add(this.29);
		this.28.Dock = DockStyle.Right;
		this.28.Location = new Point(274, 1);
		this.28.Name = "panel1";
		this.28.Size = new Size(149, 101);
		this.28.TabIndex = 11;
		this.36.Controls.Add(this.37);
		this.36.Controls.Add(this.38);
		this.36.Controls.Add(this.39);
		this.36.Controls.Add(this.40);
		this.36.Controls.Add(this.41);
		this.36.Controls.Add(this.42);
		this.36.Location = new Point(4, 6);
		this.36.Name = "grpRight";
		this.36.Size = new Size(133, 69);
		this.36.TabIndex = 1;
		this.36.TabStop = false;
		this.37.AutoSize = true;
		this.37.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this.37.ForeColor = Color.FromArgb(136, 16, 16);
		this.37.Location = new Point(63, 46);
		this.37.Name = "lblErrors";
		this.37.Size = new Size(39, 13);
		this.37.TabIndex = 5;
		this.37.Text = "errors";
		this.38.AutoSize = true;
		this.38.Location = new Point(2, 45);
		this.38.Name = "label3";
		this.38.Size = new Size(46, 15);
		this.38.TabIndex = 4;
		this.38.Text = "Errors:";
		this.39.AutoSize = true;
		this.39.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this.39.ForeColor = Color.FromArgb(120, 80, 16);
		this.39.Location = new Point(63, 31);
		this.39.Name = "lblWarnings";
		this.39.Size = new Size(57, 13);
		this.39.TabIndex = 3;
		this.39.Text = "warnings";
		this.40.AutoSize = true;
		this.40.Location = new Point(2, 30);
		this.40.Name = "label2";
		this.40.Size = new Size(65, 15);
		this.40.TabIndex = 2;
		this.40.Text = "Warnings:";
		this.41.AutoSize = true;
		this.41.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this.41.ForeColor = Color.FromArgb(16, 112, 16);
		this.41.Location = new Point(63, 16);
		this.41.Name = "lblDifficulty";
		this.41.Size = new Size(55, 13);
		this.41.TabIndex = 1;
		this.41.Text = "difficulty";
		this.42.AutoSize = true;
		this.42.Location = new Point(2, 15);
		this.42.Name = "label1";
		this.42.Size = new Size(59, 15);
		this.42.TabIndex = 0;
		this.42.Text = "Difficulty:";
		this.29.BackColor = Color.FromArgb(128, 255, 255, 255);
		this.29.Controls.Add(this.30);
		this.29.Controls.Add(this.31);
		this.29.Controls.Add(this.32);
		this.29.Controls.Add(this.33);
		this.29.Controls.Add(this.34);
		this.29.Controls.Add(this.35);
		this.29.Location = new Point(12, 0);
		this.29.Name = "pnlGlass";
		this.29.Size = new Size(135, 65);
		this.29.TabIndex = 0;
		this.29.Visible = false;
		this.30.AutoSize = true;
		this.30.BackColor = Color.Transparent;
		this.30.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this.30.ForeColor = Color.FromArgb(136, 16, 16);
		this.30.Location = new Point(63, 41);
		this.30.Name = "monoErrors";
		this.30.Size = new Size(39, 13);
		this.30.TabIndex = 5;
		this.30.Text = "errors";
		this.31.AutoSize = true;
		this.31.BackColor = Color.Transparent;
		this.31.Location = new Point(3, 40);
		this.31.Name = "monochromeLabel4";
		this.31.Size = new Size(46, 15);
		this.31.TabIndex = 4;
		this.31.Text = "Errors:";
		this.32.AutoSize = true;
		this.32.BackColor = Color.Transparent;
		this.32.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this.32.ForeColor = Color.FromArgb(120, 80, 16);
		this.32.Location = new Point(63, 26);
		this.32.Name = "monoWarnings";
		this.32.Size = new Size(57, 13);
		this.32.TabIndex = 3;
		this.32.Text = "warnings";
		this.33.AutoSize = true;
		this.33.BackColor = Color.Transparent;
		this.33.Location = new Point(3, 25);
		this.33.Name = "monochromeLabel3";
		this.33.Size = new Size(65, 15);
		this.33.TabIndex = 2;
		this.33.Text = "Warnings:";
		this.34.AutoSize = true;
		this.34.BackColor = Color.Transparent;
		this.34.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this.34.ForeColor = Color.FromArgb(16, 112, 16);
		this.34.Location = new Point(63, 11);
		this.34.Name = "monoDifficulty";
		this.34.Size = new Size(55, 13);
		this.34.TabIndex = 1;
		this.34.Text = "difficulty";
		this.35.AutoSize = true;
		this.35.BackColor = Color.Transparent;
		this.35.Location = new Point(3, 10);
		this.35.Name = "monochromeLabel1";
		this.35.Size = new Size(59, 15);
		this.35.TabIndex = 0;
		this.35.Text = "Difficulty:";
		this.20.BackColor = Color.Transparent;
		this.20.Location = new Point(9, 29);
		this.20.Margin = new Padding(8);
		this.20.Name = "buttonRun";
		this.20.Size = new Size(91, 43);
		this.20.TabIndex = 3;
		this.20.Text = "Refresh";
		this.20.UseVisualStyleBackColor = false;
		this.20.Click += this.19;
		this.46.FillWeight = 25.29443f;
		this.46.HeaderText = string.Empty;
		this.46.MinimumWidth = 14;
		this.46.Name = "SeverityColumn";
		this.47.FillWeight = 251.94f;
		this.47.HeaderText = "Information";
		this.47.Name = "Information";
		this.47.ReadOnly = true;
		this.48.FillWeight = 78.6944f;
		this.48.HeaderText = "Time";
		this.48.Name = "Time";
		this.48.ReadOnly = true;
		this.48.SortMode = DataGridViewColumnSortMode.Automatic;
		base.AutoScaleDimensions = new SizeF(96f, 96f);
		base.AutoScaleMode = AutoScaleMode.Dpi;
		base.ClientSize = new Size(424, 446);
		base.Controls.Add(this.19);
		base.Controls.Add(this.27);
		base.FormBorderStyle = FormBorderStyle.SizableToolWindow;
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		this.MinimumSize = new Size(440, 320);
		base.Name = "AiModWindow";
		base.ShowIcon = false;
		base.ShowInTaskbar = false;
		base.SizeGripStyle = SizeGripStyle.Hide;
		base.StartPosition = FormStartPosition.CenterParent;
		this.Text = "AiMod";
		base.KeyPress += delegate(object 1, KeyPressEventArgs 2)
		{
			if (2.KeyChar == '\u001b')
			{
				2.Handled = true;
				this.13();
			}
		};
		((ISupportInitialize)this.19).EndInit();
		this.27.ResumeLayout(false);
		this.27.PerformLayout();
		this.43.ResumeLayout(false);
		this.21.ResumeLayout(false);
		this.28.ResumeLayout(false);
		this.36.ResumeLayout(false);
		this.36.PerformLayout();
		this.29.ResumeLayout(false);
		this.29.PerformLayout();
		base.ResumeLayout(false);
	}

	// Token: 0x06002FFB RID: 12283 RVA: 0x00110194 File Offset: 0x0010E394
	private void 23()
	{
		this.6.43 = null;
	}

	// Token: 0x0400226B RID: 8811
	private readonly 2263 6;

	// Token: 0x0400226C RID: 8812
	private new 2280 7;

	// Token: 0x0400226D RID: 8813
	private new 2251 8 = new 2251();

	// Token: 0x0400226E RID: 8814
	private int 9;

	// Token: 0x0400226F RID: 8815
	private int 10;

	// Token: 0x04002270 RID: 8816
	private new bool 11;

	// Token: 0x04002271 RID: 8817
	private new 2278 12;

	// Token: 0x04002272 RID: 8818
	private bool 13;

	// Token: 0x04002273 RID: 8819
	private bool 14;

	// Token: 0x04002274 RID: 8820
	private Color 15 = Color.FromArgb(0, 16, 112, 16);

	// Token: 0x04002275 RID: 8821
	private Color 16 = Color.FromArgb(0, 120, 80, 16);

	// Token: 0x04002276 RID: 8822
	private Color 17 = Color.FromArgb(0, 136, 16, 16);

	// Token: 0x04002278 RID: 8824
	private DataGridView 19;

	// Token: 0x04002279 RID: 8825
	private Button 20;

	// Token: 0x0400227A RID: 8826
	private TabControl 21;

	// Token: 0x0400227B RID: 8827
	private TabPage 22;

	// Token: 0x0400227C RID: 8828
	private TabPage 23;

	// Token: 0x0400227D RID: 8829
	private TabPage 24;

	// Token: 0x0400227E RID: 8830
	private TabPage 25;

	// Token: 0x0400227F RID: 8831
	private TabPage 26;

	// Token: 0x04002280 RID: 8832
	private 1487 27;

	// Token: 0x04002281 RID: 8833
	private Panel 28;

	// Token: 0x04002282 RID: 8834
	private 1471 29;

	// Token: 0x04002283 RID: 8835
	private 754 30;

	// Token: 0x04002284 RID: 8836
	private 754 31;

	// Token: 0x04002285 RID: 8837
	private 754 32;

	// Token: 0x04002286 RID: 8838
	private 754 33;

	// Token: 0x04002287 RID: 8839
	private 754 34;

	// Token: 0x04002288 RID: 8840
	private 754 35;

	// Token: 0x04002289 RID: 8841
	private GroupBox 36;

	// Token: 0x0400228A RID: 8842
	private Label 37;

	// Token: 0x0400228B RID: 8843
	private Label 38;

	// Token: 0x0400228C RID: 8844
	private Label 39;

	// Token: 0x0400228D RID: 8845
	private Label 40;

	// Token: 0x0400228E RID: 8846
	private Label 41;

	// Token: 0x0400228F RID: 8847
	private Label 42;

	// Token: 0x04002290 RID: 8848
	private Panel 43;

	// Token: 0x04002291 RID: 8849
	private TabPage 44;

	// Token: 0x04002292 RID: 8850
	private CheckBox 45;

	// Token: 0x04002293 RID: 8851
	private DataGridViewImageColumn 46;

	// Token: 0x04002294 RID: 8852
	private DataGridViewTextBoxColumn 47;

	// Token: 0x04002295 RID: 8853
	private DataGridViewLinkColumn 48;

	// Token: 0x02000630 RID: 1584
	public sealed class 2304
	{
		// Token: 0x06003000 RID: 12288 RVA: 0x0011021B File Offset: 0x0010E41B
		internal bool 1(2034 1)
		{
			return 1.1 == this.1.1;
		}

		// Token: 0x04002296 RID: 8854
		public 2036 1;
	}
}
