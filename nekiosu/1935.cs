using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

// Token: 0x0200083C RID: 2108
internal static class 1935
{
	// Token: 0x170002CD RID: 717
	// (get) Token: 0x06003D31 RID: 15665 RVA: 0x00182030 File Offset: 0x00180230
	private static string FilePath
	{
		get
		{
			return 268.2("nekiosu.checkpoints");
		}
	}

	// Token: 0x06003D32 RID: 15666 RVA: 0x0018203C File Offset: 0x0018023C
	internal static List<int> Get(string 1)
	{
		1935.34();
		List<int> collection;
		if (1 == null || !1935.4.TryGetValue(1, out collection))
		{
			return new List<int>();
		}
		return new List<int>(collection);
	}

	// Token: 0x06003D33 RID: 15667 RVA: 0x0018206C File Offset: 0x0018026C
	internal static List<1937> 1(string 1)
	{
		1935.34();
		List<1937> collection;
		if (1 == null || !1935.5.TryGetValue(1, out collection))
		{
			return new List<1937>();
		}
		return new List<1937>(collection);
	}

	// Token: 0x06003D34 RID: 15668 RVA: 0x0018209C File Offset: 0x0018029C
	internal static string 2(string 1, int 2)
	{
		string text = 1935.10(1, 1935.8(2));
		if (text != null)
		{
			return text;
		}
		int num = 1935.Get(1).IndexOf(2);
		return "Checkpoint " + ((num >= 0) ? (num + 1) : 0).ToString();
	}

	// Token: 0x06003D35 RID: 15669 RVA: 0x001820E4 File Offset: 0x001802E4
	internal static string 3(string 1, 1937 2)
	{
		string text = 1935.10(1, 1935.9(2));
		if (text != null)
		{
			return text;
		}
		int num = 1935.1(1).IndexOf(2);
		return "Segment " + ((num >= 0) ? (num + 1) : 0).ToString();
	}

	// Token: 0x06003D36 RID: 15670 RVA: 0x0018212C File Offset: 0x0018032C
	internal static string 4(string 1, int 2)
	{
		return 1935.10(1, 1935.8(2));
	}

	// Token: 0x06003D37 RID: 15671 RVA: 0x0018213A File Offset: 0x0018033A
	internal static string 5(string 1, 1937 2)
	{
		return 1935.10(1, 1935.9(2));
	}

	// Token: 0x06003D38 RID: 15672 RVA: 0x00182148 File Offset: 0x00180348
	internal static void 6(string 1, int 2, string 3)
	{
		1935.11(1, 1935.8(2), 3);
	}

	// Token: 0x06003D39 RID: 15673 RVA: 0x00182157 File Offset: 0x00180357
	internal static void 7(string 1, 1937 2, string 3)
	{
		1935.11(1, 1935.9(2), 3);
	}

	// Token: 0x06003D3A RID: 15674 RVA: 0x00182166 File Offset: 0x00180366
	private static string 8(int 1)
	{
		return "c" + 1.ToString(CultureInfo.InvariantCulture);
	}

	// Token: 0x06003D3B RID: 15675 RVA: 0x00182180 File Offset: 0x00180380
	private static string 9(1937 1)
	{
		return "s" + 1.1.ToString(CultureInfo.InvariantCulture) + "-" + 1.2.ToString(CultureInfo.InvariantCulture);
	}

	// Token: 0x06003D3C RID: 15676 RVA: 0x001821C4 File Offset: 0x001803C4
	private static string 10(string 1, string 2)
	{
		1935.34();
		Dictionary<string, string> dictionary;
		string result;
		if (1 == null || !1935.7.TryGetValue(1, out dictionary) || !dictionary.TryGetValue(2, out result))
		{
			return null;
		}
		return result;
	}

	// Token: 0x06003D3D RID: 15677 RVA: 0x001821F8 File Offset: 0x001803F8
	private static void 11(string 1, string 2, string 3)
	{
		if (1 == null)
		{
			return;
		}
		1935.34();
		3 = ((3 != null) ? 3.Trim() : null);
		if (string.IsNullOrEmpty(3))
		{
			if (!1935.12(1, 2))
			{
				return;
			}
		}
		else
		{
			Dictionary<string, string> dictionary;
			if (!1935.7.TryGetValue(1, out dictionary))
			{
				dictionary = (1935.7[1] = new Dictionary<string, string>(StringComparer.Ordinal));
			}
			dictionary[2] = 3;
		}
		1935.Save();
	}

	// Token: 0x06003D3E RID: 15678 RVA: 0x00182264 File Offset: 0x00180464
	private static bool 12(string 1, string 2)
	{
		Dictionary<string, string> dictionary;
		if (!1935.7.TryGetValue(1, out dictionary) || !dictionary.Remove(2))
		{
			return false;
		}
		if (dictionary.Count == 0)
		{
			1935.7.Remove(1);
		}
		return true;
	}

	// Token: 0x06003D3F RID: 15679 RVA: 0x001822A0 File Offset: 0x001804A0
	internal static 1934? 13(string 1)
	{
		1935.34();
		1934 value;
		if (1 == null || !1935.6.TryGetValue(1, out value))
		{
			return null;
		}
		return new 1934?(value);
	}

	// Token: 0x06003D40 RID: 15680 RVA: 0x001822D4 File Offset: 0x001804D4
	internal static void 14(string 1, 1934? 2)
	{
		if (1 == null)
		{
			return;
		}
		1935.34();
		if (2 != null)
		{
			1935.6[1] = 2.Value;
		}
		else if (!1935.6.Remove(1))
		{
			return;
		}
		1935.Save();
	}

	// Token: 0x06003D41 RID: 15681 RVA: 0x0018230F File Offset: 0x0018050F
	internal static bool 15(string 1, int 2)
	{
		if (1 == null)
		{
			return false;
		}
		1935.34();
		if (!1935.23(1, 2))
		{
			return false;
		}
		1935.Save();
		return true;
	}

	// Token: 0x06003D42 RID: 15682 RVA: 0x0018232C File Offset: 0x0018052C
	internal static bool 16(string 1, 1937 2)
	{
		if (1 == null || 2.2 - 2.1 < 1000)
		{
			return false;
		}
		1935.34();
		if (!1935.24(1, 2))
		{
			return false;
		}
		1935.Save();
		return true;
	}

	// Token: 0x06003D43 RID: 15683 RVA: 0x00182360 File Offset: 0x00180560
	internal static void 17(string 1, 1937 2)
	{
		1935.34();
		List<1937> list;
		if (1 != null && 1935.5.TryGetValue(1, out list) && list.Remove(2))
		{
			if (list.Count == 0)
			{
				1935.5.Remove(1);
			}
			1934 3;
			if (1935.6.TryGetValue(1, out 3) && 3.2(2))
			{
				1935.6.Remove(1);
			}
			1935.12(1, 1935.9(2));
			1935.Save();
		}
	}

	// Token: 0x06003D44 RID: 15684 RVA: 0x001823D8 File Offset: 0x001805D8
	internal static int? 18(string 1, int 2)
	{
		1935.34();
		List<int> list;
		if (4 == null || !1935.4.TryGetValue(4, out list) || list.Count == 0)
		{
			return null;
		}
		int num = (from 1 in list
		orderby Math.Abs(1 - 2)
		select 1).First<int>();
		list.Remove(num);
		if (list.Count == 0)
		{
			1935.4.Remove(4);
		}
		1934 3;
		if (1935.6.TryGetValue(4, out 3) && 3.1(num))
		{
			1935.6.Remove(4);
		}
		1935.12(4, 1935.8(num));
		1935.Save();
		return new int?(num);
	}

	// Token: 0x06003D45 RID: 15685 RVA: 0x0018248D File Offset: 0x0018068D
	internal static void 19(string 1)
	{
		1935.34();
		if (1 != null && (1935.4.Remove(1) | 1935.5.Remove(1) | 1935.6.Remove(1) | 1935.7.Remove(1)))
		{
			1935.Save();
		}
	}

	// Token: 0x06003D46 RID: 15686 RVA: 0x001824D0 File Offset: 0x001806D0
	internal static string 20(string 1, string 2, int 3)
	{
		List<int> list = 1935.Get(1);
		List<1937> list2 = 1935.1(1);
		if (list.Count == 0 && list2.Count == 0)
		{
			return null;
		}
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("```json\n{\n");
		stringBuilder.Append("  \"beatmap\": ").Append(1935.21(2 ?? string.Empty)).Append(",\n");
		if (3 > 0)
		{
			stringBuilder.Append("  \"beatmap_id\": ").Append(3.ToString(CultureInfo.InvariantCulture)).Append(",\n");
		}
		stringBuilder.Append("  \"md5\": ").Append(1935.21(1)).Append(",\n");
		stringBuilder.Append("  \"checkpoints\": [");
		for (int i = 0; i < list.Count; i++)
		{
			stringBuilder.Append((i == 0) ? "\n" : ",\n").Append("    { \"time\": ").Append(list[i].ToString(CultureInfo.InvariantCulture)).Append(1935.22(1935.10(1, 1935.8(list[i])))).Append(" }");
		}
		stringBuilder.Append((list.Count > 0) ? "\n  ],\n" : "],\n");
		stringBuilder.Append("  \"segments\": [");
		for (int j = 0; j < list2.Count; j++)
		{
			stringBuilder.Append((j == 0) ? "\n" : ",\n").Append("    { \"start\": ").Append(list2[j].1.ToString(CultureInfo.InvariantCulture)).Append(", \"end\": ").Append(list2[j].2.ToString(CultureInfo.InvariantCulture)).Append(1935.22(1935.10(1, 1935.9(list2[j])))).Append(" }");
		}
		stringBuilder.Append((list2.Count > 0) ? "\n  ]" : "]");
		1934? 4 = 1935.13(1);
		if (4 != null)
		{
			StringBuilder stringBuilder2 = stringBuilder.Append(",\n  \"autostart\": ");
			1934 value = 4.Value;
			string value2;
			if (value.2 == null)
			{
				value2 = "{ \"time\": " + 4.Value.1.ToString(CultureInfo.InvariantCulture) + " }";
			}
			else
			{
				string[] array = new string[5];
				array[0] = "{ \"start\": ";
				int num = 1;
				value = 4.Value;
				array[num] = value.2.Value.1.ToString(CultureInfo.InvariantCulture);
				array[2] = ", \"end\": ";
				int num2 = 3;
				value = 4.Value;
				array[num2] = value.2.Value.2.ToString(CultureInfo.InvariantCulture);
				array[4] = " }";
				value2 = string.Concat(array);
			}
			stringBuilder2.Append(value2);
		}
		stringBuilder.Append("\n}\n```");
		return stringBuilder.ToString();
	}

	// Token: 0x06003D47 RID: 15687 RVA: 0x001827EC File Offset: 0x001809EC
	private static string 21(string 1)
	{
		StringBuilder stringBuilder = new StringBuilder("\"");
		foreach (char c in 1)
		{
			if (c == '"' || c == '\\')
			{
				stringBuilder.Append('\\').Append(c);
			}
			else if (c < ' ')
			{
				StringBuilder stringBuilder2 = stringBuilder.Append("\\u");
				int num = (int)c;
				stringBuilder2.Append(num.ToString("x4", CultureInfo.InvariantCulture));
			}
			else
			{
				stringBuilder.Append(c);
			}
		}
		return stringBuilder.Append('"').ToString();
	}

	// Token: 0x06003D48 RID: 15688 RVA: 0x0018287B File Offset: 0x00180A7B
	private static string 22(string 1)
	{
		if (!string.IsNullOrEmpty(1))
		{
			return ", \"name\": " + 1935.21(1);
		}
		return string.Empty;
	}

	// Token: 0x06003D49 RID: 15689 RVA: 0x0018289C File Offset: 0x00180A9C
	internal static int? Import(string 1, string 2, out string 3)
	{
		3 = null;
		2 = (2 ?? string.Empty);
		int num = 2.IndexOf('{');
		int num2 = 2.LastIndexOf('}');
		217 4 = null;
		if (num >= 0 && num2 > num)
		{
			try
			{
				4 = 217.Parse(2.Substring(num, num2 - num + 1));
			}
			catch (Exception)
			{
			}
		}
		if (4 == null || 4["md5"] == null)
		{
			3 = "The clipboard has no checkpoints";
			int? result = null;
			return result;
		}
		if (!string.Equals((string)4["md5"], 1, StringComparison.OrdinalIgnoreCase))
		{
			3 = "These checkpoints are for another beatmap (or another version of it)";
			int? result = null;
			return result;
		}
		List<int> list = new List<int>();
		List<1937> list2 = new List<1937>();
		Dictionary<string, string> dictionary = new Dictionary<string, string>(StringComparer.Ordinal);
		1934? 5 = null;
		try
		{
			foreach (226 6 in ((4["checkpoints"] as 109) ?? new 109()))
			{
				int item = (int)6["time"];
				list.Add(item);
				if (!string.IsNullOrEmpty((string)6["name"]))
				{
					dictionary[1935.8(item)] = (string)6["name"];
				}
			}
			foreach (226 7 in ((4["segments"] as 109) ?? new 109()))
			{
				1937 item2 = new 1937((int)7["start"], (int)7["end"]);
				list2.Add(item2);
				if (!string.IsNullOrEmpty((string)7["name"]))
				{
					dictionary[1935.9(item2)] = (string)7["name"];
				}
			}
			217 8 = 4["autostart"] as 217;
			if (8 != null)
			{
				5 = new 1934?((8["time"] != null) ? new 1934((int)8["time"]) : new 1934(new 1937((int)8["start"], (int)8["end"])));
			}
		}
		catch (Exception)
		{
			3 = "The checkpoints could not be read";
			int? result = null;
			return result;
		}
		1935.34();
		int num3 = 0;
		foreach (int num4 in list)
		{
			if (1935.23(1, num4))
			{
				num3++;
			}
		}
		foreach (1937 9 in list2)
		{
			if (9.2 - 9.1 >= 1000 && 1935.24(1, 9))
			{
				num3++;
			}
		}
		HashSet<string> hashSet = new HashSet<string>(StringComparer.Ordinal);
		List<int> list3;
		if (1935.4.TryGetValue(1, out list3))
		{
			HashSet<string> hashSet2 = hashSet;
			IEnumerable<int> source = list3;
			Func<int, string> selector;
			if ((selector = 1935.<>O.<0>__CheckpointKey) == null)
			{
				selector = (1935.<>O.<0>__CheckpointKey = new Func<int, string>(1935.8));
			}
			hashSet2.UnionWith(source.Select(selector));
		}
		List<1937> list4;
		if (1935.5.TryGetValue(1, out list4))
		{
			HashSet<string> hashSet3 = hashSet;
			IEnumerable<1937> source2 = list4;
			Func<1937, string> selector2;
			if ((selector2 = 1935.<>O.<1>__SegmentKey) == null)
			{
				selector2 = (1935.<>O.<1>__SegmentKey = new Func<1937, string>(1935.9));
			}
			hashSet3.UnionWith(source2.Select(selector2));
		}
		if (5 != null)
		{
			HashSet<string> hashSet4 = hashSet;
			1934 value = 5.Value;
			string item3;
			if (value.2 == null)
			{
				item3 = 1935.8(5.Value.1);
			}
			else
			{
				value = 5.Value;
				item3 = 1935.9(value.2.Value);
			}
			if (!hashSet4.Contains(item3))
			{
				5 = null;
			}
		}
		if (dictionary != null && dictionary.Count > 0)
		{
			Dictionary<string, string> dictionary2;
			if (!1935.7.TryGetValue(1, out dictionary2))
			{
				dictionary2 = (1935.7[1] = new Dictionary<string, string>(StringComparer.Ordinal));
			}
			foreach (KeyValuePair<string, string> keyValuePair in dictionary)
			{
				if (!dictionary2.ContainsKey(keyValuePair.Key) && hashSet.Contains(keyValuePair.Key))
				{
					dictionary2[keyValuePair.Key] = keyValuePair.Value;
					num3++;
				}
			}
		}
		if (5 != null && !1935.6.ContainsKey(1))
		{
			1935.6[1] = 5.Value;
			1935.Save();
		}
		if (num3 > 0)
		{
			1935.Save();
		}
		return new int?(num3);
	}

	// Token: 0x06003D4A RID: 15690 RVA: 0x00182E24 File Offset: 0x00181024
	private static bool 23(string 1, int 2)
	{
		List<int> list;
		if (!1935.4.TryGetValue(3, out list))
		{
			list = (1935.4[3] = new List<int>());
		}
		if (list.Any((int 1) => Math.Abs(1 - 2) < 50))
		{
			return false;
		}
		list.Add(2);
		list.Sort();
		return true;
	}

	// Token: 0x06003D4B RID: 15691 RVA: 0x00182E88 File Offset: 0x00181088
	private static bool 24(string 1, 1937 2)
	{
		List<1937> list;
		if (!1935.5.TryGetValue(3, out list))
		{
			list = (1935.5[3] = new List<1937>());
		}
		if (list.Any((1937 1) => Math.Abs(1.1 - 2.1) < 50 && Math.Abs(1.2 - 2.2) < 50))
		{
			return false;
		}
		list.Add(2);
		1935.25(list);
		return true;
	}

	// Token: 0x06003D4C RID: 15692 RVA: 0x00182EEC File Offset: 0x001810EC
	private static void 25(List<1937> 1)
	{
		3.Sort(delegate(1937 1, 1937 2)
		{
			if (1.1 == 2.1)
			{
				return 1.2.CompareTo(2.2);
			}
			return 1.1.CompareTo(2.1);
		});
	}

	// Token: 0x06003D4D RID: 15693 RVA: 0x00182F14 File Offset: 0x00181114
	private static string 26(IEnumerable<int> 1)
	{
		string text = string.Join(",", from 1 in 2
		select 1.ToString(CultureInfo.InvariantCulture));
		if (text.Length <= 0)
		{
			return "-";
		}
		return text;
	}

	// Token: 0x06003D4E RID: 15694 RVA: 0x00182F64 File Offset: 0x00181164
	private static string 27(IEnumerable<1937> 1)
	{
		string text = string.Join(",", from 1 in 2
		select 1.1.ToString(CultureInfo.InvariantCulture) + "-" + 1.2.ToString(CultureInfo.InvariantCulture));
		if (text.Length <= 0)
		{
			return "-";
		}
		return text;
	}

	// Token: 0x06003D4F RID: 15695 RVA: 0x00182FB4 File Offset: 0x001811B4
	private static string 28(string 1)
	{
		Dictionary<string, string> dictionary;
		if (!1935.7.TryGetValue(2, out dictionary) || dictionary.Count == 0)
		{
			return "-";
		}
		return string.Join(",", from 1 in dictionary
		select 1.Key + "=" + Uri.EscapeDataString(1.Value));
	}

	// Token: 0x06003D50 RID: 15696 RVA: 0x00183010 File Offset: 0x00181210
	private static Dictionary<string, string> 29(string 1)
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>(StringComparer.Ordinal);
		if (1 == "-")
		{
			return dictionary;
		}
		foreach (string text in 1.Split(new char[]
		{
			','
		}, StringSplitOptions.RemoveEmptyEntries))
		{
			int num = text.IndexOf('=');
			if (num > 1)
			{
				try
				{
					dictionary[text.Substring(0, num)] = Uri.UnescapeDataString(text.Substring(num + 1));
				}
				catch (Exception)
				{
				}
			}
		}
		return dictionary;
	}

	// Token: 0x06003D51 RID: 15697 RVA: 0x001830A0 File Offset: 0x001812A0
	private static string 30(1934? 1)
	{
		if (1 == null)
		{
			return "-";
		}
		1934 value = 1.Value;
		if (value.2 == null)
		{
			return "c" + 1.Value.1.ToString(CultureInfo.InvariantCulture);
		}
		string str = "s";
		1937[] array = new 1937[1];
		int num = 0;
		value = 1.Value;
		array[num] = value.2.Value;
		return str + 1935.27(array);
	}

	// Token: 0x06003D52 RID: 15698 RVA: 0x00183128 File Offset: 0x00181328
	private static 1934? 31(string 1)
	{
		if (1.Length < 2)
		{
			return null;
		}
		int num;
		if (1[0] == 'c' && int.TryParse(1.Substring(1), NumberStyles.Integer, CultureInfo.InvariantCulture, out num))
		{
			return new 1934?(new 1934(num));
		}
		List<1937> list = (1[0] == 's') ? 1935.33(1.Substring(1)) : null;
		if (list == null || list.Count != 1)
		{
			return null;
		}
		return new 1934?(new 1934(list[0]));
	}

	// Token: 0x06003D53 RID: 15699 RVA: 0x001831B8 File Offset: 0x001813B8
	private static List<int> 32(string 1)
	{
		List<int> list = new List<int>();
		if (1 == "-")
		{
			return list;
		}
		string[] array = 1.Split(new char[]
		{
			','
		}, StringSplitOptions.RemoveEmptyEntries);
		for (int i = 0; i < array.Length; i++)
		{
			int item;
			if (!int.TryParse(array[i], NumberStyles.Integer, CultureInfo.InvariantCulture, out item))
			{
				return null;
			}
			list.Add(item);
		}
		list.Sort();
		return list;
	}

	// Token: 0x06003D54 RID: 15700 RVA: 0x00183220 File Offset: 0x00181420
	private static List<1937> 33(string 1)
	{
		List<1937> list = new List<1937>();
		if (1 == "-")
		{
			return list;
		}
		foreach (string text in 1.Split(new char[]
		{
			','
		}, StringSplitOptions.RemoveEmptyEntries))
		{
			int num = (text.Length > 1) ? text.IndexOf('-', 1) : -1;
			int num2;
			int num3;
			if (num <= 0 || !int.TryParse(text.Substring(0, num), NumberStyles.Integer, CultureInfo.InvariantCulture, out num2) || !int.TryParse(text.Substring(num + 1), NumberStyles.Integer, CultureInfo.InvariantCulture, out num3))
			{
				return null;
			}
			list.Add(new 1937(num2, num3));
		}
		1935.25(list);
		return list;
	}

	// Token: 0x06003D55 RID: 15701 RVA: 0x001832CC File Offset: 0x001814CC
	private static void 34()
	{
		if (1935.4 != null)
		{
			return;
		}
		1935.4 = new Dictionary<string, List<int>>(StringComparer.OrdinalIgnoreCase);
		1935.5 = new Dictionary<string, List<1937>>(StringComparer.OrdinalIgnoreCase);
		1935.6 = new Dictionary<string, 1934>(StringComparer.OrdinalIgnoreCase);
		1935.7 = new Dictionary<string, Dictionary<string, string>>(StringComparer.OrdinalIgnoreCase);
		try
		{
			if (File.Exists(1935.FilePath))
			{
				string[] array = File.ReadAllLines(1935.FilePath);
				for (int i = 0; i < array.Length; i++)
				{
					string[] array2 = array[i].Split(new char[]
					{
						' '
					}, StringSplitOptions.RemoveEmptyEntries);
					if (array2.Length >= 2)
					{
						List<int> list = 1935.32(array2[1]);
						if (list != null && list.Count > 0)
						{
							1935.4[array2[0]] = list;
						}
						List<1937> list2 = (array2.Length > 2) ? 1935.33(array2[2]) : null;
						if (list2 != null && list2.Count > 0)
						{
							1935.5[array2[0]] = list2;
						}
						1934? <<EMPTY_NAME>> = (array2.Length > 3) ? 1935.31(array2[3]) : null;
						if (<<EMPTY_NAME>> != null)
						{
							1935.6[array2[0]] = <<EMPTY_NAME>>.Value;
						}
						Dictionary<string, string> dictionary = (array2.Length > 4) ? 1935.29(array2[4]) : null;
						if (dictionary != null && dictionary.Count > 0)
						{
							1935.7[array2[0]] = dictionary;
						}
					}
				}
			}
		}
		catch (Exception ex)
		{
			1338.4(ex, "reading the practice checkpoints", 1341.Runtime);
		}
	}

	// Token: 0x06003D56 RID: 15702 RVA: 0x00183454 File Offset: 0x00181654
	private static void Save()
	{
		try
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (string text in 1935.4.Keys.Union(1935.5.Keys, StringComparer.OrdinalIgnoreCase))
			{
				List<int> list2;
				List<int> list = 1935.4.TryGetValue(text, out list2) ? list2 : new List<int>();
				List<1937> list4;
				List<1937> list3 = 1935.5.TryGetValue(text, out list4) ? list4 : new List<1937>();
				if (list.Count > 0 || list3.Count > 0)
				{
					stringBuilder.Append(text).Append(' ').Append(1935.26(list)).Append(' ').Append(1935.27(list3)).Append(' ').Append(1935.30(1935.13(text))).Append(' ').Append(1935.28(text)).Append('\n');
				}
			}
			File.WriteAllText(1935.FilePath, stringBuilder.ToString(), new UTF8Encoding(false));
		}
		catch (Exception ex)
		{
			1338.4(ex, "saving the practice checkpoints", 1341.Runtime);
		}
	}

	// Token: 0x04002D16 RID: 11542
	private const string 1 = "nekiosu.checkpoints";

	// Token: 0x04002D17 RID: 11543
	private const int 2 = 50;

	// Token: 0x04002D18 RID: 11544
	internal const int 3 = 1000;

	// Token: 0x04002D19 RID: 11545
	private static Dictionary<string, List<int>> 4;

	// Token: 0x04002D1A RID: 11546
	private static Dictionary<string, List<1937>> 5;

	// Token: 0x04002D1B RID: 11547
	private static Dictionary<string, 1934> 6;

	// Token: 0x04002D1C RID: 11548
	private static Dictionary<string, Dictionary<string, string>> 7;

	// Token: 0x0200083D RID: 2109
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x04002D1D RID: 11549
		public static Func<int, string> <0>__CheckpointKey;

		// Token: 0x04002D1E RID: 11550
		public static Func<1937, string> <1>__SegmentKey;
	}
}
