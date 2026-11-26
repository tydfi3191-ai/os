using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

// Token: 0x020003F9 RID: 1017
public static class 261
{
	// Token: 0x17000225 RID: 549
	// (get) Token: 0x06001FE7 RID: 8167 RVA: 0x0008596A File Offset: 0x00083B6A
	// (set) Token: 0x06001FE8 RID: 8168 RVA: 0x00085971 File Offset: 0x00083B71
	public static string VisibleGameRoot { get; private set; }

	// Token: 0x17000226 RID: 550
	// (get) Token: 0x06001FE9 RID: 8169 RVA: 0x00085979 File Offset: 0x00083B79
	public static bool IsContained
	{
		get
		{
			return 261.3;
		}
	}

	// Token: 0x17000227 RID: 551
	// (get) Token: 0x06001FEA RID: 8170 RVA: 0x00085980 File Offset: 0x00083B80
	// (set) Token: 0x06001FEB RID: 8171 RVA: 0x00085987 File Offset: 0x00083B87
	public static bool FullyOffline { get; set; }

	// Token: 0x06001FEC RID: 8172 RVA: 0x00085990 File Offset: 0x00083B90
	public static void 1()
	{
		261.3 = 261.4();
		string[] array = new string[]
		{
			"http://",
			"https://",
			"ftp://"
		};
		for (int i = 0; i < array.Length; i++)
		{
			if (!WebRequest.RegisterPrefix(array[i], new 261.262()))
			{
				throw new SecurityException("Unable to install the offline HTTP boundary.");
			}
		}
		261.1 = Path.Combine(Environment.CurrentDirectory, ".offline-local");
		261.2 = Path.GetFullPath(Environment.CurrentDirectory).TrimEnd(new char[]
		{
			'\\',
			'/'
		});
		string path = Path.Combine(261.1, "visible-game-root.txt");
		261.VisibleGameRoot = (File.Exists(path) ? Path.GetFullPath(File.ReadAllText(path, Encoding.UTF8).Trim()).TrimEnd(new char[]
		{
			'\\',
			'/'
		}) : 261.2);
	}

	// Token: 0x06001FED RID: 8173 RVA: 0x00085A74 File Offset: 0x00083C74
	public static string 2(string 1)
	{
		if (string.IsNullOrEmpty(1) || string.IsNullOrEmpty(261.2) || string.IsNullOrEmpty(261.VisibleGameRoot))
		{
			return 1;
		}
		1 = 261.3(1, 261.2, 261.VisibleGameRoot);
		return 261.3(1, 261.2.Replace('\\', '/'), 261.VisibleGameRoot.Replace('\\', '/'));
	}

	// Token: 0x06001FEE RID: 8174 RVA: 0x00085AD8 File Offset: 0x00083CD8
	private static string 3(string 1, string 2, string 3)
	{
		StringBuilder stringBuilder = new StringBuilder();
		int num = 0;
		int num2;
		while ((num2 = 1.IndexOf(2, num, StringComparison.OrdinalIgnoreCase)) >= 0)
		{
			int num3 = num2 + 2.Length;
			bool flag = num3 == 1.Length || 1[num3] == '\\' || 1[num3] == '/' || char.IsWhiteSpace(1[num3]) || 1[num3] == '"' || 1[num3] == '\'';
			stringBuilder.Append(1, num, num2 - num);
			stringBuilder.Append(flag ? 3 : 1.Substring(num2, 2.Length));
			num = num3;
		}
		stringBuilder.Append(1, num, 1.Length - num);
		return stringBuilder.ToString();
	}

	// Token: 0x06001FEF RID: 8175 RVA: 0x00085B94 File Offset: 0x00083D94
	private static bool 4()
	{
		bool result;
		try
		{
			IntPtr intPtr;
			if (!260.OpenProcessToken(260.GetCurrentProcess(), 8U, out intPtr))
			{
				result = false;
			}
			else
			{
				try
				{
					result = (261.7(intPtr, 29) == 1);
				}
				finally
				{
					260.CloseHandle(intPtr);
				}
			}
		}
		catch (Exception)
		{
			result = false;
		}
		return result;
	}

	// Token: 0x06001FF0 RID: 8176 RVA: 0x00085BF0 File Offset: 0x00083DF0
	public static void 5(IntPtr 1, bool 2 = true)
	{
		IntPtr intPtr;
		if (!260.OpenProcessToken(1, 8U, out intPtr))
		{
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}
		try
		{
			if (261.7(intPtr, 29) != 1)
			{
				throw new SecurityException("Run with OfflineLauncher.exe. Uncontained launches are refused.");
			}
			if (261.7(intPtr, 30) != 0)
			{
				throw new SecurityException("The offline container must have zero capabilities.");
			}
			if (2)
			{
				IntPtr intPtr2 = 261.6(intPtr, 31);
				try
				{
					261.8(Marshal.ReadIntPtr(intPtr2));
				}
				finally
				{
					Marshal.FreeHGlobal(intPtr2);
				}
			}
		}
		finally
		{
			260.CloseHandle(intPtr);
		}
	}

	// Token: 0x06001FF1 RID: 8177 RVA: 0x00085C88 File Offset: 0x00083E88
	private static IntPtr 6(IntPtr 1, int 2)
	{
		int num;
		260.GetTokenInformation(1, 2, IntPtr.Zero, 0, out num);
		if (num < 4 || num > 1048576)
		{
			throw new SecurityException("Unable to verify the offline process token.");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		if (!260.GetTokenInformation(1, 2, intPtr, num, out num))
		{
			int lastWin32Error = Marshal.GetLastWin32Error();
			Marshal.FreeHGlobal(intPtr);
			throw new Win32Exception(lastWin32Error);
		}
		return intPtr;
	}

	// Token: 0x06001FF2 RID: 8178 RVA: 0x00085CE4 File Offset: 0x00083EE4
	private static int 7(IntPtr 1, int 2)
	{
		IntPtr intPtr = 261.6(1, 2);
		int result;
		try
		{
			result = Marshal.ReadInt32(intPtr);
		}
		finally
		{
			Marshal.FreeHGlobal(intPtr);
		}
		return result;
	}

	// Token: 0x06001FF3 RID: 8179 RVA: 0x00085D1C File Offset: 0x00083F1C
	private static void 8(IntPtr 1)
	{
		uint num2;
		IntPtr ptr;
		uint num = 260.NetworkIsolationGetAppContainerConfig(out num2, out ptr);
		if (num != 0U)
		{
			throw new Win32Exception((int)num);
		}
		try
		{
			int num3 = (IntPtr.Size == 8) ? 16 : 8;
			for (uint num4 = 0U; num4 < num2; num4 += 1U)
			{
				if (260.EqualSid(1, Marshal.ReadIntPtr(ptr, checked((int)num4 * num3))))
				{
					throw new SecurityException("Loopback exemptions are forbidden for the offline container.");
				}
			}
		}
		finally
		{
			int num5 = (IntPtr.Size == 8) ? 16 : 8;
			for (uint num6 = 0U; num6 < num2; num6 += 1U)
			{
				260.HeapFree(260.GetProcessHeap(), 0U, Marshal.ReadIntPtr(ptr, checked((int)num6 * num5)));
			}
			260.HeapFree(260.GetProcessHeap(), 0U, ptr);
		}
	}

	// Token: 0x06001FF4 RID: 8180 RVA: 0x00085DD4 File Offset: 0x00083FD4
	public static void 9(string 1)
	{
		throw new WebException("Offline build: " + 1 + " is disabled.", WebExceptionStatus.RequestCanceled);
	}

	// Token: 0x06001FF5 RID: 8181 RVA: 0x00085DEC File Offset: 0x00083FEC
	public static bool 10(string 1)
	{
		if (string.IsNullOrEmpty(1))
		{
			return false;
		}
		1 = 1.Trim().ToLowerInvariant();
		int num = 1.IndexOf("://", StringComparison.Ordinal);
		if (num >= 0)
		{
			1 = 1.Substring(num + 3);
		}
		int num2 = 1.IndexOfAny(new char[]
		{
			'/',
			'\\',
			'?',
			'#'
		});
		if (num2 >= 0)
		{
			1 = 1.Substring(0, num2);
		}
		int num3 = 1.LastIndexOf('@');
		if (num3 >= 0)
		{
			1 = 1.Substring(num3 + 1);
		}
		int num4 = 1.LastIndexOf(':');
		if (num4 >= 0 && 1.IndexOf(']') < num4)
		{
			1 = 1.Substring(0, num4);
		}
		1 = 1.TrimEnd(new char[]
		{
			'.'
		});
		return 1 == "ppy.sh" || 1.EndsWith(".ppy.sh", StringComparison.Ordinal);
	}

	// Token: 0x06001FF6 RID: 8182 RVA: 0x00085EBA File Offset: 0x000840BA
	public static void 11(string 1)
	{
		if (261.10(1))
		{
			throw new WebException("Offline build: ppy.sh hosts are permanently blocked.", WebExceptionStatus.RequestProhibitedByProxy);
		}
	}

	// Token: 0x06001FF7 RID: 8183 RVA: 0x00085ED1 File Offset: 0x000840D1
	public static void 12(Uri 1)
	{
		if (1 != null)
		{
			261.11(1.IsAbsoluteUri ? 1.Host : 1.OriginalString);
		}
	}

	// Token: 0x06001FF8 RID: 8184 RVA: 0x00085EF7 File Offset: 0x000840F7
	public static WebRequest 13(string 1)
	{
		261.11(1);
		261.9("network request");
		return null;
	}

	// Token: 0x06001FF9 RID: 8185 RVA: 0x00085F0A File Offset: 0x0008410A
	public static WebRequest 14(Uri 1)
	{
		261.12(1);
		261.9("network request");
		return null;
	}

	// Token: 0x06001FFA RID: 8186 RVA: 0x00085F1D File Offset: 0x0008411D
	public static IPAddress[] 15(string 1)
	{
		261.11(1);
		261.9("DNS lookup");
		return null;
	}

	// Token: 0x06001FFB RID: 8187 RVA: 0x00085F30 File Offset: 0x00084130
	public static Process Start(ProcessStartInfo 1)
	{
		261.9("external process or browser");
		return null;
	}

	// Token: 0x06001FFC RID: 8188 RVA: 0x00085F30 File Offset: 0x00084130
	public static Process Start(string 1)
	{
		261.9("external process or browser");
		return null;
	}

	// Token: 0x06001FFD RID: 8189 RVA: 0x00085F30 File Offset: 0x00084130
	public static Process Start(string 1, string 2)
	{
		261.9("external process or browser");
		return null;
	}

	// Token: 0x06001FFE RID: 8190 RVA: 0x00085F3D File Offset: 0x0008413D
	public static bool 16(Process 1)
	{
		261.9("external process or browser");
		return false;
	}

	// Token: 0x06001FFF RID: 8191 RVA: 0x00085F4A File Offset: 0x0008414A
	public static bool 17(string 1)
	{
		if (!261.3)
		{
			return 261.27(false, 1);
		}
		return 261.29("open", 1, true, out 1);
	}

	// Token: 0x06002000 RID: 8192 RVA: 0x00085F69 File Offset: 0x00084169
	public static bool 18(string 1)
	{
		if (!261.3)
		{
			return 261.27(false, 1);
		}
		return 261.29("reveal", 1, true, out 1);
	}

	// Token: 0x06002001 RID: 8193 RVA: 0x00085F88 File Offset: 0x00084188
	public static bool 19(string 1)
	{
		if (!261.3)
		{
			return 261.27(true, 1);
		}
		return 261.29("directory", 1, true, out 1);
	}

	// Token: 0x06002002 RID: 8194 RVA: 0x00085FA8 File Offset: 0x000841A8
	public static bool 20(IntPtr 1)
	{
		string text;
		return 261.3 && 261.29("drop-window", 1.ToInt64().ToString(CultureInfo.InvariantCulture), true, out text);
	}

	// Token: 0x06002003 RID: 8195 RVA: 0x00085FE0 File Offset: 0x000841E0
	public static bool 21(out bool 1)
	{
		if (!261.3)
		{
			1 = false;
			return true;
		}
		string a;
		bool flag = 261.29("refresh", "", true, out a);
		1 = (flag && a == "OK CHANGED");
		return flag;
	}

	// Token: 0x06002004 RID: 8196 RVA: 0x00086020 File Offset: 0x00084220
	public static bool 22(int 1, int 2, bool 3)
	{
		if (261.3 || (2 <= 0 && 1 <= 0))
		{
			return false;
		}
		bool result;
		try
		{
			string text = (2 > 0) ? 2.ToString(CultureInfo.InvariantCulture) : "";
			string text2 = (1 > 0) ? ("https://osu.ppy.sh/beatmapsets/" + 1.ToString(CultureInfo.InvariantCulture)) : null;
			string fileName = (2 > 0) ? ("https://osu.ppy.sh/beatmaps/" + text) : text2;
			if (3 && text2 != null)
			{
				fileName = text2 + "/discussion" + ((text.Length > 0) ? ("/" + text) : "");
			}
			Process.Start(new ProcessStartInfo(fileName)
			{
				UseShellExecute = true
			});
			result = true;
		}
		catch (Exception)
		{
			result = false;
		}
		return result;
	}

	// Token: 0x06002005 RID: 8197 RVA: 0x000860E4 File Offset: 0x000842E4
	public static bool 23(string 1)
	{
		return 1 != null && Regex.IsMatch(1, "\\Ahttps://(discord\\.gg|discord\\.com/invite)/[A-Za-z0-9-]{2,32}\\z");
	}

	// Token: 0x06002006 RID: 8198 RVA: 0x000860F8 File Offset: 0x000842F8
	public static bool 24(string 1)
	{
		if (261.3 || !261.23(1))
		{
			return false;
		}
		bool result;
		try
		{
			Process.Start(new ProcessStartInfo(1)
			{
				UseShellExecute = true
			});
			result = true;
		}
		catch (Exception)
		{
			result = false;
		}
		return result;
	}

	// Token: 0x06002007 RID: 8199 RVA: 0x00086144 File Offset: 0x00084344
	public static bool 25(string 1)
	{
		if (261.3 || Array.IndexOf<string>(261.5, 1) < 0)
		{
			return false;
		}
		bool result;
		try
		{
			Process.Start(new ProcessStartInfo("https://nekiosu.nekiak.com/tutorial#" + 1)
			{
				UseShellExecute = true
			});
			result = true;
		}
		catch (Exception)
		{
			result = false;
		}
		return result;
	}

	// Token: 0x06002008 RID: 8200 RVA: 0x000861A0 File Offset: 0x000843A0
	public static bool 26(string 1)
	{
		if (261.3 || string.IsNullOrEmpty(1) || 1.Length > 24)
		{
			return false;
		}
		foreach (char c in 1)
		{
			if (c < '0' || c > '9')
			{
				return false;
			}
		}
		bool result;
		try
		{
			Process.Start(new ProcessStartInfo("https://discord.com/oauth2/authorize?client_id=" + 1 + "&integration_type=1&scope=applications.commands")
			{
				UseShellExecute = true
			});
			result = true;
		}
		catch (Exception)
		{
			result = false;
		}
		return result;
	}

	// Token: 0x06002009 RID: 8201 RVA: 0x0008622C File Offset: 0x0008442C
	private static bool 27(bool 1, string 2)
	{
		bool result;
		try
		{
			if (string.IsNullOrEmpty(2) || 2.StartsWith("\\\\", StringComparison.Ordinal))
			{
				result = false;
			}
			else
			{
				string text = Path.GetFullPath(2).TrimEnd(new char[]
				{
					'\\',
					'/'
				});
				if (new DriveInfo(Path.GetPathRoot(text)).DriveType == DriveType.Network)
				{
					result = false;
				}
				else
				{
					bool flag = Directory.Exists(text);
					if (1 && !flag)
					{
						result = false;
					}
					else
					{
						if (!flag)
						{
							if (!File.Exists(text))
							{
								return false;
							}
							string value = Path.GetExtension(text).ToLowerInvariant();
							if (Array.IndexOf<string>(new string[]
							{
								".png",
								".jpg",
								".jpeg",
								".bmp",
								".gif",
								".osu",
								".osz",
								".osk",
								".osr",
								".txt",
								".log"
							}, value) < 0)
							{
								return false;
							}
						}
						Process.Start(new ProcessStartInfo(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Windows), "explorer.exe"), (flag ? "" : "/select,") + "\"" + text + "\"")
						{
							UseShellExecute = false
						});
						result = true;
					}
				}
			}
		}
		catch (Exception)
		{
			result = false;
		}
		return result;
	}

	// Token: 0x0600200A RID: 8202 RVA: 0x00086398 File Offset: 0x00084598
	public static bool 28(out string 1)
	{
		1 = null;
		if (!261.3 || 261.1 == null || !File.Exists(Path.Combine(261.1, "ready")))
		{
			return false;
		}
		string path = Path.Combine(261.1, "imports");
		if (!Directory.Exists(path))
		{
			return false;
		}
		foreach (string path2 in Directory.GetFiles(path, "*.import"))
		{
			try
			{
				string path3 = File.ReadAllText(path2, Encoding.UTF8).Trim();
				File.Delete(path2);
				string fullPath = Path.GetFullPath(path3);
				string value = Path.Combine(261.1, "staged") + Path.DirectorySeparatorChar.ToString();
				if (fullPath.StartsWith(value, StringComparison.OrdinalIgnoreCase) && File.Exists(fullPath))
				{
					string a = Path.GetExtension(fullPath).ToLowerInvariant();
					if (!(a != ".osu") || !(a != ".osz") || !(a != ".osk") || !(a != ".osr"))
					{
						1 = fullPath;
						return true;
					}
				}
			}
			catch (IOException)
			{
			}
			catch (UnauthorizedAccessException)
			{
			}
		}
		return false;
	}

	// Token: 0x0600200B RID: 8203 RVA: 0x000864E0 File Offset: 0x000846E0
	private static bool 29(string 1, string 2, bool 3, out string 4)
	{
		4 = null;
		if (261.1 == null || !File.Exists(Path.Combine(261.1, "ready")))
		{
			return false;
		}
		if (2 != null && 2.Length <= 8192)
		{
			char[] array = new char[3];
			array[0] = '\r';
			array[1] = '\n';
			if (2.IndexOfAny(array) < 0)
			{
				try
				{
					string str = Guid.NewGuid().ToString("N");
					string text = Path.Combine(261.1, "requests", str + ".request");
					string text2 = text + ".tmp";
					File.WriteAllText(text2, 1 + "\n" + 2, Encoding.UTF8);
					File.Move(text2, text);
					if (!3)
					{
						return true;
					}
					string path = Path.Combine(261.1, "responses", str + ".response");
					Stopwatch stopwatch = Stopwatch.StartNew();
					while (stopwatch.ElapsedMilliseconds < 8000L)
					{
						if (File.Exists(path))
						{
							4 = File.ReadAllText(path, Encoding.UTF8).Trim();
							File.Delete(path);
							return 4.StartsWith("OK", StringComparison.Ordinal);
						}
						Thread.Sleep(15);
					}
				}
				catch (IOException)
				{
				}
				catch (UnauthorizedAccessException)
				{
				}
				return false;
			}
		}
		return false;
	}

	// Token: 0x040010B8 RID: 4280
	private static string 1;

	// Token: 0x040010B9 RID: 4281
	private static string 2;

	// Token: 0x040010BA RID: 4282
	private static bool 3;

	// Token: 0x040010BD RID: 4285
	public const string 4 = "https://nekiosu.nekiak.com/tutorial";

	// Token: 0x040010BE RID: 4286
	private static readonly string[] 5 = new string[]
	{
		"osu-api",
		"discord-bot"
	};

	// Token: 0x020003FA RID: 1018
	private sealed class 262 : IWebRequestCreate
	{
		// Token: 0x0600200D RID: 8205 RVA: 0x00086649 File Offset: 0x00084849
		public WebRequest Create(Uri 1)
		{
			261.12(1);
			261.9("network request");
			return null;
		}
	}
}
