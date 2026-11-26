using System;
using System.Collections.Generic;

// Token: 0x020004C6 RID: 1222
[276]
public sealed class 2485 : 2486
{
	// Token: 0x06002509 RID: 9481 RVA: 0x000AB4C8 File Offset: 0x000A96C8
	public override void Update()
	{
		if (!this.94.3 || this.39.35 == 0)
		{
			base.66();
			return;
		}
		if (2485.220 && !this.164())
		{
			this.165(true);
			2485.220 = false;
		}
		float num = 1662.69.28(1662.55.1() + this.34.22.43 + this.34.21.43 + this.34.23.43 + this.34.24.43);
		if (1662.23)
		{
			this.214.6 = ((num > 5f) ? 198.Red : 198.White);
			this.214.54(num > 5f);
			this.214.SetText(string.Format("Current: {0:00}:{1:00}:{2:00} | SB Load: {3:0.00}x", new object[]
			{
				1226.16 / 1000 / 60,
				1226.16 % 60000 / 1000,
				1226.16 % 1000 / 10,
				num
			}));
		}
		if (this.210 == -1 || (this.39.31 >= 0 && 1226.16 - this.39.34[this.39.31].2 > 200 && 1226.16 / 200 > this.210))
		{
			this.210 = 1226.16 / 200;
			if (2486.14() == 2147.OsuMania)
			{
				this.215.SetText(string.Format("300g x {0}\n300 x {1}\n200 x {2}\n100 x {3}\n50 x {4}\nMiss x {5}\nMistimed Hits: {6:#,0}% (ave {7}ms {8})", new object[]
				{
					2486.88.4,
					2486.88.2,
					2486.88.5,
					2486.88.1,
					2486.88.3,
					2486.88.6,
					(this.219 > 0) ? ((float)this.211 / (float)this.219 * 100f) : 0f,
					(this.213 > 0.0) ? ((int)Math.Round(Math.Abs(this.212 / this.213))) : 0,
					(this.212 < 0.0) ? 1568.1(2679.PlayerTest_Early) : 1568.1(2679.PlayerTest_Late)
				}));
			}
			else
			{
				this.215.SetText(string.Format("300 x {0}\n100 x {1}\n50 x {2}\nMiss x {3}\n\nMistimed Hits: {4:#,0}% (ave {5}ms {6})", new object[]
				{
					2486.88.2,
					2486.88.1,
					2486.88.3,
					2486.88.6,
					(this.219 > 0) ? ((float)this.211 / (float)this.219 * 100f) : 0f,
					(this.213 > 0.0) ? ((int)Math.Round(Math.Abs(this.212 / this.213))) : 0,
					(this.212 < 0.0) ? 1568.1(2679.PlayerTest_Early) : 1568.1(2679.PlayerTest_Late)
				}));
			}
		}
		base.Update();
	}

	// Token: 0x0600250A RID: 9482 RVA: 0x000AB899 File Offset: 0x000A9A99
	protected override bool ReturnToSongSelect()
	{
		1662.SetMode(1677.Edit, false);
		return true;
	}

	// Token: 0x0600250B RID: 9483 RVA: 0x000AB8A3 File Offset: 0x000A9AA3
	protected override void Dispose(bool 1)
	{
		if (1662.78 != 1677.Edit && 1662.78 != 1677.Play)
		{
			1662.84 = false;
		}
		2485.220 = (2486.57 && 1535.1());
		1535.2(false);
		base.Dispose(1);
	}

	// Token: 0x0600250C RID: 9484 RVA: 0x000AB8DC File Offset: 0x000A9ADC
	private bool 164()
	{
		return 1535.1();
	}

	// Token: 0x0600250D RID: 9485 RVA: 0x000AB8E4 File Offset: 0x000A9AE4
	private void 165(bool 1)
	{
		if (1 == 1535.1() || !1662.84 || 1226.16 >= this.39.34[this.39.35 - 1].2 || !2486.109)
		{
			return;
		}
		1535.2(1);
		if (1535.1())
		{
			1535.39 = this.222;
			while (1535.39.26[1535.33].10 < 1226.16)
			{
				1535.33++;
			}
			1535.33 -= 2;
			if (1535.33 < 0)
			{
				1535.33 = 0;
			}
			foreach (2034 2 in this.39.34)
			{
				if (2.2 >= 1226.16)
				{
					break;
				}
				2.11 = true;
			}
		}
		1763.2("Autoplay mod " + (1535.1() ? "enabled" : "disabled"), 2000, (1389)0);
	}

	// Token: 0x0600250E RID: 9486 RVA: 0x000ABA14 File Offset: 0x000A9C14
	protected override bool HandleGameplayKeyDown(object 1, 200 2)
	{
		if (this.164() && 1548.18(2, 2486.14()))
		{
			this.165(false);
		}
		if (base.HandleGameplayKeyDown(1, 2))
		{
			return true;
		}
		if (2 <= 200.B)
		{
			if (2 == 200.Tab)
			{
				this.165(!this.164());
				return true;
			}
			if (2 == 200.B)
			{
				if (1549.1)
				{
					if (2485.221 == null && this.39.25 != null)
					{
						2485.221 = this.39.25;
					}
					else if (2485.221 == null)
					{
						2485.221 = new List<int>();
					}
					2485.221.Add(1226.16);
					1763.2("Added new bookmark!", 1000, (1389)0);
					return true;
				}
				return false;
			}
		}
		else if (2 != 200.P)
		{
			switch (2)
			{
			case 200.F1:
				1662.89(1677.Edit, false, 0);
				return true;
			case 200.F2:
				1662.85 = 1226.16;
				1662.89(1677.Edit, false, 0);
				return true;
			case 200.F3:
			{
				if (!1535.1())
				{
					1763.2("Press [Tab] to active autoplay before changing speed.", 1500, (1389)0);
					return true;
				}
				double num = 1226.38();
				num = ((num != 150.0) ? 150.0 : 100.0);
				1226.39(num);
				1763.2(string.Format("Speed set to {0:0.0}x", num / 100.0), 1000, (1389)0);
				return true;
			}
			}
		}
		else
		{
			if (1549.1)
			{
				1226.107();
				2486.13 = !2486.13;
				return true;
			}
			return false;
		}
		return false;
	}

	// Token: 0x0600250F RID: 9487 RVA: 0x000ABB9B File Offset: 0x000A9D9B
	public override void Initialize()
	{
		base.Initialize();
	}

	// Token: 0x06002510 RID: 9488 RVA: 0x000ABBA4 File Offset: 0x000A9DA4
	protected override bool HandleBeatmapLoadCompleted(bool 1)
	{
		this.222 = 1535.39;
		this.214 = new 1452("\n", 10f, new 208(1f, 44f), 208.Zero, 1f, true, 198.White, true);
		this.214.74 = false;
		this.214.85 = false;
		this.214.40 = new bool?(true);
		this.71.12(this.214);
		int num = (int)(this.214.GetTextSize().Y / 1662.70.3());
		this.215 = new 1452(string.Empty, 10f, new 208(1f, (float)(50 + num)), 208.Zero, 1f, true, 198.White, true);
		this.215.74 = false;
		this.215.85 = false;
		this.215.40 = new bool?(true);
		this.71.12(this.215);
		this.216 = new 1452(string.Empty, 10f, new 208(1f, this.215.17.Y + (float)(num * 9) + 6f), 208.Zero, 1f, true, new 198(231, byte.MaxValue, 208), true);
		this.216.74 = false;
		this.216.85 = false;
		this.216.40 = new bool?(true);
		this.71.12(this.216);
		int num2 = this.218;
		if (2486.14() == 2147.OsuMania)
		{
			num2 = 1000000;
		}
		this.216.SetText(string.Format("Star Rating: {3:0.00}\nTotal Play Length: {0}s\nMaximum Score: {1:0,0}\nMaximum Combo: {2:0,0}\n\nTab: autoplay\nCtrl-B: bookmark\nCtrl-P: Toggle pause\nF1: quick exit\nF2: exit at current pos\nF3: change autoplay speed", new object[]
		{
			1272.5().52,
			num2,
			this.217,
			1272.5().31()
		}));
		1259 2 = 1226.73();
		if (2 != null)
		{
			2486.103 = 2.3();
		}
		if (2486.103 && !1304.54.1())
		{
			this.58.OnKiaiStateChanged(2486.103);
		}
		if (this.34 != null)
		{
			this.34.22.11 = true;
			this.34.21.11 = true;
			this.34.23.11 = true;
			this.34.24.11 = true;
		}
		return base.HandleBeatmapLoadCompleted(1);
	}

	// Token: 0x06002511 RID: 9489 RVA: 0x000ABE44 File Offset: 0x000AA044
	internal override void OnObjectHit(2034 1)
	{
		if (2486.14() != 2147.OsuMania || 1.2 <= 1.1)
		{
			if (Math.Abs(1226.16 - 1.1) > 20)
			{
				this.211++;
			}
			this.212 = 0.95 * this.212 + 0.05 * (double)(1226.16 - 1.1);
			this.213 = 1.0 - (1.0 - this.213) * 0.95;
			if (this.213 > 0.99)
			{
				this.213 = 1.0;
			}
			this.219++;
			base.OnObjectHit(1);
		}
	}

	// Token: 0x06002512 RID: 9490 RVA: 0x00005ADD File Offset: 0x00003CDD
	protected override void LoadScoreboard()
	{
	}

	// Token: 0x06002513 RID: 9491 RVA: 0x00005ADD File Offset: 0x00003CDD
	protected override void CreateSpectatorList()
	{
	}

	// Token: 0x040019FE RID: 6654
	private int 210 = -1;

	// Token: 0x040019FF RID: 6655
	private int 211;

	// Token: 0x04001A00 RID: 6656
	private double 212;

	// Token: 0x04001A01 RID: 6657
	private double 213;

	// Token: 0x04001A02 RID: 6658
	private 1452 214;

	// Token: 0x04001A03 RID: 6659
	private 1452 215;

	// Token: 0x04001A04 RID: 6660
	private 1452 216;

	// Token: 0x04001A05 RID: 6661
	internal int 217;

	// Token: 0x04001A06 RID: 6662
	internal int 218;

	// Token: 0x04001A07 RID: 6663
	internal int 219;

	// Token: 0x04001A08 RID: 6664
	private static bool 220;

	// Token: 0x04001A09 RID: 6665
	internal static List<int> 221;

	// Token: 0x04001A0A RID: 6666
	private 2241 222;
}
