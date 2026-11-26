using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

// Token: 0x02000668 RID: 1640
[276]
internal static class 2206
{
	// Token: 0x060031B3 RID: 12723 RVA: 0x0012B5E4 File Offset: 0x001297E4
	internal static double? 1(2241 1)
	{
		2241 2 = 2206.5;
		if (1 == null || 2 == null || 2206.3 == null)
		{
			return null;
		}
		if (1 != 2 && (!(1.10 == 2.10) || !(1.7 == 2.7) || !string.Equals(1.23, 2.23, StringComparison.OrdinalIgnoreCase)))
		{
			return null;
		}
		return 2206.3;
	}

	// Token: 0x17000273 RID: 627
	// (get) Token: 0x060031B4 RID: 12724 RVA: 0x0012B666 File Offset: 0x00129866
	internal static double? Peak
	{
		get
		{
			return 2206.3;
		}
	}

	// Token: 0x060031B5 RID: 12725 RVA: 0x0012B670 File Offset: 0x00129870
	internal static void 2(2241 1, double 2)
	{
		if (1 == null || !2206.IsReady)
		{
			return;
		}
		long num = (long)(((((ulong)1.2 * 31UL + (ulong)1.1) * 31UL + (ulong)1.3) * 31UL + (ulong)1.6) * 1000003UL + (ulong)((long)1.13 * 7919L) + (ulong)((long)1.GetScore()));
		if (num == 2206.4)
		{
			return;
		}
		2206.4 = num;
		2206.5 = 1;
		double? num2 = 2206.5(1, 2);
		if (num2 != null && !double.IsNaN(num2.Value) && (2206.3 == null || num2.Value > 2206.3.Value))
		{
			2206.3 = new double?(num2.Value);
		}
	}

	// Token: 0x060031B6 RID: 12726 RVA: 0x0012B738 File Offset: 0x00129938
	internal static void 3(2241 1, 1262 2)
	{
		2206.3 = null;
		2206.4 = -1L;
		2206.5 = null;
		if (1 == null || !2237.1(2, 1.9) || (1.8 & 2023.Target) != 2023.None)
		{
			2206.1 = null;
			1338.5("pp counter: not shown for this play (" + ((1 == null || 2 == null) ? "no score or beatmap" : (((1.8 & 2023.Target) != 2023.None) ? "Target Practice" : "beatmap not playable in this mode")) + ")", 1341.Runtime, (1114)2);
			return;
		}
		2237.2240 settings = 2237.14(1, 2);
		2206.2207 3 = 2206.1;
		if (3 != null && 3.1 == settings.1)
		{
			return;
		}
		bool wholeBeatmap = settings.8 == null && settings.9 == null;
		2206.2207 4 = 2206.2;
		if (wholeBeatmap && 4 != null && 4.1 == settings.1)
		{
			2206.1 = 4;
			return;
		}
		if (3 != null && 3 != 2206.2 && 3.2 == null)
		{
			3.Cancel();
		}
		2206.2207 job = new 2206.2207
		{
			1 = settings.1
		};
		2206.1 = job;
		if (wholeBeatmap)
		{
			2206.2 = job;
		}
		new Thread(delegate()
		{
			1891 5 = null;
			try
			{
				Stopwatch stopwatch = Stopwatch.StartNew();
				2237.2240 settings;
				if (wholeBeatmap)
				{
					2206.4(job, 2, settings);
				}
				5 = 2237.16(2, settings);
				if (5 == null)
				{
					1338.5("pp counter: no difficulty calculator for this beatmap", 1341.Runtime, (1114)2);
				}
				else
				{
					job.5 = 5;
					if (!job.4)
					{
						List<KeyValuePair<double, 1890>> list = new List<KeyValuePair<double, 1890>>();
						1923 6 = new 1923();
						if (wholeBeatmap && job.3 == null)
						{
							1920 7 = 5 as 1920;
							if (7 != null)
							{
								7.12 = 6;
							}
						}
						1890 8 = 2237.17(5, settings.3, list);
						if (!job.4)
						{
							if ((8 != null & wholeBeatmap) && job.3 == null)
							{
								try
								{
									job.3 = 6.2(1923.1(8, 6.2.Count));
								}
								catch (Exception ex)
								{
									1338.4(ex, "working out the strain graph", 1341.Runtime);
								}
							}
							if (list.Count == 0 && 8 != null)
							{
								list.Add(new KeyValuePair<double, 1890>(double.MinValue, 8));
							}
							KeyValuePair<double, 1890>[] array = list.ToArray();
							Array.Sort<KeyValuePair<double, 1890>>(array, (KeyValuePair<double, 1890> 1, KeyValuePair<double, 1890> 2) => 1.Key.CompareTo(2.Key));
							job.2 = array;
							string[] array2 = new string[7];
							array2[0] = "pp counter: difficulty ready (";
							array2[1] = array.Length.ToString();
							array2[2] = " steps, ";
							array2[3] = stopwatch.ElapsedMilliseconds.ToString();
							array2[4] = " ms";
							int num = 5;
							string text;
							if (!wholeBeatmap)
							{
								string str = ", objects ";
								settings = settings;
								string str2 = ((settings.8 != null) ? settings.8.GetValueOrDefault().ToString() : null) ?? "-";
								string str3 = " to ";
								2237.2240 settings2 = settings;
								text = str + str2 + str3 + (((settings2.9 != null) ? settings2.9.GetValueOrDefault().ToString() : null) ?? "-");
							}
							else
							{
								text = string.Empty;
							}
							array2[num] = text;
							array2[6] = ")";
							1338.5(string.Concat(array2), 1341.Runtime, (1114)2);
						}
					}
				}
			}
			catch (Exception ex2)
			{
				1338.4(ex2, "working out the pp counter's difficulty", 1341.Runtime);
			}
			finally
			{
				if (5 != null)
				{
					5.ReleaseHitObjectManager();
				}
			}
		})
		{
			IsBackground = true,
			Priority = ThreadPriority.BelowNormal,
			Name = "pp counter difficulty"
		}.Start();
	}

	// Token: 0x060031B7 RID: 12727 RVA: 0x0012B908 File Offset: 0x00129B08
	private static void 4(2206.2207 1, 1262 2, 2237.2240 3)
	{
		1891 4 = null;
		try
		{
			4 = 2237.16(2, 3);
			1920 5 = 4 as 1920;
			if (5 != null)
			{
				1923 6 = new 1923();
				5.12 = 6;
				1890 7 = 2237.17(4, 3.3, null);
				if (7 != null && 6.2.Count > 0)
				{
					1.3 = 6.2(1923.1(7, 6.2.Count));
				}
			}
		}
		catch (Exception ex)
		{
			1338.4(ex, "working out the strain graph", 1341.Runtime);
		}
		finally
		{
			if (4 != null)
			{
				4.ReleaseHitObjectManager();
			}
		}
	}

	// Token: 0x17000274 RID: 628
	// (get) Token: 0x060031B8 RID: 12728 RVA: 0x0012B9AC File Offset: 0x00129BAC
	internal static 1922 StrainGraph
	{
		get
		{
			2206.2207 <<EMPTY_NAME>> = 2206.2;
			if (<<EMPTY_NAME>> == null)
			{
				return null;
			}
			return <<EMPTY_NAME>>.3;
		}
	}

	// Token: 0x17000275 RID: 629
	// (get) Token: 0x060031B9 RID: 12729 RVA: 0x0012B9C2 File Offset: 0x00129BC2
	internal static bool IsReady
	{
		get
		{
			2206.2207 <<EMPTY_NAME>> = 2206.1;
			return ((<<EMPTY_NAME>> != null) ? <<EMPTY_NAME>>.2 : null) != null;
		}
	}

	// Token: 0x17000276 RID: 630
	// (get) Token: 0x060031BA RID: 12730 RVA: 0x0012B9DC File Offset: 0x00129BDC
	internal static bool IsSupported
	{
		get
		{
			return 2206.1 != null;
		}
	}

	// Token: 0x060031BB RID: 12731 RVA: 0x0012B9E8 File Offset: 0x00129BE8
	internal static double? 5(2241 1, double 2)
	{
		1890 3 = 2206.6(2);
		double? result;
		if (3 == null || 1 == null)
		{
			result = null;
			return result;
		}
		try
		{
			result = new double?(2237.11(3, 1));
		}
		catch (Exception)
		{
			result = null;
		}
		return result;
	}

	// Token: 0x060031BC RID: 12732 RVA: 0x0012BA3C File Offset: 0x00129C3C
	internal static 1890 6(double 1)
	{
		2206.2207 2 = 2206.1;
		KeyValuePair<double, 1890>[] array = (2 != null) ? 2.2 : null;
		if (array == null || array.Length == 0)
		{
			return null;
		}
		int i = 0;
		int num = array.Length - 1;
		int num2 = 0;
		while (i <= num)
		{
			int num3 = (i + num) / 2;
			if (array[num3].Key <= 1)
			{
				num2 = num3;
				i = num3 + 1;
			}
			else
			{
				num = num3 - 1;
			}
		}
		return array[num2].Value;
	}

	// Token: 0x060031BD RID: 12733 RVA: 0x0012BAAC File Offset: 0x00129CAC
	internal static double? 7(2241 1)
	{
		2206.2207 2 = 2206.1;
		KeyValuePair<double, 1890>[] array = (2 != null) ? 2.2 : null;
		double? result;
		if (array == null || array.Length == 0 || 1 == null)
		{
			result = null;
			return result;
		}
		1890 value = array[array.Length - 1].Value;
		try
		{
			result = new double?(2237.12(value, 2237.8(value, 2237.10(1))));
		}
		catch (Exception)
		{
			result = null;
		}
		return result;
	}

	// Token: 0x040024A5 RID: 9381
	private static volatile 2206.2207 1;

	// Token: 0x040024A6 RID: 9382
	private static volatile 2206.2207 2;

	// Token: 0x040024A7 RID: 9383
	private static double? 3;

	// Token: 0x040024A8 RID: 9384
	private static long 4 = -1L;

	// Token: 0x040024A9 RID: 9385
	private static 2241 5;

	// Token: 0x02000669 RID: 1641
	[276]
	private sealed class 2207
	{
		// Token: 0x060031BF RID: 12735 RVA: 0x0012BB38 File Offset: 0x00129D38
		public void Cancel()
		{
			this.4 = true;
			1891 <<EMPTY_NAME>> = this.5;
			if (<<EMPTY_NAME>> != null)
			{
				<<EMPTY_NAME>>.11 = true;
			}
		}

		// Token: 0x040024AA RID: 9386
		public string 1;

		// Token: 0x040024AB RID: 9387
		public volatile KeyValuePair<double, 1890>[] 2;

		// Token: 0x040024AC RID: 9388
		public volatile 1922 3;

		// Token: 0x040024AD RID: 9389
		public volatile bool 4;

		// Token: 0x040024AE RID: 9390
		public volatile 1891 5;
	}
}
