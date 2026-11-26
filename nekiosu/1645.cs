using System;
using System.IO;
using System.Runtime.InteropServices;

// Token: 0x02000987 RID: 2439
[ComVisible(false)]
public sealed class 1645
{
	// Token: 0x0600448A RID: 17546 RVA: 0x001B096D File Offset: 0x001AEB6D
	public 1645(byte[] 1, int 2, int 3)
	{
		this.1 = 1;
		this.2 = 2;
		this.3 = 3;
		this.4 = new MemoryStream(1, 2, 3, true);
	}

	// Token: 0x04003272 RID: 12914
	public byte[] 1;

	// Token: 0x04003273 RID: 12915
	public int 2;

	// Token: 0x04003274 RID: 12916
	public int 3;

	// Token: 0x04003275 RID: 12917
	public MemoryStream 4;
}
