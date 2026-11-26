using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;

// Token: 0x02000ADE RID: 2782
public static class 1455
{
	// Token: 0x06004D8F RID: 19855 RVA: 0x001EB554 File Offset: 0x001E9754
	internal static 1381 1(string[] 1, 1416 2)
	{
		1381 result = null;
		int num = 0;
		while (num < 1.Length && (result = 1455.2(1[num], 2, null)) == null)
		{
			num++;
		}
		return result;
	}

	// Token: 0x06004D90 RID: 19856 RVA: 0x001EB580 File Offset: 0x001E9780
	internal static 1381 2(string 1, 1416 2, 1453 3)
	{
		if (1 == null)
		{
			return null;
		}
		if (2630.13 && 2 != (1416)4)
		{
			2 &= (1416)(-5);
		}
		if (2630.17 && (2 & (1416)1) != (1416)0 && 2630.9(1))
		{
			2 = (1416)1;
		}
		if (2 == (1416)7 && 1662.78 - 1677.Edit > 1)
		{
			2 &= (1416)(-5);
		}
		1381 4 = null;
		ConcurrentDictionary<string, 1381> concurrentDictionary = null;
		if (!1455.2.TryGetValue(2, out concurrentDictionary))
		{
			concurrentDictionary = (1455.2[2] = new ConcurrentDictionary<string, 1381>());
		}
		if (concurrentDictionary.TryGetValue(1, out 4))
		{
			return 4;
		}
		1381 result;
		try
		{
			if (1 == "taiko-bar-right" || 1 == "taikobigcircle" || 1 == "taikohitcircle" || 1 == "taikohitcircleoverlay")
			{
				1381.14 = true;
			}
			1262 5 = null;
			if ((2 & (1416)4) > (1416)0 && (5 = 1272.5()) != null)
			{
				if (1455.6.TryGetValue(1, out 4))
				{
					if (4 != null)
					{
						return 4;
					}
				}
				else
				{
					foreach (string str in 1455.10)
					{
						string text = (1.IndexOf('.') < 0) ? (1 + str) : 1;
						using (Stream stream = 5.48(text))
						{
							if (stream != null)
							{
								4 = 1381.14(stream, 3);
								if (4 != null)
								{
									4.1 = text;
									4.2 = 1;
									4.6 = (1416)4;
									4.18();
								}
								1455.6[1] = 4;
								if (3 != null)
								{
									1455.3.Add(3);
								}
								return 4;
							}
						}
					}
					1455.6[1] = null;
				}
			}
			if ((2 & (1416)2) > (1416)0 && !2630.20())
			{
				if (1455.8.TryGetValue(1, out 4))
				{
					if (4 != null)
					{
						return 4;
					}
				}
				else
				{
					foreach (string str2 in 1455.10)
					{
						string text2 = Path.Combine(2630.5.14(), (1.IndexOf('.') < 0) ? (1 + str2) : 1);
						string path = text2.Insert(text2.LastIndexOf('.'), "@2x");
						if (1662.54() && File.Exists(path))
						{
							4 = 1381.13(path, 3);
							1455.8[1] = 4;
							if (3 != null)
							{
								1455.5.Add(3);
							}
							if (4 != null)
							{
								4.resolutionScale = 2;
								4.6 = (1416)2;
								4.2 = 1;
								4.18();
							}
							return 4;
						}
						if (File.Exists(text2))
						{
							4 = 1381.13(text2, 3);
							1455.8[1] = 4;
							if (3 != null)
							{
								1455.5.Add(3);
							}
							if (4 != null)
							{
								4.6 = (1416)2;
								4.2 = 1;
								4.18();
							}
							return 4;
						}
					}
					1455.8[1] = null;
				}
			}
			if ((2 & (1416)1) == (1416)0)
			{
				result = null;
			}
			else
			{
				try
				{
					if (1455.7.TryGetValue(1, out 4))
					{
						result = 4;
					}
					else
					{
						1 = 2672.17(1);
						4 = ((1.IndexOf(Path.DirectorySeparatorChar) > 0) ? 1381.13(1, 3) : 1381.12(2672.35(1), 3));
						1455.7[1] = 4;
						if (3 != null)
						{
							1455.4.Add(3);
						}
						if (4 != null)
						{
							4.6 = (1416)1;
							4.2 = 1;
							4.18();
						}
						result = 4;
					}
				}
				catch
				{
					result = null;
				}
			}
		}
		finally
		{
			concurrentDictionary[1] = 4;
			1381.14 = false;
		}
		return result;
	}

	// Token: 0x06004D91 RID: 19857 RVA: 0x001EB954 File Offset: 0x001E9B54
	internal static List<1381> 3()
	{
		List<1381> list = new List<1381>();
		foreach (1381 <<EMPTY_NAME>> in 1455.6.Values)
		{
			if (<<EMPTY_NAME>> != null && !<<EMPTY_NAME>>.5())
			{
				list.Add(<<EMPTY_NAME>>);
			}
		}
		return list;
	}

	// Token: 0x06004D92 RID: 19858 RVA: 0x001EB9B8 File Offset: 0x001E9BB8
	internal static List<KeyValuePair<string, 1381>> 4()
	{
		List<KeyValuePair<string, 1381>> list = new List<KeyValuePair<string, 1381>>();
		ConcurrentDictionary<string, 1381>[] array = new ConcurrentDictionary<string, 1381>[]
		{
			1455.8,
			1455.7
		};
		for (int i = 0; i < array.Length; i++)
		{
			foreach (KeyValuePair<string, 1381> item in array[i])
			{
				if (item.Value != null && !item.Value.5())
				{
					list.Add(item);
				}
			}
		}
		return list;
	}

	// Token: 0x06004D93 RID: 19859 RVA: 0x001EBA48 File Offset: 0x001E9C48
	internal static 1381[] 5(string 1, 1416 2, bool 3)
	{
		1381[] array;
		if (1455.1.TryGetValue(1, out array) && array[0].6 == 2)
		{
			return array;
		}
		int num = 1.LastIndexOf('.');
		string text = 3 ? "-" : string.Empty;
		1381 4 = 1455.2((num == -1) ? (1 + text + 0.ToString()) : 1.Insert(num, text + 0.ToString()), 2, null);
		1381 5 = 1455.2(1, 2, null);
		if (4 != null && 4 == 1455.6(4, 5))
		{
			List<1381> list = new List<1381>();
			int num2 = 1;
			while (4 != null)
			{
				list.Add(4);
				4 = 1455.2((num == -1) ? (1 + text + num2.ToString()) : 1.Insert(num, text + num2.ToString()), 4.6, null);
				num2++;
			}
			array = list.ToArray();
			1455.1[1] = array;
			return array;
		}
		if (5 != null)
		{
			array = new 1381[]
			{
				5
			};
			1455.1[1] = array;
			return array;
		}
		return null;
	}

	// Token: 0x06004D94 RID: 19860 RVA: 0x001EBB60 File Offset: 0x001E9D60
	private static 1381 6(1381 1, 1381 2)
	{
		if (1 != null && (2 == null || 1.6 == (1416)4 || (1.6 == (1416)2 && 2.6 != (1416)4) || (1.6 == (1416)1 && 2.6 != (1416)4 && 2.6 != (1416)2)))
		{
			return 1;
		}
		return 2;
	}

	// Token: 0x06004D95 RID: 19861 RVA: 0x001EBBAC File Offset: 0x001E9DAC
	internal static 1381 7(string 1, 1416 2, bool 3)
	{
		1381 4 = 1455.2(1, 2, null);
		1381[] array = 1455.5(1, 2, 3);
		1381 5 = (array != null) ? array[0] : null;
		return 1455.6(4, 5);
	}

	// Token: 0x06004D96 RID: 19862 RVA: 0x001EBBDC File Offset: 0x001E9DDC
	internal static void 8(bool 1)
	{
		1455.11 = 1;
		if (1455.6.Count == 0)
		{
			return;
		}
		foreach (1381 2 in 1455.6.Values.ToArray<1381>())
		{
			if (2 != null && !2.11)
			{
				2.Dispose();
			}
		}
		1455.6.Clear();
		1455.1.Clear();
		1455.9.Clear();
		1455.11 = false;
		1455.2.Clear();
		if (1)
		{
			1455.13(1455.3);
		}
	}

	// Token: 0x06004D97 RID: 19863 RVA: 0x001EBC6C File Offset: 0x001E9E6C
	internal static void 9(bool 1)
	{
		List<1381> list = new List<1381>();
		foreach (1381 2 in 1455.7.Values)
		{
			if (2 != null)
			{
				if (2.11 || 1)
				{
					2.Dispose();
				}
				else
				{
					list.Add(2);
				}
			}
		}
		1455.7.Clear();
		if (list.Count > 0)
		{
			foreach (1381 3 in list)
			{
				1455.7.TryAdd(3.1, 3);
			}
		}
		1455.1.Clear();
		1455.2.Clear();
		if (1)
		{
			1455.13(1455.4);
		}
	}

	// Token: 0x06004D98 RID: 19864 RVA: 0x001EBD58 File Offset: 0x001E9F58
	internal static List<1381> 10()
	{
		return new List<1381>(1455.13);
	}

	// Token: 0x06004D99 RID: 19865 RVA: 0x001EBD64 File Offset: 0x001E9F64
	internal static void 11()
	{
		1455.12 = false;
		foreach (1381 <<EMPTY_NAME>> in 1455.13)
		{
			<<EMPTY_NAME>>.Dispose();
		}
		1455.13.Clear();
		1455.13(1455.14);
	}

	// Token: 0x06004D9A RID: 19866 RVA: 0x001EBDD0 File Offset: 0x001E9FD0
	internal static void 12(bool 1)
	{
		List<1381> list = new List<1381>();
		foreach (1381 2 in 1455.8.Values)
		{
			if (2 != null)
			{
				if ((2.11 || 1) && 1455.12)
				{
					1455.13.Add(2);
				}
				else if (2.11 || 1)
				{
					2.Dispose();
				}
				else
				{
					list.Add(2);
				}
			}
		}
		1455.8.Clear();
		if (list.Count > 0)
		{
			foreach (1381 3 in list)
			{
				1455.8.TryAdd(3.1, 3);
			}
		}
		1455.1.Clear();
		1455.2.Clear();
		if (1 && 1455.12)
		{
			1455.14.UnionWith(1455.5);
			1455.5.Clear();
			return;
		}
		if (1)
		{
			1455.13(1455.5);
		}
	}

	// Token: 0x06004D9B RID: 19867 RVA: 0x001EBF00 File Offset: 0x001EA100
	internal static void 13(HashSet<1453> 1)
	{
		foreach (1453 2 in 1)
		{
			2.Reset();
		}
		1.Clear();
	}

	// Token: 0x06004D9C RID: 19868 RVA: 0x001EBF54 File Offset: 0x001EA154
	internal static void 14()
	{
		1455.1.Clear();
		1455.2.Clear();
		1455.13(1455.4);
		1455.15(1455.7, true);
		1455.13(1455.3);
		1455.15(1455.6, true);
		1455.13(1455.5);
		1455.15(1455.8, true);
		1414.4();
	}

	// Token: 0x06004D9D RID: 19869 RVA: 0x001EBFBC File Offset: 0x001EA1BC
	internal static void 15(ConcurrentDictionary<string, 1381> 1, bool 2)
	{
		ConcurrentDictionary<string, 1381> concurrentDictionary = new ConcurrentDictionary<string, 1381>(1);
		1.Clear();
		foreach (KeyValuePair<string, 1381> keyValuePair in concurrentDictionary)
		{
			if (keyValuePair.Value == null)
			{
				1[keyValuePair.Key] = null;
			}
			else
			{
				if (keyValuePair.Value.7 != null)
				{
					keyValuePair.Value.7.Dispose();
				}
				1381 3 = 1455.2(keyValuePair.Key, keyValuePair.Value.6, keyValuePair.Value.3);
				if (3 != null)
				{
					GC.SuppressFinalize(3);
					keyValuePair.Value.gpuTexture = 3.7;
					keyValuePair.Value.resolutionScale = 3.resolutionScale;
					keyValuePair.Value.6(false);
				}
				else
				{
					keyValuePair.Value.gpuTexture = null;
				}
				1[keyValuePair.Key] = keyValuePair.Value;
				1455.2[keyValuePair.Value.6][keyValuePair.Key] = keyValuePair.Value;
			}
		}
	}

	// Token: 0x06004D9E RID: 19870 RVA: 0x001EC0F4 File Offset: 0x001EA2F4
	internal static void 16(string 1)
	{
		if (1455.9.ContainsKey(1))
		{
			ConcurrentDictionary<string, int> concurrentDictionary = 1455.9;
			int num = concurrentDictionary[1];
			concurrentDictionary[1] = num + 1;
			return;
		}
		1455.9[1] = 1;
	}

	// Token: 0x06004D9F RID: 19871 RVA: 0x001EC134 File Offset: 0x001EA334
	internal static void 17(string 1)
	{
		if (1455.11)
		{
			return;
		}
		int num = 0;
		if (!1455.9.TryGetValue(1, out num))
		{
			return;
		}
		int num2;
		if (num > 1)
		{
			ConcurrentDictionary<string, int> concurrentDictionary = 1455.9;
			num2 = concurrentDictionary[1];
			concurrentDictionary[1] = num2 - 1;
			return;
		}
		1455.9.TryRemove(1, out num2);
		if (1455.6.ContainsKey(1))
		{
			1381 2 = 1455.6[1];
			if (2 != null)
			{
				2.Dispose();
				1455.6.TryRemove(1, out 2);
				1455.2.Clear();
			}
		}
	}

	// Token: 0x040039C4 RID: 14788
	private static ConcurrentDictionary<string, 1381[]> 1 = new ConcurrentDictionary<string, 1381[]>();

	// Token: 0x040039C5 RID: 14789
	private static ConcurrentDictionary<1416, ConcurrentDictionary<string, 1381>> 2 = new ConcurrentDictionary<1416, ConcurrentDictionary<string, 1381>>();

	// Token: 0x040039C6 RID: 14790
	private static readonly HashSet<1453> 3 = new HashSet<1453>();

	// Token: 0x040039C7 RID: 14791
	private static readonly HashSet<1453> 4 = new HashSet<1453>();

	// Token: 0x040039C8 RID: 14792
	private static readonly HashSet<1453> 5 = new HashSet<1453>();

	// Token: 0x040039C9 RID: 14793
	private static ConcurrentDictionary<string, 1381> 6 = new ConcurrentDictionary<string, 1381>();

	// Token: 0x040039CA RID: 14794
	private static ConcurrentDictionary<string, 1381> 7 = new ConcurrentDictionary<string, 1381>();

	// Token: 0x040039CB RID: 14795
	private static ConcurrentDictionary<string, 1381> 8 = new ConcurrentDictionary<string, 1381>();

	// Token: 0x040039CC RID: 14796
	private static readonly ConcurrentDictionary<string, int> 9 = new ConcurrentDictionary<string, int>();

	// Token: 0x040039CD RID: 14797
	private static string[] 10 = new string[]
	{
		".png",
		".jpg"
	};

	// Token: 0x040039CE RID: 14798
	internal static bool 11 = false;

	// Token: 0x040039CF RID: 14799
	internal static bool 12;

	// Token: 0x040039D0 RID: 14800
	private static readonly List<1381> 13 = new List<1381>();

	// Token: 0x040039D1 RID: 14801
	private static readonly HashSet<1453> 14 = new HashSet<1453>();
}
