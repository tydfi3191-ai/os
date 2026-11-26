using System;

// Token: 0x0200035A RID: 858
[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = false)]
[62]
public sealed class 241 : Attribute
{
	// Token: 0x06001A83 RID: 6787 RVA: 0x00064015 File Offset: 0x00062215
	public 241(byte 1)
	{
		this.nullableFlags = new byte[]
		{
			1
		};
	}

	// Token: 0x06001A84 RID: 6788 RVA: 0x0006402D File Offset: 0x0006222D
	public 241(byte[] 1)
	{
		this.nullableFlags = 1;
	}

	// Token: 0x04000CA1 RID: 3233
	public readonly byte[] nullableFlags;
}
