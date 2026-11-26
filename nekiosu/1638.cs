using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

// Token: 0x020009A2 RID: 2466
internal static class 1638
{
	// Token: 0x06004524 RID: 17700 RVA: 0x001B31EC File Offset: 0x001B13EC
	public static string 1(int 1, string 2, string 3, string 4, int 5, DateTime? 6, bool 7, bool 8, IEnumerable<string> 9)
	{
		string text = (6 ?? DateTime.UtcNow).ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
		return string.Join("|", new string[]
		{
			1.ToString() + ".osz",
			1638.5(2),
			1638.5(3),
			1638.5(4),
			5.ToString(CultureInfo.InvariantCulture),
			"10.00",
			text,
			1.ToString(CultureInfo.InvariantCulture),
			"0",
			7 ? "1" : "0",
			8 ? "1" : "0",
			"0",
			"0",
			string.Join(",", 9 ?? Enumerable.Empty<string>())
		});
	}

	// Token: 0x06004525 RID: 17701 RVA: 0x001B32EC File Offset: 0x001B14EC
	public static string Difficulty(string 1, double 2, int 3)
	{
		return string.Concat(new string[]
		{
			1638.5(1).Replace(",", " ").Replace("@", " "),
			" ★",
			2.ToString("0.00", CultureInfo.InvariantCulture),
			"@",
			3.ToString(CultureInfo.InvariantCulture)
		});
	}

	// Token: 0x06004526 RID: 17702 RVA: 0x001B3360 File Offset: 0x001B1560
	public static string 2(IList<string> 1, bool 2)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(2 ? Math.Max(101, 1.Count) : Math.Min(100, 1.Count)).Append('\n');
		foreach (string value in 1.Take(100))
		{
			stringBuilder.Append(value).Append('\n');
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06004527 RID: 17703 RVA: 0x001B33F0 File Offset: 0x001B15F0
	public static int[] 3(int 1)
	{
		switch (1)
		{
		case 0:
		case 7:
			return new int[]
			{
				1,
				2
			};
		case 2:
			return new int[]
			{
				0,
				-1
			};
		case 3:
			return new int[]
			{
				3
			};
		case 5:
			return new int[]
			{
				-2
			};
		case 8:
			return new int[]
			{
				4
			};
		}
		return new int[0];
	}

	// Token: 0x06004528 RID: 17704 RVA: 0x001B346B File Offset: 0x001B166B
	public static bool 4(string 1, out string 2)
	{
		2 = ((1 == "Newest" || 1 == "Top Rated" || 1 == "Most Played") ? 1 : null);
		return 2 != null;
	}

	// Token: 0x06004529 RID: 17705 RVA: 0x001B349F File Offset: 0x001B169F
	private static string 5(string 1)
	{
		return (1 ?? string.Empty).Replace('|', '/').Replace('\r', ' ').Replace('\n', ' ');
	}

	// Token: 0x0600452A RID: 17706 RVA: 0x001B34C8 File Offset: 0x001B16C8
	public static 226 6(string 1)
	{
		if (string.IsNullOrWhiteSpace(1))
		{
			return null;
		}
		226 result;
		try
		{
			result = 226.Parse(1);
		}
		catch (Exception)
		{
			result = null;
		}
		return result;
	}

	// Token: 0x0600452B RID: 17707 RVA: 0x001B3500 File Offset: 0x001B1700
	public static int Approved(226 1)
	{
		int? num = (int?)((1 != null) ? 1["ranked"] : null);
		if (num != null)
		{
			return num.Value;
		}
		string a = (string)((1 != null) ? 1["status"] : null);
		if (a == "graveyard")
		{
			return -2;
		}
		if (a == "wip")
		{
			return -1;
		}
		if (a == "ranked")
		{
			return 1;
		}
		if (a == "approved")
		{
			return 2;
		}
		if (a == "qualified")
		{
			return 3;
		}
		if (!(a == "loved"))
		{
			return 0;
		}
		return 4;
	}

	// Token: 0x0600452C RID: 17708 RVA: 0x001B35AC File Offset: 0x001B17AC
	public static DateTime? Date(226 1)
	{
		if (1 == null || 1.Type == 705.Null)
		{
			return null;
		}
		if (1.Type == 705.Date)
		{
			return new DateTime?(((DateTime)1).ToUniversalTime());
		}
		if (1.Type == 705.Integer)
		{
			return new DateTime?(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds((double)((long)1)));
		}
		DateTime value;
		if (!DateTime.TryParse((string)1, CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal | DateTimeStyles.AssumeUniversal, out value))
		{
			return null;
		}
		return new DateTime?(value);
	}

	// Token: 0x0600452D RID: 17709 RVA: 0x001B3644 File Offset: 0x001B1844
	public static string 7(226 1)
	{
		int valueOrDefault = ((int?)((5 != null) ? 5["id"] : null)).GetValueOrDefault();
		if (valueOrDefault <= 0)
		{
			return null;
		}
		109 2 = 5["beatmaps"] as 109;
		787<226>? 3 = (2 != null) ? new 787<226>?(2.Children()) : null;
		IEnumerable<226> source;
		if (3 == null)
		{
			source = Enumerable.Empty<226>();
		}
		else
		{
			IEnumerable<226> enumerable = 3.GetValueOrDefault();
			source = enumerable;
		}
		IEnumerable<string> 4 = from 1 in source
		orderby ((int?)1["mode_int"]).GetValueOrDefault(), ((double?)1["difficulty_rating"]).GetValueOrDefault()
		select 1638.Difficulty((string)1["version"], ((double?)1["difficulty_rating"]).GetValueOrDefault(), ((int?)1["mode_int"]).GetValueOrDefault());
		return 1638.1(valueOrDefault, (string)5["artist"], (string)5["title"], (string)5["creator"], 1638.Approved(5), 1638.Date(5["last_updated"]), ((bool?)5["video"]).GetValueOrDefault(), ((bool?)5["storyboard"]).GetValueOrDefault(), 4);
	}

	// Token: 0x0600452E RID: 17710 RVA: 0x001B37B0 File Offset: 0x001B19B0
	public static string 8(string 1, int 2)
	{
		109 3 = 1638.6(4) as 109;
		if (3 == null)
		{
			return null;
		}
		IEnumerable<226> source = 3;
		Func<226, string> selector;
		if ((selector = 1638.<>O.<0>__V2SetLine) == null)
		{
			selector = (1638.<>O.<0>__V2SetLine = new Func<226, string>(1638.7));
		}
		return 1638.2((from 1 in source.Select(selector)
		where 1 != null
		select 1).ToList<string>(), 3.Count >= 2);
	}

	// Token: 0x0600452F RID: 17711 RVA: 0x001B382C File Offset: 0x001B1A2C
	public static 226 9(226 1)
	{
		if (1 is 217 && 1["beatmaps"] is 109)
		{
			return 1;
		}
		217 2 = ((1 != null) ? 1["set"] : null) as 217;
		if (2 == null || !(2["beatmaps"] is 109))
		{
			return null;
		}
		return 2;
	}

	// Token: 0x06004530 RID: 17712 RVA: 0x001B3884 File Offset: 0x001B1A84
	public static string 10(226 1, int 2, string 3)
	{
		109 4 = new 109();
		109 5 = ((1 != null) ? 1["beatmaps"] : null) as 109;
		787<226>? 6 = (5 != null) ? new 787<226>?(5.Children()) : null;
		IEnumerable<226> enumerable;
		if (6 == null)
		{
			enumerable = Enumerable.Empty<226>();
		}
		else
		{
			IEnumerable<226> enumerable2 = 6.GetValueOrDefault();
			enumerable = enumerable2;
		}
		foreach (226 7 in enumerable)
		{
			int valueOrDefault = ((int?)7["id"]).GetValueOrDefault();
			string text = (string)7["checksum"];
			if ((2 <= 0 || valueOrDefault == 2) && (string.IsNullOrEmpty(3) || string.Equals(text, 3, StringComparison.OrdinalIgnoreCase)))
			{
				int 8 = (7["ranked"] != null || 7["status"] != null) ? 1638.Approved(7) : 1638.Approved(1);
				109 9 = 4;
				217 10 = new 217();
				10["beatmapset_id"] = ((int?)1["id"]).GetValueOrDefault();
				10["beatmap_id"] = valueOrDefault;
				10["approved"] = 8;
				10["file_md5"] = text;
				10["version"] = (string)7["version"];
				10["mode"] = ((int?)7["mode_int"]).GetValueOrDefault();
				10["difficultyrating"] = ((double?)7["difficulty_rating"]).GetValueOrDefault();
				10["artist"] = (string)1["artist"];
				10["title"] = (string)1["title"];
				10["creator"] = (string)1["creator"];
				10["last_update"] = (string)7["last_updated"];
				DateTime? dateTime;
				10["approved_date"] = ((1638.Date(1["ranked_date"]) != null) ? dateTime.GetValueOrDefault().ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture) : null);
				9.Add(10);
			}
		}
		return 4.ToString((95)0, Array.Empty<214>());
	}

	// Token: 0x06004531 RID: 17713 RVA: 0x001B3B60 File Offset: 0x001B1D60
	public static string 11(string 1, int 2, string 3)
	{
		109 4 = 1638.6(5) as 109;
		if (4 == null)
		{
			return null;
		}
		if (2 <= 0 && string.IsNullOrEmpty(3))
		{
			return 5;
		}
		return new 109(from 1 in 4
		where (2 <= 0 || ((int?)1["beatmap_id"]).GetValueOrDefault() == 2) && (string.IsNullOrEmpty(3) || string.Equals((string)1["file_md5"], 3, StringComparison.OrdinalIgnoreCase))
		select 1).ToString((95)0, Array.Empty<214>());
	}

	// Token: 0x020009A3 RID: 2467
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x040032B8 RID: 12984
		public static Func<226, string> <0>__V2SetLine;
	}
}
