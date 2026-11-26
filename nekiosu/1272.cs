using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;

// Token: 0x02000B70 RID: 2928
public static class 1272
{
	// Token: 0x060050BD RID: 20669 RVA: 0x001FEFB6 File Offset: 0x001FD1B6
	internal static string 1()
	{
		return Path.Combine(1272.1, "Failed");
	}

	// Token: 0x060050BE RID: 20670 RVA: 0x001FEFC8 File Offset: 0x001FD1C8
	internal static void 2(1272.1273 1)
	{
		1272.1273 2 = 1272.11;
		1272.1273 3;
		do
		{
			3 = 2;
			1272.1273 value = (1272.1273)Delegate.Combine(3, 1);
			2 = Interlocked.CompareExchange<1272.1273>(ref 1272.11, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x060050BF RID: 20671 RVA: 0x001FEFFC File Offset: 0x001FD1FC
	internal static void 3(1272.1273 1)
	{
		1272.1273 2 = 1272.11;
		1272.1273 3;
		do
		{
			3 = 2;
			1272.1273 value = (1272.1273)Delegate.Remove(3, 1);
			2 = Interlocked.CompareExchange<1272.1273>(ref 1272.11, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x060050C0 RID: 20672 RVA: 0x001FF02F File Offset: 0x001FD22F
	private static string 4()
	{
		return 268.1("osu!.db");
	}

	// Token: 0x060050C1 RID: 20673 RVA: 0x001FF03B File Offset: 0x001FD23B
	internal static 1262 5()
	{
		return 1272.18;
	}

	// Token: 0x060050C2 RID: 20674 RVA: 0x001FF042 File Offset: 0x001FD242
	internal static void SetCurrentBeatmap(1262 1)
	{
		if (1272.18 != 1)
		{
			if (1272.18 != null)
			{
				1272.18.63();
				1455.8(true);
			}
			1272.18 = 1;
		}
	}

	// Token: 0x060050C3 RID: 20675 RVA: 0x001FF06C File Offset: 0x001FD26C
	internal static bool 6(string 1, bool 2)
	{
		1262 3 = 1272.7(1);
		if (2 || 3 != null)
		{
			1272.SetCurrentBeatmap(3);
		}
		return 3 != null;
	}

	// Token: 0x060050C4 RID: 20676 RVA: 0x001FF090 File Offset: 0x001FD290
	internal static 1262 7(string 1)
	{
		1262 item = new 1262
		{
			58 = 1
		};
		int num = 1272.3.BinarySearch(item);
		if (num >= 0)
		{
			return 1272.3[num];
		}
		return null;
	}

	// Token: 0x060050C5 RID: 20677 RVA: 0x001FF0C8 File Offset: 0x001FD2C8
	internal static 1262 8(string 1)
	{
		if (1 == null)
		{
			return null;
		}
		object obj = 1272.6;
		1262 result;
		lock (obj)
		{
			1262 2;
			result = ((1272.4 != null && 1272.4.TryGetValue(1, out 2)) ? 2 : null);
		}
		return result;
	}

	// Token: 0x060050C6 RID: 20678 RVA: 0x001FF124 File Offset: 0x001FD324
	private static 1271 9(string 1, bool 2)
	{
		if (6.EndsWith(".osz") && File.Exists(6))
		{
			6 = Path.GetDirectoryName(6);
		}
		if (6.StartsWith(1272.1))
		{
			6 = 6.Replace(1272.1, string.Empty).TrimStart(new char[]
			{
				'\\'
			});
		}
		6 = 2672.17(6).TrimStart(new char[]
		{
			Path.DirectorySeparatorChar
		});
		1271 3 = 1272.10;
		if (6.Length == 0)
		{
			return 3;
		}
		string[] array = 6.Split(new char[]
		{
			Path.DirectorySeparatorChar
		});
		if (2 && array.Length < 2)
		{
			1271 4 = new 1271(Path.Combine(1272.1, 6), 3);
			3.2.Add(4);
			return 4;
		}
		string a = array[array.Length - 1];
		if (a == "Failed" || a == "SubmissionCache")
		{
			return null;
		}
		string path = 1272.1;
		string[] array2 = array;
		for (int i = 0; i < array2.Length; i++)
		{
			1272.1277 folderNameMatcher = new 1272.1277();
			folderNameMatcher.1 = array2[i];
			1271 5 = 3.2.Find((1271 1) => 1.4 == folderNameMatcher.1);
			path = Path.Combine(path, folderNameMatcher.1);
			if (5 == null)
			{
				3.2.Add(5 = new 1271(path, 3));
			}
			3 = 5;
		}
		return 3;
	}

	// Token: 0x060050C7 RID: 20679 RVA: 0x001FF298 File Offset: 0x001FD498
	private static void 10(1271 1)
	{
		if (3.1.Count > 0)
		{
			3.1.ForEach(delegate(1262 1)
			{
				1272.12(1);
			});
			Dictionary<string, int> dictionary = new Dictionary<string, int>();
			foreach (1262 2 in 3.1)
			{
				dictionary[2.44()] = 1;
				if (!2.42())
				{
					1272.16--;
				}
			}
			3.1.Clear();
			1272.17 -= dictionary.Count;
		}
		if (3.2.Count > 0 && 3.5 != 1272.1)
		{
			List<1271> list = 3.2;
			Action<1271> action;
			if ((action = 1272.<>O.<0>__RemoveFolderBeatmaps) == null)
			{
				action = (1272.<>O.<0>__RemoveFolderBeatmaps = new Action<1271>(1272.10));
			}
			list.ForEach(action);
		}
	}

	// Token: 0x060050C8 RID: 20680 RVA: 0x001FF3A8 File Offset: 0x001FD5A8
	internal static void 11()
	{
		Dictionary<string, 1262> dictionary = new Dictionary<string, 1262>();
		Dictionary<int, 1262> dictionary2 = new Dictionary<int, 1262>();
		foreach (1262 <<EMPTY_NAME>> in 1272.3)
		{
			if (<<EMPTY_NAME>>.23 != null)
			{
				dictionary[<<EMPTY_NAME>>.23] = <<EMPTY_NAME>>;
			}
			if (<<EMPTY_NAME>>.25 > 0)
			{
				dictionary2[<<EMPTY_NAME>>.25] = <<EMPTY_NAME>>;
			}
		}
		object obj = 1272.6;
		lock (obj)
		{
			1272.4 = dictionary;
			1272.5 = dictionary2;
		}
	}

	// Token: 0x060050C9 RID: 20681 RVA: 0x001FF464 File Offset: 0x001FD664
	internal static bool 12(1262 1)
	{
		if (!1272.3.Remove(1))
		{
			return false;
		}
		object obj = 1272.6;
		lock (obj)
		{
			if (1.23 != null)
			{
				1272.4.Remove(1.23);
			}
			if (1.25 > 0)
			{
				1272.5.Remove(1.25);
			}
		}
		return true;
	}

	// Token: 0x060050CA RID: 20682 RVA: 0x001FF4E0 File Offset: 0x001FD6E0
	internal static void 13()
	{
		1272.1275 <<EMPTY_NAME>> = new 1272.1275();
		if ((!1662.47 || 1662.48) && !1662.49)
		{
			for (int i = 1; i <= 6; i++)
			{
				try
				{
					<<EMPTY_NAME>>.1 = new List<1262>(1272.3);
					if (1322.4(1272.4(), new 1322.1324(<<EMPTY_NAME>>.1)))
					{
						return;
					}
				}
				catch (Exception ex)
				{
					1338.4(ex, "beatmap database save, attempt " + i.ToString(), 1341.Runtime);
				}
				Thread.Sleep(150);
			}
			1338.5("The beatmap database could not be saved; beatmaps added this session are found again by the folder check at the next start.", 1341.Runtime, (1114)3);
		}
	}

	// Token: 0x060050CB RID: 20683 RVA: 0x001FF580 File Offset: 0x001FD780
	private static void 14()
	{
		string path = 1272.4();
		bool flag = File.Exists(path) || File.Exists(2672.31(path));
		if (!1322.1(path, new 1322.1323(1272.1274.instance.1), null, delegate
		{
			1272.3 = null;
		}) && flag)
		{
			1272.3 = null;
			string text = 268.25("osu!.db");
			if (text != null && 1322.2(text, new 1322.1323(1272.1274.instance.1)))
			{
				1338.5("The beatmap database was damaged; it was rebuilt from osu!'s osu!.db.", 1341.Runtime, (1114)2);
			}
			else
			{
				1272.3 = null;
				1272.1274.instance.2();
			}
		}
		1272.15();
	}

	// Token: 0x060050CC RID: 20684 RVA: 0x001FF638 File Offset: 0x001FD838
	private static void 15()
	{
		if (1272.3 == null)
		{
			1272.3 = new List<1262>();
			1272.9 = 1296.11;
			return;
		}
		1272.13 = true;
		int num = 1272.3.RemoveAll(new Predicate<1262>(1272.1274.instance.3));
		if (num > 0)
		{
			1338.5(string.Format("{0} beatmaps were ignored due to having a null or invalid ContainingFolder. this should NEVER be the case.", num), 1341.Runtime, (1114)3);
		}
		1272.10.1.AddRange(1272.3.FindAll(new Predicate<1262>(1272.1274.instance.4)));
		Dictionary<string, 1271> dictionary = new Dictionary<string, 1271>();
		foreach (1262 <<EMPTY_NAME>> in 1272.3)
		{
			1271 2;
			if (!dictionary.TryGetValue(<<EMPTY_NAME>>.44(), out 2))
			{
				2 = 1272.9(<<EMPTY_NAME>>.44(), true);
				dictionary.Add(<<EMPTY_NAME>>.44(), 2);
			}
			2.1.Add(<<EMPTY_NAME>>);
		}
		1272.16 = 1272.3.FindAll(new Predicate<1262>(1272.1274.instance.5)).Count;
	}

	// Token: 0x060050CD RID: 20685 RVA: 0x001FF768 File Offset: 0x001FD968
	internal static int 16(1262 1)
	{
		int num = 1272.3.BinarySearch(1);
		if (num >= 0)
		{
			if (1272.3[num].61 == 1.61)
			{
				return num;
			}
			1272.3.Insert(num, 1);
		}
		else
		{
			1272.3.Insert(~num, 1);
		}
		object obj = 1272.6;
		lock (obj)
		{
			if (1.23 != null)
			{
				1272.4[1.23] = 1;
			}
			if (1.25 > 0)
			{
				1272.5[1.25] = 1;
			}
		}
		return -1;
	}

	// Token: 0x060050CE RID: 20686 RVA: 0x001FF81C File Offset: 0x001FDA1C
	public static 1262 17(int 1)
	{
		if (1 <= 0)
		{
			return null;
		}
		object obj = 1272.6;
		1262 result;
		lock (obj)
		{
			1262 2;
			result = ((1272.5 != null && 1272.5.TryGetValue(1, out 2)) ? 2 : null);
		}
		return result;
	}

	// Token: 0x060050CF RID: 20687 RVA: 0x001FF878 File Offset: 0x001FDA78
	public static 1262 18(int 1)
	{
		1272.1280 setIdMatcher = new 1272.1280();
		setIdMatcher.1 = 2;
		if (setIdMatcher.1 <= 0)
		{
			return null;
		}
		return 1272.3.Find((1262 1) => 1.29 == setIdMatcher.1);
	}

	// Token: 0x060050D0 RID: 20688 RVA: 0x001FF8C8 File Offset: 0x001FDAC8
	public static void 19(1262 1, bool 2)
	{
		1272.1279 3 = new 1272.1279();
		3.1 = 1;
		1272.15.EnableRaisingEvents = false;
		1226.103();
		if (2)
		{
			if (!3.1.28 || 3.1.44().EndsWith(1272.1) || 3.1.61)
			{
				try
				{
					if (3.1.61)
					{
						1226.5();
						1226.103();
						1520.3(3.1.55());
						1292.2(3.1.44());
						1272.12--;
					}
					else if (!3.1.44().EndsWith(1272.1))
					{
						1292.2(3.1.44());
						1272.12--;
					}
					else
					{
						3.1.51(3.1.18);
					}
					goto IL_127;
				}
				catch
				{
					goto IL_127;
				}
			}
			try
			{
				1292.2(3.1.44());
				1272.12--;
				goto IL_127;
			}
			catch (Exception)
			{
				goto IL_127;
			}
		}
		3.1.51(1272.5().58);
		IL_127:
		List<1262> list;
		if (!2)
		{
			(list = new List<1262>()).Add(1272.5());
		}
		else
		{
			list = 1272.3.FindAll(new Predicate<1262>(3.1));
		}
		List<1262> list2 = list;
		foreach (1262 item in list2)
		{
			1272.12(item);
			1272.10.1.Remove(item);
		}
		1272.15.EnableRaisingEvents = true;
		if (1272.11 != null && list2.Count > 0)
		{
			1272.11(null, list2);
		}
	}

	// Token: 0x060050D1 RID: 20689 RVA: 0x001FFABC File Offset: 0x001FDCBC
	public static void 20(Action<string> 1)
	{
		Action<string> action = 1272.20;
		Action<string> action2;
		do
		{
			action2 = action;
			Action<string> value = (Action<string>)Delegate.Combine(action2, 1);
			action = Interlocked.CompareExchange<Action<string>>(ref 1272.20, value, action2);
		}
		while (action != action2);
	}

	// Token: 0x060050D2 RID: 20690 RVA: 0x001FFAEF File Offset: 0x001FDCEF
	private static void 21(string 1)
	{
		Action<string> action = 1272.20;
		if (action == null)
		{
			return;
		}
		action(1);
	}

	// Token: 0x060050D3 RID: 20691 RVA: 0x001FFB04 File Offset: 0x001FDD04
	internal static void 22()
	{
		1272.3.Clear();
		object obj = 1272.6;
		lock (obj)
		{
			1272.4.Clear();
			1272.5.Clear();
		}
	}

	// Token: 0x060050D4 RID: 20692 RVA: 0x001FFB5C File Offset: 0x001FDD5C
	internal static void 23()
	{
		1272.20 = null;
	}

	// Token: 0x060050D5 RID: 20693 RVA: 0x001FFB64 File Offset: 0x001FDD64
	internal static void LoadTrackFor(1262 1)
	{
		if (1 != null)
		{
			1272.SetCurrentBeatmap(1);
			1226.99(1272.5(), false, false, true, false);
			1226.Pause();
		}
	}

	// Token: 0x060050D6 RID: 20694 RVA: 0x001FFB83 File Offset: 0x001FDD83
	public static void 24(string 1)
	{
		if (!1272.7.Contains(1))
		{
			1272.7.Add(1);
		}
	}

	// Token: 0x060050D7 RID: 20695 RVA: 0x001FFBA0 File Offset: 0x001FDDA0
	public static void 25(1189 1)
	{
		1189 2 = 1272.26;
		1189 3;
		do
		{
			3 = 2;
			1189 value = (1189)Delegate.Combine(3, 1);
			2 = Interlocked.CompareExchange<1189>(ref 1272.26, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x060050D8 RID: 20696 RVA: 0x001FFBD3 File Offset: 0x001FDDD3
	private static void 26()
	{
		1189 <<EMPTY_NAME>> = 1272.26;
		if (<<EMPTY_NAME>> != null)
		{
			<<EMPTY_NAME>>();
		}
		1272.26 = null;
	}

	// Token: 0x060050D9 RID: 20697 RVA: 0x001FFBEC File Offset: 0x001FDDEC
	public static void 27()
	{
		if (!1272.25 && 1662.21())
		{
			1272.25 = true;
			1763.2("Loading online favourites...", 1000, (1389)0);
			1621 <<EMPTY_NAME>> = new 1621(string.Format(1661.23(), 1304.189, 1304.186.1(1643.Hashed)), Array.Empty<object>());
			<<EMPTY_NAME>>.9(new 1621.1622(1272.1274.instance.6));
			<<EMPTY_NAME>>.Start();
		}
	}

	// Token: 0x060050DA RID: 20698 RVA: 0x001FFC5C File Offset: 0x001FDE5C
	internal static bool 28(bool 1)
	{
		if (1272.3 != null && 1272.3.Count != 0 && !1)
		{
			return false;
		}
		object obj = 1272.6;
		lock (obj)
		{
			1272.4 = new Dictionary<string, 1262>();
			1272.5 = new Dictionary<int, 1262>();
		}
		1272.13 = false;
		1272.10 = new 1271(1272.1, null);
		1272.14();
		if (1)
		{
			1272.30();
		}
		else
		{
			1272.27 = true;
		}
		1272.31();
		return true;
	}

	// Token: 0x060050DB RID: 20699 RVA: 0x001FFCF4 File Offset: 0x001FDEF4
	internal static void 29()
	{
		if (!1272.27)
		{
			return;
		}
		1272.27 = false;
		1272.30();
	}

	// Token: 0x060050DC RID: 20700 RVA: 0x001FFD10 File Offset: 0x001FDF10
	private static void 30()
	{
		try
		{
			if (1272.3 != null && Directory.Exists(1272.1))
			{
				HashSet<string> hashSet = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
				HashSet<string> hashSet2 = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
				foreach (1262 <<EMPTY_NAME>> in 1272.3.ToArray())
				{
					if (<<EMPTY_NAME>> != null)
					{
						if (!string.IsNullOrEmpty(<<EMPTY_NAME>>.58))
						{
							hashSet2.Add(<<EMPTY_NAME>>.58);
						}
						if (!string.IsNullOrEmpty(<<EMPTY_NAME>>.37))
						{
							int num = <<EMPTY_NAME>>.37.IndexOfAny(new char[]
							{
								'\\',
								'/'
							});
							hashSet.Add((num > 0) ? <<EMPTY_NAME>>.37.Substring(0, num) : <<EMPTY_NAME>>.37);
						}
					}
				}
				List<string> obj = 1272.7;
				HashSet<string> hashSet3;
				lock (obj)
				{
					hashSet3 = new HashSet<string>(1272.7);
				}
				List<string> list = new List<string>();
				int num2 = 0;
				foreach (string text in Directory.GetDirectories(1272.1))
				{
					if (!hashSet.Contains(Path.GetFileName(text)) && !hashSet3.Contains(text))
					{
						bool flag2 = false;
						bool flag3 = false;
						foreach (string path in Directory.EnumerateFiles(text, "*.osu", SearchOption.AllDirectories))
						{
							flag2 = true;
							if (!hashSet2.Contains(Path.GetFileName(path)))
							{
								flag3 = true;
								break;
							}
						}
						if (flag3)
						{
							list.Add(text);
						}
						else if (flag2)
						{
							num2++;
						}
					}
				}
				obj = 1272.7;
				lock (obj)
				{
					foreach (string item in list)
					{
						if (!1272.7.Contains(item))
						{
							1272.7.Add(item);
						}
					}
				}
				if (num2 > 0)
				{
					1338.5(num2.ToString() + " song folder(s) only hold beatmaps that are in the database from another folder (the same map twice); they are not loaded again.", 1341.Runtime, (1114)1);
				}
				if (list.Count > 0)
				{
					int i = list.Count;
					1338.5(i.ToString() + " song folder(s) are missing from the beatmap database and will be loaded.", 1341.Runtime, (1114)2);
					2463.2(true);
				}
			}
		}
		catch (Exception ex)
		{
			1338.4(ex, "check for song folders missing from the database", 1341.Runtime);
		}
	}

	// Token: 0x060050DD RID: 20701 RVA: 0x00200008 File Offset: 0x001FE208
	private static void 31()
	{
		if (1272.15 == null)
		{
			1272.15 = new FileSystemWatcher(1272.1)
			{
				IncludeSubdirectories = true
			};
			FileSystemWatcher fileSystemWatcher = 1272.15;
			FileSystemEventHandler value;
			if ((value = 1272.<>O.<1>__OnFileSystemChanged) == null)
			{
				value = (1272.<>O.<1>__OnFileSystemChanged = new FileSystemEventHandler(1272.34));
			}
			fileSystemWatcher.Created += value;
			FileSystemWatcher fileSystemWatcher2 = 1272.15;
			FileSystemEventHandler value2;
			if ((value2 = 1272.<>O.<1>__OnFileSystemChanged) == null)
			{
				value2 = (1272.<>O.<1>__OnFileSystemChanged = new FileSystemEventHandler(1272.34));
			}
			fileSystemWatcher2.Deleted += value2;
			FileSystemWatcher fileSystemWatcher3 = 1272.15;
			RenamedEventHandler value3;
			if ((value3 = 1272.<>O.<2>__OnFileSystemChanged) == null)
			{
				value3 = (1272.<>O.<2>__OnFileSystemChanged = new RenamedEventHandler(1272.34));
			}
			fileSystemWatcher3.Renamed += value3;
		}
		1272.15.EnableRaisingEvents = true;
	}

	// Token: 0x060050DE RID: 20702 RVA: 0x002000B0 File Offset: 0x001FE2B0
	internal static void 32(bool 1)
	{
		object obj = 1272.7.Count > 0 || 1272.8.Count > 0;
		1338.6(string.Format("ChangedFolders: {0}\nChangedPackages: {1}", 1272.7.Count, 1272.8.Count), 1341.Runtime, (1114)1);
		object obj2 = obj;
		if (obj2 != null)
		{
			1272.21(1568.1(2679.BeatmapManager_LoadingNewFilesOnly));
			1272.33(true);
		}
		if ((obj2 == 0 && 1) || 1272.3.Count == 0)
		{
			1272.21(1568.1(2679.BeatmapManager_ReloadingDatabase));
			1272.33(false);
		}
		1272.7.Clear();
		1272.8.Clear();
		1272.21.Clear();
	}

	// Token: 0x060050DF RID: 20703 RVA: 0x00200168 File Offset: 0x001FE368
	internal static void 33(bool 1)
	{
		1272.15.EnableRaisingEvents = false;
		if (!6)
		{
			1338.6("_______________ Full process initiated. _______________", 1341.Runtime, (1114)1);
			1272.3.ForEach(new Action<1262>(1272.1274.instance.8));
			1272.10.2.Clear();
			1272.10.1.Clear();
			1272.17 = 0;
			1272.16 = 0;
			1272.36(1272.1);
			int num = 1272.3.RemoveAll((1262 1) => 1.45);
			if (num > 0)
			{
				1272.21(string.Format(1568.1(2679.BeatmapManager_RemoveMissingMaps), num));
			}
			1272.11();
			1272.21(string.Format(1568.1(2679.BeatmapManager_LoadedMaps), 1272.3.Count));
		}
		else
		{
			for (int i = 0; i < 1272.8.Count; i++)
			{
				1272.1278 2 = new 1272.1278();
				2.1 = 1272.8[i];
				if (!File.Exists(2.1))
				{
					1338.5(2.1 + " could not be loaded. It no longer exists.", 1341.Runtime, (1114)1);
					1272.3.FindAll(new Predicate<1262>(2.6)).ForEach(new Action<1262>(1272.1274.instance.9));
				}
				else
				{
					1271 3 = 1272.9(Path.GetDirectoryName(2.1), false);
					if (3 != null)
					{
						1272.38(2.1, 3);
					}
				}
			}
			for (int j = 0; j < 1272.7.Count; j++)
			{
				string text = 1272.7[j];
				271.2(string.Concat(new string[]
				{
					"loading song folder ",
					(j + 1).ToString(),
					" of ",
					1272.7.Count.ToString(),
					": ",
					Path.GetFileName(text)
				}));
				bool flag = Directory.Exists(text);
				if (!text.StartsWith(1272.1))
				{
					1272.33(false);
					return;
				}
				1271 4 = 1272.9(text, false);
				if (4 != null)
				{
					1272.10(4);
					if (flag)
					{
						1272.37(4);
					}
					else
					{
						1271 5 = 4.6;
						if (5 != null)
						{
							5.2.Remove(4);
						}
					}
				}
			}
		}
		if (1272.5() != null && 6)
		{
			1272.6(1272.5().58, false);
		}
		1272.13 = true;
		1272.15.EnableRaisingEvents = true;
	}

	// Token: 0x060050E0 RID: 20704 RVA: 0x00200408 File Offset: 0x001FE608
	private static void 34(object 1, FileSystemEventArgs 2)
	{
		string text = Directory.Exists(2.FullPath) ? Path.GetDirectoryName(2.FullPath.TrimEnd(new char[]
		{
			Path.DirectorySeparatorChar
		}) + Path.DirectorySeparatorChar.ToString()) : Path.GetDirectoryName(2.FullPath);
		if (text.Contains("_tmp"))
		{
			return;
		}
		if (text == 1272.1)
		{
			if (!2463.1())
			{
				1272.35();
				return;
			}
		}
		else
		{
			if (2.FullPath.EndsWith(".osz2") && !1272.8.Contains(2.FullPath))
			{
				if (!2463.1())
				{
					1272.35();
				}
				1272.8.Add(2.FullPath);
				return;
			}
			List<string> obj = 1272.7;
			bool flag2;
			lock (obj)
			{
				flag2 = !1272.7.Contains(text);
			}
			if (flag2)
			{
				1272.35();
				obj = 1272.7;
				lock (obj)
				{
					if (!1272.7.Contains(text))
					{
						1272.7.Add(text);
					}
				}
			}
		}
	}

	// Token: 0x060050E1 RID: 20705 RVA: 0x00200554 File Offset: 0x001FE754
	private static void 35()
	{
		2463.2(true);
		1677 <<EMPTY_NAME>> = 1662.78;
		if (<<EMPTY_NAME>> - 1677.SelectEdit <= 1 || <<EMPTY_NAME>> - 1677.MatchSetup <= 1)
		{
			1763.2(1568.1(2679.BeatmapManager_NewBeatmapDetected), 2000, (1389)0);
		}
	}

	// Token: 0x060050E2 RID: 20706 RVA: 0x0020058F File Offset: 0x001FE78F
	internal static void 36(string 1)
	{
		1272.37(1272.9(1, false));
	}

	// Token: 0x060050E3 RID: 20707 RVA: 0x002005A0 File Offset: 0x001FE7A0
	private static void 37(1271 1)
	{
		if (6 == null || (1662.47 && !1662.48))
		{
			return;
		}
		int num = 0;
		string text = 6.5;
		if (6 != 1272.10)
		{
			1272.21(text.Replace(1272.1, string.Empty).Trim(new char[]
			{
				'\\',
				'/'
			}));
		}
		try
		{
			bool flag = text == 1272.1;
			if (!flag && 1272.13 && (1272.5() == null || 1272.5().37 == null || 1272.5().44() != text))
			{
				string b = text.Replace(1272.1, string.Empty);
				bool flag2 = false;
				foreach (1262 2 in 1272.3)
				{
					if (!(2.37 != b))
					{
						num++;
						if (!2.61)
						{
							2.45 = false;
							2.45(text);
							6.1.Add(2);
							flag2 = true;
						}
					}
				}
				if (flag2)
				{
					1272.17++;
					return;
				}
			}
			string[] array = Directory.GetFiles(text, "*.osz2");
			foreach (string a in array)
			{
				if (a == "LastUpload.osz2")
				{
					break;
				}
				if (1272.38(a, 6))
				{
					1272.17++;
				}
			}
			array = Directory.GetFiles(text, "*.osu");
			string[] array2 = array;
			int i = 0;
			while (i < array2.Length)
			{
				string path = array2[i];
				num++;
				1262 3 = new 1262
				{
					58 = Path.GetFileName(path)
				};
				if (!1272.13)
				{
					goto IL_204;
				}
				int num2 = 1272.3.BinarySearch(3);
				if (num2 < 0)
				{
					goto IL_204;
				}
				1262 4 = 1272.3[num2];
				if (4.61)
				{
					goto IL_204;
				}
				4.45 = false;
				4.28 = true;
				4.45(text);
				6.1.Add(4);
				IL_26E:
				i++;
				continue;
				IL_204:
				3.45(text);
				try
				{
					3.65();
				}
				catch (UnauthorizedAccessException)
				{
					1338.5(string.Format("{0} could not be loaded. Insufficient permissions", 3), 1341.Runtime, (1114)1);
					goto IL_26E;
				}
				if (3.42() || 3.28)
				{
					1272.21.Add(3);
					3.64 = true;
					1272.16(3);
					1272.14 = 3;
					6.1.Add(3);
					goto IL_26E;
				}
				goto IL_26E;
			}
			if (num == 0 && (6 == 1272.10 || 6.6 == 1272.10))
			{
				string text2 = null;
				string[] array3 = (from 1 in Directory.GetFiles(text, "*", SearchOption.TopDirectoryOnly)
				where 2672.24(1) == (2670)7
				select 1).ToArray<string>();
				if (array3.Length != 0)
				{
					text2 = array3[0];
				}
				if (text2 != null)
				{
					1262 5 = new 1262();
					5.18 = Path.GetFileName(text2);
					5.58 = Path.GetFileNameWithoutExtension(text2) + ".osu";
					5.49 = Path.GetFileName(text2);
					5.51 = Path.GetFileName(text2);
					5.81 = Path.GetFileName(text2);
					5.43(true);
					5.28 = false;
					5.45(text);
					1262 item = 5;
					int num3 = 1272.16(item);
					if (num3 >= 0)
					{
						1272.3[num3].45 = false;
					}
					6.1.Add(item);
					1272.14 = item;
					1272.16++;
				}
			}
			if (num > 0)
			{
				1272.17++;
			}
			if (flag || num == 0)
			{
				array = Directory.GetDirectories(text);
				for (int j = 0; j < array.Length; j++)
				{
					1272.36(array[j]);
				}
			}
		}
		catch (Exception ex)
		{
			1763.4(string.Format(1568.1(2679.BeatmapManager_ErrorWhileProcessing), text));
			1338.4(ex, "map processing failure (" + text + ")", 1341.Runtime);
		}
	}

	// Token: 0x060050E4 RID: 20708 RVA: 0x002009F0 File Offset: 0x001FEBF0
	private static bool 38(string 1, 1271 2)
	{
		1514 3 = 1520.1(1);
		if (3 == null)
		{
			1763.5("Error reading " + Path.GetFileName(1), 198.Red, 4000, null);
			return false;
		}
		int num = 0;
		string[] array = 3.25();
		int i = 0;
		while (i < array.Length)
		{
			string 4 = array[i];
			1262 5 = new 1262
			{
				58 = 4
			};
			if (!1272.13)
			{
				goto IL_B7;
			}
			int num2 = 1272.3.BinarySearch(5);
			if (num2 < 0)
			{
				goto IL_B7;
			}
			1262 6 = 1272.3[num2];
			if (!6.61)
			{
				goto IL_B7;
			}
			6.45 = false;
			6.28 = true;
			6.45(1);
			6.61 = true;
			2.1.Add(6);
			num++;
			IL_151:
			i++;
			continue;
			IL_B7:
			5.29 = Convert.ToInt32(3.29(1513.BeatmapSetID));
			5.25 = 3.26(4);
			5.45(1);
			5.61 = true;
			5.43(true);
			5.28 = true;
			5.65();
			if (!5.59)
			{
				goto IL_151;
			}
			5.64 = true;
			1272.21.Add(5);
			if (5.42() || 5.28)
			{
				1272.16(5);
				1272.14 = 5;
				2.1.Add(5);
				num++;
				goto IL_151;
			}
			goto IL_151;
		}
		1520.3(3);
		return num > 0;
	}

	// Token: 0x04003D49 RID: 15689
	internal static string 1;

	// Token: 0x04003D4A RID: 15690
	internal static bool 2 = false;

	// Token: 0x04003D4B RID: 15691
	internal static List<1262> 3;

	// Token: 0x04003D4C RID: 15692
	private static Dictionary<string, 1262> 4;

	// Token: 0x04003D4D RID: 15693
	private static Dictionary<int, 1262> 5;

	// Token: 0x04003D4E RID: 15694
	private static readonly object 6 = new object();

	// Token: 0x04003D4F RID: 15695
	internal static List<string> 7 = new List<string>();

	// Token: 0x04003D50 RID: 15696
	internal static List<string> 8 = new List<string>();

	// Token: 0x04003D51 RID: 15697
	internal static int 9;

	// Token: 0x04003D52 RID: 15698
	private static 1271 10;

	// Token: 0x04003D53 RID: 15699
	private static 1272.1273 11;

	// Token: 0x04003D54 RID: 15700
	public static int 12;

	// Token: 0x04003D55 RID: 15701
	private static bool 13;

	// Token: 0x04003D56 RID: 15702
	internal static 1262 14;

	// Token: 0x04003D57 RID: 15703
	internal static FileSystemWatcher 15;

	// Token: 0x04003D58 RID: 15704
	internal static int 16;

	// Token: 0x04003D59 RID: 15705
	internal static int 17;

	// Token: 0x04003D5A RID: 15706
	private static 1262 18;

	// Token: 0x04003D5B RID: 15707
	internal static string 19;

	// Token: 0x04003D5C RID: 15708
	private static Action<string> 20;

	// Token: 0x04003D5D RID: 15709
	private static List<1262> 21 = new List<1262>();

	// Token: 0x04003D5E RID: 15710
	private static bool 22 = true;

	// Token: 0x04003D5F RID: 15711
	private static DateTime 23;

	// Token: 0x04003D60 RID: 15712
	private static int 24;

	// Token: 0x04003D61 RID: 15713
	internal static bool 25;

	// Token: 0x04003D62 RID: 15714
	private static 1189 26;

	// Token: 0x04003D63 RID: 15715
	private static volatile bool 27;

	// Token: 0x02000B71 RID: 2929
	[Serializable]
	public sealed class 1274
	{
		// Token: 0x060050E6 RID: 20710 RVA: 0x00200B9C File Offset: 0x001FED9C
		internal void 1(1647 1)
		{
			1272.9 = 1.ReadInt32();
			1272.12 = 1.ReadInt32();
			1272.22 = 1.ReadBoolean();
			1272.23 = 1.3().ToLocalTime();
			1272.19 = 1.ReadString();
			1272.3 = (List<1262>)1.4<1262>(true);
			if (1.BaseStream.Length - 1.BaseStream.Position >= 4L)
			{
				1272.24 = 1.ReadInt32();
			}
			1287.3(1287.2(1), 1272.3);
			1272.11();
		}

		// Token: 0x060050E7 RID: 20711 RVA: 0x00200C34 File Offset: 0x001FEE34
		internal void 2()
		{
			1705.1("The local beatmap database seems corrupt.  Will create from scratch (this may take a while...).");
		}

		// Token: 0x060050E8 RID: 20712 RVA: 0x00200C44 File Offset: 0x001FEE44
		internal bool 3(1262 1)
		{
			if (1.37 == null)
			{
				return true;
			}
			try
			{
				1.44();
			}
			catch (Exception)
			{
				1338.5(string.Format("{0} was not loaded due to invalid characters in file path {1}", 1, 1.37), 1341.Runtime, (1114)3);
				return true;
			}
			return false;
		}

		// Token: 0x060050E9 RID: 20713 RVA: 0x00200C98 File Offset: 0x001FEE98
		internal bool 4(1262 1)
		{
			return 1.44().LastIndexOf(Path.DirectorySeparatorChar) < 1272.1.Length;
		}

		// Token: 0x060050EA RID: 20714 RVA: 0x00200CB6 File Offset: 0x001FEEB6
		internal bool 5(1262 1)
		{
			return !1.42();
		}

		// Token: 0x060050EB RID: 20715 RVA: 0x00200CC4 File Offset: 0x001FEEC4
		internal void 6(1621 1, Exception 2)
		{
			string[] array = 3.12().Split(new char[]
			{
				'\n'
			});
			for (int i = 0; i < array.Length; i++)
			{
				string text = array[i];
				1272.1276 favouriteSetMatcher = new 1272.1276();
				if (text.Length != 0)
				{
					favouriteSetMatcher.1 = int.Parse(text);
					1272.3.FindAll((1262 1) => 1.29 == favouriteSetMatcher.1).ForEach(new Action<1262>(1272.1274.instance.7));
				}
			}
			1272.26();
		}

		// Token: 0x060050EC RID: 20716 RVA: 0x00200D54 File Offset: 0x001FEF54
		internal void 7(1262 1)
		{
			1.98 = true;
		}

		// Token: 0x060050ED RID: 20717 RVA: 0x00200D5D File Offset: 0x001FEF5D
		internal void 8(1262 1)
		{
			1.45 = true;
			1.59 = false;
		}

		// Token: 0x060050EE RID: 20718 RVA: 0x000EE2B9 File Offset: 0x000EC4B9
		internal void 9(1262 1)
		{
			1272.12(1);
		}

		// Token: 0x04003D64 RID: 15716
		public static readonly 1272.1274 instance = new 1272.1274();

		// Token: 0x04003D65 RID: 15717
		public static Action<1262> action;

		// Token: 0x04003D66 RID: 15718
		public static 1322.1323 databaseReadHandler;

		// Token: 0x04003D67 RID: 15719
		public static 1189 voidDelegate;

		// Token: 0x04003D68 RID: 15720
		public static Predicate<1262> predicate;

		// Token: 0x04003D69 RID: 15721
		public static Predicate<1262> predicate2;

		// Token: 0x04003D6A RID: 15722
		public static Predicate<1262> predicate3;

		// Token: 0x04003D6B RID: 15723
		public static Comparison<1262> cachedCompareByFileName;

		// Token: 0x04003D6C RID: 15724
		public static Predicate<1262> predicate4;

		// Token: 0x04003D6D RID: 15725
		public static Action<1262> action2;

		// Token: 0x04003D6E RID: 15726
		public static 1621.1622 requestCompletedHandler;

		// Token: 0x04003D6F RID: 15727
		public static Action<1262> action3;

		// Token: 0x04003D70 RID: 15728
		public static Predicate<1262> predicate5;

		// Token: 0x04003D71 RID: 15729
		public static Action<1262> action4;

		// Token: 0x04003D72 RID: 15730
		public static Func<string, bool> cachedIsAudioFile;
	}

	// Token: 0x02000B73 RID: 2931
	public sealed class 1275
	{
		// Token: 0x060050F3 RID: 20723 RVA: 0x00200D90 File Offset: 0x001FEF90
		internal void 1(1648 1)
		{
			1.Write(1296.11);
			1.Write(1272.12);
			1.Write(1272.22);
			1.1(1272.23);
			1.Write(1304.189);
			1.2<1262>(this.1);
			1.Write(1272.24);
			1287.1(1);
		}

		// Token: 0x04003D74 RID: 15732
		public List<1262> 1;
	}

	// Token: 0x02000B74 RID: 2932
	public sealed class 1278
	{
		// Token: 0x060050F5 RID: 20725 RVA: 0x00200DF6 File Offset: 0x001FEFF6
		internal bool 1(1262 1)
		{
			return 1.44() == this.1;
		}

		// Token: 0x04003D75 RID: 15733
		public string 1;
	}

	// Token: 0x02000B75 RID: 2933
	public sealed class 1277
	{
		// Token: 0x04003D76 RID: 15734
		public string 1;
	}

	// Token: 0x02000B76 RID: 2934
	public sealed class 1279
	{
		// Token: 0x060050F8 RID: 20728 RVA: 0x00200E09 File Offset: 0x001FF009
		internal bool 1(1262 1)
		{
			return 1.37 == this.1.37;
		}

		// Token: 0x04003D77 RID: 15735
		public 1262 1;
	}

	// Token: 0x02000B77 RID: 2935
	public sealed class 1280
	{
		// Token: 0x04003D78 RID: 15736
		public int 1;
	}

	// Token: 0x02000B78 RID: 2936
	public sealed class 1276
	{
		// Token: 0x04003D79 RID: 15737
		public int 1;
	}

	// Token: 0x02000B79 RID: 2937
	// (Invoke) Token: 0x060050FD RID: 20733
	public delegate void 1273(object 1, List<1262> 2);

	// Token: 0x02000B7A RID: 2938
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x04003D7A RID: 15738
		public static Action<1271> <0>__RemoveFolderBeatmaps;

		// Token: 0x04003D7B RID: 15739
		public static FileSystemEventHandler <1>__OnFileSystemChanged;

		// Token: 0x04003D7C RID: 15740
		public static RenamedEventHandler <2>__OnFileSystemChanged;
	}
}
