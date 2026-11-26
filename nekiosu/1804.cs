using System;
using System.IO;

// Token: 0x02000877 RID: 2167
internal static class 1804
{
	// Token: 0x06003E8F RID: 16015 RVA: 0x0018681C File Offset: 0x00184A1C
	internal static bool 1()
	{
		bool flag;
		if (261.21(out flag))
		{
			if (flag)
			{
				2463.2(false);
			}
			return flag;
		}
		1763.5("Local folder refresh could not finish. Please try again.", 198.OrangeRed, 4000, null);
		return false;
	}

	// Token: 0x06003E90 RID: 16016 RVA: 0x00186853 File Offset: 0x00184A53
	internal static void 2()
	{
		if (1662.81 == 1677.BeatmapImport)
		{
			return;
		}
		if (1804.1())
		{
			2463.2(false);
		}
	}

	// Token: 0x06003E91 RID: 16017 RVA: 0x0018686C File Offset: 0x00184A6C
	internal static void 3(string 1)
	{
		if (!261.18(1))
		{
			1804.6();
		}
	}

	// Token: 0x06003E92 RID: 16018 RVA: 0x0018687B File Offset: 0x00184A7B
	internal static void 4(string 1)
	{
		if (!261.19(1))
		{
			1804.6();
		}
	}

	// Token: 0x06003E93 RID: 16019 RVA: 0x0018688A File Offset: 0x00184A8A
	internal static void 5(string 1, string 2)
	{
		if (string.IsNullOrEmpty(2) && !string.IsNullOrEmpty(1) && !1.StartsWith("\\\\", StringComparison.Ordinal) && (Directory.Exists(1) || File.Exists(1)) && 261.17(1))
		{
			return;
		}
		1804.6();
	}

	// Token: 0x06003E94 RID: 16020 RVA: 0x001868C8 File Offset: 0x00184AC8
	private static void 6()
	{
		1763.5("This location cannot be opened by the offline build.", 198.OrangeRed, 4000, null);
	}

	// Token: 0x06003E95 RID: 16021 RVA: 0x001868E0 File Offset: 0x00184AE0
	internal static void 7()
	{
		if (1272.3 == null || 1662.30() || 1662.33 < 1804.1)
		{
			return;
		}
		1804.1 = 1662.33 + 250;
		string text;
		if (261.28(out text))
		{
			1804.8(new string[]
			{
				text
			});
		}
	}

	// Token: 0x06003E96 RID: 16022 RVA: 0x00186930 File Offset: 0x00184B30
	internal static void 8(string[] 1)
	{
		if (1 == null)
		{
			return;
		}
		foreach (string text in 1)
		{
			if (!string.IsNullOrEmpty(text) && File.Exists(text))
			{
				string a = Path.GetExtension(text).ToLowerInvariant();
				if (!(a != ".osu") || !(a != ".osz") || !(a != ".osk") || !(a != ".osr"))
				{
					1677 2 = 1662.65(new string[]
					{
						text
					});
					if (2 != 1677.Unknown)
					{
						1662.SetMode(2, true);
					}
				}
			}
		}
	}

	// Token: 0x04002DC7 RID: 11719
	private static int 1;
}
