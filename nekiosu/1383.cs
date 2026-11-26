using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

// Token: 0x02000A92 RID: 2706
internal static class 1383
{
	// Token: 0x06004B11 RID: 19217 RVA: 0x001DBE18 File Offset: 0x001DA018
	internal static List<1383.1384> Get()
	{
		1320<string> <<EMPTY_NAME>> = 1304.47;
		string text = ((<<EMPTY_NAME>> != null) ? <<EMPTY_NAME>>.GetValue() : null) ?? string.Empty;
		if (text != 1383.4)
		{
			1383.5 = 1383.5(text);
			1383.4 = text;
		}
		return (from 1 in 1383.5
		select new 1383.1384
		{
			1 = 1.1,
			2 = 1.2,
			3 = 1.3
		}).ToList<1383.1384>();
	}

	// Token: 0x06004B12 RID: 19218 RVA: 0x001DBE88 File Offset: 0x001DA088
	internal static void Set(List<1383.1384> 1)
	{
		string value = string.Join(";", from 1 in (from 1 in 3
		where !double.IsNaN(1.1) && !double.IsNaN(1.2)
		select 1).Take(6)
		select string.Concat(new string[]
		{
			1383.4(1.1),
			"-",
			1383.4(1.2),
			"=",
			1383.4(1.3)
		}));
		1320<string> 2 = 1304.47;
		if (2 == null)
		{
			return;
		}
		2.SetValue(value);
	}

	// Token: 0x06004B13 RID: 19219 RVA: 0x001DBF00 File Offset: 0x001DA100
	internal static double 1()
	{
		double? num = 1355.Get(1272.5());
		if (num != null)
		{
			return num.Value;
		}
		1383.1384 <<EMPTY_NAME>> = 1383.2();
		if (<<EMPTY_NAME>> != null)
		{
			return Math.Max(0.1, Math.Min(3.0, <<EMPTY_NAME>>.3));
		}
		2241 2 = 2486.88;
		2147? 3 = (2 != null) ? new 2147?(2.9) : null;
		if (1383.Get().Count != 0 && 3.GetValueOrDefault() != 2147.Taiko && 3.GetValueOrDefault() != 2147.OsuMania)
		{
			return 1.0;
		}
		return 1304.46.GetValue();
	}

	// Token: 0x06004B14 RID: 19220 RVA: 0x001DBFA8 File Offset: 0x001DA1A8
	internal static 1383.1384 2()
	{
		2241 <<EMPTY_NAME>> = 2486.88;
		2147? 2 = (<<EMPTY_NAME>> != null) ? new 2147?(<<EMPTY_NAME>>.9) : null;
		if (2.GetValueOrDefault() == 2147.Taiko || 2.GetValueOrDefault() == 2147.OsuMania)
		{
			return null;
		}
		double? approachRate = 1383.3();
		if (approachRate == null)
		{
			return null;
		}
		return 1383.Get().FirstOrDefault((1383.1384 1) => 1.1(approachRate.Value));
	}

	// Token: 0x06004B15 RID: 19221 RVA: 0x001DC020 File Offset: 0x001DA220
	internal static double? 3()
	{
		2241 <<EMPTY_NAME>> = 2486.88;
		if (<<EMPTY_NAME>> == null)
		{
			return null;
		}
		if (<<EMPTY_NAME>> == 1383.6)
		{
			return 1383.7;
		}
		2486 2 = 2486.7;
		2039 3 = (2 != null) ? 2.39 : null;
		1262 4 = 1272.5();
		if (3 == null || 4 == null)
		{
			return null;
		}
		1383.6 = <<EMPTY_NAME>>;
		1383.7 = null;
		if (<<EMPTY_NAME>>.9 != 2147.Osu && <<EMPTY_NAME>>.9 != 2147.CatchTheBeat)
		{
			return null;
		}
		float num = 3.16(1928.ApproachRate, 4.1);
		if (1926.1(num))
		{
			return null;
		}
		2023 5 = <<EMPTY_NAME>>.8;
		double num2 = 2039.22((double)num, 1.4, 5);
		double num3 = 1939.17(5, <<EMPTY_NAME>>.44);
		if (num3 != 1.0)
		{
			double num4 = ((num2 > 5.0) ? (1200.0 - 750.0 * (num2 - 5.0) / 5.0) : (1200.0 + 600.0 * (5.0 - num2) / 5.0)) / num3;
			num2 = ((num4 > 1200.0) ? (5.0 - (num4 - 1200.0) / 120.0) : (5.0 + (1200.0 - num4) / 150.0));
		}
		1383.7 = new double?(Math.Round(num2, 2));
		return 1383.7;
	}

	// Token: 0x06004B16 RID: 19222 RVA: 0x001DC1D8 File Offset: 0x001DA3D8
	internal static string 4(double 1)
	{
		return Math.Round(1, 2).ToString("0.0#", CultureInfo.InvariantCulture);
	}

	// Token: 0x06004B17 RID: 19223 RVA: 0x001DC200 File Offset: 0x001DA400
	private static List<1383.1384> 5(string 1)
	{
		List<1383.1384> list = new List<1383.1384>();
		foreach (string text in (1 ?? string.Empty).Split(new char[]
		{
			';'
		}, StringSplitOptions.RemoveEmptyEntries))
		{
			int num = text.IndexOf('=');
			int num2 = (num > 1) ? text.IndexOf('-', 1) : -1;
			double d;
			double d2;
			double num3;
			if (num2 > 0 && num2 < num && double.TryParse(text.Substring(0, num2), NumberStyles.Float, CultureInfo.InvariantCulture, out d) && double.TryParse(text.Substring(num2 + 1, num - num2 - 1), NumberStyles.Float, CultureInfo.InvariantCulture, out d2) && double.TryParse(text.Substring(num + 1), NumberStyles.Float, CultureInfo.InvariantCulture, out num3) && !double.IsNaN(d) && !double.IsNaN(d2) && !double.IsNaN(num3) && !double.IsInfinity(d) && !double.IsInfinity(d2) && !double.IsInfinity(num3))
			{
				list.Add(new 1383.1384
				{
					1 = d,
					2 = d2,
					3 = Math.Max(0.1, Math.Min(3.0, num3))
				});
				if (list.Count == 6)
				{
					break;
				}
			}
		}
		return list;
	}

	// Token: 0x04003800 RID: 14336
	internal const int 1 = 6;

	// Token: 0x04003801 RID: 14337
	internal const double 2 = 0.1;

	// Token: 0x04003802 RID: 14338
	internal const double 3 = 3.0;

	// Token: 0x04003803 RID: 14339
	private static string 4;

	// Token: 0x04003804 RID: 14340
	private static List<1383.1384> 5 = new List<1383.1384>();

	// Token: 0x04003805 RID: 14341
	private static 2241 6;

	// Token: 0x04003806 RID: 14342
	private static double? 7;

	// Token: 0x02000A93 RID: 2707
	internal sealed class 1384
	{
		// Token: 0x06004B19 RID: 19225 RVA: 0x001DC364 File Offset: 0x001DA564
		public bool 1(double 1)
		{
			return 1 >= Math.Min(this.1, this.2) - 0.0001 && 1 <= Math.Max(this.1, this.2) + 0.0001;
		}

		// Token: 0x04003807 RID: 14343
		public double 1;

		// Token: 0x04003808 RID: 14344
		public double 2;

		// Token: 0x04003809 RID: 14345
		public double 3;
	}
}
