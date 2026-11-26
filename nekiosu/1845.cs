using System;

// Token: 0x020007D8 RID: 2008
public static class 1845
{
	// Token: 0x06003A5A RID: 14938 RVA: 0x0016F29C File Offset: 0x0016D49C
	public static double 1(1841 1, 1845.1846 2)
	{
		if (1 == null)
		{
			return 0.0;
		}
		int num = Math.Max(0, 2.6);
		double 3 = (double)Math.Max(0, Math.Min(1.4, 2.7));
		double num2 = 1897.11(5.0 * Math.Max(1.0, 1.3 / 0.0049) - 4.0, 2.0) / 100000.0;
		int num3 = num + 2.3 + 2.2;
		double num4 = 0.95 + 0.3 * Math.Min(1.0, (double)num3 / 2500.0) + ((num3 > 2500) ? (Math.Log10((double)num3 / 2500.0) * 0.475) : 0.0);
		num2 *= num4;
		num2 *= 1897.12(0.97, num);
		if (1.4 > 0)
		{
			num2 *= Math.Min(1897.11(3, 0.35) / 1897.11((double)1.4, 0.35), 1.0);
		}
		double num5 = 1845.2(1.5, 1800.0, 1200.0, 450.0) / 1.6;
		double num6 = (num5 > 1200.0) ? (-(num5 - 1800.0) / 120.0) : (-(num5 - 1200.0) / 150.0 + 5.0);
		double num7 = 1.0;
		if (num6 > 9.0)
		{
			num7 += 0.1 * (num6 - 9.0);
		}
		if (num6 > 10.0)
		{
			num7 += 0.1 * (num6 - 10.0);
		}
		else if (num6 < 8.0)
		{
			num7 += 0.025 * (8.0 - num6);
		}
		num2 *= num7;
		if ((2.1 & 2023.Hidden) != 2023.None)
		{
			if (num6 <= 10.0)
			{
				num2 *= 1.05 + 0.075 * (10.0 - num6);
			}
			else if (num6 > 10.0)
			{
				num2 *= 1.01 + 0.04 * (11.0 - Math.Min(11.0, num6));
			}
		}
		if ((2.1 & 2023.Flashlight) != 2023.None)
		{
			num2 *= 1.35 * num4;
		}
		int num8 = 2.4 + 2.3 + 2.2 + num + 2.5;
		double 4 = (num8 == 0) ? 0.0 : Math.Max(0.0, Math.Min(1.0, (double)(2.4 + 2.3 + 2.2) / (double)num8));
		num2 *= 1897.11(4, 5.5);
		if ((2.1 & 2023.NoFail) != 2023.None)
		{
			num2 *= Math.Max(0.9, 1.0 - 0.02 * (double)num);
		}
		return num2;
	}

	// Token: 0x06003A5B RID: 14939 RVA: 0x0016F630 File Offset: 0x0016D830
	private static double 2(double 1, double 2, double 3, double 4)
	{
		if (1 > 5.0)
		{
			return 3 + (4 - 3) * ((1 - 5.0) / 5.0);
		}
		if (1 < 5.0)
		{
			return 3 + (3 - 2) * ((1 - 5.0) / 5.0);
		}
		return 3;
	}

	// Token: 0x020007D9 RID: 2009
	public struct 1846
	{
		// Token: 0x04002B04 RID: 11012
		public 2023 1;

		// Token: 0x04002B05 RID: 11013
		public int 2;

		// Token: 0x04002B06 RID: 11014
		public int 3;

		// Token: 0x04002B07 RID: 11015
		public int 4;

		// Token: 0x04002B08 RID: 11016
		public int 5;

		// Token: 0x04002B09 RID: 11017
		public int 6;

		// Token: 0x04002B0A RID: 11018
		public int 7;
	}
}
