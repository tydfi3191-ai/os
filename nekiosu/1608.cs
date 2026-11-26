using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;

// Token: 0x02000A0D RID: 2573
internal static class 1608
{
	// Token: 0x17000303 RID: 771
	// (get) Token: 0x0600477F RID: 18303 RVA: 0x0019F851 File Offset: 0x0019DA51
	private static int TopCount
	{
		get
		{
			return Math.Max(100, Math.Min(1000, 1304.45.6()));
		}
	}

	// Token: 0x06004780 RID: 18304 RVA: 0x001C4CF0 File Offset: 0x001C2EF0
	internal static 217 1(bool 1)
	{
		217 2 = 10 ? 1585.2("rb", "Display the user's top plays sorted by date") : 1585.2("top", "Display the user's top plays");
		109 3 = new 109
		{
			1585.4(true)
		};
		if (!10)
		{
			217 4 = 1585.3(3, "sort", "Choose how the scores should be ordered");
			4["choices"] = new 109(1608.3.Select(delegate([TupleElementNames(new string[]
			{
				"Value",
				"Name"
			})] ValueTuple<string, string> 1)
			{
				217 11 = new 217();
				11["name"] = 1.Item2;
				11["value"] = 1.Item1;
				return 11;
			}));
			3.Add(4);
		}
		3.Add(1585.3(3, "mods", "Filter mods (`+mods` for included, `+mods!` for exact, `-mods!` for excluded)"));
		3.Add(1585.3(3, "index", "Choose a specific score index or `random`"));
		3.Add(1585.3(5, "reverse", "Reverse the resulting score list"));
		3.Add(1585.3(3, "query", "Specify a search query containing artist, difficulty, AR, BPM, ..."));
		3.Add(1585.5());
		3.Add(1585.3(5, "perfect_combo", "Filter out all scores that don't have a perfect combo"));
		217 5 = 1585.3(3, "size", 10 ? "Condense top plays" : "Size of the embed");
		217 6 = 5;
		string text = "choices";
		object[] array = new object[3];
		int num = 0;
		217 7 = new 217();
		7["name"] = "Condensed";
		7["value"] = "condensed";
		array[num] = 7;
		int num2 = 1;
		217 8 = new 217();
		8["name"] = "Detailed";
		8["value"] = "detailed";
		array[num2] = 8;
		int num3 = 2;
		217 9 = new 217();
		9["name"] = "Single";
		9["value"] = "single";
		array[num3] = 9;
		6[text] = new 109(array);
		3.Add(5);
		2["options"] = 3;
		return 2;
	}

	// Token: 0x06004781 RID: 18305 RVA: 0x001C4EDC File Offset: 0x001C30DC
	internal static void 2(217 1, bool 2)
	{
		1608.<>c__DisplayClass7_0 CS$<>8__locals1 = new 1608.<>c__DisplayClass7_0();
		CS$<>8__locals1.interaction = 1;
		Dictionary<string, 226> dictionary = 1585.Options(CS$<>8__locals1.interaction);
		1608.<>c__DisplayClass7_0 CS$<>8__locals2 = CS$<>8__locals1;
		1608.1609 3 = new 1608.1609();
		3.1 = 1585.Mode(dictionary);
		3.2 = (2 ? "date" : (1585.Text(dictionary, "sort") ?? "pp"));
		string text = 1585.Text(dictionary, "index");
		3.4 = ((text != null) ? text.Trim() : null);
		3.5 = 1585.6(dictionary, "reverse").GetValueOrDefault();
		string text2 = 1585.Text(dictionary, "grade");
		3.7 = ((text2 != null) ? text2.ToUpperInvariant() : null);
		3.8 = 1585.6(dictionary, "perfect_combo");
		3.9 = (1585.Text(dictionary, "size") ?? "condensed");
		CS$<>8__locals2.args = 3;
		string text3 = 1585.Text(dictionary, "mods");
		if (text3 != null)
		{
			CS$<>8__locals1.args.3 = 1608.1610.1(text3);
			if (CS$<>8__locals1.args.3 == null)
			{
				1586.58(CS$<>8__locals1.interaction, "Failed to parse mods.\nIf you want included mods, specify it e.g. as `+hrdt`.\nIf you want exact mods, specify it e.g. as `+hdhr!`.\nAnd if you want to exclude mods, specify it e.g. as `-hdnf!`.");
				return;
			}
		}
		string value = 1585.Text(dictionary, "query");
		if (!string.IsNullOrWhiteSpace(value))
		{
			CS$<>8__locals1.args.6 = 1608.1613.1(value);
		}
		CS$<>8__locals1.items = 1608.3(1608.TopCount, CS$<>8__locals1.args.1);
		CS$<>8__locals1.args.10 = 1608.TopCount;
		1589.3(CS$<>8__locals1.interaction);
		bool flag = CS$<>8__locals1.args.2 == "stars" || CS$<>8__locals1.args.8 != null || (CS$<>8__locals1.args.6 != null && CS$<>8__locals1.args.6.NeedsDifficulty);
		bool flag2 = CS$<>8__locals1.args.2 == "ranked_date" || (CS$<>8__locals1.args.6 != null && !CS$<>8__locals1.args.6.14.IsEmpty);
		1586.1588 4 = new 1586.1588(delegate()
		{
			1608.Show(CS$<>8__locals1.interaction, CS$<>8__locals1.args, CS$<>8__locals1.items);
		});
		foreach (1599.1600 5 in CS$<>8__locals1.items)
		{
			if (flag)
			{
				1586.34(5.1, 5.2, 5.3, 4);
			}
			if (flag2)
			{
				1586.49(5.1.4, 4);
			}
		}
		4.Start((flag || flag2) ? 20000 : 0);
	}

	// Token: 0x06004782 RID: 18306 RVA: 0x001C518C File Offset: 0x001C338C
	internal static List<1599.1600> 3(int 1, 2147 2)
	{
		2210.2216 3 = 2210.4(2);
		List<2210.2214> list = (from 1 in ((3 != null) ? 3.9 : null) ?? new List<2210.2214>()
		where !1.7 && 1.1 != null
		select 1).Take(8).ToList<2210.2214>();
		List<1599.1600> list2 = new List<1599.1600>();
		for (int i = 0; i < list.Count; i++)
		{
			2210.2214 4 = list[i];
			1262 5 = 4.3 ?? 1272.8(4.2);
			2228.2229 6 = 2228.2(4.1, 5);
			6.32 = new double?(4.4);
			6.29 = true;
			if (6.4 <= 0)
			{
				6.4 = 4.9;
			}
			if (5 == null)
			{
				6.7 = (4.8 ?? 4.2);
			}
			List<1599.1600> list3 = list2;
			1599.1600 7 = new 1599.1600();
			7.1 = 6;
			7.2 = 5;
			7.3 = 4.1;
			7.5 = i + 1;
			7.4 = ((1599.1600 1) => "Personal Best #" + 1.5.ToString());
			list3.Add(7);
		}
		return list2;
	}

	// Token: 0x06004783 RID: 18307 RVA: 0x001C52D4 File Offset: 0x001C34D4
	private static void Show(217 1, 1608.1609 2, List<1599.1600> 3)
	{
		foreach (1599.1600 4 in 3)
		{
			1586.35(4.1, 4.2, 4.3);
		}
		int count = 3.Count;
		List<1599.1600> items = (from 1 in 3
		where 1608.4(1, 7)
		select 1).ToList<1599.1600>();
		1608.5(items, 7.2);
		if (7.5)
		{
			items.Reverse();
		}
		string profileName = 1586.ProfileName;
		int? 5 = null;
		if (7.4 == "random" || 7.4 == "?")
		{
			5 = ((items.Count > 0) ? new int?(new Random().Next(1, items.Count + 1)) : null);
		}
		else if (!string.IsNullOrEmpty(7.4))
		{
			int num;
			if (!int.TryParse(7.4, NumberStyles.None, CultureInfo.InvariantCulture, out num))
			{
				1584.12(6, 1586.57("Failed to parse index. Must be an integer between 1 and " + 7.10.ToString() + " or `random` / `?`."));
				return;
			}
			if (num > items.Count)
			{
				1584.12(6, 1586.57(string.Concat(new string[]
				{
					"`",
					profileName,
					"` only has ",
					items.Count.ToString(),
					" top scores",
					(count > items.Count) ? " with the specified properties" : string.Empty
				})));
				return;
			}
			5 = new int?(num);
		}
		int? num2 = (5 != null) ? new int?(Math.Max(0, 5.Value - 1)) : ((items.Count == 1) ? new int?(0) : null);
		string content = 1608.6(profileName, 7, items.Count, 5);
		if ((num2 != null || 7.9 == "single") && items.Count > 0)
		{
			1599.8(6, items, num2.GetValueOrDefault(), content, (num2 != null) ? num2.Value : -1, true);
			return;
		}
		bool condensed = 7.9 != "detailed";
		1589.Start(6, items.Count, condensed ? 10 : 5, 0, delegate(1589.1590 1, 217 2)
		{
			List<1599.1600> page = items.Skip(1.3).Take(1.5).ToList<1599.1600>();
			1586.1588 8 = new 1586.1588(delegate()
			{
				foreach (1599.1600 10 in page)
				{
					1586.35(10.1, 10.2, 10.3);
				}
				byte[] array = 1586.47();
				217 11 = new 217();
				11["color"] = 2067276;
				11["author"] = 1586.Author(7.1);
				11["description"] = (condensed ? 1608.Condensed(page, 7.2) : 1608.Detailed(page, 7.2));
				217 12 = 11;
				string text = "footer";
				217 13 = new 217();
				13["text"] = string.Concat(new string[]
				{
					"Page ",
					1.Page.ToString(),
					"/",
					1.LastPage.ToString(),
					" • Mode: ",
					1586.41(7.1)
				});
				12[text] = 13;
				217 14 = 11;
				if (array != null)
				{
					217 15 = 14;
					string text2 = "thumbnail";
					217 16 = new 217();
					16["url"] = "attachment://avatar.jpg";
					15[text2] = 16;
				}
				217 17 = new 217();
				17["content"] = (content ?? string.Empty);
				17["embeds"] = new 109(14);
				17["components"] = 1589.Buttons(1);
				217 18 = 17;
				1589.Edit(1, 2, 18, (array != null) ? "avatar.jpg" : null, array);
			});
			foreach (1599.1600 9 in page)
			{
				1586.34(9.1, 9.2, 9.3, 8);
				if (7.2 == "ranked_date")
				{
					1586.49(9.1.4, 8);
				}
			}
			1586.46(8, 7.1);
			8.Start(8000);
		}, null, true);
	}

	// Token: 0x06004784 RID: 18308 RVA: 0x001C55EC File Offset: 0x001C37EC
	private static bool 4(1599.1600 1, 1608.1609 2)
	{
		2228.2229 3 = 1.1;
		return (2.7 == null || !(1586.13(3.28) != 2.7)) && (2.3 == null || 2.3.3(3)) && (2.6 == null || 2.6.6(1)) && (2.8 == null || 2.8.Value == (3.24 > 0 && 3.23 == 3.24));
	}

	// Token: 0x06004785 RID: 18309 RVA: 0x001C568C File Offset: 0x001C388C
	private static void 5(List<1599.1600> 1, string 2)
	{
		Comparison<1599.1600> comparison2;
		if (4 != null)
		{
			switch (4.Length)
			{
			case 2:
			{
				char c = 4[0];
				if (c <= 'c')
				{
					if (c != 'a')
					{
						if (c == 'c')
						{
							if (4 == "cs")
							{
								comparison2 = 1608.<Sort>g__descending|11_0((1599.1600 1) => 1586.23(1.1, 1928.CircleSize));
								goto IL_480;
							}
						}
					}
					else if (4 == "ar")
					{
						comparison2 = 1608.<Sort>g__descending|11_0((1599.1600 1) => 1586.23(1.1, 1928.ApproachRate));
						goto IL_480;
					}
				}
				else if (c != 'h')
				{
					if (c == 'o')
					{
						if (4 == "od")
						{
							comparison2 = 1608.<Sort>g__descending|11_0((1599.1600 1) => 1586.23(1.1, 1928.OverallDifficulty));
							goto IL_480;
						}
					}
				}
				else if (4 == "hp")
				{
					comparison2 = 1608.<Sort>g__descending|11_0((1599.1600 1) => 1586.23(1.1, 1928.DrainRate));
					goto IL_480;
				}
				break;
			}
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
								comparison2 = 1608.<Sort>g__descending|11_0((1599.1600 1) => 1586.28(1.1));
								goto IL_480;
							}
						}
					}
					else if (4 == "bpm")
					{
						comparison2 = 1608.<Sort>g__descending|11_0((1599.1600 1) => 1586.27(1.1));
						goto IL_480;
					}
				}
				else if (4 == "acc")
				{
					comparison2 = 1608.<Sort>g__descending|11_0((1599.1600 1) => 1.1.27);
					goto IL_480;
				}
				break;
			}
			case 4:
			{
				char c = 4[0];
				if (c != 'd')
				{
					if (c == 'm')
					{
						if (4 == "miss")
						{
							comparison2 = delegate(1599.1600 1, 1599.1600 2)
							{
								int num = 2.1.22.CompareTo(1.1.22);
								if (num != 0)
								{
									return num;
								}
								double value = (double)1.1.22 / (double)Math.Max(1, 1.1.TotalHits);
								int num2 = ((double)2.1.22 / (double)Math.Max(1, 2.1.TotalHits)).CompareTo(value);
								if (num2 == 0)
								{
									return 2.1.TotalHits.CompareTo(1.1.TotalHits);
								}
								return num2;
							};
							goto IL_480;
						}
					}
				}
				else if (4 == "date")
				{
					comparison2 = 1608.<Sort>g__descending|11_0((1599.1600 1) => (double)1.1.1.Ticks);
					goto IL_480;
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
								comparison2 = 1608.<Sort>g__descending|11_0((1599.1600 1) => 1586.36(1.1, 1.2));
								goto IL_480;
							}
						}
					}
					else if (4 == "combo")
					{
						comparison2 = 1608.<Sort>g__descending|11_0((1599.1600 1) => (double)1.1.23);
						goto IL_480;
					}
				}
				else if (4 == "score")
				{
					comparison2 = 1608.<Sort>g__descending|11_0((1599.1600 1) => (double)1.1.26);
					goto IL_480;
				}
				break;
			}
			case 10:
				if (4 == "mods_count")
				{
					comparison2 = 1608.<Sort>g__descending|11_0((1599.1600 1) => (double)1586.19(1.1));
					goto IL_480;
				}
				break;
			case 11:
				if (4 == "ranked_date")
				{
					comparison2 = 1608.<Sort>g__descending|11_0(delegate(1599.1600 1)
					{
						1586.1587 5 = 1586.48(1.1.4);
						return (double)((5 != null) ? ((5.2 != null) ? new long?(5.2.GetValueOrDefault().Ticks) : null) : null).GetValueOrDefault();
					});
					goto IL_480;
				}
				break;
			}
		}
		comparison2 = 1608.<Sort>g__descending|11_0((1599.1600 1) => 1.1.32.GetValueOrDefault());
		IL_480:
		Comparison<1599.1600> comparison = comparison2;
		List<ValueTuple<1599.1600, int>> list = 3.Select((1599.1600 1, int 2) => new ValueTuple<1599.1600, int>(1, 2)).ToList<ValueTuple<1599.1600, int>>();
		list.Sort(delegate([TupleElementNames(new string[]
		{
			"item",
			"i"
		})] ValueTuple<1599.1600, int> 1, [TupleElementNames(new string[]
		{
			"item",
			"i"
		})] ValueTuple<1599.1600, int> 2)
		{
			int num = comparison(1.Item1, 2.Item1);
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

	// Token: 0x06004786 RID: 18310 RVA: 0x001C5B90 File Offset: 0x001C3D90
	private static string 6(string 1, 1608.1609 2, int 3, int? 4)
	{
		bool flag = 2.7 != null || 2.3 != null || 2.8 != null || 2.6 != null;
		string text = 1.EndsWith("s", StringComparison.Ordinal) ? string.Empty : "s";
		if (flag)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("`Order: ").Append(1608.7(2.2));
			stringBuilder.Append(2.5 ? " (reverse)`" : "`");
			if (2.7 != null)
			{
				stringBuilder.Append(" • `Grade: ").Append((2.7 == "SS") ? "X" : 2.7).Append('`');
			}
			if (2.3 != null)
			{
				stringBuilder.Append(" • `Mods: ").Append(2.3.4()).Append('`');
			}
			if (2.8 != null)
			{
				stringBuilder.Append(" • `Perfect combo: ").Append(2.8.Value ? "true" : "false").Append('`');
			}
			1608.1613 5 = 2.6;
			if (5 != null)
			{
				5.Display(stringBuilder);
			}
			stringBuilder.Append("\nFound ").Append(3).Append(" matching top score").Append((3 == 1) ? string.Empty : "s").Append(':');
			return stringBuilder.ToString();
		}
		string text2 = 2.5 ? "reversed " : string.Empty;
		string text3 = string.Concat(new string[]
		{
			"`",
			1,
			"`'",
			text,
			" top",
			2.10.ToString()
		});
		string text4 = (4 != null && 4.Value % 10 == 1 && 4.Value != 11) ? "st" : ((4 != null && 4.Value % 10 == 2 && 4.Value != 12) ? "nd" : ((4 != null && 4.Value % 10 == 3 && 4.Value != 13) ? "rd" : "th"));
		string a = 2.2;
		if (!(a == "date"))
		{
			if (!(a == "pp"))
			{
				return string.Concat(new string[]
				{
					text3,
					" sorted by ",
					text2,
					1608.8(2.2),
					":"
				});
			}
			if (!2.5)
			{
				return null;
			}
			return text3 + " sorted by reversed pp:";
		}
		else
		{
			if (2.5 && 4 != null && 4.Value <= 1)
			{
				return "Oldest score in " + text3 + ":";
			}
			if (2.5 && 4 != null)
			{
				return string.Concat(new string[]
				{
					4.Value.ToString(),
					text4,
					" oldest score in ",
					text3,
					":"
				});
			}
			if (2.5)
			{
				return "Oldest scores in " + text3 + ":";
			}
			if (4 != null && 4.Value <= 1)
			{
				return "Most recent score in " + text3 + ":";
			}
			if (4 != null)
			{
				return string.Concat(new string[]
				{
					4.Value.ToString(),
					text4,
					" most recent score in ",
					text3,
					":"
				});
			}
			return "Most recent scores in " + text3 + ":";
		}
	}

	// Token: 0x06004787 RID: 18311 RVA: 0x001C5F68 File Offset: 0x001C4168
	private static string 7(string 1)
	{
		if (1 != null)
		{
			switch (1.Length)
			{
			case 2:
			{
				char c = 1[0];
				if (c <= 'c')
				{
					if (c != 'a')
					{
						if (c == 'c')
						{
							if (1 == "cs")
							{
								return "CS";
							}
						}
					}
					else if (1 == "ar")
					{
						return "AR";
					}
				}
				else if (c != 'h')
				{
					if (c == 'o')
					{
						if (1 == "od")
						{
							return "OD";
						}
					}
				}
				else if (1 == "hp")
				{
					return "HP";
				}
				break;
			}
			case 3:
			{
				char c = 1[0];
				if (c != 'a')
				{
					if (c != 'b')
					{
						if (c == 'l')
						{
							if (1 == "len")
							{
								return "Length";
							}
						}
					}
					else if (1 == "bpm")
					{
						return "BPM";
					}
				}
				else if (1 == "acc")
				{
					return "Accuracy";
				}
				break;
			}
			case 4:
			{
				char c = 1[0];
				if (c != 'd')
				{
					if (c == 'm')
					{
						if (1 == "miss")
						{
							return "Miss count";
						}
					}
				}
				else if (1 == "date")
				{
					return "Date";
				}
				break;
			}
			case 5:
			{
				char c = 1[1];
				if (c != 'c')
				{
					if (c != 'o')
					{
						if (c == 't')
						{
							if (1 == "stars")
							{
								return "Stars";
							}
						}
					}
					else if (1 == "combo")
					{
						return "Combo";
					}
				}
				else if (1 == "score")
				{
					return "Score";
				}
				break;
			}
			case 10:
				if (1 == "mods_count")
				{
					return "Amount of mods";
				}
				break;
			case 11:
				if (1 == "ranked_date")
				{
					return "Ranked date";
				}
				break;
			}
		}
		return "Pp";
	}

	// Token: 0x06004788 RID: 18312 RVA: 0x001C61E0 File Offset: 0x001C43E0
	private static string 8(string 1)
	{
		if (1 != null)
		{
			switch (1.Length)
			{
			case 2:
			{
				char c = 1[0];
				if (c <= 'c')
				{
					if (c != 'a')
					{
						if (c == 'c')
						{
							if (1 == "cs")
							{
								return "CS";
							}
						}
					}
					else if (1 == "ar")
					{
						return "AR";
					}
				}
				else if (c != 'h')
				{
					if (c == 'o')
					{
						if (1 == "od")
						{
							return "OD";
						}
					}
				}
				else if (1 == "hp")
				{
					return "HP";
				}
				break;
			}
			case 3:
			{
				char c = 1[0];
				if (c != 'a')
				{
					if (c != 'b')
					{
						if (c == 'l')
						{
							if (1 == "len")
							{
								return "length";
							}
						}
					}
					else if (1 == "bpm")
					{
						return "BPM";
					}
				}
				else if (1 == "acc")
				{
					return "accuracy";
				}
				break;
			}
			case 4:
				if (1 == "miss")
				{
					return "miss count";
				}
				break;
			case 5:
			{
				char c = 1[1];
				if (c != 'c')
				{
					if (c != 'o')
					{
						if (c == 't')
						{
							if (1 == "stars")
							{
								return "stars";
							}
						}
					}
					else if (1 == "combo")
					{
						return "combo";
					}
				}
				else if (1 == "score")
				{
					return "score";
				}
				break;
			}
			case 10:
				if (1 == "mods_count")
				{
					return "amount of mods";
				}
				break;
			case 11:
				if (1 == "ranked_date")
				{
					return "ranked date";
				}
				break;
			}
		}
		return "pp";
	}

	// Token: 0x06004789 RID: 18313 RVA: 0x001C6418 File Offset: 0x001C4618
	private static string 9(2228.2229 1, string 2)
	{
		if (1.4 <= 0)
		{
			return 2;
		}
		return string.Concat(new string[]
		{
			"[",
			2,
			"](",
			244.3(1.4),
			")"
		});
	}

	// Token: 0x0600478A RID: 18314 RVA: 0x001C6468 File Offset: 0x001C4668
	private static string Accuracy(2228.2229 1, string 2)
	{
		if (!(2 == "acc"))
		{
			return 1586.1(1.27);
		}
		return Math.Round(1.27, 5).ToString("0.#####", CultureInfo.InvariantCulture);
	}

	// Token: 0x0600478B RID: 18315 RVA: 0x001C64AC File Offset: 0x001C46AC
	private static string Stars(1599.1600 1)
	{
		double num = 1586.36(1.1, 1.2);
		if (num <= 0.0)
		{
			return "-";
		}
		return 1586.1(num);
	}

	// Token: 0x0600478C RID: 18316 RVA: 0x001C64E3 File Offset: 0x001C46E3
	private static string 10(2228.2229 1)
	{
		if (1.24 <= 0)
		{
			return "-";
		}
		return 1.24.ToString(CultureInfo.InvariantCulture) + "x";
	}

	// Token: 0x0600478D RID: 18317 RVA: 0x001C6510 File Offset: 0x001C4710
	private static string Condensed(List<1599.1600> 1, string 2)
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (1599.1600 3 in 1)
		{
			2228.2229 4 = 3.1;
			stringBuilder.Append("**#").Append(3.5).Append(' ').Append(1608.9(4, 1586.39(4))).Append("** [").Append(1608.Stars(3)).Append("★]\n");
			if (4.10 == 2147.OsuMania)
			{
				string value = (4.26 < 10000L) ? 4.26.ToString(CultureInfo.InvariantCulture) : ((4.26 / 1000L).ToString(CultureInfo.InvariantCulture) + "K");
				stringBuilder.Append(1586.12(4.28)).Append(" **").Append(1586.1(4.32.GetValueOrDefault())).Append("pp** ").Append(1608.Accuracy(4, 2)).Append("% `").Append(value).Append("` {").Append(4.20).Append('/').Append(4.17).Append("/../").Append(4.22).Append("} **+").Append(1586.18(4)).Append("** ").Append(1608.11(3, 2, true)).Append('\n');
			}
			else
			{
				stringBuilder.Append(1586.12(4.28)).Append(" **").Append(1586.1(4.32.GetValueOrDefault())).Append("pp** (").Append(1608.Accuracy(4, 2)).Append("%) [**").Append(4.23).Append("x**/").Append(1608.10(4)).Append("] ");
				if (4.22 > 0)
				{
					stringBuilder.Append(4.22).Append(1586.Emote("miss", " miss")).Append(' ');
				}
				stringBuilder.Append("**+").Append(1586.18(4)).Append("** ").Append(1608.11(3, 2, true)).Append('\n');
			}
		}
		return stringBuilder.ToString();
	}

	// Token: 0x0600478E RID: 18318 RVA: 0x001C67CC File Offset: 0x001C49CC
	private static string Detailed(List<1599.1600> 1, string 2)
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (1599.1600 3 in 1)
		{
			2228.2229 4 = 3.1;
			string text = string.IsNullOrEmpty(4.8) ? 1586.5(4.7) : (1586.5(4.7) + " [" + 1586.5(4.8) + "]");
			string value = (4.35 != null) ? 1586.2(4.35.Value) : 1608.Stars(3);
			string value2 = string.Concat(new string[]
			{
				"**",
				1586.2(4.32.GetValueOrDefault()),
				"**/",
				(4.34 != null) ? 1586.2(Math.Max(4.34.Value, 4.32.GetValueOrDefault())) : "-",
				"PP"
			});
			stringBuilder.Append("**#").Append(3.5).Append(' ').Append(1608.9(4, text)).Append(" +").Append(1586.18(4)).Append("** [").Append(value).Append("★]\n");
			stringBuilder.Append(1586.12(4.28)).Append(' ').Append(value2).Append(" • ").Append(1608.Accuracy(4, 2)).Append("% • ").Append(1586.4(4.26)).Append('\n');
			stringBuilder.Append("[ **").Append(4.23).Append("x**/").Append(1608.10(4)).Append(" ] • ").Append(1586.44(4)).Append(" • ").Append(1608.11(3, 2, false)).Append('\n');
		}
		return stringBuilder.ToString().TrimEnd(new char[]
		{
			'\n'
		});
	}

	// Token: 0x0600478F RID: 18319 RVA: 0x001C6A30 File Offset: 0x001C4C30
	private static string 11(1599.1600 1, string 2, bool 3)
	{
		2228.2229 4 = 1.1;
		if (2 != null)
		{
			int length = 2.Length;
			switch (length)
			{
			case 2:
			{
				char c = 2[0];
				if (c <= 'c')
				{
					if (c != 'a')
					{
						if (c == 'c')
						{
							if (2 == "cs")
							{
								return "`CS " + 1586.1(1586.23(4, 1928.CircleSize)) + "`";
							}
						}
					}
					else if (2 == "ar")
					{
						return "`AR " + 1586.1(1586.23(4, 1928.ApproachRate)) + "`";
					}
				}
				else if (c != 'h')
				{
					if (c == 'o')
					{
						if (2 == "od")
						{
							return "`OD " + 1586.1(1586.23(4, 1928.OverallDifficulty)) + "`";
						}
					}
				}
				else if (2 == "hp")
				{
					return "`HP " + 1586.1(1586.23(4, 1928.DrainRate)) + "`";
				}
				break;
			}
			case 3:
			{
				char c = 2[0];
				if (c != 'b')
				{
					if (c == 'l')
					{
						if (2 == "len")
						{
							return "`" + 1586.9((int)1586.28(4)) + "`";
						}
					}
				}
				else if (2 == "bpm")
				{
					return "`" + 1586.1(1586.27(4)) + "bpm`";
				}
				break;
			}
			case 4:
				break;
			case 5:
				if (2 == "score")
				{
					if (3 && 4.10 != 2147.OsuMania)
					{
						long 5 = 4.26;
						if (5 > 1000000000L)
						{
							return "`" + ((double)5 / 1000000000.0).ToString("0.00", CultureInfo.InvariantCulture) + "bn`";
						}
						if (5 <= 1000000L)
						{
							return "`" + 1586.4(5) + "`";
						}
						return "`" + ((double)5 / 1000000.0).ToString("0.00", CultureInfo.InvariantCulture) + "m`";
					}
				}
				break;
			default:
				if (length == 11)
				{
					if (2 == "ranked_date")
					{
						1586.1587 6 = 1586.48(4.4);
						DateTime? dateTime = (6 != null) ? 6.2 : null;
						if (dateTime == null)
						{
							return string.Empty;
						}
						return "<t:" + 1586.7(dateTime.Value) + ":d>";
					}
				}
				break;
			}
		}
		return "<t:" + 1586.7(4.1) + ":R>";
	}

	// Token: 0x06004791 RID: 18321 RVA: 0x001C6E81 File Offset: 0x001C5081
	[CompilerGenerated]
	internal static Comparison<1599.1600> <Sort>g__descending|11_0(Func<1599.1600, double> 1)
	{
		return (1599.1600 1, 1599.1600 2) => 3(2).CompareTo(3(1));
	}

	// Token: 0x04003482 RID: 13442
	private const int 1 = 20000;

	// Token: 0x04003483 RID: 13443
	private const string 2 = "Failed to parse mods.\nIf you want included mods, specify it e.g. as `+hrdt`.\nIf you want exact mods, specify it e.g. as `+hdhr!`.\nAnd if you want to exclude mods, specify it e.g. as `-hdnf!`.";

	// Token: 0x04003484 RID: 13444
	[TupleElementNames(new string[]
	{
		"Value",
		"Name"
	})]
	private static readonly ValueTuple<string, string>[] 3 = new ValueTuple<string, string>[]
	{
		new ValueTuple<string, string>("acc", "Accuracy"),
		new ValueTuple<string, string>("ar", "Approach Rate (AR)"),
		new ValueTuple<string, string>("bpm", "BPM"),
		new ValueTuple<string, string>("combo", "Combo"),
		new ValueTuple<string, string>("cs", "Circle Size (CS)"),
		new ValueTuple<string, string>("date", "Date"),
		new ValueTuple<string, string>("hp", "Drain Rate (HP)"),
		new ValueTuple<string, string>("len", "Length"),
		new ValueTuple<string, string>("ranked_date", "Map ranked date"),
		new ValueTuple<string, string>("miss", "Misses"),
		new ValueTuple<string, string>("mods_count", "Mods count"),
		new ValueTuple<string, string>("od", "Overall Difficulty (OD)"),
		new ValueTuple<string, string>("pp", "PP"),
		new ValueTuple<string, string>("score", "Score"),
		new ValueTuple<string, string>("stars", "Stars")
	};

	// Token: 0x02000A0E RID: 2574
	private sealed class 1609
	{
		// Token: 0x04003485 RID: 13445
		public 2147 1;

		// Token: 0x04003486 RID: 13446
		public string 2 = "pp";

		// Token: 0x04003487 RID: 13447
		public 1608.1610 3;

		// Token: 0x04003488 RID: 13448
		public string 4;

		// Token: 0x04003489 RID: 13449
		public bool 5;

		// Token: 0x0400348A RID: 13450
		public 1608.1613 6;

		// Token: 0x0400348B RID: 13451
		public string 7;

		// Token: 0x0400348C RID: 13452
		public bool? 8;

		// Token: 0x0400348D RID: 13453
		public string 9 = "condensed";

		// Token: 0x0400348E RID: 13454
		public int 10 = 200;
	}

	// Token: 0x02000A0F RID: 2575
	internal sealed class 1610
	{
		// Token: 0x06004793 RID: 18323 RVA: 0x001C6EC4 File Offset: 0x001C50C4
		internal static 1608.1610 1(string 1)
		{
			1 = 1.Trim();
			Match match = Regex.Match(1, "^\\+(\\w+)!?$");
			Match match2 = Regex.Match(1, "^-(\\w+)!$");
			if (match.Success)
			{
				bool flag;
				List<string> list = 1608.1610.2(match.Groups[1].Value, out flag);
				if (list == null)
				{
					return null;
				}
				return new 1608.1610
				{
					1 = (1.EndsWith("!", StringComparison.Ordinal) ? 1608.1610.1611.Exact : 1608.1610.1611.Include),
					2 = list
				};
			}
			else if (match2.Success)
			{
				bool flag2;
				List<string> list2 = 1608.1610.2(match2.Groups[1].Value, out flag2);
				if (list2 == null)
				{
					return null;
				}
				return new 1608.1610
				{
					1 = 1608.1610.1611.Exclude,
					2 = list2,
					3 = flag2
				};
			}
			else
			{
				bool flag;
				List<string> list3 = 1608.1610.2(1, out flag);
				if (list3 == null)
				{
					return null;
				}
				return new 1608.1610
				{
					1 = 1608.1610.1611.Exact,
					2 = list3
				};
			}
		}

		// Token: 0x06004794 RID: 18324 RVA: 0x001C6FA4 File Offset: 0x001C51A4
		private static List<string> 2(string 1, out bool 2)
		{
			2 = false;
			string text = 1.ToUpperInvariant();
			HashSet<string> hashSet = new HashSet<string>(StringComparer.Ordinal);
			int i = 0;
			while (i < text.Length)
			{
				if (text.Length - i >= 3 && text.Substring(i, 3) == "SV2")
				{
					hashSet.Add("SV2");
					i += 3;
				}
				else
				{
					if (text.Length - i < 2)
					{
						return null;
					}
					string text2 = text.Substring(i, 2);
					i += 2;
					if (text2 == "NM")
					{
						2 = true;
					}
					else
					{
						if (text2 == "V2")
						{
							text2 = "SV2";
						}
						if (!1608.1610.4.Contains(text2))
						{
							return null;
						}
						hashSet.Add(text2);
					}
				}
			}
			return 1608.1610.4.Where(new Func<string, bool>(hashSet.Contains)).ToList<string>();
		}

		// Token: 0x06004795 RID: 18325 RVA: 0x001C707C File Offset: 0x001C527C
		internal bool 3(2228.2229 1)
		{
			List<string> played = 1586.16(2);
			switch (this.1)
			{
			case 1608.1610.1611.Include:
				if (this.2.Count != 0)
				{
					return this.2.All(delegate(string 1)
					{
						if (1 == "DT")
						{
							return played.Contains("DT") || played.Contains("NC");
						}
						if (!(1 == "SD"))
						{
							return played.Contains(1);
						}
						return played.Contains("SD") || played.Contains("PF");
					});
				}
				break;
			case 1608.1610.1611.Exact:
				if (this.2.Count != 0)
				{
					goto IL_AB;
				}
				break;
			case 1608.1610.1611.Exclude:
			{
				int num = played.Count((string 1) => !this.2.Contains(1) && (!(1 == "NC") || !this.2.Contains("DT")) && (!(1 == "PF") || !this.2.Contains("SD")));
				if (!this.3)
				{
					return num == played.Count;
				}
				return num > 0;
			}
			default:
				goto IL_AB;
			}
			return played.Count == 0;
			IL_AB:
			return played.Count == this.2.Count && played.All(new Func<string, bool>(this.2.Contains));
		}

		// Token: 0x06004796 RID: 18326 RVA: 0x001C716C File Offset: 0x001C536C
		internal string 4()
		{
			string text = (this.2.Count > 0) ? string.Concat(this.2) : "NM";
			1608.1610.1611 <<EMPTY_NAME>> = this.1;
			if (<<EMPTY_NAME>> == 1608.1610.1611.Include)
			{
				return "Include " + text;
			}
			if (<<EMPTY_NAME>> != 1608.1610.1611.Exclude)
			{
				return text;
			}
			if (this.3)
			{
				return "Exclude NM (without " + text + ")";
			}
			return "Exclude " + text;
		}

		// Token: 0x0400348F RID: 13455
		private 1608.1610.1611 1;

		// Token: 0x04003490 RID: 13456
		private List<string> 2 = new List<string>();

		// Token: 0x04003491 RID: 13457
		private bool 3;

		// Token: 0x04003492 RID: 13458
		private static readonly List<string> 4 = (from 1 in 1586.5
		select 1.Value).Concat(1586.6).Distinct<string>().ToList<string>();

		// Token: 0x02000A10 RID: 2576
		private enum 1611
		{
			// Token: 0x04003494 RID: 13460
			Include,
			// Token: 0x04003495 RID: 13461
			Exact,
			// Token: 0x04003496 RID: 13462
			Exclude
		}
	}

	// Token: 0x02000A13 RID: 2579
	internal sealed class 1612
	{
		// Token: 0x17000304 RID: 772
		// (get) Token: 0x0600479F RID: 18335 RVA: 0x001C731D File Offset: 0x001C551D
		public bool IsEmpty
		{
			get
			{
				return this.1 == null && this.2 == null;
			}
		}

		// Token: 0x060047A0 RID: 18336 RVA: 0x001C733C File Offset: 0x001C553C
		public void 1(string 1, double 2, double 3)
		{
			if (1 == "=" || 1 == ":")
			{
				this.1 = new double?(2 - 3);
				this.2 = new double?(2 + 3);
				this.3 = true;
				this.4 = true;
				return;
			}
			if (1 == "<")
			{
				this.2 = new double?(2 - 3);
				return;
			}
			if (1 == "<=" || 1 == "<:")
			{
				this.2 = new double?(2 + 3);
				this.4 = true;
				return;
			}
			if (!(1 == ">"))
			{
				this.1 = new double?(2 - 3);
				this.3 = true;
				return;
			}
			this.1 = new double?(2 + 3);
		}

		// Token: 0x060047A1 RID: 18337 RVA: 0x001C7410 File Offset: 0x001C5610
		public bool 2(double 1)
		{
			return (this.1 == null || (1 >= this.1.Value && (1 != this.1.Value || this.3))) && (this.2 == null || (1 <= this.2.Value && (1 != this.2.Value || this.4)));
		}

		// Token: 0x060047A2 RID: 18338 RVA: 0x001C7484 File Offset: 0x001C5684
		public string 3()
		{
			if ((this.5 || this.6) && this.1 != null && this.2 != null && this.1.Value == this.2.Value)
			{
				return this.<Describe>g__Show|10_0(this.1.Value);
			}
			return string.Concat(new string[]
			{
				this.3 ? "[" : "(",
				(this.1 != null) ? this.<Describe>g__Show|10_0(this.1.Value) : string.Empty,
				(this.1 != null && this.2 != null) ? "," : "..",
				(this.2 != null) ? this.<Describe>g__Show|10_0(this.2.Value) : string.Empty,
				this.4 ? "]" : ")"
			});
		}

		// Token: 0x060047A4 RID: 18340 RVA: 0x001C7598 File Offset: 0x001C5798
		[CompilerGenerated]
		private string <Describe>g__Show|10_0(double 1)
		{
			if (this.5)
			{
				return new DateTime((long)1, DateTimeKind.Utc).ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
			}
			if (!this.6)
			{
				return 1.ToString("0.####", CultureInfo.InvariantCulture);
			}
			return ((long)1).ToString(CultureInfo.InvariantCulture);
		}

		// Token: 0x0400349A RID: 13466
		public double? 1;

		// Token: 0x0400349B RID: 13467
		public double? 2;

		// Token: 0x0400349C RID: 13468
		public bool 3;

		// Token: 0x0400349D RID: 13469
		public bool 4;

		// Token: 0x0400349E RID: 13470
		public bool 5;

		// Token: 0x0400349F RID: 13471
		public bool 6;
	}

	// Token: 0x02000A14 RID: 2580
	internal sealed class 1613
	{
		// Token: 0x17000305 RID: 773
		// (get) Token: 0x060047A5 RID: 18341 RVA: 0x001C75F1 File Offset: 0x001C57F1
		public bool NeedsDifficulty
		{
			get
			{
				return !this.2.IsEmpty;
			}
		}

		// Token: 0x060047A6 RID: 18342 RVA: 0x001C7604 File Offset: 0x001C5804
		internal static 1608.1613 1(string 1)
		{
			1608.1613 2 = new 1608.1613();
			StringBuilder stringBuilder = new StringBuilder(1);
			int num = 0;
			foreach (object obj in 1608.1613.21.Matches(1))
			{
				Match match = (Match)obj;
				string text = match.Groups["key"].Value.ToLowerInvariant();
				string text2 = match.Groups["value"].Value.ToLowerInvariant();
				string value = match.Groups["op"].Value;
				if (2.2(text, value, text2))
				{
					int startIndex = match.Groups["key"].Index - num;
					int num2 = match.Groups["value"].Index + match.Groups["value"].Length - match.Groups["key"].Index;
					stringBuilder.Remove(startIndex, num2);
					num += num2;
				}
			}
			2.20 = stringBuilder.ToString().Trim().ToLowerInvariant();
			2.19 = 2.20.Split(new char[]
			{
				' ',
				'\t'
			}, StringSplitOptions.RemoveEmptyEntries);
			return 2;
		}

		// Token: 0x060047A7 RID: 18343 RVA: 0x001C7780 File Offset: 0x001C5980
		private bool 2(string 1, string 2, string 3)
		{
			if (1 != null)
			{
				switch (1.Length)
				{
				case 2:
				{
					char c = 1[0];
					if (c <= 'h')
					{
						switch (c)
						{
						case 'a':
							if (!(1 == "ar"))
							{
								return false;
							}
							return 1608.1613.3(this.3, 2, 3, 0.005);
						case 'b':
							return false;
						case 'c':
							if (!(1 == "cs"))
							{
								return false;
							}
							return 1608.1613.3(this.4, 2, 3, 0.005);
						case 'd':
							if (!(1 == "dr"))
							{
								return false;
							}
							break;
						default:
							if (c != 'h')
							{
								return false;
							}
							if (!(1 == "hp"))
							{
								return false;
							}
							break;
						}
						return 1608.1613.3(this.5, 2, 3, 0.005);
					}
					if (c != 'o')
					{
						if (c != 'p')
						{
							return false;
						}
						if (!(1 == "pp"))
						{
							return false;
						}
						return 1608.1613.3(this.1, 2, 3, 0.005);
					}
					else
					{
						if (!(1 == "od"))
						{
							return false;
						}
						return 1608.1613.3(this.6, 2, 3, 0.005);
					}
					break;
				}
				case 3:
				{
					char c = 1[0];
					if (c != 'a')
					{
						if (c != 'b')
						{
							if (c != 'l')
							{
								return false;
							}
							if (!(1 == "len"))
							{
								return false;
							}
							goto IL_537;
						}
						else
						{
							if (!(1 == "bpm"))
							{
								return false;
							}
							return 1608.1613.3(this.8, 2, 3, 0.05);
						}
					}
					else
					{
						if (!(1 == "acc"))
						{
							return false;
						}
						goto IL_557;
					}
					break;
				}
				case 4:
				{
					char c = 1[2];
					if (c <= 'f')
					{
						if (c != 'a')
						{
							if (c != 'f')
							{
								return false;
							}
							if (!(1 == "diff"))
							{
								return false;
							}
							goto IL_5EB;
						}
						else if (!(1 == "star"))
						{
							return false;
						}
					}
					else if (c != 's')
					{
						if (c != 't')
						{
							return false;
						}
						if (!(1 == "date"))
						{
							return false;
						}
						goto IL_5B3;
					}
					else
					{
						if (!(1 == "miss"))
						{
							return false;
						}
						goto IL_59C;
					}
					break;
				}
				case 5:
				{
					char c = 1[1];
					if (c <= 'i')
					{
						if (c != 'c')
						{
							if (c != 'i')
							{
								return false;
							}
							if (!(1 == "title"))
							{
								return false;
							}
							return 1608.1613.Text(ref this.17, 2, 3);
						}
						else
						{
							if (!(1 == "score"))
							{
								return false;
							}
							return 1608.1613.3(this.10, 2, 3, 0.0);
						}
					}
					else if (c != 'm')
					{
						if (c != 'o')
						{
							if (c != 't')
							{
								return false;
							}
							if (!(1 == "stars"))
							{
								return false;
							}
						}
						else
						{
							if (!(1 == "combo"))
							{
								return false;
							}
							goto IL_585;
						}
					}
					else
					{
						if (!(1 == "nmiss"))
						{
							return false;
						}
						goto IL_59C;
					}
					break;
				}
				case 6:
				{
					char c = 1[3];
					switch (c)
					{
					case 'g':
						if (!(1 == "length"))
						{
							return false;
						}
						goto IL_537;
					case 'h':
					case 'j':
						return false;
					case 'i':
						if (!(1 == "artist"))
						{
							return false;
						}
						return 1608.1613.Text(ref this.15, 2, 3);
					case 'k':
						if (!(1 == "ranked"))
						{
							return false;
						}
						goto IL_5C1;
					default:
						if (c != 'p')
						{
							if (c != 's')
							{
								return false;
							}
							if (!(1 == "misses"))
							{
								return false;
							}
							goto IL_59C;
						}
						else
						{
							if (!(1 == "mapper"))
							{
								return false;
							}
							goto IL_5DD;
						}
						break;
					}
					break;
				}
				case 7:
				{
					char c = 1[0];
					if (c != 'c')
					{
						if (c != 'n')
						{
							if (c != 'v')
							{
								return false;
							}
							if (!(1 == "version"))
							{
								return false;
							}
							goto IL_5EB;
						}
						else
						{
							if (!(1 == "nmisses"))
							{
								return false;
							}
							goto IL_59C;
						}
					}
					else
					{
						if (!(1 == "creator"))
						{
							return false;
						}
						goto IL_5DD;
					}
					break;
				}
				case 8:
				{
					char c = 1[0];
					if (c != 'a')
					{
						if (c != 'e')
						{
							if (c != 'm')
							{
								return false;
							}
							if (!(1 == "maxcombo"))
							{
								return false;
							}
							goto IL_585;
						}
						else
						{
							if (!(1 == "ended_at"))
							{
								return false;
							}
							goto IL_5B3;
						}
					}
					else
					{
						if (!(1 == "accuracy"))
						{
							return false;
						}
						goto IL_557;
					}
					break;
				}
				case 9:
				{
					char c = 1[0];
					if (c != 'c')
					{
						if (c != 's')
						{
							return false;
						}
						if (!(1 == "scoredate"))
						{
							return false;
						}
						goto IL_5B3;
					}
					else
					{
						if (!(1 == "countmiss"))
						{
							return false;
						}
						goto IL_59C;
					}
					break;
				}
				case 10:
				{
					char c = 1[0];
					if (c != 'd')
					{
						if (c != 'r')
						{
							return false;
						}
						if (!(1 == "rankeddate"))
						{
							return false;
						}
						goto IL_5C1;
					}
					else
					{
						if (!(1 == "difficulty"))
						{
							return false;
						}
						goto IL_5EB;
					}
					break;
				}
				case 11:
					if (!(1 == "ranked_date"))
					{
						return false;
					}
					goto IL_5C1;
				default:
					return false;
				}
				return 1608.1613.3(this.2, 2, 3, 0.005);
				IL_537:
				return this.4(2, 3);
				IL_557:
				return 1608.1613.3(this.9, 2, 3, 0.005);
				IL_585:
				return 1608.1613.3(this.11, 2, 3, 0.0);
				IL_59C:
				return 1608.1613.3(this.12, 2, 3, 0.0);
				IL_5B3:
				return 1608.1613.5(this.13, 2, 3);
				IL_5C1:
				return 1608.1613.5(this.14, 2, 3);
				IL_5DD:
				return 1608.1613.Text(ref this.16, 2, 3);
				IL_5EB:
				return 1608.1613.Text(ref this.18, 2, 3);
			}
			return false;
		}

		// Token: 0x060047A8 RID: 18344 RVA: 0x001C7D98 File Offset: 0x001C5F98
		private static bool 3(1608.1612 1, string 2, string 3, double 4)
		{
			double num;
			if (!double.TryParse(3, NumberStyles.Float, CultureInfo.InvariantCulture, out num))
			{
				return false;
			}
			1.1(2, num, 4);
			return true;
		}

		// Token: 0x060047A9 RID: 18345 RVA: 0x001C7DC8 File Offset: 0x001C5FC8
		private bool 4(string 1, string 2)
		{
			double num;
			if (!double.TryParse(2.TrimEnd(new char[]
			{
				'm',
				's',
				'h'
			}), NumberStyles.Float, CultureInfo.InvariantCulture, out num))
			{
				return false;
			}
			double num2 = 2.EndsWith("ms", StringComparison.Ordinal) ? 0.001 : ((double)(2.EndsWith("s", StringComparison.Ordinal) ? 1 : (2.EndsWith("m", StringComparison.Ordinal) ? 60 : (2.EndsWith("h", StringComparison.Ordinal) ? 3600 : 1))));
			this.7.1(1, num * num2, num2 / 2.0);
			return true;
		}

		// Token: 0x060047AA RID: 18346 RVA: 0x001C7E70 File Offset: 0x001C6070
		private static bool 5(1608.1612 1, string 2, string 3)
		{
			DateTime dateTime;
			if (!DateTime.TryParseExact(3, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal | DateTimeStyles.AssumeUniversal, out dateTime))
			{
				return false;
			}
			1.1(2, (double)dateTime.Date.Ticks, 0.0);
			return true;
		}

		// Token: 0x060047AB RID: 18347 RVA: 0x001C7EB6 File Offset: 0x001C60B6
		private static bool Text(ref string 1, string 2, string 3)
		{
			if (2 != "=" && 2 != ":")
			{
				return false;
			}
			1 = 3.Trim(new char[]
			{
				'"'
			});
			return true;
		}

		// Token: 0x060047AC RID: 18348 RVA: 0x001C7EE8 File Offset: 0x001C60E8
		internal bool 6(1599.1600 1)
		{
			2228.2229 2 = 4.1;
			bool flag = this.11.2((double)2.23) && this.12.2((double)2.22) && this.10.2((double)2.26) && this.13.2((double)2.1.Date.Ticks) && this.1.2(2.32.GetValueOrDefault()) && this.9.2(2.27) && (this.2.IsEmpty || this.2.2(1586.36(2, 4.2)));
			if (flag && !this.14.IsEmpty)
			{
				1586.1587 3 = 1586.48(2.4);
				DateTime? dateTime = (3 != null) ? 3.2 : null;
				flag = (dateTime != null && this.14.2((double)dateTime.Value.Date.Ticks));
			}
			if (!flag || !this.3.2(1586.23(2, 1928.ApproachRate)) || !this.4.2(1586.23(2, 1928.CircleSize)) || !this.5.2(1586.23(2, 1928.DrainRate)) || !this.6.2(1586.23(2, 1928.OverallDifficulty)) || !this.7.2(1586.28(2)) || !this.8.2(1586.27(2)))
			{
				return false;
			}
			string artist = (2.6 ?? string.Empty).ToLowerInvariant();
			string creator = (2.9 ?? string.Empty).ToLowerInvariant();
			string version = (2.8 ?? string.Empty).ToLowerInvariant();
			string title = (2.7 ?? string.Empty).ToLowerInvariant();
			return (this.15 == null || !(this.15 != artist)) && (this.16 == null || !(this.16 != creator)) && (this.18 == null || !(this.18 != version)) && (this.17 == null || !(this.17 != title)) && this.19.All((string 1) => artist.Contains(1) || creator.Contains(1) || version.Contains(1) || title.Contains(1));
		}

		// Token: 0x060047AD RID: 18349 RVA: 0x001C818C File Offset: 0x001C638C
		internal void Display(StringBuilder 1)
		{
			1608.1613.<>c__DisplayClass30_0 CS$<>8__locals1;
			CS$<>8__locals1.content = 2;
			1608.1613.<Display>g__Range|30_0("AR", this.3, ref CS$<>8__locals1);
			1608.1613.<Display>g__Range|30_0("CS", this.4, ref CS$<>8__locals1);
			1608.1613.<Display>g__Range|30_0("HP", this.5, ref CS$<>8__locals1);
			1608.1613.<Display>g__Range|30_0("OD", this.6, ref CS$<>8__locals1);
			1608.1613.<Display>g__Range|30_0("Length", this.7, ref CS$<>8__locals1);
			1608.1613.<Display>g__Range|30_0("Stars", this.2, ref CS$<>8__locals1);
			1608.1613.<Display>g__Range|30_0("PP", this.1, ref CS$<>8__locals1);
			1608.1613.<Display>g__Range|30_0("BPM", this.8, ref CS$<>8__locals1);
			1608.1613.<Display>g__Range|30_0("Accuracy", this.9, ref CS$<>8__locals1);
			1608.1613.<Display>g__Range|30_0("Combo", this.11, ref CS$<>8__locals1);
			1608.1613.<Display>g__Range|30_0("Misses", this.12, ref CS$<>8__locals1);
			1608.1613.<Display>g__Range|30_0("Score", this.10, ref CS$<>8__locals1);
			1608.1613.<Display>g__Text|30_1("Artist", this.15, ref CS$<>8__locals1);
			1608.1613.<Display>g__Text|30_1("Title", this.17, ref CS$<>8__locals1);
			1608.1613.<Display>g__Text|30_1("Version", this.18, ref CS$<>8__locals1);
			1608.1613.<Display>g__Text|30_1("Creator", this.16, ref CS$<>8__locals1);
			1608.1613.<Display>g__Range|30_0("Date", this.13, ref CS$<>8__locals1);
			1608.1613.<Display>g__Range|30_0("Ranked", this.14, ref CS$<>8__locals1);
			if (this.20.Length > 0)
			{
				bool flag;
				if (this.15 == null && this.17 == null && this.18 == null && this.16 == null)
				{
					flag = new 1608.1612[]
					{
						this.1,
						this.2,
						this.3,
						this.4,
						this.5,
						this.6,
						this.7,
						this.8,
						this.9,
						this.10,
						this.11,
						this.12,
						this.13,
						this.14
					}.Any((1608.1612 1) => !1.IsEmpty);
				}
				else
				{
					flag = true;
				}
				bool flag2 = flag;
				CS$<>8__locals1.content.Append(" • `").Append(flag2 ? "Remaining query: " : "Query: ").Append(this.20).Append('`');
			}
		}

		// Token: 0x060047B0 RID: 18352 RVA: 0x001C8505 File Offset: 0x001C6705
		[CompilerGenerated]
		internal static void <Display>g__Range|30_0(string 1, 1608.1612 2, ref 1608.1613.<>c__DisplayClass30_0 3)
		{
			if (!2.IsEmpty)
			{
				3.content.Append(" • `").Append(1).Append(": ").Append(2.3()).Append('`');
			}
		}

		// Token: 0x060047B1 RID: 18353 RVA: 0x001C8542 File Offset: 0x001C6742
		[CompilerGenerated]
		internal static void <Display>g__Text|30_1(string 1, string 2, ref 1608.1613.<>c__DisplayClass30_0 3)
		{
			if (2 != null)
			{
				3.content.Append(" • `").Append(1).Append(": ").Append(2).Append('`');
			}
		}

		// Token: 0x040034A0 RID: 13472
		public readonly 1608.1612 1 = new 1608.1612();

		// Token: 0x040034A1 RID: 13473
		public readonly 1608.1612 2 = new 1608.1612();

		// Token: 0x040034A2 RID: 13474
		public readonly 1608.1612 3 = new 1608.1612();

		// Token: 0x040034A3 RID: 13475
		public readonly 1608.1612 4 = new 1608.1612();

		// Token: 0x040034A4 RID: 13476
		public readonly 1608.1612 5 = new 1608.1612();

		// Token: 0x040034A5 RID: 13477
		public readonly 1608.1612 6 = new 1608.1612();

		// Token: 0x040034A6 RID: 13478
		public readonly 1608.1612 7 = new 1608.1612();

		// Token: 0x040034A7 RID: 13479
		public readonly 1608.1612 8 = new 1608.1612();

		// Token: 0x040034A8 RID: 13480
		public readonly 1608.1612 9 = new 1608.1612();

		// Token: 0x040034A9 RID: 13481
		public readonly 1608.1612 10 = new 1608.1612
		{
			6 = true
		};

		// Token: 0x040034AA RID: 13482
		public readonly 1608.1612 11 = new 1608.1612
		{
			6 = true
		};

		// Token: 0x040034AB RID: 13483
		public readonly 1608.1612 12 = new 1608.1612
		{
			6 = true
		};

		// Token: 0x040034AC RID: 13484
		public readonly 1608.1612 13 = new 1608.1612
		{
			5 = true
		};

		// Token: 0x040034AD RID: 13485
		public readonly 1608.1612 14 = new 1608.1612
		{
			5 = true
		};

		// Token: 0x040034AE RID: 13486
		public string 15;

		// Token: 0x040034AF RID: 13487
		public string 16;

		// Token: 0x040034B0 RID: 13488
		public string 17;

		// Token: 0x040034B1 RID: 13489
		public string 18;

		// Token: 0x040034B2 RID: 13490
		public string[] 19 = new string[0];

		// Token: 0x040034B3 RID: 13491
		private string 20 = string.Empty;

		// Token: 0x040034B4 RID: 13492
		private static readonly Regex 21 = new Regex("\\b(?<key>\\w+)(?<op>(:|=|(>|<)(:|=)?))(?<value>(\".*\")|(\\S*))", RegexOptions.Compiled);
	}
}
