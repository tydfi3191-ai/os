using System;

// Token: 0x0200070A RID: 1802
[276]
public sealed class 2135 : 2153
{
	// Token: 0x0600351A RID: 13594 RVA: 0x0013F7E0 File Offset: 0x0013D9E0
	public 2135(2241 1) : base(1)
	{
	}

	// Token: 0x0600351B RID: 13595 RVA: 0x00147A24 File Offset: 0x00145C24
	internal override int GetScore()
	{
		if (this.BaselineJudgementCount == 0)
		{
			return 0;
		}
		return (int)Math.Round((700000.0 * this.2 / this.BaselineComboScore + 300000.0 * Math.Pow((double)this.1.CalculateAccuracy(), 10.0) * ((double)this.1.GetJudgementCount() / (double)this.BaselineJudgementCount) + this.3) * 2019.9(this.1, true));
	}
}
