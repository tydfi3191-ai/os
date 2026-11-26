using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

// Token: 0x020000DC RID: 220
[241(0)]
[ComVisible(false)]
[242(1)]
[Serializable]
public class 134 : Exception
{
	// Token: 0x060005A5 RID: 1445 RVA: 0x00012723 File Offset: 0x00010923
	public 134()
	{
	}

	// Token: 0x060005A6 RID: 1446 RVA: 0x0001272B File Offset: 0x0001092B
	public 134(string 1) : base(1)
	{
	}

	// Token: 0x060005A7 RID: 1447 RVA: 0x00012734 File Offset: 0x00010934
	public 134(string 1, [241(2)] Exception 2) : base(1, 2)
	{
	}

	// Token: 0x060005A8 RID: 1448 RVA: 0x0001273E File Offset: 0x0001093E
	public 134(SerializationInfo 1, StreamingContext 2) : base(1, 2)
	{
	}

	// Token: 0x060005A9 RID: 1449 RVA: 0x00012748 File Offset: 0x00010948
	internal static 134 Method8331(99 1, string 2, string 3)
	{
		3 = 137.Method3522(1, 2, 3);
		return new 134(3);
	}
}
