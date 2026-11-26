using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

// Token: 0x020006ED RID: 1773
public static class 2162
{
	// Token: 0x06003497 RID: 13463 RVA: 0x0014354C File Offset: 0x0014174C
	public static double 1(1896 1, double 2)
	{
		1911 3 = ((1919)1).13;
		double num = 0.0;
		double num2 = 0.0;
		double num3 = 0.0;
		double num4 = 0.0;
		1907 4 = 3.1;
		if (((4 != null) ? 4.1() : null) == 1)
		{
			num += 10.0 * 2162.2(3.1, 2);
			num3 = 2162.3(3.1, 2, 0.1);
			num4 = 2162.4(3.1.2);
		}
		1909 5 = 3.2;
		if (((5 != null) ? 5.5() : null) == 1)
		{
			num2 += 1.15 * 2162.5(3.2.4(), 8);
		}
		return 0.0 + Math.Max(num, num2) * num3 * num4;
	}

	// Token: 0x06003498 RID: 13464 RVA: 0x00143630 File Offset: 0x00141830
	private static double 2(1907 1, double 2)
	{
		double num = 2162.5(1.4, 8);
		1907 3 = 1.2;
		double? num2 = (3 != null) ? 3.3 : null;
		num *= 2162.3(1, 2, 0.1);
		if (num2 != null && 1.1.Count > 1)
		{
			double num3 = num2.Value * (double)1.1.Count;
			double num4 = 1.3() - num3;
			if (num4 > 0.0)
			{
				num *= 1897.3(num4 / 2, 0.35, 2.0, 1.0);
			}
		}
		num *= 1897.3(1.3() / 2, 0.3, 2.0, 1.0);
		return 1897.11(num, 0.75);
	}

	// Token: 0x06003499 RID: 13465 RVA: 0x0014371C File Offset: 0x0014191C
	private static double 3(1907 1, double 2, double 3)
	{
		2162.2163 4 = default(2162.2163);
		4.1 = 3;
		double val = 2162.7(1, 3, ref 4);
		double val2 = (1.1.Count < 6) ? 2162.7(1, 4, ref 4) : 1.0;
		double num = Math.Max(1.0 - 1.3() * 2.0 / 2, 0.5);
		return Math.Min(val, val2) * num;
	}

	// Token: 0x0600349A RID: 13466 RVA: 0x00143798 File Offset: 0x00141998
	private static double 4(1907 1)
	{
		if (1 == null)
		{
			return 1.0;
		}
		double 2 = 1.1().4;
		double valueOrDefault = 1.3.GetValueOrDefault(2);
		double 3 = (double)1.1.Count;
		double num = 1897.3(2 / Math.Max(valueOrDefault, 1.0), 1.75, 20.0, 1.0);
		double num2 = 1897.10(3, 8.0, 2.0);
		return 1.0 - 0.75 * num * num2;
	}

	// Token: 0x0600349B RID: 13467 RVA: 0x0014383C File Offset: 0x00141A3C
	private static double 5(double 1, int 2)
	{
		double num = 0.0;
		1 = ((double.IsNaN(1) || double.IsInfinity(1)) ? 0.0 : 1);
		for (int i = 1; i <= 2; i++)
		{
			num += 2162.6(1, i, 4.0, 1.0);
		}
		num += (double)2 / (1.0 + 1);
		num += 1897.6(1, 1.0, 0.5, 1.0);
		num -= 1897.6(1, 1.0, 0.3, 1.0);
		num = Math.Max(num, 0.0);
		return num / Math.Sqrt(8.0);
	}

	// Token: 0x0600349C RID: 13468 RVA: 0x00143912 File Offset: 0x00141B12
	private static double 6(double 1, int 2, double 3, double 4)
	{
		return (0.0 - 4) * 1897.11(Math.Cos((double)2 * 3.141592653589793 * 1), 3);
	}

	// Token: 0x0600349D RID: 13469 RVA: 0x0014393C File Offset: 0x00141B3C
	internal static double 7(1907 1, int 2, ref 2162.2163 3)
	{
		List<double?> list = new List<double?>();
		1907 4 = 1;
		int num = 0;
		while (num < 2 && 4 != null)
		{
			list.Add(4.3);
			4 = 4.2;
			num++;
		}
		list.RemoveAll(new Predicate<double?>(2162.2164.instance.1));
		if (list.Count < 2)
		{
			return 1.0;
		}
		for (int i = 0; i < list.Count; i++)
		{
			for (int j = i + 1; j < list.Count; j++)
			{
				double num2 = list[i].Value / list[j].Value;
				if (Math.Abs(1.0 - num2) <= 3.1)
				{
					return 0.8;
				}
			}
		}
		return 1.0;
	}

	// Token: 0x020006EE RID: 1774
	[Serializable]
	public sealed class 2164
	{
		// Token: 0x0600349E RID: 13470 RVA: 0x00143A15 File Offset: 0x00141C15
		internal bool 1(double? 1)
		{
			return 1 == null;
		}

		// Token: 0x0400270D RID: 9997
		public static readonly 2162.2164 instance = new 2162.2164();

		// Token: 0x0400270E RID: 9998
		public static Predicate<double?> predicate;
	}

	// Token: 0x020006EF RID: 1775
	[StructLayout(LayoutKind.Auto)]
	public struct 2163
	{
		// Token: 0x0400270F RID: 9999
		public double 1;
	}
}
