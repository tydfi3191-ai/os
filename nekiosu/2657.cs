using System;
using System.Collections.Generic;

// Token: 0x02000466 RID: 1126
public sealed class 2657 : 1457
{
	// Token: 0x06002280 RID: 8832 RVA: 0x000956A4 File Offset: 0x000938A4
	public 2657(2656 1, int 2, int 3) : base(2, 1)
	{
		this.4 = 1;
		this.5 = 3;
		this.6 = 2;
	}

	// Token: 0x06002281 RID: 8833 RVA: 0x000956C4 File Offset: 0x000938C4
	internal override List<1445> GenerateTransformations()
	{
		return this.7 = base.GenerateTransformations();
	}

	// Token: 0x06002282 RID: 8834 RVA: 0x000956E0 File Offset: 0x000938E0
	public new List<1445> 1()
	{
		return this.7;
	}

	// Token: 0x040017E3 RID: 6115
	internal readonly 2656 4;

	// Token: 0x040017E4 RID: 6116
	internal int 5;

	// Token: 0x040017E5 RID: 6117
	internal int 6;

	// Token: 0x040017E6 RID: 6118
	private List<1445> 7;
}
