using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

// Token: 0x020000E2 RID: 226
[ComVisible(false)]
[242(1)]
[241(0)]
[Serializable]
public sealed class 141 : 134
{
	// Token: 0x1700004E RID: 78
	// (get) Token: 0x06000619 RID: 1561 RVA: 0x00013F6E File Offset: 0x0001216E
	[241(2)]
	public string Text10046
	{
		[242(2)]
		get
		{
			return this.text3;
		}
	}

	// Token: 0x0600061A RID: 1562 RVA: 0x0000D7D8 File Offset: 0x0000B9D8
	public 141()
	{
	}

	// Token: 0x0600061B RID: 1563 RVA: 0x0000D7E0 File Offset: 0x0000B9E0
	public 141(string 1) : base(1)
	{
	}

	// Token: 0x0600061C RID: 1564 RVA: 0x0000D7E9 File Offset: 0x0000B9E9
	public 141(string 1, Exception 2) : base(1, 2)
	{
	}

	// Token: 0x0600061D RID: 1565 RVA: 0x0000D7F3 File Offset: 0x0000B9F3
	public 141(SerializationInfo 1, StreamingContext 2) : base(1, 2)
	{
	}

	// Token: 0x0600061E RID: 1566 RVA: 0x00013F76 File Offset: 0x00012176
	public 141(string 1, string 2, int 3, int 4, [241(2)] Exception 5) : base(1, 5)
	{
		this.text3 = 2;
		this.number3 = 3;
		this.number4 = 4;
	}

	// Token: 0x0600061F RID: 1567 RVA: 0x00013F97 File Offset: 0x00012197
	public int GetNumber10043_12884()
	{
		return this.number3;
	}

	// Token: 0x06000620 RID: 1568 RVA: 0x00013F9F File Offset: 0x0001219F
	public int GetNumber10044_12885()
	{
		return this.number4;
	}

	// Token: 0x06000621 RID: 1569 RVA: 0x00013FA7 File Offset: 0x000121A7
	internal static 141 Method12886(139 1, string 2)
	{
		return 141.Method12886(1, 2, null);
	}

	// Token: 0x06000622 RID: 1570 RVA: 0x00013FB1 File Offset: 0x000121B1
	internal static 141 Method12886(139 1, string 2, [241(2)] Exception 3)
	{
		return 141.Method12886(1 as 99, 1.Path, 2, 3);
	}

	// Token: 0x06000623 RID: 1571 RVA: 0x00013FC8 File Offset: 0x000121C8
	internal static 141 Method12886([241(2)] 99 1, string 2, string 3, [241(2)] Exception 4)
	{
		3 = 137.Method3522(1, 2, 3);
		int 5;
		int 6;
		if (1 != null && 1.HasLineInfo())
		{
			5 = 1.GetLineNumber();
			6 = 1.GetLinePosition();
		}
		else
		{
			5 = 0;
			6 = 0;
		}
		return new 141(3, 2, 5, 6, 4);
	}

	// Token: 0x04000468 RID: 1128
	private readonly int number3;

	// Token: 0x04000469 RID: 1129
	private readonly int number4;

	// Token: 0x0400046A RID: 1130
	[241(2)]
	private readonly string text3;
}
