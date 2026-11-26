using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

// Token: 0x02000B2F RID: 2863
[ComVisible(false)]
public static class 1336
{
	// Token: 0x06004F35 RID: 20277 RVA: 0x001F49E8 File Offset: 0x001F2BE8
	public static void 1(string 1, object[] 2)
	{
		if (1336.6 == null)
		{
			1336.6 = 1338.7(1341.Update, false);
		}
		1336.6.11(string.Format(1, 2), (1114)2);
	}

	// Token: 0x06004F36 RID: 20278 RVA: 0x001F4A10 File Offset: 0x001F2C10
	public static float 2()
	{
		List<1650> obj = 1336.4;
		float result;
		lock (obj)
		{
			1336.5 = Math.Max(1336.4.Count, 1336.5);
			int num = 1336.5;
			if (num != 0)
			{
				if (num != 1)
				{
					float num2 = (float)((1336.5 - 1336.4.Count) * 100);
					foreach (1650 <<EMPTY_NAME>> in 1336.4)
					{
						num2 += <<EMPTY_NAME>>.progress;
					}
					result = num2 / (float)(1336.5 * 100) * 100f;
				}
				else
				{
					result = ((1336.4.Count > 0) ? 1336.4[0].progress : 100f);
				}
			}
			else
			{
				result = 0f;
			}
		}
		return result;
	}

	// Token: 0x06004F37 RID: 20279 RVA: 0x001F4B18 File Offset: 0x001F2D18
	public static string 3(bool 1)
	{
		switch (1336.10)
		{
		case 2665.Checking:
			return 1568.1(2679.CommonUpdater_CheckingForUpdates);
		case 2665.Updating:
		{
			List<1650> obj = 1336.4;
			lock (obj)
			{
				1336.5 = Math.Max(1336.4.Count, 1336.5);
				string str = (1 && 1336.2() > 0f) ? (" (" + ((int)1336.2()).ToString() + "%)") : string.Empty;
				if (1336.4.Count == 0 || 1336.5 == 0)
				{
					if (1336.11)
					{
						return string.Empty;
					}
					return 1568.1(2679.CommonUpdater_PerformingUpdates);
				}
				else if (1336.4.FindAll(new Predicate<1650>(1336.1337.instance.1)).Count > 1)
				{
					if (1336.5 == 1336.4.Count)
					{
						return string.Format(1568.1(2679.CommonUpdater_DownloadingRequiredFiles), 1336.5) + str;
					}
					return string.Format(1568.1(2679.CommonUpdater_DownloadingRequiredFiles2), 1336.5 - 1336.4.Count, 1336.5) + str;
				}
				else
				{
					1650 2 = 1336.4.FindLast(new Predicate<1650>(1336.1337.instance.2));
					if (2 != null)
					{
						if (2.isPatching)
						{
							return string.Format(1568.1(2679.CommonUpdater_PatchingFilePercentage), 1336.4(2.filename)) + str;
						}
						return string.Format(1568.1(2679.CommonUpdater_DownloadingFile), 1336.4(2.filename) + ((2.url_patch != null) ? "_patch" : string.Empty)) + str;
					}
					else
					{
						if (1336.4.Count == 1 && 1336.4[0].filename.Contains("auth"))
						{
							return string.Empty;
						}
						return 1568.1(2679.CommonUpdater_PerformingUpdates);
					}
				}
			}
			break;
		}
		case 2665.Error:
			if (1336.7 is 1130)
			{
				return 1568.1(2679.GameBase_UpdateFailedFrameworkVersion);
			}
			return 1568.1(2679.CommonUpdater_ErrorOccurred);
		case 2665.NeedsRestart:
			return 1568.1(2679.CommonUpdater_RestartRequired);
		}
		return 1568.1(2679.CommonUpdater_Updated);
	}

	// Token: 0x06004F38 RID: 20280 RVA: 0x001F4DAC File Offset: 0x001F2FAC
	private static string 4(string 1)
	{
		if (!1.Contains("auth"))
		{
			return 1;
		}
		return "osu!.exe";
	}

	// Token: 0x06004F39 RID: 20281 RVA: 0x001F4DC2 File Offset: 0x001F2FC2
	public static void 5(2666 1, 2667 2, ThreadPriority 3)
	{
		1336.10 = 2665.NoUpdate;
		if (1 != null)
		{
			1(2665.NoUpdate);
		}
	}

	// Token: 0x06004F3A RID: 20282 RVA: 0x001F4DD4 File Offset: 0x001F2FD4
	private static string 6(string 1, bool 2)
	{
		if (!File.Exists(1))
		{
			return null;
		}
		if (2)
		{
			try
			{
				if (!1310.2.ContainsKey("h_" + 1))
				{
					1310.2["h_" + 1] = 1336.6(1, false);
				}
				return 1310.2["h_" + 1];
			}
			catch (Exception)
			{
			}
		}
		string result;
		try
		{
			using (Stream stream = File.Open(1, FileMode.Open, FileAccess.Read, FileShare.Read))
			{
				byte[] array = MD5.Create().ComputeHash(stream);
				StringBuilder stringBuilder = new StringBuilder();
				for (int i = 0; i < array.Length; i++)
				{
					stringBuilder.Append(array[i].ToString("x2"));
				}
				result = stringBuilder.ToString();
			}
		}
		catch (Exception)
		{
			result = null;
		}
		return result;
	}

	// Token: 0x06004F3B RID: 20283 RVA: 0x001F4EC8 File Offset: 0x001F30C8
	private static bool 7(string 1, string 2, int 3, int 4, bool 5)
	{
		int millisecondsTimeout = 3 / 4;
		try
		{
			2672.20(2 + "_old");
			goto IL_5E;
		}
		catch
		{
			goto IL_5E;
		}
		IL_1A:
		try
		{
			if (5)
			{
				2672.20(2);
			}
			else
			{
				File.Delete(2);
			}
		}
		catch
		{
		}
		try
		{
			File.Move(1, 2);
			return true;
		}
		catch
		{
			try
			{
				File.Copy(1, 2, true);
				2672.20(1);
				return true;
			}
			catch
			{
			}
		}
		Thread.Sleep(millisecondsTimeout);
		IL_5E:
		if (4-- <= 0)
		{
			return false;
		}
		goto IL_1A;
	}

	// Token: 0x06004F3C RID: 20284 RVA: 0x001F4F74 File Offset: 0x001F3174
	public static bool 8(bool 1)
	{
		if (!Directory.Exists("_pending"))
		{
			return true;
		}
		1336.1("Attempting to MoveInPlace", new object[0]);
		1310.2();
		bool flag = true;
		foreach (string text in Directory.GetFiles("_pending"))
		{
			try
			{
				if (!1210.3(text) && !(Path.GetFileName(text) == "bass.dll") && Environment.OSVersion.Version.Major >= 6 && (!(Path.GetFileName(text) == "Microsoft.Ink.dll") || !(1209.1(text) == "68bc76fd41fb987b0d616d5e1c4fe936")))
				{
					1336.1("Authenticode signature check failed on {0}!", new object[]
					{
						text
					});
					2672.20(text);
				}
				else if (new FileInfo(text).Length == 0L)
				{
					2672.20(text);
				}
				else
				{
					string fileName = Path.GetFileName(text);
					if (1336.7(text, fileName, 200, 5, 1))
					{
						string text2 = 1336.6(fileName, false);
						1336.1("{0} => {1}: OK {2}", new object[]
						{
							text,
							fileName,
							text2
						});
						1310.2["h_" + fileName] = text2;
					}
					else
					{
						1336.1("{0} => {1}: FAIL", new object[]
						{
							text,
							fileName
						});
						flag = false;
					}
				}
			}
			catch
			{
				flag = false;
			}
		}
		if (!flag)
		{
			return false;
		}
		1336.9(5000, true);
		1336.1("Saving configuration...", new object[0]);
		1310.Save();
		1336.1("MoveInPlace successful!", new object[0]);
		return true;
	}

	// Token: 0x06004F3D RID: 20285 RVA: 0x001F5114 File Offset: 0x001F3314
	public static bool 9(int 1, bool 2)
	{
		if (268.SharesStableInstall)
		{
			return true;
		}
		1336.1("Running cleanup..", new object[0]);
		int num = Math.Max(2, 1 / 100);
		while (num-- > 0)
		{
			bool flag = true;
			if (2)
			{
				try
				{
					if (File.Exists("_pending"))
					{
						File.Delete("_pending");
					}
				}
				catch
				{
					1336.1("Failed to cleanup STAGING_COMPLETE", new object[0]);
					flag = false;
				}
				try
				{
					if (Directory.Exists("_pending"))
					{
						Directory.Delete("_pending", true);
					}
				}
				catch
				{
					1336.1("Failed to cleanup STAGING_COMPLETE", new object[0]);
					flag = false;
				}
			}
			try
			{
				if (File.Exists("_staging"))
				{
					File.Delete("_staging");
				}
			}
			catch
			{
				1336.1("Failed to cleanup STAGING", new object[0]);
				flag = false;
			}
			try
			{
				if (Directory.Exists("_staging"))
				{
					Directory.Delete("_staging", true);
				}
			}
			catch
			{
				1336.1("Failed to cleanup STAGING", new object[0]);
				flag = false;
			}
			if (flag)
			{
				1336.1("Cleanup successful!", new object[0]);
				return true;
			}
			Thread.Sleep(100);
		}
		return false;
	}

	// Token: 0x06004F3E RID: 20286 RVA: 0x001F5264 File Offset: 0x001F3464
	public static void 10(bool 1)
	{
		if (1)
		{
			Thread thread = 1336.1;
			if (thread != null && thread.IsAlive)
			{
				thread.Abort();
				while (thread.IsAlive)
				{
					Thread.Sleep(20);
				}
			}
			1336.1 = null;
		}
		List<1650> obj = 1336.4;
		lock (obj)
		{
			foreach (1650 2 in 1336.4)
			{
				1620 request = 2.request;
				if (request != null)
				{
					request.18();
				}
			}
			1336.4.Clear();
		}
		1336.5 = 0;
		1336.9(5000, true);
		1336.11();
		1336.1("Resetting update process", new object[0]);
	}

	// Token: 0x06004F3F RID: 20287 RVA: 0x001F5348 File Offset: 0x001F3548
	public static void 11()
	{
		1336.7 = null;
		1336.8 = string.Empty;
	}

	// Token: 0x04003B43 RID: 15171
	private static Thread 1;

	// Token: 0x04003B44 RID: 15172
	public static string 2 = "https://osu.offline.invalid/web/check-updates.php";

	// Token: 0x04003B45 RID: 15173
	public static string 3 = "https://m1.offline.invalid/release/";

	// Token: 0x04003B46 RID: 15174
	private static List<1650> 4 = new List<1650>();

	// Token: 0x04003B47 RID: 15175
	private static int 5 = 0;

	// Token: 0x04003B48 RID: 15176
	private static 1338 6;

	// Token: 0x04003B49 RID: 15177
	public static Exception 7;

	// Token: 0x04003B4A RID: 15178
	public static string 8 = string.Empty;

	// Token: 0x04003B4B RID: 15179
	public static 2667 9;

	// Token: 0x04003B4C RID: 15180
	public static 2665 10;

	// Token: 0x04003B4D RID: 15181
	private static bool 11 = false;

	// Token: 0x04003B4E RID: 15182
	private static object 12 = new object();

	// Token: 0x02000B30 RID: 2864
	[Serializable]
	public sealed class 1337
	{
		// Token: 0x06004F41 RID: 20289 RVA: 0x001F539A File Offset: 0x001F359A
		internal bool 1(1650 1)
		{
			return 1.isDownloading && !1.filename.Contains("auth");
		}

		// Token: 0x06004F42 RID: 20290 RVA: 0x001F539A File Offset: 0x001F359A
		internal bool 2(1650 1)
		{
			return 1.isDownloading && !1.filename.Contains("auth");
		}

		// Token: 0x04003B4F RID: 15183
		public static readonly 1336.1337 instance = new 1336.1337();

		// Token: 0x04003B50 RID: 15184
		public static Predicate<1650> predicate;

		// Token: 0x04003B51 RID: 15185
		public static Predicate<1650> predicate2;

		// Token: 0x04003B52 RID: 15186
		public static ThreadStart threadStart;

		// Token: 0x04003B53 RID: 15187
		public static Action<1650> action;
	}
}
