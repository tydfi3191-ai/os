using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

// Token: 0x020009AB RID: 2475
public static class 1631
{
	// Token: 0x170002ED RID: 749
	// (get) Token: 0x0600456A RID: 17770 RVA: 0x001B4878 File Offset: 0x001B2A78
	public static bool IsConfigured
	{
		get
		{
			1631.1();
			return 1304.50.1() && 267.IsConfigured;
		}
	}

	// Token: 0x170002EE RID: 750
	// (get) Token: 0x0600456B RID: 17771 RVA: 0x001B4892 File Offset: 0x001B2A92
	public static bool HasKey
	{
		get
		{
			1631.1();
			return 267.IsConfigured;
		}
	}

	// Token: 0x170002EF RID: 751
	// (get) Token: 0x0600456C RID: 17772 RVA: 0x001B489E File Offset: 0x001B2A9E
	public static string ClientId
	{
		get
		{
			return 1304.48.GetValue() ?? string.Empty;
		}
	}

	// Token: 0x0600456D RID: 17773 RVA: 0x001B48B4 File Offset: 0x001B2AB4
	private static void 1()
	{
		if (1631.3)
		{
			return;
		}
		1631.3 = true;
		try
		{
			267.1(1631.ClientId, 1631.17(1304.49.GetValue()));
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x0600456E RID: 17774 RVA: 0x001B4900 File Offset: 0x001B2B00
	public static bool 2(1262 1, 1289 2)
	{
		return 1 != null && (2 == 1289.Top || 2 == 1289.SelectedMod) && 1.25 > 0 && !1.97 && 1.85 >= (1281)4 && 1631.IsConfigured;
	}

	// Token: 0x0600456F RID: 17775 RVA: 0x001B4930 File Offset: 0x001B2B30
	private static string 3(1281 1)
	{
		switch (1)
		{
		case (1281)0:
			return "unknown";
		case (1281)1:
			return "not submitted";
		case (1281)2:
			return "pending";
		case (1281)4:
			return "ranked";
		case (1281)5:
			return "approved";
		case (1281)6:
			return "qualified";
		case (1281)7:
			return "loved";
		}
		int num = (int)1;
		return num.ToString(CultureInfo.InvariantCulture);
	}

	// Token: 0x06004570 RID: 17776 RVA: 0x001B49A0 File Offset: 0x001B2BA0
	internal static void 4(1262 1, 1289 2)
	{
		if (1 == null)
		{
			return;
		}
		1631.1();
		bool flag = 1631.2(1, 2);
		string a = string.Format(CultureInfo.InvariantCulture, "Ranking: beatmap {0} (set {1}) \"{2} - {3} [{4}]\", status {5}, update available {6}, file {7}; ranking {8}; API key {9}, API on {10}, fully offline {11}, signed in {12}; {13}", new object[]
		{
			1.25,
			1.29,
			1.7,
			1.10,
			1.89,
			1631.3(1.85),
			1.97,
			1.23,
			2,
			1631.HasKey,
			1304.50.1(),
			261.FullyOffline,
			1662.21(),
			flag ? "asking the osu! API" : "not asking"
		});
		if (a == 1631.5)
		{
			return;
		}
		1631.5 = a;
		1338.5(a, 1341.Runtime, (1114)2);
	}

	// Token: 0x06004571 RID: 17777 RVA: 0x001B4AA8 File Offset: 0x001B2CA8
	internal static void 5(1262 1, 1289 2)
	{
		if (1 == null || (2 != 1289.Top && 2 != 1289.SelectedMod) || !1631.4.Add(1.23 ?? string.Empty))
		{
			return;
		}
		string text = (!1631.IsConfigured) ? (1631.HasKey ? "the osu! API is turned off" : "no osu! API key is set") : ((1.25 <= 0) ? "it has no beatmap ID" : (1.97 ? "an update is available for it" : ((1.85 < (1281)4) ? ("its status is " + 1.85.ToString() + " (only ranked, approved, qualified and loved maps have one)") : null)));
		if (text != null)
		{
			string str = "Online ranking not asked for beatmap ";
			int 3 = 1.25;
			1338.5(str + 3.ToString() + ": " + text, 1341.Runtime, (1114)2);
		}
	}

	// Token: 0x06004572 RID: 17778 RVA: 0x001B4B74 File Offset: 0x001B2D74
	public static void 6(string 1, string 2, Action<bool, string> 3)
	{
		1631.1();
		1 = (1 ?? string.Empty).Trim();
		2 = (2 ?? string.Empty).Trim();
		string previousId = 1631.ClientId;
		string previousSecret = 1631.17(1304.49.GetValue());
		if (1.Length == 0)
		{
			1631.7(string.Empty, string.Empty);
			3(false, "Online rankings are turned off.");
			return;
		}
		if (2.Length == 0)
		{
			2 = previousSecret;
		}
		1662.17(delegate
		{
			string failure = null;
			try
			{
				267.1(1, 2);
				267.2();
			}
			catch (Exception ex)
			{
				failure = ((ex is InvalidOperationException || ex is ArgumentException) ? ex.Message : "The osu! API could not be reached.");
			}
			1662.89.Schedule(delegate()
			{
				if (failure != null)
				{
					try
					{
						267.1(previousId, previousSecret);
					}
					catch (Exception)
					{
					}
					3(false, failure);
					return;
				}
				1631.7(1, 2);
				3(true, "Connected. Online rankings are available in song select.");
			}, false);
		});
	}

	// Token: 0x06004573 RID: 17779 RVA: 0x001B4C50 File Offset: 0x001B2E50
	private static void 7(string 1, string 2)
	{
		1304.48.SetValue(1);
		1304.49.SetValue(1631.16(2));
		try
		{
			267.1(1, 2);
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06004574 RID: 17780 RVA: 0x001B4C94 File Offset: 0x001B2E94
	public static void 8(1262 1, 2147 2, 2023? 3, Action<List<string>, int, string> 4)
	{
		int beatmapId = 1.25;
		string mode = (2 == 2147.Taiko) ? "taiko" : ((2 == 2147.CatchTheBeat) ? "fruits" : ((2 == 2147.OsuMania) ? "mania" : "osu"));
		string[] mods = (3 != null) ? 1631.9(3.Value) : null;
		1338.5(string.Concat(new string[]
		{
			"Online ranking for beatmap ",
			beatmapId.ToString(),
			" (",
			mode,
			(mods != null) ? (", " + string.Join("", mods)) : string.Empty,
			"): asking"
		}), 1341.Runtime, (1114)2);
		1662.17(delegate
		{
			List<string> lines = null;
			int total = 0;
			string failure = null;
			try
			{
				lines = 1631.11(267.3(beatmapId, mode, mods, true, 100), out total);
				1338.5(string.Concat(new string[]
				{
					"Online ranking for beatmap ",
					beatmapId.ToString(),
					" (",
					mode,
					(mods != null) ? (", " + string.Join("", mods)) : string.Empty,
					"): ",
					lines.Count.ToString(),
					" score(s) of ",
					total.ToString()
				}), 1341.Runtime, (1114)2);
			}
			catch (Exception ex)
			{
				failure = ((ex is InvalidOperationException) ? ex.Message : "Scores could not be retrieved.");
				1338.5("Online ranking for beatmap " + beatmapId.ToString() + " failed: " + ex.Message, 1341.Runtime, (1114)2);
			}
			1662.89.Schedule(delegate()
			{
				4(lines, total, failure);
			}, false);
		});
	}

	// Token: 0x06004575 RID: 17781 RVA: 0x001B4D84 File Offset: 0x001B2F84
	private static string[] 9(2023 1)
	{
		1631.<>c__DisplayClass19_0 CS$<>8__locals1;
		CS$<>8__locals1.mods = 1;
		CS$<>8__locals1.acronyms = new List<string>();
		1631.<ToAcronyms>g__Add|19_0(2023.NoFail, "NF", ref CS$<>8__locals1);
		1631.<ToAcronyms>g__Add|19_0(2023.Easy, "EZ", ref CS$<>8__locals1);
		1631.<ToAcronyms>g__Add|19_0(2023.Hidden, "HD", ref CS$<>8__locals1);
		1631.<ToAcronyms>g__Add|19_0(2023.HardRock, "HR", ref CS$<>8__locals1);
		1631.<ToAcronyms>g__Add|19_0(2023.DoubleTime, "DT", ref CS$<>8__locals1);
		1631.<ToAcronyms>g__Add|19_0(2023.Nightcore, "DT", ref CS$<>8__locals1);
		1631.<ToAcronyms>g__Add|19_0(2023.HalfTime, "HT", ref CS$<>8__locals1);
		1631.<ToAcronyms>g__Add|19_0(2023.Flashlight, "FL", ref CS$<>8__locals1);
		1631.<ToAcronyms>g__Add|19_0(2023.SpunOut, "SO", ref CS$<>8__locals1);
		1631.<ToAcronyms>g__Add|19_0(2023.FadeIn, "FI", ref CS$<>8__locals1);
		1631.<ToAcronyms>g__Add|19_0(2023.Key1, "1K", ref CS$<>8__locals1);
		1631.<ToAcronyms>g__Add|19_0(2023.Key2, "2K", ref CS$<>8__locals1);
		1631.<ToAcronyms>g__Add|19_0(2023.Key3, "3K", ref CS$<>8__locals1);
		1631.<ToAcronyms>g__Add|19_0(2023.Key4, "4K", ref CS$<>8__locals1);
		1631.<ToAcronyms>g__Add|19_0(2023.Key5, "5K", ref CS$<>8__locals1);
		1631.<ToAcronyms>g__Add|19_0(2023.Key6, "6K", ref CS$<>8__locals1);
		1631.<ToAcronyms>g__Add|19_0(2023.Key7, "7K", ref CS$<>8__locals1);
		1631.<ToAcronyms>g__Add|19_0(2023.Key8, "8K", ref CS$<>8__locals1);
		1631.<ToAcronyms>g__Add|19_0(2023.Key9, "9K", ref CS$<>8__locals1);
		if (CS$<>8__locals1.acronyms.Count == 0)
		{
			CS$<>8__locals1.acronyms.Add("NM");
		}
		return CS$<>8__locals1.acronyms.ToArray();
	}

	// Token: 0x06004576 RID: 17782 RVA: 0x001B4F00 File Offset: 0x001B3100
	internal static 2023 10(226 1)
	{
		2023 2 = 2023.None;
		109 3 = 1 as 109;
		if (3 == null)
		{
			return 2;
		}
		foreach (226 4 in 3)
		{
			string text = (4 is 217) ? 1631.Text(4["acronym"]) : 1631.Text(4);
			if (text != null)
			{
				int length = text.Length;
				if (length != 2)
				{
					if (length != 3)
					{
						continue;
					}
					if (!(text == "SV2"))
					{
						continue;
					}
				}
				else
				{
					switch (text[0])
					{
					case '1':
						if (!(text == "1K"))
						{
							continue;
						}
						2 |= 2023.Key1;
						continue;
					case '2':
						if (!(text == "2K"))
						{
							continue;
						}
						2 |= 2023.Key2;
						continue;
					case '3':
						if (!(text == "3K"))
						{
							continue;
						}
						2 |= 2023.Key3;
						continue;
					case '4':
						if (!(text == "4K"))
						{
							continue;
						}
						2 |= 2023.Key4;
						continue;
					case '5':
						if (!(text == "5K"))
						{
							continue;
						}
						2 |= 2023.Key5;
						continue;
					case '6':
						if (!(text == "6K"))
						{
							continue;
						}
						2 |= 2023.Key6;
						continue;
					case '7':
						if (!(text == "7K"))
						{
							continue;
						}
						2 |= 2023.Key7;
						continue;
					case '8':
						if (!(text == "8K"))
						{
							continue;
						}
						2 |= 2023.Key8;
						continue;
					case '9':
						if (!(text == "9K"))
						{
							continue;
						}
						2 |= 2023.Key9;
						continue;
					case ':':
					case ';':
					case '<':
					case '=':
					case '>':
					case '?':
					case '@':
					case 'B':
					case 'C':
					case 'G':
					case 'I':
					case 'J':
					case 'K':
					case 'L':
					case 'O':
					case 'Q':
					case 'U':
						continue;
					case 'A':
						if (!(text == "AP"))
						{
							continue;
						}
						2 |= 2023.Relax2;
						continue;
					case 'D':
						if (!(text == "DT"))
						{
							continue;
						}
						2 |= 2023.DoubleTime;
						continue;
					case 'E':
						if (!(text == "EZ"))
						{
							continue;
						}
						2 |= 2023.Easy;
						continue;
					case 'F':
						if (text == "FL")
						{
							2 |= 2023.Flashlight;
							continue;
						}
						if (!(text == "FI"))
						{
							continue;
						}
						2 |= 2023.FadeIn;
						continue;
					case 'H':
						if (text == "HD")
						{
							2 |= 2023.Hidden;
							continue;
						}
						if (text == "HR")
						{
							2 |= 2023.HardRock;
							continue;
						}
						if (!(text == "HT"))
						{
							continue;
						}
						2 |= 2023.HalfTime;
						continue;
					case 'M':
						if (!(text == "MR"))
						{
							continue;
						}
						2 |= 2023.Mirror;
						continue;
					case 'N':
						if (text == "NF")
						{
							2 |= 2023.NoFail;
							continue;
						}
						if (!(text == "NC"))
						{
							continue;
						}
						2 |= (2023.DoubleTime | 2023.Nightcore);
						continue;
					case 'P':
						if (!(text == "PF"))
						{
							continue;
						}
						2 |= (2023.SuddenDeath | 2023.Perfect);
						continue;
					case 'R':
						if (text == "RX")
						{
							2 |= 2023.Relax;
							continue;
						}
						if (!(text == "RD"))
						{
							continue;
						}
						2 |= 2023.Random;
						continue;
					case 'S':
						if (text == "SD")
						{
							2 |= 2023.SuddenDeath;
							continue;
						}
						if (!(text == "SO"))
						{
							continue;
						}
						2 |= 2023.SpunOut;
						continue;
					case 'T':
						if (!(text == "TD"))
						{
							continue;
						}
						2 |= 2023.TouchDevice;
						continue;
					case 'V':
						if (!(text == "V2"))
						{
							continue;
						}
						break;
					default:
						continue;
					}
				}
				2 |= 2023.ScoreV2;
			}
		}
		return 2;
	}

	// Token: 0x06004577 RID: 17783 RVA: 0x001B53C0 File Offset: 0x001B35C0
	private static List<string> 11(string 1, out int 2)
	{
		List<string> list = new List<string>();
		217 3 = 217.Parse(1);
		2 = (int)1631.12(3["score_count"]);
		109 4 = 3["scores"] as 109;
		if (4 == null)
		{
			return list;
		}
		int num = 1;
		foreach (226 5 in 4)
		{
			226 6 = 5["statistics"];
			226 7 = 5["user"];
			string text = (1631.Text((7 != null) ? 7["username"] : null) ?? string.Empty).Replace('|', ' ').Replace('\n', ' ');
			if (text.Length != 0)
			{
				233 8 = 5["pp"] as 233;
				if (((8 != null) ? 8.Value : null) != null)
				{
					try
					{
						double value = Convert.ToDouble(((233)5["pp"]).Value, CultureInfo.InvariantCulture);
						Dictionary<long, double> obj = 1631.2;
						lock (obj)
						{
							1631.2[1631.12(5["id"])] = value;
						}
					}
					catch (Exception)
					{
					}
				}
				list.Add(string.Join("|", new string[]
				{
					1631.12(5["id"]).ToString(CultureInfo.InvariantCulture),
					text,
					Math.Min(2147483647L, 1631.12(5["score"])).ToString(CultureInfo.InvariantCulture),
					1631.13(5["max_combo"]),
					1631.13((6 != null) ? 6["count_50"] : null),
					1631.13((6 != null) ? 6["count_100"] : null),
					1631.13((6 != null) ? 6["count_300"] : null),
					1631.13((6 != null) ? 6["count_miss"] : null),
					1631.13((6 != null) ? 6["count_katu"] : null),
					1631.13((6 != null) ? 6["count_geki"] : null),
					1631.14(5["perfect"]),
					((int)1631.10(5["mods"])).ToString(CultureInfo.InvariantCulture),
					1631.12(5["user_id"]).ToString(CultureInfo.InvariantCulture),
					num++.ToString(CultureInfo.InvariantCulture),
					1631.15(5["created_at"]).ToString(CultureInfo.InvariantCulture),
					1631.14(5["replay"])
				}));
			}
		}
		if (2 < list.Count)
		{
			2 = list.Count;
		}
		return list;
	}

	// Token: 0x06004578 RID: 17784 RVA: 0x001B5740 File Offset: 0x001B3940
	internal static string Text(226 1)
	{
		233 2 = 1 as 233;
		object obj = (2 != null) ? 2.Value : null;
		if (obj != null)
		{
			return Convert.ToString(obj, CultureInfo.InvariantCulture);
		}
		return null;
	}

	// Token: 0x06004579 RID: 17785 RVA: 0x001B5770 File Offset: 0x001B3970
	internal static long 12(226 1)
	{
		233 2 = 1 as 233;
		object obj = (2 != null) ? 2.Value : null;
		long result;
		try
		{
			result = ((obj == null) ? 0L : Convert.ToInt64(obj, CultureInfo.InvariantCulture));
		}
		catch (Exception)
		{
			result = 0L;
		}
		return result;
	}

	// Token: 0x0600457A RID: 17786 RVA: 0x001B57BC File Offset: 0x001B39BC
	private static string 13(226 1)
	{
		return Math.Max(0L, Math.Min(65535L, 1631.12(1))).ToString(CultureInfo.InvariantCulture);
	}

	// Token: 0x0600457B RID: 17787 RVA: 0x001B57F0 File Offset: 0x001B39F0
	private static string 14(226 1)
	{
		233 2 = 1 as 233;
		object obj = (2 != null) ? 2.Value : null;
		bool flag;
		bool flag2;
		if (obj is bool)
		{
			flag = (bool)obj;
			flag2 = true;
		}
		else
		{
			flag2 = false;
		}
		if (!flag2 || !flag)
		{
			return "0";
		}
		return "1";
	}

	// Token: 0x0600457C RID: 17788 RVA: 0x001B5834 File Offset: 0x001B3A34
	internal static long 15(226 1)
	{
		233 2 = 1 as 233;
		object obj = (2 != null) ? 2.Value : null;
		DateTime d;
		if (obj is DateTime)
		{
			d = ((DateTime)obj).ToUniversalTime();
		}
		else if (obj is DateTimeOffset)
		{
			d = ((DateTimeOffset)obj).UtcDateTime;
		}
		else if (!DateTime.TryParse(Convert.ToString(obj, CultureInfo.InvariantCulture), CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal | DateTimeStyles.AssumeUniversal, out d))
		{
			return 0L;
		}
		return (long)(d - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
	}

	// Token: 0x0600457D RID: 17789 RVA: 0x001B58C4 File Offset: 0x001B3AC4
	internal static string 16(string 1)
	{
		if (string.IsNullOrEmpty(1))
		{
			return string.Empty;
		}
		return "dpapi:" + Convert.ToBase64String(ProtectedData.Protect(Encoding.UTF8.GetBytes(1), null, DataProtectionScope.CurrentUser));
	}

	// Token: 0x0600457E RID: 17790 RVA: 0x001B58F8 File Offset: 0x001B3AF8
	internal static string 17(string 1)
	{
		if (string.IsNullOrEmpty(1) || !1.StartsWith("dpapi:", StringComparison.Ordinal))
		{
			return string.Empty;
		}
		string result;
		try
		{
			result = Encoding.UTF8.GetString(ProtectedData.Unprotect(Convert.FromBase64String(1.Substring("dpapi:".Length)), null, DataProtectionScope.CurrentUser));
		}
		catch (Exception)
		{
			result = string.Empty;
		}
		return result;
	}

	// Token: 0x06004580 RID: 17792 RVA: 0x001B597E File Offset: 0x001B3B7E
	[CompilerGenerated]
	internal static void <ToAcronyms>g__Add|19_0(2023 1, string 2, ref 1631.<>c__DisplayClass19_0 3)
	{
		if ((3.mods & 1) > 2023.None && !3.acronyms.Contains(2))
		{
			3.acronyms.Add(2);
		}
	}

	// Token: 0x040032D3 RID: 13011
	private const string 1 = "dpapi:";

	// Token: 0x040032D4 RID: 13012
	internal static readonly Dictionary<long, double> 2 = new Dictionary<long, double>();

	// Token: 0x040032D5 RID: 13013
	private static bool 3;

	// Token: 0x040032D6 RID: 13014
	private static readonly HashSet<string> 4 = new HashSet<string>();

	// Token: 0x040032D7 RID: 13015
	private static string 5;
}
