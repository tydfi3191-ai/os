using System;
using System.Globalization;

// Token: 0x020008FC RID: 2300
public sealed class 1759 : 1689
{
	// Token: 0x06004193 RID: 16787 RVA: 0x00197520 File Offset: 0x00195720
	public 1759(2023 1, 2018 2) : base(1939.1(4) ? "Double Time" : "Half Time", true)
	{
		1759 <>4__this = this;
		this.19 = (1939.1(4) ? 2023.DoubleTime : 2023.HalfTime);
		float num = (float)1662.70.1() / 2f;
		this.32 = 1743.Create(this.7);
		if (this.32 != null)
		{
			this.3 += 30f;
		}
		this.25 = new 1452(this.13(), 14f, new 208(0f, this.3 - 30f), 208.Zero, 0.94f, true, 198.LightGray, true)
		{
			41 = (1376)7,
			49 = 1065.Centre
		};
		this.7.12(this.25);
		1452 3 = new 1452((this.19 == 2023.DoubleTime) ? "Speed increase" : "Speed decrease", 16f, new 208(num - 230f, this.3), 0.94f, true, 198.White);
		3.49 = 1065.CentreLeft;
		this.7.12(3);
		this.20 = new 1429(this.7, 1939.3(this.19), 1939.4(this.19), 1939.9(this.19), new 208(num - 100f, this.3), 200);
		this.20.21 = 0.05;
		this.17.Add(this.20);
		this.20.18 = delegate(bool 1)
		{
			if (!<>4__this.29 && <>4__this.14())
			{
				1939.12(<>4__this.19, <>4__this.20.7);
				<>4__this.Refresh();
			}
		};
		this.27 = new 208(num + 115f, this.3);
		this.21 = new 1452(string.Empty, 16f, this.27, 0.94f, true, 198.White);
		this.21.49 = 1065.CentreLeft;
		this.21.10 = true;
		this.21.52 = "Click to type the speed";
		this.21.3(delegate(object 1, EventArgs 2)
		{
			<>4__this.19();
		});
		this.7.12(this.21);
		this.22 = new 1452("reset", 14f, new 208(num + 165f, this.3), 0.94f, true, 198.Gray);
		this.22.49 = 1065.CentreLeft;
		this.22.42 = new 1445(198.Gray, 198.White, 0, 100);
		this.22.3(delegate(object 1, EventArgs 2)
		{
			1939.12(<>4__this.19, 1939.8(<>4__this.19));
			<>4__this.Refresh();
		});
		this.7.12(this.22);
		this.3 += 35f;
		this.23 = new 1364("Adjust pitch (the pitch follows the speed)", 0.8f, new 208(num - 230f, this.3 - 8f), 0.94f, 1939.10(this.19), 0f);
		this.23.9(delegate(object 1, bool 2)
		{
			1939.14(<>4__this.19, 2);
		});
		this.7.14<1433>(this.23.2);
		this.3 += 35f;
		this.24 = new 1364((this.19 == 2023.DoubleTime) ? "No Limits (up to 5.00x)" : "No Limits (down to 0.10x)", 0.8f, new 208(num - 230f, this.3 - 8f), 0.94f, 1939.NoLimits, 0f);
		this.24.9(delegate(object 1, bool 2)
		{
			1939.2(2);
			<>4__this.Refresh();
		});
		this.7.14<1433>(this.24.2);
		this.3 += 45f;
		this.26 = base.7(this.17(), this.18(), delegate(object 1, EventArgs 2)
		{
			<>4__this.16(!<>4__this.14());
			<>4__this.Refresh();
		}, false, false, true);
		base.7("Back", 198.Gray, null, true, false, true);
		base.3(delegate(object 1, EventArgs 2)
		{
			if (1662.78 == 1677.SelectPlay)
			{
				1662.25(new 1754(5));
			}
		});
	}

	// Token: 0x06004194 RID: 16788 RVA: 0x00197960 File Offset: 0x00195B60
	private bool 12()
	{
		return this.14() && 1939.7(1939.9(this.19));
	}

	// Token: 0x06004195 RID: 16789 RVA: 0x0019797C File Offset: 0x00195B7C
	private string 13()
	{
		if (this.12())
		{
			return "Past lazer's limits: the replay might not play on lazer.";
		}
		if (this.19 != 2023.DoubleTime)
		{
			return "Play the beatmap slower than normal.";
		}
		return "Play the beatmap faster than normal.";
	}

	// Token: 0x06004196 RID: 16790 RVA: 0x001979A1 File Offset: 0x00195BA1
	private new bool 14()
	{
		return (2019.1 & ((this.19 == 2023.DoubleTime) ? (2023.DoubleTime | 2023.Nightcore) : 2023.HalfTime)) > 2023.None;
	}

	// Token: 0x06004197 RID: 16791 RVA: 0x001979C2 File Offset: 0x00195BC2
	private new bool 15()
	{
		return this.19 == 2023.DoubleTime && (2019.1 & 2023.Nightcore) > 2023.None;
	}

	// Token: 0x06004198 RID: 16792 RVA: 0x001979E0 File Offset: 0x00195BE0
	private new void 16(bool 1)
	{
		if (1)
		{
			2019.1 |= this.19;
			2019.7(this.19);
		}
		else
		{
			2019.1 &= ~((this.19 == 2023.DoubleTime) ? (2023.DoubleTime | 2023.Nightcore) : 2023.HalfTime);
			2019.7(2023.None);
		}
		2019.3();
	}

	// Token: 0x06004199 RID: 16793 RVA: 0x00197A3B File Offset: 0x00195C3B
	private new string 17()
	{
		if (!this.14())
		{
			return "Enable Rate Change";
		}
		return "Disable Rate Change";
	}

	// Token: 0x0600419A RID: 16794 RVA: 0x00197A50 File Offset: 0x00195C50
	private 198 18()
	{
		if (!this.14())
		{
			return 198.YellowGreen;
		}
		return 198.OrangeRed;
	}

	// Token: 0x0600419B RID: 16795 RVA: 0x00197A65 File Offset: 0x00195C65
	internal override void OnShown()
	{
		base.OnShown();
		this.Refresh();
	}

	// Token: 0x0600419C RID: 16796 RVA: 0x00197A74 File Offset: 0x00195C74
	public override void Update()
	{
		base.Update();
		bool flag = 1555.2() == 199.Pressed;
		if (!flag || !this.4 || !this.14())
		{
			this.30 = false;
		}
		else if (!this.31)
		{
			this.30 = this.20.25();
		}
		if (this.30)
		{
			this.20.27();
		}
		this.31 = flag;
		1743 <<EMPTY_NAME>> = this.32;
		if (<<EMPTY_NAME>> == null)
		{
			return;
		}
		<<EMPTY_NAME>>.1();
	}

	// Token: 0x0600419D RID: 16797 RVA: 0x00197AF0 File Offset: 0x00195CF0
	internal override bool OnKeyDown(200 1)
	{
		if (this.28 != null && this.28.1())
		{
			return false;
		}
		if (1939.21(1))
		{
			this.Refresh();
			return true;
		}
		if ((1 == 200.Left || 1 == 200.Right) && this.14())
		{
			1939.12(this.19, 1939.9(this.19) + ((1 == 200.Right) ? 0.01 : -0.01));
			this.Refresh();
			return true;
		}
		return base.OnKeyDown(1);
	}

	// Token: 0x0600419E RID: 16798 RVA: 0x00197B78 File Offset: 0x00195D78
	private void 19()
	{
		if (this.28 != null || !this.14())
		{
			return;
		}
		this.28 = new 1448(1939.9(this.19).ToString("0.00", CultureInfo.InvariantCulture), 16f, this.27 - new 208(0f, 9f), 60f, 0.95f, false);
		this.28.4 = 6;
		this.28.3(delegate(1448 1, bool 2)
		{
			string s = (this.28.GetText() ?? string.Empty).Trim().TrimEnd(new char[]
			{
				'x',
				'X'
			}).Replace(',', '.');
			double 3;
			if (2 && double.TryParse(s, NumberStyles.Float, CultureInfo.InvariantCulture, out 3))
			{
				1939.12(this.19, 3);
			}
			this.20();
		});
		this.7.14<1433>(this.28.2);
		this.21.16 = 0f;
		1662.89.Schedule(delegate()
		{
			1448 <<EMPTY_NAME>> = this.28;
			if (<<EMPTY_NAME>> == null)
			{
				return;
			}
			<<EMPTY_NAME>>.16();
		}, true);
	}

	// Token: 0x0600419F RID: 16799 RVA: 0x00197C4C File Offset: 0x00195E4C
	private void 20()
	{
		1448 box = this.28;
		this.28 = null;
		if (box != null)
		{
			1662.89.Schedule(delegate()
			{
				this.7.20<1433>(box.2);
				box.Dispose();
			}, true);
		}
		this.Refresh();
	}

	// Token: 0x060041A0 RID: 16800 RVA: 0x00197C9F File Offset: 0x00195E9F
	protected override void Dispose(bool 1)
	{
		1448 2 = this.28;
		if (2 != null)
		{
			2.Dispose();
		}
		base.Dispose(1);
	}

	// Token: 0x060041A1 RID: 16801 RVA: 0x00197CBC File Offset: 0x00195EBC
	private void Refresh()
	{
		bool flag = this.14();
		bool flag2 = 1939.11(this.19);
		this.29 = true;
		this.20.22(1939.3(this.19), 1939.4(this.19), 1939.9(this.19));
		this.20.2(!flag);
		for (int i = 0; i < this.20.13.Count; i++)
		{
			float num = (i == this.20.13.Count - 1) ? 0.5f : 1f;
			this.20.13[i].24(num * (flag ? 1f : 0.3f), 140, (1046)0);
		}
		this.29 = false;
		string text = 1939.22(1939.9(this.19));
		this.21.SetText(flag2 ? text : (text + " (default)"));
		this.21.10 = flag;
		this.21.24((this.28 != null) ? 0f : ((!flag) ? 0.3f : (flag2 ? 1f : 0.6f)), 140, (1046)0);
		bool flag3 = flag && flag2;
		this.22.10 = flag3;
		this.22.24(flag3 ? 1f : 0f, 140, (1046)0);
		bool flag4 = flag && !this.15();
		this.23.7(this.15() || 1939.10(this.19));
		this.23.2(flag4);
		foreach (1433 <<EMPTY_NAME>> in this.23.2)
		{
			<<EMPTY_NAME>>.24(flag4 ? 1f : 0.3f, 140, (1046)0);
		}
		this.24.7(1939.NoLimits);
		this.24.2(flag);
		foreach (1433 2 in this.24.2)
		{
			2.24(flag ? 1f : 0.3f, 140, (1046)0);
		}
		this.25.SetText(this.13());
		this.25.6 = (this.12() ? 198.Orange : 198.LightGray);
		this.26.4.SetText(this.17());
		this.26.4(this.18());
	}

	// Token: 0x04002FE1 RID: 12257
	private const float 18 = 0.3f;

	// Token: 0x04002FE2 RID: 12258
	private readonly 2023 19;

	// Token: 0x04002FE3 RID: 12259
	private readonly 1429 20;

	// Token: 0x04002FE4 RID: 12260
	private readonly 1452 21;

	// Token: 0x04002FE5 RID: 12261
	private readonly 1452 22;

	// Token: 0x04002FE6 RID: 12262
	private readonly 1364 23;

	// Token: 0x04002FE7 RID: 12263
	private readonly 1364 24;

	// Token: 0x04002FE8 RID: 12264
	private readonly 1452 25;

	// Token: 0x04002FE9 RID: 12265
	private readonly 1361 26;

	// Token: 0x04002FEA RID: 12266
	private readonly 208 27;

	// Token: 0x04002FEB RID: 12267
	private 1448 28;

	// Token: 0x04002FEC RID: 12268
	private bool 29;

	// Token: 0x04002FED RID: 12269
	private bool 30;

	// Token: 0x04002FEE RID: 12270
	private bool 31;

	// Token: 0x04002FEF RID: 12271
	private readonly 1743 32;
}
