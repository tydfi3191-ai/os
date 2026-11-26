using System;

// Token: 0x020006F5 RID: 1781
public static class 2173
{
	// Token: 0x060034BC RID: 13500 RVA: 0x00144418 File Offset: 0x00142618
	public static double 1(2170 1, 2173.2174 2)
	{
		if (1 == null)
		{
			return 0.0;
		}
		int 3 = 2.2;
		int num = Math.Max(0, 2.4);
		int num2 = 3 + 2.3 + num;
		double 4 = 1.10;
		double? num3 = (3 == 0 || 4 <= 0.0 || num2 == 0) ? null : new double?(2173.5((double)3 / (double)num2, num2, 4) * 10.0);
		double num4 = (double)num2 * 1.9;
		bool 5 = 1.12;
		double num5 = 2173.3(2, 1, 5, true, num3, num2, num4, 4) * 1.08;
		double num6 = 2173.4(2, 1, 5, num3, num2, num4, 4) * 1.1;
		return num5 + num6;
	}

	// Token: 0x060034BD RID: 13501 RVA: 0x001444DE File Offset: 0x001426DE
	private static bool 2(2173.2174 1, 2023 2)
	{
		return (1.1 & 2) > 2023.None;
	}

	// Token: 0x060034BE RID: 13502 RVA: 0x001444EC File Offset: 0x001426EC
	private static double 3(2173.2174 1, 2170 2, bool 3, bool 4, double? 5, int 6, double 7, double 8)
	{
		if (5 == null || 7 == 0.0)
		{
			return 0.0;
		}
		double num = 2173.5(1.0, 6, 8) * 10.0;
		double num2 = 2173.5(0.8, 6, 8) * 10.0;
		double num3 = 1897.10(2.4 / 2.3, 0.15, 0.4);
		double num4 = 1.0 - 1897.3(5.Value, (num + num2) / 2.0, 10.0 / (num2 - num), 0.25 * 1897.12(num3, 3));
		double num5 = 5.0 * Math.Max(1.0, 2.3 * num4 / 0.11) - 4.0;
		double num6 = Math.Min(1897.12(num5, 3) / 69052.51, 1897.11(num5, 2.25) / 1250.0);
		num6 *= 1.0 + 0.1 * Math.Max(0.0, 2.3 - 10.0);
		double num7 = 1.0 + 0.25 * 7 / (7 + 4000.0);
		num6 *= num7;
		double num8 = 0.97 + 0.03 * 7 / (7 + 1500.0);
		num6 *= 1897.12(num8, Math.Max(0, 1.4));
		if (2173.2(1, 2023.Hidden))
		{
			double num9 = 3 ? 0.025 : 0.1;
			if (!2173.2(1, 2023.Flashlight))
			{
				if (!4)
				{
					num9 *= 0.2;
				}
				if (2173.2(1, 2023.Easy) && 4)
				{
					num9 *= 0.5;
				}
			}
			num6 *= 1.0 + num9;
		}
		if (2173.2(1, 2023.Flashlight))
		{
			num6 *= Math.Max(1.0, 1.05 - Math.Min(2.8 / 50.0, 1.0) * num7);
		}
		double 9 = 2.0 + 2.8;
		double num10 = 500.0 - 100.0 * (2.8 * 3.0);
		return num6 * 1897.11(1897.15(num10 / (1.414213562373095 * 5.Value)), 9);
	}

	// Token: 0x060034BF RID: 13503 RVA: 0x001447D4 File Offset: 0x001429D4
	private static double 4(2173.2174 1, 2170 2, bool 3, double? 4, int 5, double 6, double 7)
	{
		if (7 <= 0.0 || 4 == null)
		{
			return 0.0;
		}
		double num = 470.0 * 1897.11(0.9885, 4.Value);
		num *= 1.0 + 1897.12(50.0 / 4.Value, 2) * 1897.11(2.3, 2.8) / 600.0;
		if (2173.2(1, 2023.Hidden) && !3)
		{
			num *= 1.075;
		}
		num *= 1.0 + 0.3 * 6 / (6 + 4000.0);
		double num2 = Math.Min(1.15, 1897.11((double)5 / 1500.0, 0.3));
		if (2173.2(1, 2023.Flashlight) && 2173.2(1, 2023.Hidden) && !3)
		{
			num *= Math.Max(1.0, 1.05 * num2);
		}
		return num;
	}

	// Token: 0x060034C0 RID: 13504 RVA: 0x00144904 File Offset: 0x00142B04
	private static double 5(double 1, int 2, double 3)
	{
		double num = (double)2;
		double num2 = (num * 1 + 2.7059472155252142) / (num + 5.4118944310504284) - 2.32634787404 / (num + 5.4118944310504284) * Math.Sqrt(num * 1 * (1.0 - 1) + 1.3529736077626071);
		return 3 / (1.414213562373095 * 1897.16(num2));
	}

	// Token: 0x0400272C RID: 10028
	private const double 1 = 1.414213562373095;

	// Token: 0x020006F6 RID: 1782
	public struct 2174
	{
		// Token: 0x0400272D RID: 10029
		public 2023 1;

		// Token: 0x0400272E RID: 10030
		public int 2;

		// Token: 0x0400272F RID: 10031
		public int 3;

		// Token: 0x04002730 RID: 10032
		public int 4;
	}
}
