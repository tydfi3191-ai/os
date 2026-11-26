using System;
using System.Threading;

// Token: 0x02000264 RID: 612
public interface 486<TItem> : 688
{
	// Token: 0x06001293 RID: 4755
	TItem Method134252();

	// Token: 0x06001294 RID: 4756
	TItem Method134252(int 1, bool 2);

	// Token: 0x06001295 RID: 4757
	TItem Method134252(TimeSpan 1, bool 2);

	// Token: 0x06001296 RID: 4758
	TItem Method134252(int 1, bool 2, WaitHandle 3);

	// Token: 0x06001297 RID: 4759
	TItem Method134252(TimeSpan 1, bool 2, WaitHandle 3);

	// Token: 0x06001298 RID: 4760
	TItem Method134252(out Exception 1);

	// Token: 0x06001299 RID: 4761
	TItem Method134252(int 1, bool 2, out Exception 3);

	// Token: 0x0600129A RID: 4762
	TItem Method134252(TimeSpan 1, bool 2, out Exception 3);

	// Token: 0x0600129B RID: 4763
	TItem Method134252(int 1, bool 2, WaitHandle 3, out Exception 4);

	// Token: 0x0600129C RID: 4764
	TItem Method134252(TimeSpan 1, bool 2, WaitHandle 3, out Exception 4);

	// Token: 0x0600129D RID: 4765
	bool Method13423();

	// Token: 0x0600129E RID: 4766
	bool Method13424();

	// Token: 0x0600129F RID: 4767
	object GetValue10400_13437();

	// Token: 0x060012A0 RID: 4768
	bool Method134352();

	// Token: 0x060012A1 RID: 4769
	bool Method134352(bool 1);

	// Token: 0x060012A2 RID: 4770
	639 Method13438();

	// Token: 0x060012A3 RID: 4771
	TItem Method13439();

	// Token: 0x060012A4 RID: 4772
	object GetException10403_13440();
}
