using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

// Token: 0x02000B80 RID: 2944
internal static class 1285
{
	// Token: 0x0600510A RID: 20746 RVA: 0x00200E78 File Offset: 0x001FF078
	public static double? Get(1262 1)
	{
		bool flag;
		return 1285.2(1, out flag);
	}

	// Token: 0x0600510B RID: 20747 RVA: 0x00200E8D File Offset: 0x001FF08D
	public static double? Get(1262 1, out bool 2)
	{
		return 1285.2(1, out 2);
	}

	// Token: 0x0600510C RID: 20748 RVA: 0x00200E98 File Offset: 0x001FF098
	public static double? 1(1262 1)
	{
		bool flag;
		string key;
		double? num = 1285.3(1, out flag, out key);
		double? num2;
		if (num == null)
		{
			num2 = null;
			return num2;
		}
		object obj = 1285.1;
		lock (obj)
		{
			if (1285.8 != 1662.115)
			{
				1285.8 = 1662.115;
				1285.7.Clear();
			}
			bool flag2;
			if (!1285.7.TryGetValue(key, out flag2))
			{
				flag2 = true;
				foreach (1262 2 in 1285.6.ToArray())
				{
					if (2 != 1)
					{
						bool flag3;
						num2 = 1285.2(2, out flag3);
						if (num2 == null)
						{
							flag2 = false;
							break;
						}
					}
				}
				1285.7[key] = flag2;
			}
			double? num3;
			if (!flag2)
			{
				num2 = null;
				num3 = num2;
			}
			else
			{
				num3 = num;
			}
			num2 = num3;
		}
		return num2;
	}

	// Token: 0x0600510D RID: 20749 RVA: 0x00200F88 File Offset: 0x001FF188
	private static double? 2(1262 1, out bool 2)
	{
		string text;
		return 1285.3(1, out 2, out text);
	}

	// Token: 0x0600510E RID: 20750 RVA: 0x00200FA0 File Offset: 0x001FF1A0
	private static double? 3(1262 1, out bool 2, out string 3)
	{
		2 = false;
		3 = null;
		1262 4 = 1272.5();
		double? result;
		if (1662.78 != 1677.SelectPlay || 1 == null || 4 == null || 1.37 != 4.37)
		{
			result = null;
			return result;
		}
		2147 5 = 1.38();
		1927 6 = 1926.3(5);
		if (6 != null && 6.IsEmpty)
		{
			6 = null;
		}
		2023 7 = 1891.7(1929.2(5, 2019.1), 5, 1);
		1940 8 = 1939.16(7);
		if (8 != null && Math.Abs(8.Rate - 1939.17(7, null)) < 0.005)
		{
			8 = null;
		}
		if (6 == null && 8 == null)
		{
			result = null;
			return result;
		}
		string[] array = new string[7];
		int num = 0;
		int num2 = (int)5;
		array[num] = num2.ToString();
		array[1] = "|";
		int num3 = 2;
		num2 = (int)7;
		array[num3] = num2.ToString();
		array[3] = "|";
		array[4] = ((6 != null) ? 6.1() : null);
		array[5] = "|";
		array[6] = ((8 != null) ? 8.1() : null);
		3 = string.Concat(array);
		string key = 1.23 + "|" + 3;
		object obj = 1285.1;
		lock (obj)
		{
			KeyValuePair<double?, bool> keyValuePair;
			if (1285.10 != 1662.115)
			{
				1285.10 = 1662.115;
				1285.9.Clear();
			}
			else if (1285.9.TryGetValue(key, out keyValuePair))
			{
				2 = keyValuePair.Value;
				return keyValuePair.Key;
			}
			double? num4 = 1285.4(1, 4, 5, 7, 6, 8, 3, key, out 2);
			1285.9[key] = new KeyValuePair<double?, bool>(num4, 2);
			result = num4;
		}
		return result;
	}

	// Token: 0x0600510F RID: 20751 RVA: 0x0020116C File Offset: 0x001FF36C
	private static double? 4(1262 1, 1262 2, 2147 3, 2023 4, 1927 5, 1940 6, string 7, string 8, out bool 9)
	{
		1285.<>c__DisplayClass16_0 CS$<>8__locals1 = new 1285.<>c__DisplayClass16_0();
		CS$<>8__locals1.key = 8;
		CS$<>8__locals1.settings = 7;
		9 = false;
		if (1285.5 != 2.37)
		{
			1285.5 = 2.37;
			string folder = 1285.5;
			1285.6 = 1272.3.FindAll((1262 1) => 1.37 == folder);
		}
		double num;
		if (!1285.2.TryGetValue(CS$<>8__locals1.key, out num))
		{
			9 = true;
			if ((1285.3 == null || 1285.3.1 != CS$<>8__locals1.key) && !1285.4.Exists((1285.1286 1) => 1.1 == CS$<>8__locals1.key))
			{
				1285.<>c__DisplayClass16_2 CS$<>8__locals3 = new 1285.<>c__DisplayClass16_2();
				CS$<>8__locals3.CS$<>8__locals1 = CS$<>8__locals1;
				1285.<>c__DisplayClass16_2 CS$<>8__locals4 = CS$<>8__locals3;
				int num2 = (int)3;
				CS$<>8__locals4.prefix = num2.ToString() + "|";
				1285.4.RemoveAll((1285.1286 1) => 1.2 != CS$<>8__locals3.CS$<>8__locals1.settings && 1.2.StartsWith(CS$<>8__locals3.prefix, StringComparison.Ordinal));
				1285.1286 item = new 1285.1286
				{
					1 = CS$<>8__locals3.CS$<>8__locals1.key,
					2 = CS$<>8__locals3.CS$<>8__locals1.settings,
					3 = 10,
					4 = 3,
					5 = 4,
					6 = 5,
					7 = 6
				};
				if (10 == 2)
				{
					1285.4.Insert(0, item);
				}
				else
				{
					1285.4.Add(item);
				}
				if (1285.3 == null)
				{
					1285.5();
				}
			}
			return null;
		}
		if (num <= 0.0)
		{
			return null;
		}
		return new double?(num);
	}

	// Token: 0x06005110 RID: 20752 RVA: 0x00201314 File Offset: 0x001FF514
	private static void 5()
	{
		if (1285.4.Count == 0)
		{
			return;
		}
		1285.1286 request = 1285.4[0];
		1285.4.RemoveAt(0);
		1285.3 = request;
		ThreadPool.QueueUserWorkItem(delegate(object 1)
		{
			double num = -1.0;
			try
			{
				while (1662.78 == 1677.Play)
				{
					Thread.Sleep(1000);
				}
				1891 2 = request.3.17(request.4);
				2.5 = request.6;
				2.6 = request.7;
				try
				{
					num = Math.Abs(2.12(request.5, null, null));
				}
				finally
				{
					2.ReleaseHitObjectManager();
				}
			}
			catch (Exception)
			{
			}
			object obj = 1285.1;
			bool flag2;
			lock (obj)
			{
				1285.2[request.1] = ((num > 0.0) ? num : -1.0);
				1285.3 = null;
				1285.5();
				flag2 = (1285.3 == null);
			}
			if (num > 0.0 && (flag2 || request.3 == 1272.5()))
			{
				2662 3 = 1662.89;
				1189 4;
				if ((4 = 1285.<>O.<0>__RaiseModsChanged) == null)
				{
					4 = (1285.<>O.<0>__RaiseModsChanged = new 1189(2019.3));
				}
				3.Schedule(4, true);
			}
		});
	}

	// Token: 0x04003D86 RID: 15750
	private static readonly object 1 = new object();

	// Token: 0x04003D87 RID: 15751
	private static readonly Dictionary<string, double> 2 = new Dictionary<string, double>();

	// Token: 0x04003D88 RID: 15752
	private static 1285.1286 3;

	// Token: 0x04003D89 RID: 15753
	private static readonly List<1285.1286> 4 = new List<1285.1286>();

	// Token: 0x04003D8A RID: 15754
	private static string 5;

	// Token: 0x04003D8B RID: 15755
	private static List<1262> 6 = new List<1262>();

	// Token: 0x04003D8C RID: 15756
	private static readonly Dictionary<string, bool> 7 = new Dictionary<string, bool>();

	// Token: 0x04003D8D RID: 15757
	private static long 8 = -1L;

	// Token: 0x04003D8E RID: 15758
	private static readonly Dictionary<string, KeyValuePair<double?, bool>> 9 = new Dictionary<string, KeyValuePair<double?, bool>>();

	// Token: 0x04003D8F RID: 15759
	private static long 10 = -1L;

	// Token: 0x02000B81 RID: 2945
	private sealed class 1286
	{
		// Token: 0x04003D90 RID: 15760
		public string 1;

		// Token: 0x04003D91 RID: 15761
		public string 2;

		// Token: 0x04003D92 RID: 15762
		public 1262 3;

		// Token: 0x04003D93 RID: 15763
		public 2147 4;

		// Token: 0x04003D94 RID: 15764
		public 2023 5;

		// Token: 0x04003D95 RID: 15765
		public 1927 6;

		// Token: 0x04003D96 RID: 15766
		public 1940 7;
	}

	// Token: 0x02000B82 RID: 2946
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x04003D97 RID: 15767
		public static 1189 <0>__RaiseModsChanged;
	}
}
