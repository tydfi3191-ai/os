using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;

// Token: 0x0200094E RID: 2382
public sealed class 1711 : 1689
{
	// Token: 0x06004366 RID: 17254 RVA: 0x001A4F50 File Offset: 0x001A3150
	public 1711(2568 1, bool 2 = false) : base(string.Empty, true)
	{
		this.32 = 2;
		this.23 = 1.16;
		int num = 1662.33;
		this.19 = (2 ? -1 : 2230.5(this.23, true, true));
		if (1662.21() && !2)
		{
			1621 3 = new 1621(string.Concat(new string[]
			{
				1296.6,
				"/web/osu-rate.php?u=",
				1304.189,
				"&p=",
				1304.186.1(1643.Hashed),
				"&c=",
				1272.5().23
			}), Array.Empty<object>());
			3.9(new 1621.1622(this.38));
			3.Start();
		}
		this.25 = 20;
		int num2 = 820 - 1662.70.1();
		int num3 = (1662.70.1() - num2) / 2;
		bool flag = this.19 > -1;
		1433 4 = new 1452(flag ? string.Format(1568.1(2679.RankingDialog_LocalRanking), this.19) : string.Empty, (float)(flag ? 22 : 18), new 208((float)num3, (float)this.25), 0.95f, true, flag ? new 198(byte.MaxValue, 203, 33) : new 198(64, 51, 8))
		{
			49 = 1065.Centre
		};
		1445 item = new 1445(1456.Fade, 0f, 1f, 0, 400, (1046)0);
		4.3.Add(item);
		this.AddSprite(4);
		this.25 += 20;
		int num4 = 1662.70.1() - 160;
		int num5 = 10;
		this.27 = new 1364(1568.1(2679.RankingDialog_SaveReplay), 0.7f, new 208((float)num4, (float)num5), 0.95f, false, 0f);
		num5 += 20;
		this.18 = new 1364(1568.1(2679.RankingDialog_AddOnlineFavourite), 0.7f, new 208((float)num4, (float)num5), 0.95f, 1272.5().98, 0f);
		if (!2)
		{
			this.7.14<1433>(this.27.2);
		}
		this.21 = (!2 && this.23.9() > (700)0);
		if (this.21)
		{
			this.25 += 20;
			1662.100.17(new 208((float)(num3 - 100), (float)this.25), false, 0);
			1662.100.25(false);
			this.7.14<1433>(1662.100.36);
			if (this.23.9() < (700)2)
			{
				this.23.35(new 2152(this.14));
				this.20 = new 1452(1568.1(2679.RankingDialog_LoadingResults), 22f, new 208((float)(1662.70.1() / 2), 180f), 208.Zero, 1f, true, 198.White, false);
				this.20.3.Add(new 1445(1456.Fade, 0f, 1f, 0, 200, (1046)1));
				this.20.3.Add(new 1445(1456.Scale, 0f, 1.2f, 0, 200, (1046)1));
				this.20.3.Add(new 1445(1456.Scale, 1.2f, 1f, 200, 1200, (1046)1));
				this.20.3.Add(new 1445(1456.Scale, 1f, 1.1f, 1200, 2400, (1046)1));
				this.20.3[this.20.3.Count - 1].17 = true;
				this.20.3[this.20.3.Count - 1].11 = 1200;
				this.20.3.Add(new 1445(1456.Scale, 1.1f, 1f, 2400, 3600, (1046)2));
				this.20.3[this.20.3.Count - 1].17 = true;
				this.20.3[this.20.3.Count - 1].11 = 1200;
				this.20.49 = 1065.Centre;
				this.7.12(this.20);
			}
			else
			{
				this.14(this.23);
			}
		}
		this.15();
		this.14.9(true);
		198 5 = new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue, 220);
		1433 6 = new 1433(1455.2("ranking-dialog-middle", (1416)1, null), new 208(168.75f, 0f), 0.5f, true, 5)
		{
			20 = new 208(((float)1662.70.1() - 343.75f) * 1.6f, 1f)
		};
		1711.13(6);
		this.AddSprite(6);
		1433 7 = new 1433(1455.2("ranking-dialog-left", (1416)1, null), new 208(0f, 0f), 0.5f, true, 5);
		1711.13(7);
		this.AddSprite(7);
		7 = new 1433(1455.2("ranking-dialog-right", (1416)1, null), (1376)8, 1065.TopRight, (1044)0, new 208(0f, 0f), 0.5f, true, 5, null);
		1711.13(7);
		this.AddSprite(7);
		1433 8 = new 1433(1455.2("ranking-dialog-middle", (1416)1, null), new 208(168.75f, 0f), 0.5f, true, 5)
		{
			20 = new 208(((float)1662.70.1() - 343.75f) * 1.6f, 1f)
		};
		1711.12(8);
		this.AddSprite(8);
		8 = new 1433(1455.2("ranking-dialog-left", (1416)1, null), new 208(0f, 0f), 0.5f, true, 5);
		1711.12(8);
		this.AddSprite(8);
		8 = new 1433(1455.2("ranking-dialog-right", (1416)1, null), (1376)8, 1065.TopRight, (1044)0, new 208(0f, 0f), 0.5f, true, 5, null);
		1711.12(8);
		this.AddSprite(8);
		this.22 = new 1452(1568.1(2679.RankingDialog_CheckingMapRating), 16f, new 208((float)(1662.70.1() / 2), 355f), 0.98f, true, 198.White);
		this.22.49 = 1065.Centre;
		this.22.62(198.OrangeRed);
		int num6 = 25;
		for (int i = 0; i < 10; i++)
		{
			this.24[i] = new 1433(1455.2("star3", (1416)1, null), (1376)6, 1065.Centre, (1044)0, new 208((float)(1662.70.1() / 2 - 144 + 32 * i), this.22.17.Y + (float)num6), 0.98f, true, new 198(0, 0, 0, 50), null);
			this.24[i].9 = i + 1;
			this.24[i] = new 1433(1455.2("star3", (1416)1, null), (1376)6, 1065.Centre, (1044)0, new 208((float)(1662.70.1() / 2 - 144 + 32 * i), this.22.17.Y + (float)num6), 0.99f, true, 198.TransparentWhite, null);
			this.24[i].9 = i + 1;
		}
	}

	// Token: 0x06004367 RID: 17255 RVA: 0x001A578C File Offset: 0x001A398C
	private static void 12(1433 1)
	{
		if (1.38 <= 0)
		{
			return;
		}
		float num = (float)1.38 / 709f;
		float num2 = (float)((int)(477f * num));
		1.37 = (int)(300f * num);
		1.34 = (int)(170f * num);
		float num3 = num2 * 0.625f;
		1.17 = new 208(1.17.X, 1.17.Y + num3);
		1.7 = 1.17;
		1.20 = new 208(1.20.X, (480f - num3) / ((float)1.34 * 0.625f));
	}

	// Token: 0x06004368 RID: 17256 RVA: 0x001A5837 File Offset: 0x001A3A37
	private static void 13(1433 1)
	{
		if (1.38 > 0)
		{
			1.34 = (int)((float)1.38 * 0.67277855f);
		}
	}

	// Token: 0x06004369 RID: 17257 RVA: 0x0001702D File Offset: 0x0001522D
	internal override bool KeepsChatOpen()
	{
		return true;
	}

	// Token: 0x0600436A RID: 17258 RVA: 0x001A5856 File Offset: 0x001A3A56
	private new void 14(object 1)
	{
		1662.89.Schedule(new 1189(this.35), true);
	}

	// Token: 0x0600436B RID: 17259 RVA: 0x001A5870 File Offset: 0x001A3A70
	internal override void Show()
	{
		if (this.23.9() == (700)2)
		{
			1662.100.24();
			this.31 = true;
		}
		base.Show();
	}

	// Token: 0x0600436C RID: 17260 RVA: 0x00005ADD File Offset: 0x00003CDD
	protected override void SubscribeInput()
	{
	}

	// Token: 0x0600436D RID: 17261 RVA: 0x001A5897 File Offset: 0x001A3A97
	protected override void Dispose(bool 1)
	{
		this.47 = true;
		this.34.Dispose();
		this.23.36(new 2152(this.14));
		base.Dispose(1);
	}

	// Token: 0x0600436E RID: 17262 RVA: 0x001A58C9 File Offset: 0x001A3AC9
	internal override void AddSprite(1433 1)
	{
		if (this.35)
		{
			this.34.12(1);
			return;
		}
		base.AddSprite(1);
	}

	// Token: 0x0600436F RID: 17263 RVA: 0x001A58E8 File Offset: 0x001A3AE8
	private new void 15()
	{
		if (this.21 || this.33 || this.16 || this.47)
		{
			return;
		}
		1262 <<EMPTY_NAME>> = 1272.5();
		this.20(<<EMPTY_NAME>>);
		if (2237.2(this.23, <<EMPTY_NAME>>) && this.23.18)
		{
			if (this.20 == null)
			{
				this.20 = new 1452(string.Empty, 22f, new 208((float)(1662.70.1() / 2), 180f), 208.Zero, 1f, true, 198.White, false);
				this.20.49 = 1065.Centre;
				this.7.12(this.20);
			}
			else
			{
				this.20.3.Clear();
				this.20.15 = 1f;
				this.20.16 = 1f;
			}
			this.16();
			return;
		}
		if (this.41 && this.20 == null)
		{
			this.20 = new 1452(string.Empty, 22f, new 208((float)(1662.70.1() / 2), 180f), 208.Zero, 1f, true, 198.White, false);
			this.20.49 = 1065.Centre;
			this.7.12(this.20);
		}
		if (this.23())
		{
			return;
		}
		if (this.23.18 && <<EMPTY_NAME>> != null)
		{
			this.18(<<EMPTY_NAME>>);
			return;
		}
		this.34(null, null, null);
	}

	// Token: 0x06004370 RID: 17264 RVA: 0x001A5A88 File Offset: 0x001A3C88
	private new void 16()
	{
		try
		{
			if (!this.33 && !this.16 && !this.47)
			{
				1262 <<EMPTY_NAME>> = 1272.5();
				double? num = 2237.Get(this.23, <<EMPTY_NAME>>, new Action(this.16));
				if (num == null)
				{
					if (2237.HasFailed(this.23, <<EMPTY_NAME>>))
					{
						if (!this.23())
						{
							this.18(<<EMPTY_NAME>>);
						}
					}
					else
					{
						this.20.SetText("Calculating performance...");
					}
				}
				else
				{
					double? 2 = 2237.3(this.23, <<EMPTY_NAME>>, null);
					List<2241> list = 2230.3(<<EMPTY_NAME>>.23, this.23.9);
					if (this.32)
					{
						if (this.28())
						{
							2210.2216 3 = this.17();
							this.24(3, 3, num, null);
							this.45 = this.46;
						}
						this.37 = this.19(this.23, list);
						if (this.28())
						{
							2210.2216 4 = this.17();
							int? num2 = 2210.76(4.1, new Action(this.16), new 2147?(this.23.9));
							if (this.30(4.1, 4.1))
							{
								return;
							}
							this.36 = 1711.31(4, 4, num2, num2);
						}
						this.34(num, num, 2);
					}
					else
					{
						double? num3 = null;
						if (list != null)
						{
							foreach (2241 5 in list)
							{
								if (5 != this.23 && 5.18 && 2237.2(5, <<EMPTY_NAME>>) && this.29(5))
								{
									double? num4 = 2210.30(5);
									double? num5 = (num4 != null) ? num4 : 2237.Get(5, <<EMPTY_NAME>>, new Action(this.16));
									if (num5 != null || !2237.HasFailed(5, <<EMPTY_NAME>>))
									{
										if (num5 == null)
										{
											this.20.SetText("Calculating performance...");
											return;
										}
										num3 = new double?((num3 != null) ? Math.Max(num3.Value, num5.Value) : num5.Value);
									}
								}
							}
						}
						this.37 = this.19(this.23, list);
						2210.2216 6 = this.17();
						2210.2216 7 = 2210.37(this.23, num);
						int? 8 = 2210.76(6.1, new Action(this.16), new 2147?(this.23.9));
						int? 9 = 2218.Get(7.1, new Action(this.16), this.23.9);
						bool flag = this.30(6.1, 7.1);
						if (!this.23() && !flag)
						{
							this.24(6, 7, num, num3);
							this.37 = this.19(this.23, list);
							this.36 = 1711.31(6, 7, 8, 9);
							this.34(num, num3, 2);
						}
					}
				}
			}
		}
		catch (Exception 10)
		{
			1338.4(10, "the local results table", 1341.Runtime);
			this.34(null, null, null);
		}
	}

	// Token: 0x06004371 RID: 17265 RVA: 0x001A5E38 File Offset: 0x001A4038
	private new 2210.2216 17()
	{
		return 2210.39(null, null, 1304.189.GetValue() ?? string.Empty, this.23.9);
	}

	// Token: 0x06004372 RID: 17266 RVA: 0x001A5E74 File Offset: 0x001A4074
	private void 18(1262 1)
	{
		List<2241> 2 = 2230.3(1.23, this.23.9);
		this.37 = this.19(this.23, 2);
		if (this.28())
		{
			2210.2216 3 = this.17();
			2210.2216 4 = this.32 ? 3 : 2210.37(this.23, null);
			int? num = 2210.76(3.1, null, new 2147?(this.23.9));
			this.36 = 1711.31(3, 4, num, num);
		}
		this.34(null, null, null);
	}

	// Token: 0x06004373 RID: 17267 RVA: 0x001A5F2C File Offset: 0x001A412C
	private string 19(2241 1, List<2241> 2)
	{
		2 = (2 ?? new List<2241>());
		List<2241> list = 2;
		2 = 2.FindAll((2241 1) => 1 == 4 || !2210.31(1));
		2241 previous = null;
		if (!this.32)
		{
			using (List<2241>.Enumerator enumerator = 2.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					2241 3 = enumerator.Current;
					if (3 != 4 && 3.18 && this.29(3) && (previous == null || 3.GetScore() > previous.GetScore()))
					{
						previous = 3;
					}
				}
				goto IL_BE;
			}
		}
		previous = 4;
		IL_BE:
		IFormatProvider provider = 1662.18;
		string text = (previous == null) ? string.Empty : (1 + list.FindAll((2241 1) => 1 != previous && (this.32 || 1 != 4) && (1.GetScore() > previous.GetScore() || (1.GetScore() == previous.GetScore() && 1.7 < previous.7))).Count).ToString(provider);
		string text2 = (1 + list.FindAll(delegate(2241 1)
		{
			if (1 == 4)
			{
				return false;
			}
			if (!this.32)
			{
				return 1.GetScore() >= 4.GetScore();
			}
			return 1.GetScore() > 4.GetScore() || (1.GetScore() == 4.GetScore() && 1.7 < 4.7);
		}).Count).ToString(provider);
		if (this.44 != null)
		{
			text = this.43;
			text2 = this.44;
		}
		else if (this.46 != null)
		{
			text = this.45;
			text2 = this.46;
		}
		return string.Concat(new string[]
		{
			"|rankBefore:",
			text,
			"|rankAfter:",
			text2,
			"|accuracyBefore:",
			(previous == null) ? string.Empty : ((double)previous.CalculateAccuracy() * 100.0).ToString("0.####", provider),
			"|accuracyAfter:",
			((double)4.CalculateAccuracy() * 100.0).ToString("0.####", provider),
			"|maxComboBefore:",
			(previous == null) ? string.Empty : previous.13.ToString(provider),
			"|maxComboAfter:",
			4.13.ToString(provider),
			"|rankedScoreBefore:",
			(previous == null) ? string.Empty : previous.GetScore().ToString(provider),
			"|rankedScoreAfter:",
			4.GetScore().ToString(provider),
			"|totalScoreBefore:",
			(previous == null) ? string.Empty : previous.GetScore().ToString(provider),
			"|totalScoreAfter:",
			4.GetScore().ToString(provider)
		});
	}

	// Token: 0x06004374 RID: 17268 RVA: 0x001A621C File Offset: 0x001A441C
	private void 20(1262 1)
	{
		if (this.40)
		{
			return;
		}
		this.40 = true;
		2023 4 = 2023.Relax | 2023.Relax2 | 2023.Cinema | 2023.ScoreV2;
		if (this.23.9 != 2147.OsuMania)
		{
			4 |= (2023.Random | 2023.Mirror);
		}
		if (this.32 || !this.23.18 || !this.23.41 || 261.FullyOffline || !1631.2(5, 1289.Top) || 2486.14() != this.23.9 || !2019.4(this.23.8) || (this.23.8 & 4) != 2023.None || 2210.69(this.23))
		{
			return;
		}
		this.41 = true;
		long playScore = (long)this.23.GetScore();
		string player = this.23.23 ?? string.Empty;
		1631.8(5, this.23.9, null, delegate(List<string> 1, int 2, string 3)
		{
			this.41 = false;
			if (1 != null)
			{
				this.21(1, 2, playScore, player);
			}
			this.15();
		});
	}

	// Token: 0x06004375 RID: 17269 RVA: 0x001A6338 File Offset: 0x001A4538
	private void 21(List<string> 1, int 2, long 3, string 4)
	{
		string b = 1711.22(4);
		int num = 0;
		long num2 = -1L;
		List<long> list = new List<long>();
		for (int i = 0; i < 5.Count; i++)
		{
			string[] array = 5[i].Split(new char[]
			{
				'|'
			});
			long num3;
			if (array.Length < 3 || !long.TryParse(array[2], NumberStyles.Integer, CultureInfo.InvariantCulture, out num3))
			{
				return;
			}
			if (num == 0 && 1711.22(array[1]) == b)
			{
				num = i + 1;
				num2 = num3;
			}
			else
			{
				list.Add(num3);
			}
		}
		IFormatProvider provider = 1662.18;
		if (num > 0 && num2 >= 3)
		{
			this.43 = (this.44 = num.ToString(provider));
			return;
		}
		int num4 = 1 + list.FindAll((long 1) => 1 >= 3).Count;
		if (num4 > list.Count && num == 0 && (2 > 5.Count || 5.Count >= 100))
		{
			return;
		}
		this.43 = ((num > 0) ? num.ToString(provider) : string.Empty);
		this.44 = num4.ToString(provider);
	}

	// Token: 0x06004376 RID: 17270 RVA: 0x001A646D File Offset: 0x001A466D
	private static string 22(string 1)
	{
		return (1 ?? string.Empty).Trim().Replace('_', ' ').ToLowerInvariant();
	}

	// Token: 0x06004377 RID: 17271 RVA: 0x001A648C File Offset: 0x001A468C
	private bool 23()
	{
		if (!this.41)
		{
			return false;
		}
		if (this.42 < 0)
		{
			this.42 = 1662.33;
			1662.89.2(new 1189(this.15), 5050, false);
		}
		if (1662.33 - this.42 >= 5000)
		{
			return false;
		}
		1452 <<EMPTY_NAME>> = this.20;
		if (<<EMPTY_NAME>> != null)
		{
			<<EMPTY_NAME>>.SetText("Calculating performance...");
		}
		return true;
	}

	// Token: 0x06004378 RID: 17272 RVA: 0x001A6500 File Offset: 0x001A4700
	private void 24(2210.2216 1, 2210.2216 2, double? 3, double? 4)
	{
		1711.<>c__DisplayClass55_0 CS$<>8__locals1 = new 1711.<>c__DisplayClass55_0();
		CS$<>8__locals1.<>4__this = this;
		this.45 = (this.46 = null);
		1262 5 = 1272.5();
		1711.<>c__DisplayClass55_0 CS$<>8__locals2 = CS$<>8__locals1;
		string group;
		if (5 == null || 5.25 <= 0)
		{
			group = this.23.10;
		}
		else
		{
			string str = "#";
			int num = 5.25;
			group = str + num.ToString();
		}
		CS$<>8__locals2.group = group;
		int num2 = 1711.27(2, (2210.2214 1) => 1.1 == CS$<>8__locals1.<>4__this.23);
		if (num2 == 0 && 3 != null)
		{
			num2 = 1711.25(2, 3.Value);
		}
		int num3 = 1711.27(6, (2210.2214 1) => 1711.26(1) == CS$<>8__locals1.group);
		if (num3 == 0 && 4 != null)
		{
			num3 = 1711.25(6, 4.Value);
		}
		if (num2 > 0)
		{
			IFormatProvider provider = 1662.18;
			this.46 = num2.ToString(provider);
			this.45 = ((num3 > 0) ? num3.ToString(provider) : string.Empty);
		}
	}

	// Token: 0x06004379 RID: 17273 RVA: 0x001A6600 File Offset: 0x001A4800
	private static int 25(2210.2216 1, double 2)
	{
		return 1 + 3.9.FindAll((2210.2214 1) => !1.7 && 1.4 > 2).Count;
	}

	// Token: 0x0600437A RID: 17274 RVA: 0x001A6638 File Offset: 0x001A4838
	private static string 26(2210.2214 1)
	{
		if (1.9 <= 0)
		{
			return 1.2;
		}
		return "#" + 1.9.ToString();
	}

	// Token: 0x0600437B RID: 17275 RVA: 0x001A6660 File Offset: 0x001A4860
	private static int 27(2210.2216 1, Predicate<2210.2214> 2)
	{
		int num = 0;
		foreach (2210.2214 3 in 1.9)
		{
			if (!3.7)
			{
				num++;
				if (2(3))
				{
					return num;
				}
			}
		}
		return 0;
	}

	// Token: 0x0600437C RID: 17276 RVA: 0x001A66CC File Offset: 0x001A48CC
	private bool 28()
	{
		return string.Equals(this.23.23 ?? string.Empty, 1304.189.GetValue() ?? string.Empty, StringComparison.OrdinalIgnoreCase);
	}

	// Token: 0x0600437D RID: 17277 RVA: 0x001A66FB File Offset: 0x001A48FB
	private bool 29(2241 1)
	{
		return 1.9 == this.23.9 && 2210.28(1, this.23.23);
	}

	// Token: 0x0600437E RID: 17278 RVA: 0x001A6724 File Offset: 0x001A4924
	private bool 30(double 1, double 2)
	{
		if (2218.3(1, this.23.9) && 2218.3(2, this.23.9))
		{
			return false;
		}
		if (this.39 < 0)
		{
			this.39 = 1662.33;
			1662.89.2(new 1189(this.16), 5050, false);
		}
		if (1662.33 - this.39 >= 5000)
		{
			return false;
		}
		1452 3 = this.20;
		if (3 != null)
		{
			3.SetText("Calculating performance...");
		}
		return true;
	}

	// Token: 0x0600437F RID: 17279 RVA: 0x001A67B8 File Offset: 0x001A49B8
	private static string 31(2210.2216 1, 2210.2216 2, int? 3, int? 4)
	{
		IFormatProvider provider = 1662.18;
		string text = (4 != null) ? ("|rankBefore:" + ((3 != null) ? 3.Value.ToString(provider) : string.Empty) + "|rankAfter:" + 4.Value.ToString(provider)) : string.Empty;
		return string.Concat(new string[]
		{
			text,
			"|ppBefore:",
			1.1.ToString("0.##", provider),
			"|ppAfter:",
			2.1.ToString("0.##", provider),
			"|accuracyBefore:",
			(1.2 * 100.0).ToString("0.####", provider),
			"|accuracyAfter:",
			(2.2 * 100.0).ToString("0.####", provider),
			"|maxComboBefore:",
			1.7.ToString(provider),
			"|maxComboAfter:",
			2.7.ToString(provider),
			"|rankedScoreBefore:",
			1.4.ToString(provider),
			"|rankedScoreAfter:",
			2.4.ToString(provider),
			"|totalScoreBefore:",
			1.3.ToString(provider),
			"|totalScoreAfter:",
			2.3.ToString(provider)
		});
	}

	// Token: 0x06004380 RID: 17280 RVA: 0x001A694C File Offset: 0x001A4B4C
	private void 32(Dictionary<string, string> 1, float 2, int 3, int 4, int 5)
	{
		198 6 = new 198(42, 48, 48);
		198 7 = new 198(40, 40, 40);
		198 8 = new 198(214, 112, 28);
		198 9 = new 198(130, 130, 130);
		IFormatProvider provider = 1662.18;
		string 10 = "-\n ";
		198 11 = 9;
		198 12 = 7;
		string s;
		float num;
		if (1.TryGetValue("ppIfFc", out s) && float.TryParse(s, NumberStyles.Float, provider, out num))
		{
			float num2 = (float)Math.Round((double)num) - (float)Math.Round((double)2);
			10 = num.ToString("#,0", provider) + "pp\n" + ((num2 > 0f) ? ("(+" + num2.ToString("#,0", provider) + "pp)") : "-");
			11 = ((num2 > 0f) ? 198.White : 9);
			12 = ((num2 > 0f) ? 8 : 7);
		}
		string 13 = "-\n ";
		198 14 = 9;
		198 15 = 7;
		string s2;
		float num3;
		if (1.TryGetValue("ppPeak", out s2) && float.TryParse(s2, NumberStyles.Float, provider, out num3))
		{
			float num4 = (float)Math.Round((double)num3) - (float)Math.Round((double)2);
			13 = num3.ToString("#,0", provider) + "pp\n" + ((num4 > 0f) ? ("(+" + num4.ToString("#,0", provider) + "pp)") : "-");
			14 = 198.White;
			15 = 8;
		}
		this.AddSprite(new 1433(1662.34, new 208((float)(3 - 4), (float)(4 - 4)), 0.93f, true, new 198(14, 14, 18))
		{
			20 = new 208(124.8f, 121.6f),
			16 = 0f,
			3 = 
			{
				new 1445(1456.Fade, 0f, 1f, 5 + 100, 5 + 400, (1046)0)
			}
		});
		this.33("If FC", 3, 4, 6, 198.White, true, 5, "pp of this play as a full combo: its 100s and 50s kept, the misses counted as 300s");
		this.33(10, 3, 4 + 10, 12, 11, false, 5, null);
		this.33("Peak pp", 3, 4 + 34, 6, 198.White, true, 5, "The highest pp this play reached on its way");
		this.33(13, 3, 4 + 44, 15, 14, false, 5, null);
	}

	// Token: 0x06004381 RID: 17281 RVA: 0x001A6BC8 File Offset: 0x001A4DC8
	private void 33(string 1, int 2, int 3, 198 4, 198 5, bool 6, int 7, string 8)
	{
		1452 9 = new 1452(1, 6 ? 9f : 11f, new 208((float)2, (float)3), new 208(69f, 0f), 0.95f, true, 198.White, false);
		9.58(4);
		9.62(5);
		9.54(6);
		9.16 = 0f;
		9.75 = (1066)2;
		if (8 != null)
		{
			9.10 = true;
			9.52 = 8;
		}
		9.3.Add(new 1445(1456.Fade, 0f, 0.9f, 7 + 200 + (2 + 3 - 150) / 4, 7 + 200 + (2 + 3 - 150) * 2, (1046)0));
		this.AddSprite(9);
	}

	// Token: 0x06004382 RID: 17282 RVA: 0x001A6C98 File Offset: 0x001A4E98
	private void 34(double? 1, double? 2, double? 3)
	{
		if (this.33)
		{
			return;
		}
		this.33 = true;
		string text = (1 != null) ? ("|ppBefore:" + ((2 != null) ? 2.Value.ToString("0.##", 1662.18) : string.Empty) + "|ppAfter:" + 1.Value.ToString("0.##", 1662.18)) : string.Empty;
		if (1 != null && 3 != null)
		{
			text = text + "|ppIfFc:" + 3.Value.ToString("0.##", 1662.18);
		}
		double? num = 2206.1(this.23);
		if (num != null)
		{
			num = ((1 != null) ? new double?(Math.Max(num.Value, 1.Value)) : num);
			2210.43(this.23, num.Value);
		}
		else
		{
			num = 2210.46(this.23);
		}
		if (1 != null && num != null)
		{
			text = text + "|ppPeak:" + num.Value.ToString("0.##", 1662.18);
		}
		string text2 = (this.44 != null) ? "Beatmap Ranking" : ((this.46 != null) ? "Top play" : "Local Ranking");
		string response = string.Concat(new string[]
		{
			"beatmapId:0\nchartId:beatmap|chartName:",
			text2,
			this.37,
			text,
			"\nchartId:overall|chartName:Overall Ranking",
			this.36,
			"\n"
		});
		1662.89.Schedule(delegate()
		{
			if (!this.16 && this.23.37 == null)
			{
				this.23.37 = response;
				this.35();
			}
		}, true);
	}

	// Token: 0x06004383 RID: 17283 RVA: 0x001A6E70 File Offset: 0x001A5070
	private void 35()
	{
		1711.1712 <<EMPTY_NAME>> = new 1711.1712();
		<<EMPTY_NAME>>.1 = this;
		1677 14 = 1662.78;
		if (14 != 1677.Rank && 14 != 1677.RankingVs && 14 - 1677.RankingTagCoop > 1)
		{
			this.28 = false;
			this.23.37 = null;
			return;
		}
		if (1272.5() == null || this.23 == null || this.23.37 == null || !this.23.37.StartsWith("beatmapId"))
		{
			this.28 = false;
			return;
		}
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		<<EMPTY_NAME>>.2 = new Dictionary<string, string>();
		this.35 = true;
		try
		{
			1711.1714 3 = default(1711.1714);
			3.5 = base.2();
			if (this.4 && !this.31 && this.21)
			{
				1662.100.24();
			}
			if (this.20 != null)
			{
				this.20.3.Clear();
				this.20.15 = 1f;
				this.20.3.Add(new 1445(1456.Fade, 1f, 0f, 3.5, 3.5 + 500, (1046)0));
			}
			1381 4;
			switch (this.23.9)
			{
			case 2147.Taiko:
				4 = 1455.2("mode-taiko", (1416)7, null);
				break;
			case 2147.CatchTheBeat:
				4 = 1455.2("mode-fruits", (1416)7, null);
				break;
			case 2147.OsuMania:
				4 = 1455.2("mode-mania", (1416)7, null);
				break;
			default:
				4 = 1455.2("mode-osu", (1416)7, null);
				break;
			}
			1433 5 = new 1433(4, (1376)8, 1065.Centre, (1044)0, new 208(100f, 230f), 0.94f, true, 198.TransparentWhite, null)
			{
				15 = 0.8f
			};
			5.3.Add(new 1445(1456.Rotation, 0f, 0.1f, 3.5, 3.5 + 5000, (1046)1));
			5.3.Add(new 1445(1456.Fade, 0f, 0.1f, 3.5, 3.5 + 2000, (1046)0));
			5.28 = true;
			this.AddSprite(5);
			198 6 = new 198(42, 48, 48, 0);
			3.6 = new 198(103, 157, 17, byte.MaxValue);
			3.7 = new 198(203, 35, 18, byte.MaxValue);
			3.4 = new 198(31, 175, 231, byte.MaxValue);
			int num = 3 + (1662.70.1() - 640) / 2;
			3.3 = 170;
			3.2 = num;
			3.1 = null;
			new 1445(1456.Fade, 0.78431374f, 1f, 0, 100, (1046)1);
			3.2 += 100;
			3.1 = new 1452("Rank", 9f, new 208((float)3.2, (float)3.3), new 208(69f, 0f), 0.95f, true, 198.White, false);
			3.1.58(6);
			3.1.54(true);
			3.1.16 = 0f;
			3.1.75 = (1066)2;
			3.1.10 = true;
			3.1.3.Add(new 1445(1456.Fade, 0f, 0.9f, 3.5 + 200 + (3.2 + 3.3 - 150) / 4, 3.5 + 200 + (3.2 + 3.3 - 150) * 2, (1046)0));
			this.AddSprite(3.1);
			3.2 += 70;
			3.1 = new 1452(1568.1(2679.RankingDialog_Accuracy), 9f, new 208((float)3.2, (float)3.3), new 208(69f, 0f), 0.95f, true, 198.White, false);
			3.1.58(6);
			3.1.54(true);
			3.1.16 = 0f;
			3.1.75 = (1066)2;
			3.1.10 = true;
			3.1.3.Add(new 1445(1456.Fade, 0f, 0.9f, 3.5 + 200 + (3.2 + 3.3 - 150) / 4, 3.5 + 200 + (3.2 + 3.3 - 150) * 2, (1046)0));
			this.AddSprite(3.1);
			3.2 += 70;
			3.1 = new 1452("Max Combo", 9f, new 208((float)3.2, (float)3.3), new 208(69f, 0f), 0.95f, true, 198.White, false);
			3.1.58(6);
			3.1.54(true);
			3.1.16 = 0f;
			3.1.75 = (1066)2;
			3.1.10 = true;
			3.1.3.Add(new 1445(1456.Fade, 0f, 0.9f, 3.5 + 200 + (3.2 + 3.3 - 150) / 4, 3.5 + 200 + (3.2 + 3.3 - 150) * 2, (1046)0));
			this.AddSprite(3.1);
			3.2 += 70;
			int num2 = this.33 ? 90 : 110;
			3.1 = new 1452(1568.1(2679.RankingDialog_RankedScore), 9f, new 208((float)3.2, (float)3.3), new 208((float)(num2 - 1), 0f), 0.95f, true, 198.White, false);
			3.1.58(6);
			3.1.54(true);
			3.1.16 = 0f;
			3.1.75 = (1066)2;
			3.1.10 = true;
			3.1.3.Add(new 1445(1456.Fade, 0f, 0.9f, 3.5 + 200 + (3.2 + 3.3 - 150) / 4, 3.5 + 200 + (3.2 + 3.3 - 150) * 2, (1046)0));
			this.AddSprite(3.1);
			3.2 += num2;
			3.1 = new 1452(1568.1(2679.RankingDialog_TotalScore), 9f, new 208((float)3.2, (float)3.3), new 208((float)(num2 - 1), 0f), 0.95f, true, 198.White, false);
			3.1.58(6);
			3.1.54(true);
			3.1.16 = 0f;
			3.1.75 = (1066)2;
			3.1.10 = true;
			3.1.3.Add(new 1445(1456.Fade, 0f, 0.9f, 3.5 + 200 + (3.2 + 3.3 - 150) / 4, 3.5 + 200 + (3.2 + 3.3 - 150) * 2, (1046)0));
			this.AddSprite(3.1);
			3.2 += num2;
			3.1 = new 1452("Performance", 9f, new 208((float)3.2, (float)3.3), new 208(69f, 0f), 0.95f, true, 198.White, false);
			3.1.58(6);
			3.1.54(true);
			3.1.16 = 0f;
			3.1.75 = (1066)2;
			3.1.10 = true;
			3.1.3.Add(new 1445(1456.Fade, 0f, 0.9f, 3.5 + 200 + (3.2 + 3.3 - 150) / 4, 3.5 + 200 + (3.2 + 3.3 - 150) * 2, (1046)0));
			this.AddSprite(3.1);
			int num3 = 310 + num2 * 2 + 70;
			int 7 = num + num3 + 10;
			int 8 = 3.3;
			1433 9 = new 1433(1662.34, new 208((float)(num - 4), (float)(3.3 - 4)), 0.93f, true, new 198(14, 14, 18));
			9.20 = new 208((float)(num3 + 8) * 1.6f, (float)(10 + 24 * (Array.FindAll<string>(this.23.37.Split(new char[]
			{
				'\n'
			}), (string 1) => 1.Length > 0).Length - 1) + 8) * 1.6f);
			9.16 = 0f;
			9.3.Add(new 1445(1456.Fade, 0f, 1f, 3.5 + 100, 3.5 + 400, (1046)0));
			this.AddSprite(9);
			3.3 += 10;
			string[] array = this.23.37.Split(new char[]
			{
				'\n'
			});
			foreach (string text in array[0].Split(new char[]
			{
				'|'
			}))
			{
				if (text.Length != 0 && !text.Contains("error:"))
				{
					int num4 = text.IndexOf(':');
					if (num4 >= 0)
					{
						dictionary[text.Remove(num4).Trim()] = text.Substring(num4 + 1).Trim();
					}
				}
			}
			if (dictionary.ContainsKey("beatmapPlaycount"))
			{
				DateTime now = DateTime.Now;
				string arg = "unknown";
				if (!string.IsNullOrEmpty(dictionary["approvedDate"]) && DateTime.TryParse(dictionary["approvedDate"], 1662.18, DateTimeStyles.None, out now))
				{
					arg = now.ToString("MMM, yyyy", 1662.18);
				}
				int num5 = (int)((float)int.Parse(dictionary["beatmapPasscount"]) / (float)int.Parse(dictionary["beatmapPlaycount"]) * 100f);
				3.1 = new 1452(string.Concat(new string[]
				{
					string.Format("{0} by {1}", 1272.5().49, 1272.5().43),
					"\n",
					string.Format(1568.1(2679.RankingDialog_PlaysSince), int.Parse(dictionary["beatmapPlaycount"]), arg),
					" | ",
					string.Format(1568.1(2679.RankingDialog_PassRate), num5)
				}), 14f, new 208(170f, 301f), 0.951f, true, 198.White);
				3.1.62(new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue, 200));
				3.1.75 = (1066)2;
				this.AddSprite(3.1);
			}
			1711.1713 10 = default(1711.1713);
			10.1 = 1;
			while (10.1 < array.Length)
			{
				1711.1716 chartRow = new 1711.1716();
				chartRow.8 = <<EMPTY_NAME>>;
				chartRow.1 = 10.1;
				string text2 = array[10.1];
				if (text2.Length != 0)
				{
					chartRow.8.2 = new Dictionary<string, string>();
					foreach (string text3 in text2.Split(new char[]
					{
						'|'
					}))
					{
						if (text3.Length != 0)
						{
							int num6 = text3.IndexOf(':');
							if (num6 >= 0)
							{
								chartRow.8.2[text3.Remove(num6).Trim()] = text3.Substring(num6 + 1).Trim();
							}
						}
					}
					if (chartRow.8.2.Count != 0)
					{
						chartRow.5 = ((10.1 % 2 == 0) ? new 198(20, 20, 20) : new 198(40, 40, 40));
						3.2 = num;
						chartRow.6 = new EventHandler(chartRow.1);
						chartRow.7 = delegate(object 1, EventArgs 2)
						{
							chartRow.8.1.34.16("chart" + chartRow.1.ToString()).ForEach(delegate(1371 1)
							{
								1.24(0.9f, 100, (1046)2);
							});
							1452 15 = 1 as 1452;
							15.72 = 0;
							15.88 = true;
						};
						chartRow.2 = 0.0;
						chartRow.3 = 0.0;
						chartRow.4 = 0.0;
						bool flag = chartRow.8.2["chartId"] == "beatmap";
						if (chartRow.8.2.ContainsKey("chartEndDate") && chartRow.8.2["chartEndDate"].Length > 0)
						{
							int days = (DateTime.Parse(chartRow.8.2["chartEndDate"], 1662.18) - DateTime.Today).Days;
							int num7 = chartRow.8.2["chartName"].Split(new char[]
							{
								'\n'
							}).Length;
							3.1 = new 1452("(" + days.ToString() + ((days != 1) ? " days" : " day") + " left)", 8f, new 208((float)(3.2 + 2), (float)(3.3 + (num7 + 1) * 12)), new 208(95f, 0f), 0.951f, true, 198.White, false);
							3.1.3.Add(new 1445(1456.Fade, 0f, 0.9f, 3.5 + 200 + (3.2 + 3.3 - 150) / 4, 3.5 + 200 + (3.2 + 3.3 - 150) * 2, (1046)0));
							3.1.16 = 0f;
							3.1.75 = (1066)2;
							3.1.8 = "chart" + 10.1.ToString();
							this.AddSprite(3.1);
						}
						3.1 = new 1452(chartRow.8.2["chartName"] + "\n\t", 11f, new 208((float)3.2, (float)3.3), new 208(99f, 0f), 0.95f, true, 198.Orange, false);
						3.1.58(chartRow.5);
						3.1.3.Add(new 1445(1456.Fade, 0f, 0.9f, 3.5 + 200 + (3.2 + 3.3 - 150) / 4, 3.5 + 200 + (3.2 + 3.3 - 150) * 2, (1046)0));
						3.1.54(true);
						3.1.16 = 0f;
						3.1.75 = (1066)2;
						3.1.35(chartRow.6);
						3.1.37(chartRow.7);
						3.1.10 = true;
						if (chartRow.8.2.ContainsKey("chartUrl"))
						{
							1711.1715 11 = new 1711.1715();
							11.1 = chartRow.8.2["chartUrl"];
							3.1.52 = "Click to view this ranking on the site.";
							3.1.3(new EventHandler(11.1));
						}
						if (chartRow.8.2["chartId"] == "overall" && this.23 != null && chartRow.8.2.ContainsKey("onlineScoreId"))
						{
							this.23.16 = long.Parse(chartRow.8.2["onlineScoreId"]);
						}
						3.1.8 = "chart" + 10.1.ToString();
						this.AddSprite(3.1);
						3.2 += 100;
						chartRow.2("rank", "#{i:#,0}", 70, true, flag, ref 3, ref 10);
						chartRow.2("accuracy", "{i:0.00}%", 70, false, flag, ref 3, ref 10);
						chartRow.2("maxCombo", "{i:#,0}x", 70, false, flag, ref 3, ref 10);
						chartRow.2("rankedScore", "{i:#,0}", num2, false, flag, ref 3, ref 10);
						chartRow.2("totalScore", "{i:#,0}", num2, false, flag, ref 3, ref 10);
						chartRow.2("pp", "{i:#,0}pp", 70, false, flag, ref 3, ref 10);
						if (this.33 && flag)
						{
							this.32(chartRow.8.2, (float)chartRow.2, 7, 8, 3.5);
						}
						3.3 += 24;
					}
				}
				10.1++;
			}
		}
		catch (Exception 12)
		{
			1763.5("An error occurred when displaying the new ranking screen!\nThis has been reported and will be fixed soon!", 198.Red, 5000, null);
			1618 13 = new 1618(12);
			string text4 = "response: \"" + this.23.37 + "\"\n";
			if (dictionary != null)
			{
				foreach (KeyValuePair<string, string> keyValuePair in dictionary)
				{
					text4 = string.Concat(new string[]
					{
						text4,
						keyValuePair.Key,
						" - ",
						keyValuePair.Value,
						"\n"
					});
				}
			}
			text4 += "\n\n";
			if (<<EMPTY_NAME>>.2 != null)
			{
				foreach (KeyValuePair<string, string> keyValuePair2 in <<EMPTY_NAME>>.2)
				{
					text4 = string.Concat(new string[]
					{
						text4,
						keyValuePair2.Key,
						" - ",
						keyValuePair2.Value,
						"\n"
					});
				}
			}
			13.1 = text4;
			1619.1(13);
		}
		finally
		{
			this.35 = false;
		}
		this.23.37 = null;
	}

	// Token: 0x06004384 RID: 17284 RVA: 0x001A835C File Offset: 0x001A655C
	internal override void Close(bool 1 = false)
	{
		if (!this.4)
		{
			return;
		}
		foreach (1371 2 in this.34.28)
		{
			1433 3 = (1433)2;
			3.16(120, (1046)0, 0);
			3.10 = false;
			3.5 = false;
		}
		if (this.23 != null)
		{
			this.23.37 = null;
		}
		if (this.21)
		{
			if (this.18 != null && this.18.4() && !1272.5().98)
			{
				1272.5().98 = true;
				1621 4 = new 1621(string.Format(1661.24(), 1304.189, 1304.186.1(1643.Hashed), 1272.5().29), Array.Empty<object>());
				4.9(new 1621.1622(1711.1717.rankingDialogCallbacks.2));
				4.Start();
			}
			if (1662.100.36 != null)
			{
				1662.100.25(true);
				if (this.7 != null)
				{
					foreach (1433 5 in 1662.100.36)
					{
						this.7.Remove(5);
					}
				}
				if (this.7 != null)
				{
					this.7.20<1433>(1662.100.36);
				}
			}
		}
		if (this.19 > -1)
		{
			if (this.27.4())
			{
				2230.20(this.23, true);
			}
			2210.29(this.23);
			2230.5(this.23, false, true);
		}
		base.Close(1);
	}

	// Token: 0x06004385 RID: 17285 RVA: 0x001A8534 File Offset: 0x001A6734
	protected void 36(object 1, EventArgs 2)
	{
		this.30 = ((1433)4).9;
		foreach (1433 3 in this.24)
		{
			if (3.9 > this.30)
			{
				3.8 = 198.Black;
			}
			else
			{
				3.8 = 198.YellowGreen;
			}
			if (3.15 > 1f)
			{
				3.3.Add(new 1445(1456.Scale, 3.15, 1f, 1662.33, 1662.33 + 500, (1046)0));
			}
		}
		string text = string.Concat(new string[]
		{
			"Vote (",
			this.30.ToString(),
			" star",
			(this.30 > 1) ? "s" : string.Empty,
			")"
		});
		if (this.29 == null)
		{
			this.29 = new 1361(text, new 208(this.24[9].17.X + 32f, this.24[0].17.Y - 11f), new 208(140f, 24f), 0.98f, 198.YellowGreen, delegate(object 1, EventArgs 2)
			{
				1621 6 = new 1621(string.Concat(new string[]
				{
					1296.6,
					"/web/osu-rate.php?u=",
					1304.189,
					"&p=",
					1304.186.1(1643.Hashed),
					"&c=",
					1272.5().23,
					"&v=",
					this.30.ToString()
				}), Array.Empty<object>());
				6.9(new 1621.1622(this.37));
				this.26 = false;
				foreach (1433 7 in this.24)
				{
					7.10 = false;
					if (7.9 > this.30)
					{
						7.39(198.Black, 500, false, (1046)0);
					}
					else
					{
						7.39(198.YellowGreen, 500, false, (1046)0);
					}
					if (7.15 > 1f)
					{
						7.3.Add(new 1445(1456.Scale, 7.15, 1f, 1662.33, 1662.33 + 500, (1046)0));
					}
				}
				this.22.SetText(1568.1(2679.RankingDialog_SendingRating));
				this.29.Hide();
				6.Start();
			}, true, false, null, true);
			this.7.14<1433>(this.29.1);
			this.7.14<1433>(this.29.1);
		}
		else
		{
			this.29.4.SetText(text);
		}
		this.29.1.ForEach(new Action<1433>(1711.1717.rankingDialogCallbacks.3));
	}

	// Token: 0x06004386 RID: 17286 RVA: 0x001A86FD File Offset: 0x001A68FD
	internal override bool OnKeyDown(200 1)
	{
		if (!this.4 || 1535.4())
		{
			return false;
		}
		if (1 == 200.Enter || 1 == 200.Escape)
		{
			this.Close(false);
		}
		return true;
	}

	// Token: 0x06004387 RID: 17287 RVA: 0x001A8724 File Offset: 0x001A6924
	protected void 37(1621 1, Exception 2)
	{
		if (2 == null)
		{
			string text = 1.12();
			if (text.IndexOf('\n') > 0)
			{
				text = text.Substring(text.IndexOf('\n') + 1);
			}
			this.22.SetText(string.Format(1568.1(2679.RankingDialog_RatingResult), text));
			this.39(float.Parse(text, 1662.18));
		}
	}

	// Token: 0x06004388 RID: 17288 RVA: 0x001A8784 File Offset: 0x001A6984
	public override void Update()
	{
		if (this.4 && this.28 && this.21)
		{
			if (this.23.17 > 0)
			{
				this.20.SetText(string.Format(1568.1(2679.RankingDialog_OnlineRanking), this.23.17));
				this.20.3.Add(new 1445(1456.Scale, 1f, 1.1f, 1662.33, 1662.33 + 100, (1046)1));
				this.20.3.Add(new 1445(1456.Scale, 1.1f, 1f, 1662.33 + 100, 1662.33 + 200, (1046)2));
				this.20.62(198.YellowGreen);
			}
			else
			{
				this.20.SetText(1568.1(2679.RankingDialog_OnlineRankingHigherPrevious));
				this.20.40(198.OrangeRed, 400);
				this.20.3.Add(new 1445(1456.Rotation, 0f, 0.1f, 1662.33, 1662.33 + 50, (1046)0));
				this.20.3.Add(new 1445(1456.Rotation, 0.1f, -0.1f, 1662.33 + 50, 1662.33 + 150, (1046)0));
				this.20.3.Add(new 1445(1456.Rotation, -0.1f, 0f, 1662.33 + 150, 1662.33 + 200, (1046)0));
			}
			if (!this.31)
			{
				1662.100.24();
				this.31 = true;
			}
			this.28 = false;
		}
		if (!this.26)
		{
			return;
		}
		int num = -1;
		for (int i = 0; i < 10; i++)
		{
			if (this.24[i].IsHovered())
			{
				num = i;
			}
		}
		for (int j = 0; j < 10; j++)
		{
			this.24[j].39((j <= num) ? 198.White : ((this.24[j].8 == null) ? new 198(35, 162, byte.MaxValue) : ((198)this.24[j].8)), 100, false, (1046)0);
		}
	}

	// Token: 0x06004389 RID: 17289 RVA: 0x001A89D0 File Offset: 0x001A6BD0
	protected void 38(1621 1, Exception 2)
	{
		if (2 != null)
		{
			return;
		}
		string[] array = 1.12().Split(new char[]
		{
			'\n'
		});
		int num = base.2();
		this.26 = (array[0] == "ok");
		if (this.26 && this.23.9 == 1272.5().3())
		{
			this.22.SetText(1568.1(2679.RankingDialog_RatingSuggestion));
			for (int i = 0; i < 10; i++)
			{
				this.24[i].3(new EventHandler(this.36));
				this.24[i].39(new 198(66, 173, byte.MaxValue, byte.MaxValue), 100, false, (1046)0);
				this.24[i].3.Add(new 1445(1456.Fade, 0f, 1f, num + i * 50, num + i * 200, (1046)1));
				this.24[i].10 = true;
				1445 3 = new 1445(1456.Scale, 1f, 1.5f, 0, 300, (1046)0);
				3.15 = (1046)1;
				this.24[i].42 = 3;
			}
			return;
		}
		this.22.SetText("Rating is not available ");
		string a = array[0];
		if (!(a == "alreadyvoted") && !(a == "owner"))
		{
			if (!(a == "auth fail"))
			{
				if (!(a == "no exist"))
				{
					if (a == "not ranked")
					{
						1452 4 = this.22;
						4.SetText(4.GetText() + "because this beatmap is not a ranked map.");
					}
				}
				else
				{
					1452 5 = this.22;
					5.SetText(5.GetText() + "because this beatmap has not been submitted yet.");
				}
			}
			else
			{
				1452 6 = this.22;
				6.SetText(6.GetText() + "because you are not logged in.");
			}
		}
		if (array.Length > 1)
		{
			this.22.SetText("This map has an average rating of ");
			float num2 = float.Parse(array[1], 1662.18);
			this.39(num2);
			1452 7 = this.22;
			7.SetText(7.GetText() + Math.Round((double)num2, 2).ToString());
		}
		this.22.62(198.OrangeRed);
	}

	// Token: 0x0600438A RID: 17290 RVA: 0x001A8C24 File Offset: 0x001A6E24
	private void 39(float 1)
	{
		int num = base.2();
		for (int i = 0; i < 10; i++)
		{
			if (1 > (float)i)
			{
				198 2 = new 198(253, 222, 48, byte.MaxValue);
				this.24[i].16 = 0f;
				if (1 < (float)(i + 1))
				{
					2 = new 198(253, 183, 43, byte.MaxValue);
					this.24[i].3.Add(new 1445(1456.Fade, 0f, 1 - (float)((int)1), num + i * 50, num + i * 200, (1046)1));
				}
				else
				{
					this.24[i].3.Add(new 1445(1456.Fade, 0f, 1f, num + i * 50, num + i * 200, (1046)1));
				}
				this.24[i].3.Add(new 1445(1456.Scale, 1.5f, 1f, num + i * 50, num + i * 200, (1046)1));
				if (this.24[i].19)
				{
					this.24[i].39(2, 100, false, (1046)0);
				}
				else
				{
					this.24[i].6 = 2;
				}
			}
			else if (this.24[i].19)
			{
				this.24[i].16(100, (1046)0, 0);
			}
			else
			{
				this.24[i].6 = 198.TransparentWhite;
				this.24[i].16 = 1f;
				this.24[i].35 = 0;
			}
		}
	}

	// Token: 0x0600438B RID: 17291 RVA: 0x001A8DBC File Offset: 0x001A6FBC
	internal static string 40(int 1, ref 1711.1718 2)
	{
		return 2.1.Replace("i", 1.ToString());
	}

	// Token: 0x04003158 RID: 12632
	private readonly 1364 18;

	// Token: 0x04003159 RID: 12633
	private readonly int 19;

	// Token: 0x0400315A RID: 12634
	private 1452 20;

	// Token: 0x0400315B RID: 12635
	private readonly bool 21;

	// Token: 0x0400315C RID: 12636
	private readonly 1452 22;

	// Token: 0x0400315D RID: 12637
	private readonly 2241 23;

	// Token: 0x0400315E RID: 12638
	private readonly 1433[] 24 = new 1433[10];

	// Token: 0x0400315F RID: 12639
	private readonly int 25;

	// Token: 0x04003160 RID: 12640
	private bool 26;

	// Token: 0x04003161 RID: 12641
	internal 1364 27;

	// Token: 0x04003162 RID: 12642
	private bool 28;

	// Token: 0x04003163 RID: 12643
	private 1361 29;

	// Token: 0x04003164 RID: 12644
	private int 30 = -1;

	// Token: 0x04003165 RID: 12645
	private bool 31;

	// Token: 0x04003166 RID: 12646
	private readonly bool 32;

	// Token: 0x04003167 RID: 12647
	private bool 33;

	// Token: 0x04003168 RID: 12648
	internal readonly 1436 34 = new 1436(true)
	{
		10 = false
	};

	// Token: 0x04003169 RID: 12649
	private bool 35;

	// Token: 0x0400316A RID: 12650
	private string 36 = string.Empty;

	// Token: 0x0400316B RID: 12651
	private string 37 = string.Empty;

	// Token: 0x0400316C RID: 12652
	private const int 38 = 5000;

	// Token: 0x0400316D RID: 12653
	private int 39 = -1;

	// Token: 0x0400316E RID: 12654
	private bool 40;

	// Token: 0x0400316F RID: 12655
	private bool 41;

	// Token: 0x04003170 RID: 12656
	private int 42 = -1;

	// Token: 0x04003171 RID: 12657
	private string 43;

	// Token: 0x04003172 RID: 12658
	private string 44;

	// Token: 0x04003173 RID: 12659
	private string 45;

	// Token: 0x04003174 RID: 12660
	private string 46;

	// Token: 0x04003175 RID: 12661
	private bool 47;

	// Token: 0x0200094F RID: 2383
	public sealed class 1712
	{
		// Token: 0x04003176 RID: 12662
		public 1711 1;

		// Token: 0x04003177 RID: 12663
		public Dictionary<string, string> 2;
	}

	// Token: 0x02000950 RID: 2384
	[Serializable]
	public sealed class 1717
	{
		// Token: 0x0600438E RID: 17294 RVA: 0x001A8F2C File Offset: 0x001A712C
		internal void 1(1371 1)
		{
			1.24(1f, 100, (1046)1);
		}

		// Token: 0x0600438F RID: 17295 RVA: 0x001A8F3C File Offset: 0x001A713C
		internal void 2(1621 1, Exception 2)
		{
			string text = 1.12();
			if (!string.IsNullOrEmpty(text))
			{
				1763.2(text, 2000, (1389)0);
				return;
			}
			1763.2(1568.1(2679.RankingDialog_OnlineFavouriteAdded), 1000, (1389)0);
		}

		// Token: 0x06004390 RID: 17296 RVA: 0x001A8F7A File Offset: 0x001A717A
		internal void 3(1433 1)
		{
			1.40(198.White, 500);
		}

		// Token: 0x04003178 RID: 12664
		public static readonly 1711.1717 rankingDialogCallbacks = new 1711.1717();

		// Token: 0x04003179 RID: 12665
		public static Action<1371> action;

		// Token: 0x0400317A RID: 12666
		public static Action<1371> action2;

		// Token: 0x0400317B RID: 12667
		public static 1621.1622 requestCompletedHandler;

		// Token: 0x0400317C RID: 12668
		public static Action<1433> action3;
	}

	// Token: 0x02000951 RID: 2385
	[StructLayout(LayoutKind.Auto)]
	public struct 1713
	{
		// Token: 0x0400317D RID: 12669
		public int 1;
	}

	// Token: 0x02000952 RID: 2386
	[StructLayout(LayoutKind.Auto)]
	public struct 1714
	{
		// Token: 0x0400317E RID: 12670
		public 1452 1;

		// Token: 0x0400317F RID: 12671
		public int 2;

		// Token: 0x04003180 RID: 12672
		public int 3;

		// Token: 0x04003181 RID: 12673
		public 198 4;

		// Token: 0x04003182 RID: 12674
		public int 5;

		// Token: 0x04003183 RID: 12675
		public 198 6;

		// Token: 0x04003184 RID: 12676
		public 198 7;
	}

	// Token: 0x02000953 RID: 2387
	public sealed class 1716
	{
		// Token: 0x06004393 RID: 17299 RVA: 0x001A8F98 File Offset: 0x001A7198
		internal void 1(object 1, EventArgs 2)
		{
			this.8.1.34.16("chart" + this.1.ToString()).ForEach(new Action<1371>(1711.1717.rankingDialogCallbacks.1));
			1452 3 = 1 as 1452;
			3.72 = 1;
			3.60(198.White);
			3.88 = true;
		}

		// Token: 0x06004394 RID: 17300 RVA: 0x001A9004 File Offset: 0x001A7204
		internal void 2(string 1, string 2, int 3, bool 4, bool 5, ref 1711.1714 6, ref 1711.1713 7)
		{
			1711.1718 8 = default(1711.1718);
			8.1 = 2;
			if (this.8.2.ContainsKey(1 + "After"))
			{
				bool flag = double.TryParse(this.8.2[1 + "After"], NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, 1662.18, out this.2);
				bool flag2 = double.TryParse(this.8.2[1 + "Before"], NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, 1662.18, out this.3);
				bool flag3 = (1 == "pp" && flag2) || this.3 > 0.0;
				bool flag4 = (1 == "pp" && flag) || this.2 > 0.0;
				int digits = (1 == "accuracy") ? 2 : 0;
				this.4 = Math.Round(this.2, digits) - Math.Round(this.3, digits);
				this.4 = Math.Round(this.4, digits);
				bool flag5 = 4 ? (this.4 < 0.0) : (this.4 > 0.0);
				if (!flag3 && flag4)
				{
					6.1 = new 1452(string.Format(1711.40(0, ref 8), this.2) + "\n" + ((!flag3) ? "new!" : "-"), 11f, new 208((float)6.2, (float)6.3), new 208((float)(3 - 1), 0f), 0.95f, true, 198.White, this.4 != 0.0);
					6.1.58((this.4 == 0.0) ? this.5 : 6.4);
					6.1.3.Add(new 1445(1456.Fade, 0f, 0.9f, 6.5 + 200 + (6.2 + 6.3 - 150) / 4, 6.5 + 200 + (6.2 + 6.3 - 150) * 2, (1046)0));
					6.1.16 = 0f;
					6.1.75 = (1066)2;
					6.1.35(this.6);
					6.1.37(this.7);
					6.1.8 = "chart" + 7.1.ToString();
					6.1.10 = true;
					this.8.1.AddSprite(6.1);
				}
				else if (flag5 || !5 || this.8.1.32)
				{
					6.1 = new 1452(string.Format(1711.40(0, ref 8) + "\n" + ((this.4 != 0.0) ? ("({1}" + 1711.40(2, ref 8) + ")") : "-"), this.2, flag5 ? "+" : "-", Math.Abs(this.4)), 11f, new 208((float)6.2, (float)6.3), new 208((float)(3 - 1), 0f), 0.95f, true, 198.White, false);
					6.1.58((this.4 == 0.0) ? this.5 : (flag5 ? 6.6 : 6.7));
					6.1.3.Add(new 1445(1456.Fade, 0f, 0.9f, 6.5 + 200 + (6.2 + 6.3 - 150) / 4, 6.5 + 200 + (6.2 + 6.3 - 150) * 2, (1046)0));
					6.1.16 = 0f;
					6.1.75 = (1066)2;
					6.1.35(this.6);
					6.1.37(this.7);
					6.1.8 = "chart" + 7.1.ToString();
					6.1.10 = true;
					this.8.1.AddSprite(6.1);
				}
				else
				{
					6.1 = new 1452(string.Format("your best: " + (flag3 ? 1711.40(0, ref 8) : "-"), this.3), 8f, new 208((float)(6.2 + 2), (float)(6.3 + 12)), new 208((float)(3 - 1 - 4), 0f), 0.951f, true, 198.White, false);
					6.1.3.Add(new 1445(1456.Fade, 0f, 0.9f, 6.5 + 200 + (6.2 + 6.3 - 150) / 4, 6.5 + 200 + (6.2 + 6.3 - 150) * 2, (1046)0));
					6.1.16 = 0f;
					6.1.75 = (1066)2;
					6.1.8 = "chart" + 7.1.ToString();
					this.8.1.AddSprite(6.1);
					6.1 = new 1452(string.Format((flag4 ? 1711.40(0, ref 8) : "-") + "\n\t", this.2), 11f, new 208((float)6.2, (float)6.3), new 208((float)(3 - 1), 0f), 0.95f, true, 198.White, false);
					6.1.58(this.5);
					6.1.62(198.Gray);
					6.1.3.Add(new 1445(1456.Fade, 0f, 0.9f, 6.5 + 200 + (6.2 + 6.3 - 150) / 4, 6.5 + 200 + (6.2 + 6.3 - 150) * 2, (1046)0));
					6.1.16 = 0f;
					6.1.75 = (1066)2;
					6.1.35(this.6);
					6.1.37(this.7);
					6.1.8 = "chart" + 7.1.ToString();
					6.1.10 = true;
					this.8.1.AddSprite(6.1);
				}
			}
			else
			{
				6.1 = new 1452("-\n ", 11f, new 208((float)6.2, (float)6.3), new 208((float)(3 - 1), 0f), 0.95f, true, 198.White, false);
				6.1.58(this.5);
				6.1.62(198.Gray);
				6.1.3.Add(new 1445(1456.Fade, 0f, 0.9f, 6.5 + 200 + (6.2 + 6.3 - 150) / 4, 6.5 + 200 + (6.2 + 6.3 - 150) * 2, (1046)0));
				6.1.16 = 0f;
				6.1.75 = (1066)2;
				6.1.35(this.6);
				6.1.37(this.7);
				6.1.8 = "chart" + 7.1.ToString();
				6.1.10 = true;
				this.8.1.AddSprite(6.1);
			}
			string a;
			if (1 == "pp" && this.8.2.TryGetValue("chartId", out a) && a == "beatmap" && !this.8.2.ContainsKey("ppAfter"))
			{
				2241 9 = this.8.1.23;
				6.1.52 = ((!9.18) ? "A failed play gives no pp." : "The pp of this play could not be worked out.");
			}
			6.2 += 3;
		}

		// Token: 0x06004395 RID: 17301 RVA: 0x001A99BC File Offset: 0x001A7BBC
		internal void 3(string 1, int 2, 198 3, 198 4, ref 1711.1714 5, ref 1711.1713 6)
		{
			5.1 = new 1452(1, 11f, new 208((float)5.2, (float)5.3), new 208((float)(2 - 1), 0f), 0.95f, true, 198.White, false);
			5.1.58(3);
			5.1.62(4);
			5.1.3.Add(new 1445(1456.Fade, 0f, 0.9f, 5.5 + 200 + (5.2 + 5.3 - 150) / 4, 5.5 + 200 + (5.2 + 5.3 - 150) * 2, (1046)0));
			5.1.16 = 0f;
			5.1.75 = (1066)2;
			5.1.35(this.6);
			5.1.37(this.7);
			5.1.8 = "chart" + 6.1.ToString();
			5.1.10 = true;
			this.8.1.AddSprite(5.1);
			5.2 += 2;
		}

		// Token: 0x04003185 RID: 12677
		public int 1;

		// Token: 0x04003186 RID: 12678
		public double 2;

		// Token: 0x04003187 RID: 12679
		public double 3;

		// Token: 0x04003188 RID: 12680
		public double 4;

		// Token: 0x04003189 RID: 12681
		public 198 5;

		// Token: 0x0400318A RID: 12682
		public EventHandler 6;

		// Token: 0x0400318B RID: 12683
		public EventHandler 7;

		// Token: 0x0400318C RID: 12684
		public 1711.1712 8;
	}

	// Token: 0x02000954 RID: 2388
	public sealed class 1715
	{
		// Token: 0x06004397 RID: 17303 RVA: 0x001A9B25 File Offset: 0x001A7D25
		internal void 1(object 1, EventArgs 2)
		{
			1662.69(this.1);
		}

		// Token: 0x0400318D RID: 12685
		public string 1;
	}

	// Token: 0x02000955 RID: 2389
	[StructLayout(LayoutKind.Auto)]
	public struct 1718
	{
		// Token: 0x0400318E RID: 12686
		public string 1;
	}
}
