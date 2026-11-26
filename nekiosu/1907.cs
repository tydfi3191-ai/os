using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x0200086C RID: 2156
public sealed class 1907 : 1903
{
	// Token: 0x06003E4E RID: 15950 RVA: 0x00185ED0 File Offset: 0x001840D0
	public 1907(1907 1, List<1919> 2)
	{
		1907.1908 intervalLookup = new 1907.1908();
		this.2 = 3;
		this.1 = 2;
		intervalLookup.1 = 1904.1(2, 5.0);
		List<double> list = (from 1 in 2.Skip(1)
		select intervalLookup.1[1]).ToList<double>();
		double num = (list.Count > 0) ? Math.Round(list[0]) : 0.0;
		double? num2;
		if (list.Count > 0)
		{
			num2 = ((3 != null) ? 3.3 : null);
			if (num2 != null)
			{
				double valueOrDefault = num2.GetValueOrDefault();
				if (Math.Abs(num - valueOrDefault) <= 5.0)
				{
					this.3 = new double?(valueOrDefault);
					goto IL_13E;
				}
			}
			this.3 = new double?(num);
		}
		IL_13E:
		num2 = ((3 != null) ? 3.3 : null);
		if (num2 == null)
		{
			goto IL_187;
		}
		double valueOrDefault2 = num2.GetValueOrDefault();
		num2 = this.3;
		if (num2 == null)
		{
			goto IL_187;
		}
		double num3 = num2.GetValueOrDefault() / valueOrDefault2;
		IL_F2:
		this.4 = num3;
		if (3 != null)
		{
			if (Math.Abs(this.2() - 3.2()) <= 5.0)
			{
				this.5 = 0.0;
				return;
			}
			this.5 = this.2() - 3.2();
		}
		return;
		IL_187:
		num3 = 1.0;
		goto IL_F2;
	}

	// Token: 0x06003E4F RID: 15951 RVA: 0x00186073 File Offset: 0x00184273
	public 1919 1()
	{
		return this.1[0];
	}

	// Token: 0x06003E50 RID: 15952 RVA: 0x00186081 File Offset: 0x00184281
	public double 2()
	{
		return this.1[0].5;
	}

	// Token: 0x06003E51 RID: 15953 RVA: 0x00186094 File Offset: 0x00184294
	public double 3()
	{
		return this.1[this.1.Count - 1].5 - this.1[0].5;
	}

	// Token: 0x06003E52 RID: 15954 RVA: 0x001860C5 File Offset: 0x001842C5
	[CompilerGenerated]
	public double GetStartGap()
	{
		return this.5;
	}

	// Token: 0x04002DA0 RID: 11680
	public readonly List<1919> 1;

	// Token: 0x04002DA1 RID: 11681
	public readonly 1907 2;

	// Token: 0x04002DA2 RID: 11682
	public readonly double? 3;

	// Token: 0x04002DA3 RID: 11683
	public readonly double 4;

	// Token: 0x04002DA4 RID: 11684
	private readonly double 5 = double.PositiveInfinity;

	// Token: 0x0200086D RID: 2157
	public sealed class 1908
	{
		// Token: 0x04002DA5 RID: 11685
		public Dictionary<1919, double> 1;
	}
}
