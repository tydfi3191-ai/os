using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;

// Token: 0x02000670 RID: 1648
[276]
internal static class 2210
{
	// Token: 0x17000278 RID: 632
	// (get) Token: 0x060031D5 RID: 12757 RVA: 0x0012C69C File Offset: 0x0012A89C
	private static 2023 Excluded
	{
		get
		{
			if (!1304.24.1())
			{
				return 2023.Relax | 2023.Autoplay | 2023.Relax2 | 2023.Cinema | 2023.Target;
			}
			return 2023.Autoplay | 2023.Relax2 | 2023.Cinema | 2023.Target;
		}
	}

	// Token: 0x060031D6 RID: 12758 RVA: 0x0012C6B8 File Offset: 0x0012A8B8
	private static string 1(2241 1)
	{
		string text = 2210.2(1);
		if (text.Length != 0)
		{
			return "cc885fcf14f6-" + text;
		}
		return "cc885fcf14f6";
	}

	// Token: 0x060031D7 RID: 12759 RVA: 0x0012C6E5 File Offset: 0x0012A8E5
	private static string 2(2241 1)
	{
		if (1 != null && 1.9 == 2147.Osu)
		{
			return 2099.Tag(1.8, 2099.Current);
		}
		return string.Empty;
	}

	// Token: 0x060031D8 RID: 12760 RVA: 0x0012C70D File Offset: 0x0012A90D
	private static bool 3(string 1)
	{
		return 1 == "cc885fcf14f6" || (1 != null && 1.StartsWith("cc885fcf14f6-rx", StringComparison.Ordinal));
	}

	// Token: 0x17000279 RID: 633
	// (get) Token: 0x060031D9 RID: 12761 RVA: 0x0012C72F File Offset: 0x0012A92F
	// (set) Token: 0x060031DA RID: 12762 RVA: 0x0012C736 File Offset: 0x0012A936
	internal static 2210.2216 Current { get; private set; }

	// Token: 0x1700027A RID: 634
	// (get) Token: 0x060031DB RID: 12763 RVA: 0x0012C740 File Offset: 0x0012A940
	internal static 2147 Mode
	{
		get
		{
			if (2210.33 == null)
			{
				1320<2147> <<EMPTY_NAME>> = 2601.73;
				2147 2 = (<<EMPTY_NAME>> != null) ? <<EMPTY_NAME>>.GetValue() : 2147.Osu;
				2210.33 = new 2147?((2 >= 2147.Osu && 2 <= 2147.OsuMania) ? 2 : 2147.Osu);
			}
			return 2210.33.Value;
		}
	}

	// Token: 0x060031DC RID: 12764 RVA: 0x0012C78C File Offset: 0x0012A98C
	internal static 2210.2216 4(2147 1)
	{
		if (1 == 2210.Mode)
		{
			return 2210.Current;
		}
		2210.2216 2;
		if (!2210.34.TryGetValue(1, out 2))
		{
			2 = 2210.39(null, null, 1304.189.GetValue() ?? string.Empty, 1);
			2210.34[1] = 2;
		}
		return 2;
	}

	// Token: 0x060031DD RID: 12765 RVA: 0x0012C7E8 File Offset: 0x0012A9E8
	internal static void SetMode(2147 1)
	{
		if (1 < 2147.Osu || 1 > 2147.OsuMania || 1 == 2210.Mode)
		{
			return;
		}
		2210.33 = new 2147?(1);
		2210.Current = null;
		2210.34.Clear();
		2210.31 = 0;
		2210.32 = -1.0;
		2210.7();
	}

	// Token: 0x060031DE RID: 12766 RVA: 0x0012C83C File Offset: 0x0012AA3C
	internal static string 5(string 1, 2147 2)
	{
		1 = (1 ?? string.Empty);
		if (2 != 2147.Osu)
		{
			string str = 1;
			string str2 = "\u001f";
			int num = (int)2;
			return str + str2 + num.ToString();
		}
		return 1;
	}

	// Token: 0x1700027B RID: 635
	// (get) Token: 0x060031DF RID: 12767 RVA: 0x0012C86E File Offset: 0x0012AA6E
	internal static 1659 CurrentStats
	{
		get
		{
			if (2210.Current == null || !2210.6(2210.Current))
			{
				return null;
			}
			return 2210.77(2210.Current);
		}
	}

	// Token: 0x060031E0 RID: 12768 RVA: 0x0012C88F File Offset: 0x0012AA8F
	private static bool 6(2210.2216 1)
	{
		return 1.5 > 0 || (2210.Mode != 2147.Osu && !string.IsNullOrEmpty(1304.189.GetValue()));
	}

	// Token: 0x060031E1 RID: 12769 RVA: 0x0012C8B7 File Offset: 0x0012AAB7
	internal static void 7()
	{
		if (2210.28)
		{
			return;
		}
		2210.28 = true;
		2662 <<EMPTY_NAME>> = 1662.89;
		1189 2;
		if ((2 = 2210.<>O.<0>__Refresh) == null)
		{
			2 = (2210.<>O.<0>__Refresh = new 1189(2210.Refresh));
		}
		<<EMPTY_NAME>>.2(2, 600, false);
	}

	// Token: 0x060031E2 RID: 12770 RVA: 0x0012C8F3 File Offset: 0x0012AAF3
	private static void 8()
	{
		if (2210.28)
		{
			return;
		}
		2210.28 = true;
		2662 <<EMPTY_NAME>> = 1662.89;
		1189 2;
		if ((2 = 2210.<>O.<0>__Refresh) == null)
		{
			2 = (2210.<>O.<0>__Refresh = new 1189(2210.Refresh));
		}
		<<EMPTY_NAME>>.2(2, 2000, false);
	}

	// Token: 0x060031E3 RID: 12771 RVA: 0x0012C930 File Offset: 0x0012AB30
	internal static void Refresh()
	{
		if (1662.78 == 1677.Play)
		{
			2210.28 = true;
			2662 <<EMPTY_NAME>> = 1662.89;
			1189 5;
			if ((5 = 2210.<>O.<0>__Refresh) == null)
			{
				5 = (2210.<>O.<0>__Refresh = new 1189(2210.Refresh));
			}
			<<EMPTY_NAME>>.2(5, 2000, false);
			return;
		}
		2210.28 = false;
		try
		{
			if (!2210.29)
			{
				2210.29 = true;
				1304.12.SubscribeChanged(delegate(object 1, EventArgs 2)
				{
					2210.7();
				});
				1313[] array;
				if (!1304.22.1())
				{
					bool flag = 1304.13.1();
					array = 2210.66();
					for (int i = 0; i < array.Length; i++)
					{
						array[i].2(flag);
					}
					1304.22.2(true);
				}
				array = 2210.66();
				for (int i = 0; i < array.Length; i++)
				{
					array[i].SubscribeChanged(delegate(object 1, EventArgs 2)
					{
						2210.7();
					});
				}
				1304.21.SubscribeChanged(delegate(object 1, EventArgs 2)
				{
					2210.7();
				});
				1304.23.SubscribeChanged(delegate(object 1, EventArgs 2)
				{
					2210.7();
				});
				1304.24.SubscribeChanged(delegate(object 1, EventArgs 2)
				{
					2210.7();
				});
				1304.25.SubscribeChanged(delegate(object 1, EventArgs 2)
				{
					2210.7();
				});
				array = new 1313[]
				{
					1304.36,
					1304.37,
					1304.38,
					1304.39,
					1304.40
				};
				for (int i = 0; i < array.Length; i++)
				{
					array[i].SubscribeChanged(delegate(object 1, EventArgs 2)
					{
						2210.7();
					});
				}
				1304.42.SubscribeChanged(delegate(object 1, EventArgs 2)
				{
					2210.7();
				});
				1304.41.SubscribeChanged(delegate(object 1, EventArgs 2)
				{
					2210.31 = 0;
					2210.32 = -1.0;
					2210.7();
				});
				1304.189.SubscribeChanged(delegate(object 1, EventArgs 2)
				{
					2210.Current = null;
					2210.31 = 0;
					2210.32 = -1.0;
					2210.7();
				});
			}
			2210.2216 3 = 2210.37(null, null);
			2210.Current = 3;
			2210.34.Clear();
			if (2210.23)
			{
				2210.23 = false;
				2230.17(true);
			}
			2210.32();
			2210.79();
			2210.73(3);
			string text = string.Concat(new string[]
			{
				3.1.ToString("0.##", CultureInfo.InvariantCulture),
				" pp, ",
				3.5.ToString(),
				" play(s) on ",
				3.6.ToString(),
				" beatmap(s), ",
				3.8.ToString(),
				" still being worked out"
			});
			if (text != 2210.30)
			{
				2210.30 = text;
				1338.5("Local profile: " + text, 1341.Runtime, (1114)2);
			}
			if (2210.6(3) && 1662.100 != null)
			{
				1662.100.13(2210.77(3));
			}
			else
			{
				1654 4 = 1662.100;
				if (4 != null)
				{
					4.11(true);
				}
			}
		}
		catch (Exception ex)
		{
			1338.4(ex, "working out the local profile", 1341.Runtime);
		}
	}

	// Token: 0x060031E4 RID: 12772 RVA: 0x0012CCF8 File Offset: 0x0012AEF8
	private static Dictionary<string, int> 9(string 1)
	{
		Dictionary<string, int> result;
		if (!2210.21.TryGetValue(1, out result))
		{
			result = (2210.21[1] = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase));
		}
		return result;
	}

	// Token: 0x060031E5 RID: 12773 RVA: 0x0012CD2C File Offset: 0x0012AF2C
	internal static void 10(double 1, 2147 2)
	{
		string value = 1304.189.GetValue();
		if (string.IsNullOrEmpty(value) || 1 <= 0.0 || 1 > 1000.0)
		{
			return;
		}
		2210.78();
		string key = 2210.5(value, 2);
		double num;
		2210.19.TryGetValue(key, out num);
		2210.19[key] = num + 1 / 1000.0;
		2210.22 = true;
	}

	// Token: 0x060031E6 RID: 12774 RVA: 0x0012CDA0 File Offset: 0x0012AFA0
	internal static string 11(string 1)
	{
		2210.78();
		string result;
		if (1 == null || !2210.20.TryGetValue(1, out result))
		{
			return null;
		}
		return result;
	}

	// Token: 0x060031E7 RID: 12775 RVA: 0x0012CDC8 File Offset: 0x0012AFC8
	internal static void 12(string 1, string 2)
	{
		if (string.IsNullOrEmpty(1))
		{
			return;
		}
		2210.78();
		if (string.IsNullOrEmpty(2))
		{
			2210.20.Remove(1);
		}
		else
		{
			2210.20[1] = 2.ToUpperInvariant();
		}
		2210.22 = true;
		2210.79();
	}

	// Token: 0x060031E8 RID: 12776 RVA: 0x0012CE18 File Offset: 0x0012B018
	internal static double 13(string 1, 2147 2)
	{
		2210.78();
		double result;
		if (1 == null || !2210.19.TryGetValue(2210.5(1, 2), out result))
		{
			return 0.0;
		}
		return result;
	}

	// Token: 0x060031E9 RID: 12777 RVA: 0x0012CE50 File Offset: 0x0012B050
	internal static void 14(string 1)
	{
		string value = 1304.189.GetValue();
		if (string.IsNullOrEmpty(value) || string.IsNullOrEmpty(1))
		{
			return;
		}
		2210.78();
		Dictionary<string, int> dictionary = 2210.9(value);
		int num;
		dictionary.TryGetValue(1, out num);
		dictionary[1] = num + 1;
		2210.22 = true;
	}

	// Token: 0x060031EA RID: 12778 RVA: 0x0012CEA0 File Offset: 0x0012B0A0
	internal static List<2210.2215> 15(string 1, 2147 2 = 2147.Osu)
	{
		2210.78();
		HashSet<string> hashSet = 1304.12.1() ? null : 2210.72();
		2210.<>c__DisplayClass65_0 CS$<>8__locals1;
		CS$<>8__locals1.beatmaps = new Dictionary<string, 2210.2215>(StringComparer.OrdinalIgnoreCase);
		foreach (KeyValuePair<string, List<2241>> keyValuePair in 2230.6(true))
		{
			foreach (2241 3 in keyValuePair.Value)
			{
				if (3 != null && 3.9 == 8 && 3.18)
				{
					string text = 2210.70(3);
					if (2210.26(3, text, 7) && (hashSet == null || !hashSet.Contains(text)))
					{
						2210.2215 4 = 2210.<GetMostPlayed>g__Get|65_0(keyValuePair.Key, ref CS$<>8__locals1);
						4.4++;
						2210.2211 5;
						if (4.3 == null && 2210.8.TryGetValue(text, out 5))
						{
							4.3 = 5.5;
						}
					}
				}
			}
		}
		Dictionary<string, int> dictionary;
		if (8 == 2147.Osu && 7 != null && 2210.21.TryGetValue(7, out dictionary))
		{
			foreach (KeyValuePair<string, int> keyValuePair2 in dictionary)
			{
				2210.<GetMostPlayed>g__Get|65_0(keyValuePair2.Key, ref CS$<>8__locals1).4 += keyValuePair2.Value;
			}
		}
		List<2210.2215> list = new List<2210.2215>(CS$<>8__locals1.beatmaps.Values);
		foreach (2210.2215 6 in list)
		{
			6.2 = 1272.8(6.1);
		}
		list.Sort(delegate(2210.2215 1, 2210.2215 2)
		{
			if (2.4 == 1.4)
			{
				return string.CompareOrdinal(1.1, 2.1);
			}
			return 2.4.CompareTo(1.4);
		});
		return list;
	}

	// Token: 0x060031EB RID: 12779 RVA: 0x0012D0D0 File Offset: 0x0012B2D0
	private static HashSet<string> 16(Dictionary<string, HashSet<string>> 1, string 2)
	{
		HashSet<string> result;
		if (!1.TryGetValue(2, out result))
		{
			result = (1[2] = new HashSet<string>(StringComparer.Ordinal));
		}
		return result;
	}

	// Token: 0x060031EC RID: 12780 RVA: 0x0012D0FC File Offset: 0x0012B2FC
	internal static List<2241> 17(string 1)
	{
		2210.78();
		List<2241> list = new List<2241>();
		foreach (KeyValuePair<string, List<2241>> keyValuePair in 2230.6(true))
		{
			foreach (2241 2 in keyValuePair.Value)
			{
				if (2 != null && 2210.26(2, 2210.70(2), 1))
				{
					list.Add(2);
				}
			}
		}
		return list;
	}

	// Token: 0x060031ED RID: 12781 RVA: 0x0012D1B0 File Offset: 0x0012B3B0
	internal static 2210.2217 18(2241 1, string 2)
	{
		2210.78();
		string text = 2210.70(1);
		2210.2217 3 = new 2210.2217
		{
			6 = 2210.27(2, 1, text),
			7 = 2210.15.Contains(text)
		};
		2210.2211 4;
		if (2210.8.TryGetValue(text, out 4))
		{
			3.1 = 4.1;
			3.2 = 4.2;
			3.3 = 4.3;
			3.4 = 4.4;
			3.5 = 4.5;
		}
		return 3;
	}

	// Token: 0x060031EE RID: 12782 RVA: 0x0012D23C File Offset: 0x0012B43C
	internal static void 19(2241 1, 2210.2217 2)
	{
		2210.78();
		2210.24.Remove(1);
		string text = 2210.70(1);
		2210.2211 3;
		if (!2210.8.TryGetValue(text, out 3))
		{
			3 = (2210.8[text] = new 2210.2211());
		}
		if (2.1 != null && !string.IsNullOrEmpty(2.2))
		{
			3.1 = 2.1;
			3.2 = 2.2;
		}
		3.3 = 2.3;
		3.4 = 2.4;
		3.5 = 2.5;
		if (2.6)
		{
			2210.9.Add(text);
		}
		if (2.7)
		{
			2210.15.Add(text);
		}
		2210.22 = true;
	}

	// Token: 0x060031EF RID: 12783 RVA: 0x0012D308 File Offset: 0x0012B508
	internal static double? 20(string 1, 2147 2)
	{
		2210.78();
		double value;
		if (!2210.16.TryGetValue(2210.5(1, 2), out value))
		{
			return null;
		}
		return new double?(value);
	}

	// Token: 0x060031F0 RID: 12784 RVA: 0x0012D33F File Offset: 0x0012B53F
	internal static void 21(string 1, double 2, 2147 3)
	{
		2210.78();
		2210.19[2210.5(1, 3)] = Math.Max(0.0, 2);
		2210.22 = true;
	}

	// Token: 0x060031F1 RID: 12785 RVA: 0x0012D36C File Offset: 0x0012B56C
	internal static Dictionary<string, int> 22(string 1)
	{
		2210.78();
		Dictionary<string, int> dictionary;
		if (!2210.21.TryGetValue(1 ?? string.Empty, out dictionary))
		{
			return new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
		}
		return new Dictionary<string, int>(dictionary, StringComparer.OrdinalIgnoreCase);
	}

	// Token: 0x060031F2 RID: 12786 RVA: 0x0012D3AC File Offset: 0x0012B5AC
	internal static void 23(string 1, Dictionary<string, int> 2)
	{
		2210.78();
		2210.21[1] = new Dictionary<string, int>(2, StringComparer.OrdinalIgnoreCase);
		2210.22 = true;
	}

	// Token: 0x060031F3 RID: 12787 RVA: 0x0012D3CF File Offset: 0x0012B5CF
	internal static void 24(string 1)
	{
		2210.78();
		if (2210.10.Add(1) | 2210.11.Remove(1))
		{
			2210.22 = true;
		}
	}

	// Token: 0x060031F4 RID: 12788 RVA: 0x0012D3F5 File Offset: 0x0012B5F5
	internal static bool 25(2241 1)
	{
		2210.78();
		return 1 != null && 2210.26(1, 2210.70(1), 1304.189.GetValue());
	}

	// Token: 0x060031F5 RID: 12789 RVA: 0x0012D418 File Offset: 0x0012B618
	private static bool 26(2241 1, string 2, string 3)
	{
		HashSet<string> hashSet;
		return string.Equals(1.23 ?? string.Empty, 3 ?? string.Empty, StringComparison.OrdinalIgnoreCase) || (3 != null && 2210.17.TryGetValue(3, out hashSet) && hashSet.Contains(2));
	}

	// Token: 0x060031F6 RID: 12790 RVA: 0x0012D464 File Offset: 0x0012B664
	private static bool 27(string 1, 2241 2, string 3)
	{
		if (string.Equals(2.23 ?? string.Empty, 1 ?? string.Empty, StringComparison.OrdinalIgnoreCase))
		{
			return 2210.9.Contains(3);
		}
		HashSet<string> hashSet;
		return 1 != null && 2210.18.TryGetValue(1, out hashSet) && hashSet.Contains(3);
	}

	// Token: 0x060031F7 RID: 12791 RVA: 0x0012D4BC File Offset: 0x0012B6BC
	internal static bool 28(2241 1, string 2)
	{
		2210.78();
		if (1 == null || !1.18 || (1.8 & 2210.Excluded) != 2023.None)
		{
			return false;
		}
		string item = 2210.70(1);
		return 2210.26(1, item, 2) && 2210.67(1) && !2210.27(2, 1, item) && (1304.12.1() || 1.16 > 0L || !2210.72().Contains(item));
	}

	// Token: 0x060031F8 RID: 12792 RVA: 0x0012D53D File Offset: 0x0012B73D
	internal static void 29(2241 1)
	{
		if (1 != null)
		{
			2210.24.Remove(1);
		}
	}

	// Token: 0x060031F9 RID: 12793 RVA: 0x0012D550 File Offset: 0x0012B750
	internal static double? 30(2241 1)
	{
		2210.78();
		2210.2211 2;
		if (1 == null || !2210.8.TryGetValue(2210.70(1), out 2) || !2.1(1))
		{
			return null;
		}
		return 2.1;
	}

	// Token: 0x060031FA RID: 12794 RVA: 0x0012D592 File Offset: 0x0012B792
	internal static bool 31(2241 1)
	{
		2210.78();
		return 1 != null && 2210.27(1304.189.GetValue(), 1, 2210.70(1));
	}

	// Token: 0x060031FB RID: 12795 RVA: 0x0012D5B4 File Offset: 0x0012B7B4
	private static void 32()
	{
		if (2230.HasUnsavedChanges)
		{
			return;
		}
		HashSet<string> live = new HashSet<string>(StringComparer.Ordinal);
		HashSet<2241> hashSet = new HashSet<2241>();
		foreach (KeyValuePair<string, List<2241>> keyValuePair in 2230.6(true))
		{
			foreach (2241 <<EMPTY_NAME>> in keyValuePair.Value)
			{
				if (<<EMPTY_NAME>> != null)
				{
					hashSet.Add(<<EMPTY_NAME>>);
					live.Add(2210.70(<<EMPTY_NAME>>));
				}
			}
		}
		if (live.Count == 0)
		{
			return;
		}
		foreach (2241 2 in new List<2241>(2210.24.Keys))
		{
			if (!hashSet.Contains(2))
			{
				2210.24.Remove(2);
			}
		}
		foreach (string text in new List<string>(2210.8.Keys))
		{
			if (!live.Contains(text))
			{
				2210.8.Remove(text);
				2210.22 = true;
			}
		}
		if (2210.9.RemoveWhere((string 1) => !live.Contains(1)) > 0)
		{
			2210.22 = true;
		}
		if (2210.15.RemoveWhere((string 1) => !live.Contains(1)) > 0)
		{
			2210.22 = true;
		}
		Predicate<string> <>9__2;
		foreach (HashSet<string> hashSet2 in 2210.17.Values)
		{
			Predicate<string> match;
			if ((match = <>9__2) == null)
			{
				match = (<>9__2 = ((string 1) => !live.Contains(1)));
			}
			if (hashSet2.RemoveWhere(match) > 0)
			{
				2210.22 = true;
			}
		}
		Predicate<string> <>9__3;
		foreach (HashSet<string> hashSet3 in 2210.18.Values)
		{
			Predicate<string> match2;
			if ((match2 = <>9__3) == null)
			{
				match2 = (<>9__3 = ((string 1) => !live.Contains(1)));
			}
			if (hashSet3.RemoveWhere(match2) > 0)
			{
				2210.22 = true;
			}
		}
	}

	// Token: 0x060031FC RID: 12796 RVA: 0x0012D870 File Offset: 0x0012BA70
	internal static bool 33(2241 1)
	{
		2210.78();
		if (1 == null || !string.Equals(1.23 ?? string.Empty, 1304.189.GetValue() ?? string.Empty, StringComparison.OrdinalIgnoreCase))
		{
			return false;
		}
		2210.72();
		return !2210.27;
	}

	// Token: 0x060031FD RID: 12797 RVA: 0x0012D8BF File Offset: 0x0012BABF
	internal static bool 34(string 1)
	{
		2210.78();
		return 2210.12.Contains(1);
	}

	// Token: 0x060031FE RID: 12798 RVA: 0x0012D8D4 File Offset: 0x0012BAD4
	internal static void 35(2241 1)
	{
		if (!2210.33(1))
		{
			return;
		}
		string text = 2210.70(1);
		bool flag = 2210.72().Contains(text);
		if (flag)
		{
			2210.12.Add(text);
		}
		2230.22(1.10, text, flag);
		2210.8.Remove(text);
		2210.9.Remove(text);
		foreach (HashSet<string> hashSet in 2210.17.Values)
		{
			hashSet.Remove(text);
		}
		foreach (HashSet<string> hashSet2 in 2210.18.Values)
		{
			hashSet2.Remove(text);
		}
		2210.24.Remove(1);
		2210.22 = true;
		2210.79();
		2230.17(true);
	}

	// Token: 0x060031FF RID: 12799 RVA: 0x0012D9DC File Offset: 0x0012BBDC
	internal static void 36(2241 1, bool 2)
	{
		2210.78();
		string item = 2210.70(1);
		string b = 1304.189.GetValue() ?? string.Empty;
		HashSet<string> hashSet = string.Equals(1.23 ?? string.Empty, b, StringComparison.OrdinalIgnoreCase) ? 2210.9 : 2210.16(2210.18, b);
		if (2 ? hashSet.Add(item) : hashSet.Remove(item))
		{
			2210.22 = true;
		}
	}

	// Token: 0x06003200 RID: 12800 RVA: 0x0012DA4F File Offset: 0x0012BC4F
	internal static 2210.2216 37(2241 1, double? 2)
	{
		return 2210.38(1, 2, 1304.189.GetValue() ?? string.Empty);
	}

	// Token: 0x06003201 RID: 12801 RVA: 0x0012DA6B File Offset: 0x0012BC6B
	internal static 2210.2216 38(2241 1, double? 2, string 3)
	{
		return 2210.39(1, 2, 3, (1 != null) ? 1.9 : 2210.Mode);
	}

	// Token: 0x06003202 RID: 12802 RVA: 0x0012DA88 File Offset: 0x0012BC88
	internal static 2210.2216 39(2241 1, double? 2, string 3, 2147 4)
	{
		2210.78();
		2210.2212 5 = new 2210.2212
		{
			1 = 4,
			2 = 3,
			3 = 8,
			4 = 9,
			5 = 1304.13.1(),
			6 = (1304.12.1() ? null : 2210.72()),
			7 = 1304.36.1(),
			8 = 1304.37.1(),
			9 = 1304.38.1(),
			10 = 1304.39.1(),
			11 = 1304.40.1(),
			12 = 2210.72()
		};
		2210.2216 6 = new 2210.2216();
		List<2210.2214> list = new List<2210.2214>();
		Dictionary<string, 2210.2214> dictionary = new Dictionary<string, 2210.2214>(StringComparer.Ordinal);
		Dictionary<string, long> dictionary2 = new Dictionary<string, long>(StringComparer.Ordinal);
		bool flag = 8 == null;
		foreach (KeyValuePair<string, List<2241>> keyValuePair in 2230.6(true))
		{
			List<2241> collection = keyValuePair.Value;
			if (!flag && keyValuePair.Key == 8.10)
			{
				collection = new List<2241>(collection)
				{
					8
				};
				flag = true;
			}
			2210.40(keyValuePair.Key, collection, 5, 6, list, dictionary, dictionary2);
		}
		if (!flag)
		{
			2210.40(8.10, new List<2241>
			{
				8
			}, 5, 6, list, dictionary, dictionary2);
		}
		foreach (long num in dictionary2.Values)
		{
			6.4 += num;
		}
		6.9.AddRange(dictionary.Values);
		6.9.Sort((2210.2214 1, 2210.2214 2) => 2.4.CompareTo(1.4));
		double num2 = 1.0;
		double num3 = 0.0;
		double num4 = 0.0;
		foreach (2210.2214 7 in 6.9)
		{
			7.6 = num2;
			6.1 += 7.4 * num2;
			num4 += 7.5 * num2;
			num3 += num2;
			num2 *= 0.95;
		}
		6.6 = 6.9.Count;
		6.10 = 6.9.FindAll((2210.2214 1) => 1.10).Count;
		if (6.9.Count > 0)
		{
			double num5;
			if (2210.16.TryGetValue(2210.5(3, 4), out num5))
			{
				int num6 = 0;
				foreach (string item in dictionary.Keys)
				{
					if (!5.13.Contains(item))
					{
						num6++;
					}
				}
				6.1 += num5 + 2210.52(Math.Min(1000.0, 2210.53(num5) + (double)num6)) - 2210.52(2210.53(num5));
			}
			else
			{
				6.1 += 2210.52((double)Math.Min(1000, 6.9.Count));
			}
			6.2 = num4 / num3;
		}
		list.Sort((2210.2214 1, 2210.2214 2) => 2.4.CompareTo(1.4));
		6.9.AddRange(list);
		return 6;
	}

	// Token: 0x06003203 RID: 12803 RVA: 0x0012DEA4 File Offset: 0x0012C0A4
	private static void 40(string 1, List<2241> 2, 2210.2212 3, 2210.2216 4, List<2210.2214> 5, Dictionary<string, 2210.2214> 6, Dictionary<string, long> 7)
	{
		1262 8 = null;
		bool flag = false;
		2210.2214 9 = null;
		bool flag2 = false;
		long num = -1L;
		int num2 = 0;
		foreach (2241 10 in 2)
		{
			if (10 != null && 10.9 == 3.1 && 10.18 && (10.8 & 2210.Excluded) == 2023.None)
			{
				string text = 2210.70(10);
				if ((10 == 3.3 || 2210.26(10, text, 3.2)) && 2210.67(10) && (10 == 3.3 || 3.6 == null || 10.16 > 0L || !3.6.Contains(text)))
				{
					4.5++;
					4.3 += (long)10.GetScore();
					4.7 = Math.Max(4.7, 10.13);
					if (!flag)
					{
						flag = true;
						8 = 1272.8(1);
					}
					2210.2211 11;
					2210.8.TryGetValue(text, out 11);
					if (8 != null && 10 != 3.3)
					{
						11 = 2210.41(text, 11, 8);
					}
					int num3 = (int)((8 != null) ? 8.85 : ((1281)((11 != null) ? 11.3 : -1)));
					if (8 != null && num3 <= 1 && 11 != null && 11.3 > 1)
					{
						num3 = 11.3;
					}
					if (num2 <= 0)
					{
						num2 = ((8 != null) ? 8.25 : ((11 != null) ? 11.4 : 0));
					}
					1281? 12 = 1633.1(num2);
					if (12 != null)
					{
						1281 valueOrDefault = 12.GetValueOrDefault();
						if (valueOrDefault > (1281)1)
						{
							num3 = (int)valueOrDefault;
							if (11 != null && 11.3 != num3)
							{
								11.3 = num3;
								2210.22 = true;
							}
						}
					}
					if (3.1(num3))
					{
						if (10 == 3.3 || !2210.27(3.2, 10, text))
						{
							num = Math.Max(num, (long)10.GetScore());
						}
						if (10 != 3.3 && 11 != null && 11.2 == "mcosu-unchecked" && 8 != null && 2210.50(10, text, 11, 8))
						{
							2210.23 = true;
						}
						double? num4;
						if (10 == 3.3)
						{
							num4 = 3.4;
						}
						else if (11 != null && (11.1(10) || (11.2 == "bancho-lazer" && 11.1 != null)))
						{
							num4 = 11.1;
						}
						else if (8 != null)
						{
							bool flag3 = 2237.2(10, 8);
							double? num5;
							if (!flag3)
							{
								num5 = null;
							}
							else
							{
								2241 13 = 10;
								1262 14 = 8;
								Action action;
								if ((action = 2210.<>O.<1>__QueueRefreshAfterPerformance) == null)
								{
									action = (2210.<>O.<1>__QueueRefreshAfterPerformance = new Action(2210.8));
								}
								num5 = 2237.Get(13, 14, action);
							}
							num4 = num5;
							if (num4 != null)
							{
								11.1 = num4;
								11.2 = 2210.1(10);
								2210.22 = true;
							}
							else if (flag3 && !2237.HasFailed(10, 8))
							{
								4.8++;
								num4 = ((11 != null) ? 11.1 : null);
							}
							else if (((11 != null) ? 11.2 : null) == "bancho")
							{
								num4 = 11.1;
							}
						}
						else
						{
							num4 = ((11 != null) ? 11.1 : null);
						}
						if (num4 != null)
						{
							2210.2214 15 = new 2210.2214
							{
								1 = 10,
								2 = 1,
								3 = 8,
								4 = num4.Value,
								5 = (double)10.CalculateAccuracy(),
								8 = (((8 != null) ? 8.49 : null) ?? ((11 != null) ? 11.5 : null)),
								9 = ((8 != null) ? 8.25 : ((11 != null) ? 11.4 : 0)),
								10 = (10 != 3.3 && 2210.49(11))
							};
							if (10 != 3.3 && 2210.27(3.2, 10, text))
							{
								15.7 = true;
								5.Add(15);
							}
							else
							{
								if (9 == null || 15.4 > 9.4)
								{
									9 = 15;
								}
								flag2 |= (10 != 3.3 && (10.16 > 0L || 3.12.Contains(text)));
							}
						}
					}
				}
			}
		}
		string text2 = (num2 > 0) ? ("#" + num2.ToString()) : 1;
		if (flag2)
		{
			3.13.Add(text2);
		}
		long num6;
		if (num >= 0L && (!7.TryGetValue(text2, out num6) || num > num6))
		{
			7[text2] = num;
		}
		2210.2214 16;
		if (9 != null && (!6.TryGetValue(text2, out 16) || 9.4 > 16.4))
		{
			6[text2] = 9;
		}
	}

	// Token: 0x06003204 RID: 12804 RVA: 0x0012E3E8 File Offset: 0x0012C5E8
	private static 2210.2211 41(string 1, 2210.2211 2, 1262 3)
	{
		if (2 == null)
		{
			2 = (2210.8[1] = new 2210.2211());
		}
		string b = (3.49 ?? string.Empty).Replace('\t', ' ');
		int num = (3.85 <= (1281)1 && 2.3 > 1) ? 2.3 : ((int)3.85);
		if (2.3 != num || 2.4 != 3.25 || 2.5 != b)
		{
			2.3 = num;
			2.4 = 3.25;
			2.5 = b;
			2210.22 = true;
		}
		return 2;
	}

	// Token: 0x06003205 RID: 12805 RVA: 0x0012E48C File Offset: 0x0012C68C
	internal static void 42(2241 1, double 2, bool 3)
	{
		2210.78();
		string key = 2210.70(1);
		2210.2211 4;
		if (!2210.8.TryGetValue(key, out 4))
		{
			4 = (2210.8[key] = new 2210.2211());
		}
		if (4.1 == null)
		{
			4.1 = new double?(2);
			4.2 = (3 ? "mcosu" : "mcosu-unchecked");
			2210.22 = true;
		}
	}

	// Token: 0x06003206 RID: 12806 RVA: 0x0012E4FC File Offset: 0x0012C6FC
	internal static void 43(2241 1, double 2)
	{
		2210.78();
		string key = 2210.47(1);
		double num;
		if (!2210.14.TryGetValue(key, out num) || Math.Abs(num - 2) > 0.0005)
		{
			2210.14[key] = 2;
			2210.22 = true;
		}
	}

	// Token: 0x06003207 RID: 12807 RVA: 0x0012E549 File Offset: 0x0012C749
	internal static void 44(2241 1)
	{
		2210.78();
		if (1 != null && 2210.15.Add(2210.70(1)))
		{
			2210.22 = true;
		}
	}

	// Token: 0x06003208 RID: 12808 RVA: 0x0012E56B File Offset: 0x0012C76B
	internal static bool 45(2241 1)
	{
		2210.78();
		return 1 != null && (1.8 & 2023.Relax) != 2023.None && 2210.15.Contains(2210.70(1));
	}

	// Token: 0x06003209 RID: 12809 RVA: 0x0012E59C File Offset: 0x0012C79C
	internal static double? 46(2241 1)
	{
		2210.78();
		double value;
		if (1 == null || !2210.14.TryGetValue(2210.47(1), out value))
		{
			return null;
		}
		return new double?(value);
	}

	// Token: 0x0600320A RID: 12810 RVA: 0x0012E5D8 File Offset: 0x0012C7D8
	private static string 47(2241 1)
	{
		string text = 2210.2(1);
		if (text.Length != 0)
		{
			return 2210.70(1) + "|" + text;
		}
		return 2210.70(1);
	}

	// Token: 0x0600320B RID: 12811 RVA: 0x0012E60C File Offset: 0x0012C80C
	internal static void 48(2241 1, float 2, float 3, float 4, float 5)
	{
		2210.78();
		2210.13[2210.70(1)] = new float[]
		{
			2,
			3,
			4,
			5
		};
		2210.22 = true;
	}

	// Token: 0x0600320C RID: 12812 RVA: 0x0012E640 File Offset: 0x0012C840
	private static bool 49(2210.2211 1)
	{
		return 1 != null && (1.2 == "mcosu" || 1.2 == "mcosu-unchecked");
	}

	// Token: 0x0600320D RID: 12813 RVA: 0x0012E66C File Offset: 0x0012C86C
	private static bool 50(2241 1, string 2, 2210.2211 3, 1262 4)
	{
		bool result = false;
		float[] array;
		if (2210.13.TryGetValue(2, out array))
		{
			bool flag = 1.43 != null;
			2220.5(1, 4, array[0], array[1], array[2], array[3]);
			result = (!flag && 1.43 != null);
			2210.13.Remove(2);
		}
		3.2 = "mcosu";
		2210.22 = true;
		return result;
	}

	// Token: 0x0600320E RID: 12814 RVA: 0x0012E6D4 File Offset: 0x0012C8D4
	internal static void 51(2241 1, double 2, int 3, int 4, string 5, bool 6)
	{
		2210.78();
		string key = 2210.70(1);
		2210.2211 7;
		if (!2210.8.TryGetValue(key, out 7))
		{
			7 = (2210.8[key] = new 2210.2211());
		}
		bool flag = 2 > 0.0 && !double.IsNaN(2) && !double.IsInfinity(2);
		if (6 && flag)
		{
			7.1 = new double?(2);
			7.2 = "bancho-lazer";
		}
		else if (7.1 == null && flag)
		{
			7.1 = new double?(2);
			7.2 = "bancho";
		}
		if (7.3 < 0)
		{
			7.3 = 3;
		}
		if (7.4 <= 0)
		{
			7.4 = 4;
		}
		if (7.5 == null && !string.IsNullOrEmpty(5))
		{
			7.5 = 5.Replace('\t', ' ');
		}
		2210.22 = true;
	}

	// Token: 0x0600320F RID: 12815 RVA: 0x0012E7BF File Offset: 0x0012C9BF
	private static double 52(double 1)
	{
		return 416.6666666666667 * (1.0 - Math.Pow(0.995, 1));
	}

	// Token: 0x06003210 RID: 12816 RVA: 0x0012E7E4 File Offset: 0x0012C9E4
	private static double 53(double 1)
	{
		double num = 1 / 416.6666666666667;
		if (num < 1.0 - Math.Pow(0.995, 1000.0))
		{
			return Math.Max(0.0, Math.Log(1.0 - num) / Math.Log(0.995));
		}
		return 1000.0;
	}

	// Token: 0x06003211 RID: 12817 RVA: 0x0012E858 File Offset: 0x0012CA58
	internal static void 54(string 1, double 2, 2147 3)
	{
		2210.78();
		2210.16[2210.5(1, 3)] = Math.Max(0.0, 2);
		2210.22 = true;
	}

	// Token: 0x06003212 RID: 12818 RVA: 0x0012E885 File Offset: 0x0012CA85
	internal static void Save()
	{
		2210.79();
	}

	// Token: 0x06003213 RID: 12819 RVA: 0x0012E88C File Offset: 0x0012CA8C
	internal static List<string> 55()
	{
		2210.78();
		HashSet<string> hashSet = new HashSet<string>(2210.10, StringComparer.OrdinalIgnoreCase);
		string current = 1304.189.GetValue();
		if (!string.IsNullOrEmpty(current))
		{
			hashSet.Add(current);
		}
		HashSet<string> hashSet2 = 2210.72();
		foreach (KeyValuePair<string, List<2241>> keyValuePair in 2230.6(true))
		{
			foreach (2241 <<EMPTY_NAME>> in keyValuePair.Value)
			{
				if (<<EMPTY_NAME>> != null && !string.IsNullOrEmpty(<<EMPTY_NAME>>.23) && !hashSet2.Contains(2210.70(<<EMPTY_NAME>>)))
				{
					hashSet.Add(<<EMPTY_NAME>>.23);
				}
			}
		}
		hashSet.RemoveWhere((string 1) => 2210.11.Contains(1) && !string.Equals(1, current, StringComparison.OrdinalIgnoreCase));
		List<string> list = new List<string>(hashSet);
		list.Sort(StringComparer.OrdinalIgnoreCase);
		return list;
	}

	// Token: 0x06003214 RID: 12820 RVA: 0x0012E9B8 File Offset: 0x0012CBB8
	internal static void 56(string 1)
	{
		2210.78();
		1 = (1 ?? string.Empty).Trim();
		if (1.Length == 0)
		{
			return;
		}
		string value = 1304.189.GetValue();
		if (!string.IsNullOrEmpty(value) && 2210.10.Add(value))
		{
			2210.22 = true;
		}
		if (2210.10.Add(1) | 2210.11.Remove(1))
		{
			2210.22 = true;
		}
		1304.189.SetValue(1);
		1654 2 = 1662.100;
		if (2 != null)
		{
			2.3(1);
		}
		2226.5();
		2210.Current = null;
		2210.Refresh();
		1654 3 = 1662.100;
		if (3 == null)
		{
			return;
		}
		3.11(true);
	}

	// Token: 0x06003215 RID: 12821 RVA: 0x0012EA66 File Offset: 0x0012CC66
	internal static int 57(string 1)
	{
		return 2210.65(1).Count;
	}

	// Token: 0x06003216 RID: 12822 RVA: 0x0012EA74 File Offset: 0x0012CC74
	internal static string 58(string 1, bool 2)
	{
		2210.78();
		if (string.Equals(4, 1304.189.GetValue(), StringComparison.OrdinalIgnoreCase))
		{
			return "The profile in use cannot be deleted.";
		}
		if (!2)
		{
			2210.10.Remove(4);
			2210.11.Add(4);
			2210.22 = true;
			2210.79();
			return null;
		}
		2210.72();
		if (2210.27)
		{
			return "osu!'s score file could not be read. Try again in a moment.";
		}
		List<KeyValuePair<string, 2241>> list = 2210.65(4);
		List<string> list2 = new List<string>();
		using (Dictionary<string, HashSet<string>>.Enumerator enumerator = 2210.17.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				KeyValuePair<string, HashSet<string>> shared = enumerator.Current;
				if (!string.Equals(shared.Key, 4, StringComparison.OrdinalIgnoreCase) && list.Exists((KeyValuePair<string, 2241> 1) => shared.Value.Contains(2210.70(1.Value))))
				{
					list2.Add(shared.Key);
				}
			}
		}
		if (list2.Count > 0)
		{
			return "Its plays are shared with " + string.Join(", ", list2) + " (cloned from it): delete that first.";
		}
		foreach (KeyValuePair<string, 2241> keyValuePair in list)
		{
			string text = 2210.70(keyValuePair.Value);
			2230.22(keyValuePair.Key, text, false);
			2210.8.Remove(text);
			2210.9.Remove(text);
			2210.24.Remove(keyValuePair.Value);
		}
		2210.10.Remove(4);
		2210.11.Remove(4);
		foreach (2147 3 in 2210.35)
		{
			2210.16.Remove(2210.5(4, 3));
			2210.19.Remove(2210.5(4, 3));
		}
		2210.17.Remove(4);
		2210.18.Remove(4);
		2210.20.Remove(4);
		2210.21.Remove(4);
		2226.Remove(4);
		2210.22 = true;
		2210.79();
		2230.17(true);
		return null;
	}

	// Token: 0x06003217 RID: 12823 RVA: 0x0012ECB8 File Offset: 0x0012CEB8
	internal static bool 59(string 1)
	{
		2 = (2 ?? string.Empty).Trim();
		if (2210.55().Exists((string 1) => string.Equals(1, 2, StringComparison.OrdinalIgnoreCase)))
		{
			return true;
		}
		Predicate<2241> <>9__1;
		foreach (KeyValuePair<string, List<2241>> keyValuePair in 2230.6(true))
		{
			List<2241> value = keyValuePair.Value;
			Predicate<2241> match;
			if ((match = <>9__1) == null)
			{
				match = (<>9__1 = ((2241 1) => 1 != null && string.Equals(1.23 ?? string.Empty, 2, StringComparison.OrdinalIgnoreCase)));
			}
			if (value.Exists(match))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06003218 RID: 12824 RVA: 0x0012ED7C File Offset: 0x0012CF7C
	internal static int 60(string 1)
	{
		HashSet<string> hashSet = 2210.72();
		int num = 0;
		foreach (KeyValuePair<string, List<2241>> keyValuePair in 2230.6(true))
		{
			foreach (2241 2 in keyValuePair.Value)
			{
				if (2 != null && string.Equals(2.23 ?? string.Empty, 1, StringComparison.OrdinalIgnoreCase) && hashSet.Contains(2210.70(2)))
				{
					num++;
				}
			}
		}
		return num;
	}

	// Token: 0x06003219 RID: 12825 RVA: 0x0012EE40 File Offset: 0x0012D040
	internal static int 61(string 1, string 2)
	{
		2210.78();
		2 = (2 ?? string.Empty).Trim();
		HashSet<string> hashSet = 2210.72();
		if (2210.7 || 2210.27)
		{
			return -1;
		}
		int num = 0;
		foreach (KeyValuePair<string, List<2241>> keyValuePair in 2230.6(true))
		{
			foreach (2241 3 in keyValuePair.Value)
			{
				if (3 != null && string.Equals(3.23 ?? string.Empty, 7, StringComparison.OrdinalIgnoreCase))
				{
					string item = 2210.70(3);
					if (!hashSet.Contains(item))
					{
						3.23 = 2;
						2210.24.Remove(3);
						string item2 = 2210.70(3);
						2210.64(item, item2, true);
						foreach (HashSet<string> hashSet2 in 2210.17.Values)
						{
							if (hashSet2.Contains(item))
							{
								hashSet2.Add(item2);
							}
						}
						foreach (HashSet<string> hashSet3 in 2210.18.Values)
						{
							if (hashSet3.Contains(item))
							{
								hashSet3.Add(item2);
							}
						}
						num++;
					}
				}
			}
		}
		2210.10.RemoveWhere((string 1) => string.Equals(1, 7, StringComparison.OrdinalIgnoreCase));
		2210.10.Add(2);
		foreach (2147 4 in 2210.35)
		{
			double value;
			if (2210.16.TryGetValue(2210.5(7, 4), out value))
			{
				2210.16.Remove(2210.5(7, 4));
				2210.16[2210.5(2, 4)] = value;
			}
			double value2;
			if (2210.19.TryGetValue(2210.5(7, 4), out value2))
			{
				2210.19.Remove(2210.5(7, 4));
				2210.19[2210.5(2, 4)] = value2;
			}
		}
		2226.Move(7, 2);
		string value3;
		if (2210.20.TryGetValue(7, out value3))
		{
			2210.20.Remove(7);
			2210.20[2] = value3;
		}
		Dictionary<string, int> value4;
		if (2210.21.TryGetValue(7, out value4))
		{
			2210.21.Remove(7);
			2210.21[2] = value4;
		}
		foreach (Dictionary<string, HashSet<string>> dictionary in new Dictionary<string, HashSet<string>>[]
		{
			2210.17,
			2210.18
		})
		{
			HashSet<string> value5;
			if (dictionary.TryGetValue(7, out value5))
			{
				dictionary.Remove(7);
				dictionary[2] = value5;
			}
		}
		2210.22 = true;
		2210.79();
		2230.17(true);
		if (string.Equals(1304.189.GetValue() ?? string.Empty, 7, StringComparison.OrdinalIgnoreCase))
		{
			1304.189.SetValue(2);
			1654 5 = 1662.100;
			if (5 != null)
			{
				5.3(2);
			}
			2210.Current = null;
			2210.Refresh();
			1654 6 = 1662.100;
			if (6 != null)
			{
				6.11(true);
			}
		}
		else
		{
			2210.7();
		}
		return num;
	}

	// Token: 0x0600321A RID: 12826 RVA: 0x0012F270 File Offset: 0x0012D470
	internal static int 62(string 1, string 2)
	{
		2210.78();
		2 = (2 ?? string.Empty).Trim();
		if (2210.7)
		{
			return -1;
		}
		HashSet<string> hashSet = 2210.16(2210.17, 2);
		HashSet<string> hashSet2 = 2210.16(2210.18, 2);
		foreach (KeyValuePair<string, List<2241>> keyValuePair in 2230.6(true))
		{
			foreach (2241 3 in keyValuePair.Value)
			{
				if (3 != null)
				{
					string item = 2210.70(3);
					if (2210.26(3, item, 1))
					{
						hashSet.Add(item);
						if (2210.27(1, 3, item))
						{
							hashSet2.Add(item);
						}
					}
				}
			}
		}
		2210.10.Add(2);
		foreach (2147 4 in 2210.35)
		{
			double value;
			if (2210.16.TryGetValue(2210.5(1, 4), out value))
			{
				2210.16[2210.5(2, 4)] = value;
			}
			double value2;
			if (2210.19.TryGetValue(2210.5(1, 4), out value2))
			{
				2210.19[2210.5(2, 4)] = value2;
			}
		}
		2226.Copy(1, 2);
		string value3;
		if (2210.20.TryGetValue(1, out value3))
		{
			2210.20[2] = value3;
		}
		Dictionary<string, int> dictionary;
		if (2210.21.TryGetValue(1, out dictionary))
		{
			2210.21[2] = new Dictionary<string, int>(dictionary, StringComparer.OrdinalIgnoreCase);
		}
		2210.22 = true;
		2210.79();
		2210.7();
		return hashSet.Count;
	}

	// Token: 0x0600321B RID: 12827 RVA: 0x0012F448 File Offset: 0x0012D648
	internal static 2210.2213 63(string 1, string 2)
	{
		2210.78();
		9 = (9 ?? string.Empty).Trim();
		2 = (2 ?? string.Empty).Trim();
		HashSet<string> hashSet = 2210.72();
		if (2210.7 || 2210.27 || 9.Length == 0 || 2.Length == 0 || string.Equals(9, 2, StringComparison.OrdinalIgnoreCase))
		{
			return null;
		}
		2210.2213 3 = new 2210.2213();
		List<KeyValuePair<string, List<2241>>> list = 2230.6(true);
		HashSet<string> hashSet2 = 2210.16(2210.17, 2);
		HashSet<string> hashSet3 = 2210.16(2210.18, 2);
		HashSet<string> hashSet4 = new HashSet<string>(StringComparer.Ordinal);
		HashSet<string> hashSet5 = new HashSet<string>(StringComparer.Ordinal);
		foreach (KeyValuePair<string, List<2241>> keyValuePair in list)
		{
			foreach (2241 4 in keyValuePair.Value)
			{
				if (4 != null && string.Equals(4.23 ?? string.Empty, 2, StringComparison.OrdinalIgnoreCase))
				{
					hashSet4.Add(2210.70(4));
					if (4.16 > 0L)
					{
						hashSet5.Add(keyValuePair.Key + "#" + 4.16.ToString());
					}
				}
			}
		}
		foreach (KeyValuePair<string, List<2241>> keyValuePair2 in list)
		{
			foreach (2241 5 in keyValuePair2.Value)
			{
				if (5 != null && string.Equals(5.23 ?? string.Empty, 9, StringComparison.OrdinalIgnoreCase))
				{
					string item = 2210.70(5);
					if (hashSet.Contains(item))
					{
						if (!hashSet2.Contains(item))
						{
							hashSet2.Add(item);
							if (2210.9.Contains(item))
							{
								hashSet3.Add(item);
							}
							3.3++;
						}
					}
					else
					{
						5.23 = 2;
						2210.24.Remove(5);
						string item2 = 2210.70(5);
						if (hashSet4.Contains(item2) || (5.16 > 0L && hashSet5.Contains(keyValuePair2.Key + "#" + 5.16.ToString())))
						{
							5.23 = 9;
							2210.24.Remove(5);
							2230.22(keyValuePair2.Key, item, true);
							hashSet2.Remove(item);
							hashSet3.Remove(item);
							3.2++;
						}
						else
						{
							2210.64(item, item2, true);
							if (hashSet2.Contains(item))
							{
								if (hashSet3.Contains(item))
								{
									2210.9.Add(item2);
								}
								else
								{
									2210.9.Remove(item2);
								}
								hashSet2.Remove(item);
								hashSet3.Remove(item);
							}
							foreach (KeyValuePair<string, HashSet<string>> keyValuePair3 in 2210.17)
							{
								if (!string.Equals(keyValuePair3.Key, 2, StringComparison.OrdinalIgnoreCase) && keyValuePair3.Value.Contains(item))
								{
									keyValuePair3.Value.Add(item2);
								}
							}
							foreach (KeyValuePair<string, HashSet<string>> keyValuePair4 in 2210.18)
							{
								if (!string.Equals(keyValuePair4.Key, 2, StringComparison.OrdinalIgnoreCase) && keyValuePair4.Value.Contains(item))
								{
									keyValuePair4.Value.Add(item2);
								}
							}
							hashSet4.Add(item2);
							if (5.16 > 0L)
							{
								hashSet5.Add(keyValuePair2.Key + "#" + 5.16.ToString());
							}
							3.1++;
						}
					}
				}
			}
		}
		HashSet<string> hashSet6;
		if (2210.17.TryGetValue(9, out hashSet6))
		{
			HashSet<string> hashSet7;
			2210.18.TryGetValue(9, out hashSet7);
			foreach (string item3 in hashSet6)
			{
				if (!hashSet4.Contains(item3) && !hashSet2.Contains(item3))
				{
					hashSet2.Add(item3);
					if (hashSet7 != null && hashSet7.Contains(item3))
					{
						hashSet3.Add(item3);
					}
					3.3++;
				}
			}
		}
		2210.17.Remove(9);
		2210.18.Remove(9);
		if (hashSet2.Count == 0)
		{
			2210.17.Remove(2);
		}
		if (hashSet3.Count == 0)
		{
			2210.18.Remove(2);
		}
		foreach (2147 6 in 2210.35)
		{
			string key = 2210.5(9, 6);
			string key2 = 2210.5(2, 6);
			double value;
			if (2210.16.TryGetValue(key, out value) && !2210.16.ContainsKey(key2))
			{
				2210.16[key2] = value;
			}
			2210.16.Remove(key);
			double num;
			if (2210.19.TryGetValue(key, out num))
			{
				double num2;
				2210.19[key2] = (2210.19.TryGetValue(key2, out num2) ? num2 : 0.0) + num;
				2210.19.Remove(key);
			}
		}
		string value2;
		if (2210.20.TryGetValue(9, out value2))
		{
			if (!2210.20.ContainsKey(2))
			{
				2210.20[2] = value2;
			}
			2210.20.Remove(9);
		}
		Dictionary<string, int> dictionary;
		if (2210.21.TryGetValue(9, out dictionary))
		{
			Dictionary<string, int> dictionary2;
			if (!2210.21.TryGetValue(2, out dictionary2))
			{
				dictionary2 = (2210.21[2] = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase));
			}
			foreach (KeyValuePair<string, int> keyValuePair5 in dictionary)
			{
				int num3;
				dictionary2[keyValuePair5.Key] = (dictionary2.TryGetValue(keyValuePair5.Key, out num3) ? num3 : 0) + keyValuePair5.Value;
			}
			2210.21.Remove(9);
		}
		if (2226.2(2))
		{
			2226.Remove(9);
		}
		else
		{
			2226.Move(9, 2);
		}
		2210.10.RemoveWhere((string 1) => string.Equals(1, 9, StringComparison.OrdinalIgnoreCase));
		2210.11.RemoveWhere((string 1) => string.Equals(1, 9, StringComparison.OrdinalIgnoreCase));
		2210.10.Add(2);
		2210.11.RemoveWhere((string 1) => string.Equals(1, 2, StringComparison.OrdinalIgnoreCase));
		2210.22 = true;
		2210.79();
		2230.17(true);
		1338.5(string.Concat(new string[]
		{
			"Profiles: merged ",
			9,
			" into ",
			2,
			": ",
			3.1.ToString(),
			" play(s) moved, ",
			3.2.ToString(),
			" already there, ",
			3.3.ToString(),
			" shared."
		}), 1341.Runtime, (1114)2);
		if (string.Equals(1304.189.GetValue() ?? string.Empty, 9, StringComparison.OrdinalIgnoreCase))
		{
			1304.189.SetValue(2);
			1654 7 = 1662.100;
			if (7 != null)
			{
				7.3(2);
			}
			2226.5();
			2210.Current = null;
			2210.Refresh();
			1654 8 = 1662.100;
			if (8 != null)
			{
				8.11(true);
			}
		}
		else
		{
			2210.Current = null;
			2210.7();
		}
		return 3;
	}

	// Token: 0x0600321C RID: 12828 RVA: 0x0012FDF8 File Offset: 0x0012DFF8
	private static void 64(string 1, string 2, bool 3)
	{
		if (1 == 2)
		{
			return;
		}
		2210.2211 4;
		if (2210.8.TryGetValue(1, out 4))
		{
			Dictionary<string, 2210.2211> dictionary = 2210.8;
			2210.2211 value;
			if (!3)
			{
				value = 4;
			}
			else
			{
				2210.2211 5 = new 2210.2211();
				5.1 = 4.1;
				5.2 = 4.2;
				5.3 = 4.3;
				5.4 = 4.4;
				value = 5;
				5.5 = 4.5;
			}
			dictionary[2] = value;
			if (!3)
			{
				2210.8.Remove(1);
			}
		}
		if (2210.9.Contains(1))
		{
			2210.9.Add(2);
			if (!3)
			{
				2210.9.Remove(1);
			}
		}
		if (2210.15.Contains(1))
		{
			2210.15.Add(2);
			2210.22 = true;
			if (!3)
			{
				2210.15.Remove(1);
			}
		}
		List<KeyValuePair<string, double>> list = new List<KeyValuePair<string, double>>();
		foreach (KeyValuePair<string, double> item in 2210.14)
		{
			if (item.Key == 1 || item.Key.StartsWith(1 + "|", StringComparison.Ordinal))
			{
				list.Add(item);
			}
		}
		foreach (KeyValuePair<string, double> keyValuePair in list)
		{
			2210.14[2 + keyValuePair.Key.Substring(1.Length)] = keyValuePair.Value;
			2210.22 = true;
			if (!3)
			{
				2210.14.Remove(keyValuePair.Key);
			}
		}
	}

	// Token: 0x0600321D RID: 12829 RVA: 0x0012FFC8 File Offset: 0x0012E1C8
	private static List<KeyValuePair<string, 2241>> 65(string 1)
	{
		List<KeyValuePair<string, 2241>> list = new List<KeyValuePair<string, 2241>>();
		HashSet<string> hashSet = 2210.72();
		foreach (KeyValuePair<string, List<2241>> keyValuePair in 2230.6(true))
		{
			foreach (2241 2 in keyValuePair.Value)
			{
				if (2 != null && string.Equals(2.23, 1, StringComparison.OrdinalIgnoreCase) && !hashSet.Contains(2210.70(2)))
				{
					list.Add(new KeyValuePair<string, 2241>(keyValuePair.Key, 2));
				}
			}
		}
		return list;
	}

	// Token: 0x0600321E RID: 12830 RVA: 0x00130098 File Offset: 0x0012E298
	private static 1313[] 66()
	{
		return new 1313[]
		{
			1304.14,
			1304.15,
			1304.16,
			1304.17,
			1304.18,
			1304.19,
			1304.20
		};
	}

	// Token: 0x0600321F RID: 12831 RVA: 0x001300D8 File Offset: 0x0012E2D8
	internal static bool 67(2241 1)
	{
		bool flag = 1304.23.1();
		1925 2 = 1.52;
		if (!flag && (2210.68(1) || 1.43 != null || 1.45 || 1.47 || (2 != null && (2.5 != null || 2.7 != null || 2.6 == 1930.Alternate || 2.6 == 1930.SingleTap))))
		{
			return false;
		}
		if (2210.68(1) && !1304.20.1())
		{
			return false;
		}
		if (1.43 != null && !1304.16.1())
		{
			return false;
		}
		if (1.45 && !1304.17.1())
		{
			return false;
		}
		if (1.47 && !1304.21.1())
		{
			return false;
		}
		1925 3 = 1.52;
		return 3 == null || ((3.5 == null || 1304.15.1()) && (3.7 == null || 1304.14.1()) && (3.6 != 1930.Alternate || 1304.18.1()) && (3.6 != 1930.SingleTap || 1304.19.1()));
	}

	// Token: 0x06003220 RID: 12832 RVA: 0x00130200 File Offset: 0x0012E400
	private static bool 68(2241 1)
	{
		return 1.44 != null && Math.Abs(1939.17(1.8, 1.44) - 1939.17(1.8, null)) > 0.001;
	}

	// Token: 0x06003221 RID: 12833 RVA: 0x00130250 File Offset: 0x0012E450
	internal static bool 69(2241 1)
	{
		bool flag = 1.44 != null && Math.Abs(1939.17(1.8, 1.44) - 1939.17(1.8, null)) > 0.001;
		return (1.52 != null && !1.52.IsEmpty) || 1.43 != null || 1.45 || 1.47 || flag;
	}

	// Token: 0x06003222 RID: 12834 RVA: 0x001302D4 File Offset: 0x0012E4D4
	private static string 70(2241 1)
	{
		string result;
		if (!2210.24.TryGetValue(1, out result))
		{
			result = (2210.24[1] = (1.4() ?? string.Empty));
		}
		return result;
	}

	// Token: 0x06003223 RID: 12835 RVA: 0x0013030D File Offset: 0x0012E50D
	internal static HashSet<string> 71()
	{
		return 2210.72();
	}

	// Token: 0x06003224 RID: 12836 RVA: 0x00130314 File Offset: 0x0012E514
	private static HashSet<string> 72()
	{
		try
		{
			string path = Path.Combine(268.InstallDirectory, "scores.db");
			long num = (File.Exists(path) && !string.Equals(Path.GetFullPath(path), Path.GetFullPath(2230.1()), StringComparison.OrdinalIgnoreCase)) ? File.GetLastWriteTimeUtc(path).Ticks : 0L;
			if (2210.25 == null || num != 2210.26)
			{
				2210.25 = ((num == 0L) ? new HashSet<string>() : 2230.7(path));
				2210.26 = num;
			}
			2210.27 = false;
		}
		catch (Exception ex)
		{
			1338.4(ex, "reading osu!'s scores for the local profile", 1341.Runtime);
			2210.25 = (2210.25 ?? new HashSet<string>());
			2210.27 = true;
		}
		return 2210.25;
	}

	// Token: 0x06003225 RID: 12837 RVA: 0x001303D8 File Offset: 0x0012E5D8
	private static void 73(2210.2216 1)
	{
		if (1.8 == 0 && 1.5 > 0)
		{
			2208.Get(2210.11(1304.189.GetValue()), 1.1, null, 2210.Mode);
		}
		if (!2218.Available || 1.5 == 0 || 1.1 < 0.01)
		{
			2210.31 = 0;
			2210.32 = -1.0;
			return;
		}
		if (1.8 > 0)
		{
			return;
		}
		double num = 1.1;
		Action action;
		if ((action = 2210.<>O.<2>__OnRankSettled) == null)
		{
			action = (2210.<>O.<2>__OnRankSettled = new Action(2210.74));
		}
		int? num2 = 2218.Get(num, action, 2210.Mode);
		if (num2 != null)
		{
			2210.75(1, num2.Value);
		}
	}

	// Token: 0x06003226 RID: 12838 RVA: 0x00130498 File Offset: 0x0012E698
	private static void 74()
	{
		2210.2216 <<EMPTY_NAME>> = 2210.Current;
		if (<<EMPTY_NAME>> == null || <<EMPTY_NAME>>.8 > 0 || <<EMPTY_NAME>>.5 == 0)
		{
			return;
		}
		int? num = 2218.Get(<<EMPTY_NAME>>.1, null, 2210.Mode);
		if (num != null)
		{
			2210.75(<<EMPTY_NAME>>, num.Value);
		}
	}

	// Token: 0x06003227 RID: 12839 RVA: 0x001304E8 File Offset: 0x0012E6E8
	private static void 75(2210.2216 1, int 2)
	{
		bool flag = 2 != 2210.31;
		2210.31 = 2;
		2210.32 = 1.1;
		if (1 == 2210.Current)
		{
			2224.Note(2210.5(1304.189.GetValue(), 2210.Mode), 2, 1.2 * 100.0);
		}
		if (flag && 1662.100 != null && 1 == 2210.Current)
		{
			1662.100.13(2210.77(1));
		}
	}

	// Token: 0x06003228 RID: 12840 RVA: 0x00130564 File Offset: 0x0012E764
	internal static int? 76(double 1, Action 2, 2147? 3 = null)
	{
		if (!2218.Available || 1 < 0.01)
		{
			return null;
		}
		2147 4 = 3 ?? 2210.Mode;
		if (4 == 2210.Mode && 2210.31 > 0 && Math.Abs(1 - 2210.32) < 0.005)
		{
			return new int?(2210.31);
		}
		return 2218.Get(1, 2, 4);
	}

	// Token: 0x06003229 RID: 12841 RVA: 0x001305E4 File Offset: 0x0012E7E4
	private static 1659 77(2210.2216 1)
	{
		return new 1659
		{
			8 = -1,
			6 = new 1660(1653.Unknown, false, string.Empty, string.Empty, 0, 2023.None, 2210.Mode),
			5 = 1.4,
			7 = 1.3,
			1 = (float)1.2,
			3 = 1.5,
			4 = ((2218.Available && 1.5 > 0) ? 2210.31 : 0),
			9 = (short)((ushort)Math.Min(65535.0, Math.Round(1.1)))
		};
	}

	// Token: 0x1700027C RID: 636
	// (get) Token: 0x0600322A RID: 12842 RVA: 0x0013068B File Offset: 0x0012E88B
	private static string StorePath
	{
		get
		{
			return 268.2("nekiosu.profile");
		}
	}

	// Token: 0x0600322B RID: 12843 RVA: 0x00130698 File Offset: 0x0012E898
	private static void 78()
	{
		if (2210.8 != null)
		{
			return;
		}
		2210.8 = new Dictionary<string, 2210.2211>(StringComparer.Ordinal);
		2210.9 = new HashSet<string>(StringComparer.Ordinal);
		2210.10 = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
		2210.11 = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
		2210.12 = new HashSet<string>(StringComparer.Ordinal);
		2210.13 = new Dictionary<string, float[]>(StringComparer.Ordinal);
		2210.14 = new Dictionary<string, double>(StringComparer.Ordinal);
		2210.15 = new HashSet<string>(StringComparer.Ordinal);
		2210.16 = new Dictionary<string, double>(StringComparer.OrdinalIgnoreCase);
		2210.17 = new Dictionary<string, HashSet<string>>(StringComparer.OrdinalIgnoreCase);
		2210.18 = new Dictionary<string, HashSet<string>>(StringComparer.OrdinalIgnoreCase);
		2210.19 = new Dictionary<string, double>(StringComparer.OrdinalIgnoreCase);
		2210.20 = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
		2210.21 = new Dictionary<string, Dictionary<string, int>>(StringComparer.OrdinalIgnoreCase);
		try
		{
			if (File.Exists(2210.StorePath))
			{
				int num = 0;
				foreach (string text in File.ReadAllLines(2210.StorePath))
				{
					if (text.StartsWith("!", StringComparison.Ordinal))
					{
						2210.9.Add(text.Substring(1));
					}
					else if (text.StartsWith("@", StringComparison.Ordinal))
					{
						if (text.Length > 1)
						{
							2210.10.Add(text.Substring(1));
						}
					}
					else if (text.StartsWith("+", StringComparison.Ordinal))
					{
						if (text.Length > 1)
						{
							2210.15.Add(text.Substring(1));
						}
					}
					else if (text.StartsWith("*", StringComparison.Ordinal))
					{
						string[] array2 = text.Substring(1).Split(new char[]
						{
							'\t'
						});
						double value;
						if (array2.Length == 2 && array2[0].Length > 0 && double.TryParse(array2[1], NumberStyles.Float, CultureInfo.InvariantCulture, out value))
						{
							2210.14[array2[0]] = value;
						}
					}
					else if (text.StartsWith("&", StringComparison.Ordinal))
					{
						string[] array3 = text.Substring(1).Split(new char[]
						{
							'\t'
						});
						float[] array4 = new float[4];
						bool flag = array3.Length == 5 && array3[0].Length > 0;
						int num2 = 0;
						while (flag && num2 < 4)
						{
							flag = float.TryParse(array3[num2 + 1], NumberStyles.Float, CultureInfo.InvariantCulture, out array4[num2]);
							num2++;
						}
						if (flag)
						{
							2210.13[array3[0]] = array4;
						}
					}
					else if (text.StartsWith("x", StringComparison.Ordinal))
					{
						if (text.Length > 1)
						{
							2210.12.Add(text.Substring(1));
						}
					}
					else if (text.StartsWith("-", StringComparison.Ordinal))
					{
						if (text.Length > 1)
						{
							2210.11.Add(text.Substring(1));
						}
					}
					else if (text.StartsWith("$", StringComparison.Ordinal))
					{
						string[] array5 = text.Substring(1).Split(new char[]
						{
							'\t'
						});
						double value2;
						if (array5.Length == 2 && array5[0].Length > 0 && double.TryParse(array5[1], NumberStyles.Float, CultureInfo.InvariantCulture, out value2))
						{
							2210.19[array5[0]] = value2;
						}
					}
					else if (text.StartsWith("^", StringComparison.Ordinal))
					{
						string[] array6 = text.Substring(1).Split(new char[]
						{
							'\t'
						});
						int value3;
						if (array6.Length == 3 && array6[0].Length > 0 && array6[1].Length > 0 && int.TryParse(array6[2], NumberStyles.Integer, CultureInfo.InvariantCulture, out value3))
						{
							2210.9(array6[0])[array6[1]] = value3;
						}
					}
					else if (text.StartsWith("%", StringComparison.Ordinal) || text.StartsWith("~", StringComparison.Ordinal))
					{
						string[] array7 = text.Substring(1).Split(new char[]
						{
							'\t'
						});
						if (array7.Length == 2 && array7[0].Length > 0 && array7[1].Length > 0)
						{
							2210.16((text[0] == '%') ? 2210.17 : 2210.18, array7[0]).Add(array7[1]);
						}
					}
					else if (text.StartsWith("=", StringComparison.Ordinal))
					{
						string[] array8 = text.Substring(1).Split(new char[]
						{
							'\t'
						});
						if (array8.Length == 2 && array8[0].Length > 0 && array8[1].Length == 2)
						{
							2210.20[array8[0]] = array8[1].ToUpperInvariant();
						}
					}
					else if (text.StartsWith("#", StringComparison.Ordinal))
					{
						string[] array9 = text.Substring(1).Split(new char[]
						{
							'\t'
						});
						double value4;
						if (array9.Length == 2 && array9[0].Length > 0 && double.TryParse(array9[1], NumberStyles.Float, CultureInfo.InvariantCulture, out value4))
						{
							2210.16[array9[0]] = value4;
						}
					}
					else
					{
						string[] array10 = text.Split(new char[]
						{
							'\t'
						});
						if (array10.Length >= 3 && array10[0].Length != 0)
						{
							2210.2211 <<EMPTY_NAME>> = new 2210.2211();
							double value5;
							if (array10[1].Length > 0 && double.TryParse(array10[1], NumberStyles.Float, CultureInfo.InvariantCulture, out value5))
							{
								<<EMPTY_NAME>>.1 = new double?(value5);
								<<EMPTY_NAME>>.2 = array10[2];
								if (!2210.3(array10[2]) && array10[2] != "mcosu" && array10[2] != "mcosu-unchecked" && array10[2] != "bancho" && array10[2] != "bancho-lazer")
								{
									num++;
								}
							}
							if (array10.Length >= 6)
							{
								int num3;
								<<EMPTY_NAME>>.3 = (int.TryParse(array10[3], NumberStyles.Integer, CultureInfo.InvariantCulture, out num3) ? num3 : -1);
								int.TryParse(array10[4], NumberStyles.Integer, CultureInfo.InvariantCulture, out <<EMPTY_NAME>>.4);
								<<EMPTY_NAME>>.5 = ((array10[5].Length > 0) ? array10[5] : null);
							}
							2210.8[array10[0]] = <<EMPTY_NAME>>;
						}
					}
				}
				if (num > 0)
				{
					1338.5("Local profile: the pp calculation changed, " + num.ToString() + " stored value(s) are worked out again (where the beatmap is here).", 1341.Runtime, (1114)2);
				}
			}
		}
		catch (Exception ex)
		{
			2210.7 = true;
			1338.4(ex, "reading nekiosu.profile (it is left as it is until the next start)", 1341.Runtime);
		}
	}

	// Token: 0x0600322C RID: 12844 RVA: 0x00130D70 File Offset: 0x0012EF70
	private static void 79()
	{
		if (!2210.22 || 2210.8 == null || 2210.7)
		{
			return;
		}
		2210.22 = false;
		try
		{
			List<string> list = new List<string>(2210.8.Count + 2210.9.Count + 2210.10.Count);
			foreach (KeyValuePair<string, 2210.2211> keyValuePair in 2210.8)
			{
				2210.2211 value = keyValuePair.Value;
				list.Add(string.Concat(new string[]
				{
					keyValuePair.Key,
					"\t",
					(value.1 != null) ? value.1.Value.ToString("0.###", CultureInfo.InvariantCulture) : string.Empty,
					"\t",
					(value.1 != null) ? value.2 : string.Empty,
					"\t",
					value.3.ToString(CultureInfo.InvariantCulture),
					"\t",
					value.4.ToString(CultureInfo.InvariantCulture),
					"\t",
					value.5 ?? string.Empty
				}));
			}
			foreach (string str in 2210.9)
			{
				list.Add("!" + str);
			}
			foreach (string str2 in 2210.10)
			{
				list.Add("@" + str2);
			}
			foreach (string str3 in 2210.11)
			{
				list.Add("-" + str3);
			}
			foreach (string str4 in 2210.12)
			{
				list.Add("x" + str4);
			}
			foreach (string str5 in 2210.15)
			{
				list.Add("+" + str5);
			}
			foreach (KeyValuePair<string, double> keyValuePair2 in 2210.14)
			{
				list.Add("*" + keyValuePair2.Key + "\t" + keyValuePair2.Value.ToString("0.###", CultureInfo.InvariantCulture));
			}
			foreach (KeyValuePair<string, float[]> keyValuePair3 in 2210.13)
			{
				list.Add("&" + keyValuePair3.Key + "\t" + string.Join("\t", Array.ConvertAll<float, string>(keyValuePair3.Value, (float 1) => 1.ToString("R", CultureInfo.InvariantCulture))));
			}
			foreach (KeyValuePair<string, double> keyValuePair4 in 2210.19)
			{
				list.Add("$" + keyValuePair4.Key + "\t" + keyValuePair4.Value.ToString("0.#", CultureInfo.InvariantCulture));
			}
			foreach (KeyValuePair<string, string> keyValuePair5 in 2210.20)
			{
				list.Add("=" + keyValuePair5.Key + "\t" + keyValuePair5.Value);
			}
			foreach (KeyValuePair<string, Dictionary<string, int>> keyValuePair6 in 2210.21)
			{
				foreach (KeyValuePair<string, int> keyValuePair7 in keyValuePair6.Value)
				{
					list.Add(string.Concat(new string[]
					{
						"^",
						keyValuePair6.Key,
						"\t",
						keyValuePair7.Key,
						"\t",
						keyValuePair7.Value.ToString(CultureInfo.InvariantCulture)
					}));
				}
			}
			foreach (KeyValuePair<string, HashSet<string>> keyValuePair8 in 2210.17)
			{
				foreach (string str6 in keyValuePair8.Value)
				{
					list.Add("%" + keyValuePair8.Key + "\t" + str6);
				}
			}
			foreach (KeyValuePair<string, HashSet<string>> keyValuePair9 in 2210.18)
			{
				foreach (string str7 in keyValuePair9.Value)
				{
					list.Add("~" + keyValuePair9.Key + "\t" + str7);
				}
			}
			foreach (KeyValuePair<string, double> keyValuePair10 in 2210.16)
			{
				list.Add("#" + keyValuePair10.Key + "\t" + keyValuePair10.Value.ToString("0.###", CultureInfo.InvariantCulture));
			}
			string text = 2210.StorePath + ".tmp";
			File.WriteAllLines(text, list);
			if (File.Exists(2210.StorePath))
			{
				File.Replace(text, 2210.StorePath, null);
			}
			else
			{
				File.Move(text, 2210.StorePath);
			}
		}
		catch (Exception ex)
		{
			2210.22 = true;
			1338.4(ex, "writing nekiosu.profile", 1341.Runtime);
		}
	}

	// Token: 0x0600322E RID: 12846 RVA: 0x00131634 File Offset: 0x0012F834
	[CompilerGenerated]
	internal static 2210.2215 <GetMostPlayed>g__Get|65_0(string 1, ref 2210.<>c__DisplayClass65_0 2)
	{
		2210.2215 result;
		if (!2.beatmaps.TryGetValue(1, out result))
		{
			Dictionary<string, 2210.2215> beatmaps = 2.beatmaps;
			2210.2215 3 = new 2210.2215();
			3.1 = 1;
			result = 3;
			beatmaps[1] = 3;
		}
		return result;
	}

	// Token: 0x040024C6 RID: 9414
	private const string 1 = "nekiosu.profile";

	// Token: 0x040024C7 RID: 9415
	private const 2023 2 = 2023.Autoplay | 2023.Relax2 | 2023.Cinema | 2023.Target;

	// Token: 0x040024C8 RID: 9416
	internal const string 3 = "mcosu";

	// Token: 0x040024C9 RID: 9417
	internal const string 4 = "mcosu-unchecked";

	// Token: 0x040024CA RID: 9418
	internal const string 5 = "bancho-lazer";

	// Token: 0x040024CB RID: 9419
	internal const string 6 = "bancho";

	// Token: 0x040024CC RID: 9420
	private static bool 7;

	// Token: 0x040024CD RID: 9421
	private static Dictionary<string, 2210.2211> 8;

	// Token: 0x040024CE RID: 9422
	private static HashSet<string> 9;

	// Token: 0x040024CF RID: 9423
	private static HashSet<string> 10;

	// Token: 0x040024D0 RID: 9424
	private static HashSet<string> 11;

	// Token: 0x040024D1 RID: 9425
	private static HashSet<string> 12;

	// Token: 0x040024D2 RID: 9426
	private static Dictionary<string, float[]> 13;

	// Token: 0x040024D3 RID: 9427
	private static Dictionary<string, double> 14;

	// Token: 0x040024D4 RID: 9428
	private static HashSet<string> 15;

	// Token: 0x040024D5 RID: 9429
	private static Dictionary<string, double> 16;

	// Token: 0x040024D6 RID: 9430
	private static Dictionary<string, HashSet<string>> 17;

	// Token: 0x040024D7 RID: 9431
	private static Dictionary<string, HashSet<string>> 18;

	// Token: 0x040024D8 RID: 9432
	private static Dictionary<string, double> 19;

	// Token: 0x040024D9 RID: 9433
	private static Dictionary<string, string> 20;

	// Token: 0x040024DA RID: 9434
	private static Dictionary<string, Dictionary<string, int>> 21;

	// Token: 0x040024DB RID: 9435
	private static bool 22;

	// Token: 0x040024DC RID: 9436
	private static bool 23;

	// Token: 0x040024DD RID: 9437
	private static readonly Dictionary<2241, string> 24 = new Dictionary<2241, string>();

	// Token: 0x040024DE RID: 9438
	private static HashSet<string> 25;

	// Token: 0x040024DF RID: 9439
	private static long 26 = -1L;

	// Token: 0x040024E0 RID: 9440
	private static bool 27;

	// Token: 0x040024E1 RID: 9441
	private static bool 28;

	// Token: 0x040024E2 RID: 9442
	private static bool 29;

	// Token: 0x040024E3 RID: 9443
	private static string 30;

	// Token: 0x040024E4 RID: 9444
	private static int 31;

	// Token: 0x040024E5 RID: 9445
	private static double 32 = -1.0;

	// Token: 0x040024E7 RID: 9447
	private static 2147? 33;

	// Token: 0x040024E8 RID: 9448
	private static readonly Dictionary<2147, 2210.2216> 34 = new Dictionary<2147, 2210.2216>();

	// Token: 0x040024E9 RID: 9449
	private static readonly 2147[] 35 = new 2147[]
	{
		2147.Osu,
		2147.Taiko,
		2147.CatchTheBeat,
		2147.OsuMania
	};

	// Token: 0x02000671 RID: 1649
	[276]
	internal sealed class 2216
	{
		// Token: 0x040024EA RID: 9450
		public double 1;

		// Token: 0x040024EB RID: 9451
		public double 2;

		// Token: 0x040024EC RID: 9452
		public long 3;

		// Token: 0x040024ED RID: 9453
		public long 4;

		// Token: 0x040024EE RID: 9454
		public int 5;

		// Token: 0x040024EF RID: 9455
		public int 6;

		// Token: 0x040024F0 RID: 9456
		public int 7;

		// Token: 0x040024F1 RID: 9457
		public int 8;

		// Token: 0x040024F2 RID: 9458
		public List<2210.2214> 9 = new List<2210.2214>();

		// Token: 0x040024F3 RID: 9459
		public int 10;
	}

	// Token: 0x02000672 RID: 1650
	[276]
	internal sealed class 2214
	{
		// Token: 0x040024F4 RID: 9460
		public 2241 1;

		// Token: 0x040024F5 RID: 9461
		public string 2;

		// Token: 0x040024F6 RID: 9462
		public 1262 3;

		// Token: 0x040024F7 RID: 9463
		public double 4;

		// Token: 0x040024F8 RID: 9464
		public double 5;

		// Token: 0x040024F9 RID: 9465
		public double 6;

		// Token: 0x040024FA RID: 9466
		public bool 7;

		// Token: 0x040024FB RID: 9467
		public string 8;

		// Token: 0x040024FC RID: 9468
		public int 9;

		// Token: 0x040024FD RID: 9469
		public bool 10;
	}

	// Token: 0x02000673 RID: 1651
	[276]
	private sealed class 2211
	{
		// Token: 0x06003231 RID: 12849 RVA: 0x0013167F File Offset: 0x0012F87F
		public bool 1(2241 1)
		{
			return this.1 != null && this.2 == 2210.1(1);
		}

		// Token: 0x040024FE RID: 9470
		public double? 1;

		// Token: 0x040024FF RID: 9471
		public string 2;

		// Token: 0x04002500 RID: 9472
		public int 3 = -1;

		// Token: 0x04002501 RID: 9473
		public int 4;

		// Token: 0x04002502 RID: 9474
		public string 5;
	}

	// Token: 0x02000674 RID: 1652
	[276]
	internal sealed class 2215
	{
		// Token: 0x04002503 RID: 9475
		public string 1;

		// Token: 0x04002504 RID: 9476
		public 1262 2;

		// Token: 0x04002505 RID: 9477
		public string 3;

		// Token: 0x04002506 RID: 9478
		public int 4;
	}

	// Token: 0x02000675 RID: 1653
	[276]
	internal sealed class 2217
	{
		// Token: 0x04002507 RID: 9479
		public double? 1;

		// Token: 0x04002508 RID: 9480
		public string 2;

		// Token: 0x04002509 RID: 9481
		public int 3 = -1;

		// Token: 0x0400250A RID: 9482
		public int 4;

		// Token: 0x0400250B RID: 9483
		public string 5;

		// Token: 0x0400250C RID: 9484
		public bool 6;

		// Token: 0x0400250D RID: 9485
		public bool 7;
	}

	// Token: 0x02000676 RID: 1654
	[276]
	private sealed class 2212
	{
		// Token: 0x06003235 RID: 12853 RVA: 0x001316C0 File Offset: 0x0012F8C0
		public bool 1(int 1)
		{
			switch (1)
			{
			case 2:
			case 3:
				return this.10;
			case 4:
			case 5:
				return this.7;
			case 6:
				return this.9;
			case 7:
				return this.8;
			default:
				return this.11;
			}
		}

		// Token: 0x0400250E RID: 9486
		public 2147 1;

		// Token: 0x0400250F RID: 9487
		public string 2;

		// Token: 0x04002510 RID: 9488
		public 2241 3;

		// Token: 0x04002511 RID: 9489
		public double? 4;

		// Token: 0x04002512 RID: 9490
		public bool 5;

		// Token: 0x04002513 RID: 9491
		public HashSet<string> 6;

		// Token: 0x04002514 RID: 9492
		public bool 7;

		// Token: 0x04002515 RID: 9493
		public bool 8;

		// Token: 0x04002516 RID: 9494
		public bool 9;

		// Token: 0x04002517 RID: 9495
		public bool 10;

		// Token: 0x04002518 RID: 9496
		public bool 11;

		// Token: 0x04002519 RID: 9497
		public HashSet<string> 12;

		// Token: 0x0400251A RID: 9498
		public readonly HashSet<string> 13 = new HashSet<string>(StringComparer.Ordinal);
	}

	// Token: 0x02000677 RID: 1655
	[276]
	internal sealed class 2213
	{
		// Token: 0x0400251B RID: 9499
		public int 1;

		// Token: 0x0400251C RID: 9500
		public int 2;

		// Token: 0x0400251D RID: 9501
		public int 3;
	}

	// Token: 0x02000678 RID: 1656
	[CompilerGenerated]
	[276]
	private static class <>O
	{
		// Token: 0x0400251E RID: 9502
		public static 1189 <0>__Refresh;

		// Token: 0x0400251F RID: 9503
		public static Action <1>__QueueRefreshAfterPerformance;

		// Token: 0x04002520 RID: 9504
		public static Action <2>__OnRankSettled;
	}
}
