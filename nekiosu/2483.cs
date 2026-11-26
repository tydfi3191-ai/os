using System;
using System.Collections.Generic;
using System.IO;

// Token: 0x020004C3 RID: 1219
[276]
internal static class 2483
{
	// Token: 0x060024FA RID: 9466 RVA: 0x000AAB5E File Offset: 0x000A8D5E
	internal static void Reset()
	{
		2483.1();
		1455.11();
	}

	// Token: 0x060024FB RID: 9467 RVA: 0x000AAB6C File Offset: 0x000A8D6C
	private static void 1()
	{
		foreach (1381 <<EMPTY_NAME>> in 2483.3)
		{
			<<EMPTY_NAME>>.9 = null;
		}
		2483.3.Clear();
	}

	// Token: 0x060024FC RID: 9468 RVA: 0x000AABC8 File Offset: 0x000A8DC8
	private static void 2(1262 1)
	{
		string text = (1.1() && !string.IsNullOrEmpty(1.80)) ? 1.80 : null;
		1455.12 = true;
		2630.10(text, false);
	}

	// Token: 0x060024FD RID: 9469 RVA: 0x000AABF8 File Offset: 0x000A8DF8
	private static int 3()
	{
		2483.1();
		List<1381> list = 1455.10();
		list.AddRange(1455.3());
		foreach (KeyValuePair<string, 1381> keyValuePair in 1455.4())
		{
			list.Add(keyValuePair.Value);
		}
		HashSet<1381> hashSet = new HashSet<1381>();
		foreach (1381 <<EMPTY_NAME>> in list)
		{
			string text = (<<EMPTY_NAME>> != null) ? <<EMPTY_NAME>>.2 : null;
			if (text != null && hashSet.Add(<<EMPTY_NAME>>) && !2483.4(text) && (<<EMPTY_NAME>>.6 != (1416)1 || !text.StartsWith("score-", StringComparison.OrdinalIgnoreCase)))
			{
				1381 2 = 2483.5(text, (1416)7);
				if (2 != null && 2 != <<EMPTY_NAME>> && 2.9 == null)
				{
					<<EMPTY_NAME>>.9 = 2;
					2483.3.Add(<<EMPTY_NAME>>);
				}
			}
		}
		return 2483.3.Count;
	}

	// Token: 0x060024FE RID: 9470 RVA: 0x000AAD24 File Offset: 0x000A8F24
	private static bool 4(string 1)
	{
		return 1 != null && 1.StartsWith("cursor", StringComparison.OrdinalIgnoreCase);
	}

	// Token: 0x060024FF RID: 9471 RVA: 0x000AAD38 File Offset: 0x000A8F38
	private static 1381 5(string 1, 1416 2)
	{
		if (1 == null)
		{
			return null;
		}
		1381 3 = 1455.2(1, 2, null);
		if (3 != null)
		{
			return 3;
		}
		int num = 1.LastIndexOf('-');
		int num2;
		if (num > 0 && int.TryParse(1.Substring(num + 1), out num2))
		{
			string str = 1.Substring(0, num);
			return 1455.2(str + "-0", 2, null) ?? 1455.2(str, 2, null);
		}
		return null;
	}

	// Token: 0x06002500 RID: 9472 RVA: 0x000AADA0 File Offset: 0x000A8FA0
	internal static void Apply(2486 1, bool 2)
	{
		1262 3 = 1272.5();
		2039 objects = (1 != null) ? 1.39 : null;
		if (3 == null || objects == null)
		{
			return;
		}
		try
		{
			3.108 = 2;
			2630.13 = 2;
			int num = 0;
			2483.1();
			2483.2(3);
			HashSet<1433> hashSet = new HashSet<1433>();
			if (objects.34 != null)
			{
				foreach (2034 4 in objects.34)
				{
					foreach (1433 5 in 4.30)
					{
						num += 2483.7(5, hashSet, true);
					}
				}
			}
			foreach (1436 6 in new 1436[]
			{
				objects.39,
				1.73,
				1.72
			})
			{
				num += 2483.6(6, hashSet, true);
			}
			foreach (1436 7 in new 1436[]
			{
				1.76,
				1.77,
				1.71,
				1.79
			})
			{
				num += 2483.6(7, hashSet, false);
			}
			2630.3.Clear();
			if (3.1())
			{
				2483.9(3);
			}
			objects.LoadComboColours(false);
			2483.10(objects, 3);
			2630.12(objects);
			1662.89.Schedule(delegate()
			{
				if (objects.34 == null)
				{
					return;
				}
				foreach (2034 8 in objects.34)
				{
					2123 9 = 8 as 2123;
					if (9 != null)
					{
						9.36();
					}
				}
			}, true);
			2630.13(true);
			int num2 = 2483.3();
			1338.5(string.Concat(new string[]
			{
				"Beatmap skin ",
				2 ? "off" : "on",
				" during the play: ",
				num.ToString(),
				" sprite(s) changed, ",
				num2.ToString(),
				" picture(s) redirected."
			}), 1341.Runtime, (1114)2);
		}
		catch (Exception ex)
		{
			1338.4(ex, "switching the beatmap skin during a play", 1341.Runtime);
		}
	}

	// Token: 0x06002501 RID: 9473 RVA: 0x000AB028 File Offset: 0x000A9228
	private static int 6(1436 1, HashSet<1433> 2, bool 3)
	{
		if (1 == null)
		{
			return 0;
		}
		int num = 0;
		1371[] array = 1.28.ToArray();
		for (int i = 0; i < array.Length; i++)
		{
			1433 4 = array[i] as 1433;
			if (4 != null)
			{
				num += 2483.7(4, 2, 3);
			}
		}
		return num;
	}

	// Token: 0x06002502 RID: 9474 RVA: 0x000AB070 File Offset: 0x000A9270
	private static int 7(1433 1, HashSet<1433> 2, bool 3)
	{
		if (1 == null || 1 is 1452 || !2.Add(1))
		{
			return 0;
		}
		1351 4 = 1 as 1351;
		if (4 != null)
		{
			1381[] array = 4.54();
			if (array != null && array.Length != 0)
			{
				1381 5 = array[0];
				if (((5 != null) ? 5.2 : null) != null && (3 || array[0].6 != (1416)1))
				{
					string text = array[0].2;
					bool flag = text.EndsWith("-0", StringComparison.Ordinal);
					1381[] array2 = 1455.5(flag ? text.Substring(0, text.Length - 2) : ((array.Length > 1 && text.EndsWith("0", StringComparison.Ordinal)) ? text.Substring(0, text.Length - 1) : text), (1416)7, flag || array.Length == 1);
					if (array2 == null || array2.Length == 0 || 2483.8(array, array2))
					{
						return 0;
					}
					4.55(array2);
					return 1;
				}
			}
			return 0;
		}
		1381 6 = 1.47;
		if (6 == null || 6.2 == null || (!3 && 6.6 == (1416)1))
		{
			return 0;
		}
		1381 7 = 1455.2(6.2, (1416)7, null);
		if (7 == null || 7 == 6)
		{
			return 0;
		}
		1.SetTexture(7);
		return 1;
	}

	// Token: 0x06002503 RID: 9475 RVA: 0x000AB19C File Offset: 0x000A939C
	private static bool 8(1381[] 1, 1381[] 2)
	{
		if (1.Length != 2.Length)
		{
			return false;
		}
		for (int i = 0; i < 1.Length; i++)
		{
			if (1[i] != 2[i])
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06002504 RID: 9476 RVA: 0x000AB1CC File Offset: 0x000A93CC
	private static void 9(1262 1)
	{
		string text;
		using (Stream stream = 1.48(1.58))
		{
			if (stream == null)
			{
				return;
			}
			using (StreamReader streamReader = new StreamReader(stream))
			{
				text = streamReader.ReadToEnd();
			}
		}
		bool flag = false;
		bool flag2 = false;
		string[] array = text.Split(new char[]
		{
			'\n'
		});
		for (int i = 0; i < array.Length; i++)
		{
			string text2 = array[i].Trim();
			if (text2.StartsWith("[", StringComparison.Ordinal))
			{
				flag = text2.Equals("[Colours]", StringComparison.OrdinalIgnoreCase);
			}
			else
			{
				int num = text2.IndexOf(':');
				if (flag && num > 0)
				{
					string text3 = text2.Substring(0, num).Trim();
					string[] array2 = text2.Substring(num + 1).Split(new char[]
					{
						','
					});
					byte b;
					byte b2;
					byte b3;
					if (array2.Length >= 3 && byte.TryParse(array2[0].Trim(), out b) && byte.TryParse(array2[1].Trim(), out b2) && byte.TryParse(array2[2].Trim(), out b3))
					{
						if (text3.StartsWith("Combo", StringComparison.OrdinalIgnoreCase) && !flag2)
						{
							flag2 = true;
							for (int j = 1; j <= 8; j++)
							{
								2630.3["Combo" + j.ToString()] = 198.TransparentWhite;
							}
						}
						2630.3[text3] = new 198(b, b2, b3);
					}
				}
			}
		}
	}

	// Token: 0x06002505 RID: 9477 RVA: 0x000AB374 File Offset: 0x000A9574
	private static void 10(2039 1, 1262 2)
	{
		List<2034> 3 = 1.34;
		int count = 1.27.Count;
		if (3 == null || count == 0)
		{
			return;
		}
		bool flag = 2.1();
		int num = 0;
		bool flag2 = false;
		for (int i = 0; i < 3.Count; i++)
		{
			2034 4 = 3[i];
			int num2 = flag ? 4.16 : 0;
			if (4.HasObjectType(2047.Spinner))
			{
				if (2.32 <= 8)
				{
					flag2 = true;
				}
				else if (4.IsNewCombo())
				{
					num += num2;
					flag2 = true;
				}
			}
			else if (flag2 || (4.3 & 2047.NewCombo) > (2047)0 || (i == 0 && !(4 is 1866)))
			{
				num += num2 + 1;
				flag2 = false;
			}
			4.SetComboColour(1.27[num % count]);
			4.17 = num % count;
		}
	}

	// Token: 0x040019F5 RID: 6645
	private const 1416 1 = (1416)7;

	// Token: 0x040019F6 RID: 6646
	private const 1416 2 = (1416)1;

	// Token: 0x040019F7 RID: 6647
	private static readonly List<1381> 3 = new List<1381>();
}
