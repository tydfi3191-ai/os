using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

// Token: 0x0200069E RID: 1694
[276]
internal static class 2228
{
	// Token: 0x060032C5 RID: 12997 RVA: 0x0013512C File Offset: 0x0013332C
	internal static void 1(2241 1)
	{
		if (1 == null || 1 == 2228.6)
		{
			return;
		}
		2228.6 = 1;
		try
		{
			1262 2;
			if ((2 = 1.40) == null)
			{
				2 = (1272.8(1.10) ?? 1272.5());
			}
			1262 3 = 2;
			2228.2229 4 = 2228.2(1, 3);
			4.1 = DateTime.UtcNow;
			4.2 = 2228.9();
			object obj = 2228.4;
			lock (obj)
			{
				2228.11();
				2228.5.Insert(0, 4);
				2228.10();
				2228.Save();
			}
			2228.3(4, 1, 3);
			1338.5(string.Concat(new string[]
			{
				"Play submitted locally: ",
				4.6,
				" - ",
				4.7,
				" [",
				4.8,
				"], ",
				4.29 ? 4.28 : (4.30 ? "quit" : "failed"),
				", ",
				4.27.ToString("0.00", CultureInfo.InvariantCulture),
				"%"
			}), 1341.Runtime, (1114)2);
		}
		catch (Exception ex)
		{
			1338.4(ex, "recording a recent play", 1341.Runtime);
		}
	}

	// Token: 0x060032C6 RID: 12998 RVA: 0x001352AC File Offset: 0x001334AC
	internal static 2228.2229 2(2241 1, 1262 2)
	{
		2228.2229 3 = new 2228.2229();
		3.1 = 1.7.ToUniversalTime();
		3.3 = 1.10;
		3.4 = ((2 != null) ? 2.25 : 0);
		3.5 = ((2 != null) ? 2.29 : -1);
		3.6 = ((2 != null) ? 2.7 : null);
		3.7 = ((2 != null) ? 2.10 : null);
		3.8 = ((2 != null) ? 2.89 : null);
		3.9 = ((2 != null) ? 2.43 : null);
		3.10 = 1.9;
		3.11 = 1.8;
		1940 4 = 1.44;
		3.12 = ((4 != null) ? new double?(4.Rate) : null);
		1940 5 = 1.44;
		3.13 = (5 != null && 5.AdjustPitch);
		3.17 = (int)1.2;
		3.18 = (int)1.1;
		3.19 = (int)1.3;
		3.20 = (int)1.4;
		3.21 = (int)1.5;
		3.22 = (int)1.6;
		3.23 = 1.13;
		3.24 = 1.14;
		3.25 = 1.15;
		3.26 = (long)1.GetScore();
		3.27 = (double)1.CalculateAccuracy() * 100.0;
		3.28 = (1.18 ? 1.CalculateGrade().ToString() : "F");
		3.29 = 1.18;
		3.30 = 1.19;
		3.31 = 1.20;
		3.36 = new 2100?(2099.Current);
		3.37 = ((1.8 & 2023.Relax) != 2023.None && (1.51 || 2210.45(1)));
		2228.2229 6 = 3;
		if (2 != null)
		{
			6.38 = 2.2;
			6.39 = 2.1;
			6.40 = 2.4;
			6.41 = 2.3;
			6.42 = (double)2.86().Z;
			6.43 = 2.53;
		}
		if (1.45)
		{
			6.15.Add("NL");
		}
		if (1.47)
		{
			6.15.Add("PR");
		}
		if (1.52 != null)
		{
			6.15.AddRange(1.52.1());
		}
		if (1.43 != null)
		{
			6.14 = new Dictionary<1928, float>();
			6.16 = 1.43.ExtendedLimits;
			foreach (object obj in Enum.GetValues(typeof(1928)))
			{
				1928 key = (1928)obj;
				float? num = 1.43.Get(key);
				if (num != null)
				{
					6.14[key] = num.Value;
				}
			}
		}
		return 6;
	}

	// Token: 0x060032C7 RID: 12999 RVA: 0x00135604 File Offset: 0x00133804
	private static void 3(2228.2229 1, 2241 2, 1262 3)
	{
		if (!2237.2(2, 3))
		{
			return;
		}
		if (!1.29)
		{
			1.32 = 2206.5(2, (double)2.20);
		}
		Action fill = null;
		fill = delegate()
		{
			try
			{
				1890 4 = 2237.4(2, 3, fill);
				if (4 != null)
				{
					object obj = 2228.4;
					lock (obj)
					{
						2228.2229 entry = 1;
						double value = entry.32.GetValueOrDefault();
						if (entry.32 == null)
						{
							value = 2237.11(4, 2);
							entry.32 = new double?(value);
						}
						2237.2238 5;
						1.33 = 1586.Unchoke(4, 2237.10(2), out 5);
						1.34 = new double?(2237.6(4, 2.8));
						1.35 = new double?(2237.StarRating(4));
						2228.2229 entry2 = 1;
						2092 6 = 4 as 2092;
						entry2.36 = new 2100?((6 != null) ? 6.29 : 2099.Current);
						2228.Save();
					}
				}
			}
			catch (Exception ex)
			{
				1338.4(ex, "working out a recent play's pp", 1341.Runtime);
			}
		};
		fill();
	}

	// Token: 0x060032C8 RID: 13000 RVA: 0x00135694 File Offset: 0x00133894
	internal static List<2228.2229> Get(string 1)
	{
		object obj = 2228.4;
		List<2228.2229> result;
		lock (obj)
		{
			2228.11();
			2228.10();
			List<2228.2229> list = (from 1 in 2228.5
			where string.Equals(1.2, 2, StringComparison.Ordinal)
			select 1).ToList<2228.2229>();
			Action<2228.2229> action;
			if ((action = 2228.<>O.<0>__MatchRelaxSystem) == null)
			{
				action = (2228.<>O.<0>__MatchRelaxSystem = new Action<2228.2229>(2228.4));
			}
			list.ForEach(action);
			result = list;
		}
		return result;
	}

	// Token: 0x060032C9 RID: 13001 RVA: 0x00135724 File Offset: 0x00133924
	private static void 4(2228.2229 1)
	{
		2100 2 = 2099.Current;
		if (1.10 == 2147.Osu && 2099.1(1.11))
		{
			2100? 3 = 1.36;
			2100 4 = 2;
			if (!(3.GetValueOrDefault() == 4 & 3 != null))
			{
				1.32 = null;
				1.33 = null;
				1.34 = null;
				1.35 = null;
				1.36 = new 2100?(2);
				return;
			}
		}
	}

	// Token: 0x060032CA RID: 13002 RVA: 0x001357A8 File Offset: 0x001339A8
	internal static int 5(List<2228.2229> 1, int 2)
	{
		2228.2229 3 = 1[2];
		int num = 1;
		int num2 = 2 + 1;
		while (num2 < 1.Count && 1[num2].3 == 3.3 && 2228.6(1[num2], 3))
		{
			num++;
			num2++;
		}
		return num;
	}

	// Token: 0x060032CB RID: 13003 RVA: 0x00135800 File Offset: 0x00133A00
	private static bool 6(2228.2229 1, 2228.2229 2)
	{
		if (2228.7(3.11) == 2228.7(2.11) && Nullable.Equals<double>(3.12, 2.12) && 2228.8(3, 2))
		{
			return (from 1 in 3.15
			orderby 1
			select 1).SequenceEqual(from 1 in 2.15
			orderby 1
			select 1);
		}
		return false;
	}

	// Token: 0x060032CC RID: 13004 RVA: 0x0013589C File Offset: 0x00133A9C
	private static 2023 7(2023 1)
	{
		if ((1 & 2023.Nightcore) != 2023.None)
		{
			1 = ((1 & ~2023.Nightcore) | 2023.DoubleTime);
		}
		if ((1 & 2023.Perfect) != 2023.None)
		{
			1 = ((1 & ~2023.Perfect) | 2023.SuddenDeath);
		}
		return 1;
	}

	// Token: 0x060032CD RID: 13005 RVA: 0x001358CC File Offset: 0x00133ACC
	private static bool 8(2228.2229 1, 2228.2229 2)
	{
		if (3.14 == null || 2.14 == null)
		{
			return 3.14 == null && 2.14 == null;
		}
		return 3.14.Count == 2.14.Count && 3.14.All(delegate(KeyValuePair<1928, float> 1)
		{
			float num;
			return 2.14.TryGetValue(1.Key, out num) && num == 1.Value;
		});
	}

	// Token: 0x060032CE RID: 13006 RVA: 0x0013594A File Offset: 0x00133B4A
	private static string 9()
	{
		return 1304.189.GetValue() ?? string.Empty;
	}

	// Token: 0x060032CF RID: 13007 RVA: 0x00135960 File Offset: 0x00133B60
	private static void 10()
	{
		DateTime oldest = DateTime.UtcNow - 2228.2;
		2228.5.RemoveAll((2228.2229 1) => 1.1 < oldest);
		Dictionary<string, int> perProfile = new Dictionary<string, int>(StringComparer.Ordinal);
		2228.5.RemoveAll(delegate(2228.2229 1)
		{
			int num;
			perProfile.TryGetValue(1.2 ?? string.Empty, out num);
			perProfile[1.2 ?? string.Empty] = num + 1;
			return num >= 100;
		});
	}

	// Token: 0x17000281 RID: 641
	// (get) Token: 0x060032D0 RID: 13008 RVA: 0x001359C6 File Offset: 0x00133BC6
	private static string FilePath
	{
		get
		{
			return 268.2("nekiosu.recent.json");
		}
	}

	// Token: 0x060032D1 RID: 13009 RVA: 0x001359D4 File Offset: 0x00133BD4
	private static void 11()
	{
		if (2228.5 != null)
		{
			return;
		}
		2228.5 = new List<2228.2229>();
		foreach (string text in new string[]
		{
			2228.FilePath,
			2672.31(2228.FilePath)
		})
		{
			try
			{
				if (File.Exists(text))
				{
					foreach (226 <<EMPTY_NAME>> in ((IEnumerable<226>)226.Parse(File.ReadAllText(text, Encoding.UTF8))))
					{
						2228.5.Add(2228.14(<<EMPTY_NAME>>));
					}
					break;
				}
			}
			catch (Exception ex)
			{
				2228.5.Clear();
				1338.4(ex, "reading " + Path.GetFileName(text), 1341.Runtime);
				try
				{
					File.Copy(text, text + ".unreadable", true);
				}
				catch (Exception)
				{
				}
			}
		}
	}

	// Token: 0x060032D2 RID: 13010 RVA: 0x00135ADC File Offset: 0x00133CDC
	private static void Save()
	{
		try
		{
			IEnumerable<2228.2229> source = 2228.5;
			Func<2228.2229, 217> selector;
			if ((selector = 2228.<>O.<1>__Write) == null)
			{
				selector = (2228.<>O.<1>__Write = new Func<2228.2229, 217>(2228.12));
			}
			109 <<EMPTY_NAME>> = new 109(source.Select(selector));
			byte[] bytes = Encoding.UTF8.GetBytes(<<EMPTY_NAME>>.ToString((95)0, Array.Empty<214>()));
			using (2681 2 = new 2681(2228.FilePath))
			{
				2.Write(bytes, 0, bytes.Length);
			}
		}
		catch (Exception ex)
		{
			1338.4(ex, "saving nekiosu.recent.json", 1341.Runtime);
		}
	}

	// Token: 0x060032D3 RID: 13011 RVA: 0x00135B78 File Offset: 0x00133D78
	private static 217 12(2228.2229 1)
	{
		217 2 = new 217();
		2["time"] = 1.1.ToString("o", CultureInfo.InvariantCulture);
		2["profile"] = 1.2;
		2["hash"] = 1.3;
		2["beatmap_id"] = 1.4;
		2["set_id"] = 1.5;
		2["artist"] = 1.6;
		2["title"] = 1.7;
		2["version"] = 1.8;
		2["creator"] = 1.9;
		2["mode"] = (int)1.10;
		2["mods"] = (int)1.11;
		2["n300"] = 1.17;
		2["n100"] = 1.18;
		2["n50"] = 1.19;
		2["geki"] = 1.20;
		2["katu"] = 1.21;
		2["miss"] = 1.22;
		2["combo"] = 1.23;
		2["map_combo_stable"] = 1.24;
		2["map_objects"] = 1.25;
		2["score"] = 1.26;
		2["accuracy"] = 1.27;
		2["grade"] = 1.28;
		2["passed"] = 1.29;
		2["quit"] = 1.30;
		2["end_time"] = 1.31;
		2["relax_normal_multiplier"] = 1.37;
		2["cs"] = 1.38;
		2["ar"] = 1.39;
		2["od"] = 1.40;
		2["hp"] = 1.41;
		2["bpm"] = 1.42;
		2["drain"] = 1.43;
		217 3 = 2;
		if (1.15.Count > 0)
		{
			3["extra"] = new 109(1.15);
		}
		if (1.32 != null)
		{
			3["pp"] = 1.32.Value;
		}
		if (1.35 != null)
		{
			3["if_fc_pp"] = 1.33;
			3["max_pp"] = 1.34;
			3["stars"] = 1.35.Value;
		}
		if (1.36 != null && 2099.1(1.11))
		{
			3["relax_pp_system"] = (int)1.36.Value;
		}
		if (1.12 != null)
		{
			3["rate"] = 1.12.Value;
			3["adjust_pitch"] = 1.13;
		}
		if (1.14 != null)
		{
			217 4 = new 217();
			foreach (KeyValuePair<1928, float> keyValuePair in 1.14)
			{
				4[((int)keyValuePair.Key).ToString(CultureInfo.InvariantCulture)] = keyValuePair.Value;
			}
			3["difficulty_adjust"] = 4;
			3["difficulty_adjust_extended"] = 1.16;
		}
		return 3;
	}

	// Token: 0x060032D4 RID: 13012 RVA: 0x0013601C File Offset: 0x0013421C
	private static DateTime 13(226 1)
	{
		if (1 != null && 1.Type == 705.Date)
		{
			return ((DateTime)1).ToUniversalTime();
		}
		return DateTime.Parse((string)1, CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind).ToUniversalTime();
	}

	// Token: 0x060032D5 RID: 13013 RVA: 0x00136064 File Offset: 0x00134264
	private static 2228.2229 14(226 1)
	{
		2228.2229 2 = new 2228.2229();
		2.1 = 2228.13(7["time"]);
		2.2 = (string)7["profile"];
		2.3 = (string)7["hash"];
		2.4 = ((int?)7["beatmap_id"]).GetValueOrDefault();
		2.5 = ((int?)7["set_id"]).GetValueOrDefault(-1);
		2.6 = (string)7["artist"];
		2.7 = (string)7["title"];
		2.8 = (string)7["version"];
		2.9 = (string)7["creator"];
		2.10 = (2147)((int?)7["mode"]).GetValueOrDefault();
		2.11 = (2023)((int?)7["mods"]).GetValueOrDefault();
		2.17 = ((int?)7["n300"]).GetValueOrDefault();
		2.18 = ((int?)7["n100"]).GetValueOrDefault();
		2.19 = ((int?)7["n50"]).GetValueOrDefault();
		2.20 = ((int?)7["geki"]).GetValueOrDefault();
		2.21 = ((int?)7["katu"]).GetValueOrDefault();
		2.22 = ((int?)7["miss"]).GetValueOrDefault();
		2.23 = ((int?)7["combo"]).GetValueOrDefault();
		2.24 = ((int?)7["map_combo_stable"]).GetValueOrDefault();
		2.25 = ((int?)7["map_objects"]).GetValueOrDefault();
		2.26 = ((long?)7["score"]).GetValueOrDefault();
		2.27 = ((double?)7["accuracy"]).GetValueOrDefault();
		2.28 = (((string)7["grade"]) ?? "F");
		2.29 = ((bool?)7["passed"]).GetValueOrDefault();
		2.30 = ((bool?)7["quit"]).GetValueOrDefault();
		2.31 = ((int?)7["end_time"]).GetValueOrDefault();
		2.37 = ((bool?)7["relax_normal_multiplier"]).GetValueOrDefault();
		2.12 = (double?)7["rate"];
		2.13 = ((bool?)7["adjust_pitch"]).GetValueOrDefault();
		2.32 = (double?)7["pp"];
		2.33 = (double?)7["if_fc_pp"];
		2.34 = (double?)7["max_pp"];
		2.35 = (double?)7["stars"];
		int? num = (int?)7["relax_pp_system"];
		2.36 = ((num != null) ? new 2100?((2100)num.GetValueOrDefault()) : null);
		2.38 = ((float?)7["cs"]).GetValueOrDefault();
		2.39 = ((float?)7["ar"]).GetValueOrDefault();
		2.40 = ((float?)7["od"]).GetValueOrDefault();
		2.41 = ((float?)7["hp"]).GetValueOrDefault();
		2.42 = ((double?)7["bpm"]).GetValueOrDefault();
		2.43 = ((int?)7["drain"]).GetValueOrDefault();
		2228.2229 3 = 2;
		109 4 = 7["extra"] as 109;
		if (4 != null)
		{
			3.15.AddRange(from 1 in 4
			select (string)1 into 1
			where !string.IsNullOrEmpty(1)
			select 1);
		}
		217 5 = 7["difficulty_adjust"] as 217;
		if (5 != null)
		{
			3.14 = new Dictionary<1928, float>();
			foreach (222 6 in 5.Properties())
			{
				3.14[(1928)int.Parse(6.Name, CultureInfo.InvariantCulture)] = (float)6.Value;
			}
			3.16 = ((bool?)7["difficulty_adjust_extended"]).GetValueOrDefault();
		}
		return 3;
	}

	// Token: 0x04002584 RID: 9604
	internal const int 1 = 100;

	// Token: 0x04002585 RID: 9605
	internal static readonly TimeSpan 2 = TimeSpan.FromHours(24.0);

	// Token: 0x04002586 RID: 9606
	private const string 3 = "nekiosu.recent.json";

	// Token: 0x04002587 RID: 9607
	private static readonly object 4 = new object();

	// Token: 0x04002588 RID: 9608
	private static List<2228.2229> 5;

	// Token: 0x04002589 RID: 9609
	private static 2241 6;

	// Token: 0x0200069F RID: 1695
	[276]
	internal sealed class 2229
	{
		// Token: 0x17000282 RID: 642
		// (get) Token: 0x060032D7 RID: 13015 RVA: 0x00136620 File Offset: 0x00134820
		public int TotalHits
		{
			get
			{
				switch (this.10)
				{
				case 2147.Taiko:
					return this.17 + this.18 + this.22;
				case 2147.CatchTheBeat:
					return this.17 + this.18 + this.19 + this.22 + this.21;
				case 2147.OsuMania:
					return this.17 + this.18 + this.19 + this.22 + this.21 + this.20;
				default:
					return this.17 + this.18 + this.19 + this.22;
				}
			}
		}

		// Token: 0x0400258A RID: 9610
		public DateTime 1;

		// Token: 0x0400258B RID: 9611
		public string 2;

		// Token: 0x0400258C RID: 9612
		public string 3;

		// Token: 0x0400258D RID: 9613
		public int 4;

		// Token: 0x0400258E RID: 9614
		public int 5;

		// Token: 0x0400258F RID: 9615
		public string 6;

		// Token: 0x04002590 RID: 9616
		public string 7;

		// Token: 0x04002591 RID: 9617
		public string 8;

		// Token: 0x04002592 RID: 9618
		public string 9;

		// Token: 0x04002593 RID: 9619
		public 2147 10;

		// Token: 0x04002594 RID: 9620
		public 2023 11;

		// Token: 0x04002595 RID: 9621
		public double? 12;

		// Token: 0x04002596 RID: 9622
		public bool 13;

		// Token: 0x04002597 RID: 9623
		public Dictionary<1928, float> 14;

		// Token: 0x04002598 RID: 9624
		public List<string> 15 = new List<string>();

		// Token: 0x04002599 RID: 9625
		public bool 16;

		// Token: 0x0400259A RID: 9626
		public int 17;

		// Token: 0x0400259B RID: 9627
		public int 18;

		// Token: 0x0400259C RID: 9628
		public int 19;

		// Token: 0x0400259D RID: 9629
		public int 20;

		// Token: 0x0400259E RID: 9630
		public int 21;

		// Token: 0x0400259F RID: 9631
		public int 22;

		// Token: 0x040025A0 RID: 9632
		public int 23;

		// Token: 0x040025A1 RID: 9633
		public int 24;

		// Token: 0x040025A2 RID: 9634
		public int 25;

		// Token: 0x040025A3 RID: 9635
		public long 26;

		// Token: 0x040025A4 RID: 9636
		public double 27;

		// Token: 0x040025A5 RID: 9637
		public string 28;

		// Token: 0x040025A6 RID: 9638
		public bool 29;

		// Token: 0x040025A7 RID: 9639
		public bool 30;

		// Token: 0x040025A8 RID: 9640
		public int 31;

		// Token: 0x040025A9 RID: 9641
		public double? 32;

		// Token: 0x040025AA RID: 9642
		public double? 33;

		// Token: 0x040025AB RID: 9643
		public double? 34;

		// Token: 0x040025AC RID: 9644
		public double? 35;

		// Token: 0x040025AD RID: 9645
		public 2100? 36;

		// Token: 0x040025AE RID: 9646
		public bool 37;

		// Token: 0x040025AF RID: 9647
		public float 38;

		// Token: 0x040025B0 RID: 9648
		public float 39;

		// Token: 0x040025B1 RID: 9649
		public float 40;

		// Token: 0x040025B2 RID: 9650
		public float 41;

		// Token: 0x040025B3 RID: 9651
		public double 42;

		// Token: 0x040025B4 RID: 9652
		public int 43;
	}

	// Token: 0x020006A0 RID: 1696
	[CompilerGenerated]
	[276]
	private static class <>O
	{
		// Token: 0x040025B5 RID: 9653
		public static Action<2228.2229> <0>__MatchRelaxSystem;

		// Token: 0x040025B6 RID: 9654
		public static Func<2228.2229, 217> <1>__Write;
	}
}
