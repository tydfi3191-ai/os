using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

// Token: 0x020001C5 RID: 453
[ComVisible(false)]
public sealed class 786 : IEqualityComparer<226>
{
	// Token: 0x06000E73 RID: 3699 RVA: 0x00030D73 File Offset: 0x0002EF73
	[242(2)]
	public bool Equals(226 1, 226 2)
	{
		return 226.DeepEquals(1, 2);
	}

	// Token: 0x06000E74 RID: 3700 RVA: 0x00030D7C File Offset: 0x0002EF7C
	[242(1)]
	public int GetHashCode(226 1)
	{
		if (1 == null)
		{
			return 0;
		}
		return 1.Method14364();
	}
}
