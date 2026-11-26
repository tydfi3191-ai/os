using System;
using System.Collections.Generic;
using System.IO;

// Token: 0x02000B5A RID: 2906
public sealed class 1297
{
	// Token: 0x0600501D RID: 20509 RVA: 0x001F9239 File Offset: 0x001F7439
	internal static SortedDictionary<string, List<string>> 1()
	{
		if (1297.2 == null)
		{
			1297.5();
		}
		return 1297.2;
	}

	// Token: 0x0600501E RID: 20510 RVA: 0x001F924C File Offset: 0x001F744C
	internal static string 2()
	{
		return 268.1("collection.db");
	}

	// Token: 0x0600501F RID: 20511 RVA: 0x001F9258 File Offset: 0x001F7458
	internal static List<string> 3(string 1)
	{
		if (1297.1() == null || 1 == null)
		{
			return null;
		}
		List<string> result;
		if (!1297.1().TryGetValue(1, out result))
		{
			return null;
		}
		return result;
	}

	// Token: 0x06005020 RID: 20512 RVA: 0x001F9284 File Offset: 0x001F7484
	internal static List<string> 4(string 1)
	{
		if (1297.1() == null || 1 == null)
		{
			return null;
		}
		List<string> list = new List<string>();
		foreach (KeyValuePair<string, List<string>> keyValuePair in 1297.1())
		{
			if (keyValuePair.Value.IndexOf(1) >= 0)
			{
				list.Add(keyValuePair.Key);
			}
		}
		return list;
	}

	// Token: 0x06005021 RID: 20513 RVA: 0x001F9300 File Offset: 0x001F7500
	internal static void 5()
	{
		if (1297.2 == null)
		{
			if (1272.3 == null)
			{
				1272.33(false);
			}
			1297.2 = new SortedDictionary<string, List<string>>();
			1297.7();
			1297.6();
			if (!File.Exists(1297.2()))
			{
				1297.Save(true);
			}
		}
	}

	// Token: 0x06005022 RID: 20514 RVA: 0x001F933C File Offset: 0x001F753C
	private static void 6()
	{
		string text = 268.24("collection.db");
		if (text == null || string.Equals(Path.GetFullPath(text), Path.GetFullPath(1297.2()), StringComparison.OrdinalIgnoreCase))
		{
			return;
		}
		try
		{
			int num = 0;
			using (Stream stream = File.Open(text, FileMode.Open, FileAccess.Read, FileShare.Read | FileShare.Write | FileShare.Delete))
			{
				1647 <<EMPTY_NAME>> = new 1647(stream);
				<<EMPTY_NAME>>.ReadInt32();
				int num2 = <<EMPTY_NAME>>.ReadInt32();
				for (int i = 0; i < num2; i++)
				{
					string key = <<EMPTY_NAME>>.ReadString();
					int num3 = <<EMPTY_NAME>>.ReadInt32();
					List<string> list;
					if (!1297.2.TryGetValue(key, out list))
					{
						list = (1297.2[key] = new List<string>());
						num++;
					}
					HashSet<string> hashSet = new HashSet<string>(list);
					for (int j = 0; j < num3; j++)
					{
						string item = <<EMPTY_NAME>>.ReadString();
						if (hashSet.Add(item))
						{
							list.Add(item);
							num++;
						}
					}
				}
			}
			if (num > 0)
			{
				1297.3 = true;
			}
			268.26("collection.db");
		}
		catch (Exception ex)
		{
			1338.4(ex, "reading osu!'s collection.db", 1341.Runtime);
		}
	}

	// Token: 0x06005023 RID: 20515 RVA: 0x001F9464 File Offset: 0x001F7664
	private static void 7()
	{
		1322.1(1297.2(), new 1322.1323(1297.1298.instance.1), null, delegate
		{
			SortedDictionary<string, List<string>> sortedDictionary = 1297.2;
			if (sortedDictionary == null)
			{
				return;
			}
			sortedDictionary.Clear();
		});
	}

	// Token: 0x06005024 RID: 20516 RVA: 0x001F94A1 File Offset: 0x001F76A1
	internal static bool 8(string 1)
	{
		if (!1297.2.ContainsKey(1))
		{
			1297.2.Add(1, new List<string>());
			1297.3 = true;
			return true;
		}
		return false;
	}

	// Token: 0x06005025 RID: 20517 RVA: 0x001F94CC File Offset: 0x001F76CC
	internal static bool 9(string 1, string 2)
	{
		1297.5();
		List<string> list = 1297.2.ContainsKey(1) ? 1297.2[1] : (1297.2[1] = new List<string>());
		if (list.Contains(2))
		{
			return false;
		}
		list.Add(2);
		1297.3 = true;
		return true;
	}

	// Token: 0x06005026 RID: 20518 RVA: 0x001F9528 File Offset: 0x001F7728
	internal static void Save(bool 1)
	{
		1297.1299 2 = new 1297.1299();
		if (1297.2 != null && (1 || 1297.3))
		{
			Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>(1297.2.Count);
			foreach (KeyValuePair<string, List<string>> keyValuePair in 1297.2)
			{
				dictionary.Add(keyValuePair.Key, new List<string>(keyValuePair.Value));
			}
			2.1 = dictionary;
			1297.3 = false;
			if (!1322.4(1297.2(), new 1322.1324(2.1)))
			{
				1297.3 = true;
			}
		}
	}

	// Token: 0x06005027 RID: 20519 RVA: 0x001F95E4 File Offset: 0x001F77E4
	internal static void 10(string 1)
	{
		1297.2.Remove(1);
		1297.3 = true;
	}

	// Token: 0x06005028 RID: 20520 RVA: 0x001F95F8 File Offset: 0x001F77F8
	internal static bool 11(string 1, string 2)
	{
		1297.3 = true;
		return 1297.2.ContainsKey(1) && 1297.2[1].Remove(2);
	}

	// Token: 0x04003CA8 RID: 15528
	private static int 1;

	// Token: 0x04003CA9 RID: 15529
	private static SortedDictionary<string, List<string>> 2;

	// Token: 0x04003CAA RID: 15530
	private static bool 3;

	// Token: 0x02000B5B RID: 2907
	[Serializable]
	public sealed class 1298
	{
		// Token: 0x0600502A RID: 20522 RVA: 0x001F9620 File Offset: 0x001F7820
		internal void 1(1647 1)
		{
			1297.1 = 1.ReadInt32();
			int num = 1.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				string key = 1.ReadString();
				int num2 = 1.ReadInt32();
				List<string> list = new List<string>(num2);
				for (int j = 0; j < num2; j++)
				{
					list.Add(1.ReadString());
				}
				1297.2.Add(key, list);
			}
		}

		// Token: 0x04003CAB RID: 15531
		public static readonly 1297.1298 instance = new 1297.1298();

		// Token: 0x04003CAC RID: 15532
		public static 1322.1323 databaseReadHandler;
	}

	// Token: 0x02000B5C RID: 2908
	public sealed class 1299
	{
		// Token: 0x0600502D RID: 20525 RVA: 0x001F9698 File Offset: 0x001F7898
		internal void 1(1648 1)
		{
			1.Write(1296.11);
			1.Write(this.1.Count);
			foreach (KeyValuePair<string, List<string>> keyValuePair in this.1)
			{
				1.Write(keyValuePair.Key);
				1.Write(keyValuePair.Value.Count);
				foreach (string value in keyValuePair.Value)
				{
					1.Write(value);
				}
			}
		}

		// Token: 0x04003CAD RID: 15533
		public Dictionary<string, List<string>> 1;
	}
}
