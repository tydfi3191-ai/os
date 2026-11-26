using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

// Token: 0x02000B36 RID: 2870
[ComVisible(false)]
public sealed class 1338
{
	// Token: 0x06004F4E RID: 20302 RVA: 0x001F54D6 File Offset: 0x001F36D6
	private 1338(1341 1 = 1341.Runtime)
	{
		this.9(1);
	}

	// Token: 0x06004F4F RID: 20303 RVA: 0x001F54E5 File Offset: 0x001F36E5
	public static void 1(string 1)
	{
		1338.directory = 1;
		1338.directoryExists = null;
	}

	// Token: 0x06004F50 RID: 20304 RVA: 0x001F54F8 File Offset: 0x001F36F8
	public static void 2(string 1)
	{
		if (!string.IsNullOrEmpty(1))
		{
			List<string> obj = 1338.maskedStrings;
			lock (obj)
			{
				if (!1338.maskedStrings.Contains(1))
				{
					1338.maskedStrings.Add(1);
				}
			}
		}
	}

	// Token: 0x06004F51 RID: 20305 RVA: 0x001F5554 File Offset: 0x001F3754
	public static string 3(string 1)
	{
		List<string> obj = 1338.maskedStrings;
		lock (obj)
		{
			foreach (string text in 1338.maskedStrings)
			{
				1 = 1.Replace(text, string.Empty.PadRight(text.Length, '*'));
			}
		}
		return 1;
	}

	// Token: 0x06004F52 RID: 20306 RVA: 0x001F55E4 File Offset: 0x001F37E4
	public static void 4(Exception 1, string 2, 1341 3)
	{
		1338.5("ERROR: " + 2, 3, (1114)3);
		1338.5(1.ToString(), 3, (1114)3);
	}

	// Token: 0x06004F53 RID: 20307 RVA: 0x001F5608 File Offset: 0x001F3808
	public static void 5(string 1, 1341 2, 1114 3)
	{
		try
		{
			1338.7(2, true).11(1, 3);
		}
		catch
		{
		}
	}

	// Token: 0x06004F54 RID: 20308 RVA: 0x001F5638 File Offset: 0x001F3838
	public static void 6(string 1, 1341 2, 1114 3)
	{
		1338.5(1, 2, 3);
	}

	// Token: 0x06004F55 RID: 20309 RVA: 0x001F5644 File Offset: 0x001F3844
	public static 1338 7(1341 1, bool 2)
	{
		1338 3;
		if (!1338.logsByCategory.TryGetValue(1, out 3))
		{
			3 = (1338.logsByCategory[1] = new 1338(1));
			if (2)
			{
				3.12(null);
			}
		}
		return 3;
	}

	// Token: 0x06004F56 RID: 20310 RVA: 0x001F5680 File Offset: 0x001F3880
	public 1341 8()
	{
		return this.category;
	}

	// Token: 0x06004F57 RID: 20311 RVA: 0x001F5688 File Offset: 0x001F3888
	private void 9(1341 1)
	{
		this.category = 1;
	}

	// Token: 0x06004F58 RID: 20312 RVA: 0x001F5694 File Offset: 0x001F3894
	public string 10()
	{
		return Path.Combine(1338.directory, this.8().ToString().ToLower() + ".log");
	}

	// Token: 0x06004F59 RID: 20313 RVA: 0x001F56D0 File Offset: 0x001F38D0
	public void 11(string 1, 1114 2)
	{
		1338.1340 3 = new 1338.1340();
		3.1 = this;
		if (2 >= (1114)2 && 2 > (1114)0 && 1338.isEnabled)
		{
			1 = 1338.3(1);
			3.2 = 1.TrimEnd(Array.Empty<char>()).Replace("\\r\\n", "\\n").Split(new char[]
			{
				'\n'
			});
			for (int i = 0; i < 3.2.Length; i++)
			{
				string text = 3.2[i];
				3.2[i] = string.Format("{0:s}: {1}", DateTime.UtcNow, text.Trim());
			}
			1338.scheduler.Schedule(new 1189(3.1), true);
		}
	}

	// Token: 0x06004F5A RID: 20314 RVA: 0x001F5790 File Offset: 0x001F3990
	public void 12(string 1)
	{
		1338.1339 2 = new 1338.1339();
		2.1 = 1;
		2.2 = this;
		1338.scheduler.Schedule(new 1189(2.1), true);
		this.13();
	}

	// Token: 0x06004F5B RID: 20315 RVA: 0x001F57D0 File Offset: 0x001F39D0
	private void 13()
	{
		this.11("----------------------------------------------------------", (1114)1);
		this.11(string.Format("{0} Log for {1}", this.8(), 1338.userName), (1114)1);
		this.11("osu! version " + 1338.gameVersion, (1114)1);
		this.11(string.Format("Running on {0}, {1} cores", Environment.OSVersion, Environment.ProcessorCount), (1114)1);
		this.11("----------------------------------------------------------", (1114)1);
	}

	// Token: 0x06004F5C RID: 20316 RVA: 0x001F584C File Offset: 0x001F3A4C
	private void 14()
	{
		if (1338.directoryExists != null)
		{
			return;
		}
		try
		{
			1338.directoryExists = new bool?(Directory.CreateDirectory(1338.directory) != null);
		}
		catch
		{
			1338.directoryExists = new bool?(false);
		}
	}

	// Token: 0x04003B58 RID: 15192
	public static bool isEnabled = true;

	// Token: 0x04003B59 RID: 15193
	public static string userName = Environment.UserName;

	// Token: 0x04003B5A RID: 15194
	public static string gameVersion = "unknown";

	// Token: 0x04003B5B RID: 15195
	private 1341 category;

	// Token: 0x04003B5C RID: 15196
	private static List<string> maskedStrings = new List<string>();

	// Token: 0x04003B5D RID: 15197
	private static Dictionary<1341, 1338> logsByCategory = new Dictionary<1341, 1338>();

	// Token: 0x04003B5E RID: 15198
	private static 2663 scheduler = new 2663(50);

	// Token: 0x04003B5F RID: 15199
	private static bool? directoryExists;

	// Token: 0x04003B60 RID: 15200
	private static string directory;

	// Token: 0x02000B37 RID: 2871
	public sealed class 1339
	{
		// Token: 0x06004F5E RID: 20318 RVA: 0x001F58DC File Offset: 0x001F3ADC
		internal void 1()
		{
			if (!string.IsNullOrEmpty(this.1))
			{
				2672.16(this.2.10(), this.2.10().Replace(".log", "_" + this.1 + ".log"), true);
				return;
			}
			2672.20(this.2.10());
		}

		// Token: 0x04003B61 RID: 15201
		public string 1;

		// Token: 0x04003B62 RID: 15202
		public 1338 2;
	}

	// Token: 0x02000B38 RID: 2872
	public sealed class 1340
	{
		// Token: 0x06004F60 RID: 20320 RVA: 0x001F5944 File Offset: 0x001F3B44
		internal void 1()
		{
			this.1.14();
			if (!1338.directoryExists.Value)
			{
				return;
			}
			try
			{
				File.AppendAllLines(this.1.10(), this.2);
			}
			catch
			{
			}
		}

		// Token: 0x04003B63 RID: 15203
		public 1338 1;

		// Token: 0x04003B64 RID: 15204
		public string[] 2;
	}
}
