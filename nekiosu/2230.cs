using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;

// Token: 0x020006A6 RID: 1702
[276]
public sealed class 2230
{
	// Token: 0x060032E8 RID: 13032 RVA: 0x001368E0 File Offset: 0x00134AE0
	internal static string 1()
	{
		return 268.1("scores.db");
	}

	// Token: 0x060032E9 RID: 13033 RVA: 0x001368EC File Offset: 0x00134AEC
	public static string 2()
	{
		return Path.Combine(1345.4(), "Data", "r");
	}

	// Token: 0x060032EA RID: 13034 RVA: 0x00136904 File Offset: 0x00134B04
	internal static List<2241> 3(string 1, 2147 2)
	{
		2230.2234 CS_0024_003C_003E8__locals2 = new 2230.2234();
		CS_0024_003C_003E8__locals2.1 = 2;
		if (2230.4 == null || 3 == null)
		{
			return null;
		}
		object obj = 2230.2;
		List<2241> result;
		lock (obj)
		{
			List<2241> list;
			if (!2230.4.TryGetValue(3, out list))
			{
				if (!2230.1.TryGetValue(3, out list) || 1272.8(3) == null)
				{
					return null;
				}
				2230.1.Remove(3);
				2230.4[3] = list;
			}
			result = list.FindAll((2241 1) => 1.9 == CS_0024_003C_003E8__locals2.1);
		}
		return result;
	}

	// Token: 0x060032EB RID: 13035 RVA: 0x001369C0 File Offset: 0x00134BC0
	internal static void 4()
	{
		if (2230.4 == null)
		{
			if (1272.3 == null)
			{
				1272.33(false);
			}
			Stopwatch stopwatch = Stopwatch.StartNew();
			string stage = 271.Stage;
			2230.4 = new Dictionary<string, List<2241>>();
			2230.1.Clear();
			271.2("score list: reading scores.nekiosu.db");
			2230.16();
			271.2("score list: taking over osu!'s new scores");
			2230.12();
			271.2("score list: replay files");
			2230.11();
			271.2("score list: matching scores to beatmaps");
			2230.13();
			271.4("score list loaded in " + stopwatch.ElapsedMilliseconds.ToString() + " ms.");
			271.3(stage);
			if (2230.3 < 1024 && Directory.GetFiles(2230.2()).Length != 0)
			{
				1662.82(true);
				new 1719((1327)1).ShowDialog(1662.13());
				1662.82(false);
			}
			if (!File.Exists(2230.1()))
			{
				2230.17(true);
			}
		}
	}

	// Token: 0x060032EC RID: 13036 RVA: 0x00136AB0 File Offset: 0x00134CB0
	internal static int 5(2241 1, bool 2, bool 3)
	{
		2230.4();
		if (1 == null)
		{
			return -1;
		}
		object obj = 2230.2;
		int result;
		lock (obj)
		{
			result = 2230.15(1, 2, 3);
		}
		if (!2)
		{
			if (1.51 && (1.8 & 2023.Relax) != 2023.None)
			{
				2210.44(1);
			}
			2210.7();
		}
		return result;
	}

	// Token: 0x060032ED RID: 13037 RVA: 0x00136B28 File Offset: 0x00134D28
	internal static List<KeyValuePair<string, List<2241>>> 6(bool 1 = false)
	{
		2230.4();
		List<KeyValuePair<string, List<2241>>> list = new List<KeyValuePair<string, List<2241>>>();
		object obj = 2230.2;
		lock (obj)
		{
			if (2230.4 != null)
			{
				foreach (KeyValuePair<string, List<2241>> keyValuePair in 2230.4)
				{
					list.Add(new KeyValuePair<string, List<2241>>(keyValuePair.Key, new List<2241>(keyValuePair.Value)));
				}
				if (1)
				{
					foreach (KeyValuePair<string, List<2241>> keyValuePair2 in 2230.1)
					{
						if (!2230.4.ContainsKey(keyValuePair2.Key))
						{
							list.Add(new KeyValuePair<string, List<2241>>(keyValuePair2.Key, new List<2241>(keyValuePair2.Value)));
						}
					}
				}
			}
		}
		return list;
	}

	// Token: 0x060032EE RID: 13038 RVA: 0x00136C40 File Offset: 0x00134E40
	internal static HashSet<string> 7(string 1)
	{
		HashSet<string> hashSet = new HashSet<string>();
		using (Stream stream = File.Open(1, FileMode.Open, FileAccess.Read, FileShare.Read | FileShare.Write | FileShare.Delete))
		{
			1647 2 = new 1647(stream);
			int num = 2.ReadInt32();
			int num2 = 2.ReadInt32();
			for (int i = 0; i < num2; i++)
			{
				2.ReadString();
				int num3 = 2.ReadInt32();
				for (int j = 0; j < num3; j++)
				{
					2241 3 = 2246.Create((2147)2.ReadByte(), null, null, false);
					3.16(2);
					if ((3.8 & 2023.Target) > 2023.None)
					{
						3 = new 2136(3);
					}
					3.15(2, num >= 20140721);
					hashSet.Add(3.4());
				}
			}
		}
		return hashSet;
	}

	// Token: 0x060032EF RID: 13039 RVA: 0x00136D1C File Offset: 0x00134F1C
	private static string 8()
	{
		return 268.2("replays.pending");
	}

	// Token: 0x060032F0 RID: 13040 RVA: 0x00136D28 File Offset: 0x00134F28
	private static void 9(string 1)
	{
		try
		{
			object obj = 2230.6;
			lock (obj)
			{
				File.AppendAllText(2230.8(), 1 + Environment.NewLine);
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x060032F1 RID: 13041 RVA: 0x00136D88 File Offset: 0x00134F88
	private static List<string> 10()
	{
		List<string> list = new List<string>();
		try
		{
			object obj = 2230.6;
			lock (obj)
			{
				string path = 2230.8();
				if (File.Exists(path))
				{
					foreach (string text in File.ReadAllLines(path))
					{
						if (text.Trim().Length > 0 && !list.Contains(text.Trim()))
						{
							list.Add(text.Trim());
						}
					}
					File.Delete(path);
				}
			}
		}
		catch (Exception)
		{
		}
		return list;
	}

	// Token: 0x060032F2 RID: 13042 RVA: 0x00136E3C File Offset: 0x0013503C
	private static void 11()
	{
		try
		{
			int num = 0;
			DateTime t = File.Exists(2230.1()) ? File.GetLastWriteTimeUtc(2230.1()) : DateTime.MinValue;
			foreach (string path in 2230.10())
			{
				if (File.Exists(path) && !(File.GetLastWriteTimeUtc(path) <= t))
				{
					string[] array = Path.GetFileNameWithoutExtension(path).Split(new char[]
					{
						'-'
					});
					long fileTime;
					if (array.Length == 2 && array[0].Length == 32 && long.TryParse(array[1], out fileTime))
					{
						string text = array[0];
						List<2241> list;
						if ((!2230.4.TryGetValue(text, out list) && !2230.1.TryGetValue(text, out list)) || !list.Exists((2241 1) => 2230.14(1) == fileTime))
						{
							2241 2;
							try
							{
								using (Stream stream = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.Read))
								{
									1647 <<EMPTY_NAME>> = new 1647(stream);
									2 = 2246.Create((2147)<<EMPTY_NAME>>.ReadByte(), null, null, false);
									2.16(<<EMPTY_NAME>>);
									if ((2.8 & 2023.Target) > 2023.None)
									{
										2 = new 2136(2);
									}
									2.ReadFrom(<<EMPTY_NAME>>);
									2.26();
								}
							}
							catch (Exception)
							{
								continue;
							}
							if (!(2.10 != text) && 2230.14(2) == fileTime)
							{
								Dictionary<string, List<2241>> dictionary = (1272.8(text) != null) ? 2230.4 : 2230.1;
								if (!dictionary.TryGetValue(text, out list))
								{
									list = (dictionary[text] = new List<2241>());
								}
								int num2 = list.BinarySearch(2);
								list.Insert((num2 < 0) ? (~num2) : num2, 2);
								num++;
							}
						}
					}
				}
			}
			if (num > 0)
			{
				2230.5 = true;
				1338.5("Score database: put back " + num.ToString() + " score(s) from their replay files.", 1341.Runtime, (1114)2);
			}
		}
		catch (Exception ex)
		{
			1338.4(ex, "score recovery from replay files", 1341.Runtime);
		}
	}

	// Token: 0x060032F3 RID: 13043 RVA: 0x001370CC File Offset: 0x001352CC
	private static void 12()
	{
		string text = 268.24("scores.db");
		if (text == null || string.Equals(Path.GetFullPath(text), Path.GetFullPath(2230.1()), StringComparison.OrdinalIgnoreCase))
		{
			return;
		}
		try
		{
			Dictionary<string, List<2241>> dictionary = new Dictionary<string, List<2241>>();
			using (Stream stream = File.Open(text, FileMode.Open, FileAccess.Read, FileShare.Read | FileShare.Write | FileShare.Delete))
			{
				1647 <<EMPTY_NAME>> = new 1647(stream);
				int num = <<EMPTY_NAME>>.ReadInt32();
				int num2 = <<EMPTY_NAME>>.ReadInt32();
				for (int i = 0; i < num2; i++)
				{
					string key = <<EMPTY_NAME>>.ReadString();
					int num3 = <<EMPTY_NAME>>.ReadInt32();
					List<2241> list = new List<2241>(num3);
					for (int j = 0; j < num3; j++)
					{
						2241 2 = 2246.Create((2147)<<EMPTY_NAME>>.ReadByte(), null, null, false);
						2.16(<<EMPTY_NAME>>);
						if ((2.8 & 2023.Target) > 2023.None)
						{
							2 = new 2136(2);
						}
						2.15(<<EMPTY_NAME>>, num >= 20140721);
						list.Add(2);
					}
					dictionary[key] = list;
				}
			}
			int num4 = 0;
			foreach (KeyValuePair<string, List<2241>> keyValuePair in dictionary)
			{
				Dictionary<string, List<2241>> dictionary2 = (1272.8(keyValuePair.Key) != null) ? 2230.4 : 2230.1;
				List<2241> list2;
				if (!dictionary2.TryGetValue(keyValuePair.Key, out list2))
				{
					list2 = (dictionary2[keyValuePair.Key] = new List<2241>());
				}
				HashSet<string> hashSet = new HashSet<string>();
				foreach (2241 3 in list2)
				{
					hashSet.Add(3.4());
				}
				foreach (2241 4 in keyValuePair.Value)
				{
					string item = 4.4();
					if (!2210.34(item) && hashSet.Add(item))
					{
						4.26();
						int num5 = list2.BinarySearch(4);
						list2.Insert((num5 < 0) ? (~num5) : num5, 4);
						num4++;
					}
				}
			}
			if (num4 > 0)
			{
				2230.5 = true;
			}
			268.26("scores.db");
			1338.5("Scores: took over " + num4.ToString() + " new score(s) from osu!'s scores.db.", 1341.Runtime, (1114)2);
		}
		catch (Exception ex)
		{
			1338.4(ex, "reading osu!'s scores.db", 1341.Runtime);
		}
	}

	// Token: 0x060032F4 RID: 13044 RVA: 0x001373CC File Offset: 0x001355CC
	internal static void 13()
	{
		if (2230.4 == null)
		{
			return;
		}
		object obj = 2230.2;
		lock (obj)
		{
			foreach (string key in new List<string>(2230.1.Keys))
			{
				if (1272.8(key) != null && !2230.4.ContainsKey(key))
				{
					2230.4[key] = 2230.1[key];
					2230.1.Remove(key);
				}
			}
			foreach (KeyValuePair<string, List<2241>> keyValuePair in 2230.4)
			{
				1262 <<EMPTY_NAME>> = 1272.8(keyValuePair.Key);
				if (<<EMPTY_NAME>> != null)
				{
					foreach (2241 2 in keyValuePair.Value)
					{
						DateTime dateTime = 2.7.ToUniversalTime();
						if (dateTime <= DateTime.UtcNow && dateTime > <<EMPTY_NAME>>.46.ToUniversalTime())
						{
							<<EMPTY_NAME>>.46 = DateTime.SpecifyKind(dateTime, DateTimeKind.Utc);
						}
					}
				}
			}
		}
	}

	// Token: 0x060032F5 RID: 13045 RVA: 0x00137584 File Offset: 0x00135784
	private static long 14(2241 1)
	{
		long result;
		try
		{
			result = 1.7.ToFileTimeUtc();
		}
		catch (Exception)
		{
			result = -1L;
		}
		return result;
	}

	// Token: 0x060032F6 RID: 13046 RVA: 0x001375B8 File Offset: 0x001357B8
	private static int 15(2241 1, bool 2, bool 3)
	{
		int num = 0;
		int num2 = 0;
		2241 4 = null;
		2241 5 = null;
		List<2241> list = 2230.3(1.10, 1.9);
		if (list == null)
		{
			list = new List<2241>();
			2230.4.Add(1.10, list);
			2230.5 = true;
		}
		foreach (2241 6 in list)
		{
			num2++;
			if (6.GetScore() >= 1.GetScore())
			{
				num++;
				if (4 == null || 6.GetScore() < 4.GetScore())
				{
					4 = 6;
				}
				if (num >= 250)
				{
					return -1;
				}
			}
			else if (5 == null || 6.GetScore() < 5.GetScore())
			{
				5 = 6;
			}
			if (6.4() == 1.4())
			{
				return num2;
			}
		}
		if (!2)
		{
			List<2241> list2 = 2230.4[1.10];
			2230.5 = true;
			if (5 != null && num2 >= 250)
			{
				try
				{
					2230.23(5);
				}
				catch (Exception)
				{
				}
				list2.Remove(5);
			}
			if (3)
			{
				2230.20(1, false);
			}
			int num3 = list2.BinarySearch(1);
			if (num3 < 0)
			{
				num3 = ~num3;
			}
			list2.Insert(num3, 1);
			1326.4();
		}
		return num + 1;
	}

	// Token: 0x060032F7 RID: 13047 RVA: 0x00137728 File Offset: 0x00135928
	private static void 16()
	{
		1322.1(2230.1(), new 1322.1323(2230.2233.instance.1), null, delegate
		{
			Dictionary<string, List<2241>> dictionary = 2230.4;
			if (dictionary != null)
			{
				dictionary.Clear();
			}
			2230.1.Clear();
		});
	}

	// Token: 0x060032F8 RID: 13048 RVA: 0x00137768 File Offset: 0x00135968
	internal static void 17(bool 1)
	{
		2230.2232 2 = new 2230.2232();
		if (2230.4 != null && (1 || 2230.5))
		{
			object obj = 2230.2;
			lock (obj)
			{
				2.1 = new Dictionary<string, List<2241>>();
				foreach (KeyValuePair<string, List<2241>> keyValuePair in 2230.1)
				{
					2.1[keyValuePair.Key] = new List<2241>(keyValuePair.Value);
				}
				foreach (KeyValuePair<string, List<2241>> keyValuePair2 in 2230.4)
				{
					List<2241> list;
					if (2.1.TryGetValue(keyValuePair2.Key, out list))
					{
						list.AddRange(keyValuePair2.Value);
						list.Sort();
					}
					else
					{
						2.1[keyValuePair2.Key] = new List<2241>(keyValuePair2.Value);
					}
				}
				2230.5 = false;
			}
			bool flag2 = false;
			int num = 1;
			while (num <= 4 && !flag2)
			{
				flag2 = 1322.4(2230.1(), new 1322.1324(2.1));
				if (!flag2)
				{
					Thread.Sleep(100);
				}
				num++;
			}
			if (!flag2)
			{
				2230.5 = true;
			}
		}
	}

	// Token: 0x060032F9 RID: 13049 RVA: 0x001378F0 File Offset: 0x00135AF0
	public static 2241 18(string 1)
	{
		return 2230.19(1, true);
	}

	// Token: 0x060032FA RID: 13050 RVA: 0x001378FC File Offset: 0x00135AFC
	public static 2241 19(string 1, bool 2)
	{
		2230.4();
		2241 3 = null;
		bool flag = false;
		try
		{
			using (Stream stream = File.Open(1, FileMode.Open))
			{
				1647 4 = new 1647(stream);
				3 = 2246.Create((2147)4.ReadByte(), null, null, false);
				3.16(4);
				2023 5 = 3.8;
				2023 6 = 2023.Target;
				if ((5 & 6) > 2023.None)
				{
					3 = new 2136(3);
				}
				3.ReadFrom(4);
				if (3.7 < DateTime.UtcNow + new TimeSpan(1825, 0, 0, 0))
				{
					flag = true;
				}
			}
		}
		catch
		{
		}
		if (!flag || 3 == null)
		{
			1763.4(1568.1(2679.ScoreManager_ReplayCorrupt));
			return null;
		}
		if (3.7.Year > 2050 || 3.7 == DateTime.MinValue)
		{
			string[] array = 1.Split(new char[]
			{
				'-'
			});
			if (array.Length > 1)
			{
				long fileTime = 0L;
				if (long.TryParse(array[1].Replace(".osr", string.Empty), out fileTime))
				{
					3.7 = DateTime.FromFileTimeUtc(fileTime);
				}
			}
		}
		if (3.7.Year > 2050)
		{
			File.Delete(1);
			1763.4(1568.1(2679.ScoreManager_ReplayCorrupt));
			return null;
		}
		if (1272.8(3.10) == null)
		{
			if (2)
			{
				1731.13(3.10, null, new EventHandler(2230.2233.instance.2));
			}
			return null;
		}
		2230.5(3, false, true);
		return 3;
	}

	// Token: 0x060032FB RID: 13051 RVA: 0x00137A94 File Offset: 0x00135C94
	public static bool 20(2241 1, bool 2)
	{
		2230.2235 CS_0024_003C_003E8__locals6 = new 2230.2235();
		if (2)
		{
			string text = Path.Combine(1345.4(), "Replays");
			Directory.CreateDirectory(text);
			int num = 0;
			do
			{
				string str = string.Format("{0} - {1} ({2:yyyy-MM-dd}) {3}", new object[]
				{
					1.23,
					1272.5().49,
					1.7.ToUniversalTime(),
					1.9
				});
				if (num > 0)
				{
					str += string.Format("-{0}", num);
				}
				CS_0024_003C_003E8__locals6.1 = Path.Combine(text, 2672.2(str + ".osr"));
				num++;
			}
			while (File.Exists(CS_0024_003C_003E8__locals6.1));
		}
		else
		{
			CS_0024_003C_003E8__locals6.1 = 1.7();
		}
		bool flag = true;
		if (1.25 == null)
		{
			if (1.26 == null || 1.26.Count == 0)
			{
				flag = false;
			}
			else
			{
				try
				{
					1.25 = 182.Compress(new ASCIIEncoding().GetBytes(1.5()));
				}
				catch
				{
					flag = false;
				}
			}
		}
		if (flag)
		{
			try
			{
				using (Stream stream = File.Open(CS_0024_003C_003E8__locals6.1, FileMode.Create))
				{
					1.WriteTo(new 1648(stream));
				}
				if (!2)
				{
					2230.9(CS_0024_003C_003E8__locals6.1);
				}
				if (!2 && 1.30.Count > 0)
				{
					using (Stream stream2 = File.Open(1.6(), FileMode.Create))
					{
						1648 3 = new 1648(stream2);
						try
						{
							3.Write(1296.11);
							3.2<2247>(1.30);
						}
						finally
						{
							((IDisposable)3).Dispose();
						}
					}
				}
			}
			catch (IOException)
			{
				flag = false;
			}
		}
		if (2)
		{
			if (flag)
			{
				1804.1();
				1763.5(string.Format(1568.1(2679.ScoreManager_SavedReplayToFile), CS_0024_003C_003E8__locals6.1), 198.BlueViolet, 6000, delegate
				{
					1662.67(CS_0024_003C_003E8__locals6.1);
				});
			}
			else
			{
				1763.4(1568.1(2679.ScoreManager_ReplayFailed));
			}
		}
		return flag;
	}

	// Token: 0x060032FC RID: 13052 RVA: 0x00137D08 File Offset: 0x00135F08
	internal static void 21(string 1)
	{
		object obj = 2230.2;
		lock (obj)
		{
			List<2241> list;
			if (2230.4.TryGetValue(1, out list))
			{
				foreach (2241 2 in list)
				{
					try
					{
						2.28();
					}
					catch (Exception)
					{
					}
				}
			}
			2230.4.Remove(1);
			2230.5 = true;
		}
		2210.7();
	}

	// Token: 0x060032FD RID: 13053 RVA: 0x00137DB8 File Offset: 0x00135FB8
	internal static void 22(string 1, string 2, bool 3 = false)
	{
		2230.2231 4 = new 2230.2231();
		4.1 = 2;
		object obj = 2230.2;
		lock (obj)
		{
			List<2241> list;
			if (!2230.4.TryGetValue(1, out list) && !2230.1.TryGetValue(1, out list))
			{
				return;
			}
			int num = list.FindIndex(new Predicate<2241>(4.1));
			if (num >= 0)
			{
				try
				{
					if (!3)
					{
						2230.23(list[num]);
					}
				}
				catch (Exception)
				{
				}
				list.RemoveAt(num);
			}
			2230.5 = true;
		}
		2210.7();
	}

	// Token: 0x17000283 RID: 643
	// (get) Token: 0x060032FE RID: 13054 RVA: 0x00137E6C File Offset: 0x0013606C
	internal static bool HasUnsavedChanges
	{
		get
		{
			return 2230.5;
		}
	}

	// Token: 0x060032FF RID: 13055 RVA: 0x00137E74 File Offset: 0x00136074
	private static void 23(2241 1)
	{
		string replayPath = 2.7();
		Predicate<2241> <>9__0;
		foreach (Dictionary<string, List<2241>> dictionary in new Dictionary<string, List<2241>>[]
		{
			2230.4,
			2230.1
		})
		{
			List<2241> list;
			if (dictionary != null && 2.10 != null && dictionary.TryGetValue(2.10, out list))
			{
				List<2241> list2 = list;
				Predicate<2241> match;
				if ((match = <>9__0) == null)
				{
					match = (<>9__0 = ((2241 1) => 1 != 2 && 1.7() == replayPath));
				}
				if (list2.Exists(match))
				{
					return;
				}
			}
		}
		2.28();
	}

	// Token: 0x06003300 RID: 13056 RVA: 0x00137F23 File Offset: 0x00136123
	internal static 2241 24(2241 1)
	{
		return 2230.26(2230.25(1));
	}

	// Token: 0x06003301 RID: 13057 RVA: 0x00137F30 File Offset: 0x00136130
	internal static byte[] 25(2241 1)
	{
		byte[] result;
		using (MemoryStream memoryStream = new MemoryStream())
		{
			1.17(new 1648(memoryStream), false);
			result = memoryStream.ToArray();
		}
		return result;
	}

	// Token: 0x06003302 RID: 13058 RVA: 0x00137F74 File Offset: 0x00136174
	internal static 2241 26(byte[] 1)
	{
		2241 result;
		try
		{
			using (MemoryStream memoryStream = new MemoryStream(1))
			{
				1647 2 = new 1647(memoryStream);
				2241 3 = 2246.Create((2147)2.ReadByte(), null, null, false);
				3.16(2);
				if ((3.8 & 2023.Target) > 2023.None)
				{
					3 = new 2136(3);
				}
				3.15(2, true);
				result = 3;
			}
		}
		catch (Exception ex)
		{
			1338.4(ex, "copying a score", 1341.Runtime);
			result = null;
		}
		return result;
	}

	// Token: 0x06003303 RID: 13059 RVA: 0x00138004 File Offset: 0x00136204
	internal static int 27(List<2241> 1)
	{
		2230.4();
		int num = 0;
		object obj = 2230.2;
		lock (obj)
		{
			foreach (2241 2 in 3)
			{
				bool flag2 = 1272.8(2.10) != null;
				List<2241> list;
				if (flag2 && 2230.1.TryGetValue(2.10, out list))
				{
					List<2241> list2;
					if (2230.4.TryGetValue(2.10, out list2))
					{
						using (List<2241>.Enumerator enumerator2 = list.GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								2241 item = enumerator2.Current;
								int num2 = list2.BinarySearch(item);
								list2.Insert((num2 < 0) ? (~num2) : num2, item);
							}
							goto IL_D8;
						}
						goto IL_C5;
					}
					goto IL_C5;
					IL_D8:
					2230.1.Remove(2.10);
					goto IL_EA;
					IL_C5:
					2230.4[2.10] = list;
					goto IL_D8;
				}
				IL_EA:
				Dictionary<string, List<2241>> dictionary = (2230.4.ContainsKey(2.10) || flag2) ? 2230.4 : 2230.1;
				List<2241> list3;
				if (!dictionary.TryGetValue(2.10, out list3))
				{
					list3 = (dictionary[2.10] = new List<2241>());
				}
				string checksum = 2.4();
				if (!list3.Exists((2241 1) => 1.4() == checksum))
				{
					int num3 = list3.BinarySearch(2);
					list3.Insert((num3 < 0) ? (~num3) : num3, 2);
					num++;
				}
			}
			if (num > 0)
			{
				2230.5 = true;
			}
		}
		if (num > 0)
		{
			2230.17(true);
			2210.7();
		}
		return num;
	}

	// Token: 0x040025C4 RID: 9668
	private static readonly Dictionary<string, List<2241>> 1 = new Dictionary<string, List<2241>>();

	// Token: 0x040025C5 RID: 9669
	private static readonly object 2 = new object();

	// Token: 0x040025C6 RID: 9670
	private static int 3;

	// Token: 0x040025C7 RID: 9671
	internal static Dictionary<string, List<2241>> 4;

	// Token: 0x040025C8 RID: 9672
	internal static bool 5;

	// Token: 0x040025C9 RID: 9673
	private static readonly object 6 = new object();

	// Token: 0x020006A7 RID: 1703
	[276]
	public sealed class 2234
	{
		// Token: 0x040025CA RID: 9674
		public 2147 1;
	}

	// Token: 0x020006A8 RID: 1704
	[276]
	[Serializable]
	public sealed class 2233
	{
		// Token: 0x06003307 RID: 13063 RVA: 0x00138240 File Offset: 0x00136440
		internal void 1(1647 1)
		{
			2230.3 = 1.ReadInt32();
			int num = 1.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				string text = 1.ReadString();
				int num2 = 1.ReadInt32();
				List<2241> list = new List<2241>(num2);
				for (int j = 0; j < num2; j++)
				{
					2241 2 = 2246.Create((2147)1.ReadByte(), null, null, false);
					2.16(1);
					2023 3 = 2.8;
					2023 4 = 2023.Target;
					if ((3 & 4) > 2023.None)
					{
						2 = new 2136(2);
					}
					2.15(1, 2230.3 >= 20140721);
					list.Add(2);
				}
				if (1272.8(text) != null)
				{
					2230.4.Add(text, list);
				}
				else
				{
					2230.1[text] = list;
				}
			}
		}

		// Token: 0x06003308 RID: 13064 RVA: 0x00138315 File Offset: 0x00136515
		internal void 2(object 1, EventArgs 2)
		{
			1763.4(1568.1(2679.ScoreManager_DontHaveBeatmap));
		}

		// Token: 0x040025CB RID: 9675
		public static readonly 2230.2233 instance = new 2230.2233();

		// Token: 0x040025CC RID: 9676
		public static 1322.1323 databaseReadHandler;

		// Token: 0x040025CD RID: 9677
		public static EventHandler eventHandler;
	}

	// Token: 0x020006A9 RID: 1705
	[276]
	public sealed class 2235
	{
		// Token: 0x040025CE RID: 9678
		public string 1;
	}

	// Token: 0x020006AA RID: 1706
	[276]
	public sealed class 2231
	{
		// Token: 0x0600330C RID: 13068 RVA: 0x00138332 File Offset: 0x00136532
		internal bool 1(2241 1)
		{
			return 1.4() == this.1;
		}

		// Token: 0x040025CF RID: 9679
		public string 1;
	}

	// Token: 0x020006AB RID: 1707
	[276]
	public sealed class 2232
	{
		// Token: 0x0600330E RID: 13070 RVA: 0x00138348 File Offset: 0x00136548
		internal void 1(1648 1)
		{
			1.Write(1296.11);
			1.Write(this.1.Count);
			foreach (KeyValuePair<string, List<2241>> keyValuePair in this.1)
			{
				1.Write(keyValuePair.Key);
				1.Write(keyValuePair.Value.Count);
				foreach (2241 2 in keyValuePair.Value)
				{
					2.17(1, false);
				}
			}
		}

		// Token: 0x040025D0 RID: 9680
		public Dictionary<string, List<2241>> 1;
	}
}
