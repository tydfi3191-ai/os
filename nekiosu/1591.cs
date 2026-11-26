using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

// Token: 0x020009D5 RID: 2517
internal static class 1591
{
	// Token: 0x0600467C RID: 18044 RVA: 0x001BB024 File Offset: 0x001B9224
	internal static 217 1()
	{
		return 1585.2("mostplayed", "Display the most played maps of a user");
	}

	// Token: 0x0600467D RID: 18045 RVA: 0x001BB038 File Offset: 0x001B9238
	internal static 217 2()
	{
		217 <<EMPTY_NAME>> = 1585.2("rl", "Show all recent plays of a user");
		217 2 = 1585.3(3, "sort", "Choose how the scores should be ordered");
		2["choices"] = new 109(1591.1.Select(delegate([TupleElementNames(new string[]
		{
			"Value",
			"Name"
		})] ValueTuple<string, string> 1)
		{
			217 3 = new 217();
			3["name"] = 1.Item2;
			3["value"] = 1.Item1;
			return 3;
		}));
		<<EMPTY_NAME>>["options"] = new 109
		{
			1585.4(true),
			1585.3(3, "query", "Specify a search query containing artist, difficulty, AR, BPM, ..."),
			1585.5(),
			2,
			1585.3(5, "passes", "Specify whether only passes should be considered"),
			1585.3(3, "mods", "Specify mods (`+mods` for included, `+mods!` for exact, `-mods!` for excluded)")
		};
		return <<EMPTY_NAME>>;
	}

	// Token: 0x0600467E RID: 18046 RVA: 0x001BB110 File Offset: 0x001B9310
	internal static void 3(217 1)
	{
		List<2210.2215> maps = (from 1 in 2210.15(1586.ProfileName, 2147.Osu) ?? new List<2210.2215>()
		orderby 1.4 descending
		select 1).ToList<2210.2215>();
		1589.Start(3, maps.Count, 10, 0, delegate(1589.1590 1, 217 2)
		{
			1586.1588 4 = new 1586.1588(delegate()
			{
				StringBuilder stringBuilder = new StringBuilder();
				foreach (2210.2215 5 in maps.Skip(1.3).Take(1.5))
				{
					1262 6 = 5.2 ?? 1272.8(5.1);
					string text = (6 != null) ? string.Concat(new string[]
					{
						1586.5(6.7),
						" - ",
						1586.5(6.10),
						" [",
						1586.5(6.89),
						"]"
					}) : 1586.5(5.3 ?? 5.1);
					string value = (6 != null && 6.25 > 0) ? string.Concat(new string[]
					{
						"[",
						text,
						"](",
						244.3(6.25),
						")"
					}) : text;
					double num = 0.0;
					try
					{
						num = ((6 != null) ? 6.18(2147.Osu, 2023.None) : 0.0);
					}
					catch (Exception)
					{
					}
					stringBuilder.Append("**[").Append(5.4).Append("]** ").Append(value).Append(" [").Append((num > 0.0) ? 1586.2(num) : "-").Append("★]\n");
				}
				byte[] array = 1586.47();
				217 7 = new 217();
				7["color"] = 2067276;
				7["author"] = 1586.Author(2147.Osu);
				7["title"] = "Most played maps:";
				7["description"] = ((stringBuilder.Length > 0) ? stringBuilder.ToString() : "No plays");
				string text2 = "footer";
				217 8 = new 217();
				8["text"] = "Page " + 1.Page.ToString() + "/" + 1.LastPage.ToString();
				7[text2] = 8;
				217 9 = 7;
				if (array != null)
				{
					217 10 = 9;
					string text3 = "thumbnail";
					217 11 = new 217();
					11["url"] = "attachment://avatar.jpg";
					10[text3] = 11;
				}
				217 12 = new 217();
				12["embeds"] = new 109(9);
				12["components"] = 1589.Buttons(1);
				217 13 = 12;
				1589.Edit(1, 2, 13, (array != null) ? "avatar.jpg" : null, array);
			});
			1586.46(4, 2147.Osu);
			4.Start(8000);
		}, null, false);
	}

	// Token: 0x0600467F RID: 18047 RVA: 0x001BB18C File Offset: 0x001B938C
	internal static void 4(217 1)
	{
		1591.<>c__DisplayClass4_0 CS$<>8__locals1 = new 1591.<>c__DisplayClass4_0();
		CS$<>8__locals1.interaction = 4;
		Dictionary<string, 226> dictionary = 1585.Options(CS$<>8__locals1.interaction);
		1591.<>c__DisplayClass4_0 CS$<>8__locals2 = CS$<>8__locals1;
		string text = 1585.Text(dictionary, "grade");
		CS$<>8__locals2.grade = ((text != null) ? text.ToUpperInvariant() : null);
		CS$<>8__locals1.passes = 1585.6(dictionary, "passes");
		CS$<>8__locals1.sort = 1585.Text(dictionary, "sort");
		CS$<>8__locals1.query = 1585.Text(dictionary, "query");
		string text2 = 1585.Text(dictionary, "mods");
		CS$<>8__locals1.mode = 1585.Mode(dictionary);
		CS$<>8__locals1.mods = null;
		if (text2 != null)
		{
			CS$<>8__locals1.mods = 1608.1610.1(text2);
			if (CS$<>8__locals1.mods == null)
			{
				1586.58(CS$<>8__locals1.interaction, "Failed to parse mods.\nIf you want included mods, specify it e.g. as `+hrdt`.\nIf you want exact mods, specify it e.g. as `+hdhr!`.\nAnd if you want to exclude mods, specify it e.g. as `-hdnf!`.");
				return;
			}
		}
		if (CS$<>8__locals1.grade == "F" && CS$<>8__locals1.passes.GetValueOrDefault())
		{
			1586.58(CS$<>8__locals1.interaction, ":clown:");
			return;
		}
		string profileName = 1586.ProfileName;
		List<2228.2229> list = (from 1 in 2228.Get(profileName)
		where 1.10 == CS$<>8__locals1.mode
		select 1).ToList<2228.2229>();
		if (list.Count == 0)
		{
			1586.58(CS$<>8__locals1.interaction, string.Concat(new string[]
			{
				"No recent ",
				1586.42(CS$<>8__locals1.mode),
				"plays found for user `",
				profileName,
				"`"
			}));
			return;
		}
		CS$<>8__locals1.criteria = (string.IsNullOrWhiteSpace(CS$<>8__locals1.query) ? null : 1608.1613.1(CS$<>8__locals1.query));
		CS$<>8__locals1.items = list.Select((2228.2229 1, int 2) => new 1599.1600
		{
			1 = 1,
			2 = 1272.8(1.3),
			5 = 2 + 1
		}).Where(delegate(1599.1600 1)
		{
			2228.2229 6 = 1.1;
			return (CS$<>8__locals1.grade == null || !((CS$<>8__locals1.grade == "F") ? 6.29 : (!6.29 || 1586.13(6.28) != CS$<>8__locals1.grade))) && (CS$<>8__locals1.grade != null || CS$<>8__locals1.passes == null || 6.29 == CS$<>8__locals1.passes.Value) && (CS$<>8__locals1.mods == null || CS$<>8__locals1.mods.3(6)) && (CS$<>8__locals1.criteria == null || CS$<>8__locals1.criteria.6(1));
		}).ToList<1599.1600>();
		1589.3(CS$<>8__locals1.interaction);
		bool flag = CS$<>8__locals1.sort == "stars" || CS$<>8__locals1.sort == "pp" || (CS$<>8__locals1.criteria != null && CS$<>8__locals1.criteria.NeedsDifficulty);
		1586.1588 5 = new 1586.1588(delegate()
		{
			1591.6(CS$<>8__locals1.items, CS$<>8__locals1.sort);
			string content = 1591.7(CS$<>8__locals1.grade, CS$<>8__locals1.mods, CS$<>8__locals1.query);
			1589.Start(CS$<>8__locals1.interaction, CS$<>8__locals1.items.Count, 10, 0, delegate(1589.1590 1, 217 2)
			{
				List<1599.1600> page = CS$<>8__locals1.items.Skip(1.3).Take(1.5).ToList<1599.1600>();
				1586.1588 6 = new 1586.1588(delegate()
				{
					StringBuilder stringBuilder = new StringBuilder();
					foreach (1599.1600 8 in page)
					{
						1586.35(8.1, 8.2, null);
						2228.2229 9 = 8.1;
						string text3 = string.IsNullOrEmpty(9.8) ? 1586.5(9.7) : (1586.5(9.7) + " [" + 1586.5(9.8) + "]");
						string value = (9.4 > 0) ? string.Concat(new string[]
						{
							"[",
							text3,
							"](",
							244.3(9.4),
							")"
						}) : text3;
						stringBuilder.Append("**#").Append(8.5).Append(' ').Append(1591.5(9)).Append('\t').Append(value).Append("** [").Append((9.35 != null) ? 1586.2(9.35.Value) : "-").Append("★]");
						if (9.10 == 2147.OsuMania)
						{
							stringBuilder.Append('\t').Append(1586.Keys(9, 8.2));
						}
						stringBuilder.Append('\n');
						string value2 = ((9.32 != null) ? ("**" + 1586.2(9.32.Value) + "**") : "-") + "/" + ((9.34 != null) ? 1586.2(Math.Max(9.34.Value, 9.32.GetValueOrDefault())) : "-") + "PP";
						stringBuilder.Append(value2).Append("\t[ **").Append(9.23).Append("x**/").Append((9.24 > 0) ? (9.24.ToString() + "x") : "-").Append(" ]\t(").Append(1586.1(9.27)).Append("%)\t<t:").Append(1586.7(9.1)).Append(":R>\n");
					}
					byte[] array = 1586.47();
					217 10 = new 217();
					10["color"] = 2067276;
					10["author"] = 1586.Author(CS$<>8__locals1.mode);
					10["title"] = "List of recent scores:";
					10["description"] = ((stringBuilder.Length > 0) ? stringBuilder.ToString() : "No recent scores found");
					string text4 = "footer";
					217 11 = new 217();
					11["text"] = "Page " + 1.Page.ToString() + "/" + 1.LastPage.ToString();
					10[text4] = 11;
					217 12 = 10;
					if (array != null)
					{
						217 13 = 12;
						string text5 = "thumbnail";
						217 14 = new 217();
						14["url"] = "attachment://avatar.jpg";
						13[text5] = 14;
					}
					217 15 = new 217();
					15["content"] = (content ?? string.Empty);
					15["embeds"] = new 109(12);
					15["components"] = 1589.Buttons(1);
					217 16 = 15;
					1589.Edit(1, 2, 16, (array != null) ? "avatar.jpg" : null, array);
				});
				foreach (1599.1600 7 in page)
				{
					1586.34(7.1, 7.2, null, 6);
				}
				1586.46(6, CS$<>8__locals1.mode);
				6.Start(8000);
			}, null, true);
		});
		foreach (1599.1600 3 in CS$<>8__locals1.items)
		{
			if (flag)
			{
				1586.34(3.1, 3.2, null, 5);
			}
			if (CS$<>8__locals1.sort == "ranked_date")
			{
				1586.49(3.1.4, 5);
			}
		}
		5.Start((flag || CS$<>8__locals1.sort == "ranked_date") ? 20000 : 0);
	}

	// Token: 0x06004680 RID: 18048 RVA: 0x001BB450 File Offset: 0x001B9650
	private static string 5(2228.2229 1)
	{
		string text = 1586.18(1);
		string text2 = 1586.12(1.29 ? 1.28 : "F");
		if (!1.29 && 1.10 != 2147.CatchTheBeat)
		{
			text2 = text2 + "@" + ((1.25 > 0) ? (100 * 1.TotalHits / 1.25) : 100).ToString() + "%";
		}
		if (!(text == "NM"))
		{
			return text2 + " +" + text;
		}
		return text2;
	}

	// Token: 0x06004681 RID: 18049 RVA: 0x001BB4E4 File Offset: 0x001B96E4
	private static void 6(List<1599.1600> 1, string 2)
	{
		if (4 == null || 4 == "date")
		{
			return;
		}
		Func<1599.1600, double> key2;
		if (4 != null)
		{
			switch (4.Length)
			{
			case 2:
				if (4 == "pp")
				{
					key2 = ((1599.1600 1) => 1.1.32.GetValueOrDefault());
					goto IL_2F4;
				}
				break;
			case 3:
			{
				char c = 4[0];
				if (c != 'a')
				{
					if (c != 'b')
					{
						if (c == 'l')
						{
							if (4 == "len")
							{
								key2 = ((1599.1600 1) => 1586.28(1.1));
								goto IL_2F4;
							}
						}
					}
					else if (4 == "bpm")
					{
						key2 = ((1599.1600 1) => 1586.27(1.1));
						goto IL_2F4;
					}
				}
				else if (4 == "acc")
				{
					key2 = ((1599.1600 1) => 1.1.27);
					goto IL_2F4;
				}
				break;
			}
			case 5:
			{
				char c = 4[1];
				if (c != 'c')
				{
					if (c != 'o')
					{
						if (c == 't')
						{
							if (4 == "stars")
							{
								key2 = ((1599.1600 1) => 1586.36(1.1, 1.2));
								goto IL_2F4;
							}
						}
					}
					else if (4 == "combo")
					{
						key2 = ((1599.1600 1) => (double)1.1.23);
						goto IL_2F4;
					}
				}
				else if (4 == "score")
				{
					key2 = ((1599.1600 1) => (double)1.1.26);
					goto IL_2F4;
				}
				break;
			}
			case 6:
				if (4 == "misses")
				{
					key2 = ((1599.1600 1) => (double)1.1.22);
					goto IL_2F4;
				}
				break;
			case 10:
				if (4 == "mods_count")
				{
					key2 = ((1599.1600 1) => (double)1586.19(1.1));
					goto IL_2F4;
				}
				break;
			case 11:
				if (4 == "ranked_date")
				{
					key2 = delegate(1599.1600 1)
					{
						1586.1587 4 = 1586.48(1.1.4);
						return (double)((4 != null) ? ((4.2 != null) ? new long?(4.2.GetValueOrDefault().Ticks) : null) : null).GetValueOrDefault();
					};
					goto IL_2F4;
				}
				break;
			}
		}
		key2 = ((1599.1600 1) => 0.0);
		IL_2F4:
		Func<1599.1600, double> key = key2;
		List<ValueTuple<1599.1600, int>> list = 3.Select((1599.1600 1, int 2) => new ValueTuple<1599.1600, int>(1, 2)).ToList<ValueTuple<1599.1600, int>>();
		list.Sort(delegate([TupleElementNames(new string[]
		{
			"Item",
			"Index"
		})] ValueTuple<1599.1600, int> 1, [TupleElementNames(new string[]
		{
			"Item",
			"Index"
		})] ValueTuple<1599.1600, int> 2)
		{
			int num = key(2.Item1).CompareTo(key(1.Item1));
			if (num == 0)
			{
				return 1.Item2.CompareTo(2.Item2);
			}
			return num;
		});
		3.Clear();
		3.AddRange(from 1 in list
		select 1.Item1);
	}

	// Token: 0x06004682 RID: 18050 RVA: 0x001BB85C File Offset: 0x001B9A5C
	private static string 7(string 1, 1608.1610 2, string 3)
	{
		List<string> list = new List<string>();
		if (1 != null)
		{
			list.Add("`Grade: " + ((1 == "SS") ? "X" : 1) + "`");
		}
		if (2 != null)
		{
			list.Add("`Mods: " + 2.4() + "`");
		}
		if (!string.IsNullOrWhiteSpace(3))
		{
			list.Add("`Query: " + 3 + "`");
		}
		if (list.Count <= 0)
		{
			return null;
		}
		return string.Join(" ~ ", list);
	}

	// Token: 0x0400337B RID: 13179
	[TupleElementNames(new string[]
	{
		"Value",
		"Name"
	})]
	private static readonly ValueTuple<string, string>[] 1 = new ValueTuple<string, string>[]
	{
		new ValueTuple<string, string>("acc", "Accuracy"),
		new ValueTuple<string, string>("bpm", "BPM"),
		new ValueTuple<string, string>("combo", "Combo"),
		new ValueTuple<string, string>("date", "Date"),
		new ValueTuple<string, string>("len", "Length"),
		new ValueTuple<string, string>("misses", "Misses"),
		new ValueTuple<string, string>("mods_count", "Mods count"),
		new ValueTuple<string, string>("pp", "PP"),
		new ValueTuple<string, string>("ranked_date", "Map ranked date"),
		new ValueTuple<string, string>("score", "Score"),
		new ValueTuple<string, string>("stars", "Stars")
	};
}
