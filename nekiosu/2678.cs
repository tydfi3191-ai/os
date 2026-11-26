using System;

// Token: 0x02000439 RID: 1081
public static class 2678
{
	// Token: 0x060021B1 RID: 8625 RVA: 0x00091350 File Offset: 0x0008F550
	public static float 1(string 1, float 2, bool 3)
	{
		float num = float.Parse(1, 1662.18);
		if (!3)
		{
			return num;
		}
		if (num < 0f - 2)
		{
			throw new OverflowException("Value is too low");
		}
		if (num > 2)
		{
			throw new OverflowException("Value is too high");
		}
		if (float.IsNaN(num))
		{
			throw new FormatException("Not a number");
		}
		return num;
	}

	// Token: 0x060021B2 RID: 8626 RVA: 0x000913A8 File Offset: 0x0008F5A8
	public static double 2(string 1, double 2, bool 3)
	{
		double num = double.Parse(1, 1662.18);
		if (!3)
		{
			return num;
		}
		if (num < 0.0 - 2)
		{
			throw new OverflowException("Value is too low");
		}
		if (num > 2)
		{
			throw new OverflowException("Value is too high");
		}
		if (double.IsNaN(num))
		{
			throw new FormatException("Not a number");
		}
		return num;
	}

	// Token: 0x060021B3 RID: 8627 RVA: 0x00091404 File Offset: 0x0008F604
	public static int 3(string 1, int 2, bool 3)
	{
		int num = int.Parse(1, 1662.18);
		if (!3)
		{
			return num;
		}
		if (num < -2)
		{
			throw new OverflowException("Value is too low");
		}
		if (num > 2)
		{
			throw new OverflowException("Value is too high");
		}
		return num;
	}
}
