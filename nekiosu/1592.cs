using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Token: 0x020009DD RID: 2525
internal static class 1592
{
	// Token: 0x060046A4 RID: 18084 RVA: 0x001BC56C File Offset: 0x001BA76C
	internal static 217 1()
	{
		217 <<EMPTY_NAME>> = 1585.2("nochoke", "How the top plays would look like with only full combos");
		217 2 = 1585.3(4, "miss_limit", "Only unchoke scores with at most this many misses");
		2["min_value"] = 0;
		217 3 = 1585.3(3, "version", "Specify a version to unchoke scores");
		217 4 = 3;
		string text = "choices";
		object[] array = new object[2];
		int num = 0;
		217 5 = new 217();
		5["name"] = "Unchoke";
		5["value"] = "unchoke";
		array[num] = 5;
		int num2 = 1;
		217 6 = new 217();
		6["name"] = "Perfect";
		6["value"] = "perfect";
		array[num2] = 6;
		4[text] = new 109(array);
		217 7 = 1585.3(3, "filter", "Filter out certain scores");
		217 8 = 7;
		string text2 = "choices";
		object[] array2 = new object[2];
		int num3 = 0;
		217 9 = new 217();
		9["name"] = "Only keep chokes";
		9["value"] = "only_chokes";
		array2[num3] = 9;
		int num4 = 1;
		217 10 = new 217();
		10["name"] = "Remove all chokes";
		10["value"] = "remove_chokes";
		array2[num4] = 10;
		8[text2] = new 109(array2);
		<<EMPTY_NAME>>["options"] = new 109(new object[]
		{
			1585.4(false),
			2,
			3,
			7
		});
		return <<EMPTY_NAME>>;
	}

	// Token: 0x060046A5 RID: 18085 RVA: 0x001BC6F0 File Offset: 0x001BA8F0
	internal static void 2(217 1)
	{
		Dictionary<string, 226> dictionary = 1585.Options(1);
		226 2;
		int missLimit = dictionary.TryGetValue("miss_limit", out 2) ? ((int?)2).GetValueOrDefault(int.MaxValue) : int.MaxValue;
		bool perfect = 1585.Text(dictionary, "version") == "perfect";
		string filter = 1585.Text(dictionary, "filter");
		2147 mode = 1585.Mode(dictionary);
		List<1599.1600> items = 1608.3(200, mode);
		1589.3(1);
		1586.1588 3 = new 1586.1588(delegate()
		{
			1592.Show(1, mode, items, missLimit, perfect, filter);
		});
		foreach (1599.1600 4 in items)
		{
			1586.34(4.1, 4.2, 4.3, 3);
		}
		3.Start(30000);
	}

	// Token: 0x060046A6 RID: 18086 RVA: 0x001BC81C File Offset: 0x001BAA1C
	private static 1592.1593 Unchoke(1599.1600 1, int 2, bool 3)
	{
		1586.35(1.1, 1.2, 1.3);
		2228.2229 4 = 1.1;
		1592.1593 5 = new 1592.1593
		{
			1 = 1,
			3 = 4.32.GetValueOrDefault(),
			4 = 4.28,
			5 = 4.27,
			6 = 4.23
		};
		1890 6 = (1.2 != null && 1.3 != null) ? 2237.4(1.3, 1.2, null) : null;
		if (6 == null || 4.22 > 2)
		{
			return 5;
		}
		if (3)
		{
			2237.2238 7 = (4.10 == 2147.Taiko && 4.22 == 0) ? 1586.32(4) : 2237.7(6, 4.11);
			5.2 = true;
			5.3 = 2237.12(6, 7);
			7.1 = 4.11;
			5.4 = 1586.Grade(4.10, 7);
			5.5 = 1586.Accuracy(4.10, 7);
			5.6 = 1592.3(6, 4);
			return 5;
		}
		if (1586.29(4))
		{
			return 5;
		}
		2237.2238 8;
		double? num = 1586.Unchoke(6, 1586.32(4), out 8);
		if (num == null)
		{
			return 5;
		}
		5.2 = true;
		5.3 = num.Value;
		8.1 = 4.11;
		5.4 = 1586.Grade(4.10, 8);
		5.5 = 1586.Accuracy(4.10, 8);
		5.6 = 1592.3(6, 4);
		return 5;
	}

	// Token: 0x060046A7 RID: 18087 RVA: 0x001BC9B8 File Offset: 0x001BABB8
	private static int 3(1890 1, 2228.2229 2)
	{
		2092 3 = 1 as 2092;
		if (3 == null)
		{
			2170 4 = 1 as 2170;
			if (4 != null)
			{
				return 4.11;
			}
			1841 5 = 1 as 1841;
			if (5 == null)
			{
				return 2.24;
			}
			return 5.4;
		}
		else
		{
			if (3.18 <= 0)
			{
				return 3.17;
			}
			return 3.18;
		}
	}

	// Token: 0x060046A8 RID: 18088 RVA: 0x001BCA10 File Offset: 0x001BAC10
	private static void Show(217 1, 2147 2, List<1599.1600> 3, int 4, bool 5, string 6)
	{
		List<1592.1593> entries = (from 1 in 3
		select 1592.Unchoke(1, 4, 5)).ToList<1592.1593>();
		2210.2216 7 = 2210.4(9);
		double num = (7 != null) ? 7.1 : 0.0;
		double num2 = 0.0;
		for (int i = 0; i < entries.Count; i++)
		{
			num2 += entries[i].1.1.32.GetValueOrDefault() * Math.Pow(0.95, (double)i);
		}
		double num3 = num - num2;
		entries.Sort((1592.1593 1, 1592.1593 2) => 2.3.CompareTo(1.3));
		double unchokedPp = 0.0;
		for (int j = 0; j < entries.Count; j++)
		{
			unchokedPp += entries[j].3 * Math.Pow(0.95, (double)j);
		}
		unchokedPp = Math.Round(unchokedPp + num3, 2);
		if (6 == "only_chokes")
		{
			entries = (from 1 in entries
			where 1.2
			select 1).ToList<1592.1593>();
		}
		else if (6 == "remove_chokes")
		{
			entries = (from 1 in entries
			where !1.2
			select 1).ToList<1592.1593>();
		}
		string content = string.Concat(new string[]
		{
			5 ? "Perfect" : "No-choke",
			" top ",
			1586.42(9),
			"scores for `",
			1586.ProfileName,
			"`",
			(6 == "only_chokes") ? " (only chokes)" : ((6 == "remove_chokes") ? " (removed chokes)" : string.Empty),
			":"
		});
		double num4 = Math.Round(unchokedPp - num, 2);
		string title = string.Concat(new string[]
		{
			"Total pp: ",
			1586.1(num),
			" → **",
			1586.1(unchokedPp),
			"pp** (+",
			1586.1(num4),
			")"
		});
		1589.Start(8, entries.Count, 5, 0, delegate(1589.1590 1, 217 2)
		{
			1586.1588 10 = new 1586.1588(delegate()
			{
				StringBuilder stringBuilder = new StringBuilder();
				foreach (1592.1593 11 in entries.Skip(1.3).Take(1.5))
				{
					2228.2229 12 = 11.1.1;
					string text = string.IsNullOrEmpty(12.8) ? 1586.5(12.7) : (1586.5(12.7) + " [" + 1586.5(12.8) + "]");
					string value = (12.4 > 0) ? string.Concat(new string[]
					{
						"[",
						text,
						"](",
						244.3(12.4),
						")"
					}) : text;
					string value2 = 11.2 ? (" • *Removed " + 12.22.ToString() + 1586.Emote("miss", " miss") + "*") : ((12.22 > 0) ? " • *Skipped :track_next:*" : string.Empty);
					stringBuilder.Append("**#").Append(11.1.5).Append(' ').Append(value).Append(" +").Append(1586.18(12)).Append("** [").Append((12.35 != null) ? 1586.2(12.35.Value) : "-").Append("★]\n");
					stringBuilder.Append(1586.12(11.4)).Append(' ').Append(1586.2(12.32.GetValueOrDefault())).Append(" → **").Append(1586.2(11.3)).Append("pp**/").Append((12.34 != null) ? 1586.2(12.34.Value) : "-").Append("PP • ").Append(1586.2(12.27)).Append(" → **").Append(1586.2(11.5)).Append("%**\n");
					stringBuilder.Append("[ ").Append(12.23).Append(" → **").Append(11.6).Append("x**/").Append((12.24 > 0) ? (12.24.ToString() + "x") : "-").Append(" ]").Append(value2).Append(" • <t:").Append(1586.7(12.1)).Append(":R>\n");
				}
				string text2 = "Page " + 1.Page.ToString() + "/" + 1.LastPage.ToString();
				int? num5 = 2218.Get(unchokedPp, null, 9);
				if (num5 != null)
				{
					int valueOrDefault = num5.GetValueOrDefault();
					text2 = string.Concat(new string[]
					{
						text2,
						" • The current rank for ",
						1586.3(unchokedPp),
						"pp is approx. #",
						1586.4((long)valueOrDefault)
					});
				}
				byte[] array = 1586.47();
				217 13 = new 217();
				13["color"] = 2067276;
				13["author"] = 1586.Author(9);
				13["title"] = title;
				13["description"] = stringBuilder.ToString();
				string text3 = "footer";
				217 14 = new 217();
				14["text"] = text2;
				13[text3] = 14;
				217 15 = 13;
				if (array != null)
				{
					217 16 = 15;
					string text4 = "thumbnail";
					217 17 = new 217();
					17["url"] = "attachment://avatar.jpg";
					16[text4] = 17;
				}
				217 18 = new 217();
				18["content"] = content;
				18["embeds"] = new 109(15);
				18["components"] = 1589.Buttons(1);
				217 19 = 18;
				1589.Edit(1, 2, 19, (array != null) ? "avatar.jpg" : null, array);
			});
			1586.46(10, 9);
			Action action = 10.1();
			if (2218.Get(unchokedPp, action, 9) != null || 2218.3(unchokedPp, 9))
			{
				action();
			}
			10.Start(8000);
		}, null, true);
	}

	// Token: 0x040033A1 RID: 13217
	private const int 1 = 30000;

	// Token: 0x020009DE RID: 2526
	private sealed class 1593
	{
		// Token: 0x040033A2 RID: 13218
		public 1599.1600 1;

		// Token: 0x040033A3 RID: 13219
		public bool 2;

		// Token: 0x040033A4 RID: 13220
		public double 3;

		// Token: 0x040033A5 RID: 13221
		public string 4;

		// Token: 0x040033A6 RID: 13222
		public double 5;

		// Token: 0x040033A7 RID: 13223
		public int 6;
	}
}
