using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

// Token: 0x020009F6 RID: 2550
internal static class 1599
{
	// Token: 0x0600472D RID: 18221 RVA: 0x001C1328 File Offset: 0x001BF528
	internal static void 1(1599.1600 1, Action 2)
	{
		1586.1588 3 = new 1586.1588(2);
		1586.34(1.1, 1.2, 1.3, 3);
		1586.49(1.1.4, 3);
		1586.46(3, 1.1.10);
		3.Start(8000);
	}

	// Token: 0x0600472E RID: 18222 RVA: 0x001C1382 File Offset: 0x001BF582
	internal static 217 2(1599.1600 1)
	{
		return 1599.3(1, 1604.Current, -1);
	}

	// Token: 0x0600472F RID: 18223 RVA: 0x001C1390 File Offset: 0x001BF590
	internal static 217 3(1599.1600 1, 1604 2, int 3)
	{
		1599.<>c__DisplayClass5_0 CS$<>8__locals1;
		CS$<>8__locals1.mark = 3;
		1586.35(1.1, 1.2, 1.3);
		CS$<>8__locals1.entry = 1.1;
		CS$<>8__locals1.approved = 1586.Approved(CS$<>8__locals1.entry, 1.2);
		CS$<>8__locals1.info = 1586.48(CS$<>8__locals1.entry.4);
		CS$<>8__locals1.values = 2.3;
		StringBuilder stringBuilder = new StringBuilder();
		CS$<>8__locals1.value = new StringBuilder();
		CS$<>8__locals1.footer = new StringBuilder();
		CS$<>8__locals1.writer = stringBuilder;
		for (int i = 0; i < CS$<>8__locals1.values.Count; i++)
		{
			1604.1607 4 = CS$<>8__locals1.values[i];
			1604.1607 5 = (i > 0) ? CS$<>8__locals1.values[i - 1] : null;
			1604.1607 6 = (i + 1 < CS$<>8__locals1.values.Count) ? CS$<>8__locals1.values[i + 1] : null;
			bool flag = CS$<>8__locals1.mark == i;
			bool flag2 = false;
			int num = i - 1;
			while (num >= 0 && CS$<>8__locals1.values[num].2 == 4.2)
			{
				flag2 |= !1599.<Build>g__Hidden|5_3(CS$<>8__locals1.values[num], ref CS$<>8__locals1);
				num--;
			}
			bool flag3 = 5 != null && 5.2 == 4.2;
			bool flag4 = 6 != null && 6.2 == 4.2;
			if (5 != null && 5.1 == 1604.1606.Grade && 4.1 == 1604.1606.Mods && flag3)
			{
				CS$<>8__locals1.writer.Append(' ');
				CS$<>8__locals1.writer.Append(flag ? "__" : string.Empty);
				1599.4(CS$<>8__locals1.writer, 4, 1, CS$<>8__locals1.approved, CS$<>8__locals1.info);
				CS$<>8__locals1.writer.Append(flag ? "__" : string.Empty);
			}
			else if (1599.<Build>g__IsAttribute|5_4(5) && 1599.<Build>g__IsAttribute|5_4(4) && 1599.<Build>g__IsAttribute|5_4(6) && flag3 && flag4)
			{
				CS$<>8__locals1.writer.Append(flag ? "*" : string.Empty).Append(1599.Attribute(CS$<>8__locals1.entry, 4.1)).Append(flag ? "*" : string.Empty).Append(' ');
			}
			else if (1599.<Build>g__IsAttribute|5_4(5) && 1599.<Build>g__IsAttribute|5_4(4) && flag3)
			{
				CS$<>8__locals1.writer.Append(flag ? "*" : string.Empty).Append(1599.Attribute(CS$<>8__locals1.entry, 4.1)).Append(flag ? "*" : string.Empty);
				if (4.2 < 255)
				{
					CS$<>8__locals1.writer.Append('`');
				}
			}
			else if (1599.<Build>g__IsAttribute|5_4(4) && 1599.<Build>g__IsAttribute|5_4(6) && flag4)
			{
				1599.<Build>g__Start|5_5(4, 5, flag2, true, ref CS$<>8__locals1);
				if (4.2 < 255)
				{
					CS$<>8__locals1.writer.Append('`');
				}
				CS$<>8__locals1.writer.Append(flag ? "*" : string.Empty).Append(1599.Attribute(CS$<>8__locals1.entry, 4.1)).Append(flag ? "*" : string.Empty).Append(' ');
			}
			else if (!1599.<Build>g__Hidden|5_3(4, ref CS$<>8__locals1))
			{
				1604.1607 7 = 4;
				if (4.1 == 1604.1606.Mapper && 4.9 && 1599.<Build>g__HideMapperStatus|5_2(ref CS$<>8__locals1))
				{
					7 = 4.Clone();
					7.9 = false;
				}
				1599.<Build>g__Start|5_5(4, 5, flag2, false, ref CS$<>8__locals1);
				string value = flag ? ((4.2 == byte.MaxValue) ? "*" : "__") : string.Empty;
				CS$<>8__locals1.writer.Append(value);
				1599.4(CS$<>8__locals1.writer, 7, 1, CS$<>8__locals1.approved, CS$<>8__locals1.info);
				CS$<>8__locals1.writer.Append(value);
			}
		}
		string text = (2.4 ? 1586.37(CS$<>8__locals1.entry) : 1586.38(CS$<>8__locals1.entry)) + ((2.5 && CS$<>8__locals1.entry.35 != null) ? (" [" + 1586.1(CS$<>8__locals1.entry.35.Value) + "★]") : string.Empty);
		217 8 = new 217();
		8["color"] = 2067276;
		8["author"] = 1586.Author(CS$<>8__locals1.entry.10);
		8["title"] = 1586.6(text, 256);
		string text2 = "fields";
		217 9 = new 217();
		9["name"] = 1586.6(stringBuilder.ToString(), 256);
		9["value"] = 1586.6(CS$<>8__locals1.value.ToString(), 1024);
		9["inline"] = false;
		8[text2] = new 109(9);
		217 10 = 8;
		if (CS$<>8__locals1.footer.Length > 0)
		{
			10["footer"] = 1586.14(CS$<>8__locals1.footer.ToString(), 1586.43(CS$<>8__locals1.entry.10));
		}
		if (CS$<>8__locals1.entry.4 > 0)
		{
			10["url"] = 244.3(CS$<>8__locals1.entry.4);
		}
		if (CS$<>8__locals1.entry.5 > 0)
		{
			1604.1605 11 = 2.6;
			if (11 != 1604.1605.Thumbnail)
			{
				if (11 == 1604.1605.Image)
				{
					217 12 = 10;
					string text3 = "image";
					217 13 = new 217();
					13["url"] = 244.5(CS$<>8__locals1.entry.5);
					12[text3] = 13;
				}
			}
			else
			{
				217 14 = 10;
				string text4 = "thumbnail";
				217 15 = new 217();
				15["url"] = 244.4(CS$<>8__locals1.entry.5);
				14[text4] = 15;
			}
		}
		Func<1599.1600, string> 16 = 1.4;
		string text5 = (16 != null) ? 16(1) : null;
		if (!string.IsNullOrEmpty(text5))
		{
			10["description"] = "__**" + text5 + "**__";
		}
		return 10;
	}

	// Token: 0x06004730 RID: 18224 RVA: 0x001C1A38 File Offset: 0x001BFC38
	private static string Attribute(2228.2229 1, 1604.1606 2)
	{
		switch (2)
		{
		case 1604.1606.Ar:
			return 1586.26(1, 1928.ApproachRate, "AR");
		case 1604.1606.Cs:
			return 1586.26(1, 1928.CircleSize, "CS");
		case 1604.1606.Hp:
			return 1586.26(1, 1928.DrainRate, "HP");
		default:
			return 1586.26(1, 1928.OverallDifficulty, "OD");
		}
	}

	// Token: 0x06004731 RID: 18225 RVA: 0x001C1A90 File Offset: 0x001BFC90
	private static void 4(StringBuilder 1, 1604.1607 2, 1599.1600 3, int 4, 1586.1587 5)
	{
		2228.2229 6 = 3.1;
		bool flag = 2.2 == byte.MaxValue;
		string value = flag ? string.Empty : "**";
		switch (2.1)
		{
		case 1604.1606.Grade:
		{
			string text = 6.29 ? 6.28 : "F";
			1.Append(flag ? text : 1586.12(text));
			if (!6.29 && 6.10 != 2147.CatchTheBeat)
			{
				int value2 = (6.25 > 0) ? (100 * 6.TotalHits / 6.25) : 100;
				1.Append('@').Append(value2).Append('%');
				return;
			}
			break;
		}
		case 1604.1606.Mods:
			1.Append('+').Append(1586.18(6));
			return;
		case 1604.1606.Score:
			1.Append(1586.4(6.26));
			return;
		case 1604.1606.Accuracy:
			1.Append(1586.1(6.27)).Append('%');
			return;
		case 1604.1606.ScoreDate:
			if (flag)
			{
				1.Append("Played ").Append((DateTime.UtcNow < 6.1.AddDays(1.0)) ? 1586.8(6.1) : (6.1.ToString("yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture) + " UTC"));
				return;
			}
			1.Append("<t:").Append(1586.7(6.1)).Append(":R>");
			return;
		case 1604.1606.Pp:
		{
			string value3 = flag ? string.Empty : "~~";
			double? num = (2.4 && !1586.29(6)) ? 6.33 : null;
			bool flag2 = 6.34 != null;
			string value4 = flag2 ? 1586.2(Math.Max(6.34.Value, 6.32.GetValueOrDefault())) : string.Empty;
			1.Append(value).Append((6.32 != null) ? 1586.2(6.32.Value) : "-");
			if (2.3 && flag2 && num != null)
			{
				1.Append(value).Append('/').Append(value4).Append("PP ").Append(value3).Append('(').Append(1586.2(num.Value)).Append("pp)").Append(value3);
				return;
			}
			if (flag2 && (2.3 || (2.5 && num == null)))
			{
				1.Append(value).Append('/').Append(value4).Append("PP");
				return;
			}
			if (num != null)
			{
				1.Append("pp").Append(value).Append(' ').Append(value3).Append('(').Append(1586.2(num.Value)).Append("pp)").Append(value3);
				return;
			}
			1.Append("pp").Append(value);
			return;
		}
		case 1604.1606.Combo:
			1.Append(value).Append(6.23).Append('x').Append(value);
			if (2.6)
			{
				1.Append('/').Append((6.24 > 0) ? (6.24.ToString(CultureInfo.InvariantCulture) + "x") : "-");
				return;
			}
			break;
		case 1604.1606.Hitresults:
			if (2.7)
			{
				1.Append(1586.44(6));
				return;
			}
			if (!flag)
			{
				1.Append(6.22).Append(1586.Emote("miss", " miss"));
				return;
			}
			1.Append(6.22).Append(" miss");
			return;
		case 1604.1606.Ratio:
		{
			float num2 = (float)6.20;
			int value5 = 0;
			if (6.17 > 0)
			{
				num2 /= (float)6.17;
				value5 = 1;
			}
			1.Append(num2.ToString("0.00", CultureInfo.InvariantCulture)).Append(':').Append(value5);
			return;
		}
		case 1604.1606.Stars:
			1.Append((6.35 != null) ? 1586.1(6.35.Value) : "-").Append('★');
			return;
		case 1604.1606.Length:
		{
			string value6 = flag ? string.Empty : "`";
			1.Append(value6).Append(1586.9((int)1586.28(6))).Append(value6);
			return;
		}
		case 1604.1606.Ar:
		case 1604.1606.Cs:
		case 1604.1606.Hp:
		case 1604.1606.Od:
		{
			string value7 = flag ? string.Empty : "`";
			1.Append(value7).Append(1599.Attribute(6, 2.1)).Append(value7);
			return;
		}
		case 1604.1606.Bpm:
		{
			string text2 = 1586.1(1586.27(6));
			string text3 = 1584.Emote("bpm");
			1.Append(value).Append((!2.8 && !flag && text3.Length > 0) ? (text3 + " " + text2) : (text2 + " BPM")).Append(value);
			return;
		}
		case 1604.1606.CountObjects:
			1599.5(1, 2, flag, "count_objects", "object", (int)((3.2 != null) ? (3.2.40 + 3.2.41 + 3.2.42) : 0));
			return;
		case 1604.1606.CountSliders:
		{
			bool 7 = flag;
			string 8 = "count_sliders";
			string 9 = "slider";
			1262 10 = 3.2;
			1599.5(1, 2, 7, 8, 9, (int)((10 != null) ? 10.41 : 0));
			return;
		}
		case 1604.1606.CountSpinners:
		{
			bool 11 = flag;
			string 12 = "count_spinners";
			string 13 = "spinner";
			1262 14 = 3.2;
			1599.5(1, 2, 11, 12, 13, (int)((14 != null) ? 14.42 : 0));
			return;
		}
		case 1604.1606.MapRankedDate:
		{
			DateTime? dateTime = (5 != null) ? 5.2 : null;
			if (dateTime != null)
			{
				DateTime valueOrDefault = dateTime.GetValueOrDefault();
				string text4 = 1586.51(4);
				if (text4 != null)
				{
					1.Append(text4).Append(' ');
				}
				if (DateTime.UtcNow < valueOrDefault.AddDays(1.0))
				{
					1.Append(flag ? 1586.8(valueOrDefault) : ("<t:" + 1586.7(valueOrDefault) + ":R>"));
					return;
				}
				1.Append(flag ? (valueOrDefault.ToString("yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture) + " UTC") : ("<t:" + 1586.7(valueOrDefault) + ":f>"));
				return;
			}
			break;
		}
		case 1604.1606.Mapper:
		{
			string text5 = 2.9 ? 1586.51(4) : null;
			1.Append((text5 != null) ? (text5 + " mapset by ") : "Mapset by ").Append(6.9 ?? string.Empty);
			break;
		}
		default:
			return;
		}
	}

	// Token: 0x06004732 RID: 18226 RVA: 0x001C21AC File Offset: 0x001C03AC
	private static void 5(StringBuilder 1, 1604.1607 2, bool 3, string 4, string 5, int 6)
	{
		string text = 1584.Emote(4);
		if (!2.8 && !3 && text.Length > 0)
		{
			1.Append(text).Append(' ').Append(6);
			return;
		}
		1.Append(6).Append(' ').Append(5).Append((6 == 1) ? string.Empty : "s");
	}

	// Token: 0x06004733 RID: 18227 RVA: 0x001C2218 File Offset: 0x001C0418
	internal static string 6(2228.2229 1, 1262 2)
	{
		2210.2216 3 = 2210.4(4.10);
		List<2210.2214> list = (3 != null) ? 3.9 : null;
		if (4.32 == null || list == null)
		{
			return null;
		}
		List<2210.2214> list2 = (from 1 in list
		where !1.7
		select 1).Take(100).ToList<2210.2214>();
		double pp = 4.32.Value;
		int num = list2.Count((2210.2214 1) => 1.4 > pp);
		if (num >= 100)
		{
			return null;
		}
		int num2 = 1586.Approved(4, 2);
		if (num2 != 1 && num2 != 2)
		{
			return "Personal Best #" + (num + 1).ToString() + " (if ranked)";
		}
		int num3 = num;
		while (num3 < list2.Count && list2[num3].4 <= pp)
		{
			if (1599.7(list2[num3], 4))
			{
				return "Personal Best #" + (num3 + 1).ToString();
			}
			num3++;
		}
		if (list2.Take(num).Any((2210.2214 1) => 1.2 == 4.3 || (4.4 > 0 && 1.9 == 4.4)))
		{
			return null;
		}
		return "Personal Best #" + (num + 1).ToString();
	}

	// Token: 0x06004734 RID: 18228 RVA: 0x001C2388 File Offset: 0x001C0588
	private static bool 7(2210.2214 1, 2228.2229 2)
	{
		2241 3 = 1.1;
		return 3 != null && 1.2 == 2.3 && (long)3.GetScore() == 2.26 && 3.13 == 2.23 && (int)3.2 == 2.17 && (int)3.1 == 2.18 && (int)3.3 == 2.19 && (int)3.6 == 2.22;
	}

	// Token: 0x06004735 RID: 18229 RVA: 0x001C240C File Offset: 0x001C060C
	internal static void 8(217 1, List<1599.1600> 2, int 3, string 4, int 5, bool 6 = false)
	{
		1589.Start(7, 8.Count, 1, 3, delegate(1589.1590 1, 217 2)
		{
			1599.1600 item = 8[1.3];
			1599.1(item, delegate
			{
				217 10;
				try
				{
					217 9 = new 217();
					9["content"] = ((4 != null && (5 < 0 || 5 == 1.3)) ? 4 : string.Empty);
					9["embeds"] = new 109(1599.2(item));
					9["components"] = (1604.Current.7 ? 1589.Buttons(1) : new 109());
					10 = 9;
				}
				catch (Exception ex)
				{
					1338.4(ex, "building a score embed", 1341.Runtime);
					10 = 1586.57("Something went wrong.");
					10["components"] = new 109();
				}
				1589.Edit(1, 2, 10, null, null);
			});
		}, null, 6);
	}

	// Token: 0x06004736 RID: 18230 RVA: 0x001C2458 File Offset: 0x001C0658
	[CompilerGenerated]
	internal static bool <Build>g__HideRatio|5_0(ref 1599.<>c__DisplayClass5_0 1)
	{
		return 1.entry.10 != 2147.OsuMania && 1.mark == -1;
	}

	// Token: 0x06004737 RID: 18231 RVA: 0x001C2473 File Offset: 0x001C0673
	[CompilerGenerated]
	internal static bool <Build>g__HideRankedDate|5_1(ref 1599.<>c__DisplayClass5_0 1)
	{
		1586.1587 info = 1.info;
		return info == null || info.2 == null;
	}

	// Token: 0x06004738 RID: 18232 RVA: 0x001C2490 File Offset: 0x001C0690
	[CompilerGenerated]
	internal static bool <Build>g__HideMapperStatus|5_2(ref 1599.<>c__DisplayClass5_0 1)
	{
		if (2.approved >= 1 && 2.approved <= 4)
		{
			1586.1587 info = 2.info;
			if (info != null && info.2 != null)
			{
				return 2.values.Any((1604.1607 1) => 1.1 == 1604.1606.MapRankedDate);
			}
		}
		return false;
	}

	// Token: 0x06004739 RID: 18233 RVA: 0x001C24F4 File Offset: 0x001C06F4
	[CompilerGenerated]
	internal static bool <Build>g__Hidden|5_3(1604.1607 1, ref 1599.<>c__DisplayClass5_0 2)
	{
		return (1.1 == 1604.1606.Ratio && 1599.<Build>g__HideRatio|5_0(ref 2)) || (1.1 == 1604.1606.MapRankedDate && 1599.<Build>g__HideRankedDate|5_1(ref 2));
	}

	// Token: 0x0600473A RID: 18234 RVA: 0x001C251B File Offset: 0x001C071B
	[CompilerGenerated]
	internal static bool <Build>g__IsAttribute|5_4(1604.1607 1)
	{
		return 1 != null && (1.1 == 1604.1606.Ar || 1.1 == 1604.1606.Cs || 1.1 == 1604.1606.Hp || 1.1 == 1604.1606.Od);
	}

	// Token: 0x0600473B RID: 18235 RVA: 0x001C254C File Offset: 0x001C074C
	[CompilerGenerated]
	internal static void <Build>g__Start|5_5(1604.1607 1, 1604.1607 2, bool 3, bool 4, ref 1599.<>c__DisplayClass5_0 5)
	{
		if (3)
		{
			5.writer.Append((1.2 == 0) ? "\t" : " • ");
			return;
		}
		if (1.2 == 255)
		{
			5.writer = 5.footer;
			return;
		}
		if (2 != null && 2.2 == 0)
		{
			5.writer = 5.value;
			return;
		}
		if (2 != null || 4)
		{
			5.writer.Append('\n');
		}
	}

	// Token: 0x04003415 RID: 13333
	internal const int 1 = -1;

	// Token: 0x04003416 RID: 13334
	internal const int 2 = -2;

	// Token: 0x020009F7 RID: 2551
	internal sealed class 1600
	{
		// Token: 0x04003417 RID: 13335
		public 2228.2229 1;

		// Token: 0x04003418 RID: 13336
		public 1262 2;

		// Token: 0x04003419 RID: 13337
		public 2241 3;

		// Token: 0x0400341A RID: 13338
		public Func<1599.1600, string> 4;

		// Token: 0x0400341B RID: 13339
		public int 5;
	}
}
