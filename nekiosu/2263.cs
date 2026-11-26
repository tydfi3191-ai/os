using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

// Token: 0x02000576 RID: 1398
public sealed class 2263 : 2462
{
	// Token: 0x06002B10 RID: 11024 RVA: 0x000E8B74 File Offset: 0x000E6D74
	internal bool 1()
	{
		return this.isUndoCommitDeferred;
	}

	// Token: 0x06002B11 RID: 11025 RVA: 0x000E8B7C File Offset: 0x000E6D7C
	internal void 2(bool 1)
	{
		this.85 = 1;
		this.8.17 = !1;
		this.isUndoCommitDeferred = 1;
	}

	// Token: 0x06002B12 RID: 11026 RVA: 0x000E8B9C File Offset: 0x000E6D9C
	internal new bool 3(2275 1, bool 2)
	{
		if (1 == null)
		{
			return false;
		}
		if (1.GetDuration() < 650)
		{
			return false;
		}
		int num;
		int num2;
		this.7(1, out num, out num2);
		return num >= 0 && num2 >= 0 && 1.8 - num >= 200 && num2 - 1.1 >= this.7.2 && this.4(num, num2, 2);
	}

	// Token: 0x06002B13 RID: 11027 RVA: 0x000E8C00 File Offset: 0x000E6E00
	internal bool 4(int 1, int 2, bool 3)
	{
		int 4 = 3 ? 5000 : 1200;
		return this.6(1, 2, 4);
	}

	// Token: 0x06002B14 RID: 11028 RVA: 0x000E8C28 File Offset: 0x000E6E28
	internal bool 5(int 1, int 2, bool 3)
	{
		int 4 = 3 ? 50 : 1200;
		return this.6(1, 2, 4);
	}

	// Token: 0x06002B15 RID: 11029 RVA: 0x000E8C4B File Offset: 0x000E6E4B
	internal bool 6(int 1, int 2, int 3)
	{
		return 1 >= 0 && 2 >= 0 && 2 - 1 >= 3;
	}

	// Token: 0x06002B16 RID: 11030 RVA: 0x000E8C60 File Offset: 0x000E6E60
	internal bool 7(2275 1, out int 2, out int 3)
	{
		int num = this.7.71(1);
		int 4 = num - 1;
		2034 5 = this.7.60(4);
		int num2 = (5 == null) ? this.7.67(1.8, num) : this.7.67(Math.Min(5.2, 1.8), num);
		if (num2 >= 0)
		{
			4 = num2;
		}
		5 = this.7.60(4);
		2034 6 = this.7.60(num);
		2 = this.8(5);
		3 = this.9(6);
		return 2 >= 0 && 3 >= 0;
	}

	// Token: 0x06002B17 RID: 11031 RVA: 0x000E8D03 File Offset: 0x000E6F03
	private int 8(2034 1)
	{
		if (1 == null)
		{
			return -1;
		}
		return 1.2;
	}

	// Token: 0x06002B18 RID: 11032 RVA: 0x000E8D10 File Offset: 0x000E6F10
	private int 9(2034 1)
	{
		if (1 == null)
		{
			return -1;
		}
		return 1.1;
	}

	// Token: 0x06002B19 RID: 11033 RVA: 0x000E8D20 File Offset: 0x000E6F20
	internal 2275 10(int 1)
	{
		2263.2266 2 = new 2263.2266();
		2.1 = 1;
		return this.6.13.Find(new Predicate<2275>(2.1));
	}

	// Token: 0x06002B1A RID: 11034 RVA: 0x000E8D58 File Offset: 0x000E6F58
	internal 2275 11(int 1, int 2)
	{
		2263.2265 match = new 2263.2265();
		match.1 = 3;
		match.2 = 2;
		return this.6.13.Find((2275 1) => (1.8 <= match.1 && 1.1 > match.1) || (1.1 > match.1 && 1.1 <= match.2));
	}

	// Token: 0x06002B1B RID: 11035 RVA: 0x000E8DAA File Offset: 0x000E6FAA
	internal void 12(bool 1)
	{
		if (this.10)
		{
			this.13(1, true);
			this.85 = false;
			this.8.20(false, false);
		}
	}

	// Token: 0x06002B1C RID: 11036 RVA: 0x000E8DD0 File Offset: 0x000E6FD0
	internal void 13(bool 1, bool 2)
	{
		for (int i = 0; i < this.6.13.Count; i++)
		{
			2275 3 = this.6.13[i];
			if (!this.3(3, false))
			{
				this.21(3, 1);
				i--;
			}
		}
		for (int j = 1; j < this.6.13.Count; j++)
		{
			2275 4 = this.6.13[j - 1];
			int 5 = 4.1;
			4 = this.6.13[j];
			int 6 = this.7.60(this.7.68(4.8) - 1).2;
			if (4.8 <= 5 || 6 <= 5)
			{
				this.21(4, 1);
				j--;
			}
		}
		if (2)
		{
			this.8.20(false, false);
		}
	}

	// Token: 0x06002B1D RID: 11037 RVA: 0x000E8EC0 File Offset: 0x000E70C0
	internal void 14(bool 1)
	{
		if (1)
		{
			this.8.15((2452)2, (2451)9, null);
		}
		if (this.6.13.Count > 0)
		{
			if (1)
			{
				this.8.24<2275>(this.6.13, false);
			}
			this.6.38();
		}
		this.18(1);
		if (this.1())
		{
			this.2(false);
			this.8.20(false, false);
		}
		this.85 = false;
	}

	// Token: 0x06002B1E RID: 11038 RVA: 0x000E8F4C File Offset: 0x000E714C
	internal bool 15(2275 1, bool 2, int 3)
	{
		if (!this.85 || 1 == null)
		{
			return false;
		}
		this.85 = false;
		if (2)
		{
			int 4 = 1.1;
			if (3 == 4)
			{
				return false;
			}
			if (3 < 4)
			{
				int num;
				int num2;
				if (!this.7(1, out num, out num2))
				{
					this.21(1, true);
					return true;
				}
				int num3 = num + 200;
				int num4 = Math.Max(3, num3 + 50);
				if (num4 < this.88)
				{
					return false;
				}
				1.SetEndTime(num4);
			}
			else
			{
				if (!1.13)
				{
					return false;
				}
				int num;
				int num2;
				if (!this.7(1, out num, out num2))
				{
					this.21(1, true);
					return true;
				}
				int val = num2 - this.7.2;
				int num4 = Math.Min(3, val);
				1.SetEndTime(num4);
			}
		}
		else
		{
			int num5 = 1.8;
			if (3 == num5)
			{
				return false;
			}
			if (3 < num5)
			{
				if (!1.12)
				{
					return false;
				}
				int num;
				int num2;
				if (!this.7(1, out num, out num2))
				{
					this.21(1, true);
					return true;
				}
				int val2 = num + 200;
				int num6 = Math.Max(3, val2);
				1.SetStartTime(num6);
			}
			else
			{
				int num;
				int num2;
				if (!this.7(1, out num, out num2))
				{
					this.21(1, true);
					return true;
				}
				int num7 = num2 - this.7.2;
				int num6 = Math.Min(3, num7 - 50);
				if (num6 > this.88)
				{
					return false;
				}
				1.SetStartTime(num6);
			}
		}
		1.11(!2, true, true, false);
		return true;
	}

	// Token: 0x06002B1F RID: 11039 RVA: 0x000E90BD File Offset: 0x000E72BD
	internal void 16(bool 1)
	{
		this.17(true, false, this.86, 1);
	}

	// Token: 0x06002B20 RID: 11040 RVA: 0x000E90D0 File Offset: 0x000E72D0
	internal void 17(bool 1, bool 2, bool 3, bool 4)
	{
		if (!this.85)
		{
			return;
		}
		if (4)
		{
			this.8.19((2452)2, null);
			this.8.13((2451)0, (2450)2304);
		}
		if (this.7.35 > 1)
		{
			for (int i = 0; i < this.6.13.Count; i++)
			{
				if (!this.6.13[i].11(1, 2, 3, 4))
				{
					i--;
				}
			}
			if (this.87)
			{
				this.13(4, false);
			}
			this.18(4);
		}
		else if (this.6.13.Count > 0)
		{
			if (4)
			{
				this.8.13((2451)9, (2450)0);
				this.8.24<2275>(this.6.13, false);
			}
			this.6.38();
		}
		this.85 = false;
		this.86 = false;
		this.87 = false;
		if (4 && this.1())
		{
			this.2(false);
			this.8.20(false, false);
		}
	}

	// Token: 0x06002B21 RID: 11041 RVA: 0x000E91F4 File Offset: 0x000E73F4
	private void 18(bool 1)
	{
		for (int i = 1; i < this.7.35; i++)
		{
			int 2 = this.7.34[i - 1].2;
			int 3 = this.7.34[i].1;
			if (this.4(2, 3, true) && this.11(2, 3) == null)
			{
				int num = this.7.67(2, i - 1);
				if (num >= 0)
				{
					2 = this.7.34[num].2;
				}
				if (this.4(2, 3, true))
				{
					this.19(new 2275(2, 3, false), 1);
				}
			}
		}
	}

	// Token: 0x06002B22 RID: 11042 RVA: 0x000E92A7 File Offset: 0x000E74A7
	internal void 19(2275 1, bool 2)
	{
		if (1.GetDuration() >= 650)
		{
			if (2)
			{
				this.8.18((2452)2, (2451)8, 1);
			}
			this.6.9(1);
		}
	}

	// Token: 0x06002B23 RID: 11043 RVA: 0x000E92D4 File Offset: 0x000E74D4
	internal void 20(int 1, bool 2, bool 3)
	{
		bool flag;
		int num = this.7.69(1, out flag);
		if (!flag && num > 0 && num < this.7.35)
		{
			int 4 = this.7.60(num - 1).2;
			int 5 = this.7.60(num).1;
			int num2 = this.7.67(4, num);
			if (num2 >= 0)
			{
				4 = this.7.60(num2).2;
			}
			if (4 < 1 && 5 > 1)
			{
				bool flag2 = false;
				if (this.4(4, 5, false) && !(flag2 = (this.11(4, 5) != null)))
				{
					2275 6 = new 2275(4, 5, false);
					if (6.GetDuration() >= 650)
					{
						this.19(6, 3);
						return;
					}
				}
				if (flag2)
				{
					return;
				}
			}
		}
		if (2)
		{
			1763.2(1568.1(2679.EditorModeCompose_NotEnoughRoomMessage), 3000, (1389)0);
		}
	}

	// Token: 0x06002B24 RID: 11044 RVA: 0x000E93C0 File Offset: 0x000E75C0
	internal void 21(2275 1, bool 2)
	{
		if (2)
		{
			this.8.18((2452)2, (2451)9, 1);
		}
		this.6.12(1);
	}

	// Token: 0x06002B25 RID: 11045 RVA: 0x000E93E0 File Offset: 0x000E75E0
	internal 2263(1803 1) : base(1)
	{
		if (1662.8 == null)
		{
			1662.8 = new 2330();
		}
		2263.4 = this;
	}

	// Token: 0x06002B26 RID: 11046 RVA: 0x000E954B File Offset: 0x000E774B
	internal bool 22()
	{
		return this.73 != null && this.73.HasGrid();
	}

	// Token: 0x06002B27 RID: 11047 RVA: 0x000E9562 File Offset: 0x000E7762
	internal static bool 23()
	{
		return 1226.81().Count > 0;
	}

	// Token: 0x06002B28 RID: 11048 RVA: 0x000E9574 File Offset: 0x000E7774
	public override void Initialize()
	{
		1226.2(true);
		1226.5 = false;
		1662.11.40.6(this, 20);
		1262 <<EMPTY_NAME>> = 1272.5();
		if (<<EMPTY_NAME>> == null)
		{
			1763.5(1568.1(2679.Player_CantLoadBeatmap), 198.Red, 2000, null);
			this.33(false);
			return;
		}
		2648.35 = 30;
		this.65 = new 1436(true);
		this.7 = new 2028(false, true);
		this.8 = new 2458(this);
		2458 2 = this.8;
		2.8 = (1184)Delegate.Combine(2.8, new 1184(2263.2267.Instance.1));
		2458 3 = this.8;
		3.9 = (1184)Delegate.Combine(3.9, new 1184(delegate(bool 1)
		{
			if (1662.8 != null)
			{
				1662.8.66.Enabled = 1;
			}
		}));
		2019.5();
		2019.1 &= ~2023.DoubleTime;
		2486.88 = null;
		1662.8.22(this);
		this.64();
		try
		{
			if (!<<EMPTY_NAME>>.28)
			{
				1226.103();
				string text = Path.GetExtension(<<EMPTY_NAME>>.18);
				if (string.IsNullOrEmpty(text))
				{
					text = ".mp3";
				}
				string text2 = "audio" + text;
				if (<<EMPTY_NAME>>.18 != text2)
				{
					int num = 1;
					while (<<EMPTY_NAME>>.52(text2))
					{
						text2 = "audio-" + num.ToString() + text;
						num++;
					}
					if (<<EMPTY_NAME>>.50(<<EMPTY_NAME>>.18, text2))
					{
						<<EMPTY_NAME>>.18 = text2;
					}
				}
				1226.99(<<EMPTY_NAME>>, true, false, true, false);
				<<EMPTY_NAME>>.10 = 2672.21(1226.33, true);
				<<EMPTY_NAME>>.11 = 1226.33;
				<<EMPTY_NAME>>.7 = 2672.21(1226.34, true);
				<<EMPTY_NAME>>.8 = 1226.34;
			}
			else
			{
				1226.99(<<EMPTY_NAME>>, false, false, true, false);
			}
		}
		catch (1043)
		{
			1763.5(1568.1(2679.Player_CantLoadAudio), 198.Red, 2000, null);
			this.33(false);
			return;
		}
		if (this.34(<<EMPTY_NAME>>, false, false))
		{
			this.99(1052.19(<<EMPTY_NAME>>.86, 0.1f, 8f));
			this.62();
			this.51();
			if (2485.221 != null && 2485.221 != this.7.25)
			{
				this.7.25 = 2485.221;
				this.8.13 = true;
			}
			2485.221 = null;
			this.15 = <<EMPTY_NAME>>.3();
			this.24();
			1662.8.18(100.0);
			1662.8.21(2255.54[2357.GridSnap]);
			base.Initialize();
			1226.46(100, false);
			if (1226.81().Count == 0)
			{
				this.27(2335.Timing);
			}
			else
			{
				this.27((2263.82 == 2335.None) ? 2335.Compose : 2263.82);
			}
			1662.8.17(this.26);
			if (1662.84 || 1662.85 > 0)
			{
				1226.4(1662.85, false, false);
				1662.85 = 0;
				1662.84 = false;
			}
			else if (<<EMPTY_NAME>>.36 > 0)
			{
				1226.4(<<EMPTY_NAME>>.36, false, false);
			}
			else
			{
				1226.4(0, false, false);
			}
			this.77(1226.38());
			1662.8.68(1226.84());
			1763.3();
			1662.55.5 = false;
		}
	}

	// Token: 0x06002B29 RID: 11049 RVA: 0x000E98F4 File Offset: 0x000E7AF4
	private void 24()
	{
		switch (1272.5().3())
		{
		case 2147.Taiko:
			this.74 = new 2362(this);
			break;
		case 2147.CatchTheBeat:
			this.74 = new 2276(this);
			break;
		case 2147.OsuMania:
			this.74 = new 2345(this);
			break;
		default:
			this.74 = new 2255(this);
			break;
		}
		this.76 = new 2366(this);
		this.75 = new 2298(this);
		this.74.Initialize();
		this.76.Initialize();
		this.75.Initialize();
	}

	// Token: 0x06002B2A RID: 11050 RVA: 0x000E9990 File Offset: 0x000E7B90
	protected override void Dispose(bool 1)
	{
		2263.2264 2 = new 2263.2264();
		1226.2(false);
		1662.11.40.6(this, 0);
		1226.98();
		2.1 = this.7.21;
		if (2.1 != null)
		{
			List<1262> list = 1272.3.FindAll(new Predicate<1262>(2.1));
			foreach (1262 3 in list)
			{
				3.59 = false;
			}
			2.1.65();
			foreach (1262 4 in list)
			{
				4.85 = (1281)0;
			}
			1633.6(list);
		}
		if (this.73 != null)
		{
			this.73.Deactivate();
		}
		2263.4 = null;
		if (this.65 != null)
		{
			this.65.Dispose();
		}
		if (this.40 != null)
		{
			this.40.Dispose();
		}
		if (this.42 != null)
		{
			this.42.Dispose();
		}
		if (this.41 != null)
		{
			this.41.Dispose();
		}
		if (this.7 != null)
		{
			this.7.Dispose();
		}
		1662.69.12(1f, false);
		1555.26();
		if (this.76 != null)
		{
			this.76.Dispose();
		}
		if (this.74 != null)
		{
			this.74.Dispose();
		}
		if (this.75 != null)
		{
			this.75.Dispose();
		}
		2317.13();
		1304.144.7(this.96());
		this.39();
		1549.6(new 1549.1551(this.56));
		base.Dispose(1);
	}

	// Token: 0x06002B2B RID: 11051 RVA: 0x000E9B78 File Offset: 0x000E7D78
	public override void Update()
	{
		if (this.6 == null || this.73 == null)
		{
			return;
		}
		base.Update();
		this.6.16();
		if (!1662.11.2())
		{
			this.10 = false;
		}
		this.74.65();
		this.73.Update();
		this.93();
		this.69 = (1662.69.22(1535.6) && 1662.92 == null);
		this.70 = (this.66.Contains(1535.5) && 1662.92 == null);
		this.71 = this.35.Contains(1535.5);
		if (!this.10)
		{
			this.59 = (2329)0;
		}
		if (this.59 == (2329)3 && (1662.33 % 125 < 16 || 1226.32 == (1042)0))
		{
			1226.4((int)((float)1226.9() * ((float)(1535.5.X - this.35.GetLeft()) / (float)this.35.Width)), false, false);
		}
		if (!this.5 && this.73.IsEditingSliderPath())
		{
			this.40.22 = false;
			if (this.73.5 != null)
			{
				this.73.5.22 = false;
			}
		}
		else
		{
			this.40.22 = true;
			if (this.73.5 != null)
			{
				this.73.5.22 = true;
			}
		}
		if (1662.23)
		{
			bool flag = 1226.63();
			if (flag != this.30)
			{
				this.30 = flag;
				if (flag)
				{
					this.28.3.RemoveAll(new Predicate<1445>(2263.2267.Instance.2));
					this.28.3.Add(new 1445(1456.Fade, 0f, 0.9f, 1662.33, 1662.33 + 160, (1046)1));
					this.28.3.Add(new 1445(1456.MovementX, -40f, 0f, 1662.33, 1662.33 + 160, (1046)1));
					this.29.24(0.4f, 100, (1046)0);
					this.29.3.RemoveAll(new Predicate<1445>(2263.2267.Instance.3));
					this.29.3.Add(new 1445(1456.MovementX, -40f, 0f, 1662.33, 1662.33 + 160, (1046)1));
				}
				else
				{
					this.28.16(100, (1046)0, 0);
					this.28.3.RemoveAll((1445 1) => 1.14 == 1456.MovementX);
					this.28.3.Add(new 1445(1456.MovementX, 0f, -40f, 1662.33, 1662.33 + 160, (1046)1));
					this.29.16(100, (1046)0, 0);
					this.29.3.RemoveAll(new Predicate<1445>(2263.2267.Instance.4));
					this.29.3.Add(new 1445(1456.MovementX, 0f, -40f, 1662.33, 1662.33 + 160, (1046)1));
				}
			}
			if (flag && this.29.3.Count == 0)
			{
				this.29.16 = 0.4f - (float)1226.68 * 0.6f;
			}
		}
		if (this.71 && !2263.35() && !this.73.IsEditingSliderPath())
		{
			if (this.11.3.Count == 0)
			{
				this.11.FadeIn(200, (1046)0, 0);
				this.36.FadeIn(200, (1046)0, 0);
				this.13.FadeIn(200, (1046)0, 0);
				this.12.FadeIn(200, (1046)0, 0);
				this.14.FadeIn(200, (1046)0, 0);
			}
			this.5 = false;
		}
		else if (!2263.25.Contains(1535.5) && this.11.16 == 1f)
		{
			this.11.16(200, (1046)0, 0);
			this.36.16(200, (1046)0, 0);
			this.13.16(200, (1046)0, 0);
			this.12.16(200, (1046)0, 0);
			this.14.16(200, (1046)0, 0);
			this.5 = false;
		}
		else if (this.11.19)
		{
			this.74.65();
			this.5 = true;
		}
		else
		{
			this.5 = false;
		}
		if (1662.23)
		{
			if (1226.16 >= 0)
			{
				this.37.SetText(string.Format("{0:00}:{1:00}:{2:000}", 1226.16 / 60000, 1226.16 % 60000 / 1000, Math.Max(0, 1226.16) % 1000));
			}
			else
			{
				this.37.SetText(string.Format("-{0:00}:{1:00}:{2:000}", -1226.16 / 60000, -1226.16 % 60000 / 1000, Math.Max(0, -1226.16) % 1000));
				this.38.SetText("intro");
			}
			if (1226.16 < 0)
			{
				this.38.SetText("intro");
			}
			else if (1226.16 > 1226.9())
			{
				this.38.SetText("outro");
			}
			else
			{
				this.38.SetText(string.Format("{0:0.0}%", (float)1226.16 / (float)1226.9() * 100f));
			}
		}
		this.34.17 = new 208((float)this.35.GetLeft() + (float)1226.16 / (float)1226.9() * (float)this.35.Width, (float)(this.35.GetTop() + this.35.Height / 2));
	}

	// Token: 0x06002B2C RID: 11052 RVA: 0x000EA1EC File Offset: 0x000E83EC
	public override void Draw()
	{
		if (this.6 != null && this.73 != null)
		{
			base.Draw();
			this.6.13();
			this.6.14();
			if (this.26 != 2335.Timing && this.15 != 2147.OsuMania)
			{
				this.7.8();
				this.6.15();
			}
			if (this.43 != null)
			{
				this.43.17();
			}
			this.41.22();
			this.100();
			this.76();
			this.42.22();
			this.73.Draw();
			this.40.22();
		}
	}

	// Token: 0x06002B2D RID: 11053 RVA: 0x000EA2A4 File Offset: 0x000E84A4
	internal void 25()
	{
		if (this.7.35 != 0)
		{
			this.57();
			if (MessageBox.Show("Are you sure you want to clear all objects in the current difficulty?", "osu!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.OK)
			{
				this.8.17<2034>((2452)0, (2451)9, this.7.34);
				this.7.7();
				this.2(true);
			}
		}
	}

	// Token: 0x06002B2E RID: 11054 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal void 26()
	{
	}

	// Token: 0x06002B2F RID: 11055 RVA: 0x000EA308 File Offset: 0x000E8508
	internal void 27(2335 1)
	{
		if (this.27)
		{
			this.26();
		}
		1555.26();
		if (1226.81().Count == 0 && 1 != 2335.Timing)
		{
			MessageBox.Show("Please time the song first!  This is imperative to creating a good beatmap.  Read the guide on the site if you don't understand timing, or ask in the Beatmap Help forum.", "denied", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		if (1 != this.26)
		{
			this.26 = 1;
			this.39.19(new 208((float)((this.26 - 2335.Compose) * 100), 0f), 300, (1046)1);
			if (this.73 != null)
			{
				this.73.Deactivate();
			}
			this.7.36.ForEach(new Action<2034>(2263.2267.Instance.5));
			this.12(true);
			this.8.20(false, false);
			switch (1)
			{
			case 2335.Compose:
				this.73 = this.74;
				break;
			case 2335.Design:
				this.73 = this.75;
				break;
			case 2335.Timing:
				this.73 = this.76;
				break;
			}
			this.73.Activate();
			this.65();
			1662.8.17(1);
		}
	}

	// Token: 0x06002B30 RID: 11056 RVA: 0x000EA428 File Offset: 0x000E8628
	internal void 28(2337 1, bool 2)
	{
		this.73.1(1, 2);
	}

	// Token: 0x06002B31 RID: 11057 RVA: 0x000EA437 File Offset: 0x000E8637
	internal void 29()
	{
		this.73.CopySelection();
	}

	// Token: 0x06002B32 RID: 11058 RVA: 0x000EA444 File Offset: 0x000E8644
	internal void Paste()
	{
		this.73.Paste();
	}

	// Token: 0x06002B33 RID: 11059 RVA: 0x000EA451 File Offset: 0x000E8651
	internal void 30()
	{
		this.73.SelectAll();
	}

	// Token: 0x06002B34 RID: 11060 RVA: 0x000EA45E File Offset: 0x000E865E
	internal void 31()
	{
		if (this.73 != null)
		{
			this.73.ClearSelection();
		}
	}

	// Token: 0x06002B35 RID: 11061 RVA: 0x000EA473 File Offset: 0x000E8673
	internal bool 32()
	{
		return this.33(true);
	}

	// Token: 0x06002B36 RID: 11062 RVA: 0x000EA47C File Offset: 0x000E867C
	internal bool 33(bool 1)
	{
		this.9 = true;
		2263.82 = 2335.None;
		this.47();
		if (this.45 != null)
		{
			this.45.Close();
			this.45 = null;
		}
		1662.82(true);
		if (this.74 != null)
		{
			this.74.65();
		}
		this.41();
		if (1691.7 && this.7 != null && this.7.34.Count == 0)
		{
			return false;
		}
		if (!this.8.13 || this.7.53(1, false, false, false))
		{
			1662.SetMode(1677.SelectEdit, false);
			1262 2 = this.7.21;
			if (2 != null)
			{
				if (2.26)
				{
					if (2.55() != null && 2.55().25().Length != 0)
					{
						1272.6(2.55().25()[0], true);
					}
					else
					{
						1272.SetCurrentBeatmap(1272.3.Find(new Predicate<1262>(2263.2267.Instance.6)));
					}
				}
				1272.3.FindAll(new Predicate<1262>(2263.2267.Instance.7)).ForEach(new Action<1262>(2263.2267.Instance.8));
				2.36 = 1226.16;
			}
			1662.85 = 0;
			1662.84 = false;
			1662.82(false);
			return true;
		}
		1662.82(false);
		this.9 = false;
		return false;
	}

	// Token: 0x06002B37 RID: 11063 RVA: 0x000EA5E4 File Offset: 0x000E87E4
	internal bool 34(1262 1, bool 2, bool 3)
	{
		this.12(true);
		this.8.20(false, false);
		if (2 && this.68())
		{
			DialogResult dialogResult = 1763.9(1568.1(2679.Editor_FileOperations_RevertFileToLastSavedState), MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
			if (dialogResult == DialogResult.Cancel)
			{
				return false;
			}
			if (dialogResult == DialogResult.No)
			{
				return false;
			}
		}
		1662.105(Path.GetFileName(1.58));
		2263.4.31();
		this.8.18 = true;
		2630.18();
		if (3)
		{
			1455.8(true);
		}
		1226.99(1, false, false, true, false);
		this.77(100.0);
		2648.4(1304.79);
		2648.2(1304.79);
		bool flag;
		try
		{
			this.7.6(1, 2023.None);
			flag = this.7.45();
		}
		catch (2270)
		{
			1662.89(1677.SelectEdit, true, 0);
			this.8.18 = false;
			return false;
		}
		if (this.74 != null && 1.3() != this.15)
		{
			1662.SetMode(1677.Edit, true);
			this.8.18 = false;
			return false;
		}
		this.6 = this.7.32;
		this.6.22.11 = true;
		this.6.21.11 = true;
		this.6.23.11 = true;
		this.6.24.11 = true;
		this.8.10();
		if (!flag || 1.43.Length == 0)
		{
			if (this.74 != null)
			{
				this.74.26(1304.138.4);
			}
			this.46(false);
		}
		1.32 = 14;
		this.7.25(false);
		if (this.75 != null)
		{
			this.75.OnBeatmapLoaded();
		}
		if (this.73 != null)
		{
			this.73.Activate();
		}
		this.8.34();
		if (this.43 != null)
		{
			this.43.14();
		}
		this.85 = true;
		this.87 = true;
		this.17(true, true, false, false);
		1662.8.14();
		this.8.13 = false;
		this.8.18 = false;
		return true;
	}

	// Token: 0x06002B38 RID: 11064 RVA: 0x000EA838 File Offset: 0x000E8A38
	internal static bool 35()
	{
		return 2263.44;
	}

	// Token: 0x06002B39 RID: 11065 RVA: 0x000EA840 File Offset: 0x000E8A40
	internal static void 36(bool 1)
	{
		if (2263.44 != 1)
		{
			2263.44 = 1;
			if (2263.35() && !1226.10())
			{
				1226.107();
			}
			1662.8.Enabled = !1;
			2263.4.73.SetInputEnabled(!1);
			2263.4.40.22 = !1;
			2263.4.42.22 = !1;
			2263.4.65.22 = !1;
		}
	}

	// Token: 0x06002B3A RID: 11066 RVA: 0x000EA8CC File Offset: 0x000E8ACC
	private void 37(object 1, EventArgs 2)
	{
		if (this.45 == null)
		{
			this.46 = true;
			1662.82(true);
			this.45 = new 2308(this.37.GetText());
			this.45.FormClosing += this.50;
			this.45.8(1065.BottomLeft);
		}
	}

	// Token: 0x06002B3B RID: 11067 RVA: 0x000EA928 File Offset: 0x000E8B28
	internal void 38()
	{
		if (this.43 == null || this.43.IsDisposed)
		{
			this.43 = new 2303(this);
		}
		this.43.14();
		if (!this.43.Visible)
		{
			this.43.Show(1662.13());
		}
	}

	// Token: 0x06002B3C RID: 11068 RVA: 0x000EA97E File Offset: 0x000E8B7E
	private void 39()
	{
		if (this.43 != null)
		{
			this.43.13();
			this.43 = null;
		}
	}

	// Token: 0x06002B3D RID: 11069 RVA: 0x000EA99A File Offset: 0x000E8B9A
	public void 40()
	{
		if (this.81 == null || this.81.IsDisposed)
		{
			this.81 = new 2317();
			this.81.Show(1662.13());
		}
	}

	// Token: 0x06002B3E RID: 11070 RVA: 0x000EA9CC File Offset: 0x000E8BCC
	internal void 41()
	{
		if (this.81 != null && !this.81.IsDisposed)
		{
			this.81.Close();
			this.81 = null;
		}
	}

	// Token: 0x06002B3F RID: 11071 RVA: 0x000EA9F8 File Offset: 0x000E8BF8
	public void 42()
	{
		if (this.73 == this.74 && this.74.44.Count != 0 && this.77 == null)
		{
			this.77 = new 2316();
			this.77.ShowDialog(1662.13());
			this.77 = null;
		}
	}

	// Token: 0x06002B40 RID: 11072 RVA: 0x000EAA50 File Offset: 0x000E8C50
	public void 43()
	{
		if (this.73 == this.74 && this.74.44.Count != 0 && this.78 == null)
		{
			float num = this.74.82(true);
			if (num == -1f)
			{
				num = 5f;
			}
			this.78 = new 2319();
			this.78.1(0.5f);
			this.78.2(Math.Max(num, 1f));
			this.78.ShowDialog(1662.13());
			this.78 = null;
		}
	}

	// Token: 0x06002B41 RID: 11073 RVA: 0x000EAAE9 File Offset: 0x000E8CE9
	public void 44()
	{
		if (this.73 == this.74 && this.79 == null)
		{
			this.79 = new 2315();
			this.79.ShowDialog(1662.13());
			this.79 = null;
		}
	}

	// Token: 0x06002B42 RID: 11074 RVA: 0x000EAB24 File Offset: 0x000E8D24
	public void 45()
	{
		if (this.73 == this.74 && this.74.45 != null && this.80 == null)
		{
			this.80 = new 2306(this.74.45);
			this.80.ShowDialog(1662.13());
			this.80 = null;
		}
	}

	// Token: 0x06002B43 RID: 11075 RVA: 0x000EAB84 File Offset: 0x000E8D84
	internal void 46(bool 1)
	{
		this.47();
		1662.82(true);
		new 2320(false, 1).ShowDialog(1662.13());
		1662.82(false);
		if (!this.7.21.44)
		{
			2630.18();
		}
		this.7.LoadComboColours(false);
		this.7.2(true);
	}

	// Token: 0x06002B44 RID: 11076 RVA: 0x000EABE5 File Offset: 0x000E8DE5
	internal bool 47()
	{
		if (this.84 != null)
		{
			this.84.Close();
			this.84 = null;
			return true;
		}
		return false;
	}

	// Token: 0x06002B45 RID: 11077 RVA: 0x000EAC04 File Offset: 0x000E8E04
	internal void 48(bool 1)
	{
		if (this.84 != null && !this.84.IsDisposed && this.84.Visible)
		{
			this.84.Focus();
			return;
		}
		this.84 = new 2312(1);
		this.84.Location = new Point(1662.13().Location.X + 10, 1662.13().Location.Y + 55);
		this.84.Show(1662.13());
	}

	// Token: 0x06002B46 RID: 11078 RVA: 0x000EAC96 File Offset: 0x000E8E96
	public void 49()
	{
		1662.82(false);
		2263.36(false);
	}

	// Token: 0x06002B47 RID: 11079 RVA: 0x000EACA4 File Offset: 0x000E8EA4
	private void 50(object 1, FormClosingEventArgs 2)
	{
		1662.82(false);
		this.46 = false;
		this.45 = null;
	}

	// Token: 0x06002B48 RID: 11080 RVA: 0x000EACBC File Offset: 0x000E8EBC
	private void 51()
	{
		1535.40((1082)8, new 1081(this.59), 1545.Default, (1559)0);
		1535.40((1082)6, delegate(object 1, EventArgs 2)
		{
			this.46 = false;
			return this.73.HandleRelease();
		}, 1545.Default, (1559)0);
		1535.40((1082)5, new 1081(this.58), 1545.Default, (1559)0);
		1535.40((1082)3, new 1081(this.60), 1545.Default, (1559)0);
		1549.5(new 1549.1551(this.56));
		1535.40((1082)2, new 1081(this.61), 1545.Default, (1559)0);
		1535.40((1082)1, new 1081(this.53), 1545.Default, (1559)0);
		1535.40((1082)0, delegate(object 1, EventArgs 2)
		{
			if (this.73.HandleWheelDown())
			{
				return true;
			}
			this.55((!1549.3) ? 1 : 4);
			return true;
		}, 1545.Default, (1559)0);
		1535.40((1082)1, delegate(object 1, EventArgs 2)
		{
			if (1549.2)
			{
				if (this.70)
				{
					this.94(null, null);
					return true;
				}
				if (this.73.HandleAltWheelUp())
				{
					return true;
				}
			}
			return false;
		}, 1545.AltOverrides, (1559)0);
		1535.40((1082)0, new 1081(this.52), 1545.AltOverrides, (1559)0);
	}

	// Token: 0x06002B49 RID: 11081 RVA: 0x000EAD8E File Offset: 0x000E8F8E
	private bool 52(object 1, EventArgs 2)
	{
		if (1549.2)
		{
			if (this.70)
			{
				this.95(null, null);
				return true;
			}
			if (this.73.HandleAltWheelDown())
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06002B4A RID: 11082 RVA: 0x000EADB9 File Offset: 0x000E8FB9
	private bool 53(object 1, EventArgs 2)
	{
		if (this.73.HandleWheelUp())
		{
			return true;
		}
		this.54((!1549.3) ? 1 : 4);
		return true;
	}

	// Token: 0x06002B4B RID: 11083 RVA: 0x000EADDC File Offset: 0x000E8FDC
	private void 54(int 1)
	{
		if (1226.75())
		{
			if (1226.32 == (1042)1)
			{
				1 *= 250 / (int)1226.76() + 1;
			}
			int num = (1226.32 == (1042)1) ? 1 : this.96();
			int num2 = (int)(1226.76() / (double)num) * 1;
			1226.4(this.76.28((double)(1226.16 - num2), (double)1226.16), this.26 == 2335.Design, false);
			return;
		}
		int num3 = 1000 / this.96() * 1;
		int num4 = 1226.16 - num3;
		num4 -= num4 - 1000 / this.96() * Math.DivRem(num4, 1000 / this.96(), out num3);
		if (num4 < 0)
		{
			num4 = 0;
		}
		1226.4(num4, false, false);
	}

	// Token: 0x06002B4C RID: 11084 RVA: 0x000EAE9C File Offset: 0x000E909C
	private void 55(int 1)
	{
		if (1226.75())
		{
			if (1226.32 == (1042)1)
			{
				1 *= 250 / (int)1226.76() + 1;
			}
			int num = (1226.32 == (1042)1) ? 1 : this.96();
			int num2 = (int)(1226.76() / (double)num) * 1;
			1226.4(this.76.28((double)(1226.16 + num2), (double)1226.16), this.26 == 2335.Design, false);
			return;
		}
		int num3 = 1000 / this.96() * 1;
		int num4 = 1226.16 + num3;
		num4 += 1000 / this.96() * Math.DivRem(num4, 1000 / this.96(), out num3) - num4;
		1226.4(num4, false, false);
	}

	// Token: 0x06002B4D RID: 11085 RVA: 0x000EAF58 File Offset: 0x000E9158
	private bool 56(object 1, 200 2, bool 3)
	{
		if (2263.44)
		{
			return false;
		}
		if (this.31 && 1226.32 == (1042)1 && 2 == 200.Escape)
		{
			this.88();
			return true;
		}
		if (this.73.HandleKey(2, 3))
		{
			return false;
		}
		if (1549.1)
		{
			if (2 == 200.Up)
			{
				this.77(Math.Min(100.0, 1226.38() + (double)(1549.3 ? 3 : 25)));
				return true;
			}
			if (2 == 200.Down)
			{
				this.77(Math.Max(25.0, 1226.38() - (double)(1549.3 ? 3 : 25)));
				return true;
			}
		}
		else
		{
			switch (2)
			{
			case 200.Left:
				this.54((!1549.3) ? 1 : 4);
				return true;
			case 200.Up:
				this.73();
				return true;
			case 200.Right:
				this.55((!1549.3) ? 1 : 4);
				return true;
			case 200.Down:
				this.74();
				return true;
			}
		}
		if (3)
		{
			if (1549.1)
			{
				if (2 == 200.Left)
				{
					this.78(null, null);
					return true;
				}
				if (2 == 200.Right)
				{
					this.79(null, null);
					return true;
				}
				switch (2)
				{
				case 200.A:
					if (1549.3)
					{
						this.38();
						return true;
					}
					break;
				case 200.B:
					if (1549.3)
					{
						this.81(null, null);
					}
					else
					{
						this.82(null, null);
					}
					return true;
				case 200.C:
					this.29();
					return true;
				case 200.D:
					if (1549.3)
					{
						this.44();
						return true;
					}
					break;
				case 200.F:
					if (1549.3)
					{
						this.45();
						return true;
					}
					break;
				case 200.I:
					if (1549.3)
					{
						this.40();
						return true;
					}
					this.76.19();
					return true;
				case 200.L:
					this.34(this.7.21, true, 1549.3);
					return true;
				case 200.N:
					this.25();
					return true;
				case 200.O:
					this.48(false);
					return true;
				case 200.P:
					if (1549.3)
					{
						this.76.18(false, null);
					}
					else
					{
						this.76.18(true, null);
					}
					return true;
				case 200.S:
					if (1549.3)
					{
						this.43();
						return true;
					}
					this.66();
					return true;
				case 200.V:
					this.Paste();
					return true;
				case 200.Y:
					this.8.Redo();
					return true;
				case 200.Z:
					this.8.Undo();
					return true;
				}
				if (this.73.HasGrid())
				{
					switch (2)
					{
					case 200.D1:
						this.73.1(2337.Tiny, true);
						return true;
					case 200.D2:
						this.73.1(2337.Small, true);
						return true;
					case 200.D3:
						this.73.1(2337.Medium, true);
						return true;
					case 200.D4:
						this.73.1(2337.Large, true);
						return true;
					}
				}
			}
			if (!1549.1)
			{
				switch (1548.9(2, 1531.Editor))
				{
				case 1532.HelpToggle:
					this.26();
					break;
				case 1532.JumpToBegin:
					this.74.65();
					if (this.7.35 == 0)
					{
						this.85(null, null);
						return true;
					}
					if (this.7.34[0].1 == 1226.16)
					{
						this.85(null, null);
					}
					else
					{
						1226.4(this.7.34[0].1, false, false);
					}
					return true;
				case 1532.PlayFromBegin:
					1226.Pause();
					return true;
				case 1532.AudioPause:
					this.88();
					return true;
				case 1532.JumpToEnd:
					if (this.7.34.Count > 0 && 1226.16 < this.7.34[this.7.34.Count - 1].2)
					{
						1226.4(this.7.34[this.7.34.Count - 1].2, false, false);
					}
					else
					{
						1226.4(Math.Max(0, 1226.9() - 500), false, false);
					}
					return true;
				case 1532.GridChange:
					if (this.73.HasGrid())
					{
						this.28(2332.7(this.73.7.1()), true);
						return true;
					}
					break;
				case 1532.TimingSection:
					this.76.18(true, null);
					return true;
				case 1532.InheritingSection:
					this.76.18(false, null);
					return true;
				case 1532.RemoveSection:
					this.76.19();
					return true;
				}
				if (2 == 200.Space)
				{
					this.88();
					return true;
				}
			}
			if (!1549.2)
			{
				if (2 != 200.Escape)
				{
					switch (2)
					{
					case 200.F1:
						this.27(2335.Compose);
						return true;
					case 200.F2:
						this.27(2335.Design);
						return true;
					case 200.F3:
						this.27(2335.Timing);
						return true;
					case 200.F4:
						this.46(true);
						return true;
					case 200.F5:
						this.89();
						return true;
					case 200.F6:
						this.76.4((2325)1);
						return true;
					}
				}
				else
				{
					if (this.27)
					{
						this.26();
						return true;
					}
					if (this.73.HandleEscape())
					{
						if (!this.47())
						{
							this.32();
						}
						return true;
					}
				}
			}
		}
		return false;
	}

	// Token: 0x06002B4E RID: 11086 RVA: 0x000EB4A4 File Offset: 0x000E96A4
	internal void 57()
	{
		if (this.59 - (2329)1 <= 1)
		{
			1535.19();
		}
	}

	// Token: 0x06002B4F RID: 11087 RVA: 0x000EB4B6 File Offset: 0x000E96B6
	private bool 58(object 1, EventArgs 2)
	{
		return !this.5 && this.73.HandleDoubleClick();
	}

	// Token: 0x06002B50 RID: 11088 RVA: 0x000EB4D0 File Offset: 0x000E96D0
	private bool 59(object 1, EventArgs 2)
	{
		if (this.5 || 1662.92 != null || 1662.76 != (932)2 || 2263.35())
		{
			return false;
		}
		if (!this.46)
		{
			if (this.45 != null)
			{
				this.45.Close();
			}
			this.45 = null;
		}
		if (!this.73.IsEditingSliderPath())
		{
			if (this.40.23 != null || this.73.5.23 != null)
			{
				return false;
			}
			int x = 1535.5.X;
			if ((float)1535.5.Y <= 1662.70.3() * 16f && 1535.5.Y >= 0 && (float)x <= 1662.70.3() * 400f && x >= 0)
			{
				if ((float)x / (1662.70.3() * 100f) >= 3f)
				{
					this.46(true);
				}
				else
				{
					this.27((2335)Math.Max(0f, (float)x / (1662.70.3() * 100f) + 1f));
				}
				return true;
			}
			if (this.71)
			{
				1226.4((int)((float)1226.9() * ((float)(1535.5.X - this.35.GetLeft()) / (float)this.35.Width)), false, false);
				return true;
			}
		}
		return this.73.HandleClick();
	}

	// Token: 0x06002B51 RID: 11089 RVA: 0x000EB63C File Offset: 0x000E983C
	private bool 60(object 1, EventArgs 2)
	{
		if (1662.92 != null || 2263.35())
		{
			return false;
		}
		if (this.5)
		{
			return false;
		}
		if (!this.10)
		{
			this.10 = true;
			if (this.73.HandleDragStart())
			{
				return true;
			}
			if (this.71)
			{
				this.59 = (2329)3;
				return true;
			}
		}
		return false;
	}

	// Token: 0x06002B52 RID: 11090 RVA: 0x000EB693 File Offset: 0x000E9893
	private bool 61(object 1, EventArgs 2)
	{
		this.73.HandleDragEnd();
		this.59 = (2329)0;
		this.10 = false;
		return false;
	}

	// Token: 0x06002B53 RID: 11091 RVA: 0x000EB6B0 File Offset: 0x000E98B0
	private void 62()
	{
		this.40 = new 1436(true);
		this.41 = new 1436(true);
		this.42 = new 1436(true);
		this.37 = new 1452(string.Empty, 14f, new 208(10f, 463f), 1f, true, 198.White);
		this.37.49 = 1065.TopLeft;
		this.37.10 = true;
		this.37.52 = "Jump to specific time.";
		this.37.3(new EventHandler(this.37));
		this.40.12(this.37);
		this.28 = new 1433(1455.2("editor-kiai", (1416)1, null), (1376)6, 1065.TopLeft, (1044)0, new 208(0f, 66f), 0.98f, true, 198.White, null);
		this.28.16 = 0f;
		this.40.12(this.28);
		this.29 = new 1433(1455.2("editor-kiai", (1416)1, null), (1376)6, 1065.TopLeft, (1044)0, new 208(0f, 66f), 1f, true, 198.White, null);
		this.29.16 = 0f;
		this.29.28 = true;
		this.40.12(this.29);
		this.38 = new 1452(string.Empty, 12f, new 208(70f, 465f), 1f, true, 198.White);
		this.40.12(this.38);
		this.41.12(new 1433(1455.2("editor-menu-bg-top", (1416)1, null), (1376)6, 1065.TopLeft, (1044)0, 208.Zero, 0f, true, 198.White, null)
		{
			20 = new 208(1024f * (float)1662.70.1() / 640f, 1f)
		});
		this.41.12(new 1433(1455.2("editor-menu-bg-bottom", (1416)1, null), (1376)12, 1065.BottomLeft, (1044)0, 208.Zero, 0f, true, 198.White, null)
		{
			20 = new 208(1024f * (float)1662.70.1() / 640f, 1f)
		});
		this.41.12(new 1433(1455.2("topmenu-bg", (1416)1, null), (1376)6, 1065.TopLeft, (1044)0, 208.Zero, 0.1f, true, 198.White, null));
		this.39 = new 1433(1455.2("topmenu-selection", (1416)1, null), (1376)6, 1065.TopLeft, (1044)0, 208.Zero, 0.8f, true, 198.White, null);
		this.41.12(this.39);
		if (1662.112)
		{
			this.39.28 = true;
		}
		1433 <<EMPTY_NAME>> = new 1433(1455.2("editor-timeline-plus", (1416)1, null), (1376)6, 1065.Centre, (1044)0, new 208(10f, 37f), 1f, true, 198.White, null);
		<<EMPTY_NAME>>.10 = true;
		<<EMPTY_NAME>>.12 = new 1445(1456.Scale, 1.1f, 1f, 0, 200, (1046)0);
		<<EMPTY_NAME>>.3(new EventHandler(this.94));
		<<EMPTY_NAME>>.52 = "Increase timeline zoom";
		this.40.12(<<EMPTY_NAME>>);
		<<EMPTY_NAME>> = new 1433(1455.2("editor-timeline-minus", (1416)1, null), (1376)6, 1065.Centre, (1044)0, new 208(10f, 53f), 1f, true, 198.White, null);
		<<EMPTY_NAME>>.10 = true;
		<<EMPTY_NAME>>.12 = new 1445(1456.Scale, 1.1f, 1f, 0, 200, (1046)0);
		<<EMPTY_NAME>>.52 = "Decrease timeline zoom";
		<<EMPTY_NAME>>.3(new EventHandler(this.95));
		this.40.12(<<EMPTY_NAME>>);
		float num = 2328.1(1662.13(), false) / 96f;
		1452 2 = new 1452(2263.63(), 10f * num, new 208(70f, 70f), new 208((float)1662.70.1 - 140f * 1662.70.3(), 1662.69.3()), 1f, false, 198.TransparentWhite, true);
		2.40 = new bool?(true);
		2.85 = false;
		2.75 = (1066)2;
		2.74 = false;
		2.3.Add(new 1445(1456.Fade, 1f, 1f, 1662.33, 1662.33 + 10000, (1046)0));
		2.3.Add(new 1445(1456.Fade, 1f, 0f, 1662.33 + 10000, 1662.33 + 10500, (1046)0));
		this.40.12(2);
		this.34 = new 1433(1455.2("seekbar-over", (1416)1, null), (1376)16, 1065.Centre, (1044)0, new 208((float)this.35.GetLeft(), (float)(this.35.GetTop() + this.35.Height / 2)), 1f, true, 198.White, null);
		this.34.28 = true;
		this.42.12(this.34);
		int num2 = 0;
		if (this.7.21.3() == 2147.OsuMania)
		{
			num2 = (int)(25f + 30f * this.7.21.2);
			2263.25.Width = Math.Max(400 + num2, 2263.25.Width);
		}
		this.11 = new 1433(1455.2("editor-timeline-plus", (1416)1, null), (1376)6, 1065.Centre, (1044)0, new 208((float)(150 + num2), 450f), 1f, true, 198.TransparentWhite, "bookmark");
		this.11.10 = true;
		this.11.12 = new 1445(1456.Scale, 1.1f, 1f, 0, 200, (1046)0);
		this.11.3(new EventHandler(this.82));
		this.11.52 = "Add new bookmark at current location (Ctrl+B)";
		this.40.12(this.11);
		this.36 = new 1433(1455.2("editor-timeline-minus", (1416)1, null), (1376)6, 1065.Centre, (1044)0, new 208((float)(170 + num2), 450f), 1f, true, 198.TransparentWhite, "bookmark");
		this.36.10 = true;
		this.36.12 = new 1445(1456.Scale, 1.1f, 1f, 0, 200, (1046)0);
		this.36.52 = "Remove bookmark at current location (Ctrl+Shift+B)";
		this.36.3(new EventHandler(this.81));
		this.40.12(this.36);
		this.13 = new 1433(1455.2("editor-timeline-left", (1416)1, null), (1376)6, 1065.Centre, (1044)0, new 208((float)(190 + num2), 450f), 1f, true, 198.TransparentWhite, "bookmark");
		this.13.10 = true;
		this.13.12 = new 1445(1456.Scale, 1.1f, 1f, 0, 200, (1046)0);
		this.13.52 = "Seek to previous bookmark (Ctrl-LeftArrow)";
		this.13.3(new EventHandler(this.78));
		this.40.12(this.13);
		this.12 = new 1433(1455.2("editor-timeline-right", (1416)1, null), (1376)6, 1065.Centre, (1044)0, new 208((float)(210 + num2), 450f), 1f, true, 198.TransparentWhite, "bookmark");
		this.12.10 = true;
		this.12.52 = "Seek to next bookmark (Ctrl-RightArrow)";
		this.12.12 = new 1445(1456.Scale, 1.1f, 1f, 0, 200, (1046)0);
		this.12.3(new EventHandler(this.79));
		this.40.12(this.12);
		this.14 = new 1433(1455.2("editor-timeline-reset", (1416)1, null), (1376)6, 1065.Centre, (1044)0, new 208((float)(242 + num2), 450f), 1f, true, 198.TransparentWhite, "bookmark");
		this.14.10 = true;
		this.14.52 = "Reset all bookmarks";
		this.14.12 = new 1445(1456.Scale, 1.1f, 1f, 0, 200, (1046)0);
		this.14.3(new EventHandler(this.80));
		this.40.12(this.14);
		this.33 = new 1433(1455.2("editor-rate-arrow", (1416)1, null), (1376)8, 1065.Centre, (1044)0, new 208(18f, 483f), 1f, true, 198.White, null);
		this.40.12(this.33);
		1445 3 = new 1445(1456.Fade, 0.5f, 1f, 0, 100, (1046)0);
		3.15 = (1046)1;
		<<EMPTY_NAME>> = new 1433(1455.2("editor-rate-25", (1416)1, null), (1376)8, 1065.Centre, (1044)0, new 208(85f, 470f), 1f, true, new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue, 128), null);
		<<EMPTY_NAME>>.10 = true;
		<<EMPTY_NAME>>.42 = 3;
		<<EMPTY_NAME>>.8 = 25;
		<<EMPTY_NAME>>.3(new EventHandler(this.87));
		this.40.12(<<EMPTY_NAME>>);
		<<EMPTY_NAME>> = new 1433(1455.2("editor-rate-50", (1416)1, null), (1376)8, 1065.Centre, (1044)0, new 208(62f, 470f), 1f, true, new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue, 128), null);
		<<EMPTY_NAME>>.10 = true;
		<<EMPTY_NAME>>.8 = 50;
		<<EMPTY_NAME>>.42 = 3;
		<<EMPTY_NAME>>.3(new EventHandler(this.87));
		this.40.12(<<EMPTY_NAME>>);
		<<EMPTY_NAME>> = new 1433(1455.2("editor-rate-75", (1416)1, null), (1376)8, 1065.Centre, (1044)0, new 208(41f, 470f), 1f, true, new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue, 128), null);
		<<EMPTY_NAME>>.10 = true;
		<<EMPTY_NAME>>.8 = 75;
		<<EMPTY_NAME>>.3(new EventHandler(this.87));
		<<EMPTY_NAME>>.42 = 3;
		this.40.12(<<EMPTY_NAME>>);
		<<EMPTY_NAME>> = new 1433(1455.2("editor-rate-100", (1416)1, null), (1376)8, 1065.Centre, (1044)0, new 208(18f, 470f), 1f, true, new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue, 128), null);
		<<EMPTY_NAME>>.10 = true;
		<<EMPTY_NAME>>.8 = 100;
		<<EMPTY_NAME>>.3(new EventHandler(this.87));
		<<EMPTY_NAME>>.42 = 3;
		this.40.12(<<EMPTY_NAME>>);
		<<EMPTY_NAME>> = new 1433(1455.2("editor-rate-bg", (1416)1, null), (1376)8, 1065.Centre, (1044)0, new 208(77f, 470f), 1f, true, 198.White, null);
		this.40.12(<<EMPTY_NAME>>);
		3 = new 1445(1456.Scale, 1f, 1.2f, 0, 100, (1046)0);
		3.15 = (1046)1;
		1445 4 = new 1445(1456.Scale, 1.1f, 1.2f, 0, 100, (1046)0);
		4.15 = (1046)1;
		<<EMPTY_NAME>> = new 1433(1455.2("editor-button-play", (1416)1, null), (1376)8, 1065.Centre, (1044)0, new 208(245f, 470f), 1f, true, 198.White, null);
		<<EMPTY_NAME>>.10 = true;
		<<EMPTY_NAME>>.12 = 4;
		<<EMPTY_NAME>>.42 = 3;
		<<EMPTY_NAME>>.3(new EventHandler(this.83));
		this.40.12(<<EMPTY_NAME>>);
		<<EMPTY_NAME>> = new 1433(1455.2("editor-button-pause", (1416)1, null), (1376)8, 1065.Centre, (1044)0, new 208(225f, 470f), 1f, true, 198.White, null);
		<<EMPTY_NAME>>.10 = true;
		<<EMPTY_NAME>>.12 = 4;
		<<EMPTY_NAME>>.42 = 3;
		<<EMPTY_NAME>>.3(new EventHandler(this.84));
		this.40.12(<<EMPTY_NAME>>);
		<<EMPTY_NAME>> = new 1433(1455.2("editor-button-stop", (1416)1, null), (1376)8, 1065.Centre, (1044)0, new 208(205f, 470f), 1f, true, 198.White, null);
		<<EMPTY_NAME>>.10 = true;
		<<EMPTY_NAME>>.12 = 4;
		<<EMPTY_NAME>>.42 = 3;
		<<EMPTY_NAME>>.3(new EventHandler(this.85));
		this.40.12(<<EMPTY_NAME>>);
		<<EMPTY_NAME>> = new 1433(1455.2("editor-button-test", (1416)1, null), (1376)8, 1065.Centre, (1044)0, new 208(175f, 470f), 1f, true, 198.White, null);
		<<EMPTY_NAME>>.10 = true;
		<<EMPTY_NAME>>.52 = "Enter test mode, where you can play through from the current location.\nThis requires saving your beatmap.";
		<<EMPTY_NAME>>.12 = 4;
		<<EMPTY_NAME>>.42 = 3;
		<<EMPTY_NAME>>.3(new EventHandler(this.86));
		this.40.12(<<EMPTY_NAME>>);
	}

	// Token: 0x06002B54 RID: 11092 RVA: 0x000EC3D4 File Offset: 0x000EA5D4
	private static string 63()
	{
		int num = 34;
		int num2 = 1304.147 % num;
		1304.147.7((num2 + 1) % num);
		return 1568.1(2679.EditorTip_1 + num2);
	}

	// Token: 0x06002B55 RID: 11093 RVA: 0x000EC40C File Offset: 0x000EA60C
	internal void 64()
	{
		this.65();
		this.35 = new 207((int)(110f * 1662.70.3()), (int)(460f * 1662.70.3()), (int)(1662.70.3() * (float)(1662.70.1() - 370)), (int)(1662.70.3() * 20f));
		2263.25 = new 207((int)(110f * 1662.70.3()), (int)(430f * 1662.70.3()), (int)(1662.70.3() * (float)(1662.70.1() - 440)), (int)(1662.70.3() * 40f));
	}

	// Token: 0x06002B56 RID: 11094 RVA: 0x000EC4D4 File Offset: 0x000EA6D4
	private void 65()
	{
		this.66 = new 207((int)(1662.70.3() * (float)this.56), (int)(1662.70.3() * (float)this.57), (int)(1662.70.3() * (float)this.68), (int)(1662.70.3() * (float)this.55));
	}

	// Token: 0x06002B57 RID: 11095 RVA: 0x000EC538 File Offset: 0x000EA738
	internal void 66()
	{
		this.74.65();
		this.17(true, false, false, true);
		this.7.53(false, false, false, false);
		1272.16(this.7.21);
		1763.2(1568.1(2679.Editor_FileOperations_SavedBeatmap), 1000, (1389)0);
		this.8.13 = false;
	}

	// Token: 0x06002B58 RID: 11096 RVA: 0x000EC59C File Offset: 0x000EA79C
	internal bool 67(1262 1)
	{
		if (this.74.74 != null)
		{
			this.74.74.Dispose();
			this.74.74 = null;
		}
		bool result;
		try
		{
			if (1 == null)
			{
				this.74.OnReferenceBeatmapChanged();
				result = false;
			}
			else
			{
				this.74.74 = new 2028(true, true);
				this.74.74.6(1, 2023.None);
				this.74.74.46(true, false);
				this.74.74.41 = new 2011(this.74.74);
				this.74.OnReferenceBeatmapChanged();
				result = true;
			}
		}
		catch (Exception)
		{
			this.74.OnReferenceBeatmapChanged();
			result = false;
		}
		return result;
	}

	// Token: 0x06002B59 RID: 11097 RVA: 0x000EC66C File Offset: 0x000EA86C
	internal bool 68()
	{
		this.74.65();
		return this.7.53(false, false, true, false);
	}

	// Token: 0x06002B5A RID: 11098 RVA: 0x000EC688 File Offset: 0x000EA888
	internal bool 69(bool 1)
	{
		if (this.8.13)
		{
			this.74.65();
			if (!this.7.53(1, false, false, false))
			{
				return false;
			}
			this.8.13 = false;
		}
		return true;
	}

	// Token: 0x06002B5B RID: 11099 RVA: 0x000EC6C4 File Offset: 0x000EA8C4
	internal void 70()
	{
		this.47();
		1662.82(true);
		if (new 2320(true, false).ShowDialog(1662.13()) == DialogResult.OK)
		{
			1272.3.Sort();
			this.7.21.25 = 0;
			1272.36(this.7.21.61 ? this.7.21.53() : this.7.21.44());
			if (this.7.35 > 0 && MessageBox.Show(1568.1(2679.Editor_FileOperations_SaveAsDialog), "osu!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
			{
				this.7.7();
				this.7.53(false, false, false, false);
			}
		}
		1662.82(false);
	}

	// Token: 0x06002B5C RID: 11100 RVA: 0x000EC794 File Offset: 0x000EA994
	internal void 71()
	{
		1262 <<EMPTY_NAME>> = this.7.21;
		if (!<<EMPTY_NAME>>.61)
		{
			this.66();
			this.72();
			1662.66(<<EMPTY_NAME>>.81 + ".osz", <<EMPTY_NAME>>.44());
		}
	}

	// Token: 0x06002B5D RID: 11101 RVA: 0x000EC7DC File Offset: 0x000EA9DC
	internal void 72()
	{
		1262 <<EMPTY_NAME>> = this.7.21;
		if (<<EMPTY_NAME>>.61)
		{
			return;
		}
		try
		{
			2672.20(Path.Combine(<<EMPTY_NAME>>.44(), "Thumbs.db"));
		}
		catch
		{
		}
		List<string> list = new List<string>();
		foreach (string text in Directory.GetFiles(<<EMPTY_NAME>>.44()))
		{
			2263.2268 2 = new 2263.2268();
			2670 3 = 2672.24(text);
			2.1 = Path.GetFileName(text);
			if (3 != (2670)0 && 3 != (2670)2)
			{
				switch (3)
				{
				case (2670)7:
				case (2670)8:
				case (2670)9:
				case (2670)13:
					goto IL_109;
				case (2670)12:
					if (2672.23(text) == "png" || 2.1 == "pause-overlay.jpg" || 2.1 == "spinner-background.jpg" || 2263.4.6.14.Find(new Predicate<2647>(2.1)) != null)
					{
						goto IL_109;
					}
					break;
				}
				list.Add(text);
			}
			IL_109:;
		}
		if (list.Count <= 0)
		{
			return;
		}
		string text2 = string.Empty;
		foreach (string str in list)
		{
			text2 = text2 + str + "\n";
		}
		text2 = text2.Trim(new char[]
		{
			'\n'
		});
		if (DialogResult.Yes != MessageBox.Show(1568.1(2679.Editor_FileOperations_UnusedFilesInDirectoryDialog) + "\n\n" + text2, "osu!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
		{
			return;
		}
		foreach (string 4 in list)
		{
			try
			{
				2672.20(4);
			}
			catch
			{
			}
		}
	}

	// Token: 0x06002B5E RID: 11102 RVA: 0x000EC9F4 File Offset: 0x000EABF4
	internal void 73()
	{
		if (1226.71 != 1226.81().Count - 1)
		{
			1226.4((int)1226.81()[1226.71 + 1].3, false, false);
		}
	}

	// Token: 0x06002B5F RID: 11103 RVA: 0x000ECA28 File Offset: 0x000EAC28
	internal void 74()
	{
		if (1226.71 >= 0)
		{
			if ((double)1226.16 - 1226.81()[1226.71].3 > 1000.0)
			{
				1226.4((int)1226.81()[1226.71].3, false, false);
				return;
			}
			if (1226.71 != 0)
			{
				1226.4((int)1226.81()[1226.71 - 1].3, false, false);
			}
		}
	}

	// Token: 0x06002B60 RID: 11104 RVA: 0x000ECAA5 File Offset: 0x000EACA5
	private float 75(double 1)
	{
		return (float)this.35.X + (float)this.35.Width * ((float)1 / (float)1226.9());
	}

	// Token: 0x06002B61 RID: 11105 RVA: 0x000ECACC File Offset: 0x000EACCC
	private void 76()
	{
		List<1259> list = 1226.81();
		if (list == null)
		{
			return;
		}
		1662.13.1();
		for (int i = 0; i < list.Count; i++)
		{
			1259 <<EMPTY_NAME>> = list[i];
			if (<<EMPTY_NAME>>.3())
			{
				float 2 = this.75(<<EMPTY_NAME>>.3);
				float 3 = this.75((i == list.Count - 1) ? ((double)1226.9()) : list[i + 1].3);
				1662.13.2(new 208(2, (float)this.35.GetTop() + (float)this.35.Height * 0.36f), new 208(3, (float)this.35.GetTop() + (float)this.35.Height * 0.64f), 2263.16);
			}
		}
		foreach (2275 4 in this.6.13)
		{
			float 5 = this.75((double)4.8);
			float 6 = this.75((double)4.1);
			1662.13.2(new 208(5, (float)this.35.GetTop() + (float)this.35.Height * 0.4f), new 208(6, (float)this.35.GetTop() + (float)this.35.Height * 0.6f), 2263.17);
		}
		1662.13.3();
		float 7 = (float)(this.35.GetTop() + this.35.Height / 2);
		1662.20.2();
		1662.20.3(new 208((float)this.35.GetLeft(), 7), 2263.19);
		1662.20.3(new 208((float)this.35.GetRight(), 7), 2263.19);
		1262 8 = this.7.21;
		if (8.78 >= 0)
		{
			float 9 = this.75((double)8.78);
			1662.20.3(new 208(9, (float)this.35.GetTop()), 2263.22);
			1662.20.3(new 208(9, (float)(this.35.GetTop() + this.35.Height)), 2263.22);
		}
		foreach (int num in this.7.25)
		{
			float 10 = this.75((double)num);
			1662.20.3(new 208(10, (float)(this.35.GetTop() + this.35.Height / 2)), 2263.18);
			1662.20.3(new 208(10, (float)(this.35.GetTop() + this.35.Height)), 2263.18);
		}
		for (int j = 0; j < list.Count; j++)
		{
			1259 11 = list[j];
			float 12 = this.75(11.3);
			198 13 = 11.1() ? 2263.20 : 2263.21;
			1662.20.3(new 208(12, (float)this.35.GetTop()), 13);
			1662.20.3(new 208(12, (float)(this.35.GetTop() + this.35.Height / 2)), 13);
		}
		1662.20.4();
	}

	// Token: 0x06002B62 RID: 11106 RVA: 0x000ECEA4 File Offset: 0x000EB0A4
	internal void 77(double 1)
	{
		if (1 >= 25.0 && 1 <= 100.0)
		{
			bool flag = Math.Abs(1226.38() - 1) > 10.0;
			1226.39(1);
			if (this.33 != null)
			{
				float num = (float)(1 - 25.0) / 75f * 66f + 567f;
				this.33.18(new 208(640f - num, 473f), flag ? 300 : 80);
				1662.8.18(1);
			}
		}
	}

	// Token: 0x06002B63 RID: 11107 RVA: 0x000ECF44 File Offset: 0x000EB144
	private void 78(object 1, EventArgs 2)
	{
		int num = -1;
		foreach (int num2 in this.7.25)
		{
			if (num2 >= 1226.16 - 500)
			{
				break;
			}
			num = num2;
		}
		if (num >= 0)
		{
			1226.4(num, false, false);
		}
	}

	// Token: 0x06002B64 RID: 11108 RVA: 0x000ECFB8 File Offset: 0x000EB1B8
	private void 79(object 1, EventArgs 2)
	{
		foreach (int num in this.7.25)
		{
			if (num > 1226.16 + 50)
			{
				1226.4(num, false, false);
				break;
			}
		}
	}

	// Token: 0x06002B65 RID: 11109 RVA: 0x000ED020 File Offset: 0x000EB220
	private void 80(object 1, EventArgs 2)
	{
		if (MessageBox.Show(1662.13(), "Remove all bookmarks?", "osu!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.OK)
		{
			this.8.17<int>((2452)3, (2451)9, this.7.25);
			this.7.25.Clear();
			this.8.20(false, false);
		}
	}

	// Token: 0x06002B66 RID: 11110 RVA: 0x000ED080 File Offset: 0x000EB280
	private void 81(object 1, EventArgs 2)
	{
		int num = -1;
		int num2 = -1;
		for (int i = 0; i < this.7.25.Count; i++)
		{
			int num3 = Math.Abs(this.7.25[i] - 1226.16);
			if (num3 < 2000 && (num3 < num2 || num2 == -1))
			{
				num = i;
				num2 = num3;
			}
		}
		if (num > -1)
		{
			this.8.18((2452)3, (2451)9, this.7.25[num]);
			this.7.25.RemoveAt(num);
			this.7.25.Sort();
			this.8.20(false, false);
		}
	}

	// Token: 0x06002B67 RID: 11111 RVA: 0x000ED134 File Offset: 0x000EB334
	private void 82(object 1, EventArgs 2)
	{
		int num = this.76.27((double)1226.16);
		if (!this.7.25.Contains(num))
		{
			this.8.18((2452)3, (2451)8, num);
			this.7.25.Add(num);
			this.7.25.Sort();
			this.8.20(false, false);
		}
	}

	// Token: 0x06002B68 RID: 11112 RVA: 0x000ED1A7 File Offset: 0x000EB3A7
	private void 83(object 1, EventArgs 2)
	{
		if (1226.32 == (1042)1)
		{
			1226.Pause();
			return;
		}
		this.88();
	}

	// Token: 0x06002B69 RID: 11113 RVA: 0x000ED1BD File Offset: 0x000EB3BD
	private void 84(object 1, EventArgs 2)
	{
		this.88();
	}

	// Token: 0x06002B6A RID: 11114 RVA: 0x000ED1C8 File Offset: 0x000EB3C8
	private void 85(object 1, EventArgs 2)
	{
		1226.5();
		foreach (2034 3 in this.7.34)
		{
			3.StopHitSounds();
		}
	}

	// Token: 0x06002B6B RID: 11115 RVA: 0x000ED224 File Offset: 0x000EB424
	private void 86(object 1, EventArgs 2)
	{
		this.89();
	}

	// Token: 0x06002B6C RID: 11116 RVA: 0x000ED22C File Offset: 0x000EB42C
	private void 87(object 1, EventArgs 2)
	{
		this.77((double)((int)((1433)1).8));
		((1433)1).3.Add(new 1445(1456.Scale, 1.2f, 1f, 1662.33, 1662.33 + 100, (1046)0));
	}

	// Token: 0x06002B6D RID: 11117 RVA: 0x000ED280 File Offset: 0x000EB480
	internal void 88()
	{
		1226.107();
		foreach (2034 <<EMPTY_NAME>> in this.7.34)
		{
			<<EMPTY_NAME>>.StopHitSounds();
		}
	}

	// Token: 0x06002B6E RID: 11118 RVA: 0x000ED2DC File Offset: 0x000EB4DC
	internal void 89()
	{
		2263.82 = this.26;
		if (this.7.34.Count == 0)
		{
			return;
		}
		if (1226.32 == (1042)1)
		{
			this.88();
		}
		if (this.74 != null)
		{
			this.74.66();
			this.74.65();
		}
		this.12(true);
		this.8.20(false, false);
		if (1226.76() <= 0.0)
		{
			MessageBox.Show(1568.1(2679.EditorControl_OneSectionRequiredWarning), "osu!", MessageBoxButtons.OK);
			return;
		}
		this.8.18 = true;
		while (!1226.81()[0].1())
		{
			1226.81().RemoveAt(0);
			1226.70(false);
		}
		this.8.18 = false;
		this.39();
		this.41();
		1662.84 = true;
		1662.85 = 1226.16;
		1262 <<EMPTY_NAME>> = this.7.21;
		2486.15(<<EMPTY_NAME>>.3());
		if (this.7.34.FindAll(new Predicate<2034>(2263.2267.Instance.9)).Count == 0)
		{
			1662.85 = 0;
		}
		if (!this.8.13 || this.7.53(true, false, false, false))
		{
			if (<<EMPTY_NAME>>.35(<<EMPTY_NAME>>.3()))
			{
				<<EMPTY_NAME>>.23(<<EMPTY_NAME>>.3());
			}
			this.47();
			if (1304.80)
			{
				2648.35 = (1272.5().112 ?? 1304.141.6());
			}
			1662.89(1677.Play, false, 0);
			return;
		}
		1662.84 = false;
	}

	// Token: 0x06002B6F RID: 11119 RVA: 0x000ED494 File Offset: 0x000EB694
	internal static bool 90(string 1)
	{
		if (2263.4 == null || 1662.78 != 1677.Edit)
		{
			1763.4(1568.1(2679.Editor_FileOperations_LoadSelectionRequirement));
			return false;
		}
		if (!1226.10())
		{
			1226.107();
		}
		int 2 = 0;
		if (int.TryParse(1, out 2))
		{
			1226.4(2, false, false);
			return true;
		}
		try
		{
			if (1.IndexOf('(') <= 0)
			{
				string[] array = 1.Replace("-", string.Empty).Trim().Split(new char[]
				{
					':'
				});
				int num = 0;
				int i = array.Length;
				int num2;
				int num3;
				if (i != 2)
				{
					if (i != 3)
					{
						return false;
					}
					num2 = int.Parse(array[0]);
					num3 = int.Parse(array[1]);
					num = int.Parse(array[2]);
				}
				else
				{
					num2 = int.Parse(array[0]);
					num3 = int.Parse(array[1]);
				}
				1226.4(num2 * 60000 + num3 * 1000 + num, false, false);
				return true;
			}
			2263.2269 3 = new 2263.2269();
			3.1 = int.Parse(1.Substring(0, 2)) * 60000 + int.Parse(1.Substring(3, 2)) * 1000 + int.Parse(1.Substring(6, 3)) - 20;
			int num4 = 2263.4.7.34.FindIndex(new Predicate<2034>(3.1));
			if (num4 < 0 || 1.IndexOf(')') < 0)
			{
				1226.4(3.1 + 20, false, false);
				return true;
			}
			1226.4(2263.4.7.34[num4].1, false, false);
			2263.4.31();
			2263.4.27(2335.Compose);
			string[] array2 = 1.Substring(11, 1.IndexOf(')') - 11).Split(new char[]
			{
				','
			});
			if (array2.Length != 0 && array2[0].IndexOf('|') > 0)
			{
				string[] array3 = array2;
				for (int j = 0; j < array3.Length; j++)
				{
					string[] array4 = array3[j].Split(new char[]
					{
						'|'
					});
					int num5 = 0;
					int num6 = 0;
					int.TryParse(array4[0], out num5);
					int.TryParse(array4[1], out num6);
					for (int k = num4; k < 2263.4.7.35; k++)
					{
						2034 4 = 2263.4.7.34[k];
						if (4.1 == num5 && 2263.4.7.41.49(4.8, false) == num6)
						{
							2263.4.74.SelectObject(4);
						}
					}
				}
			}
			else
			{
				List<int> list = new List<int>();
				foreach (string s in array2)
				{
					list.Add(int.Parse(s));
				}
				if (list.Count == 1)
				{
					2263.4.74.SelectObject(2263.4.7.34[num4]);
				}
				else
				{
					for (int l = num4; l < 2263.4.7.35; l++)
					{
						if (2263.4.7.34[l].GetComboNumber() == list[0])
						{
							2263.4.74.SelectObject(2263.4.7.34[l]);
							list.RemoveAt(0);
						}
						if (list.Count == 0)
						{
							break;
						}
					}
				}
			}
		}
		catch (Exception)
		{
			1763.4(1568.1(2679.Editor_FileOperations_InvalidFormat));
			return false;
		}
		return true;
	}

	// Token: 0x06002B70 RID: 11120 RVA: 0x000ED86C File Offset: 0x000EBA6C
	internal static double 91(double 1, double 2, double 3)
	{
		return 1 * 2 * 3 / 1000.0;
	}

	// Token: 0x06002B71 RID: 11121 RVA: 0x000ED87D File Offset: 0x000EBA7D
	internal static double 92(double 1, double 2, double 3)
	{
		if (2 == 0.0 || 3 == 0.0)
		{
			return 0.0;
		}
		return 1 * 1000.0 / 3 / 2;
	}

	// Token: 0x06002B72 RID: 11122 RVA: 0x000ED8B0 File Offset: 0x000EBAB0
	private void 93()
	{
		this.65.15(false);
		this.61 = (int)(6000f / this.98());
		this.62 = 1226.16 - this.61 / 2;
		this.63 = 1226.16 + this.61 / 2;
		this.73.UpdateTimelineObjects();
	}

	// Token: 0x06002B73 RID: 11123 RVA: 0x000ED910 File Offset: 0x000EBB10
	private void 94(object 1, EventArgs 2)
	{
		1262 3 = this.7.21;
		float num;
		this.99(num = 1052.19(this.98() + 0.1f, 0.1f, 8f));
		3.86 = num;
	}

	// Token: 0x06002B74 RID: 11124 RVA: 0x000ED954 File Offset: 0x000EBB54
	private void 95(object 1, EventArgs 2)
	{
		1262 3 = this.7.21;
		float num;
		this.99(num = 1052.19(this.98() - 0.1f, 0.1f, 8f));
		3.86 = num;
	}

	// Token: 0x06002B75 RID: 11125 RVA: 0x000ED995 File Offset: 0x000EBB95
	internal int 96()
	{
		return this.58;
	}

	// Token: 0x06002B76 RID: 11126 RVA: 0x000ED99D File Offset: 0x000EBB9D
	internal void 97(int 1)
	{
		this.58 = 1052.18(1, 1, 128);
	}

	// Token: 0x06002B77 RID: 11127 RVA: 0x000ED9B1 File Offset: 0x000EBBB1
	internal float 98()
	{
		return 2263.64;
	}

	// Token: 0x06002B78 RID: 11128 RVA: 0x000ED9B8 File Offset: 0x000EBBB8
	internal void 99(float 1)
	{
		2263.64 = 1;
		this.64();
	}

	// Token: 0x06002B79 RID: 11129 RVA: 0x000ED9C8 File Offset: 0x000EBBC8
	private void 100()
	{
		if (1226.75() && this.96() > 0)
		{
			this.60 = 1226.76() / (double)this.96();
		}
		else
		{
			this.60 = 250.0;
		}
		this.73.DrawTimelineContent();
		this.65.22();
		1662.20.2();
		if (this.26 != 2335.Timing && 1226.81() != null)
		{
			int num = this.7.21.78;
			if (num >= 0 && num >= this.62 && num <= this.63)
			{
				float <<EMPTY_NAME>> = this.102((double)num);
				1662.20.3(new 208(<<EMPTY_NAME>>, (float)this.66.GetTop()), 2263.22);
				1662.20.3(new 208(<<EMPTY_NAME>>, (float)this.66.GetBottom()), 2263.22);
			}
			foreach (1259 2 in 1226.81())
			{
				if (2.3 >= (double)this.62 && 2.3 <= (double)this.63)
				{
					198 3 = 2.1() ? new 198(180, 20, 20, 150) : new 198(156, byte.MaxValue, 0, 150);
					float 4 = this.102(2.3);
					1662.20.3(new 208(4, (float)this.66.GetTop()), 3);
					1662.20.3(new 208(4, (float)this.66.GetBottom()), 3);
				}
			}
		}
		1662.20.3(new 208((float)this.66.GetLeft(), (float)this.66.GetBottom()), this.54);
		1662.20.3(new 208((float)this.66.GetRight(), (float)this.66.GetBottom()), this.54);
		1662.20.3(new 208((float)(this.66.GetLeft() + this.66.Width / 2 - 1), (float)this.66.GetTop()), this.54);
		1662.20.3(new 208((float)(this.66.GetLeft() + this.66.Width / 2 - 1), (float)this.66.GetBottom()), this.54);
		1662.20.3(new 208((float)(this.66.GetLeft() + this.66.Width / 2 + 1), (float)this.66.GetTop()), this.54);
		1662.20.3(new 208((float)(this.66.GetLeft() + this.66.Width / 2 + 1), (float)this.66.GetBottom()), this.54);
		int num2;
		double num3;
		if (1226.75())
		{
			num2 = (int)Math.Floor(((double)this.62 - 1226.79()) / 1226.76());
			num3 = (double)num2 * 1226.76() + 1226.79();
		}
		else
		{
			num2 = 0;
			num3 = (double)this.62 / this.60;
		}
		int num4 = (int)1226.84();
		if (this.60 > 1E-05)
		{
			int num5 = 0;
			for (double num6 = num3; num6 < (double)this.63; num6 += this.60)
			{
				int num7 = num5 % this.96();
				198 5 = (num7 == 0) ? this.51 : ((num7 * 2 % this.96() == 0) ? this.49 : ((num7 * 3 % this.96() == 0) ? this.50 : ((num7 * 4 % this.96() == 0) ? this.47 : ((num7 * 5 % this.96() == 0) ? this.48 : ((num7 * 6 % this.96() == 0) ? this.52 : ((num7 * 7 % this.96() == 0) ? this.48 : ((num7 * 8 % this.96() == 0) ? this.48 : ((num7 * 9 % this.96() != 0) ? this.53 : this.48))))))));
				int bottom = this.66.GetBottom();
				if (num6 >= (double)this.62)
				{
					if (num5 % this.96() == 0)
					{
						1662.20.3(new 208(this.102(num6), (float)(this.66.GetBottom() - this.67 * ((num2 % num4 != 0) ? 1 : 2))), 5);
						1662.20.3(new 208(this.102(num6), (float)bottom), 5);
					}
					else
					{
						1662.20.3(new 208(this.102(num6), (float)(this.66.GetBottom() - this.67 / 8 * 7)), 5);
						1662.20.3(new 208(this.102(num6), (float)this.66.GetBottom()), 5);
					}
				}
				if (num5 % this.96() == 0)
				{
					num2++;
				}
				num5++;
			}
		}
		198 6 = new 198(58, 110, 170, 240);
		foreach (int num8 in this.7.25)
		{
			if (num8 >= this.62 && num8 <= this.63)
			{
				1662.20.3(new 208(this.102((double)num8), (float)this.66.GetTop()), 6);
				1662.20.3(new 208(this.102((double)num8), (float)this.66.GetBottom()), 6);
			}
		}
		1662.20.4();
		this.73.DrawTimelineOverlay();
	}

	// Token: 0x06002B7A RID: 11130 RVA: 0x000EDFF8 File Offset: 0x000EC1F8
	internal float 101(double 1)
	{
		return (float)Math.Min(Math.Max((double)this.56 + (1 - (double)this.62) / (double)this.61 * (double)this.68, (double)this.56), (double)(this.56 + this.68));
	}

	// Token: 0x06002B7B RID: 11131 RVA: 0x000EE048 File Offset: 0x000EC248
	internal float 102(double 1)
	{
		return (float)Math.Min(Math.Max((double)this.66.GetLeft() + (1 - (double)this.62) / (double)this.61 * (double)this.66.Width, (double)this.66.GetLeft()), (double)this.66.GetRight());
	}

	// Token: 0x06002B7C RID: 11132 RVA: 0x000EE0A3 File Offset: 0x000EC2A3
	internal int 103(int 1)
	{
		return (int)((double)this.62 + (double)(1 - this.66.GetLeft()) / (double)this.66.Width * (double)this.61);
	}

	// Token: 0x06002B7D RID: 11133 RVA: 0x000EE0D1 File Offset: 0x000EC2D1
	internal int 104()
	{
		if (!1226.75())
		{
			return 1226.16;
		}
		return this.76.27((double)1226.16);
	}

	// Token: 0x04001F7B RID: 8059
	internal static 2263 4;

	// Token: 0x04001F7C RID: 8060
	private bool 5;

	// Token: 0x04001F7D RID: 8061
	internal 2648 6;

	// Token: 0x04001F7E RID: 8062
	internal 2039 7;

	// Token: 0x04001F7F RID: 8063
	internal 2458 8;

	// Token: 0x04001F80 RID: 8064
	internal bool 9;

	// Token: 0x04001F81 RID: 8065
	internal bool 10;

	// Token: 0x04001F82 RID: 8066
	private 1433 11;

	// Token: 0x04001F83 RID: 8067
	private 1433 12;

	// Token: 0x04001F84 RID: 8068
	private 1433 13;

	// Token: 0x04001F85 RID: 8069
	private 1433 14;

	// Token: 0x04001F86 RID: 8070
	internal 2147 15;

	// Token: 0x04001F87 RID: 8071
	private static 198 16 = new 198(byte.MaxValue, 146, 18, 140);

	// Token: 0x04001F88 RID: 8072
	private static 198 17 = new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue, 140);

	// Token: 0x04001F89 RID: 8073
	private static 198 18 = new 198(58, 110, 170, 240);

	// Token: 0x04001F8A RID: 8074
	private static 198 19 = new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue, 128);

	// Token: 0x04001F8B RID: 8075
	private static 198 20 = new 198(180, 20, 20, 150);

	// Token: 0x04001F8C RID: 8076
	private static 198 21 = new 198(156, byte.MaxValue, 0, 100);

	// Token: 0x04001F8D RID: 8077
	private static 198 22 = new 198(byte.MaxValue, 247, 17, 150);

	// Token: 0x04001F8E RID: 8078
	private static 198 23 = new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue, 25);

	// Token: 0x04001F8F RID: 8079
	private static 198 24 = new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue, 75);

	// Token: 0x04001F90 RID: 8080
	private static 207 25;

	// Token: 0x04001F91 RID: 8081
	internal 2335 26;

	// Token: 0x04001F92 RID: 8082
	private bool 27;

	// Token: 0x04001F93 RID: 8083
	private 1433 28;

	// Token: 0x04001F94 RID: 8084
	private 1433 29;

	// Token: 0x04001F95 RID: 8085
	private bool 30;

	// Token: 0x04001F96 RID: 8086
	internal bool 31;

	// Token: 0x04001F97 RID: 8087
	internal bool 32 = true;

	// Token: 0x04001F98 RID: 8088
	private 1433 33;

	// Token: 0x04001F99 RID: 8089
	private 1433 34;

	// Token: 0x04001F9A RID: 8090
	private 207 35;

	// Token: 0x04001F9B RID: 8091
	private 1433 36;

	// Token: 0x04001F9C RID: 8092
	private 1452 37;

	// Token: 0x04001F9D RID: 8093
	private 1452 38;

	// Token: 0x04001F9E RID: 8094
	private 1433 39;

	// Token: 0x04001F9F RID: 8095
	internal 1436 40;

	// Token: 0x04001FA0 RID: 8096
	internal 1436 41;

	// Token: 0x04001FA1 RID: 8097
	internal 1436 42;

	// Token: 0x04001FA2 RID: 8098
	internal 2303 43;

	// Token: 0x04001FA3 RID: 8099
	private static bool 44;

	// Token: 0x04001FA4 RID: 8100
	private 2308 45;

	// Token: 0x04001FA5 RID: 8101
	private bool 46;

	// Token: 0x04001FA6 RID: 8102
	internal readonly 198 47 = new 198(50, 128, byte.MaxValue, 225);

	// Token: 0x04001FA7 RID: 8103
	internal readonly 198 48 = new 198(byte.MaxValue, byte.MaxValue, 0, 225);

	// Token: 0x04001FA8 RID: 8104
	internal readonly 198 49 = new 198(byte.MaxValue, 0, 0, 225);

	// Token: 0x04001FA9 RID: 8105
	internal readonly 198 50 = new 198(200, 0, 200, 225);

	// Token: 0x04001FAA RID: 8106
	internal readonly 198 51 = new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue, 220);

	// Token: 0x04001FAB RID: 8107
	internal readonly 198 52 = new 198(144, 64, 144, 225);

	// Token: 0x04001FAC RID: 8108
	internal readonly 198 53 = new 198(160, 160, 160, 225);

	// Token: 0x04001FAD RID: 8109
	internal readonly 198 54 = new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);

	// Token: 0x04001FAE RID: 8110
	internal readonly int 55 = 35;

	// Token: 0x04001FAF RID: 8111
	internal readonly int 56 = 20;

	// Token: 0x04001FB0 RID: 8112
	internal readonly int 57 = 25;

	// Token: 0x04001FB1 RID: 8113
	private int 58 = 1;

	// Token: 0x04001FB2 RID: 8114
	internal 2329 59;

	// Token: 0x04001FB3 RID: 8115
	internal double 60 = 250.0;

	// Token: 0x04001FB4 RID: 8116
	internal int 61;

	// Token: 0x04001FB5 RID: 8117
	internal int 62;

	// Token: 0x04001FB6 RID: 8118
	internal int 63;

	// Token: 0x04001FB7 RID: 8119
	private static float 64 = 1f;

	// Token: 0x04001FB8 RID: 8120
	internal 1436 65;

	// Token: 0x04001FB9 RID: 8121
	internal 207 66;

	// Token: 0x04001FBA RID: 8122
	internal int 67 = 10;

	// Token: 0x04001FBB RID: 8123
	internal int 68 = 1662.70.1() - 220;

	// Token: 0x04001FBC RID: 8124
	internal bool 69;

	// Token: 0x04001FBD RID: 8125
	internal bool 70;

	// Token: 0x04001FBE RID: 8126
	internal bool 71;

	// Token: 0x04001FBF RID: 8127
	internal 2339 72;

	// Token: 0x04001FC0 RID: 8128
	private 2336 73;

	// Token: 0x04001FC1 RID: 8129
	internal 2255 74;

	// Token: 0x04001FC2 RID: 8130
	internal 2298 75;

	// Token: 0x04001FC3 RID: 8131
	internal 2366 76;

	// Token: 0x04001FC4 RID: 8132
	private 2316 77;

	// Token: 0x04001FC5 RID: 8133
	private 2319 78;

	// Token: 0x04001FC6 RID: 8134
	private 2315 79;

	// Token: 0x04001FC7 RID: 8135
	private 2306 80;

	// Token: 0x04001FC8 RID: 8136
	private 2317 81;

	// Token: 0x04001FC9 RID: 8137
	private static 2335 82;

	// Token: 0x04001FCA RID: 8138
	private readonly 198 83 = 198.White;

	// Token: 0x04001FCB RID: 8139
	private 2312 84;

	// Token: 0x04001FCC RID: 8140
	internal bool 85;

	// Token: 0x04001FCD RID: 8141
	internal bool 86;

	// Token: 0x04001FCE RID: 8142
	internal bool 87;

	// Token: 0x04001FCF RID: 8143
	internal int 88;

	// Token: 0x04001FD0 RID: 8144
	private bool isUndoCommitDeferred;

	// Token: 0x02000577 RID: 1399
	public sealed class 2266
	{
		// Token: 0x06002B82 RID: 11138 RVA: 0x000EE25C File Offset: 0x000EC45C
		internal bool 1(2275 1)
		{
			return 1.8 >= this.1;
		}

		// Token: 0x04001FD1 RID: 8145
		public int 1;
	}

	// Token: 0x02000578 RID: 1400
	public sealed class 2265
	{
		// Token: 0x04001FD2 RID: 8146
		public int 1;

		// Token: 0x04001FD3 RID: 8147
		public int 2;
	}

	// Token: 0x02000579 RID: 1401
	[Serializable]
	public sealed class 2267
	{
		// Token: 0x06002B85 RID: 11141 RVA: 0x000EE26F File Offset: 0x000EC46F
		internal void 1(bool 1)
		{
			if (1662.8 != null)
			{
				1662.8.65.Enabled = 1;
			}
		}

		// Token: 0x06002B86 RID: 11142 RVA: 0x000EE288 File Offset: 0x000EC488
		internal bool 2(1445 1)
		{
			return 1.14 == 1456.MovementX;
		}

		// Token: 0x06002B87 RID: 11143 RVA: 0x000EE288 File Offset: 0x000EC488
		internal bool 3(1445 1)
		{
			return 1.14 == 1456.MovementX;
		}

		// Token: 0x06002B88 RID: 11144 RVA: 0x000EE288 File Offset: 0x000EC488
		internal bool 4(1445 1)
		{
			return 1.14 == 1456.MovementX;
		}

		// Token: 0x06002B89 RID: 11145 RVA: 0x000EE297 File Offset: 0x000EC497
		internal void 5(2034 1)
		{
			1.StopHitSounds();
		}

		// Token: 0x06002B8A RID: 11146 RVA: 0x000EE29F File Offset: 0x000EC49F
		internal bool 6(1262 1)
		{
			return !1.26 && 1.42();
		}

		// Token: 0x06002B8B RID: 11147 RVA: 0x000EE2B1 File Offset: 0x000EC4B1
		internal bool 7(1262 1)
		{
			return 1.26;
		}

		// Token: 0x06002B8C RID: 11148 RVA: 0x000EE2B9 File Offset: 0x000EC4B9
		internal void 8(1262 1)
		{
			1272.12(1);
		}

		// Token: 0x06002B8D RID: 11149 RVA: 0x000EE2C2 File Offset: 0x000EC4C2
		internal bool 9(2034 1)
		{
			return 1.2 > 1226.16;
		}

		// Token: 0x06002B8E RID: 11150 RVA: 0x000EE2D1 File Offset: 0x000EC4D1
		internal bool 10(2647 1)
		{
			return 1.10 == 2635.Sprite;
		}

		// Token: 0x04001FD4 RID: 8148
		public static readonly 2263.2267 Instance = new 2263.2267();

		// Token: 0x04001FD5 RID: 8149
		public static 1184 boolDelegate;

		// Token: 0x04001FD6 RID: 8150
		public static 1184 boolDelegate2;

		// Token: 0x04001FD7 RID: 8151
		public static Predicate<1445> predicate;

		// Token: 0x04001FD8 RID: 8152
		public static Predicate<1445> predicate2;

		// Token: 0x04001FD9 RID: 8153
		public static Predicate<1445> predicate3;

		// Token: 0x04001FDA RID: 8154
		public static Predicate<1445> predicate4;

		// Token: 0x04001FDB RID: 8155
		public static Action<2034> action;

		// Token: 0x04001FDC RID: 8156
		public static Predicate<1262> predicate5;

		// Token: 0x04001FDD RID: 8157
		public static Predicate<1262> predicate6;

		// Token: 0x04001FDE RID: 8158
		public static Action<1262> action2;

		// Token: 0x04001FDF RID: 8159
		public static Predicate<2034> predicate7;

		// Token: 0x04001FE0 RID: 8160
		public static Predicate<2647> predicate8;

		// Token: 0x04001FE1 RID: 8161
		public static Predicate<2647> predicate9;
	}

	// Token: 0x0200057A RID: 1402
	public sealed class 2264
	{
		// Token: 0x06002B91 RID: 11153 RVA: 0x000EE2E8 File Offset: 0x000EC4E8
		internal bool 1(1262 1)
		{
			return this.1.37 == 1.37;
		}

		// Token: 0x04001FE2 RID: 8162
		public 1262 1;
	}

	// Token: 0x0200057B RID: 1403
	public sealed class 2268
	{
		// Token: 0x06002B93 RID: 11155 RVA: 0x000EE300 File Offset: 0x000EC500
		internal bool 1(2647 1)
		{
			return 1.3 == this.1;
		}

		// Token: 0x04001FE3 RID: 8163
		public string 1;
	}

	// Token: 0x0200057C RID: 1404
	public sealed class 2269
	{
		// Token: 0x06002B95 RID: 11157 RVA: 0x000EE313 File Offset: 0x000EC513
		internal bool 1(2034 1)
		{
			return 1.1 > this.1;
		}

		// Token: 0x04001FE4 RID: 8164
		public int 1;
	}
}
