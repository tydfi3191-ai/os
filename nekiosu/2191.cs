using System;

// Token: 0x020006D8 RID: 1752
public sealed class 2191 : 2241
{
	// Token: 0x0600340A RID: 13322 RVA: 0x0013F765 File Offset: 0x0013D965
	internal 2191()
	{
		this.9 = 2147.Taiko;
	}

	// Token: 0x0600340B RID: 13323 RVA: 0x0013F774 File Offset: 0x0013D974
	internal 2191(2247 1, string 2) : base(1, 2)
	{
		this.9 = 2147.Taiko;
	}

	// Token: 0x0600340C RID: 13324 RVA: 0x0013F785 File Offset: 0x0013D985
	internal 2191(1262 1, string 2) : base(1, 2)
	{
		this.9 = 2147.Taiko;
	}

	// Token: 0x0600340D RID: 13325 RVA: 0x0013F796 File Offset: 0x0013D996
	internal 2191(string 1, 1262 2) : base(1, 2)
	{
		this.9 = 2147.Taiko;
	}

	// Token: 0x0600340E RID: 13326 RVA: 0x0013F7A7 File Offset: 0x0013D9A7
	internal override float CalculateAccuracy()
	{
		if (this.GetJudgementCount() <= 0)
		{
			return 0f;
		}
		return (float)(this.1 * 150 + this.2 * 300) / (float)(this.GetJudgementCount() * 300);
	}
}
