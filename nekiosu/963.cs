using System;
using System.Runtime.InteropServices;

// Token: 0x020003A5 RID: 933
[810]
[ComVisible(false)]
[Serializable]
public struct 963
{
	// Token: 0x06001CCA RID: 7370 RVA: 0x00073134 File Offset: 0x00071334
	public override string ToString()
	{
		return string.Format("{{X={0}, Y={1}, Z={2}}}", this.X, this.Y, this.Z);
	}

	// Token: 0x04000E57 RID: 3671
	[519]
	public int X;

	// Token: 0x04000E58 RID: 3672
	[519]
	public int Y;

	// Token: 0x04000E59 RID: 3673
	[519]
	public int Z;
}
