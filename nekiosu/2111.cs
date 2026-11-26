using System;
using System.Collections.Generic;

// Token: 0x02000755 RID: 1877
[276]
public sealed class 2111 : 2090
{
	// Token: 0x0600371A RID: 14106 RVA: 0x0015978A File Offset: 0x0015798A
	public 2111(2023 1) : base(1)
	{
	}

	// Token: 0x0600371B RID: 14107 RVA: 0x0015979E File Offset: 0x0015799E
	protected override double GetHarmonicScale()
	{
		return 20.0;
	}

	// Token: 0x0600371C RID: 14108 RVA: 0x001553CA File Offset: 0x001535CA
	protected override double GetIndexExponent()
	{
		return 0.9;
	}

	// Token: 0x0600371D RID: 14109 RVA: 0x001597A9 File Offset: 0x001579A9
	private double 5(double 1)
	{
		return 1897.11(0.3, 1 / 1000.0);
	}

	// Token: 0x0600371E RID: 14110 RVA: 0x001597C4 File Offset: 0x001579C4
	protected override double CalculateObjectStrain(1896 1)
	{
		if ((this.1 & 2023.Relax) > 2023.None)
		{
			return 0.0;
		}
		double num = this.5(((2095)1).9);
		this.4 *= num;
		this.4 += this.8(1) * (1.0 - num) * 1.16;
		double num2 = 2101.1(1);
		double num3 = this.4 * num2;
		if (1.2 is 2123)
		{
			this.5.Add(num3);
		}
		return num3;
	}

	// Token: 0x0600371F RID: 14111 RVA: 0x00159860 File Offset: 0x00157A60
	public double 6()
	{
		if (this.2.Count == 0)
		{
			return 0.0;
		}
		double num = 0.0;
		foreach (double val in this.2)
		{
			num = Math.Max(num, val);
		}
		if (num == 0.0)
		{
			return 0.0;
		}
		double num2 = 0.0;
		foreach (double num3 in this.2)
		{
			num2 += 1897.3(num3 / num, 0.5, 12.0, 1.0);
		}
		return num2;
	}

	// Token: 0x06003720 RID: 14112 RVA: 0x0015995C File Offset: 0x00157B5C
	public double 7(double 1)
	{
		return base.3(this.5, 1, 0.88, 10.0);
	}

	// Token: 0x06003721 RID: 14113 RVA: 0x00159980 File Offset: 0x00157B80
	private double 8(1896 1)
	{
		double num = 2112.1(1);
		if ((this.1 & 2023.Relax2) > 2023.None)
		{
			num *= 0.5;
		}
		return num;
	}

	// Token: 0x04002900 RID: 10496
	private new double 4;

	// Token: 0x04002901 RID: 10497
	private readonly List<double> 5 = new List<double>();
}
