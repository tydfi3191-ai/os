using System;

// Token: 0x0200035B RID: 859
[62]
[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = false)]
public sealed class 242 : Attribute
{
	// Token: 0x06001A85 RID: 6789 RVA: 0x0006403C File Offset: 0x0006223C
	public 242(byte 1)
	{
		this.flag = 1;
	}

	// Token: 0x04000CA2 RID: 3234
	public readonly byte flag;
}
