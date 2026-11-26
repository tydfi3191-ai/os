using System;

// Token: 0x0200082A RID: 2090
[276]
public abstract class 2072 : 2034
{
	// Token: 0x06003CA9 RID: 15529 RVA: 0x00180354 File Offset: 0x0017E554
	protected 2072(2039 1) : base(1)
	{
	}

	// Token: 0x06003CAA RID: 15530 RVA: 0x00180A68 File Offset: 0x0017EC68
	internal override 2149 GetOrCalculateJudgement()
	{
		this.11 = true;
		int num = Math.Abs(1226.16 - this.1);
		if (this.43)
		{
			this.43 = false;
			this.14 = (2149)(-131072);
		}
		else if (num < this.28.5)
		{
			this.14 = (2149)1024;
		}
		else if (num < this.28.4)
		{
			this.14 = (2149)512;
		}
		else if (num < this.28.3)
		{
			this.14 = (2149)256;
		}
		else
		{
			this.14 = (2149)(-131072);
		}
		if (this.14 > (2149)0)
		{
			this.PlayHitSound();
		}
		this.ApplyJudgementAnimation(this.14 > (2149)0);
		return this.14;
	}

	// Token: 0x04002CCF RID: 11471
	internal bool 43;
}
