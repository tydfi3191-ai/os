using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x020009E3 RID: 2531
internal static class 1594
{
	// Token: 0x060046B6 RID: 18102 RVA: 0x001BD318 File Offset: 0x001BB518
	internal static 217 1()
	{
		217 <<EMPTY_NAME>> = 1585.2("pp", "How many pp is a user missing to reach the given amount?");
		217 2 = 1585.3(3, "pp", "Specify a target total pp amount");
		2["required"] = true;
		217 3 = 1585.3(10, "each", "Fill a top200 with scores of this many pp until the target total pp are reached");
		3["min_value"] = 0;
		217 4 = 1585.3(4, "amount", "Specify an amount of scores to set to reach the target pp");
		4["min_value"] = 1;
		4["max_value"] = 100;
		<<EMPTY_NAME>>["options"] = new 109(new object[]
		{
			2,
			1585.4(true),
			3,
			4
		});
		return <<EMPTY_NAME>>;
	}

	// Token: 0x060046B7 RID: 18103 RVA: 0x001BD3DC File Offset: 0x001BB5DC
	internal static 217 2()
	{
		217 <<EMPTY_NAME>> = 1585.2("whatif", "Display the impact of a new X pp score for a user");
		217 2 = 1585.3(10, "pp", "Specify a pp amount");
		2["required"] = true;
		2["min_value"] = 0;
		217 3 = 1585.3(4, "count", "Specify how many times a score should be added, defaults to 1");
		3["min_value"] = 1;
		3["max_value"] = 1000;
		<<EMPTY_NAME>>["options"] = new 109(new object[]
		{
			2,
			1585.4(true),
			3
		});
		return <<EMPTY_NAME>>;
	}

	// Token: 0x060046B8 RID: 18104 RVA: 0x001BD48C File Offset: 0x001BB68C
	private static List<double> 3(2147 1)
	{
		2210.2216 2 = 2210.4(3);
		return (from 1 in (from 1 in ((2 != null) ? 2.9 : null) ?? new List<2210.2214>()
		where !1.7
		select 1).Take(200)
		select 1.4).ToList<double>();
	}

	// Token: 0x060046B9 RID: 18105 RVA: 0x001BD50C File Offset: 0x001BB70C
	private static double 4(IEnumerable<double> 1)
	{
		double num = 0.0;
		int num2 = 0;
		foreach (double num3 in 1)
		{
			num += num3 * Math.Pow(0.95, (double)num2++);
		}
		return num;
	}

	// Token: 0x060046BA RID: 18106 RVA: 0x001BD574 File Offset: 0x001BB774
	[return: TupleElementNames(new string[]
	{
		"Required",
		"Index"
	})]
	private static ValueTuple<double, int> 5(double 1, double 2, IList<double> 3)
	{
		double num = 1;
		double num2 = 0.0;
		for (int i = 3.Count - 1; i >= 0; i--)
		{
			double num3 = Math.Pow(0.95, (double)i) * 3[i];
			double num4 = num3 * 0.95;
			if (num + num2 + num4 >= 2)
			{
				return new ValueTuple<double, int>((2 - num - num2) / Math.Pow(0.95, (double)(i + 1)), i + 1);
			}
			num2 += num4;
			num -= num3;
		}
		return new ValueTuple<double, int>(2 - num - num2, 0);
	}

	// Token: 0x060046BB RID: 18107 RVA: 0x001BD604 File Offset: 0x001BB804
	private static string 6(int 1)
	{
		int num = 1 % 100;
		if (num - 11 <= 2)
		{
			return "th";
		}
		switch (1 % 10)
		{
		case 1:
			return "st";
		case 2:
			return "nd";
		case 3:
			return "rd";
		default:
			return "th";
		}
	}

	// Token: 0x060046BC RID: 18108 RVA: 0x001BD655 File Offset: 0x001BB855
	private static string C(double 1)
	{
		return 1586.3(1);
	}

	// Token: 0x060046BD RID: 18109 RVA: 0x001BD660 File Offset: 0x001BB860
	internal static void 7(217 1)
	{
		Dictionary<string, 226> dictionary = 1585.Options(8);
		string text = (1585.Text(dictionary, "pp") ?? string.Empty).Trim();
		bool flag = text.StartsWith("+", StringComparison.Ordinal);
		double num;
		if (!double.TryParse(text, NumberStyles.Float, CultureInfo.InvariantCulture, out num))
		{
			1586.58(8, "Failed to parse pp. Be sure to specify a decimal number.");
			return;
		}
		if (num < 0.0)
		{
			1586.58(8, "The pp number must be non-negative");
			return;
		}
		if (num > 9007199254740992.0)
		{
			1586.58(8, "Number too large");
			return;
		}
		double? num2 = 1585.7(dictionary, "each");
		226 2;
		int? num3 = dictionary.TryGetValue("amount", out 2) ? ((int?)2) : null;
		2147 3 = 1585.Mode(dictionary);
		string text2 = 1586.5(1586.ProfileName);
		2210.2216 4 = 2210.4(3);
		double num4 = (4 != null) ? 4.1 : 0.0;
		double goal = flag ? (num4 + num) : num;
		List<double> list = 1594.3(3);
		string 5;
		if (list.Count == 0)
		{
			5 = "No top scores found";
		}
		else if (num4 > goal)
		{
			5 = string.Concat(new string[]
			{
				text2,
				" has ",
				1594.C(num4),
				"pp which is already more than ",
				1594.C(goal),
				"pp."
			});
		}
		else if (num2 == null && (num3 == null || num3.Value == 1))
		{
			ValueTuple<double, int> valueTuple = 1594.5(num4, goal, list);
			double item = valueTuple.Item1;
			int item2 = valueTuple.Item2;
			5 = string.Concat(new string[]
			{
				"To reach ",
				1594.C(goal),
				"pp with one additional score, ",
				text2,
				" needs to perform a **",
				1594.C(item),
				"pp** score which would be their ",
				(item2 >= 200) ? "~" : string.Empty,
				(item2 + 1).ToString(),
				1594.6(item2 + 1),
				" top play"
			});
		}
		else if (num2 != null && num2.Value < list[list.Count - 1])
		{
			5 = string.Concat(new string[]
			{
				"New top200 scores require at least **",
				1594.C(list[list.Count - 1]),
				"pp** for ",
				text2,
				" so ",
				1594.C(goal),
				" total pp can't be reached with ",
				1594.C(num2.Value),
				"pp scores."
			});
		}
		else if (num2 != null)
		{
			5 = 1594.8(text2, num4, goal, num2.Value, list);
		}
		else
		{
			int value = num3.Value;
			double num5 = Enumerable.Range(0, value).Sum((int 1) => Math.Pow(0.95, (double)1));
			double 6 = num4 + (goal - num4) / num5;
			double required = 1594.5(num4, 6, list).Item1;
			int num6 = list.Count((double 1) => 1 >= required);
			if (list.Count >= 100 && required < list[list.Count - 1])
			{
				required = Math.Max(0.0, list[list.Count - 1] - 0.01);
			}
			string text3 = (num6 >= 200) ? "outside of the top 200" : ("at personal bests #" + (num6 + 1).ToString() + " to #" + (num6 + value).ToString());
			5 = string.Concat(new string[]
			{
				"To reach ",
				1594.C(goal),
				"pp with ",
				value.ToString(),
				" additional score",
				(value == 1) ? string.Empty : "s",
				" of the same pp, each of them would need to be **",
				1594.C(required),
				"pp**, placing them ",
				text3,
				" for ",
				text2,
				"."
			});
		}
		string 7 = string.Concat(new string[]
		{
			"What scores is ",
			text2,
			" missing to reach ",
			1594.C(goal),
			"pp?"
		});
		1594.10(8, 3, 7, 5, new double?(goal), (int 1) => "The current rank for " + 1594.C(goal) + "pp is approx. #" + 1586.4((long)1), false);
	}

	// Token: 0x060046BE RID: 18110 RVA: 0x001BDB58 File Offset: 0x001BBD58
	private static string 8(string 1, double 2, double 3, double 4, List<double> 5)
	{
		ValueTuple<double, int> valueTuple = 1594.5(7, 3, 5);
		double item = valueTuple.Item1;
		int item2 = valueTuple.Item2;
		if (item < 4)
		{
			return string.Concat(new string[]
			{
				"To reach ",
				1594.C(3),
				"pp with one additional score, ",
				6,
				" needs to perform a **",
				1594.C(item),
				"pp** score which would be their ",
				(item2 + 1).ToString(),
				1594.6(item2 + 1),
				" top play"
			});
		}
		int num = 5.Count((double 1) => 1 >= 4);
		double num2 = 0.0;
		for (int i = 0; i < num; i++)
		{
			num2 += 5[i] * Math.Pow(0.95, (double)i);
		}
		double num3 = 0.0;
		for (int j = num; j < 5.Count; j++)
		{
			num3 += 5[j] * Math.Pow(0.95, (double)j);
		}
		double num4 = Math.Max(7 - (num2 + num3), 0.0);
		num2 += num4;
		int? num5 = null;
		int count = 5.Count;
		for (int k = num; k < count; k++)
		{
			double num6 = 0.0;
			for (int l = num; l < count; l++)
			{
				num6 += 5[l] * Math.Pow(0.95, (double)(k + 1 + (l - num)));
			}
			double num7 = Math.Pow(0.95, (double)k);
			if (num2 + num7 * 4 + num6 >= 3)
			{
				num5 = new int?(k - num);
				break;
			}
			num2 += num7 * 4;
		}
		if (num5 == null)
		{
			double num8 = 0.0;
			for (int m = num; m < count; m++)
			{
				num8 += 5[m] * Math.Pow(0.95, (double)(count + (m - num)));
			}
			num2 += num8;
			if (num2 >= 3)
			{
				num5 = new int?(count - num);
			}
		}
		if (num5 != null)
		{
			List<double> list = new List<double>(5);
			list.AddRange(Enumerable.Repeat<double>(4, num5.Value));
			list.Sort((double 1, double 2) => 2.CompareTo(1));
			double item3 = 1594.5(1594.4(list) + num4, 3, list).Item1;
			return string.Concat(new string[]
			{
				"To reach ",
				1594.C(3),
				"pp, ",
				6,
				" needs to perform **",
				num5.Value.ToString(),
				"** more ",
				1594.C(4),
				"pp score",
				(num5.Value != 1) ? "s" : string.Empty,
				" and one **",
				1594.C(item3),
				"pp** score."
			});
		}
		int num9 = count - num;
		return string.Concat(new string[]
		{
			"Filling up ",
			6,
			"'",
			(num != 1) ? "s" : string.Empty,
			" top scores with ",
			num9.ToString(),
			" new ",
			1594.C(4),
			"pp score",
			(num9 != 1) ? "s" : string.Empty,
			" would only lead to ",
			(num >= 200) ? "roughly " : string.Empty,
			"**",
			1594.C(num2),
			"pp** which is still less than ",
			1594.C(3),
			"pp."
		});
	}

	// Token: 0x060046BF RID: 18111 RVA: 0x001BDF88 File Offset: 0x001BC188
	internal static void 9(217 1)
	{
		1594.<>c__DisplayClass10_0 CS$<>8__locals1 = new 1594.<>c__DisplayClass10_0();
		CS$<>8__locals1.interaction = 5;
		Dictionary<string, 226> dictionary = 1585.Options(CS$<>8__locals1.interaction);
		CS$<>8__locals1.pp = 1585.7(dictionary, "pp").GetValueOrDefault();
		226 6;
		int num = dictionary.TryGetValue("count", out 6) ? ((int?)6).GetValueOrDefault(1) : 1;
		if (CS$<>8__locals1.pp < 0.0)
		{
			1586.58(CS$<>8__locals1.interaction, "The pp number must be non-negative");
			return;
		}
		if (CS$<>8__locals1.pp > 9007199254740992.0)
		{
			1586.58(CS$<>8__locals1.interaction, "Number too large");
			return;
		}
		CS$<>8__locals1.mode = 1585.Mode(dictionary);
		string text = 1586.5(1586.ProfileName);
		1594.<>c__DisplayClass10_0 CS$<>8__locals2 = CS$<>8__locals1;
		2210.2216 3 = 2210.4(CS$<>8__locals1.mode);
		CS$<>8__locals2.statsPp = ((3 != null) ? 3.1 : 0.0);
		CS$<>8__locals1.pps = 1594.3(CS$<>8__locals1.mode);
		CS$<>8__locals1.title = ((num <= 1) ? string.Concat(new string[]
		{
			"What if ",
			text,
			" got a new ",
			1586.1(CS$<>8__locals1.pp),
			"pp score?"
		}) : string.Concat(new string[]
		{
			"What if ",
			text,
			" got ",
			num.ToString(),
			" new ",
			1586.1(CS$<>8__locals1.pp),
			"pp scores?"
		}));
		if (CS$<>8__locals1.pps.Count == 200 && CS$<>8__locals1.pp < CS$<>8__locals1.pps[CS$<>8__locals1.pps.Count - 1])
		{
			1594.10(CS$<>8__locals1.interaction, CS$<>8__locals1.mode, CS$<>8__locals1.title, string.Concat(new string[]
			{
				"A ",
				1586.1(CS$<>8__locals1.pp),
				"pp play wouldn't even be in ",
				text,
				"'s top 200 plays.\nThere would not be any significant pp change."
			}), null, null, false);
			return;
		}
		if (CS$<>8__locals1.pps.Count == 0)
		{
			CS$<>8__locals1.newPp = 1594.4(Enumerable.Repeat<double>(CS$<>8__locals1.pp, num));
			CS$<>8__locals1.lead = ((num == 1) ? string.Concat(new string[]
			{
				"A ",
				1594.C(CS$<>8__locals1.pp),
				"pp play would be ",
				text,
				"'s #1 best play.\nTheir pp would change by **+",
				1594.C(CS$<>8__locals1.pp),
				"** to **",
				1594.C(CS$<>8__locals1.pp),
				"pp**"
			}) : string.Concat(new string[]
			{
				"A ",
				1594.C(CS$<>8__locals1.pp),
				"pp play would be ",
				text,
				"'s #1 best play.\nAdding ",
				num.ToString(),
				" of them would change their pp by **+",
				1594.C(CS$<>8__locals1.pp),
				"** to **",
				1594.C(CS$<>8__locals1.pp),
				"pp**"
			}));
		}
		else
		{
			double num2 = Math.Max(CS$<>8__locals1.statsPp - 1594.4(CS$<>8__locals1.pps), 0.0);
			int num3 = CS$<>8__locals1.pps.FindIndex((double 1) => 1 < CS$<>8__locals1.pp);
			num3 = ((num3 < 0) ? (CS$<>8__locals1.pps.Count - 1) : num3);
			List<double> list = new List<double>(CS$<>8__locals1.pps);
			list.AddRange(Enumerable.Repeat<double>(CS$<>8__locals1.pp, num));
			list.Sort((double 1, double 2) => 2.CompareTo(1));
			CS$<>8__locals1.newPp = 1594.4(list) + num2;
			string text2 = "+" + 1586.2(Math.Max(0.0, CS$<>8__locals1.newPp - CS$<>8__locals1.statsPp));
			CS$<>8__locals1.lead = ((num == 1) ? string.Concat(new string[]
			{
				"A ",
				1586.1(CS$<>8__locals1.pp),
				"pp play would be ",
				text,
				"'s #",
				(num3 + 1).ToString(),
				" best play.\nTheir pp would change by **",
				text2,
				"** to **",
				1594.C(CS$<>8__locals1.newPp),
				"pp**"
			}) : string.Concat(new string[]
			{
				"A ",
				1586.1(CS$<>8__locals1.pp),
				"pp play would be ",
				text,
				"'s #",
				(num3 + 1).ToString(),
				" best play.\nAdding ",
				num.ToString(),
				" of them would change their pp by **",
				text2,
				"** to **",
				1594.C(CS$<>8__locals1.newPp),
				"pp**"
			}));
		}
		double num4 = (CS$<>8__locals1.pps.Count > 0) ? CS$<>8__locals1.pps[0] : 0.0;
		CS$<>8__locals1.banned = (CS$<>8__locals1.pps.Count > 0 && CS$<>8__locals1.pp > num4 * 2.0 && CS$<>8__locals1.pp > 30.0);
		CS$<>8__locals1.current = 2210.76(CS$<>8__locals1.statsPp, null, new 2147?(CS$<>8__locals1.mode));
		Action action = delegate()
		{
			int? num5 = 2218.Get(CS$<>8__locals1.newPp, null, CS$<>8__locals1.mode);
			string text3 = CS$<>8__locals1.lead;
			if (num5 != null)
			{
				int num6 = CS$<>8__locals1.current ?? 2210.76(CS$<>8__locals1.statsPp, null, new 2147?(CS$<>8__locals1.mode)).GetValueOrDefault();
				text3 = string.Concat(new string[]
				{
					text3,
					(CS$<>8__locals1.pps.Count == 0) ? "\nand" : " and",
					" they would reach approx. rank #",
					1586.4((long)((num6 > 0) ? Math.Min(num5.Value, num6) : num5.Value)),
					(num6 > 0) ? (" (+" + 1586.4((long)Math.Max(0, num6 - num5.Value)) + ")") : string.Empty,
					"."
				});
			}
			else
			{
				text3 += ".";
			}
			if (CS$<>8__locals1.banned)
			{
				text3 += "\nThey'd probably also get banned :^)";
			}
			1594.10(CS$<>8__locals1.interaction, CS$<>8__locals1.mode, CS$<>8__locals1.title, text3, null, null, true);
		};
		1589.3(CS$<>8__locals1.interaction);
		1586.1588 4 = new 1586.1588(action);
		Action action2 = 4.1();
		if (2218.Get(CS$<>8__locals1.newPp, action2, CS$<>8__locals1.mode) != null || 2218.3(CS$<>8__locals1.newPp, CS$<>8__locals1.mode))
		{
			action2();
		}
		1586.46(4, CS$<>8__locals1.mode);
		4.Start(8000);
	}

	// Token: 0x060046C0 RID: 18112 RVA: 0x001BE578 File Offset: 0x001BC778
	private static void 10(217 1, 2147 2, string 3, string 4, double? 5, Func<int, string> 6, bool 7 = false)
	{
		if (!7)
		{
			1589.3(1);
		}
		1586.1588 8 = new 1586.1588(delegate()
		{
			byte[] array = 1586.47();
			217 9 = new 217();
			9["color"] = 2067276;
			9["author"] = 1586.Author(2);
			9["title"] = 1586.6(3, 256);
			9["description"] = 4;
			217 10 = 9;
			if (5 != null && 6 != null)
			{
				int? num = 2218.Get(5.Value, null, 2);
				if (num != null)
				{
					int valueOrDefault = num.GetValueOrDefault();
					217 11 = 10;
					string text = "footer";
					217 12 = new 217();
					12["text"] = 6(valueOrDefault);
					11[text] = 12;
				}
			}
			if (array != null)
			{
				217 13 = 10;
				string text2 = "thumbnail";
				217 14 = new 217();
				14["url"] = "attachment://avatar.jpg";
				13[text2] = 14;
			}
			217 interaction = 1;
			217 15 = new 217();
			15["embeds"] = new 109(10);
			1584.13(interaction, 15, (array != null) ? "avatar.jpg" : null, array);
		});
		1586.46(8, 2);
		if (5 != null)
		{
			Action action = 8.1();
			if (2218.Get(5.Value, action, 2) != null || 2218.3(5.Value, 2))
			{
				action();
			}
		}
		8.Start(8000);
	}

	// Token: 0x040033BC RID: 13244
	private const double 1 = 0.95;
}
