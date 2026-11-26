using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x0200085B RID: 2139
public sealed class 1919 : 1896, 1903
{
	// Token: 0x06003E04 RID: 15876 RVA: 0x00185110 File Offset: 0x00183310
	public 1919(2034 1, 2034 2, double 3, List<1896> 4, List<1919> 5, List<1919> 6, List<1919> 7, int 8, 2039 9, double 10, Func<double, double> 11 = null, double 12 = 0.0) : base(1, 2, 3, 4, 8, 12)
	{
		this.11 = 7;
		this.14 = new 1900();
		this.13 = new 1911(this);
		1887? 13 = null;
		if (1.HasObjectType(2047.Normal))
		{
			13 = new 1887?((1.HasClap() || 1.HasWhistle()) ? ((1887)1) : ((1887)0));
		}
		if (13 != null)
		{
			1887 valueOrDefault = 13.GetValueOrDefault();
			if (valueOrDefault != (1887)0)
			{
				if (valueOrDefault == (1887)1)
				{
					this.10 = 6.Count;
					6.Add(this);
					this.9 = 6;
				}
			}
			else
			{
				this.10 = 5.Count;
				5.Add(this);
				this.9 = 5;
			}
		}
		if (1.HasObjectType(2047.Normal))
		{
			this.12 = 7.Count;
			7.Add(this);
		}
		double num = this.5 * 3 - 12;
		1259 14 = 9.21.93(num);
		double num2 = 1919.3(9, 10, num, 3, 11);
		this.15 = 14.8() * num2;
	}

	// Token: 0x06003E05 RID: 15877 RVA: 0x00185224 File Offset: 0x00183424
	private new static double 3(2039 1, double 2, double 3, double 4, Func<double, double> 5)
	{
		double num = 1.0;
		if (5 != null)
		{
			num = 5(3);
		}
		else if (1.21.3() == 2147.Taiko)
		{
			1259 6 = 1.21.92(3);
			num = Math.Min(10.0, Math.Max(0.01, (6 != null) ? 6.7() : 1.0));
		}
		return 2 * num * 4;
	}

	// Token: 0x06003E06 RID: 15878 RVA: 0x0018529B File Offset: 0x0018349B
	public new 1919 4(int 1)
	{
		List<1919> list = this.9;
		if (list == null)
		{
			return null;
		}
		return list.ElementAtOrDefault(this.10 - (1 + 1));
	}

	// Token: 0x06003E07 RID: 15879 RVA: 0x001852B8 File Offset: 0x001834B8
	public new 1919 5(int 1)
	{
		return this.11.ElementAtOrDefault(this.12 - (1 + 1));
	}

	// Token: 0x06003E08 RID: 15880 RVA: 0x001852CF File Offset: 0x001834CF
	public new 1919 6(int 1)
	{
		return this.11.ElementAtOrDefault(this.12 + (1 + 1));
	}

	// Token: 0x06003E09 RID: 15881 RVA: 0x001852E6 File Offset: 0x001834E6
	public double GetStartGap()
	{
		return this.4;
	}

	// Token: 0x04002D74 RID: 11636
	private readonly List<1919> 9;

	// Token: 0x04002D75 RID: 11637
	public readonly int 10;

	// Token: 0x04002D76 RID: 11638
	private readonly List<1919> 11;

	// Token: 0x04002D77 RID: 11639
	public readonly int 12;

	// Token: 0x04002D78 RID: 11640
	public readonly 1911 13;

	// Token: 0x04002D79 RID: 11641
	public readonly 1900 14;

	// Token: 0x04002D7A RID: 11642
	public double 15;
}
