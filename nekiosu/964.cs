using System;
using System.Runtime.InteropServices;

// Token: 0x020003A6 RID: 934
[810]
[ComVisible(false)]
[Serializable]
public struct 964
{
	// Token: 0x06001CCB RID: 7371 RVA: 0x00073161 File Offset: 0x00071361
	public override string ToString()
	{
		return string.Format("{{X={0}, Y={1}, Z={2}}}", this.X, this.Y, this.Z);
	}

	// Token: 0x04000E5A RID: 3674
	[519]
	public float X;

	// Token: 0x04000E5B RID: 3675
	[519]
	public float Y;

	// Token: 0x04000E5C RID: 3676
	[519]
	public float Z;
}
