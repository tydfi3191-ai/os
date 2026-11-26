using System;
using System.Runtime.InteropServices;

// Token: 0x0200039F RID: 927
[ComVisible(false)]
[810]
[Serializable]
public struct 957
{
	// Token: 0x06001CC8 RID: 7368 RVA: 0x000730E5 File Offset: 0x000712E5
	public override string ToString()
	{
		return string.Format("{{{0}, Size={1}, Found={2}}}", this.Position, this.Size, this.Found);
	}

	// Token: 0x04000E3C RID: 3644
	[519]
	public 962 RawPosition;

	// Token: 0x04000E3D RID: 3645
	[519]
	public 965 Position;

	// Token: 0x04000E3E RID: 3646
	[519]
	public int Size;

	// Token: 0x04000E3F RID: 3647
	[519]
	public bool Found;
}
