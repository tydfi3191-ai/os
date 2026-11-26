using System;
using System.Collections.Generic;

// Token: 0x02000621 RID: 1569
public abstract class 2425 : 2421
{
	// Token: 0x06002FA5 RID: 12197 RVA: 0x0010BAE9 File Offset: 0x00109CE9
	protected 2425(2445 1, 2450 2) : base(1, 2)
	{
	}

	// Token: 0x06002FA6 RID: 12198 RVA: 0x0010D4FA File Offset: 0x0010B6FA
	protected void 20()
	{
		base.17();
		this.19 = new List<208>();
		this.20 = new List<208>();
	}

	// Token: 0x06002FA7 RID: 12199 RVA: 0x0010D518 File Offset: 0x0010B718
	internal override void Apply(2457 1)
	{
		int num = 0;
		foreach (1445 2 in this.13)
		{
			177.Method12592<208>(this.19, num, ref 2.2);
			177.Method12592<208>(this.20, num, ref 2.6);
			177.Method12592<int>(this.16, num, ref 2.9);
			177.Method12592<int>(this.17, num, ref 2.10);
			num++;
		}
	}

	// Token: 0x06002FA8 RID: 12200 RVA: 0x0010D5B4 File Offset: 0x0010B7B4
	protected void 21(1445 1)
	{
		this.16.Add(1.9);
		this.17.Add(1.10);
		this.19.Add(1.2);
		this.20.Add(1.6);
	}

	// Token: 0x0400225D RID: 8797
	protected new 208 18;

	// Token: 0x0400225E RID: 8798
	protected new List<208> 19;

	// Token: 0x0400225F RID: 8799
	protected List<208> 20;
}
