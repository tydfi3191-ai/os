using System;
using System.Collections.Generic;

// Token: 0x0200061E RID: 1566
public abstract class 2422 : 2421
{
	// Token: 0x06002F9A RID: 12186 RVA: 0x0010BAE9 File Offset: 0x00109CE9
	protected 2422(2445 1, 2450 2) : base(1, 2)
	{
	}

	// Token: 0x06002F9B RID: 12187 RVA: 0x0010D2BF File Offset: 0x0010B4BF
	protected void 20()
	{
		base.17();
		this.18 = new List<float>();
		this.19 = new List<float>();
	}

	// Token: 0x06002F9C RID: 12188 RVA: 0x0010D2E0 File Offset: 0x0010B4E0
	internal override void Apply(2457 1)
	{
		2647 2 = (2647)this.8[0];
		int num = 0;
		foreach (1445 3 in this.13)
		{
			177.Method12592<float>(this.18, num, ref 3.1);
			177.Method12592<float>(this.19, num, ref 3.5);
			177.Method12592<int>(this.16, num, ref 3.9);
			177.Method12592<int>(this.17, num, ref 3.10);
			num++;
		}
	}

	// Token: 0x06002F9D RID: 12189 RVA: 0x0010D38C File Offset: 0x0010B58C
	protected void 21(1445 1)
	{
		this.16.Add(1.9);
		this.17.Add(1.10);
		this.18.Add(1.1);
		this.19.Add(1.5);
	}

	// Token: 0x04002258 RID: 8792
	protected new List<float> 18;

	// Token: 0x04002259 RID: 8793
	protected new List<float> 19;
}
