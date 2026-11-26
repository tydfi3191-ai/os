using System;
using System.Runtime.InteropServices;

// Token: 0x020003A7 RID: 935
[810]
[ComVisible(false)]
[Serializable]
public struct 965
{
	// Token: 0x06001CCC RID: 7372 RVA: 0x0007318E File Offset: 0x0007138E
	public override string ToString()
	{
		return string.Format("{{X={0}, Y={1}}}", this.X, this.Y);
	}

	// Token: 0x04000E5D RID: 3677
	[519]
	public float X;

	// Token: 0x04000E5E RID: 3678
	[519]
	public float Y;
}
