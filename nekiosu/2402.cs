using System;
using System.Collections.Generic;

// Token: 0x0200060A RID: 1546
public abstract class 2402 : 2421
{
	// Token: 0x06002F4B RID: 12107 RVA: 0x0010BAE9 File Offset: 0x00109CE9
	protected 2402(2445 1, 2450 2) : base(1, 2)
	{
	}

	// Token: 0x06002F4C RID: 12108 RVA: 0x0010BAF3 File Offset: 0x00109CF3
	protected void 20()
	{
		base.17();
		this.18 = new List<198>();
		this.19 = new List<198>();
	}

	// Token: 0x06002F4D RID: 12109 RVA: 0x0010BB14 File Offset: 0x00109D14
	internal override void Apply(2457 1)
	{
		int num = 0;
		foreach (1445 2 in this.13)
		{
			177.Method12592<198>(this.18, num, ref 2.3);
			177.Method12592<198>(this.19, num, ref 2.7);
			177.Method12592<int>(this.16, num, ref 2.9);
			177.Method12592<int>(this.17, num, ref 2.10);
			num++;
		}
	}

	// Token: 0x0400223A RID: 8762
	protected new List<198> 18;

	// Token: 0x0400223B RID: 8763
	protected new List<198> 19;
}
