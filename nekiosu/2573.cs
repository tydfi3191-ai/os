using System;
using System.Collections.Generic;
using System.Threading;
using OpenTK;

// Token: 0x02000480 RID: 1152
public sealed class 2573 : 1474
{
	// Token: 0x060022FE RID: 8958 RVA: 0x0009854C File Offset: 0x0009674C
	internal 2573(1803 1) : base(3)
	{
		897 4 = new 897();
		4.SetMaxWorkerThreads(1);
		4.Method9344(true);
		4.SetIdleTimeout(1000);
		4.SetThreadPriority(ThreadPriority.Normal);
		this.46 = new 915(4);
		1535.40((1082)1, new 1081(this.67), 1545.Default, (1559)0);
		1535.40((1082)0, delegate(object 1, EventArgs 2)
		{
			this.27 = false;
			this.37 += 0.4 * (1.0 + Math.Min(Math.Abs(this.37) / 2.0, 5.0));
			this.48 = 0.994;
			return true;
		}, 1545.Default, (1559)0);
		1535.40((1082)6, delegate(object 1, EventArgs 2)
		{
			bool flag = this.22;
			if (1535.14 != 199.Pressed)
			{
				if (this.33)
				{
					this.37 *= Math.Pow(0.95, Math.Max(0.0, this.47 - 66.0));
					this.47 = 0.0;
				}
				this.22 = false;
				this.33 = false;
			}
			if (!this.20)
			{
				return false;
			}
			if (this.35 < 0 || this.35 >= this.10.Count)
			{
				return false;
			}
			if (flag || this.10.Count == 0 || !this.10[this.35].10(1555.17()))
			{
				return false;
			}
			this.27 = false;
			2593 5 = this.10[this.35];
			if (5 is 2598 || this.35 != this.26)
			{
				if (5.27() <= (2597)1)
				{
					this.90(this.35, true);
				}
				else
				{
					this.92(this.35, true);
				}
			}
			else if (!1535.49 && this.41 != null)
			{
				this.41(this, 5);
			}
			if (1535.49 && this.40 != null)
			{
				this.40(this, 5);
			}
			this.35 = -1;
			return false;
		}, 1545.Default, (1559)0);
		1535.40((1082)8, new 1081(this.29), 1545.Default, (1559)0);
		1549.5(new 1549.1551(this.30));
		1546.1(new 1546.1547(this.31));
		1272.2(new 1272.1273(this.85));
		this.6 = new 1436(true);
		this.4 = 1304.193;
		this.5 = 1304.194;
		this.3 = new 2592(delegate(1262 1, 1262 2)
		{
			if (1 == 2)
			{
				return 0;
			}
			if (!1.28)
			{
				return 1;
			}
			if (!2.28)
			{
				return -1;
			}
			int num = 0;
			switch (this.5.GetValue())
			{
			case 2620.Artist:
				num = 1.7.CompareTo(2.7);
				if (num != 0)
				{
					return num;
				}
				break;
			case 2620.BPM:
				num = 1.85().CompareTo(2.85());
				goto IL_173;
			case 2620.Creator:
				num = 1.43.CompareTo(2.43);
				goto IL_173;
			case 2620.Date:
				num = ((1.37 != 2.37 || (1.61 && 2.61) || Math.Abs((1.47 - 2.47).TotalSeconds) > 10.0) ? 1.47.CompareTo(2.47) : 0);
				goto IL_173;
			case 2620.Difficulty:
				num = 1.33(true).CompareTo(2.33(true));
				goto IL_173;
			case 2620.Length:
				num = (1.87 / 1000).CompareTo(2.87 / 1000);
				goto IL_173;
			case 2620.Rank:
				num = 2.72().CompareTo(1.72());
				goto IL_173;
			case 2620.Title:
				break;
			default:
				goto IL_173;
			}
			num = 1.10.CompareTo(2.10);
			IL_173:
			if (num != 0)
			{
				return num;
			}
			num = 1.37.CompareTo(2.37);
			if (num != 0)
			{
				return num;
			}
			num = 1.38().CompareTo(2.38());
			if (num != 0)
			{
				return num;
			}
			num = 1.33(false).CompareTo(2.33(false));
			if (num != 0)
			{
				return num;
			}
			num = 1.58.CompareTo(2.58);
			if (num == 0)
			{
				return 0;
			}
			return num;
		});
	}

	// Token: 0x060022FF RID: 8959 RVA: 0x000986D8 File Offset: 0x000968D8
	protected override void Dispose(bool 1)
	{
		this.46.Method4890(false, 0);
		this.46.Dispose();
		1549.6(new 1549.1551(this.30));
		1546.2(new 1546.1547(this.31));
		1272.3(new 1272.1273(this.85));
		if (this.6 != null)
		{
			this.6.Dispose();
		}
		this.1(this.10);
		base.Dispose(1);
	}

	// Token: 0x06002300 RID: 8960 RVA: 0x00098758 File Offset: 0x00096958
	private void 1(List<2593> 1)
	{
		foreach (2593 2 in 1)
		{
			2.9();
		}
	}

	// Token: 0x06002301 RID: 8961 RVA: 0x000987A4 File Offset: 0x000969A4
	public override void Draw()
	{
		base.Draw();
		this.6.22();
	}

	// Token: 0x06002302 RID: 8962 RVA: 0x000987B8 File Offset: 0x000969B8
	public override void Update()
	{
		this.60();
		if (this.20)
		{
			this.71();
		}
		this.72();
		if (this.26 >= 0)
		{
			this.99(this.26);
		}
		this.55();
		base.Update();
	}

	// Token: 0x06002303 RID: 8963 RVA: 0x000987F8 File Offset: 0x000969F8
	internal void 2()
	{
		this.7 = 0.6f;
		for (int i = 0; i < this.10.Count; i++)
		{
			this.10[i].12(this.7);
			this.7 += 3E-05f;
		}
		this.41();
		this.52();
	}

	// Token: 0x06002304 RID: 8964 RVA: 0x0009885C File Offset: 0x00096A5C
	internal void 3(2573.2575 1)
	{
		2573.2575 2 = this.38;
		2573.2575 3;
		do
		{
			3 = 2;
			2573.2575 value = (2573.2575)Delegate.Combine(3, 1);
			2 = Interlocked.CompareExchange<2573.2575>(ref this.38, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x06002305 RID: 8965 RVA: 0x00098894 File Offset: 0x00096A94
	internal void 4(2573.2575 1)
	{
		2573.2575 2 = this.38;
		2573.2575 3;
		do
		{
			3 = 2;
			2573.2575 value = (2573.2575)Delegate.Remove(3, 1);
			2 = Interlocked.CompareExchange<2573.2575>(ref this.38, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x06002306 RID: 8966 RVA: 0x000988CC File Offset: 0x00096ACC
	internal void 5(2573.2580 1)
	{
		2573.2580 2 = this.39;
		2573.2580 3;
		do
		{
			3 = 2;
			2573.2580 value = (2573.2580)Delegate.Combine(3, 1);
			2 = Interlocked.CompareExchange<2573.2580>(ref this.39, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x06002307 RID: 8967 RVA: 0x00098904 File Offset: 0x00096B04
	internal void 6(2573.2580 1)
	{
		2573.2580 2 = this.39;
		2573.2580 3;
		do
		{
			3 = 2;
			2573.2580 value = (2573.2580)Delegate.Remove(3, 1);
			2 = Interlocked.CompareExchange<2573.2580>(ref this.39, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x06002308 RID: 8968 RVA: 0x0009893C File Offset: 0x00096B3C
	internal void 7(2573.2580 1)
	{
		2573.2580 2 = this.40;
		2573.2580 3;
		do
		{
			3 = 2;
			2573.2580 value = (2573.2580)Delegate.Combine(3, 1);
			2 = Interlocked.CompareExchange<2573.2580>(ref this.40, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x06002309 RID: 8969 RVA: 0x00098974 File Offset: 0x00096B74
	internal void 8(2573.2580 1)
	{
		2573.2580 2 = this.40;
		2573.2580 3;
		do
		{
			3 = 2;
			2573.2580 value = (2573.2580)Delegate.Remove(3, 1);
			2 = Interlocked.CompareExchange<2573.2580>(ref this.40, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x0600230A RID: 8970 RVA: 0x000989AC File Offset: 0x00096BAC
	internal void 9(2573.2580 1)
	{
		2573.2580 2 = this.41;
		2573.2580 3;
		do
		{
			3 = 2;
			2573.2580 value = (2573.2580)Delegate.Combine(3, 1);
			2 = Interlocked.CompareExchange<2573.2580>(ref this.41, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x0600230B RID: 8971 RVA: 0x000989E4 File Offset: 0x00096BE4
	internal void 10(2573.2580 1)
	{
		2573.2580 2 = this.41;
		2573.2580 3;
		do
		{
			3 = 2;
			2573.2580 value = (2573.2580)Delegate.Remove(3, 1);
			2 = Interlocked.CompareExchange<2573.2580>(ref this.41, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x0600230C RID: 8972 RVA: 0x00098A1C File Offset: 0x00096C1C
	internal void 11(2573.2580 1)
	{
		2573.2580 2 = this.42;
		2573.2580 3;
		do
		{
			3 = 2;
			2573.2580 value = (2573.2580)Delegate.Combine(3, 1);
			2 = Interlocked.CompareExchange<2573.2580>(ref this.42, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x0600230D RID: 8973 RVA: 0x00098A54 File Offset: 0x00096C54
	internal void 12(2573.2580 1)
	{
		2573.2580 2 = this.42;
		2573.2580 3;
		do
		{
			3 = 2;
			2573.2580 value = (2573.2580)Delegate.Remove(3, 1);
			2 = Interlocked.CompareExchange<2573.2580>(ref this.42, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x0600230E RID: 8974 RVA: 0x00098A8C File Offset: 0x00096C8C
	internal void 13(2573.2580 1)
	{
		2573.2580 2 = this.43;
		2573.2580 3;
		do
		{
			3 = 2;
			2573.2580 value = (2573.2580)Delegate.Combine(3, 1);
			2 = Interlocked.CompareExchange<2573.2580>(ref this.43, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x0600230F RID: 8975 RVA: 0x00098AC4 File Offset: 0x00096CC4
	internal void 14(2573.2580 1)
	{
		2573.2580 2 = this.43;
		2573.2580 3;
		do
		{
			3 = 2;
			2573.2580 value = (2573.2580)Delegate.Remove(3, 1);
			2 = Interlocked.CompareExchange<2573.2580>(ref this.43, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x06002310 RID: 8976 RVA: 0x00098AFC File Offset: 0x00096CFC
	internal void 15(1189 1)
	{
		1189 2 = this.44;
		1189 3;
		do
		{
			3 = 2;
			1189 value = (1189)Delegate.Combine(3, 1);
			2 = Interlocked.CompareExchange<1189>(ref this.44, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x06002311 RID: 8977 RVA: 0x00098B34 File Offset: 0x00096D34
	internal void 16(1189 1)
	{
		1189 2 = this.44;
		1189 3;
		do
		{
			3 = 2;
			1189 value = (1189)Delegate.Remove(3, 1);
			2 = Interlocked.CompareExchange<1189>(ref this.44, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x06002312 RID: 8978 RVA: 0x00098B6C File Offset: 0x00096D6C
	internal void 17(1189 1)
	{
		1189 2 = this.45;
		1189 3;
		do
		{
			3 = 2;
			1189 value = (1189)Delegate.Combine(3, 1);
			2 = Interlocked.CompareExchange<1189>(ref this.45, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x06002313 RID: 8979 RVA: 0x00098BA4 File Offset: 0x00096DA4
	internal void 18(1189 1)
	{
		1189 2 = this.45;
		1189 3;
		do
		{
			3 = 2;
			1189 value = (1189)Delegate.Remove(3, 1);
			2 = Interlocked.CompareExchange<1189>(ref this.45, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x06002314 RID: 8980 RVA: 0x00098BDC File Offset: 0x00096DDC
	internal List<1262> 19()
	{
		if (1304.206.5() && 1304.207.5())
		{
			return 1272.3;
		}
		return 1272.3.FindAll(delegate(1262 1)
		{
			double num = 1.18(1.38(), 2023.None);
			return (num > 10.0 && 1304.207.GetValue() == 10.0) || 1.36() || (num >= 1304.206.GetValue() && num <= 1304.207.GetValue());
		});
	}

	// Token: 0x06002315 RID: 8981 RVA: 0x00098C30 File Offset: 0x00096E30
	internal 2593 20(1262 1, 2593 2, 2147? 3)
	{
		return new 2593(1, 2, 3);
	}

	// Token: 0x06002316 RID: 8982 RVA: 0x00098C3A File Offset: 0x00096E3A
	internal 2598 21(string 1)
	{
		return new 2598(1);
	}

	// Token: 0x06002317 RID: 8983 RVA: 0x00098C44 File Offset: 0x00096E44
	internal void 22(2591 1, bool 2, 1189 3)
	{
		2573.2584 4 = new 2573.2584();
		4.2 = this;
		4.3 = 1;
		4.4 = 2;
		4.5 = 3;
		this.9++;
		4.1 = this.9;
		this.46.Method36622(new Action(4.1), (639)2);
	}

	// Token: 0x06002318 RID: 8984 RVA: 0x00098CAC File Offset: 0x00096EAC
	private void 23(List<2593> 1, 2591 2, bool 3)
	{
		List<1262> list = 3 ? 1272.3 : this.19();
		switch (2)
		{
		case 2591.Artist:
			this.24(13, list, 3, (1262 1) => 1.7);
			return;
		case 2591.BPM:
		{
			2573.2583 4 = new 2573.2583();
			4.1 = 1;
			while (4.1 < 6)
			{
				string 5 = string.Format(1568.1(2679.BeatmapTreeManager_UnderBPM), 4.1 * 60);
				this.27(13, 5, list.FindAll(new Predicate<1262>(4.13)), 3);
				4.1++;
			}
			this.27(13, string.Format(1568.1(2679.BeatmapTreeManager_OverBPM), 300), list.FindAll(new Predicate<1262>(2573.2577.beatmapTreeCallbacks.9)), 3);
			return;
		}
		case 2591.Creator:
			this.24(13, list, 3, new 2573.2576(2573.2577.beatmapTreeCallbacks.4));
			return;
		case 2591.Date:
			this.25(13, list, 3, (1262 1) => 1.47);
			return;
		case 2591.Difficulty:
		{
			this.27(13, "Below 1 star", list.FindAll(new Predicate<1262>(2573.2577.beatmapTreeCallbacks.5)), 3);
			2573.2590 6 = new 2573.2590();
			6.1 = 1.0;
			while (6.1 <= 10.0)
			{
				string 7 = 6.1.ToString() + " Star" + ((6.1 != 1.0) ? "s" : string.Empty);
				this.27(13, 7, list.FindAll(new Predicate<1262>(6.13)), 3);
				6.1 += 1.0;
			}
			this.27(13, "Above 10 stars", list.FindAll(new Predicate<1262>(2573.2577.beatmapTreeCallbacks.6)), 3);
			return;
		}
		case 2591.Length:
		{
			2573.2578 8 = new 2573.2578();
			8.1 = 1;
			while (8.1 < 6)
			{
				string 9 = string.Format(1568.1(2679.BeatmapTreeManager_MinutesOrLess), 8.1);
				this.27(13, 9, list.FindAll(new Predicate<1262>(8.13)), 3);
				8.1++;
			}
			this.27(13, string.Format(1568.1(2679.BeatmapTreeManager_MinutesOrLess), 10), list.FindAll(new Predicate<1262>(2573.2577.beatmapTreeCallbacks.7)), 3);
			this.27(13, string.Format(1568.1(2679.BeatmapTreeManager_OverMinutes), 10), list.FindAll(new Predicate<1262>(2573.2577.beatmapTreeCallbacks.8)), 3);
			return;
		}
		case 2591.Rank:
			this.27(13, 1568.1(2679.BeatmapTreeManager_SilverSS), list.FindAll(new Predicate<1262>(2573.2577.beatmapTreeCallbacks.2)), 3);
			this.27(13, 1568.1(2679.BeatmapTreeManager_SilverS), list.FindAll((1262 1) => 1.72() == 2236.SH), 3);
			this.27(13, "SS", list.FindAll((1262 1) => 1.72() == 2236.X), 3);
			for (int i = 3; i < 8; i++)
			{
				2573.2581 gradeMatcher = new 2573.2581();
				gradeMatcher.1 = (2236)i;
				this.27(13, gradeMatcher.1.ToString(), list.FindAll((1262 1) => 1.72() == gradeMatcher.1), 3);
			}
			this.27(13, 1568.1(2679.BeatmapTreeManager_NoRankAchieved), list.FindAll(new Predicate<1262>(2573.2577.beatmapTreeCallbacks.3)), 3);
			return;
		case 2591.My_Maps:
			this.26(13, list.FindAll((1262 1) => 1.43.ToLower() == 1304.189.GetValue().ToLower()), 3);
			return;
		case (2591)9:
		case (2591)10:
		case (2591)11:
			break;
		case 2591.Search:
			this.26(13, list, 3);
			return;
		case 2591.Title:
			this.24(13, list, 3, (1262 1) => 1.10);
			return;
		case 2591.Last_Played:
			this.25(13, list, 3, new 2573.2574(2573.2577.beatmapTreeCallbacks.10));
			return;
		case 2591.Online_Favourites:
			this.26(13, list.FindAll(new Predicate<1262>(2573.2577.beatmapTreeCallbacks.13)), 3);
			return;
		case 2591.Mania_Keys:
		{
			list = list.FindAll(new Predicate<1262>(2573.2577.beatmapTreeCallbacks.15));
			2573.2582 10 = new 2573.2582();
			10.1 = 1;
			while (10.1 <= 18)
			{
				this.27(13, string.Format(1568.1(2679.BeatmapTreeManager_Keys), 10.1), list.FindAll(new Predicate<1262>(10.13)), 3);
				10.1++;
			}
			return;
		}
		case 2591.Mode:
			this.27(13, 2148.1(2147.Osu), list.FindAll((1262 1) => 1.3() == 2147.Osu), 3);
			this.27(13, 2148.1(2147.Taiko), list.FindAll((1262 1) => 1.3() == 2147.Taiko), 3);
			this.27(13, 2148.1(2147.CatchTheBeat), list.FindAll(new Predicate<1262>(2573.2577.beatmapTreeCallbacks.16)), 3);
			this.27(13, 2148.1(2147.OsuMania), list.FindAll(new Predicate<1262>(2573.2577.beatmapTreeCallbacks.17)), 3);
			return;
		case 2591.Collection:
			list = new List<1262>();
			foreach (KeyValuePair<string, List<string>> keyValuePair in 1297.1())
			{
				list.Clear();
				foreach (string 11 in keyValuePair.Value)
				{
					1262 12 = 1272.8(11);
					if (12 != null)
					{
						list.Add(12);
					}
				}
				if (list.Count > 0)
				{
					this.27(13, keyValuePair.Key, list, 3);
				}
			}
			break;
		case 2591.RankedStatus:
			this.27(13, 1568.1(2679.MapStatus_Ranked), list.FindAll(new Predicate<1262>(2573.2577.beatmapTreeCallbacks.11)), 3);
			this.27(13, 1568.1(2679.MapStatus_Qualified), list.FindAll(new Predicate<1262>(2573.2577.beatmapTreeCallbacks.12)), 3);
			this.27(13, 1568.1(2679.MapStatus_Pending), list.FindAll(new Predicate<1262>(2573.2577.beatmapTreeCallbacks.13)), 3);
			this.27(13, 1568.1(2679.MapStatus_NotSubmitted), list.FindAll(new Predicate<1262>(2573.2577.beatmapTreeCallbacks.14)), 3);
			this.27(13, 1568.1(2679.MapStatus_Unknown), list.FindAll((1262 1) => 1.85 == (1281)0), 3);
			this.27(13, 1568.1(2679.MapStatus_Loved), list.FindAll((1262 1) => 1.85 == (1281)7), 3);
			return;
		default:
			return;
		}
	}

	// Token: 0x06002319 RID: 8985 RVA: 0x00099464 File Offset: 0x00097664
	private void 24(List<2593> 1, List<1262> 2, bool 3, 2573.2576 4)
	{
		List<1262> list = new List<1262>();
		List<List<1262>> list2 = new List<List<1262>>();
		for (char c = 'A'; c <= 'Z'; c += '\u0001')
		{
			list2.Add(new List<1262>());
		}
		List<1262> list3 = new List<1262>();
		foreach (1262 5 in 2)
		{
			string text = 4(5);
			if (text.Length > 0)
			{
				char c2 = text[0];
				if (char.IsNumber(c2))
				{
					list.Add(5);
					continue;
				}
				char c3 = char.ToUpper(c2);
				if (c3 >= 'A' && c3 <= 'Z')
				{
					list2[(int)(c3 - 'A')].Add(5);
					continue;
				}
			}
			list3.Add(5);
		}
		this.27(1, "0-9", list, 3);
		for (char c4 = 'A'; c4 <= 'Z'; c4 += '\u0001')
		{
			this.27(1, c4.ToString(), list2[(int)(c4 - 'A')], 3);
		}
		this.27(1, 1568.1(2679.BeatmapTreeManager_Other), list3, 3);
	}

	// Token: 0x0600231A RID: 8986 RVA: 0x0009958C File Offset: 0x0009778C
	private void 25(List<2593> 1, List<1262> 2, bool 3, 2573.2574 4)
	{
		DateTime now = DateTime.Now;
		List<1262> list = new List<1262>();
		List<1262> list2 = new List<1262>();
		List<1262> list3 = new List<1262>();
		List<List<1262>> list4 = new List<List<1262>>();
		int i;
		for (i = 1; i <= 5; i++)
		{
			list4.Add(new List<1262>());
		}
		List<1262> list5 = new List<1262>();
		List<1262> list6 = new List<1262>();
		foreach (1262 5 in 2)
		{
			DateTime dateTime = 4(5);
			if (dateTime < new DateTime(1999, 1, 1))
			{
				list6.Add(5);
			}
			else if (now - dateTime >= new TimeSpan(30 * (i - 1), 0, 0, 0))
			{
				list5.Add(5);
			}
			else
			{
				int j;
				for (j = i - 1; j >= 2; j--)
				{
					if (now - dateTime >= new TimeSpan(30 * (j - 1), 0, 0, 0))
					{
						list4[j - 1].Add(5);
						break;
					}
				}
				if (j < 2)
				{
					if (now - dateTime >= new TimeSpan(7, 0, 0, 0))
					{
						list4[0].Add(5);
					}
					else if (now - dateTime >= new TimeSpan(2, 0, 0, 0))
					{
						list3.Add(5);
					}
					else if (now - dateTime >= new TimeSpan(24, 0, 0))
					{
						list2.Add(5);
					}
					else
					{
						list.Add(5);
					}
				}
			}
		}
		this.27(1, 1568.1(2679.BeatmapTreeManager_Today), list, 3);
		this.27(1, 1568.1(2679.BeatmapTreeManager_Yesterday), list2, 3);
		this.27(1, 1568.1(2679.BeatmapTreeManager_LastWeek), list3, 3);
		for (i = 1; i <= 5; i++)
		{
			string 6 = string.Format(1568.1(2679.BeatmapTreeManager_MonthsAgo), i);
			this.27(1, 6, list4[i - 1], 3);
		}
		this.27(1, string.Format(1568.1(2679.BeatmapTreeManager_OverMonthsAgo), i - 1), list5, 3);
		this.27(1, 1568.1(2679.BeatmapTreeManager_Never), list6, 3);
	}

	// Token: 0x0600231B RID: 8987 RVA: 0x000997F8 File Offset: 0x000979F8
	private void 26(List<2593> 1, List<1262> 2, bool 3)
	{
		foreach (1262 4 in 2)
		{
			if (4.28 || 3)
			{
				1.Add(this.20(4, null, null));
			}
		}
	}

	// Token: 0x0600231C RID: 8988 RVA: 0x00099860 File Offset: 0x00097A60
	private void 27(List<2593> 1, string 2, List<1262> 3, bool 4)
	{
		2598 5 = this.21(2);
		foreach (1262 6 in 3)
		{
			if (6.28 || 4)
			{
				5.48.Add(this.20(6, 5, null));
			}
		}
		if (5.48.Count > 0)
		{
			1.Add(5);
			1.AddRange(5.48);
		}
	}

	// Token: 0x0600231D RID: 8989 RVA: 0x000998F8 File Offset: 0x00097AF8
	private bool 28()
	{
		return this.24 >= 0;
	}

	// Token: 0x0600231E RID: 8990 RVA: 0x00099906 File Offset: 0x00097B06
	private bool 29(object 1, EventArgs 2)
	{
		if (!this.20)
		{
			return false;
		}
		this.32();
		this.35 = this.24;
		this.27 = false;
		if (!this.28() && 1535.43 == 199.Pressed)
		{
			this.34 = true;
		}
		return false;
	}

	// Token: 0x0600231F RID: 8991 RVA: 0x00099944 File Offset: 0x00097B44
	private bool 30(object 1, 200 2, bool 3)
	{
		if (!this.20)
		{
			return false;
		}
		if (1549.1 && (2 == 200.Up || 2 == 200.Down))
		{
			return false;
		}
		switch (2)
		{
		case 200.PageUp:
			this.35(-10, true, false);
			return true;
		case 200.PageDown:
			this.35(10, true, false);
			return true;
		case 200.End:
		case 200.Home:
			goto IL_CB;
		case 200.Left:
		case 200.Right:
			if (3)
			{
				if (1549.3)
				{
					this.34((2 != 200.Left) ? 1 : -1);
				}
				else if (this.83())
				{
					this.90(this.28, true);
				}
				else
				{
					this.35((2 != 200.Left) ? 1 : -1, false, true);
				}
			}
			return true;
		case 200.Up:
			break;
		case 200.Down:
			goto IL_C0;
		default:
			if (2 != (200)342)
			{
				if (2 != (200)343)
				{
					goto IL_CB;
				}
				goto IL_C0;
			}
			break;
		}
		this.35(-1, true, false);
		return true;
		IL_C0:
		this.35(1, true, false);
		return true;
		IL_CB:
		if (!3 || 2 != 200.Enter)
		{
			return false;
		}
		if (1662.104.15())
		{
			return true;
		}
		if (1549.3 && !1549.1)
		{
			this.33();
		}
		else if (this.83())
		{
			this.90(this.28, true);
		}
		else if (this.41 != null)
		{
			this.41(this, this.79());
		}
		return true;
	}

	// Token: 0x06002320 RID: 8992 RVA: 0x00099A7C File Offset: 0x00097C7C
	private void 31(object 1, List<200> 2)
	{
		if (2[0] == (200)341)
		{
			this.30(null, 200.Enter, true);
		}
	}

	// Token: 0x06002321 RID: 8993 RVA: 0x00099A98 File Offset: 0x00097C98
	private void 32()
	{
		if (this.33 || this.34)
		{
			return;
		}
		bool flag = false;
		for (int i = this.31; i < this.32; i++)
		{
			2593 <<EMPTY_NAME>> = this.10[i];
			if (<<EMPTY_NAME>>.16() && <<EMPTY_NAME>>.17())
			{
				if (this.24 != i && <<EMPTY_NAME>>.29())
				{
					this.24 = i;
					if (1662.11.2())
					{
						1226.20(null, "menuclick", 1f, false);
					}
					<<EMPTY_NAME>>.30(1045.2(<<EMPTY_NAME>>.47, 0.3f), 1000);
				}
				flag = true;
			}
		}
		if (!flag)
		{
			this.24 = -1;
		}
	}

	// Token: 0x06002322 RID: 8994 RVA: 0x00099B54 File Offset: 0x00097D54
	private void 33()
	{
		int num = (this.77() == null) ? this.26 : this.25;
		if (num != -1)
		{
			if (this.10[num].22 == null)
			{
				if (!(this.10[num] is 2598))
				{
					return;
				}
			}
			while (!(this.10[num] is 2598))
			{
				num--;
			}
			this.87();
			this.92(num, true);
		}
	}

	// Token: 0x06002323 RID: 8995 RVA: 0x00099BCC File Offset: 0x00097DCC
	private void 34(int 1)
	{
		int num = (this.77() == null) ? this.26 : this.25;
		if (num == -1 || (this.10[num].22 == null && !(this.10[num] is 2598)))
		{
			return;
		}
		while (!(this.10[num] is 2598))
		{
			num--;
		}
		this.87();
		int num2 = num;
		int num3 = Math.Sign(1);
		int num4 = 0;
		do
		{
			num2 = (this.10.Count + num2 + num3) % this.10.Count;
			2593 2 = this.10[num2];
			if (!2.23 && 2 is 2598)
			{
				num4++;
			}
		}
		while (num != num2 && num4 < Math.Abs(1));
		this.92(num2, true);
	}

	// Token: 0x06002324 RID: 8996 RVA: 0x00099C98 File Offset: 0x00097E98
	private void 35(int 1, bool 2, bool 3)
	{
		if (1 == 0 || this.10.Count == 0)
		{
			return;
		}
		int num = this.84();
		if (num >= 0 && !this.76(num).16() && this.77() != null && this.77().23())
		{
			num = this.25;
		}
		if (num == -1)
		{
			return;
		}
		int num2 = num;
		int num3 = this.81() ? this.79().15 : -1;
		int num4 = Math.Sign(1);
		int num5 = 0;
		do
		{
			num2 = (this.10.Count + num2 + num4) % this.10.Count;
			2593 4 = this.10[num2];
			if (!4.23 && (2 || (!(4 is 2598) && 4.15 != num3)) && (!2 || !4.18()))
			{
				num5++;
			}
		}
		while (num != num2 && num5 < Math.Abs(1));
		if (3)
		{
			this.90(num2, true);
			return;
		}
		this.36(num2);
	}

	// Token: 0x06002325 RID: 8997 RVA: 0x00099D90 File Offset: 0x00097F90
	internal void 36(int 1)
	{
		this.87();
		2593 2 = this.10[1];
		this.27 = true;
		if (this.81() && 2.15 == this.79().15)
		{
			this.92(1, true);
			return;
		}
		this.28 = 1;
		1226.20(null, "menuclick", 1f, false);
		this.89();
	}

	// Token: 0x06002326 RID: 8998 RVA: 0x00099E01 File Offset: 0x00098001
	internal int 37(int 1)
	{
		return this.10.FindIndex(2, (2593 1) => 1.14 != null && !1.18() && 1.14.28);
	}

	// Token: 0x06002327 RID: 8999 RVA: 0x00099E2E File Offset: 0x0009802E
	internal static double 38()
	{
		return (double)((float)1662.70.1 / 1662.70.3() - 340f);
	}

	// Token: 0x06002328 RID: 9000 RVA: 0x00099E50 File Offset: 0x00098050
	internal void 39()
	{
		foreach (2593 <<EMPTY_NAME>> in this.10)
		{
			if (<<EMPTY_NAME>>.14 != null && <<EMPTY_NAME>>.34 != null)
			{
				if (<<EMPTY_NAME>>.14.72() <= 2236.D && <<EMPTY_NAME>>.14.64)
				{
					<<EMPTY_NAME>>.14.64 = false;
				}
				<<EMPTY_NAME>>.14();
			}
		}
	}

	// Token: 0x06002329 RID: 9001 RVA: 0x00099EDC File Offset: 0x000980DC
	internal void 40(object 1, EventArgs 2)
	{
		1662.89.Schedule(delegate()
		{
			if (this.10 != null)
			{
				this.39();
				1272.11();
				this.41();
			}
		}, false);
	}

	// Token: 0x0600232A RID: 9002 RVA: 0x00099EF8 File Offset: 0x000980F8
	internal void 41()
	{
		int num = 0;
		2593 <<EMPTY_NAME>> = null;
		for (int i = 0; i < this.10.Count; i++)
		{
			2593 2 = this.10[i];
			2598 3 = 2 as 2598;
			if (3 != null)
			{
				<<EMPTY_NAME>> = null;
				3.23 = (3.36() == 0);
				3.37(false);
			}
			else if (2.23)
			{
				2.21 = null;
				2.15 = -1;
				2.28((2597)0);
			}
			else
			{
				if (<<EMPTY_NAME>> == null || <<EMPTY_NAME>>.14.37 != 2.14.37)
				{
					<<EMPTY_NAME>> = 2;
				}
				2.21 = <<EMPTY_NAME>>;
				if (2.5())
				{
					num++;
					2.24 = true;
				}
				else
				{
					2.21.24 = false;
					2.24 = false;
				}
				2.15 = num;
				if (!2.14.64)
				{
					2.21.3(true);
				}
			}
		}
		this.42();
		this.43();
		this.89();
	}

	// Token: 0x0600232B RID: 9003 RVA: 0x0009A000 File Offset: 0x00098200
	internal void 42()
	{
		this.11 = 0;
		this.12 = 0;
		for (int i = 0; i < this.10.Count; i++)
		{
			2593 <<EMPTY_NAME>> = this.10[i];
			if (!(<<EMPTY_NAME>> is 2598) && !<<EMPTY_NAME>>.23)
			{
				this.56(<<EMPTY_NAME>>);
				if (!<<EMPTY_NAME>>.18())
				{
					this.11++;
					if (<<EMPTY_NAME>>.5())
					{
						this.12++;
					}
				}
			}
		}
	}

	// Token: 0x0600232C RID: 9004 RVA: 0x0009A084 File Offset: 0x00098284
	private void 43()
	{
		int num = 0;
		this.13.Clear();
		this.13.Capacity = this.10.Count;
		2593 <<EMPTY_NAME>> = null;
		double num2 = 0.0;
		for (int i = 0; i < this.10.Count; i++)
		{
			2593 2 = this.10[i];
			if (2.16())
			{
				if (2 is 2598)
				{
					if (<<EMPTY_NAME>> != null && !(<<EMPTY_NAME>> is 2598))
					{
						num2 += 10.0;
					}
				}
				else if (2.14 != null && <<EMPTY_NAME>> != null && (<<EMPTY_NAME>>.23() || (!<<EMPTY_NAME>>.23() && 2.23())))
				{
					num2 += 10.0;
				}
				<<EMPTY_NAME>> = 2;
				num++;
			}
			this.13.Add(200.0 + num2 + (double)((num - 1) * 48));
		}
		if (num <= 0)
		{
			this.14 = -1.0;
			return;
		}
		double num3 = this.64() * this.14;
		this.14 = num2 + (double)((num - 1) * 48);
		this.65((this.14 <= 0.0) ? 0.0 : 1052.20(num3 / this.14, 0.0, 1.0));
	}

	// Token: 0x0600232D RID: 9005 RVA: 0x0009A1E0 File Offset: 0x000983E0
	private static double 44(double 1)
	{
		return Math.Min(200.0, Math.Abs(1 / 480.0 - 0.5) * 75.0);
	}

	// Token: 0x0600232E RID: 9006 RVA: 0x0009A214 File Offset: 0x00098414
	private double 45(int 1)
	{
		double num = 0.0;
		2593 2 = this.10[1];
		if (2 is 2598)
		{
			num -= 50.0;
		}
		if (2.14 != null && 2.23())
		{
			num -= 50.0;
		}
		if (1 == this.24)
		{
			num -= 45.0;
		}
		return num;
	}

	// Token: 0x0600232F RID: 9007 RVA: 0x0009A27E File Offset: 0x0009847E
	private double 46(int 1)
	{
		return this.45(1) + 2573.44(this.10[1].44.Y + this.66() + this.73());
	}

	// Token: 0x06002330 RID: 9008 RVA: 0x0009A2B4 File Offset: 0x000984B4
	private double 47(int 1)
	{
		if (this.28())
		{
			if (this.24 < 1)
			{
				return this.13[1] + 10.0;
			}
			if (this.24 > 1)
			{
				return this.13[1] - 10.0;
			}
		}
		return this.13[1];
	}

	// Token: 0x06002331 RID: 9009 RVA: 0x0009A315 File Offset: 0x00098515
	private Vector2d 48(int 1)
	{
		return new Vector2d(this.46(1), this.47(1));
	}

	// Token: 0x06002332 RID: 9010 RVA: 0x0009A32A File Offset: 0x0009852A
	private static bool 49(double 1)
	{
		return 1 < -20.0;
	}

	// Token: 0x06002333 RID: 9011 RVA: 0x0009A338 File Offset: 0x00098538
	private static bool 50(double 1)
	{
		return 1 > 640.0;
	}

	// Token: 0x06002334 RID: 9012 RVA: 0x0009A348 File Offset: 0x00098548
	private void 51(Vector2d 1)
	{
		this.53();
		int num = -1;
		Vector2d vector2d = 2593.1();
		for (int i = this.31; i < this.32; i++)
		{
			2593 2 = this.10[i];
			if (2.16())
			{
				num = i;
				vector2d = 2.44;
				IL_159:
				while (this.31 > 0)
				{
					2593 3 = this.10[this.31 - 1];
					if (2573.49(this.47(this.31 - 1) + 1.Y))
					{
						break;
					}
					3.11(true);
					this.31--;
					if (3.16())
					{
						if (num >= 0)
						{
							double num2 = this.45(this.31);
							vector2d.Y += this.13[this.31] - this.13[num];
							vector2d.X = Math.Min(vector2d.X - this.45(num) + num2, num2 + 1.X + 200.0);
						}
						else
						{
							vector2d.X = this.46(this.31) + 1.X + 200.0;
							vector2d.Y = 0.0 - 1.Y;
						}
						num = this.31;
					}
					3.44 = vector2d;
				}
				num = -1;
				vector2d = 2593.1();
				for (int j = this.32 - 1; j >= this.31; j--)
				{
					2593 4 = this.10[j];
					if (4.16())
					{
						num = j;
						vector2d = 4.44;
						IL_2C7:
						while (this.32 < this.10.Count)
						{
							2593 5 = this.10[this.32];
							if (2573.50(this.47(this.32) + 1.Y))
							{
								break;
							}
							5.11(true);
							this.32++;
							if (5.16())
							{
								if (num >= 0)
								{
									double num3 = this.45(this.32 - 1);
									vector2d.Y += this.13[this.32 - 1] - this.13[num];
									vector2d.X = Math.Min(vector2d.X - this.45(num) + num3, num3 + 1.X + 200.0);
								}
								else
								{
									vector2d.X = this.46(this.32 - 1) + 1.X + 200.0;
									vector2d.Y = 0.0 - 1.Y;
								}
								num = this.32 - 1;
							}
							5.44 = vector2d;
						}
						return;
					}
				}
				goto IL_2C7;
			}
		}
		goto IL_159;
	}

	// Token: 0x06002335 RID: 9013 RVA: 0x0009A632 File Offset: 0x00098832
	internal void 52()
	{
		this.31 = 0;
		this.32 = this.10.Count;
	}

	// Token: 0x06002336 RID: 9014 RVA: 0x0009A64C File Offset: 0x0009884C
	internal void 53()
	{
		this.32 = Math.Min(this.32, this.10.Count);
		if (this.31 > this.32)
		{
			this.31 = this.32;
		}
	}

	// Token: 0x06002337 RID: 9015 RVA: 0x0009A684 File Offset: 0x00098884
	private void 54(int 1, 2593 2, Vector2d 3)
	{
		Vector2d vector2d = this.48(1) + new Vector2d(3.X, 0.0);
		Vector2d vector2d2;
		if (this.23)
		{
			vector2d2 = vector2d;
		}
		else
		{
			vector2d2 = 2.44;
			double num = vector2d.X - vector2d2.X;
			num *= Math.Pow(0.95, 1662.10);
			double num2 = vector2d.Y - vector2d2.Y;
			num2 *= Math.Pow(0.875, 1662.10);
			vector2d2.X = vector2d.X - num;
			vector2d2.Y = vector2d.Y - num2;
		}
		2.44 = vector2d2;
		bool flag = 2573.49(vector2d2.Y + this.66());
		bool flag2 = 2573.50(vector2d2.Y + this.66());
		if (!flag && !flag2)
		{
			2.26(true);
			2.11(false);
			2.22(new Vector2d(0.0, 3.Y));
			2.20(this.6);
			return;
		}
		if (2573.50(vector2d.Y + this.66()) && flag2)
		{
			for (int i = this.32 - 1; i >= 1; i--)
			{
				this.10[i].44 = this.48(i) + new Vector2d(3.X, 0.0);
				this.10[i].8();
			}
			this.32 = Math.Min(1, this.32);
			return;
		}
		if (2573.49(vector2d.Y + this.66()) && flag)
		{
			for (int j = this.31; j <= 1; j++)
			{
				this.10[j].44 = this.48(j) + new Vector2d(3.X, 0.0);
				this.10[j].8();
			}
			this.31 = Math.Max(1 + 1, this.31);
		}
	}

	// Token: 0x06002338 RID: 9016 RVA: 0x0009A8A4 File Offset: 0x00098AA4
	private void 55()
	{
		Vector2d vector2d;
		vector2d..ctor(2573.38() + this.30, this.66());
		this.51(vector2d - new Vector2d(0.0, this.73()));
		1433 <<EMPTY_NAME>> = this.6.23;
		this.6.15(false);
		bool flag = false;
		for (int i = this.31; i < this.32; i++)
		{
			2593 2 = this.10[i];
			if (!2.16())
			{
				if (2.16)
				{
					2.8();
				}
			}
			else
			{
				this.54(i, 2, vector2d);
				if (!this.33 && !this.34 && 2.17())
				{
					if (this.24 != i && 2.29())
					{
						this.24 = i;
						if (1662.11.2())
						{
							1226.20(null, "menuclick", 1f, false);
						}
						2.30(1045.2(2.47, 0.3f), 1000);
					}
					flag = true;
				}
			}
		}
		if (!flag && !this.33 && !this.34)
		{
			this.24 = -1;
		}
		if (<<EMPTY_NAME>> != null)
		{
			<<EMPTY_NAME>>.SetHovered(false);
		}
		this.23 = false;
	}

	// Token: 0x06002339 RID: 9017 RVA: 0x0009A9FC File Offset: 0x00098BFC
	private void 56(2593 1)
	{
		if ((1.22 != null && !1.22.23()) || 1.23)
		{
			1.28((2597)0);
			return;
		}
		2593 2 = this.79();
		bool flag = 2 != null && 2.14 != null && 1.14 != null && 1.14.37 == 2.14.37;
		if (1 == 2)
		{
			1.28((2597)4);
		}
		else if (flag)
		{
			1.28((2597)3);
		}
		else if (1.24)
		{
			1.28((2597)2);
		}
		else if (1.5())
		{
			1.28((2597)1);
		}
		else
		{
			1.28((2597)0);
		}
		if (1.23() && this.42 != null)
		{
			this.42(this, 1);
		}
	}

	// Token: 0x0600233A RID: 9018 RVA: 0x0009AAC8 File Offset: 0x00098CC8
	internal void 57(int 1)
	{
		foreach (2593 2 in this.10)
		{
			2.25(1);
		}
	}

	// Token: 0x0600233B RID: 9019 RVA: 0x0009AB1C File Offset: 0x00098D1C
	private void 58()
	{
		Vector2d vector2d = this.77().44;
		int num = this.25 + 1;
		while (num < this.10.Count && !(this.10[num] is 2598))
		{
			2593 <<EMPTY_NAME>> = this.10[num];
			if (!2573.50(vector2d.Y + this.66()) && !2573.49(vector2d.Y + this.66()))
			{
				<<EMPTY_NAME>>.26(false);
			}
			<<EMPTY_NAME>>.44 = vector2d;
			if (<<EMPTY_NAME>>.5() && <<EMPTY_NAME>>.16())
			{
				vector2d.Y += 48.0;
			}
			num++;
		}
	}

	// Token: 0x0600233C RID: 9020 RVA: 0x0009ABD0 File Offset: 0x00098DD0
	internal bool 59()
	{
		if (this.10.Count < 2 || this.11 < 2 || 1662.30())
		{
			return false;
		}
		this.18.Clear();
		for (int i = this.37(0); i >= 0; i = this.37(i + 1))
		{
			this.18.Add(i);
		}
		if (this.18.Count <= 0)
		{
			return false;
		}
		if (1272.5() != null)
		{
			LinkedList<2573.2589> linkedList = this.19;
			2573.2589 value = default(2573.2589);
			value.1 = 1272.5();
			2593 <<EMPTY_NAME>> = this.79();
			string 2;
			if (<<EMPTY_NAME>> == null)
			{
				2 = null;
			}
			else
			{
				2593 3 = <<EMPTY_NAME>>.22;
				2 = ((3 != null) ? 3.GetDisplayTitle() : null);
			}
			value.2 = 2;
			linkedList.AddLast(value);
		}
		if (this.19.Count > 20)
		{
			this.19.RemoveFirst();
		}
		this.17 = 0.0001f;
		this.15 = true;
		if (this.44 != null)
		{
			this.44();
		}
		this.36(this.18[1196.1(this.18.Count)]);
		return true;
	}

	// Token: 0x0600233D RID: 9021 RVA: 0x0009ACEC File Offset: 0x00098EEC
	private void 60()
	{
		if (this.15 && 1662.23)
		{
			int num = this.16;
			this.16 = num + 1;
			if ((float)num > this.17)
			{
				if (this.11 <= 1)
				{
					this.61();
					return;
				}
				int num2 = this.84();
				num2 = this.37(num2 + 1);
				if (num2 < 0)
				{
					num2 = this.37(0);
				}
				if (num2 < 0)
				{
					this.61();
					return;
				}
				1226.20(new int?((int)(Math.Min(50f, this.17 + 20f) / 50f * 100f)), "menuclick", 1f, false);
				this.16 = 0;
				this.17 *= 1.6f;
				if (this.17 > (float)1196.2(20, 50))
				{
					this.61();
					this.17 = 0.0001f;
					return;
				}
				this.36(num2);
				return;
			}
		}
	}

	// Token: 0x0600233E RID: 9022 RVA: 0x0009ADD8 File Offset: 0x00098FD8
	internal void 61()
	{
		if (this.15)
		{
			this.15 = false;
			if (this.45 != null)
			{
				this.45();
			}
			2593 <<EMPTY_NAME>> = this.76(this.84());
			if (<<EMPTY_NAME>> != null && <<EMPTY_NAME>>.27() <= (2597)1)
			{
				this.90(this.84(), true);
				return;
			}
			this.92(this.84(), true);
		}
	}

	// Token: 0x0600233F RID: 9023 RVA: 0x0009AE3C File Offset: 0x0009903C
	internal void 62()
	{
		if (this.19.Count != 0 && !this.15)
		{
			2573.2589 value = this.19.Last.Value;
			this.91(value.1, true, value.2, false);
			this.19.RemoveLast();
		}
	}

	// Token: 0x06002340 RID: 9024 RVA: 0x0009AE90 File Offset: 0x00099090
	private double 63(int 1, double 2)
	{
		if (this.14 <= 0.0 || 1 < 0)
		{
			return -1.0;
		}
		return Math.Max(0.0, this.13[1] + 2) / this.14;
	}

	// Token: 0x06002341 RID: 9025 RVA: 0x0009AEDF File Offset: 0x000990DF
	internal double 64()
	{
		return this.29;
	}

	// Token: 0x06002342 RID: 9026 RVA: 0x0009AEE7 File Offset: 0x000990E7
	private void 65(double 1)
	{
		this.29 = 1;
	}

	// Token: 0x06002343 RID: 9027 RVA: 0x0009AEF0 File Offset: 0x000990F0
	internal double 66()
	{
		return 0.0 - this.14 * this.64();
	}

	// Token: 0x06002344 RID: 9028 RVA: 0x0009AF0C File Offset: 0x0009910C
	private bool 67(object 1, EventArgs 2)
	{
		this.27 = false;
		this.37 -= 0.4 * (1.0 + Math.Min(Math.Abs(this.37) / 2.0, 5.0));
		this.48 = 0.994;
		return true;
	}

	// Token: 0x06002345 RID: 9029 RVA: 0x0009AF74 File Offset: 0x00099174
	private void 68(double 1, double 2)
	{
		if (2 == 0.0)
		{
			this.37 = 0.0;
			this.65(1);
			return;
		}
		double num = (1 - this.64()) * this.14;
		this.48 = 2;
		this.37 = (0.0 - num) * Math.Log(this.48);
	}

	// Token: 0x06002346 RID: 9030 RVA: 0x0009AFD8 File Offset: 0x000991D8
	internal void 69(double 1)
	{
		int 2 = (this.27 && this.28 >= 0) ? this.28 : this.26;
		2593 3 = this.76(2);
		if (3 != null && 3.22 != null && !3.22.23())
		{
			2 = this.25;
		}
		this.70(2, -220.0, 1);
	}

	// Token: 0x06002347 RID: 9031 RVA: 0x0009B040 File Offset: 0x00099240
	internal void 70(int 1, double 2, double 3)
	{
		double num = this.63(1, 2);
		if (num >= 0.0)
		{
			this.68(num, 3);
		}
	}

	// Token: 0x06002348 RID: 9032 RVA: 0x0009B06C File Offset: 0x0009926C
	public void 71()
	{
		if (1535.14 == 199.Pressed)
		{
			if (this.33 && 1662.82 > 0.0)
			{
				this.47 += 1662.82;
				double num = (double)((float)(this.36 - 1555.17().Y) * 1662.70.8()) / this.47;
				this.49 = num * this.47;
				double num2 = Math.Pow((Math.Sign(num) == -Math.Sign(this.37) || Math.Abs(num) > Math.Abs(this.37)) ? 0.9 : 0.95, this.47);
				if (num != 0.0)
				{
					this.47 = 0.0;
					this.37 = this.37 * num2 + (1.0 - num2) * num;
					this.48 = ((this.37 == 0.0) ? 0.5 : Math.Max(0.5, 0.9959999918937683 - 0.002 / Math.Abs(this.37)));
				}
				if (this.28() && (double)(1555.21().X / 1662.70.3()) < 2573.38() - 200.0 && this.43 != null)
				{
					this.43(this, this.76(this.24));
				}
			}
			if (1535.19 == 199.Released && (this.21 || this.28()))
			{
				this.49 = 0.0;
				this.33 = true;
				this.47 = 0.0;
			}
		}
		else
		{
			this.33 = false;
		}
		this.36 = 1555.17().Y;
		if (1535.43 != 199.Pressed)
		{
			this.34 = false;
		}
		if ((1555.19().X < 200f && !this.33) || this.27)
		{
			this.69(0.992);
			return;
		}
		if ((1535.14 == 199.Pressed || 1535.43 == 199.Pressed) && !this.22 && 208.DistanceSquared(1555.11, 1555.21()) > 6400f)
		{
			this.22 = true;
		}
		if (1535.14 != 199.Pressed && this.34)
		{
			float num3 = 1052.19((1535.6.Y - 70f * 1662.70.3()) / ((float)1662.70.2 - 150f * 1662.70.3()), 0f, 1f);
			this.68((double)num3, 0.992);
		}
	}

	// Token: 0x06002349 RID: 9033 RVA: 0x0009B338 File Offset: 0x00099538
	private void 72()
	{
		if (!this.33)
		{
			double num = this.37;
			this.37 *= Math.Pow(this.48, 1662.82);
			this.49 = ((num != this.37) ? ((this.37 - num) / Math.Log(this.48)) : num);
			if (Math.Abs(this.37) < 0.01)
			{
				this.37 = 0.0;
				this.48 = 0.9959999918937683;
			}
		}
		if (this.14 > 0.0)
		{
			this.65(1052.20(this.49 / this.14 + this.64(), 0.0, 1.0));
		}
	}

	// Token: 0x0600234A RID: 9034 RVA: 0x0009B40D File Offset: 0x0009960D
	private double 73()
	{
		return (0.0 - this.37) / Math.Log(this.48);
	}

	// Token: 0x0600234B RID: 9035 RVA: 0x0009B42C File Offset: 0x0009962C
	internal int 74(int 1, int 2, bool 3)
	{
		do
		{
			1 += 2;
		}
		while (1 >= 0 && 1 < this.10.Count && ((this.10[1].23 && !3) || this.10[1] is 2598));
		return 1;
	}

	// Token: 0x0600234C RID: 9036 RVA: 0x0009B47A File Offset: 0x0009967A
	internal int 75()
	{
		return this.26;
	}

	// Token: 0x0600234D RID: 9037 RVA: 0x0009B482 File Offset: 0x00099682
	private 2593 76(int 1)
	{
		if (1 < 0)
		{
			return null;
		}
		return this.10[1];
	}

	// Token: 0x0600234E RID: 9038 RVA: 0x0009B496 File Offset: 0x00099696
	internal 2598 77()
	{
		return this.76(this.25) as 2598;
	}

	// Token: 0x0600234F RID: 9039 RVA: 0x0009B4A9 File Offset: 0x000996A9
	internal 1262 78()
	{
		if (!this.81())
		{
			return null;
		}
		return this.79().14;
	}

	// Token: 0x06002350 RID: 9040 RVA: 0x0009B4C0 File Offset: 0x000996C0
	internal 2593 79()
	{
		if (!this.81())
		{
			return null;
		}
		return this.76(this.26);
	}

	// Token: 0x06002351 RID: 9041 RVA: 0x0009B4D8 File Offset: 0x000996D8
	private void 80(2593 1)
	{
		this.26 = this.10.IndexOf(1);
	}

	// Token: 0x06002352 RID: 9042 RVA: 0x0009B4EC File Offset: 0x000996EC
	internal bool 81()
	{
		return this.26 >= 0;
	}

	// Token: 0x06002353 RID: 9043 RVA: 0x0009B4FA File Offset: 0x000996FA
	internal bool 82()
	{
		return this.81() && this.76(this.26).14 != null;
	}

	// Token: 0x06002354 RID: 9044 RVA: 0x0009B51A File Offset: 0x0009971A
	private bool 83()
	{
		return this.28 >= 0;
	}

	// Token: 0x06002355 RID: 9045 RVA: 0x0009B528 File Offset: 0x00099728
	internal int 84()
	{
		if (this.28 < 0)
		{
			return this.26;
		}
		return this.28;
	}

	// Token: 0x06002356 RID: 9046 RVA: 0x0009B540 File Offset: 0x00099740
	private void 85(object 1, List<1262> 2)
	{
		2573.2579 3 = new 2573.2579();
		3.1 = 2;
		List<2593> 4 = this.10.FindAll(new Predicate<2593>(3.1));
		this.94(4);
	}

	// Token: 0x06002357 RID: 9047 RVA: 0x0009B579 File Offset: 0x00099779
	internal void 86()
	{
		this.24 = -1;
		this.87();
	}

	// Token: 0x06002358 RID: 9048 RVA: 0x0009B588 File Offset: 0x00099788
	internal void 87()
	{
		if (this.28 >= 0)
		{
			2593 <<EMPTY_NAME>> = this.10[this.28];
			<<EMPTY_NAME>>.31(<<EMPTY_NAME>>.6(), 50);
		}
		this.28 = -1;
	}

	// Token: 0x06002359 RID: 9049 RVA: 0x0009B5B8 File Offset: 0x000997B8
	internal void 88()
	{
		this.86();
		this.26 = -1;
		this.25 = -1;
	}

	// Token: 0x0600235A RID: 9050 RVA: 0x0009B5CE File Offset: 0x000997CE
	private void 89()
	{
		if (this.83())
		{
			2593 <<EMPTY_NAME>> = this.10[this.28];
			<<EMPTY_NAME>>.31(1045.1(<<EMPTY_NAME>>.6(), 0.4f), 50);
		}
	}

	// Token: 0x0600235B RID: 9051 RVA: 0x0009B600 File Offset: 0x00099800
	internal void 90(int 1, bool 2)
	{
		if (1 != -1 && !(this.10[1] is 2598) && !this.10[1].23)
		{
			double num = 1662.100.4();
			while (1 > 0 && !this.10[1].5())
			{
				1--;
			}
			double num2 = double.PositiveInfinity;
			int num3 = 1;
			while (num3 < this.10.Count && this.10[num3].15 == this.10[1].15)
			{
				2593 3 = this.10[num3];
				if (3.14 != null && 3.14.38() == 2486.14())
				{
					double num4 = Math.Abs(3.14.37() - num);
					if (num4 < num2)
					{
						num2 = num4;
						1 = num3;
					}
				}
				num3 = this.74(num3, 1, false);
			}
		}
		this.92(1, 2);
	}

	// Token: 0x0600235C RID: 9052 RVA: 0x0009B704 File Offset: 0x00099904
	internal void 91(1262 1, bool 2, string 3, bool 4)
	{
		2573.2588 5 = new 2573.2588();
		5.1 = 1;
		5.2 = 3;
		int num = this.10.FindIndex(new Predicate<2593>(5.1));
		if (5.2 != null && num == -1)
		{
			this.91(5.1, 2, null, 4);
			return;
		}
		if (4)
		{
			this.90(num, 2);
			return;
		}
		this.92(num, 2);
	}

	// Token: 0x0600235D RID: 9053 RVA: 0x0009B770 File Offset: 0x00099970
	internal void 92(int 1, bool 2)
	{
		this.24 = 1;
		bool flag = false;
		bool flag2 = true;
		if (1 >= 0)
		{
			2593 3 = this.10[1];
			bool flag3 = 3 is 2598;
			2593 4 = this.79();
			if (!flag3)
			{
				this.87();
				this.26 = 1;
				if (3.22 != null && !3.22.23() && 2)
				{
					1 = this.10.IndexOf(3.22);
				}
				else if (3.27() == (2597)3)
				{
					flag2 = false;
					if (4 != null)
					{
						this.56(4);
					}
					this.56(3);
				}
				if (this.38 != null)
				{
					this.38(this, this.79().14);
				}
			}
			3 = this.10[1];
			if (3 is 2598)
			{
				if (this.25 != 1 && this.77() != null)
				{
					this.77().24(false);
				}
				this.25 = 1;
				this.77().24(!this.77().23());
				flag = this.77().23();
				if (flag3 && 4 != null && 4.14 != null)
				{
					for (int i = 1 + 1; i < this.10.Count; i++)
					{
						2593 5 = this.10[i];
						if (5.22 != 3)
						{
							break;
						}
						if (5.14 == 4.14)
						{
							this.26 = i;
							break;
						}
					}
				}
				if (this.39 != null)
				{
					this.39(this, this.77());
				}
			}
		}
		else
		{
			this.26 = 1;
			if (this.38 != null)
			{
				this.38(this, null);
			}
		}
		if (flag2)
		{
			this.42();
			this.43();
		}
		this.89();
		if (flag)
		{
			this.58();
		}
		this.69(0.99);
	}

	// Token: 0x0600235E RID: 9054 RVA: 0x0009B952 File Offset: 0x00099B52
	internal void 93(int 1)
	{
		this.97(1);
		this.98();
	}

	// Token: 0x0600235F RID: 9055 RVA: 0x0009B964 File Offset: 0x00099B64
	internal void 94(IEnumerable<2593> 1)
	{
		foreach (2593 2 in 1)
		{
			this.95(2);
		}
		this.98();
	}

	// Token: 0x06002360 RID: 9056 RVA: 0x0009B9B4 File Offset: 0x00099BB4
	private void 95(2593 1)
	{
		this.97(this.10.IndexOf(1));
	}

	// Token: 0x06002361 RID: 9057 RVA: 0x0009B9C8 File Offset: 0x00099BC8
	private int 96(int 1, bool 2)
	{
		int num = this.74(1, 1, 2);
		if (num < this.10.Count && this.76(num).14.37 == this.76(1).14.37)
		{
			return num;
		}
		int num2 = this.74(1, -1, 2);
		if (num2 >= 0)
		{
			return num2;
		}
		if (num < this.10.Count)
		{
			return num;
		}
		if (2)
		{
			return -1;
		}
		return this.96(1, true);
	}

	// Token: 0x06002362 RID: 9058 RVA: 0x0009BA48 File Offset: 0x00099C48
	private void 97(int 1)
	{
		if (1 >= 0 && this.10.Count != 0)
		{
			if (this.76(1).16())
			{
				this.11--;
			}
			if (this.26 == 1)
			{
				this.26 = this.96(1, false);
			}
			2593 2 = this.10[1];
			if (2.22 != null)
			{
				(2.22 as 2598).48.Remove(2);
			}
			this.10.RemoveAt(1);
			if (this.25 > 1)
			{
				this.25--;
			}
			else if (this.25 == 1 && 2 is 2598)
			{
				this.25 = -1;
			}
			if (this.26 > 1)
			{
				this.26--;
			}
		}
	}

	// Token: 0x06002363 RID: 9059 RVA: 0x0009BB20 File Offset: 0x00099D20
	private void 98()
	{
		if (this.81())
		{
			this.86();
			if (this.78() != null && 1272.5() != null && this.78().37 != 1272.5().37)
			{
				this.90(this.26, false);
			}
			else
			{
				this.92(this.26, false);
			}
		}
		else
		{
			this.88();
		}
		this.41();
	}

	// Token: 0x06002364 RID: 9060 RVA: 0x0009BB90 File Offset: 0x00099D90
	internal void 99(int 1)
	{
		int num = this.10[1].15;
		if (num >= 0)
		{
			int num2 = 1;
			while (--num2 >= 0 && this.10[num2].15 == num)
			{
			}
			num2++;
			int num3 = 1;
			while (++num3 < this.10.Count && this.10[num3].15 == num)
			{
			}
			2593 2 = this.79();
			if (this.100(this.10, num2, num3))
			{
				this.80(2);
				this.2();
			}
		}
	}

	// Token: 0x06002365 RID: 9061 RVA: 0x0009BC24 File Offset: 0x00099E24
	internal bool 100(List<2593> 1, int 2, int 3)
	{
		for (int i = 2 + 1; i < 3; i++)
		{
			if (this.3.Compare(1[i - 1], 1[i]) > 0)
			{
				1.Sort(2, 3 - 2, this.3);
				return true;
			}
		}
		return false;
	}

	// Token: 0x06002366 RID: 9062 RVA: 0x0009BC70 File Offset: 0x00099E70
	internal void 101()
	{
		2573.2587 <<EMPTY_NAME>> = new 2573.2587();
		<<EMPTY_NAME>>.2 = this;
		this.9++;
		<<EMPTY_NAME>>.1 = this.9;
		this.46.Method36622(new Action(<<EMPTY_NAME>>.1), (639)2);
	}

	// Token: 0x06002367 RID: 9063 RVA: 0x0009BCC4 File Offset: 0x00099EC4
	internal void 102(List<2593> 1)
	{
		for (int i = 0; i < 1.Count; i++)
		{
			int num = i;
			while (num < 1.Count && !(1[num] is 2598))
			{
				num++;
			}
			int num2 = num - i;
			if (num2 != 0)
			{
				this.100(1, i, num);
				i += num2;
			}
		}
	}

	// Token: 0x04001848 RID: 6216
	private IComparer<2593> 3;

	// Token: 0x04001849 RID: 6217
	internal 1320<2591> 4;

	// Token: 0x0400184A RID: 6218
	internal 1320<2620> 5;

	// Token: 0x0400184B RID: 6219
	internal readonly 1436 6;

	// Token: 0x0400184C RID: 6220
	private float 7 = 0.6f;

	// Token: 0x0400184D RID: 6221
	private volatile int 8;

	// Token: 0x0400184E RID: 6222
	private volatile int 9;

	// Token: 0x0400184F RID: 6223
	internal List<2593> 10 = new List<2593>();

	// Token: 0x04001850 RID: 6224
	internal int 11;

	// Token: 0x04001851 RID: 6225
	internal int 12;

	// Token: 0x04001852 RID: 6226
	private List<double> 13 = new List<double>();

	// Token: 0x04001853 RID: 6227
	private double 14 = -1.0;

	// Token: 0x04001854 RID: 6228
	internal bool 15;

	// Token: 0x04001855 RID: 6229
	private int 16;

	// Token: 0x04001856 RID: 6230
	private float 17 = 0.0001f;

	// Token: 0x04001857 RID: 6231
	private List<int> 18 = new List<int>();

	// Token: 0x04001858 RID: 6232
	private LinkedList<2573.2589> 19 = new LinkedList<2573.2589>();

	// Token: 0x04001859 RID: 6233
	internal bool 20 = true;

	// Token: 0x0400185A RID: 6234
	internal bool 21;

	// Token: 0x0400185B RID: 6235
	private bool 22;

	// Token: 0x0400185C RID: 6236
	internal bool 23;

	// Token: 0x0400185D RID: 6237
	private int 24 = -1;

	// Token: 0x0400185E RID: 6238
	private int 25 = -1;

	// Token: 0x0400185F RID: 6239
	private int 26 = -1;

	// Token: 0x04001860 RID: 6240
	private bool 27;

	// Token: 0x04001861 RID: 6241
	private int 28 = -1;

	// Token: 0x04001862 RID: 6242
	private double 29;

	// Token: 0x04001863 RID: 6243
	internal double 30;

	// Token: 0x04001864 RID: 6244
	private int 31;

	// Token: 0x04001865 RID: 6245
	private int 32;

	// Token: 0x04001866 RID: 6246
	private bool 33;

	// Token: 0x04001867 RID: 6247
	private bool 34;

	// Token: 0x04001868 RID: 6248
	private int 35 = -1;

	// Token: 0x04001869 RID: 6249
	private int 36;

	// Token: 0x0400186A RID: 6250
	private double 37;

	// Token: 0x0400186B RID: 6251
	private 2573.2575 38;

	// Token: 0x0400186C RID: 6252
	private 2573.2580 39;

	// Token: 0x0400186D RID: 6253
	private 2573.2580 40;

	// Token: 0x0400186E RID: 6254
	private 2573.2580 41;

	// Token: 0x0400186F RID: 6255
	private 2573.2580 42;

	// Token: 0x04001870 RID: 6256
	private 2573.2580 43;

	// Token: 0x04001871 RID: 6257
	private 1189 44;

	// Token: 0x04001872 RID: 6258
	private 1189 45;

	// Token: 0x04001873 RID: 6259
	private 915 46;

	// Token: 0x04001874 RID: 6260
	private double 47;

	// Token: 0x04001875 RID: 6261
	private double 48 = 0.9959999918937683;

	// Token: 0x04001876 RID: 6262
	private double 49;

	// Token: 0x02000481 RID: 1153
	// (Invoke) Token: 0x0600236D RID: 9069
	public delegate void 2580(object 1, 2593 2);

	// Token: 0x02000482 RID: 1154
	// (Invoke) Token: 0x06002371 RID: 9073
	public delegate void 2575(object 1, 1262 2);

	// Token: 0x02000483 RID: 1155
	[Serializable]
	public sealed class 2577
	{
		// Token: 0x06002374 RID: 9076 RVA: 0x0009C0F9 File Offset: 0x0009A2F9
		internal bool 1(1262 1)
		{
			return 1.98;
		}

		// Token: 0x06002375 RID: 9077 RVA: 0x0009C101 File Offset: 0x0009A301
		internal bool 2(1262 1)
		{
			return 1.72() == 2236.XH;
		}

		// Token: 0x06002376 RID: 9078 RVA: 0x0009C10C File Offset: 0x0009A30C
		internal bool 3(1262 1)
		{
			return 1.72() >= 2236.F;
		}

		// Token: 0x06002377 RID: 9079 RVA: 0x0009C11A File Offset: 0x0009A31A
		internal string 4(1262 1)
		{
			return 1.43;
		}

		// Token: 0x06002378 RID: 9080 RVA: 0x0009C122 File Offset: 0x0009A322
		internal bool 5(1262 1)
		{
			return 1.33(true) < 1.0;
		}

		// Token: 0x06002379 RID: 9081 RVA: 0x0009C136 File Offset: 0x0009A336
		internal bool 6(1262 1)
		{
			return 1.33(true) >= 11.0;
		}

		// Token: 0x0600237A RID: 9082 RVA: 0x0009C14D File Offset: 0x0009A34D
		internal bool 7(1262 1)
		{
			return 1.87 < 600000 && 1.87 >= 300000;
		}

		// Token: 0x0600237B RID: 9083 RVA: 0x0009C16E File Offset: 0x0009A36E
		internal bool 8(1262 1)
		{
			return 1.87 >= 600000;
		}

		// Token: 0x0600237C RID: 9084 RVA: 0x0009C180 File Offset: 0x0009A380
		internal bool 9(1262 1)
		{
			return 1.85() > 300.0;
		}

		// Token: 0x0600237D RID: 9085 RVA: 0x0009C193 File Offset: 0x0009A393
		internal DateTime 10(1262 1)
		{
			return 1.46;
		}

		// Token: 0x0600237E RID: 9086 RVA: 0x0009C19B File Offset: 0x0009A39B
		internal bool 11(1262 1)
		{
			return 1.85 == (1281)4 || 1.85 == (1281)5;
		}

		// Token: 0x0600237F RID: 9087 RVA: 0x0009C1B1 File Offset: 0x0009A3B1
		internal bool 12(1262 1)
		{
			return 1.85 == (1281)6;
		}

		// Token: 0x06002380 RID: 9088 RVA: 0x0009C1BC File Offset: 0x0009A3BC
		internal bool 13(1262 1)
		{
			return 1.85 == (1281)2;
		}

		// Token: 0x06002381 RID: 9089 RVA: 0x0009C1C7 File Offset: 0x0009A3C7
		internal bool 14(1262 1)
		{
			return 1.85 == (1281)1;
		}

		// Token: 0x06002382 RID: 9090 RVA: 0x0009C1D2 File Offset: 0x0009A3D2
		internal bool 15(1262 1)
		{
			return 1.3() == 2147.Osu || 1.3() == 2147.OsuMania;
		}

		// Token: 0x06002383 RID: 9091 RVA: 0x0009C1E7 File Offset: 0x0009A3E7
		internal bool 16(1262 1)
		{
			return 1.3() == 2147.CatchTheBeat;
		}

		// Token: 0x06002384 RID: 9092 RVA: 0x0009C1F2 File Offset: 0x0009A3F2
		internal bool 17(1262 1)
		{
			return 1.3() == 2147.OsuMania;
		}

		// Token: 0x04001877 RID: 6263
		public static readonly 2573.2577 beatmapTreeCallbacks = new 2573.2577();

		// Token: 0x04001878 RID: 6264
		public static Predicate<1262> predicate;

		// Token: 0x04001879 RID: 6265
		public static Predicate<2593> predicate2;

		// Token: 0x0400187A RID: 6266
		public static Predicate<1262> predicate3;

		// Token: 0x0400187B RID: 6267
		public static 2573.2576 beatmapStringSelector;

		// Token: 0x0400187C RID: 6268
		public static Predicate<1262> predicate4;

		// Token: 0x0400187D RID: 6269
		public static Predicate<1262> predicate5;

		// Token: 0x0400187E RID: 6270
		public static Predicate<1262> predicate6;

		// Token: 0x0400187F RID: 6271
		public static Predicate<1262> predicate7;

		// Token: 0x04001880 RID: 6272
		public static 2573.2576 beatmapStringSelector2;

		// Token: 0x04001881 RID: 6273
		public static 2573.2576 beatmapStringSelector3;

		// Token: 0x04001882 RID: 6274
		public static Predicate<1262> predicate8;

		// Token: 0x04001883 RID: 6275
		public static Predicate<1262> predicate9;

		// Token: 0x04001884 RID: 6276
		public static Predicate<1262> predicate10;

		// Token: 0x04001885 RID: 6277
		public static Predicate<1262> predicate11;

		// Token: 0x04001886 RID: 6278
		public static Predicate<1262> predicate12;

		// Token: 0x04001887 RID: 6279
		public static Predicate<1262> predicate13;

		// Token: 0x04001888 RID: 6280
		public static 2573.2574 beatmapDateSelector;

		// Token: 0x04001889 RID: 6281
		public static 2573.2574 beatmapDateSelector2;

		// Token: 0x0400188A RID: 6282
		public static Predicate<1262> predicate14;

		// Token: 0x0400188B RID: 6283
		public static Predicate<1262> predicate15;

		// Token: 0x0400188C RID: 6284
		public static Predicate<1262> predicate16;

		// Token: 0x0400188D RID: 6285
		public static Predicate<1262> predicate17;

		// Token: 0x0400188E RID: 6286
		public static Predicate<1262> predicate18;

		// Token: 0x0400188F RID: 6287
		public static Predicate<1262> predicate19;

		// Token: 0x04001890 RID: 6288
		public static Predicate<1262> predicate20;

		// Token: 0x04001891 RID: 6289
		public static Predicate<1262> predicate21;

		// Token: 0x04001892 RID: 6290
		public static Predicate<1262> predicate22;

		// Token: 0x04001893 RID: 6291
		public static Predicate<1262> predicate23;

		// Token: 0x04001894 RID: 6292
		public static Predicate<1262> predicate24;
	}

	// Token: 0x02000484 RID: 1156
	public sealed class 2578
	{
		// Token: 0x06002387 RID: 9095 RVA: 0x0009C209 File Offset: 0x0009A409
		internal bool 1(1262 1)
		{
			return 1.87 < this.1 * 60000 && 1.87 >= (this.1 - 1) * 60000;
		}

		// Token: 0x04001895 RID: 6293
		public int 1;
	}

	// Token: 0x02000485 RID: 1157
	public sealed class 2590
	{
		// Token: 0x06002389 RID: 9097 RVA: 0x0009C23A File Offset: 0x0009A43A
		internal bool 1(1262 1)
		{
			return 1.33(true) >= this.1 && 1.33(true) < this.1 + 1.0;
		}

		// Token: 0x04001896 RID: 6294
		public double 1;
	}

	// Token: 0x02000486 RID: 1158
	public sealed class 2585
	{
		// Token: 0x0600238B RID: 9099 RVA: 0x0009C268 File Offset: 0x0009A468
		internal void Apply()
		{
			try
			{
				if (this.1 != null)
				{
					this.2.2.61();
					this.2.2.88();
					this.2.2.1(this.2.2.10);
					this.2.2.10 = this.1;
					this.2.2.4.SetValue(this.2.3);
					this.2.2.2();
				}
				if (this.2.5 != null)
				{
					this.2.5();
				}
			}
			finally
			{
				this.2.2.8 = this.2.2.8 + 1;
			}
		}

		// Token: 0x04001897 RID: 6295
		public List<2593> 1;

		// Token: 0x04001898 RID: 6296
		public 2573.2584 2;
	}

	// Token: 0x02000487 RID: 1159
	public sealed class 2581
	{
		// Token: 0x04001899 RID: 6297
		public 2236 1;
	}

	// Token: 0x02000488 RID: 1160
	public sealed class 2584
	{
		// Token: 0x0600238E RID: 9102 RVA: 0x0009C35C File Offset: 0x0009A55C
		internal void 1()
		{
			2573.2585 <<EMPTY_NAME>> = new 2573.2585();
			<<EMPTY_NAME>>.2 = this;
			while (this.1 - this.2.8 > 1)
			{
				Thread.Sleep(1);
			}
			for (int i = 0; i < 3; i++)
			{
				try
				{
					List<2593> list = new List<2593>(1272.3.Count * 2);
					this.2.23(list, this.3, this.4);
					this.2.102(list);
					<<EMPTY_NAME>>.1 = list;
					break;
				}
				catch (Exception ex)
				{
					1338.4(ex, "grouping the song list", 1341.Runtime);
					Thread.Sleep(50);
				}
			}
			1662.89.Schedule(new 1189(<<EMPTY_NAME>>.Apply), false);
		}

		// Token: 0x0400189A RID: 6298
		public int 1;

		// Token: 0x0400189B RID: 6299
		public 2573 2;

		// Token: 0x0400189C RID: 6300
		public 2591 3;

		// Token: 0x0400189D RID: 6301
		public bool 4;

		// Token: 0x0400189E RID: 6302
		public 1189 5;
	}

	// Token: 0x02000489 RID: 1161
	public sealed class 2582
	{
		// Token: 0x06002390 RID: 9104 RVA: 0x0009C420 File Offset: 0x0009A620
		internal bool 1(1262 1)
		{
			return 2011.52(1) == this.1;
		}

		// Token: 0x0400189F RID: 6303
		public int 1;
	}

	// Token: 0x0200048A RID: 1162
	public sealed class 2583
	{
		// Token: 0x06002392 RID: 9106 RVA: 0x0009C430 File Offset: 0x0009A630
		internal bool 1(1262 1)
		{
			return 1.85() < (double)(this.1 * 60) && 1.85() >= (double)((this.1 - 1) * 60);
		}

		// Token: 0x040018A0 RID: 6304
		public int 1;
	}

	// Token: 0x0200048B RID: 1163
	// (Invoke) Token: 0x06002395 RID: 9109
	public delegate string 2576(1262 1);

	// Token: 0x0200048C RID: 1164
	// (Invoke) Token: 0x06002399 RID: 9113
	public delegate DateTime 2574(1262 1);

	// Token: 0x0200048D RID: 1165
	public struct 2589
	{
		// Token: 0x040018A1 RID: 6305
		public 1262 1;

		// Token: 0x040018A2 RID: 6306
		public string 2;
	}

	// Token: 0x0200048E RID: 1166
	public sealed class 2579
	{
		// Token: 0x0600239C RID: 9116 RVA: 0x0009C45D File Offset: 0x0009A65D
		internal bool 1(2593 1)
		{
			return 1.14 != null && this.1.Contains(1.14);
		}

		// Token: 0x040018A3 RID: 6307
		public List<1262> 1;
	}

	// Token: 0x0200048F RID: 1167
	public sealed class 2588
	{
		// Token: 0x0600239E RID: 9118 RVA: 0x0009C47A File Offset: 0x0009A67A
		internal bool 1(2593 1)
		{
			return 1.14 == this.1 && (this.2 == null || (1.22 != null && 1.22.GetDisplayTitle() == this.2));
		}

		// Token: 0x040018A4 RID: 6308
		public 1262 1;

		// Token: 0x040018A5 RID: 6309
		public string 2;
	}

	// Token: 0x02000490 RID: 1168
	public sealed class 2586
	{
		// Token: 0x040018A6 RID: 6310
		public List<2593> 1;

		// Token: 0x040018A7 RID: 6311
		public 2573.2587 2;
	}

	// Token: 0x02000491 RID: 1169
	public sealed class 2587
	{
		// Token: 0x060023A1 RID: 9121 RVA: 0x0009C4B8 File Offset: 0x0009A6B8
		internal void 1()
		{
			2573.2586 CS_0024_003C_003E8__locals13 = new 2573.2586();
			CS_0024_003C_003E8__locals13.2 = this;
			while (this.1 - this.2.8 > 1)
			{
				Thread.Sleep(1);
			}
			try
			{
				CS_0024_003C_003E8__locals13.1 = new List<2593>(1272.3.Count * 2);
				CS_0024_003C_003E8__locals13.1.AddRange(this.2.10);
				this.2.102(CS_0024_003C_003E8__locals13.1);
			}
			catch (Exception ex)
			{
				1338.4(ex, "sorting the song list", 1341.Runtime);
				1662.89.Schedule(delegate()
				{
					this.2.8 = this.2.8 + 1;
				}, false);
				return;
			}
			1662.89.Schedule(delegate()
			{
				try
				{
					CS_0024_003C_003E8__locals13.2.2.61();
					2593 <<EMPTY_NAME>> = CS_0024_003C_003E8__locals13.2.2.79();
					CS_0024_003C_003E8__locals13.2.2.10 = CS_0024_003C_003E8__locals13.1;
					CS_0024_003C_003E8__locals13.2.2.80(<<EMPTY_NAME>>);
					CS_0024_003C_003E8__locals13.2.2.2();
					CS_0024_003C_003E8__locals13.2.2.69(0.0);
				}
				finally
				{
					CS_0024_003C_003E8__locals13.2.2.8 = CS_0024_003C_003E8__locals13.2.2.8 + 1;
				}
			}, false);
		}

		// Token: 0x040018A8 RID: 6312
		public int 1;

		// Token: 0x040018A9 RID: 6313
		public 2573 2;
	}
}
