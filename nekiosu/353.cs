using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

// Token: 0x020002B0 RID: 688
[ComVisible(false)]
[Serializable]
public sealed class 353 : ApplicationException
{
	// Token: 0x060014E7 RID: 5351 RVA: 0x0004902B File Offset: 0x0004722B
	public 353()
	{
	}

	// Token: 0x060014E8 RID: 5352 RVA: 0x00049033 File Offset: 0x00047233
	public 353(string 1) : base(1)
	{
	}

	// Token: 0x060014E9 RID: 5353 RVA: 0x0004903C File Offset: 0x0004723C
	public 353(string 1, Exception 2) : base(1, 2)
	{
	}

	// Token: 0x060014EA RID: 5354 RVA: 0x00049046 File Offset: 0x00047246
	protected 353(SerializationInfo 1, StreamingContext 2) : base(1, 2)
	{
	}
}
