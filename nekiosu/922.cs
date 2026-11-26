using System;
using System.Threading;

// Token: 0x02000283 RID: 643
public static class 922
{
	// Token: 0x060013BC RID: 5052 RVA: 0x000454AF File Offset: 0x000436AF
	internal static bool WaitAll(WaitHandle[] 1, int 2, bool 3)
	{
		return WaitHandle.WaitAll(1, 2, 3);
	}

	// Token: 0x060013BD RID: 5053 RVA: 0x000454B9 File Offset: 0x000436B9
	internal static int Method5095(WaitHandle[] 1)
	{
		return WaitHandle.WaitAny(1);
	}

	// Token: 0x060013BE RID: 5054 RVA: 0x000454C1 File Offset: 0x000436C1
	internal static int Method5095(WaitHandle[] 1, int 2, bool 3)
	{
		return WaitHandle.WaitAny(1, 2, 3);
	}

	// Token: 0x060013BF RID: 5055 RVA: 0x000454CB File Offset: 0x000436CB
	internal static bool WaitOne(WaitHandle 1, int 2, bool 3)
	{
		return 1.WaitOne(2, 3);
	}
}
