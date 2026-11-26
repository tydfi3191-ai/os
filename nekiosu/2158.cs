using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x020006EA RID: 1770
public static class 2158
{
	// Token: 0x0600348F RID: 13455 RVA: 0x00143290 File Offset: 0x00141490
	private static double 1(1919 1, double 2, int 3)
	{
		2158.2159 CS_0024_003C_003E8__locals5 = new 2158.2159();
		int num = 0;
		double num2 = 0.0;
		CS_0024_003C_003E8__locals5.1 = new List<double>();
		1919 4 = 9;
		1919 5 = (1919)4.1(1);
		int num3 = 0;
		while (num3 < 3 && 4.8 > 1)
		{
			double 6 = 4.13.3;
			double 7 = 5.13.3;
			CS_0024_003C_003E8__locals5.1.Add(6);
			if (Math.Abs(1.0 - 6 / 7) <= 2)
			{
				num++;
				num2 += 6;
				break;
			}
			4 = 5;
			num3++;
		}
		if (num > 0)
		{
			return 1.0 - num2 / (double)(num + 1) * 0.8;
		}
		if (CS_0024_003C_003E8__locals5.1.Count <= 1)
		{
			return 1.0;
		}
		double 8 = CS_0024_003C_003E8__locals5.1.Max((double 1) => Math.Abs(1 - CS_0024_003C_003E8__locals5.1.Average()));
		return 0.7 + 0.3 * 1897.9(8, 0.0, 1.0);
	}

	// Token: 0x06003490 RID: 13456 RVA: 0x001433CC File Offset: 0x001415CC
	public static double 2(1896 1)
	{
		1919 2 = (1919)1;
		1900 3 = 2.14;
		double num = 0.0;
		1886 4 = 3.1;
		if (((4 != null) ? 4.2() : null) == 1)
		{
			num += 2158.3(3.1);
		}
		1899 5 = 3.2;
		if (((5 != null) ? 5.1() : null) == 1)
		{
			num += 2158.4(3.2);
		}
		1902 6 = 3.3;
		if (((6 != null) ? 6.1() : null) == 1)
		{
			num += 2158.5(3.3);
		}
		double num2 = 2158.1(2, 0.01, 64);
		return num * num2;
	}

	// Token: 0x06003491 RID: 13457 RVA: 0x00143470 File Offset: 0x00141670
	private static double 3(1886 1)
	{
		return 1897.4(2.718281828459045 * (double)1.3 - 5.43656365691809, 1.0) * 2158.4(1.2) * 0.5;
	}

	// Token: 0x06003492 RID: 13458 RVA: 0x001434BC File Offset: 0x001416BC
	private static double 4(1899 1)
	{
		return 1897.4(2.718281828459045 * (double)1.3 - 5.43656365691809, 1.0) * 2158.5(1.2);
	}

	// Token: 0x06003493 RID: 13459 RVA: 0x001434F3 File Offset: 0x001416F3
	private static double 5(1902 1)
	{
		return 2.0 * (1.0 - 1897.4(2.718281828459045 * (double)1.2() - 5.43656365691809, 1.0));
	}

	// Token: 0x020006EB RID: 1771
	public sealed class 2159
	{
		// Token: 0x0400270B RID: 9995
		public List<double> 1;
	}
}
