using System;
using System.Collections.Generic;
using System.Windows.Forms;

// Token: 0x020005B3 RID: 1459
public sealed class 2345 : 2255
{
	// Token: 0x06002D2F RID: 11567 RVA: 0x000FCA01 File Offset: 0x000FAC01
	internal override void CutSelection()
	{
		if (this.115)
		{
			if (this.104.Count != 0)
			{
				this.CopySelection();
				this.DeleteSelection();
				return;
			}
		}
		else
		{
			base.CutSelection();
		}
	}

	// Token: 0x06002D30 RID: 11568 RVA: 0x000FCA2C File Offset: 0x000FAC2C
	internal override void Paste()
	{
		if (!this.6.16)
		{
			this.6.20(false, false);
		}
		if (this.115)
		{
			if (this.105.Count == 0)
			{
				return;
			}
			this.6.15((2452)2, (2451)8, null);
			this.ClearSelection();
			int num = (1226.75() ? this.3.76.27((double)1226.16) : 1226.16) - this.105[0].8;
			using (List<2654>.Enumerator enumerator = this.105.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					2654 <<EMPTY_NAME>> = enumerator.Current;
					2654 2 = (2654)<<EMPTY_NAME>>.Clone();
					2.8 += num;
					2.1 += num;
					int num2 = this.3.76.26((double)2.8);
					int num3 = this.3.76.26((double)2.1);
					if (Math.Abs(num2 - 2.8) == 1)
					{
						2.8 = num2;
					}
					if (Math.Abs(num3 - 2.1) == 1)
					{
						2.1 = num3;
					}
					this.111(2);
					this.3.6.9(2);
					this.6.23(2, false);
				}
				goto IL_2E6;
			}
		}
		if (this.20.Count == 0)
		{
			return;
		}
		this.6.19((2452)0, null);
		this.6.13((2451)8, (2450)0);
		this.ClearSelection();
		this.20.Sort(new Comparison<2034>(2345.2347.Instance.2));
		int num4 = (1226.75() ? this.3.76.27((double)1226.16) : 1226.16) - this.20[0].1;
		foreach (2034 3 in this.20)
		{
			2034 4 = 3.Clone();
			4.1 += num4;
			4.2 += num4;
			int num5 = this.3.76.26((double)4.1);
			int num6 = this.3.76.26((double)4.2);
			if (Math.Abs(num5 - 4.1) == 1)
			{
				4.1 = num5;
			}
			if (Math.Abs(num6 - 4.2) == 1)
			{
				4.2 = num6;
			}
			4.4(false);
			this.90(4);
			this.6.23(4, false);
		}
		this.4.2(true);
		IL_2E6:
		this.6.20(false, false);
	}

	// Token: 0x06002D31 RID: 11569 RVA: 0x000FCD48 File Offset: 0x000FAF48
	internal override void CopySelection()
	{
		string text = string.Empty;
		int num = 1226.16;
		if (this.115)
		{
			this.105.Clear();
			this.104.Sort();
			if (this.104.Count > 0)
			{
				foreach (2654 <<EMPTY_NAME>> in this.104)
				{
					this.105.Add((2654)<<EMPTY_NAME>>.Clone());
					text = text + <<EMPTY_NAME>>.ToString() + "\n";
				}
				text.Remove(text.Length - 1);
			}
		}
		else
		{
			base.22();
			this.44.Sort();
			if (this.44.Count > 0)
			{
				if (2255.54[2357.NoteLock])
				{
					if (this.44.Count == 1)
					{
						this.72 = this.44[0];
					}
					if (this.100 != null)
					{
						this.72 = this.100;
					}
				}
				text = " (";
				foreach (2034 2 in this.44)
				{
					this.20.Add(2.Clone());
					text += string.Format("{0}|{1},", 2.1, this.91.49(2.8, false));
				}
				text = text.Trim(new char[]
				{
					','
				}) + ")";
				num = this.44[0].1;
			}
		}
		if (!this.115 || (this.115 && this.105.Count == 0))
		{
			text = string.Format("{0:00}:{1:00}:{2:000}", num / 60000, num % 60000 / 1000, num % 1000) + text + " - ";
		}
		try
		{
			Clipboard.SetText(text);
		}
		catch (Exception)
		{
			1763.4(1568.1(2679.General_Editor_ClipboardNotAvailable));
		}
	}

	// Token: 0x06002D32 RID: 11570 RVA: 0x000FCFB0 File Offset: 0x000FB1B0
	public 2345(2263 1) : base(1)
	{
	}

	// Token: 0x06002D33 RID: 11571 RVA: 0x0000FF75 File Offset: 0x0000E175
	internal override bool HasGrid()
	{
		return false;
	}

	// Token: 0x06002D34 RID: 11572 RVA: 0x000FD02A File Offset: 0x000FB22A
	internal override bool IsInputEnabled()
	{
		return base.IsInputEnabled();
	}

	// Token: 0x06002D35 RID: 11573 RVA: 0x000FD032 File Offset: 0x000FB232
	internal override void SetInputEnabled(bool 1)
	{
		base.SetInputEnabled(1);
		this.93.22 = 1;
	}

	// Token: 0x06002D36 RID: 11574 RVA: 0x000FD047 File Offset: 0x000FB247
	protected override bool IsToolAvailable(2255.2257 1)
	{
		return 1 <= (2255.2257)1 || 1 == (2255.2257)4;
	}

	// Token: 0x06002D37 RID: 11575 RVA: 0x000FD054 File Offset: 0x000FB254
	private float 83()
	{
		float num = (float)(1662.70.1() - this.79) - 70f;
		return Math.Min(30f, num / (float)this.84);
	}

	// Token: 0x06002D38 RID: 11576 RVA: 0x000FD08D File Offset: 0x000FB28D
	private float 84()
	{
		return this.83() / 30f;
	}

	// Token: 0x06002D39 RID: 11577 RVA: 0x0000FF75 File Offset: 0x0000E175
	internal override bool IsEditingSliderPath()
	{
		return false;
	}

	// Token: 0x06002D3A RID: 11578 RVA: 0x0000FF75 File Offset: 0x0000E175
	protected override bool SupportsDistanceSpacing()
	{
		return false;
	}

	// Token: 0x06002D3B RID: 11579 RVA: 0x000FD09C File Offset: 0x000FB29C
	internal override void Initialize()
	{
		this.84 = (int)Math.Round((double)1272.5().2);
		this.80 = (float)this.79 + this.83() * (float)this.84;
		this.83 = this.82 - this.81;
		this.91 = (this.4.41 = new 2011(2630.17(this.84, 2023.None), true, 0f, 480f, float.NaN, 1f, 0, 0));
		this.92 = new 1436(true);
		this.93 = new 1436(true);
		this.94 = new 1436(true);
		base.22();
		this.20 = new List<2034>();
		this.105 = new List<2654>();
		this.104 = new List<2654>();
		this.106 = new 2033[this.84];
		base.Initialize();
	}

	// Token: 0x06002D3C RID: 11580 RVA: 0x000FD190 File Offset: 0x000FB390
	protected override void CreateInterface()
	{
		this.5.15(true);
		base.CreateInterface();
		1433 <<EMPTY_NAME>> = new 1433(1662.34, (1376)6, 1065.TopLeft, (1044)0, new 208((float)(this.79 - 1), (float)this.81), 0.9f, true, 198.Black, null);
		<<EMPTY_NAME>>.20 = new 208((float)this.84 * this.83() + 1f, (float)this.83) * 1.6f;
		this.5.12(<<EMPTY_NAME>>);
		this.89 = new 1433(1662.34, (1376)6, 1065.TopLeft, (1044)0, new 208((float)this.78, (float)this.81), 0.9f, true, 198.Black, null);
		this.89.20 = new 208(60f, (float)this.83) * 1.6f;
		this.89.16 = 0.95f;
		this.89.10 = true;
		this.5.12(this.89);
		this.90 = new 1433(1662.34, (1376)6, 1065.BottomLeft, (1044)0, new 208((float)(this.78 - 2), (float)this.82), 0.901f, true, 198.White, null);
		this.90.20 = new 208(62f, 0f) * 1.6f;
		this.90.16 = 0.5f;
		this.5.12(this.90);
		for (int i = 0; i <= this.84; i++)
		{
			<<EMPTY_NAME>> = new 1433(1662.34, (1376)6, 1065.TopLeft, (1044)0, new 208((float)this.79 + this.83() * (float)i, (float)this.81), 0.91f, true, 198.White, null);
			<<EMPTY_NAME>>.20 = new 208(1f, (float)this.83) * 1.6f;
			if (i > 0 && i < this.84)
			{
				<<EMPTY_NAME>>.8 = "vertical";
			}
			this.5.12(<<EMPTY_NAME>>);
		}
		<<EMPTY_NAME>> = new 1433(1662.34, (1376)6, 1065.TopLeft, (1044)0, new 208((float)this.78, (float)this.81), 0.91f, true, 198.White, null);
		<<EMPTY_NAME>>.20 = new 208(1f, (float)this.83) * 1.6f;
		this.5.12(<<EMPTY_NAME>>);
		<<EMPTY_NAME>> = new 1433(1662.34, (1376)6, 1065.TopLeft, (1044)0, new 208((float)(this.78 + 60), (float)this.81), 0.91f, true, 198.White, null);
		<<EMPTY_NAME>>.20 = new 208(1f, (float)this.83) * 1.6f;
		this.5.12(<<EMPTY_NAME>>);
		<<EMPTY_NAME>> = new 1433(1662.34, (1376)6, 1065.TopLeft, (1044)0, new 208((float)this.79, (float)(this.82 - (this.82 - this.81) / 5)), 0.96f, true, 198.GreenYellow, null);
		<<EMPTY_NAME>>.20 = new 208((float)this.84 * this.83(), 4f) * 1.6f;
		this.5.12(<<EMPTY_NAME>>);
		this.88 = new 1452(string.Empty, 13f, new 208(200f, 20f), 1f, true, 198.White);
		this.88.41 = (1376)8;
		this.88.49 = 1065.TopRight;
		this.94.12(this.88);
		this.87 = new 1433(1455.2("mania-note1", (1416)1, null), (1376)6, 1065.BottomCentre, (1044)0, new 208(0f, 0f), 0.95f, true, 198.White, null);
		this.87.9(true);
		this.87.20.X = this.84();
		this.87.15 = 0.1875f;
		this.94.12(this.87);
		if (this.74 != null)
		{
			this.OnReferenceBeatmapChanged();
		}
	}

	// Token: 0x06002D3D RID: 11581 RVA: 0x000FD5B4 File Offset: 0x000FB7B4
	internal override void OnReferenceBeatmapChanged()
	{
		this.5.28.RemoveAll(new Predicate<1371>(2345.2347.Instance.1));
		if (this.74 != null)
		{
			int num = (int)Math.Round((double)this.74.21.2);
			float num2 = (float)this.79 + this.83() * (float)this.84 + this.83();
			1433 <<EMPTY_NAME>> = new 1433(1662.34, (1376)6, 1065.TopLeft, (1044)0, new 208(num2, (float)this.81), 0.9f, true, new 198(50, 50, 50), null);
			<<EMPTY_NAME>>.20 = new 208((float)num * this.83() + 1f, (float)this.83) * 1.6f;
			<<EMPTY_NAME>>.9 = -10086;
			this.5.12(<<EMPTY_NAME>>);
			for (int i = 0; i <= num; i++)
			{
				<<EMPTY_NAME>> = new 1433(1662.34, (1376)6, 1065.TopLeft, (1044)0, new 208(num2 + this.83() * (float)i, (float)this.81), 0.91f, true, 198.White, null);
				<<EMPTY_NAME>>.20 = new 208(1f, (float)this.83) * 1.6f;
				<<EMPTY_NAME>>.9 = -10086;
				this.5.12(<<EMPTY_NAME>>);
			}
		}
	}

	// Token: 0x06002D3E RID: 11582 RVA: 0x000FD707 File Offset: 0x000FB907
	internal override void Dispose()
	{
		this.87.Dispose();
		this.92.Dispose();
		this.93.Dispose();
		this.94.Dispose();
		base.Dispose();
	}

	// Token: 0x06002D3F RID: 11583 RVA: 0x000FD73C File Offset: 0x000FB93C
	internal override void Update()
	{
		this.91.21();
		this.86 = new 208(1535.6.X, 1535.6.Y) / 1662.70.3();
		this.113();
		this.111 = this.102();
		if (this.111)
		{
			if (this.115)
			{
				this.108 = this.101();
			}
			else
			{
				this.33 = this.100();
			}
		}
		else
		{
			this.33 = null;
			this.108 = null;
		}
		if (!this.115)
		{
			this.109 = this.97();
		}
		else
		{
			this.109 = -1;
		}
		if (this.21 != (2255.2257)0 && this.111)
		{
			this.87.9(false);
			this.87.17 = this.86;
		}
		else
		{
			this.87.9(true);
		}
		if (this.99 != null)
		{
			int num = this.115(this.86.Y);
			if (num > this.99.1)
			{
				this.99.2 = num;
			}
			else
			{
				this.99.1 = num;
			}
		}
		if (this.3.10)
		{
			this.86();
		}
		if (1226.75())
		{
			int num2 = (int)(1226.64() / 1226.76());
			int num3 = (int)1226.84();
			this.113 = num2 % num3;
			this.114 = num2 / num3;
		}
		this.89();
		this.4.74();
		if (this.47)
		{
			if (this.115)
			{
				this.104.Sort();
			}
			else
			{
				this.44.Sort();
			}
			this.110();
			this.47 = false;
		}
		this.112 = this.89.IsHovered();
		this.110 = this.109;
		this.85 = this.86;
	}

	// Token: 0x06002D40 RID: 11584 RVA: 0x000FD918 File Offset: 0x000FBB18
	internal override void Draw()
	{
		this.5.22();
		this.92.22();
		this.93.22();
		this.94.22();
		if (this.27 && this.3.59 == (2329)2)
		{
			198 <<EMPTY_NAME>> = new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue, 180);
			208 2 = new 208(this.26.X, this.25.Y);
			208 3 = new 208(this.25.X, this.26.Y);
			1662.20.2();
			1662.20.3(this.25, <<EMPTY_NAME>>);
			1662.20.3(2, <<EMPTY_NAME>>);
			1662.20.3(2, <<EMPTY_NAME>>);
			1662.20.3(this.26, <<EMPTY_NAME>>);
			1662.20.3(this.26, <<EMPTY_NAME>>);
			1662.20.3(3, <<EMPTY_NAME>>);
			1662.20.3(3, <<EMPTY_NAME>>);
			1662.20.3(this.25, <<EMPTY_NAME>>);
			1662.20.4();
			1662.13.1();
			1662.13.2(this.25, this.26, this.13);
			1662.13.3();
		}
		if (1226.75())
		{
			this.88.SetText(string.Format("{0}:{1}", this.114, this.113));
		}
		else
		{
			this.88.SetText("-");
		}
		try
		{
			2648.1.15();
		}
		catch
		{
		}
	}

	// Token: 0x06002D41 RID: 11585 RVA: 0x000FDAE4 File Offset: 0x000FBCE4
	internal override void Activate()
	{
		if (this.84 != (int)Math.Round((double)1272.5().2))
		{
			this.6.20(false, false);
			this.6.18 = true;
			this.Initialize();
			this.6.18 = false;
		}
		base.Activate();
	}

	// Token: 0x06002D42 RID: 11586 RVA: 0x000FDB3B File Offset: 0x000FBD3B
	internal override void Deactivate()
	{
		base.Deactivate();
	}

	// Token: 0x06002D43 RID: 11587 RVA: 0x000FDB43 File Offset: 0x000FBD43
	private string 85(string 1)
	{
		if (1.LastIndexOf(".") > 0)
		{
			return 1.Substring(0, 1.LastIndexOf("."));
		}
		return 1;
	}

	// Token: 0x06002D44 RID: 11588 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal override void OnBeatmapLoaded()
	{
	}

	// Token: 0x06002D45 RID: 11589 RVA: 0x000FDB68 File Offset: 0x000FBD68
	private void 86()
	{
		if (this.27)
		{
			this.108();
			return;
		}
		if (2255.54[2357.NoteLock] || !this.35)
		{
			return;
		}
		base.58(this.115(this.86.Y), this.97, this.98);
		this.113();
		if (this.99 != null)
		{
			return;
		}
		int num = this.115(this.86.Y) - this.102;
		this.77 += num;
		int num2 = (int)(this.3.60 * Math.Round((double)this.77 / this.3.60));
		if (num2 != 0)
		{
			this.77 -= num2;
		}
		bool flag = true;
		if (this.115)
		{
			if (1549.3)
			{
				num2 = num;
			}
			num2 = this.87(num2);
			if (!flag)
			{
				goto IL_2DC;
			}
			using (List<2654>.Enumerator enumerator = this.104.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					2654 <<EMPTY_NAME>> = enumerator.Current;
					<<EMPTY_NAME>>.8 += num2;
				}
				goto IL_2DC;
			}
		}
		int num3;
		int num4;
		this.103(out num3, out num4);
		int num5 = 0;
		if (this.109 != -1 && this.110 != -1)
		{
			num5 = this.109 - this.110;
		}
		else if (this.86.X < (float)this.79)
		{
			num5 = num3 * -1;
		}
		else if (this.86.X > this.80)
		{
			num5 = this.91.19.Count - num4 - 1;
		}
		bool flag2 = num3 + num5 >= 0 && this.86.X < this.80;
		bool flag3 = num4 + num5 <= this.91.19.Count - 1 && this.86.X > (float)this.79;
		if (this.44.Count > 0)
		{
			num = this.87(num);
			foreach (2034 2 in this.44)
			{
				if (flag)
				{
					2.1 += num;
					2.2 += num;
				}
				if ((flag2 && num5 < 0) || (flag3 && num5 > 0))
				{
					int num6 = this.91.49(2.8, false);
					num6 += num5;
					num6 = Math.Min(this.84, Math.Max(0, num6));
					2.8.X = (2.18.X = (float)this.91.19[num6].7());
				}
			}
		}
		if (num5 != 0)
		{
			this.101 = this.86.X;
		}
		IL_2DC:
		if (num != 0)
		{
			this.102 = this.115(this.86.Y);
		}
	}

	// Token: 0x06002D46 RID: 11590 RVA: 0x000FDE88 File Offset: 0x000FC088
	private int 87(int 1)
	{
		int num = this.115(this.86.Y);
		int num2 = this.88(1);
		bool flag = false;
		int num3 = this.103;
		if (num3 != -1)
		{
			if (num3 != 0)
			{
				flag = (num > this.103);
				if (flag)
				{
					num2 = 0;
				}
			}
			else
			{
				flag = (num < this.103);
				if (flag)
				{
					num2 = 0;
				}
			}
		}
		else if (1 != num2)
		{
			if (1 < 0 && num < 0)
			{
				this.103 = 0;
				flag = true;
			}
			else if (1 > 0 && num > 1226.9())
			{
				this.103 = 1226.9();
				flag = true;
			}
		}
		if (flag)
		{
			this.102 = this.103;
		}
		else
		{
			this.103 = -1;
		}
		return num2;
	}

	// Token: 0x06002D47 RID: 11591 RVA: 0x000FDF2C File Offset: 0x000FC12C
	private int 88(int 1)
	{
		int num;
		if (this.115)
		{
			if (this.104.Count == 0)
			{
				return 0;
			}
			num = this.104[0].8;
		}
		else
		{
			if (this.44.Count == 0)
			{
				return 0;
			}
			num = this.44[0].1;
		}
		if (1 < 0)
		{
			if (num + 1 < 0)
			{
				double num2;
				for (num2 = (double)this.3.76.27(0.0); num2 < 0.0; num2 += this.3.60)
				{
				}
				1 = (((double)num >= num2) ? ((num - (int)num2) * -1) : 0);
			}
		}
		else if (1 > 0)
		{
			double num3;
			for (num3 = (double)this.3.76.27((double)1226.9()); num3 > (double)1226.9(); num3 -= this.3.60)
			{
			}
			for (int i = Math.Min(this.115 ? this.104.Count : this.44.Count, 70) - 1; i >= 0; i--)
			{
				int num4 = (!this.115) ? this.44[i].2 : this.104[i].1;
				int num5 = (int)(num3 - (double)num4);
				if (num5 <= 1)
				{
					if (num5 < 0)
					{
						1 = 0;
						break;
					}
					1 = num5;
				}
			}
		}
		return 1;
	}

	// Token: 0x06002D48 RID: 11592 RVA: 0x000FE09C File Offset: 0x000FC29C
	internal override void HandleDragEnd()
	{
		if (this.99 == null)
		{
			this.27 = false;
			if (this.115)
			{
				this.104.Sort();
			}
			else
			{
				this.44.Sort();
			}
			if (this.35)
			{
				this.91();
			}
			this.103 = -1;
			this.6.20(false, false);
			this.36 = false;
			this.35 = false;
			this.3.59 = (2329)0;
		}
	}

	// Token: 0x06002D49 RID: 11593 RVA: 0x000FE114 File Offset: 0x000FC314
	internal override bool HandleDragStart()
	{
		if (this.99 != null || this.3.71)
		{
			return false;
		}
		int num = this.79 - 100;
		float num2 = this.80 + this.83();
		if (this.111 || (this.86.X >= (float)(this.79 - 20) && this.86.X <= num2 + 20f))
		{
			this.3.59 = (2329)2;
		}
		if (this.86.X >= (float)num && this.86.X <= num2 && this.86.Y > (float)this.81)
		{
			this.25 = (this.26 = 1535.6);
			this.102 = this.115(this.86.Y);
			this.101 = this.86.X;
			if (this.115)
			{
				if (this.108 != null)
				{
					if (this.104.Count > 0)
					{
						this.6.19((2452)2, null);
						this.6.13((2451)0, (2450)2304);
						this.6.24<2654>(this.104, false);
						this.36 = true;
					}
					this.35 = true;
					return true;
				}
			}
			else
			{
				this.35 = (this.33 != null || this.99 != null);
				if (this.33 != null)
				{
					this.6.19((2452)0, null);
					if (this.99 == null || !this.99.51)
					{
						if (this.44.Count <= 0)
						{
							return true;
						}
						this.6.19((2452)0, null);
						this.6.13((2451)0, (2450)2304);
						this.6.13((2451)1, (2450)256);
						this.6.21<2034>(this.44);
						this.36 = true;
					}
					this.35 = true;
					return true;
				}
			}
			this.27 = (this.21 == (2255.2257)0);
			return true;
		}
		return false;
	}

	// Token: 0x06002D4A RID: 11594 RVA: 0x000FE338 File Offset: 0x000FC538
	private void 89()
	{
		if (!this.3.31 || this.115 || 1226.32 != (1042)1)
		{
			return;
		}
		bool flag = false;
		for (int i = 0; i < this.91.19.Count; i++)
		{
			if (this.91.19[i].23() && !this.91.19[i].18)
			{
				2033 <<EMPTY_NAME>> = new 2033(this.4, new 208((float)this.91.19[i].7(), 192f), this.3.76.27((double)1226.16), false, false, false, false, 0);
				this.6.18((2452)0, (2451)8, <<EMPTY_NAME>>);
				this.90(<<EMPTY_NAME>>);
				this.106[i] = <<EMPTY_NAME>>;
				flag = true;
			}
			else if (!this.91.19[i].23() && this.91.19[i].18)
			{
				int num = this.3.76.27((double)1226.16);
				2033 2 = this.106[i];
				if (2 != null && num - 2.1 > 300)
				{
					this.6.18((2452)0, (2451)9, 2);
					this.4.29(2, false);
					2048 3 = new 2048(this.4, 2.8, 2.1, false, false, false, false, 0);
					3.2 = num;
					this.6.18((2452)0, (2451)8, 3);
					this.90(3);
					this.106[i] = null;
					flag = true;
				}
			}
		}
		if (flag)
		{
			this.4.2(true);
			this.6.20(false, false);
		}
	}

	// Token: 0x06002D4B RID: 11595 RVA: 0x000FE516 File Offset: 0x000FC716
	private void 90(2034 1)
	{
		this.4.AddCircleReplacingContainingObject(1);
	}

	// Token: 0x06002D4C RID: 11596 RVA: 0x000FE524 File Offset: 0x000FC724
	private void 91()
	{
		if (this.115)
		{
			if (this.104.Count == 0)
			{
				return;
			}
			int num = this.104[0].8 - this.3.76.27((double)this.104[0].8);
			foreach (2654 <<EMPTY_NAME>> in this.104)
			{
				<<EMPTY_NAME>>.8 = this.3.76.26((double)(<<EMPTY_NAME>>.8 - num));
			}
			this.3.6.15.Sort();
			return;
		}
		else
		{
			if (this.44.Count == 0)
			{
				return;
			}
			int num2 = this.44[0].1 - this.3.76.27((double)this.44[0].1);
			if (this.44.Count == 1)
			{
				2034 2 = this.44[0];
				2.1 = this.3.76.27((double)2.1);
				2.2 = this.3.76.27((double)2.2);
			}
			else
			{
				foreach (2034 3 in this.44)
				{
					3.1 = this.3.76.26((double)(3.1 - num2));
					3.2 = this.3.76.26((double)(3.2 - num2));
				}
			}
			this.4.2(true);
			return;
		}
	}

	// Token: 0x06002D4D RID: 11597 RVA: 0x000FE720 File Offset: 0x000FC920
	internal override void FlipHorizontally()
	{
		if (this.44.Count == 0)
		{
			return;
		}
		this.6.19((2452)0, null);
		this.6.13((2451)24, (2450)1);
		this.6.24<2034>(this.44, false);
		foreach (2034 <<EMPTY_NAME>> in this.44)
		{
			int num = this.91.49(<<EMPTY_NAME>>.8, false);
			num = this.84 - num - 1;
			<<EMPTY_NAME>>.8.X = (<<EMPTY_NAME>>.18.X = (float)this.91.19[num].7());
		}
		this.6.20(false, false);
	}

	// Token: 0x06002D4E RID: 11598 RVA: 0x000FE80C File Offset: 0x000FCA0C
	internal override void FlipVertically()
	{
		if (this.44.Count == 0)
		{
			return;
		}
		this.6.19((2452)0, null);
		this.6.13((2451)24, (2450)2);
		this.6.24<2034>(this.44, false);
		int num = int.MaxValue;
		int num2 = int.MinValue;
		foreach (2034 <<EMPTY_NAME>> in this.44)
		{
			if (<<EMPTY_NAME>>.1 < num)
			{
				num = <<EMPTY_NAME>>.1;
			}
			if (<<EMPTY_NAME>>.2 > num2)
			{
				num2 = <<EMPTY_NAME>>.2;
			}
		}
		foreach (2034 2 in this.44)
		{
			int num3 = num2 - (2.1 - num);
			int num4 = num2 - (2.2 - num);
			if (2.HasObjectType(2047.Hold))
			{
				2.1 = num4;
				2.2 = num3;
			}
			else
			{
				2.1 = num3;
				2.2 = num4;
			}
			int num5 = this.3.76.26((double)2.1);
			int num6 = this.3.76.26((double)2.2);
			if (Math.Abs(num5 - 2.1) == 1)
			{
				2.1 = num5;
			}
			if (Math.Abs(num6 - 2.2) == 1)
			{
				2.2 = num6;
			}
		}
		this.6.20(false, false);
	}

	// Token: 0x06002D4F RID: 11599 RVA: 0x000FE9D4 File Offset: 0x000FCBD4
	internal override void DeleteSelection()
	{
		if (this.115)
		{
			if (this.104.Count != 0)
			{
				this.6.17<2654>((2452)2, (2451)9, this.104);
				this.104.ForEach(delegate(2654 1)
				{
					this.3.6.12(1);
				});
				this.ClearSelection();
				this.6.20(false, false);
				return;
			}
		}
		else
		{
			base.DeleteSelection();
		}
	}

	// Token: 0x06002D50 RID: 11600 RVA: 0x000FEA3B File Offset: 0x000FCC3B
	private void 92(2654 1)
	{
		1.8 += (int)this.3.60;
	}

	// Token: 0x06002D51 RID: 11601 RVA: 0x000FEA56 File Offset: 0x000FCC56
	private void 93(2654 1)
	{
		1.8 -= (int)this.3.60;
	}

	// Token: 0x06002D52 RID: 11602 RVA: 0x000FEA71 File Offset: 0x000FCC71
	internal override bool HandleAltWheelUp()
	{
		if (!1549.1)
		{
			return false;
		}
		if (this.21 == (2255.2257)4)
		{
			base.63((2255.2257)1);
			return true;
		}
		return base.HandleAltWheelUp();
	}

	// Token: 0x06002D53 RID: 11603 RVA: 0x000FEA94 File Offset: 0x000FCC94
	internal override bool HandleAltWheelDown()
	{
		if (!1549.1)
		{
			return false;
		}
		2255.2257 <<EMPTY_NAME>> = this.21;
		if (<<EMPTY_NAME>> != (2255.2257)1)
		{
			return <<EMPTY_NAME>> == (2255.2257)4 || base.HandleAltWheelDown();
		}
		base.63((2255.2257)4);
		return true;
	}

	// Token: 0x06002D54 RID: 11604 RVA: 0x000FEACC File Offset: 0x000FCCCC
	internal override bool HandleKey(200 1, bool 2)
	{
		2345.2346 3 = new 2345.2346();
		3.1 = 1;
		3.2 = this;
		1548.9(3.1, 1531.Editor);
		if (this.3.31 && 1226.32 == (1042)1 && this.91.19.Find(new Predicate<1995>(3.1)) != null)
		{
			return true;
		}
		if (1549.1 && 2)
		{
			if (this.115)
			{
				if (this.104.Count > 0)
				{
					200 4 = 3.1;
					if (4 == 200.Up)
					{
						this.94(true);
						return true;
					}
					if (4 == 200.Down)
					{
						this.94(false);
						return true;
					}
				}
			}
			else if (this.44.Count > 0)
			{
				switch (3.1)
				{
				case 200.Left:
					this.95(-1, 0);
					return true;
				case 200.Up:
					this.95(0, 1);
					return true;
				case 200.Right:
					this.95(1, 0);
					return true;
				case 200.Down:
					this.95(0, -1);
					return true;
				}
			}
		}
		else if (3.1 == 200.Tab)
		{
			if (1549.2)
			{
				return false;
			}
			this.115 = !this.115;
			if (this.115)
			{
				this.33 = null;
			}
			else
			{
				this.108 = null;
			}
			this.5.28.ForEach(new Action<1371>(3.2));
			return true;
		}
		return base.HandleKey(3.1, 2);
	}

	// Token: 0x06002D55 RID: 11605 RVA: 0x000FEC40 File Offset: 0x000FCE40
	private void 94(bool 1)
	{
		if (this.104.Count != 0)
		{
			this.6.17<2654>((2452)2, (2451)0, this.104);
			if (1)
			{
				this.104.ForEach(new Action<2654>(this.92));
			}
			else
			{
				this.104.ForEach(new Action<2654>(this.93));
			}
			this.91();
			this.6.20(false, false);
		}
	}

	// Token: 0x06002D56 RID: 11606 RVA: 0x000FECB4 File Offset: 0x000FCEB4
	private void 95(int 1, int 2)
	{
		if (this.44.Count == 0)
		{
			return;
		}
		this.6.19((2452)0, new bool?(true));
		this.6.13((2451)1, (2450)256);
		this.6.13((2451)0, (2450)2304);
		this.6.24<2034>(this.44, false);
		foreach (2034 3 in this.44)
		{
			if (1 != 0)
			{
				int num = this.91.49(3.8, false);
				num += 1;
				num = Math.Min(this.84 - 1, Math.Max(0, num));
				3.8.X = (3.18.X = (float)this.91.19[num].7());
			}
			if (2 != 0)
			{
				double num2 = 1226.88((double)3.1, false) / (double)this.3.96();
				3.1 += (int)num2 * 2;
				3.2 += (int)num2 * 2;
			}
		}
		this.91();
		this.6.4(false);
		this.6.20(false, false);
	}

	// Token: 0x06002D57 RID: 11607 RVA: 0x000FEE1C File Offset: 0x000FD01C
	internal override bool HandleEscape()
	{
		if (!this.115)
		{
			return base.HandleEscape();
		}
		if (this.104.Count > 0)
		{
			this.ClearSelection();
			return false;
		}
		return true;
	}

	// Token: 0x06002D58 RID: 11608 RVA: 0x000FEE44 File Offset: 0x000FD044
	private float 96(int 1)
	{
		if (1 >= this.91.19.Count)
		{
			return -1f;
		}
		return (float)this.79 + ((float)(1 + 1) * this.83() - this.83() / 2f);
	}

	// Token: 0x06002D59 RID: 11609 RVA: 0x000FEE7F File Offset: 0x000FD07F
	private int 97()
	{
		return this.98(this.86.X);
	}

	// Token: 0x06002D5A RID: 11610 RVA: 0x000FEE94 File Offset: 0x000FD094
	private int 98(float 1)
	{
		float num = (float)this.79;
		if (1 >= num)
		{
			for (int i = 0; i < this.91.19.Count; i++)
			{
				num += this.83();
				if (1 <= num)
				{
					return i;
				}
			}
		}
		return -1;
	}

	// Token: 0x06002D5B RID: 11611 RVA: 0x000FEED8 File Offset: 0x000FD0D8
	private 1433 99()
	{
		for (int i = 0; i < this.93.28.Count; i++)
		{
			1433 <<EMPTY_NAME>> = this.93.28[i] as 1433;
			if (<<EMPTY_NAME>>.50.6(1535.6.X, 1535.6.Y) && <<EMPTY_NAME>>.8 != null)
			{
				return <<EMPTY_NAME>>;
			}
		}
		return null;
	}

	// Token: 0x06002D5C RID: 11612 RVA: 0x000FEF44 File Offset: 0x000FD144
	private 2034 100()
	{
		1433 <<EMPTY_NAME>> = this.99();
		if (<<EMPTY_NAME>> == null)
		{
			return null;
		}
		return <<EMPTY_NAME>>.8 as 2034;
	}

	// Token: 0x06002D5D RID: 11613 RVA: 0x000FEF68 File Offset: 0x000FD168
	private 2654 101()
	{
		1433 <<EMPTY_NAME>> = this.99();
		if (<<EMPTY_NAME>> == null || <<EMPTY_NAME>>.9 != -10010)
		{
			return null;
		}
		return <<EMPTY_NAME>>.8 as 2654;
	}

	// Token: 0x06002D5E RID: 11614 RVA: 0x000FEF9C File Offset: 0x000FD19C
	internal override bool HandleClick()
	{
		if (!this.IsInputEnabled())
		{
			return false;
		}
		bool flag = 1535.43 == 199.Pressed;
		if (this.74 != null && !this.111)
		{
			this.ClearSelection();
			if (this.33 != null)
			{
				if (this.100 != null)
				{
					this.100.4(false);
				}
				this.100 = this.33;
				this.100.4(true);
				return true;
			}
		}
		if (!flag)
		{
			if (2255.54[2357.NoteLock] && 1549.1 && 1549.3 && this.33 != null)
			{
				base.43(this.33);
				return true;
			}
			if (1549.2)
			{
				bool flag2 = false;
				if (this.115)
				{
					if (this.104.Count > 0)
					{
						flag2 = true;
					}
					else if (this.108 != null)
					{
						this.111(this.108);
						flag2 = true;
					}
				}
				else
				{
					if (this.44.Count > 0)
					{
						flag2 = true;
					}
					if (this.33 != null)
					{
						this.SelectObject(this.33);
						flag2 = true;
					}
				}
				if (flag2)
				{
					this.3.40();
				}
				return true;
			}
			if (this.115)
			{
				if (this.108 != null)
				{
					if (!this.108.15)
					{
						if (!1549.1)
						{
							this.ClearSelection();
						}
						this.111(this.108);
					}
					else if (this.108.15 && 1549.1 && this.104.Count > 1)
					{
						this.112(this.108);
						this.108.15 = false;
						this.104.Remove(this.108);
					}
				}
				else if (!this.3.71 && !this.112)
				{
					this.ClearSelection();
				}
				return true;
			}
			int index = (int)((this.86.X - (float)this.79) / this.83());
			switch (this.21)
			{
			case (2255.2257)0:
			{
				1433 <<EMPTY_NAME>> = this.99();
				if (<<EMPTY_NAME>> != null)
				{
					2034 2 = (2034)<<EMPTY_NAME>>.8;
					int 3 = <<EMPTY_NAME>>.9;
					if (1549.3)
					{
						if (2255.54[2357.NoteLock])
						{
							if (1549.1)
							{
								base.43(2);
							}
							return true;
						}
						if (2.HasObjectType(2047.Normal) && 3 == 2.1)
						{
							this.ClearSelection();
							this.6.18((2452)0, (2451)9, 2);
							this.4.29(2, false);
							2048 4 = new 2048(this.4, 2.8, 2.1, false, 2.4, 0)
							{
								2 = 2.1,
								35 = 2.35,
								36 = 2.36,
								37 = 2.37,
								33 = 2.33,
								32 = 2.32,
								34 = 2.34,
								51 = true
							};
							this.6.13((2451)8, (2450)0);
							this.6.23(4, false);
							this.90(4);
							this.99 = 4;
							this.6.20(false, false);
						}
					}
					if (!2.HasObjectType(2047.Normal) && 3 == 2.2)
					{
						this.ClearSelection();
						2048 5 = (2048)2;
						this.6.18((2452)0, (2451)7, 5);
						5.51 = true;
						this.99 = 5;
						return true;
					}
				}
				if (this.33 != null)
				{
					if (!this.33.3())
					{
						if (!1549.1)
						{
							this.ClearSelection();
						}
						this.SelectObject(this.33);
					}
					else if (this.33.3() && 1549.1 && this.44.Count > 1)
					{
						base.20(this.33);
					}
				}
				else if (!this.3.71 && !this.112)
				{
					this.ClearSelection();
				}
				return true;
			}
			case (2255.2257)1:
				if (this.111)
				{
					this.ClearSelection();
					int num = this.115(this.86.Y);
					num = this.3.76.27((double)num);
					2033 6 = new 2033(this.4, new 208((float)this.91.19[index].7(), 192f), num, false, false, false, false, 0);
					this.6.18((2452)0, (2451)8, 6);
					this.90(6);
					this.4.2(true);
					this.6.20(false, false);
				}
				return true;
			case (2255.2257)4:
				if (this.111)
				{
					this.ClearSelection();
					int num2 = this.115(this.86.Y);
					num2 = this.3.76.27((double)num2);
					2048 7 = new 2048(this.4, new 208((float)this.91.19[index].7(), 192f), num2, false, false, false, false, 0);
					7.51 = true;
					this.6.18((2452)0, (2451)8, 7);
					this.90(7);
					this.4.2(true);
					this.99 = 7;
					this.6.20(false, false);
				}
				return true;
			}
		}
		else
		{
			if (this.115)
			{
				if (this.108 != null)
				{
					if (this.108.15)
					{
						this.DeleteSelection();
					}
					else
					{
						this.6.18((2452)2, (2451)9, this.108);
						this.104.Remove(this.108);
						this.3.6.12(this.108);
						this.6.20(false, false);
					}
					this.108 = null;
				}
				return true;
			}
			if (this.33 != null)
			{
				if (this.33.3())
				{
					this.DeleteSelection();
				}
				else
				{
					this.6.18((2452)0, (2451)9, this.33);
					this.4.29(this.33, false);
					this.6.20(false, false);
				}
				this.33 = null;
				return true;
			}
		}
		return true;
	}

	// Token: 0x06002D5F RID: 11615 RVA: 0x000FF5CC File Offset: 0x000FD7CC
	private bool 102()
	{
		return this.86.X > (float)this.79 && this.86.X < this.80 && this.86.Y > (float)this.81 && this.86.Y < (float)this.82;
	}

	// Token: 0x06002D60 RID: 11616 RVA: 0x000FF62C File Offset: 0x000FD82C
	internal override bool HandleRelease()
	{
		if (this.99 != null)
		{
			this.99.51 = false;
			this.99.2 = this.3.76.27((double)this.99.2);
			this.99.1 = this.3.76.27((double)this.99.1);
			if (this.99.2 == this.99.1)
			{
				this.6.15((2452)0, (2451)9, null);
				this.6.23(this.99, false);
				this.4.29(this.99, false);
				2033 <<EMPTY_NAME>> = (2033)this.99.9();
				this.6.13((2451)8, (2450)0);
				this.6.23(<<EMPTY_NAME>>, false);
				this.4.AddCircleReplacingContainingObject(<<EMPTY_NAME>>);
			}
			this.99 = null;
			this.6.20(false, false);
		}
		return false;
	}

	// Token: 0x06002D61 RID: 11617 RVA: 0x000FF740 File Offset: 0x000FD940
	internal override bool HandleDoubleClick()
	{
		if (!this.IsInputEnabled())
		{
			return false;
		}
		if (this.115)
		{
			if (this.108 == null)
			{
				return false;
			}
			2654 <<EMPTY_NAME>> = this.108;
			if (1549.1)
			{
				2033 2 = new 2033(this.4, new 208((float)this.91.19[0].7(), 192f), this.3.76.27((double)<<EMPTY_NAME>>.8), false, false, false, false, 0)
				{
					33 = <<EMPTY_NAME>>.3,
					34 = <<EMPTY_NAME>>.12,
					32 = <<EMPTY_NAME>>.14
				};
				this.6.18((2452)0, (2451)8, 2);
				this.6.18((2452)2, (2451)9, <<EMPTY_NAME>>);
				this.90(2);
				this.4.2(true);
				this.3.6.12(<<EMPTY_NAME>>);
				this.6.20(false, false);
			}
			else
			{
				1226.28(<<EMPTY_NAME>>.3, 1f, (1416)7);
			}
			return true;
		}
		else
		{
			if (this.33 == null)
			{
				return false;
			}
			2034 3 = this.33;
			if (this.111)
			{
				if (1549.1 && !string.IsNullOrEmpty(3.33))
				{
					2654 4 = new 2654(3.32, 3.33, 3.1, 2645.Background, 3.34);
					if (4.12 == 0)
					{
						4.12 = 70;
					}
					this.6.18((2452)0, (2451)9, 3);
					this.6.18((2452)2, (2451)8, 4);
					this.3.6.9(4);
					this.4.29(3, true);
					this.6.20(false, false);
				}
				else
				{
					3.PlayHitSound();
				}
			}
			else
			{
				2034 5 = 3.Clone();
				5.4(false);
				this.6.18((2452)0, (2451)8, 5);
				this.90(5);
				this.6.20(false, false);
			}
			return true;
		}
	}

	// Token: 0x06002D62 RID: 11618 RVA: 0x000FF938 File Offset: 0x000FDB38
	private void 103(out int 1, out int 2)
	{
		1 = -1;
		2 = -1;
		foreach (2034 3 in this.44)
		{
			int num = this.91.49(3.8, false);
			if (1 == -1)
			{
				1 = num;
				2 = num;
			}
			else if (num <= 1)
			{
				1 = num;
			}
			else if (num >= 2)
			{
				2 = num;
			}
		}
	}

	// Token: 0x06002D63 RID: 11619 RVA: 0x000FF9BC File Offset: 0x000FDBBC
	private bool 104(2034 1, int 2, int 3)
	{
		int num = this.91.49(1.8, false);
		return num >= 2 && num <= 3;
	}

	// Token: 0x06002D64 RID: 11620 RVA: 0x000FF9E9 File Offset: 0x000FDBE9
	private bool 105(float 1, float 2)
	{
		return (1 > (float)this.79 || 2 > (float)this.79) && (1 < this.80 || 2 < this.80);
	}

	// Token: 0x06002D65 RID: 11621 RVA: 0x000FFA15 File Offset: 0x000FDC15
	private float 106(float 1)
	{
		return 1 * 1662.70.3();
	}

	// Token: 0x06002D66 RID: 11622 RVA: 0x000FFA23 File Offset: 0x000FDC23
	private 208 107(208 1)
	{
		return 1 / 1662.70.3();
	}

	// Token: 0x06002D67 RID: 11623 RVA: 0x000FFA38 File Offset: 0x000FDC38
	private void 108()
	{
		2345.2348 <<EMPTY_NAME>> = new 2345.2348();
		<<EMPTY_NAME>>.1 = this;
		this.26 = 1535.6;
		1058 2 = new 1058(Math.Min(this.25.X, this.26.X), Math.Min(this.25.Y, this.26.Y), Math.Abs(this.26.X - this.25.X), Math.Abs(this.26.Y - this.25.Y));
		208 3 = this.107(this.25);
		208 4 = this.107(this.26);
		if (3.X > (float)this.78 && 3.X < (float)(this.78 + 60) && 4.X > (float)this.78 && 4.X < (float)(this.78 + 60))
		{
			int val = (int)(((float)this.82 - 3.Y) / (float)this.83 * (float)1226.9());
			int num = (int)(((float)this.82 - 4.Y) / (float)this.83 * (float)1226.9());
			<<EMPTY_NAME>>.2 = Math.Min(val, num);
			<<EMPTY_NAME>>.3 = Math.Max(val, num);
			if (this.3.59 == (2329)2)
			{
				this.4.34.ForEach(new Action<2034>(<<EMPTY_NAME>>.1));
			}
			1226.4(num, false, false);
			return;
		}
		if (this.3.59 != (2329)2)
		{
			return;
		}
		int num2 = this.97;
		int num3 = this.115(this.86.Y);
		if ((num3 > this.98 && num3 < this.102) || (num3 < this.97 && num3 > this.102))
		{
			this.102 = num3;
		}
		bool flag = false;
		if (!this.115)
		{
			flag = base.58(num3, this.97, this.98);
			this.113();
		}
		if (num2 != this.97)
		{
			this.25.Y = this.106(1052.19(this.114(this.102), (float)this.81, (float)this.82));
		}
		this.26.Y = this.106(1052.19(4.Y, (float)this.81, (float)this.82));
		int val2 = this.115(this.86.Y);
		if (this.86.Y > (float)this.82)
		{
			val2 = this.97;
		}
		else if (this.86.Y < (float)this.81)
		{
			val2 = this.98;
		}
		float num4 = Math.Min(3.X, 4.X);
		float num5 = Math.Max(3.X, 4.X);
		if (!flag && this.85 == this.86)
		{
			return;
		}
		this.ClearSelection();
		if (!this.105(num4, num5))
		{
			return;
		}
		if (this.102 >= this.97 && this.102 <= this.98)
		{
			this.109(2);
			return;
		}
		num4 = Math.Max(num4, (float)this.79);
		num5 = Math.Min(num5, this.80);
		int num6 = Math.Min(this.102, val2);
		int num7 = Math.Max(this.102, val2);
		if (this.115)
		{
			float num8 = (float)this.79;
			int num9 = 0;
			while (num8 < num4)
			{
				num8 += this.107;
				num9++;
			}
			int num10 = num9;
			while (num8 < num5)
			{
				num8 += this.107;
				num10++;
			}
			num8 = (float)this.79 + this.107 * (float)num9 + this.107 / 2f;
			if (num4 > num8)
			{
				num9++;
			}
			num8 = (float)this.79 + this.107 * (float)num10 + this.107 / 2f;
			if (num5 < num8)
			{
				num10--;
			}
			if (num9 > num10 || num10 < 0)
			{
				return;
			}
			int i = this.4.32.15.BinarySearch(new 2654(num6));
			if (i < 0)
			{
				i = ~i;
			}
			int count = this.4.32.15.Count;
			if (i >= count)
			{
				return;
			}
			2654 5 = this.4.32.15[i];
			int 6 = 5.8;
			int num11 = 0;
			while (i < count)
			{
				5 = this.4.32.15[i];
				if (5.8 > num7)
				{
					break;
				}
				if (5.8 == 6)
				{
					if (num11 >= num9 && num11 <= num10)
					{
						this.111(5);
					}
					num11++;
				}
				else
				{
					num11 = 0;
					6 = 5.8;
				}
				i++;
			}
			return;
		}
		else
		{
			int num9 = this.98(num4);
			int num10 = this.98(num5);
			if (num4 > this.96(num9))
			{
				num9++;
			}
			if (num5 < this.96(num10))
			{
				num10--;
			}
			if (num9 > num10 || num9 == this.91.19.Count || num10 < 0)
			{
				return;
			}
			int i = this.4.34.BinarySearch(new 2071(this.4, num6));
			if (i < 0)
			{
				i = ~i;
			}
			if (i >= this.4.35)
			{
				return;
			}
			while (i < this.4.35)
			{
				2034 7 = this.4.34[i];
				if (7.1 > num7)
				{
					break;
				}
				if ((7.1 >= num6 || (7.2 >= num6 && 7.2 <= num7)) && this.104(7, num9, num10))
				{
					this.SelectObject(7);
				}
				i++;
			}
			return;
		}
	}

	// Token: 0x06002D68 RID: 11624 RVA: 0x00100034 File Offset: 0x000FE234
	private void 109(1058 1)
	{
		foreach (1371 2 in this.93.28)
		{
			1433 3 = (1433)2;
			if (3.8 != null && 1.10(3.50))
			{
				if (this.115)
				{
					this.111((2654)3.8);
				}
				else
				{
					this.SelectObject((2034)3.8);
				}
			}
		}
	}

	// Token: 0x06002D69 RID: 11625 RVA: 0x001000D0 File Offset: 0x000FE2D0
	internal void 110()
	{
		1254 <<EMPTY_NAME>> = 1254.None;
		1254 2 = 1254.None;
		bool flag3;
		bool flag2;
		bool flag;
		if (this.115 || this.44.Count == 0)
		{
			flag = (flag2 = (flag3 = false));
		}
		else
		{
			<<EMPTY_NAME>> = this.44[0].35;
			2 = this.44[0].36;
			flag2 = (flag = (flag3 = true));
			bool flag4 = true;
			bool flag5 = true;
			foreach (2034 3 in this.44)
			{
				if (flag4 && <<EMPTY_NAME>> != 3.35)
				{
					<<EMPTY_NAME>> = 1254.None;
					flag4 = false;
				}
				if (flag5 && 2 != 3.36)
				{
					2 = 1254.None;
					flag5 = false;
				}
				flag2 &= 3.HasWhistle();
				flag &= 3.HasFinish();
				flag3 &= 3.HasClap();
			}
		}
		base.31(2357.Whistle, flag2);
		base.31(2357.Finish, flag);
		base.31(2357.Clap, flag3);
		if (<<EMPTY_NAME>> != (1254)this.68.18)
		{
			this.68.18(<<EMPTY_NAME>>, true);
		}
		if (2 != (1254)this.69.18)
		{
			this.69.18(2, true);
		}
	}

	// Token: 0x06002D6A RID: 11626 RVA: 0x00100220 File Offset: 0x000FE420
	internal override void SelectObjects(2036[] 1)
	{
		base.SelectObjects(1);
	}

	// Token: 0x06002D6B RID: 11627 RVA: 0x0010022C File Offset: 0x000FE42C
	internal override void SelectObject(2034 1)
	{
		if (!this.44.Contains(1))
		{
			this.44.Add(1);
			1.4(true);
			this.70.SetText(1.33 + "\n");
			this.70.52 = 1.33;
			if (1.34 != 0)
			{
				1452 2 = this.70;
				string text = 2.GetText();
				int 3 = 1.34;
				2.SetText(text + 3.ToString() + "%");
			}
			this.47 = true;
		}
	}

	// Token: 0x06002D6C RID: 11628 RVA: 0x001002C4 File Offset: 0x000FE4C4
	internal void 111(2654 1)
	{
		if (!this.104.Contains(1))
		{
			this.104.Add(1);
			1.15 = true;
			this.70.SetText(this.85(1.3) + "\n");
			this.70.52 = this.85(1.3);
			if (1.12 != 0)
			{
				1452 2 = this.70;
				2.SetText(2.GetText() + 1.12.ToString() + "%");
			}
			this.47 = true;
		}
	}

	// Token: 0x06002D6D RID: 11629 RVA: 0x00100362 File Offset: 0x000FE562
	internal void 112(2654 1)
	{
		if (1.15)
		{
			1.15 = false;
			this.104.Remove(1);
			this.47 = true;
		}
	}

	// Token: 0x06002D6E RID: 11630 RVA: 0x00100388 File Offset: 0x000FE588
	internal override void SelectAll()
	{
		this.ClearSelection();
		if (this.115)
		{
			foreach (2654 <<EMPTY_NAME>> in this.3.6.15)
			{
				this.111(<<EMPTY_NAME>>);
			}
			return;
		}
		foreach (2034 2 in this.4.34)
		{
			this.SelectObject(2);
		}
	}

	// Token: 0x06002D6F RID: 11631 RVA: 0x0010043C File Offset: 0x000FE63C
	internal override void ClearSelection()
	{
		if (this.115)
		{
			if (this.104.Count == 0)
			{
				return;
			}
			for (int i = 0; i < this.104.Count; i++)
			{
				this.104[i].15 = false;
			}
			this.104.Clear();
			this.47 = true;
		}
		else
		{
			if (this.44.Count == 0)
			{
				return;
			}
			for (int j = 0; j < this.44.Count; j++)
			{
				this.44[j].4(false);
			}
			this.44.Clear();
			this.47 = true;
		}
		if (this.100 != null)
		{
			this.100.4(false);
		}
		this.100 = null;
		this.70.SetText(string.Empty);
		this.70.52 = string.Empty;
	}

	// Token: 0x06002D70 RID: 11632 RVA: 0x0010051E File Offset: 0x000FE71E
	private void 113()
	{
		this.97 = 1226.16 - this.3.61 / 12;
		this.98 = 1226.16 + this.3.61 / 3;
	}

	// Token: 0x06002D71 RID: 11633 RVA: 0x00005ADD File Offset: 0x00003CDD
	protected override void UpdateInfoText()
	{
	}

	// Token: 0x06002D72 RID: 11634 RVA: 0x00100553 File Offset: 0x000FE753
	protected override float MeasureDistance(208 1, 208 2)
	{
		return 0f;
	}

	// Token: 0x06002D73 RID: 11635 RVA: 0x0010055A File Offset: 0x000FE75A
	private float 114(int 1)
	{
		return (float)this.82 - (float)((1 - this.97) * this.83) / (float)(this.98 - this.97);
	}

	// Token: 0x06002D74 RID: 11636 RVA: 0x00100583 File Offset: 0x000FE783
	private int 115(float 1)
	{
		return (int)((float)(this.98 - this.97) * ((float)this.82 - 1) * 1f / (float)this.83 + (float)this.97);
	}

	// Token: 0x06002D75 RID: 11637 RVA: 0x001005B4 File Offset: 0x000FE7B4
	internal override void DrawTimelineOverlay()
	{
		this.113();
		this.95 = 1226.16;
		this.96 = this.3.98();
		this.93.15(true);
		this.118();
		if (this.115)
		{
			List<2654> <<EMPTY_NAME>> = this.3.6.15;
			this.116 = -1;
			for (int i = 0; i < <<EMPTY_NAME>>.Count; i++)
			{
				2654 2 = <<EMPTY_NAME>>[i];
				if (2.8 >= this.97 && 2.8 <= this.98)
				{
					this.116(2, 2.8);
				}
			}
		}
		else
		{
			int num = 100;
			int[] array = new int[num];
			int num2 = (int)Math.Ceiling((double)1226.9() / (double)num);
			for (int j = 0; j < this.4.34.Count; j++)
			{
				2034 3 = this.4.34[j];
				int num3 = 3.1 / num2;
				int num4 = 3.2 / num2;
				if (num3 >= 0 && num3 < num)
				{
					array[num3]++;
					if (num3 != num4)
					{
						while (++num3 <= num4 && num3 < num)
						{
							array[num3]++;
						}
					}
					if (3.2 >= this.97 && 3.1 <= this.98)
					{
						this.117(3, this.84, 0f, this.3.32);
					}
				}
			}
			double num5 = (double)(60000f / 1272.5().86().Z / 2f);
			int num6 = (int)((double)num2 / num5 * (double)this.84 * 0.6000000238418579);
			for (int k = 0; k < num; k++)
			{
				if (array[k] != 0)
				{
					198 4 = new 198(247, 236, 0);
					if (array[k] > num6)
					{
						4 = new 198(250, 170, 212);
					}
					1433 5 = new 1433(1662.34, (1376)6, 1065.BottomLeft, (1044)0, new 208((float)this.78, (float)this.82 - (float)this.83 / (float)num * (float)k), 0.93f, true, 4, null);
					5.20 = new 208(60f / (float)num6 * (float)Math.Min(num6, array[k]), (float)this.83 / (float)num - 1f) * 1.6f;
					this.93.12(5);
				}
			}
		}
		if (this.74 != null)
		{
			for (int l = 0; l < this.74.34.Count; l++)
			{
				2034 6 = this.74.34[l];
				if (6.2 >= this.97)
				{
					if (6.1 > this.98)
					{
						break;
					}
					this.117(6, (int)Math.Round((double)this.74.21.2), (float)this.84 * this.83() + this.83(), this.3.32);
				}
			}
		}
		float num7 = (float)this.82 - (float)this.97 / (float)1226.9() * (float)this.83;
		float num8 = (float)this.82 - (float)this.98 / (float)1226.9() * (float)this.83;
		this.90.17.Y = num7;
		this.90.20.Y = num7 - num8;
	}

	// Token: 0x06002D76 RID: 11638 RVA: 0x00100960 File Offset: 0x000FEB60
	private void 116(2654 1, int 2)
	{
		if (2 != this.116)
		{
			this.117 = (float)this.79;
		}
		else
		{
			this.117 += (float)this.84 * this.83() / 8f;
		}
		this.116 = 2;
		198 3 = 1.15 ? 198.LightSkyBlue : 198.Orange;
		1433 4 = new 1433(1455.2("mania-note1", (1416)1, null), (1376)6, 1065.BottomLeft, (1044)0, new 208(this.117, this.114(2)), 0.92f, true, 3, 1);
		4.9 = -10010;
		4.20 = new 208((float)this.84 / 8f * this.84(), 1f) * 0.1875f;
		this.93.12(4);
		this.107 = (float)this.84 * this.83() / 8f;
	}

	// Token: 0x06002D77 RID: 11639 RVA: 0x00100A50 File Offset: 0x000FEC50
	private void 117(2034 1, int 2, float 3, bool 4)
	{
		int num = 1.28.41.49(1.8, false);
		198 5 = 1.3() ? 198.LightSkyBlue : 1.28.41.19[num].9();
		if (1.1 == 1.2)
		{
			1433 6 = new 1433(1455.2("mania-note1", (1416)1, null), (1376)6, 1065.BottomLeft, (1044)0, new 208((float)this.79 + this.83() * (float)num + 3, this.114(1.1)), 0.92f, true, 5, 1);
			6.9 = 1.1;
			6.20.X = this.84();
			6.15 = 0.1875f;
			this.93.12(6);
		}
		else
		{
			1433 7;
			if (1.1 >= this.97 && 1.1 < this.98)
			{
				7 = new 1433(1455.2("mania-note1", (1416)1, null), (1376)6, 1065.BottomLeft, (1044)0, new 208((float)this.79 + this.83() * (float)num + 3, this.114(1.1)), 0.92f, true, 5, 1);
				7.9 = 1.1;
				7.20.X = this.84();
				7.15 = 0.1875f;
				this.93.12(7);
			}
			if (1.2 >= this.97 && 1.2 < this.98)
			{
				7 = new 1433(1455.2("mania-note1", (1416)1, null), (1376)6, 1065.BottomLeft, (1044)0, new 208((float)this.79 + this.83() * (float)num + 3, this.114(1.2)), 0.92f, true, 5, 1);
				7.9 = 1.2;
				7.20.X = this.84();
				7.15 = 0.1875f;
				this.93.12(7);
			}
			float num2 = Math.Min((float)this.82, this.114(1.1));
			float num3 = Math.Max((float)this.81, this.114(1.2));
			7 = new 1433(1455.5("mania-note1L", (1416)1, true)[0], (1376)6, 1065.BottomLeft, (1044)0, new 208((float)this.79 + this.83() * (float)num + 3, num2), 0.918f, true, 5, 1);
			7.9 = 1.1;
			7.20 = new 208(0.1875f * this.84(), (num2 - num3) / 82f * 1.6f);
			this.93.12(7);
		}
		if (!4 || 1.1 <= this.97 || 1.1 >= this.98)
		{
			return;
		}
		string text = string.Empty;
		if (!string.IsNullOrEmpty(1.33))
		{
			text = this.85(1.33);
		}
		else if (1.4 != 1245.None)
		{
			if (1.HasWhistle())
			{
				text += "W|";
			}
			if (1.HasFinish())
			{
				text += "F|";
			}
			if (1.HasClap())
			{
				text += "C";
			}
			if (text.EndsWith("|"))
			{
				text = text.Substring(0, text.Length - 1);
			}
		}
		if (text != string.Empty)
		{
			1452 8 = new 1452(text, 10f, new 208((float)this.79 + this.83() * (float)num + 3, this.114(1.1) - 10f), 0.93f, true, 198.White);
			this.93.12(8);
		}
	}

	// Token: 0x06002D78 RID: 11640 RVA: 0x00100E0C File Offset: 0x000FF00C
	internal void 118()
	{
		double num = 1226.88((double)1226.16, false) / (double)this.3.96();
		int num2;
		double num3;
		if (1226.75())
		{
			num2 = (int)(((double)this.97 - 1226.79()) / 1226.76());
			num3 = (double)num2 * 1226.76() + 1226.79();
		}
		else
		{
			num3 = (double)this.97 / num + num;
			num2 = 0;
		}
		int num4 = (int)1226.84();
		this.92.15(true);
		if (num <= 1E-05)
		{
			return;
		}
		int num5 = 0;
		for (double num6 = num3; num6 < (double)this.98; num6 += num)
		{
			int num7 = num5 % this.3.96();
			198 <<EMPTY_NAME>> = this.3.51;
			<<EMPTY_NAME>> = ((num7 == 0) ? this.3.51 : ((num7 * 2 % this.3.96() == 0) ? this.3.49 : ((num7 * 3 % this.3.96() == 0) ? this.3.50 : ((num7 * 4 % this.3.96() == 0) ? this.3.47 : ((num7 * 6 % this.3.96() == 0) ? this.3.52 : ((num7 * 8 % this.3.96() != 0) ? this.3.53 : this.3.48))))));
			if (num6 >= (double)this.97)
			{
				bool flag = num2 % num4 == 0 && num5 % this.3.96() == 0;
				float num8 = this.114((int)num6);
				1433 2 = new 1433(1662.34, (1376)6, 1065.TopLeft, (1044)0, new 208((float)this.79, num8 - (flag > false)), 0.916f, true, <<EMPTY_NAME>>, null);
				2.20 = new 208((float)this.84 * this.83(), (float)((!flag) ? 1 : 3)) * 1.6f;
				this.92.12(2);
				if (this.74 != null)
				{
					2 = new 1433(1662.34, (1376)6, 1065.TopLeft, (1044)0, new 208((float)this.79 + this.83() * (float)this.84 + this.83(), num8 - (flag > false)), 0.916f, true, <<EMPTY_NAME>>, null);
					2.20 = new 208((float)((int)Math.Round((double)this.74.21.2)) * this.83(), (float)((!flag) ? 1 : 3)) * 1.6f;
					2.9 = -10086;
					this.92.12(2);
				}
			}
			if (num5 % this.3.96() == 0)
			{
				num2++;
			}
			num5++;
		}
	}

	// Token: 0x06002D79 RID: 11641 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal override void DrawTimelineContent()
	{
	}

	// Token: 0x06002D7A RID: 11642 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal override void UpdateTimelineObjects()
	{
	}

	// Token: 0x04002135 RID: 8501
	private new int 77;

	// Token: 0x04002136 RID: 8502
	private new int 78 = 80;

	// Token: 0x04002137 RID: 8503
	private new int 79 = 160;

	// Token: 0x04002138 RID: 8504
	private new float 80 = 160f;

	// Token: 0x04002139 RID: 8505
	private new int 81 = 66;

	// Token: 0x0400213A RID: 8506
	private new int 82 = 458;

	// Token: 0x0400213B RID: 8507
	private int 83;

	// Token: 0x0400213C RID: 8508
	private int 84 = 7;

	// Token: 0x0400213D RID: 8509
	private 208 85;

	// Token: 0x0400213E RID: 8510
	private 208 86;

	// Token: 0x0400213F RID: 8511
	private 1433 87;

	// Token: 0x04002140 RID: 8512
	internal 1452 88;

	// Token: 0x04002141 RID: 8513
	private 1433 89;

	// Token: 0x04002142 RID: 8514
	private 1433 90;

	// Token: 0x04002143 RID: 8515
	private 2011 91;

	// Token: 0x04002144 RID: 8516
	private 1436 92;

	// Token: 0x04002145 RID: 8517
	private 1436 93;

	// Token: 0x04002146 RID: 8518
	private 1436 94;

	// Token: 0x04002147 RID: 8519
	private int 95 = -1;

	// Token: 0x04002148 RID: 8520
	private float 96 = -1f;

	// Token: 0x04002149 RID: 8521
	private int 97;

	// Token: 0x0400214A RID: 8522
	private int 98;

	// Token: 0x0400214B RID: 8523
	private 2048 99;

	// Token: 0x0400214C RID: 8524
	private 2034 100;

	// Token: 0x0400214D RID: 8525
	private float 101;

	// Token: 0x0400214E RID: 8526
	private int 102;

	// Token: 0x0400214F RID: 8527
	private int 103 = -1;

	// Token: 0x04002150 RID: 8528
	private List<2654> 104;

	// Token: 0x04002151 RID: 8529
	private List<2654> 105;

	// Token: 0x04002152 RID: 8530
	private 2033[] 106;

	// Token: 0x04002153 RID: 8531
	private float 107;

	// Token: 0x04002154 RID: 8532
	protected 2654 108;

	// Token: 0x04002155 RID: 8533
	private int 109 = -1;

	// Token: 0x04002156 RID: 8534
	private int 110 = -1;

	// Token: 0x04002157 RID: 8535
	private bool 111;

	// Token: 0x04002158 RID: 8536
	internal bool 112;

	// Token: 0x04002159 RID: 8537
	private int 113;

	// Token: 0x0400215A RID: 8538
	private int 114;

	// Token: 0x0400215B RID: 8539
	private bool 115;

	// Token: 0x0400215C RID: 8540
	private int 116 = -1;

	// Token: 0x0400215D RID: 8541
	private float 117;

	// Token: 0x020005B4 RID: 1460
	[Serializable]
	public sealed class 2347
	{
		// Token: 0x06002D7C RID: 11644 RVA: 0x001010F5 File Offset: 0x000FF2F5
		internal bool 1(1371 1)
		{
			return 1.9 == -10086;
		}

		// Token: 0x06002D7D RID: 11645 RVA: 0x000E8B4A File Offset: 0x000E6D4A
		internal int 2(2034 1, 2034 2)
		{
			return 1.1.CompareTo(2.1);
		}

		// Token: 0x0400215E RID: 8542
		public static readonly 2345.2347 Instance = new 2345.2347();

		// Token: 0x0400215F RID: 8543
		public static Predicate<1371> predicate;

		// Token: 0x04002160 RID: 8544
		public static Comparison<2034> comparison;
	}

	// Token: 0x020005B5 RID: 1461
	public sealed class 2346
	{
		// Token: 0x06002D80 RID: 11648 RVA: 0x00101110 File Offset: 0x000FF310
		internal bool 1(1995 1)
		{
			return 1.16() == this.1 || 1.18() == this.1;
		}

		// Token: 0x06002D81 RID: 11649 RVA: 0x00101130 File Offset: 0x000FF330
		internal void 2(1371 1)
		{
			if (1.8 != null && 1.8 == "vertical")
			{
				if (this.2.115)
				{
					1.13();
					return;
				}
				1.14();
			}
		}

		// Token: 0x04002161 RID: 8545
		public 200 1;

		// Token: 0x04002162 RID: 8546
		public 2345 2;
	}

	// Token: 0x020005B6 RID: 1462
	public sealed class 2348
	{
		// Token: 0x06002D83 RID: 11651 RVA: 0x00101161 File Offset: 0x000FF361
		internal void 1(2034 1)
		{
			if (1.2 >= this.2 && 1.1 <= this.3)
			{
				this.1.SelectObject(1);
			}
		}

		// Token: 0x04002163 RID: 8547
		public 2345 1;

		// Token: 0x04002164 RID: 8548
		public int 2;

		// Token: 0x04002165 RID: 8549
		public int 3;
	}
}
