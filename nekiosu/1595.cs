using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

// Token: 0x020009EA RID: 2538
internal static class 1595
{
	// Token: 0x060046D3 RID: 18131 RVA: 0x001BE934 File Offset: 0x001BCB34
	internal static 217 1()
	{
		217 <<EMPTY_NAME>> = 1585.2("profile", "Display statistics of a user");
		217 2 = 1585.3(3, "embed", "Choose an embed type");
		2["choices"] = new 109(new ValueTuple<string, string>[]
		{
			new ValueTuple<string, string>("Compact", "compact"),
			new ValueTuple<string, string>("User statistics", "user_stats"),
			new ValueTuple<string, string>("Top100 statistics", "top100_stats"),
			new ValueTuple<string, string>("Top100 mods", "top100_mods"),
			new ValueTuple<string, string>("Top100 mappers", "top100_mappers")
		}.Select(delegate(ValueTuple<string, string> 1)
		{
			217 3 = new 217();
			3["name"] = 1.Item1;
			3["value"] = 1.Item2;
			return 3;
		}));
		<<EMPTY_NAME>>["options"] = new 109(new object[]
		{
			1585.4(true),
			2
		});
		return <<EMPTY_NAME>>;
	}

	// Token: 0x060046D4 RID: 18132 RVA: 0x001BEA30 File Offset: 0x001BCC30
	internal static void 2(217 1)
	{
		Dictionary<string, 226> dictionary = 1585.Options(3);
		2147 4 = 1585.Mode(dictionary);
		1595.1597 state = new 1595.1597
		{
			1 = 4,
			2 = (1585.Text(dictionary, "embed") ?? "compact"),
			3 = 1586.Origin(3),
			4 = 1608.3(100, 4)
		};
		1589.Start(3, 1, 1, 0, delegate(1589.1590 1, 217 2)
		{
			1586.1588 5 = new 1586.1588(delegate()
			{
				217 7;
				try
				{
					7 = 1595.3(state);
				}
				catch (Exception ex)
				{
					1338.4(ex, "building a profile embed", 1341.Runtime);
					217 8 = new 217();
					8["description"] = "Something went wrong.";
					8["color"] = 15158332;
					7 = 8;
				}
				byte[] array = 1586.47();
				if (array != null)
				{
					217 9 = 7;
					string text = "thumbnail";
					217 10 = new 217();
					10["url"] = "attachment://avatar.jpg";
					9[text] = 10;
				}
				217 11 = new 217();
				11["embeds"] = new 109(7);
				11["components"] = new 109(1589.Menu(1, 1595.1, state.2));
				217 12 = 11;
				1589.Edit(1, 2, 12, (array != null) ? "avatar.jpg" : null, array);
			});
			1586.46(5, state.1);
			if (state.2 == "top100_stats" || state.2 == "user_stats")
			{
				foreach (1599.1600 6 in state.4)
				{
					1586.34(6.1, 6.2, 6.3, 5);
				}
			}
			5.Start((state.2 == "top100_stats") ? 20000 : 8000);
		}, delegate(1589.1590 1, string 2)
		{
			if (1595.1.Any(([TupleElementNames(new string[]
			{
				"Value",
				"Label",
				"Description"
			})] ValueTuple<string, string, string> 1) => 1.Item1 == 2))
			{
				state.2 = 2;
			}
		}, false);
	}

	// Token: 0x060046D5 RID: 18133 RVA: 0x001BEABC File Offset: 0x001BCCBC
	private static 217 3(1595.1597 1)
	{
		foreach (1599.1600 2 in 1.4)
		{
			1586.35(2.1, 2.2, 2.3);
		}
		2210.2216 3 = 2210.4(1.1);
		string profileName = 1586.ProfileName;
		if (3 != null)
		{
			2224.Note(2210.5(profileName, 1.1), 0, 3.2 * 100.0);
		}
		217 4 = new 217();
		4["color"] = 2067276;
		4["author"] = 1586.Author(1.1);
		217 5 = 4;
		string 6 = 1.2;
		if (!(6 == "user_stats"))
		{
			if (!(6 == "top100_stats"))
			{
				if (!(6 == "top100_mods"))
				{
					if (!(6 == "top100_mappers"))
					{
						5["description"] = 1595.Compact(1, 3, profileName);
						1595.5(5, 1.1);
					}
					else
					{
						5["description"] = 1595.4("Top100 mappers", 1.1) + 1595.14(1.4);
					}
				}
				else
				{
					1595.12(5, 1.4, 1.1);
				}
			}
			else
			{
				5["description"] = 1595.4("Top100 statistics", 1.1) + 1595.9(1.4, 1.1);
			}
		}
		else
		{
			1595.7(5, 1, 3, profileName);
			1595.5(5, 1.1);
		}
		return 5;
	}

	// Token: 0x060046D6 RID: 18134 RVA: 0x001BEC90 File Offset: 0x001BCE90
	private static string 4(string 1, 2147 2)
	{
		string text = (1584.OwnerId != null) ? (" for <@" + 1584.OwnerId + ">") : string.Empty;
		return string.Concat(new string[]
		{
			"__**",
			1586.Emote(1586.43(2), string.Empty),
			" ",
			1,
			text,
			":**__\n"
		});
	}

	// Token: 0x060046D7 RID: 18135 RVA: 0x001BED00 File Offset: 0x001BCF00
	private static string Compact(1595.1597 1, 2210.2216 2, string 3)
	{
		double num = ((2 != null) ? 2.2 : 0.0) * 100.0;
		double num2 = 1595.Level((2 != null) ? 2.3 : 0L);
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("Accuracy: [`").Append(1586.2(num)).Append("%`](").Append(1.3).Append(" \"").Append(num.ToString(CultureInfo.InvariantCulture)).Append("\") • ");
		stringBuilder.Append("Level: [`").Append(1586.2(num2)).Append("`](").Append(1.3).Append(" \"Total score until next level: ").Append(1586.4(1595.6(num2, (2 != null) ? 2.3 : 0L))).Append("\")\n");
		stringBuilder.Append("Playcount: `").Append(1586.4((long)((2 != null) ? 2.5 : 0))).Append("` (`").Append((long)(2210.13(3, 1.1) / 3600.0)).Append(" hrs`)");
		2224.2225 4 = 2224.Get(2210.5(3, 1.1));
		if (4 != null && 4.1 > 0)
		{
			stringBuilder.Append("\nPeak rank: `#").Append(1586.4((long)4.1)).Append("` (<t:").Append(1586.7(4.2)).Append(":d>)");
		}
		return stringBuilder.ToString();
	}

	// Token: 0x060046D8 RID: 18136 RVA: 0x001BEEAC File Offset: 0x001BD0AC
	private static void 5(217 1, 2147 2)
	{
		List<2241> list = 2210.17(1586.ProfileName);
		if (list == null || list.Count == 0)
		{
			return;
		}
		DateTime dateTime = list.Min((2241 1) => 1.7).ToUniversalTime();
		3["footer"] = 1586.14(string.Concat(new string[]
		{
			"Playing since ",
			dateTime.ToString("yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture),
			" (",
			1586.8(dateTime),
			")"
		}), 1586.43(2));
	}

	// Token: 0x060046D9 RID: 18137 RVA: 0x001BEF54 File Offset: 0x001BD154
	private static double Level(long 1)
	{
		long[] array = 1654.1;
		long num = 1;
		double num2 = 0.0;
		while (num > 0L)
		{
			long num3 = array[Math.Min(array.Length - 1, (int)Math.Round(num2))];
			num2 += Math.Min(1.0, (double)num / (double)num3);
			num -= num3;
		}
		return num2 + 1.0;
	}

	// Token: 0x060046DA RID: 18138 RVA: 0x001BEFB4 File Offset: 0x001BD1B4
	private static long 6(double 1, long 2)
	{
		long[] array = 1654.1;
		int num = (int)Math.Ceiling(1);
		if ((double)num <= 1)
		{
			num++;
		}
		long num2 = 0L;
		for (int i = 0; i < num - 1; i++)
		{
			num2 += array[Math.Min(array.Length - 1, i)];
		}
		return Math.Max(0L, num2 - 2);
	}

	// Token: 0x060046DB RID: 18139 RVA: 0x001BF004 File Offset: 0x001BD204
	private static void 7(217 1, 1595.1597 2, 2210.2216 3, string 4)
	{
		string str = (1584.OwnerId != null) ? (" for <@" + 1584.OwnerId + ">") : string.Empty;
		11["description"] = "__**User statistics" + str + ":**__";
		double val = ((3 != null) ? 3.2 : 0.0) * 100.0;
		double num = (3 != null) ? 3.1 : 0.0;
		double num2 = 1595.Level((3 != null) ? 3.3 : 0L);
		2224.2225 5 = 2224.Get(2210.5(4, 2.1));
		List<2210.2214> list = (from 1 in ((3 != null) ? 3.9 : null) ?? new List<2210.2214>()
		where !1.7
		select 1).ToList<2210.2214>();
		double num3 = list.Sum((2210.2214 1) => 1.4 * 1.6);
		1595.<>c__DisplayClass10_0 CS$<>8__locals1;
		CS$<>8__locals1.grades = new Dictionary<string, int>(StringComparer.Ordinal);
		foreach (2210.2214 6 in list)
		{
			2241 7 = 6.1;
			string key = ((7 != null) ? 7.CalculateGrade().ToString() : null) ?? string.Empty;
			int num4;
			CS$<>8__locals1.grades.TryGetValue(key, out num4);
			CS$<>8__locals1.grades[key] = num4 + 1;
		}
		double num5 = (Math.Abs(num) <= 1.401298464324817E-45) ? 1.0 : ((2.1 == 2147.Taiko) ? (Math.Pow(num, 0.35) * 0.27) : (Math.Pow(num, 0.4) * 0.195));
		string 8 = (5 != null && 5.1 > 0) ? ("#" + 1586.4((long)5.1) + " " + 1595.<UserStats>g__Monthly|10_3(5.2)) : "-";
		string 9 = (5 != null && 5.3 > 0.0) ? string.Concat(new string[]
		{
			"[",
			1586.2(Math.Max(5.3, val)),
			"%](",
			2.3,
			" \"",
			Math.Max(5.3, val).ToString(CultureInfo.InvariantCulture),
			"%\") ",
			1595.<UserStats>g__Monthly|10_3(5.4)
		}) : "-";
		109 10 = new 109
		{
			1595.8("Peak rank", 8, true),
			1595.8("Top score PP", (list.Count > 0) ? (1586.2(list[0].4) + "pp") : "-", true),
			1595.8("Level", string.Concat(new string[]
			{
				"[",
				1586.2(num2),
				"](",
				2.3,
				" \"Total score until next level: ",
				1586.4(1595.6(num2, (3 != null) ? 3.3 : 0L)),
				"\")"
			}), true),
			1595.8("Total score", 1586.4((3 != null) ? 3.3 : 0L), true),
			1595.8("Bonus PP", (list.Count > 0) ? (1586.2(Math.Max(0.0, num - num3)) + "pp") : "-", true),
			1595.8("Ranked score", 1586.4((3 != null) ? 3.4 : 0L), true),
			1595.8("Peak accuracy", 9, true),
			1595.8("Accuracy", string.Concat(new string[]
			{
				"[",
				1586.2(val),
				"%](",
				2.3,
				" \"",
				val.ToString(CultureInfo.InvariantCulture),
				"%\")"
			}), true),
			1595.8("Recommended", 1586.1(num5) + "★", true),
			1595.8("Max combo", 1586.4((long)((3 != null) ? 3.7 : 0)), true),
			1595.8("Combined grades", string.Concat(new string[]
			{
				1595.<UserStats>g__Emote|10_4("X"),
				(1595.<UserStats>g__Count|10_2("XH", ref CS$<>8__locals1) + 1595.<UserStats>g__Count|10_2("X", ref CS$<>8__locals1)).ToString(),
				" ",
				1595.<UserStats>g__Emote|10_4("S"),
				(1595.<UserStats>g__Count|10_2("SH", ref CS$<>8__locals1) + 1595.<UserStats>g__Count|10_2("S", ref CS$<>8__locals1)).ToString()
			}), true),
			1595.8("Beatmaps", 1586.4((long)((3 != null) ? 3.6 : 0)), true),
			1595.8("Grades", string.Concat(new string[]
			{
				1595.<UserStats>g__Emote|10_4("XH"),
				1595.<UserStats>g__Count|10_2("XH", ref CS$<>8__locals1).ToString(),
				" ",
				1595.<UserStats>g__Emote|10_4("X"),
				1595.<UserStats>g__Count|10_2("X", ref CS$<>8__locals1).ToString(),
				" ",
				1595.<UserStats>g__Emote|10_4("SH"),
				1595.<UserStats>g__Count|10_2("SH", ref CS$<>8__locals1).ToString(),
				" ",
				1595.<UserStats>g__Emote|10_4("S"),
				1595.<UserStats>g__Count|10_2("S", ref CS$<>8__locals1).ToString(),
				" ",
				1595.<UserStats>g__Emote|10_4("A"),
				1595.<UserStats>g__Count|10_2("A", ref CS$<>8__locals1).ToString()
			}), false),
			1595.8("Play count / time", 1586.4((long)((3 != null) ? 3.5 : 0)) + " / " + ((long)(2210.13(4, 2.1) / 3600.0)).ToString() + " hrs", true)
		};
		11["fields"] = 10;
	}

	// Token: 0x060046DC RID: 18140 RVA: 0x001BF6F8 File Offset: 0x001BD8F8
	private static 217 8(string 1, string 2, bool 3 = true)
	{
		217 4 = new 217();
		4["name"] = 1;
		4["value"] = 2;
		4["inline"] = 3;
		return 4;
	}

	// Token: 0x060046DD RID: 18141 RVA: 0x001BF734 File Offset: 0x001BD934
	private static string 9(List<1599.1600> 1, 2147 2)
	{
		if (16.Count == 0)
		{
			return "No top scores :(";
		}
		1595.1596 3 = new 1595.1596();
		1595.1596 4 = new 1595.1596();
		1595.1596 5 = new 1595.1596();
		1595.1596 6 = new 1595.1596();
		1595.1596 7 = new 1595.1596();
		1595.1596 8 = new 1595.1596();
		1595.1596 9 = new 1595.1596();
		1595.1596 10 = new 1595.1596();
		1595.1596 11 = new 1595.1596();
		1595.1596 12 = new 1595.1596();
		1595.1596 13 = new 1595.1596();
		foreach (1599.1600 14 in 16)
		{
			2228.2229 15 = 14.1;
			3.1(15.27);
			4.1((double)15.23);
			5.1((double)15.22);
			6.1(15.32.GetValueOrDefault());
			double num = 1586.36(15, 14.2);
			if (num > 0.0)
			{
				7.1(num);
			}
			if (14.2 != null)
			{
				8.1(1586.23(15, 1928.ApproachRate));
				9.1(1586.23(15, 1928.CircleSize));
				10.1(1586.23(15, 1928.DrainRate));
				11.1(1586.23(15, 1928.OverallDifficulty));
				12.1(1586.27(15));
				13.1(1586.28(15));
			}
		}
		ValueTuple<string, string, string, string>[] array = new ValueTuple<string, string, string, string>[11];
		array[0] = new ValueTuple<string, string, string, string>("Accuracy", 1595.<Top100Stats>g__F|13_0(3.1), 1595.<Top100Stats>g__F|13_0(3.Avg), 1595.<Top100Stats>g__F|13_0(3.2));
		array[1] = new ValueTuple<string, string, string, string>("Combo", 1595.<Top100Stats>g__I|13_1(4.1), 1595.<Top100Stats>g__F|13_0(4.Avg), 1595.<Top100Stats>g__I|13_1(4.2));
		array[2] = new ValueTuple<string, string, string, string>("Misses", 1595.<Top100Stats>g__I|13_1(5.1), 1595.<Top100Stats>g__F|13_0(5.Avg), 1595.<Top100Stats>g__I|13_1(5.2));
		array[3] = new ValueTuple<string, string, string, string>("PP", 1595.<Top100Stats>g__F|13_0(6.1), 1595.<Top100Stats>g__F|13_0(6.Avg), 1595.<Top100Stats>g__F|13_0(6.2));
		array[4] = new ValueTuple<string, string, string, string>("Stars", (7.4 > 0) ? 1595.<Top100Stats>g__F|13_0(7.1) : "-", (7.4 > 0) ? 1595.<Top100Stats>g__F|13_0(7.Avg) : "-", (7.4 > 0) ? 1595.<Top100Stats>g__F|13_0(7.2) : "-");
		array[5] = new ValueTuple<string, string, string, string>("BPM", 1595.10(12, new Func<double, string>(1595.<Top100Stats>g__F|13_0), (1595.1596 1) => 1.1), 1595.10(12, new Func<double, string>(1595.<Top100Stats>g__F|13_0), (1595.1596 1) => 1.Avg), 1595.10(12, new Func<double, string>(1595.<Top100Stats>g__F|13_0), (1595.1596 1) => 1.2));
		array[6] = new ValueTuple<string, string, string, string>("HP", 1595.10(10, new Func<double, string>(1595.<Top100Stats>g__F|13_0), (1595.1596 1) => 1.1), 1595.10(10, new Func<double, string>(1595.<Top100Stats>g__F|13_0), (1595.1596 1) => 1.Avg), 1595.10(10, new Func<double, string>(1595.<Top100Stats>g__F|13_0), (1595.1596 1) => 1.2));
		array[7] = new ValueTuple<string, string, string, string>("AR", 1595.10(8, new Func<double, string>(1595.<Top100Stats>g__F|13_0), (1595.1596 1) => 1.1), 1595.10(8, new Func<double, string>(1595.<Top100Stats>g__F|13_0), (1595.1596 1) => 1.Avg), 1595.10(8, new Func<double, string>(1595.<Top100Stats>g__F|13_0), (1595.1596 1) => 1.2));
		array[8] = new ValueTuple<string, string, string, string>("CS", 1595.10(9, new Func<double, string>(1595.<Top100Stats>g__F|13_0), (1595.1596 1) => 1.1), 1595.10(9, new Func<double, string>(1595.<Top100Stats>g__F|13_0), (1595.1596 1) => 1.Avg), 1595.10(9, new Func<double, string>(1595.<Top100Stats>g__F|13_0), (1595.1596 1) => 1.2));
		array[9] = new ValueTuple<string, string, string, string>("OD", 1595.10(11, new Func<double, string>(1595.<Top100Stats>g__F|13_0), (1595.1596 1) => 1.1), 1595.10(11, new Func<double, string>(1595.<Top100Stats>g__F|13_0), (1595.1596 1) => 1.Avg), 1595.10(11, new Func<double, string>(1595.<Top100Stats>g__F|13_0), (1595.1596 1) => 1.2));
		array[10] = new ValueTuple<string, string, string, string>("Length", 1595.10(13, new Func<double, string>(1595.<Top100Stats>g__L|13_2), (1595.1596 1) => 1.1), 1595.10(13, new Func<double, string>(1595.<Top100Stats>g__L|13_2), (1595.1596 1) => 1.Avg), 1595.10(13, new Func<double, string>(1595.<Top100Stats>g__L|13_2), (1595.1596 1) => 1.2));
		ValueTuple<string, string, string, string>[] array2 = array;
		int num2 = Math.Max("Minimum".Length, array2.Max(([TupleElementNames(new string[]
		{
			"Label",
			"Min",
			"Avg",
			"Max"
		})] ValueTuple<string, string, string, string> 1) => 1.Item2.Length));
		int num3 = Math.Max("Average".Length, array2.Max(([TupleElementNames(new string[]
		{
			"Label",
			"Min",
			"Avg",
			"Max"
		})] ValueTuple<string, string, string, string> 1) => 1.Item3.Length));
		int num4 = Math.Max("Maximum".Length, array2.Max(([TupleElementNames(new string[]
		{
			"Label",
			"Min",
			"Avg",
			"Max"
		})] ValueTuple<string, string, string, string> 1) => 1.Item4.Length));
		StringBuilder stringBuilder = new StringBuilder("```\n");
		stringBuilder.Append("         | ").Append(1595.11("Minimum", num2)).Append(" | ").Append(1595.11("Average", num3)).Append(" | ").Append(1595.11("Maximum", num4)).Append('\n');
		stringBuilder.Append(new string('-', 9)).Append("+-").Append(new string('-', num2)).Append("-+-").Append(new string('-', num3)).Append("-+-").Append(new string('-', num4)).Append('\n');
		HashSet<string> hashSet;
		if (2 != 2147.CatchTheBeat)
		{
			if (2 != 2147.Taiko && 2 != 2147.OsuMania)
			{
				hashSet = new HashSet<string>();
			}
			else
			{
				HashSet<string> hashSet2 = new HashSet<string>();
				hashSet2.Add("AR");
				hashSet = hashSet2;
				hashSet2.Add("CS");
			}
		}
		else
		{
			(hashSet = new HashSet<string>()).Add("OD");
		}
		HashSet<string> hashSet3 = hashSet;
		foreach (ValueTuple<string, string, string, string> valueTuple in array2)
		{
			string item = valueTuple.Item1;
			string item2 = valueTuple.Item2;
			string item3 = valueTuple.Item3;
			string item4 = valueTuple.Item4;
			if (!hashSet3.Contains(item))
			{
				stringBuilder.Append(item.PadRight(9)).Append("| ").Append(1595.11(item2, num2)).Append(" | ").Append(1595.11(item3, num3)).Append(" | ").Append(1595.11(item4, num4)).Append('\n');
			}
		}
		return stringBuilder.Append("```").ToString();
	}

	// Token: 0x060046DE RID: 18142 RVA: 0x001C003C File Offset: 0x001BE23C
	private static string 10(1595.1596 1, Func<double, string> 2, Func<1595.1596, double> 3)
	{
		if (1.4 <= 0)
		{
			return "-";
		}
		return 2(3(1));
	}

	// Token: 0x060046DF RID: 18143 RVA: 0x001C005C File Offset: 0x001BE25C
	private static string 11(string 1, int 2)
	{
		int num = Math.Max(0, 2 - 1.Length);
		int num2 = num / 2;
		return new string(' ', num2) + 1 + new string(' ', num - num2);
	}

	// Token: 0x060046E0 RID: 18144 RVA: 0x001C0094 File Offset: 0x001BE294
	private static void 12(217 1, List<1599.1600> 2, 2147 3)
	{
		if (2.Count == 0)
		{
			6["description"] = 1595.4("Top100 mods", 3) + "No top scores :(";
			return;
		}
		Dictionary<string, int> dictionary = new Dictionary<string, int>(StringComparer.Ordinal);
		Dictionary<string, int> dictionary2 = new Dictionary<string, int>(StringComparer.Ordinal);
		Dictionary<string, double> dictionary3 = new Dictionary<string, double>(StringComparer.Ordinal);
		Dictionary<string, int> sizes = new Dictionary<string, int>(StringComparer.Ordinal);
		foreach (1599.1600 4 in 2)
		{
			List<string> list = 1586.16(4.1);
			string key = 1586.17(4.1);
			sizes[key] = list.Count;
			int num;
			dictionary2.TryGetValue(key, out num);
			dictionary2[key] = num + 1;
			double num2 = Math.Pow(0.95, (double)(4.5 - 1));
			double num3;
			dictionary3.TryGetValue(key, out num3);
			dictionary3[key] = num3 + 4.1.32.GetValueOrDefault() * num2;
			foreach (string key2 in list)
			{
				int num4;
				dictionary.TryGetValue(key2, out num4);
				dictionary[key2] = num4 + 1;
			}
		}
		109 5 = new 109();
		string text = 1595.13((from 1 in dictionary
		orderby 1.Value descending
		select new ValueTuple<string, string, int>(1.Key, base.<Top100Mods>g__Percent|0(1.Value).ToString(CultureInfo.InvariantCulture), 1)).ToList<ValueTuple<string, string, int>>(), "%", 4);
		if (text != null)
		{
			5.Add(1595.8("Favourite mods", text, false));
		}
		string text2 = 1595.13((from 1 in dictionary2
		orderby 1.Value descending
		select new ValueTuple<string, string, int>(1.Key, base.<Top100Mods>g__Percent|0(1.Value).ToString(CultureInfo.InvariantCulture), sizes[1.Key])).ToList<ValueTuple<string, string, int>>(), "%", 3);
		if (text2 != null)
		{
			5.Add(1595.8("Favourite mod combinations", text2, false));
		}
		string text3 = 1595.13((from 1 in dictionary3
		orderby 1.Value descending
		select new ValueTuple<string, string, int>(1.Key, 1.Value.ToString("0.0", CultureInfo.InvariantCulture), sizes[1.Key])).ToList<ValueTuple<string, string, int>>(), string.Empty, 3);
		if (text3 != null)
		{
			5.Add(1595.8("Profitable mod combinations (pp)", text3, false));
		}
		6["description"] = 1595.4("Top100 mods", 3);
		6["fields"] = 5;
	}

	// Token: 0x060046E1 RID: 18145 RVA: 0x001C0384 File Offset: 0x001BE584
	private static string 13([TupleElementNames(new string[]
	{
		"Mods",
		"Value",
		"Count"
	})] List<ValueTuple<string, string, int>> 1, string 2, int 3)
	{
		if (1.Count == 0)
		{
			return null;
		}
		int[] array = new int[3];
		int[] array2 = new int[3];
		for (int i = 0; i < 1.Count; i++)
		{
			array[i % 3] = Math.Max(array[i % 3], 1[i].Item3);
			array2[i % 3] = Math.Max(array2[i % 3], 1[i].Item2.Length);
		}
		StringBuilder stringBuilder = new StringBuilder();
		for (int j = 0; j < 1.Count; j++)
		{
			int num = j % 3;
			if (j > 0)
			{
				stringBuilder.Append((num == 0) ? "\n" : " • ");
			}
			int totalWidth = array2[num] + (Math.Max(1, array[num]) - Math.Max(1, 1[j].Item3)) * 2;
			stringBuilder.Append('`').Append(1[j].Item1).Append(':').Append(1[j].Item2.PadLeft(totalWidth)).Append(2).Append('`');
		}
		return 1586.6(stringBuilder.ToString(), 1024);
	}

	// Token: 0x060046E2 RID: 18146 RVA: 0x001C04B8 File Offset: 0x001BE6B8
	private static string 14(List<1599.1600> 1)
	{
		if (2.Count == 0)
		{
			return "No top scores :(";
		}
		List<ValueTuple<string, int, double>> list = (from 1 in (from 1 in 2
		where !string.IsNullOrEmpty(1.1.9)
		select 1).GroupBy((1599.1600 1) => 1.1.9, StringComparer.OrdinalIgnoreCase)
		select new ValueTuple<string, int, double>(1.First<1599.1600>().1.9, 1.Count<1599.1600>(), 1.Sum((1599.1600 1) => 1.1.32.GetValueOrDefault() * Math.Pow(0.95, (double)(1.5 - 1)))) into 1
		orderby 1.Item2 descending, 1.Item3 descending
		select 1).Take(10).ToList<ValueTuple<string, int, double>>();
		if (list.Count == 0)
		{
			return "No top scores :(";
		}
		List<ValueTuple<string, string, string>> list2 = (from 1 in list
		select new ValueTuple<string, string, string>(1.Item1, 1586.2(1.Item3), 1.Item2.ToString(CultureInfo.InvariantCulture))).ToList<ValueTuple<string, string, string>>();
		int num = list2.Max(([TupleElementNames(new string[]
		{
			"Name",
			"Pp",
			"Count"
		})] ValueTuple<string, string, string> 1) => 1.Item1.Length);
		int num2 = Math.Max(2, list2.Max(([TupleElementNames(new string[]
		{
			"Name",
			"Pp",
			"Count"
		})] ValueTuple<string, string, string> 1) => 1.Item2.Length));
		int num3 = Math.Max(1, list2.Max(([TupleElementNames(new string[]
		{
			"Name",
			"Pp",
			"Count"
		})] ValueTuple<string, string, string> 1) => 1.Item3.Length));
		StringBuilder stringBuilder = new StringBuilder("```\n");
		stringBuilder.Append(" ".PadRight(num)).Append(" | ").Append(1595.11("PP", num2)).Append(" | ").Append(1595.11("#", num3)).Append('\n');
		stringBuilder.Append(new string('-', num)).Append("-+-").Append(new string('-', num2)).Append("-+-").Append(new string('-', num3)).Append("-\n");
		foreach (ValueTuple<string, string, string> valueTuple in list2)
		{
			string item = valueTuple.Item1;
			string item2 = valueTuple.Item2;
			string item3 = valueTuple.Item3;
			stringBuilder.Append(item.PadRight(num)).Append(" | ").Append(item2.PadLeft(num2)).Append(" | ").Append(item3.PadLeft(num3)).Append('\n');
		}
		return stringBuilder.Append("```").ToString();
	}

	// Token: 0x060046E4 RID: 18148 RVA: 0x001C0840 File Offset: 0x001BEA40
	[CompilerGenerated]
	internal static int <UserStats>g__Count|10_2(string 1, ref 1595.<>c__DisplayClass10_0 2)
	{
		int result;
		if (!2.grades.TryGetValue(1, out result))
		{
			return 0;
		}
		return result;
	}

	// Token: 0x060046E5 RID: 18149 RVA: 0x001C0860 File Offset: 0x001BEA60
	[CompilerGenerated]
	internal static string <UserStats>g__Monthly|10_3(DateTime 1)
	{
		return string.Concat(new string[]
		{
			"('",
			(1.Year % 100).ToString("00", CultureInfo.InvariantCulture),
			"/",
			1.Month.ToString("00", CultureInfo.InvariantCulture),
			")"
		});
	}

	// Token: 0x060046E6 RID: 18150 RVA: 0x001C08CB File Offset: 0x001BEACB
	[CompilerGenerated]
	internal static string <UserStats>g__Emote|10_4(string 1)
	{
		return 1586.12(1);
	}

	// Token: 0x060046E7 RID: 18151 RVA: 0x001C08D3 File Offset: 0x001BEAD3
	[CompilerGenerated]
	internal static string <Top100Stats>g__F|13_0(double 1)
	{
		return 1586.2(1);
	}

	// Token: 0x060046E8 RID: 18152 RVA: 0x001C08DC File Offset: 0x001BEADC
	[CompilerGenerated]
	internal static string <Top100Stats>g__I|13_1(double 1)
	{
		return ((long)1).ToString(CultureInfo.InvariantCulture);
	}

	// Token: 0x060046E9 RID: 18153 RVA: 0x001C08F8 File Offset: 0x001BEAF8
	[CompilerGenerated]
	internal static string <Top100Stats>g__L|13_2(double 1)
	{
		return 1586.9((int)1);
	}

	// Token: 0x040033D6 RID: 13270
	[TupleElementNames(new string[]
	{
		"Value",
		"Label",
		"Description"
	})]
	private static readonly ValueTuple<string, string, string>[] 1 = new ValueTuple<string, string, string>[]
	{
		new ValueTuple<string, string, string>("compact", "Compact", "Compact user statistics"),
		new ValueTuple<string, string, string>("user_stats", "User Statistics", "Extended user statistics"),
		new ValueTuple<string, string, string>("top100_stats", "Top100 Statistics", "Min-Avg-Max values for top100 scores"),
		new ValueTuple<string, string, string>("top100_mods", "Top100 Mods", "Favourite mods in top100 scores"),
		new ValueTuple<string, string, string>("top100_mappers", "Top100 Mappers", "Mapper appearances in top100 scores")
	};

	// Token: 0x020009EB RID: 2539
	private sealed class 1597
	{
		// Token: 0x040033D7 RID: 13271
		public 2147 1;

		// Token: 0x040033D8 RID: 13272
		public string 2;

		// Token: 0x040033D9 RID: 13273
		public string 3;

		// Token: 0x040033DA RID: 13274
		public List<1599.1600> 4;
	}

	// Token: 0x020009EC RID: 2540
	private sealed class 1596
	{
		// Token: 0x060046EB RID: 18155 RVA: 0x001C0904 File Offset: 0x001BEB04
		public void 1(double 1)
		{
			this.1 = Math.Min(this.1, 1);
			this.2 = Math.Max(this.2, 1);
			this.3 += 1;
			this.4++;
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x060046EC RID: 18156 RVA: 0x001C0951 File Offset: 0x001BEB51
		public double Avg
		{
			get
			{
				if (this.4 <= 0)
				{
					return 0.0;
				}
				return this.3 / (double)this.4;
			}
		}

		// Token: 0x040033DB RID: 13275
		public double 1 = double.MaxValue;

		// Token: 0x040033DC RID: 13276
		public double 2 = double.MinValue;

		// Token: 0x040033DD RID: 13277
		public double 3;

		// Token: 0x040033DE RID: 13278
		public int 4;
	}
}
