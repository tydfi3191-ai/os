using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

// Token: 0x0200076A RID: 1898
public sealed class 2011 : IEnumerable<2011>, IEnumerable, IDisposable
{
	// Token: 0x060037BD RID: 14269 RVA: 0x0015D45C File Offset: 0x0015B65C
	internal 2011(1992 1, bool 2 = false, float 3 = 0f, float 4 = 480f, float 5 = float.NaN, float 6 = 1f, int 7 = 0, int 8 = 0)
	{
		this.12(2);
		this.25(4);
		this.4 = 1;
		this.2 = 7;
		this.2(8);
		if (!2)
		{
			this.5 = new 1436(true);
			this.6 = new 1436(true);
			this.7 = new 1436(true);
			this.8 = new 1436(true);
			this.11 = new 1433(this.4.19("StageHint", "mania-stage-hint", this.8()), (1376)6, 1065.CentreLeft, (1044)1, new 208(0f, this.36()), 0.62f, true, 198.White, null);
			this.11.16 = 0.9f;
			this.11.20 = new 208(0f, 0.9f);
			this.11.15 = 1.6026f;
			this.11.43(this.32());
			this.5.12(this.11);
			1433 9 = new 1433(this.4.19("StageLeft", "mania-stage-left", this.8()), (1376)6, 1065.TopRight, (1044)1, new 208(0.05f, this.26()), 0.8f, true, 198.White, null);
			9.20 = new 208(this.37(), this.24() / (float)9.38 * 1.6f);
			this.6.12(9);
			this.10 = new 1433(this.4.19("StageRight", "mania-stage-right", this.8()), (1376)6, 1065.TopLeft, (1044)1, new 208(0.05f, this.26()), 0.8f, true, 198.White, null);
			this.10.20 = new 208(this.37(), this.24() / (float)this.10.38 * 1.6f);
			this.6.12(this.10);
			1381[] array = this.4.20("StageBottom", "mania-stage-bottom", this.8());
			if (array != null && array.Length != 0)
			{
				this.12 = new 1351(array, (1376)6, this.57(1065.BottomCentre), (1044)1, new 208(0f, this.33()), 0.94f, true, 198.White);
				this.12.53(16.66666603088379);
				this.12.15 = 1.6f;
				this.7.12(this.12);
			}
			if (this.4.JudgementLine)
			{
				this.13 = new 1433(1662.34, (1376)6, this.57(1065.TopLeft), (1044)1, new 208(0f, this.36()), 0.62f, true, this.4.18("JudgementLine"), null);
				this.13.16 = 0.9f;
				this.13.20 = new 208(0f, 0.7f);
				this.13.15 = 1.6026f;
				this.5.12(this.13);
			}
			9 = new 1433(1455.2("mania-stage-light", (1416)1, null), (1376)6, 1065.BottomRight, (1044)1, new 208(0f, this.26()), 0.5f, true, 198.TransparentWhite, null);
			9.14 = -1.5707964f;
			9.20 = new 208(this.24() / (float)9.39, 0.27f) * 1.6f;
			this.6.12(9);
			this.14 = new 1433(1455.2("mania-stage-light", (1416)1, null), (1376)6, 1065.BottomLeft, (1044)1, new 208(0f, this.26()), 0.5f, true, 198.TransparentWhite, null);
			this.14.14 = 1.5707964f;
			this.14.20 = new 208(this.24() / (float)this.14.39, 0.27f) * 1.6f;
			this.6.12(this.14);
			this.15 = new 1351(null, (1376)6, 1065.Centre, (1044)1, new 208(0f, this.47((float)this.4.ScorePosition)), 0.998f, true, 198.White);
			this.15.53(50.0);
			this.7.12(this.15);
			foreach (string text in new string[]
			{
				"0",
				"50",
				"100",
				"200",
				"300",
				"300g"
			})
			{
				this.18.Add(text, this.4.20("Hit" + text, "mania-hit" + text, this.8()));
			}
			if (this.10())
			{
				2023 10 = 2486.88.8;
				2023 11 = 2023.Hidden;
				bool flag = (10 & 11) > 2023.None;
				1381 12 = 1455.2("mania-stage-hidden", (1416)1, null);
				if (12 == null)
				{
					1662.SetMode(1677.Menu, false);
				}
				if (this.32())
				{
					this.16 = new 1433(1662.34, (1376)6, (!flag) ? 1065.BottomLeft : 1065.TopLeft, (1044)1, new 208(0f, flag ? this.36() : 480f), 0.81f, true, 198.Black, null);
					this.17 = new 1433(12, (1376)6, (!flag) ? 1065.BottomLeft : 1065.TopLeft, (1044)1, new 208(0f, flag ? (this.36() + 100f) : 200f), 0.81f, true, 198.TransparentWhite, null);
				}
				else
				{
					this.16 = new 1433(1662.34, (1376)6, flag ? 1065.BottomLeft : 1065.TopLeft, (1044)1, new 208(0f, flag ? this.36() : 0f), 0.81f, true, 198.Black, null);
					this.17 = new 1433(12, (1376)6, flag ? 1065.BottomLeft : 1065.TopLeft, (1044)1, new 208(0f, flag ? (this.36() - 100f) : 100f), 0.81f, true, 198.TransparentWhite, null);
				}
				this.7.12(this.16);
				this.7.12(this.17);
			}
		}
		this.29(float.IsNaN(5) ? this.4.ColumnStart : 5);
		this.27(3);
		if (!2 && 8 == 0)
		{
			float num = Math.Min(this.28(), (float)1662.70.1() - this.4.ColumnRight);
			float num2 = Math.Min(this.4.ColumnRight, (float)1662.70.1() - this.28());
			this.29(num);
			float num3 = 0f;
			for (int j = 0; j < this.4.Columns; j++)
			{
				num3 += this.4.ColumnWidth[j] + ((j > 0) ? this.4.ColumnSpacing[j - 1] : 0f);
			}
			num3 += ((this.4.14() && this.46() != -1) ? this.4.StageSeparation : 0f);
			float num4 = this.28() + num3 + num2;
			float num5 = Math.Max(0f, num4 - (float)1662.70.1());
			6 = (num3 - num5) / num3;
		}
		this.21 = 6;
		for (int k = 8; k < 8 + this.45(); k++)
		{
			this.19.Add(new 1995(this, k, 6));
		}
		if (!2)
		{
			this.8.27(new 1058(this.28(), this.26(), this.20, this.24()));
			this.8.16 = true;
		}
		if (!2)
		{
			this.11.20.X = this.20 / (float)this.11.39;
			1433 13 = this.10;
			13.17.X = 13.17.X + this.20;
			if (this.12 != null)
			{
				1351 14 = this.12;
				14.17.X = 14.17.X + this.20 / 2f;
			}
			if (this.13 != null)
			{
				this.13.20.X = this.20;
			}
			1433 15 = this.14;
			15.17.X = 15.17.X + this.20;
			1351 16 = this.15;
			16.17.X = 16.17.X + this.20 / 2f;
			if (2630.5.Version >= 2.4 || this.37() < 1f)
			{
				this.15.20 = 208.One * this.39();
			}
			if (this.10())
			{
				2023 17 = 2486.88.8;
				2023 18 = 2023.Hidden;
				bool flag2 = (17 & 18) > 2023.None;
				this.16.20 = new 208(this.20 * 1.6f, 160f);
				this.16.16 = 0f;
				this.17.20 = new 208(this.20 * 1.6f, 0.72f);
				if ((!flag2 && !this.32()) || (flag2 && this.32()))
				{
					this.17.43(true);
				}
				this.17.16 = 0f;
			}
			if (this.46() == -1)
			{
				this.9 = new 2003(this);
			}
		}
		if (this.46() != -1)
		{
			5 = this.28() + this.20 + this.4.StageSeparation * 6;
			this.5(new 2011(this.4, 2, 3, 4, 5, 6, 7 + 1, 8 + this.45()));
			this.19.AddRange(this.4().19);
			this.9 = this.4().9;
		}
		this.14();
	}

	// Token: 0x060037BE RID: 14270 RVA: 0x0015DECC File Offset: 0x0015C0CC
	internal 2011(2039 1) : this(new 1992(2011.53(1.21, 1.22)), true, 0f, 480f, float.NaN, 1f, 0, 0)
	{
	}

	// Token: 0x060037BF RID: 14271 RVA: 0x0015DF11 File Offset: 0x0015C111
	static 2011()
	{
		2011.54();
	}

	// Token: 0x060037C0 RID: 14272 RVA: 0x0015DF18 File Offset: 0x0015C118
	internal int 1()
	{
		return this.1;
	}

	// Token: 0x060037C1 RID: 14273 RVA: 0x0015DF20 File Offset: 0x0015C120
	private void 2(int 1)
	{
		this.1 = 1;
	}

	// Token: 0x060037C2 RID: 14274 RVA: 0x0015DF29 File Offset: 0x0015C129
	private int 3()
	{
		return this.4.Columns - this.1();
	}

	// Token: 0x060037C3 RID: 14275 RVA: 0x0015DF3D File Offset: 0x0015C13D
	internal 2011 4()
	{
		return this.3;
	}

	// Token: 0x060037C4 RID: 14276 RVA: 0x0015DF45 File Offset: 0x0015C145
	private void 5(2011 1)
	{
		this.3 = 1;
	}

	// Token: 0x060037C5 RID: 14277 RVA: 0x0015DF4E File Offset: 0x0015C14E
	internal 2005 6()
	{
		return 2006.3(this.4.Columns, this.4.14() ? 2008.Split : 2008.Normal);
	}

	// Token: 0x060037C6 RID: 14278 RVA: 0x0015DF71 File Offset: 0x0015C171
	internal bool 7()
	{
		return this.22;
	}

	// Token: 0x060037C7 RID: 14279 RVA: 0x0015DF79 File Offset: 0x0015C179
	internal 1416 8()
	{
		if (1272.5().3() != 2147.OsuMania)
		{
			return (1416)3;
		}
		return (1416)7;
	}

	// Token: 0x060037C8 RID: 14280 RVA: 0x0015DF8C File Offset: 0x0015C18C
	internal 1991 9()
	{
		if (!this.41())
		{
			return 1991.None;
		}
		if (this.2 % 2 == 0)
		{
			return this.4.SpecialStyle;
		}
		if (this.4.SpecialStyle == 1991.Left)
		{
			return 1991.Right;
		}
		if (this.4.SpecialStyle == 1991.Right)
		{
			return 1991.Left;
		}
		return 1991.None;
	}

	// Token: 0x060037C9 RID: 14281 RVA: 0x0015DFDC File Offset: 0x0015C1DC
	private bool 10()
	{
		if (2486.88 != null)
		{
			2023 <<EMPTY_NAME>> = 2486.88.8;
			2023 2 = 2023.Hidden | 2023.FadeIn;
			return (<<EMPTY_NAME>> & 2) > 2023.None;
		}
		return false;
	}

	// Token: 0x060037CA RID: 14282 RVA: 0x0015E00C File Offset: 0x0015C20C
	internal bool 11()
	{
		return this.23;
	}

	// Token: 0x060037CB RID: 14283 RVA: 0x0015E014 File Offset: 0x0015C214
	private void 12(bool 1)
	{
		this.23 = 1;
	}

	// Token: 0x060037CC RID: 14284 RVA: 0x0015E01D File Offset: 0x0015C21D
	private void 13(bool 1)
	{
		this.24 = 1;
	}

	// Token: 0x060037CD RID: 14285 RVA: 0x0015E028 File Offset: 0x0015C228
	private void 14()
	{
		int num = Math.Min(this.2, 1);
		int num2 = this.45();
		bool flag = this.41() && this.9() > 1991.None;
		2004 <<EMPTY_NAME>> = this.6().3();
		if (<<EMPTY_NAME>> != null)
		{
			foreach (1995 2 in this.19)
			{
				2.17(<<EMPTY_NAME>>[2, (2007)0]);
			}
			if (flag)
			{
				this.19[this.44()].19(<<EMPTY_NAME>>[num, (2007)1]);
			}
			return;
		}
		int num3 = 0;
		if (flag)
		{
			num2--;
			num3 = ((this.44() == 0) ? 1 : 0);
			this.19[this.44()].17(1548.6[num]);
			this.19[this.44()].19(1548.7[num]);
		}
		int num4 = Math.Max(0, 1548.4[num] - num2 / 2);
		bool flag2 = num2 % 2 == 0 && num2 < 10;
		for (int i = 0; i < num2; i++)
		{
			if (flag2 && (num4 == 1548.4[0] || num4 == 1548.4[1]))
			{
				num4++;
			}
			this.19[i + num3].17(1548.5[num4++]);
		}
	}

	// Token: 0x060037CE RID: 14286 RVA: 0x0015E1A8 File Offset: 0x0015C3A8
	internal void 15()
	{
		foreach (2011 <<EMPTY_NAME>> in this)
		{
			<<EMPTY_NAME>>.14();
		}
	}

	// Token: 0x060037CF RID: 14287 RVA: 0x0015E1F0 File Offset: 0x0015C3F0
	internal void 16(2004 1)
	{
		if (1 == null)
		{
			return;
		}
		foreach (2011 2 in this)
		{
			foreach (1995 3 in 2.19)
			{
				1[3, (2007)0] = 3.16();
			}
			if (2.41() && 2.9() != 1991.None)
			{
				1[Math.Min(2.2, 1), (2007)1] = 2.19[2.44()].18();
			}
		}
	}

	// Token: 0x060037D0 RID: 14288 RVA: 0x0015E2C4 File Offset: 0x0015C4C4
	private 1381[] 17(2149 1)
	{
		if (1 <= (2149)33554432)
		{
			if (1 == (2149)16777216)
			{
				return this.18["50"];
			}
			if (1 == (2149)33554432)
			{
				return this.18["100"];
			}
		}
		else
		{
			if (1 == (2149)67108864)
			{
				return this.18["200"];
			}
			if (1 == (2149)134217728)
			{
				return this.18["300"];
			}
			if (1 == (2149)268435456)
			{
				return this.18["300g"];
			}
		}
		return this.18["0"];
	}

	// Token: 0x060037D1 RID: 14289 RVA: 0x0015E374 File Offset: 0x0015C574
	internal void 18(2149 1)
	{
		if (1 != (2149)(-1048576))
		{
			this.15.55(this.17(1));
			this.15.59();
			this.15.3.Clear();
			this.15.14 = 0f;
			float num = 1f;
			this.15.3.Add(new 1445(1456.Fade, this.15.16, 1f, 1226.16, 1226.16 + 20, (1046)1));
			if (1 == (2149)(-65536))
			{
				this.15.3.Add(new 1445(1456.Scale, num * 1.2f, num, 1226.16, 1226.16 + 100, (1046)1));
				this.15.3.Add(new 1445(1456.Rotation, 0f, 1196.7(-0.1f, 0.1f), 1226.16, 1226.16 + 100, (1046)1));
			}
			else
			{
				this.15.3.Add(new 1445(1456.Scale, num * 0.8f, num, 1226.16, 1226.16 + 40, (1046)0));
				this.15.3.Add(new 1445(1456.Scale, num, num * 0.7f, 1226.16, 1226.16 + 80, (1046)0));
				this.15.3.Add(new 1445(1456.Scale, num * 0.7f, num * 0.4f, 1226.16 + 180, 1226.16 + 220, (1046)2));
			}
			this.15.3.Add(new 1445(1456.Fade, 1f, 0f, 1226.16 + 180, 1226.16 + 220, (1046)2));
		}
	}

	// Token: 0x060037D2 RID: 14290 RVA: 0x0015E540 File Offset: 0x0015C740
	internal void 19()
	{
		foreach (2011 <<EMPTY_NAME>> in this)
		{
			<<EMPTY_NAME>>.6.22();
		}
		foreach (2011 2 in this)
		{
			2.5.22();
		}
	}

	// Token: 0x060037D3 RID: 14291 RVA: 0x0015E5C8 File Offset: 0x0015C7C8
	internal void 20()
	{
		foreach (2011 <<EMPTY_NAME>> in this)
		{
			<<EMPTY_NAME>>.8.22();
			<<EMPTY_NAME>>.7.22();
		}
	}

	// Token: 0x060037D4 RID: 14292 RVA: 0x0015E620 File Offset: 0x0015C820
	internal void 21()
	{
		foreach (2011 <<EMPTY_NAME>> in this)
		{
			<<EMPTY_NAME>>.56();
		}
		if (!1535.1())
		{
			this.19.ForEach(delegate(1995 1)
			{
				1.25();
			});
		}
	}

	// Token: 0x060037D5 RID: 14293 RVA: 0x0015E698 File Offset: 0x0015C898
	public void Dispose()
	{
		this.22(true);
		GC.SuppressFinalize(this);
	}

	// Token: 0x060037D6 RID: 14294 RVA: 0x0015E6A8 File Offset: 0x0015C8A8
	protected void 22(bool 1)
	{
		if (1)
		{
			if (!this.11())
			{
				this.5.Dispose();
				this.6.Dispose();
				this.7.Dispose();
			}
			1436 2 = this.8;
			if (2 != null)
			{
				2.Dispose();
			}
			2011 3 = this.4();
			if (3 != null)
			{
				3.Dispose();
			}
			this.13(true);
		}
	}

	// Token: 0x060037D7 RID: 14295 RVA: 0x0015E70A File Offset: 0x0015C90A
	public IEnumerator<2011> GetEnumerator()
	{
		return new 2011.2012(0)
		{
			3 = this
		};
	}

	// Token: 0x060037D8 RID: 14296 RVA: 0x0015E719 File Offset: 0x0015C919
	private IEnumerator 23()
	{
		return this.GetEnumerator();
	}

	// Token: 0x060037D9 RID: 14297 RVA: 0x0015E721 File Offset: 0x0015C921
	IEnumerator IEnumerable.GetEnumerator()
	{
		return this.23();
	}

	// Token: 0x060037DA RID: 14298 RVA: 0x0015E729 File Offset: 0x0015C929
	internal float 24()
	{
		return this.25;
	}

	// Token: 0x060037DB RID: 14299 RVA: 0x0015E731 File Offset: 0x0015C931
	private void 25(float 1)
	{
		this.25 = 1;
	}

	// Token: 0x060037DC RID: 14300 RVA: 0x0015E73A File Offset: 0x0015C93A
	internal float 26()
	{
		return this.26;
	}

	// Token: 0x060037DD RID: 14301 RVA: 0x0015E744 File Offset: 0x0015C944
	internal void 27(float 1)
	{
		2011.2017 setTopClosure = new 2011.2017();
		setTopClosure.1 = this;
		setTopClosure.2 = 2;
		if (!this.11())
		{
			this.5.28.ForEach(new Action<1371>(setTopClosure.1));
			this.7.28.ForEach(delegate(1371 1)
			{
				1.17.Y = 1.17.Y - (setTopClosure.1.26 - setTopClosure.2);
			});
			this.6.28.ForEach(delegate(1371 1)
			{
				1.17.Y = 1.17.Y - (setTopClosure.1.26 - setTopClosure.2);
			});
			this.8.27(new 1058(this.28(), this.26(), this.20, this.24()));
		}
		this.26 = setTopClosure.2;
	}

	// Token: 0x060037DE RID: 14302 RVA: 0x0015E817 File Offset: 0x0015CA17
	internal float 28()
	{
		return this.27;
	}

	// Token: 0x060037DF RID: 14303 RVA: 0x0015E820 File Offset: 0x0015CA20
	internal void 29(float 1)
	{
		2011.2016 setLeftClosure = new 2011.2016();
		setLeftClosure.1 = this;
		setLeftClosure.2 = 2;
		if (!this.11())
		{
			this.5.28.ForEach(new Action<1371>(setLeftClosure.1));
			this.7.28.ForEach(new Action<1371>(setLeftClosure.2));
			this.6.28.ForEach(delegate(1371 1)
			{
				1.17.X = 1.17.X - (setLeftClosure.1.27 - setLeftClosure.2);
			});
			this.8.27(new 1058(this.28(), this.26(), this.20, this.24()));
		}
		this.27 = setLeftClosure.2;
	}

	// Token: 0x060037E0 RID: 14304 RVA: 0x0015E8F8 File Offset: 0x0015CAF8
	internal float 30()
	{
		return this.28() + this.20;
	}

	// Token: 0x060037E1 RID: 14305 RVA: 0x0015E907 File Offset: 0x0015CB07
	internal float 31()
	{
		return this.26() + this.24();
	}

	// Token: 0x060037E2 RID: 14306 RVA: 0x0015E916 File Offset: 0x0015CB16
	internal bool 32()
	{
		return this.4.UpsideDown;
	}

	// Token: 0x060037E3 RID: 14307 RVA: 0x0015E923 File Offset: 0x0015CB23
	internal float 33()
	{
		if (!this.32())
		{
			return this.31();
		}
		return this.26();
	}

	// Token: 0x060037E4 RID: 14308 RVA: 0x0015E93A File Offset: 0x0015CB3A
	internal float 34()
	{
		if (!this.11())
		{
			return this.5.5;
		}
		return 0f;
	}

	// Token: 0x060037E5 RID: 14309 RVA: 0x0015E958 File Offset: 0x0015CB58
	internal void 35(float 1)
	{
		if (!this.11())
		{
			1436 2 = this.6;
			1436 3 = this.7;
			1436 4 = this.5;
			this.8.5 = 1;
			4.5 = 1;
			3.5 = 1;
			2.5 = 1;
		}
		if (this.4() != null)
		{
			this.4().35(this.34());
		}
	}

	// Token: 0x060037E6 RID: 14310 RVA: 0x0015E9BC File Offset: 0x0015CBBC
	internal float 36()
	{
		return this.47((float)this.4.HitPosition);
	}

	// Token: 0x060037E7 RID: 14311 RVA: 0x0015E9D0 File Offset: 0x0015CBD0
	internal float 37()
	{
		return this.24() / 480f;
	}

	// Token: 0x060037E8 RID: 14312 RVA: 0x0015E9E0 File Offset: 0x0015CBE0
	internal float 38()
	{
		2011.2014 <<EMPTY_NAME>> = new 2011.2014();
		if (this.4.Columns == 0)
		{
			return 0f;
		}
		<<EMPTY_NAME>>.1 = 0f;
		this.4.ColumnWidth.ForEach(new Action<float>(<<EMPTY_NAME>>.1));
		return <<EMPTY_NAME>>.1 * this.21 / (float)(30 * this.4.Columns);
	}

	// Token: 0x060037E9 RID: 14313 RVA: 0x0015EA4A File Offset: 0x0015CC4A
	internal float 39()
	{
		return Math.Min(this.38(), this.37());
	}

	// Token: 0x060037EA RID: 14314 RVA: 0x0015EA60 File Offset: 0x0015CC60
	internal float 40()
	{
		2011.2013 <<EMPTY_NAME>> = new 2011.2013();
		<<EMPTY_NAME>>.1 = float.MaxValue;
		this.4.ColumnWidth.ForEach(new Action<float>(<<EMPTY_NAME>>.1));
		return <<EMPTY_NAME>>.1 * this.21;
	}

	// Token: 0x060037EB RID: 14315 RVA: 0x0015EAA7 File Offset: 0x0015CCA7
	internal bool 41()
	{
		return this.45() > 4 && (this.45() & 1) == 0;
	}

	// Token: 0x060037EC RID: 14316 RVA: 0x0015EABF File Offset: 0x0015CCBF
	internal bool 42()
	{
		return this.41() && this.4 != null && this.9() == 1991.Right;
	}

	// Token: 0x060037ED RID: 14317 RVA: 0x0015EADC File Offset: 0x0015CCDC
	internal int 43()
	{
		if (this.19.Count != 8)
		{
			return this.1();
		}
		return this.1() + 1;
	}

	// Token: 0x060037EE RID: 14318 RVA: 0x0015EAFB File Offset: 0x0015CCFB
	internal int 44()
	{
		if (this.45() % 2 != 0)
		{
			return 2 + (this.45() - 5) / 2;
		}
		if (this.9() == 1991.None || !this.41())
		{
			return -1;
		}
		if (this.9() != 1991.Left)
		{
			return this.45() - 1;
		}
		return 0;
	}

	// Token: 0x060037EF RID: 14319 RVA: 0x0015EB39 File Offset: 0x0015CD39
	internal int 45()
	{
		if (!this.4.14() || this.2 > 0)
		{
			return this.3();
		}
		return (this.3() + 1) / 2;
	}

	// Token: 0x060037F0 RID: 14320 RVA: 0x0015EB62 File Offset: 0x0015CD62
	internal int 46()
	{
		if (!this.4.14() || this.2 > 0 || this.3() <= this.45())
		{
			return -1;
		}
		return this.3() - this.45();
	}

	// Token: 0x060037F1 RID: 14321 RVA: 0x0015EB97 File Offset: 0x0015CD97
	internal float 47(float 1)
	{
		1 = (this.32() ? (480f - 1) : 1);
		return this.26() + 1 * this.37();
	}

	// Token: 0x060037F2 RID: 14322 RVA: 0x0015EBBC File Offset: 0x0015CDBC
	internal 1058 48(float 1, float 2)
	{
		1 = this.47(1);
		2 = this.47(2);
		return 1058.1(this.28(), Math.Min(1, 2), this.28() + this.20, Math.Max(1, 2));
	}

	// Token: 0x060037F3 RID: 14323 RVA: 0x0015EBF8 File Offset: 0x0015CDF8
	internal int 49(208 1, bool 2)
	{
		if (2 && this.19.Count == 8)
		{
			return Math.Min((int)Math.Floor((double)(Math.Max(0f, 1.X) / 73.14286f)), 6) + 1;
		}
		float num = 512f / (float)this.19.Count;
		return Math.Min((int)Math.Floor((double)(1.X / num)), this.19.Count - 1);
	}

	// Token: 0x060037F4 RID: 14324 RVA: 0x0015EC70 File Offset: 0x0015CE70
	private static int 50(1262 1)
	{
		float num = (float)(1.41 + 1.42) / (float)1.65;
		if ((double)num < 0.2)
		{
			return 7;
		}
		if ((double)num < 0.3 || Math.Round((double)1.2) >= 5.0)
		{
			if (Math.Round((double)1.4) <= 5.0)
			{
				return 6;
			}
			return 7;
		}
		else
		{
			if ((double)num <= 0.6)
			{
				return Math.Max(4, Math.Min((int)Math.Round((double)1.4) + 1, 7));
			}
			if (Math.Round((double)1.4) <= 4.0)
			{
				return 4;
			}
			return 5;
		}
	}

	// Token: 0x060037F5 RID: 14325 RVA: 0x0015ED25 File Offset: 0x0015CF25
	internal static int 51(1262 1)
	{
		if (1.3() == 2147.OsuMania)
		{
			return (int)Math.Round((double)1.2);
		}
		return 2011.50(1);
	}

	// Token: 0x060037F6 RID: 14326 RVA: 0x0015ED44 File Offset: 0x0015CF44
	internal static int 52(1262 1)
	{
		if (1 == null)
		{
			return 4;
		}
		return 2011.53(1, 1535.1() ? 1535.39.8.1() : 2019.1);
	}

	// Token: 0x060037F7 RID: 14327 RVA: 0x0015ED70 File Offset: 0x0015CF70
	internal static int 53(1262 1, 2023 2)
	{
		if (1 == null)
		{
			return 4;
		}
		if (1.3() == 2147.OsuMania)
		{
			return (int)Math.Round((double)1.2);
		}
		2023 3 = 2 & 2023.KeyMod & ~2023.KeyCoop;
		int num = (3 <= 2023.None || (3 & 3 - 1) != 2023.None) ? 2011.50(1) : Convert.ToInt32(3.ToString().Substring(3));
		if ((2 & 2023.KeyCoop) > 2023.None)
		{
			return num * 2;
		}
		return num;
	}

	// Token: 0x060037F8 RID: 14328 RVA: 0x0015EDE4 File Offset: 0x0015CFE4
	private static void 54()
	{
		2011.28 = new 2023?[19];
		int i = 1;
		while (i <= 18)
		{
			2023 <<EMPTY_NAME>> = 2023.None;
			int num = i;
			if (i <= 9)
			{
				goto IL_28;
			}
			if (i % 2 == 0)
			{
				num /= 2;
				<<EMPTY_NAME>> = 2023.KeyCoop;
				goto IL_28;
			}
			IL_5F:
			i++;
			continue;
			IL_28:
			2011.28[i] = new 2023?(<<EMPTY_NAME>> | (2023)Enum.Parse(typeof(2023), "Key" + num.ToString()));
			goto IL_5F;
		}
	}

	// Token: 0x060037F9 RID: 14329 RVA: 0x0015EE5C File Offset: 0x0015D05C
	internal static 2023 55(1262 1, 2023 2)
	{
		2023 3 = 2 & ~(2023.Key4 | 2023.Key5 | 2023.Key6 | 2023.Key7 | 2023.Key8 | 2023.Key9 | 2023.KeyCoop | 2023.Key1 | 2023.Key3 | 2023.Key2);
		int num = 2011.53(1, 2);
		if (2011.51(1) == num)
		{
			return 3;
		}
		return 3 | 2011.28[num].Value;
	}

	// Token: 0x060037FA RID: 14330 RVA: 0x0015EE98 File Offset: 0x0015D098
	private void 56()
	{
		if (!this.10())
		{
			return;
		}
		if (this.16 != null && this.17 != null)
		{
			if (2486.13)
			{
				return;
			}
			if (2648.6)
			{
				if (this.16.16 > 0f)
				{
					this.16.16 -= 0.016667f * (float)1662.10;
				}
				if (this.16.16 < 0f)
				{
					this.16.16 = 0f;
				}
				if (this.17.16 > 0f)
				{
					this.17.16 -= 0.016667f * (float)1662.10;
				}
				if (this.17.16 < 0f)
				{
					this.17.16 = 0f;
				}
				return;
			}
			if (this.16.16 < 1f)
			{
				this.16.16 += 0.026667f * (float)1662.10;
			}
			if (this.16.16 > 1f)
			{
				this.16.16 = 1f;
			}
			if (this.17.16 < 1f)
			{
				this.17.16 += 0.026667f * (float)1662.10;
			}
			if (this.17.16 > 1f)
			{
				this.17.16 = 1f;
			}
			float num = (float)Math.Min(400, 160 + 2486.7.58.3.GetCombo() / 2);
			if (this.16.20.Y > num)
			{
				1433 <<EMPTY_NAME>> = this.16;
				<<EMPTY_NAME>>.20.Y = <<EMPTY_NAME>>.20.Y - 2f * (float)1662.10;
			}
			if (this.16.20.Y < num)
			{
				this.16.20.Y = num;
			}
			if (this.32())
			{
				2023 2 = 2486.88.8;
				2023 3 = 2023.Hidden;
				if ((2 & 3) > 2023.None)
				{
					this.17.17.Y = this.36() + this.16.20.Y / 1.6f;
					return;
				}
				this.17.17.Y = 480f - this.16.20.Y / 1.6f;
				return;
			}
			else
			{
				2023 4 = 2486.88.8;
				2023 5 = 2023.Hidden;
				if ((4 & 5) > 2023.None)
				{
					this.17.17.Y = this.36() - this.16.20.Y / 1.6f;
					return;
				}
				this.17.17.Y = this.16.20.Y / 1.6f;
			}
		}
	}

	// Token: 0x060037FB RID: 14331 RVA: 0x0015F184 File Offset: 0x0015D384
	internal 1065 57(1065 1)
	{
		if (!this.32())
		{
			return 1;
		}
		switch (1)
		{
		case 1065.TopLeft:
			return 1065.BottomLeft;
		case 1065.TopRight:
			return 1065.BottomRight;
		case 1065.BottomCentre:
			return 1065.TopCentre;
		case 1065.TopCentre:
			return 1065.BottomCentre;
		case 1065.BottomLeft:
			return 1065.TopLeft;
		case 1065.BottomRight:
			return 1065.TopRight;
		}
		return 1;
	}

	// Token: 0x0400294C RID: 10572
	private int 1;

	// Token: 0x0400294D RID: 10573
	private int 2;

	// Token: 0x0400294E RID: 10574
	private 2011 3;

	// Token: 0x0400294F RID: 10575
	internal 1992 4;

	// Token: 0x04002950 RID: 10576
	internal 1436 5;

	// Token: 0x04002951 RID: 10577
	internal 1436 6;

	// Token: 0x04002952 RID: 10578
	internal 1436 7;

	// Token: 0x04002953 RID: 10579
	internal 1436 8;

	// Token: 0x04002954 RID: 10580
	internal 2003 9;

	// Token: 0x04002955 RID: 10581
	private 1433 10;

	// Token: 0x04002956 RID: 10582
	private 1433 11;

	// Token: 0x04002957 RID: 10583
	private 1351 12;

	// Token: 0x04002958 RID: 10584
	private 1433 13;

	// Token: 0x04002959 RID: 10585
	private 1433 14;

	// Token: 0x0400295A RID: 10586
	private 1351 15;

	// Token: 0x0400295B RID: 10587
	private 1433 16;

	// Token: 0x0400295C RID: 10588
	private 1433 17;

	// Token: 0x0400295D RID: 10589
	private Dictionary<string, 1381[]> 18 = new Dictionary<string, 1381[]>(6);

	// Token: 0x0400295E RID: 10590
	internal List<1995> 19 = new List<1995>();

	// Token: 0x0400295F RID: 10591
	internal float 20;

	// Token: 0x04002960 RID: 10592
	private float 21;

	// Token: 0x04002961 RID: 10593
	private bool 22;

	// Token: 0x04002962 RID: 10594
	private bool 23;

	// Token: 0x04002963 RID: 10595
	private bool 24;

	// Token: 0x04002964 RID: 10596
	private float 25;

	// Token: 0x04002965 RID: 10597
	private float 26;

	// Token: 0x04002966 RID: 10598
	private float 27;

	// Token: 0x04002967 RID: 10599
	private static 2023?[] 28;

	// Token: 0x0200076B RID: 1899
	[Serializable]
	public sealed class 2015
	{
		// Token: 0x04002968 RID: 10600
		public static readonly 2011.2015 instance = new 2011.2015();

		// Token: 0x04002969 RID: 10601
		public static Action<1995> action;

		// Token: 0x0400296A RID: 10602
		public static Action<1995> action2;
	}

	// Token: 0x0200076C RID: 1900
	public sealed class 2013
	{
		// Token: 0x060037FE RID: 14334 RVA: 0x0015F1F3 File Offset: 0x0015D3F3
		internal void 1(float 1)
		{
			this.1 = Math.Min(this.1, 1);
		}

		// Token: 0x0400296B RID: 10603
		public float 1;
	}

	// Token: 0x0200076D RID: 1901
	public sealed class 2012 : IEnumerator<2011>, IDisposable, IEnumerator
	{
		// Token: 0x06003800 RID: 14336 RVA: 0x0015F207 File Offset: 0x0015D407
		[DebuggerHidden]
		public 2012(int 1)
		{
			this.1 = 1;
		}

		// Token: 0x06003801 RID: 14337 RVA: 0x00005ADD File Offset: 0x00003CDD
		[DebuggerHidden]
		private void 1()
		{
		}

		// Token: 0x06003802 RID: 14338 RVA: 0x0015F216 File Offset: 0x0015D416
		void IDisposable.Dispose()
		{
			this.1();
		}

		// Token: 0x06003803 RID: 14339 RVA: 0x0015F220 File Offset: 0x0015D420
		private bool 2()
		{
			int num = this.1;
			2011 <<EMPTY_NAME>> = this.3;
			if (num != 0)
			{
				if (num != 1)
				{
					return false;
				}
				this.1 = -1;
				this.4 = this.4.4();
			}
			else
			{
				this.1 = -1;
				this.4 = <<EMPTY_NAME>>;
			}
			if (this.4 != null)
			{
				this.2 = this.4;
				this.1 = 1;
				return true;
			}
			return false;
		}

		// Token: 0x06003804 RID: 14340 RVA: 0x0015F28A File Offset: 0x0015D48A
		bool IEnumerator.MoveNext()
		{
			return this.2();
		}

		// Token: 0x06003805 RID: 14341 RVA: 0x0015F292 File Offset: 0x0015D492
		[DebuggerHidden]
		private 2011 3()
		{
			return this.2;
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06003806 RID: 14342 RVA: 0x0015F29A File Offset: 0x0015D49A
		2011 IEnumerator<2011>.Current
		{
			get
			{
				return this.3();
			}
		}

		// Token: 0x06003807 RID: 14343 RVA: 0x00005BE8 File Offset: 0x00003DE8
		[DebuggerHidden]
		private void 4()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06003808 RID: 14344 RVA: 0x0015F2A2 File Offset: 0x0015D4A2
		void IEnumerator.Reset()
		{
			this.4();
		}

		// Token: 0x06003809 RID: 14345 RVA: 0x0015F292 File Offset: 0x0015D492
		[DebuggerHidden]
		private object 5()
		{
			return this.2;
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x0600380A RID: 14346 RVA: 0x0015F2AA File Offset: 0x0015D4AA
		object IEnumerator.Current
		{
			get
			{
				return this.5();
			}
		}

		// Token: 0x0400296C RID: 10604
		private int 1;

		// Token: 0x0400296D RID: 10605
		private 2011 2;

		// Token: 0x0400296E RID: 10606
		public 2011 3;

		// Token: 0x0400296F RID: 10607
		private 2011 4;
	}

	// Token: 0x0200076E RID: 1902
	public sealed class 2014
	{
		// Token: 0x0600380B RID: 14347 RVA: 0x0015F2B2 File Offset: 0x0015D4B2
		internal void 1(float 1)
		{
			this.1 += 1;
		}

		// Token: 0x04002970 RID: 10608
		public float 1;
	}

	// Token: 0x0200076F RID: 1903
	public sealed class 2017
	{
		// Token: 0x0600380D RID: 14349 RVA: 0x0015F2C2 File Offset: 0x0015D4C2
		internal void 1(1371 1)
		{
			1.17.Y = 1.17.Y - (this.1.26 - this.2);
		}

		// Token: 0x04002971 RID: 10609
		public 2011 1;

		// Token: 0x04002972 RID: 10610
		public float 2;
	}

	// Token: 0x02000770 RID: 1904
	public sealed class 2016
	{
		// Token: 0x0600380F RID: 14351 RVA: 0x0015F2E5 File Offset: 0x0015D4E5
		internal void 1(1371 1)
		{
			1.17.X = 1.17.X - (this.1.27 - this.2);
		}

		// Token: 0x06003810 RID: 14352 RVA: 0x0015F2E5 File Offset: 0x0015D4E5
		internal void 2(1371 1)
		{
			1.17.X = 1.17.X - (this.1.27 - this.2);
		}

		// Token: 0x04002973 RID: 10611
		public 2011 1;

		// Token: 0x04002974 RID: 10612
		public float 2;
	}
}
