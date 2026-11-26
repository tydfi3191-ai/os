using System;
using System.Threading;

// Token: 0x0200026B RID: 619
public static class 595
{
	// Token: 0x060012C9 RID: 4809 RVA: 0x00042AA1 File Offset: 0x00040CA1
	public static AutoResetEvent Method8116()
	{
		return new AutoResetEvent(false);
	}

	// Token: 0x060012CA RID: 4810 RVA: 0x00042AA9 File Offset: 0x00040CA9
	public static ManualResetEvent Method8117(bool 1)
	{
		return new ManualResetEvent(1);
	}
}
