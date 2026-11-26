using System;

// Token: 0x02000125 RID: 293
public static class 421
{
	// Token: 0x06000A81 RID: 2689 RVA: 0x00028694 File Offset: 0x00026894
	public static int Method3211(ulong 1)
	{
		if (1 < 10000000000UL)
		{
			if (1 < 10UL)
			{
				return 1;
			}
			if (1 < 100UL)
			{
				return 2;
			}
			if (1 < 1000UL)
			{
				return 3;
			}
			if (1 < 10000UL)
			{
				return 4;
			}
			if (1 < 100000UL)
			{
				return 5;
			}
			if (1 < 1000000UL)
			{
				return 6;
			}
			if (1 < 10000000UL)
			{
				return 7;
			}
			if (1 < 100000000UL)
			{
				return 8;
			}
			if (1 < 1000000000UL)
			{
				return 9;
			}
			return 10;
		}
		else
		{
			if (1 < 100000000000UL)
			{
				return 11;
			}
			if (1 < 1000000000000UL)
			{
				return 12;
			}
			if (1 < 10000000000000UL)
			{
				return 13;
			}
			if (1 < 100000000000000UL)
			{
				return 14;
			}
			if (1 < 1000000000000000UL)
			{
				return 15;
			}
			if (1 < 10000000000000000UL)
			{
				return 16;
			}
			if (1 < 100000000000000000UL)
			{
				return 17;
			}
			if (1 < 1000000000000000000UL)
			{
				return 18;
			}
			if (1 < 10000000000000000000UL)
			{
				return 19;
			}
			return 20;
		}
	}

	// Token: 0x06000A82 RID: 2690 RVA: 0x00028797 File Offset: 0x00026997
	public static char Method3212(int 1)
	{
		if (1 <= 9)
		{
			return (char)(1 + 48);
		}
		return (char)(1 - 10 + 97);
	}

	// Token: 0x06000A83 RID: 2691 RVA: 0x000287AC File Offset: 0x000269AC
	public static int? Method3213(int? 1, int? 2)
	{
		if (1 == null)
		{
			return 2;
		}
		if (2 == null)
		{
			return 1;
		}
		return new int?(Math.Min(1.GetValueOrDefault(), 2.GetValueOrDefault()));
	}

	// Token: 0x06000A84 RID: 2692 RVA: 0x000287DC File Offset: 0x000269DC
	public static int? Method3214(int? 1, int? 2)
	{
		if (1 == null)
		{
			return 2;
		}
		if (2 == null)
		{
			return 1;
		}
		return new int?(Math.Max(1.GetValueOrDefault(), 2.GetValueOrDefault()));
	}

	// Token: 0x06000A85 RID: 2693 RVA: 0x0002880C File Offset: 0x00026A0C
	public static double? Method3214(double? 1, double? 2)
	{
		if (1 == null)
		{
			return 2;
		}
		if (2 == null)
		{
			return 1;
		}
		return new double?(Math.Max(1.GetValueOrDefault(), 2.GetValueOrDefault()));
	}

	// Token: 0x06000A86 RID: 2694 RVA: 0x0002883C File Offset: 0x00026A3C
	public static bool Method3216(double 1, double 2)
	{
		if (1 == 2)
		{
			return true;
		}
		double num = (Math.Abs(1) + Math.Abs(2) + 10.0) * 2.220446049250313E-16;
		double num2 = 1 - 2;
		return 0.0 - num < num2 && num > num2;
	}
}
