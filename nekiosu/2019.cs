using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

// Token: 0x020006C3 RID: 1731
public static class 2019
{
	// Token: 0x06003389 RID: 13193 RVA: 0x0013B6EC File Offset: 0x001398EC
	internal static void 1(2019.2022 1)
	{
		2019.2022 2 = 2019.2;
		2019.2022 3;
		do
		{
			3 = 2;
			2019.2022 value = (2019.2022)Delegate.Combine(3, 1);
			2 = Interlocked.CompareExchange<2019.2022>(ref 2019.2, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x0600338A RID: 13194 RVA: 0x0013B720 File Offset: 0x00139920
	internal static void 2(2019.2022 1)
	{
		2019.2022 2 = 2019.2;
		2019.2022 3;
		do
		{
			3 = 2;
			2019.2022 value = (2019.2022)Delegate.Remove(3, 1);
			2 = Interlocked.CompareExchange<2019.2022>(ref 2019.2, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x0600338B RID: 13195 RVA: 0x0013B753 File Offset: 0x00139953
	internal static void 3()
	{
		if (2019.2 != null)
		{
			2019.2(null, 2019.1);
		}
	}

	// Token: 0x0600338C RID: 13196 RVA: 0x0013B76C File Offset: 0x0013996C
	public static bool 4(2023 1)
	{
		if (2486.14() == 2147.OsuMania)
		{
			if (((2023.HardRock | 2023.Random) & 1) > 2023.None)
			{
				return false;
			}
			if ((2023.KeyCoop & 1) > 2023.None)
			{
				return false;
			}
			if (1272.5().3() == 2147.Osu)
			{
				int num = 2011.53(1272.5(), 1);
				if (num < 4 || num > 9)
				{
					return false;
				}
			}
		}
		return (2023.Autoplay & 1) <= 2023.None && (2023.Target & 1) <= 2023.None;
	}

	// Token: 0x0600338D RID: 13197 RVA: 0x0013B7DD File Offset: 0x001399DD
	internal static void 5()
	{
		2019.1 = 2023.None;
		1939.15(2019.1);
	}

	// Token: 0x0600338E RID: 13198 RVA: 0x0013B7F0 File Offset: 0x001399F0
	internal static void 6(2241 1)
	{
		if (6 == null)
		{
			return;
		}
		2147 2 = 6.9;
		2019.1 = (6.8 & ~2023.TouchDevice);
		2019.7(2023.None);
		1927 overrides = 6.43;
		if (overrides != null && !overrides.IsEmpty)
		{
			1926.6(true);
			1926.13();
			1926.7(overrides.ExtendedLimits);
			if (1926.14(2).Any((1928 1) => overrides.Get(1) != null && 1926.9(1, overrides.Get(1).Value)))
			{
				1926.8(true);
			}
			foreach (1928 3 in 1926.14(2))
			{
				1926.12(3, overrides.Get(3));
			}
		}
		else
		{
			1926.6(false);
		}
		2023 4 = ((2019.1 & (2023.DoubleTime | 2023.Nightcore)) != 2023.None) ? 2023.DoubleTime : (((2019.1 & 2023.HalfTime) != 2023.None) ? 2023.HalfTime : 2023.None);
		1939.Reset(2023.DoubleTime);
		1939.Reset(2023.HalfTime);
		if (4 != 2023.None && 6.44 != null)
		{
			if (1939.7(6.44.Rate))
			{
				1939.2(true);
			}
			1939.12(4, 6.44.Rate);
			1939.14(4, 6.44.AdjustPitch);
		}
		1931.1(6.45 && 1931.2(2));
		1925 5 = 1925.7(2) ? 6.52 : null;
		if (5 != null)
		{
			bool flag = 2 == 2147.Osu;
			1925.12(5.5 != null, (flag && 5.5 != null) ? 5.5.Value : 1925.SelectedMirrorAxes);
			1925.4(5.7 != null, (5.7 != null) ? new int?(5.7.4) : 1925.SelectedRandomSeed, (flag && 5.7 != null) ? 5.7.5 : 1925.SelectedAngleSharpness);
			if ((2 == 2147.Taiko || 2 == 2147.CatchTheBeat) && 5.7 != null)
			{
				1925.6(5.7.9);
			}
			1925.13(5.6);
		}
		else
		{
			1925.Reset();
		}
		2019.3();
	}

	// Token: 0x0600338F RID: 13199 RVA: 0x0013BA28 File Offset: 0x00139C28
	internal static void 7(2023 1)
	{
		switch (2486.14())
		{
		case 2147.Taiko:
			2019.1 &= ~(2023.SpunOut | 2023.Relax2 | 2023.Target);
			break;
		case 2147.CatchTheBeat:
			2019.1 &= ~(2023.SpunOut | 2023.Relax2 | 2023.Target);
			break;
		case 2147.OsuMania:
			2019.1 &= ~(2023.Relax | 2023.SpunOut | 2023.Relax2 | 2023.Target);
			break;
		}
		bool flag = 2486.14() == 2147.OsuMania;
		if (!flag)
		{
			2019.1 &= ~(2023.Key4 | 2023.Key5 | 2023.Key6 | 2023.Key7 | 2023.Key8 | 2023.FadeIn | 2023.Random | 2023.Key9 | 2023.KeyCoop | 2023.Key1 | 2023.Key3 | 2023.Key2 | 2023.Mirror);
		}
		for (long num = (long)((1 != 2023.None) ? 1 : 2023.NoFail); num <= (long)((1 != 2023.None) ? 1 : 2023.Mirror); num *= 2L)
		{
			2023 2 = 2019.1 & (2023)num;
			if (2 <= 2023.Relax)
			{
				if (2 <= 2023.Hidden)
				{
					if (2 != 2023.NoFail)
					{
						if (2 != 2023.Easy)
						{
							if (2 == 2023.Hidden)
							{
								if (flag)
								{
									2019.1 &= ~2023.Flashlight;
									2019.1 &= ~2023.FadeIn;
								}
							}
						}
						else
						{
							2019.1 &= ~2023.HardRock;
						}
					}
					else
					{
						2019.1 &= ~2023.SuddenDeath;
						2019.1 &= ~2023.Perfect;
						2019.1 &= ~2023.Relax2;
						2019.1 &= ~2023.Relax;
					}
				}
				else if (2 <= 2023.SuddenDeath)
				{
					if (2 != 2023.HardRock)
					{
						if (2 == 2023.SuddenDeath)
						{
							2019.1 &= ~2023.NoFail;
							2019.1 &= ~2023.Relax2;
							2019.1 &= ~2023.Relax;
						}
					}
					else
					{
						2019.1 &= ~2023.Easy;
					}
				}
				else if (2 != 2023.DoubleTime)
				{
					if (2 == 2023.Relax)
					{
						2019.1 &= ~2023.Relax2;
						2019.1 &= ~2023.NoFail;
						2019.1 &= ~2023.SuddenDeath;
						2019.1 &= ~2023.Perfect;
					}
				}
				else
				{
					2019.1 &= ~2023.HalfTime;
				}
			}
			else if (2 <= 2023.SpunOut)
			{
				if (2 <= 2023.Nightcore)
				{
					if (2 != 2023.HalfTime)
					{
						if (2 == 2023.Nightcore)
						{
							2019.1 |= 2023.DoubleTime;
						}
					}
					else
					{
						2019.1 &= ~2023.DoubleTime;
						2019.1 &= ~2023.Nightcore;
					}
				}
				else if (2 != 2023.Flashlight)
				{
					if (2 == 2023.SpunOut)
					{
						2019.1 &= ~2023.Relax2;
					}
				}
				else if (flag)
				{
					2019.1 &= ~2023.Hidden;
					2019.1 &= ~2023.FadeIn;
				}
			}
			else if (2 <= 2023.Perfect)
			{
				if (2 != 2023.Relax2)
				{
					if (2 == 2023.Perfect)
					{
						2019.1 |= 2023.SuddenDeath;
					}
				}
				else
				{
					2019.1 &= ~2023.SpunOut;
					2019.1 &= ~2023.Relax;
					2019.1 &= ~2023.NoFail;
					2019.1 &= ~2023.SuddenDeath;
					2019.1 &= ~2023.Perfect;
				}
			}
			else if (2 != 2023.FadeIn)
			{
				if (2 == 2023.Cinema)
				{
					2019.1 |= 2023.Autoplay;
				}
			}
			else
			{
				2019.1 &= ~2023.Hidden;
				2019.1 &= ~2023.Flashlight;
			}
		}
		if ((2019.1 & (2023.Easy | 2023.HardRock)) > 2023.None && 1926.Enabled)
		{
			1926.6(false);
		}
		1939.15(2019.1);
		1925.14(2019.1);
		if ((2019.1 & 2023.Autoplay) > 2023.None)
		{
			2019.1 &= ~2023.SpunOut;
			2019.1 &= ~2023.Relax;
			2019.1 &= ~2023.Relax2;
			2019.1 &= ~2023.SuddenDeath;
			2019.1 &= ~2023.Perfect;
		}
	}

	// Token: 0x17000284 RID: 644
	// (get) Token: 0x06003390 RID: 13200 RVA: 0x0013BE44 File Offset: 0x0013A044
	internal static bool RelaxScoresNormally
	{
		get
		{
			bool? flag = 2019.3;
			if (flag == null)
			{
				return 1304.28.1();
			}
			return flag.GetValueOrDefault();
		}
	}

	// Token: 0x06003391 RID: 13201 RVA: 0x0013BE74 File Offset: 0x0013A074
	internal static double 8()
	{
		2023 <<EMPTY_NAME>> = 2019.1;
		2023 2 = <<EMPTY_NAME>>;
		2023 3 = 2023.ScoreV2;
		if ((2 & 3) <= 2023.None)
		{
			if (2486.14() == 2147.OsuMania)
			{
				<<EMPTY_NAME>> &= ~(2023.Hidden | 2023.HardRock | 2023.DoubleTime | 2023.Flashlight | 2023.FadeIn);
			}
			return 2019.12(<<EMPTY_NAME>>, 2486.14(), 1272.5());
		}
		return 2019.10(<<EMPTY_NAME>>, 2486.14(), 1272.5());
	}

	// Token: 0x06003392 RID: 13202 RVA: 0x0013BEC4 File Offset: 0x0013A0C4
	internal static double 9(2241 1, bool 2)
	{
		if (2)
		{
			return 2019.10(1.8, 1.9, 1.40);
		}
		return 2019.12(1.8, 1.9, 1.40);
	}

	// Token: 0x06003393 RID: 13203 RVA: 0x0013BF04 File Offset: 0x0013A104
	internal static double 10(2023 1, 2147 2, 1262 3)
	{
		1 = 2019.11(1);
		double num = 1.0;
		2023 5;
		if (2 != 2147.Osu)
		{
			if (2 == 2147.CatchTheBeat)
			{
				2023 4 = 1;
				5 = 2023.HardRock;
				if ((4 & 5) > 2023.None)
				{
					1 &= ~2023.HardRock;
					num = num;
				}
				2023 6 = 1;
				5 = 2023.Hidden;
				if ((6 & 5) > 2023.None)
				{
					1 &= ~2023.Hidden;
					num = num;
				}
				2023 7 = 1;
				5 = 2023.DoubleTime;
				if ((7 & 5) > 2023.None)
				{
					1 &= ~2023.DoubleTime;
					num = num;
				}
				2023 8 = 1;
				5 = 2023.Nightcore;
				if ((8 & 5) > 2023.None)
				{
					1 &= ~2023.Nightcore;
					num = num;
				}
			}
		}
		else
		{
			2023 9 = 1;
			5 = 2023.HardRock;
			if ((9 & 5) > 2023.None)
			{
				1 &= ~2023.HardRock;
				num *= 1.1;
			}
			2023 10 = 1;
			5 = 2023.DoubleTime;
			if ((10 & 5) > 2023.None)
			{
				1 &= ~2023.DoubleTime;
				num *= 1.2;
			}
		}
		2023 11 = 1;
		5 = 2023.NoFail;
		if ((11 & 5) > 2023.None)
		{
			1 &= ~2023.NoFail;
		}
		return num * 2019.12(1, 2, 3);
	}

	// Token: 0x06003394 RID: 13204 RVA: 0x0013BFC8 File Offset: 0x0013A1C8
	private static 2023 11(2023 1)
	{
		if (1939.18(1) == null)
		{
			return 1;
		}
		return 1 & ~(2023.DoubleTime | 2023.HalfTime | 2023.Nightcore);
	}

	// Token: 0x06003395 RID: 13205 RVA: 0x0013BFDC File Offset: 0x0013A1DC
	internal static double 12(2023 1, 2147 2, 1262 3)
	{
		1 = 2019.11(1);
		double num = 1.0;
		switch (2)
		{
		case 2147.Osu:
		case 2147.Taiko:
		{
			2023 4 = 2023.NoFail;
			if ((1 & 4) > 2023.None)
			{
				num *= 0.5;
			}
			4 = 2023.Easy;
			if ((1 & 4) > 2023.None)
			{
				num *= 0.5;
			}
			4 = 2023.HalfTime;
			if ((1 & 4) > 2023.None)
			{
				num *= 0.3;
			}
			4 = 2023.Hidden;
			if ((1 & 4) > 2023.None)
			{
				num *= 1.06;
			}
			4 = 2023.HardRock;
			if ((1 & 4) > 2023.None)
			{
				num *= 1.06;
			}
			4 = 2023.DoubleTime;
			if ((1 & 4) > 2023.None)
			{
				num *= 1.12;
			}
			4 = 2023.Flashlight;
			if ((1 & 4) > 2023.None)
			{
				num *= 1.12;
			}
			4 = 2023.SpunOut;
			if ((1 & 4) > 2023.None)
			{
				num *= 0.9;
			}
			if ((1 & 2023.Relax2) > 2023.None || ((1 & 2023.Relax) > 2023.None && !2019.RelaxScoresNormally))
			{
				num *= 0.0;
			}
			break;
		}
		case 2147.CatchTheBeat:
		{
			2023 5 = 2023.NoFail;
			if ((1 & 5) > 2023.None)
			{
				num *= 0.5;
			}
			5 = 2023.Easy;
			if ((1 & 5) > 2023.None)
			{
				num *= 0.5;
			}
			5 = 2023.HalfTime;
			if ((1 & 5) > 2023.None)
			{
				num *= 0.3;
			}
			5 = 2023.Hidden;
			if ((1 & 5) > 2023.None)
			{
				num *= 1.06;
			}
			5 = 2023.HardRock;
			if ((1 & 5) > 2023.None)
			{
				num *= 1.12;
			}
			5 = 2023.DoubleTime;
			if ((1 & 5) > 2023.None)
			{
				num *= 1.06;
			}
			5 = 2023.Flashlight;
			if ((1 & 5) > 2023.None)
			{
				num *= 1.12;
			}
			5 = 2023.SpunOut;
			if ((1 & 5) > 2023.None)
			{
				num *= 0.9;
			}
			if ((1 & 2023.Relax2) > 2023.None || ((1 & 2023.Relax) > 2023.None && !2019.RelaxScoresNormally))
			{
				num *= 0.0;
			}
			break;
		}
		case 2147.OsuMania:
		{
			2023 6 = 2023.NoFail;
			if ((1 & 6) > 2023.None)
			{
				num *= 0.5;
			}
			6 = 2023.Easy;
			if ((1 & 6) > 2023.None)
			{
				num *= 0.5;
			}
			6 = 2023.HalfTime;
			if ((1 & 6) > 2023.None)
			{
				num *= 0.5;
			}
			6 = 2023.SpunOut;
			if ((1 & 6) > 2023.None)
			{
				num *= 0.0;
			}
			6 = 2023.Relax;
			if ((1 & 6) > 2023.None)
			{
				num *= 0.0;
			}
			6 = 2023.Relax2;
			if ((1 & 6) > 2023.None)
			{
				num *= 0.0;
			}
			6 = 2023.Random;
			if ((1 & 6) > 2023.None)
			{
				num = num;
			}
			if (3 != null)
			{
				int num2 = 2011.51(3);
				int num3 = 2011.53(3, 1);
				if (num3 > num2)
				{
					num *= 0.9;
				}
				else if (num3 < num2)
				{
					num *= 0.9 - 0.04 * (double)(num2 - num3);
				}
			}
			break;
		}
		}
		return Math.Max(0.0, num);
	}

	// Token: 0x06003396 RID: 13206 RVA: 0x0013C2C8 File Offset: 0x0013A4C8
	private static string 13(2023 1, bool 2, bool 3, bool 4, bool 5)
	{
		2019.2020 6 = new 2019.2020();
		6.2 = 2;
		if (1 == 2023.None)
		{
			if (!3)
			{
				return string.Empty;
			}
			return "None";
		}
		else
		{
			6.1 = string.Empty;
			2019.2021 7 = new 2019.2021(6.1);
			2147 8 = (1272.5() != null) ? 1272.5().3() : 2147.Osu;
			if ((2023.ScoreV2 & 1) > 2023.None)
			{
				7("ScoreV2", null);
			}
			if ((2023.Cinema & 1) > 2023.None)
			{
				7("Cinema", null);
			}
			else if ((2023.Autoplay & 1) > 2023.None)
			{
				7("Auto", null);
			}
			if (8 == 2147.Osu && (2023.Target & 1) > 2023.None)
			{
				7("TP", "TargetPractice");
			}
			if (8 == 2147.Osu && (2023.SpunOut & 1) > 2023.None)
			{
				7("SO", "SpunOut");
			}
			if ((2023.Easy & 1) > 2023.None)
			{
				7("EZ", "Easy");
			}
			if ((2023.NoFail & 1) > 2023.None)
			{
				7("NF", "NoFail");
			}
			if ((2023.Hidden & 1) > 2023.None)
			{
				7("HD", "Hidden");
			}
			else if ((8 == 2147.Osu || 8 == 2147.OsuMania) && (2023.FadeIn & 1) > 2023.None)
			{
				7("FI", "FadeIn");
			}
			if ((2023.Nightcore & 1) > 2023.None)
			{
				7("NC", "Nightcore");
			}
			else if ((2023.DoubleTime & 1) > 2023.None)
			{
				7("DT", "DoubleTime");
			}
			if ((2023.HalfTime & 1) > 2023.None)
			{
				7("HT", "HalfTime");
			}
			if ((2023.HardRock & 1) > 2023.None)
			{
				7("HR", "HardRock");
			}
			if (8 != 2147.OsuMania && (2023.Relax & 1) > 2023.None)
			{
				7("Relax", null);
			}
			if (8 == 2147.Osu && (2023.Relax2 & 1) > 2023.None)
			{
				7("AP", "AutoPilot");
			}
			if ((2023.Perfect & 1) > 2023.None)
			{
				7("PF", "Perfect");
			}
			else if ((2023.SuddenDeath & 1) > 2023.None)
			{
				7("SD", "SuddenDeath");
			}
			if ((2023.Flashlight & 1) > 2023.None)
			{
				7("FL", "Flashlight");
			}
			if ((2023.TouchDevice & 1) > 2023.None)
			{
				7("TD", "TouchDevice");
			}
			if (8 == 2147.Osu)
			{
				if ((2023.Key1 & 1) > 2023.None)
				{
					7("1K", null);
				}
				else if ((2023.Key2 & 1) > 2023.None)
				{
					7("2K", null);
				}
				else if ((2023.Key3 & 1) > 2023.None)
				{
					7("3K", null);
				}
				else if ((2023.Key4 & 1) > 2023.None)
				{
					7("4K", null);
				}
				else if ((2023.Key5 & 1) > 2023.None)
				{
					7("5K", null);
				}
				else if ((2023.Key6 & 1) > 2023.None)
				{
					7("6K", null);
				}
				else if ((2023.Key7 & 1) > 2023.None)
				{
					7("7K", null);
				}
				else if ((2023.Key8 & 1) > 2023.None)
				{
					7("8K", null);
				}
				else if ((2023.Key9 & 1) > 2023.None)
				{
					7("9K", null);
				}
			}
			if (8 == 2147.Osu || 8 == 2147.OsuMania)
			{
				if ((2023.KeyCoop & 1) > 2023.None)
				{
					7("2P", "Co-op");
				}
				if ((2023.Random & 1) > 2023.None)
				{
					7("RD", "Random");
				}
				if ((2023.Mirror & 1) > 2023.None)
				{
					7("MR", "Mirror");
				}
			}
			6.1 = 6.1.Trim(new char[]
			{
				','
			});
			if (6.1.Length == 0)
			{
				return string.Empty;
			}
			if (4)
			{
				6.1 = "(" + 6.1 + ")";
			}
			if (5)
			{
				2019.2020 9 = 6;
				9.1 += " ";
			}
			return 6.1;
		}
	}

	// Token: 0x06003397 RID: 13207 RVA: 0x0013C6EA File Offset: 0x0013A8EA
	internal static string 14(2023 1, bool 2)
	{
		return 2019.13(1, false, 2, false, false);
	}

	// Token: 0x06003398 RID: 13208 RVA: 0x0013C6F6 File Offset: 0x0013A8F6
	internal static string 15(2023 1, bool 2, bool 3)
	{
		return 2019.13(1, true, false, 2, 3);
	}

	// Token: 0x06003399 RID: 13209 RVA: 0x0013C704 File Offset: 0x0013A904
	internal static List<1433> 16(2023 1, 208 2, float 3, string 4)
	{
		List<1433> list = new List<1433>();
		int num = 0;
		float num2 = 0f;
		foreach (object obj in Enum.GetValues(typeof(2023)))
		{
			2023 5 = (2023)obj;
			2023 6 = 5;
			if ((1 & 6) > 2023.None)
			{
				if (5 == 2023.DoubleTime)
				{
					6 = 2023.Nightcore;
					if ((1 & 6) > 2023.None)
					{
						continue;
					}
				}
				if (5 == 2023.SuddenDeath)
				{
					6 = 2023.Perfect;
					if ((1 & 6) > 2023.None)
					{
						continue;
					}
				}
				list.Add(new 1433(1455.2("selection-mod-" + 5.ToString().ToLower(), (1416)7, null), (1376)6, 1065.Centre, (1044)0, 2, 0.975f + num2, true, 198.TransparentWhite, null)
				{
					8 = 4,
					3 = 
					{
						new 1445(1456.Scale, 2f * 3, 3, 1662.33 + num, 1662.33 + num + 400, (1046)0)
						{
							15 = (1046)1
						},
						new 1445(1456.Fade, 0f, 1f, 1662.33 + num, 1662.33 + num + 400, (1046)0)
						{
							15 = (1046)1
						}
					}
				});
				num += 200;
				num2 += 1E-05f;
				2.X += 20f * 3;
			}
		}
		return list;
	}

	// Token: 0x04002663 RID: 9827
	internal static 2023 1;

	// Token: 0x04002664 RID: 9828
	private static 2019.2022 2;

	// Token: 0x04002665 RID: 9829
	internal static bool? 3;

	// Token: 0x020006C4 RID: 1732
	// (Invoke) Token: 0x0600339B RID: 13211
	public delegate void 2022(object 1, 2023 2);

	// Token: 0x020006C5 RID: 1733
	// (Invoke) Token: 0x0600339F RID: 13215
	public delegate void 2021(string 1, string 2 = null);

	// Token: 0x020006C6 RID: 1734
	public sealed class 2020
	{
		// Token: 0x060033A2 RID: 13218 RVA: 0x0013C89C File Offset: 0x0013AA9C
		internal void 1(string 1, string 2)
		{
			this.1 = this.1 + (this.2 ? 1 : (2 ?? 1)) + ",";
		}

		// Token: 0x04002666 RID: 9830
		public string 1;

		// Token: 0x04002667 RID: 9831
		public bool 2;
	}
}
