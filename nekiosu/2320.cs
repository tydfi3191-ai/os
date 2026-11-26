using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

// Token: 0x02000642 RID: 1602
public sealed partial class 2320 : 1488
{
	// Token: 0x0600309F RID: 12447 RVA: 0x001174F8 File Offset: 0x001156F8
	private void 13(object 1, EventArgs 2)
	{
		1244 3 = this.24();
		3.1 = 1245.Normal;
		1226.30(3, 0f, false);
	}

	// Token: 0x060030A0 RID: 12448 RVA: 0x00117520 File Offset: 0x00115720
	private void 14(object 1, EventArgs 2)
	{
		1244 3 = this.24();
		3.1 = 1245.Whistle;
		1226.30(3, 0f, false);
	}

	// Token: 0x060030A1 RID: 12449 RVA: 0x00117548 File Offset: 0x00115748
	private void 15(object 1, EventArgs 2)
	{
		1244 3 = this.24();
		3.1 = 1245.Finish;
		1226.30(3, 0f, false);
	}

	// Token: 0x060030A2 RID: 12450 RVA: 0x00117570 File Offset: 0x00115770
	private void 16(object 1, EventArgs 2)
	{
		1244 3 = this.24();
		3.1 = 1245.Clap;
		1226.30(3, 0f, false);
	}

	// Token: 0x060030A3 RID: 12451 RVA: 0x00117598 File Offset: 0x00115798
	private void 17(object 1, LinkLabelLinkClickedEventArgs 2)
	{
		1662.69(1661.21());
	}

	// Token: 0x060030A4 RID: 12452 RVA: 0x001175A4 File Offset: 0x001157A4
	private void 18(object 1, EventArgs 2)
	{
		this.36((TrackBar)1, 1.0);
		this.28(null, null);
	}

	// Token: 0x060030A5 RID: 12453 RVA: 0x001175C3 File Offset: 0x001157C3
	private void 19(object 1, EventArgs 2)
	{
		this.28(null, null);
	}

	// Token: 0x060030A6 RID: 12454 RVA: 0x001175CD File Offset: 0x001157CD
	private void 20(object 1, LinkLabelLinkClickedEventArgs 2)
	{
		1662.69(1661.22());
	}

	// Token: 0x060030A7 RID: 12455 RVA: 0x001175D9 File Offset: 0x001157D9
	private void 21(object 1, EventArgs 2)
	{
		this.83.Visible = false;
		this.9 = true;
		this.28(null, null);
	}

	// Token: 0x060030A8 RID: 12456 RVA: 0x001175F6 File Offset: 0x001157F6
	private void 22(object 1, EventArgs 2)
	{
		this.82.Visible = false;
		this.10 = true;
		this.28(null, null);
	}

	// Token: 0x060030A9 RID: 12457 RVA: 0x00117613 File Offset: 0x00115813
	private void 23(object 1, EventArgs 2)
	{
		this.89.Enabled = this.80.Checked;
		this.28(null, null);
	}

	// Token: 0x060030AA RID: 12458 RVA: 0x00117634 File Offset: 0x00115834
	private 1244 24()
	{
		1253 <<EMPTY_NAME>> = 1253.Default;
		1254 2;
		if (this.9)
		{
			2 = ((this.138.SelectedItem != null) ? ((1254)Enum.Parse(typeof(1254), this.138.SelectedItem.ToString())) : 1254.None);
			if (this.46.Checked)
			{
				<<EMPTY_NAME>> = 1253.Custom1;
			}
		}
		else
		{
			2 = 1226.73().4;
			<<EMPTY_NAME>> = 1226.73().2;
		}
		int 3 = (!this.10) ? 1226.73().6 : this.60.Value;
		return new 1244(1245.None, 2, <<EMPTY_NAME>>, 3, 1254.None);
	}

	// Token: 0x060030AB RID: 12459 RVA: 0x001176D8 File Offset: 0x001158D8
	private int 25()
	{
		int num = 0;
		while (num < 8 && this.13[num].4)
		{
			num++;
		}
		return num;
	}

	// Token: 0x060030AC RID: 12460 RVA: 0x00117704 File Offset: 0x00115904
	private void 26()
	{
		int num = this.25();
		if (this.67.Visible = (num < 8))
		{
			this.67.Location = this.13[num].Location;
		}
		this.68.Enabled = (num > 2);
		this.67.Enabled = (num < 8);
	}

	// Token: 0x060030AD RID: 12461 RVA: 0x00117764 File Offset: 0x00115964
	private void 27(object 1, EventArgs 2)
	{
		this.50.Color = this.63.BackColor;
		if (this.50.ShowDialog() == DialogResult.OK)
		{
			this.63.2(this.50.Color);
			this.28(null, null);
		}
	}

	// Token: 0x060030AE RID: 12462 RVA: 0x001177B4 File Offset: 0x001159B4
	internal 2320(bool 1, bool 2)
	{
		this.7 = 1;
		this.8 = 2;
		this.6 = 2263.4;
		this.29();
		if (Application.RenderWithVisualStyles)
		{
			foreach (object obj in this.55.TabPages)
			{
				((TabPage)obj).BackColor = SystemColors.ControlLightLight;
			}
			foreach (object obj2 in base.Controls)
			{
				Control control = (Control)obj2;
				if (control is TrackBar)
				{
					((TrackBar)control).BackColor = SystemColors.ControlLightLight;
				}
			}
		}
		base.DialogResult = DialogResult.Cancel;
	}

	// Token: 0x060030AF RID: 12463 RVA: 0x001178B4 File Offset: 0x00115AB4
	private void 28(object 1, EventArgs 2)
	{
		this.12 = true;
		this.16.Enabled = (this.18.Text.Length > 0 && this.19.Text.Length > 0 && this.64.Text.Length > 0 && this.21.Text.Length > 0);
	}

	// Token: 0x060030B1 RID: 12465 RVA: 0x00117944 File Offset: 0x00115B44
	private void 29()
	{
		this.15 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(2320));
		this.50 = new ColorDialog();
		this.72 = new ComboBox();
		this.73 = new Label();
		this.74 = new TextBox();
		this.75 = new Label();
		this.76 = new Label();
		this.77 = new Label();
		this.78 = new TextBox();
		this.79 = new TextBox();
		this.98 = new ToolTip(this.15);
		this.96 = new TextBox();
		this.64 = new ComboBox();
		this.99 = new TextBox();
		this.145 = new CheckBox();
		this.16 = new Button();
		this.38 = new Button();
		this.55 = new TabControl();
		this.56 = new TabPage();
		this.24 = new GroupBox();
		this.132 = new Panel();
		this.133 = new Label();
		this.134 = new TextBox();
		this.135 = new Panel();
		this.136 = new Label();
		this.137 = new TextBox();
		this.97 = new Label();
		this.37 = new Label();
		this.18 = new TextBox();
		this.17 = new Label();
		this.22 = new Label();
		this.20 = new Label();
		this.21 = new TextBox();
		this.19 = new TextBox();
		this.100 = new Label();
		this.43 = new GroupBox();
		this.143 = new Panel();
		this.107 = new Label();
		this.44 = new LinkLabel();
		this.45 = new LinkLabel();
		this.57 = new TabPage();
		this.25 = new GroupBox();
		this.150 = new CheckBox();
		this.111 = new Label();
		this.112 = new Label();
		this.113 = new Label();
		this.121 = new Label();
		this.149 = new Label();
		this.122 = new Label();
		this.123 = new Label();
		this.124 = new Label();
		this.125 = new TrackBar();
		this.36 = new Label();
		this.32 = new Label();
		this.33 = new Label();
		this.34 = new Label();
		this.35 = new TrackBar();
		this.65 = new Label();
		this.28 = new Label();
		this.29 = new Label();
		this.30 = new TrackBar();
		this.31 = new Label();
		this.27 = new Label();
		this.26 = new Label();
		this.23 = new TrackBar();
		this.58 = new TabPage();
		this.151 = new GroupBox();
		this.152 = new CheckBox();
		this.39 = new GroupBox();
		this.83 = new Panel();
		this.84 = new Button();
		this.110 = new Label();
		this.144 = new Panel();
		this.138 = new ListBox();
		this.139 = new Panel();
		this.108 = new Label();
		this.105 = new Button();
		this.82 = new Panel();
		this.85 = new Button();
		this.109 = new Label();
		this.66 = new Label();
		this.60 = new TrackBar();
		this.42 = new Button();
		this.61 = new LinkLabel();
		this.41 = new Button();
		this.46 = new CheckBox();
		this.40 = new Button();
		this.59 = new TabPage();
		this.62 = new GroupBox();
		this.140 = new Panel();
		this.114 = new Label();
		this.63 = new 2305();
		this.47 = new GroupBox();
		this.130 = new 2305();
		this.131 = new 2305();
		this.129 = new 2305();
		this.68 = new Button();
		this.67 = new Button();
		this.54 = new 2305();
		this.51 = new 2305();
		this.52 = new 2305();
		this.53 = new 2305();
		this.48 = new 2305();
		this.49 = new CheckBox();
		this.69 = new TabPage();
		this.103 = new GroupBox();
		this.117 = new Label();
		this.104 = new ComboBox();
		this.101 = new GroupBox();
		this.120 = new CheckBox();
		this.102 = new CheckBox();
		this.148 = new CheckBox();
		this.71 = new GroupBox();
		this.141 = new Panel();
		this.115 = new Label();
		this.89 = new Panel();
		this.126 = new NumericUpDown();
		this.127 = new Label();
		this.128 = new Label();
		this.118 = new Label();
		this.87 = new RadioButton();
		this.88 = new RadioButton();
		this.86 = new RadioButton();
		this.81 = new LinkLabel();
		this.80 = new CheckBox();
		this.70 = new TabPage();
		this.91 = new GroupBox();
		this.146 = new Panel();
		this.147 = new Label();
		this.119 = new Label();
		this.106 = new ComboBox();
		this.90 = new GroupBox();
		this.142 = new Panel();
		this.116 = new Label();
		this.92 = new Label();
		this.93 = new Label();
		this.94 = new Label();
		this.95 = new TrackBar();
		this.153 = new Panel();
		this.154 = new Panel();
		this.155 = new Panel();
		this.156 = new Panel();
		this.55.SuspendLayout();
		this.56.SuspendLayout();
		this.24.SuspendLayout();
		this.132.SuspendLayout();
		this.135.SuspendLayout();
		this.43.SuspendLayout();
		this.143.SuspendLayout();
		this.57.SuspendLayout();
		this.25.SuspendLayout();
		((ISupportInitialize)this.125).BeginInit();
		((ISupportInitialize)this.35).BeginInit();
		((ISupportInitialize)this.30).BeginInit();
		((ISupportInitialize)this.23).BeginInit();
		this.58.SuspendLayout();
		this.151.SuspendLayout();
		this.39.SuspendLayout();
		this.83.SuspendLayout();
		this.144.SuspendLayout();
		this.139.SuspendLayout();
		this.82.SuspendLayout();
		((ISupportInitialize)this.60).BeginInit();
		this.59.SuspendLayout();
		this.62.SuspendLayout();
		this.140.SuspendLayout();
		this.47.SuspendLayout();
		this.69.SuspendLayout();
		this.103.SuspendLayout();
		this.101.SuspendLayout();
		this.71.SuspendLayout();
		this.141.SuspendLayout();
		this.89.SuspendLayout();
		((ISupportInitialize)this.126).BeginInit();
		this.70.SuspendLayout();
		this.91.SuspendLayout();
		this.146.SuspendLayout();
		this.90.SuspendLayout();
		this.142.SuspendLayout();
		((ISupportInitialize)this.95).BeginInit();
		this.153.SuspendLayout();
		this.154.SuspendLayout();
		this.155.SuspendLayout();
		this.156.SuspendLayout();
		base.SuspendLayout();
		this.50.FullOpen = true;
		this.72.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
		this.72.AutoCompleteSource = AutoCompleteSource.ListItems;
		this.72.FormattingEnabled = true;
		this.72.Items.AddRange(new object[]
		{
			"Easy",
			"Normal",
			"Hard",
			"Insane"
		});
		this.72.Location = new Point(108, 96);
		this.72.Name = "comboBox1";
		this.72.Size = new Size(240, 21);
		this.72.TabIndex = 36;
		this.73.AutoSize = true;
		this.73.Location = new Point(55, 99);
		this.73.Name = "label16";
		this.73.Size = new Size(47, 13);
		this.73.TabIndex = 15;
		this.73.Text = "Difficulty";
		this.74.Location = new Point(107, 44);
		this.74.Name = "textBox7";
		this.74.Size = new Size(241, 20);
		this.74.TabIndex = 1;
		this.75.AutoSize = true;
		this.75.Location = new Point(76, 47);
		this.75.Name = "label23";
		this.75.Size = new Size(27, 13);
		this.75.TabIndex = 8;
		this.75.Text = "Title";
		this.76.AutoSize = true;
		this.76.Location = new Point(17, 73);
		this.76.Name = "label24";
		this.76.Size = new Size(86, 13);
		this.76.TabIndex = 13;
		this.76.Text = "Beatmap Creator";
		this.77.AutoSize = true;
		this.77.Location = new Point(73, 21);
		this.77.Name = "label25";
		this.77.Size = new Size(30, 13);
		this.77.TabIndex = 10;
		this.77.Text = "Artist";
		this.78.Location = new Point(107, 70);
		this.78.Name = "textBox8";
		this.78.Size = new Size(241, 20);
		this.78.TabIndex = 2;
		this.79.Location = new Point(107, 18);
		this.79.Name = "textBox9";
		this.79.Size = new Size(241, 20);
		this.79.TabIndex = 0;
		this.98.AutomaticDelay = 200;
		this.96.Location = new Point(141, 170);
		this.96.Name = "source";
		this.96.Size = new Size(218, 20);
		this.96.TabIndex = 6;
		this.98.SetToolTip(this.96, "If this song is from a series/game, name it here.");
		this.96.TextChanged += this.28;
		this.64.AutoCompleteSource = AutoCompleteSource.ListItems;
		this.64.FormattingEnabled = true;
		this.64.Items.AddRange(new object[]
		{
			"Easy",
			"Normal",
			"Hard",
			"Insane"
		});
		this.64.Location = new Point(141, 145);
		this.64.Name = "version";
		this.64.Size = new Size(218, 21);
		this.64.TabIndex = 5;
		this.98.SetToolTip(this.64, "While defaults in the drop-down are well-known, you may use any difficulty name you like.");
		this.64.TextChanged += this.28;
		this.99.Location = new Point(141, 195);
		this.99.Name = "tags";
		this.99.Size = new Size(218, 20);
		this.99.TabIndex = 7;
		this.98.SetToolTip(this.99, "Any words which can be used to identify this beatmap.  Separate with spaces.");
		this.99.TextChanged += this.28;
		this.145.AutoSize = true;
		this.145.Location = new Point(8, 45);
		this.145.Name = "cb_maniaSpecial";
		this.145.Size = new Size(223, 19);
		this.145.TabIndex = 53;
		this.145.Text = "Use special style(N+1 style) for mania";
		this.98.SetToolTip(this.145, "Notice: The left most column is used as special column");
		this.145.UseVisualStyleBackColor = true;
		this.145.CheckedChanged += delegate(object 1, EventArgs 2)
		{
			this.28(null, null);
		};
		this.16.FlatStyle = FlatStyle.System;
		this.16.Location = new Point(4, 392);
		this.16.Name = "buttonOk";
		this.16.Size = new Size(232, 34);
		this.16.TabIndex = 1;
		this.16.Text = "OK";
		this.16.UseVisualStyleBackColor = true;
		this.16.Click += this.45;
		this.38.DialogResult = DialogResult.OK;
		this.38.FlatStyle = FlatStyle.System;
		this.38.Location = new Point(242, 392);
		this.38.Name = "button1";
		this.38.Size = new Size(139, 34);
		this.38.TabIndex = 2;
		this.38.Text = "Cancel";
		this.38.UseVisualStyleBackColor = true;
		this.38.Click += this.47;
		this.55.Controls.Add(this.56);
		this.55.Controls.Add(this.57);
		this.55.Controls.Add(this.58);
		this.55.Controls.Add(this.59);
		this.55.Controls.Add(this.69);
		this.55.Controls.Add(this.70);
		this.55.Dock = DockStyle.Top;
		this.55.Location = new Point(0, 0);
		this.55.Name = "tabControl1";
		this.55.SelectedIndex = 0;
		this.55.Size = new Size(385, 386);
		this.55.TabIndex = 0;
		this.55.SelectedIndexChanged += delegate(object 1, EventArgs 2)
		{
			if (this.55.SelectedIndex == 3)
			{
				this.26();
			}
		};
		this.56.Controls.Add(this.24);
		this.56.Controls.Add(this.43);
		this.56.Location = new Point(4, 22);
		this.56.Name = "tabPage1";
		this.56.Padding = new Padding(3);
		this.56.Size = new Size(377, 360);
		this.56.TabIndex = 0;
		this.56.Text = "General";
		this.24.Controls.Add(this.132);
		this.24.Controls.Add(this.135);
		this.24.Controls.Add(this.96);
		this.24.Controls.Add(this.97);
		this.24.Controls.Add(this.64);
		this.24.Controls.Add(this.37);
		this.24.Controls.Add(this.18);
		this.24.Controls.Add(this.17);
		this.24.Controls.Add(this.22);
		this.24.Controls.Add(this.20);
		this.24.Controls.Add(this.21);
		this.24.Controls.Add(this.19);
		this.24.Controls.Add(this.99);
		this.24.Controls.Add(this.100);
		this.24.Location = new Point(6, 6);
		this.24.Name = "groupBox1";
		this.24.Size = new Size(365, 223);
		this.24.TabIndex = 0;
		this.24.TabStop = false;
		this.24.Text = "Song and Map Metadata";
		this.132.Controls.Add(this.133);
		this.132.Controls.Add(this.134);
		this.132.Enabled = false;
		this.132.Location = new Point(5, 45);
		this.132.Name = "panelRomanisedArtist";
		this.132.Size = new Size(356, 23);
		this.132.TabIndex = 1;
		this.133.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
		this.133.Location = new Point(1, 2);
		this.133.Name = "label31";
		this.133.Size = new Size(131, 16);
		this.133.TabIndex = 46;
		this.133.Text = "Romanised Artist";
		this.133.TextAlign = ContentAlignment.TopRight;
		this.134.Location = new Point(136, 0);
		this.134.Name = "artistRomanised";
		this.134.Size = new Size(218, 20);
		this.134.TabIndex = 1;
		this.134.TextChanged += this.44;
		this.135.Controls.Add(this.136);
		this.135.Controls.Add(this.137);
		this.135.Enabled = false;
		this.135.Location = new Point(6, 95);
		this.135.Name = "panelRomanisedTitle";
		this.135.Size = new Size(355, 23);
		this.135.TabIndex = 3;
		this.136.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
		this.136.Location = new Point(0, 2);
		this.136.Name = "label52";
		this.136.Size = new Size(131, 16);
		this.136.TabIndex = 47;
		this.136.Text = "Romanised Title";
		this.136.TextAlign = ContentAlignment.TopRight;
		this.137.Location = new Point(135, 0);
		this.137.Name = "titleRomanised";
		this.137.Size = new Size(218, 20);
		this.137.TabIndex = 3;
		this.137.TextChanged += this.43;
		this.97.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
		this.97.Location = new Point(32, 172);
		this.97.Name = "label29";
		this.97.Size = new Size(105, 16);
		this.97.TabIndex = 37;
		this.97.Text = "Source";
		this.97.TextAlign = ContentAlignment.TopRight;
		this.37.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
		this.37.Location = new Point(32, 147);
		this.37.Name = "label14";
		this.37.Size = new Size(105, 16);
		this.37.TabIndex = 15;
		this.37.Text = "Difficulty";
		this.37.TextAlign = ContentAlignment.TopRight;
		this.18.Location = new Point(141, 70);
		this.18.Name = "title";
		this.18.Size = new Size(218, 20);
		this.18.TabIndex = 2;
		this.18.TextChanged += this.43;
		this.17.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
		this.17.Location = new Point(32, 72);
		this.17.Name = "label3";
		this.17.Size = new Size(105, 16);
		this.17.TabIndex = 8;
		this.17.Text = "Title";
		this.17.TextAlign = ContentAlignment.TopRight;
		this.22.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
		this.22.Location = new Point(5, 122);
		this.22.Name = "label1";
		this.22.Size = new Size(132, 16);
		this.22.TabIndex = 13;
		this.22.Text = "Beatmap Creator";
		this.22.TextAlign = ContentAlignment.TopRight;
		this.20.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
		this.20.Location = new Point(32, 22);
		this.20.Name = "artistLabel";
		this.20.Size = new Size(105, 16);
		this.20.TabIndex = 10;
		this.20.Text = "Artist";
		this.20.TextAlign = ContentAlignment.TopRight;
		this.21.Location = new Point(141, 120);
		this.21.Name = "creator";
		this.21.Size = new Size(218, 20);
		this.21.TabIndex = 4;
		this.21.TextChanged += this.28;
		this.19.Location = new Point(141, 20);
		this.19.Name = "artist";
		this.19.Size = new Size(218, 20);
		this.19.TabIndex = 0;
		this.19.TextChanged += this.44;
		this.100.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
		this.100.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
		this.100.Location = new Point(32, 197);
		this.100.Name = "tagsLabel";
		this.100.Size = new Size(105, 16);
		this.100.TabIndex = 39;
		this.100.Text = "Tags";
		this.100.TextAlign = ContentAlignment.TopRight;
		this.43.Controls.Add(this.143);
		this.43.Controls.Add(this.44);
		this.43.Controls.Add(this.45);
		this.43.Location = new Point(6, 234);
		this.43.Name = "groupBox5";
		this.43.Size = new Size(365, 118);
		this.43.TabIndex = 6;
		this.43.TabStop = false;
		this.43.Text = "A quick note";
		this.143.Controls.Add(this.107);
		this.143.Location = new Point(6, 18);
		this.143.Name = "panel10";
		this.143.Size = new Size(353, 70);
		this.143.TabIndex = 42;
		this.107.Dock = DockStyle.Fill;
		this.107.ForeColor = Color.Red;
		this.107.Location = new Point(0, 0);
		this.107.Name = "label30";
		this.107.Size = new Size(353, 70);
		this.107.TabIndex = 41;
		this.107.Text = "Due to the large number of beatmap submissions, the standard of approval is relatively high.  Please ensure your beatmap is at least timed properly, or it will likely be ignored!";
		this.44.ActiveLinkColor = SystemColors.Highlight;
		this.44.AutoSize = true;
		this.44.LinkColor = SystemColors.HotTrack;
		this.44.Location = new Point(182, 91);
		this.44.Name = "linkLabel2";
		this.44.Size = new Size(150, 15);
		this.44.TabIndex = 34;
		this.44.TabStop = true;
		this.44.Text = "Official Submission Criteria";
		this.44.LinkClicked += this.42;
		this.45.ActiveLinkColor = SystemColors.Highlight;
		this.45.AutoSize = true;
		this.45.LinkColor = SystemColors.HotTrack;
		this.45.Location = new Point(31, 91);
		this.45.Name = "linkLabel1";
		this.45.Size = new Size(99, 15);
		this.45.TabIndex = 33;
		this.45.TabStop = true;
		this.45.Text = "Editor Guide/FAQ";
		this.45.LinkClicked += delegate(object 1, LinkLabelLinkClickedEventArgs 2)
		{
			1662.69(1661.10());
		};
		this.57.Controls.Add(this.25);
		this.57.Location = new Point(4, 22);
		this.57.Name = "tabPage4";
		this.57.Size = new Size(377, 360);
		this.57.TabIndex = 3;
		this.57.Text = "Difficulty";
		this.57.Enter += this.39;
		this.25.Controls.Add(this.156);
		this.25.Controls.Add(this.155);
		this.25.Controls.Add(this.154);
		this.25.Controls.Add(this.150);
		this.25.Controls.Add(this.149);
		this.25.Controls.Add(this.122);
		this.25.Controls.Add(this.123);
		this.25.Controls.Add(this.124);
		this.25.Controls.Add(this.125);
		this.25.Controls.Add(this.36);
		this.25.Controls.Add(this.32);
		this.25.Controls.Add(this.33);
		this.25.Controls.Add(this.34);
		this.25.Controls.Add(this.35);
		this.25.Controls.Add(this.65);
		this.25.Controls.Add(this.28);
		this.25.Controls.Add(this.29);
		this.25.Controls.Add(this.30);
		this.25.Controls.Add(this.31);
		this.25.Controls.Add(this.27);
		this.25.Controls.Add(this.26);
		this.25.Controls.Add(this.23);
		this.25.Controls.Add(this.153);
		this.25.Location = new Point(4, 6);
		this.25.Name = "groupBox2";
		this.25.Size = new Size(365, 351);
		this.25.TabIndex = 1;
		this.25.TabStop = false;
		this.25.Text = "Difficulty";
		this.150.AutoSize = true;
		this.150.Location = new Point(12, 124);
		this.150.Name = "coopmode";
		this.150.Size = new Size(94, 19);
		this.150.TabIndex = 60;
		this.150.Text = "Co-op mode";
		this.150.UseVisualStyleBackColor = true;
		this.150.CheckedChanged += this.41;
		this.111.Dock = DockStyle.Fill;
		this.111.Location = new Point(0, 0);
		this.111.Name = "lblOverallDifficultyDescr";
		this.111.Size = new Size(350, 25);
		this.111.TabIndex = 49;
		this.111.Text = "The harshness of the hit window and the difficulty of spinners";
		this.112.Dock = DockStyle.Fill;
		this.112.Location = new Point(0, 0);
		this.112.Name = "lblCircleSizeDescr";
		this.112.Size = new Size(350, 19);
		this.112.TabIndex = 48;
		this.112.Text = "The radial size of hit circles and sliders";
		this.113.Dock = DockStyle.Fill;
		this.113.Location = new Point(0, 0);
		this.113.Name = "lblDrainDescr";
		this.113.Size = new Size(350, 21);
		this.113.TabIndex = 47;
		this.113.Text = "The constant rate of health-bar drain throughout the song";
		this.121.Dock = DockStyle.Fill;
		this.121.Location = new Point(0, 0);
		this.121.Name = "lblApproachRateDescr";
		this.121.Size = new Size(350, 19);
		this.121.TabIndex = 54;
		this.121.Text = "The speed at which objects appear";
		this.149.AutoSize = true;
		this.149.Font = new Font("Segoe UI", 9f, FontStyle.Italic);
		this.149.Location = new Point(66, 331);
		this.149.Name = "label17";
		this.149.Size = new Size(229, 15);
		this.149.TabIndex = 59;
		this.149.Text = "Hold shift for precise difficulty adjustment.";
		this.122.AutoSize = true;
		this.122.Location = new Point(327, 196);
		this.122.Name = "label45";
		this.122.Size = new Size(28, 15);
		this.122.TabIndex = 53;
		this.122.Text = "Fast";
		this.122.TextAlign = ContentAlignment.TopRight;
		this.123.AutoSize = true;
		this.123.Location = new Point(122, 196);
		this.123.Name = "label46";
		this.123.Size = new Size(32, 15);
		this.123.TabIndex = 52;
		this.123.Text = "Slow";
		this.124.AutoSize = true;
		this.124.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
		this.124.Location = new Point(10, 176);
		this.124.Name = "label47";
		this.124.Size = new Size(89, 15);
		this.124.TabIndex = 51;
		this.124.Text = "Approach Rate";
		this.125.Location = new Point(118, 168);
		this.125.Name = "approachRate";
		this.125.Size = new Size(241, 45);
		this.125.TabIndex = 2;
		this.125.TickFrequency = 10;
		this.125.Value = 10;
		this.125.Scroll += this.33;
		this.125.MouseCaptureChanged += this.37;
		this.125.MouseDown += this.35;
		this.36.AutoSize = true;
		this.36.Location = new Point(216, 124);
		this.36.Name = "label10";
		this.36.Size = new Size(47, 15);
		this.36.TabIndex = 31;
		this.36.Text = "Normal";
		this.32.AutoSize = true;
		this.32.Location = new Point(319, 124);
		this.32.Name = "label11";
		this.32.Size = new Size(36, 15);
		this.32.TabIndex = 30;
		this.32.Text = "Small";
		this.32.TextAlign = ContentAlignment.TopRight;
		this.33.AutoSize = true;
		this.33.Location = new Point(122, 124);
		this.33.Name = "label12";
		this.33.Size = new Size(36, 15);
		this.33.TabIndex = 29;
		this.33.Text = "Large";
		this.34.AutoSize = true;
		this.34.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
		this.34.Location = new Point(10, 102);
		this.34.Name = "label13";
		this.34.Size = new Size(64, 15);
		this.34.TabIndex = 27;
		this.34.Text = "Circle Size";
		this.35.LargeChange = 1;
		this.35.Location = new Point(118, 93);
		this.35.Name = "circleSize";
		this.35.Size = new Size(241, 45);
		this.35.TabIndex = 1;
		this.35.TickFrequency = 10;
		this.35.Scroll += delegate(object 1, EventArgs 2)
		{
			TrackBar trackBar = 1 as TrackBar;
			if (this.106.SelectedIndex != 3 && !this.11)
			{
				trackBar.Value = (int)Math.Round((double)trackBar.Value / 10.0) * 10;
			}
			this.36(trackBar, (this.106.SelectedIndex == 3) ? 1.0 : 0.1);
			this.28(null, null);
		};
		this.35.ValueChanged += delegate(object 1, EventArgs 2)
		{
			this.150.Enabled = (1272.5().3() == 2147.OsuMania && this.35.Value >= 5);
			if (!this.150.Enabled)
			{
				this.150.Checked = false;
			}
		};
		this.35.MouseCaptureChanged += this.37;
		this.35.MouseDown += this.35;
		this.65.AutoSize = true;
		this.65.Location = new Point(314, 270);
		this.65.Name = "label6";
		this.65.Size = new Size(41, 15);
		this.65.TabIndex = 20;
		this.65.Text = "Insane";
		this.65.TextAlign = ContentAlignment.TopRight;
		this.28.AutoSize = true;
		this.28.Location = new Point(122, 270);
		this.28.Name = "label7";
		this.28.Size = new Size(30, 15);
		this.28.TabIndex = 19;
		this.28.Text = "Easy";
		this.29.AutoSize = true;
		this.29.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
		this.29.Location = new Point(10, 250);
		this.29.Name = "label8";
		this.29.Size = new Size(102, 15);
		this.29.TabIndex = 17;
		this.29.Text = "Overall Difficulty";
		this.30.Location = new Point(118, 241);
		this.30.Name = "overallDifficulty";
		this.30.Size = new Size(241, 45);
		this.30.TabIndex = 3;
		this.30.TickFrequency = 10;
		this.30.Value = 10;
		this.30.Scroll += delegate(object 1, EventArgs 2)
		{
			TrackBar trackBar = 1 as TrackBar;
			if (!this.11)
			{
				trackBar.Value = (int)Math.Round((double)trackBar.Value / 10.0) * 10;
			}
			this.36(trackBar, 0.1);
			this.28(null, null);
		};
		this.30.MouseCaptureChanged += this.37;
		this.30.MouseDown += this.35;
		this.31.AutoSize = true;
		this.31.Location = new Point(314, 47);
		this.31.Name = "label5";
		this.31.Size = new Size(41, 15);
		this.31.TabIndex = 16;
		this.31.Text = "Insane";
		this.31.TextAlign = ContentAlignment.TopRight;
		this.27.AutoSize = true;
		this.27.Location = new Point(122, 47);
		this.27.Name = "label4";
		this.27.Size = new Size(30, 15);
		this.27.TabIndex = 15;
		this.27.Text = "Easy";
		this.26.AutoSize = true;
		this.26.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
		this.26.Location = new Point(10, 28);
		this.26.Name = "label2";
		this.26.Size = new Size(85, 15);
		this.26.TabIndex = 14;
		this.26.Text = "HP Drain Rate";
		this.23.Location = new Point(118, 19);
		this.23.Name = "hpDrainRate";
		this.23.Size = new Size(241, 45);
		this.23.TabIndex = 0;
		this.23.TickFrequency = 10;
		this.23.Value = 10;
		this.23.Scroll += this.32;
		this.23.MouseCaptureChanged += this.37;
		this.23.MouseDown += this.35;
		this.58.Controls.Add(this.151);
		this.58.Controls.Add(this.39);
		this.58.Location = new Point(4, 22);
		this.58.Name = "tabPage2";
		this.58.Padding = new Padding(3);
		this.58.Size = new Size(377, 360);
		this.58.TabIndex = 1;
		this.58.Text = "Audio";
		this.151.Controls.Add(this.152);
		this.151.Location = new Point(6, 282);
		this.151.Name = "groupBox4";
		this.151.Size = new Size(365, 44);
		this.151.TabIndex = 3;
		this.151.TabStop = false;
		this.151.Text = "Misc. Toggles";
		this.152.AutoSize = true;
		this.152.Location = new Point(8, 21);
		this.152.Name = "checkSamplesMatchPlaybackRate";
		this.152.Size = new Size(329, 19);
		this.152.TabIndex = 0;
		this.152.Text = "Samples match playback rate (for fully-hitsounded maps)";
		this.152.UseVisualStyleBackColor = true;
		this.152.CheckedChanged += this.28;
		this.39.Controls.Add(this.83);
		this.39.Controls.Add(this.144);
		this.39.Controls.Add(this.139);
		this.39.Controls.Add(this.105);
		this.39.Controls.Add(this.82);
		this.39.Controls.Add(this.66);
		this.39.Controls.Add(this.60);
		this.39.Controls.Add(this.42);
		this.39.Controls.Add(this.61);
		this.39.Controls.Add(this.41);
		this.39.Controls.Add(this.46);
		this.39.Controls.Add(this.40);
		this.39.Location = new Point(6, 6);
		this.39.Name = "groupBox3";
		this.39.Size = new Size(365, 270);
		this.39.TabIndex = 2;
		this.39.TabStop = false;
		this.39.Text = "Default Sample Settings";
		this.83.Controls.Add(this.84);
		this.83.Controls.Add(this.110);
		this.83.Location = new Point(8, 22);
		this.83.Name = "hideSampleSettings";
		this.83.Size = new Size(353, 73);
		this.83.TabIndex = 40;
		this.83.Visible = false;
		this.84.FlatStyle = FlatStyle.System;
		this.84.Location = new Point(226, 40);
		this.84.Name = "buttonSampleReset";
		this.84.Size = new Size(123, 23);
		this.84.TabIndex = 0;
		this.84.Text = "Reset Settings";
		this.84.UseVisualStyleBackColor = true;
		this.84.Click += this.21;
		this.110.AutoSize = true;
		this.110.Location = new Point(5, 4);
		this.110.Name = "label34";
		this.110.Size = new Size(336, 30);
		this.110.TabIndex = 46;
		this.110.Text = "This beatmap has timing-section dependent volume settings.  \r\nYou can therefore not set beatmap-wide settings here.";
		this.144.Controls.Add(this.138);
		this.144.Location = new Point(11, 22);
		this.144.Name = "panel11";
		this.144.Size = new Size(133, 73);
		this.144.TabIndex = 44;
		this.138.Dock = DockStyle.Fill;
		this.138.FormattingEnabled = true;
		this.138.Items.AddRange(new object[]
		{
			"Normal",
			"Soft",
			"Drum"
		});
		this.138.Location = new Point(0, 0);
		this.138.Name = "listSampleset";
		this.138.Size = new Size(133, 73);
		this.138.TabIndex = 42;
		this.138.SelectedValueChanged += delegate(object 1, EventArgs 2)
		{
			this.28(null, null);
		};
		this.139.Controls.Add(this.108);
		this.139.Location = new Point(6, 207);
		this.139.Name = "panel1";
		this.139.Size = new Size(353, 57);
		this.139.TabIndex = 43;
		this.108.Dock = DockStyle.Fill;
		this.108.Location = new Point(0, 0);
		this.108.Name = "label32";
		this.108.Size = new Size(353, 57);
		this.108.TabIndex = 37;
		this.108.Text = "Sample settings (sets and volume) can also be assigned independently for each timing section via the timing setup panel (F6 in the editor).";
		this.105.FlatStyle = FlatStyle.System;
		this.105.Location = new Point(280, 170);
		this.105.Name = "buttonClap";
		this.105.Size = new Size(79, 23);
		this.105.TabIndex = 5;
		this.105.Text = "Clap";
		this.105.UseVisualStyleBackColor = true;
		this.105.Click += this.16;
		this.82.Controls.Add(this.85);
		this.82.Controls.Add(this.109);
		this.82.Location = new Point(8, 101);
		this.82.Name = "hideSampleVolume";
		this.82.Size = new Size(353, 65);
		this.82.TabIndex = 41;
		this.82.Visible = false;
		this.85.FlatStyle = FlatStyle.System;
		this.85.Location = new Point(226, 40);
		this.85.Name = "buttonVolumeReset";
		this.85.Size = new Size(123, 23);
		this.85.TabIndex = 1;
		this.85.Text = "Reset Settings";
		this.85.UseVisualStyleBackColor = true;
		this.85.Click += this.22;
		this.109.Location = new Point(4, 4);
		this.109.Name = "label33";
		this.109.Size = new Size(345, 41);
		this.109.TabIndex = 45;
		this.109.Text = "This beatmap has timing-section dependent volume settings.  \r\nYou can therefore not set beatmap-wide settings here.";
		this.66.AutoSize = true;
		this.66.Location = new Point(8, 101);
		this.66.Name = "label15";
		this.66.Size = new Size(89, 15);
		this.66.TabIndex = 39;
		this.66.Text = "Sample Volume";
		this.60.LargeChange = 500;
		this.60.Location = new Point(6, 119);
		this.60.Maximum = 100;
		this.60.Name = "volume1";
		this.60.Size = new Size(353, 45);
		this.60.SmallChange = 5;
		this.60.TabIndex = 37;
		this.60.TickFrequency = 10;
		this.60.Value = 100;
		this.60.Scroll += this.18;
		this.60.MouseCaptureChanged += this.37;
		this.60.MouseDown += this.35;
		this.42.FlatStyle = FlatStyle.System;
		this.42.Location = new Point(5, 170);
		this.42.Name = "buttonHit";
		this.42.Size = new Size(75, 23);
		this.42.TabIndex = 2;
		this.42.Text = "Normal";
		this.42.UseVisualStyleBackColor = true;
		this.42.Click += this.13;
		this.61.AutoSize = true;
		this.61.LinkColor = SystemColors.HotTrack;
		this.61.Location = new Point(150, 45);
		this.61.Name = "linkLabel4";
		this.61.Size = new Size(204, 15);
		this.61.TabIndex = 38;
		this.61.TabStop = true;
		this.61.Text = "How to add custom sample overrides";
		this.61.LinkClicked += this.17;
		this.41.FlatStyle = FlatStyle.System;
		this.41.Location = new Point(98, 170);
		this.41.Name = "buttonWhistle";
		this.41.Size = new Size(75, 23);
		this.41.TabIndex = 3;
		this.41.Text = "Whistle";
		this.41.UseVisualStyleBackColor = true;
		this.41.Click += this.14;
		this.46.AutoSize = true;
		this.46.FlatStyle = FlatStyle.System;
		this.46.Location = new Point(153, 22);
		this.46.Name = "sampleCustom";
		this.46.Size = new Size(161, 20);
		this.46.TabIndex = 37;
		this.46.Text = "Enable custom overrides";
		this.46.UseVisualStyleBackColor = true;
		this.46.CheckedChanged += this.19;
		this.40.FlatStyle = FlatStyle.System;
		this.40.Location = new Point(190, 170);
		this.40.Name = "buttonFinish";
		this.40.Size = new Size(75, 23);
		this.40.TabIndex = 4;
		this.40.Text = "Finish";
		this.40.UseVisualStyleBackColor = true;
		this.40.Click += this.15;
		this.59.Controls.Add(this.62);
		this.59.Controls.Add(this.47);
		this.59.Location = new Point(4, 22);
		this.59.Name = "tabPage3";
		this.59.Size = new Size(377, 360);
		this.59.TabIndex = 2;
		this.59.Text = "Colours";
		this.62.Controls.Add(this.140);
		this.62.Controls.Add(this.63);
		this.62.Location = new Point(3, 208);
		this.62.Name = "groupBox8";
		this.62.Size = new Size(365, 115);
		this.62.TabIndex = 39;
		this.62.TabStop = false;
		this.62.Text = "Playfield Background";
		this.140.Controls.Add(this.114);
		this.140.Location = new Point(6, 57);
		this.140.Name = "panel2";
		this.140.Size = new Size(353, 52);
		this.140.TabIndex = 48;
		this.114.Dock = DockStyle.Fill;
		this.114.Location = new Point(0, 0);
		this.114.Name = "label35";
		this.114.Size = new Size(353, 52);
		this.114.TabIndex = 47;
		this.114.Text = "Please note that this colour is dimmed in both editor compose mode and in gameplay during playtime.  It will be the exact shade of the chosen colour during breaks.";
		this.63.FlatAppearance.BorderColor = Color.Black;
		this.63.FlatAppearance.BorderSize = 2;
		this.63.FlatStyle = FlatStyle.Flat;
		this.63.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this.63.ForeColor = Color.White;
		this.63.Location = new Point(7, 19);
		this.63.Name = "backgroundColour";
		this.63.Size = new Size(352, 32);
		this.63.2(Color.Empty);
		this.63.TabIndex = 2;
		this.63.Text = "Background Colour";
		this.63.UseVisualStyleBackColor = false;
		this.63.Click += this.27;
		this.47.Controls.Add(this.130);
		this.47.Controls.Add(this.131);
		this.47.Controls.Add(this.129);
		this.47.Controls.Add(this.68);
		this.47.Controls.Add(this.67);
		this.47.Controls.Add(this.54);
		this.47.Controls.Add(this.51);
		this.47.Controls.Add(this.52);
		this.47.Controls.Add(this.53);
		this.47.Controls.Add(this.48);
		this.47.Controls.Add(this.49);
		this.47.Location = new Point(3, 3);
		this.47.Name = "groupBox6";
		this.47.Size = new Size(365, 202);
		this.47.TabIndex = 20;
		this.47.TabStop = false;
		this.47.Text = "Hitcircle/Slider Combos";
		this.130.FlatAppearance.BorderColor = Color.Black;
		this.130.FlatAppearance.BorderSize = 2;
		this.130.FlatStyle = FlatStyle.Flat;
		this.130.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this.130.ForeColor = Color.White;
		this.130.Location = new Point(185, 121);
		this.130.Name = "combo8";
		this.130.Size = new Size(172, 32);
		this.130.2(Color.Empty);
		this.130.TabIndex = 46;
		this.130.Text = "Combo 8";
		this.130.UseVisualStyleBackColor = false;
		this.130.Click += delegate(object 1, EventArgs 2)
		{
			2305 3 = (2305)1;
			this.50.Color = 3.1();
			if (this.50.ShowDialog() == DialogResult.OK)
			{
				3.2(this.50.Color);
				this.49.Checked = true;
				this.28(null, null);
			}
		};
		this.131.FlatAppearance.BorderColor = Color.Black;
		this.131.FlatAppearance.BorderSize = 2;
		this.131.FlatStyle = FlatStyle.Flat;
		this.131.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this.131.ForeColor = Color.White;
		this.131.Location = new Point(7, 121);
		this.131.Name = "combo7";
		this.131.Size = new Size(172, 32);
		this.131.2(Color.Empty);
		this.131.TabIndex = 45;
		this.131.Text = "Combo 7";
		this.131.UseVisualStyleBackColor = false;
		this.131.Click += delegate(object 1, EventArgs 2)
		{
			2305 3 = (2305)1;
			this.50.Color = 3.1();
			if (this.50.ShowDialog() == DialogResult.OK)
			{
				3.2(this.50.Color);
				this.49.Checked = true;
				this.28(null, null);
			}
		};
		this.129.FlatAppearance.BorderColor = Color.Black;
		this.129.FlatAppearance.BorderSize = 2;
		this.129.FlatStyle = FlatStyle.Flat;
		this.129.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this.129.ForeColor = Color.White;
		this.129.Location = new Point(185, 87);
		this.129.Name = "combo6";
		this.129.Size = new Size(172, 32);
		this.129.2(Color.Empty);
		this.129.TabIndex = 44;
		this.129.Text = "Combo 6";
		this.129.UseVisualStyleBackColor = false;
		this.129.Click += delegate(object 1, EventArgs 2)
		{
			2305 3 = (2305)1;
			this.50.Color = 3.1();
			if (this.50.ShowDialog() == DialogResult.OK)
			{
				3.2(this.50.Color);
				this.49.Checked = true;
				this.28(null, null);
			}
		};
		this.68.FlatStyle = FlatStyle.System;
		this.68.Location = new Point(185, 164);
		this.68.Name = "buttonRemoveCombo";
		this.68.Size = new Size(172, 32);
		this.68.TabIndex = 43;
		this.68.Text = "Remove Combo Colour";
		this.68.UseVisualStyleBackColor = true;
		this.68.Click += delegate(object 1, EventArgs 2)
		{
			int num = this.25();
			this.13[num - 1].Visible = false;
			this.13[num - 1].4 = false;
			this.26();
			this.49.Checked = true;
			this.28(null, null);
		};
		this.67.FlatStyle = FlatStyle.System;
		this.67.Location = new Point(136, 186);
		this.67.Name = "buttonAddCombo";
		this.67.Size = new Size(172, 32);
		this.67.TabIndex = 42;
		this.67.Text = "New Combo Colour";
		this.67.UseVisualStyleBackColor = true;
		this.67.Click += delegate(object 1, EventArgs 2)
		{
			int num = this.25();
			this.50.Color = Color.FromArgb(240, 240, 240);
			if (this.50.ShowDialog() == DialogResult.OK)
			{
				this.13[num].2(this.50.Color);
				this.13[num].Visible = true;
				this.13[num].4 = true;
				this.26();
				this.49.Checked = true;
				this.28(null, null);
			}
		};
		this.54.FlatAppearance.BorderColor = Color.Black;
		this.54.FlatAppearance.BorderSize = 2;
		this.54.FlatStyle = FlatStyle.Flat;
		this.54.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this.54.ForeColor = Color.White;
		this.54.Location = new Point(7, 87);
		this.54.Name = "combo5";
		this.54.Size = new Size(172, 32);
		this.54.2(Color.Empty);
		this.54.TabIndex = 41;
		this.54.Text = "Combo 5";
		this.54.UseVisualStyleBackColor = false;
		this.54.Click += delegate(object 1, EventArgs 2)
		{
			2305 3 = (2305)1;
			this.50.Color = 3.1();
			if (this.50.ShowDialog() == DialogResult.OK)
			{
				3.2(this.50.Color);
				this.49.Checked = true;
				this.28(null, null);
			}
		};
		this.51.FlatAppearance.BorderColor = Color.Black;
		this.51.FlatAppearance.BorderSize = 2;
		this.51.FlatStyle = FlatStyle.Flat;
		this.51.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this.51.ForeColor = Color.White;
		this.51.Location = new Point(185, 53);
		this.51.Name = "combo4";
		this.51.Size = new Size(172, 32);
		this.51.2(Color.Empty);
		this.51.TabIndex = 4;
		this.51.Text = "Combo 4";
		this.51.UseVisualStyleBackColor = false;
		this.51.Click += delegate(object 1, EventArgs 2)
		{
			2305 3 = (2305)1;
			this.50.Color = 3.1();
			if (this.50.ShowDialog() == DialogResult.OK)
			{
				3.2(this.50.Color);
				this.49.Checked = true;
				this.28(null, null);
			}
		};
		this.52.FlatAppearance.BorderColor = Color.Black;
		this.52.FlatAppearance.BorderSize = 2;
		this.52.FlatStyle = FlatStyle.Flat;
		this.52.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this.52.ForeColor = Color.White;
		this.52.Location = new Point(7, 53);
		this.52.Name = "combo3";
		this.52.Size = new Size(172, 32);
		this.52.2(Color.Empty);
		this.52.TabIndex = 3;
		this.52.Text = "Combo 3";
		this.52.UseVisualStyleBackColor = false;
		this.52.Click += delegate(object 1, EventArgs 2)
		{
			2305 3 = (2305)1;
			this.50.Color = 3.1();
			if (this.50.ShowDialog() == DialogResult.OK)
			{
				3.2(this.50.Color);
				this.49.Checked = true;
				this.28(null, null);
			}
		};
		this.53.BackColor = Color.Transparent;
		this.53.FlatAppearance.BorderColor = Color.Black;
		this.53.FlatAppearance.BorderSize = 2;
		this.53.FlatStyle = FlatStyle.Flat;
		this.53.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this.53.ForeColor = Color.White;
		this.53.Location = new Point(185, 19);
		this.53.Name = "combo2";
		this.53.Size = new Size(172, 32);
		this.53.2(Color.Empty);
		this.53.TabIndex = 2;
		this.53.Text = "Combo 2";
		this.53.UseVisualStyleBackColor = false;
		this.53.Click += delegate(object 1, EventArgs 2)
		{
			2305 3 = (2305)1;
			this.50.Color = 3.1();
			if (this.50.ShowDialog() == DialogResult.OK)
			{
				3.2(this.50.Color);
				this.49.Checked = true;
				this.28(null, null);
			}
		};
		this.48.FlatAppearance.BorderColor = Color.Black;
		this.48.FlatAppearance.BorderSize = 2;
		this.48.FlatStyle = FlatStyle.Flat;
		this.48.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
		this.48.ForeColor = Color.White;
		this.48.Location = new Point(7, 19);
		this.48.Name = "combo1";
		this.48.Size = new Size(172, 32);
		this.48.2(Color.Empty);
		this.48.TabIndex = 1;
		this.48.Text = "Combo 1";
		this.48.UseVisualStyleBackColor = false;
		this.48.Click += delegate(object 1, EventArgs 2)
		{
			2305 3 = (2305)1;
			this.50.Color = 3.1();
			if (this.50.ShowDialog() == DialogResult.OK)
			{
				3.2(this.50.Color);
				this.49.Checked = true;
				this.28(null, null);
			}
		};
		this.49.AutoSize = true;
		this.49.FlatStyle = FlatStyle.System;
		this.49.Location = new Point(12, 171);
		this.49.Name = "customColour";
		this.49.Size = new Size(156, 20);
		this.49.TabIndex = 0;
		this.49.Text = "Enable Custom Colours";
		this.49.UseVisualStyleBackColor = true;
		this.49.CheckedChanged += delegate(object 1, EventArgs 2)
		{
			this.26();
			this.28(null, null);
		};
		this.69.Controls.Add(this.103);
		this.69.Controls.Add(this.101);
		this.69.Controls.Add(this.71);
		this.69.Location = new Point(4, 22);
		this.69.Name = "tabPage5";
		this.69.Size = new Size(377, 360);
		this.69.TabIndex = 4;
		this.69.Text = "Design";
		this.103.Controls.Add(this.117);
		this.103.Controls.Add(this.104);
		this.103.Location = new Point(6, 311);
		this.103.Name = "groupBox12";
		this.103.Size = new Size(365, 41);
		this.103.TabIndex = 41;
		this.103.TabStop = false;
		this.103.Text = "Skinning";
		this.117.AutoSize = true;
		this.117.Location = new Point(6, 19);
		this.117.Name = "label44";
		this.117.Size = new Size(83, 15);
		this.117.TabIndex = 50;
		this.117.Text = "Preferred Skin:";
		this.104.FlatStyle = FlatStyle.System;
		this.104.FormattingEnabled = true;
		this.104.Items.AddRange(new object[]
		{
			"User's preference (No Change)"
		});
		this.104.Location = new Point(95, 16);
		this.104.Name = "skinPreference";
		this.104.Size = new Size(263, 21);
		this.104.TabIndex = 55;
		this.104.TextChanged += this.28;
		this.101.Controls.Add(this.120);
		this.101.Controls.Add(this.102);
		this.101.Controls.Add(this.148);
		this.101.Location = new Point(6, 189);
		this.101.Name = "groupBox11";
		this.101.Size = new Size(365, 116);
		this.101.TabIndex = 40;
		this.101.TabStop = false;
		this.101.Text = "Misc. Toggles";
		this.120.AutoSize = true;
		this.120.FlatStyle = FlatStyle.System;
		this.120.Location = new Point(10, 66);
		this.120.Name = "checkEpilepsy";
		this.120.Size = new Size(330, 20);
		this.120.TabIndex = 54;
		this.120.Text = "Display epilepsy warning (storyboard has quick strobing)";
		this.120.UseVisualStyleBackColor = true;
		this.120.CheckedChanged += this.28;
		this.102.AutoSize = true;
		this.102.FlatStyle = FlatStyle.System;
		this.102.Location = new Point(10, 44);
		this.102.Name = "checkLetterbox";
		this.102.Size = new Size(157, 20);
		this.102.TabIndex = 52;
		this.102.Text = "Letterbox during breaks";
		this.102.UseVisualStyleBackColor = true;
		this.102.CheckedChanged += this.28;
		this.148.AutoSize = true;
		this.148.FlatStyle = FlatStyle.System;
		this.148.Location = new Point(10, 22);
		this.148.Margin = new Padding(6);
		this.148.Name = "checkWidescreen";
		this.148.Size = new Size(138, 20);
		this.148.TabIndex = 55;
		this.148.Text = "Widescreen Support";
		this.148.UseVisualStyleBackColor = true;
		this.148.CheckedChanged += this.28;
		this.71.Controls.Add(this.141);
		this.71.Controls.Add(this.89);
		this.71.Controls.Add(this.81);
		this.71.Controls.Add(this.80);
		this.71.Location = new Point(6, 4);
		this.71.Name = "groupBox7";
		this.71.Size = new Size(365, 179);
		this.71.TabIndex = 1;
		this.71.TabStop = false;
		this.71.Text = "Countdown";
		this.141.Controls.Add(this.115);
		this.141.Location = new Point(3, 40);
		this.141.Name = "panel3";
		this.141.Size = new Size(356, 50);
		this.141.TabIndex = 49;
		this.115.Dock = DockStyle.Fill;
		this.115.Location = new Point(0, 0);
		this.115.Name = "label36";
		this.115.Size = new Size(356, 50);
		this.115.TabIndex = 48;
		this.115.Text = "If this is checked, an \"Are you ready? 3, 2, 1, GO!\" countdown will be inserted at the beginning of the beatmap, assuming there is enough time to do so.";
		this.89.Controls.Add(this.126);
		this.89.Controls.Add(this.127);
		this.89.Controls.Add(this.128);
		this.89.Controls.Add(this.118);
		this.89.Controls.Add(this.87);
		this.89.Controls.Add(this.88);
		this.89.Controls.Add(this.86);
		this.89.Dock = DockStyle.Bottom;
		this.89.Location = new Point(3, 90);
		this.89.Name = "panelCountdownRate";
		this.89.Size = new Size(359, 86);
		this.89.TabIndex = 2;
		this.126.Location = new Point(137, 27);
		NumericUpDown numericUpDown = this.126;
		int[] array = new int[4];
		array[0] = 3;
		numericUpDown.Maximum = new decimal(array);
		this.126.Name = "udCountdownOffset";
		this.126.Size = new Size(49, 20);
		this.126.TabIndex = 51;
		this.126.ValueChanged += this.28;
		this.127.AutoSize = true;
		this.127.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
		this.127.Location = new Point(3, 29);
		this.127.Name = "label49";
		this.127.Size = new Size(113, 15);
		this.127.TabIndex = 50;
		this.127.Text = "Countdown Offset:";
		this.128.AutoSize = true;
		this.128.Location = new Point(3, 50);
		this.128.Name = "label50";
		this.128.Size = new Size(327, 30);
		this.128.TabIndex = 52;
		this.128.Text = "If the countdown sounds off-time, use this to make it appear\r\none or more beats early.";
		this.118.AutoSize = true;
		this.118.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
		this.118.Location = new Point(3, 3);
		this.118.Name = "label43";
		this.118.Size = new Size(112, 15);
		this.118.TabIndex = 49;
		this.118.Text = "Countdown Speed:";
		this.87.AutoSize = true;
		this.87.FlatStyle = FlatStyle.System;
		this.87.Location = new Point(275, 1);
		this.87.Name = "countdownDouble";
		this.87.Size = new Size(69, 20);
		this.87.TabIndex = 43;
		this.87.Text = "Double";
		this.87.UseVisualStyleBackColor = true;
		this.87.CheckedChanged += this.28;
		this.88.AutoSize = true;
		this.88.Checked = true;
		this.88.FlatStyle = FlatStyle.System;
		this.88.Location = new Point(206, 1);
		this.88.Name = "countdownNormal";
		this.88.Size = new Size(71, 20);
		this.88.TabIndex = 42;
		this.88.TabStop = true;
		this.88.Text = "Normal";
		this.88.UseVisualStyleBackColor = true;
		this.88.CheckedChanged += this.28;
		this.86.AutoSize = true;
		this.86.FlatStyle = FlatStyle.System;
		this.86.Location = new Point(137, 1);
		this.86.Name = "countdownHalf";
		this.86.Size = new Size(53, 20);
		this.86.TabIndex = 40;
		this.86.Text = "Half";
		this.86.UseVisualStyleBackColor = true;
		this.86.CheckedChanged += this.28;
		this.81.ActiveLinkColor = SystemColors.Highlight;
		this.81.AutoSize = true;
		this.81.LinkColor = SystemColors.HotTrack;
		this.81.Location = new Point(201, 19);
		this.81.Name = "linkLabel5";
		this.81.Size = new Size(158, 15);
		this.81.TabIndex = 39;
		this.81.TabStop = true;
		this.81.Text = "Customising the countdown";
		this.81.LinkClicked += this.20;
		this.80.AutoSize = true;
		this.80.FlatStyle = FlatStyle.System;
		this.80.Location = new Point(10, 19);
		this.80.Name = "checkCountdown";
		this.80.Size = new Size(131, 20);
		this.80.TabIndex = 0;
		this.80.Text = "Enable countdown";
		this.80.UseVisualStyleBackColor = true;
		this.80.CheckedChanged += this.23;
		this.70.Controls.Add(this.91);
		this.70.Controls.Add(this.90);
		this.70.Location = new Point(4, 22);
		this.70.Name = "tabPage6";
		this.70.Size = new Size(377, 360);
		this.70.TabIndex = 4;
		this.70.Text = "Advanced";
		this.91.Controls.Add(this.145);
		this.91.Controls.Add(this.146);
		this.91.Controls.Add(this.119);
		this.91.Controls.Add(this.106);
		this.91.Location = new Point(6, 141);
		this.91.Name = "groupBox10";
		this.91.Size = new Size(365, 158);
		this.91.TabIndex = 40;
		this.91.TabStop = false;
		this.91.Text = "Mode Specific";
		this.146.Controls.Add(this.147);
		this.146.Location = new Point(1, 77);
		this.146.Name = "panel5";
		this.146.Size = new Size(353, 66);
		this.146.TabIndex = 52;
		this.147.Dock = DockStyle.Top;
		this.147.Location = new Point(0, 0);
		this.147.Name = "label38";
		this.147.Size = new Size(353, 77);
		this.147.TabIndex = 50;
		this.147.Text = componentResourceManager.GetString("label38.Text");
		this.119.AutoSize = true;
		this.119.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
		this.119.Location = new Point(6, 22);
		this.119.Name = "label42";
		this.119.Size = new Size(95, 15);
		this.119.TabIndex = 51;
		this.119.Text = "Allowed Modes:";
		this.106.FlatStyle = FlatStyle.System;
		this.106.FormattingEnabled = true;
		this.106.Items.AddRange(new object[]
		{
			"All",
			"osu!taiko",
			"osu!catch",
			"osu!mania"
		});
		this.106.Location = new Point(118, 19);
		this.106.Name = "allowedModes";
		this.106.Size = new Size(236, 21);
		this.106.TabIndex = 41;
		this.106.SelectedIndexChanged += this.40;
		this.106.TextChanged += this.28;
		this.90.Controls.Add(this.142);
		this.90.Controls.Add(this.92);
		this.90.Controls.Add(this.93);
		this.90.Controls.Add(this.94);
		this.90.Controls.Add(this.95);
		this.90.Location = new Point(6, 4);
		this.90.Name = "groupBox9";
		this.90.Size = new Size(365, 131);
		this.90.TabIndex = 2;
		this.90.TabStop = false;
		this.90.Text = "Stacking";
		this.142.Controls.Add(this.116);
		this.142.Location = new Point(7, 69);
		this.142.Name = "panel4";
		this.142.Size = new Size(351, 56);
		this.142.TabIndex = 50;
		this.116.Dock = DockStyle.Fill;
		this.116.Location = new Point(0, 0);
		this.116.Name = "label37";
		this.116.Size = new Size(351, 56);
		this.116.TabIndex = 49;
		this.116.Text = "In play mode, osu! automatically stacks notes which occur at the same location.  Increasing this value means it is more likely to snap notes of further time-distance.";
		this.92.AutoSize = true;
		this.92.Location = new Point(279, 51);
		this.92.Name = "label26";
		this.92.Size = new Size(75, 15);
		this.92.TabIndex = 20;
		this.92.Text = "Always Stack";
		this.92.TextAlign = ContentAlignment.TopRight;
		this.93.AutoSize = true;
		this.93.Location = new Point(122, 51);
		this.93.Name = "label27";
		this.93.Size = new Size(70, 15);
		this.93.TabIndex = 19;
		this.93.Text = "Rarely Stack";
		this.94.AutoSize = true;
		this.94.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
		this.94.Location = new Point(6, 24);
		this.94.Name = "label28";
		this.94.Size = new Size(93, 15);
		this.94.TabIndex = 18;
		this.94.Text = "Stack Leniency:";
		this.95.Location = new Point(118, 21);
		this.95.Name = "stackLeniency";
		this.95.Size = new Size(241, 45);
		this.95.TabIndex = 17;
		this.95.Value = 7;
		this.95.Scroll += this.38;
		this.95.MouseCaptureChanged += this.37;
		this.95.MouseDown += this.35;
		this.153.Controls.Add(this.113);
		this.153.Location = new Point(9, 69);
		this.153.Name = "pnlDrainDescrContain";
		this.153.Size = new Size(350, 21);
		this.153.TabIndex = 61;
		this.154.Controls.Add(this.112);
		this.154.Location = new Point(9, 145);
		this.154.Name = "pnlCircleSizeDescrContain";
		this.154.Size = new Size(350, 19);
		this.154.TabIndex = 62;
		this.155.Controls.Add(this.121);
		this.155.Location = new Point(9, 218);
		this.155.Name = "pnlApproachRateDescrContain";
		this.155.Size = new Size(350, 19);
		this.155.TabIndex = 63;
		this.156.Controls.Add(this.111);
		this.156.Location = new Point(9, 293);
		this.156.Name = "pnlOverallDifficultyDescrContain";
		this.156.Size = new Size(350, 25);
		this.156.TabIndex = 64;
		base.AcceptButton = this.16;
		base.AutoScaleDimensions = new SizeF(96f, 96f);
		base.AutoScaleMode = AutoScaleMode.Dpi;
		base.CancelButton = this.38;
		base.ClientSize = new Size(385, 430);
		base.Controls.Add(this.55);
		base.Controls.Add(this.16);
		base.Controls.Add(this.38);
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "SongSetup";
		base.Opacity = 1.0;
		base.ShowIcon = false;
		base.ShowInTaskbar = false;
		base.SizeGripStyle = SizeGripStyle.Hide;
		base.StartPosition = FormStartPosition.CenterParent;
		this.Text = "Song Setup";
		base.Load += delegate(object 1, EventArgs 2)
		{
			this.13 = new 2305[]
			{
				this.48,
				this.53,
				this.52,
				this.51,
				this.54,
				this.129,
				this.131,
				this.130
			};
			List<string> list = 1272.5().61 ? new List<string>(1272.5().55().25()) : null;
			bool flag;
			if (list != null && !this.7)
			{
				flag = list.Exists((string 1) => 1.EndsWith(Path.GetFileName(1272.5().58)));
			}
			else
			{
				flag = false;
			}
			bool flag2 = flag;
			this.64.Enabled = !flag2;
			this.18.Text = ((!string.IsNullOrEmpty(1272.5().11)) ? 1272.5().11 : 1272.5().10);
			this.137.Text = (string.IsNullOrEmpty(1272.5().10) ? 2672.21(1272.5().11, true) : 1272.5().10);
			this.19.Text = ((!string.IsNullOrEmpty(1272.5().8)) ? 1272.5().8 : 1272.5().7);
			this.134.Text = (string.IsNullOrEmpty(1272.5().7) ? 2672.21(1272.5().8, true) : 1272.5().7);
			this.21.Text = ((1272.5().43.Length > 0) ? 1272.5().43 : 1304.189.GetValue());
			this.96.Text = 1272.5().82;
			if (!string.IsNullOrEmpty(1304.189) && (this.21.Text == 1304.189 || flag2))
			{
				this.21.Enabled = false;
			}
			this.64.Text = 1272.5().89;
			this.150.Checked = (1272.5().3() == 2147.OsuMania && 1272.5().2 >= 10f);
			this.34(this.23, 1272.5().3, 0f, 10f, 10.0);
			if (this.106.SelectedIndex == 3)
			{
				this.34(this.35, 1272.5().2 / (float)((!this.150.Checked) ? 1 : 2), 1f, 9f, 1.0);
			}
			else
			{
				this.34(this.35, 1272.5().2, 2f, 7f, 10.0);
			}
			this.34(this.125, 1272.5().1, 0f, 10f, 10.0);
			this.34(this.30, 1272.5().4, 0f, 10f, 10.0);
			this.138.SelectedItem = 1226.25.ToString();
			this.99.Text = 1272.5().9;
			this.96.Text = 1272.5().82;
			this.46.Checked = (1226.61() == 1253.Custom1);
			this.120.Checked = 1272.5().106;
			this.126.Value = 1272.5().39;
			this.95.Value = (int)Math.Max(0.0, Math.Round((double)(1272.5().83 * 10f)));
			this.106.SelectedIndex = (int)1272.5().3();
			this.14 = 1272.5().3();
			this.60.Value = 1272.5().79;
			if (1272.5().42())
			{
				this.152.Checked = 1272.5().93;
			}
			else
			{
				this.152.Checked = true;
				this.152.Enabled = false;
			}
			this.80.Checked = (1272.5().38 > (1284)0);
			this.102.Checked = 1272.5().62;
			this.148.Checked = (1272.5().63 || this.7);
			if (1272.5().38 == (1284)0)
			{
				this.88.Checked = true;
			}
			else
			{
				this.87.Checked = (1272.5().38 == (1284)3);
				this.86.Checked = (1272.5().38 == (1284)2);
				this.88.Checked = (1272.5().38 == (1284)1);
			}
			2630.22();
			foreach (string item in 2630.8)
			{
				this.104.Items.Add(item);
			}
			if (!string.IsNullOrEmpty(1272.5().80))
			{
				this.104.Text = 1272.5().80;
			}
			else
			{
				this.104.SelectedIndex = 0;
			}
			this.89.Enabled = this.80.Checked;
			if (1226.81().Count > 0)
			{
				1254 3 = 1226.81()[0].4;
				1253 4 = 1226.81()[0].2;
				int num = 1226.81()[0].6;
				foreach (1259 5 in 1226.81())
				{
					if (5.4 != 3 || 5.2 != 4 || 5.2 >= 1253.Custom2)
					{
						this.83.Visible = true;
						this.9 = false;
					}
					if (5.6 != num)
					{
						this.82.Visible = true;
						this.10 = false;
					}
				}
				this.60.Value = num;
			}
			List<Color> list2 = new List<Color>(4);
			for (int i = 0; i < 8; i++)
			{
				Color item2 = 1052.4(2630.19("Combo" + (i + 1).ToString(), true));
				if (i < 2 || item2.A > 0)
				{
					list2.Add(item2);
				}
			}
			while (list2.Count < 2)
			{
				list2.Add(Color.FromArgb(240, 240, 240));
			}
			list2.Add(list2[0]);
			list2.RemoveAt(0);
			int j;
			for (j = 0; j < list2.Count; j++)
			{
				this.13[j].2(list2[j]);
				this.13[j].Visible = true;
				this.13[j].4 = true;
			}
			while (j < 8)
			{
				this.13[j].Visible = false;
				this.13[j].4 = false;
				j++;
			}
			this.63.2(1052.4(2648.2));
			this.26();
			this.49.Checked = 1272.5().44;
			this.145.Checked = 1272.5().91;
			if (this.7 || flag2)
			{
				this.64.Text = string.Empty;
				this.64.Select();
				this.19.Enabled = false;
				this.18.Enabled = false;
			}
			else
			{
				this.19.Select();
			}
			this.12 = false;
		};
		base.KeyDown += this.30;
		base.KeyUp += this.31;
		this.55.ResumeLayout(false);
		this.56.ResumeLayout(false);
		this.24.ResumeLayout(false);
		this.24.PerformLayout();
		this.132.ResumeLayout(false);
		this.132.PerformLayout();
		this.135.ResumeLayout(false);
		this.135.PerformLayout();
		this.43.ResumeLayout(false);
		this.43.PerformLayout();
		this.143.ResumeLayout(false);
		this.57.ResumeLayout(false);
		this.25.ResumeLayout(false);
		this.25.PerformLayout();
		((ISupportInitialize)this.125).EndInit();
		((ISupportInitialize)this.35).EndInit();
		((ISupportInitialize)this.30).EndInit();
		((ISupportInitialize)this.23).EndInit();
		this.58.ResumeLayout(false);
		this.151.ResumeLayout(false);
		this.151.PerformLayout();
		this.39.ResumeLayout(false);
		this.39.PerformLayout();
		this.83.ResumeLayout(false);
		this.83.PerformLayout();
		this.144.ResumeLayout(false);
		this.139.ResumeLayout(false);
		this.82.ResumeLayout(false);
		((ISupportInitialize)this.60).EndInit();
		this.59.ResumeLayout(false);
		this.62.ResumeLayout(false);
		this.140.ResumeLayout(false);
		this.47.ResumeLayout(false);
		this.47.PerformLayout();
		this.69.ResumeLayout(false);
		this.103.ResumeLayout(false);
		this.103.PerformLayout();
		this.101.ResumeLayout(false);
		this.101.PerformLayout();
		this.71.ResumeLayout(false);
		this.71.PerformLayout();
		this.141.ResumeLayout(false);
		this.89.ResumeLayout(false);
		this.89.PerformLayout();
		((ISupportInitialize)this.126).EndInit();
		this.70.ResumeLayout(false);
		this.91.ResumeLayout(false);
		this.91.PerformLayout();
		this.146.ResumeLayout(false);
		this.90.ResumeLayout(false);
		this.90.PerformLayout();
		this.142.ResumeLayout(false);
		((ISupportInitialize)this.95).EndInit();
		this.153.ResumeLayout(false);
		this.154.ResumeLayout(false);
		this.155.ResumeLayout(false);
		this.156.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	// Token: 0x060030B2 RID: 12466 RVA: 0x0011D381 File Offset: 0x0011B581
	private void 30(object 1, KeyEventArgs 2)
	{
		if (2.KeyCode == Keys.ShiftKey || 2.KeyCode == Keys.LShiftKey || 2.KeyCode == Keys.RShiftKey)
		{
			this.11 = true;
			2.Handled = true;
		}
	}

	// Token: 0x060030B3 RID: 12467 RVA: 0x0011D3B5 File Offset: 0x0011B5B5
	private void 31(object 1, KeyEventArgs 2)
	{
		if (2.KeyCode == Keys.ShiftKey || 2.KeyCode == Keys.LShiftKey || 2.KeyCode == Keys.RShiftKey)
		{
			this.11 = false;
			2.Handled = true;
		}
	}

	// Token: 0x060030B4 RID: 12468 RVA: 0x0011D3EC File Offset: 0x0011B5EC
	private void 32(object 1, EventArgs 2)
	{
		TrackBar trackBar = 1 as TrackBar;
		if (!this.11)
		{
			trackBar.Value = (int)Math.Round((double)trackBar.Value / 10.0) * 10;
		}
		this.36(trackBar, 0.1);
		this.28(null, null);
	}

	// Token: 0x060030B5 RID: 12469 RVA: 0x0011D440 File Offset: 0x0011B640
	private void 33(object 1, EventArgs 2)
	{
		TrackBar trackBar = 1 as TrackBar;
		if (!this.11)
		{
			trackBar.Value = (int)Math.Round((double)trackBar.Value / 10.0) * 10;
		}
		this.36(trackBar, 0.1);
		this.28(null, null);
	}

	// Token: 0x060030B6 RID: 12470 RVA: 0x0011D494 File Offset: 0x0011B694
	private void 34(TrackBar 1, float 2, float 3, float 4, double 5)
	{
		2 = Math.Max(0f, Math.Min(10f, 2));
		if (2 <= 3)
		{
			1.Minimum = (int)Math.Round((double)2 * 5);
		}
		else
		{
			1.Minimum = (int)Math.Round((double)3 * 5);
		}
		if (2 >= 4)
		{
			1.Maximum = (int)Math.Round((double)2 * 5);
		}
		else
		{
			1.Maximum = (int)Math.Round((double)4 * 5);
		}
		1.Value = (int)Math.Round((double)2 * 5);
	}

	// Token: 0x060030B7 RID: 12471 RVA: 0x0011D51C File Offset: 0x0011B71C
	private void 35(object 1, MouseEventArgs 2)
	{
		if ((1 == this.35 && this.106.SelectedIndex == 3) || 1 == this.95)
		{
			this.36((TrackBar)1, 1.0);
			return;
		}
		this.36((TrackBar)1, 0.1);
	}

	// Token: 0x060030B8 RID: 12472 RVA: 0x0011D574 File Offset: 0x0011B774
	private void 36(TrackBar 1, double 2)
	{
		this.98.Show(((double)1.Value * 2).ToString(), this.57, 1.Right + 2, 1.Top + 4);
	}

	// Token: 0x060030B9 RID: 12473 RVA: 0x0011D5B3 File Offset: 0x0011B7B3
	private void 37(object 1, EventArgs 2)
	{
		TrackBar trackBar = (TrackBar)1;
		this.98.Hide(this.57);
		this.98.RemoveAll();
	}

	// Token: 0x060030BA RID: 12474 RVA: 0x001175A4 File Offset: 0x001157A4
	private void 38(object 1, EventArgs 2)
	{
		this.36((TrackBar)1, 1.0);
		this.28(null, null);
	}

	// Token: 0x060030BB RID: 12475 RVA: 0x0011D5D8 File Offset: 0x0011B7D8
	private void 39(object 1, EventArgs 2)
	{
		if (this.106.SelectedIndex == 3)
		{
			this.34.Text = "Key Count";
			this.112.Text = "The column count";
			this.35.TickFrequency = 1;
			this.33.Text = "1";
			this.36.Text = string.Empty;
			this.32.Text = "      9";
			this.125.Enabled = false;
			return;
		}
		this.34.Text = "Circle Size";
		this.112.Text = "The radial size of hit circles and sliders";
		this.35.TickFrequency = 10;
		this.33.Text = "Large";
		this.36.Text = "Normal";
		this.32.Text = "Small";
		this.125.Enabled = true;
	}

	// Token: 0x060030BC RID: 12476 RVA: 0x0011D6C8 File Offset: 0x0011B8C8
	private void 40(object 1, EventArgs 2)
	{
		if (this.106.SelectedIndex == 3)
		{
			this.34(this.35, 1272.5().2 / (float)((!this.150.Checked) ? 1 : 2), 1f, 9f, 1.0);
			this.150.Visible = true;
		}
		else
		{
			this.34(this.35, 1272.5().2, 2f, 7f, 10.0);
			this.150.Visible = false;
		}
		this.28(null, null);
	}

	// Token: 0x060030BD RID: 12477 RVA: 0x001175C3 File Offset: 0x001157C3
	private void 41(object 1, EventArgs 2)
	{
		this.28(null, null);
	}

	// Token: 0x060030BE RID: 12478 RVA: 0x0011D76A File Offset: 0x0011B96A
	private void 42(object 1, LinkLabelLinkClickedEventArgs 2)
	{
		1662.69(1661.25());
	}

	// Token: 0x060030BF RID: 12479 RVA: 0x0011D778 File Offset: 0x0011B978
	private void 43(object 1, EventArgs 2)
	{
		bool flag = 2672.21(this.18.Text, true) == this.18.Text;
		if (flag)
		{
			this.137.Text = this.18.Text;
		}
		this.135.Enabled = !flag;
		this.137.Text = 2672.21(this.137.Text, false);
		this.28(null, null);
	}

	// Token: 0x060030C0 RID: 12480 RVA: 0x0011D7F4 File Offset: 0x0011B9F4
	private void 44(object 1, EventArgs 2)
	{
		bool flag = 2672.21(this.19.Text, true) == this.19.Text;
		if (flag)
		{
			this.134.Text = this.19.Text;
		}
		this.132.Enabled = !flag;
		this.134.Text = 2672.21(this.134.Text, false);
		this.28(null, null);
	}

	// Token: 0x060030C1 RID: 12481 RVA: 0x0011D870 File Offset: 0x0011BA70
	private void 45(object 1, EventArgs 2)
	{
		if (!this.12)
		{
			base.DialogResult = DialogResult.OK;
			base.Close();
			return;
		}
		2039 3 = this.6.7;
		bool flag = false;
		2147 selectedIndex = (2147)this.106.SelectedIndex;
		if ((selectedIndex == 2147.OsuMania || this.14 == 2147.OsuMania) && this.14 != selectedIndex)
		{
			if (MessageBox.Show("You changed play mode, do you want to save changes and clear all notes?", "Song Setup", MessageBoxButtons.OKCancel) == DialogResult.OK)
			{
				3.7();
				this.6.8.13 = false;
				flag = true;
			}
		}
		else
		{
			flag = (!this.8 || MessageBox.Show("Do you want to save changes to this beatmap?", "Song Setup", MessageBoxButtons.OKCancel) == DialogResult.OK);
		}
		if (flag)
		{
			1262 4 = 3.21;
			this.46(4);
			base.Enabled = false;
			base.Invalidate();
			3.RecalculateDifficulty(false, true, true);
			this.6.17(true, false, false, true);
			2255 5 = this.6.74;
			if (5 != null)
			{
				5.65();
			}
			bool flag2 = 3.53(false, this.7, false, false);
			this.6.34(4, false, false);
			base.DialogResult = (flag2 ? DialogResult.OK : DialogResult.Cancel);
			base.Close();
		}
	}

	// Token: 0x060030C2 RID: 12482 RVA: 0x0011D990 File Offset: 0x0011BB90
	private void 46(1262 1)
	{
		1.4((2147)this.106.SelectedIndex);
		if (this.7)
		{
			1.25 = 0;
		}
		1.10 = this.137.Text;
		1.11 = this.18.Text;
		1.7 = this.134.Text;
		1.8 = this.19.Text;
		1.43 = this.21.Text;
		1.89 = this.64.Text;
		1.82 = this.96.Text;
		1.9 = this.99.Text;
		1.3 = (float)this.23.Value / 10f;
		1.4 = (float)this.30.Value / 10f;
		1.2 = ((this.106.SelectedIndex == 3) ? ((float)(this.35.Value * ((!this.150.Checked) ? 1 : 2))) : ((float)this.35.Value / 10f));
		1.1 = (float)this.125.Value / 10f;
		if (1.3() == 2147.OsuMania)
		{
			1.2 = Math.Min(18f, Math.Max(1.2, 1f));
		}
		1.79 = this.60.Value;
		if (this.138.SelectedItem != null)
		{
			1226.59((1254)Enum.Parse(typeof(1254), this.138.SelectedItem.ToString()), true);
		}
		if (this.152.Enabled)
		{
			1.93 = this.152.Checked;
		}
		1244 2 = this.24();
		if (1226.81().Count > 0)
		{
			if (this.9)
			{
				foreach (1259 3 in 1226.81())
				{
					3.4 = 2.2;
					3.2 = 2.4;
				}
			}
			if (this.10)
			{
				foreach (1259 4 in 1226.81())
				{
					4.6 = 2.5;
				}
			}
		}
		2630.12(this.6.7);
		1.44 = this.49.Checked;
		if (this.49.Checked)
		{
			int num = this.25();
			List<Color> list = new List<Color>(num);
			for (int i = 0; i < num; i++)
			{
				list.Add(this.13[i].1());
			}
			list.Insert(0, list[list.Count - 1]);
			list.RemoveAt(list.Count - 1);
			for (int j = 0; j < list.Count; j++)
			{
				2630.3["Combo" + (j + 1).ToString()] = new 198(list[j].R, list[j].G, list[j].B);
			}
			for (int k = list.Count; k < 8; k++)
			{
				2630.3["Combo" + (k + 1).ToString()] = 198.TransparentBlack;
			}
		}
		if (2648.1 != null)
		{
			2648.1.8(new 198(this.63.1().R, this.63.1().G, this.63.1().B));
		}
		1.80 = ((this.104.SelectedIndex > 0) ? this.104.Text : string.Empty);
		1.62 = this.102.Checked;
		1.63 = this.148.Checked;
		if (!this.80.Checked)
		{
			1.38 = (1284)0;
		}
		else if (this.88.Checked)
		{
			1.38 = (1284)1;
		}
		else if (this.86.Checked)
		{
			1.38 = (1284)2;
		}
		else if (this.87.Checked)
		{
			1.38 = (1284)3;
		}
		1.106 = this.120.Checked;
		1.39 = (int)this.126.Value;
		1.83 = (float)this.95.Value / 10f;
		if (1.3() == 2147.OsuMania)
		{
			1.91 = this.145.Checked;
		}
	}

	// Token: 0x060030C3 RID: 12483 RVA: 0x0011DE9C File Offset: 0x0011C09C
	private void 47(object 1, EventArgs 2)
	{
		base.DialogResult = DialogResult.Cancel;
		base.Close();
	}

	// Token: 0x04002336 RID: 9014
	private 2263 6;

	// Token: 0x04002337 RID: 9015
	private new readonly bool 7;

	// Token: 0x04002338 RID: 9016
	private new bool 8;

	// Token: 0x04002339 RID: 9017
	private bool 9 = true;

	// Token: 0x0400233A RID: 9018
	private bool 10 = true;

	// Token: 0x0400233B RID: 9019
	private new bool 11;

	// Token: 0x0400233C RID: 9020
	private new bool 12;

	// Token: 0x0400233D RID: 9021
	private 2305[] 13;

	// Token: 0x0400233E RID: 9022
	private 2147 14;

	// Token: 0x04002340 RID: 9024
	private Button 16;

	// Token: 0x04002341 RID: 9025
	private Label 17;

	// Token: 0x04002342 RID: 9026
	private TextBox 18;

	// Token: 0x04002343 RID: 9027
	private TextBox 19;

	// Token: 0x04002344 RID: 9028
	private Label 20;

	// Token: 0x04002345 RID: 9029
	private TextBox 21;

	// Token: 0x04002346 RID: 9030
	private Label 22;

	// Token: 0x04002347 RID: 9031
	private TrackBar 23;

	// Token: 0x04002348 RID: 9032
	private GroupBox 24;

	// Token: 0x04002349 RID: 9033
	private GroupBox 25;

	// Token: 0x0400234A RID: 9034
	private Label 26;

	// Token: 0x0400234B RID: 9035
	private Label 27;

	// Token: 0x0400234C RID: 9036
	private Label 28;

	// Token: 0x0400234D RID: 9037
	private Label 29;

	// Token: 0x0400234E RID: 9038
	private TrackBar 30;

	// Token: 0x0400234F RID: 9039
	private Label 31;

	// Token: 0x04002350 RID: 9040
	private Label 32;

	// Token: 0x04002351 RID: 9041
	private Label 33;

	// Token: 0x04002352 RID: 9042
	private Label 34;

	// Token: 0x04002353 RID: 9043
	private TrackBar 35;

	// Token: 0x04002354 RID: 9044
	private Label 36;

	// Token: 0x04002355 RID: 9045
	private Label 37;

	// Token: 0x04002356 RID: 9046
	private Button 38;

	// Token: 0x04002357 RID: 9047
	private GroupBox 39;

	// Token: 0x04002358 RID: 9048
	private Button 40;

	// Token: 0x04002359 RID: 9049
	private Button 41;

	// Token: 0x0400235A RID: 9050
	private Button 42;

	// Token: 0x0400235B RID: 9051
	private GroupBox 43;

	// Token: 0x0400235C RID: 9052
	private LinkLabel 44;

	// Token: 0x0400235D RID: 9053
	private LinkLabel 45;

	// Token: 0x0400235E RID: 9054
	private CheckBox 46;

	// Token: 0x0400235F RID: 9055
	private GroupBox 47;

	// Token: 0x04002360 RID: 9056
	private 2305 48;

	// Token: 0x04002361 RID: 9057
	private CheckBox 49;

	// Token: 0x04002362 RID: 9058
	private ColorDialog 50;

	// Token: 0x04002363 RID: 9059
	private 2305 51;

	// Token: 0x04002364 RID: 9060
	private 2305 52;

	// Token: 0x04002365 RID: 9061
	private 2305 53;

	// Token: 0x04002366 RID: 9062
	private 2305 54;

	// Token: 0x04002367 RID: 9063
	private TabControl 55;

	// Token: 0x04002368 RID: 9064
	private TabPage 56;

	// Token: 0x04002369 RID: 9065
	private TabPage 57;

	// Token: 0x0400236A RID: 9066
	private TabPage 58;

	// Token: 0x0400236B RID: 9067
	private TabPage 59;

	// Token: 0x0400236C RID: 9068
	private TrackBar 60;

	// Token: 0x0400236D RID: 9069
	private LinkLabel 61;

	// Token: 0x0400236E RID: 9070
	private GroupBox 62;

	// Token: 0x0400236F RID: 9071
	private 2305 63;

	// Token: 0x04002370 RID: 9072
	private ComboBox 64;

	// Token: 0x04002371 RID: 9073
	private Label 65;

	// Token: 0x04002372 RID: 9074
	private Label 66;

	// Token: 0x04002373 RID: 9075
	private Button 67;

	// Token: 0x04002374 RID: 9076
	private Button 68;

	// Token: 0x04002375 RID: 9077
	private TabPage 69;

	// Token: 0x04002376 RID: 9078
	private TabPage 70;

	// Token: 0x04002377 RID: 9079
	private GroupBox 71;

	// Token: 0x04002378 RID: 9080
	private ComboBox 72;

	// Token: 0x04002379 RID: 9081
	private Label 73;

	// Token: 0x0400237A RID: 9082
	private TextBox 74;

	// Token: 0x0400237B RID: 9083
	private Label 75;

	// Token: 0x0400237C RID: 9084
	private Label 76;

	// Token: 0x0400237D RID: 9085
	private Label 77;

	// Token: 0x0400237E RID: 9086
	private TextBox 78;

	// Token: 0x0400237F RID: 9087
	private TextBox 79;

	// Token: 0x04002380 RID: 9088
	private CheckBox 80;

	// Token: 0x04002381 RID: 9089
	private LinkLabel 81;

	// Token: 0x04002382 RID: 9090
	private Panel 82;

	// Token: 0x04002383 RID: 9091
	private Panel 83;

	// Token: 0x04002384 RID: 9092
	private Button 84;

	// Token: 0x04002385 RID: 9093
	private Button 85;

	// Token: 0x04002386 RID: 9094
	private RadioButton 86;

	// Token: 0x04002387 RID: 9095
	private RadioButton 87;

	// Token: 0x04002388 RID: 9096
	private RadioButton 88;

	// Token: 0x04002389 RID: 9097
	private Panel 89;

	// Token: 0x0400238A RID: 9098
	private GroupBox 90;

	// Token: 0x0400238B RID: 9099
	private GroupBox 91;

	// Token: 0x0400238C RID: 9100
	private Label 92;

	// Token: 0x0400238D RID: 9101
	private Label 93;

	// Token: 0x0400238E RID: 9102
	private Label 94;

	// Token: 0x0400238F RID: 9103
	private TrackBar 95;

	// Token: 0x04002390 RID: 9104
	private TextBox 96;

	// Token: 0x04002391 RID: 9105
	private Label 97;

	// Token: 0x04002392 RID: 9106
	private ToolTip 98;

	// Token: 0x04002393 RID: 9107
	private TextBox 99;

	// Token: 0x04002394 RID: 9108
	private Label 100;

	// Token: 0x04002395 RID: 9109
	private GroupBox 101;

	// Token: 0x04002396 RID: 9110
	private CheckBox 102;

	// Token: 0x04002397 RID: 9111
	private GroupBox 103;

	// Token: 0x04002398 RID: 9112
	private ComboBox 104;

	// Token: 0x04002399 RID: 9113
	private Button 105;

	// Token: 0x0400239A RID: 9114
	private ComboBox 106;

	// Token: 0x0400239B RID: 9115
	private Label 107;

	// Token: 0x0400239C RID: 9116
	private Label 108;

	// Token: 0x0400239D RID: 9117
	private Label 109;

	// Token: 0x0400239E RID: 9118
	private Label 110;

	// Token: 0x0400239F RID: 9119
	private Label 111;

	// Token: 0x040023A0 RID: 9120
	private Label 112;

	// Token: 0x040023A1 RID: 9121
	private Label 113;

	// Token: 0x040023A2 RID: 9122
	private Label 114;

	// Token: 0x040023A3 RID: 9123
	private Label 115;

	// Token: 0x040023A4 RID: 9124
	private Label 116;

	// Token: 0x040023A5 RID: 9125
	private Label 117;

	// Token: 0x040023A6 RID: 9126
	private Label 118;

	// Token: 0x040023A7 RID: 9127
	private Label 119;

	// Token: 0x040023A8 RID: 9128
	private CheckBox 120;

	// Token: 0x040023A9 RID: 9129
	private Label 121;

	// Token: 0x040023AA RID: 9130
	private Label 122;

	// Token: 0x040023AB RID: 9131
	private Label 123;

	// Token: 0x040023AC RID: 9132
	private Label 124;

	// Token: 0x040023AD RID: 9133
	private TrackBar 125;

	// Token: 0x040023AE RID: 9134
	private NumericUpDown 126;

	// Token: 0x040023AF RID: 9135
	private Label 127;

	// Token: 0x040023B0 RID: 9136
	private Label 128;

	// Token: 0x040023B1 RID: 9137
	private 2305 129;

	// Token: 0x040023B2 RID: 9138
	private 2305 130;

	// Token: 0x040023B3 RID: 9139
	private 2305 131;

	// Token: 0x040023B4 RID: 9140
	private Panel 132;

	// Token: 0x040023B5 RID: 9141
	private Label 133;

	// Token: 0x040023B6 RID: 9142
	private TextBox 134;

	// Token: 0x040023B7 RID: 9143
	private Panel 135;

	// Token: 0x040023B8 RID: 9144
	private Label 136;

	// Token: 0x040023B9 RID: 9145
	private TextBox 137;

	// Token: 0x040023BA RID: 9146
	private ListBox 138;

	// Token: 0x040023BB RID: 9147
	private Panel 139;

	// Token: 0x040023BC RID: 9148
	private Panel 140;

	// Token: 0x040023BD RID: 9149
	private Panel 141;

	// Token: 0x040023BE RID: 9150
	private Panel 142;

	// Token: 0x040023BF RID: 9151
	private Panel 143;

	// Token: 0x040023C0 RID: 9152
	private Panel 144;

	// Token: 0x040023C1 RID: 9153
	private CheckBox 145;

	// Token: 0x040023C2 RID: 9154
	private Panel 146;

	// Token: 0x040023C3 RID: 9155
	private Label 147;

	// Token: 0x040023C4 RID: 9156
	private CheckBox 148;

	// Token: 0x040023C5 RID: 9157
	private Label 149;

	// Token: 0x040023C6 RID: 9158
	private CheckBox 150;

	// Token: 0x040023C7 RID: 9159
	private GroupBox 151;

	// Token: 0x040023C8 RID: 9160
	private CheckBox 152;

	// Token: 0x040023C9 RID: 9161
	private Panel 153;

	// Token: 0x040023CA RID: 9162
	private Panel 154;

	// Token: 0x040023CB RID: 9163
	private Panel 155;

	// Token: 0x040023CC RID: 9164
	private Panel 156;

	// Token: 0x02000643 RID: 1603
	[Serializable]
	public sealed class 2321
	{
		// Token: 0x040023CD RID: 9165
		public static readonly 2320.2321 instance = new 2320.2321();

		// Token: 0x040023CE RID: 9166
		public static Predicate<string> cachedIsCurrentBeatmapEntry;
	}
}
