using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using OpenTK;
using OpenTK.Graphics.ES20;

// Token: 0x02000416 RID: 1046
public sealed class 1662 : 1803
{
	// Token: 0x060020A7 RID: 8359 RVA: 0x0008A8BC File Offset: 0x00088ABC
	internal 1662(string 1) : base(1304.213 ? 16 : 0)
	{
		1662.11 = this;
		this.86 = 1;
		Application.EnableVisualStyles();
		1088.1(base.4().GetWindowHandle());
		NativeWindow.OsuWindowHandle = base.4().GetWindowHandle();
		string location = typeof(1662).Assembly.Location;
		try
		{
			1662.13().Icon = Icon.ExtractAssociatedIcon(location);
		}
		catch
		{
		}
		1662.13().AllowDrop = !261.IsContained;
		261.20(1662.13().Handle);
		1662.13().FormClosing += this.101;
		Control control = 1662.13();
		DragEventHandler value;
		if ((value = 1662.<>O.<0>__OnDragEnter) == null)
		{
			value = (1662.<>O.<0>__OnDragEnter = new DragEventHandler(1662.85));
		}
		control.DragEnter += value;
		Control control2 = 1662.13();
		DragEventHandler value2;
		if ((value2 = 1662.<>O.<1>__OnFileDrop) == null)
		{
			value2 = (1662.<>O.<1>__OnFileDrop = new DragEventHandler(1662.84));
		}
		control2.DragDrop += value2;
		base.7(new EventHandler(this.98));
		base.5(new EventHandler(this.99));
		1662.80(new EventHandler(1662.1668.osuGameCallbacks.1));
		1662.106 = Thread.CurrentThread;
		if (1304.201 >= 5)
		{
			1726.14();
			1304.201.7(0);
			1304.6();
			1345.15(false, null);
		}
		1568.2(1304.4, 1304.184 != 1296.1(), new 1189(1662.1668.osuGameCallbacks.2), 277.GetEnglishLocalisation());
		1662.113 = 1805.7();
		1662.114 = 1805.8();
		1662.71 = 1805.6();
		1662.70 = new 1512();
		1087 2 = 1552.1();
		if (2.2(200.LeftShift) || 2.2(200.RightShift) || (1345.8.Length > 1 && 1345.8[1] == "-config"))
		{
			new 1687().ShowDialog();
		}
		1662.69 = new 1405(1662.70);
		1662.14();
		1136.SetThreadExecutionState((1136.1139)2147483651U);
		182.Compress(new byte[0]);
	}

	// Token: 0x060020A8 RID: 8360 RVA: 0x0008AB24 File Offset: 0x00088D24
	static 1662()
	{
		897 <<EMPTY_NAME>> = new 897();
		<<EMPTY_NAME>>.Method9344(true);
		<<EMPTY_NAME>>.SetIdleTimeout(300000);
		<<EMPTY_NAME>>.SetMaxWorkerThreads(32);
		<<EMPTY_NAME>>.SetMinWorkerThreads(8);
		1662.105 = new 915(<<EMPTY_NAME>>);
		1662.110 = "nekiosu";
		1662.120 = 0;
	}

	// Token: 0x060020A9 RID: 8361 RVA: 0x0008AC2F File Offset: 0x00088E2F
	internal static 1479 13()
	{
		1662 <<EMPTY_NAME>> = 1662.11;
		1480 2 = ((<<EMPTY_NAME>> != null) ? <<EMPTY_NAME>>.4() : null) as 1480;
		if (2 == null)
		{
			return null;
		}
		return 2.10();
	}

	// Token: 0x060020AA RID: 8362 RVA: 0x0008AC52 File Offset: 0x00088E52
	internal static void 14()
	{
		1226.16(1304.179.GetValue(), false);
		if (1662.47 && !1662.48)
		{
			1226.39.7(0);
		}
	}

	// Token: 0x060020AB RID: 8363 RVA: 0x0008AC80 File Offset: 0x00088E80
	protected override void OnClosed(object 1, EventArgs 2)
	{
		272.3();
		if (1662.61 != null)
		{
			1662.61();
		}
		1173.1(false, string.Empty, string.Empty, string.Empty, string.Empty);
		if (1662.78 == 1677.Edit)
		{
			try
			{
				((2263)1662.79).32();
			}
			catch (Exception)
			{
			}
		}
		this.17.1(true);
		try
		{
			2210.Save();
		}
		catch
		{
		}
		try
		{
			if (1662.78 == 1677.Play && !1535.1())
			{
				2486.7.152();
			}
		}
		catch
		{
		}
		try
		{
			1164.2();
		}
		catch
		{
		}
		try
		{
			1662.25.Dispose();
		}
		catch
		{
		}
		try
		{
			1662.28.Dispose();
		}
		catch
		{
		}
		try
		{
			1662.29.Dispose();
		}
		catch
		{
		}
		try
		{
			if (1304.135)
			{
				1567.Disconnect();
			}
		}
		catch
		{
		}
		Cursor.Show();
		Cursor.Clip = 1535.1;
		try
		{
			Directory.Delete(1654.1(), true);
		}
		catch
		{
		}
		try
		{
			if (!1459.8())
			{
				try
				{
					Directory.Delete(1459.7(), true);
				}
				catch
				{
				}
			}
		}
		catch
		{
		}
		try
		{
			1584.5();
		}
		catch
		{
		}
		try
		{
			1219.23();
			1025.BASS_Free();
		}
		catch
		{
		}
		try
		{
			1535.11();
		}
		catch
		{
		}
		base.OnClosed(1, 2);
	}

	// Token: 0x060020AC RID: 8364 RVA: 0x0008AE7C File Offset: 0x0008907C
	protected override void OnLoad()
	{
		271.Start();
		271.Stage = "start-up";
		if (!string.IsNullOrEmpty(1304.189.GetValue()))
		{
			1338.userName = 1304.189.GetValue();
		}
		1338.gameVersion = 1296.1();
		1379.26.WaitOne(5000);
		this.15();
		1662.20 = new 1387(1);
		1662.34 = 1381.17(new byte[]
		{
			byte.MaxValue,
			byte.MaxValue,
			byte.MaxValue,
			byte.MaxValue
		}, 1, 1);
		1662.13 = new 1388();
		1662.122 = 1662.17(new 1189(1662.1668.osuGameCallbacks.5));
		this.15 = new 1441();
		this.15.1 = 1304.174;
		this.15.1(new 1441.1442(1662.1668.osuGameCallbacks.6));
		this.15.2();
		this.16 = new 1826();
		this.16.1(new Action(1662.1668.osuGameCallbacks.7));
		this.16.2();
		this.17 = new 1326();
		1662.112 = (File.Exists("osu!gameplay.dll") && File.Exists("osu!ui.dll"));
		1450.14();
		2486.15(2601.73);
		1662.44();
		base.4().4(new EventHandler(this.49));
		Control control = 1662.13();
		EventHandler value;
		if ((value = 1662.<>O.<2>__OnWindowBoundsChanged) == null)
		{
			value = (1662.<>O.<2>__OnWindowBoundsChanged = new EventHandler(1662.46));
		}
		control.LocationChanged += value;
		Control control2 = 1662.13();
		EventHandler value2;
		if ((value2 = 1662.<>O.<2>__OnWindowBoundsChanged) == null)
		{
			value2 = (1662.<>O.<2>__OnWindowBoundsChanged = new EventHandler(1662.46));
		}
		control2.SizeChanged += value2;
		Form form = 1662.13();
		EventHandler value3;
		if ((value3 = 1662.<>O.<2>__OnWindowBoundsChanged) == null)
		{
			value3 = (1662.<>O.<2>__OnWindowBoundsChanged = new EventHandler(1662.46));
		}
		form.ResizeEnd += value3;
		Form form2 = 1662.13();
		EventHandler value4;
		if ((value4 = 1662.<>O.<2>__OnWindowBoundsChanged) == null)
		{
			value4 = (1662.<>O.<2>__OnWindowBoundsChanged = new EventHandler(1662.46));
		}
		form2.Activated += value4;
		Control control3 = 1662.13();
		EventHandler value5;
		if ((value5 = 1662.<>O.<2>__OnWindowBoundsChanged) == null)
		{
			value5 = (1662.<>O.<2>__OnWindowBoundsChanged = new EventHandler(1662.46));
		}
		control3.ClientSizeChanged += value5;
		1662.98 = Screen.PrimaryScreen.Bounds.Width;
		1662.97 = Screen.PrimaryScreen.Bounds.Height;
		List<string> list = new List<string>();
		list.Add("1812a3605d6a596a67b5f2250f82307d");
		list.Add("83d489cce95f15b275e480de15bafa88");
		list.Add("f3bf7a5f31a97c2e01dbfd88d49fdcb0");
		list.Add("80ea471ed63c89c4b7db3c3b70ee20a3");
		try
		{
			Directory.CreateDirectory(1272.1);
			string text = Path.Combine(1345.4(), "Data");
			Directory.CreateDirectory(text);
			Directory.CreateDirectory(Path.Combine(text, "r"));
			Directory.CreateDirectory(Path.Combine(text, "a"));
			if (!268.SharesStableInstall)
			{
				2672.20("error_update.txt");
				2672.20("update_log.txt");
				2672.20("update_log_success.txt");
				2672.20(".gl_compatible");
			}
			if (!1181.1())
			{
				if (!File.Exists(Path.Combine(1345.4(), "osu!.exe")))
				{
					string text2 = Path.Combine(1345.4(), "start osu!.lnk");
					if (!File.Exists(text2))
					{
						1167.1(text2, Path.Combine(Environment.CurrentDirectory, "osu!.exe"), "osu!", string.Empty);
					}
				}
				string text3 = Path.Combine(1345.4(), "repair osu!.lnk");
				if (!File.Exists(text3))
				{
					1167.1(text3, Path.Combine(Environment.CurrentDirectory, "osu!.exe"), "repair osu!", "-config");
				}
			}
		}
		catch
		{
		}
		1662.43 = new 1333();
		1272.28(false);
		1535.10();
		1662.28 = new 1436(true);
		1662.28.47 = true;
		1662.29 = new 1436(true);
		1662.29.47 = true;
		1662.30 = new 1436(true);
		1662.25 = new 1436();
		1662.26 = new 1436(true)
		{
			22 = false
		};
		1662.27 = new 1369();
		1662.31 = new 1436(true);
		1662.21 = new 1433(1662.34, (1376)5, 1065.TopLeft, (1044)0, 208.Zero, 0f, true, 198.Black, null);
		1662.37(null, null, false, false);
		2630.8();
		1226.12();
		1662.55 = new 1459();
		1662.45 = new 1468();
		1662.30.12(1662.21);
		float num = 2328.1(1662.13(), false) / 96f;
		1662.99 = new 1472(string.Empty, 11f, 208.Zero, 208.Zero, 1f, true, 198.White, false);
		1662.31.12(1662.99);
		1662.104 = new 1784(this);
		this.40 = new 1740(1662.43);
		this.101 = new 1731(this);
		this.101.Initialize();
		1662.46 = new 1800();
		1662.103 = new 1247(this);
		1662.103.Initialize();
		1662.100 = new 1654(1304.189);
		1662.100.17(new 208(0f, 0f), false, 0);
		1662.100.25(true);
		1662.100.36[0].59 = true;
		1371 <<EMPTY_NAME>> = 1662.100.36[0];
		EventHandler 2;
		if ((2 = 1662.<>O.<3>__OnUserPanelClicked) == null)
		{
			2 = (1662.<>O.<3>__OnUserPanelClicked = new EventHandler(1662.22));
		}
		<<EMPTY_NAME>>.3(2);
		2662 3 = 1662.89;
		1189 4;
		if ((4 = 1662.<>O.<4>__Refresh) == null)
		{
			4 = (1662.<>O.<4>__Refresh = new 1189(2210.Refresh));
		}
		3.2(4, 4000, false);
		1677 5 = 1662.65(new string[]
		{
			this.86
		});
		1662.77 = ((5 != 1677.Unknown) ? 5 : 1662.77);
		if (1662.109)
		{
			1272.SetCurrentBeatmap(1272.3.Find(new Predicate<1262>(1662.1668.osuGameCallbacks.8)));
			2019.1 |= 2023.Autoplay;
			1662.77 = 1677.Play;
		}
		1662.76 = (932)3;
		1662.91(0);
		1534.1();
		252.7();
		1662.102();
		base.OnLoad();
		if (!string.IsNullOrEmpty(1304.184))
		{
			1304.201.7(0);
			if (1304.184 != 1296.1())
			{
				1662.96(2665.Completed);
			}
			else if (1304.127)
			{
				1662.96(2665.Completed);
			}
		}
		1304.184.SetValue(1296.1());
		1313 6 = 1304.224;
		if (6 != null)
		{
			6.3();
		}
		1313 7 = 1304.225;
		if (7 != null)
		{
			7.3();
		}
		1662.32.Start();
		2463.6();
		271.Stage = "running";
		271.4("start-up done.");
	}

	// Token: 0x060020AD RID: 8365 RVA: 0x0008B588 File Offset: 0x00089788
	private void 15()
	{
		base.1().24();
		1402.8();
		1662.119 = 1662.13().ClientSize;
		if (1304.65 && !1425.1())
		{
			1304.65.2(false);
		}
	}

	// Token: 0x060020AE RID: 8366 RVA: 0x0008B5C8 File Offset: 0x000897C8
	protected override void Update()
	{
		271.1();
		1662.43.9(1335.BetweenFrames);
		try
		{
			1662.43.7(1335.Update);
			1662.12 = (base.4().HasEmptyClientArea() || (base.4().GetClientBounds().X < -10000 && base.4().GetClientBounds().Y < -10000));
			if (1662.41 != null)
			{
				1662.41.Update();
			}
			1662.43.7(1335.Scheduler);
			1662.89.1();
			1662.43.9(1335.Scheduler);
			1804.7();
			1633.19();
			1584.1();
			this.103();
			this.40.Update();
			this.101.Update();
			1662.103.Update();
			1662.24();
			bool <<EMPTY_NAME>> = 1356.4;
			this.107 = false;
			1356.4 = false;
			this.88();
			1662.44.3();
			1662.45.Update();
			1662.55.Update();
			1662.104.Update();
			1662.46.Update();
			if (1662.54 != null)
			{
				1662.54.Update();
			}
			1535.16(new 1189(this.20));
			1662.27.4();
			if (!this.107)
			{
				1356.4 = <<EMPTY_NAME>>;
			}
			1763.8();
			1502.1();
			2630.23();
			if (1662.115 == 1662.66 && (1379.37().Contains("AMD") || 1379.37().Contains("ATI")))
			{
				GL.ReadPixels<byte>(0, 0, 1, 1, 6408, 5121, new byte[4]);
			}
			if (1662.115 % 4L == 0L)
			{
				1535.32(false);
				1662.86();
			}
			if (1662.109 && 1662.33 > 120000)
			{
				1662.27(false);
			}
		}
		catch (Exception 2)
		{
			if (1662.68++ > 1 || 1662.78 == 1677.Exit || 1662.77 == 1677.Exit)
			{
				throw;
			}
			1662.16(2);
		}
		if (1662.13().WindowState == FormWindowState.Maximized)
		{
			1662.13().WindowState = FormWindowState.Normal;
			1662.37(new int?(1662.113.Width), new int?(1662.113.Height), true, false);
		}
		2486.19();
		bool flag = 1662.35();
		if (1662.13().TopMost != flag)
		{
			1662.13().TopMost = flag;
		}
		1436 3 = null;
		if (1535.32)
		{
			3 = 1436.41();
		}
		if (3 != null && 3.23 != null)
		{
			1662.99.SetText(3.23.52);
		}
		else
		{
			1662.99.SetText(null);
		}
		1662.43.9(1335.Update);
	}

	// Token: 0x060020AF RID: 8367 RVA: 0x0008B89C File Offset: 0x00089A9C
	protected override void Draw()
	{
		try
		{
			1662.43.7(1335.Draw);
			1379.31();
			1662.91.1();
			1454.3();
			if (1662.12 && 1662.50() && 1662.115 % 4L != 0L)
			{
				1662.43.9(1335.Draw);
				1662.115 += 1L;
				return;
			}
			1436.28();
			1426.5("g_Time", 1662.33);
			1379.22.3();
			2039.35();
			GL.Clear(16384);
			object obj = 1535.1() && 1662.78 == 1677.Play;
			1385.4();
			if (1304.65)
			{
				1356.3();
			}
			1662.55.Draw();
			base.Draw();
			this.121.ForEach(new Action<1350>(1662.1668.osuGameCallbacks.11));
			1662.25.22();
			object obj2 = obj;
			if (obj2 != null)
			{
				1662.27.6();
				1662.26.22();
			}
			1662.104.Draw();
			this.101.4();
			1662.28.22();
			1247.4();
			if (1662.54 != null)
			{
				1662.54.Draw();
			}
			if (1662.92 != null)
			{
				1662.92.DrawDialog();
			}
			1662.46.Draw();
			if (1662.42 != null && 1304.173.1())
			{
				1662.42.Draw();
			}
			1662.29.22();
			this.40.Draw();
			1662.45.Draw();
			if (1662.41 != null)
			{
				1662.41.Draw();
			}
			if (obj2 == null)
			{
				1662.27.6();
				1662.26.22();
			}
			1662.31.22();
			if (1662.76 != (932)2 || 1662.30.5 > 0f)
			{
				1662.30.22();
			}
			1662.55.3();
			if (1304.65)
			{
				1356.4();
			}
			1385.Apply();
			1379.22.4();
			1662.43.9(1335.Draw);
			1662.43.7(1335.SwapBuffer);
			base.1().PresentFrame();
			1662.43.9(1335.SwapBuffer);
		}
		catch (Exception)
		{
			if (1662.68++ > 1 || 1662.78 == 1677.Exit || 1662.77 == 1677.Exit)
			{
				throw;
			}
			1662.16(<<EMPTY_NAME>>);
		}
		1662.115 += 1L;
	}

	// Token: 0x060020B0 RID: 8368 RVA: 0x0008BB38 File Offset: 0x00089D38
	private static void 16(Exception 1)
	{
		1338.4(1, "soft handled", 1341.Runtime);
		if (1662.68 == 1)
		{
			1619.1(new 1618(1)
			{
				7 = true
			});
			1763.5("An error occurred somewhere in osu! and has been reported. osu! will attempt to keep running.", 198.Red, 5000, null);
		}
		if (1 is MissingFieldException || 1 is MissingMethodException || 1 is MissingMemberException)
		{
			1662.SetMode(1677.Update, false);
		}
		1662.89.2(new 1189(1662.1668.osuGameCallbacks.12), 1000, false);
	}

	// Token: 0x060020B1 RID: 8369 RVA: 0x0008BBC0 File Offset: 0x00089DC0
	internal static 373 17(1189 1)
	{
		1662.1671 2 = new 1662.1671();
		2.1 = 1;
		return 1662.105.Method36622(new Action(2.1), (639)2);
	}

	// Token: 0x060020B2 RID: 8370 RVA: 0x0008BBF1 File Offset: 0x00089DF1
	internal static void 18(bool 1)
	{
		if (1662.33 - 1662.108 >= 5000 || 1)
		{
			1662.108 = 1662.33;
			GC.Collect();
		}
	}

	// Token: 0x060020B3 RID: 8371 RVA: 0x0008BC1C File Offset: 0x00089E1C
	internal static string 19(string 1, bool 2)
	{
		if (2 && 1304.1.ContainsKey("h_" + 1))
		{
			return 1304.1["h_" + 1].ToString();
		}
		return (1304.1["h_" + 1] = 1209.1(1)).ToString();
	}

	// Token: 0x060020B4 RID: 8372 RVA: 0x0008BC84 File Offset: 0x00089E84
	private void 20()
	{
		foreach (1350 <<EMPTY_NAME>> in this.121.ToArray())
		{
			if (this.121.Contains(<<EMPTY_NAME>>))
			{
				<<EMPTY_NAME>>.Update();
			}
		}
		base.Update();
		this.107 = true;
	}

	// Token: 0x060020B5 RID: 8373 RVA: 0x0008BCD0 File Offset: 0x00089ED0
	internal static bool 21()
	{
		return 1304.186 != null && !string.IsNullOrEmpty(1304.189);
	}

	// Token: 0x060020B6 RID: 8374 RVA: 0x0008BCED File Offset: 0x00089EED
	internal static void 22(object 1, EventArgs 2)
	{
		if (string.IsNullOrEmpty(1304.189.GetValue()))
		{
			1662.29(false);
			return;
		}
		1662.25(new 1707(false));
	}

	// Token: 0x060020B7 RID: 8375 RVA: 0x0008BD14 File Offset: 0x00089F14
	internal static bool 23(bool 1)
	{
		if (1662.78 == 1677.Play || 1662.78 == 1677.Edit || 1662.78 == 1677.Exit || 1662.78 == 1677.BeatmapImport || 1662.78 == 1677.Update)
		{
			return false;
		}
		bool flag = 1662.92 is 1707;
		bool flag2 = 1662.92 is 1710;
		bool flag3 = flag || flag2 || 1662.92 is 1709 || 1662.92 is 1708;
		if (1662.92 != null && !flag3)
		{
			return false;
		}
		if (1662.7.Exists((1689 1) => 1 != 1662.92 && (1 is 1707 || 1 is 1710 || 1 is 1709 || 1 is 1708)))
		{
			return true;
		}
		if (1662.92 != null)
		{
			1662.92.Close(false);
			if (2 ? flag2 : flag)
			{
				return true;
			}
		}
		if (2 && !string.IsNullOrEmpty(1304.189.GetValue()))
		{
			1662.25(new 1710());
		}
		else
		{
			1662.22(null, EventArgs.Empty);
		}
		return true;
	}

	// Token: 0x060020B8 RID: 8376 RVA: 0x0008BE0C File Offset: 0x0008A00C
	private static void 24()
	{
		if (1662.7.Count > 0 && 1662.92 == null && !2486.14)
		{
			1729 <<EMPTY_NAME>> = 1535.33();
			if (<<EMPTY_NAME>> != null && <<EMPTY_NAME>>.3())
			{
				1662.93 = <<EMPTY_NAME>>;
				1662.93.4(false);
			}
			1662.92 = 1662.7[0];
			1662.92.Show();
			1662.92.OnShown();
			1689 2 = 1662.92;
			EventHandler 3;
			if ((3 = 1662.<>O.<5>__OnDialogClosed) == null)
			{
				3 = (1662.<>O.<5>__OnDialogClosed = new EventHandler(1662.26));
			}
			2.3(3);
		}
		if (1662.92 != null)
		{
			1662.92.Update();
		}
	}

	// Token: 0x060020B9 RID: 8377 RVA: 0x0008BEB0 File Offset: 0x0008A0B0
	internal static void 25(1689 1)
	{
		1662.7.Add(1);
	}

	// Token: 0x060020BA RID: 8378 RVA: 0x0008BEC0 File Offset: 0x0008A0C0
	private static void 26(object 1, EventArgs 2)
	{
		1662.1664 3 = new 1662.1664();
		if (1662.92 != null)
		{
			1662.92.7.28.ForEach(new Action<1371>(1662.1668.osuGameCallbacks.10));
			3.1 = 1662.92;
			1662.89.2(new 1189(3.1), 180, false);
			1662.28.14<1371>(1662.92.7.28);
			1662.92 = null;
			if (1662.93 != null)
			{
				1662.93.4(true);
				1662.93 = null;
			}
			1662.7.Remove((1689)1);
			1662.11.121.Remove((1350)1);
		}
	}

	// Token: 0x060020BB RID: 8379 RVA: 0x0008BF88 File Offset: 0x0008A188
	internal static void 27(bool 1)
	{
		bool flag = 1731.4.Count > 0;
		if (1662.47)
		{
			1662.SetMode(1677.Exit, false);
			return;
		}
		if (!flag && !1304.76 && !1)
		{
			1662.SetMode(1677.Exit, false);
			return;
		}
		if (!1662.80)
		{
			1662.80 = true;
			string text = "Are you sure you want to exit osu!?";
			if (flag)
			{
				text = "Exiting will cancel all active downloads!\n" + text;
			}
			1688 2 = new 1688(text, new EventHandler(1662.1668.osuGameCallbacks.ConfirmExit), new EventHandler(1662.1668.osuGameCallbacks.13), true);
			2.3(new EventHandler(1662.1668.osuGameCallbacks.14));
			1662.25(2);
		}
	}

	// Token: 0x060020BC RID: 8380 RVA: 0x0008C030 File Offset: 0x0008A230
	internal static void 28()
	{
		1662.92();
	}

	// Token: 0x060020BD RID: 8381 RVA: 0x0008C038 File Offset: 0x0008A238
	internal static void 29(bool 1)
	{
		if (1662.47 || (1662.102 && !1))
		{
			return;
		}
		1662.102 = true;
		if (!1662.11.2() || !1662.122.Method13423())
		{
			1662.89.2(delegate
			{
				1662.29(true);
			}, 100, false);
			return;
		}
		1662.82(true);
		1662.104.16(true);
		1662.104.49(true);
		1662.82(false);
		1662.102 = false;
	}

	// Token: 0x060020BE RID: 8382 RVA: 0x0008C0CB File Offset: 0x0008A2CB
	public static bool 30()
	{
		return 1662.92 != null || 1662.7.Count > 0;
	}

	// Token: 0x060020BF RID: 8383 RVA: 0x0008C0E3 File Offset: 0x0008A2E3
	internal static int 31()
	{
		if (!1662.14)
		{
			return 0;
		}
		return 1662.8.Height;
	}

	// Token: 0x060020C0 RID: 8384 RVA: 0x0008C0F8 File Offset: 0x0008A2F8
	internal static double 32()
	{
		return 1000.0 / 1662.34();
	}

	// Token: 0x060020C1 RID: 8385 RVA: 0x0008C10C File Offset: 0x0008A30C
	internal static double 33()
	{
		double result = 60.0;
		switch (1304.203.GetValue())
		{
		case 1303.Limit120:
			result = (double)Math.Min(960, 1662.22 * 8);
			break;
		case 1303.VSync:
			result = double.PositiveInfinity;
			break;
		case 1303.Unlimited:
			result = double.PositiveInfinity;
			break;
		case 1303.PowerSaving:
			result = (double)(1662.22 * 2);
			break;
		case 1303.Custom:
			result = (double)1304.140.6();
			break;
		}
		return result;
	}

	// Token: 0x060020C2 RID: 8386 RVA: 0x0008C194 File Offset: 0x0008A394
	internal static double 34()
	{
		if (1304.203.GetValue() == 1303.VSync)
		{
			return double.PositiveInfinity;
		}
		double num = 1662.33();
		if (1662.78 != 1677.Play || 2486.13)
		{
			int value = (int)1304.204.GetValue();
			num = Math.Min(num, Math.Max(Math.Min(960.0, num) / 4.0, (double)(1662.22 * ((value > 0) ? value : 2))));
		}
		if (1662.50())
		{
			num = (1662.12 ? Math.Min(15.0, num) : (1662.11.2() ? Math.Min((double)1662.72, num) : Math.Min(30.0, num)));
		}
		return num;
	}

	// Token: 0x060020C3 RID: 8387 RVA: 0x0008C256 File Offset: 0x0008A456
	internal static bool 35()
	{
		return (1662.11.2() && !1662.14 && 1662.118 && !1662.129) || (1662.47 && !1662.48);
	}

	// Token: 0x060020C4 RID: 8388 RVA: 0x0008C28C File Offset: 0x0008A48C
	private static void 36()
	{
		if (1377.5())
		{
			1377.19();
			return;
		}
		1662.13().FormBorderStyle = FormBorderStyle.FixedSingle;
	}

	// Token: 0x060020C5 RID: 8389 RVA: 0x0008C2A8 File Offset: 0x0008A4A8
	internal static void 37(int? 1, int? 2, bool 3, bool 4)
	{
		1662.1663 5 = new 1662.1663();
		5.1 = 1;
		5.2 = 2;
		5.3 = 3;
		try
		{
			int? num = 5.1;
			int num2 = 1662.70.1;
			if (num.GetValueOrDefault() == num2 & num != null)
			{
				num = 5.2;
				num2 = 1662.70.2;
				if ((num.GetValueOrDefault() == num2 & num != null) && !4)
				{
					return;
				}
			}
			1662.11.1().Flag1276 = (1304.203 == 1303.VSync);
			1662.45(false);
			if (1662.63 == null && !1662.35)
			{
				1662.63 = new 1189(5.1);
				1662.SetMode(1662.78, true);
			}
			else
			{
				bool flag = 1662.118;
				1662.118 = (1304.167 && !1662.57());
				if (flag && !1662.118)
				{
					1662.36();
				}
				bool flag2 = 1662.54();
				num = 5.1;
				num2 = 0;
				if (num.GetValueOrDefault() > num2 & num != null)
				{
					num = 5.2;
					num2 = 0;
					if (num.GetValueOrDefault() > num2 & num != null)
					{
						1662.70.1 = 5.1.Value;
						1662.70.2 = 5.2.Value;
						if (!5.3)
						{
							goto IL_2EE;
						}
						if (1304.167)
						{
							1304.158.7(1662.70.1);
							1304.149.7(1662.70.2);
							goto IL_2EE;
						}
						1304.157.7(1662.70.1);
						1304.148.7(1662.70.2);
						goto IL_2EE;
					}
				}
				if (1304.167)
				{
					1662.70.1 = 1304.158;
					1662.70.2 = 1304.149;
				}
				else
				{
					1662.70.1 = 1304.157;
					1662.70.2 = 1304.148;
				}
				if (1662.70.1 == 9999 || 1662.70.2 == 9999)
				{
					if (1304.167)
					{
						Size size = 1805.4();
						1512 6 = 1662.70;
						int num3;
						1304.158.7(num3 = size.Width);
						6.1 = num3;
						1512 7 = 1662.70;
						1304.149.7(num3 = size.Height);
						7.2 = num3;
					}
					else
					{
						1512 8 = 1662.70;
						int num4;
						1304.157.7(num4 = 1662.113.Width);
						8.1 = num4;
						1512 9 = 1662.70;
						1304.148.7(num4 = 1662.113.Height);
						9.2 = num4;
					}
				}
				IL_2EE:
				if (1304.208 && (1662.70.1 > 1662.113.Width || 1662.70.2 > 1662.113.Height))
				{
					1304.208.2(false);
				}
				else
				{
					if (1304.167 && !1304.208 && !1805.1(1662.70.1, 1662.70.2, 1662.38(), true))
					{
						1763.4(1568.1(2679.GameBase_ResolutionChangeFailed));
						1304.156.2(false);
						if (!1805.1(1662.70.1, 1662.70.2, null, true))
						{
							1304.158.7(1662.70.1 = 1662.113.Width);
							1304.149.7(1662.70.2 = 1662.113.Height);
						}
					}
					1662.70.2 -= 1662.31();
					if ((float)1662.70.2 > (float)1662.70.1 * 0.8f)
					{
						1662.70.2 = (int)((float)1662.70.1 * 0.8f);
					}
					if (!1662.118 && 1143.1())
					{
						1662.89.2(new 1189(1662.1668.osuGameCallbacks.4), 250, false);
					}
					1450.11();
					1535.54.Location = new Point((int)((double)1662.70.1 * 0.015), 1662.70.2 - (int)((double)1662.70.2 * 0.052) + 2000);
					foreach (1729 10 in 1535.66)
					{
						10.2();
					}
					2630.12(null);
					if (1662.81 != 1677.Unknown && 1662.54() != flag2)
					{
						1455.14();
					}
					if (1662.8 != null)
					{
						1662.8.Width = 1662.113.Width;
					}
					if (1662.21 != null)
					{
						1662.21.20 = new 208((float)1662.70.1, (float)1662.70.2);
					}
					1662.69.12(1662.69.5, true);
					1662.73 = new 207(-1 + 1662.70.4(), -1, 1662.70.1 - 1662.70.4() * 2 + 1, 1662.70.2 + 1);
					1662.74 = new 207(-1, -1, 1662.70.1 + 1, 1662.70.2 + 1);
					1436.31.Width = (float)((int)Math.Ceiling((double)((float)1662.70.1 / 1662.70.3())));
					1662.42();
					1662.40(1662.57());
					if (1662.62 != null)
					{
						1662.62();
					}
					1662.22 = 1805.6();
				}
			}
		}
		catch
		{
			1662.40(1662.57());
			throw;
		}
	}

	// Token: 0x060020C6 RID: 8390 RVA: 0x0008C920 File Offset: 0x0008AB20
	private static int? 38()
	{
		if (1304.156.1())
		{
			return new int?(1304.155.6());
		}
		return null;
	}

	// Token: 0x060020C7 RID: 8391 RVA: 0x0008C954 File Offset: 0x0008AB54
	internal static void 39(object 1, EventArgs 2)
	{
		if (1304.208)
		{
			1379.28(null);
			1662.47();
		}
	}

	// Token: 0x060020C8 RID: 8392 RVA: 0x0008C980 File Offset: 0x0008AB80
	private static void 40(bool 1)
	{
		int num = (1 && !1377.5()) ? 1 : 0;
		1662.66 = 1662.115 + 2L;
		if (1304.208)
		{
			1662.119 = new Size(1662.113.Width, 1662.113.Height);
		}
		else
		{
			1662.119 = new Size(1662.70.1, 1662.70.2 + 1662.31());
		}
		Size size = 1805.7();
		if (1662.119.Width == size.Width && 1662.119.Height == size.Height)
		{
			1662.119.Height = 1662.119.Height + num;
			1662.120 = num;
		}
		else
		{
			1662.120 = 0;
		}
		1662.41();
		1379.28(null);
		1662.47();
		1662.13().ClientSize = 1662.119;
		if (!1662.47)
		{
			if (1662.56())
			{
				1662.13().Location = 1662.114;
			}
			else if (1662.33 == 0 || 1662.63 != null)
			{
				1662.13().45();
			}
		}
		1662.13().Invalidate();
	}

	// Token: 0x060020C9 RID: 8393 RVA: 0x0008CAAD File Offset: 0x0008ACAD
	private static void 41()
	{
		if (1662.56())
		{
			1662.13().FormBorderStyle = FormBorderStyle.None;
			return;
		}
		if (!1662.47)
		{
			1662.13().FormBorderStyle = FormBorderStyle.FixedSingle;
		}
	}

	// Token: 0x060020CA RID: 8394 RVA: 0x0008CAD4 File Offset: 0x0008ACD4
	private static void 42()
	{
		if (1304.167 && !1304.208)
		{
			1805.1(1662.70.1, 1662.70.2 + 1662.31(), 1662.38(), false);
		}
		else
		{
			1805.2();
		}
		1662.72 = 1805.6();
	}

	// Token: 0x060020CB RID: 8395 RVA: 0x0008CB31 File Offset: 0x0008AD31
	internal static int 43(1044 1)
	{
		if (1 == (1044)0)
		{
			return 1662.33;
		}
		if (1 - (1044)1 <= 1)
		{
			return 1226.16;
		}
		return 0;
	}

	// Token: 0x060020CC RID: 8396 RVA: 0x0008CB4C File Offset: 0x0008AD4C
	private static void 44()
	{
		string deviceName = Screen.FromHandle(1662.11.4().GetWindowHandle()).DeviceName;
		try
		{
			1304.160.7(int.Parse(deviceName[deviceName.Length - 1].ToString()));
		}
		catch
		{
		}
		1662.45(false);
	}

	// Token: 0x060020CD RID: 8397 RVA: 0x0008CBB4 File Offset: 0x0008ADB4
	internal static void 45(bool 1)
	{
		1662.72 = 1805.6();
		if ((!1304.167 && !1662.118) || 1)
		{
			1662.113 = 1805.7();
			1662.114 = 1805.8();
			1662.71 = 1662.72;
			if (1662.104 != null)
			{
				1662.104.34();
			}
		}
	}

	// Token: 0x060020CE RID: 8398 RVA: 0x0008CC15 File Offset: 0x0008AE15
	private static void 46(object 1, EventArgs 2)
	{
		1662.47();
	}

	// Token: 0x060020CF RID: 8399 RVA: 0x0008CC1C File Offset: 0x0008AE1C
	private static void 47()
	{
		Rectangle r = new Rectangle(1379.28.Left, 1662.119.Height - 1379.28.Bottom, 1379.28.Width, 1379.28.Height);
		1662.94 = 1662.13().RectangleToScreen(r);
	}

	// Token: 0x060020D0 RID: 8400 RVA: 0x0008CC73 File Offset: 0x0008AE73
	internal static 206 48()
	{
		return new 206(1379.28.Left, 1662.119.Height - 1379.28.Bottom);
	}

	// Token: 0x060020D1 RID: 8401 RVA: 0x0008CC99 File Offset: 0x0008AE99
	private void 49(object 1, EventArgs 2)
	{
		1662.44();
	}

	// Token: 0x060020D2 RID: 8402 RVA: 0x0008CCA0 File Offset: 0x0008AEA0
	internal static bool 50()
	{
		return (1662.12 || 1662.81() || (!1662.11.2() && !1662.47) || 1662.111) && !2486.14 && !1535.40 && !1535.1();
	}

	// Token: 0x060020D3 RID: 8403 RVA: 0x0008CCF0 File Offset: 0x0008AEF0
	private void 51()
	{
		1662.43.7(1335.Sleep);
		double num = 1662.32.GetElapsedMilliseconds();
		double num2 = 1662.32();
		if (num2 > 0.0)
		{
			if (num - 1662.38 < num2)
			{
				double num3 = num2 - (num - 1662.38);
				int num4 = (int)Math.Floor(num3);
				1662.39 += num3 - (double)num4;
				int num5 = (int)Math.Round(1662.39);
				num5 = Math.Max(num5, -num4);
				1662.39 -= (double)num5;
				num4 += num5;
				if (num4 > 0)
				{
					Thread.Sleep(num4);
				}
				double elapsedMilliseconds = 1662.32.GetElapsedMilliseconds();
				1662.39 += (double)num4 - (elapsedMilliseconds - num);
				num = elapsedMilliseconds;
			}
			else
			{
				1662.39 = 0.0 - (num - 1662.38 - num2);
			}
		}
		1662.36 = 1662.38;
		1662.38 = num;
		1662.33 = (int)Math.Round(1662.38, 0);
		if (1662.38 - 1662.37 >= 16.666666666666668 || 1662.35)
		{
			if (1662.35 || (!2486.9 && !2486.8 && !1535.1() && (1662.12 || !base.2() || (double)1662.33 - 1662.37 > 500.0)))
			{
				1662.24 = 1662.38 - 1662.37;
				1662.37 = 1662.38 - 16.666666666666668;
			}
			else
			{
				1662.24 = 1662.38 - 1662.37;
				1662.37 = 1662.38 - (1662.24 - 16.666666666666668);
			}
			1662.23 = true;
			1662.35 = false;
		}
		else
		{
			1662.23 = false;
		}
		1662.82 = 1662.38 - 1662.36;
		1662.10 = 1662.82 / 16.666666666666668;
		1662.56 += 1662.82;
		1662.43.9(1335.Sleep);
	}

	// Token: 0x060020D4 RID: 8404 RVA: 0x0008CEEC File Offset: 0x0008B0EC
	protected override void EndFrame()
	{
		1662.43.7(1335.Update);
		base.EndFrame();
		this.51();
		1662.43.9(1335.Update);
		if (1304.173)
		{
			if (1662.42 == null)
			{
				1662.42 = new 1477(1662.43);
			}
			1662.42.Update();
		}
		1662.43.4();
		1662.43.7(1335.BetweenFrames);
	}

	// Token: 0x060020D5 RID: 8405 RVA: 0x0008CF5C File Offset: 0x0008B15C
	internal static DialogResult 52(CommonDialog 1)
	{
		DialogResult result = DialogResult.Cancel;
		bool flag = !1662.65;
		if (flag)
		{
			Cursor.Show();
		}
		1662.129 = true;
		try
		{
			1662.53(delegate
			{
				1479 2 = 1662.13();
				2.TopMost = false;
				using (Form form = new Form
				{
					FormBorderStyle = FormBorderStyle.None,
					ShowInTaskbar = false,
					TopMost = true,
					StartPosition = FormStartPosition.Manual,
					Size = new Size(1, 1),
					Opacity = 0.0,
					Location = new Point(2.Left + 2.Width / 2, 2.Top + 2.Height / 2)
				})
				{
					form.Show();
					form.Activate();
					bool enabled = 2.Enabled;
					bool flag2 = 1662.118 && 2.WindowState != FormWindowState.Minimized;
					if (flag2)
					{
						2.WindowState = FormWindowState.Minimized;
					}
					2.Enabled = false;
					try
					{
						form.Activate();
						result = 1.ShowDialog(form);
					}
					finally
					{
						2.Enabled = enabled;
						if (flag2)
						{
							2.WindowState = FormWindowState.Normal;
						}
						2.Activate();
					}
				}
			});
		}
		finally
		{
			1662.129 = false;
			if (flag)
			{
				Cursor.Hide();
			}
		}
		return result;
	}

	// Token: 0x060020D6 RID: 8406 RVA: 0x0008CFCC File Offset: 0x0008B1CC
	private static void 53(1189 1)
	{
		int num;
		if (1662.118)
		{
			num = ((!1662.57()) ? 1 : 0);
			if (num != 0)
			{
				1662.36();
				1662.40(true);
			}
		}
		else
		{
			num = 0;
		}
		1();
		if (num != 0)
		{
			1662.40(false);
			1662.13().TopMost = true;
		}
	}

	// Token: 0x060020D7 RID: 8407 RVA: 0x0008D015 File Offset: 0x0008B215
	public static bool 54()
	{
		return (1662.70.2 >= 800 || 1304.90) && !1304.103 && 1379.16 > 2048;
	}

	// Token: 0x060020D8 RID: 8408 RVA: 0x0008D050 File Offset: 0x0008B250
	public static bool 55()
	{
		OperatingSystem osversion = Environment.OSVersion;
		return osversion.Platform == PlatformID.Win32NT && osversion.Version.Major >= 6 && osversion.Version.Minor >= 3;
	}

	// Token: 0x060020D9 RID: 8409 RVA: 0x0008D090 File Offset: 0x0008B290
	internal static bool 56()
	{
		return 1304.167 || 1304.208 || (1662.119.Width >= 1662.113.Width && 1662.119.Height >= 1662.113.Height);
	}

	// Token: 0x060020DA RID: 8410 RVA: 0x0008D0E8 File Offset: 0x0008B2E8
	internal static bool 57()
	{
		switch (1662.78)
		{
		case 1677.Edit:
		case 1677.SelectEdit:
			return true;
		case 1677.Play:
			if (1662.84)
			{
				return true;
			}
			break;
		}
		return 1662.14 || !1304.167;
	}

	// Token: 0x060020DB RID: 8411 RVA: 0x0008D136 File Offset: 0x0008B336
	internal static string 58()
	{
		return Path.Combine(1345.4(), "Exports");
	}

	// Token: 0x060020DC RID: 8412 RVA: 0x0008D148 File Offset: 0x0008B348
	internal static void 59(bool 1)
	{
		if (1 || !(1304.185.GetValue() == 1296.1()))
		{
			bool flag = true;
			if (1127.3() == Guid.Empty)
			{
				flag = false;
			}
			if (2672.4("osu!", null))
			{
				flag &= 2672.6("osu");
				flag &= 2672.5(".osk", "osu!");
				flag &= 2672.5(".osr", "osu!");
				flag &= 2672.5(".osz", "osu!");
				flag &= 2672.5(".osz2", "osu!");
				flag &= 2672.7("osu!");
				flag &= !2672.4("osu!", null);
			}
			if (!2672.4("osustable.File.osz", null))
			{
				flag &= 1830.2();
			}
			else if (!2672.4("osustable.File.osz", 1345.1()))
			{
				flag &= 1830.3();
			}
			if (!1127.2())
			{
				flag = false;
			}
			if (!flag && !1)
			{
				1662.61(true);
				1304.185.SetValue(1296.1());
			}
		}
	}

	// Token: 0x060020DD RID: 8413 RVA: 0x0008D25C File Offset: 0x0008B45C
	private static void 60()
	{
		OperatingSystem osversion = Environment.OSVersion;
		if (osversion.Platform != PlatformID.Win32NT || osversion.Version.Major != 6)
		{
			return;
		}
		try
		{
			Directory.CreateDirectory(".test");
			Directory.Delete(".test");
		}
		catch (Exception)
		{
			1662.61(false);
			try
			{
				Directory.Delete(".test");
			}
			catch
			{
			}
		}
	}

	// Token: 0x060020DE RID: 8414 RVA: 0x0008D2D4 File Offset: 0x0008B4D4
	internal static void 61(bool 1)
	{
		1662.1670 2 = new 1662.1670();
		2.1 = 1;
		if (!1345.18())
		{
			return;
		}
		1662.59(true);
		if (!2.1)
		{
			1345.19(null);
		}
	}

	// Token: 0x060020DF RID: 8415 RVA: 0x0008D30C File Offset: 0x0008B50C
	internal unsafe static 198[] 62(208 1, int 2)
	{
		198[] result;
		try
		{
			198[] array = new 198[2];
			Bitmap bitmap = new Bitmap(1662.70.1, 1662.70.2, PixelFormat.Format32bppArgb);
			try
			{
				BitmapData bitmapData = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadOnly, bitmap.PixelFormat);
				GL.ReadPixels(0, 0, 1662.70.1, 1662.70.2, 6408, 5121, bitmapData.Scan0);
				for (int i = 0; i < 2; i++)
				{
					byte* ptr = (byte*)((byte*)((void*)bitmapData.Scan0) + (1662.70.2 - ((int)1.Y + i)) * bitmapData.Stride) + (int)1.X * 4;
					array[i] = new 198(*ptr, ptr[1], ptr[2], ptr[3]);
				}
				bitmap.UnlockBits(bitmapData);
			}
			finally
			{
				((IDisposable)bitmap).Dispose();
			}
			result = array;
		}
		catch
		{
			result = null;
		}
		return result;
	}

	// Token: 0x060020E0 RID: 8416 RVA: 0x0008D424 File Offset: 0x0008B624
	internal static MemoryStream 63()
	{
		MemoryStream result;
		try
		{
			MemoryStream memoryStream = new MemoryStream();
			Bitmap bitmap = new Bitmap(1662.70.1, 1662.70.2, PixelFormat.Format32bppArgb);
			try
			{
				BitmapData bitmapData = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadOnly, bitmap.PixelFormat);
				GL.ReadPixels(0, 0, 1662.70.1, 1662.70.2, 6408, 5121, bitmapData.Scan0);
				bitmap.UnlockBits(bitmapData);
				bitmap.RotateFlip(RotateFlipType.Rotate180FlipX);
				bitmap.Save(memoryStream, ImageFormat.Jpeg);
			}
			finally
			{
				((IDisposable)bitmap).Dispose();
			}
			result = memoryStream;
		}
		catch
		{
			result = null;
		}
		return result;
	}

	// Token: 0x060020E1 RID: 8417 RVA: 0x0008D4EC File Offset: 0x0008B6EC
	private static void 64(string 1)
	{
		Match match = 1662.131.Match(3.Trim());
		if (!match.Success)
		{
			1763.4("This nekiosu link is not one nekiosu knows.");
			return;
		}
		if (261.FullyOffline)
		{
			1763.4("nekiosu is set to fully offline, so beatmaps can't be downloaded.");
			return;
		}
		string a = match.Groups[1].Value.ToLowerInvariant();
		int 4 = int.Parse(match.Groups[2].Value, CultureInfo.InvariantCulture);
		1731.12((a == "b") ? 1579.Beatmap : 1579.Set, 4, null, delegate(object 1, EventArgs 2)
		{
			1763.4("This beatmap wasn't found on the beatmap mirror.");
		}, a == "dl");
	}

	// Token: 0x060020E2 RID: 8418 RVA: 0x0008D5A4 File Offset: 0x0008B7A4
	internal static 1677 65(string[] 1)
	{
		1662.1667 openFilesState = new 1662.1667();
		openFilesState.1 = 12;
		if (1272.3 == null)
		{
			1662.89.Schedule(new 1189(openFilesState.1), true);
			return 1677.Unknown;
		}
		if (openFilesState.1 == null || openFilesState.1.Length == 0 || (openFilesState.1.Length == 1 && string.IsNullOrEmpty(openFilesState.1[0])))
		{
			return 1677.Unknown;
		}
		openFilesState.2 = openFilesState.1[0];
		if (openFilesState.2.StartsWith("nekiosu://", StringComparison.OrdinalIgnoreCase))
		{
			string link = openFilesState.2;
			if (1662.12 && 1662.13().Visible)
			{
				1662.13().WindowState = FormWindowState.Normal;
			}
			1662.102();
			1662.89.2(delegate
			{
				1662.64(link);
			}, 500, false);
			return 1677.Unknown;
		}
		2670 13 = 2672.24(openFilesState.2);
		try
		{
			switch (13)
			{
			case (2670)1:
			case (2670)2:
			case (2670)4:
			{
				string fullPath = Path.GetFullPath(1272.1);
				string[] 3 = openFilesState.1;
				int i = 0;
				while (i < 3.Length)
				{
					string text = 3[i];
					1662.1666 4 = new 1662.1666();
					string text2 = Path.GetFileName(text);
					int num = fullPath.Length + text2.Length - 248;
					if (num <= 0)
					{
						goto IL_20B;
					}
					int num2 = text2.Length - num;
					if (num2 > ((13 != (2670)2) ? 3 : 4) + 1)
					{
						text2 = text2.Remove(num2) + Path.GetExtension(text2);
						goto IL_20B;
					}
					1763.5("Error moving " + text2 + ". Path is too long.", 198.Red, 1000, null);
					IL_29D:
					i++;
					continue;
					IL_20B:
					4.1 = Path.Combine(1272.1, text2);
					1262 5 = 1272.3.Find(new Predicate<1262>(4.1));
					if (5 != null)
					{
						1272.SetCurrentBeatmap(5);
						goto IL_29D;
					}
					if (2672.16(text, 4.1, true))
					{
						2463.2(true);
						goto IL_29D;
					}
					if (1272.8.Contains(4.1))
					{
						1272.8.Remove(4.1);
					}
					1705.1("Error moving file " + text2);
					return 1677.Unknown;
				}
				1677 6 = 1662.78;
				switch (6)
				{
				case 1677.Edit:
				case 1677.Play:
					1763.2("New beatmap available - visit song select to finish importing!", 1000, (1389)0);
					return 1677.Unknown;
				case 1677.Exit:
				case 1677.SelectPlay:
					goto IL_303;
				case 1677.SelectEdit:
				case 1677.SelectDrawings:
					break;
				default:
					if (6 - 1677.MatchSetup > 1)
					{
						goto IL_303;
					}
					break;
				}
				return 1662.78;
				IL_303:
				return 1677.SelectPlay;
			}
			case (2670)7:
				2463.2(true);
				foreach (string text3 in openFilesState.1)
				{
					string text4 = Path.Combine(1272.1, string.Format("beatmap-{0}-{1}", DateTimeOffset.UtcNow.Ticks, Path.GetFileName(text3)));
					2672.20(text4);
					File.Copy(text3, text4);
				}
				return 1677.SelectEdit;
			case (2670)10:
				foreach (string text5 in openFilesState.1)
				{
					1662.1665 7 = new 1662.1665();
					string fileName = Path.GetFileName(text5);
					7.1 = Path.GetFileNameWithoutExtension(fileName);
					try
					{
						string text6 = Path.Combine(2630.1(), 7.1);
						string text7 = Path.Combine(2630.1(), fileName);
						2672.16(text5, text7, true);
						string text8 = 2672.34(7.1);
						Directory.CreateDirectory(text8);
						new 87().Method5857(text7, text8, ".*");
						FileInfo fileInfo = new FileInfo(text7);
						if ((fileInfo.Attributes & FileAttributes.ReadOnly) > (FileAttributes)0)
						{
							fileInfo.Attributes &= ~FileAttributes.ReadOnly;
						}
						2672.22(text8, text6);
						2672.20(text7);
						int num3 = 5;
						while (Directory.GetFiles(text6).Length < 1 && num3-- > 0)
						{
							2672.22(Directory.GetDirectories(text6)[0], text6);
						}
						2630.7();
						1662.89.Schedule(new 1189(7.1), false);
						1535.2(false);
						1662.104.16(true);
						1662.104.39(1662.104.46);
						return 1677.Menu;
					}
					catch
					{
						1763.4("Unable to import skin \"" + fileName + "\".");
					}
				}
				return 1677.Unknown;
			case (2670)11:
			{
				2241 8 = 2230.18(openFilesState.2);
				1677 9 = 1662.78;
				if (9 - 1677.Edit <= 1 || 9 == 1677.MatchSetup)
				{
					1763.2("Replay has been loaded.", 1000, (1389)0);
					return 1677.Unknown;
				}
				if (8 != null)
				{
					1262 10 = 1272.8(8.10);
					if (1272.5() != 10)
					{
						1272.SetCurrentBeatmap(10);
						1226.106(10, true, false, true);
					}
					1535.39 = 8;
					1535.2(true);
					return 1677.Rank;
				}
				return 1677.Unknown;
			}
			case (2670)12:
			case (2670)13:
				if (1662.78 == 1677.Menu && 1308.1 && 13 == (2670)12)
				{
					2630.25();
					string text9 = 2672.17(Path.Combine(2630.5.14(), "menu-background.jpg"));
					2672.20(text9);
					File.Copy(openFilesState.2, text9);
					1662.89.Schedule(new 1189(1662.1668.osuGameCallbacks.15), false);
					return 1677.Menu;
				}
				if (1662.78 != 1677.Edit)
				{
					1763.4(1568.1(2679.General_File_EnterEditor));
					return 1677.Unknown;
				}
				1662.25(new 1688("Would you like to use \"" + Path.GetFileName(openFilesState.2) + "\" as your map's background?", delegate(object 1, EventArgs 2)
				{
					2263.4.75.20(openFilesState.2);
				}, null, true));
				return 1677.Unknown;
			}
			if (openFilesState.2.StartsWith("osu://"))
			{
				return 1677.Unknown;
			}
			if (!openFilesState.2.StartsWith("-") && openFilesState.2.Contains("."))
			{
				1763.4(1568.1(2679.General_File_UnknownType) + " (" + openFilesState.2 + ")");
			}
			return 1677.Unknown;
		}
		catch (Exception 11)
		{
			1763.4(1568.1(2679.GameBase_FileImportError));
			1619.1(new 1618(11)
			{
				1 = "file handling"
			});
		}
		return 1677.Unknown;
	}

	// Token: 0x060020E3 RID: 8419 RVA: 0x0008DCD8 File Offset: 0x0008BED8
	internal static void 66(string 1, string 2)
	{
		string text = 1662.58();
		Directory.CreateDirectory(text);
		string 3 = Path.Combine(text, 2672.2(1));
		448.Method4009(932);
		new 87().Method5854(3, 2, true, "[^z]+$");
		1763.5(1 + " has been exported.  Opening the Exports folder...", 198.YellowGreen, 6000, null);
		1662.68(text);
	}

	// Token: 0x060020E4 RID: 8420 RVA: 0x0008DD3A File Offset: 0x0008BF3A
	internal static void 67(string 1)
	{
		1804.3(1);
	}

	// Token: 0x060020E5 RID: 8421 RVA: 0x0008DD42 File Offset: 0x0008BF42
	internal static void 68(string 1)
	{
		1804.4(1);
	}

	// Token: 0x060020E6 RID: 8422 RVA: 0x0008DD4A File Offset: 0x0008BF4A
	internal static void 69(string 1)
	{
		if (1.StartsWith("https://") || 1.StartsWith("http://"))
		{
			1662.70(1, null);
		}
	}

	// Token: 0x060020E7 RID: 8423 RVA: 0x0008DD6D File Offset: 0x0008BF6D
	internal static void 70(string 1, string 2)
	{
		1804.5(1, 2);
	}

	// Token: 0x060020E8 RID: 8424 RVA: 0x0008DD78 File Offset: 0x0008BF78
	internal static void 71(1189 1)
	{
		1189 2 = 1662.58;
		1189 3;
		do
		{
			3 = 2;
			1189 value = (1189)Delegate.Combine(3, 1);
			2 = Interlocked.CompareExchange<1189>(ref 1662.58, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x060020E9 RID: 8425 RVA: 0x0008DDAC File Offset: 0x0008BFAC
	internal static void 72(1189 1)
	{
		1189 2 = 1662.59;
		1189 3;
		do
		{
			3 = 2;
			1189 value = (1189)Delegate.Combine(3, 1);
			2 = Interlocked.CompareExchange<1189>(ref 1662.59, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x060020EA RID: 8426 RVA: 0x0008DDE0 File Offset: 0x0008BFE0
	internal static void 73(1189 1)
	{
		1189 2 = 1662.60;
		1189 3;
		do
		{
			3 = 2;
			1189 value = (1189)Delegate.Combine(3, 1);
			2 = Interlocked.CompareExchange<1189>(ref 1662.60, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x060020EB RID: 8427 RVA: 0x0008DE14 File Offset: 0x0008C014
	internal static void 74(1189 1)
	{
		1189 2 = 1662.60;
		1189 3;
		do
		{
			3 = 2;
			1189 value = (1189)Delegate.Remove(3, 1);
			2 = Interlocked.CompareExchange<1189>(ref 1662.60, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x060020EC RID: 8428 RVA: 0x0008DE48 File Offset: 0x0008C048
	private static void 75(1189 1)
	{
		1189 2 = 1662.61;
		1189 3;
		do
		{
			3 = 2;
			1189 value = (1189)Delegate.Combine(3, 1);
			2 = Interlocked.CompareExchange<1189>(ref 1662.61, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x060020ED RID: 8429 RVA: 0x0008DE7C File Offset: 0x0008C07C
	internal static void 76(1189 1)
	{
		1189 2 = 1662.62;
		1189 3;
		do
		{
			3 = 2;
			1189 value = (1189)Delegate.Combine(3, 1);
			2 = Interlocked.CompareExchange<1189>(ref 1662.62, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x060020EE RID: 8430 RVA: 0x0008DEB0 File Offset: 0x0008C0B0
	internal static void 77(1189 1)
	{
		1189 2 = 1662.62;
		1189 3;
		do
		{
			3 = 2;
			1189 value = (1189)Delegate.Remove(3, 1);
			2 = Interlocked.CompareExchange<1189>(ref 1662.62, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x060020EF RID: 8431 RVA: 0x0008DEE4 File Offset: 0x0008C0E4
	internal static void 78(EventHandler 1)
	{
		EventHandler eventHandler = 1662.87;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, 1);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref 1662.87, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x060020F0 RID: 8432 RVA: 0x0008DF18 File Offset: 0x0008C118
	internal static void 79(EventHandler 1)
	{
		EventHandler eventHandler = 1662.87;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, 1);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref 1662.87, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x060020F1 RID: 8433 RVA: 0x0008DF4C File Offset: 0x0008C14C
	internal static void 80(EventHandler 1)
	{
		EventHandler eventHandler = 1662.88;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, 1);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref 1662.88, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x060020F2 RID: 8434 RVA: 0x0008DF7F File Offset: 0x0008C17F
	internal static bool 81()
	{
		return 1662.83;
	}

	// Token: 0x060020F3 RID: 8435 RVA: 0x0008DF86 File Offset: 0x0008C186
	internal static void 82(bool 1)
	{
		if (1662.83 != 1)
		{
			1662.83 = 1;
			1555.28();
			1555.48();
		}
	}

	// Token: 0x060020F4 RID: 8436 RVA: 0x0008DFA0 File Offset: 0x0008C1A0
	internal static bool 83(object 1, 200 2)
	{
		if (1701.IsCapturingKey)
		{
			return false;
		}
		1532 3 = 1548.16(2);
		switch (3)
		{
		case 1532.ToggleFrameLimiter:
			switch (1304.203.GetValue())
			{
			case 1303.Limit120:
				1304.203.SetValue(1303.Unlimited);
				return true;
			case 1303.VSync:
				1304.203.SetValue(1303.Limit120);
				return true;
			case 1303.PowerSaving:
				1304.203.SetValue(1303.Limit120);
				return true;
			}
			1304.203.SetValue(1303.PowerSaving);
			return true;
		case 1532.ShowPlays:
			if (1662.23(false))
			{
				return true;
			}
			break;
		case 1532.ShowProfileSettings:
			if (1662.23(true))
			{
				return true;
			}
			break;
		case 1532.Screenshot:
			2682.1(1549.3);
			return true;
		case 1532.VolumeIncrease:
		case 1532.VolumeDecrease:
			break;
		case 1532.DisableMouseButtons:
			1304.104.4();
			1763.2("Mouse buttons are " + (1304.104 ? "disabled" : "enabled") + ".", 1000, (1389)0);
			return true;
		case 1532.BossKey:
			1662.108(true);
			return true;
		default:
			if (3 == 1532.NewRandomSeed)
			{
				if (1662.78 != 1677.Play && 1662.78 != 1677.Edit && 1925.9(1925.SelectedPlayMode))
				{
					1763.2("Random seed: " + 1925.5().ToString(), 1000, (1389)0);
					return true;
				}
			}
			break;
		}
		if (2 != 200.Enter)
		{
			switch (2)
			{
			case 200.O:
				if (1549.1 && !1549.2 && 1662.104.17())
				{
					1662.104.49(false);
					1662.104.16(true);
					return true;
				}
				if (1549.1 && !1549.2 && 1662.78 == 1677.Play && 2486.7 != null)
				{
					2486.7.75();
					return true;
				}
				break;
			case 200.P:
			case 200.Q:
			case 200.R:
				break;
			case 200.S:
				if (1549.3 && 1549.2 && 1549.1)
				{
					1662.71(new 1189(1662.1668.osuGameCallbacks.3));
					if (1662.93())
					{
						1662.SetMode(1662.78, true);
					}
					else
					{
						1763.2("Skin reload queued.", 2000, (1389)0);
					}
					return true;
				}
				break;
			default:
				if (2 == 200.F11)
				{
					if (1549.1)
					{
						1304.173.2(!1304.173.1());
						if (1304.173.1())
						{
							1763.5("Frame time graph is now visible. Press Ctrl+F11 to hide.", 198.Yellow, 300000, null);
						}
						return true;
					}
					if (1662.41 != null)
					{
						1662.41.3();
						return true;
					}
				}
				break;
			}
		}
		else if (1549.2)
		{
			1677 4 = 1662.78;
			if (4 == 1677.Menu || 4 == 1677.SelectPlay || 4 == 1677.Lobby)
			{
				1304.167.4();
				return true;
			}
			return false;
		}
		return false;
	}

	// Token: 0x060020F5 RID: 8437 RVA: 0x0008E264 File Offset: 0x0008C464
	private static void 84(object 1, DragEventArgs 2)
	{
		try
		{
			Array array = (Array)2.Data.GetData(DataFormats.FileDrop);
			1677 3;
			if (array != null)
			{
				string[] array2 = new string[array.Length];
				for (int i = 0; i < array.Length; i++)
				{
					array2[i] = array.GetValue(i).ToString();
				}
				if (2513.16(array2))
				{
					return;
				}
				3 = 1662.65(array2);
			}
			else
			{
				string text = 2.Data.GetData(DataFormats.Text) as string;
				3 = 1662.65(new string[]
				{
					text
				});
			}
			if (3 != 1677.Unknown)
			{
				1662.SetMode(3, true);
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x060020F6 RID: 8438 RVA: 0x0008E318 File Offset: 0x0008C518
	private static void 85(object 1, DragEventArgs 2)
	{
		bool dataPresent = 2.Data.GetDataPresent(DataFormats.FileDrop);
		bool dataPresent2 = 2.Data.GetDataPresent(DataFormats.Text);
		2.Effect = ((dataPresent || dataPresent2) ? DragDropEffects.Copy : DragDropEffects.None);
	}

	// Token: 0x060020F7 RID: 8439 RVA: 0x0008E358 File Offset: 0x0008C558
	private static void 86()
	{
		1557 <<EMPTY_NAME>> = (1557)1535.27(typeof(1557));
		bool flag = 2486.14;
		if (1662.11.2() && flag && !1535.1())
		{
			<<EMPTY_NAME>>.6();
		}
		else
		{
			<<EMPTY_NAME>>.7();
		}
		if (1662.11.2())
		{
			1164.1();
			return;
		}
		1164.2();
	}

	// Token: 0x060020F8 RID: 8440 RVA: 0x0008E3BA File Offset: 0x0008C5BA
	public static int 87()
	{
		return 1662.33 - 1535.68;
	}

	// Token: 0x060020F9 RID: 8441 RVA: 0x0008E3C8 File Offset: 0x0008C5C8
	private void 88()
	{
		if (1662.76 != (932)2 || 1662.75 > 0.0)
		{
			if (1304.65 && !1662.21.8())
			{
				1356.4 = true;
				1356.6 = 0.004f;
				1356.1 = false;
				1356.5 = false;
				1356.2 = 1052.19((float)1662.75, 0f, 100f) / 100f;
			}
			if (1662.76 == (932)1)
			{
				if (1662.75 <= 0.0)
				{
					1662.76 = (932)2;
					if (1662.87 != null)
					{
						1662.87(this, null);
					}
				}
				else
				{
					1662.75 = Math.Max(-1.0, 1662.75 - 1662.96 * 1662.10);
				}
			}
			else if (1662.76 == (932)0)
			{
				if (1662.75 >= 100.0)
				{
					1662.76 = (932)3;
					if (1662.88 != null)
					{
						1662.88(this, null);
					}
				}
				else
				{
					1662.75 = Math.Min(100.0, 1662.75 + 1662.95 * 1662.10);
					if (1662.77 == 1677.Exit || 1662.77 == 1677.Update)
					{
						1226.46((int)(100.0 * Math.Pow(1.0 - 1662.75 / 100.0, 3.0)), true);
						1662.13().Opacity = Math.Min(1.0, 3.0 - 3.0 * 1662.75 / 100.0);
					}
					else if (1662.78 == 1677.Play)
					{
						if (1226.56 > 50)
						{
							1226.46(1226.56 - 1, false);
						}
					}
					else
					{
						1226.46(1226.56 - 5, false);
					}
				}
			}
		}
		1662.30.5 = 1052.19((float)1662.75, 0f, 100f) / 100f;
	}

	// Token: 0x060020FA RID: 8442 RVA: 0x0008E5DC File Offset: 0x0008C7DC
	internal static void SetMode(1677 1, bool 2)
	{
		if (1 == 1677.Update)
		{
			return;
		}
		1662.1672 3 = new 1662.1672();
		3.1 = 1;
		3.2 = 2;
		if (3.1 == 1677.Unknown)
		{
			3.1 = 1662.78;
			3.2 = true;
		}
		if (3.1 != 1677.Menu && 1662.33 < 2470.53)
		{
			1662.89.2(new 1189(3.1), 2470.53 - 1662.33 + 170, false);
			return;
		}
		if (1662.78 == 1677.Edit && !((2263)1662.79).9 && !((2263)1662.79).32())
		{
			return;
		}
		if (3.1 != 1677.Exit && 3.1 != 1677.Update && (1345.1 || !1226.14()))
		{
			3.1 = 1677.Menu;
			3.2 = true;
		}
		if (1662.47)
		{
			switch (3.1)
			{
			case 1677.Exit:
			case 1677.Rank:
			case 1677.Busy:
				goto IL_137;
			case 1677.SelectPlay:
				3.1 = 1677.Menu;
				goto IL_137;
			}
			if (1662.78 == 1677.Play && !1226.10() && (1535.42 || (2486.7 != null && 2486.7.80 == (707)4)))
			{
				return;
			}
			IL_137:
			if (1662.78 == 1677.Rank && 3.1 == 1677.Play && 1662.56 < 10000.0)
			{
				return;
			}
		}
		1763.3();
		if (1621.hasInvalidCertificate)
		{
			1763.5("You have an invalid certificate installed. Please remove it.\n\nIf you are connecting to a non-official server, please contact the admin and ask them to stop forging certificates (there is a new method which does not require this).", 198.Red, 60000, null);
		}
		if ((3.1 == 1662.78 && !3.2) || (3.1 == 1662.77 && !3.2) || 1662.77 == 1677.Exit)
		{
			return;
		}
		List<1689> list = new List<1689>();
		foreach (1689 4 in 1662.7)
		{
			if (4.5)
			{
				list.Add(4);
			}
		}
		foreach (1689 5 in list)
		{
			5.Close(false);
		}
		1662.77 = 3.1;
		1662.21.9(false);
		1662.95 = 10.0;
		1662.30.15(true);
		1662.30.12(1662.21);
		if (3.1 == 1677.Exit)
		{
			272.3();
			if (1662.60 != null)
			{
				1662.60();
			}
			if (!1304.200 || (1662.123 == 2665.NeedsRestart && 1345.7) || 1662.47)
			{
				1662.95 = 5.0;
			}
			else
			{
				1662.95 = 0.6;
				1226.24("seeya", 100, (!1308.1) ? ((1416)1) : ((1416)3), false);
			}
			1535.32 = false;
		}
		1662.76 = (932)0;
	}

	// Token: 0x060020FB RID: 8443 RVA: 0x0008E8EC File Offset: 0x0008CAEC
	internal static void 89(1677 1, bool 2, int 3)
	{
		1662.1673 setModeDeferredClosure = new 1662.1673();
		setModeDeferredClosure.1 = 1;
		setModeDeferredClosure.2 = 2;
		setModeDeferredClosure.3 = 3;
		if (setModeDeferredClosure.1 != 1677.Menu && 1662.33 < 2470.53)
		{
			1662.89.2(delegate
			{
				1662.89(setModeDeferredClosure.1, setModeDeferredClosure.2, setModeDeferredClosure.3);
			}, 2470.53 - 1662.33 + 170, false);
			return;
		}
		1662.89.Schedule(delegate()
		{
			if (setModeDeferredClosure.1 != 1662.78 || setModeDeferredClosure.2)
			{
				1662.76 = (932)2;
				List<1689> list = new List<1689>();
				foreach (1689 4 in 1662.7)
				{
					if (4.5)
					{
						list.Add(4);
					}
				}
				foreach (1689 5 in list)
				{
					5.Close(false);
				}
				1662.77 = setModeDeferredClosure.1;
				1662.91(setModeDeferredClosure.3);
				if (1662.87 != null)
				{
					1662.87(null, null);
				}
			}
		}, false);
	}

	// Token: 0x060020FC RID: 8444 RVA: 0x0008E989 File Offset: 0x0008CB89
	internal static 1677 90()
	{
		if (1662.81 == 1662.78 || 1662.81 == 1677.Unknown)
		{
			return 1677.Menu;
		}
		return 1662.81;
	}

	// Token: 0x060020FD RID: 8445 RVA: 0x0008E9A8 File Offset: 0x0008CBA8
	private static void 91(int 1)
	{
		if (1662.77 == 1677.Unknown)
		{
			return;
		}
		if (1662.77 != 1677.Play || 1662.81 != 1677.Play)
		{
			1662.104();
		}
		if (1662.78 != 1662.77)
		{
			1662.104.16(false);
		}
		1534.3();
		1677 2 = 1662.77;
		if (2 != 1677.Rank && 2 != 1677.RankingVs && 2 - 1677.RankingTagCoop > 1)
		{
			1226.108();
		}
		1662.35 = true;
		bool flag = 1662.57();
		1662.81 = 1662.78;
		1662.78 = 1662.77;
		if (1662.79 != null)
		{
			1662.1675 switchModeClosure = new 1662.1675();
			switchModeClosure.1 = 1662.79;
			if (1 > 0)
			{
				1662.89.2(delegate
				{
					1662.11.121.Remove(switchModeClosure.1);
					switchModeClosure.1.Dispose();
				}, 1, false);
			}
			else
			{
				1662.11.121.Remove(switchModeClosure.1);
				switchModeClosure.1.Dispose();
			}
			1662.79 = null;
		}
		1189 3 = 1662.58;
		if (3 != null)
		{
			3();
		}
		1189 4 = 1662.59;
		if (4 != null)
		{
			4();
		}
		1662.58 = null;
		if (!1662.104.17())
		{
			1662.104.23(false);
		}
		if (1662.78 == 1677.Exit)
		{
			1662.11.9();
		}
		else
		{
			if (1662.81 != 1677.Unknown)
			{
				if (1662.81 != 1662.78)
				{
					2630.10(null, false);
				}
				else
				{
					2630.13(false);
				}
			}
			1356.7 = 0f;
			1662.56 = 0.0;
			bool flag2 = false;
			if (1662.78 == 1677.Edit)
			{
				if (1662.8 == null)
				{
					1662.8 = new 2330();
				}
				if (!1662.14)
				{
					1662.14 = true;
					1662.8.Parent = 1662.13();
					flag2 = true;
				}
			}
			else
			{
				if (1662.8 != null)
				{
					1662.8.13();
					1662.8 = null;
				}
				if (1662.14)
				{
					1662.14 = false;
					flag2 = true;
				}
			}
			flag2 |= (flag != 1662.57());
			if (!1662.47)
			{
				if (1662.63 != null)
				{
					1662.63();
				}
				else if (flag2)
				{
					1662.37(null, null, false, false);
				}
				1662.63 = null;
			}
			1662.69.12(1662.69.5, true);
			1535.5(false);
			1535.8 = string.Empty;
			1226.58 = false;
			bool 5 = false;
			1662.18(true);
			bool maximizeBox = false;
			switch (1662.78)
			{
			case 1677.Menu:
				maximizeBox = true;
				if (1662.81 != 1677.Unknown)
				{
					2470.4 = false;
				}
				5 = true;
				1662.79 = new 2470(1662.11);
				break;
			case 1677.Edit:
				1226.98();
				1226.5();
				1662.79 = new 2263(1662.11);
				break;
			case 1677.Play:
				if (1662.84)
				{
					1662.79 = new 2485();
				}
				else
				{
					if (!1535.1() && !1535.40)
					{
						2023 6 = 2023.Autoplay;
						2023 7 = 2019.1;
						2023 8 = 6;
						if ((7 & 8) <= 2023.None)
						{
							1662.79 = new 2486();
							break;
						}
					}
					1662.79 = new 2561();
				}
				break;
			case 1677.SelectEdit:
			case 1677.SelectPlay:
			case 1677.SelectMulti:
				maximizeBox = true;
				1804.2();
				if (2463.1() || (1662.81 != 1677.BeatmapImport && 1272.3.Count == 0))
				{
					1662.81 = 1662.78;
					1662.79 = new 2463(1662.11);
					1662.78 = 1677.BeatmapImport;
				}
				else
				{
					1662.79 = new 2601(1662.11);
				}
				break;
			case 1677.Rank:
				1662.79 = new 2568(1662.11);
				break;
			case 1677.Update:
			case 1677.Busy:
				goto IL_489;
			case 1677.OnlineSelection:
				maximizeBox = true;
				if (261.FullyOffline)
				{
					1662.78 = 1677.Menu;
					5 = true;
					1662.79 = new 2470(1662.11);
				}
				else
				{
					1662.79 = new 2570(1662.11);
				}
				break;
			case 1677.OptionsOffsetWizard:
				maximizeBox = true;
				5 = true;
				1662.79 = new 1777(1662.11);
				break;
			case 1677.BeatmapImport:
				1662.79 = new 2463(1662.11);
				break;
			case 1677.Benchmark:
				1662.79 = new 2248(1662.11);
				break;
			}
			if (1662.13().FormBorderStyle != FormBorderStyle.None)
			{
				1662.13().MaximizeBox = maximizeBox;
			}
			1247.3(5);
			1662.47();
			1662.11.121.Add(1662.79);
			1662.79.Initialize();
		}
		IL_489:
		if (1662.77 == 1662.78)
		{
			1662.77 = 1677.Unknown;
		}
	}

	// Token: 0x060020FE RID: 8446 RVA: 0x0008EE51 File Offset: 0x0008D051
	internal static void 92()
	{
		if (1662.76 != (932)2)
		{
			1662.75 = 140.0;
		}
		1662.76 = (932)1;
	}

	// Token: 0x060020FF RID: 8447 RVA: 0x0008EE70 File Offset: 0x0008D070
	public static bool 93()
	{
		1677 <<EMPTY_NAME>> = 1662.78;
		if (<<EMPTY_NAME>> <= 1677.Rank)
		{
			if (<<EMPTY_NAME>> != 1677.Play)
			{
				if (<<EMPTY_NAME>> != 1677.Rank)
				{
					return true;
				}
			}
			else
			{
				if (1535.39 != null)
				{
					2023 2 = 1535.39.8;
					2023 3 = 2023.Autoplay;
					return (2 & 3) > 2023.None;
				}
				return false;
			}
		}
		else if (<<EMPTY_NAME>> != 1677.RankingVs && <<EMPTY_NAME>> - 1677.RankingTagCoop > 1)
		{
			return true;
		}
		return false;
	}

	// Token: 0x06002100 RID: 8448 RVA: 0x0008EEC6 File Offset: 0x0008D0C6
	internal static void 94(1189 1)
	{
		if (1 != null)
		{
			1662.75(1);
		}
		1345.7 = true;
		1662.SetMode(1677.Exit, false);
	}

	// Token: 0x06002101 RID: 8449 RVA: 0x0008EEE0 File Offset: 0x0008D0E0
	internal static void 95(bool 1, bool 2)
	{
		if (1662.123 != 2665.NeedsRestart)
		{
			return;
		}
		if (1662.123 - 2665.Checking <= 1)
		{
			return;
		}
		1662.126 = (1662.126 || 1);
		if ((!1 && !2 && (DateTime.Now - 1662.127).TotalSeconds < 1800.0) || 1662.47)
		{
			return;
		}
		if (!string.IsNullOrEmpty(1296.3))
		{
			DateTime now = DateTime.Now;
			if (DateTime.TryParseExact(1296.11.ToString(), "yyyyMMdd", 1662.18, DateTimeStyles.None, out now) && DateTime.Now < now.AddDays(7.0))
			{
				return;
			}
		}
		1662.96(2665.Checking);
		1662.127 = DateTime.Now;
		1662.89.Schedule(new 1189(1662.1668.osuGameCallbacks.17), false);
	}

	// Token: 0x06002102 RID: 8450 RVA: 0x0008EFB8 File Offset: 0x0008D1B8
	internal static void 96(2665 1)
	{
		1662.1674 setUpdateStatusClosure = new 1662.1674();
		setUpdateStatusClosure.1 = 1;
		1662.89.Schedule(delegate()
		{
			if (setUpdateStatusClosure.1 != 1662.123)
			{
				1662.123 = setUpdateStatusClosure.1;
				1189 2 = 1662.125;
				if (2 != null)
				{
					2();
				}
				switch (1662.123)
				{
				case 2665.NoUpdate:
					1304.201.7(0);
					break;
				case 2665.Checking:
				case 2665.Updating:
					break;
				case 2665.Error:
				{
					1304.127.2(false);
					if (1336.7 != null)
					{
						if (1336.7 is 1130)
						{
							1336.11();
							1763.5(1568.1(2679.GameBase_UpdateFailedFrameworkVersion), 198.Red, 300000, new 1189(1662.1668.osuGameCallbacks.19));
						}
						else
						{
							1662.17(new 1189(1662.1668.osuGameCallbacks.20));
						}
					}
					1304.7();
					1318 3 = 1304.201;
					int num = 3.6();
					3.7(num + 1);
					return;
				}
				case 2665.NeedsRestart:
				{
					1304.21();
					1304.201.7(0);
					bool flag = !1304.127.1();
					1304.127.2(true);
					if (1662.126)
					{
						1662.97(false);
					}
					else if (1662.78 > 1677.Menu && flag)
					{
						1763.5(1568.1(2679.General_NewVersion), 198.Pink, 10000, null);
					}
					1662.124 = true;
					return;
				}
				case 2665.Completed:
					1304.201.7(0);
					1304.127.2(false);
					1304.6();
					1763.5("nekiosu was updated to " + 1296.1() + ".", 198.Pink, 6000, null);
					return;
				case 2665.EmergencyFallback:
					1345.15(true, null);
					return;
				default:
					return;
				}
			}
		}, false);
	}

	// Token: 0x06002103 RID: 8451 RVA: 0x0008EFFC File Offset: 0x0008D1FC
	internal static void 97(bool 1)
	{
		if (!1 && 1662.123 != 2665.NeedsRestart && 1662.123 != 2665.Error)
		{
			return;
		}
		1677 2 = 1662.78;
		if (2 != 1677.Menu && 2 - 1677.SelectEdit > 1)
		{
			1662.89.2(delegate
			{
				1662.97(false);
			}, 1000, false);
			return;
		}
		if (!1)
		{
			1763.2(1568.1(2679.Update_Restart), 120000, (1389)0);
		}
		1662.89.2(new 1189(1662.1668.osuGameCallbacks.21), (!1) ? 6000 : 0, false);
	}

	// Token: 0x06002104 RID: 8452 RVA: 0x0008F09C File Offset: 0x0008D29C
	private void 98(object 1, EventArgs 2)
	{
		1136.SetThreadExecutionState((1136.1139)2147483648U);
		this.100();
		if (!1662.47 && 2486.14 && !1535.1())
		{
			1662.13().BringToFront();
			1662.13().Focus();
		}
	}

	// Token: 0x06002105 RID: 8453 RVA: 0x0008F0D9 File Offset: 0x0008D2D9
	private void 99(object 1, EventArgs 2)
	{
		1136.SetThreadExecutionState((1136.1139)2147483651U);
		1535.68 = 1662.33;
		this.100();
	}

	// Token: 0x06002106 RID: 8454 RVA: 0x0008F0F8 File Offset: 0x0008D2F8
	private void 100()
	{
		using (Process currentProcess = Process.GetCurrentProcess())
		{
			if (currentProcess.PriorityClass == ProcessPriorityClass.RealTime)
			{
				currentProcess.PriorityBoostEnabled = true;
				currentProcess.PriorityClass = ProcessPriorityClass.High;
				1763.4("Realtime process priority is not supported. It will cause more issues than you think. You do not know best. Do not use it, ever.");
			}
		}
	}

	// Token: 0x06002107 RID: 8455 RVA: 0x0008F150 File Offset: 0x0008D350
	private void 101(object 1, FormClosingEventArgs 2)
	{
		switch (1662.78)
		{
		case 1677.Edit:
		{
			2263 3 = 1662.79 as 2263;
			if (3 != null)
			{
				3.32();
			}
			2.Cancel = true;
			return;
		}
		case 1677.Play:
			if (1662.84)
			{
				1662.SetMode(1677.Edit, false);
			}
			else
			{
				1662.SetMode(1677.SelectPlay, false);
			}
			2.Cancel = true;
			return;
		case 1677.Rank:
			1662.SetMode(1677.SelectPlay, false);
			2.Cancel = true;
			return;
		case 1677.Lobby:
		case 1677.OnlineSelection:
		case 1677.OptionsOffsetWizard:
			1662.SetMode(1677.Menu, false);
			2.Cancel = true;
			return;
		case 1677.MatchSetup:
			1662.SetMode(1677.Lobby, false);
			2.Cancel = true;
			return;
		case 1677.RankingVs:
		case 1677.RankingTagCoop:
		case 1677.RankingTeam:
			1662.SetMode(1677.MatchSetup, false);
			2.Cancel = true;
			return;
		}
		if (1662.78 != 1677.Exit && 1662.78 != 1677.Update)
		{
			1662.27(false);
			2.Cancel = true;
		}
	}

	// Token: 0x06002108 RID: 8456 RVA: 0x0008F24C File Offset: 0x0008D44C
	internal static void 102()
	{
		1662.13().BringToFront();
		1662.SetForegroundWindow(1662.13().Handle);
	}

	// Token: 0x06002109 RID: 8457
	[DllImport("user32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool RegisterHotKey(IntPtr 1, int 2, uint 3, uint 4);

	// Token: 0x0600210A RID: 8458 RVA: 0x0008F268 File Offset: 0x0008D468
	private void 103()
	{
		if (!1662.118)
		{
			return;
		}
		if (1662.33 < 1000 || this.67)
		{
			if (base.2())
			{
				this.67 = false;
				return;
			}
			if (!1377.1())
			{
				1662.13().Focus();
				return;
			}
		}
		else if (base.2() && 1377.1())
		{
			1377.19();
			1662.42();
			bool flag = 1662.57();
			1662.40(flag);
			if (!flag)
			{
				1662.13().TopMost = true;
			}
			if (1377.5())
			{
				this.67 = true;
				return;
			}
		}
		else if (!base.2() && !1377.1())
		{
			if (!1377.5())
			{
				1377.19();
			}
			1662.36();
			1662.89.Schedule(new 1189(1662.1668.osuGameCallbacks.9), true);
		}
	}

	// Token: 0x0600210B RID: 8459 RVA: 0x0008F333 File Offset: 0x0008D533
	internal static void 104()
	{
		1662.105(string.Empty);
	}

	// Token: 0x0600210C RID: 8460 RVA: 0x0008F340 File Offset: 0x0008D540
	internal static void 105(string 1)
	{
		1662.1676 2 = new 1662.1676();
		2.1 = 1;
		1662.89.Schedule(new 1189(2.1), false);
	}

	// Token: 0x0600210D RID: 8461
	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool SetForegroundWindow(IntPtr 1);

	// Token: 0x0600210E RID: 8462
	[SuppressUnmanagedCodeSecurity]
	[DllImport("user32.dll")]
	internal static extern bool FlashWindow(IntPtr 1, bool 2);

	// Token: 0x0600210F RID: 8463
	[DllImport("user32.dll")]
	public static extern bool GetLayeredWindowAttributes(IntPtr 1, out IntPtr 2, out IntPtr 3, out IntPtr 4);

	// Token: 0x06002110 RID: 8464 RVA: 0x0008F374 File Offset: 0x0008D574
	internal static void 106()
	{
		if (1662.47)
		{
			return;
		}
		try
		{
			if (1304.68)
			{
				1226.24("match-start", 100, (1416)3, false);
			}
			1662.13().Invoke(new 1189(1662.1668.osuGameCallbacks.16));
		}
		catch
		{
		}
	}

	// Token: 0x06002111 RID: 8465 RVA: 0x0008F3D8 File Offset: 0x0008D5D8
	public static bool 107()
	{
		return 1662.116;
	}

	// Token: 0x06002112 RID: 8466 RVA: 0x0008F3E0 File Offset: 0x0008D5E0
	public static void 108(bool 1)
	{
		if (3 == 1662.116)
		{
			return;
		}
		1662.116 = 3;
		if (1662.116)
		{
			if (1662.9 == null)
			{
				1662.9 = new NotifyIcon();
				1662.9.Icon = 1662.13().Icon;
				1662.9.Click += delegate(object 1, EventArgs 2)
				{
					1662.108(false);
				};
			}
			1662.9.Visible = true;
			if (1304.67)
			{
				1662.9.ShowBalloonTip(10000, 1568.1(2679.BossKeyActivated), 1568.1(2679.BossKeyActivated_Tooltip), ToolTipIcon.Info);
				1304.67.2(false);
			}
			1662.13().WindowState = FormWindowState.Minimized;
			1662.13().Visible = false;
			2486 4 = 2486.7;
			if (4 != null && !1226.10() && !2486.13 && !1535.1())
			{
				4.RequestPauseToggle();
			}
			1662.57 = 1226.39.6();
			1226.39.7(0);
			return;
		}
		1662.13().Visible = true;
		1662.13().WindowState = FormWindowState.Normal;
		1662.13().ShowInTaskbar = true;
		1662.9.Visible = false;
		1662.102();
		1226.39.7(1662.57);
	}

	// Token: 0x04001130 RID: 4400
	private new static List<1689> 7 = new List<1689>();

	// Token: 0x04001131 RID: 4401
	internal new static 2330 8;

	// Token: 0x04001132 RID: 4402
	private new static NotifyIcon 9;

	// Token: 0x04001133 RID: 4403
	internal static double 10;

	// Token: 0x04001134 RID: 4404
	internal new static 1662 11;

	// Token: 0x04001135 RID: 4405
	internal static bool 12;

	// Token: 0x04001136 RID: 4406
	internal static 1388 13;

	// Token: 0x04001137 RID: 4407
	internal static bool 14;

	// Token: 0x04001138 RID: 4408
	internal 1441 15;

	// Token: 0x04001139 RID: 4409
	internal 1826 16;

	// Token: 0x0400113A RID: 4410
	internal 1326 17;

	// Token: 0x0400113B RID: 4411
	internal static readonly NumberFormatInfo 18 = new CultureInfo("en-US", false).NumberFormat;

	// Token: 0x0400113C RID: 4412
	internal static int 19;

	// Token: 0x0400113D RID: 4413
	internal static 1387 20;

	// Token: 0x0400113E RID: 4414
	internal static 1433 21;

	// Token: 0x0400113F RID: 4415
	private static int 22;

	// Token: 0x04001140 RID: 4416
	internal static bool 23;

	// Token: 0x04001141 RID: 4417
	internal static double 24;

	// Token: 0x04001142 RID: 4418
	internal static 1436 25;

	// Token: 0x04001143 RID: 4419
	internal static 1436 26;

	// Token: 0x04001144 RID: 4420
	internal static 1369 27;

	// Token: 0x04001145 RID: 4421
	internal static 1436 28;

	// Token: 0x04001146 RID: 4422
	internal static 1436 29;

	// Token: 0x04001147 RID: 4423
	internal static 1436 30;

	// Token: 0x04001148 RID: 4424
	internal static 1436 31;

	// Token: 0x04001149 RID: 4425
	internal static Stopwatch 32 = new Stopwatch();

	// Token: 0x0400114A RID: 4426
	internal static int 33;

	// Token: 0x0400114B RID: 4427
	internal static 1381 34;

	// Token: 0x0400114C RID: 4428
	internal static bool 35 = true;

	// Token: 0x0400114D RID: 4429
	internal static double 36;

	// Token: 0x0400114E RID: 4430
	private static double 37;

	// Token: 0x0400114F RID: 4431
	internal static double 38;

	// Token: 0x04001150 RID: 4432
	private static double 39;

	// Token: 0x04001151 RID: 4433
	internal 1740 40;

	// Token: 0x04001152 RID: 4434
	internal static 1682 41;

	// Token: 0x04001153 RID: 4435
	internal static 1477 42;

	// Token: 0x04001154 RID: 4436
	internal static 1333 43;

	// Token: 0x04001155 RID: 4437
	internal static 1400 44 = new 1400();

	// Token: 0x04001156 RID: 4438
	internal static 1468 45;

	// Token: 0x04001157 RID: 4439
	internal static 1800 46;

	// Token: 0x04001158 RID: 4440
	internal static bool 47;

	// Token: 0x04001159 RID: 4441
	internal static bool 48;

	// Token: 0x0400115A RID: 4442
	internal static bool 49;

	// Token: 0x0400115B RID: 4443
	internal static short 50;

	// Token: 0x0400115C RID: 4444
	internal static 1452 51;

	// Token: 0x0400115D RID: 4445
	internal static bool 52;

	// Token: 0x0400115E RID: 4446
	internal static bool 53;

	// Token: 0x0400115F RID: 4447
	internal static 1678 54;

	// Token: 0x04001160 RID: 4448
	internal static 1459 55;

	// Token: 0x04001161 RID: 4449
	internal static double 56;

	// Token: 0x04001162 RID: 4450
	private static int 57 = 0;

	// Token: 0x04001163 RID: 4451
	private static 1189 58;

	// Token: 0x04001164 RID: 4452
	private static 1189 59;

	// Token: 0x04001165 RID: 4453
	private static 1189 60;

	// Token: 0x04001166 RID: 4454
	private static 1189 61;

	// Token: 0x04001167 RID: 4455
	private static 1189 62;

	// Token: 0x04001168 RID: 4456
	private static 1189 63;

	// Token: 0x04001169 RID: 4457
	internal static string 64;

	// Token: 0x0400116A RID: 4458
	internal static bool 65 = true;

	// Token: 0x0400116B RID: 4459
	private static long 66 = 1L;

	// Token: 0x0400116C RID: 4460
	private bool 67 = true;

	// Token: 0x0400116D RID: 4461
	private static int 68;

	// Token: 0x0400116E RID: 4462
	internal static 1405 69;

	// Token: 0x0400116F RID: 4463
	internal static 1512 70;

	// Token: 0x04001170 RID: 4464
	private static int 71 = 0;

	// Token: 0x04001171 RID: 4465
	internal static int 72 = 0;

	// Token: 0x04001172 RID: 4466
	internal static 207 73;

	// Token: 0x04001173 RID: 4467
	internal static 207 74;

	// Token: 0x04001174 RID: 4468
	internal static double 75;

	// Token: 0x04001175 RID: 4469
	internal static 932 76 = (932)2;

	// Token: 0x04001176 RID: 4470
	internal static 1677 77 = 1677.Menu;

	// Token: 0x04001177 RID: 4471
	internal static 1677 78 = 1677.Unknown;

	// Token: 0x04001178 RID: 4472
	internal static 2462 79;

	// Token: 0x04001179 RID: 4473
	private static bool 80;

	// Token: 0x0400117A RID: 4474
	internal static 1677 81 = 1677.Unknown;

	// Token: 0x0400117B RID: 4475
	internal static double 82;

	// Token: 0x0400117C RID: 4476
	private static bool 83;

	// Token: 0x0400117D RID: 4477
	internal static bool 84;

	// Token: 0x0400117E RID: 4478
	internal static int 85;

	// Token: 0x0400117F RID: 4479
	private readonly string 86;

	// Token: 0x04001180 RID: 4480
	private static EventHandler 87;

	// Token: 0x04001181 RID: 4481
	private static EventHandler 88;

	// Token: 0x04001182 RID: 4482
	internal static readonly 2662 89 = new 2662();

	// Token: 0x04001183 RID: 4483
	internal static readonly 2663 90 = new 2663(50);

	// Token: 0x04001184 RID: 4484
	internal static readonly 2662 91 = new 2662();

	// Token: 0x04001185 RID: 4485
	internal static 1689 92;

	// Token: 0x04001186 RID: 4486
	private static 1729 93;

	// Token: 0x04001187 RID: 4487
	internal static Rectangle 94;

	// Token: 0x04001188 RID: 4488
	private static double 95 = 8.0;

	// Token: 0x04001189 RID: 4489
	private static double 96 = 4.0;

	// Token: 0x0400118A RID: 4490
	internal static int 97;

	// Token: 0x0400118B RID: 4491
	internal static int 98;

	// Token: 0x0400118C RID: 4492
	internal static 1472 99;

	// Token: 0x0400118D RID: 4493
	internal static 1654 100;

	// Token: 0x0400118E RID: 4494
	private 1731 101;

	// Token: 0x0400118F RID: 4495
	private static bool 102;

	// Token: 0x04001190 RID: 4496
	internal static 1247 103;

	// Token: 0x04001191 RID: 4497
	internal static 1784 104;

	// Token: 0x04001192 RID: 4498
	private static 915 105;

	// Token: 0x04001193 RID: 4499
	internal static Thread 106;

	// Token: 0x04001194 RID: 4500
	private bool 107;

	// Token: 0x04001195 RID: 4501
	public static int 108;

	// Token: 0x04001196 RID: 4502
	internal static bool 109;

	// Token: 0x04001197 RID: 4503
	internal static string 110;

	// Token: 0x04001198 RID: 4504
	public static bool 111;

	// Token: 0x04001199 RID: 4505
	public static bool 112;

	// Token: 0x0400119A RID: 4506
	internal static Size 113;

	// Token: 0x0400119B RID: 4507
	internal static Point 114;

	// Token: 0x0400119C RID: 4508
	public static long 115;

	// Token: 0x0400119D RID: 4509
	private static bool 116;

	// Token: 0x0400119E RID: 4510
	internal static bool 117;

	// Token: 0x0400119F RID: 4511
	internal static bool 118;

	// Token: 0x040011A0 RID: 4512
	private static Size 119;

	// Token: 0x040011A1 RID: 4513
	internal static int 120;

	// Token: 0x040011A2 RID: 4514
	private List<1350> 121 = new List<1350>();

	// Token: 0x040011A3 RID: 4515
	private static 373 122;

	// Token: 0x040011A4 RID: 4516
	internal static 2665 123;

	// Token: 0x040011A5 RID: 4517
	private static bool 124;

	// Token: 0x040011A6 RID: 4518
	internal static 1189 125;

	// Token: 0x040011A7 RID: 4519
	private static bool 126;

	// Token: 0x040011A8 RID: 4520
	private static DateTime 127;

	// Token: 0x040011A9 RID: 4521
	internal static bool 128;

	// Token: 0x040011AA RID: 4522
	private static bool 129;

	// Token: 0x040011AB RID: 4523
	private const string 130 = "nekiosu://";

	// Token: 0x040011AC RID: 4524
	private static readonly Regex 131 = new Regex("^nekiosu://(dl|s|b)/(\\d{1,9})/?$", RegexOptions.IgnoreCase);

	// Token: 0x02000417 RID: 1047
	[Serializable]
	public sealed class 1668
	{
		// Token: 0x06002113 RID: 8467 RVA: 0x0008F52F File Offset: 0x0008D72F
		internal void 1(object 1, EventArgs 2)
		{
			1662.91(0);
		}

		// Token: 0x06002114 RID: 8468 RVA: 0x0008F538 File Offset: 0x0008D738
		internal void 2()
		{
			if (1662.33 > 0)
			{
				1662.89.2(delegate
				{
					1304.4.SetValue(1568.3);
				}, Math.Max(0, 2470.53 + 500 - 1662.33), false);
				return;
			}
			1304.4.SetValue(1568.3);
		}

		// Token: 0x06002115 RID: 8469 RVA: 0x0008F59F File Offset: 0x0008D79F
		internal void 3()
		{
			1763.2("Skin reloaded!", 2000, (1389)0);
			2630.7();
			2630.10(null, true);
			1455.14();
		}

		// Token: 0x06002116 RID: 8470 RVA: 0x0008F5C3 File Offset: 0x0008D7C3
		internal void 4()
		{
			1143.4(1662.13());
			1143.3(1662.13());
		}

		// Token: 0x06002117 RID: 8471 RVA: 0x0008F5D9 File Offset: 0x0008D7D9
		internal void 5()
		{
			if (!1662.47)
			{
				1662.60();
				1662.59(false);
				1164.1();
			}
			1522.1(1662.110);
		}

		// Token: 0x06002118 RID: 8472 RVA: 0x0008F5FC File Offset: 0x0008D7FC
		internal void 6(1441.1443 1)
		{
			1763.5(string.Format(1568.1(2679.GameBase_DetectedBackgroundApp), 1.1), 198.Orange, 10000, null);
		}

		// Token: 0x06002119 RID: 8473 RVA: 0x0008F623 File Offset: 0x0008D823
		internal void 7()
		{
			1763.5("Your PC is not plugged in and may experience degraded performance.", 198.Orange, 10000, null);
		}

		// Token: 0x0600211A RID: 8474 RVA: 0x0008F63A File Offset: 0x0008D83A
		internal bool 8(1262 1)
		{
			return 1.3() == 2147.Osu;
		}

		// Token: 0x0600211B RID: 8475 RVA: 0x0008F648 File Offset: 0x0008D848
		internal void 9()
		{
			if (1304.215 && (1377.5() || 1304.192.GetValue() > 1302.Never || 1662.119.Width < 1662.113.Width || 1662.119.Height < 1662.113.Height || 1662.72 != 1662.71))
			{
				1662.13().WindowState = FormWindowState.Minimized;
			}
			if (1662.13().WindowState == FormWindowState.Minimized)
			{
				1805.2();
			}
		}

		// Token: 0x0600211C RID: 8476 RVA: 0x0008F6CB File Offset: 0x0008D8CB
		internal void 10(1371 1)
		{
			1.16(180, (1046)0, 0);
			1.5 = false;
		}

		// Token: 0x0600211D RID: 8477 RVA: 0x0008F6E1 File Offset: 0x0008D8E1
		internal void 11(1350 1)
		{
			1474 2 = 1 as 1474;
			if (2 == null)
			{
				return;
			}
			2.Draw();
		}

		// Token: 0x0600211E RID: 8478 RVA: 0x0008F6F3 File Offset: 0x0008D8F3
		internal void 12()
		{
			1662.68--;
		}

		// Token: 0x0600211F RID: 8479 RVA: 0x0008F701 File Offset: 0x0008D901
		internal void ConfirmExit(object 1, EventArgs 2)
		{
			1662.SetMode(1677.Exit, false);
		}

		// Token: 0x06002120 RID: 8480 RVA: 0x0008F70A File Offset: 0x0008D90A
		internal void 13(object 1, EventArgs 2)
		{
			1662.80 = false;
		}

		// Token: 0x06002121 RID: 8481 RVA: 0x0008F70A File Offset: 0x0008D90A
		internal void 14(object 1, EventArgs 2)
		{
			1662.80 = false;
		}

		// Token: 0x06002122 RID: 8482 RVA: 0x0008F712 File Offset: 0x0008D912
		internal void 15()
		{
			2630.10(1304.187, true);
		}

		// Token: 0x06002123 RID: 8483 RVA: 0x0008F725 File Offset: 0x0008D925
		internal void 16()
		{
			1662.FlashWindow(1662.13().Handle, true);
		}

		// Token: 0x06002124 RID: 8484 RVA: 0x0008F738 File Offset: 0x0008D938
		internal void 17()
		{
			1662.17(new 1189(1662.1668.osuGameCallbacks.18));
		}

		// Token: 0x06002125 RID: 8485 RVA: 0x0008F750 File Offset: 0x0008D950
		internal void 18()
		{
			while (1662.78 == 1677.Play)
			{
				Thread.Sleep(1000);
			}
			2666 <<EMPTY_NAME>>;
			if ((<<EMPTY_NAME>> = 1662.1668.<>O.<0>__SetUpdateStatus) == null)
			{
				<<EMPTY_NAME>> = (1662.1668.<>O.<0>__SetUpdateStatus = new 2666(1662.96));
			}
			1336.5(<<EMPTY_NAME>>, 1304.198.GetValue(), (1662.78 != 1677.Menu && 1662.78 != 1677.Unknown) ? ThreadPriority.BelowNormal : ThreadPriority.Highest);
		}

		// Token: 0x06002126 RID: 8486 RVA: 0x0008F7AF File Offset: 0x0008D9AF
		internal void 19()
		{
			1345.14(true);
		}

		// Token: 0x06002127 RID: 8487 RVA: 0x0008F7B8 File Offset: 0x0008D9B8
		internal void 20()
		{
			WebException ex = 1336.7 as WebException;
			if (ex != null && ex.Status == WebExceptionStatus.Timeout)
			{
				1336.11();
				return;
			}
			1619.1(new 1618(1336.7)
			{
				1 = "update error",
				2 = (1336.8 ?? string.Empty)
			});
			1336.11();
		}

		// Token: 0x06002128 RID: 8488 RVA: 0x0008F816 File Offset: 0x0008DA16
		internal void 21()
		{
			if (1662.123 == 2665.NeedsRestart || 1662.123 == 2665.Completed)
			{
				1662.94(null);
				return;
			}
			1662.SetMode(1677.Update, false);
		}

		// Token: 0x040011AD RID: 4525
		public static readonly 1662.1668 osuGameCallbacks = new 1662.1668();

		// Token: 0x040011AE RID: 4526
		public static EventHandler eventHandler;

		// Token: 0x040011AF RID: 4527
		public static 1189 voidDelegate;

		// Token: 0x040011B0 RID: 4528
		public static 1189 voidDelegate2;

		// Token: 0x040011B1 RID: 4529
		public static EventHandler eventHandler2;

		// Token: 0x040011B2 RID: 4530
		public static 1189 voidDelegate3;

		// Token: 0x040011B3 RID: 4531
		public static 1189 voidDelegate4;

		// Token: 0x040011B4 RID: 4532
		public static 1189 voidDelegate5;

		// Token: 0x040011B5 RID: 4533
		public static 1189 voidDelegate6;

		// Token: 0x040011B6 RID: 4534
		public static 1441.1442 _recoveredType04624307;

		// Token: 0x040011B7 RID: 4535
		public static Action action;

		// Token: 0x040011B8 RID: 4536
		public static EventHandler eventHandler3;

		// Token: 0x040011B9 RID: 4537
		public static Predicate<1262> predicate;

		// Token: 0x040011BA RID: 4538
		public static Action<1350> action2;

		// Token: 0x040011BB RID: 4539
		public static 1189 voidDelegate7;

		// Token: 0x040011BC RID: 4540
		public static Action<1371> action3;

		// Token: 0x040011BD RID: 4541
		public static Action<1350> action4;

		// Token: 0x040011BE RID: 4542
		public static 1189 voidDelegate8;

		// Token: 0x040011BF RID: 4543
		public static Predicate<1496> predicate2;

		// Token: 0x040011C0 RID: 4544
		public static EventHandler eventHandler4;

		// Token: 0x040011C1 RID: 4545
		public static EventHandler eventHandler5;

		// Token: 0x040011C2 RID: 4546
		public static EventHandler eventHandler6;

		// Token: 0x040011C3 RID: 4547
		public static 1189 voidDelegate9;

		// Token: 0x040011C4 RID: 4548
		public static 1189 voidDelegate10;

		// Token: 0x040011C5 RID: 4549
		public static 1189 voidDelegate11;

		// Token: 0x040011C6 RID: 4550
		public static EventHandler eventHandler7;

		// Token: 0x040011C7 RID: 4551
		public static 1189 voidDelegate12;

		// Token: 0x040011C8 RID: 4552
		public static 1189 voidDelegate13;

		// Token: 0x040011C9 RID: 4553
		public static 1189 voidDelegate14;

		// Token: 0x040011CA RID: 4554
		public static 1189 voidDelegate15;

		// Token: 0x040011CB RID: 4555
		public static 1189 voidDelegate16;

		// Token: 0x040011CC RID: 4556
		public static 1189 voidDelegate17;

		// Token: 0x040011CD RID: 4557
		public static 1189 voidDelegate18;

		// Token: 0x02000418 RID: 1048
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040011CE RID: 4558
			public static 2666 <0>__SetUpdateStatus;
		}
	}

	// Token: 0x0200041A RID: 1050
	// (Invoke) Token: 0x0600212F RID: 8495
	public delegate string 1669();

	// Token: 0x0200041B RID: 1051
	public sealed class 1671
	{
		// Token: 0x06002132 RID: 8498 RVA: 0x0008F860 File Offset: 0x0008DA60
		internal void 1()
		{
			try
			{
				this.1();
			}
			catch (Exception ex)
			{
				1662.16(ex);
			}
		}

		// Token: 0x040011D1 RID: 4561
		public 1189 1;
	}

	// Token: 0x0200041C RID: 1052
	public sealed class 1664
	{
		// Token: 0x06002134 RID: 8500 RVA: 0x0008F894 File Offset: 0x0008DA94
		internal void 1()
		{
			this.1.7.Dispose();
		}

		// Token: 0x040011D2 RID: 4562
		public 1689 1;
	}

	// Token: 0x0200041D RID: 1053
	public sealed class 1663
	{
		// Token: 0x06002136 RID: 8502 RVA: 0x0008F8A6 File Offset: 0x0008DAA6
		internal void 1()
		{
			1662.37(this.1, this.2, this.3, true);
		}

		// Token: 0x040011D3 RID: 4563
		public int? 1;

		// Token: 0x040011D4 RID: 4564
		public int? 2;

		// Token: 0x040011D5 RID: 4565
		public bool 3;
	}

	// Token: 0x0200041E RID: 1054
	public sealed class 1665
	{
		// Token: 0x06002138 RID: 8504 RVA: 0x0008F8C0 File Offset: 0x0008DAC0
		internal void 1()
		{
			1304.187.SetValue(this.1);
			2630.10(null, true);
		}

		// Token: 0x040011D6 RID: 4566
		public string 1;
	}

	// Token: 0x0200041F RID: 1055
	public sealed class 1670
	{
		// Token: 0x0600213A RID: 8506 RVA: 0x0008F8DA File Offset: 0x0008DADA
		internal void 1()
		{
			bool flag = 1226.113();
			1662.53(new 1189(this.2));
			if (flag)
			{
				1226.107();
			}
		}

		// Token: 0x0600213B RID: 8507 RVA: 0x0008F8FA File Offset: 0x0008DAFA
		internal void 2()
		{
			1345.17(this.1 ? "-setassociations" : "-setpermissions", true);
		}

		// Token: 0x040011D7 RID: 4567
		public bool 1;
	}

	// Token: 0x02000420 RID: 1056
	public sealed class 1666
	{
		// Token: 0x0600213D RID: 8509 RVA: 0x0008F917 File Offset: 0x0008DB17
		internal bool 1(1262 1)
		{
			return 1.61 && 1.44() == this.1;
		}

		// Token: 0x040011D8 RID: 4568
		public string 1;
	}

	// Token: 0x02000421 RID: 1057
	public sealed class 1667
	{
		// Token: 0x0600213F RID: 8511 RVA: 0x0008F934 File Offset: 0x0008DB34
		internal void 1()
		{
			1662.65(this.1);
		}

		// Token: 0x040011D9 RID: 4569
		public string[] 1;

		// Token: 0x040011DA RID: 4570
		public string 2;
	}

	// Token: 0x02000422 RID: 1058
	public sealed class 1672
	{
		// Token: 0x06002141 RID: 8513 RVA: 0x0008F942 File Offset: 0x0008DB42
		internal void 1()
		{
			1662.SetMode(this.1, this.2);
		}

		// Token: 0x040011DB RID: 4571
		public 1677 1;

		// Token: 0x040011DC RID: 4572
		public bool 2;
	}

	// Token: 0x02000423 RID: 1059
	public sealed class 1675
	{
		// Token: 0x040011DD RID: 4573
		public 2462 1;
	}

	// Token: 0x02000424 RID: 1060
	public sealed class 1673
	{
		// Token: 0x040011DE RID: 4574
		public 1677 1;

		// Token: 0x040011DF RID: 4575
		public bool 2;

		// Token: 0x040011E0 RID: 4576
		public int 3;
	}

	// Token: 0x02000425 RID: 1061
	public sealed class 1674
	{
		// Token: 0x040011E1 RID: 4577
		public 2665 1;
	}

	// Token: 0x02000426 RID: 1062
	public sealed class 1676
	{
		// Token: 0x06002146 RID: 8518 RVA: 0x0008F958 File Offset: 0x0008DB58
		internal void 1()
		{
			string str = string.Format("nekiosu{0} {1} {2}", 1296.3, 1296.4, (this.1.Length > 0) ? ("- " + this.1) : string.Empty).Trim();
			if (1662.47 && !1662.48)
			{
				str += string.Format(" Tournament Client {0}", 1662.50);
			}
			if (1662.48)
			{
				str += " Tournament Manager";
			}
			1662.11.4().1(str);
		}

		// Token: 0x040011E2 RID: 4578
		public string 1;
	}

	// Token: 0x02000427 RID: 1063
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x040011E3 RID: 4579
		public static DragEventHandler <0>__OnDragEnter;

		// Token: 0x040011E4 RID: 4580
		public static DragEventHandler <1>__OnFileDrop;

		// Token: 0x040011E5 RID: 4581
		public static EventHandler <2>__OnWindowBoundsChanged;

		// Token: 0x040011E6 RID: 4582
		public static EventHandler <3>__OnUserPanelClicked;

		// Token: 0x040011E7 RID: 4583
		public static 1189 <4>__Refresh;

		// Token: 0x040011E8 RID: 4584
		public static EventHandler <5>__OnDialogClosed;
	}
}
