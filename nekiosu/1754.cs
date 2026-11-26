using System;
using System.Collections.Generic;

// Token: 0x020008F1 RID: 2289
public sealed class 1754 : 1689
{
	// Token: 0x06004137 RID: 16695 RVA: 0x00194C88 File Offset: 0x00192E88
	public 1754(2018 1) : base(1568.1(2679.ModSelection_Title), true)
	{
		this.20 = 7;
		if (1662.78 == 1677.SelectPlay && (this.20 & (2018)2) > (2018)0 && 1754.ShowsRateHint)
		{
			1452 8 = 1754.12(this.3);
			this.7.12(8);
			this.3 += 8.GetTextSize().Y;
		}
		1436 3 = this.7;
		1452 4 = new 1452(string.Empty, 30f, new 208(0f, this.3 - 20f), 208.Zero, 0.94f, true, 198.White, true)
		{
			41 = (1376)7
		};
		1452 5 = 4;
		this.19 = 4;
		3.12(5);
		this.19.49 = 1065.Centre;
		this.3 += this.19.GetTextSize().Y + 35f;
		this.18 = this.3;
		this.7.12(new 1452(1568.1(2679.ModSelection_Reduction), 24f, new 208(20f, this.3 - 13f), 208.Zero, 0.94f, true, 198.LimeGreen, true));
		if ((this.20 & (2018)10) > (2018)0)
		{
			this.14(new 1751(this.15(0, 0), new 2023[]
			{
				2023.Easy
			}));
		}
		if ((this.20 & (2018)10) > (2018)0)
		{
			this.14(new 1751(this.15(0, 1), new 2023[]
			{
				2023.NoFail
			}));
		}
		if ((this.20 & (2018)2) > (2018)0)
		{
			this.14(new 1751(this.15(0, 2), new 2023[]
			{
				2023.HalfTime
			}));
		}
		this.3 += 60f;
		this.7.12(new 1452(1568.1(2679.ModSelection_Increase), 24f, new 208(20f, this.3 - 13f), 208.Zero, 0.94f, true, 198.OrangeRed, true));
		if ((this.20 & (2018)10) > (2018)0)
		{
			this.14(new 1751(this.15(1, 0), new 2023[]
			{
				2023.HardRock
			}));
		}
		if ((this.20 & (2018)4) > (2018)0)
		{
			this.14(new 1751(this.15(1, 1), new 2023[]
			{
				2023.SuddenDeath,
				2023.Perfect
			}));
		}
		else if ((this.20 & (2018)10) > (2018)0)
		{
			this.14(new 1751(this.15(1, 1), new 2023[]
			{
				2023.SuddenDeath
			}));
		}
		if ((this.20 & (2018)2) > (2018)0)
		{
			this.14(new 1751(this.15(1, 2), new 2023[]
			{
				2023.DoubleTime,
				2023.Nightcore
			}));
		}
		if ((this.20 & (2018)10) > (2018)0)
		{
			if (2486.14() == 2147.OsuMania)
			{
				this.14(new 1751(this.15(1, 3), new 2023[]
				{
					2023.FadeIn,
					2023.Hidden
				}));
			}
			else
			{
				this.14(new 1751(this.15(1, 3), new 2023[]
				{
					2023.Hidden
				}));
			}
			this.14(new 1751(this.15(1, 4), new 2023[]
			{
				2023.Flashlight
			}));
		}
		this.3 += 60f;
		this.7.12(new 1452(1568.1(2679.ModSelection_Special), 24f, new 208(20f, this.3 - 13f), 208.Zero, 0.94f, true, 198.White, true));
		int num = 0;
		if ((this.20 & (2018)10) > (2018)0)
		{
			if (2486.14() == 2147.OsuMania)
			{
				this.14(new 1751(this.15(2, num++), new 2023[]
				{
					2023.Key4,
					2023.Key5,
					2023.Key6,
					2023.Key7,
					2023.Key8,
					2023.Key9,
					2023.Key1,
					2023.Key2,
					2023.Key3
				}));
				this.14(new 1751(this.15(2, num++), new 2023[]
				{
					2023.KeyCoop
				}));
				this.14(new 1751(this.15(2, num++), new 2023[]
				{
					2023.Mirror
				}));
				this.14(new 1751(this.15(2, num++), new 2023[]
				{
					2023.Random
				}));
			}
			else
			{
				this.14(new 1751(this.15(2, num++), new 2023[]
				{
					2023.Relax
				}));
			}
			if (2486.14() == 2147.Osu)
			{
				this.14(new 1751(this.15(2, num++), new 2023[]
				{
					2023.Relax2
				}));
				this.14(new 1751(this.15(2, num++), new 2023[]
				{
					2023.SpunOut
				}));
			}
		}
		if ((this.20 & (2018)4) > (2018)0)
		{
			this.14(new 1751(this.15(2, num++), new 2023[]
			{
				2023.Autoplay,
				2023.Cinema
			}));
		}
		if ((this.20 & (2018)4) > (2018)0)
		{
			this.14(new 1751(this.15(2, num++), new 2023[]
			{
				2023.ScoreV2
			}));
		}
		this.3 += 60f;
		base.7(1568.1(2679.ModSelection_Reset), 198.OrangeRed, delegate(object 1, EventArgs 2)
		{
			bool flag2 = 1891.6(2019.1) > 2023.None;
			2019.5();
			this.19();
			if (flag2)
			{
				2019.3();
			}
		}, false, false, true);
		bool flag = 1662.78 == 1677.SelectPlay;
		if (flag)
		{
			1361 6 = base.7("Next", 198.YellowGreen, delegate(object 1, EventArgs 2)
			{
				this.Close(false);
				1662.25(new 1746());
			}, false, true, true);
			base.6(6);
			this.3 -= 50f;
		}
		base.7(1568.1(2679.General_Close), 198.Gray, new EventHandler(this.18), true, flag, !flag);
	}

	// Token: 0x170002D6 RID: 726
	// (get) Token: 0x06004138 RID: 16696 RVA: 0x0019527D File Offset: 0x0019347D
	private static bool ShowsRateHint
	{
		get
		{
			return !1304.43.1() || !1304.44.1();
		}
	}

	// Token: 0x06004139 RID: 16697 RVA: 0x0019529C File Offset: 0x0019349C
	private static 1452 12(float 1)
	{
		return new 1452("Right-click HT or DT to change the speed (rate change).", 24f, new 208(2f, 1 - 50f), new 208((float)(1662.70.1() - 2), 0f), 0.92f, true, new 198(byte.MaxValue, 204, 34), true);
	}

	// Token: 0x0600413A RID: 16698 RVA: 0x001952F8 File Offset: 0x001934F8
	internal static float 13()
	{
		string text = 1568.1(2679.ModSelection_Title);
		float num = 0f;
		if (!string.IsNullOrEmpty(text))
		{
			1452 <<EMPTY_NAME>> = new 1452(text, 24f, new 208(2f, 2f), new 208((float)(1662.70.1() - 2), 0f), 0.92f, true, 198.White, true);
			num = <<EMPTY_NAME>>.GetTextSize().Y + <<EMPTY_NAME>>.17.Y + 50f;
		}
		if (!1754.ShowsRateHint)
		{
			return num;
		}
		return num + 1754.12(num).GetTextSize().Y;
	}

	// Token: 0x0600413B RID: 16699 RVA: 0x00195398 File Offset: 0x00193598
	private new void 14(1751 1)
	{
		1.5 = (EventHandler)Delegate.Combine(1.5, new EventHandler(this.17));
		foreach (2023 key in 1.4)
		{
			this.21.Add(key, 1);
		}
		this.7.14<1433>(1.1);
		2023 rateMod = 1.4[0];
		if (1662.78 == 1677.SelectPlay && rateMod == 2023.Relax)
		{
			1.6 = delegate()
			{
				this.Close(false);
				1662.25(new 1760(this.20));
			};
			1433 2 = 1.1[0];
			2.52 += "\nRight-click for its settings.";
		}
		if (1662.78 == 1677.SelectPlay && rateMod == 2023.Flashlight)
		{
			1.6 = delegate()
			{
				this.Close(false);
				1662.25(new 1748(this.20));
			};
			1433 3 = 1.1[0];
			3.52 += "\nRight-click for its settings.";
		}
		if (1662.78 == 1677.SelectPlay && rateMod == 2023.Hidden && 1925.SelectedPlayMode == 2147.Osu)
		{
			1.6 = delegate()
			{
				this.Close(false);
				1662.25(new 1749(this.20));
			};
			1433 4 = 1.1[0];
			4.52 += "\nRight-click for its settings.";
		}
		if (1662.78 == 1677.SelectPlay && (rateMod == 2023.DoubleTime || rateMod == 2023.HalfTime))
		{
			1.6 = delegate()
			{
				((rateMod == 2023.DoubleTime) ? 1304.44 : 1304.43).2(true);
				this.Close(false);
				1662.25(new 1759(rateMod, this.20));
			};
			1433 5 = 1.1[0];
			5.52 += "\nRight-click to change the speed.";
			1452 6 = new 1452(string.Empty, 12f, 1.1[0].7 + new 208(0f, 34f), 0.95f, true, 198.White);
			6.49 = 1065.Centre;
			this.7.12(6);
			this.23[rateMod] = 6;
		}
	}

	// Token: 0x0600413C RID: 16700 RVA: 0x001955DC File Offset: 0x001937DC
	internal new 208 15(int 1, int 2)
	{
		return new 208((float)(240 + 2 * 66), this.18 + (float)(1 * 60));
	}

	// Token: 0x0600413D RID: 16701 RVA: 0x001955FC File Offset: 0x001937FC
	internal new bool 16(2023 1, bool? 2, bool 3)
	{
		1751 4 = null;
		if (!this.21.TryGetValue(1, out 4))
		{
			return false;
		}
		if (2 == null)
		{
			if (4.3 == 1 || 4.4[0] == 1)
			{
				4.2(false);
			}
			else
			{
				4.1(true, 1, 3);
			}
		}
		else
		{
			4.1(2.Value, 1, 3);
		}
		return true;
	}

	// Token: 0x0600413E RID: 16702 RVA: 0x00195664 File Offset: 0x00193864
	private new void 17(object 1, EventArgs 2)
	{
		if (this.4 && !this.22)
		{
			1751 3 = 1 as 1751;
			if (3 != null)
			{
				2023 4 = 2019.1;
				foreach (2023 5 in 3.4)
				{
					2019.1 &= ~5;
				}
				2019.1 |= 3.3;
				2019.7(3.3);
				this.22 = true;
				this.19();
				this.22 = false;
				if (1891.6(4) != 1891.6(2019.1))
				{
					2019.3();
				}
				return;
			}
		}
	}

	// Token: 0x0600413F RID: 16703 RVA: 0x00195728 File Offset: 0x00193928
	internal override void Show()
	{
		base.Show();
	}

	// Token: 0x06004140 RID: 16704 RVA: 0x00195730 File Offset: 0x00193930
	internal override void OnShown()
	{
		this.22 = true;
		this.19();
		this.22 = false;
		base.OnShown();
	}

	// Token: 0x06004141 RID: 16705 RVA: 0x00005ADD File Offset: 0x00003CDD
	private void 18(object 1, EventArgs 2)
	{
	}

	// Token: 0x06004142 RID: 16706 RVA: 0x0019574C File Offset: 0x0019394C
	private void 19()
	{
		2019.7(2023.None);
		long num = 1L;
		while (num <= 1073741824L)
		{
			2023 <<EMPTY_NAME>> = (2023)num;
			2023 2 = <<EMPTY_NAME>>;
			2023 3 = 2019.1;
			2023 4 = 2;
			bool flag = (3 & 4) > 2023.None;
			if (flag)
			{
				goto IL_56;
			}
			1751 5 = null;
			if (!this.21.TryGetValue(<<EMPTY_NAME>>, out 5) || 5.3 == 2023.None || flag)
			{
				goto IL_56;
			}
			2 = 5.3;
			2023 6 = 2019.1;
			4 = 2;
			if ((6 & 4) <= 2023.None)
			{
				goto IL_56;
			}
			IL_66:
			num *= 2L;
			continue;
			IL_56:
			this.16(<<EMPTY_NAME>>, new bool?(flag), false);
			goto IL_66;
		}
		this.20();
	}

	// Token: 0x06004143 RID: 16707 RVA: 0x001957D4 File Offset: 0x001939D4
	private void 20()
	{
		foreach (KeyValuePair<2023, 1452> keyValuePair in this.23)
		{
			1940 <<EMPTY_NAME>> = 1939.16(2019.1);
			bool flag = <<EMPTY_NAME>> != null && 1939.1(2019.1) == (keyValuePair.Key == 2023.DoubleTime);
			keyValuePair.Value.SetText((flag && 1939.11(keyValuePair.Key)) ? <<EMPTY_NAME>>.1() : string.Empty);
		}
		double num = 2019.8();
		this.19.SetText(string.Format("Score Multiplier: {0:0.00}x", num));
		if (num > 1.0)
		{
			this.19.39(198.GreenYellow, 400, false, (1046)0);
			return;
		}
		if (num < 1.0)
		{
			this.19.39(198.OrangeRed, 400, false, (1046)0);
			return;
		}
		this.19.39(198.White, 400, false, (1046)0);
	}

	// Token: 0x06004144 RID: 16708 RVA: 0x001958F8 File Offset: 0x00193AF8
	public override void Update()
	{
		base.Update();
		if (1662.78 == 1677.Play)
		{
			this.Close(true);
		}
	}

	// Token: 0x06004145 RID: 16709 RVA: 0x00195910 File Offset: 0x00193B10
	internal static 2023 21(200 1)
	{
		switch (1548.9(1, 1531.ModSelect))
		{
		case 1532.Easy:
			return 2023.Easy;
		case 1532.NoFail:
			return 2023.NoFail;
		case 1532.HalfTime:
			return 2023.HalfTime;
		case 1532.HardRock:
			return 2023.HardRock;
		case 1532.SuddenDeath:
			if (1549.3)
			{
				return 2023.Perfect;
			}
			return 2023.SuddenDeath;
		case 1532.DoubleTime:
			if (1549.3)
			{
				return 2023.Nightcore;
			}
			return 2023.DoubleTime;
		case 1532.Hidden:
			if (!1549.3 && 2486.14() == 2147.OsuMania)
			{
				return 2023.FadeIn;
			}
			return 2023.Hidden;
		case 1532.Flashlight:
			return 2023.Flashlight;
		case 1532.Relax:
			if (2486.14() == 2147.OsuMania)
			{
				return 2023.Key4;
			}
			return 2023.Relax;
		case 1532.Autopilot:
			if (2486.14() == 2147.OsuMania)
			{
				return 2023.Random;
			}
			return 2023.Relax2;
		case 1532.SpunOut:
			return 2023.SpunOut;
		case 1532.Auto:
			if (1549.3)
			{
				return 2023.Cinema;
			}
			return 2023.Autoplay;
		case 1532.ScoreV2:
			return 2023.ScoreV2;
		default:
			return 2023.None;
		}
	}

	// Token: 0x06004146 RID: 16710 RVA: 0x001959FC File Offset: 0x00193BFC
	internal override bool OnKeyDown(200 1)
	{
		if (1939.21(1))
		{
			this.19();
			return true;
		}
		2023 2 = 1754.21(1);
		if (2 != 2023.None)
		{
			this.16(2, null, true);
			return true;
		}
		if (2486.14() == 2147.OsuMania)
		{
			switch (1)
			{
			case 200.D0:
				if ((2019.1 | 2023.KeyMod) != 2023.None)
				{
					this.16(2023.Key4, new bool?(false), true);
				}
				return true;
			case 200.D3:
				2 = 2023.Key3;
				break;
			case 200.D4:
				2 = 2023.Key4;
				break;
			case 200.D5:
				2 = 2023.Key5;
				break;
			case 200.D6:
				2 = 2023.Key6;
				break;
			case 200.D7:
				2 = 2023.Key7;
				break;
			case 200.D8:
				2 = 2023.Key8;
				break;
			case 200.D9:
				2 = 2023.Key9;
				break;
			}
			if (2 != 2023.None)
			{
				2023 3 = 2;
				2023 4 = 2019.1;
				2023 5 = 3;
				if ((4 & 5) <= 2023.None)
				{
					this.16(2, new bool?(true), true);
				}
				return true;
			}
		}
		if (1 == 200.F1)
		{
			this.Close(false);
			return true;
		}
		return base.OnKeyDown(1);
	}

	// Token: 0x06004147 RID: 16711 RVA: 0x00195B04 File Offset: 0x00193D04
	internal override void Close(bool 1 = false)
	{
		base.Close(1);
	}

	// Token: 0x04002FB0 RID: 12208
	private float 18;

	// Token: 0x04002FB1 RID: 12209
	private 1452 19;

	// Token: 0x04002FB2 RID: 12210
	private readonly 2018 20;

	// Token: 0x04002FB3 RID: 12211
	private Dictionary<2023, 1751> 21 = new Dictionary<2023, 1751>();

	// Token: 0x04002FB4 RID: 12212
	private bool 22;

	// Token: 0x04002FB5 RID: 12213
	private readonly Dictionary<2023, 1452> 23 = new Dictionary<2023, 1452>();
}
