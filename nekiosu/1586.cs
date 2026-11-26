using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

// Token: 0x020009C7 RID: 2503
internal static class 1586
{
	// Token: 0x0600460E RID: 17934 RVA: 0x001B8094 File Offset: 0x001B6294
	internal static string 1(double 1)
	{
		return Math.Round(1, 2).ToString("0.##", CultureInfo.InvariantCulture);
	}

	// Token: 0x0600460F RID: 17935 RVA: 0x001B80BA File Offset: 0x001B62BA
	internal static string 2(double 1)
	{
		return 1.ToString("0.00", CultureInfo.InvariantCulture);
	}

	// Token: 0x06004610 RID: 17936 RVA: 0x001B80CD File Offset: 0x001B62CD
	internal static string 3(double 1)
	{
		return 1.ToString("#,0.##", CultureInfo.InvariantCulture);
	}

	// Token: 0x06004611 RID: 17937 RVA: 0x001B80E0 File Offset: 0x001B62E0
	internal static string 4(long 1)
	{
		return 1.ToString("#,0", CultureInfo.InvariantCulture);
	}

	// Token: 0x06004612 RID: 17938 RVA: 0x001B80F4 File Offset: 0x001B62F4
	internal static string 5(string 1)
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (char c in 1 ?? string.Empty)
		{
			if (c == '\\' || c == '*' || c == '_' || c == '~' || c == '`' || c == '|' || c == '>')
			{
				stringBuilder.Append('\\');
			}
			stringBuilder.Append(c);
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06004613 RID: 17939 RVA: 0x001B8165 File Offset: 0x001B6365
	internal static string 6(string 1, int 2)
	{
		if (1.Length > 2)
		{
			return 1.Substring(0, 2 - 1) + "…";
		}
		return 1;
	}

	// Token: 0x06004614 RID: 17940 RVA: 0x001B8188 File Offset: 0x001B6388
	internal static string 7(DateTime 1)
	{
		return new DateTimeOffset(DateTime.SpecifyKind(1, DateTimeKind.Utc)).ToUnixTimeSeconds().ToString(CultureInfo.InvariantCulture);
	}

	// Token: 0x06004615 RID: 17941 RVA: 0x001B81B8 File Offset: 0x001B63B8
	internal static string 8(DateTime 1)
	{
		DateTime utcNow = DateTime.UtcNow;
		long num = Math.Max(0L, (long)(utcNow - 1).TotalSeconds);
		long num2;
		string text;
		if (num < 60L)
		{
			num2 = num;
			text = "second";
		}
		else if (num < 3600L)
		{
			num2 = num / 60L;
			text = "minute";
		}
		else if (num < 86400L)
		{
			num2 = num / 3600L;
			text = "hour";
		}
		else if (num < 604800L)
		{
			num2 = num / 86400L;
			text = "day";
		}
		else if (num < 2419200L)
		{
			num2 = num / 604800L;
			text = "week";
		}
		else
		{
			long num3 = (long)(12 * (utcNow.Year - 1.Year) + utcNow.Month - 1.Month);
			if (utcNow.Day < 1.Day)
			{
				num3 -= 1L;
			}
			if (num3 < 12L)
			{
				num2 = Math.Max(1L, num3);
				text = "month";
			}
			else
			{
				num2 = num3 / 12L;
				text = "year";
			}
		}
		return string.Concat(new string[]
		{
			num2.ToString(),
			" ",
			text,
			(num2 == 1L) ? string.Empty : "s",
			" ago"
		});
	}

	// Token: 0x06004616 RID: 17942 RVA: 0x001B8304 File Offset: 0x001B6504
	internal static string 9(int 1)
	{
		return (1 / 60).ToString() + ":" + (1 % 60).ToString("00", CultureInfo.InvariantCulture);
	}

	// Token: 0x06004617 RID: 17943 RVA: 0x001B8340 File Offset: 0x001B6540
	internal static string Emote(string 1, string 2)
	{
		string text = 1584.Emote(1);
		if (text.Length <= 0)
		{
			return 2;
		}
		return text;
	}

	// Token: 0x06004618 RID: 17944 RVA: 0x001B8360 File Offset: 0x001B6560
	internal static string 10(string 1)
	{
		string text = 1584.Emote(1);
		int num = text.LastIndexOf(':');
		if (num <= 0)
		{
			return null;
		}
		return text.Substring(num + 1).TrimEnd(new char[]
		{
			'>'
		});
	}

	// Token: 0x06004619 RID: 17945 RVA: 0x001B839C File Offset: 0x001B659C
	internal static string 11(string 1)
	{
		string text = 1586.10(1);
		if (text == null)
		{
			return null;
		}
		return "https://cdn.discordapp.com/emojis/" + text + ".png";
	}

	// Token: 0x0600461A RID: 17946 RVA: 0x001B83C5 File Offset: 0x001B65C5
	internal static string 12(string 1)
	{
		return 1586.Emote((1.Length == 1) ? (1 + "_") : 1, 1);
	}

	// Token: 0x0600461B RID: 17947 RVA: 0x001B83E4 File Offset: 0x001B65E4
	internal static string 13(string 1)
	{
		if (1 == "X" || 1 == "XH")
		{
			return "SS";
		}
		if (!(1 == "SH"))
		{
			return 1;
		}
		return "S";
	}

	// Token: 0x0600461C RID: 17948 RVA: 0x001B841C File Offset: 0x001B661C
	internal static 217 14(string 1, string 2 = "osu_std")
	{
		217 3 = new 217();
		3["text"] = 1;
		217 4 = 3;
		string text = 1586.11(2);
		if (text != null)
		{
			4["icon_url"] = text;
		}
		return 4;
	}

	// Token: 0x0600461D RID: 17949 RVA: 0x001B845C File Offset: 0x001B665C
	internal static 2023 15(2023 1)
	{
		if ((1 & 2023.Nightcore) != 2023.None)
		{
			1 &= ~2023.DoubleTime;
		}
		if ((1 & 2023.Perfect) != 2023.None)
		{
			1 &= ~2023.SuddenDeath;
		}
		return 1;
	}

	// Token: 0x0600461E RID: 17950 RVA: 0x001B8480 File Offset: 0x001B6680
	internal static List<string> 16(2228.2229 1)
	{
		2023 mods = 1586.15(2.11);
		List<string> list = (from 1 in 1586.5
		where (mods & 1.Key) > 2023.None
		select 1.Value).ToList<string>();
		if (2.14 != null)
		{
			list.Add("DA");
		}
		foreach (string item in (2.15 ?? new List<string>()))
		{
			if (!list.Contains(item))
			{
				list.Add(item);
			}
		}
		return list;
	}

	// Token: 0x0600461F RID: 17951 RVA: 0x001B8550 File Offset: 0x001B6750
	internal static string 17(2228.2229 1)
	{
		List<string> list = 1586.16(1);
		if (list.Count <= 0)
		{
			return "NM";
		}
		return string.Concat(list);
	}

	// Token: 0x06004620 RID: 17952 RVA: 0x001B857C File Offset: 0x001B677C
	internal static string 18(2228.2229 1)
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (string text in 1586.16(1))
		{
			stringBuilder.Append(text);
			if (1.12 != null && (text == "DT" || text == "NC" || text == "HT"))
			{
				stringBuilder.Append('(').Append(1586.1(1.12.Value)).Append("x)");
			}
		}
		if (stringBuilder.Length <= 0)
		{
			return "NM";
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06004621 RID: 17953 RVA: 0x001B8648 File Offset: 0x001B6848
	internal static int 19(2228.2229 1)
	{
		return 1586.16(1).Count;
	}

	// Token: 0x06004622 RID: 17954 RVA: 0x001B8655 File Offset: 0x001B6855
	internal static 1927 20(2228.2229 1)
	{
		if (1.14 == null || 1.14.Count <= 0)
		{
			return null;
		}
		return new 1927(1.14, 1.16);
	}

	// Token: 0x06004623 RID: 17955 RVA: 0x001B8680 File Offset: 0x001B6880
	internal static 1940 21(2228.2229 1)
	{
		if (1.12 == null)
		{
			return null;
		}
		return new 1940(1.12.Value, 1.13);
	}

	// Token: 0x06004624 RID: 17956 RVA: 0x001B86A7 File Offset: 0x001B68A7
	internal static double 22(2228.2229 1)
	{
		return 1939.17(1.11, 1586.21(1));
	}

	// Token: 0x06004625 RID: 17957 RVA: 0x001B86BA File Offset: 0x001B68BA
	internal static double 23(2228.2229 1, 1928 2)
	{
		1927 3 = 1586.20(1);
		return 1586.25(2, (double)((3 != null) ? 3.Apply(2, 1586.24(1, 2)) : 1586.24(1, 2)), 1.11, 1586.22(1));
	}

	// Token: 0x06004626 RID: 17958 RVA: 0x001B86F0 File Offset: 0x001B68F0
	private static float 24(2228.2229 1, 1928 2)
	{
		switch (2)
		{
		case 1928.CircleSize:
			return 1.38;
		case 1928.OverallDifficulty:
			return 1.40;
		case 1928.ApproachRate:
			return 1.39;
		}
		return 1.41;
	}

	// Token: 0x06004627 RID: 17959 RVA: 0x001B8738 File Offset: 0x001B6938
	private static double 25(1928 1, double 2, 2023 3, double 4)
	{
		if ((3 & 2023.Easy) != 2023.None)
		{
			2 = Math.Max(0.0, 2 / 2.0);
		}
		if ((3 & 2023.HardRock) != 2023.None)
		{
			2 = Math.Min(10.0, 2 * ((1 == 1928.CircleSize) ? 1.3 : 1.4));
		}
		if (4 == 1.0)
		{
			return 2;
		}
		if (1 == 1928.ApproachRate)
		{
			double num = ((2 > 5.0) ? (1200.0 - 150.0 * (2 - 5.0)) : (1200.0 + 120.0 * (5.0 - 2))) / 4;
			if (num <= 1200.0)
			{
				return 5.0 + (1200.0 - num) / 150.0;
			}
			return 5.0 - (num - 1200.0) / 120.0;
		}
		else
		{
			if (1 == 1928.OverallDifficulty)
			{
				return (80.0 - (80.0 - 6.0 * 2) / 4) / 6.0;
			}
			return 2;
		}
	}

	// Token: 0x06004628 RID: 17960 RVA: 0x001B8878 File Offset: 0x001B6A78
	internal static string 26(2228.2229 1, 1928 2, string 3)
	{
		double value = 1586.23(1, 2);
		string text = 3 + ": " + 1586.1(value);
		if (1.14 != null && 1.14.ContainsKey(2))
		{
			double value2 = 1586.25(2, (double)1586.24(1, 2), 1.11, 1586.22(1));
			if (Math.Round(value, 2) > Math.Round(value2, 2))
			{
				text += "⬆";
			}
			else if (Math.Round(value, 2) < Math.Round(value2, 2))
			{
				text += "⬇";
			}
		}
		return text;
	}

	// Token: 0x06004629 RID: 17961 RVA: 0x001B890B File Offset: 0x001B6B0B
	internal static double 27(2228.2229 1)
	{
		return 1.42 * 1586.22(1);
	}

	// Token: 0x0600462A RID: 17962 RVA: 0x001B891A File Offset: 0x001B6B1A
	internal static double 28(2228.2229 1)
	{
		return (double)1.43 / 1586.22(1);
	}

	// Token: 0x0600462B RID: 17963 RVA: 0x001B892C File Offset: 0x001B6B2C
	internal static bool 29(2228.2229 1)
	{
		if (!1.29 || 1.22 > 0)
		{
			return false;
		}
		int 2 = 1.24;
		switch (1.10)
		{
		case 2147.Taiko:
		case 2147.OsuMania:
			return true;
		case 2147.CatchTheBeat:
			return 2 > 0 && 1.23 == 2;
		default:
			return 2 > 0 && 1.23 >= 2 - Math.Max(2 / 500, 4);
		}
	}

	// Token: 0x0600462C RID: 17964 RVA: 0x001B89A2 File Offset: 0x001B6BA2
	private static bool 30(2228.2229 1)
	{
		return 1.35 != null && 1.34 != null && (1.24 > 0 || 1.10 == 2147.OsuMania);
	}

	// Token: 0x0600462D RID: 17965 RVA: 0x001B89D4 File Offset: 0x001B6BD4
	internal static void 31(2228.2229 1, 1890 2)
	{
		2237.2238 3 = 1586.32(1);
		double value = 1.32.GetValueOrDefault();
		if (1.32 == null)
		{
			value = 2237.12(2, 3);
			1.32 = new double?(value);
		}
		double? 4 = 1.33;
		if (4 == null)
		{
			2237.2238 5;
			1.33 = 1586.Unchoke(2, 3, out 5);
		}
		value = 1.34.GetValueOrDefault();
		if (1.34 == null)
		{
			value = 2237.6(2, 1.11);
			1.34 = new double?(value);
		}
		value = 1.35.GetValueOrDefault();
		if (1.35 == null)
		{
			value = 2237.StarRating(2);
			1.35 = new double?(value);
		}
		2092 6 = 2 as 2092;
		if (6 == null)
		{
			2170 7 = 2 as 2170;
			if (7 == null)
			{
				1841 8 = 2 as 1841;
				if (8 == null)
				{
					1956 9 = 2 as 1956;
					if (9 == null)
					{
						return;
					}
					if (1.25 <= 0)
					{
						1.25 = 9.4;
					}
				}
				else
				{
					if (1.24 <= 0)
					{
						1.24 = 8.4;
					}
					if (1.25 <= 0)
					{
						1.25 = 8.4;
						return;
					}
				}
			}
			else
			{
				if (1.24 <= 0)
				{
					1.24 = 7.11;
				}
				if (1.25 <= 0)
				{
					1.25 = 7.11;
					return;
				}
			}
		}
		else
		{
			if (1.24 <= 0)
			{
				1.24 = ((6.18 > 0) ? 6.18 : 6.17);
			}
			if (1.25 <= 0)
			{
				1.25 = 6.19 + 6.20 + 6.21;
				return;
			}
		}
	}

	// Token: 0x0600462E RID: 17966 RVA: 0x001B8B94 File Offset: 0x001B6D94
	internal static 2237.2238 32(2228.2229 1)
	{
		return new 2237.2238
		{
			1 = 1.11,
			2 = 1.17,
			3 = 1.18,
			4 = 1.19,
			5 = 1.20,
			6 = 1.21,
			7 = 1.22,
			8 = 1.23,
			9 = 1.26,
			10 = 1.37
		};
	}

	// Token: 0x0600462F RID: 17967 RVA: 0x001B8C2C File Offset: 0x001B6E2C
	internal static double? Unchoke(1890 1, 2237.2238 2, out 2237.2238 3)
	{
		3 = 2;
		3.7 = 0;
		3.11 = true;
		3.9 = 0L;
		2092 4 = 1 as 2092;
		if (4 == null)
		{
			2170 5 = 1 as 2170;
			if (5 == null)
			{
				1841 6 = 1 as 1841;
				if (6 == null)
				{
					return null;
				}
				int num = 2.2 + 2.3 + 2.7;
				int num2 = Math.Max(0, 6.4 - num);
				int num3 = Math.Max(0, num2 - Math.Max(0, 6.8 - 2.3));
				int num4 = num2 - num3;
				3.2 = 2.2 + num3;
				3.3 = 2.3 + num4;
				3.6 = 2.6;
				3.4 = Math.Max(0, 6.9 - 2.6);
				3.8 = 6.4;
			}
			else
			{
				1586.33(5.11, 2, ref 3);
				3.8 = 5.11;
			}
		}
		else
		{
			1586.33(4.19 + 4.20 + 4.21, 2, ref 3);
			3.8 = 4.17;
		}
		return new double?(2237.12(1, 3));
	}

	// Token: 0x06004630 RID: 17968 RVA: 0x001B8D7C File Offset: 0x001B6F7C
	private static void 33(int 1, 2237.2238 2, ref 2237.2238 3)
	{
		int num = 2.2 + 2.3 + 2.4 + 2.7;
		int num2 = 2.2 + Math.Max(0, 1 - num);
		int num3 = Math.Max(1, 1 - 2.7);
		int num4 = (int)Math.Ceiling((1.0 - (double)num2 / (double)num3) * (double)2.7);
		3.2 = num2 + Math.Max(0, 2.7 - num4);
		3.3 = 2.3 + num4;
		3.4 = 2.4;
	}

	// Token: 0x06004631 RID: 17969 RVA: 0x001B8E14 File Offset: 0x001B7014
	internal static string Grade(int 1, int 2, int 3, int 4, 2023 5)
	{
		int num = 1 + 2 + 3 + 4;
		if (num == 0)
		{
			return "D";
		}
		bool flag = (5 & (2023.Hidden | 2023.Flashlight | 2023.FadeIn)) > 2023.None;
		double num2 = (double)1 / (double)num;
		double num3 = (double)3 / (double)num;
		if (1 == num)
		{
			if (!flag)
			{
				return "X";
			}
			return "XH";
		}
		else if (num2 > 0.9 && num3 <= 0.01 && 4 == 0)
		{
			if (!flag)
			{
				return "S";
			}
			return "SH";
		}
		else
		{
			if ((num2 > 0.8 && 4 == 0) || num2 > 0.9)
			{
				return "A";
			}
			if ((num2 > 0.7 && 4 == 0) || num2 > 0.8)
			{
				return "B";
			}
			if (num2 <= 0.6)
			{
				return "D";
			}
			return "C";
		}
	}

	// Token: 0x06004632 RID: 17970 RVA: 0x001B8EE0 File Offset: 0x001B70E0
	internal static double Accuracy(int 1, int 2, int 3, int 4)
	{
		int num = 1 + 2 + 3 + 4;
		if (num <= 0)
		{
			return 0.0;
		}
		return 100.0 * (300.0 * (double)1 + 100.0 * (double)2 + 50.0 * (double)3) / (300.0 * (double)num);
	}

	// Token: 0x06004633 RID: 17971 RVA: 0x001B8F40 File Offset: 0x001B7140
	internal static bool 34(2228.2229 1, 1262 2, 2241 3, 1586.1588 4)
	{
		if (1586.30(1))
		{
			return true;
		}
		if (!2237.1(2, 1.10))
		{
			return false;
		}
		Action action = 4.1();
		1890 5 = (3 != null) ? 2237.4(3, 2, action) : 2237.5(2, 1.10, 1.11, 1586.20(1), 1586.21(1), action);
		if (5 == null)
		{
			if ((3 != null) ? 2237.HasFailed(3, 2) : 2237.HasFailed(2, 1.10, 1.11, 1586.20(1), 1586.21(1)))
			{
				action();
			}
			return false;
		}
		action();
		1586.31(1, 5);
		return true;
	}

	// Token: 0x06004634 RID: 17972 RVA: 0x001B8FE0 File Offset: 0x001B71E0
	internal static void 35(2228.2229 1, 1262 2, 2241 3)
	{
		if (1586.30(1) || !2237.1(2, 1.10))
		{
			return;
		}
		1890 4 = (3 != null) ? 2237.4(3, 2, null) : 2237.5(2, 1.10, 1.11, 1586.20(1), 1586.21(1), null);
		if (4 != null)
		{
			1586.31(1, 4);
		}
	}

	// Token: 0x06004635 RID: 17973 RVA: 0x001B903C File Offset: 0x001B723C
	internal static double 36(2228.2229 1, 1262 2)
	{
		if (1.35 != null)
		{
			return 1.35.Value;
		}
		if (2 == null || 1.12 != null || (1.14 != null && 1.14.Count > 0))
		{
			return 0.0;
		}
		double result;
		try
		{
			result = 2.18(1.10, 1.11);
		}
		catch (Exception)
		{
			result = 0.0;
		}
		return result;
	}

	// Token: 0x06004636 RID: 17974 RVA: 0x001B90C8 File Offset: 0x001B72C8
	internal static string 37(2228.2229 1)
	{
		string text = string.IsNullOrEmpty(1.6) ? 1586.5(1.7) : (1586.5(1.6) + " - " + 1586.5(1.7));
		if (!string.IsNullOrEmpty(1.8))
		{
			return text + " [" + 1586.5(1.8) + "]";
		}
		return text;
	}

	// Token: 0x06004637 RID: 17975 RVA: 0x001B913C File Offset: 0x001B733C
	internal static string 38(2228.2229 1)
	{
		string text = 1586.5(1.7);
		if (!string.IsNullOrEmpty(1.8))
		{
			return text + " [" + 1586.5(1.8) + "]";
		}
		return text;
	}

	// Token: 0x06004638 RID: 17976 RVA: 0x001B9180 File Offset: 0x001B7380
	internal static string 39(2228.2229 1)
	{
		string text = 1.6 ?? string.Empty;
		string text2 = 1.7 ?? string.Empty;
		string text3 = 1.8 ?? string.Empty;
		if (text3.Length == 0)
		{
			return 1586.5((text2.Length <= 42) ? text2 : (text2.Substring(0, 39) + "..."));
		}
		if (text.Length + text2.Length + text3.Length + 6 <= 42)
		{
			return string.Concat(new string[]
			{
				1586.5(text),
				" - ",
				1586.5(text2),
				" [",
				1586.5(text3),
				"]"
			});
		}
		if (text2.Length + text3.Length + 3 <= 42)
		{
			return 1586.5(text2) + " [" + 1586.5(text3) + "]";
		}
		if (text3.Length <= 18)
		{
			return 1586.5(1586.<ShortMapName>g__Cut|48_0(text2, 42 - text3.Length - 3 - 3)) + " [" + 1586.5(text3) + "]";
		}
		if (text2.Length <= 18)
		{
			return 1586.5(text2) + " [" + 1586.5(1586.<ShortMapName>g__Cut|48_0(text3, 42 - text2.Length - 3 - 3)) + "]";
		}
		int val = 16;
		return 1586.5(1586.<ShortMapName>g__Cut|48_0(text2, Math.Max(15, val))) + " [" + 1586.5(1586.<ShortMapName>g__Cut|48_0(text3, Math.Max(15, val))) + "]";
	}

	// Token: 0x06004639 RID: 17977 RVA: 0x001B931C File Offset: 0x001B751C
	internal static 2147 40(string 1, 2147 2)
	{
		if (1 == "osu")
		{
			return 2147.Osu;
		}
		if (1 == "taiko")
		{
			return 2147.Taiko;
		}
		if (1 == "ctb")
		{
			return 2147.CatchTheBeat;
		}
		if (!(1 == "mania"))
		{
			return 2;
		}
		return 2147.OsuMania;
	}

	// Token: 0x0600463A RID: 17978 RVA: 0x001B9368 File Offset: 0x001B7568
	internal static string 41(2147 1)
	{
		switch (1)
		{
		case 2147.Taiko:
			return "Taiko";
		case 2147.CatchTheBeat:
			return "Catch";
		case 2147.OsuMania:
			return "Mania";
		default:
			return "osu!";
		}
	}

	// Token: 0x0600463B RID: 17979 RVA: 0x001B9397 File Offset: 0x001B7597
	internal static string 42(2147 1)
	{
		switch (1)
		{
		case 2147.Taiko:
			return "taiko ";
		case 2147.CatchTheBeat:
			return "ctb ";
		case 2147.OsuMania:
			return "mania ";
		default:
			return string.Empty;
		}
	}

	// Token: 0x0600463C RID: 17980 RVA: 0x001B93C6 File Offset: 0x001B75C6
	internal static string 43(2147 1)
	{
		switch (1)
		{
		case 2147.Taiko:
			return "osu_taiko";
		case 2147.CatchTheBeat:
			return "osu_ctb";
		case 2147.OsuMania:
			return "osu_mania";
		default:
			return "osu_std";
		}
	}

	// Token: 0x0600463D RID: 17981 RVA: 0x001B93F8 File Offset: 0x001B75F8
	internal static string 44(2228.2229 1)
	{
		2147 2 = 1.10;
		if (2 == 2147.Taiko)
		{
			return string.Concat(new string[]
			{
				"{",
				1.17.ToString(),
				"/",
				1.18.ToString(),
				"/",
				1.22.ToString(),
				"}"
			});
		}
		if (2 != 2147.OsuMania)
		{
			return string.Concat(new string[]
			{
				"{",
				1.17.ToString(),
				"/",
				1.18.ToString(),
				"/",
				1.19.ToString(),
				"/",
				1.22.ToString(),
				"}"
			});
		}
		return string.Concat(new string[]
		{
			"{",
			1.20.ToString(),
			"/",
			1.17.ToString(),
			"/",
			1.21.ToString(),
			"/",
			1.18.ToString(),
			"/",
			1.19.ToString(),
			"/",
			1.22.ToString(),
			"}"
		});
	}

	// Token: 0x0600463E RID: 17982 RVA: 0x001B9578 File Offset: 0x001B7778
	internal static string Keys(2228.2229 1, 1262 2)
	{
		string text = (from 1 in 1586.5
		where (3.11 & 1.Key) != 2023.None && 1.Value.EndsWith("K", StringComparison.Ordinal)
		select 1.Value).FirstOrDefault<string>();
		if (text != null)
		{
			return "[" + text + "]";
		}
		return "[" + ((2 != null) ? 2011.53(2, 3.11) : ((int)Math.Round((double)3.38))).ToString() + "K]";
	}

	// Token: 0x0600463F RID: 17983 RVA: 0x001B9628 File Offset: 0x001B7828
	private static 2241 45(2147 1, 2237.2238 2)
	{
		2241 3 = 2246.Create(1, string.Empty, null, false);
		3.18 = true;
		3.8 = 2.1;
		3.2 = (ushort)Math.Max(0, Math.Min(65535, 2.2));
		3.1 = (ushort)Math.Max(0, Math.Min(65535, 2.3));
		3.3 = (ushort)Math.Max(0, Math.Min(65535, 2.4));
		3.4 = (ushort)Math.Max(0, Math.Min(65535, 2.5));
		3.5 = (ushort)Math.Max(0, Math.Min(65535, 2.6));
		3.6 = (ushort)Math.Max(0, Math.Min(65535, 2.7));
		3.13 = (int)((ushort)Math.Max(0, Math.Min(65535, 2.8)));
		return 3;
	}

	// Token: 0x06004640 RID: 17984 RVA: 0x001B9728 File Offset: 0x001B7928
	internal static string Grade(2147 1, 2237.2238 2)
	{
		return 1586.45(1, 2).CalculateGrade().ToString();
	}

	// Token: 0x06004641 RID: 17985 RVA: 0x001B974F File Offset: 0x001B794F
	internal static double Accuracy(2147 1, 2237.2238 2)
	{
		return (double)1586.45(1, 2).CalculateAccuracy() * 100.0;
	}

	// Token: 0x170002FB RID: 763
	// (get) Token: 0x06004642 RID: 17986 RVA: 0x0013594A File Offset: 0x00133B4A
	internal static string ProfileName
	{
		get
		{
			return 1304.189.GetValue() ?? string.Empty;
		}
	}

	// Token: 0x06004643 RID: 17987 RVA: 0x001B9768 File Offset: 0x001B7968
	internal static 217 Author(2147 1 = 2147.Osu)
	{
		string profileName = 1586.ProfileName;
		2210.2216 2 = 2210.4(1);
		double num = (2 != null) ? 2.1 : 0.0;
		string text = 2210.11(profileName);
		string str = profileName + ": " + 1586.3(num) + "pp";
		int? num2 = 2210.76(num, null, new 2147?(1));
		int? num3 = 2208.Get(text, num, null, 1);
		List<string> list = new List<string>();
		if (num2 != null && num2.Value > 0)
		{
			list.Add("#" + 1586.4((long)num2.Value));
		}
		if (num3 != null && num3.Value > 0)
		{
			list.Add(text.ToUpperInvariant() + 1586.4((long)num3.Value));
		}
		if (list.Count > 0)
		{
			str = str + " (" + string.Join(" ", list) + ")";
		}
		217 3 = new 217();
		3["name"] = str;
		217 4 = 3;
		if (2204.1(text))
		{
			4["icon_url"] = "https://osuflags.omkserver.nl/" + text.ToUpperInvariant() + "-256.png";
		}
		return 4;
	}

	// Token: 0x06004644 RID: 17988 RVA: 0x001B98A4 File Offset: 0x001B7AA4
	internal static void 46(1586.1588 1, 2147 2 = 2147.Osu)
	{
		2210.2216 3 = 2210.4(2);
		double num = (3 != null) ? 3.1 : 0.0;
		Action action = 1.1();
		if (2210.76(num, action, new 2147?(2)) != null || 2218.3(num, 2))
		{
			action();
		}
		string text = 2210.11(1586.ProfileName);
		Action action2 = 1.1();
		if (2208.Get(text, num, action2, 2) != null || 2208.3(text, num, 2))
		{
			action2();
		}
	}

	// Token: 0x06004645 RID: 17989 RVA: 0x001B9930 File Offset: 0x001B7B30
	internal static byte[] 47()
	{
		string profileName = 1586.ProfileName;
		byte[] result;
		try
		{
			if (!2226.2(profileName))
			{
				result = null;
			}
			else
			{
				string path = 2226.1(profileName);
				DateTime lastWriteTimeUtc = File.GetLastWriteTimeUtc(path);
				if (1586.7 == null || 1586.8 != profileName || 1586.9 != lastWriteTimeUtc)
				{
					1586.7 = File.ReadAllBytes(path);
					1586.8 = profileName;
					1586.9 = lastWriteTimeUtc;
				}
				result = 1586.7;
			}
		}
		catch (Exception)
		{
			result = null;
		}
		return result;
	}

	// Token: 0x06004646 RID: 17990 RVA: 0x001B99B4 File Offset: 0x001B7BB4
	internal static string Origin(217 1)
	{
		string str = ((string)1["guild_id"]) ?? "@me";
		string str2 = ((string)1["channel_id"]) ?? ((string)1.SelectToken("channel.id"));
		return "https://discord.com/channels/" + str + "/" + str2;
	}

	// Token: 0x06004647 RID: 17991 RVA: 0x001B9A14 File Offset: 0x001B7C14
	internal static 1586.1587 48(int 1)
	{
		1586.55();
		1586.1587 result;
		if (!1586.12.TryGetValue(1, out result))
		{
			return null;
		}
		return result;
	}

	// Token: 0x06004648 RID: 17992 RVA: 0x001B9A38 File Offset: 0x001B7C38
	internal static void 49(int 1, 1586.1588 2)
	{
		1586.55();
		if (1 <= 0 || 261.FullyOffline)
		{
			return;
		}
		1586.1587 3;
		if (1586.12.TryGetValue(1, out 3) && (3.1 == 1 || 3.1 == 2 || 3.1 == 4 || DateTime.UtcNow - 3.3 < 1586.11))
		{
			return;
		}
		Action item = 2.1();
		List<Action> list;
		if (!1586.14.TryGetValue(1, out list))
		{
			list = (1586.14[1] = new List<Action>());
		}
		list.Add(item);
		if (1586.13.Add(1))
		{
			1586.17.Enqueue(1);
			1586.50();
		}
	}

	// Token: 0x06004649 RID: 17993 RVA: 0x001B9AEC File Offset: 0x001B7CEC
	private static void 50()
	{
		while (1586.18 < 4 && 1586.17.Count > 0)
		{
			1586.18++;
			int num = 1586.17.Dequeue();
			IEnumerable<1637> source = 1632.1();
			Func<1637, bool> predicate;
			if ((predicate = 1586.<>O.<0>__CanLookUp) == null)
			{
				predicate = (1586.<>O.<0>__CanLookUp = new Func<1637, bool>(1586.52));
			}
			1586.53(num, source.FirstOrDefault(predicate));
		}
	}

	// Token: 0x0600464A RID: 17994 RVA: 0x001B9B50 File Offset: 0x001B7D50
	internal static int Approved(2228.2229 1, 1262 2)
	{
		1586.1587 3 = 1586.48(1.4);
		if (3 != null && 3.1 != -2147483648)
		{
			return 3.1;
		}
		switch ((2 != null) ? 2.85 : ((1281)0))
		{
		case (1281)2:
			return 0;
		case (1281)4:
			return 1;
		case (1281)5:
			return 2;
		case (1281)6:
			return 3;
		case (1281)7:
			return 4;
		}
		return int.MinValue;
	}

	// Token: 0x0600464B RID: 17995 RVA: 0x001B9BC0 File Offset: 0x001B7DC0
	internal static string 51(int 1)
	{
		switch (1)
		{
		case -2:
			return "Graveyard";
		case -1:
			return "WIP";
		case 0:
			return "Pending";
		case 1:
			return "Ranked";
		case 2:
			return "Approved";
		case 3:
			return "Qualified";
		case 4:
			return "Loved";
		default:
			return null;
		}
	}

	// Token: 0x0600464C RID: 17996 RVA: 0x001B9C1F File Offset: 0x001B7E1F
	private static bool 52(1637 1)
	{
		return 1.GetBeatmapInfoUrl(1) != null;
	}

	// Token: 0x0600464D RID: 17997 RVA: 0x001B9C2C File Offset: 0x001B7E2C
	private static void 53(int 1, 1637 2)
	{
		if (5 == null)
		{
			1586.54(4, null);
			return;
		}
		1621 3 = new 1621(5.GetBeatmapInfoUrl(4), Array.Empty<object>());
		3.9(delegate(1621 1, Exception 2)
		{
			1586.1587 info = null;
			try
			{
				string text = (2 == null) ? 5.ToBeatmapRows(1.12(), 4, null) : null;
				if (text == null && 2 != null && 1632.3(2))
				{
					text = "[]";
				}
				if (text != null)
				{
					109 6 = 1638.6(text) as 109;
					if (6 != null)
					{
						226 7 = 6.FirstOrDefault<226>();
						info = new 1586.1587
						{
							1 = ((7 == null) ? int.MinValue : ((int?)7["approved"]).GetValueOrDefault(int.MinValue)),
							2 = ((7 == null) ? null : 1638.Date(7["approved_date"])),
							3 = DateTime.UtcNow
						};
					}
				}
			}
			catch (Exception)
			{
			}
			1662.89.Schedule(delegate()
			{
				if (info == null)
				{
					1637 mirror = 5;
					Func<1637, bool> func;
					if ((func = 1586.<>O.<0>__CanLookUp) == null)
					{
						func = (1586.<>O.<0>__CanLookUp = new Func<1637, bool>(1586.52));
					}
					1637 8 = 1632.Next(mirror, func);
					if (8 != null)
					{
						1586.53(4, 8);
						return;
					}
				}
				if (info == null)
				{
					1338.5("Discord bot: no mirror answered about beatmap " + 4.ToString() + ((2 != null) ? (" (" + 2.Message + ")") : string.Empty), 1341.Runtime, (1114)2);
				}
				1586.54(4, info);
			}, false);
		});
		3.Start();
	}

	// Token: 0x0600464E RID: 17998 RVA: 0x001B9C94 File Offset: 0x001B7E94
	private static void 54(int 1, 1586.1587 2)
	{
		1586.13.Remove(1);
		1586.18--;
		1586.50();
		if (2 != null)
		{
			1586.12[1] = 2;
			1586.15 = true;
		}
		List<Action> list;
		if (1586.14.TryGetValue(1, out list))
		{
			1586.14.Remove(1);
			foreach (Action action in list)
			{
				action();
			}
		}
		if (1586.13.Count == 0 && 1586.15)
		{
			1586.56();
		}
	}

	// Token: 0x170002FC RID: 764
	// (get) Token: 0x0600464F RID: 17999 RVA: 0x001B9D44 File Offset: 0x001B7F44
	private static string MapInfoPath
	{
		get
		{
			return 268.2("nekiosu.discord-maps.json");
		}
	}

	// Token: 0x06004650 RID: 18000 RVA: 0x001B9D50 File Offset: 0x001B7F50
	private static void 55()
	{
		if (1586.12 != null)
		{
			return;
		}
		1586.12 = new Dictionary<int, 1586.1587>();
		try
		{
			if (File.Exists(1586.MapInfoPath))
			{
				foreach (222 <<EMPTY_NAME>> in 217.Parse(File.ReadAllText(1586.MapInfoPath, Encoding.UTF8)).Properties())
				{
					int key;
					if (int.TryParse(<<EMPTY_NAME>>.Name, NumberStyles.Integer, CultureInfo.InvariantCulture, out key))
					{
						217 2 = <<EMPTY_NAME>>.Value as 217;
						if (2 != null)
						{
							1586.12[key] = new 1586.1587
							{
								1 = ((int?)2["approved"]).GetValueOrDefault(int.MinValue),
								2 = 1638.Date(2["ranked"]),
								3 = (1638.Date(2["checked"]) ?? DateTime.MinValue)
							};
						}
					}
				}
			}
		}
		catch (Exception ex)
		{
			1338.4(ex, "reading nekiosu.discord-maps.json", 1341.Runtime);
		}
	}

	// Token: 0x06004651 RID: 18001 RVA: 0x001B9E90 File Offset: 0x001B8090
	private static void 56()
	{
		1586.15 = false;
		try
		{
			217 <<EMPTY_NAME>> = new 217();
			foreach (KeyValuePair<int, 1586.1587> keyValuePair in 1586.12)
			{
				217 2 = <<EMPTY_NAME>>;
				string text = keyValuePair.Key.ToString(CultureInfo.InvariantCulture);
				217 3 = new 217();
				3["approved"] = keyValuePair.Value.1;
				string text2 = "ranked";
				1586.1587 value = keyValuePair.Value;
				3[text2] = ((value.2 != null) ? value.2.GetValueOrDefault().ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture) : null);
				3["checked"] = keyValuePair.Value.3.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
				2[text] = 3;
			}
			byte[] bytes = Encoding.UTF8.GetBytes(<<EMPTY_NAME>>.ToString((95)0, Array.Empty<214>()));
			using (2681 4 = new 2681(1586.MapInfoPath))
			{
				4.Write(bytes, 0, bytes.Length);
			}
		}
		catch (Exception ex)
		{
			1338.4(ex, "saving nekiosu.discord-maps.json", 1341.Runtime);
		}
	}

	// Token: 0x06004652 RID: 18002 RVA: 0x001BA01C File Offset: 0x001B821C
	internal static 217 57(string 1)
	{
		217 2 = new 217();
		string text = "embeds";
		217 3 = new 217();
		3["description"] = 1;
		3["color"] = 15158332;
		2[text] = new 109(3);
		return 2;
	}

	// Token: 0x06004653 RID: 18003 RVA: 0x001BA069 File Offset: 0x001B8269
	internal static void 58(217 1, string 2)
	{
		217 3 = new 217();
		3["type"] = 4;
		3["data"] = 1586.57(2);
		1584.11(1, 3);
	}

	// Token: 0x06004655 RID: 18005 RVA: 0x001BA3CC File Offset: 0x001B85CC
	[CompilerGenerated]
	internal static string <ShortMapName>g__Cut|48_0(string 1, int 2)
	{
		if (1.Length > 2 + 3)
		{
			return 1.Substring(0, Math.Max(0, 2)) + "...";
		}
		return 1;
	}

	// Token: 0x04003344 RID: 13124
	internal const int 1 = 2067276;

	// Token: 0x04003345 RID: 13125
	internal const int 2 = 15158332;

	// Token: 0x04003346 RID: 13126
	internal const int 3 = 8000;

	// Token: 0x04003347 RID: 13127
	internal const string 4 = "avatar.jpg";

	// Token: 0x04003348 RID: 13128
	internal static readonly KeyValuePair<2023, string>[] 5 = new KeyValuePair<2023, string>[]
	{
		new KeyValuePair<2023, string>(2023.NoFail, "NF"),
		new KeyValuePair<2023, string>(2023.Easy, "EZ"),
		new KeyValuePair<2023, string>(2023.TouchDevice, "TD"),
		new KeyValuePair<2023, string>(2023.Hidden, "HD"),
		new KeyValuePair<2023, string>(2023.HardRock, "HR"),
		new KeyValuePair<2023, string>(2023.SuddenDeath, "SD"),
		new KeyValuePair<2023, string>(2023.DoubleTime, "DT"),
		new KeyValuePair<2023, string>(2023.Relax, "RX"),
		new KeyValuePair<2023, string>(2023.HalfTime, "HT"),
		new KeyValuePair<2023, string>(2023.Nightcore, "NC"),
		new KeyValuePair<2023, string>(2023.Flashlight, "FL"),
		new KeyValuePair<2023, string>(2023.Autoplay, "AT"),
		new KeyValuePair<2023, string>(2023.SpunOut, "SO"),
		new KeyValuePair<2023, string>(2023.Relax2, "AP"),
		new KeyValuePair<2023, string>(2023.Perfect, "PF"),
		new KeyValuePair<2023, string>(2023.Key4, "4K"),
		new KeyValuePair<2023, string>(2023.Key5, "5K"),
		new KeyValuePair<2023, string>(2023.Key6, "6K"),
		new KeyValuePair<2023, string>(2023.Key7, "7K"),
		new KeyValuePair<2023, string>(2023.Key8, "8K"),
		new KeyValuePair<2023, string>(2023.FadeIn, "FI"),
		new KeyValuePair<2023, string>(2023.Random, "RD"),
		new KeyValuePair<2023, string>(2023.Cinema, "CN"),
		new KeyValuePair<2023, string>(2023.Target, "TP"),
		new KeyValuePair<2023, string>(2023.Key9, "9K"),
		new KeyValuePair<2023, string>(2023.KeyCoop, "DS"),
		new KeyValuePair<2023, string>(2023.Key1, "1K"),
		new KeyValuePair<2023, string>(2023.Key3, "3K"),
		new KeyValuePair<2023, string>(2023.Key2, "2K"),
		new KeyValuePair<2023, string>(2023.ScoreV2, "SV2"),
		new KeyValuePair<2023, string>(2023.Mirror, "MR")
	};

	// Token: 0x04003349 RID: 13129
	internal static readonly string[] 6 = new string[]
	{
		"DA",
		"NL",
		"MR",
		"RD",
		"AL",
		"SG",
		"PR"
	};

	// Token: 0x0400334A RID: 13130
	private static byte[] 7;

	// Token: 0x0400334B RID: 13131
	private static string 8;

	// Token: 0x0400334C RID: 13132
	private static DateTime 9;

	// Token: 0x0400334D RID: 13133
	private const string 10 = "nekiosu.discord-maps.json";

	// Token: 0x0400334E RID: 13134
	private static readonly TimeSpan 11 = TimeSpan.FromDays(1.0);

	// Token: 0x0400334F RID: 13135
	private static Dictionary<int, 1586.1587> 12;

	// Token: 0x04003350 RID: 13136
	private static readonly HashSet<int> 13 = new HashSet<int>();

	// Token: 0x04003351 RID: 13137
	private static readonly Dictionary<int, List<Action>> 14 = new Dictionary<int, List<Action>>();

	// Token: 0x04003352 RID: 13138
	private static bool 15;

	// Token: 0x04003353 RID: 13139
	private const int 16 = 4;

	// Token: 0x04003354 RID: 13140
	private static readonly Queue<int> 17 = new Queue<int>();

	// Token: 0x04003355 RID: 13141
	private static int 18;

	// Token: 0x020009C8 RID: 2504
	internal sealed class 1587
	{
		// Token: 0x04003356 RID: 13142
		public int 1;

		// Token: 0x04003357 RID: 13143
		public DateTime? 2;

		// Token: 0x04003358 RID: 13144
		public DateTime 3;
	}

	// Token: 0x020009C9 RID: 2505
	internal sealed class 1588
	{
		// Token: 0x06004657 RID: 18007 RVA: 0x001BA3F3 File Offset: 0x001B85F3
		internal 1588(Action 1)
		{
			this.1 = 1;
		}

		// Token: 0x06004658 RID: 18008 RVA: 0x001BA409 File Offset: 0x001B8609
		internal Action 1()
		{
			this.2++;
			bool called = false;
			return delegate()
			{
				if (called)
				{
					return;
				}
				called = true;
				this.Done();
			};
		}

		// Token: 0x06004659 RID: 18009 RVA: 0x001BA437 File Offset: 0x001B8637
		internal void Start(int 1 = 8000)
		{
			1662.89.2(new 1189(this.Finish), 1, false);
			this.Done();
		}

		// Token: 0x0600465A RID: 18010 RVA: 0x001BA458 File Offset: 0x001B8658
		private void Done()
		{
			int num = this.2 - 1;
			this.2 = num;
			if (num <= 0)
			{
				this.Finish();
			}
		}

		// Token: 0x0600465B RID: 18011 RVA: 0x001BA480 File Offset: 0x001B8680
		private void Finish()
		{
			if (this.3)
			{
				return;
			}
			this.3 = true;
			try
			{
				this.1();
			}
			catch (Exception ex)
			{
				1338.4(ex, "a Discord command", 1341.Runtime);
			}
		}

		// Token: 0x04003359 RID: 13145
		private readonly Action 1;

		// Token: 0x0400335A RID: 13146
		private int 2 = 1;

		// Token: 0x0400335B RID: 13147
		private bool 3;
	}

	// Token: 0x020009CB RID: 2507
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x0400335E RID: 13150
		public static Func<1637, bool> <0>__CanLookUp;
	}
}
