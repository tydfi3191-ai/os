using System;
using System.Collections.Generic;

// Token: 0x02000496 RID: 1174
public sealed class 2592 : IComparer<2593>
{
	// Token: 0x060023B6 RID: 9142 RVA: 0x0009C7CB File Offset: 0x0009A9CB
	internal 2592(Comparison<1262> 1)
	{
		this.1 = 1;
	}

	// Token: 0x060023B7 RID: 9143 RVA: 0x0009C7DA File Offset: 0x0009A9DA
	public int Compare(2593 1, 2593 2)
	{
		if (1 == 2)
		{
			return 0;
		}
		if (1.14 == null)
		{
			return -1;
		}
		if (2.14 == null)
		{
			return 1;
		}
		return this.1(1.14, 2.14);
	}

	// Token: 0x040018CD RID: 6349
	private Comparison<1262> 1;
}
