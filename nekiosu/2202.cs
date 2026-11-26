using System;
using System.Collections.Generic;
using System.Globalization;

// Token: 0x0200065B RID: 1627
[276]
internal static class 2202
{
	// Token: 0x06003188 RID: 12680 RVA: 0x001283A0 File Offset: 0x001265A0
	internal static void Start()
	{
		if (261.FullyOffline)
		{
			return;
		}
		if (!1631.IsConfigured)
		{
			1763.5("Import Bancho data needs the osu! API: set it up first in Options (Online rankings).", 198.Orange, 6000, null);
			return;
		}
		string profile = 1304.189.GetValue() ?? string.Empty;
		if (profile.Trim().Length == 0)
		{
			1763.5("Import Bancho data needs a profile name: the name of your osu! account.", 198.Orange, 5000, null);
			return;
		}
		if (2202.4)
		{
			return;
		}
		2202.4 = true;
		2147 mode = 2210.Mode;
		1763.5(string.Concat(new string[]
		{
			"Bancho: looking up the best ",
			2202.2(mode),
			" plays of ",
			profile,
			"..."
		}), 198.YellowGreen, 3000, null);
		1662.17(delegate
		{
			2202.2203 fetched = null;
			string failure = null;
			try
			{
				fetched = 2202.3(profile.Trim(), mode);
			}
			catch (Exception ex)
			{
				failure = ((ex is InvalidOperationException || ex is ArgumentException) ? ex.Message : "The plays could not be retrieved.");
				1338.5("Bancho: matching " + profile + " failed: " + ex.Message, 1341.Runtime, (1114)2);
			}
			1662.89.Schedule(delegate()
			{
				2202.4 = false;
				if (failure != null)
				{
					1763.5("Bancho: " + failure, 198.OrangeRed, 6000, null);
					return;
				}
				if (fetched == null)
				{
					1763.5("Bancho: there is no osu! account named " + profile + " (or it is restricted).", 198.Orange, 6000, null);
					return;
				}
				2202.4(profile, fetched);
			}, true);
		});
	}

	// Token: 0x06003189 RID: 12681 RVA: 0x0012848E File Offset: 0x0012668E
	internal static string 1(2147 1)
	{
		switch (1)
		{
		case 2147.Taiko:
			return "taiko";
		case 2147.CatchTheBeat:
			return "fruits";
		case 2147.OsuMania:
			return "mania";
		default:
			return "osu";
		}
	}

	// Token: 0x0600318A RID: 12682 RVA: 0x001284BD File Offset: 0x001266BD
	internal static string 2(2147 1)
	{
		switch (1)
		{
		case 2147.Taiko:
			return "osu!taiko";
		case 2147.CatchTheBeat:
			return "osu!catch";
		case 2147.OsuMania:
			return "osu!mania";
		default:
			return "osu!standard";
		}
	}

	// Token: 0x0600318B RID: 12683 RVA: 0x001284EC File Offset: 0x001266EC
	private static 2202.2203 3(string 1, 2147 2)
	{
		string text = 267.5(1, 2202.1(2));
		if (text == null)
		{
			return null;
		}
		217 3 = 217.Parse(text);
		long num = 1631.12(3["id"]);
		if (num <= 0L)
		{
			return null;
		}
		2202.2203 4 = new 2202.2203
		{
			1 = 2,
			2 = (1631.Text(3["username"]) ?? 1),
			3 = num
		};
		string text2 = 1631.Text(3["country_code"]);
		4.5 = (2204.1(text2) ? text2.ToUpperInvariant() : null);
		try
		{
			226 5 = 3["statistics"];
			233 6 = ((5 != null) ? 5["pp"] : null) as 233;
			object obj = (6 != null) ? 6.Value : null;
			4.4 = ((obj == null) ? 0.0 : Convert.ToDouble(obj, CultureInfo.InvariantCulture));
		}
		catch (Exception)
		{
			4.4 = 0.0;
		}
		for (int i = 0; i < 200; i += 100)
		{
			109 7 = 226.Parse(267.6(num, i, 100, 2202.1(2))) as 109;
			if (7 == null)
			{
				throw new InvalidOperationException("The osu! API answered with something other than a list of plays.");
			}
			4.6.AddRange(7);
			if (7.Count < 100)
			{
				break;
			}
		}
		return 4;
	}

	// Token: 0x0600318C RID: 12684 RVA: 0x00128654 File Offset: 0x00126854
	private static void 4(string 1, 2202.2203 2)
	{
		if (!string.Equals(1304.189.GetValue() ?? string.Empty, 3, StringComparison.Ordinal))
		{
			1763.5("Bancho: the profile was changed meanwhile; nothing was added.", 198.Orange, 5000, null);
			return;
		}
		if (4.6.Count == 0)
		{
			1763.5(string.Concat(new string[]
			{
				"Bancho: the osu! account ",
				4.2,
				" has no ",
				2202.2(4.1),
				" plays set in osu!stable."
			}), 198.Orange, 6000, null);
			return;
		}
		string text = string.Equals(4.2, 3.Trim(), StringComparison.OrdinalIgnoreCase) ? string.Empty : " (found by an earlier name)";
		1662.25(new 1688(string.Concat(new string[]
		{
			"Add the best ",
			4.6.Count.ToString(),
			" ",
			2202.2(4.1),
			" plays of the osu! account ",
			4.2,
			text,
			" to the profile ",
			3,
			"?"
		}), delegate(object 1, EventArgs 2)
		{
			2202.Apply(3, 4);
			1662.25(new 1707(false));
		}, null, true));
	}

	// Token: 0x0600318D RID: 12685 RVA: 0x001287D4 File Offset: 0x001269D4
	private static void Apply(string 1, 2202.2203 2)
	{
		Dictionary<string, List<2241>> dictionary = new Dictionary<string, List<2241>>();
		foreach (KeyValuePair<string, List<2241>> keyValuePair in 2230.6(true))
		{
			dictionary[keyValuePair.Key] = keyValuePair.Value;
		}
		List<2241> list = new List<2241>();
		int num = 0;
		int num2 = 0;
		bool flag = false;
		foreach (226 3 in 8.6)
		{
			bool flag2 = 2202.6(3);
			double num3;
			int num4;
			int num5;
			string text;
			2241 score = 2202.7(3, 7, 8.1, out num3, out num4, out num5, out text);
			if (score == null)
			{
				num2++;
			}
			else
			{
				List<2241> list2;
				2241 4 = dictionary.TryGetValue(score.10, out list2) ? list2.Find((2241 1) => 2202.8(1, score, 7)) : null;
				if (4 != null)
				{
					num++;
					if (flag2)
					{
						2210.51(4, num3, num4, num5, text, true);
					}
					if (4.16 <= 0L && score.16 > 0L)
					{
						4.16 = score.16;
						flag = true;
					}
				}
				else
				{
					2210.51(score, num3, num4, num5, text, flag2);
					list.Add(score);
				}
			}
		}
		double num6 = -1.0;
		if (8.4 > 0.0)
		{
			List<double> list3 = new List<double>();
			foreach (226 5 in 8.6)
			{
				try
				{
					233 6 = 5["pp"] as 233;
					object obj = (6 != null) ? 6.Value : null;
					if (obj != null)
					{
						list3.Add(Convert.ToDouble(obj, CultureInfo.InvariantCulture));
					}
				}
				catch (Exception)
				{
				}
			}
			list3.Sort((double 1, double 2) => 2.CompareTo(1));
			double num7 = 0.0;
			double num8 = 1.0;
			foreach (double num9 in list3)
			{
				num7 += num9 * num8;
				num8 *= 0.95;
			}
			num6 = Math.Max(0.0, 8.4 - num7);
			2210.54(7, num6, 8.1);
		}
		2210.Save();
		int num10 = (list.Count > 0) ? 2230.27(list) : 0;
		num += list.Count - num10;
		if (flag)
		{
			2230.17(true);
		}
		string text2 = string.Equals(8.2, 7, StringComparison.OrdinalIgnoreCase) ? string.Empty : (" (account " + 8.2 + ")");
		string str = string.Concat(new string[]
		{
			"Bancho",
			text2,
			": ",
			num10.ToString(),
			" of the best ",
			8.6.Count.ToString(),
			" ",
			2202.2(8.1),
			" play(s) added to ",
			7
		});
		if (num > 0)
		{
			str = str + ", " + num.ToString() + " were here already";
		}
		if (num2 > 0)
		{
			str = str + ", " + num2.ToString() + " could not be read";
		}
		if (num6 >= 0.0)
		{
			str += string.Format(1662.18, ". Bonus pp as on Bancho: {0:0.##}pp", num6);
		}
		str += ".";
		1338.5(str, 1341.Runtime, (1114)2);
		1763.5(str, (num10 > 0) ? 198.YellowGreen : 198.Orange, 8000, null);
		2210.7();
		2202.5(7, 8.3);
		if (8.5 != null && 2210.11(7) == null)
		{
			2210.12(7, 8.5);
		}
	}

	// Token: 0x0600318E RID: 12686 RVA: 0x00128CE0 File Offset: 0x00126EE0
	private static void 5(string 1, long 2)
	{
		if (2 <= 0L || 2226.2(1))
		{
			return;
		}
		1662.17(delegate
		{
			byte[] image = null;
			try
			{
				image = 267.10(2);
			}
			catch (Exception ex)
			{
				1338.5("Bancho: the avatar of " + 1 + " could not be fetched: " + ex.Message, 1341.Runtime, (1114)2);
			}
			if (image != null)
			{
				1662.89.Schedule(delegate()
				{
					if (!2226.2(1))
					{
						2226.4(1, image);
					}
				}, true);
			}
		});
	}

	// Token: 0x0600318F RID: 12687 RVA: 0x00128D2B File Offset: 0x00126F2B
	private static bool 6(226 1)
	{
		return 1631.Text(1["type"]) == "solo_score" || 1631.12(1["best_id"]) <= 0L;
	}

	// Token: 0x06003190 RID: 12688 RVA: 0x00128D64 File Offset: 0x00126F64
	private static 2241 7(226 1, string 2, 2147 3, out double 4, out int 5, out int 6, out string 7)
	{
		4 = 0.0;
		5 = -1;
		6 = 0;
		7 = null;
		226 8 = 1["beatmap"];
		string text = 1631.Text((8 != null) ? 8["checksum"] : null);
		226 9 = 1["statistics"];
		if (text != null && text.Length == 32 && 9 != null && !(1631.Text(1["mode"]) != 2202.1(3)))
		{
			233 10 = 1["passed"] as 233;
			if ((((10 != null) ? 10.Value : null) as bool?).GetValueOrDefault())
			{
				long num = 1631.15(1["created_at"]);
				if (num <= 0L)
				{
					return null;
				}
				2241 11 = 2246.Create(3, 2, null, false);
				11.10 = text.ToLowerInvariant();
				11.23 = 2;
				11.18 = true;
				11.7 = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds((double)num);
				11.2 = 2202.9(9["count_300"]);
				11.1 = 2202.9(9["count_100"]);
				11.3 = 2202.9(9["count_50"]);
				11.4 = 2202.9(9["count_geki"]);
				11.5 = 2202.9(9["count_katu"]);
				11.6 = 2202.9(9["count_miss"]);
				11.SetRawScore((int)Math.Max(0L, Math.Min(2147483647L, 1631.12(1["score"]))));
				11.13 = (int)2202.9(1["max_combo"]);
				2241 12 = 11;
				233 13 = 1["perfect"] as 233;
				12.22 = (((13 != null) ? 13.Value : null) as bool?).GetValueOrDefault();
				11.8 = 1631.10(1["mods"]);
				11.16 = 1631.12(1["id"]);
				try
				{
					233 14 = 1["pp"] as 233;
					object obj = (14 != null) ? 14.Value : null;
					4 = ((obj == null) ? 0.0 : Convert.ToDouble(obj, CultureInfo.InvariantCulture));
				}
				catch (Exception)
				{
					4 = 0.0;
				}
				string a = 1631.Text(8["status"]);
				if (!(a == "ranked"))
				{
					if (!(a == "approved"))
					{
						if (!(a == "qualified"))
						{
							if (a == "loved")
							{
								5 = 7;
							}
						}
						else
						{
							5 = 6;
						}
					}
					else
					{
						5 = 5;
					}
				}
				else
				{
					5 = 4;
				}
				6 = (int)Math.Max(0L, Math.Min(2147483647L, 1631.12(8["id"])));
				226 15 = 1["beatmapset"];
				string text2 = 1631.Text((15 != null) ? 15["artist"] : null);
				string text3 = 1631.Text((15 != null) ? 15["title"] : null);
				string text4 = 1631.Text(8["version"]);
				if (!string.IsNullOrEmpty(text3))
				{
					7 = (string.IsNullOrEmpty(text2) ? text3 : (text2 + " - " + text3)) + (string.IsNullOrEmpty(text4) ? string.Empty : (" [" + text4 + "]"));
				}
				return 11;
			}
		}
		return null;
	}

	// Token: 0x06003191 RID: 12689 RVA: 0x00129130 File Offset: 0x00127330
	private static bool 8(2241 1, 2241 2, string 3)
	{
		return 1 != null && 1.9 == 2.9 && string.Equals(1.23 ?? string.Empty, 3, StringComparison.OrdinalIgnoreCase) && ((1.16 > 0L && 1.16 == 2.16) || (1.GetScore() == 2.GetScore() && 1.2 == 2.2 && 1.1 == 2.1 && 1.3 == 2.3 && 1.6 == 2.6 && ((2.9 != 2147.OsuMania && 2.9 != 2147.CatchTheBeat) || (1.4 == 2.4 && 1.5 == 2.5)) && (1.8 & (2023.NoFail | 2023.Easy | 2023.Hidden | 2023.HardRock | 2023.DoubleTime | 2023.HalfTime | 2023.Flashlight | 2023.SpunOut | 2023.Key4 | 2023.Key5 | 2023.Key6 | 2023.Key7 | 2023.Key8 | 2023.FadeIn | 2023.Random | 2023.Key9 | 2023.KeyCoop | 2023.Key1 | 2023.Key3 | 2023.Key2 | 2023.Mirror)) == (2.8 & (2023.NoFail | 2023.Easy | 2023.Hidden | 2023.HardRock | 2023.DoubleTime | 2023.HalfTime | 2023.Flashlight | 2023.SpunOut | 2023.Key4 | 2023.Key5 | 2023.Key6 | 2023.Key7 | 2023.Key8 | 2023.FadeIn | 2023.Random | 2023.Key9 | 2023.KeyCoop | 2023.Key1 | 2023.Key3 | 2023.Key2 | 2023.Mirror)) && (1.7.ToUniversalTime() - 2.7).Duration() <= 2202.3));
	}

	// Token: 0x06003192 RID: 12690 RVA: 0x00129250 File Offset: 0x00127450
	private static ushort 9(226 1)
	{
		return (ushort)Math.Max(0L, Math.Min(65535L, 1631.12(1)));
	}

	// Token: 0x04002483 RID: 9347
	private const int 1 = 100;

	// Token: 0x04002484 RID: 9348
	private const int 2 = 200;

	// Token: 0x04002485 RID: 9349
	private static readonly TimeSpan 3 = TimeSpan.FromMinutes(5.0);

	// Token: 0x04002486 RID: 9350
	private static bool 4;

	// Token: 0x04002487 RID: 9351
	private const 2023 5 = 2023.NoFail | 2023.Easy | 2023.Hidden | 2023.HardRock | 2023.DoubleTime | 2023.HalfTime | 2023.Flashlight | 2023.SpunOut | 2023.Key4 | 2023.Key5 | 2023.Key6 | 2023.Key7 | 2023.Key8 | 2023.FadeIn | 2023.Random | 2023.Key9 | 2023.KeyCoop | 2023.Key1 | 2023.Key3 | 2023.Key2 | 2023.Mirror;

	// Token: 0x0200065C RID: 1628
	[276]
	private sealed class 2203
	{
		// Token: 0x04002488 RID: 9352
		public 2147 1;

		// Token: 0x04002489 RID: 9353
		public string 2;

		// Token: 0x0400248A RID: 9354
		public long 3;

		// Token: 0x0400248B RID: 9355
		public double 4;

		// Token: 0x0400248C RID: 9356
		public string 5;

		// Token: 0x0400248D RID: 9357
		public readonly List<226> 6 = new List<226>();
	}
}
