using System;

// Token: 0x020006FA RID: 1786
public sealed class 2166 : 1915
{
	// Token: 0x060034CB RID: 13515 RVA: 0x00144B1B File Offset: 0x00142D1B
	public 2166(2023 1, double 2) : base(1)
	{
		this.7 = 2;
	}

	// Token: 0x060034CC RID: 13516 RVA: 0x00144B2B File Offset: 0x00142D2B
	protected override double GetStrainWeight()
	{
		return 1.0;
	}

	// Token: 0x060034CD RID: 13517 RVA: 0x00144B36 File Offset: 0x00142D36
	protected override double GetDecayBase()
	{
		return 0.4;
	}

	// Token: 0x060034CE RID: 13518 RVA: 0x00144B44 File Offset: 0x00142D44
	protected override double CalculateObjectStrain(1896 1)
	{
		double num = 2162.1(1, this.7);
		double 2 = 2169.1(1) - 0.5;
		return num * 1897.3(2, 0.06666666666666667, 50.0, 1.0);
	}

	// Token: 0x04002733 RID: 10035
	private new readonly double 7;
}
