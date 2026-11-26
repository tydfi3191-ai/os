using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Threading;
using System.Windows.Forms;
using OpenTK.Graphics;

// Token: 0x0200040E RID: 1038
public static class 1345
{
	// Token: 0x06002080 RID: 8320 RVA: 0x00089B6B File Offset: 0x00087D6B
	internal static string 1()
	{
		string result;
		if ((result = 1345.3) == null)
		{
			result = (1345.3 = Application.ExecutablePath);
		}
		return result;
	}

	// Token: 0x06002081 RID: 8321 RVA: 0x00089B81 File Offset: 0x00087D81
	internal static string 2()
	{
		return Path.GetFileNameWithoutExtension(1345.1());
	}

	// Token: 0x06002082 RID: 8322 RVA: 0x00089B8D File Offset: 0x00087D8D
	internal static string 3()
	{
		return Path.GetFileName(1345.1());
	}

	// Token: 0x06002083 RID: 8323 RVA: 0x00089B99 File Offset: 0x00087D99
	internal static string 4()
	{
		if (1345.4 != null)
		{
			return 1345.4;
		}
		return 1345.4 = Path.GetDirectoryName(1345.1());
	}

	// Token: 0x06002084 RID: 8324 RVA: 0x00089BB8 File Offset: 0x00087DB8
	[STAThread]
	internal static void 5()
	{
		string location = typeof(269).Assembly.Location;
		1345.3 = location;
		1345.4 = (268.InstallDirectory ?? Path.GetDirectoryName(location));
		1345.8 = new string[]
		{
			location
		};
		1345.6 = false;
		Environment.CurrentDirectory = 1345.4;
		try
		{
			Application.SetCompatibleTextRenderingDefault(false);
		}
		catch (InvalidOperationException)
		{
		}
		Directory.CreateDirectory("Logs");
		Directory.CreateDirectory("Songs");
		Directory.CreateDirectory("Skins");
		string logDirectory = 268.LogDirectory;
		Directory.CreateDirectory(logDirectory);
		1338.1(logDirectory);
		1310.1 = (268.DataDirectory ?? 1345.4);
		string[] array = 268.11();
		string text = (array.Length > 1) ? string.Join(" ", array, 1, array.Length - 1) : null;
		if (text != null && 268.18())
		{
			1522.6(text);
			return;
		}
		if (Environment.GetEnvironmentVariable("OSU_OFFLINE_SMOKE") != "1")
		{
			252.6();
		}
		1345.9(text);
	}

	// Token: 0x06002085 RID: 8325 RVA: 0x00089CC8 File Offset: 0x00087EC8
	internal static void 6()
	{
		261.Start("osu!.exe", "-go");
		1345.16();
	}

	// Token: 0x06002086 RID: 8326 RVA: 0x00089CE0 File Offset: 0x00087EE0
	private static void 7(string[] 1)
	{
		string text = 1[0].Trim(new char[]
		{
			'"'
		});
		if (text.IndexOf(Path.DirectorySeparatorChar) >= 0)
		{
			1345.3 = text;
		}
		if (1.Length > 1)
		{
			bool flag;
			if (1345.8(1, out flag))
			{
				return;
			}
			if (flag)
			{
				1 = new string[0];
			}
		}
		string text2 = (1.Length > 1) ? string.Join(" ", 1, 1, 1.Length - 1) : null;
		bool flag2 = text2 != null || 1345.1;
		try
		{
			try
			{
				if (!flag2)
				{
					InterProcessOsu interProcessOsu = 1522.5();
					if (interProcessOsu != null && interProcessOsu.WakeUp())
					{
						return;
					}
				}
			}
			catch
			{
			}
			using (1126 2 = new 1126(1345.2, flag2 ? -1 : 5000))
			{
				try
				{
					if (!2.1() && text2 != null)
					{
						1522.6(text2);
						return;
					}
					1345.9(text2);
				}
				catch (BadImageFormatException ex)
				{
					1345.12(ex);
				}
				catch
				{
				}
			}
		}
		catch (1155)
		{
		}
		1345.13(false);
	}

	// Token: 0x06002087 RID: 8327 RVA: 0x00089E10 File Offset: 0x00088010
	private static bool 8(string[] 1, out bool 2)
	{
		1345.1346 3 = default(1345.1346);
		3.1 = 1;
		3.2 = 1;
		2 = false;
		string a;
		while ((a = 1345.20(ref 3)) != null)
		{
			uint num = 1197.1(a);
			if (num <= 1324264909U)
			{
				if (num != 552904152U)
				{
					if (num != 1292286484U)
					{
						if (num == 1324264909U)
						{
							if (a == "-multi")
							{
								1345.1 = true;
								2 = true;
							}
						}
					}
					else if (a == "-setpermissions")
					{
						Environment.CurrentDirectory = Path.GetDirectoryName(1345.1());
						1662.61(false);
						return true;
					}
				}
				else if (a == "-arcade")
				{
					1662.128 = true;
					2 = true;
				}
			}
			else if (num <= 3822232796U)
			{
				if (num != 2013816119U)
				{
					if (num == 3822232796U)
					{
						if (a == "-setassociations")
						{
							Environment.CurrentDirectory = Path.GetDirectoryName(1345.1());
							1662.61(true);
							return true;
						}
					}
				}
				else if (a == "-benchmark")
				{
					1662.109 = true;
					return false;
				}
			}
			else if (num != 3858182660U)
			{
				if (num != 4096500472U)
				{
				}
			}
			else if (a == "-devserver")
			{
				string text = 1345.20(ref 3);
				if (!string.IsNullOrEmpty(text) && !261.10(text))
				{
					1296.6 = "https://osu." + text;
					1296.7 = "https://s." + text;
					1296.8 = "https://b." + text;
					1296.9 = "https://a." + text;
					1296.10 = "https://assets." + text;
					1345.11 = text;
				}
				2 = true;
			}
		}
		return false;
	}

	// Token: 0x06002088 RID: 8328 RVA: 0x00089FD0 File Offset: 0x000881D0
	private static void 9(string 1)
	{
		if (4 != null && 4.StartsWith("-"))
		{
			4 = null;
		}
		AppDomain.CurrentDomain.UnhandledException += 1345.1347.instance.1;
		Application.ThreadException += delegate(object 1, ThreadExceptionEventArgs 2)
		{
			1345.11(2.Exception, false);
		};
		1662.95(false, false);
		try
		{
			if (1562.3())
			{
				1345.6 = false;
			}
			1345.10();
			1345.5 = true;
			using (Process.GetCurrentProcess())
			{
			}
			2684 5 = null;
			928 3 = new 928(1);
			250.1();
			try
			{
				new 1662(4).11();
			}
			catch (Exception arg)
			{
				if (1304.214 || 1304.213)
				{
					1338.5(string.Format("Handling startup failure: {0}", arg), 1341.Runtime, (1114)1);
					try
					{
						1338.5("Attempting without forced optimus", 1341.Runtime, (1114)1);
						1304.214 = false;
						new 1662(4).11();
					}
					catch
					{
						1338.5("failed", 1341.Runtime, (1114)1);
						try
						{
							1338.5("Attempting without compatibility context", 1341.Runtime, (1114)1);
							1304.213 = false;
							new 1662(4).11();
						}
						catch
						{
							1338.5("failed", 1341.Runtime, (1114)1);
							try
							{
								1338.5("Attempting without fullscreen", 1341.Runtime, (1114)1);
								1304.167 = false;
								new 1662(4).11();
							}
							catch
							{
								1338.5("failed", 1341.Runtime, (1114)1);
							}
						}
					}
				}
			}
			finally
			{
				((IDisposable)3).Dispose();
			}
			if (5 != null)
			{
				5.Dispose();
			}
		}
		catch (MissingManifestResourceException ex)
		{
			1345.15(true, ex);
		}
		catch (UnauthorizedAccessException)
		{
			1345.7 = true;
		}
		catch (TypeInitializationException ex2)
		{
			1345.15(true, ex2);
		}
		catch (Exception ex3)
		{
			if (!(ex3 is BadImageFormatException) || !1345.12(ex3 as BadImageFormatException))
			{
				new 1691(ex3, true).ShowDialog();
			}
		}
	}

	// Token: 0x06002089 RID: 8329 RVA: 0x0008A298 File Offset: 0x00088498
	private static void 10()
	{
		if (!1345.6)
		{
			return;
		}
		try
		{
			new Thread(new ThreadStart(new 1345.1349
			{
				1 = 277.GetSplashImage()
			}.1))
			{
				IsBackground = true
			}.Start();
		}
		catch
		{
		}
	}

	// Token: 0x0600208A RID: 8330 RVA: 0x0008A2F0 File Offset: 0x000884F0
	private static void 11(Exception 1, bool 2)
	{
		1345.1348 CS_0024_003C_003E8__locals11 = new 1345.1348();
		CS_0024_003C_003E8__locals11.1 = 1;
		CS_0024_003C_003E8__locals11.2 = 2;
		try
		{
			if (1662.79 is 2263)
			{
				2263.4.7.53(true, false, false, true);
			}
		}
		catch (Exception)
		{
		}
		if ((CS_0024_003C_003E8__locals11.1 is BadImageFormatException && 1345.12(CS_0024_003C_003E8__locals11.1 as BadImageFormatException)) || CS_0024_003C_003E8__locals11.1 is GraphicsContextException)
		{
			return;
		}
		if (CS_0024_003C_003E8__locals11.1 is 1055)
		{
			1705.1("osu! was unable to obtain a graphics context. If this is the first time you've seen this, please try restarting your PC.\n\nIf this is a fresh install, you may be missing graphics drivers.");
			new 1691(CS_0024_003C_003E8__locals11.1, false).ShowDialog();
			Environment.Exit(0);
		}
		TypeInitializationException ex = CS_0024_003C_003E8__locals11.1 as TypeInitializationException;
		if (ex != null)
		{
			1345.15(true, ex);
		}
		1662.89.Schedule(delegate()
		{
			1662.82(true);
			new 1691(CS_0024_003C_003E8__locals11.1, true).ShowDialog();
			if (CS_0024_003C_003E8__locals11.2)
			{
				Environment.Exit(-1);
				return;
			}
			1662.82(false);
		}, false);
		while (CS_0024_003C_003E8__locals11.2)
		{
			Thread.Sleep(60000);
		}
	}

	// Token: 0x0600208B RID: 8331 RVA: 0x0008A420 File Offset: 0x00088620
	private static bool 12(BadImageFormatException 1)
	{
		if (!1345.9.Contains(1.FileName) && !1345.9.Contains(1.FileName + ".dll"))
		{
			return false;
		}
		1345.15(true, 1);
		return true;
	}

	// Token: 0x0600208C RID: 8332 RVA: 0x0008A45C File Offset: 0x0008865C
	private static void 13(bool 1)
	{
		if (1345.10)
		{
			return;
		}
		1345.10 = true;
		if (1662.123 == 2665.NeedsRestart && 1662.78 != 1677.Exit)
		{
			try
			{
				1345.21();
				return;
			}
			catch
			{
				return;
			}
		}
		if (1345.7 || 1)
		{
			1345.21();
		}
	}

	// Token: 0x0600208D RID: 8333 RVA: 0x0008A4B0 File Offset: 0x000886B0
	internal static void 14(bool 1)
	{
		1345.7 = true;
		if (1662.123 != 2665.NeedsRestart)
		{
			File.WriteAllBytes(".require_update", new byte[0]);
		}
		if (1)
		{
			261.Start("osu!.exe");
			1345.16();
		}
	}

	// Token: 0x0600208E RID: 8334 RVA: 0x0008A4E4 File Offset: 0x000886E4
	internal static void 15(bool 1, Exception 2)
	{
		1336.1("Running repair ({0})", new object[]
		{
			1.ToString()
		});
		if (2 != null)
		{
			1336.1("This repair was triggered by an exception: {0}", new object[]
			{
				2.ToString()
			});
		}
		261.Start("osu!.exe", 1 ? "-fix-framework" : "-repair");
		1345.16();
	}

	// Token: 0x0600208F RID: 8335 RVA: 0x0008A546 File Offset: 0x00088746
	internal static void 16()
	{
		Process.GetCurrentProcess().Kill();
	}

	// Token: 0x06002090 RID: 8336 RVA: 0x0008A554 File Offset: 0x00088754
	internal static bool 17(string 1, bool 2)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo
		{
			UseShellExecute = true,
			WorkingDirectory = Environment.CurrentDirectory,
			FileName = 1345.1(),
			Arguments = (1 ?? string.Empty),
			Verb = "runas"
		};
		try
		{
			Process process = 261.Start(processStartInfo);
			if (2)
			{
				if (process == null || process.WaitForExit(60000))
				{
					return true;
				}
				1705.1("osu! took a bit too long while trying to perform an elevated operation (" + (1 ?? "unknown") + ").\\nPlease report this.");
				return false;
			}
		}
		catch
		{
			return false;
		}
		1345.16();
		return true;
	}

	// Token: 0x06002091 RID: 8337 RVA: 0x0008A600 File Offset: 0x00088800
	internal static bool 18()
	{
		WindowsIdentity current = WindowsIdentity.GetCurrent();
		return current != null && new WindowsPrincipal(current).IsInRole(WindowsBuiltInRole.Administrator);
	}

	// Token: 0x06002092 RID: 8338 RVA: 0x0008A628 File Offset: 0x00088828
	internal static void 19(string 1)
	{
		if (string.IsNullOrEmpty(1))
		{
			1 = Environment.CurrentDirectory;
		}
		if (!1345.18())
		{
			1345.17("-allowuserwrites " + 1, true);
			return;
		}
		if (!Directory.Exists(1))
		{
			Directory.CreateDirectory(1);
		}
		2672.29(1);
	}

	// Token: 0x06002093 RID: 8339 RVA: 0x0008A674 File Offset: 0x00088874
	internal static string 20(ref 1345.1346 1)
	{
		if (1.1.Length <= 1.2)
		{
			return null;
		}
		string[] array = 1.1;
		int num = 1.2;
		1.2 = num + 1;
		return array[num];
	}

	// Token: 0x06002094 RID: 8340 RVA: 0x0008A6A8 File Offset: 0x000888A8
	internal static void 21()
	{
		if (!string.IsNullOrEmpty(1345.11))
		{
			261.Start("osu!.exe", "-devserver " + 1345.11);
			return;
		}
		261.Start("osu!.exe");
	}

	// Token: 0x04001116 RID: 4374
	internal static bool 1;

	// Token: 0x04001117 RID: 4375
	internal static Guid 2 = new Guid("{20F7B388-7444-42CC-9388-C23275781FF8}");

	// Token: 0x04001118 RID: 4376
	private static string 3;

	// Token: 0x04001119 RID: 4377
	private static string 4;

	// Token: 0x0400111A RID: 4378
	public static bool 5;

	// Token: 0x0400111B RID: 4379
	private static bool 6 = true;

	// Token: 0x0400111C RID: 4380
	internal static bool 7;

	// Token: 0x0400111D RID: 4381
	internal static string[] 8;

	// Token: 0x0400111E RID: 4382
	private static readonly List<string> 9 = new List<string>
	{
		"avcodec-51.dll",
		"avformat-52.dll",
		"avutil-49.dll",
		"bass.dll",
		"bass_fx.dll",
		"pthreadGC2.dll",
		"d3dcompiler_47.dll",
		"libEGL.dll",
		"libGLESv2.dll",
		"Microsoft.Ink.dll",
		"OpenTK.dll",
		"osu!gameplay.dll",
		"osu!ui.dll",
		"osu!seasonal.dll"
	};

	// Token: 0x0400111F RID: 4383
	private static bool 10;

	// Token: 0x04001120 RID: 4384
	internal static string 11 = string.Empty;

	// Token: 0x0200040F RID: 1039
	public sealed class 1348
	{
		// Token: 0x04001121 RID: 4385
		public Exception 1;

		// Token: 0x04001122 RID: 4386
		public bool 2;
	}

	// Token: 0x02000410 RID: 1040
	[Serializable]
	public sealed class 1347
	{
		// Token: 0x06002097 RID: 8343 RVA: 0x0008A7AC File Offset: 0x000889AC
		internal void 1(object 1, UnhandledExceptionEventArgs 2)
		{
			1345.11(2.ExceptionObject as Exception, true);
		}

		// Token: 0x04001123 RID: 4387
		public static readonly 1345.1347 instance = new 1345.1347();

		// Token: 0x04001124 RID: 4388
		public static ResolveEventHandler resolveEventHandler;

		// Token: 0x04001125 RID: 4389
		public static Predicate<string> predicate;

		// Token: 0x04001126 RID: 4390
		public static UnhandledExceptionEventHandler unhandledExceptionEventHandler;

		// Token: 0x04001127 RID: 4391
		public static ThreadExceptionEventHandler threadExceptionEventHandler;
	}

	// Token: 0x02000411 RID: 1041
	public sealed class 1349
	{
		// Token: 0x0600209A RID: 8346 RVA: 0x0008A7CC File Offset: 0x000889CC
		internal void 1()
		{
			try
			{
				Application.Run(new 1726(this.1));
			}
			catch
			{
			}
		}

		// Token: 0x04001128 RID: 4392
		public Bitmap 1;
	}

	// Token: 0x02000412 RID: 1042
	[StructLayout(LayoutKind.Auto)]
	public struct 1346
	{
		// Token: 0x04001129 RID: 4393
		public string[] 1;

		// Token: 0x0400112A RID: 4394
		public int 2;
	}
}
