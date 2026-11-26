using System;

// Token: 0x02000723 RID: 1827
[276]
public static class 2073
{
	// Token: 0x06003601 RID: 13825 RVA: 0x00151790 File Offset: 0x0014F990
	public static double 1(1896 1, bool 2)
	{
		if (1.2 is 2070 || 1.8 <= 1 || 1.1(0).2 is 2070)
		{
			return 0.0;
		}
		2095 3 = (2095)1;
		2095 4 = (2095)1.1(0);
		2095 5 = (2095)1.1(2);
		double num = 2 ? 3.10() : 3.8();
		double num2 = num / 3.9;
		if (4.2 is 2063 && 2)
		{
			double num3 = 4.21() + 3.10();
			num2 = Math.Max(num2, num3 / 3.9);
		}
		double num4 = 2 ? 4.10() : 4.8();
		double num5 = num4 / 4.9;
		double num6 = num2;
		num6 *= 2073.3(3, 4);
		if (3.25() != null && 4.25() != null)
		{
			double value = 3.25().Value;
			double value2 = 4.25().Value;
			double num7 = Math.Min(num2, num5);
			double num8 = 0.0;
			if (Math.Max(3.9, 4.9) < 1.25 * Math.Min(3.9, 4.9))
			{
				num8 = 2073.5(value);
				num8 *= 0.08 + 0.92 * (1.0 - Math.Min(num8, 1897.12(2073.5(value2), 3)));
				num8 *= num7 * 1897.9(1897.2(3.9, 2), 300.0, 400.0) * 1897.9(num, 0.0, 200.0);
			}
			double num9 = 2073.4(value);
			num9 *= 0.25 + 0.75 * (1.0 - Math.Min(num9, 1897.12(2073.4(value2), 3)));
			double val = num / 1897.11(3.9, 1.45);
			double val2 = num4 / 1897.11(4.9, 1.45);
			if (4.2 is 2063 && 2)
			{
				double num10 = 4.21() + 3.10();
				val = Math.Max(val, num10 / 1897.11(3.9, 1.45));
			}
			num9 *= Math.Min(val, val2);
			if (5 != null)
			{
				2034 6 = 4.2;
				float num11 = (5.2.8 - 6.8).Length();
				if (num11 < 1f)
				{
					num9 *= 1.0 - 0.55 * (double)(1f - num11);
				}
			}
			num6 += Math.Max(num8 * 2.41, num9 * 9.67);
			double num12 = num7 * 1897.9(num, 50.0, 100.0) * 1897.11(1897.10(num, 300.0, 100.0), 1.8) * 1897.9(value, 1897.14(110.0), 1897.14(60.0)) * 1897.9(num4, 50.0, 100.0) * 1897.11(1897.10(num4, 300.0, 100.0), 1.8) * 1897.9(value2, 1897.14(110.0), 1897.14(60.0));
			num6 += num12 * 1.02;
		}
		if (Math.Max(num5, num2) != 0.0)
		{
			if (2)
			{
				num2 = num / 3.9;
			}
			double num13 = 1897.8(Math.Abs(num5 - num2) / Math.Max(num5, num2), 0.0, 1.0);
			double num14 = Math.Min(125.0 / Math.Min(3.9, 4.9), Math.Abs(num5 - num2)) * num13;
			num14 *= 1897.12(Math.Min(3.9, 4.9) / Math.Max(3.9, 4.9), 2);
			num6 += num14 * 0.9;
		}
		if (3.2 is 2063 && 2)
		{
			double num15 = 3.15() / 3.17();
			num6 += ((num15 < 1.0) ? num15 : 1897.11(num15, 0.75)) * 1.5;
		}
		num6 *= 3.33();
		return num6 * 2073.2(3.9);
	}

	// Token: 0x06003602 RID: 13826 RVA: 0x00151CC5 File Offset: 0x0014FEC5
	private static double 2(double 1)
	{
		return 1.0 / (1.0 - 1897.11(0.03, 1897.11(1 / 1000.0, 0.65)));
	}

	// Token: 0x06003603 RID: 13827 RVA: 0x00151D04 File Offset: 0x0014FF04
	private static double 3(2095 1, 2095 2)
	{
		if (1.25() == null || 2.25() == null)
		{
			return 1.0;
		}
		double num = 0.0;
		int num2 = 0;
		while ((double)num2 < 6.0)
		{
			2095 3 = (2095)1.1(num2);
			if (3 == null || Math.Max(1.9, 3.9) > 1.1 * Math.Min(1.9, 3.9))
			{
				break;
			}
			if (3.29() != null && 1.29() != null)
			{
				double val = Math.Abs(1.29().Value - 3.29().Value);
				num += Math.Cos(8.0 * Math.Min(1897.14(11.25), val));
			}
			num2++;
		}
		double num3 = 1897.12(Math.Min(0.5 / num, 1.0), 2);
		double num4 = 1897.9(1.10(), 0.0, 100.0);
		double value = 1.25().Value;
		double value2 = 2.25().Value;
		double num5 = Math.Cos(2.0 * Math.Min(1897.14(45.0), Math.Abs(value - value2) * num4));
		double num6 = 1.0 - 0.15 * 2073.5(value2) * num5;
		return 1897.12(num6 + (1.0 - num6) * num3 * 0.5 * num4, 2);
	}

	// Token: 0x06003604 RID: 13828 RVA: 0x00151EF1 File Offset: 0x001500F1
	private static double 4(double 1)
	{
		return 1897.8(1, 1897.14(40.0), 1897.14(140.0));
	}

	// Token: 0x06003605 RID: 13829 RVA: 0x00151F15 File Offset: 0x00150115
	public static double 5(double 1)
	{
		return 1897.8(1, 1897.14(140.0), 1897.14(40.0));
	}
}
