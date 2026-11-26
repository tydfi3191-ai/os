using System;
using System.Collections.Generic;

// Token: 0x02000503 RID: 1283
[276]
internal sealed class 2511 : IDisposable
{
	// Token: 0x17000258 RID: 600
	// (get) Token: 0x06002744 RID: 10052 RVA: 0x000C39F6 File Offset: 0x000C1BF6
	internal string Performance
	{
		get
		{
			2538 <<EMPTY_NAME>> = this.6;
			return ((<<EMPTY_NAME>> != null) ? <<EMPTY_NAME>>.Text : null) ?? "0";
		}
	}

	// Token: 0x06002745 RID: 10053 RVA: 0x000C3A14 File Offset: 0x000C1C14
	internal 2511(2486 1, 1436 2, 2541 3, 2538 4)
	{
		this.2 = 9;
		this.1 = 10;
		this.6 = 4;
		2241 5 = 2486.88;
		this.8 = ((5 != null) ? 1939.17(5.8, 5.44) : 1.0);
		float windowWidth = 2528.WindowWidth;
		208 6 = new 208(windowWidth - 8f, 80f);
		208 7;
		float num;
		if (3 != null && 3.1(out 7, out num))
		{
			6 = new 208(windowWidth - 7.X, 7.Y);
			this.7 = num;
		}
		this.1("pp", "PP counter", "Performance points so far", 2509.TopRight, 6, (2511 1, 2528 2) => new 2501(1, 2, 2501.2502.Performance));
		this.1("iffc", "If-FC pp", "pp of a full combo with these hits", 2509.TopRight, new 208(windowWidth - 8f, 140f), (2511 1, 2528 2) => new 2501(1, 2, 2501.2502.IfFullCombo));
		this.1("stars", "Star rating so far", "Star rating of the map up to now", 2509.TopRight, new 208(windowWidth - 8f, 110f), (2511 1, 2528 2) => new 2501(1, 2, 2501.2502.Stars));
		this.1("ur", "Unstable rate", "Unstable rate (speed adjusted)", 2509.BottomCentre, new 208(windowWidth / 2f, 430f), (2511 1, 2528 2) => new 2501(1, 2, 2501.2502.UnstableRate));
		this.1("bpm", "BPM", "Current BPM", 2509.BottomRight, new 208(windowWidth - 8f, 400f), (2511 1, 2528 2) => new 2501(1, 2, 2501.2502.Bpm));
		this.1("kps", "Clicks per second", "Clicks in the last second", 2509.BottomRight, new 208(windowWidth - 8f, 365f), (2511 1, 2528 2) => new 2501(1, 2, 2501.2502.Clicks));
		this.1("timeleft", "Song time", "Time left, time passed or progress", 2509.TopCentre, new 208(windowWidth / 2f, 6f), (2511 1, 2528 2) => new 2501(1, 2, 2501.2502.SongTime));
		this.1("longestcombo", "Longest combo", "The longest combo so far", 2509.BottomLeft, new 208(8f, 395f), (2511 1, 2528 2) => new 2501(1, 2, 2501.2502.LongestCombo));
		this.1("judgements", "Judgement counter", "300 / 100 / 50 / miss counts", 2509.CentreLeft, new 208(8f, 170f), (2511 1, 2528 2) => new 2534(1, 2));
		this.1("rank", "Rank", "The grade the play is on", 2509.TopRight, new 208(windowWidth - 30f, 180f), (2511 1, 2528 2) => new 2540(1, 2));
		this.1("aimerror", "Aim error meter", "Where the hits landed on the circles", 2509.CentreRight, new 208(windowWidth - 50f, 300f), (2511 1, 2528 2) => new 2495(1, 2));
		this.3[this.3.Count - 1].7 = true;
		this.1("straingraph", "Strain graph", "How hard each part of the map is (danser's)", 2509.CentreLeft, new 208(3f, 150f), (2511 1, 2528 2) => new 2543(1, 2));
		this.1("text", "Text", "Any text, in a font of your choice", 2509.Centre, new 208(windowWidth / 2f, 200f), (2511 1, 2528 2) => new 2545(1, 2));
		this.1("beatmapinfo", "Beatmap info", "A value of the beatmap: title, star rating, length...", 2509.TopLeft, new 208(8f, 60f), (2511 1, 2528 2) => new 2497(1, 2));
		this.1("playername", "Player name", "The name of the player", 2509.TopLeft, new 208(8f, 40f), (2511 1, 2528 2) => new 2539(1, 2));
		this.1("box", "Box", "A box of one colour, to put behind other elements", 2509.Centre, new 208(windowWidth / 2f, 240f), (2511 1, 2528 2) => new 2498(1, 2));
		this.1("image", "Image", "A picture of yours (drop one on the window)", 2509.Centre, new 208(windowWidth / 2f, 240f), (2511 1, 2528 2) => new 2533(1, 2));
		foreach (2511.2512 8 in this.3)
		{
			this.Create(8, 8.1);
			foreach (string text in 2525.4(8.1))
			{
				this.Create(8, text);
			}
		}
	}

	// Token: 0x06002746 RID: 10054 RVA: 0x000C40C4 File Offset: 0x000C22C4
	private void 1(string 1, string 2, string 3, 2509 4, 208 5, Func<2511, 2528, 2510> 6)
	{
		this.3.Add(new 2511.2512
		{
			1 = 1,
			2 = 2,
			3 = 3,
			4 = 4,
			5 = 5,
			6 = 6
		});
	}

	// Token: 0x06002747 RID: 10055 RVA: 0x000C4104 File Offset: 0x000C2304
	internal 2511.2512 2(string 1)
	{
		return this.3.Find((2511.2512 1) => string.Equals(1.1, 2, StringComparison.OrdinalIgnoreCase));
	}

	// Token: 0x17000259 RID: 601
	// (get) Token: 0x06002748 RID: 10056 RVA: 0x000C4135 File Offset: 0x000C2335
	internal static 2511 Current
	{
		get
		{
			2504 <<EMPTY_NAME>> = 2504.28;
			if (<<EMPTY_NAME>> == null)
			{
				return null;
			}
			return <<EMPTY_NAME>>.13;
		}
	}

	// Token: 0x06002749 RID: 10057 RVA: 0x000C4148 File Offset: 0x000C2348
	private 2528 Create(2511.2512 1, string 2)
	{
		2528 3 = 2528.5(2, 2511.3(1, 2), 1.4, 1.5, false, 1.1);
		2510 4 = 1.6(this, 3);
		this.4[2] = 4;
		2522.3(3);
		4.Build();
		return 3;
	}

	// Token: 0x0600274A RID: 10058 RVA: 0x000C41A0 File Offset: 0x000C23A0
	private static string 3(2511.2512 1, string 2)
	{
		int num = 2.IndexOf('#');
		if (num <= 0)
		{
			return 1.2;
		}
		return 1.2 + " (" + 2.Substring(num + 1) + ")";
	}

	// Token: 0x0600274B RID: 10059 RVA: 0x000C41E0 File Offset: 0x000C23E0
	internal 2528 4(string 1)
	{
		2511.2512 2 = this.2(1);
		if (2 == null)
		{
			return null;
		}
		2528 3 = 2522.5(2.1);
		if (3 != null && !3.11)
		{
			return 3;
		}
		int num = 2;
		while (this.4.ContainsKey(2.1 + "#" + num.ToString()) || 2525.3(2.1 + "#" + num.ToString()))
		{
			num++;
		}
		return this.Create(2, 2.1 + "#" + num.ToString());
	}

	// Token: 0x0600274C RID: 10060 RVA: 0x000C427C File Offset: 0x000C247C
	internal 2528 5(string 1, string 2)
	{
		2510 3;
		if (this.4.TryGetValue(1, out 3))
		{
			return 3.2;
		}
		2511.2512 4 = this.2(2);
		if (4 != null)
		{
			return this.Create(4, 1);
		}
		return null;
	}

	// Token: 0x0600274D RID: 10061 RVA: 0x000C42B8 File Offset: 0x000C24B8
	internal void 6(2528 1)
	{
		2510 2;
		if (!1.IsExtraInstance || !this.4.TryGetValue(1.3, out 2))
		{
			return;
		}
		this.4.Remove(1.3);
		2.Dispose();
		2522.4(1);
	}

	// Token: 0x0600274E RID: 10062 RVA: 0x000C4301 File Offset: 0x000C2501
	internal bool 7(2528 1)
	{
		return this.4.ContainsKey(1.3);
	}

	// Token: 0x0600274F RID: 10063 RVA: 0x000C4314 File Offset: 0x000C2514
	internal 2510 8(2528 1)
	{
		2510 result;
		if (!this.4.TryGetValue(1.3, out result))
		{
			return null;
		}
		return result;
	}

	// Token: 0x06002750 RID: 10064 RVA: 0x000C433C File Offset: 0x000C253C
	internal void 9()
	{
		2241 <<EMPTY_NAME>> = 2486.88;
		if (<<EMPTY_NAME>> == null)
		{
			return;
		}
		this.10(<<EMPTY_NAME>>);
		this.11();
		this.12();
		this.13();
		this.15(<<EMPTY_NAME>>);
		this.16(<<EMPTY_NAME>>);
		foreach (2510 2 in this.4.Values)
		{
			2.Update();
		}
	}

	// Token: 0x06002751 RID: 10065 RVA: 0x000C43C4 File Offset: 0x000C25C4
	private void 10(2241 1)
	{
		List<int> 2 = 1.27;
		if (2 == null)
		{
			return;
		}
		if (2.Count < this.21)
		{
			this.21 = 0;
			this.22 = 0.0;
			this.23 = 0.0;
		}
		while (this.21 < 2.Count)
		{
			List<int> list = 2;
			int num = this.21;
			this.21 = num + 1;
			double num2 = (double)list[num];
			this.22 += num2;
			this.23 += num2 * num2;
		}
		double num3 = 0.0;
		if (this.21 > 0)
		{
			double num4 = this.22 / (double)this.21;
			num3 = Math.Sqrt(Math.Max(0.0, this.23 / (double)this.21 - num4 * num4)) * 10.0 / this.8;
		}
		this.9 = num3.ToString("0.00", 1662.18);
	}

	// Token: 0x06002752 RID: 10066 RVA: 0x000C44CC File Offset: 0x000C26CC
	private void 11()
	{
		1262 <<EMPTY_NAME>> = 1272.5();
		if (((<<EMPTY_NAME>> != null) ? <<EMPTY_NAME>>.94 : null) == null)
		{
			return;
		}
		int num = 1226.16;
		1259 2 = null;
		foreach (1259 3 in <<EMPTY_NAME>>.94)
		{
			if (3.1())
			{
				if (2 == null || 3.3 <= (double)num)
				{
					2 = 3;
				}
				if (3.3 > (double)num)
				{
					break;
				}
			}
		}
		if (2 != null && 2.1 > 0.0)
		{
			this.10 = Math.Round(60000.0 / 2.1 * this.8).ToString("0", 1662.18);
		}
	}

	// Token: 0x06002753 RID: 10067 RVA: 0x000C45A8 File Offset: 0x000C27A8
	private void 12()
	{
		int <<EMPTY_NAME>> = 1662.33;
		if (1535.21)
		{
			this.5.Enqueue(<<EMPTY_NAME>>);
		}
		if (1535.50)
		{
			this.5.Enqueue(<<EMPTY_NAME>>);
		}
		while (this.5.Count > 0 && <<EMPTY_NAME>> - this.5.Peek() > 1000)
		{
			this.5.Dequeue();
		}
		this.11 = this.5.Count.ToString(1662.18);
	}

	// Token: 0x06002754 RID: 10068 RVA: 0x000C4630 File Offset: 0x000C2830
	private void 13()
	{
		int replayEndTime = this.2.ReplayEndTime;
		2039 <<EMPTY_NAME>> = this.2.39;
		int num = (<<EMPTY_NAME>> != null && <<EMPTY_NAME>>.34.Count > 0) ? <<EMPTY_NAME>>.34[0].1 : 0;
		int num2 = 1226.16;
		double a = (replayEndTime > 0) ? Math.Max(0.0, (double)(replayEndTime - num2) / this.8 / 1000.0) : 0.0;
		double d = Math.Max(0.0, (double)(num2 - num) / this.8 / 1000.0);
		this.12 = 2511.14((int)Math.Ceiling(a));
		this.13 = 2511.14((int)Math.Floor(d));
		double num3 = (double)(replayEndTime - num);
		this.14 = ((num3 > 0.0) ? ((int)Math.Max(0.0, Math.Min(100.0, (double)(num2 - num) / num3 * 100.0))) : 0).ToString(1662.18) + "%";
	}

	// Token: 0x06002755 RID: 10069 RVA: 0x000C4764 File Offset: 0x000C2964
	internal static string 14(int 1)
	{
		return (1 / 60).ToString(1662.18) + ":" + (1 % 60).ToString("00", 1662.18);
	}

	// Token: 0x06002756 RID: 10070 RVA: 0x000C47A4 File Offset: 0x000C29A4
	private void 15(2241 1)
	{
		this.20[0] = (int)1.4;
		this.20[1] = (int)1.2;
		this.20[2] = (int)1.5;
		this.20[3] = (int)1.1;
		this.20[4] = (int)1.3;
		this.20[5] = (int)1.6;
		this.17 = 1.13.ToString(1662.18) + "x";
	}

	// Token: 0x06002757 RID: 10071 RVA: 0x000C4828 File Offset: 0x000C2A28
	private void 16(2241 1)
	{
		this.18 = 2206.IsSupported;
		this.19 = (this.18 && 2206.IsReady);
		if (!this.19)
		{
			return;
		}
		1890 2 = 2206.6((double)1226.16);
		if (2 != null)
		{
			this.15 = 2237.StarRating(2).ToString("0.00", 1662.18);
		}
		long num = (long)(((((ulong)1.1 * 100003UL + (ulong)1.3) * 31UL + (ulong)1.2) * 31UL + (ulong)1.4) * 31UL + (ulong)1.5);
		if (num != this.24 || !this.25)
		{
			this.24 = num;
			this.25 = true;
			double? num2 = 2206.7(1);
			if (num2 != null)
			{
				this.16 = ((int)Math.Round(num2.Value, MidpointRounding.AwayFromZero)).ToString(1662.18) + "";
			}
		}
	}

	// Token: 0x06002758 RID: 10072 RVA: 0x000C4924 File Offset: 0x000C2B24
	internal void 17(208 1, 2034 2, float 3)
	{
		foreach (2510 4 in this.4.Values)
		{
			2495 5 = 4 as 2495;
			if (5 != null)
			{
				5.9(1, 2.8, 3);
			}
		}
	}

	// Token: 0x06002759 RID: 10073 RVA: 0x000C498C File Offset: 0x000C2B8C
	internal void 18()
	{
		foreach (2510 <<EMPTY_NAME>> in this.4.Values)
		{
			2495 2 = <<EMPTY_NAME>> as 2495;
			if (2 != null)
			{
				2.12();
			}
		}
	}

	// Token: 0x0600275A RID: 10074 RVA: 0x000C49EC File Offset: 0x000C2BEC
	public void Dispose()
	{
		foreach (2510 <<EMPTY_NAME>> in this.4.Values)
		{
			<<EMPTY_NAME>>.Dispose();
		}
		this.4.Clear();
	}

	// Token: 0x04001C40 RID: 7232
	internal readonly 1436 1;

	// Token: 0x04001C41 RID: 7233
	internal readonly 2486 2;

	// Token: 0x04001C42 RID: 7234
	internal readonly List<2511.2512> 3 = new List<2511.2512>();

	// Token: 0x04001C43 RID: 7235
	private readonly Dictionary<string, 2510> 4 = new Dictionary<string, 2510>(StringComparer.OrdinalIgnoreCase);

	// Token: 0x04001C44 RID: 7236
	private readonly Queue<int> 5 = new Queue<int>();

	// Token: 0x04001C45 RID: 7237
	private readonly 2538 6;

	// Token: 0x04001C46 RID: 7238
	internal readonly float 7 = 0.5f;

	// Token: 0x04001C47 RID: 7239
	internal double 8 = 1.0;

	// Token: 0x04001C48 RID: 7240
	internal string 9 = "0.00";

	// Token: 0x04001C49 RID: 7241
	internal string 10 = "0";

	// Token: 0x04001C4A RID: 7242
	internal string 11 = "0";

	// Token: 0x04001C4B RID: 7243
	internal string 12 = "0:00";

	// Token: 0x04001C4C RID: 7244
	internal string 13 = "0:00";

	// Token: 0x04001C4D RID: 7245
	internal string 14 = "0%";

	// Token: 0x04001C4E RID: 7246
	internal string 15 = "0.00";

	// Token: 0x04001C4F RID: 7247
	internal string 16 = "0";

	// Token: 0x04001C50 RID: 7248
	internal string 17 = "0x";

	// Token: 0x04001C51 RID: 7249
	internal bool 18;

	// Token: 0x04001C52 RID: 7250
	internal bool 19;

	// Token: 0x04001C53 RID: 7251
	internal readonly int[] 20 = new int[6];

	// Token: 0x04001C54 RID: 7252
	private int 21;

	// Token: 0x04001C55 RID: 7253
	private double 22;

	// Token: 0x04001C56 RID: 7254
	private double 23;

	// Token: 0x04001C57 RID: 7255
	private long 24 = long.MinValue;

	// Token: 0x04001C58 RID: 7256
	private bool 25;

	// Token: 0x02000504 RID: 1284
	[276]
	internal sealed class 2512
	{
		// Token: 0x04001C59 RID: 7257
		internal string 1;

		// Token: 0x04001C5A RID: 7258
		internal string 2;

		// Token: 0x04001C5B RID: 7259
		internal string 3;

		// Token: 0x04001C5C RID: 7260
		internal 2509 4;

		// Token: 0x04001C5D RID: 7261
		internal 208 5;

		// Token: 0x04001C5E RID: 7262
		internal Func<2511, 2528, 2510> 6;

		// Token: 0x04001C5F RID: 7263
		internal bool 7;
	}
}
