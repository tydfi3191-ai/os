using System;
using System.Collections.Generic;
using System.Globalization;

// Token: 0x02000513 RID: 1299
[276]
internal sealed class 2497 : 2503
{
	// Token: 0x060027AA RID: 10154 RVA: 0x000C6D1C File Offset: 0x000C4F1C
	internal 2497(2511 1, 2528 2) : base(1, 2)
	{
		2.8(2530.3("attribute", "Attribute", "The value of the beatmap shown.", "StarRating", 2497.10, 2497.11));
		2.8(2530.Text("template", "Template", "Supports {Label} and {Value}, but also any attribute by name, like {StarRating} (see the attribute list).", "{Label}: {Value}", 120));
		base.6();
	}

	// Token: 0x060027AB RID: 10155 RVA: 0x000C6D94 File Offset: 0x000C4F94
	protected override string GetText()
	{
		if (this.12.Count == 0 || (!this.13 && 2206.IsReady))
		{
			this.10();
		}
		string text = this.2.10("attribute");
		int num = Array.IndexOf<string>(2497.10, text);
		string text2 = this.2.10("template");
		string text3;
		text2 = text2.Replace("{Label}", (num >= 0) ? 2497.11[num] : text).Replace("{Value}", this.12.TryGetValue(text, out text3) ? text3 : string.Empty);
		foreach (string text4 in 2497.10)
		{
			string text5;
			text2 = text2.Replace("{" + text4 + "}", this.12.TryGetValue(text4, out text5) ? text5 : string.Empty);
		}
		if (text2.Length != 0)
		{
			return text2;
		}
		return " ";
	}

	// Token: 0x060027AC RID: 10156 RVA: 0x000C6E90 File Offset: 0x000C5090
	private void 10()
	{
		1262 <<EMPTY_NAME>> = 1272.5();
		2039 2 = this.1.2.39;
		2241 3 = 2486.88;
		if (<<EMPTY_NAME>> == null || 2 == null || 3 == null)
		{
			return;
		}
		2023 4 = 3.8;
		double 5 = this.1.8;
		double 6 = 2039.22((double)2.16(1928.CircleSize, <<EMPTY_NAME>>.2), 1.3, 4);
		double 7 = 2039.22((double)2.16(1928.DrainRate, <<EMPTY_NAME>>.3), 1.4, 4);
		double num = 2039.22((double)2.16(1928.ApproachRate, <<EMPTY_NAME>>.1), 1.4, 4);
		double num2 = 2039.22((double)2.16(1928.OverallDifficulty, <<EMPTY_NAME>>.4), 1.4, 4);
		if (5 != 1.0)
		{
			double num3 = ((num > 5.0) ? (1200.0 - 750.0 * (num - 5.0) / 5.0) : (1200.0 + 600.0 * (5.0 - num) / 5.0)) / 5;
			num = ((num3 > 1200.0) ? (5.0 - (num3 - 1200.0) / 120.0) : (5.0 + (1200.0 - num3) / 150.0));
			num2 = (80.0 - (80.0 - 6.0 * num2) / 5) / 6.0;
		}
		this.12["CircleSize"] = 2497.11(6);
		this.12["HPDrain"] = 2497.11(7);
		this.12["Accuracy"] = 2497.11(num2);
		this.12["ApproachRate"] = (1926.1(2.16(1928.ApproachRate, <<EMPTY_NAME>>.1)) ? "-inf" : 2497.11(num));
		this.12["Title"] = (<<EMPTY_NAME>>.10 ?? string.Empty);
		this.12["Artist"] = (<<EMPTY_NAME>>.7 ?? string.Empty);
		this.12["DifficultyName"] = (<<EMPTY_NAME>>.89 ?? string.Empty);
		this.12["Creator"] = (<<EMPTY_NAME>>.43 ?? string.Empty);
		this.12["Source"] = (<<EMPTY_NAME>>.82 ?? string.Empty);
		this.12["RankedStatus"] = 2497.12((int)<<EMPTY_NAME>>.85);
		this.12["BPM"] = 2497.11((double)<<EMPTY_NAME>>.86().Z * 5);
		int num4 = (2.34.Count > 0) ? 2.34[0].1 : 0;
		int num5 = (2.34.Count > 0) ? 2.34[2.34.Count - 1].2 : 0;
		this.12["Length"] = 2511.14((int)Math.Round((double)(num5 - num4) / 5 / 1000.0));
		this.12["StarRating"] = "0.00";
		this.12["MaxPP"] = "0";
		this.13 = false;
		1890 8 = 2206.IsReady ? 2206.6(double.MaxValue) : null;
		if (8 != null)
		{
			this.12["StarRating"] = 2237.StarRating(8).ToString("0.00", CultureInfo.InvariantCulture);
			double value = 2237.6(8, 4);
			this.12["MaxPP"] = Math.Round(value, MidpointRounding.AwayFromZero).ToString("0", CultureInfo.InvariantCulture);
			this.13 = true;
		}
	}

	// Token: 0x060027AD RID: 10157 RVA: 0x000C72D9 File Offset: 0x000C54D9
	private static string 11(double 1)
	{
		return 1.ToString("0.##", CultureInfo.InvariantCulture);
	}

	// Token: 0x060027AE RID: 10158 RVA: 0x000C72EC File Offset: 0x000C54EC
	private static string 12(int 1)
	{
		switch (1)
		{
		case 1:
			return "Not submitted";
		case 2:
			return "Pending";
		case 4:
			return "Ranked";
		case 5:
			return "Approved";
		case 6:
			return "Qualified";
		case 7:
			return "Loved";
		}
		return "Unknown";
	}

	// Token: 0x04001CA1 RID: 7329
	private static readonly string[] 10 = new string[]
	{
		"CircleSize",
		"HPDrain",
		"Accuracy",
		"ApproachRate",
		"StarRating",
		"Title",
		"Artist",
		"DifficultyName",
		"Creator",
		"Length",
		"RankedStatus",
		"BPM",
		"Source",
		"MaxPP"
	};

	// Token: 0x04001CA2 RID: 7330
	private static readonly string[] 11 = new string[]
	{
		"Circle Size",
		"HP Drain",
		"Accuracy",
		"Approach Rate",
		"Star Rating",
		"Title",
		"Artist",
		"Difficulty",
		"Creator",
		"Length",
		"Status",
		"BPM",
		"Source",
		"Max PP"
	};

	// Token: 0x04001CA3 RID: 7331
	private readonly Dictionary<string, string> 12 = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

	// Token: 0x04001CA4 RID: 7332
	private bool 13;
}
