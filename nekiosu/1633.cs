using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

// Token: 0x02000992 RID: 2450
public static class 1633
{
	// Token: 0x170002E2 RID: 738
	// (get) Token: 0x060044BC RID: 17596 RVA: 0x001B16FF File Offset: 0x001AF8FF
	// (set) Token: 0x060044BD RID: 17597 RVA: 0x001B1706 File Offset: 0x001AF906
	public static int Version { get; private set; }

	// Token: 0x060044BE RID: 17598 RVA: 0x001B1710 File Offset: 0x001AF910
	public static 1281? 1(int 1)
	{
		1281 value;
		if (1 <= 0 || !1633.7.TryGetValue(1, out value))
		{
			return null;
		}
		return new 1281?(value);
	}

	// Token: 0x060044BF RID: 17599 RVA: 0x001B1740 File Offset: 0x001AF940
	private static void 2(int 1, int 2)
	{
		1281 3 = 1633.21(2);
		1281 4;
		if (1 <= 0 || (1633.7.TryGetValue(1, out 4) && 4 == 3))
		{
			return;
		}
		1633.7[1] = 3;
		if (!1633.8)
		{
			1633.8 = true;
			1662.89.2(delegate
			{
				1633.8 = false;
				2210.7();
			}, 10000, false);
		}
	}

	// Token: 0x060044C0 RID: 17600 RVA: 0x001B17B5 File Offset: 0x001AF9B5
	private static 1637 3()
	{
		if (261.FullyOffline)
		{
			return null;
		}
		IEnumerable<1637> source = 1632.1();
		Func<1637, bool> predicate;
		if ((predicate = 1633.<>O.<0>__CanUpdateFrom) == null)
		{
			predicate = (1633.<>O.<0>__CanUpdateFrom = new Func<1637, bool>(1633.8));
		}
		return source.FirstOrDefault(predicate);
	}

	// Token: 0x060044C1 RID: 17601 RVA: 0x001B17E5 File Offset: 0x001AF9E5
	public static bool 4(1262 1)
	{
		return 1 != null && 1.25 > 0 && !1.61 && !string.IsNullOrEmpty(1.23) && 1633.3() != null;
	}

	// Token: 0x060044C2 RID: 17602 RVA: 0x001B1812 File Offset: 0x001AFA12
	public static void 5(1262 1, Action 2)
	{
		if (!1304.11.1() || 1 == null || 1633.3() == null)
		{
			return;
		}
		if (1.29 > 0)
		{
			1633.16(1.29, 2);
			return;
		}
		1633.7(1, 2);
	}

	// Token: 0x060044C3 RID: 17603 RVA: 0x001B184C File Offset: 0x001AFA4C
	public static void 6(IEnumerable<1262> 1)
	{
		if (!1304.11.1() || 1633.3() == null)
		{
			return;
		}
		foreach (1262 2 in 1.ToList<1262>())
		{
			if (2.29 > 0)
			{
				1633.4.Remove(2.29);
				1633.16(2.29, null);
			}
			else
			{
				1633.5.Remove(2);
				1633.7(2, null);
			}
		}
	}

	// Token: 0x060044C4 RID: 17604 RVA: 0x001B18EC File Offset: 0x001AFAEC
	private static bool 7(1262 1, Action 2)
	{
		if (1633.5.Contains(1) || 1662.33 < 1633.11 || (1.25 <= 0 && string.IsNullOrEmpty(1.23)))
		{
			return false;
		}
		1633.5.Add(1);
		1633.6++;
		1633.15(1, 2, 1633.3());
		return true;
	}

	// Token: 0x060044C5 RID: 17605 RVA: 0x001B194F File Offset: 0x001AFB4F
	private static bool 8(1637 1)
	{
		return 1.GetBeatmapInfoUrl(1) != null && 1.GetBeatmapInfoByHashUrl("0") != null && 1.GetOsuFileUrl(1) != null;
	}

	// Token: 0x060044C6 RID: 17606 RVA: 0x001B1974 File Offset: 0x001AFB74
	private static string 9(1637 1, 1621 2, Exception 3, int 4, string 5)
	{
		string result;
		try
		{
			if (3 != null)
			{
				result = (1632.3(3) ? "[]" : null);
			}
			else
			{
				string text = 1.ToBeatmapRows(2.12(), 4, 5);
				result = ((text != null && text.TrimStart(Array.Empty<char>()).StartsWith("[", StringComparison.Ordinal)) ? text : null);
			}
		}
		catch
		{
			result = null;
		}
		return result;
	}

	// Token: 0x060044C7 RID: 17607 RVA: 0x001B19E0 File Offset: 0x001AFBE0
	private static void 10(1262 1, 1281 2, bool 3, string 4, string 5)
	{
		bool flag = 2 >= (1281)4 && 1.85 < (1281)4;
		bool flag2 = !3 && 1.97;
		if (!flag && !flag2)
		{
			return;
		}
		string[] array = new string[16];
		array[0] = "Beatmap ";
		int num = 1;
		int num2 = 1.25;
		array[num] = num2.ToString();
		array[2] = " (set ";
		int num3 = 3;
		num2 = 1.29;
		array[num3] = num2.ToString();
		array[4] = "): ";
		array[5] = 4;
		array[6] = " made it ";
		array[7] = 1.85.ToString();
		array[8] = (1.97 ? ", update available" : string.Empty);
		array[9] = " (was ";
		array[10] = 2.ToString();
		array[11] = "; local file ";
		array[12] = 1.23;
		array[13] = ", mirror's ";
		array[14] = (5 ?? "not listed");
		array[15] = ")";
		1338.5(string.Concat(array), 1341.Runtime, (1114)2);
	}

	// Token: 0x060044C8 RID: 17608 RVA: 0x001B1AF0 File Offset: 0x001AFCF0
	private static void 11(1637 1, string 2, Exception 3)
	{
		1338.5(string.Concat(new string[]
		{
			"Beatmap status lookup for ",
			2,
			" on ",
			1.Name,
			" failed: ",
			(3 != null) ? 3.Message : "unreadable answer"
		}), 1341.Runtime, (1114)2);
	}

	// Token: 0x060044C9 RID: 17609 RVA: 0x001B1B48 File Offset: 0x001AFD48
	private static bool 12(1262 1, string 2)
	{
		string text = (2 != null) ? 2.Trim() : null;
		string text2 = (1.89 ?? string.Empty).Trim();
		return !string.IsNullOrEmpty(text) && text2.Length > text.Length && text2.IndexOf(text, StringComparison.OrdinalIgnoreCase) >= 0;
	}

	// Token: 0x060044CA RID: 17610 RVA: 0x001B1BA0 File Offset: 0x001AFDA0
	private static List<1633.1634> 13(string 1)
	{
		List<1633.1634> list = new List<1633.1634>();
		109 2 = 1638.6(1) as 109;
		if (2 == null)
		{
			return list;
		}
		foreach (217 3 in 2.OfType<217>())
		{
			int? num = 1633.14(3["beatmap_id"]);
			int? num2 = 1633.14(3["approved"]);
			if (num != null && num2 != null)
			{
				233 4 = 3["file_md5"] as 233;
				string text = ((4 != null) ? 4.Value : null) as string;
				List<1633.1634> list2 = list;
				1633.1634 5 = new 1633.1634();
				5.1 = num.Value;
				5.2 = 1633.14(3["beatmapset_id"]).GetValueOrDefault();
				5.3 = num2.Value;
				5.4 = ((text != null && text.Length == 32) ? text.ToLowerInvariant() : string.Empty);
				233 6 = 3["version"] as 233;
				5.5 = (((6 != null) ? 6.Value : null) as string);
				list2.Add(5);
			}
		}
		return list;
	}

	// Token: 0x060044CB RID: 17611 RVA: 0x001B1D00 File Offset: 0x001AFF00
	private static int? 14(226 1)
	{
		233 2 = 1 as 233;
		object obj = (2 != null) ? 2.Value : null;
		int value;
		if (obj == null || !int.TryParse(Convert.ToString(obj, CultureInfo.InvariantCulture), NumberStyles.Integer, CultureInfo.InvariantCulture, out value))
		{
			return null;
		}
		return new int?(value);
	}

	// Token: 0x060044CC RID: 17612 RVA: 0x001B1D50 File Offset: 0x001AFF50
	private static void 15(1262 1, Action 2, 1637 3)
	{
		1621 4 = new 1621((5.25 > 0) ? 3.GetBeatmapInfoUrl(5.25) : 3.GetBeatmapInfoByHashUrl(5.23), Array.Empty<object>());
		4.9(delegate(1621 1, Exception 2)
		{
			string response = 1633.9(3, 1, 2, 5.25, (5.25 > 0) ? null : 5.23);
			if (response == null)
			{
				1637 mirror = 3;
				string str = "beatmap ";
				int 7 = 5.25;
				1633.11(mirror, str + 7.ToString(), 2);
			}
			1662.89.Schedule(delegate()
			{
				if (response == null)
				{
					1637 mirror2 = 3;
					Func<1637, bool> func;
					if ((func = 1633.<>O.<0>__CanUpdateFrom) == null)
					{
						func = (1633.<>O.<0>__CanUpdateFrom = new Func<1637, bool>(1633.8));
					}
					1637 8 = 1632.Next(mirror2, func);
					if (8 != null)
					{
						1633.15(5, 6, 8);
						return;
					}
				}
				1633.6--;
				if (response == null)
				{
					1633.5.Remove(5);
					1633.11 = 1662.33 + 60000;
					return;
				}
				1281 9 = 5.85;
				bool 10 = 5.97;
				int 11 = 5.25;
				1633.1634 12 = 1633.13(response).FirstOrDefault<1633.1634>();
				if (12 != null && !1633.24(12.4, 5.23) && 1633.12(5, 12.5))
				{
					5.97 = false;
					5.85 = (1281)1;
				}
				else if (12 != null)
				{
					5.25 = 12.1;
					1633.2(5.25, 12.3);
					if (12.2 > 0)
					{
						5.29 = 12.2;
					}
					5.85 = 1633.21(12.3);
					if (12.4.Length > 0)
					{
						1633.1[5.25] = 12.4;
						5.97 = (!5.61 && !1633.24(12.4, 5.23));
						if (5.97)
						{
							5.85 = (1281)0;
						}
					}
				}
				else
				{
					5.85 = (1281)1;
				}
				if (9 != 5.85 || 10 != 5.97 || 11 != 5.25)
				{
					string text;
					1633.10(5, 9, 10, 3.Name, 1633.1.TryGetValue(5.25, out text) ? text : null);
					1633.Version++;
					Action onChanged = 6;
					if (onChanged == null)
					{
						return;
					}
					onChanged();
				}
			}, false);
		});
		4.Start();
	}

	// Token: 0x060044CD RID: 17613 RVA: 0x001B1DD8 File Offset: 0x001AFFD8
	private static bool 16(int 1, Action 2)
	{
		if (1633.4.Contains(1) || 1662.33 < 1633.11)
		{
			return false;
		}
		1633.4.Add(1);
		1633.6++;
		1633.17(1, 2, 1633.3());
		return true;
	}

	// Token: 0x060044CE RID: 17614 RVA: 0x001B1E28 File Offset: 0x001B0028
	private static void 17(int 1, Action 2, 1637 3)
	{
		1621 4 = new 1621(3.GetBeatmapSetInfoUrl(5), Array.Empty<object>());
		4.9(delegate(1621 1, Exception 2)
		{
			string response = 1633.9(3, 1, 2, 0, null);
			if (response == null)
			{
				1633.11(3, "set " + 5.ToString(), 2);
			}
			1662.89.Schedule(delegate()
			{
				if (response == null)
				{
					1637 mirror = 3;
					Func<1637, bool> func;
					if ((func = 1633.<>O.<0>__CanUpdateFrom) == null)
					{
						func = (1633.<>O.<0>__CanUpdateFrom = new Func<1637, bool>(1633.8));
					}
					1637 7 = 1632.Next(mirror, func);
					if (7 != null)
					{
						1633.17(5, 6, 7);
						return;
					}
				}
				1633.6--;
				if (response == null)
				{
					1633.4.Remove(5);
					1633.11 = 1662.33 + 60000;
					return;
				}
				if (1633.18(5, response, 3.Name))
				{
					1633.Version++;
					Action onChanged = 6;
					if (onChanged == null)
					{
						return;
					}
					onChanged();
				}
			}, false);
		});
		4.Start();
	}

	// Token: 0x060044CF RID: 17615 RVA: 0x001B1E84 File Offset: 0x001B0084
	private static bool 18(int 1, string 2, string 3)
	{
		Dictionary<int, string[]> dictionary = new Dictionary<int, string[]>();
		Dictionary<string, string[]> dictionary2 = new Dictionary<string, string[]>(StringComparer.OrdinalIgnoreCase);
		foreach (1633.1634 4 in 1633.13(2))
		{
			string[] array = new string[]
			{
				4.4,
				4.3.ToString(CultureInfo.InvariantCulture),
				4.1.ToString(CultureInfo.InvariantCulture),
				4.5
			};
			dictionary[4.1] = array;
			1633.2(4.1, 4.3);
			if (4.4.Length > 0)
			{
				dictionary2[array[0]] = array;
			}
		}
		bool result = false;
		List<1262> list = 1272.3;
		Predicate<1262> <>9__0;
		Predicate<1262> match;
		if ((match = <>9__0) == null)
		{
			match = (<>9__0 = ((1262 1) => 1.29 == 9));
		}
		foreach (1262 5 in list.FindAll(match))
		{
			1281 6 = 5.85;
			bool 7 = 5.97;
			int 8 = 5.25;
			string[] array2;
			if (!string.IsNullOrEmpty(5.23) && dictionary2.TryGetValue(5.23.ToLowerInvariant(), out array2))
			{
				5.25 = int.Parse(array2[2]);
				1633.1[5.25] = array2[0];
				5.97 = false;
				5.85 = 1633.21(int.Parse(array2[1]));
			}
			else if (5.25 > 0 && dictionary.TryGetValue(5.25, out array2) && !1633.12(5, array2[3]))
			{
				1633.1[5.25] = array2[0];
				5.97 = (array2[0].Length > 0 && !5.61 && !1633.24(array2[0], 5.23));
				5.85 = (5.97 ? ((1281)0) : 1633.21(int.Parse(array2[1])));
			}
			else
			{
				5.85 = (1281)1;
				5.97 = false;
			}
			if (6 != 5.85 || 7 != 5.97 || 8 != 5.25)
			{
				result = true;
				string text;
				1633.10(5, 6, 7, 3, 1633.1.TryGetValue(5.25, out text) ? text : null);
			}
		}
		return result;
	}

	// Token: 0x060044D0 RID: 17616 RVA: 0x001B2170 File Offset: 0x001B0370
	public static void 19()
	{
		if (1662.33 < 1633.10)
		{
			return;
		}
		1633.10 = 1662.33 + 1500;
		if (!1304.11.1() || 1633.6 > 0 || 1662.33 < 1633.11 || 1662.78 == 1677.Play || 1662.78 == 1677.Edit || 1272.3 == null || 1633.3() == null)
		{
			return;
		}
		List<1262> list = 1272.3;
		for (int i = 0; i < list.Count; i++)
		{
			if (1633.9 >= list.Count)
			{
				1633.9 = 0;
				if (i > 0)
				{
					break;
				}
			}
			1262 <<EMPTY_NAME>> = list[1633.9++];
			if ((<<EMPTY_NAME>>.85 == (1281)6 || (<<EMPTY_NAME>>.85 == (1281)1 && <<EMPTY_NAME>>.25 > 0)) && <<EMPTY_NAME>>.29 > 0 && !1633.4.Contains(<<EMPTY_NAME>>.29))
			{
				if (1633.16(<<EMPTY_NAME>>.29, null))
				{
					return;
				}
			}
			else if (<<EMPTY_NAME>>.85 == (1281)0 && !<<EMPTY_NAME>>.97)
			{
				if (<<EMPTY_NAME>>.29 > 0)
				{
					1633.4.Remove(<<EMPTY_NAME>>.29);
				}
				else
				{
					1633.5.Remove(<<EMPTY_NAME>>);
				}
				if ((<<EMPTY_NAME>>.29 > 0) ? 1633.16(<<EMPTY_NAME>>.29, null) : 1633.7(<<EMPTY_NAME>>, null))
				{
					return;
				}
			}
		}
		1633.10 = 1662.33 + 30000;
	}

	// Token: 0x060044D1 RID: 17617 RVA: 0x001B22DC File Offset: 0x001B04DC
	public static void 20(1262 1, Action<bool, string> 2)
	{
		1633.<>c__DisplayClass35_0 CS$<>8__locals1 = new 1633.<>c__DisplayClass35_0();
		CS$<>8__locals1.beatmap = 1;
		CS$<>8__locals1.done = 2;
		1637 3 = 1633.3();
		if (!1633.4(CS$<>8__locals1.beatmap) || 3 == null)
		{
			CS$<>8__locals1.done(false, "This beatmap cannot be updated.");
			return;
		}
		CS$<>8__locals1.beatmapId = CS$<>8__locals1.beatmap.25;
		if (!1633.2.Add(CS$<>8__locals1.beatmapId))
		{
			return;
		}
		1633.1.TryGetValue(CS$<>8__locals1.beatmapId, out CS$<>8__locals1.expectedHash);
		CS$<>8__locals1.watching = (1272.15 != null && 1272.15.EnableRaisingEvents);
		if (CS$<>8__locals1.watching)
		{
			1272.15.EnableRaisingEvents = false;
		}
		string str = Path.Combine(CS$<>8__locals1.beatmap.44(), CS$<>8__locals1.beatmap.58);
		CS$<>8__locals1.temporaryPath = str + "_";
		CS$<>8__locals1.<Update>g__DownloadFrom|0(3);
	}

	// Token: 0x060044D2 RID: 17618 RVA: 0x001B23C1 File Offset: 0x001B05C1
	private static 1281 21(int 1)
	{
		switch (1)
		{
		case 1:
			return (1281)4;
		case 2:
			return (1281)5;
		case 3:
			return (1281)6;
		case 4:
			return (1281)7;
		default:
			return (1281)2;
		}
	}

	// Token: 0x060044D3 RID: 17619 RVA: 0x001B23E8 File Offset: 0x001B05E8
	private static string 22(string 1, string 2, string 3)
	{
		string result;
		try
		{
			byte[] array = File.ReadAllBytes(1);
			if (!Encoding.UTF8.GetString(array, 0, Math.Min(array.Length, 64)).TrimStart(new char[]
			{
				'﻿',
				' ',
				'\r',
				'\n',
				'\t'
			}).StartsWith("osu file format v", StringComparison.Ordinal))
			{
				result = "The mirror did not return a beatmap file.";
			}
			else
			{
				string text;
				using (MD5 md = MD5.Create())
				{
					text = BitConverter.ToString(md.ComputeHash(array)).Replace("-", string.Empty).ToLowerInvariant();
				}
				if (1633.24(text, 3) || (!string.IsNullOrEmpty(2) && !1633.24(text, 2)))
				{
					result = "The mirror does not have the new version yet. Try again later.";
				}
				else
				{
					result = null;
				}
			}
		}
		catch (Exception ex)
		{
			result = "Could not read the downloaded file: " + ex.Message;
		}
		return result;
	}

	// Token: 0x060044D4 RID: 17620 RVA: 0x001B24CC File Offset: 0x001B06CC
	private static void 23(bool 1)
	{
		if (1 && 1272.15 != null)
		{
			1272.15.EnableRaisingEvents = true;
		}
	}

	// Token: 0x060044D5 RID: 17621 RVA: 0x001B24E3 File Offset: 0x001B06E3
	private static bool 24(string 1, string 2)
	{
		return string.Equals(1, 2, StringComparison.OrdinalIgnoreCase);
	}

	// Token: 0x060044D6 RID: 17622 RVA: 0x001B24F0 File Offset: 0x001B06F0
	private static void 25(string 1)
	{
		try
		{
			File.Delete(1);
		}
		catch
		{
		}
	}

	// Token: 0x04003288 RID: 12936
	private static readonly Dictionary<int, string> 1 = new Dictionary<int, string>();

	// Token: 0x04003289 RID: 12937
	private static readonly HashSet<int> 2 = new HashSet<int>();

	// Token: 0x0400328A RID: 12938
	private static readonly Dictionary<int, 1281> 3 = new Dictionary<int, 1281>();

	// Token: 0x0400328B RID: 12939
	private static readonly HashSet<int> 4 = new HashSet<int>();

	// Token: 0x0400328C RID: 12940
	private static readonly HashSet<1262> 5 = new HashSet<1262>();

	// Token: 0x0400328D RID: 12941
	private static int 6;

	// Token: 0x0400328F RID: 12943
	private static readonly Dictionary<int, 1281> 7 = new Dictionary<int, 1281>();

	// Token: 0x04003290 RID: 12944
	private static bool 8;

	// Token: 0x04003291 RID: 12945
	private static int 9;

	// Token: 0x04003292 RID: 12946
	private static int 10;

	// Token: 0x04003293 RID: 12947
	private static int 11;

	// Token: 0x02000993 RID: 2451
	private sealed class 1634
	{
		// Token: 0x04003294 RID: 12948
		public int 1;

		// Token: 0x04003295 RID: 12949
		public int 2;

		// Token: 0x04003296 RID: 12950
		public int 3;

		// Token: 0x04003297 RID: 12951
		public string 4;

		// Token: 0x04003298 RID: 12952
		public string 5;
	}

	// Token: 0x02000994 RID: 2452
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x04003299 RID: 12953
		public static Func<1637, bool> <0>__CanUpdateFrom;
	}
}
