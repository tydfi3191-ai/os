using System;

// Token: 0x02000BC8 RID: 3016
public static class 1196
{
	// Token: 0x060052EC RID: 21228 RVA: 0x002098C0 File Offset: 0x00207AC0
	internal static int 1(int 1)
	{
		return 1196.1.Next(1);
	}

	// Token: 0x060052ED RID: 21229 RVA: 0x002098CD File Offset: 0x00207ACD
	internal static int 2(int 1, int 2)
	{
		return 1196.1.Next(1, 2);
	}

	// Token: 0x060052EE RID: 21230 RVA: 0x002098DB File Offset: 0x00207ADB
	internal static double 3()
	{
		return 1196.1.NextDouble();
	}

	// Token: 0x060052EF RID: 21231 RVA: 0x002098E7 File Offset: 0x00207AE7
	internal static double 4(double 1)
	{
		if (1 < 0.0)
		{
			throw new ArgumentOutOfRangeException("#=zyRqf7oE=", "The given maximum value must be greater than or equal to 0.");
		}
		return 1196.1.NextDouble() * 1;
	}

	// Token: 0x060052F0 RID: 21232 RVA: 0x00209911 File Offset: 0x00207B11
	internal static float 5()
	{
		return (float)1196.1.NextDouble();
	}

	// Token: 0x060052F1 RID: 21233 RVA: 0x0020991E File Offset: 0x00207B1E
	internal static float 6(float 1)
	{
		if (1 < 0f)
		{
			throw new ArgumentOutOfRangeException("#=zyRqf7oE=", "The given maximum value must be greater than or equal to 0.");
		}
		return 1196.5() * 1;
	}

	// Token: 0x060052F2 RID: 21234 RVA: 0x0020993F File Offset: 0x00207B3F
	internal static float 7(float 1, float 2)
	{
		if (1 > 2)
		{
			throw new ArgumentOutOfRangeException("#=z6tWuDg4=", "The given minimum value must be less than or equal to the given maximum value.");
		}
		return 1 + 1196.5() * (2 - 1);
	}

	// Token: 0x060052F3 RID: 21235 RVA: 0x00209960 File Offset: 0x00207B60
	internal static bool 8(double 1)
	{
		return 1196.3() < 1;
	}

	// Token: 0x04003F19 RID: 16153
	private static Random 1 = new Random();
}
