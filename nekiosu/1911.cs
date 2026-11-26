using System;
using System.Linq;

// Token: 0x02000871 RID: 2161
public sealed class 1911
{
	// Token: 0x06003E60 RID: 15968 RVA: 0x001861E8 File Offset: 0x001843E8
	public 1911(1919 1)
	{
		1911.1912 CS_0024_003C_003E8__locals2 = new 1911.1912();
		1896 2 = 3.1(0);
		if (2 == null)
		{
			this.3 = 1.0;
			return;
		}
		CS_0024_003C_003E8__locals2.1 = 3.4 / 2.4;
		double num = (from 1 in 1911.4
		orderby Math.Abs(1 - CS_0024_003C_003E8__locals2.1)
		select 1).First<double>();
		this.3 = num;
	}

	// Token: 0x04002DAB RID: 11691
	public 1907 1;

	// Token: 0x04002DAC RID: 11692
	public 1909 2;

	// Token: 0x04002DAD RID: 11693
	public readonly double 3;

	// Token: 0x04002DAE RID: 11694
	private static readonly double[] 4 = new double[]
	{
		1.0,
		2.0,
		0.5,
		3.0,
		0.3333333333333333,
		1.5,
		0.6666666666666666,
		1.25,
		0.8
	};

	// Token: 0x02000872 RID: 2162
	public sealed class 1912
	{
		// Token: 0x04002DAF RID: 11695
		public double 1;
	}
}
