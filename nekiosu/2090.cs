using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x0200073A RID: 1850
[276]
public abstract class 2090 : 1914
{
	// Token: 0x06003664 RID: 13924 RVA: 0x001553C1 File Offset: 0x001535C1
	protected 2090(2023 1) : base(1)
	{
	}

	// Token: 0x06003665 RID: 13925 RVA: 0x00144B2B File Offset: 0x00142D2B
	protected virtual double GetHarmonicScale()
	{
		return 1.0;
	}

	// Token: 0x06003666 RID: 13926 RVA: 0x001553CA File Offset: 0x001535CA
	protected virtual double GetIndexExponent()
	{
		return 0.9;
	}

	// Token: 0x06003667 RID: 13927
	protected abstract double CalculateObjectStrain(1896 1);

	// Token: 0x06003668 RID: 13928 RVA: 0x001553D5 File Offset: 0x001535D5
	protected sealed override double StrainValueAt(1896 1)
	{
		return this.CalculateObjectStrain(1);
	}

	// Token: 0x06003669 RID: 13929 RVA: 0x00022391 File Offset: 0x00020591
	protected virtual List<double> PreprocessValues(List<double> 1)
	{
		return 1;
	}

	// Token: 0x0600366A RID: 13930 RVA: 0x001553E0 File Offset: 0x001535E0
	public override double DifficultyValue()
	{
		if (this.2.Count == 0)
		{
			return 0.0;
		}
		List<double> list = this.2;
		if (list.Count == 0)
		{
			return 0.0;
		}
		list = this.PreprocessValues(list);
		double num = 0.0;
		int num2 = 0;
		this.3 = 0.0;
		foreach (double num3 in from 1 in list.OrderByDescending(new Func<double, double>(2090.2091.instance.1))
		where 1 > 0.0
		select 1)
		{
			double num4 = (1.0 + this.GetHarmonicScale() / (double)(1 + num2)) / (1897.11((double)num2, this.GetIndexExponent()) + 1.0 + this.GetHarmonicScale() / (double)(1 + num2));
			this.3 += num4;
			num += num3 * num4;
			num2++;
		}
		return num;
	}

	// Token: 0x0600366B RID: 13931 RVA: 0x00155508 File Offset: 0x00153708
	public virtual double CountTopWeightedObjectDifficulties(double 1)
	{
		return this.3(this.2, 1, 0.88, 10.0);
	}

	// Token: 0x0600366C RID: 13932 RVA: 0x0015552C File Offset: 0x0015372C
	protected double 3(List<double> 1, double 2, double 3, double 4)
	{
		if (1.Count == 0 || this.3 == 0.0)
		{
			return 0.0;
		}
		double num = 2 / this.3;
		if (num == 0.0)
		{
			return 0.0;
		}
		double num2 = 0.0;
		foreach (double num3 in 1)
		{
			num2 += 1897.3(num3 / num, 3, 4, 1.1);
		}
		return num2;
	}

	// Token: 0x0600366D RID: 13933 RVA: 0x001555D8 File Offset: 0x001537D8
	public static double 4(double 1)
	{
		return 4.0 * 1897.12(1, 3);
	}

	// Token: 0x04002886 RID: 10374
	protected double 3;

	// Token: 0x0200073B RID: 1851
	[276]
	[Serializable]
	public sealed class 2091
	{
		// Token: 0x0600366E RID: 13934 RVA: 0x00022391 File Offset: 0x00020591
		internal double 1(double 1)
		{
			return 1;
		}

		// Token: 0x04002887 RID: 10375
		public static readonly 2090.2091 instance = new 2090.2091();

		// Token: 0x04002888 RID: 10376
		public static Func<double, double> func;

		// Token: 0x04002889 RID: 10377
		public static Func<double, bool> func2;
	}
}
