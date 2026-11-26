using System;

// Token: 0x020006FB RID: 1787
public sealed class 2167 : 1916
{
	// Token: 0x060034CF RID: 13519 RVA: 0x00144B90 File Offset: 0x00142D90
	public 2167(2023 1, bool 2, bool 3) : base(1)
	{
		this.6 = 2;
		this.7 = 3;
	}

	// Token: 0x060034D0 RID: 13520 RVA: 0x00144BA7 File Offset: 0x00142DA7
	private double 7(double 1)
	{
		return 1897.11(0.4, 1 / 1000.0);
	}

	// Token: 0x060034D1 RID: 13521 RVA: 0x00144BC4 File Offset: 0x00142DC4
	protected override double StrainValueOf(1896 1)
	{
		this.8 *= this.7(1.4);
		double num = 2169.1(1) * 1.1;
		1919 2 = 1 as 1919;
		int? num2;
		if (2 != null)
		{
			1886 3 = 2.14.1;
			num2 = ((3 != null) ? new int?(3.1().IndexOf(2)) : null);
		}
		else
		{
			num2 = null;
		}
		int? num3 = num2;
		int valueOrDefault = num3.GetValueOrDefault();
		double num4 = this.7 ? 1.0 : (1.0 + 0.5 * 1897.10((double)valueOrDefault, 5.0, 20.0));
		if (!this.6)
		{
			num *= num4;
		}
		this.8 += num;
		if (!this.6)
		{
			return this.8;
		}
		return 1897.4((double)(-(double)(valueOrDefault - 10)) / 2.0, this.8);
	}

	// Token: 0x060034D2 RID: 13522 RVA: 0x00144CCB File Offset: 0x00142ECB
	protected override double CalculateInitialStrain(double 1, 1896 2)
	{
		if (!this.6)
		{
			return this.8 * this.7(1 - 2.1(0).5);
		}
		return 0.0;
	}

	// Token: 0x04002734 RID: 10036
	public new readonly bool 6;

	// Token: 0x04002735 RID: 10037
	private readonly bool 7;

	// Token: 0x04002736 RID: 10038
	private double 8;
}
