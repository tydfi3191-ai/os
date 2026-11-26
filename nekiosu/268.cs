using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

// Token: 0x020003E3 RID: 995
public static class 268
{
	// Token: 0x17000219 RID: 537
	// (get) Token: 0x06001F45 RID: 8005 RVA: 0x0007BB3C File Offset: 0x00079D3C
	// (set) Token: 0x06001F46 RID: 8006 RVA: 0x0007BB43 File Offset: 0x00079D43
	public static string ExecutableDirectory { get; private set; }

	// Token: 0x1700021A RID: 538
	// (get) Token: 0x06001F47 RID: 8007 RVA: 0x0007BB4B File Offset: 0x00079D4B
	// (set) Token: 0x06001F48 RID: 8008 RVA: 0x0007BB52 File Offset: 0x00079D52
	public static string InstallDirectory { get; private set; }

	// Token: 0x1700021B RID: 539
	// (get) Token: 0x06001F49 RID: 8009 RVA: 0x0007BB5A File Offset: 0x00079D5A
	// (set) Token: 0x06001F4A RID: 8010 RVA: 0x0007BB61 File Offset: 0x00079D61
	public static string DataDirectory { get; private set; }

	// Token: 0x1700021C RID: 540
	// (get) Token: 0x06001F4B RID: 8011 RVA: 0x0007BB69 File Offset: 0x00079D69
	public static bool HasOwnDataDirectory
	{
		get
		{
			return 268.DataDirectory != null && !string.Equals(268.DataDirectory, 268.InstallDirectory, StringComparison.OrdinalIgnoreCase);
		}
	}

	// Token: 0x1700021D RID: 541
	// (get) Token: 0x06001F4C RID: 8012 RVA: 0x0007BB87 File Offset: 0x00079D87
	public static string PicturesDirectory
	{
		get
		{
			if (!268.HasOwnDataDirectory)
			{
				return Path.Combine(268.InstallDirectory, "Data", "profiles");
			}
			return Path.Combine(268.DataDirectory, "profiles");
		}
	}

	// Token: 0x1700021E RID: 542
	// (get) Token: 0x06001F4D RID: 8013 RVA: 0x0007BBB4 File Offset: 0x00079DB4
	public static string CacheDirectory
	{
		get
		{
			if (!268.HasOwnDataDirectory)
			{
				return Path.Combine(268.InstallDirectory, "Data", "nekiosu");
			}
			return Path.Combine(268.DataDirectory, "cache");
		}
	}

	// Token: 0x1700021F RID: 543
	// (get) Token: 0x06001F4E RID: 8014 RVA: 0x0007BBE4 File Offset: 0x00079DE4
	public static string LogDirectory
	{
		get
		{
			if (268.HasOwnDataDirectory)
			{
				return Path.Combine(268.DataDirectory, "Logs");
			}
			if (!268.SharesStableInstall)
			{
				return Path.Combine(268.InstallDirectory, "Logs");
			}
			return Path.Combine(268.InstallDirectory, "Logs", "nekiosu");
		}
	}

	// Token: 0x06001F4F RID: 8015 RVA: 0x0007BC33 File Offset: 0x00079E33
	public static string 1(string 1)
	{
		return 268.3(268.DataDirectory ?? 268.InstallDirectory, 268.9(1));
	}

	// Token: 0x06001F50 RID: 8016 RVA: 0x0007BC4E File Offset: 0x00079E4E
	public static string 2(string 1)
	{
		string text;
		if ((text = 268.DataDirectory) == null)
		{
			text = (268.InstallDirectory ?? AppDomain.CurrentDomain.BaseDirectory);
		}
		return 268.3(text, 1);
	}

	// Token: 0x17000220 RID: 544
	// (get) Token: 0x06001F51 RID: 8017 RVA: 0x0007BC72 File Offset: 0x00079E72
	public static string BackupDirectory
	{
		get
		{
			if (!268.HasOwnDataDirectory)
			{
				return null;
			}
			return Path.Combine(268.DataDirectory, "backups");
		}
	}

	// Token: 0x06001F52 RID: 8018 RVA: 0x0007BC8C File Offset: 0x00079E8C
	private static string 3(string 1, string 2)
	{
		string text = 268.HasOwnDataDirectory ? 268.4(2) : null;
		if (text != null)
		{
			return Path.Combine(1, text, 2);
		}
		return Path.Combine(1, 2);
	}

	// Token: 0x06001F53 RID: 8019 RVA: 0x0007BCC0 File Offset: 0x00079EC0
	private static string 4(string 1)
	{
		string text = 1.ToLowerInvariant();
		if (text.EndsWith(".cfg") || text.EndsWith(".ini") || text == "nekiosu.hitsounds.json" || text == "nekiosu.gamma.json" || text == "nekiosu.scoreembed.json")
		{
			return "config";
		}
		if (text.EndsWith(".db") || text == "nekiosu.sync" || text == "replays.pending" || text == "nekiosu.checkpoints")
		{
			return "databases";
		}
		if (text == "nekiosu.profile" || text == "nekiosu.peaks.json" || text == "nekiosu.recent.json" || text == "nekiosu.id")
		{
			return "stats";
		}
		if (text == "nekiosu.discord-maps.json")
		{
			return "cache";
		}
		return null;
	}

	// Token: 0x06001F54 RID: 8020 RVA: 0x0007BDA4 File Offset: 0x00079FA4
	private static void 5()
	{
		try
		{
			foreach (string path in 268.6)
			{
				Directory.CreateDirectory(Path.Combine(268.DataDirectory, path));
			}
			Directory.CreateDirectory(268.BackupDirectory);
			foreach (string text in Directory.GetFiles(268.DataDirectory))
			{
				string fileName = Path.GetFileName(text);
				bool flag = fileName.EndsWith(".backup", StringComparison.OrdinalIgnoreCase) || fileName.EndsWith(".bak", StringComparison.OrdinalIgnoreCase);
				string text2 = flag ? "backups" : 268.4(fileName);
				if (text2 != null)
				{
					string text3 = Path.Combine(268.DataDirectory, text2, fileName);
					try
					{
						if (!File.Exists(text3))
						{
							File.Move(text, text3);
						}
						else if (flag)
						{
							File.Delete(text);
						}
					}
					catch (Exception)
					{
					}
				}
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x17000221 RID: 545
	// (get) Token: 0x06001F55 RID: 8021 RVA: 0x0007BE9C File Offset: 0x0007A09C
	public static string UsageId
	{
		get
		{
			if (268.7 != null)
			{
				return 268.7;
			}
			string text = 268.HasOwnDataDirectory ? 268.DataDirectory : (268.10(268.ExecutableDirectory) ? 268.ExecutableDirectory : Path.Combine(268.ExecutableDirectory, "data"));
			string text2 = Path.Combine(text, "nekiosu.id");
			string result;
			try
			{
				if (!string.Equals(text, 268.ExecutableDirectory, StringComparison.OrdinalIgnoreCase))
				{
					string text3 = text2;
					text = Path.Combine(text, "stats");
					text2 = Path.Combine(text, "nekiosu.id");
					if (File.Exists(text3) && !File.Exists(text2))
					{
						Directory.CreateDirectory(text);
						File.Move(text3, text2);
					}
				}
				if (File.Exists(text2))
				{
					foreach (string text4 in File.ReadAllLines(text2))
					{
						if (268.6(text4.Trim()))
						{
							return 268.7 = text4.Trim();
						}
					}
				}
				string item = Guid.NewGuid().ToString("N");
				Directory.CreateDirectory(text);
				List<string> contents = new List<string>(268.9)
				{
					item
				};
				File.WriteAllLines(text2, contents);
				result = (268.7 = item);
			}
			catch (Exception)
			{
				result = (268.7 = string.Empty);
			}
			return result;
		}
	}

	// Token: 0x06001F56 RID: 8022 RVA: 0x0007BFE8 File Offset: 0x0007A1E8
	public static bool 6(string 1)
	{
		return 1 != null && Regex.IsMatch(1, "^[0-9a-f]{32}$");
	}

	// Token: 0x17000222 RID: 546
	// (get) Token: 0x06001F57 RID: 8023 RVA: 0x0007BFFA File Offset: 0x0007A1FA
	// (set) Token: 0x06001F58 RID: 8024 RVA: 0x0007C001 File Offset: 0x0007A201
	public static bool SharesStableInstall { get; private set; }

	// Token: 0x06001F59 RID: 8025
	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern bool SetDllDirectory(string 1);

	// Token: 0x06001F5A RID: 8026 RVA: 0x0007C00C File Offset: 0x0007A20C
	public static void 7()
	{
		268.ExecutableDirectory = Path.GetDirectoryName(Path.GetFullPath(typeof(268).Assembly.Location));
		AppDomain currentDomain = AppDomain.CurrentDomain;
		ResolveEventHandler value;
		if ((value = 268.<>O.<0>__ResolveLibrary) == null)
		{
			value = (268.<>O.<0>__ResolveLibrary = new ResolveEventHandler(268.30));
		}
		currentDomain.AssemblyResolve += value;
		268.InstallDirectory = 268.ExecutableDirectory;
		268.DataDirectory = 268.ExecutableDirectory;
		273.7();
		if (261.IsContained)
		{
			return;
		}
		bool flag = 268.11().Length > 1;
		if (Environment.GetEnvironmentVariable("OSU_OFFLINE_SMOKE") != "1" && !272.1(268.ExecutableDirectory, flag ? 0 : 1000) && !flag)
		{
			272.6();
			Environment.Exit(0);
		}
		273.6();
		string text = Path.Combine(268.ExecutableDirectory, "nekiosu.ini");
		string text2 = 268.16(text, "OsuFolder");
		261.FullyOffline = string.Equals(268.16(text, "FullyOffline"), "true", StringComparison.OrdinalIgnoreCase);
		string text3 = null;
		string text4 = null;
		if (text2 != null)
		{
			if (268.10(text2))
			{
				text3 = text2;
			}
			else
			{
				text4 = "The osu! folder that was set could not be found.";
			}
		}
		else if (268.10(268.ExecutableDirectory))
		{
			text3 = 268.ExecutableDirectory;
		}
		bool flag2 = Environment.GetEnvironmentVariable("OSU_OFFLINE_SMOKE") == "1" || (268.11().Length > 1 && 268.18());
		bool flag3 = string.Equals(268.16(text, "SkipLauncher"), "true", StringComparison.OrdinalIgnoreCase);
		bool flag4 = false;
		if (text3 != null && !flag2 && flag3 && !268.12())
		{
			273.275 <<EMPTY_NAME>> = 268.13();
			if (<<EMPTY_NAME>> != null && (<<EMPTY_NAME>>.2 || <<EMPTY_NAME>>.3))
			{
				flag4 = true;
			}
			else if (<<EMPTY_NAME>> != null && <<EMPTY_NAME>>.1 != null)
			{
				268.14();
				if (!252.16(<<EMPTY_NAME>>.1))
				{
					Environment.Exit(0);
				}
				flag2 = true;
			}
			else
			{
				flag2 = true;
			}
		}
		if (text3 == null || !flag2)
		{
			if (text2 == null)
			{
				string text5 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "osu!");
				text2 = (268.10(text5) ? text5 : null);
			}
			258 2 = 268.15(text3 ?? text2, text4, flag3, flag4);
			if (2 == null)
			{
				Environment.Exit(0);
			}
			268.17(text, 2);
			261.FullyOffline = 2.2;
			text3 = 2.1;
		}
		268.InstallDirectory = Path.GetFullPath(text3).TrimEnd(new char[]
		{
			'\\',
			'/'
		});
		268.SharesStableInstall = File.Exists(Path.Combine(268.InstallDirectory, "osu!.exe"));
		268.DataDirectory = (string.Equals(268.InstallDirectory, 268.ExecutableDirectory, StringComparison.OrdinalIgnoreCase) ? 268.InstallDirectory : Path.Combine(268.ExecutableDirectory, "data"));
		if (268.HasOwnDataDirectory)
		{
			Directory.CreateDirectory(268.DataDirectory);
			268.5();
			268.19();
		}
		if (!string.Equals(268.InstallDirectory, 268.ExecutableDirectory, StringComparison.OrdinalIgnoreCase))
		{
			268.SetDllDirectory(268.InstallDirectory);
		}
		268.21();
		268.8();
	}

	// Token: 0x06001F5B RID: 8027 RVA: 0x0007C2F0 File Offset: 0x0007A4F0
	private static void 8()
	{
		string text = 268.1("osu!." + 268.23(Environment.UserName) + ".cfg");
		if (268.16(text, "LowLatencyAudio") == "1" && 268.16(text, "AudioCompatibility") != "1")
		{
			1219.29();
		}
	}

	// Token: 0x06001F5C RID: 8028 RVA: 0x0007C350 File Offset: 0x0007A550
	public static string 9(string 1)
	{
		string result;
		if (268.4.TryGetValue(1, out result))
		{
			return result;
		}
		if (1.StartsWith("osu!.", StringComparison.OrdinalIgnoreCase) && 1.EndsWith(".cfg", StringComparison.OrdinalIgnoreCase))
		{
			return "nekiosu." + 1.Substring(5);
		}
		return 1;
	}

	// Token: 0x06001F5D RID: 8029 RVA: 0x0007C3A0 File Offset: 0x0007A5A0
	private static bool 10(string 1)
	{
		bool result;
		try
		{
			if (string.IsNullOrEmpty(1) || !Directory.Exists(1))
			{
				result = false;
			}
			else
			{
				bool flag = File.Exists(Path.Combine(1, "osu!.exe")) || File.Exists(Path.Combine(1, "osu!.db")) || File.Exists(Path.Combine(1, "osu!.nekiosu.db"));
				foreach (string path in 268.3)
				{
					if (!File.Exists(Path.Combine(1, path)) && !File.Exists(Path.Combine(268.ExecutableDirectory, path)))
					{
						return false;
					}
				}
				result = flag;
			}
		}
		catch (Exception)
		{
			result = false;
		}
		return result;
	}

	// Token: 0x06001F5E RID: 8030 RVA: 0x0007C458 File Offset: 0x0007A658
	internal static string[] 11()
	{
		List<string> list = new List<string>();
		foreach (string text in Environment.GetCommandLineArgs())
		{
			if (!string.Equals(text, "--launcher", StringComparison.OrdinalIgnoreCase))
			{
				list.Add(text);
			}
		}
		return list.ToArray();
	}

	// Token: 0x06001F5F RID: 8031
	[DllImport("user32.dll")]
	private static extern short GetAsyncKeyState(int 1);

	// Token: 0x06001F60 RID: 8032 RVA: 0x0007C4A0 File Offset: 0x0007A6A0
	private static bool 12()
	{
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		for (int i = 0; i < commandLineArgs.Length; i++)
		{
			if (string.Equals(commandLineArgs[i], "--launcher", StringComparison.OrdinalIgnoreCase))
			{
				return true;
			}
		}
		try
		{
			if (((int)268.GetAsyncKeyState(16) & 32768) != 0)
			{
				return true;
			}
		}
		catch (Exception)
		{
		}
		return (Control.ModifierKeys & Keys.Shift) > Keys.None;
	}

	// Token: 0x06001F61 RID: 8033 RVA: 0x0007C50C File Offset: 0x0007A70C
	private static 273.275 13()
	{
		if (261.FullyOffline || !273.2())
		{
			return null;
		}
		273.275 result;
		try
		{
			result = 273.1(268.UsageId);
		}
		catch (Exception)
		{
			result = null;
		}
		return result;
	}

	// Token: 0x06001F62 RID: 8034 RVA: 0x0007C550 File Offset: 0x0007A750
	private static void 14()
	{
		try
		{
			Application.SetCompatibleTextRenderingDefault(false);
		}
		catch (InvalidOperationException)
		{
		}
		Application.EnableVisualStyles();
	}

	// Token: 0x06001F63 RID: 8035 RVA: 0x0007C580 File Offset: 0x0007A780
	private static 258 15(string 1, string 2, bool 3, bool 4)
	{
		268.14();
		string text = "v1.1.8";
		bool fullyOffline = 261.FullyOffline;
		string text2 = text;
		Func<string, bool> func;
		if ((func = 268.<>O.<1>__IsGameFolder) == null)
		{
			func = (268.<>O.<1>__IsGameFolder = new Func<string, bool>(268.10));
		}
		258 choice;
		using (252 5 = new 252(1, fullyOffline, 3, 4, 2, text2, func))
		{
			Application.Run(5);
			choice = 5.Choice;
		}
		return choice;
	}

	// Token: 0x06001F64 RID: 8036 RVA: 0x0007C5F0 File Offset: 0x0007A7F0
	private static string 16(string 1, string 2)
	{
		try
		{
			if (!File.Exists(1))
			{
				return null;
			}
			foreach (string text in File.ReadAllLines(1, Encoding.UTF8))
			{
				int num = text.IndexOf('=');
				if (num > 0 && !text.TrimStart(Array.Empty<char>()).StartsWith("#", StringComparison.Ordinal) && text.Substring(0, num).Trim().Equals(2, StringComparison.OrdinalIgnoreCase))
				{
					string text2 = text.Substring(num + 1).Trim();
					return (text2.Length > 0) ? text2 : null;
				}
			}
		}
		catch (Exception)
		{
		}
		return null;
	}

	// Token: 0x06001F65 RID: 8037 RVA: 0x0007C6A4 File Offset: 0x0007A8A4
	private static void 17(string 1, 258 2)
	{
		try
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("OsuFolder = ").Append(2.1 ?? string.Empty).Append("\r\n");
			stringBuilder.Append("FullyOffline = ").Append(2.2 ? "true" : "false").Append("\r\n");
			stringBuilder.Append("SkipLauncher = ").Append(2.3 ? "true" : "false").Append("\r\n");
			File.WriteAllText(1, stringBuilder.ToString(), Encoding.UTF8);
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06001F66 RID: 8038 RVA: 0x0007C768 File Offset: 0x0007A968
	internal static bool 18()
	{
		bool result;
		try
		{
			using (Process currentProcess = Process.GetCurrentProcess())
			{
				Process[] processesByName = Process.GetProcessesByName(currentProcess.ProcessName);
				Process[] array = processesByName;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].Dispose();
				}
				result = (processesByName.Length > 1);
			}
		}
		catch (Exception)
		{
			result = false;
		}
		return result;
	}

	// Token: 0x06001F67 RID: 8039 RVA: 0x0007C7D8 File Offset: 0x0007A9D8
	private static void 19()
	{
		List<string> list = new List<string>(268.4.Values)
		{
			"nekiosu.profile",
			"nekiosu.hud.ini",
			"nekiosu.sync"
		};
		try
		{
			foreach (string path in Directory.GetFiles(268.InstallDirectory, "nekiosu.*.cfg"))
			{
				list.Add(Path.GetFileName(path));
			}
		}
		catch (Exception)
		{
		}
		foreach (string path2 in list)
		{
			268.20(Path.Combine(268.InstallDirectory, path2), 268.3(268.DataDirectory, path2), false);
		}
		268.20(Path.Combine(268.InstallDirectory, "Data", "profiles"), 268.PicturesDirectory, true);
		268.20(Path.Combine(268.InstallDirectory, "Data", "nekiosu"), 268.CacheDirectory, true);
		268.20(Path.Combine(268.InstallDirectory, "Logs", "nekiosu"), 268.LogDirectory, true);
	}

	// Token: 0x06001F68 RID: 8040 RVA: 0x0007C90C File Offset: 0x0007AB0C
	private static void 20(string 1, string 2, bool 3)
	{
		try
		{
			if (3 ? (Directory.Exists(1) && !Directory.Exists(2)) : (File.Exists(1) && !File.Exists(2)))
			{
				if (3)
				{
					Directory.Move(1, 2);
				}
				else
				{
					File.Move(1, 2);
				}
			}
		}
		catch (Exception)
		{
			try
			{
				if (!3 && File.Exists(1) && !File.Exists(2))
				{
					File.Copy(1, 2);
				}
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x06001F69 RID: 8041 RVA: 0x0007C99C File Offset: 0x0007AB9C
	private static void 21()
	{
		foreach (string path in new List<string>(268.4.Keys)
		{
			"osu!." + 268.23(Environment.UserName) + ".cfg"
		})
		{
			string text = Path.Combine(268.InstallDirectory, path);
			string text2 = 268.1(path);
			try
			{
				if (!File.Exists(text2) && File.Exists(text))
				{
					File.Copy(text, text2);
					268.29(path, File.GetLastWriteTimeUtc(text).Ticks);
				}
			}
			catch (Exception)
			{
			}
		}
		if (!268.HasOwnDataDirectory)
		{
			268.22();
		}
	}

	// Token: 0x06001F6A RID: 8042 RVA: 0x0007CA6C File Offset: 0x0007AC6C
	private static void 22()
	{
		try
		{
			string directoryName = Path.GetDirectoryName(Path.GetFullPath(268.1("osu!.db")));
			string text = Path.Combine(directoryName, "backups");
			foreach (string searchPattern in new string[]
			{
				"*.backup",
				"*.bak"
			})
			{
				foreach (string text2 in Directory.GetFiles(directoryName, searchPattern))
				{
					if (Path.GetFileName(text2).IndexOf("nekiosu", StringComparison.OrdinalIgnoreCase) >= 0)
					{
						try
						{
							Directory.CreateDirectory(text);
							string text3 = Path.Combine(text, Path.GetFileName(text2));
							if (File.Exists(text3))
							{
								File.Delete(text2);
							}
							else
							{
								File.Move(text2, text3);
							}
						}
						catch (Exception)
						{
						}
					}
				}
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06001F6B RID: 8043 RVA: 0x0007CB58 File Offset: 0x0007AD58
	private static string 23(string 1)
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (char c in 1 ?? string.Empty)
		{
			if (c != '.' && Array.IndexOf<char>(Path.GetInvalidFileNameChars(), c) < 0)
			{
				stringBuilder.Append(c);
			}
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06001F6C RID: 8044 RVA: 0x0007CBB0 File Offset: 0x0007ADB0
	public static string 24(string 1)
	{
		string text = Path.Combine(268.InstallDirectory, 1);
		string result;
		try
		{
			if (!File.Exists(text))
			{
				result = null;
			}
			else
			{
				result = ((File.GetLastWriteTimeUtc(text).Ticks != 268.28(1)) ? text : null);
			}
		}
		catch (Exception)
		{
			result = null;
		}
		return result;
	}

	// Token: 0x06001F6D RID: 8045 RVA: 0x0007CC08 File Offset: 0x0007AE08
	public static string 25(string 1)
	{
		string result;
		try
		{
			string text = Path.Combine(268.InstallDirectory, 1);
			result = ((File.Exists(text) && !string.Equals(Path.GetFullPath(text), Path.GetFullPath(268.1(1)), StringComparison.OrdinalIgnoreCase)) ? text : null);
		}
		catch (Exception)
		{
			result = null;
		}
		return result;
	}

	// Token: 0x06001F6E RID: 8046 RVA: 0x0007CC60 File Offset: 0x0007AE60
	public static void 26(string 1)
	{
		try
		{
			string path = Path.Combine(268.InstallDirectory, 1);
			if (File.Exists(path))
			{
				268.29(1, File.GetLastWriteTimeUtc(path).Ticks);
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06001F6F RID: 8047 RVA: 0x0007CCAC File Offset: 0x0007AEAC
	private static Dictionary<string, long> 27()
	{
		Dictionary<string, long> dictionary = new Dictionary<string, long>(StringComparer.OrdinalIgnoreCase);
		try
		{
			string path = 268.2("nekiosu.sync");
			if (File.Exists(path))
			{
				foreach (string text in File.ReadAllLines(path))
				{
					int num = text.LastIndexOf('=');
					long value;
					if (num > 0 && long.TryParse(text.Substring(num + 1), out value))
					{
						dictionary[text.Substring(0, num)] = value;
					}
				}
			}
		}
		catch (Exception)
		{
		}
		return dictionary;
	}

	// Token: 0x06001F70 RID: 8048 RVA: 0x0007CD40 File Offset: 0x0007AF40
	private static long 28(string 1)
	{
		long result;
		if (!268.27().TryGetValue(1, out result))
		{
			return 0L;
		}
		return result;
	}

	// Token: 0x06001F71 RID: 8049 RVA: 0x0007CD60 File Offset: 0x0007AF60
	private static void 29(string 1, long 2)
	{
		Dictionary<string, long> dictionary = 268.27();
		dictionary[1] = 2;
		StringBuilder stringBuilder = new StringBuilder();
		foreach (KeyValuePair<string, long> keyValuePair in dictionary)
		{
			stringBuilder.Append(keyValuePair.Key).Append('=').Append(keyValuePair.Value).Append("\r\n");
		}
		File.WriteAllText(268.2("nekiosu.sync"), stringBuilder.ToString());
	}

	// Token: 0x06001F72 RID: 8050 RVA: 0x0007CDFC File Offset: 0x0007AFFC
	private static Assembly 30(object 1, ResolveEventArgs 2)
	{
		string name = new AssemblyName(2.Name).Name;
		if (name.IndexOf("auth", StringComparison.OrdinalIgnoreCase) >= 0 || string.IsNullOrEmpty(268.InstallDirectory))
		{
			return null;
		}
		Dictionary<string, Assembly> obj = 268.5;
		Assembly result;
		lock (obj)
		{
			Assembly assembly;
			if (268.5.TryGetValue(name, out assembly))
			{
				result = assembly;
			}
			else
			{
				string text = Path.Combine(268.InstallDirectory, name + ".dll");
				if (!File.Exists(text))
				{
					result = null;
				}
				else
				{
					Assembly assembly2 = Assembly.UnsafeLoadFrom(text);
					268.5[name] = assembly2;
					result = assembly2;
				}
			}
		}
		return result;
	}

	// Token: 0x04001032 RID: 4146
	private const string 1 = "nekiosu.ini";

	// Token: 0x04001033 RID: 4147
	private const string 2 = "nekiosu.sync";

	// Token: 0x04001034 RID: 4148
	private static readonly string[] 3 = new string[]
	{
		"OpenTK.dll",
		"osu!ui.dll",
		"osu!gameplay.dll",
		"bass.dll"
	};

	// Token: 0x04001035 RID: 4149
	private static readonly Dictionary<string, string> 4 = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
	{
		{
			"osu!.db",
			"osu!.nekiosu.db"
		},
		{
			"scores.db",
			"scores.nekiosu.db"
		},
		{
			"collection.db",
			"collection.nekiosu.db"
		},
		{
			"presence.db",
			"presence.nekiosu.db"
		},
		{
			"osu!.cfg",
			"nekiosu.cfg"
		}
	};

	// Token: 0x04001036 RID: 4150
	private static readonly Dictionary<string, Assembly> 5 = new Dictionary<string, Assembly>(StringComparer.OrdinalIgnoreCase);

	// Token: 0x0400103A RID: 4154
	private static readonly string[] 6 = new string[]
	{
		"config",
		"databases",
		"stats",
		"cache"
	};

	// Token: 0x0400103B RID: 4155
	private static string 7;

	// Token: 0x0400103C RID: 4156
	public const string 8 = "nekiosu.id";

	// Token: 0x0400103D RID: 4157
	private static readonly string[] 9 = new string[]
	{
		"# nekiosu usage statistics",
		"#",
		"# nekiosu uses a randomly generated and anonymous installation ID",
		"# to count active installations and game versions.",
		"#",
		"# No account, hardware fingerprint, or gameplay",
		"# activity is collected for analytics.",
		"#",
		"# This ID is deleted when you uninstall nekiosu.",
		string.Empty
	};

	// Token: 0x0400103F RID: 4159
	internal const string 10 = "--launcher";

	// Token: 0x020003E4 RID: 996
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x04001040 RID: 4160
		public static ResolveEventHandler <0>__ResolveLibrary;

		// Token: 0x04001041 RID: 4161
		public static Func<string, bool> <1>__IsGameFolder;
	}
}
