using System;

// Token: 0x02000820 RID: 2080
[276]
public sealed class 2061 : 2033
{
	// Token: 0x06003C8E RID: 15502 RVA: 0x001802F0 File Offset: 0x0017E4F0
	internal 2061(2039 1, 208 2, int 3, bool 4, 1245 5, int 6) : base(1, 2, 3, 4, 5, 6)
	{
	}

	// Token: 0x06003C8F RID: 15503 RVA: 0x00180304 File Offset: 0x0017E504
	internal 2061(2039 1, 208 2, int 3, bool 4, bool 5 = false, bool 6 = false, bool 7 = false, int 8 = 0) : base(1, 2, 3, 4, 5, 6, 7, 8)
	{
	}

	// Token: 0x06003C90 RID: 15504 RVA: 0x00180324 File Offset: 0x0017E524
	internal override string GetCircleTextureName()
	{
		return "sliderstartcircle";
	}

	// Token: 0x06003C91 RID: 15505 RVA: 0x0018032C File Offset: 0x0017E52C
	internal override 2149 GetOrCalculateJudgement()
	{
		2149 orCalculateJudgement = base.GetOrCalculateJudgement();
		if (orCalculateJudgement > (2149)0)
		{
			return orCalculateJudgement;
		}
		return (2149)(-262144);
	}
}
