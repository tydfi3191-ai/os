using System;

// Token: 0x020006FC RID: 1788
public sealed class 2168 : 1915
{
	// Token: 0x060034D3 RID: 13523 RVA: 0x00144AF4 File Offset: 0x00142CF4
	public 2168(2023 1) : base(1)
	{
	}

	// Token: 0x060034D4 RID: 13524 RVA: 0x00144B2B File Offset: 0x00142D2B
	protected override double GetStrainWeight()
	{
		return 1.0;
	}

	// Token: 0x060034D5 RID: 13525 RVA: 0x00144B36 File Offset: 0x00142D36
	protected override double GetDecayBase()
	{
		return 0.4;
	}

	// Token: 0x060034D6 RID: 13526 RVA: 0x00144CFC File Offset: 0x00142EFC
	protected override double CalculateObjectStrain(1896 1)
	{
		if (!1.2.HasObjectType(2047.Normal))
		{
			return 0.0;
		}
		1919 2 = (1919)1;
		1886 3 = 2.14.1;
		int num = (3 != null) ? 3.1().IndexOf(2) : 0;
		this.7 *= 1897.3((double)num, 4.0, -0.04, 0.5) + 0.5;
		this.7 *= this.GetDecayBase();
		this.7 += 2175.1(2) * this.GetStrainWeight();
		return this.7;
	}

	// Token: 0x04002737 RID: 10039
	private new double 7;
}
