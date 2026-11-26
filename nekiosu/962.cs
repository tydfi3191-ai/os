using System;
using System.Runtime.InteropServices;

// Token: 0x020003A4 RID: 932
[810]
[ComVisible(false)]
[Serializable]
public struct 962
{
	// Token: 0x06001CC9 RID: 7369 RVA: 0x00073112 File Offset: 0x00071312
	public override string ToString()
	{
		return string.Format("{{X={0}, Y={1}}}", this.X, this.Y);
	}

	// Token: 0x04000E55 RID: 3669
	[519]
	public int X;

	// Token: 0x04000E56 RID: 3670
	[519]
	public int Y;
}
