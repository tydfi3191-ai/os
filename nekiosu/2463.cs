using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

// Token: 0x02000561 RID: 1377
public sealed class 2463 : 2462
{
	// Token: 0x06002A3E RID: 10814 RVA: 0x000DE178 File Offset: 0x000DC378
	public 2463(1803 1) : base(1)
	{
		1662.78(new EventHandler(this.4));
		1662.75 = 0.0;
		1662.76 = (932)2;
		2463.5 = new 2468(1568.1(2679.BeatmapImport_CheckingForNewFiles));
		1272.20(new Action<string>(2463.5.3));
	}

	// Token: 0x06002A3F RID: 10815 RVA: 0x000DE1DA File Offset: 0x000DC3DA
	internal static bool 1()
	{
		return 2463.6;
	}

	// Token: 0x06002A40 RID: 10816 RVA: 0x000DE1E1 File Offset: 0x000DC3E1
	internal static void 2(bool 1)
	{
		2463.4 = !1;
		2463.6 = true;
	}

	// Token: 0x06002A41 RID: 10817 RVA: 0x000DE1F2 File Offset: 0x000DC3F2
	protected override void Dispose(bool 1)
	{
		if (2463.5 != null)
		{
			2463.5.Dispose();
			2463.5 = null;
		}
		base.Dispose(1);
	}

	// Token: 0x06002A42 RID: 10818 RVA: 0x000DE212 File Offset: 0x000DC412
	internal new static bool 3()
	{
		return 2463.7 != null && !2463.7.Method13423();
	}

	// Token: 0x06002A43 RID: 10819 RVA: 0x000DE22A File Offset: 0x000DC42A
	private void 4(object 1, EventArgs 2)
	{
		1662.79(new EventHandler(this.4));
		2463.6();
	}

	// Token: 0x06002A44 RID: 10820 RVA: 0x000DE244 File Offset: 0x000DC444
	internal static bool 5()
	{
		1677 <<EMPTY_NAME>> = 1662.78;
		if (2463.3() || <<EMPTY_NAME>> == 1677.Play || <<EMPTY_NAME>> == 1677.Edit || <<EMPTY_NAME>> == 1677.BeatmapImport)
		{
			return false;
		}
		2463.8 = false;
		2463.4 = false;
		2463.7();
		return true;
	}

	// Token: 0x06002A45 RID: 10821 RVA: 0x000DE27F File Offset: 0x000DC47F
	internal static void 6()
	{
		if (!1662.49 && !2463.3())
		{
			1189 <<EMPTY_NAME>>;
			if ((<<EMPTY_NAME>> = 2463.<>O.<0>__RunImport) == null)
			{
				<<EMPTY_NAME>> = (2463.<>O.<0>__RunImport = new 1189(2463.7));
			}
			2463.7 = 1662.17(<<EMPTY_NAME>>);
		}
	}

	// Token: 0x06002A46 RID: 10822 RVA: 0x000DE2B4 File Offset: 0x000DC4B4
	public override void Draw()
	{
		if (2463.5 != null)
		{
			2463.5.4();
		}
		base.Draw();
	}

	// Token: 0x06002A47 RID: 10823 RVA: 0x000DE2CD File Offset: 0x000DC4CD
	public override void Update()
	{
		base.Update();
	}

	// Token: 0x06002A48 RID: 10824 RVA: 0x000DE2D8 File Offset: 0x000DC4D8
	private static void 7()
	{
		Stopwatch stopwatch = Stopwatch.StartNew();
		271.4(string.Concat(new string[]
		{
			"song import started (",
			1272.7.Count.ToString(),
			" changed folder(s), full rescan ",
			2463.4.ToString(),
			")."
		}));
		271.BackgroundStage = "song import: looking for new files";
		1804.1();
		if (Thread.CurrentThread != 1662.106)
		{
			271.BackgroundStage = "song import: checking song folders";
			1272.29();
			271.BackgroundStage = "song import: looking for new files";
		}
		int num = -1;
		if (2463.8() || 1272.8.Count > 0 || 1272.7.Count > 0)
		{
			2463.4 = false;
		}
		else if (!2463.4)
		{
			num = Directory.GetDirectories(1272.1).Length + Directory.GetFiles(1272.1).Length;
			if (1272.12 != num)
			{
				1338.5(string.Format("Detected a change in folder/file count (changed from {0} to {1})", 1272.12, num), 1341.Runtime, (1114)2);
				if (1272.12 == 0)
				{
					2468 <<EMPTY_NAME>> = 2463.5;
					if (<<EMPTY_NAME>> != null)
					{
						<<EMPTY_NAME>>.3(1568.1(2679.BeatmapImport_TimeToPopulateAnEmptyDatabase));
					}
					2463.4 = true;
					2463.8 = false;
				}
				else
				{
					1763.5(1568.1(2679.BeatmapImport_ChangeDetected), 198.OrangeRed, 10000, null);
				}
			}
		}
		if (2463.5 != null)
		{
			1272.20(new Action<string>(2463.5.3));
		}
		if (2463.4 && 2463.8 && 1272.3.Count > 1000)
		{
			2463.2467 2 = new 2463.2467();
			2.1 = false;
			1662.17(new 1189(2.1));
			while (2463.8 && 1662.78 == 1677.BeatmapImport)
			{
				Thread.Sleep(50);
			}
			if (!2.1)
			{
				2662 3 = 1662.89;
				1189 4;
				if ((4 = 2463.<>O.<1>__FinishImport) == null)
				{
					4 = (2463.<>O.<1>__FinishImport = new 1189(2463.12));
				}
				3.Schedule(4, false);
				1272.23();
				return;
			}
		}
		1272.32(2463.4);
		1272.23();
		if (num >= 0)
		{
			1272.12 = num;
		}
		271.4(string.Concat(new string[]
		{
			"song import finished in ",
			stopwatch.ElapsedMilliseconds.ToString(),
			" ms (",
			1272.3.Count.ToString(),
			" beatmaps)."
		}));
		271.BackgroundStage = "idle";
		2662 5 = 1662.89;
		1189 6;
		if ((6 = 2463.<>O.<1>__FinishImport) == null)
		{
			6 = (2463.<>O.<1>__FinishImport = new 1189(2463.12));
		}
		5.Schedule(6, false);
	}

	// Token: 0x06002A49 RID: 10825 RVA: 0x000DE574 File Offset: 0x000DC774
	private static bool 8()
	{
		bool result = false;
		string <<EMPTY_NAME>> = 1272.1;
		string[] files = Directory.GetFiles(1272.1);
		int i = 0;
		while (i < files.Length)
		{
			string text = files[i];
			2670 5 = 2672.24(text);
			switch (5)
			{
			case (2670)0:
				goto IL_5E;
			case (2670)1:
			case (2670)4:
			{
				2463.2466 importPendingFilesClosure = new 2463.2466();
				string fileName = Path.GetFileName(text);
				string text2 = Path.GetFileNameWithoutExtension(text).Replace("-novid", string.Empty);
				text2 = 2672.3(text2);
				if (2463.5 != null)
				{
					2463.5.3(string.Format(1568.1(2679.BeatmapImport_Importing), (fileName.Length > 50) ? (fileName.Remove(50) + "...") : fileName));
				}
				int num = 212;
				string text3 = 2672.34("_beatmaps");
				2672.20(text3);
				importPendingFilesClosure.2 = new List<string>();
				importPendingFilesClosure.1 = new List<string>();
				try
				{
					740 3 = new 740();
					3._recoveredType09649319 = (496)Delegate.Combine(3._recoveredType09649319, new 496(delegate(object 1, 782 2)
					{
						if (2 != null)
						{
							importPendingFilesClosure.1.Add(Path.GetDirectoryName(2.GetText9990_12765()));
						}
					}));
					3._recoveredType20139320 = (719)Delegate.Combine(3._recoveredType20139320, new 719(importPendingFilesClosure.1));
					new 87(3).Method5857(text, text3, ".*");
					if (importPendingFilesClosure.2.Count + importPendingFilesClosure.1.Count > 0)
					{
						2463.10(importPendingFilesClosure.2, importPendingFilesClosure.1);
						if (!2463.9(text3))
						{
							throw new Exception("Beatmap missing required files");
						}
					}
					int length = Path.GetFullPath(<<EMPTY_NAME>>).Length;
					int num2 = text2.Length;
					if (length + text2.Length * 2 >= num)
					{
						num2 = 2672.25(text3) - text3.Length;
					}
					int num3 = length + text2.Length + num2 - 248;
					if (num3 > 0)
					{
						if (num3 >= text2.Length - 1)
						{
							throw new PathTooLongException();
						}
						text2 = text2.Remove(text2.Length - num3);
					}
					text2 = text2.TrimEnd(new char[]
					{
						' ',
						'.'
					});
					if (text2.Length == 0)
					{
						throw new PathTooLongException();
					}
					FileInfo fileInfo = new FileInfo(text);
					if ((fileInfo.Attributes & FileAttributes.ReadOnly) > (FileAttributes)0)
					{
						fileInfo.Attributes &= ~FileAttributes.ReadOnly;
					}
					string text4 = Path.Combine(<<EMPTY_NAME>>, text2);
					if (!Directory.Exists(text4))
					{
						1272.12++;
					}
					2672.22(text3, text4);
					1272.24(text4);
					2672.20(text);
				}
				catch (Exception ex)
				{
					if (!(ex is PathTooLongException) && importPendingFilesClosure.2.Count + importPendingFilesClosure.1.Count > 0)
					{
						2463.10(importPendingFilesClosure.2, importPendingFilesClosure.1);
					}
					2463.11(ex, text);
					try
					{
						Directory.Delete(text3, true);
					}
					catch
					{
					}
				}
				result = true;
				break;
			}
			case (2670)2:
			case (2670)3:
				break;
			default:
				if (5 == (2670)7)
				{
					goto IL_5E;
				}
				if (5 == (2670)14)
				{
					2672.20(text);
				}
				break;
			}
			IL_415:
			i++;
			continue;
			IL_5E:
			string fileName2 = Path.GetFileName(text);
			if (2463.5 != null)
			{
				2463.5.3(string.Format(1568.1(2679.BeatmapImport_Importing), (fileName2.Length > 50) ? (fileName2.Remove(50) + "...") : fileName2));
			}
			1272.15.EnableRaisingEvents = false;
			try
			{
				string text5 = Path.Combine(<<EMPTY_NAME>>, Path.GetFileNameWithoutExtension(text));
				if (!Directory.Exists(text5))
				{
					Directory.CreateDirectory(text5);
					1272.7.Add(text5);
					1272.12++;
				}
				text5 = Path.Combine(text5, fileName2);
				if (!2672.16(text, text5, true))
				{
					try
					{
						File.Copy(text, text5);
					}
					catch
					{
						1763.4(string.Format(1568.1(2679.BeatmapImport_FileInUse), fileName2));
					}
				}
			}
			catch (Exception 4)
			{
				2463.11(4, text);
			}
			1272.15.EnableRaisingEvents = true;
			result = true;
			goto IL_415;
		}
		return result;
	}

	// Token: 0x06002A4A RID: 10826 RVA: 0x000DEA08 File Offset: 0x000DCC08
	private static bool 9(string 1)
	{
		if (!Directory.Exists(1))
		{
			return false;
		}
		bool flag = false;
		int num = 0;
		string[] files = Directory.GetFiles(1);
		for (int i = 0; i < files.Length; i++)
		{
			2670 2 = 2672.24(files[i]);
			if (2 != (2670)0)
			{
				if (2 == (2670)7)
				{
					flag = true;
				}
			}
			else
			{
				num++;
			}
		}
		return flag && num > 0;
	}

	// Token: 0x06002A4B RID: 10827 RVA: 0x000DEA60 File Offset: 0x000DCC60
	private static void 10(List<string> 1, List<string> 2)
	{
		StringBuilder stringBuilder = new StringBuilder("Error extracting files: \n");
		foreach (string str in 1)
		{
			stringBuilder.Append(str + "\n");
		}
		foreach (string str2 in 2)
		{
			stringBuilder.Append(str2 + "\n");
		}
		1763.4(stringBuilder.ToString());
	}

	// Token: 0x06002A4C RID: 10828 RVA: 0x000DEB18 File Offset: 0x000DCD18
	private static void 11(Exception 1, string 2)
	{
		string fileName = Path.GetFileName(2);
		if (1 is PathTooLongException)
		{
			1763.4(string.Format("File path is too long. Consider renaming the file or containing directory. \nFile: {0}", fileName));
		}
		else
		{
			1763.4(string.Format(1568.1(2679.BeatmapImport_FileCorrupt), fileName));
		}
		try
		{
			Directory.CreateDirectory(1272.1());
			2672.16(2, Path.Combine(1272.1(), fileName), true);
		}
		catch
		{
		}
	}

	// Token: 0x06002A4D RID: 10829 RVA: 0x000DEB90 File Offset: 0x000DCD90
	private static void 12()
	{
		1272.25 = false;
		2463.4 = false;
		2463.6 = false;
		if (1662.78 == 1677.BeatmapImport)
		{
			1662.89(1662.90(), false, 0);
		}
		if (1662.47 && 1662.48)
		{
			1272.13();
			return;
		}
		2230.13();
		1326.4();
	}

	// Token: 0x06002A4E RID: 10830 RVA: 0x000DEBE4 File Offset: 0x000DCDE4
	public static bool 13(bool 1, 1262 2)
	{
		if (1662.30())
		{
			return false;
		}
		if (2 != null && 2463.9 == 2)
		{
			return false;
		}
		2463.9 = 2;
		2463.8 = 1;
		2463.4 = true;
		1662.89.Schedule(delegate()
		{
			1662.89(1677.BeatmapImport, true, 0);
		}, false);
		return true;
	}

	// Token: 0x04001EF3 RID: 7923
	internal static bool 4;

	// Token: 0x04001EF4 RID: 7924
	private static 2468 5;

	// Token: 0x04001EF5 RID: 7925
	private static bool 6 = true;

	// Token: 0x04001EF6 RID: 7926
	private static 373 7;

	// Token: 0x04001EF7 RID: 7927
	private static bool 8;

	// Token: 0x04001EF8 RID: 7928
	private static 1262 9;

	// Token: 0x02000562 RID: 1378
	[Serializable]
	public sealed class 2464
	{
		// Token: 0x06002A50 RID: 10832 RVA: 0x000DEC4D File Offset: 0x000DCE4D
		internal void 1(object 1, EventArgs 2)
		{
			2463.8 = false;
		}

		// Token: 0x04001EF9 RID: 7929
		public static readonly 2463.2464 instance = new 2463.2464();

		// Token: 0x04001EFA RID: 7930
		public static EventHandler eventHandler;

		// Token: 0x04001EFB RID: 7931
		public static 1189 voidDelegate;
	}

	// Token: 0x02000563 RID: 1379
	public sealed class 2467
	{
		// Token: 0x06002A53 RID: 10835 RVA: 0x000DEC64 File Offset: 0x000DCE64
		internal void 1()
		{
			2463.2465 <<EMPTY_NAME>> = new 2463.2465();
			<<EMPTY_NAME>>.1 = new 1688(1568.1(2679.BeatmapImport_FullProcess), new EventHandler(this.2), new EventHandler(this.3), false);
			<<EMPTY_NAME>>.1.3(new EventHandler(2463.2464.instance.1));
			1662.89.Schedule(new 1189(<<EMPTY_NAME>>.1), false);
		}

		// Token: 0x06002A54 RID: 10836 RVA: 0x000DECD8 File Offset: 0x000DCED8
		internal void 2(object 1, EventArgs 2)
		{
			this.1 = true;
			2463.8 = false;
		}

		// Token: 0x06002A55 RID: 10837 RVA: 0x000DECE7 File Offset: 0x000DCEE7
		internal void 3(object 1, EventArgs 2)
		{
			this.1 = false;
			2463.8 = false;
		}

		// Token: 0x04001EFC RID: 7932
		public bool 1;
	}

	// Token: 0x02000564 RID: 1380
	public sealed class 2466
	{
		// Token: 0x06002A57 RID: 10839 RVA: 0x000DECF6 File Offset: 0x000DCEF6
		internal void 1(object 1, 782 2)
		{
			if (2 != null)
			{
				this.2.Add(Path.GetFileName(2.GetText9990_12765()));
			}
		}

		// Token: 0x04001EFD RID: 7933
		public List<string> 1;

		// Token: 0x04001EFE RID: 7934
		public List<string> 2;
	}

	// Token: 0x02000565 RID: 1381
	public sealed class 2465
	{
		// Token: 0x06002A59 RID: 10841 RVA: 0x000DED11 File Offset: 0x000DCF11
		internal void 1()
		{
			1662.25(this.1);
		}

		// Token: 0x04001EFF RID: 7935
		public 1689 1;
	}

	// Token: 0x02000566 RID: 1382
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x04001F00 RID: 7936
		public static 1189 <0>__RunImport;

		// Token: 0x04001F01 RID: 7937
		public static 1189 <1>__FinishImport;
	}
}
