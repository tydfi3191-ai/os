using System;

// Token: 0x020007B3 RID: 1971
public sealed class 1963 : 1915
{
	// Token: 0x0600397A RID: 14714 RVA: 0x0016AA0D File Offset: 0x00168C0D
	public 1963(2023 1, int 2) : base(1)
	{
		this.7 = new double[2];
		this.9 = 1.0;
	}

	// Token: 0x0600397B RID: 14715 RVA: 0x00144B2B File Offset: 0x00142D2B
	protected override double GetStrainWeight()
	{
		return 1.0;
	}

	// Token: 0x0600397C RID: 14716 RVA: 0x00144B2B File Offset: 0x00142D2B
	protected override double GetDecayBase()
	{
		return 1.0;
	}

	// Token: 0x0600397D RID: 14717 RVA: 0x0016AA34 File Offset: 0x00168C34
	protected override double CalculateObjectStrain(1896 1)
	{
		1958 2 = (1958)1;
		this.7[2.columnIndex] = this.10(this.7[2.columnIndex], 2.timeSincePreviousInColumn, 0.125);
		this.7[2.columnIndex] += 1959.1(1);
		this.8 = ((2.4 <= 1.0) ? Math.Max(this.8, this.7[2.columnIndex]) : this.7[2.columnIndex]);
		this.9 = this.10(this.9, 2.4, 0.3);
		this.9 += 1962.1(1);
		return this.8 + this.9 - base.7();
	}

	// Token: 0x0600397E RID: 14718 RVA: 0x0016AB18 File Offset: 0x00168D18
	protected override double CalculateInitialStrain(double 1, 1896 2)
	{
		return this.10(this.8, 1 - 2.1(0).5, 0.125) + this.10(this.9, 1 - 2.1(0).5, 0.3);
	}

	// Token: 0x0600397F RID: 14719 RVA: 0x0016AB6C File Offset: 0x00168D6C
	private double 10(double 1, double 2, double 3)
	{
		return 1 * 1897.11(3, 2 / 1000.0);
	}

	// Token: 0x04002A9A RID: 10906
	private new readonly double[] 7;

	// Token: 0x04002A9B RID: 10907
	private double 8;

	// Token: 0x04002A9C RID: 10908
	private double 9;
}
