using System;
using System.Collections.Generic;

// Token: 0x02000C36 RID: 3126
public sealed class 1084 : IComparer<1083>
{
	// Token: 0x0600545F RID: 21599 RVA: 0x0020BE88 File Offset: 0x0020A088
	public int Compare(1083 1, 1083 2)
	{
		return 2.GetPriority().CompareTo(1.GetPriority());
	}
}
