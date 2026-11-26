using System;

// Token: 0x02000768 RID: 1896
public static class 2009
{
	// Token: 0x060037A2 RID: 14242 RVA: 0x0015C670 File Offset: 0x0015A870
	internal static void 1(bool 1)
	{
		int num;
		if (1272.5() == null)
		{
			num = 1304.150.6();
			2009.5 = 100.0;
		}
		else
		{
			num = ((1304.151 && 1272.5().92 > 0) ? 1272.5().92 : 1304.150.6());
			2009.5 = (double)1272.5().86().Z;
		}
		2009.1 = false;
		2009.2((double)num, 1, (1984)0);
	}

	// Token: 0x060037A3 RID: 14243 RVA: 0x0015C6F4 File Offset: 0x0015A8F4
	internal static bool 2(double 1, bool 2, 1984 3)
	{
		if (!2 && 2009.1)
		{
			return false;
		}
		2023 4 = (1535.1() && 1535.39 != null) ? 1535.39.8.1() : 2019.1;
		double num = 2009.5;
		2023 5 = 2023.DoubleTime;
		double num2;
		if ((4 & 5) <= 2023.None)
		{
			5 = 2023.HalfTime;
			num2 = (((4 & 5) > 2023.None) ? 1939.19(2023.HalfTime) : 1.0);
		}
		else
		{
			num2 = 1939.19(2023.DoubleTime);
		}
		2009.4 = num * num2;
		double num3 = 2009.3;
		if (3 == (1984)1)
		{
			2009.3 = 1;
			2009.2 = 1052.18((int)Math.Round(2009.3 * (1304.152 ? 1.0 : (2009.4 / 100.0))), 1, 40);
		}
		else
		{
			2009.2 = 1052.18((int)Math.Round(1), 1, 40);
			2009.3 = (double)2009.2 * (1304.152 ? 1.0 : (100.0 / Math.Max(2009.4, 1.0)));
		}
		if (2)
		{
			2009.1 = true;
			if (!1535.1())
			{
				1304.150.7(2009.2);
				if (1272.5() != null && 1304.151)
				{
					1272.5().92 = 2009.2;
				}
			}
		}
		return 2009.3 != num3;
	}

	// Token: 0x060037A4 RID: 14244 RVA: 0x0015C868 File Offset: 0x0015AA68
	internal static void 3(int 1)
	{
		2009.2((double)(2009.2 + 1), true, (1984)0);
		1763.2(string.Format(1568.1(2679.ConfigMania_OsuManiaSpeedSet), 2009.4()), 1750, (1389)0);
	}

	// Token: 0x060037A5 RID: 14245 RVA: 0x0015C899 File Offset: 0x0015AA99
	internal static string 4()
	{
		return string.Format("{0:0} ({1})", 2009.2, 1304.152 ? 1568.1(2679.ConfigMania_BPMscale) : 1568.1(2679.ConfigMania_Fixed));
	}

	// Token: 0x060037A6 RID: 14246 RVA: 0x0015C8D4 File Offset: 0x0015AAD4
	internal static double 5(int 1)
	{
		2039 2 = null;
		if (1662.78 == 1677.Play)
		{
			2 = 2486.7.39;
		}
		else if (1662.78 == 1677.Edit)
		{
			2 = 2263.4.7;
		}
		if (2 == null)
		{
			return 1226.88((double)1, 1272.5().3() == 2147.OsuMania);
		}
		return 2.21.90((double)1, 2.21.3() == 2147.OsuMania);
	}

	// Token: 0x060037A7 RID: 14247 RVA: 0x0015C93E File Offset: 0x0015AB3E
	internal static double 6(double 1, double 2)
	{
		return 21.0 * 2009.3 * 2 / 1;
	}

	// Token: 0x060037A8 RID: 14248 RVA: 0x0015C953 File Offset: 0x0015AB53
	internal static double 7(int 1, int 2)
	{
		return (double)2 * 2009.5(1) / 21.0 / 2009.3;
	}

	// Token: 0x060037A9 RID: 14249 RVA: 0x0015C96E File Offset: 0x0015AB6E
	internal static double 8(double 1, double 2)
	{
		return 2 * 1 / 21.0 / 2009.3;
	}

	// Token: 0x0400293C RID: 10556
	private static bool 1;

	// Token: 0x0400293D RID: 10557
	internal static int 2 = 12;

	// Token: 0x0400293E RID: 10558
	internal static double 3;

	// Token: 0x0400293F RID: 10559
	internal static double 4;

	// Token: 0x04002940 RID: 10560
	private static double 5;
}
