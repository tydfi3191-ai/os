using System;

// Token: 0x02000853 RID: 2131
public static class 1897
{
	// Token: 0x06003DD9 RID: 15833 RVA: 0x00184A30 File Offset: 0x00182C30
	public static double 1(double 1, int 2)
	{
		return 60000.0 / (double)2 / 1;
	}

	// Token: 0x06003DDA RID: 15834 RVA: 0x00184A40 File Offset: 0x00182C40
	public static double 2(double 1, int 2)
	{
		return 60000.0 / (1 * (double)2);
	}

	// Token: 0x06003DDB RID: 15835 RVA: 0x00184A50 File Offset: 0x00182C50
	public static double 3(double 1, double 2, double 3, double 4)
	{
		return 4 / (1.0 + Math.Exp(3 * (2 - 1)));
	}

	// Token: 0x06003DDC RID: 15836 RVA: 0x00184A68 File Offset: 0x00182C68
	public static double 4(double 1, double 2)
	{
		return 2 / (1.0 + Math.Exp(1));
	}

	// Token: 0x06003DDD RID: 15837 RVA: 0x00184A7C File Offset: 0x00182C7C
	public static double 5(double 1, double[] 2)
	{
		double num = 0.0;
		foreach (double 3 in 2)
		{
			num += 1897.11(3, 1);
		}
		return 1897.11(num, 1.0 / 1);
	}

	// Token: 0x06003DDE RID: 15838 RVA: 0x00184AC2 File Offset: 0x00182CC2
	public static double 6(double 1, double 2, double 3, double 4)
	{
		return 4 * Math.Exp(2.718281828459045 * (0.0 - Math.Pow(1 - 2, 2.0) / Math.Pow(3, 2.0)));
	}

	// Token: 0x06003DDF RID: 15839 RVA: 0x00184B00 File Offset: 0x00182D00
	public static double 7(double 1)
	{
		1 = 0.5 - Math.Abs(1 - 0.5);
		1 = 1052.20(1 * 2.0, 0.0, 1.0);
		return 1 * 1 * (3.0 - 2.0 * 1);
	}

	// Token: 0x06003DE0 RID: 15840 RVA: 0x00184B66 File Offset: 0x00182D66
	public static double 8(double 1, double 2, double 3)
	{
		1 = 1052.20((1 - 2) / (3 - 2), 0.0, 1.0);
		return 1 * 1 * (3.0 - 2.0 * 1);
	}

	// Token: 0x06003DE1 RID: 15841 RVA: 0x00184BA4 File Offset: 0x00182DA4
	public static double 9(double 1, double 2, double 3)
	{
		1 = 1052.20((1 - 2) / (3 - 2), 0.0, 1.0);
		return 1 * 1 * 1 * (1 * (6.0 * 1 - 15.0) + 10.0);
	}

	// Token: 0x06003DE2 RID: 15842 RVA: 0x00184BF8 File Offset: 0x00182DF8
	public static double 10(double 1, double 2, double 3)
	{
		return 1052.20((1 - 2) / (3 - 2), 0.0, 1.0);
	}

	// Token: 0x06003DE3 RID: 15843 RVA: 0x00184C18 File Offset: 0x00182E18
	public static double 11(double 1, double 2)
	{
		return Math.Pow(1, 2);
	}

	// Token: 0x06003DE4 RID: 15844 RVA: 0x00184C24 File Offset: 0x00182E24
	public static double 12(double 1, int 2)
	{
		double result;
		switch (2)
		{
		case 0:
			result = 1.0;
			break;
		case 1:
			result = 1;
			break;
		case 2:
			result = 1 * 1;
			break;
		case 3:
			result = 1 * 1 * 1;
			break;
		case 4:
			result = 1 * 1 * 1 * 1;
			break;
		case 5:
			result = 1 * 1 * 1 * 1 * 1;
			break;
		default:
			result = Math.Pow(1, (double)2);
			break;
		}
		return result;
	}

	// Token: 0x06003DE5 RID: 15845 RVA: 0x00184C8F File Offset: 0x00182E8F
	public static double 13(double 1)
	{
		return 1897.11(1, 0.3333333333333333);
	}

	// Token: 0x06003DE6 RID: 15846 RVA: 0x00184CA0 File Offset: 0x00182EA0
	public static double 14(double 1)
	{
		return 1 * 3.141592653589793 / 180.0;
	}

	// Token: 0x06003DE7 RID: 15847 RVA: 0x00184CB8 File Offset: 0x00182EB8
	public static double 15(double 1)
	{
		if (1 == 0.0)
		{
			return 0.0;
		}
		if (double.IsPositiveInfinity(1))
		{
			return 1.0;
		}
		if (double.IsNegativeInfinity(1))
		{
			return -1.0;
		}
		if (double.IsNaN(1))
		{
			return double.NaN;
		}
		double num = 1.0 / (1.0 + 0.3275911 * Math.Abs(1));
		double num2 = num * (0.254829592 + num * (-0.284496736 + num * (1.421413741 + num * (-1.453152027 + num * 1.061405429))));
		double num3 = 1.0 - num2 * Math.Exp(-1 * 1);
		if (1 < 0.0)
		{
			return -num3;
		}
		return num3;
	}

	// Token: 0x06003DE8 RID: 15848 RVA: 0x00184D98 File Offset: 0x00182F98
	public static double 16(double 1)
	{
		if (1 <= -1.0)
		{
			return double.NegativeInfinity;
		}
		if (1 >= 1.0)
		{
			return double.PositiveInfinity;
		}
		if (1 == 0.0)
		{
			return 0.0;
		}
		double num = (double)Math.Sign(1);
		1 = Math.Abs(1);
		double num2 = Math.Log(1.0 - 1 * 1);
		double num3 = 4.330746750799873 + num2 / 2.0;
		double num4 = num2 / 0.147;
		double d = Math.Sqrt(num3 * num3 - num4) - num3;
		double num5 = (1 >= 0.85) ? 1897.12((1 - 0.85) / 0.293, 8) : 0.0;
		return num * (Math.Sqrt(d) + num5);
	}
}
