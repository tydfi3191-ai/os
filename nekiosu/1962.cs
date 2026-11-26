using System;

// Token: 0x020007B2 RID: 1970
public static class 1962
{
	// Token: 0x06003979 RID: 14713 RVA: 0x0016A8CC File Offset: 0x00168ACC
	public static double 1(1896 1)
	{
		1958 2 = (1958)1;
		double 3 = 2.5;
		double 4 = 2.6;
		bool flag = false;
		double num = Math.Abs(4 - 3);
		double num2 = 1.0;
		double num3 = 0.0;
		foreach (1958 5 in 2.latestPerColumn)
		{
			if (5 != null)
			{
				flag |= (1194.1(5.6, 3, 1.0) && 1194.1(4, 5.6, 1.0) && 1194.1(3, 5.5, 1.0));
				if (1194.1(5.6, 4, 1.0) && 1194.1(3, 5.5, 1.0))
				{
					num2 = 1.25;
				}
				num = Math.Min(num, Math.Abs(4 - 5.6));
			}
		}
		if (flag)
		{
			num3 = 1897.3(num, 30.0, 0.27, 1.0);
		}
		return (1.0 + num3) * num2;
	}
}
