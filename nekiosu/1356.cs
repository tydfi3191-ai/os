using System;
using System.Runtime.CompilerServices;

// Token: 0x02000A75 RID: 2677
public static class 1356
{
	// Token: 0x06004A3C RID: 19004 RVA: 0x001D7060 File Offset: 0x001D5260
	internal static bool 1()
	{
		if (!1304.65)
		{
			return true;
		}
		try
		{
			if (1356.8 != null)
			{
				1356.8.Dispose();
			}
			1356.8 = new 1415(1662.70.1, 1662.70.2, null);
			if (1356.9 != null)
			{
				1356.9.Dispose();
			}
			1356.9 = 1425.6(1510.Texture2D, 1049.Bloom, false);
			1189 <<EMPTY_NAME>>;
			if ((<<EMPTY_NAME>> = 1356.<>O.<0>__OnResized) == null)
			{
				<<EMPTY_NAME>> = (1356.<>O.<0>__OnResized = new 1189(1356.2));
			}
			1662.77(<<EMPTY_NAME>>);
			1189 2;
			if ((2 = 1356.<>O.<0>__OnResized) == null)
			{
				2 = (1356.<>O.<0>__OnResized = new 1189(1356.2));
			}
			1662.76(2);
		}
		catch
		{
			1304.66.2(false);
			1763.4(1568.1(2679.BloomRenderer_InitializationFailed));
		}
		return true;
	}

	// Token: 0x06004A3D RID: 19005 RVA: 0x001D7144 File Offset: 0x001D5344
	private static void 2()
	{
		1356.1();
	}

	// Token: 0x06004A3E RID: 19006 RVA: 0x001D714C File Offset: 0x001D534C
	internal static void 3()
	{
		if (1304.66 || 1356.4)
		{
			if (1356.8 == null)
			{
				1356.1();
			}
			1356.8.10();
		}
	}

	// Token: 0x06004A3F RID: 19007 RVA: 0x001D7178 File Offset: 0x001D5378
	internal static void 4()
	{
		if (!1304.66 && !1356.4)
		{
			return;
		}
		1356.8.11();
		try
		{
			if (1379.19)
			{
				1379.35(1, 0);
				1356.8.5().Draw(208.Zero, 208.Zero, 198.White, new 208(1f, -1f), 0f, null, null);
			}
			1379.35(770, 771);
			1356.9.3();
			if (1304.66)
			{
				1356.9.1["mag"] = 0.004f;
				1356.9.1["alpha"] = 0.15f;
				1356.9.1["hirange"] = false;
				1356.9.1["redtint"] = 0f;
				1356.8.5().Draw(208.Zero, 208.Zero, 198.White, new 208(1f, -1f), 0f, null, null);
			}
			if (1356.4)
			{
				1356.9.1["mag"] = 1356.6;
				1356.9.1["alpha"] = 1356.2;
				1356.9.1["hirange"] = 1356.5;
				1356.9.1["redtint"] = 1356.7;
				if (1356.1)
				{
					1379.35(770, 1);
				}
				1356.8.5().Draw(208.Zero, 208.Zero, 198.White, new 208(1f, -1f), 0f, null, null);
				if (1356.1)
				{
					1379.35(770, 771);
				}
			}
			1356.9.4();
		}
		catch
		{
		}
	}

	// Token: 0x0400374E RID: 14158
	internal static bool 1;

	// Token: 0x0400374F RID: 14159
	internal static float 2 = 0.2f;

	// Token: 0x04003750 RID: 14160
	internal static 198 3 = 198.White;

	// Token: 0x04003751 RID: 14161
	internal static bool 4;

	// Token: 0x04003752 RID: 14162
	internal static bool 5;

	// Token: 0x04003753 RID: 14163
	internal static float 6 = 0.004f;

	// Token: 0x04003754 RID: 14164
	internal static float 7;

	// Token: 0x04003755 RID: 14165
	private static 1415 8;

	// Token: 0x04003756 RID: 14166
	private static 1426 9;

	// Token: 0x02000A76 RID: 2678
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x04003757 RID: 14167
		public static 1189 <0>__OnResized;
	}
}
