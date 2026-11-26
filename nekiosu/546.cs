using System;
using System.Runtime.Serialization;

// Token: 0x02000159 RID: 345
[241(0)]
[242(1)]
public sealed class 546 : 718
{
	// Token: 0x06000BEC RID: 3052 RVA: 0x0002B276 File Offset: 0x00029476
	public 546(SerializationBinder 1)
	{
		this.serializationBinder2 = 1;
	}

	// Token: 0x06000BED RID: 3053 RVA: 0x0002B285 File Offset: 0x00029485
	public Type BindToType([241(2)] string 1, string 2)
	{
		return this.serializationBinder2.BindToType(1, 2);
	}

	// Token: 0x06000BEE RID: 3054 RVA: 0x0002B294 File Offset: 0x00029494
	[242(2)]
	public void BindToName([241(1)] Type 1, out string 2, out string 3)
	{
		this.serializationBinder2.BindToName(1, out 2, out 3);
	}

	// Token: 0x040005CE RID: 1486
	public readonly SerializationBinder serializationBinder2;
}
