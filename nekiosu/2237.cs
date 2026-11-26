using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

// Token: 0x020006B3 RID: 1715
[276]
internal static class 2237
{
	// Token: 0x0600331D RID: 13085 RVA: 0x001384A4 File Offset: 0x001366A4
	internal static bool 1(1262 1, 2147 2)
	{
		if (1 == null || 2 < 2147.Osu || 2 > 2147.OsuMania)
		{
			return false;
		}
		2147 3 = 1.3();
		return 3 == 2 || 3 == 2147.Osu;
	}

	// Token: 0x0600331E RID: 13086 RVA: 0x001384CF File Offset: 0x001366CF
	public static bool 2(2241 1, 1262 2)
	{
		return 1 != null && 2237.1(2, 1.9) && (1.8 & (2023.Autoplay | 2023.Cinema | 2023.Target)) == 2023.None;
	}

	// Token: 0x0600331F RID: 13087 RVA: 0x001384F8 File Offset: 0x001366F8
	public static double? Get(2241 1, 1262 2, Action 3)
	{
		1890 4 = 2237.4(1, 2, 3);
		if (4 != null)
		{
			return new double?(2237.11(4, 1));
		}
		return null;
	}

	// Token: 0x06003320 RID: 13088 RVA: 0x00138527 File Offset: 0x00136727
	public static bool HasFailed(2241 1, 1262 2)
	{
		return 2237.2(1, 2) && 2237.HasFailed(2237.14(1, 2).1);
	}

	// Token: 0x06003321 RID: 13089 RVA: 0x00138545 File Offset: 0x00136745
	internal static bool HasFailed(1262 1, 2147 2, 2023 3, 1927 4, 1940 5)
	{
		return 2237.1(1, 2) && 2237.HasFailed(2237.15(1, 2, 3, 4, 5, null).1);
	}

	// Token: 0x06003322 RID: 13090 RVA: 0x00138568 File Offset: 0x00136768
	private static bool HasFailed(string 1)
	{
		object obj = 2237.2;
		bool result;
		lock (obj)
		{
			1890 2;
			result = (2237.3.TryGetValue(1, out 2) && 2 == null);
		}
		return result;
	}

	// Token: 0x06003323 RID: 13091 RVA: 0x001385BC File Offset: 0x001367BC
	public static double? 3(2241 1, 1262 2, Action 3)
	{
		1890 4 = 2237.4(1, 2, 3);
		if (4 != null)
		{
			return new double?(2237.12(4, 2237.8(4, 2237.10(1))));
		}
		return null;
	}

	// Token: 0x06003324 RID: 13092 RVA: 0x001385F6 File Offset: 0x001367F6
	internal static 1890 4(2241 1, 1262 2, Action 3)
	{
		if (!2237.2(1, 2))
		{
			return null;
		}
		return 2237.18(2237.14(1, 2), 2, 3);
	}

	// Token: 0x06003325 RID: 13093 RVA: 0x00138611 File Offset: 0x00136811
	internal static 1890 5(1262 1, 2147 2, 2023 3, 1927 4, 1940 5, Action 6)
	{
		if (!2237.1(1, 2))
		{
			return null;
		}
		return 2237.18(2237.15(1, 2, 3, 4, 5, null), 1, 6);
	}

	// Token: 0x06003326 RID: 13094 RVA: 0x00138634 File Offset: 0x00136834
	internal static double StarRating(1890 1)
	{
		2092 2 = 1 as 2092;
		double? num;
		if (2 == null)
		{
			num = null;
		}
		else
		{
			2077 3 = 2.30;
			num = ((3 != null) ? new double?(3.10) : null);
		}
		double? num2 = num;
		if (num2 == null)
		{
			return 1.3;
		}
		return num2.GetValueOrDefault();
	}

	// Token: 0x06003327 RID: 13095 RVA: 0x0013868C File Offset: 0x0013688C
	internal static double 6(1890 1, 2023 2)
	{
		return 2237.12(1, 2237.7(1, 2));
	}

	// Token: 0x06003328 RID: 13096 RVA: 0x0013869C File Offset: 0x0013689C
	internal static 2237.2238 7(1890 1, 2023 2)
	{
		2237.2238 result = new 2237.2238
		{
			1 = 2,
			11 = true
		};
		2092 3 = 1 as 2092;
		if (3 == null)
		{
			2170 4 = 1 as 2170;
			if (4 == null)
			{
				1841 5 = 1 as 1841;
				if (5 == null)
				{
					1956 6 = 1 as 1956;
					if (6 != null)
					{
						result.5 = 6.4;
					}
				}
				else
				{
					result.2 = 5.7;
					result.3 = 5.8;
					result.4 = 5.9;
					result.8 = 5.4;
				}
			}
			else
			{
				result.2 = 4.11;
				result.8 = 4.11;
			}
		}
		else
		{
			result.2 = 3.19 + 3.20 + 3.21;
			result.8 = 3.17;
		}
		return result;
	}

	// Token: 0x06003329 RID: 13097 RVA: 0x00138788 File Offset: 0x00136988
	internal static 2237.2238 8(1890 1, 2237.2238 2)
	{
		2237.2238 result = 2;
		result.7 = 0;
		result.11 = true;
		result.9 = 0L;
		2092 3 = 1 as 2092;
		if (3 == null)
		{
			2170 4 = 1 as 2170;
			if (4 == null)
			{
				1841 5 = 1 as 1841;
				if (5 == null)
				{
					1956 6 = 1 as 1956;
					if (6 != null)
					{
						result.5 = Math.Max(0, 6.4 - 2.2 - 2.6 - 2.3 - 2.4);
					}
				}
				else
				{
					result.2 = 5.7;
					result.3 = 5.8;
					result.8 = 5.4;
				}
			}
			else
			{
				result.2 = Math.Max(0, 4.11 - 2.3);
				result.8 = 4.11;
			}
		}
		else
		{
			result.2 = Math.Max(0, 3.19 + 3.20 + 3.21 - 2.3 - 2.4);
			result.8 = 3.17;
		}
		return result;
	}

	// Token: 0x0600332A RID: 13098 RVA: 0x001388A8 File Offset: 0x00136AA8
	internal static 2237.2238 9(1890 1, 2023 2, double 3)
	{
		2237.2238 4 = new 2237.2238
		{
			1 = 2,
			11 = true
		};
		double num = Math.Max(0.0, 1.0 - 3);
		2092 5 = 1 as 2092;
		if (5 == null)
		{
			2170 6 = 1 as 2170;
			if (6 == null)
			{
				1841 7 = 1 as 1841;
				if (7 == null)
				{
					1956 8 = 1 as 1956;
					if (8 != null)
					{
						4.3 = Math.Min(8.4, (int)Math.Round(num * 1.5 * (double)8.4));
						4.5 = 8.4 - 4.3;
					}
				}
				else
				{
					int num2 = 7.7 + 7.8 + 7.9;
					4.6 = Math.Min(7.9, (int)Math.Round(num * (double)num2));
					4.2 = 7.7;
					4.3 = 7.8;
					4.4 = 7.9 - 4.6;
					4.8 = 7.4;
				}
			}
			else
			{
				4.3 = Math.Min(6.11, (int)Math.Round(num * 2.0 * (double)6.11));
				4.2 = 6.11 - 4.3;
				4.8 = 6.11;
			}
		}
		else
		{
			int num3 = 5.19 + 5.20 + 5.21;
			4.3 = Math.Min(num3, (int)Math.Round(num * 1.5 * (double)num3));
			4.2 = num3 - 4.3;
			4.8 = 5.17;
		}
		return 4;
	}

	// Token: 0x0600332B RID: 13099 RVA: 0x00138A90 File Offset: 0x00136C90
	internal static 2237.2238 10(2241 1)
	{
		return new 2237.2238
		{
			1 = 1.8,
			2 = (int)1.2,
			3 = (int)1.1,
			4 = (int)1.3,
			5 = (int)1.4,
			6 = (int)1.5,
			7 = (int)1.6,
			8 = 1.13,
			9 = (long)1.GetScore(),
			10 = (1.51 || 2210.45(1))
		};
	}

	// Token: 0x0600332C RID: 13100 RVA: 0x00138B39 File Offset: 0x00136D39
	internal static double 11(1890 1, 2241 2)
	{
		return 2237.12(1, 2237.10(2));
	}

	// Token: 0x0600332D RID: 13101 RVA: 0x00138B48 File Offset: 0x00136D48
	internal static double 12(1890 1, 2237.2238 2)
	{
		2092 3 = 1 as 2092;
		if (3 != null)
		{
			return 2096.1(3, new 2096.2097
			{
				1 = 2.1,
				2 = 2.2,
				3 = 2.3,
				4 = 2.4,
				5 = 2.7,
				6 = 2.8,
				7 = 2.9,
				8 = 2.11,
				9 = 2.10
			});
		}
		2170 4 = 1 as 2170;
		if (4 != null)
		{
			return 2173.1(4, new 2173.2174
			{
				1 = 2.1,
				2 = 2.2,
				3 = 2.3,
				4 = 2.7
			});
		}
		1841 5 = 1 as 1841;
		if (5 != null)
		{
			return 1845.1(5, new 1845.1846
			{
				1 = 2.1,
				2 = 2.2,
				3 = 2.3,
				4 = 2.4,
				5 = 2.6,
				6 = 2.7,
				7 = 2.8
			});
		}
		1956 6 = 1 as 1956;
		if (6 == null)
		{
			return 0.0;
		}
		return 1960.1(6, new 1960.1961
		{
			1 = 2.1,
			2 = 2.5,
			3 = 2.2,
			4 = 2.6,
			5 = 2.3,
			6 = 2.4,
			7 = 2.7
		});
	}

	// Token: 0x0600332E RID: 13102 RVA: 0x00138D38 File Offset: 0x00136F38
	internal static 1925 13(2241 1)
	{
		1925 2 = 1.52;
		if (2 == null)
		{
			return null;
		}
		switch (1.9)
		{
		case 2147.Osu:
		case 2147.CatchTheBeat:
			if (2.7 == null)
			{
				return null;
			}
			return 2;
		case 2147.Taiko:
			if (2.7 == null && 2.5 == null)
			{
				return null;
			}
			return 2;
		default:
			return null;
		}
	}

	// Token: 0x0600332F RID: 13103 RVA: 0x00138D94 File Offset: 0x00136F94
	internal static 2237.2240 14(2241 1, 1262 2)
	{
		2023 3 = 1.46 ? (1.8 & ~2023.Hidden) : 1.8;
		2237.2240 4 = 2237.15(2, 1.9, 3, 1.43, 1.44, 2237.13(1));
		if (1.47 && 1.48 != null)
		{
			4.8 = 1.48;
			4.9 = 1.49;
			2237.2240 5 = 4;
			5.1 = string.Concat(new string[]
			{
				5.1,
				"|window ",
				1.48.Value.ToString(),
				"-",
				(1.49 != null) ? 1.49.Value.ToString() : "end"
			});
		}
		return 4;
	}

	// Token: 0x06003330 RID: 13104 RVA: 0x00138E88 File Offset: 0x00137088
	private static 2237.2240 15(1262 1, 2147 2, 2023 3, 1927 4, 1940 5, 1925 6)
	{
		2237.2240 7 = new 2237.2240
		{
			2 = 2,
			5 = 5,
			6 = 6
		};
		7.7 = 2099.Current;
		3 &= (2023.Easy | 2023.TouchDevice | 2023.Hidden | 2023.HardRock | 2023.DoubleTime | 2023.Relax | 2023.HalfTime | 2023.Flashlight | 2023.Relax2 | 2023.Key4 | 2023.Key5 | 2023.Key6 | 2023.Key7 | 2023.Key8 | 2023.Key9 | 2023.KeyCoop | 2023.Key1 | 2023.Key3 | 2023.Key2);
		string text = string.Empty;
		if (2 == 2147.Osu)
		{
			text = 2099.Tag(3, 7.7);
			3 = 2099.2(3, 7.7);
		}
		7.3 = 3;
		7.4 = ((4 != null && !4.IsEmpty) ? 4 : null);
		string text2;
		if (6 != null)
		{
			string[] array = new string[8];
			array[0] = "|conversion ";
			int num = 1;
			1938 8 = 6.7;
			array[num] = ((8 != null) ? new int?(8.4) : null).ToString();
			array[2] = " ";
			int num2 = 3;
			1938 9 = 6.7;
			array[num2] = ((9 != null) ? 9.5.ToString(1662.18) : null);
			array[4] = " ";
			int num3 = 5;
			1938 10 = 6.7;
			array[num3] = ((10 != null) ? new int?(10.9) : null).ToString();
			array[6] = " ";
			array[7] = 6.5.ToString();
			text2 = string.Concat(array);
		}
		else
		{
			text2 = string.Empty;
		}
		string text3 = text2;
		2237.2240 11 = 7;
		string[] array2 = new string[10];
		int num4 = 0;
		int num5;
		string text4;
		if (2 != 2147.Osu)
		{
			string str = "mode";
			num5 = (int)2;
			text4 = str + num5.ToString() + "|";
		}
		else
		{
			text4 = string.Empty;
		}
		array2[num4] = text4;
		array2[1] = 1.23;
		array2[2] = "|";
		int num6 = 3;
		num5 = (int)3;
		array2[num6] = num5.ToString();
		array2[4] = "|";
		int num7 = 5;
		1927 12 = 7.4;
		array2[num7] = ((12 != null) ? 12.1() : null);
		array2[6] = "|";
		array2[7] = ((5 != null) ? 5.1() : null);
		array2[8] = text3;
		array2[9] = ((text.Length > 0) ? ("|" + text) : string.Empty);
		11.1 = string.Concat(array2);
		return 7;
	}

	// Token: 0x06003331 RID: 13105 RVA: 0x00139090 File Offset: 0x00137290
	internal static 1891 16(1262 1, 2237.2240 2)
	{
		1891 3 = 1.17(2.2);
		if (3 == null)
		{
			return null;
		}
		3.5 = 2.4;
		3.6 = 2.5;
		3.7 = 2.6;
		3.9 = 2.8;
		3.10 = 2.9;
		2093 4 = 3 as 2093;
		if (4 != null)
		{
			4.14 = true;
			4.13 = 2.7;
		}
		return 3;
	}

	// Token: 0x06003332 RID: 13106 RVA: 0x0013910C File Offset: 0x0013730C
	internal static 1890 17(1891 1, 2023 2, List<KeyValuePair<double, 1890>> 3)
	{
		1890 4 = null;
		2093 5 = 1 as 2093;
		if (5 == null)
		{
			2171 6 = 1 as 2171;
			if (6 == null)
			{
				1850 7 = 1 as 1850;
				if (7 == null)
				{
					1957 8 = 1 as 1957;
					if (8 != null)
					{
						List<KeyValuePair<double, 1956>> 9 = (3 != null) ? new List<KeyValuePair<double, 1956>>() : null;
						8.14 = 9;
						8.12(2, null, null);
						4 = 8.13;
						2237.Copy<1956>(9, 3);
					}
				}
				else
				{
					List<KeyValuePair<double, 1841>> 10 = (3 != null) ? new List<KeyValuePair<double, 1841>>() : null;
					7.14 = 10;
					7.12(2, null, null);
					4 = 7.13;
					2237.Copy<1841>(10, 3);
				}
			}
			else
			{
				List<KeyValuePair<double, 2170>> 11 = (3 != null) ? new List<KeyValuePair<double, 2170>>() : null;
				6.19 = 11;
				6.12(2, null, null);
				4 = 6.18;
				2237.Copy<2170>(11, 3);
			}
		}
		else
		{
			List<KeyValuePair<double, 2092>> 12 = (3 != null) ? new List<KeyValuePair<double, 2092>>() : null;
			5.15 = 12;
			5.12(2, null, null);
			4 = ((5.18 != null && 5.18.4) ? 5.18 : null);
			2237.Copy<2092>(12, 3);
		}
		if (4 != null)
		{
			4.2 = null;
		}
		return 4;
	}

	// Token: 0x06003333 RID: 13107 RVA: 0x00139238 File Offset: 0x00137438
	private static void Copy<T>(List<KeyValuePair<double, T>> 1, List<KeyValuePair<double, 1890>> 2) where T : 1890
	{
		if (1 == null || 2 == null)
		{
			return;
		}
		foreach (KeyValuePair<double, T> keyValuePair in 1)
		{
			keyValuePair.Value.2 = null;
			2.Add(new KeyValuePair<double, 1890>(keyValuePair.Key, keyValuePair.Value));
		}
	}

	// Token: 0x06003334 RID: 13108 RVA: 0x001392B8 File Offset: 0x001374B8
	private static 1890 18(2237.2240 1, 1262 2, Action 3)
	{
		object obj = 2237.2;
		lock (obj)
		{
			1890 result;
			if (2237.3.TryGetValue(1.1, out result))
			{
				return result;
			}
			2237.2239 4;
			if (!2237.4.TryGetValue(1.1, out 4))
			{
				4 = new 2237.2239
				{
					1 = 1,
					2 = 2
				};
				2237.4[1.1] = 4;
				2237.5.Enqueue(4);
				if (!2237.6)
				{
					2237.6 = true;
					WaitCallback callBack;
					if ((callBack = 2237.<>O.<0>__Work) == null)
					{
						callBack = (2237.<>O.<0>__Work = new WaitCallback(2237.19));
					}
					ThreadPool.QueueUserWorkItem(callBack);
				}
			}
			if (3 != null && !4.3.Contains(3))
			{
				4.3.Add(3);
			}
		}
		return null;
	}

	// Token: 0x06003335 RID: 13109 RVA: 0x001393A0 File Offset: 0x001375A0
	private static void 19(object 1)
	{
		for (;;)
		{
			object obj = 2237.2;
			2237.2239 2;
			lock (obj)
			{
				if (2237.5.Count == 0)
				{
					2237.6 = false;
					break;
				}
				2 = 2237.5.Dequeue();
			}
			1890 3 = null;
			try
			{
				while (1662.78 == 1677.Play)
				{
					Thread.Sleep(500);
				}
				1891 4 = 2237.16(2.2, 2.1);
				if (4 != null)
				{
					try
					{
						3 = 2237.17(4, 2.1.3, null);
					}
					finally
					{
						4.ReleaseHitObjectManager();
					}
				}
			}
			catch (Exception ex)
			{
				1338.4(ex, "working out the difficulty for pp (" + 2.1.1 + ")", 1341.Runtime);
			}
			if (3 == null)
			{
				1338.5("pp: the difficulty could not be worked out for " + 2.1.1, 1341.Runtime, (1114)2);
			}
			obj = 2237.2;
			List<Action> callbacks;
			lock (obj)
			{
				2237.3[2.1.1] = 3;
				2237.4.Remove(2.1.1);
				callbacks = 2.3;
			}
			if (callbacks.Count > 0)
			{
				1662.89.Schedule(delegate()
				{
					foreach (Action action in callbacks)
					{
						try
						{
							action();
						}
						catch (Exception ex2)
						{
							1338.4(ex2, "a pp result's callback", 1341.Runtime);
						}
					}
				}, true);
			}
		}
	}

	// Token: 0x040025E5 RID: 9701
	private const 2023 1 = 2023.Easy | 2023.TouchDevice | 2023.Hidden | 2023.HardRock | 2023.DoubleTime | 2023.Relax | 2023.HalfTime | 2023.Flashlight | 2023.Relax2 | 2023.Key4 | 2023.Key5 | 2023.Key6 | 2023.Key7 | 2023.Key8 | 2023.Key9 | 2023.KeyCoop | 2023.Key1 | 2023.Key3 | 2023.Key2;

	// Token: 0x040025E6 RID: 9702
	private static readonly object 2 = new object();

	// Token: 0x040025E7 RID: 9703
	private static readonly Dictionary<string, 1890> 3 = new Dictionary<string, 1890>();

	// Token: 0x040025E8 RID: 9704
	private static readonly Dictionary<string, 2237.2239> 4 = new Dictionary<string, 2237.2239>();

	// Token: 0x040025E9 RID: 9705
	private static readonly Queue<2237.2239> 5 = new Queue<2237.2239>();

	// Token: 0x040025EA RID: 9706
	private static bool 6;

	// Token: 0x020006B4 RID: 1716
	[276]
	internal sealed class 2240
	{
		// Token: 0x040025EB RID: 9707
		public string 1;

		// Token: 0x040025EC RID: 9708
		public 2147 2;

		// Token: 0x040025ED RID: 9709
		public 2023 3;

		// Token: 0x040025EE RID: 9710
		public 1927 4;

		// Token: 0x040025EF RID: 9711
		public 1940 5;

		// Token: 0x040025F0 RID: 9712
		public 1925 6;

		// Token: 0x040025F1 RID: 9713
		public 2100 7;

		// Token: 0x040025F2 RID: 9714
		public int? 8;

		// Token: 0x040025F3 RID: 9715
		public int? 9;
	}

	// Token: 0x020006B5 RID: 1717
	[276]
	internal struct 2238
	{
		// Token: 0x040025F4 RID: 9716
		public 2023 1;

		// Token: 0x040025F5 RID: 9717
		public int 2;

		// Token: 0x040025F6 RID: 9718
		public int 3;

		// Token: 0x040025F7 RID: 9719
		public int 4;

		// Token: 0x040025F8 RID: 9720
		public int 5;

		// Token: 0x040025F9 RID: 9721
		public int 6;

		// Token: 0x040025FA RID: 9722
		public int 7;

		// Token: 0x040025FB RID: 9723
		public int 8;

		// Token: 0x040025FC RID: 9724
		public long 9;

		// Token: 0x040025FD RID: 9725
		public bool 10;

		// Token: 0x040025FE RID: 9726
		public bool 11;
	}

	// Token: 0x020006B6 RID: 1718
	[276]
	private sealed class 2239
	{
		// Token: 0x040025FF RID: 9727
		public 2237.2240 1;

		// Token: 0x04002600 RID: 9728
		public 1262 2;

		// Token: 0x04002601 RID: 9729
		public List<Action> 3 = new List<Action>();
	}

	// Token: 0x020006B7 RID: 1719
	[CompilerGenerated]
	[276]
	private static class <>O
	{
		// Token: 0x04002602 RID: 9730
		public static WaitCallback <0>__Work;
	}
}
