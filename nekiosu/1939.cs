using System;
using System.Globalization;

// Token: 0x02000844 RID: 2116
public static class 1939
{
	// Token: 0x06003D69 RID: 15721 RVA: 0x00183713 File Offset: 0x00181913
	public static bool 1(2023 1)
	{
		return (1 & (2023.DoubleTime | 2023.Nightcore)) > 2023.None;
	}

	// Token: 0x170002D1 RID: 721
	// (get) Token: 0x06003D6A RID: 15722 RVA: 0x0018371F File Offset: 0x0018191F
	public static bool NoLimits
	{
		get
		{
			1313 <<EMPTY_NAME>> = 1304.62;
			return <<EMPTY_NAME>> != null && <<EMPTY_NAME>>.1();
		}
	}

	// Token: 0x06003D6B RID: 15723 RVA: 0x00183731 File Offset: 0x00181931
	public static void 2(bool 1)
	{
		if (1939.NoLimits == 1)
		{
			return;
		}
		1313 2 = 1304.62;
		if (2 != null)
		{
			2.2(1);
		}
		1939.13(2023.DoubleTime, 1939.5);
		1939.13(2023.HalfTime, 1939.6);
		2019.3();
	}

	// Token: 0x06003D6C RID: 15724 RVA: 0x0018376D File Offset: 0x0018196D
	public static double 3(2023 1)
	{
		return 1939.5(1, 1939.NoLimits);
	}

	// Token: 0x06003D6D RID: 15725 RVA: 0x0018377A File Offset: 0x0018197A
	public static double 4(2023 1)
	{
		return 1939.6(1, 1939.NoLimits);
	}

	// Token: 0x06003D6E RID: 15726 RVA: 0x00183787 File Offset: 0x00181987
	public static double 5(2023 1, bool 2)
	{
		if (1939.1(1))
		{
			return 1.01;
		}
		if (!2)
		{
			return 0.5;
		}
		return 0.1;
	}

	// Token: 0x06003D6F RID: 15727 RVA: 0x001837B1 File Offset: 0x001819B1
	public static double 6(2023 1, bool 2)
	{
		if (!1939.1(1))
		{
			return 0.99;
		}
		if (!2)
		{
			return 2.0;
		}
		return 5.0;
	}

	// Token: 0x06003D70 RID: 15728 RVA: 0x001837DB File Offset: 0x001819DB
	public static bool 7(double 1)
	{
		return 1 < 0.495 || 1 > 2.005;
	}

	// Token: 0x06003D71 RID: 15729 RVA: 0x001837F7 File Offset: 0x001819F7
	public static double 8(2023 1)
	{
		if (!1939.1(1))
		{
			return 0.75;
		}
		return 1.5;
	}

	// Token: 0x06003D72 RID: 15730 RVA: 0x00183814 File Offset: 0x00181A14
	public static double 9(2023 1)
	{
		if (!1939.1(1))
		{
			return 1939.6;
		}
		return 1939.5;
	}

	// Token: 0x06003D73 RID: 15731 RVA: 0x00183829 File Offset: 0x00181A29
	public static bool 10(2023 1)
	{
		if (!1939.1(1))
		{
			return 1939.8;
		}
		return 1939.7;
	}

	// Token: 0x06003D74 RID: 15732 RVA: 0x0018383E File Offset: 0x00181A3E
	public static bool 11(2023 1)
	{
		return Math.Abs(1939.9(1) - 1939.8(1)) > 0.005;
	}

	// Token: 0x06003D75 RID: 15733 RVA: 0x0018385D File Offset: 0x00181A5D
	public static void 12(2023 1, double 2)
	{
		1939.13(1, 2);
		2019.3();
	}

	// Token: 0x06003D76 RID: 15734 RVA: 0x0018386C File Offset: 0x00181A6C
	private static void 13(2023 1, double 2)
	{
		2 = Math.Round(Math.Max(1939.3(1), Math.Min(1939.4(1), 2)) / 0.01) * 0.01;
		if (1939.1(1))
		{
			1939.5 = 2;
			return;
		}
		1939.6 = 2;
	}

	// Token: 0x06003D77 RID: 15735 RVA: 0x001838C0 File Offset: 0x00181AC0
	public static void 14(2023 1, bool 2)
	{
		if (1939.1(1))
		{
			1939.7 = 2;
		}
		else
		{
			1939.8 = 2;
		}
		2019.3();
	}

	// Token: 0x06003D78 RID: 15736 RVA: 0x001838DD File Offset: 0x00181ADD
	public static void Reset(2023 1)
	{
		if (1939.1(1))
		{
			1939.5 = 1.5;
			1939.7 = false;
			return;
		}
		1939.6 = 0.75;
		1939.8 = false;
	}

	// Token: 0x06003D79 RID: 15737 RVA: 0x00183910 File Offset: 0x00181B10
	public static void 15(2023 1)
	{
		if ((1 & (2023.DoubleTime | 2023.Nightcore)) == 2023.None)
		{
			1939.Reset(2023.DoubleTime);
		}
		if ((1 & 2023.HalfTime) == 2023.None)
		{
			1939.Reset(2023.HalfTime);
		}
	}

	// Token: 0x06003D7A RID: 15738 RVA: 0x00183938 File Offset: 0x00181B38
	public static 1940 16(2023 1)
	{
		2023 2 = ((1 & (2023.DoubleTime | 2023.Nightcore)) != 2023.None) ? 2023.DoubleTime : (((1 & 2023.HalfTime) != 2023.None) ? 2023.HalfTime : 2023.None);
		if (2 == 2023.None)
		{
			return null;
		}
		bool flag = 1939.10(2) && (1 & 2023.Nightcore) == 2023.None;
		if (!1939.11(2) && !flag)
		{
			return null;
		}
		return new 1940(1939.9(2), flag);
	}

	// Token: 0x06003D7B RID: 15739 RVA: 0x00183998 File Offset: 0x00181B98
	public static double 17(2023 1, 1940 2)
	{
		if ((1 & (2023.DoubleTime | 2023.Nightcore)) != 2023.None)
		{
			if (2 == null)
			{
				return 1.5;
			}
			return 2.Rate;
		}
		else
		{
			if ((1 & 2023.HalfTime) == 2023.None)
			{
				return 1.0;
			}
			if (2 == null)
			{
				return 0.75;
			}
			return 2.Rate;
		}
	}

	// Token: 0x06003D7C RID: 15740 RVA: 0x001839E8 File Offset: 0x00181BE8
	public static 1940 18(2023 1)
	{
		2241 2 = 2486.88;
		if (2 == null)
		{
			return 1939.16(1);
		}
		return 2.44;
	}

	// Token: 0x06003D7D RID: 15741 RVA: 0x00183A0B File Offset: 0x00181C0B
	public static double 19(2023 1)
	{
		return 1939.17(1, 1939.18(1));
	}

	// Token: 0x06003D7E RID: 15742 RVA: 0x00183A1C File Offset: 0x00181C1C
	public static double 20(double 1)
	{
		2023 2 = 2019.1;
		2023 3 = ((2 & (2023.DoubleTime | 2023.Nightcore)) != 2023.None) ? 2023.DoubleTime : (((2 & 2023.HalfTime) != 2023.None) ? 2023.HalfTime : 2023.None);
		double num = (3 == 2023.None) ? 1.0 : 1939.9(3);
		bool flag = 3 != 2023.None && 1939.10(3);
		double num2 = Math.Round((num + 1) / 0.01) * 0.01;
		if (Math.Abs(num2 - 1.0) < 0.005)
		{
			2019.1 &= ~(2023.DoubleTime | 2023.HalfTime | 2023.Nightcore);
			2019.7(2023.None);
			2019.3();
			return 1.0;
		}
		2023 4 = (num2 > 1.0) ? 2023.DoubleTime : 2023.HalfTime;
		if (4 != 3)
		{
			2019.1 = ((2 & ~(2023.DoubleTime | 2023.HalfTime | 2023.Nightcore)) | 4);
			2019.7(4);
			1939.13(4, num2);
			if (1939.1(4))
			{
				1939.7 = flag;
			}
			else
			{
				1939.8 = flag;
			}
			2019.3();
			return 1939.9(4);
		}
		1939.12(4, num2);
		return 1939.9(4);
	}

	// Token: 0x06003D7F RID: 15743 RVA: 0x00183B38 File Offset: 0x00181D38
	public static bool 21(200 1)
	{
		1532 2 = 1548.16(1);
		if (2 != 1532.SpeedUp && 2 != 1532.SpeedDown)
		{
			return false;
		}
		double num = 1939.20((2 == 1532.SpeedUp) ? 0.05 : -0.05);
		1763.2("Speed: " + 1939.22(num), 1000, (1389)0);
		return true;
	}

	// Token: 0x06003D80 RID: 15744 RVA: 0x00183B93 File Offset: 0x00181D93
	public static string 22(double 1)
	{
		return 1.ToString("0.00", CultureInfo.InvariantCulture) + "x";
	}

	// Token: 0x04002D2A RID: 11562
	public const double 1 = 1.5;

	// Token: 0x04002D2B RID: 11563
	public const double 2 = 0.75;

	// Token: 0x04002D2C RID: 11564
	public const double 3 = 0.01;

	// Token: 0x04002D2D RID: 11565
	private const 2023 4 = 2023.DoubleTime | 2023.Nightcore;

	// Token: 0x04002D2E RID: 11566
	private static double 5 = 1.5;

	// Token: 0x04002D2F RID: 11567
	private static double 6 = 0.75;

	// Token: 0x04002D30 RID: 11568
	private static bool 7;

	// Token: 0x04002D31 RID: 11569
	private static bool 8;
}
