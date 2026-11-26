using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

// Token: 0x02000988 RID: 2440
[ComVisible(false)]
public sealed class 1646 : Stack<1645>
{
	// Token: 0x0600448B RID: 17547 RVA: 0x001B099C File Offset: 0x001AEB9C
	public 1646(int 1, int 2) : base(2)
	{
		this.2 = 1;
		this.3 = 2;
		this.1 = new byte[1 * 2];
		this.4 = GCHandle.Alloc(this.1, GCHandleType.Pinned);
		for (int i = 0; i < 1 * 2 - 1; i++)
		{
			this.1[i] = 0;
		}
		for (int j = 0; j < 2; j++)
		{
			this.1(new 1645(this.1, j * 1, 1));
		}
	}

	// Token: 0x0600448C RID: 17548 RVA: 0x001B0A18 File Offset: 0x001AEC18
	public void 1(1645 1)
	{
		lock (this)
		{
			base.Push(1);
		}
	}

	// Token: 0x04003276 RID: 12918
	private byte[] 1;

	// Token: 0x04003277 RID: 12919
	private int 2;

	// Token: 0x04003278 RID: 12920
	private int 3;

	// Token: 0x04003279 RID: 12921
	private GCHandle 4;
}
