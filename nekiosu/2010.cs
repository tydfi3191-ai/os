using System;

// Token: 0x02000769 RID: 1897
public sealed class 2010 : 1689
{
	// Token: 0x060037AB RID: 14251 RVA: 0x0015C98C File Offset: 0x0015AB8C
	internal 2010() : base(1568.1(2679.Options_TabSkin_CustonKey), false)
	{
		2630.25();
		this.7.47 = true;
		1354 <<EMPTY_NAME>> = new 1354(new EventHandler(this.18), false, true);
		this.7.14<1433>(<<EMPTY_NAME>>.1);
		int num = 225 + (int)1662.70.5();
		int num2 = 80;
		int num3 = 35;
		this.22 = new 1373(this.7, string.Empty, new 208((float)(num + 10), (float)num2), 75f, 1f);
		int i = 1;
		while (i <= 18)
		{
			this.22.10(this.17(i, i >= 10), i);
			this.16(ref i);
		}
		this.22.1(new EventHandler(this.19));
		this.23 = new 1364(1568.1(2679.Options_TabSkin_SplitLayout), new 208((float)(num + 105), (float)num2), 0.8f, false);
		this.23.9(new 1183(this.20));
		this.7.14<1433>(this.23.2);
		num2 = 300;
		this.26 = new 1373(this.7, string.Empty, new 208((float)(num - 65), (float)num2), 150f, 0.8f, false, false);
		this.26.10(1568.1(2679.Options_ManiaSpecial_Normal), 0);
		this.26.10(1568.1(2679.Options_ManiaSpecial_Left), 1);
		this.26.10(1568.1(2679.Options_ManiaSpecial_Right), 2);
		this.26.1(delegate(object 1, EventArgs 2)
		{
			int num4 = (int)1;
			if (num4 != 1)
			{
				if (num4 != 2)
				{
					this.28.4.SpecialStyle = 1991.None;
				}
				else
				{
					this.28.4.SpecialStyle = 1991.Right;
				}
			}
			else
			{
				this.28.4.SpecialStyle = 1991.Left;
			}
			2630.16();
			this.12(false);
		});
		this.27 = new 1364(1568.1(2679.Options_TabSkin_BindAlternateSpecialKeys), new 208((float)(num + 105), (float)num2), 0.8f, false);
		this.27.9(delegate(object 1, bool 2)
		{
			this.12(false);
		});
		this.7.14<1433>(this.27.2);
		num2 += num3;
		this.24 = new 1364(1568.1(2679.Options_TabSkin_UpsiedDown), new 208((float)num, (float)num2), 0.8f, false);
		this.24.9(new 1183(this.21));
		this.7.14<1433>(this.24.2);
		num2 += num3;
		this.25 = new 1364(1568.1(2679.Options_TabSkin_ShowJudgement), new 208((float)num, (float)num2), 0.8f, false);
		this.25.9(new 1183(this.22));
		this.7.14<1433>(this.25.2);
		this.22.18(this.18, false);
	}

	// Token: 0x060037AC RID: 14252 RVA: 0x0015CC83 File Offset: 0x0015AE83
	protected override void Dispose(bool 1)
	{
		this.14();
		1373 2 = this.22;
		if (2 != null)
		{
			2.17();
		}
		1373 3 = this.26;
		if (3 != null)
		{
			3.17();
		}
		base.Dispose(1);
	}

	// Token: 0x060037AD RID: 14253 RVA: 0x0015CCB4 File Offset: 0x0015AEB4
	internal void 12(bool 1)
	{
		this.19 = 0;
		this.7.28.FindAll(new Predicate<1371>(this.23)).ForEach(delegate(1371 1)
		{
			1.16(50, (1046)0, 0);
			1.5 = false;
			this.7.Remove(1);
		});
		this.14();
		1992 2 = 2630.17(this.18, 2023.None);
		this.23.2(this.18 > 1 && 2.SplitStagesFromSkin == null);
		if (!7)
		{
			2.15(this.23.4());
		}
		this.23.7(2.14());
		this.22.10.SetText(this.17(this.18, 2.14()));
		this.28 = new 2011(2, true, 0f, 480f, float.NaN, 1f, 0, 0);
		this.28.16(this.28.6().3());
		this.26.5(this.28.41());
		1991 3 = this.28.9();
		if (3 != 1991.Left)
		{
			if (3 != 1991.Right)
			{
				this.26.18(0, true);
			}
			else
			{
				this.26.18(2, true);
			}
		}
		else
		{
			this.26.18(1, true);
		}
		this.27.2(this.28.9() > 1991.None);
		if (this.28.9() == 1991.None)
		{
			this.27.7(false);
		}
		this.25.7(2.JudgementLine);
		this.24.7(2.UpsideDown);
		float num = 40f;
		float num2 = 2.14() ? 1f : 0f;
		float num3 = ((float)this.18 + num2) * num;
		float num4 = Math.Min(1f, (float)1662.70.1() / num3);
		num3 *= num4;
		num *= num4;
		float num5 = ((float)1662.70.1() - num3) / 2f;
		this.21 = new 1433(1455.1(new string[]
		{
			"arrow-generic",
			"play-warningarrow"
		}, (1416)1), (1376)6, 1065.CentreLeft, (1044)0, new 208(0f, 100f), 0.92f, true, 1662.112 ? 198.SkyBlue : 198.White, null);
		this.21.8 = this;
		this.21.14 = 1.5707964f;
		this.7.12(this.21);
		this.20 = new 1452[this.18];
		int 4 = 0;
		for (int i = 0; i < this.18; i++)
		{
			bool flag = false;
			if (this.27.4())
			{
				flag = true;
				foreach (2011 5 in this.28)
				{
					if (i == 5.19[5.44()])
					{
						flag = false;
					}
				}
			}
			if (!flag)
			{
				1433 6 = new 1433(1455.2("mania-key1D", (1416)1, null), (1376)6, 1065.TopLeft, (1044)0, new 208(num5, 192f), 0.92f, true, this.28.19[i].9(), null);
				6.20 = 1.3f * new 208(num4, 1f);
				6.8 = this;
				this.7.12(6);
				this.20[i] = new 1452(this.15(i), (float)Math.Max(1, (int)Math.Round((double)(14f * num4))), new 208(num5 + num / 2f, 232f), 0.93f, true, 198.White);
				this.20[i].64(true);
				this.20[i].49 = 1065.Centre;
				this.20[i].8 = this;
				this.20[i].9 = 4;
				this.7.12(this.20[i]);
				if (4++ == 0)
				{
					this.19 = i;
					this.21.17.X = num5 + num / 2f;
				}
			}
			num5 += num + num * ((i == this.28.45() - 1) ? num2 : 0f);
		}
	}

	// Token: 0x060037AE RID: 14254 RVA: 0x0015D154 File Offset: 0x0015B354
	private void 13(200 1)
	{
		2005 2 = this.28.6();
		if (2.1() < 0)
		{
			2.6(0, null);
			2.2(0);
			this.28.16(2.3());
		}
		2007 3 = this.27.4() ? ((2007)1) : ((2007)0);
		2.3()[this.20[this.19].9, 3] = 1;
		this.28.15();
		for (int i = 0; i < this.18; i++)
		{
			if (this.20[i] != null)
			{
				this.20[i].SetText(this.15(i));
			}
		}
		int num;
		do
		{
			num = this.19 + 1;
			this.19 = num;
		}
		while (num < this.18 && this.20[this.19] == null);
		if (this.19 >= this.18)
		{
			if (this.16(ref this.18) > 18)
			{
				this.18 = 1;
			}
			this.22.18(this.18, false);
			return;
		}
		this.21.20(this.20[this.19].17.X, 300, (1046)1);
	}

	// Token: 0x060037AF RID: 14255 RVA: 0x0015D28F File Offset: 0x0015B48F
	internal override bool OnKeyDown(200 1)
	{
		if (1 == 200.Escape)
		{
			this.Close(false);
		}
		else
		{
			this.13(1);
		}
		return true;
	}

	// Token: 0x060037B0 RID: 14256 RVA: 0x0015D2A7 File Offset: 0x0015B4A7
	private new void 14()
	{
		if (this.28 != null)
		{
			this.28.Dispose();
			this.28 = null;
		}
	}

	// Token: 0x060037B1 RID: 14257 RVA: 0x0015D2C4 File Offset: 0x0015B4C4
	private new string 15(int 1)
	{
		return 1548.11(this.27.4() ? this.28.19[1].18() : this.28.19[1].16());
	}

	// Token: 0x060037B2 RID: 14258 RVA: 0x0015D311 File Offset: 0x0015B511
	private new int 16(ref int 1)
	{
		1++;
		if (1 > 10 && 1 % 2 != 0)
		{
			1++;
		}
		return 1;
	}

	// Token: 0x060037B3 RID: 14259 RVA: 0x0015D330 File Offset: 0x0015B530
	private new string 17(int 1, bool 2)
	{
		if (!2 || 1 % 2 != 0)
		{
			return 1.ToString() + "K";
		}
		return (1 / 2).ToString() + "K Co-op";
	}

	// Token: 0x060037B4 RID: 14260 RVA: 0x0015D36C File Offset: 0x0015B56C
	private void 18(object 1, EventArgs 2)
	{
		this.Close(false);
	}

	// Token: 0x060037B5 RID: 14261 RVA: 0x0015D375 File Offset: 0x0015B575
	private void 19(object 1, EventArgs 2)
	{
		this.18 = (int)1;
		this.27.7(false);
		this.12(true);
	}

	// Token: 0x060037B6 RID: 14262 RVA: 0x0015D396 File Offset: 0x0015B596
	private void 20(object 1, bool 2)
	{
		this.12(false);
	}

	// Token: 0x060037B7 RID: 14263 RVA: 0x0015D39F File Offset: 0x0015B59F
	private void 21(object 1, bool 2)
	{
		this.28.4.UpsideDown = 2;
		2630.16();
	}

	// Token: 0x060037B8 RID: 14264 RVA: 0x0015D3B7 File Offset: 0x0015B5B7
	private void 22(object 1, bool 2)
	{
		this.28.4.JudgementLine = 2;
		2630.16();
	}

	// Token: 0x060037B9 RID: 14265 RVA: 0x0015D3CF File Offset: 0x0015B5CF
	private bool 23(1371 1)
	{
		return 1.8 == this;
	}

	// Token: 0x04002941 RID: 10561
	private int 18 = 4;

	// Token: 0x04002942 RID: 10562
	private int 19;

	// Token: 0x04002943 RID: 10563
	private 1452[] 20;

	// Token: 0x04002944 RID: 10564
	private 1433 21;

	// Token: 0x04002945 RID: 10565
	private 1373 22;

	// Token: 0x04002946 RID: 10566
	private 1364 23;

	// Token: 0x04002947 RID: 10567
	private 1364 24;

	// Token: 0x04002948 RID: 10568
	private 1364 25;

	// Token: 0x04002949 RID: 10569
	private 1373 26;

	// Token: 0x0400294A RID: 10570
	private 1364 27;

	// Token: 0x0400294B RID: 10571
	private 2011 28;
}
