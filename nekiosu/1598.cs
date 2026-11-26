using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

// Token: 0x020009F3 RID: 2547
internal static class 1598
{
	// Token: 0x06004722 RID: 18210 RVA: 0x001C0E74 File Offset: 0x001BF074
	internal static 217 1(2147? 1 = null)
	{
		109 2 = new 109();
		217 3;
		if (1 != null)
		{
			switch (1.GetValueOrDefault())
			{
			case 2147.Taiko:
				3 = 1585.2("rt", "Display a user's most recent taiko play");
				goto IL_7F;
			case 2147.CatchTheBeat:
				3 = 1585.2("rc", "Display a user's most recent ctb play");
				goto IL_7F;
			case 2147.OsuMania:
				3 = 1585.2("rm", "Display a user's most recent mania play");
				goto IL_7F;
			}
		}
		3 = 1585.2("rs", "Show a user's recent score");
		2.Add(1585.4(true));
		IL_7F:
		2.Add(1585.3(3, "index", "Choose the recent score's index or `random`"));
		2.Add(1585.5());
		2.Add(1585.3(5, "passes", "Specify whether only passes should be considered"));
		3["options"] = 2;
		return 3;
	}

	// Token: 0x06004723 RID: 18211 RVA: 0x001C0F44 File Offset: 0x001BF144
	internal static void 2(217 1, 2147? 2)
	{
		1598.<>c__DisplayClass1_0 CS$<>8__locals1 = new 1598.<>c__DisplayClass1_0();
		Dictionary<string, 226> 3 = 1585.Options(5);
		CS$<>8__locals1.mode = (2 ?? 1585.Mode(3));
		1598.<>c__DisplayClass1_0 CS$<>8__locals2 = CS$<>8__locals1;
		string text = 1585.Text(3, "grade");
		CS$<>8__locals2.grade = ((text != null) ? text.ToUpperInvariant() : null);
		CS$<>8__locals1.passes = 1585.6(3, "passes");
		string text2 = 1585.Text(3, "index");
		string text3 = (text2 != null) ? text2.Trim() : null;
		if (CS$<>8__locals1.grade == "F" && CS$<>8__locals1.passes.GetValueOrDefault())
		{
			1586.58(5, ":clown:");
			return;
		}
		string profileName = 1586.ProfileName;
		List<2228.2229> list = (from 1 in 2228.Get(profileName)
		where 1.10 == CS$<>8__locals1.mode
		select 1).ToList<2228.2229>();
		if (list.Count == 0)
		{
			1586.58(5, string.Concat(new string[]
			{
				"No recent ",
				1586.42(CS$<>8__locals1.mode),
				"plays found for user `",
				profileName,
				"`"
			}));
			return;
		}
		if (CS$<>8__locals1.grade != null)
		{
			List<2228.2229> list2;
			if (!(CS$<>8__locals1.grade == "F"))
			{
				list2 = (from 1 in list
				where 1.29 && 1586.13(1.28) == CS$<>8__locals1.grade
				select 1).ToList<2228.2229>();
			}
			else
			{
				list2 = (from 1 in list
				where !1.29
				select 1).ToList<2228.2229>();
			}
			list = list2;
		}
		else if (CS$<>8__locals1.passes != null)
		{
			list = (from 1 in list
			where 1.29 == CS$<>8__locals1.passes.Value
			select 1).ToList<2228.2229>();
		}
		int num = 0;
		if (text3 == "random" || text3 == "?")
		{
			num = ((list.Count > 0) ? new Random().Next(list.Count) : 0);
		}
		else if (!string.IsNullOrEmpty(text3))
		{
			if (!int.TryParse(text3, NumberStyles.None, CultureInfo.InvariantCulture, out num))
			{
				1586.58(5, "Failed to parse index. Must be an integer between 1 and 100 or `random` / `?`.");
				return;
			}
			num = Math.Max(0, num - 1);
		}
		if (num >= list.Count)
		{
			int count = list.Count;
			1586.58(5, string.Concat(new string[]
			{
				"There ",
				(count != 1) ? "are" : "is",
				" only ",
				count.ToString(),
				" score",
				(count != 1) ? "s" : string.Empty,
				" in `",
				profileName,
				"`'",
				profileName.EndsWith("s", StringComparison.Ordinal) ? string.Empty : "s",
				" recent history."
			}));
			return;
		}
		List<1599.1600> 4 = list.Select(delegate(2228.2229 1)
		{
			1599.1600 6 = new 1599.1600();
			6.1 = 1;
			6.2 = 1272.8(1.3);
			6.4 = delegate(1599.1600 1)
			{
				if (!1.1.29)
				{
					return null;
				}
				return 1599.6(1.1, 1.2);
			};
			return 6;
		}).ToList<1599.1600>();
		1599.8(5, 4, num, "Try #" + 2228.5(list, num).ToString(), num, false);
	}
}
