using System;

// Token: 0x020006F7 RID: 1783
public static class 2175
{
	// Token: 0x060034C1 RID: 13505 RVA: 0x00144978 File Offset: 0x00142B78
	public static double 1(1919 1)
	{
		2175.2176 2 = new 2175.2176(480.0, 640.0);
		2175.2176 3 = new 2175.2176(360.0, 480.0);
		double num = Math.Max(1.0, 1.15);
		double num2 = 0.5 * 1897.3(num, 3.3(), 1.0 / (3.4() / 10.0), 1.0);
		double num3 = 1897.3(21000.0 / num / Math.Max(1.0, 1.4), 0.925, 15.0, 1.0);
		double num4 = (1.0 - 0.33 * num3) * 1897.3(num, 2.3() + 8.0 * num3, (1.0 + 0.5 * num3) / (2.4() / 10.0), 1.0);
		return num2 + num4;
	}

	// Token: 0x020006F8 RID: 1784
	[107]
	public struct 2176
	{
		// Token: 0x060034C2 RID: 13506 RVA: 0x00144AAC File Offset: 0x00142CAC
		public 2176(double 1, double 2)
		{
			this.1 = 1;
			this.2 = 2;
		}

		// Token: 0x060034C3 RID: 13507 RVA: 0x00144ABC File Offset: 0x00142CBC
		public double 1()
		{
			return this.1;
		}

		// Token: 0x060034C4 RID: 13508 RVA: 0x00144AC4 File Offset: 0x00142CC4
		public double 2()
		{
			return this.2;
		}

		// Token: 0x060034C5 RID: 13509 RVA: 0x00144ACC File Offset: 0x00142CCC
		public double 3()
		{
			return (this.2() + this.1()) / 2.0;
		}

		// Token: 0x060034C6 RID: 13510 RVA: 0x00144AE5 File Offset: 0x00142CE5
		public double 4()
		{
			return this.2() - this.1();
		}

		// Token: 0x04002731 RID: 10033
		private readonly double 1;

		// Token: 0x04002732 RID: 10034
		private readonly double 2;
	}
}
