using System;

// Token: 0x0200077B RID: 1915
public sealed class 1987 : 2153
{
	// Token: 0x0600383F RID: 14399 RVA: 0x0013F7E0 File Offset: 0x0013D9E0
	public 1987(2241 1) : base(1)
	{
	}

	// Token: 0x06003840 RID: 14400 RVA: 0x00160211 File Offset: 0x0015E411
	internal new double 3()
	{
		return 200000.0 * this.2 / this.BaselineComboScore;
	}

	// Token: 0x06003841 RID: 14401 RVA: 0x0016022C File Offset: 0x0015E42C
	internal new double 4()
	{
		return 800000.0 * Math.Pow((double)this.1.CalculateAccuracy(), (double)(2f + 2f * this.1.CalculateAccuracy())) * ((double)this.1.GetJudgementCount() / (double)this.BaselineJudgementCount);
	}

	// Token: 0x06003842 RID: 14402 RVA: 0x00160281 File Offset: 0x0015E481
	internal override int GetScore()
	{
		if (this.BaselineJudgementCount == 0)
		{
			return 0;
		}
		return (int)Math.Round((this.3() + this.4()) * 2019.9(this.1, true));
	}

	// Token: 0x06003843 RID: 14403 RVA: 0x001602B0 File Offset: 0x0015E4B0
	protected override void AccumulateEvent(2155 1)
	{
		if (1.3 > 0)
		{
			this.2 += (double)1.GetBaseScore() * Math.Min(Math.Max(0.5, Math.Log((double)1.3, 4.0)), Math.Log(400.0, 4.0));
		}
	}
}
