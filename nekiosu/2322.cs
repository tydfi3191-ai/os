using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

// Token: 0x02000645 RID: 1605
public sealed partial class 2322 : 1488
{
	// Token: 0x060030DC RID: 12508 RVA: 0x0011EC00 File Offset: 0x0011CE00
	private void 13(object 1, EventArgs 2)
	{
		if (!this.15 && this.77.Checked)
		{
			this.78.Checked = false;
			this.76.Checked = false;
			this.75.Enabled = false;
			this.15 = true;
			this.75.Value = 5m;
			this.15 = false;
			this.38((1257)4);
			this.51();
		}
	}

	// Token: 0x060030DD RID: 12509 RVA: 0x0011EC74 File Offset: 0x0011CE74
	private void 14(object 1, EventArgs 2)
	{
		if (!this.15 && this.76.Checked)
		{
			this.78.Checked = false;
			this.77.Checked = false;
			this.75.Enabled = true;
			this.15(null, null);
		}
	}

	// Token: 0x060030DE RID: 12510 RVA: 0x0011ECC2 File Offset: 0x0011CEC2
	private void 15(object 1, EventArgs 2)
	{
		if (!this.15)
		{
			this.38((1257)((int)this.75.Value));
			this.51();
		}
	}

	// Token: 0x060030DF RID: 12511 RVA: 0x0011ECE8 File Offset: 0x0011CEE8
	private void 16(object 1, EventArgs 2)
	{
		if (this.15 || !this.83.Checked)
		{
			return;
		}
		this.84.Checked = false;
		this.82.Checked = false;
		this.81.Checked = false;
		this.80.Enabled = false;
		this.15 = true;
		this.80.Value = 1.0m;
		this.15 = false;
		this.6.8.13((2451)18, (2450)0);
		foreach (1259 3 in this.11)
		{
			if (!3.1())
			{
				this.6.8.23(3, false);
				3.1 = -100.0;
			}
		}
		this.51();
	}

	// Token: 0x060030E0 RID: 12512 RVA: 0x0011EDE0 File Offset: 0x0011CFE0
	private void 17(object 1, EventArgs 2)
	{
		if (!this.15 && this.81.Checked)
		{
			this.84.Checked = false;
			this.83.Checked = false;
			this.82.Checked = false;
			this.80.Enabled = true;
			this.51();
		}
	}

	// Token: 0x060030E1 RID: 12513 RVA: 0x0011EE38 File Offset: 0x0011D038
	private void 18(object 1, EventArgs 2)
	{
		if (this.15)
		{
			return;
		}
		this.6.8.13((2451)18, (2450)0);
		foreach (1259 3 in this.11)
		{
			if (!3.1())
			{
				this.6.8.23(3, false);
				3.1 = (double)(-100.0m / this.80.Value);
			}
		}
		this.51();
	}

	// Token: 0x060030E2 RID: 12514 RVA: 0x0011EEEC File Offset: 0x0011D0EC
	private void 19(object 1, EventArgs 2)
	{
		this.6.8.13((2451)0, (2450)0);
		this.6.8.24<1259>(this.11, false);
		foreach (1259 3 in this.11)
		{
			3.3 += (double)((int)this.70.Value);
		}
		this.70.Value = 0m;
		this.54();
	}

	// Token: 0x060030E3 RID: 12515 RVA: 0x0011EF94 File Offset: 0x0011D194
	private void 20(object 1, EventArgs 2)
	{
		base.AcceptButton = this.71;
	}

	// Token: 0x060030E4 RID: 12516 RVA: 0x0011EFA4 File Offset: 0x0011D1A4
	private void 21(object 1, EventArgs 2)
	{
		int 3 = this.40.Items.IndexOf(this.40.TopItem);
		bool flag = this.29.SelectedIndex == 1 || (this.29.SelectedIndex == 0 && this.40.SelectedIndices.Count == 0);
		1259 4;
		if (this.40.SelectedIndices.Count > 0 && this.12 != null)
		{
			4 = new 1259(flag ? this.50(this.12) : ((!this.12.1()) ? this.12.1 : (this.12.1() ? this.12.1 : -100.0)), this.16 ? this.12.3 : ((double)1226.16), this.12.5, this.12.4, this.12.2, this.12.6, flag, this.12.8);
		}
		else
		{
			4 = new 1259(0.0, (double)(flag ? 500 : -100));
			4.2(flag);
		}
		this.6.8.13((2451)8, (2450)0);
		this.6.8.23(4, false);
		this.9.Add(4);
		this.9.Sort();
		1488.11(this.40);
		this.52(false);
		this.15 = true;
		int num = this.9.IndexOf(4);
		this.40.SelectedIndices.Add(num);
		this.15 = false;
		this.56(3);
		this.55(num);
		this.40.Focus();
		1488.12(this.40);
		this.80();
		this.74(true);
		this.16 = true;
	}

	// Token: 0x060030E5 RID: 12517 RVA: 0x0011F1A4 File Offset: 0x0011D3A4
	private void 22(object 1, EventArgs 2)
	{
		if (this.40.SelectedIndices.Count == 0)
		{
			return;
		}
		int num = Math.Max(this.40.SelectedIndices[0] - 1, 0);
		this.6.8.13((2451)9, (2450)0);
		this.6.8.24<1259>(this.11, false);
		foreach (1259 item in this.11)
		{
			this.9.Remove(item);
		}
		1488.11(this.40);
		this.15 = true;
		foreach (object obj in this.40.Items)
		{
			ListViewItem listViewItem = (ListViewItem)obj;
			if (listViewItem.Selected)
			{
				this.40.Items.Remove(listViewItem);
			}
		}
		this.15 = false;
		this.53();
		if (num < this.9.Count)
		{
			this.40.SelectedIndices.Add(num);
		}
		else if (this.9.Count > 0)
		{
			this.40.SelectedIndices.Add(this.9.Count - 1);
		}
		1488.12(this.40);
		this.80();
		this.74(true);
		this.55(num);
		this.40.Focus();
		this.16 = true;
		1488.12(this.40);
	}

	// Token: 0x060030E6 RID: 12518 RVA: 0x0011F364 File Offset: 0x0011D564
	private void 23(object 1, KeyEventArgs 2)
	{
		Keys keyCode = 2.KeyCode;
		if (keyCode <= Keys.A)
		{
			if (keyCode != Keys.Delete)
			{
				if (keyCode == Keys.A)
				{
					if (2.Control)
					{
						this.24();
					}
				}
			}
			else if (this.40.SelectedIndices.Count > 0)
			{
				this.22(1, EventArgs.Empty);
			}
		}
		else if (keyCode != Keys.C)
		{
			if (keyCode != Keys.V)
			{
				if (keyCode == Keys.X)
				{
					if (2.Control)
					{
						this.25();
						this.22(1, EventArgs.Empty);
					}
				}
			}
			else if (2.Control)
			{
				this.26();
			}
		}
		else if (2.Control)
		{
			this.25();
		}
		if (this.19)
		{
			this.74(true);
		}
		this.40.Focus();
	}

	// Token: 0x060030E7 RID: 12519 RVA: 0x0011F424 File Offset: 0x0011D624
	private void 24()
	{
		this.40.SelectedIndices.Clear();
		for (int i = 0; i < this.40.Items.Count; i++)
		{
			this.40.SelectedIndices.Add(i);
		}
	}

	// Token: 0x060030E8 RID: 12520 RVA: 0x0011F470 File Offset: 0x0011D670
	private void 25()
	{
		if (this.11.Count == 0)
		{
			return;
		}
		this.6.76.27.Clear();
		this.6.74.22();
		string data = 2039.56(this.11);
		foreach (1259 item in this.11)
		{
			this.6.76.27.Add(item);
		}
		Clipboard.Clear();
		Clipboard.SetData(DataFormats.Text, data);
	}

	// Token: 0x060030E9 RID: 12521 RVA: 0x0011F524 File Offset: 0x0011D724
	private bool 26()
	{
		if (!Clipboard.ContainsData(DataFormats.Text))
		{
			return false;
		}
		bool flag;
		List<1259> list = 2039.51(1272.5(), (string)Clipboard.GetData(DataFormats.Text), out flag, false);
		if (!flag)
		{
			return false;
		}
		this.40.SelectedIndices.Clear();
		this.11.Clear();
		this.6.8.13((2451)8, (2450)0);
		this.6.8.24<1259>(list, false);
		this.9.AddRange(list);
		this.11.AddRange(list);
		this.54();
		this.80();
		this.74(true);
		this.40.Focus();
		if (this.40.SelectedIndices.Count > 0)
		{
			this.55(this.40.SelectedIndices[0]);
		}
		return true;
	}

	// Token: 0x060030EA RID: 12522 RVA: 0x0011F604 File Offset: 0x0011D804
	private void 27(object 1, CancelEventArgs 2)
	{
		ToolStripItem toolStripItem = this.110;
		ToolStripItem toolStripItem2 = this.111;
		bool enabled = this.113.Enabled = (this.11.Count > 0);
		bool enabled2 = toolStripItem2.Enabled = enabled;
		toolStripItem.Enabled = enabled2;
		bool enabled3 = false;
		if (Clipboard.ContainsData(DataFormats.Text))
		{
			2039.51(1272.5(), (string)Clipboard.GetData(DataFormats.Text), out enabled3, true);
		}
		this.112.Enabled = enabled3;
		this.115.Enabled = (this.9.Count > 0);
	}

	// Token: 0x060030EB RID: 12523 RVA: 0x0011F69A File Offset: 0x0011D89A
	private void 28(object 1, EventArgs 2)
	{
		this.25();
		this.22(1, EventArgs.Empty);
	}

	// Token: 0x060030EC RID: 12524 RVA: 0x0011F6AE File Offset: 0x0011D8AE
	private void 29(object 1, EventArgs 2)
	{
		this.25();
	}

	// Token: 0x060030ED RID: 12525 RVA: 0x0011F6B6 File Offset: 0x0011D8B6
	private void 30(object 1, EventArgs 2)
	{
		this.22(1, EventArgs.Empty);
	}

	// Token: 0x060030EE RID: 12526 RVA: 0x0011F6C4 File Offset: 0x0011D8C4
	private void 31(object 1, EventArgs 2)
	{
		this.24();
	}

	// Token: 0x060030EF RID: 12527 RVA: 0x0011F6CC File Offset: 0x0011D8CC
	private void 32(object 1, EventArgs 2)
	{
		this.21(1, EventArgs.Empty);
	}

	// Token: 0x060030F0 RID: 12528 RVA: 0x0011F6DA File Offset: 0x0011D8DA
	internal 2322(2263 1, 2325 2) : this(1, 2, true, false)
	{
	}

	// Token: 0x060030F1 RID: 12529 RVA: 0x0011F6E6 File Offset: 0x0011D8E6
	internal 2322(2263 1, 2325 2, bool 3) : this(1, 2, 3, false)
	{
	}

	// Token: 0x060030F2 RID: 12530 RVA: 0x0011F6F4 File Offset: 0x0011D8F4
	internal 2322(2263 1, 2325 2, bool 3, bool 4)
	{
		this.6 = 1;
		this.7 = 2;
		this.37();
		this.46.ColorDepth = (Application.RenderWithVisualStyles ? ColorDepth.Depth32Bit : ColorDepth.Depth24Bit);
		this.46.Images.Clear();
		this.46.Images.Add(277.GetRedBulletImage());
		this.46.Images.Add(277.GetGreenBulletImage());
		if (Application.RenderWithVisualStyles)
		{
			foreach (object obj in this.24.TabPages)
			{
				TabPage tabPage = (TabPage)obj;
				tabPage.BackColor = SystemColors.ControlLightLight;
				foreach (object obj2 in tabPage.Controls)
				{
					TrackBar trackBar = ((Control)obj2) as TrackBar;
					if (trackBar != null)
					{
						trackBar.BackColor = SystemColors.ControlLightLight;
					}
				}
			}
		}
		1143.6(this.40, "explorer");
		this.24.TabPages.Remove(this.26);
		this.24.TabPages.Remove(this.68);
		this.24.SelectedIndex = ((2 == (2325)3) ? 1 : 0);
		this.9 = 1226.81();
		this.10 = new List<1259>();
		this.8 = null;
		if (1226.83().Count > 0)
		{
			this.8 = (1259)1226.83()[0].Clone();
		}
		int num = 1.96();
		switch (num)
		{
		case 1:
			this.104.SelectedIndex = 0;
			goto IL_281;
		case 2:
			this.104.SelectedIndex = 1;
			goto IL_281;
		case 3:
			this.104.SelectedIndex = 2;
			goto IL_281;
		case 4:
		case 10:
		case 11:
			break;
		case 5:
			this.104.SelectedIndex = 4;
			goto IL_281;
		case 6:
			this.104.SelectedIndex = 5;
			goto IL_281;
		case 7:
			this.104.SelectedIndex = 6;
			goto IL_281;
		case 8:
			this.104.SelectedIndex = 7;
			goto IL_281;
		case 9:
			this.104.SelectedIndex = 8;
			goto IL_281;
		case 12:
			this.104.SelectedIndex = 9;
			goto IL_281;
		default:
			if (num == 24)
			{
				this.104.SelectedIndex = 10;
				goto IL_281;
			}
			break;
		}
		this.104.SelectedIndex = 3;
		IL_281:
		1488.11(this.40);
		this.52(false);
		this.18 = (3 ? 1226.71 : 1226.70);
		1.8.19((2452)1, null);
		1.8.17 = false;
	}

	// Token: 0x060030F3 RID: 12531 RVA: 0x0011F9E8 File Offset: 0x0011DBE8
	private void 33(object 1, EventArgs 2)
	{
		this.15 = true;
		if (this.18 >= 0)
		{
			this.40.SelectedIndices.Add(this.18);
		}
		this.80();
		this.15 = false;
		1488.12(this.40);
		this.74(false);
		if (this.40.Items.Count > 0)
		{
			this.55(this.40.SelectedIndices[0]);
		}
		if (this.24.TabPages.Contains(this.25))
		{
			switch (this.7)
			{
			case (2325)0:
				base.ActiveControl = this.40;
				return;
			case (2325)1:
				base.ActiveControl = this.107;
				this.107.Select(0, this.107.Text.Length);
				return;
			case (2325)2:
				base.ActiveControl = this.106;
				this.106.Select(0, this.106.Text.Length);
				return;
			case (2325)3:
				this.24.SelectedIndex = 1;
				base.ActiveControl = this.97;
				return;
			default:
				return;
			}
		}
		else
		{
			if (!this.24.TabPages.Contains(this.26))
			{
				if (this.24.TabPages.Contains(this.68))
				{
					switch (this.7)
					{
					case (2325)0:
						base.ActiveControl = this.40;
						return;
					case (2325)1:
					case (2325)2:
						base.ActiveControl = this.70;
						this.70.Select(0, this.70.Text.Length);
						return;
					case (2325)3:
						this.24.SelectedIndex = 1;
						base.ActiveControl = this.97;
						break;
					default:
						return;
					}
				}
				return;
			}
			switch (this.7)
			{
			case (2325)0:
				base.ActiveControl = this.40;
				return;
			case (2325)1:
			case (2325)2:
				base.ActiveControl = this.108;
				this.108.Select(0, this.108.Text.Length);
				return;
			case (2325)3:
				this.24.SelectedIndex = 1;
				base.ActiveControl = this.97;
				return;
			default:
				return;
			}
		}
	}

	// Token: 0x060030F4 RID: 12532 RVA: 0x0011FC1F File Offset: 0x0011DE1F
	private void 34(object 1, EventArgs 2)
	{
		this.21.Focus();
		this.17 = true;
		base.Close();
	}

	// Token: 0x060030F5 RID: 12533 RVA: 0x0011FC3A File Offset: 0x0011DE3A
	private void 35(object 1, EventArgs 2)
	{
		this.17 = false;
		base.Close();
	}

	// Token: 0x060030F6 RID: 12534 RVA: 0x0011FC4C File Offset: 0x0011DE4C
	private void 36(object 1, FormClosingEventArgs 2)
	{
		this.60(true, true);
		1226.82(this.9);
		if (!this.17)
		{
			this.6.8.17 = true;
			this.6.8.20(true, true);
			return;
		}
		if (1226.83().Count <= 0)
		{
			MessageBox.Show("At least one timing point is required.", "osu!", MessageBoxButtons.OK);
			base.DialogResult = DialogResult.None;
			return;
		}
		this.6.8.13((2451)21, (2450)0);
		this.6.76.21();
		this.6.76.25 = true;
		int num2;
		if (this.118.Checked)
		{
			int num = (this.8 != null && 1226.83().Count != 0) ? ((int)(this.8.3 - 1226.83()[0].3) * -1) : 0;
			if (num != 0)
			{
				List<int> list = this.6.7.25;
				if (list.Count > 0)
				{
					this.6.8.17<int>((2452)3, (2451)0, list);
					for (int i = 0; i < list.Count; i++)
					{
						List<int> list2 = list;
						num2 = i;
						list2[num2] += num;
					}
				}
				this.6.8.18((2452)4, (2451)0, 1272.5().78);
				1272.5().78 += num;
			}
		}
		switch (this.104.SelectedIndex)
		{
		case 0:
			num2 = 1;
			goto IL_1D1;
		case 1:
			num2 = 2;
			goto IL_1D1;
		case 2:
			num2 = 3;
			goto IL_1D1;
		case 4:
			num2 = 5;
			goto IL_1D1;
		case 5:
			num2 = 6;
			goto IL_1D1;
		case 6:
			num2 = 7;
			goto IL_1D1;
		case 7:
			num2 = 8;
			goto IL_1D1;
		case 8:
			num2 = 9;
			goto IL_1D1;
		case 9:
			num2 = 12;
			goto IL_1D1;
		case 10:
			num2 = 16;
			goto IL_1D1;
		}
		num2 = 4;
		IL_1D1:
		int num3 = num2;
		if (this.103.Checked)
		{
			this.6.76.22 = true;
			this.6.76.23 = true;
		}
		else if (this.102.Checked)
		{
			this.6.8.17 = false;
			this.6.76.22(false, new int?(num3));
			this.6.8.17 = true;
		}
		int 3 = this.6.96();
		if (this.101.Checked)
		{
			this.6.97(num3);
			this.6.76.24 = !this.102.Checked;
		}
		this.6.8.17 = false;
		this.6.76.2(true);
		this.6.8.17 = true;
		this.6.97(3);
		this.6.8.19((2452)0, null);
		this.6.8.13((2451)7, (2450)256);
		this.6.7.25(false);
		this.6.2(true);
		this.6.16(true);
	}

	// Token: 0x060030F8 RID: 12536 RVA: 0x0011FFC4 File Offset: 0x0011E1C4
	private void 37()
	{
		this.20 = new Container();
		this.23 = new ToolTip(this.20);
		this.118 = new CheckBox();
		this.123 = new NumericUpDown();
		this.21 = new Button();
		this.22 = new Button();
		this.24 = new TabControl();
		this.25 = new TabPage();
		this.48 = new GroupBox();
		this.52 = new Label();
		this.53 = new NumericUpDown();
		this.54 = new RadioButton();
		this.55 = new RadioButton();
		this.56 = new RadioButton();
		this.47 = new GroupBox();
		this.106 = new NumericUpDown();
		this.107 = new NumericUpDown();
		this.49 = new Button();
		this.50 = new Label();
		this.51 = new Label();
		this.26 = new TabPage();
		this.57 = new GroupBox();
		this.61 = new NumericUpDown();
		this.62 = new RadioButton();
		this.63 = new RadioButton();
		this.64 = new RadioButton();
		this.65 = new RadioButton();
		this.66 = new Label();
		this.58 = new GroupBox();
		this.108 = new NumericUpDown();
		this.59 = new Button();
		this.60 = new Label();
		this.68 = new TabPage();
		this.79 = new GroupBox();
		this.80 = new NumericUpDown();
		this.81 = new RadioButton();
		this.82 = new RadioButton();
		this.83 = new RadioButton();
		this.84 = new RadioButton();
		this.73 = new GroupBox();
		this.74 = new Label();
		this.75 = new NumericUpDown();
		this.76 = new RadioButton();
		this.77 = new RadioButton();
		this.78 = new RadioButton();
		this.69 = new GroupBox();
		this.70 = new NumericUpDown();
		this.71 = new Button();
		this.72 = new Label();
		this.27 = new TabPage();
		this.92 = new GroupBox();
		this.86 = new Button();
		this.87 = new Button();
		this.88 = new Button();
		this.89 = new Button();
		this.93 = new Label();
		this.94 = new NumericUpDown();
		this.95 = new TrackBar();
		this.85 = new GroupBox();
		this.120 = new Panel();
		this.97 = new ListBox();
		this.96 = new LinkLabel();
		this.124 = new RadioButton();
		this.90 = new RadioButton();
		this.91 = new RadioButton();
		this.28 = new TabPage();
		this.98 = new GroupBox();
		this.121 = new Panel();
		this.122 = new Label();
		this.125 = new CheckBox();
		this.119 = new Panel();
		this.99 = new Label();
		this.100 = new CheckBox();
		this.29 = new TabControl();
		this.30 = new TabPage();
		this.32 = new TabPage();
		this.33 = new TabPage();
		this.31 = new Panel();
		this.40 = new 1473();
		this.41 = new ColumnHeader();
		this.42 = new ColumnHeader();
		this.43 = new ColumnHeader();
		this.44 = new ColumnHeader();
		this.45 = new ColumnHeader();
		this.67 = new ColumnHeader();
		this.109 = new ContextMenuStrip(this.20);
		this.116 = new ToolStripMenuItem();
		this.117 = new ToolStripSeparator();
		this.110 = new ToolStripMenuItem();
		this.111 = new ToolStripMenuItem();
		this.112 = new ToolStripMenuItem();
		this.113 = new ToolStripMenuItem();
		this.114 = new ToolStripSeparator();
		this.115 = new ToolStripMenuItem();
		this.46 = new ImageList(this.20);
		this.34 = new GroupBox();
		this.104 = new DomainUpDown();
		this.105 = new Label();
		this.101 = new CheckBox();
		this.102 = new CheckBox();
		this.103 = new CheckBox();
		this.35 = new CheckBox();
		this.36 = new Panel();
		this.37 = new ToolStrip();
		this.38 = new ToolStripButton();
		this.39 = new ToolStripButton();
		((ISupportInitialize)this.123).BeginInit();
		this.24.SuspendLayout();
		this.25.SuspendLayout();
		this.48.SuspendLayout();
		((ISupportInitialize)this.53).BeginInit();
		this.47.SuspendLayout();
		((ISupportInitialize)this.106).BeginInit();
		((ISupportInitialize)this.107).BeginInit();
		this.26.SuspendLayout();
		this.57.SuspendLayout();
		((ISupportInitialize)this.61).BeginInit();
		this.58.SuspendLayout();
		((ISupportInitialize)this.108).BeginInit();
		this.68.SuspendLayout();
		this.79.SuspendLayout();
		((ISupportInitialize)this.80).BeginInit();
		this.73.SuspendLayout();
		((ISupportInitialize)this.75).BeginInit();
		this.69.SuspendLayout();
		((ISupportInitialize)this.70).BeginInit();
		this.27.SuspendLayout();
		this.92.SuspendLayout();
		((ISupportInitialize)this.94).BeginInit();
		((ISupportInitialize)this.95).BeginInit();
		this.85.SuspendLayout();
		this.120.SuspendLayout();
		this.28.SuspendLayout();
		this.98.SuspendLayout();
		this.121.SuspendLayout();
		this.119.SuspendLayout();
		this.29.SuspendLayout();
		this.31.SuspendLayout();
		this.109.SuspendLayout();
		this.34.SuspendLayout();
		this.36.SuspendLayout();
		this.37.SuspendLayout();
		base.SuspendLayout();
		this.23.AutomaticDelay = 300;
		this.23.AutoPopDelay = 10000;
		this.23.InitialDelay = 300;
		this.23.ReshowDelay = 60;
		this.118.AutoSize = true;
		this.118.FlatStyle = FlatStyle.System;
		this.118.Location = new Point(191, 43);
		this.118.Name = "chkAdjustBookmarkAndPreview";
		this.118.Size = new Size(228, 20);
		this.118.TabIndex = 5;
		this.118.Text = "Adjust bookmarks and audio preview";
		this.23.SetToolTip(this.118, "Will be adjusted based on the offset change of the first control point only.");
		this.118.UseVisualStyleBackColor = true;
		this.123.Location = new Point(133, 64);
		NumericUpDown numericUpDown = this.123;
		int[] array = new int[4];
		array[0] = 2;
		numericUpDown.Minimum = new decimal(array);
		this.123.Name = "nudCustom";
		this.123.Size = new Size(54, 20);
		this.123.TabIndex = 6;
		this.23.SetToolTip(this.123, "Custom sample set number");
		NumericUpDown numericUpDown2 = this.123;
		int[] array2 = new int[4];
		array2[0] = 2;
		numericUpDown2.Value = new decimal(array2);
		this.123.ValueChanged += this.68;
		this.21.DialogResult = DialogResult.OK;
		this.21.FlatStyle = FlatStyle.System;
		this.21.Location = new Point(4, 383);
		this.21.Name = "buttonOk";
		this.21.Size = new Size(397, 35);
		this.21.TabIndex = 2;
		this.21.Text = "OK";
		this.21.UseVisualStyleBackColor = true;
		this.21.Click += this.34;
		this.22.DialogResult = DialogResult.OK;
		this.22.FlatStyle = FlatStyle.System;
		this.22.Location = new Point(407, 383);
		this.22.Name = "btnCancel";
		this.22.Size = new Size(171, 35);
		this.22.TabIndex = 9;
		this.22.Text = "Cancel";
		this.22.UseVisualStyleBackColor = true;
		this.22.Click += this.35;
		this.24.Controls.Add(this.25);
		this.24.Controls.Add(this.26);
		this.24.Controls.Add(this.68);
		this.24.Controls.Add(this.27);
		this.24.Controls.Add(this.28);
		this.24.Location = new Point(4, 4);
		this.24.Name = "tabsLeft";
		this.24.SelectedIndex = 0;
		this.24.Size = new Size(238, 297);
		this.24.TabIndex = 10;
		this.25.Controls.Add(this.48);
		this.25.Controls.Add(this.47);
		this.25.Location = new Point(4, 22);
		this.25.Name = "tabTiming";
		this.25.Padding = new Padding(3);
		this.25.Size = new Size(230, 271);
		this.25.TabIndex = 0;
		this.25.Text = "Timing";
		this.48.Controls.Add(this.52);
		this.48.Controls.Add(this.53);
		this.48.Controls.Add(this.54);
		this.48.Controls.Add(this.55);
		this.48.Controls.Add(this.56);
		this.48.Location = new Point(6, 141);
		this.48.Name = "grpTimingSignature";
		this.48.Size = new Size(218, 124);
		this.48.TabIndex = 1;
		this.48.TabStop = false;
		this.48.Text = "Time Signature (metronome)";
		this.52.AutoSize = true;
		this.52.Location = new Point(123, 75);
		this.52.Name = "lblCustomSignature";
		this.52.Size = new Size(21, 15);
		this.52.TabIndex = 4;
		this.52.Text = "/ 4";
		this.53.Location = new Point(73, 73);
		NumericUpDown numericUpDown3 = this.53;
		int[] array3 = new int[4];
		array3[0] = 8;
		numericUpDown3.Maximum = new decimal(array3);
		NumericUpDown numericUpDown4 = this.53;
		int[] array4 = new int[4];
		array4[0] = 5;
		numericUpDown4.Minimum = new decimal(array4);
		this.53.Name = "udMetronome";
		this.53.Size = new Size(44, 20);
		this.53.TabIndex = 3;
		NumericUpDown numericUpDown5 = this.53;
		int[] array5 = new int[4];
		array5[0] = 5;
		numericUpDown5.Value = new decimal(array5);
		this.53.ValueChanged += this.41;
		this.54.AutoSize = true;
		this.54.FlatStyle = FlatStyle.System;
		this.54.Location = new Point(9, 73);
		this.54.Name = "radCustomSignature";
		this.54.Size = new Size(64, 20);
		this.54.TabIndex = 2;
		this.54.TabStop = true;
		this.54.Text = "Other:";
		this.54.UseVisualStyleBackColor = true;
		this.54.CheckedChanged += this.40;
		this.55.AutoSize = true;
		this.55.FlatStyle = FlatStyle.System;
		this.55.Location = new Point(9, 52);
		this.55.Name = "radTimingQuad";
		this.55.Size = new Size(114, 20);
		this.55.TabIndex = 1;
		this.55.TabStop = true;
		this.55.Text = "4 / 4 (common)";
		this.55.UseVisualStyleBackColor = true;
		this.55.CheckedChanged += delegate(object 1, EventArgs 2)
		{
			if (!this.15 && this.55.Checked)
			{
				this.56.Checked = false;
				this.54.Checked = false;
				this.53.Enabled = false;
				this.53.Value = 5m;
				this.38((1257)4);
				this.51();
			}
		};
		this.56.AutoSize = true;
		this.56.FlatStyle = FlatStyle.System;
		this.56.Location = new Point(9, 31);
		this.56.Name = "radTimingTriple";
		this.56.Size = new Size(92, 20);
		this.56.TabIndex = 0;
		this.56.TabStop = true;
		this.56.Text = "3 / 4 (waltz)";
		this.56.UseVisualStyleBackColor = true;
		this.56.CheckedChanged += this.39;
		this.47.Controls.Add(this.106);
		this.47.Controls.Add(this.107);
		this.47.Controls.Add(this.49);
		this.47.Controls.Add(this.50);
		this.47.Controls.Add(this.51);
		this.47.Location = new Point(6, 6);
		this.47.Name = "grpTimingGeneral";
		this.47.Size = new Size(218, 129);
		this.47.TabIndex = 0;
		this.47.TabStop = false;
		this.47.Text = "General";
		this.106.Location = new Point(65, 47);
		NumericUpDown numericUpDown6 = this.106;
		int[] array6 = new int[4];
		array6[0] = 100000000;
		numericUpDown6.Maximum = new decimal(array6);
		this.106.Minimum = new decimal(new int[]
		{
			100000000,
			0,
			0,
			int.MinValue
		});
		this.106.Name = "udTimingOffset";
		this.106.Size = new Size(147, 20);
		this.106.TabIndex = 6;
		this.106.ValueChanged += this.45;
		this.107.DecimalPlaces = 3;
		this.107.Location = new Point(65, 17);
		NumericUpDown numericUpDown7 = this.107;
		int[] array7 = new int[4];
		array7[0] = 10000;
		numericUpDown7.Maximum = new decimal(array7);
		NumericUpDown numericUpDown8 = this.107;
		int[] array8 = new int[4];
		array8[0] = 15;
		numericUpDown8.Minimum = new decimal(array8);
		this.107.Name = "udBpm";
		this.107.Size = new Size(147, 20);
		this.107.TabIndex = 5;
		NumericUpDown numericUpDown9 = this.107;
		int[] array9 = new int[4];
		array9[0] = 15;
		numericUpDown9.Value = new decimal(array9);
		this.107.ValueChanged += this.44;
		this.49.FlatStyle = FlatStyle.System;
		this.49.Location = new Point(6, 81);
		this.49.Name = "btnTimingUseCurrent";
		this.49.Size = new Size(206, 42);
		this.49.TabIndex = 4;
		this.49.Text = "Use Current Time";
		this.49.UseVisualStyleBackColor = true;
		this.49.Click += this.46;
		this.50.AutoSize = true;
		this.50.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
		this.50.Location = new Point(6, 49);
		this.50.Name = "lblTimingOffset";
		this.50.Size = new Size(43, 15);
		this.50.TabIndex = 1;
		this.50.Text = "Offset";
		this.51.AutoSize = true;
		this.51.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
		this.51.Location = new Point(6, 19);
		this.51.Name = "lblBpm";
		this.51.Size = new Size(33, 15);
		this.51.TabIndex = 0;
		this.51.Text = "BPM";
		this.26.Controls.Add(this.57);
		this.26.Controls.Add(this.58);
		this.26.Location = new Point(4, 22);
		this.26.Name = "tabGameplay";
		this.26.Padding = new Padding(3);
		this.26.Size = new Size(230, 271);
		this.26.TabIndex = 1;
		this.26.Text = "Timing";
		this.57.Controls.Add(this.61);
		this.57.Controls.Add(this.62);
		this.57.Controls.Add(this.63);
		this.57.Controls.Add(this.64);
		this.57.Controls.Add(this.65);
		this.57.Controls.Add(this.66);
		this.57.Location = new Point(6, 141);
		this.57.Name = "grpDifficulty";
		this.57.Size = new Size(218, 124);
		this.57.TabIndex = 3;
		this.57.TabStop = false;
		this.57.Text = "Difficulty";
		this.61.DecimalPlaces = 2;
		this.61.Increment = new decimal(new int[]
		{
			1,
			0,
			0,
			65536
		});
		this.61.Location = new Point(91, 62);
		NumericUpDown numericUpDown10 = this.61;
		int[] array10 = new int[4];
		array10[0] = 2;
		numericUpDown10.Maximum = new decimal(array10);
		this.61.Minimum = new decimal(new int[]
		{
			5,
			0,
			0,
			65536
		});
		this.61.Name = "udSliderMultiplier";
		this.61.Size = new Size(61, 20);
		this.61.TabIndex = 5;
		NumericUpDown numericUpDown11 = this.61;
		int[] array11 = new int[4];
		array11[0] = 1;
		numericUpDown11.Value = new decimal(array11);
		this.61.ValueChanged += this.43;
		this.62.AutoSize = true;
		this.62.FlatStyle = FlatStyle.System;
		this.62.Location = new Point(9, 63);
		this.62.Name = "radSliderCustom";
		this.62.Size = new Size(76, 20);
		this.62.TabIndex = 4;
		this.62.TabStop = true;
		this.62.Text = "Custom:";
		this.62.UseVisualStyleBackColor = true;
		this.62.CheckedChanged += this.42;
		this.63.AutoSize = true;
		this.63.FlatStyle = FlatStyle.System;
		this.63.Location = new Point(135, 37);
		this.63.Name = "radSlider150";
		this.63.Size = new Size(51, 20);
		this.63.TabIndex = 3;
		this.63.TabStop = true;
		this.63.Text = "1.5x";
		this.63.UseVisualStyleBackColor = true;
		this.63.CheckedChanged += delegate(object 1, EventArgs 2)
		{
			if (!this.15 && this.63.Checked)
			{
				this.65.Checked = false;
				this.64.Checked = false;
				this.62.Checked = false;
				this.61.Enabled = false;
				this.15 = true;
				this.61.Value = 1.5m;
				this.15 = false;
				this.6.8.13((2451)18, (2450)0);
				this.6.8.23(this.12, false);
				this.12.1 = -66.6666666666667;
				this.51();
			}
		};
		this.64.AutoSize = true;
		this.64.FlatStyle = FlatStyle.System;
		this.64.Location = new Point(72, 37);
		this.64.Name = "radSlider100";
		this.64.Size = new Size(51, 20);
		this.64.TabIndex = 2;
		this.64.TabStop = true;
		this.64.Text = "1.0x";
		this.64.UseVisualStyleBackColor = true;
		this.64.CheckedChanged += delegate(object 1, EventArgs 2)
		{
			if (!this.15 && this.64.Checked)
			{
				this.65.Checked = false;
				this.63.Checked = false;
				this.62.Checked = false;
				this.61.Enabled = false;
				this.15 = true;
				this.61.Value = 1.0m;
				this.15 = false;
				this.6.8.13((2451)18, (2450)0);
				this.6.8.23(this.12, false);
				this.12.1 = -100.0;
				this.51();
			}
		};
		this.65.AutoSize = true;
		this.65.FlatStyle = FlatStyle.System;
		this.65.Location = new Point(9, 37);
		this.65.Name = "radSlider75";
		this.65.Size = new Size(57, 20);
		this.65.TabIndex = 1;
		this.65.TabStop = true;
		this.65.Text = "0.75x";
		this.65.UseVisualStyleBackColor = true;
		this.65.CheckedChanged += delegate(object 1, EventArgs 2)
		{
			if (!this.15 && this.65.Checked)
			{
				this.64.Checked = false;
				this.63.Checked = false;
				this.62.Checked = false;
				this.61.Enabled = false;
				this.15 = true;
				this.61.Value = 0.750000000000002m;
				this.15 = false;
				this.6.8.13((2451)18, (2450)0);
				this.6.8.23(this.12, false);
				this.12.1 = -133.333333333333;
				this.51();
			}
		};
		this.66.AutoSize = true;
		this.66.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
		this.66.Location = new Point(6, 19);
		this.66.Name = "lblSliderMultiplier";
		this.66.Size = new Size(146, 15);
		this.66.TabIndex = 0;
		this.66.Text = "Slider velocity multiplier:";
		this.58.Controls.Add(this.108);
		this.58.Controls.Add(this.59);
		this.58.Controls.Add(this.60);
		this.58.Location = new Point(6, 6);
		this.58.Name = "grpGameplayGeneral";
		this.58.Size = new Size(218, 129);
		this.58.TabIndex = 2;
		this.58.TabStop = false;
		this.58.Text = "General";
		this.108.Location = new Point(65, 34);
		NumericUpDown numericUpDown12 = this.108;
		int[] array12 = new int[4];
		array12[0] = 100000000;
		numericUpDown12.Maximum = new decimal(array12);
		this.108.Minimum = new decimal(new int[]
		{
			100,
			0,
			0,
			int.MinValue
		});
		this.108.Name = "udGameplayOffset";
		this.108.Size = new Size(147, 20);
		this.108.TabIndex = 7;
		this.108.ValueChanged += this.47;
		this.59.FlatStyle = FlatStyle.System;
		this.59.Location = new Point(6, 81);
		this.59.Name = "btnGameplayUseCurrent";
		this.59.Size = new Size(206, 42);
		this.59.TabIndex = 4;
		this.59.Text = "Use Current Time";
		this.59.UseVisualStyleBackColor = true;
		this.59.Click += this.48;
		this.60.AutoSize = true;
		this.60.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
		this.60.Location = new Point(6, 36);
		this.60.Name = "lblGameplayOffset";
		this.60.Size = new Size(43, 15);
		this.60.TabIndex = 1;
		this.60.Text = "Offset";
		this.68.Controls.Add(this.79);
		this.68.Controls.Add(this.73);
		this.68.Controls.Add(this.69);
		this.68.Location = new Point(4, 22);
		this.68.Name = "tabBulk";
		this.68.Size = new Size(230, 271);
		this.68.TabIndex = 4;
		this.68.Text = "Timing";
		this.79.Controls.Add(this.80);
		this.79.Controls.Add(this.81);
		this.79.Controls.Add(this.82);
		this.79.Controls.Add(this.83);
		this.79.Controls.Add(this.84);
		this.79.Location = new Point(6, 186);
		this.79.Name = "grpBulkDifficulty";
		this.79.Size = new Size(218, 77);
		this.79.TabIndex = 4;
		this.79.TabStop = false;
		this.79.Text = "Slider velocity multiplier";
		this.80.DecimalPlaces = 2;
		this.80.Increment = new decimal(new int[]
		{
			1,
			0,
			0,
			65536
		});
		this.80.Location = new Point(91, 47);
		NumericUpDown numericUpDown13 = this.80;
		int[] array13 = new int[4];
		array13[0] = 2;
		numericUpDown13.Maximum = new decimal(array13);
		this.80.Minimum = new decimal(new int[]
		{
			5,
			0,
			0,
			65536
		});
		this.80.Name = "udBulkSliderMultiplier";
		this.80.Size = new Size(61, 20);
		this.80.TabIndex = 5;
		NumericUpDown numericUpDown14 = this.80;
		int[] array14 = new int[4];
		array14[0] = 1;
		numericUpDown14.Value = new decimal(array14);
		this.80.ValueChanged += this.18;
		this.81.AutoSize = true;
		this.81.FlatStyle = FlatStyle.System;
		this.81.Location = new Point(9, 48);
		this.81.Name = "radBulkSliderCustom";
		this.81.Size = new Size(76, 20);
		this.81.TabIndex = 4;
		this.81.TabStop = true;
		this.81.Text = "Custom:";
		this.81.UseVisualStyleBackColor = true;
		this.81.CheckedChanged += this.17;
		this.82.AutoSize = true;
		this.82.FlatStyle = FlatStyle.System;
		this.82.Location = new Point(135, 22);
		this.82.Name = "radBulkSlider150";
		this.82.Size = new Size(51, 20);
		this.82.TabIndex = 3;
		this.82.TabStop = true;
		this.82.Text = "1.5x";
		this.82.UseVisualStyleBackColor = true;
		this.82.CheckedChanged += delegate(object 1, EventArgs 2)
		{
			if (!this.15 && this.82.Checked)
			{
				this.84.Checked = false;
				this.83.Checked = false;
				this.81.Checked = false;
				this.80.Enabled = false;
				this.15 = true;
				this.80.Value = 1.5m;
				this.15 = false;
				this.6.8.13((2451)18, (2450)0);
				foreach (1259 3 in this.11)
				{
					if (!3.1())
					{
						this.6.8.23(3, false);
						3.1 = -66.6666666666667;
					}
				}
				this.51();
			}
		};
		this.83.AutoSize = true;
		this.83.FlatStyle = FlatStyle.System;
		this.83.Location = new Point(72, 22);
		this.83.Name = "radBulkSlider100";
		this.83.Size = new Size(51, 20);
		this.83.TabIndex = 2;
		this.83.TabStop = true;
		this.83.Text = "1.0x";
		this.83.UseVisualStyleBackColor = true;
		this.83.CheckedChanged += this.16;
		this.84.AutoSize = true;
		this.84.FlatStyle = FlatStyle.System;
		this.84.Location = new Point(9, 22);
		this.84.Name = "radBulkSlider75";
		this.84.Size = new Size(57, 20);
		this.84.TabIndex = 1;
		this.84.TabStop = true;
		this.84.Text = "0.75x";
		this.84.UseVisualStyleBackColor = true;
		this.84.CheckedChanged += delegate(object 1, EventArgs 2)
		{
			if (!this.15 && this.84.Checked)
			{
				this.83.Checked = false;
				this.82.Checked = false;
				this.81.Checked = false;
				this.80.Enabled = false;
				this.15 = true;
				this.80.Value = 0.750000000000002m;
				this.15 = false;
				this.6.8.13((2451)18, (2450)0);
				foreach (1259 3 in this.11)
				{
					if (!3.1())
					{
						this.6.8.23(3, false);
						3.1 = -133.333333333333;
					}
				}
				this.51();
			}
		};
		this.73.Controls.Add(this.74);
		this.73.Controls.Add(this.75);
		this.73.Controls.Add(this.76);
		this.73.Controls.Add(this.77);
		this.73.Controls.Add(this.78);
		this.73.Location = new Point(6, 83);
		this.73.Name = "grpBulkTimeSignature";
		this.73.Size = new Size(218, 97);
		this.73.TabIndex = 2;
		this.73.TabStop = false;
		this.73.Text = "Time Signature (metronome)";
		this.74.AutoSize = true;
		this.74.Location = new Point(123, 66);
		this.74.Name = "lblBulkCustomSignature";
		this.74.Size = new Size(21, 15);
		this.74.TabIndex = 4;
		this.74.Text = "/ 4";
		this.75.Location = new Point(73, 64);
		NumericUpDown numericUpDown15 = this.75;
		int[] array15 = new int[4];
		array15[0] = 7;
		numericUpDown15.Maximum = new decimal(array15);
		NumericUpDown numericUpDown16 = this.75;
		int[] array16 = new int[4];
		array16[0] = 5;
		numericUpDown16.Minimum = new decimal(array16);
		this.75.Name = "udBulkMetronome";
		this.75.Size = new Size(44, 20);
		this.75.TabIndex = 3;
		NumericUpDown numericUpDown17 = this.75;
		int[] array17 = new int[4];
		array17[0] = 5;
		numericUpDown17.Value = new decimal(array17);
		this.75.ValueChanged += this.15;
		this.76.AutoSize = true;
		this.76.FlatStyle = FlatStyle.System;
		this.76.Location = new Point(9, 64);
		this.76.Name = "radBulkCustomSignature";
		this.76.Size = new Size(64, 20);
		this.76.TabIndex = 2;
		this.76.TabStop = true;
		this.76.Text = "Other:";
		this.76.UseVisualStyleBackColor = true;
		this.76.CheckedChanged += this.14;
		this.77.AutoSize = true;
		this.77.FlatStyle = FlatStyle.System;
		this.77.Location = new Point(9, 43);
		this.77.Name = "radBulkTimingQuad";
		this.77.Size = new Size(114, 20);
		this.77.TabIndex = 1;
		this.77.TabStop = true;
		this.77.Text = "4 / 4 (common)";
		this.77.UseVisualStyleBackColor = true;
		this.77.CheckedChanged += this.13;
		this.78.AutoSize = true;
		this.78.FlatStyle = FlatStyle.System;
		this.78.Location = new Point(9, 22);
		this.78.Name = "radBulkTimingTriple";
		this.78.Size = new Size(92, 20);
		this.78.TabIndex = 0;
		this.78.TabStop = true;
		this.78.Text = "3 / 4 (waltz)";
		this.78.UseVisualStyleBackColor = true;
		this.78.CheckedChanged += delegate(object 1, EventArgs 2)
		{
			if (!this.15 && this.78.Checked)
			{
				this.77.Checked = false;
				this.76.Checked = false;
				this.75.Enabled = false;
				this.15 = true;
				this.75.Value = 5m;
				this.15 = false;
				this.38((1257)3);
				this.51();
			}
		};
		this.69.Controls.Add(this.70);
		this.69.Controls.Add(this.71);
		this.69.Controls.Add(this.72);
		this.69.Location = new Point(6, 6);
		this.69.Name = "grpBulkGeneral";
		this.69.Size = new Size(218, 71);
		this.69.TabIndex = 0;
		this.69.TabStop = false;
		this.69.Text = "General";
		this.70.Location = new Point(9, 39);
		NumericUpDown numericUpDown18 = this.70;
		int[] array18 = new int[4];
		array18[0] = 300000;
		numericUpDown18.Maximum = new decimal(array18);
		this.70.Minimum = new decimal(new int[]
		{
			300000,
			0,
			0,
			int.MinValue
		});
		this.70.Name = "udBulkMove";
		this.70.Size = new Size(120, 20);
		this.70.TabIndex = 3;
		this.70.Enter += this.20;
		this.70.Leave += delegate(object 1, EventArgs 2)
		{
			base.AcceptButton = this.21;
		};
		this.71.FlatStyle = FlatStyle.System;
		this.71.Location = new Point(137, 37);
		this.71.Name = "btnBulkMove";
		this.71.Size = new Size(75, 23);
		this.71.TabIndex = 2;
		this.71.Text = "Move";
		this.71.UseVisualStyleBackColor = true;
		this.71.Click += this.19;
		this.72.AutoSize = true;
		this.72.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
		this.72.Location = new Point(6, 19);
		this.72.Name = "lblBulkMove";
		this.72.Size = new Size(150, 15);
		this.72.TabIndex = 0;
		this.72.Text = "Move selected offsets by:";
		this.27.Controls.Add(this.92);
		this.27.Controls.Add(this.85);
		this.27.Location = new Point(4, 22);
		this.27.Name = "tabAudio";
		this.27.Size = new Size(230, 271);
		this.27.TabIndex = 2;
		this.27.Text = "Audio";
		this.92.Controls.Add(this.86);
		this.92.Controls.Add(this.87);
		this.92.Controls.Add(this.88);
		this.92.Controls.Add(this.89);
		this.92.Controls.Add(this.93);
		this.92.Controls.Add(this.94);
		this.92.Controls.Add(this.95);
		this.92.Location = new Point(6, 143);
		this.92.Name = "grpVolume";
		this.92.Size = new Size(218, 123);
		this.92.TabIndex = 4;
		this.92.TabStop = false;
		this.92.Text = "Volume";
		this.86.FlatStyle = FlatStyle.System;
		this.86.Location = new Point(114, 89);
		this.86.Name = "button4";
		this.86.Size = new Size(96, 25);
		this.86.TabIndex = 7;
		this.86.Text = "Clap";
		this.86.UseVisualStyleBackColor = true;
		this.86.Click += this.73;
		this.87.FlatStyle = FlatStyle.System;
		this.87.Location = new Point(114, 58);
		this.87.Name = "button3";
		this.87.Size = new Size(96, 25);
		this.87.TabIndex = 6;
		this.87.Text = "Finish";
		this.87.UseVisualStyleBackColor = true;
		this.87.Click += this.72;
		this.88.FlatStyle = FlatStyle.System;
		this.88.Location = new Point(9, 89);
		this.88.Name = "button2";
		this.88.Size = new Size(96, 25);
		this.88.TabIndex = 5;
		this.88.Text = "Whistle";
		this.88.UseVisualStyleBackColor = true;
		this.88.Click += this.71;
		this.89.FlatStyle = FlatStyle.System;
		this.89.Location = new Point(9, 58);
		this.89.Name = "button1";
		this.89.Size = new Size(96, 25);
		this.89.TabIndex = 4;
		this.89.Text = "Hit";
		this.89.UseVisualStyleBackColor = true;
		this.89.Click += this.70;
		this.93.AutoSize = true;
		this.93.Location = new Point(199, 27);
		this.93.Name = "lblVolume";
		this.93.Size = new Size(17, 15);
		this.93.TabIndex = 2;
		this.93.Text = "%";
		this.94.Location = new Point(156, 23);
		this.94.Name = "udVolume";
		this.94.Size = new Size(43, 20);
		this.94.TabIndex = 1;
		this.94.ValueChanged += delegate(object 1, EventArgs 2)
		{
			if (!this.15)
			{
				this.15 = true;
				this.94.Value = Math.Min(100m, Math.Max(5m, this.94.Value));
				this.95.Value = (int)this.94.Value;
				this.15 = false;
				this.6.8.13((2451)19, (2450)0);
				this.6.8.24<1259>(this.11, false);
				foreach (1259 3 in this.11)
				{
					3.6 = (int)this.94.Value;
				}
				this.51();
			}
		};
		this.95.LargeChange = 10;
		this.95.Location = new Point(2, 20);
		this.95.Maximum = 100;
		this.95.Minimum = 5;
		this.95.Name = "tbVolume";
		this.95.Size = new Size(147, 45);
		this.95.TabIndex = 0;
		this.95.TickFrequency = 5;
		this.95.Value = 5;
		this.95.ValueChanged += this.69;
		this.85.Controls.Add(this.123);
		this.85.Controls.Add(this.120);
		this.85.Controls.Add(this.96);
		this.85.Controls.Add(this.124);
		this.85.Controls.Add(this.90);
		this.85.Controls.Add(this.91);
		this.85.Location = new Point(6, 6);
		this.85.Name = "grpSampleset";
		this.85.Size = new Size(218, 117);
		this.85.TabIndex = 3;
		this.85.TabStop = false;
		this.85.Text = "Sampleset";
		this.120.Controls.Add(this.97);
		this.120.Location = new Point(8, 22);
		this.120.Name = "panel2";
		this.120.Size = new Size(103, 62);
		this.120.TabIndex = 5;
		this.97.Dock = DockStyle.Fill;
		this.97.FormattingEnabled = true;
		this.97.Items.AddRange(new object[]
		{
			"Normal",
			"Soft",
			"Drum"
		});
		this.97.Location = new Point(0, 0);
		this.97.Name = "listSampleset";
		this.97.Size = new Size(103, 62);
		this.97.TabIndex = 3;
		this.97.SelectedIndexChanged += delegate(object 1, EventArgs 2)
		{
			if (!this.15 && this.97.SelectedItem != null)
			{
				1254 3 = (1254)Enum.Parse(typeof(1254), this.97.SelectedItem.ToString());
				this.6.8.13((2451)3, (2450)0);
				this.6.8.24<1259>(this.11, false);
				foreach (1259 4 in this.11)
				{
					4.4 = 3;
				}
				this.51();
			}
		};
		this.96.ActiveLinkColor = SystemColors.Highlight;
		this.96.AutoSize = true;
		this.96.LinkColor = SystemColors.HotTrack;
		this.96.Location = new Point(6, 93);
		this.96.Name = "linkLabel1";
		this.96.Size = new Size(204, 15);
		this.96.TabIndex = 4;
		this.96.TabStop = true;
		this.96.Text = "How to add custom sample overrides";
		this.96.LinkClicked += delegate(object 1, LinkLabelLinkClickedEventArgs 2)
		{
			1662.69(1661.21());
		};
		this.124.AutoSize = true;
		this.124.FlatStyle = FlatStyle.System;
		this.124.Location = new Point(117, 64);
		this.124.Name = "radSamplesetCustom2";
		this.124.Size = new Size(34, 20);
		this.124.TabIndex = 2;
		this.124.TabStop = true;
		this.124.Text = " ";
		this.124.UseVisualStyleBackColor = true;
		this.124.CheckedChanged += delegate(object 1, EventArgs 2)
		{
			if (!this.15)
			{
				if (this.124.Checked)
				{
					this.123.Enabled = true;
					this.91.Checked = false;
					this.90.Checked = false;
					this.6.8.13((2451)22, (2450)0);
					this.6.8.24<1259>(this.11, false);
					foreach (1259 3 in this.11)
					{
						3.2 = (1253)((int)this.123.Value);
					}
					this.51();
					return;
				}
				this.123.Enabled = false;
			}
		};
		this.90.AutoSize = true;
		this.90.FlatStyle = FlatStyle.System;
		this.90.Location = new Point(117, 43);
		this.90.Name = "radSamplesetCustom1";
		this.90.Size = new Size(82, 20);
		this.90.TabIndex = 1;
		this.90.TabStop = true;
		this.90.Text = "Custom 1";
		this.90.UseVisualStyleBackColor = true;
		this.90.CheckedChanged += this.67;
		this.91.AutoSize = true;
		this.91.FlatStyle = FlatStyle.System;
		this.91.Location = new Point(117, 22);
		this.91.Name = "radSamplesetDefault";
		this.91.Size = new Size(69, 20);
		this.91.TabIndex = 0;
		this.91.TabStop = true;
		this.91.Text = "Default";
		this.91.UseVisualStyleBackColor = true;
		this.91.CheckedChanged += this.66;
		this.28.Controls.Add(this.98);
		this.28.Location = new Point(4, 22);
		this.28.Name = "tabStyle";
		this.28.Size = new Size(230, 271);
		this.28.TabIndex = 3;
		this.28.Text = "Style";
		this.98.Controls.Add(this.121);
		this.98.Controls.Add(this.125);
		this.98.Controls.Add(this.119);
		this.98.Controls.Add(this.100);
		this.98.Location = new Point(6, 6);
		this.98.Name = "grpEffects";
		this.98.Size = new Size(218, 222);
		this.98.TabIndex = 0;
		this.98.TabStop = false;
		this.98.Text = "Effects";
		this.121.Controls.Add(this.122);
		this.121.Location = new Point(6, 162);
		this.121.Name = "panel3";
		this.121.Size = new Size(206, 49);
		this.121.TabIndex = 4;
		this.122.Dock = DockStyle.Fill;
		this.122.FlatStyle = FlatStyle.System;
		this.122.Location = new Point(0, 0);
		this.122.Name = "labelOmitBarline";
		this.122.Size = new Size(206, 49);
		this.122.TabIndex = 0;
		this.122.Text = "Use this to remove the first bar line from this section in Taiko and Mania modes.";
		this.125.AutoSize = true;
		this.125.FlatStyle = FlatStyle.System;
		this.125.Location = new Point(9, 135);
		this.125.Name = "chkOmitBarline";
		this.125.Size = new Size(124, 20);
		this.125.TabIndex = 3;
		this.125.Text = "Omit first bar line";
		this.125.UseVisualStyleBackColor = true;
		this.125.CheckedChanged += delegate(object 1, EventArgs 2)
		{
			if (!this.15)
			{
				this.6.8.13((2451)23, (2450)0);
				foreach (1259 3 in this.11)
				{
					if (3.1())
					{
						this.6.8.23(3, false);
						if (this.125.Checked)
						{
							3.8 |= (1258)8;
						}
						else
						{
							3.8 &= (1258)(-9);
						}
					}
				}
				this.125.ThreeState = false;
				this.51();
			}
		};
		this.119.Controls.Add(this.99);
		this.119.Location = new Point(6, 48);
		this.119.Name = "panel1";
		this.119.Size = new Size(206, 83);
		this.119.TabIndex = 2;
		this.99.Dock = DockStyle.Fill;
		this.99.FlatStyle = FlatStyle.System;
		this.99.Location = new Point(0, 0);
		this.99.Name = "lblKiai";
		this.99.Size = new Size(206, 83);
		this.99.TabIndex = 1;
		this.99.Text = "Fountains, flying stars, flashing beats. This is what you could call the \"epic chorus\" mode in osu!. It will emphasize a particular part of a song. Please don't overuse it.";
		this.100.AutoSize = true;
		this.100.FlatStyle = FlatStyle.System;
		this.100.Location = new Point(9, 22);
		this.100.Name = "chkKiai";
		this.100.Size = new Size(85, 20);
		this.100.TabIndex = 0;
		this.100.Text = "Kiai Mode";
		this.100.UseVisualStyleBackColor = true;
		this.100.CheckedChanged += delegate(object 1, EventArgs 2)
		{
			if (!this.15)
			{
				bool flag = true;
				this.6.8.13((2451)20, (2450)0);
				foreach (1259 3 in this.11)
				{
					if (flag && this.64(3))
					{
						3.4(false);
						flag = false;
					}
					else
					{
						flag = false;
						if (3.3() != this.100.Checked)
						{
							this.6.8.23(3, false);
							3.4(this.100.Checked);
						}
					}
				}
				this.100.ThreeState = false;
				this.51();
			}
		};
		this.29.Controls.Add(this.30);
		this.29.Controls.Add(this.32);
		this.29.Controls.Add(this.33);
		this.29.Location = new Point(248, 4);
		this.29.Name = "tabsRight";
		this.29.SelectedIndex = 0;
		this.29.Size = new Size(330, 272);
		this.29.TabIndex = 11;
		this.29.SelectedIndexChanged += delegate(object 1, EventArgs 2)
		{
			switch (this.29.SelectedIndex)
			{
			case 0:
				this.60(true, true);
				break;
			case 1:
				this.60(true, false);
				break;
			case 2:
				this.60(false, true);
				break;
			}
			1488.11(this.40);
			this.56(0);
			this.52(false);
			if (this.40.Items.Count > 0)
			{
				this.40.SelectedIndices.Add(0);
			}
			this.80();
			1488.12(this.40);
			this.74(true);
			this.29.Focus();
		};
		this.30.BackColor = Color.Transparent;
		this.30.Location = new Point(4, 22);
		this.30.Name = "tabAll";
		this.30.Padding = new Padding(3);
		this.30.Size = new Size(322, 246);
		this.30.TabIndex = 0;
		this.30.Text = "All";
		this.30.UseVisualStyleBackColor = true;
		this.32.BackColor = Color.Transparent;
		this.32.Location = new Point(4, 22);
		this.32.Name = "tabReds";
		this.32.Padding = new Padding(3);
		this.32.Size = new Size(322, 246);
		this.32.TabIndex = 1;
		this.32.Text = "Timing Points";
		this.32.UseVisualStyleBackColor = true;
		this.33.BackColor = Color.Transparent;
		this.33.Location = new Point(4, 22);
		this.33.Name = "tabGreens";
		this.33.Size = new Size(322, 246);
		this.33.TabIndex = 2;
		this.33.Text = "Inherited Points";
		this.33.UseVisualStyleBackColor = true;
		this.31.BackColor = Color.Transparent;
		this.31.Controls.Add(this.40);
		this.31.Location = new Point(251, 28);
		this.31.Name = "pnlTimingPoints";
		this.31.Size = new Size(323, 245);
		this.31.TabIndex = 12;
		this.40.BorderStyle = BorderStyle.None;
		this.40.Columns.AddRange(new ColumnHeader[]
		{
			this.41,
			this.42,
			this.43,
			this.44,
			this.45,
			this.67
		});
		this.40.ContextMenuStrip = this.109;
		this.40.Dock = DockStyle.Fill;
		this.40.FullRowSelect = true;
		this.40.HeaderStyle = ColumnHeaderStyle.Nonclickable;
		this.40.HideSelection = false;
		this.40.Location = new Point(0, 0);
		this.40.Name = "listTimingPoints";
		this.40.Size = new Size(323, 245);
		this.40.SmallImageList = this.46;
		this.40.TabIndex = 0;
		this.40.UseCompatibleStateImageBehavior = false;
		this.40.View = View.Details;
		this.40.ItemActivate += this.61;
		this.40.SelectedIndexChanged += this.59;
		this.40.Click += this.62;
		this.40.KeyDown += this.23;
		this.40.KeyUp += this.63;
		this.40.Leave += this.65;
		this.40.MouseUp += delegate(object 1, MouseEventArgs 2)
		{
			if (this.19)
			{
				this.74(true);
			}
		};
		this.41.Text = "Offset";
		this.41.TextAlign = HorizontalAlignment.Right;
		this.41.Width = 81;
		this.42.Text = "BPM";
		this.42.Width = 58;
		this.43.Text = "Meter";
		this.43.Width = 44;
		this.44.Text = "Sample";
		this.44.Width = 51;
		this.45.Text = "Vol.";
		this.45.Width = 45;
		this.67.Text = "Ki";
		this.67.Width = 25;
		this.109.Items.AddRange(new ToolStripItem[]
		{
			this.116,
			this.117,
			this.110,
			this.111,
			this.112,
			this.113,
			this.114,
			this.115
		});
		this.109.Name = "contextMenuStrip1";
		this.109.Size = new Size(171, 148);
		this.109.Opening += this.27;
		this.116.Name = "addControlPointToolStripMenuItem";
		this.116.Size = new Size(170, 22);
		this.116.Text = "A&dd Control Point";
		this.116.Click += this.32;
		this.117.Name = "toolStripMenuItem2";
		this.117.Size = new Size(167, 6);
		this.110.Name = "cutToolStripMenuItem";
		this.110.ShortcutKeyDisplayString = "Ctrl+X";
		this.110.Size = new Size(170, 22);
		this.110.Text = "Cu&t";
		this.110.Click += this.28;
		this.111.Name = "copyToolStripMenuItem";
		this.111.ShortcutKeyDisplayString = "Ctrl+C";
		this.111.Size = new Size(170, 22);
		this.111.Text = "&Copy";
		this.111.Click += this.29;
		this.112.Name = "pasteToolStripMenuItem";
		this.112.ShortcutKeyDisplayString = "Ctrl+V";
		this.112.Size = new Size(170, 22);
		this.112.Text = "&Paste";
		this.112.Click += delegate(object 1, EventArgs 2)
		{
			this.26();
		};
		this.113.Name = "deleteToolStripMenuItem";
		this.113.ShortcutKeyDisplayString = "Del";
		this.113.Size = new Size(170, 22);
		this.113.Text = "De&lete";
		this.113.Click += this.30;
		this.114.Name = "toolStripMenuItem1";
		this.114.Size = new Size(167, 6);
		this.115.Name = "selectAllToolStripMenuItem";
		this.115.ShortcutKeyDisplayString = "Ctrl+A";
		this.115.Size = new Size(170, 22);
		this.115.Text = "Select &All";
		this.115.Click += this.31;
		this.46.ColorDepth = ColorDepth.Depth24Bit;
		this.46.ImageSize = new Size(16, 16);
		this.46.TransparentColor = Color.Transparent;
		this.34.Controls.Add(this.118);
		this.34.Controls.Add(this.104);
		this.34.Controls.Add(this.105);
		this.34.Controls.Add(this.101);
		this.34.Controls.Add(this.102);
		this.34.Controls.Add(this.103);
		this.34.Location = new Point(4, 303);
		this.34.Name = "grpTimingScale";
		this.34.Size = new Size(574, 74);
		this.34.TabIndex = 12;
		this.34.TabStop = false;
		this.34.Text = "When applying timing changes...";
		this.104.Items.Add("1/1");
		this.104.Items.Add("1/2");
		this.104.Items.Add("1/3");
		this.104.Items.Add("1/4");
		this.104.Items.Add("1/5");
		this.104.Items.Add("1/6");
		this.104.Items.Add("1/7");
		this.104.Items.Add("1/8");
		this.104.Items.Add("1/9");
		this.104.Items.Add("1/12");
		this.104.Items.Add("1/24");
		this.104.Location = new Point(478, 22);
		this.104.Name = "udBeatSnap";
		this.104.Size = new Size(48, 20);
		this.104.TabIndex = 4;
		this.104.Text = "1/4";
		this.105.AutoSize = true;
		this.105.FlatStyle = FlatStyle.System;
		this.105.Location = new Point(340, 24);
		this.105.Name = "lblBeatSnap";
		this.105.Size = new Size(132, 15);
		this.105.TabIndex = 3;
		this.105.Text = "Use beat snap divisor of";
		this.101.AutoSize = true;
		this.101.FlatStyle = FlatStyle.System;
		this.101.Location = new Point(191, 22);
		this.101.Name = "chkResnapSliders";
		this.101.Size = new Size(143, 20);
		this.101.TabIndex = 2;
		this.101.Text = "Resnap slider lengths";
		this.101.UseVisualStyleBackColor = true;
		this.102.AutoSize = true;
		this.102.FlatStyle = FlatStyle.System;
		this.102.Location = new Point(8, 43);
		this.102.Name = "chkSnapObjects";
		this.102.Size = new Size(176, 20);
		this.102.TabIndex = 1;
		this.102.Text = "Snap objects to new timing";
		this.102.UseVisualStyleBackColor = true;
		this.103.AutoSize = true;
		this.103.FlatStyle = FlatStyle.System;
		this.103.Location = new Point(8, 22);
		this.103.Name = "chkScaleObjects";
		this.103.Size = new Size(177, 20);
		this.103.TabIndex = 0;
		this.103.Text = "Scale objects to new timing";
		this.103.UseVisualStyleBackColor = true;
		this.35.AutoSize = true;
		this.35.FlatStyle = FlatStyle.System;
		this.35.Location = new Point(252, 282);
		this.35.Name = "chkInherit";
		this.35.Size = new Size(196, 20);
		this.35.TabIndex = 15;
		this.35.Text = "Inherit previous timing settings";
		this.35.UseVisualStyleBackColor = true;
		this.35.CheckedChanged += this.49;
		this.36.Controls.Add(this.37);
		this.36.Location = new Point(509, 278);
		this.36.Name = "pnlToolStrip";
		this.36.Size = new Size(64, 25);
		this.36.TabIndex = 16;
		this.37.BackColor = SystemColors.Control;
		this.37.GripStyle = ToolStripGripStyle.Hidden;
		this.37.Items.AddRange(new ToolStripItem[]
		{
			this.38,
			this.39
		});
		this.37.Location = new Point(0, 0);
		this.37.Name = "toolStrip1";
		this.37.Padding = new Padding(0);
		this.37.RenderMode = ToolStripRenderMode.System;
		this.37.Size = new Size(64, 27);
		this.37.TabIndex = 0;
		this.37.Text = "toolStrip1";
		this.38.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.38.Image = 277.GetAddImage();
		this.38.ImageTransparentColor = Color.Magenta;
		this.38.Margin = new Padding(0, 1, 8, 2);
		this.38.Name = "toolAdd";
		this.38.Overflow = ToolStripItemOverflow.Never;
		this.38.Padding = new Padding(2);
		this.38.Size = new Size(24, 24);
		this.38.Text = "Add Timing Section";
		this.38.Click += this.21;
		this.39.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.39.Image = 277.GetSubImage();
		this.39.ImageTransparentColor = Color.Magenta;
		this.39.Name = "toolRemove";
		this.39.Padding = new Padding(2);
		this.39.Size = new Size(24, 24);
		this.39.Text = "Remove Timing Section";
		this.39.Click += delegate(object 1, EventArgs 2)
		{
			if (this.40.SelectedIndices.Count != 0)
			{
				int num = Math.Max(this.40.SelectedIndices[0] - 1, 0);
				this.6.8.13((2451)9, (2450)0);
				this.6.8.24<1259>(this.11, false);
				foreach (1259 item in this.11)
				{
					this.9.Remove(item);
				}
				1488.11(this.40);
				this.15 = true;
				foreach (object obj in this.40.Items)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					if (listViewItem.Selected)
					{
						this.40.Items.Remove(listViewItem);
					}
				}
				this.15 = false;
				this.53();
				if (num < this.9.Count)
				{
					this.40.SelectedIndices.Add(num);
				}
				else if (this.9.Count > 0)
				{
					this.40.SelectedIndices.Add(this.9.Count - 1);
				}
				1488.12(this.40);
				this.80();
				this.74(true);
				this.55(num);
				this.40.Focus();
				this.16 = true;
				1488.12(this.40);
			}
		};
		base.AcceptButton = this.21;
		base.AutoScaleDimensions = new SizeF(96f, 96f);
		base.AutoScaleMode = AutoScaleMode.Dpi;
		base.CancelButton = this.22;
		base.ClientSize = new Size(582, 422);
		base.Controls.Add(this.31);
		base.Controls.Add(this.35);
		base.Controls.Add(this.34);
		base.Controls.Add(this.36);
		base.Controls.Add(this.29);
		base.Controls.Add(this.24);
		base.Controls.Add(this.21);
		base.Controls.Add(this.22);
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "TimingEntry";
		base.ShowIcon = false;
		base.ShowInTaskbar = false;
		base.SizeGripStyle = SizeGripStyle.Hide;
		base.StartPosition = FormStartPosition.CenterParent;
		this.Text = "Timing and Control Points";
		base.FormClosing += this.36;
		base.Load += this.33;
		((ISupportInitialize)this.123).EndInit();
		this.24.ResumeLayout(false);
		this.25.ResumeLayout(false);
		this.48.ResumeLayout(false);
		this.48.PerformLayout();
		((ISupportInitialize)this.53).EndInit();
		this.47.ResumeLayout(false);
		this.47.PerformLayout();
		((ISupportInitialize)this.106).EndInit();
		((ISupportInitialize)this.107).EndInit();
		this.26.ResumeLayout(false);
		this.57.ResumeLayout(false);
		this.57.PerformLayout();
		((ISupportInitialize)this.61).EndInit();
		this.58.ResumeLayout(false);
		this.58.PerformLayout();
		((ISupportInitialize)this.108).EndInit();
		this.68.ResumeLayout(false);
		this.79.ResumeLayout(false);
		this.79.PerformLayout();
		((ISupportInitialize)this.80).EndInit();
		this.73.ResumeLayout(false);
		this.73.PerformLayout();
		((ISupportInitialize)this.75).EndInit();
		this.69.ResumeLayout(false);
		this.69.PerformLayout();
		((ISupportInitialize)this.70).EndInit();
		this.27.ResumeLayout(false);
		this.92.ResumeLayout(false);
		this.92.PerformLayout();
		((ISupportInitialize)this.94).EndInit();
		((ISupportInitialize)this.95).EndInit();
		this.85.ResumeLayout(false);
		this.85.PerformLayout();
		this.120.ResumeLayout(false);
		this.28.ResumeLayout(false);
		this.98.ResumeLayout(false);
		this.98.PerformLayout();
		this.121.ResumeLayout(false);
		this.119.ResumeLayout(false);
		this.29.ResumeLayout(false);
		this.31.ResumeLayout(false);
		this.109.ResumeLayout(false);
		this.34.ResumeLayout(false);
		this.34.PerformLayout();
		this.36.ResumeLayout(false);
		this.36.PerformLayout();
		this.37.ResumeLayout(false);
		this.37.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	// Token: 0x060030F9 RID: 12537 RVA: 0x0012439C File Offset: 0x0012259C
	private void 38(1257 1)
	{
		List<1259> list = this.81();
		if (list.Count <= 0)
		{
			return;
		}
		this.6.8.13((2451)21, (2450)0);
		this.6.8.24<1259>(list, false);
		foreach (1259 2 in list)
		{
			2.5 = 1;
		}
	}

	// Token: 0x060030FA RID: 12538 RVA: 0x00124420 File Offset: 0x00122620
	private void 39(object 1, EventArgs 2)
	{
		if (!this.15 && this.56.Checked)
		{
			this.55.Checked = false;
			this.54.Checked = false;
			this.53.Enabled = false;
			this.53.Value = 5m;
			this.38((1257)3);
			this.51();
		}
	}

	// Token: 0x060030FB RID: 12539 RVA: 0x00124484 File Offset: 0x00122684
	private void 40(object 1, EventArgs 2)
	{
		if (!this.15 && this.54.Checked)
		{
			this.56.Checked = false;
			this.55.Checked = false;
			this.53.Enabled = true;
			this.41(null, null);
		}
	}

	// Token: 0x060030FC RID: 12540 RVA: 0x001244D2 File Offset: 0x001226D2
	private void 41(object 1, EventArgs 2)
	{
		if (!this.15)
		{
			this.38((1257)((int)this.53.Value));
			this.51();
		}
	}

	// Token: 0x060030FD RID: 12541 RVA: 0x001244F8 File Offset: 0x001226F8
	private void 42(object 1, EventArgs 2)
	{
		if (!this.15 && this.62.Checked)
		{
			this.65.Checked = false;
			this.64.Checked = false;
			this.63.Checked = false;
			this.61.Enabled = true;
			this.51();
		}
	}

	// Token: 0x060030FE RID: 12542 RVA: 0x00124550 File Offset: 0x00122750
	private void 43(object 1, EventArgs 2)
	{
		if (!this.15)
		{
			this.6.8.13((2451)18, (2450)0);
			this.6.8.23(this.12, false);
			this.12.1 = (double)(-100.0m / this.61.Value);
			this.51();
		}
	}

	// Token: 0x060030FF RID: 12543 RVA: 0x001245C4 File Offset: 0x001227C4
	private void 44(object 1, EventArgs 2)
	{
		if (!this.15)
		{
			this.6.8.13((2451)18, (2450)0);
			this.6.8.23(this.12, false);
			this.12.1 = 60000.0 / (double)this.107.Value;
			this.51();
		}
	}

	// Token: 0x06003100 RID: 12544 RVA: 0x00124630 File Offset: 0x00122830
	private void 45(object 1, EventArgs 2)
	{
		if (!this.15)
		{
			this.6.8.13((2451)0, (2450)0);
			this.6.8.23(this.12, false);
			this.12.3 = (double)this.106.Value;
			this.54();
		}
	}

	// Token: 0x06003101 RID: 12545 RVA: 0x00124690 File Offset: 0x00122890
	private void 46(object 1, EventArgs 2)
	{
		this.6.8.13((2451)0, (2450)0);
		this.6.8.23(this.12, false);
		this.12.3 = (double)((1226.16 >= 0) ? 1226.16 : 0);
		this.106.Value = (decimal)this.12.3;
		this.54();
	}

	// Token: 0x06003102 RID: 12546 RVA: 0x00124704 File Offset: 0x00122904
	private void 47(object 1, EventArgs 2)
	{
		if (!this.15)
		{
			this.6.8.13((2451)0, (2450)0);
			this.6.8.23(this.12, false);
			this.12.3 = (double)this.108.Value;
			this.54();
		}
	}

	// Token: 0x06003103 RID: 12547 RVA: 0x00124764 File Offset: 0x00122964
	private void 48(object 1, EventArgs 2)
	{
		this.6.8.13((2451)0, (2450)0);
		this.6.8.23(this.12, false);
		this.12.3 = (double)1226.16;
		this.108.Value = (decimal)this.12.3;
		this.54();
	}

	// Token: 0x06003104 RID: 12548 RVA: 0x001247CC File Offset: 0x001229CC
	private void 49(object 1, EventArgs 2)
	{
		if (this.15 || this.12 == null)
		{
			return;
		}
		this.6.8.13((2451)18, (2450)0);
		foreach (1259 3 in this.11)
		{
			if (this.35.Checked)
			{
				if (3.1())
				{
					this.6.8.23(3, false);
					3.2(false);
				}
			}
			else
			{
				this.6.8.23(3, false);
				3.1 = this.50(3);
				3.2(true);
			}
		}
		this.35.ThreeState = false;
		this.51();
		this.74(true);
	}

	// Token: 0x06003105 RID: 12549 RVA: 0x001248AC File Offset: 0x00122AAC
	private double 50(1259 1)
	{
		for (int i = this.9.IndexOf(1); i >= 0; i--)
		{
			1259 2 = this.9[i];
			if (2.1())
			{
				return 2.1;
			}
		}
		return 500.0;
	}

	// Token: 0x06003106 RID: 12550 RVA: 0x001248F8 File Offset: 0x00122AF8
	private void 51()
	{
		this.15 = true;
		if (this.40.SelectedIndices.Count == 0)
		{
			return;
		}
		Color backColor = 1045.5(Color.FromKnownColor(KnownColor.Control), Color.FromKnownColor(KnownColor.Window), 0.5f);
		foreach (object obj in this.40.SelectedIndices)
		{
			int num = (int)obj;
			ListViewItem listViewItem = this.57(this.9[num]);
			if (num % 2 == 0)
			{
				listViewItem.BackColor = backColor;
			}
			for (int i = 0; i < 6; i++)
			{
				this.40.Items[num].SubItems[i].Text = listViewItem.SubItems[i].Text;
				this.40.Items[num].SubItems[i].ForeColor = listViewItem.SubItems[i].ForeColor;
			}
			this.40.Items[num].ImageIndex = listViewItem.ImageIndex;
		}
		this.15 = false;
	}

	// Token: 0x06003107 RID: 12551 RVA: 0x00124A44 File Offset: 0x00122C44
	private void 52(bool 1)
	{
		this.15 = true;
		int 2 = this.40.Items.IndexOf(this.40.TopItem);
		this.40.Items.Clear();
		if (this.11 == null)
		{
			1 = false;
		}
		int index = 0;
		bool flag = false;
		Color backColor = 1045.5(Color.FromKnownColor(KnownColor.Control), Color.FromKnownColor(KnownColor.Window), 0.5f);
		foreach (1259 3 in this.9)
		{
			ListViewItem listViewItem = this.57(3);
			if (flag)
			{
				listViewItem.BackColor = backColor;
			}
			flag = !flag;
			if (1)
			{
				int num = this.11.IndexOf(3, index);
				if (num >= 0)
				{
					listViewItem.Selected = true;
					index = num;
				}
			}
			this.40.Items.Add(listViewItem);
		}
		this.55(2);
		this.15 = false;
	}

	// Token: 0x06003108 RID: 12552 RVA: 0x00124B4C File Offset: 0x00122D4C
	private void 53()
	{
		Color color = 1045.5(Color.FromKnownColor(KnownColor.Control), Color.FromKnownColor(KnownColor.Window), 0.5f);
		Color color2 = Color.FromKnownColor(KnownColor.Window);
		bool flag = false;
		foreach (object obj in this.40.Items)
		{
			((ListViewItem)obj).BackColor = (flag ? color : color2);
			flag = !flag;
		}
	}

	// Token: 0x06003109 RID: 12553 RVA: 0x00124BD8 File Offset: 0x00122DD8
	private void 54()
	{
		int <<EMPTY_NAME>> = this.40.Items.IndexOf(this.40.TopItem);
		this.9.Sort();
		this.11.Sort();
		1488.11(this.40);
		this.52(true);
		this.56(<<EMPTY_NAME>>);
		1488.12(this.40);
		this.15 = false;
	}

	// Token: 0x0600310A RID: 12554 RVA: 0x00124C44 File Offset: 0x00122E44
	private void 55(int 1)
	{
		int count = this.40.Items.Count;
		if (count == 0)
		{
			return;
		}
		if (1 < 0)
		{
			1 = 0;
		}
		if (1 >= count)
		{
			1 = count - 1;
		}
		try
		{
			this.40.EnsureVisible(1);
		}
		catch (ArgumentOutOfRangeException)
		{
		}
	}

	// Token: 0x0600310B RID: 12555 RVA: 0x00124C98 File Offset: 0x00122E98
	private void 56(int 1)
	{
		int count = this.40.Items.Count;
		if (count == 0)
		{
			return;
		}
		if (1 < 0)
		{
			1 = 0;
		}
		if (1 >= count)
		{
			1 = count - 1;
		}
		try
		{
			this.40.EnsureVisible(count - 1);
			this.40.EnsureVisible(1);
		}
		catch (ArgumentOutOfRangeException)
		{
		}
	}

	// Token: 0x0600310C RID: 12556 RVA: 0x00124CFC File Offset: 0x00122EFC
	private ListViewItem 57(1259 1)
	{
		if (1.1())
		{
			string[] array = new string[6];
			array[0] = string.Format("{0:00}:{1:00}:{2:000}", (int)1.3 / 60000, (int)1.3 % 60000 / 1000, (int)1.3 % 1000);
			array[1] = 1.8().ToString("0.000");
			int num = (int)1.5;
			array[2] = num.ToString() + "/4";
			string str = this.58(1);
			string str2;
			if (1.2 <= 1253.Default)
			{
				str2 = string.Empty;
			}
			else
			{
				string str3 = ":C";
				num = (int)1.2;
				str2 = str3 + num.ToString();
			}
			array[3] = str + str2;
			array[4] = 1.6.ToString() + "%";
			array[5] = (1.3() ? "☆" : string.Empty);
			return new ListViewItem(array, 0);
		}
		string[] array2 = new string[6];
		array2[0] = string.Format("{0:00}:{1:00}:{2:000}", (int)1.3 / 60000, (int)1.3 % 60000 / 1000, (int)1.3 % 1000);
		array2[1] = "x" + (-100.0 / 1.1).ToString("0.00");
		array2[2] = string.Empty;
		string str4 = this.58(1);
		string str5;
		if (1.2 <= 1253.Default)
		{
			str5 = string.Empty;
		}
		else
		{
			string str6 = ":C";
			int 2 = (int)1.2;
			str5 = str6 + 2.ToString();
		}
		array2[3] = str4 + str5;
		array2[4] = 1.6.ToString() + "%";
		array2[5] = (1.3() ? "☆" : string.Empty);
		return new ListViewItem(array2, 1);
	}

	// Token: 0x0600310D RID: 12557 RVA: 0x00124F00 File Offset: 0x00123100
	private string 58(1259 1)
	{
		string result;
		switch (1.4)
		{
		case 1254.Normal:
			result = "N";
			break;
		case 1254.Soft:
			result = "S";
			break;
		case 1254.Drum:
			result = "D";
			break;
		default:
			result = "?";
			break;
		}
		return result;
	}

	// Token: 0x0600310E RID: 12558 RVA: 0x00124F49 File Offset: 0x00123149
	private void 59(object 1, EventArgs 2)
	{
		if (!this.15)
		{
			this.80();
			this.16 = true;
			this.19 = true;
		}
	}

	// Token: 0x0600310F RID: 12559 RVA: 0x00124F68 File Offset: 0x00123168
	private void 60(bool 1, bool 2)
	{
		List<1259> list = new List<1259>();
		List<1259> list2 = new List<1259>();
		foreach (1259 3 in this.9)
		{
			if (3.1())
			{
				if (1)
				{
					list.Add(3);
				}
				else
				{
					list2.Add(3);
				}
			}
			else if (2)
			{
				list.Add(3);
			}
			else
			{
				list2.Add(3);
			}
		}
		foreach (1259 4 in this.10)
		{
			if (4.1())
			{
				if (1)
				{
					list.Add(4);
				}
				else
				{
					list2.Add(4);
				}
			}
			else if (2)
			{
				list.Add(4);
			}
			else
			{
				list2.Add(4);
			}
		}
		list.Sort();
		list2.Sort();
		this.9 = list;
		this.10 = list2;
	}

	// Token: 0x06003110 RID: 12560 RVA: 0x0012507C File Offset: 0x0012327C
	private void 61(object 1, EventArgs 2)
	{
		if (this.12 != null)
		{
			1226.4((int)this.12.3, false, false);
		}
	}

	// Token: 0x06003111 RID: 12561 RVA: 0x00125099 File Offset: 0x00123299
	private void 62(object 1, EventArgs 2)
	{
		if (this.19)
		{
			this.74(true);
		}
		this.40.Focus();
	}

	// Token: 0x06003112 RID: 12562 RVA: 0x00125099 File Offset: 0x00123299
	private void 63(object 1, KeyEventArgs 2)
	{
		if (this.19)
		{
			this.74(true);
		}
		this.40.Focus();
	}

	// Token: 0x06003113 RID: 12563 RVA: 0x001250B8 File Offset: 0x001232B8
	private bool 64(1259 1)
	{
		1259 2 = (this.10.Count == 0) ? this.9[0] : ((this.9.Count != 0) ? ((this.9[0].3 < this.10[0].3) ? this.9[0] : this.10[0]) : this.10[0]);
		return 1 == 2;
	}

	// Token: 0x06003114 RID: 12564 RVA: 0x0012513E File Offset: 0x0012333E
	private void 65(object 1, EventArgs 2)
	{
		if (this.19)
		{
			this.74(true);
		}
	}

	// Token: 0x06003115 RID: 12565 RVA: 0x00125150 File Offset: 0x00123350
	private void 66(object 1, EventArgs 2)
	{
		if (this.15 || !this.91.Checked)
		{
			return;
		}
		this.90.Checked = false;
		this.124.Checked = false;
		this.6.8.13((2451)22, (2450)0);
		this.6.8.24<1259>(this.11, false);
		foreach (1259 3 in this.11)
		{
			3.2 = 1253.Default;
		}
		this.51();
	}

	// Token: 0x06003116 RID: 12566 RVA: 0x00125200 File Offset: 0x00123400
	private void 67(object 1, EventArgs 2)
	{
		if (this.15 || !this.90.Checked)
		{
			return;
		}
		this.91.Checked = false;
		this.124.Checked = false;
		this.6.8.13((2451)22, (2450)0);
		this.6.8.24<1259>(this.11, false);
		foreach (1259 3 in this.11)
		{
			3.2 = 1253.Custom1;
		}
		this.51();
	}

	// Token: 0x06003117 RID: 12567 RVA: 0x001252B0 File Offset: 0x001234B0
	private void 68(object 1, EventArgs 2)
	{
		if (!this.124.Checked)
		{
			return;
		}
		foreach (1259 3 in this.11)
		{
			3.2 = (1253)((int)this.123.Value);
		}
		this.51();
	}

	// Token: 0x06003118 RID: 12568 RVA: 0x00125324 File Offset: 0x00123524
	private void 69(object 1, EventArgs 2)
	{
		if (this.15)
		{
			return;
		}
		this.15 = true;
		this.94.Value = this.95.Value;
		this.15 = false;
		this.6.8.13((2451)19, (2450)0);
		this.6.8.24<1259>(this.11, false);
		foreach (1259 3 in this.11)
		{
			3.6 = this.95.Value;
		}
		this.51();
	}

	// Token: 0x06003119 RID: 12569 RVA: 0x001253E4 File Offset: 0x001235E4
	private void 70(object 1, EventArgs 2)
	{
		1226.30(new 1244(1245.Normal, this.12.4, this.12.2, this.12.6, 1254.None), 0f, false);
	}

	// Token: 0x0600311A RID: 12570 RVA: 0x00125419 File Offset: 0x00123619
	private void 71(object 1, EventArgs 2)
	{
		1226.30(new 1244(1245.Whistle, this.12.4, this.12.2, this.12.6, 1254.None), 0f, false);
	}

	// Token: 0x0600311B RID: 12571 RVA: 0x0012544E File Offset: 0x0012364E
	private void 72(object 1, EventArgs 2)
	{
		1226.30(new 1244(1245.Finish, this.12.4, this.12.2, this.12.6, 1254.None), 0f, false);
	}

	// Token: 0x0600311C RID: 12572 RVA: 0x00125483 File Offset: 0x00123683
	private void 73(object 1, EventArgs 2)
	{
		1226.30(new 1244(1245.Clap, this.12.4, this.12.2, this.12.6, 1254.None), 0f, false);
	}

	// Token: 0x0600311D RID: 12573 RVA: 0x001254B8 File Offset: 0x001236B8
	private void 74(bool 1)
	{
		this.19 = false;
		if (this.12 == null)
		{
			this.24.Enabled = false;
			this.35.Enabled = false;
			this.39.Enabled = false;
			return;
		}
		this.24.Enabled = true;
		this.35.Enabled = true;
		this.39.Enabled = true;
		if (2)
		{
			1488.11(this.24);
		}
		this.15 = true;
		bool flag = false;
		bool flag2 = this.11.Count > 1;
		if (flag2)
		{
			bool flag3 = this.24.SelectedIndex == 0;
			if (!this.24.TabPages.Contains(this.68))
			{
				this.24.TabPages.Insert(0, this.68);
			}
			if (flag3)
			{
				this.24.SelectedIndex = 0;
			}
			this.24.TabPages.Remove(this.25);
			this.24.TabPages.Remove(this.26);
		}
		else if (flag = this.12.1())
		{
			bool flag4 = this.24.SelectedIndex == 0;
			if (!this.24.TabPages.Contains(this.25))
			{
				this.24.TabPages.Insert(0, this.25);
			}
			if (flag4)
			{
				this.24.SelectedIndex = 0;
			}
			this.24.TabPages.Remove(this.26);
			this.24.TabPages.Remove(this.68);
		}
		else
		{
			bool flag5 = this.24.SelectedIndex == 0;
			if (!this.24.TabPages.Contains(this.26))
			{
				this.24.TabPages.Insert(0, this.26);
			}
			if (flag5)
			{
				this.24.SelectedIndex = 0;
			}
			this.24.TabPages.Remove(this.25);
			this.24.TabPages.Remove(this.68);
		}
		if (flag2)
		{
			this.70.Value = 0m;
			bool enabled = this.13 != null;
			bool flag6 = this.14 != null;
			this.73.Enabled = enabled;
			this.78.Enabled = enabled;
			this.77.Enabled = enabled;
			this.76.Enabled = enabled;
			this.75.Enabled = enabled;
			this.79.Enabled = flag6;
			this.84.Enabled = flag6;
			this.83.Enabled = flag6;
			this.82.Enabled = flag6;
			this.81.Enabled = flag6;
			this.80.Enabled = flag6;
			if (this.11.TrueForAll((1259 1) => !1.1() || 1.5 == this.12.5))
			{
				this.78(this.12.5, this.78, this.77, this.76, this.75);
			}
			else
			{
				this.79(this.78, this.77, this.76, this.75);
			}
			if (flag6)
			{
				if (this.11.TrueForAll(new Predicate<1259>(this.82)))
				{
					this.76(this.14.1, this.84, this.83, this.82, this.81, this.80);
				}
				else
				{
					this.77(this.84, this.83, this.82, this.81, this.80);
				}
			}
		}
		else if (flag)
		{
			this.106.Value = this.75(this.12.3, this.106.Minimum, this.106.Maximum);
			this.107.Value = this.75(this.12.8(), this.107.Minimum, this.107.Maximum);
			this.78(this.12.5, this.56, this.55, this.54, this.53);
		}
		else
		{
			this.108.Value = this.75(this.12.3, this.108.Minimum, this.108.Maximum);
			this.76(this.12.1, this.65, this.64, this.63, this.62, this.61);
		}
		if (this.11.TrueForAll(new Predicate<1259>(this.83)))
		{
			try
			{
				this.97.SelectedItem = this.12.4.ToString();
				goto IL_4DB;
			}
			catch (Exception)
			{
				this.97.SelectedItems.Clear();
				goto IL_4DB;
			}
		}
		this.97.SelectedItems.Clear();
		IL_4DB:
		if (this.11.TrueForAll(new Predicate<1259>(this.84)))
		{
			this.91.Checked = (this.12.2 == 1253.Default);
			this.90.Checked = (this.12.2 == 1253.Custom1);
			Control control = this.123;
			bool enabled2 = this.124.Checked = (this.12.2 >= 1253.Custom2);
			control.Enabled = enabled2;
			this.123.Value = Math.Max(2, Math.Min((int)this.12.2, 100));
		}
		else
		{
			this.91.Checked = false;
			this.90.Checked = false;
			Control control2 = this.123;
			bool enabled3 = this.124.Checked = false;
			control2.Enabled = enabled3;
		}
		this.95.Value = Math.Min(100, Math.Max(5, this.12.6));
		this.94.Value = this.12.6;
		if (this.11.TrueForAll((1259 1) => 1.3() == this.12.3()))
		{
			this.100.CheckState = (this.12.3() ? CheckState.Checked : CheckState.Unchecked);
			this.100.ThreeState = false;
		}
		else
		{
			this.100.CheckState = CheckState.Indeterminate;
		}
		this.100.Enabled = (this.100.CheckState != CheckState.Unchecked || (this.11.Count == 1 && !this.64(this.11[0])) || this.11.Count > 1);
		this.125.Enabled = this.11.Exists(new Predicate<1259>(2322.2324.instance.2));
		if (this.11.TrueForAll(new Predicate<1259>(this.85)))
		{
			this.125.CheckState = (((this.12.8 & (1258)8) > (1258)0) ? CheckState.Checked : CheckState.Unchecked);
			this.125.ThreeState = false;
		}
		else
		{
			this.125.CheckState = CheckState.Indeterminate;
		}
		if (this.11.TrueForAll(new Predicate<1259>(this.86)))
		{
			this.35.CheckState = ((!this.12.1()) ? CheckState.Checked : CheckState.Unchecked);
			this.35.ThreeState = false;
		}
		else
		{
			this.35.CheckState = CheckState.Indeterminate;
		}
		this.15 = false;
		if (2)
		{
			1488.12(this.24);
		}
	}

	// Token: 0x0600311E RID: 12574 RVA: 0x00125C44 File Offset: 0x00123E44
	private decimal 75(double 1, decimal 2, decimal 3)
	{
		if (double.IsNaN(1))
		{
			return 2;
		}
		if (double.IsNegativeInfinity(1))
		{
			return 2;
		}
		if (double.IsPositiveInfinity(1))
		{
			return 3;
		}
		return (decimal)Math.Min((double)3, Math.Max((double)2, 1));
	}

	// Token: 0x0600311F RID: 12575 RVA: 0x00125C84 File Offset: 0x00123E84
	private void 76(double 1, RadioButton 2, RadioButton 3, RadioButton 4, RadioButton 5, NumericUpDown 6)
	{
		2.Checked = (1 == -133.333333333333);
		3.Checked = (1 == -100.0);
		4.Checked = (1 == -66.6666666666667);
		5.Checked = (1 != -133.333333333333 && 1 != -100.0 && 1 != -66.6666666666667);
		6.Enabled = 5.Checked;
		decimal num = (decimal)(-100.0 / 1);
		2147 7 = this.6.15;
		if (7 == 2147.Taiko || 7 == 2147.OsuMania)
		{
			6.Minimum = Math.Min(0.01m, num);
			6.Maximum = Math.Max(10.0m, num);
		}
		else
		{
			6.Minimum = Math.Min(0.1m, num);
			6.Maximum = Math.Max(10.0m, num);
		}
		6.Value = num;
	}

	// Token: 0x06003120 RID: 12576 RVA: 0x00125D94 File Offset: 0x00123F94
	private void 77(RadioButton 1, RadioButton 2, RadioButton 3, RadioButton 4, NumericUpDown 5)
	{
		1.Checked = false;
		2.Checked = false;
		3.Checked = false;
		4.Checked = false;
		5.Enabled = false;
		2147 6 = this.6.15;
		if (6 == 2147.Taiko || 6 == 2147.OsuMania)
		{
			5.Minimum = 0.01m;
			5.Maximum = 10.0m;
		}
		else
		{
			5.Minimum = 0.1m;
			5.Maximum = 10.0m;
		}
		5.Value = 1.0m;
	}

	// Token: 0x06003121 RID: 12577 RVA: 0x00125E34 File Offset: 0x00124034
	private void 78(1257 1, RadioButton 2, RadioButton 3, RadioButton 4, NumericUpDown 5)
	{
		int num = 5;
		if (1 != (1257)3)
		{
			if (1 != (1257)4)
			{
				num = (int)1;
				4.Checked = true;
				5.Enabled = true;
				2.Checked = false;
				3.Checked = false;
			}
			else
			{
				3.Checked = true;
				2.Checked = false;
				4.Checked = false;
				5.Enabled = false;
			}
		}
		else
		{
			2.Checked = true;
			3.Checked = false;
			4.Checked = false;
			5.Enabled = false;
		}
		5.Minimum = Math.Min(5, num);
		5.Maximum = Math.Max(7, num);
		5.Value = num;
	}

	// Token: 0x06003122 RID: 12578 RVA: 0x00125EE0 File Offset: 0x001240E0
	private void 79(RadioButton 1, RadioButton 2, RadioButton 3, NumericUpDown 4)
	{
		1.Checked = false;
		2.Checked = false;
		3.Checked = false;
		4.Enabled = false;
		4.Minimum = 5m;
		4.Maximum = 7m;
		4.Value = 5m;
	}

	// Token: 0x06003123 RID: 12579 RVA: 0x00125F34 File Offset: 0x00124134
	private void 80()
	{
		this.11 = new List<1259>();
		this.13 = null;
		this.14 = null;
		if (this.40.SelectedIndices.Count == 0)
		{
			this.12 = null;
			return;
		}
		foreach (object obj in this.40.SelectedIndices)
		{
			int index = (int)obj;
			this.11.Add(this.9[index]);
			if (this.13 == null || this.14 == null)
			{
				if (this.9[index].1())
				{
					if (this.13 == null)
					{
						this.13 = this.9[index];
					}
				}
				else if (this.14 == null)
				{
					this.14 = this.9[index];
				}
			}
		}
		this.12 = this.11[0];
	}

	// Token: 0x06003124 RID: 12580 RVA: 0x00126044 File Offset: 0x00124244
	private List<1259> 81()
	{
		2322.2323 <<EMPTY_NAME>> = new 2322.2323();
		if (this.11.Count == 0)
		{
			return new List<1259>();
		}
		<<EMPTY_NAME>>.1 = this.11.Last<1259>();
		<<EMPTY_NAME>>.2 = (this.13 ?? <<EMPTY_NAME>>.1);
		<<EMPTY_NAME>>.3 = this.9.Find(new Predicate<1259>(<<EMPTY_NAME>>.1));
		return this.9.SkipWhile(new Func<1259, bool>(<<EMPTY_NAME>>.2)).TakeWhile(new Func<1259, bool>(<<EMPTY_NAME>>.3)).ToList<1259>();
	}

	// Token: 0x06003125 RID: 12581 RVA: 0x001260DB File Offset: 0x001242DB
	private bool 82(1259 1)
	{
		return 1.1() || 1.1 == this.14.1;
	}

	// Token: 0x06003126 RID: 12582 RVA: 0x001260FA File Offset: 0x001242FA
	private bool 83(1259 1)
	{
		return 1.4 == this.12.4;
	}

	// Token: 0x06003127 RID: 12583 RVA: 0x0012610F File Offset: 0x0012430F
	private bool 84(1259 1)
	{
		return 1.2 == this.12.2;
	}

	// Token: 0x06003128 RID: 12584 RVA: 0x00126124 File Offset: 0x00124324
	private bool 85(1259 1)
	{
		return (1.8 & (1258)8) == (this.12.8 & (1258)8);
	}

	// Token: 0x06003129 RID: 12585 RVA: 0x0012613D File Offset: 0x0012433D
	private bool 86(1259 1)
	{
		return 1.1() == this.12.1();
	}

	// Token: 0x040023D2 RID: 9170
	private readonly 2263 6;

	// Token: 0x040023D3 RID: 9171
	private new readonly 2325 7;

	// Token: 0x040023D4 RID: 9172
	private new 1259 8;

	// Token: 0x040023D5 RID: 9173
	private List<1259> 9;

	// Token: 0x040023D6 RID: 9174
	private List<1259> 10;

	// Token: 0x040023D7 RID: 9175
	private new List<1259> 11;

	// Token: 0x040023D8 RID: 9176
	private new 1259 12;

	// Token: 0x040023D9 RID: 9177
	private 1259 13;

	// Token: 0x040023DA RID: 9178
	private 1259 14;

	// Token: 0x040023DB RID: 9179
	private bool 15;

	// Token: 0x040023DC RID: 9180
	private bool 16;

	// Token: 0x040023DD RID: 9181
	private bool 17;

	// Token: 0x040023DE RID: 9182
	private int 18 = -1;

	// Token: 0x040023DF RID: 9183
	private bool 19;

	// Token: 0x040023E1 RID: 9185
	private Button 21;

	// Token: 0x040023E2 RID: 9186
	private Button 22;

	// Token: 0x040023E3 RID: 9187
	private ToolTip 23;

	// Token: 0x040023E4 RID: 9188
	private TabControl 24;

	// Token: 0x040023E5 RID: 9189
	private TabPage 25;

	// Token: 0x040023E6 RID: 9190
	private TabPage 26;

	// Token: 0x040023E7 RID: 9191
	private TabPage 27;

	// Token: 0x040023E8 RID: 9192
	private TabPage 28;

	// Token: 0x040023E9 RID: 9193
	private TabControl 29;

	// Token: 0x040023EA RID: 9194
	private TabPage 30;

	// Token: 0x040023EB RID: 9195
	private Panel 31;

	// Token: 0x040023EC RID: 9196
	private TabPage 32;

	// Token: 0x040023ED RID: 9197
	private TabPage 33;

	// Token: 0x040023EE RID: 9198
	private GroupBox 34;

	// Token: 0x040023EF RID: 9199
	private CheckBox 35;

	// Token: 0x040023F0 RID: 9200
	private Panel 36;

	// Token: 0x040023F1 RID: 9201
	private ToolStrip 37;

	// Token: 0x040023F2 RID: 9202
	private ToolStripButton 38;

	// Token: 0x040023F3 RID: 9203
	private ToolStripButton 39;

	// Token: 0x040023F4 RID: 9204
	private 1473 40;

	// Token: 0x040023F5 RID: 9205
	private ColumnHeader 41;

	// Token: 0x040023F6 RID: 9206
	private ColumnHeader 42;

	// Token: 0x040023F7 RID: 9207
	private ColumnHeader 43;

	// Token: 0x040023F8 RID: 9208
	private ColumnHeader 44;

	// Token: 0x040023F9 RID: 9209
	private ColumnHeader 45;

	// Token: 0x040023FA RID: 9210
	private ImageList 46;

	// Token: 0x040023FB RID: 9211
	private GroupBox 47;

	// Token: 0x040023FC RID: 9212
	private GroupBox 48;

	// Token: 0x040023FD RID: 9213
	private Button 49;

	// Token: 0x040023FE RID: 9214
	private Label 50;

	// Token: 0x040023FF RID: 9215
	private Label 51;

	// Token: 0x04002400 RID: 9216
	private Label 52;

	// Token: 0x04002401 RID: 9217
	private NumericUpDown 53;

	// Token: 0x04002402 RID: 9218
	private RadioButton 54;

	// Token: 0x04002403 RID: 9219
	private RadioButton 55;

	// Token: 0x04002404 RID: 9220
	private RadioButton 56;

	// Token: 0x04002405 RID: 9221
	private GroupBox 57;

	// Token: 0x04002406 RID: 9222
	private GroupBox 58;

	// Token: 0x04002407 RID: 9223
	private Button 59;

	// Token: 0x04002408 RID: 9224
	private Label 60;

	// Token: 0x04002409 RID: 9225
	private NumericUpDown 61;

	// Token: 0x0400240A RID: 9226
	private RadioButton 62;

	// Token: 0x0400240B RID: 9227
	private RadioButton 63;

	// Token: 0x0400240C RID: 9228
	private RadioButton 64;

	// Token: 0x0400240D RID: 9229
	private RadioButton 65;

	// Token: 0x0400240E RID: 9230
	private Label 66;

	// Token: 0x0400240F RID: 9231
	private ColumnHeader 67;

	// Token: 0x04002410 RID: 9232
	private TabPage 68;

	// Token: 0x04002411 RID: 9233
	private GroupBox 69;

	// Token: 0x04002412 RID: 9234
	private NumericUpDown 70;

	// Token: 0x04002413 RID: 9235
	private Button 71;

	// Token: 0x04002414 RID: 9236
	private Label 72;

	// Token: 0x04002415 RID: 9237
	private GroupBox 73;

	// Token: 0x04002416 RID: 9238
	private Label 74;

	// Token: 0x04002417 RID: 9239
	private NumericUpDown 75;

	// Token: 0x04002418 RID: 9240
	private RadioButton 76;

	// Token: 0x04002419 RID: 9241
	private RadioButton 77;

	// Token: 0x0400241A RID: 9242
	private RadioButton 78;

	// Token: 0x0400241B RID: 9243
	private GroupBox 79;

	// Token: 0x0400241C RID: 9244
	private NumericUpDown 80;

	// Token: 0x0400241D RID: 9245
	private RadioButton 81;

	// Token: 0x0400241E RID: 9246
	private RadioButton 82;

	// Token: 0x0400241F RID: 9247
	private RadioButton 83;

	// Token: 0x04002420 RID: 9248
	private RadioButton 84;

	// Token: 0x04002421 RID: 9249
	private GroupBox 85;

	// Token: 0x04002422 RID: 9250
	private Button 86;

	// Token: 0x04002423 RID: 9251
	private Button 87;

	// Token: 0x04002424 RID: 9252
	private Button 88;

	// Token: 0x04002425 RID: 9253
	private Button 89;

	// Token: 0x04002426 RID: 9254
	private RadioButton 90;

	// Token: 0x04002427 RID: 9255
	private RadioButton 91;

	// Token: 0x04002428 RID: 9256
	private GroupBox 92;

	// Token: 0x04002429 RID: 9257
	private Label 93;

	// Token: 0x0400242A RID: 9258
	private NumericUpDown 94;

	// Token: 0x0400242B RID: 9259
	private TrackBar 95;

	// Token: 0x0400242C RID: 9260
	private LinkLabel 96;

	// Token: 0x0400242D RID: 9261
	private ListBox 97;

	// Token: 0x0400242E RID: 9262
	private GroupBox 98;

	// Token: 0x0400242F RID: 9263
	private Label 99;

	// Token: 0x04002430 RID: 9264
	private CheckBox 100;

	// Token: 0x04002431 RID: 9265
	private CheckBox 101;

	// Token: 0x04002432 RID: 9266
	private CheckBox 102;

	// Token: 0x04002433 RID: 9267
	private CheckBox 103;

	// Token: 0x04002434 RID: 9268
	private DomainUpDown 104;

	// Token: 0x04002435 RID: 9269
	private Label 105;

	// Token: 0x04002436 RID: 9270
	private NumericUpDown 106;

	// Token: 0x04002437 RID: 9271
	private NumericUpDown 107;

	// Token: 0x04002438 RID: 9272
	private NumericUpDown 108;

	// Token: 0x04002439 RID: 9273
	private ContextMenuStrip 109;

	// Token: 0x0400243A RID: 9274
	private ToolStripMenuItem 110;

	// Token: 0x0400243B RID: 9275
	private ToolStripMenuItem 111;

	// Token: 0x0400243C RID: 9276
	private ToolStripMenuItem 112;

	// Token: 0x0400243D RID: 9277
	private ToolStripMenuItem 113;

	// Token: 0x0400243E RID: 9278
	private ToolStripSeparator 114;

	// Token: 0x0400243F RID: 9279
	private ToolStripMenuItem 115;

	// Token: 0x04002440 RID: 9280
	private ToolStripMenuItem 116;

	// Token: 0x04002441 RID: 9281
	private ToolStripSeparator 117;

	// Token: 0x04002442 RID: 9282
	private CheckBox 118;

	// Token: 0x04002443 RID: 9283
	private Panel 119;

	// Token: 0x04002444 RID: 9284
	private Panel 120;

	// Token: 0x04002445 RID: 9285
	private Panel 121;

	// Token: 0x04002446 RID: 9286
	private Label 122;

	// Token: 0x04002447 RID: 9287
	private NumericUpDown 123;

	// Token: 0x04002448 RID: 9288
	private RadioButton 124;

	// Token: 0x04002449 RID: 9289
	private CheckBox 125;

	// Token: 0x02000646 RID: 1606
	[Serializable]
	public sealed class 2324
	{
		// Token: 0x0600313D RID: 12605 RVA: 0x00126D5C File Offset: 0x00124F5C
		internal bool 1(1259 1)
		{
			return 1.1();
		}

		// Token: 0x0400244A RID: 9290
		public static readonly 2322.2324 instance = new 2322.2324();

		// Token: 0x0400244B RID: 9291
		public static Predicate<1259> cachedIsTimingChange;
	}

	// Token: 0x02000647 RID: 1607
	public sealed class 2323
	{
		// Token: 0x06003140 RID: 12608 RVA: 0x00126D70 File Offset: 0x00124F70
		internal bool 1(1259 1)
		{
			return 1.1() && 1.3 > this.1.3;
		}

		// Token: 0x06003141 RID: 12609 RVA: 0x00126D8F File Offset: 0x00124F8F
		internal bool 2(1259 1)
		{
			return !1.Equals(this.2);
		}

		// Token: 0x06003142 RID: 12610 RVA: 0x00126DA0 File Offset: 0x00124FA0
		internal bool 3(1259 1)
		{
			return this.3 == null || !1.Equals(this.3);
		}

		// Token: 0x0400244C RID: 9292
		public 1259 1;

		// Token: 0x0400244D RID: 9293
		public 1259 2;

		// Token: 0x0400244E RID: 9294
		public 1259 3;
	}
}
