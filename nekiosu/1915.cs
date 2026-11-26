using System;

// Token: 0x02000863 RID: 2147
public abstract class 1915 : 1916
{
	// Token: 0x06003E29 RID: 15913 RVA: 0x001859F6 File Offset: 0x00183BF6
	protected 1915(2023 1) : base(1)
	{
	}

	// Token: 0x06003E2A RID: 15914
	protected abstract double GetStrainWeight();

	// Token: 0x06003E2B RID: 15915
	protected abstract double GetDecayBase();

	// Token: 0x06003E2C RID: 15916 RVA: 0x001859FF File Offset: 0x00183BFF
	protected double 7()
	{
		return this.6;
	}

	// Token: 0x06003E2D RID: 15917 RVA: 0x00185A07 File Offset: 0x00183C07
	private void 8(double 1)
	{
		this.6 = 1;
	}

	// Token: 0x06003E2E RID: 15918 RVA: 0x00185A10 File Offset: 0x00183C10
	protected override double CalculateInitialStrain(double 1, 1896 2)
	{
		return this.7() * this.9(1 - 2.1(0).5);
	}

	// Token: 0x06003E2F RID: 15919 RVA: 0x00185A2D File Offset: 0x00183C2D
	protected override double StrainValueOf(1896 1)
	{
		this.8(this.7() * this.9(1.4));
		this.8(this.7() + this.CalculateObjectStrain(1) * this.GetStrainWeight());
		return this.7();
	}

	// Token: 0x06003E30 RID: 15920
	protected abstract double CalculateObjectStrain(1896 1);

	// Token: 0x06003E31 RID: 15921 RVA: 0x00185A69 File Offset: 0x00183C69
	private double 9(double 1)
	{
		return 1897.11(this.GetDecayBase(), 1 / 1000.0);
	}

	// Token: 0x04002D90 RID: 11664
	private new double 6;
}
