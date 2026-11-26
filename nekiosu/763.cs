using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

// Token: 0x020000FA RID: 250
[242(1)]
[241(0)]
[ComVisible(false)]
[Serializable]
public sealed class 763 : 134
{
	// Token: 0x1700007C RID: 124
	// (get) Token: 0x06000887 RID: 2183 RVA: 0x0001CEB4 File Offset: 0x0001B0B4
	[241(2)]
	public string Text9651
	{
		[242(2)]
		get
		{
			return this.text3;
		}
	}

	// Token: 0x06000888 RID: 2184 RVA: 0x0000D7D8 File Offset: 0x0000B9D8
	public 763()
	{
	}

	// Token: 0x06000889 RID: 2185 RVA: 0x0000D7E0 File Offset: 0x0000B9E0
	public 763(string 1) : base(1)
	{
	}

	// Token: 0x0600088A RID: 2186 RVA: 0x0000D7E9 File Offset: 0x0000B9E9
	public 763(string 1, Exception 2) : base(1, 2)
	{
	}

	// Token: 0x0600088B RID: 2187 RVA: 0x0000D7F3 File Offset: 0x0000B9F3
	public 763(SerializationInfo 1, StreamingContext 2) : base(1, 2)
	{
	}

	// Token: 0x0600088C RID: 2188 RVA: 0x0001CEBC File Offset: 0x0001B0BC
	public 763(string 1, string 2, [241(2)] Exception 3) : base(1, 3)
	{
		this.text3 = 2;
	}

	// Token: 0x0600088D RID: 2189 RVA: 0x0001CECD File Offset: 0x0001B0CD
	internal static 763 Method12341(173 1, string 2, [241(2)] Exception 3)
	{
		return 763.Method12341(1.GetContainerPath(), 2, 3);
	}

	// Token: 0x0600088E RID: 2190 RVA: 0x0001CEDC File Offset: 0x0001B0DC
	internal static 763 Method12341(string 1, string 2, [241(2)] Exception 3)
	{
		2 = 137.Method3522(null, 1, 2);
		return new 763(2, 1, 3);
	}

	// Token: 0x040004C0 RID: 1216
	[241(2)]
	private readonly string text3;
}
