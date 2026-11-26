using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

// Token: 0x020000F1 RID: 241
[241(0)]
[ComVisible(false)]
[242(1)]
[Serializable]
public sealed class 364 : 134
{
	// Token: 0x17000075 RID: 117
	// (get) Token: 0x06000852 RID: 2130 RVA: 0x0001C665 File Offset: 0x0001A865
	[241(2)]
	public string Text1152
	{
		[242(2)]
		get
		{
			return this.text3;
		}
	}

	// Token: 0x06000853 RID: 2131 RVA: 0x0000D7D8 File Offset: 0x0000B9D8
	public 364()
	{
	}

	// Token: 0x06000854 RID: 2132 RVA: 0x0000D7E0 File Offset: 0x0000B9E0
	public 364(string 1) : base(1)
	{
	}

	// Token: 0x06000855 RID: 2133 RVA: 0x0000D7E9 File Offset: 0x0000B9E9
	public 364(string 1, Exception 2) : base(1, 2)
	{
	}

	// Token: 0x06000856 RID: 2134 RVA: 0x0000D7F3 File Offset: 0x0000B9F3
	public 364(SerializationInfo 1, StreamingContext 2) : base(1, 2)
	{
	}

	// Token: 0x06000857 RID: 2135 RVA: 0x0001C66D File Offset: 0x0001A86D
	public 364(string 1, string 2, int 3, int 4, [241(2)] Exception 5) : base(1, 5)
	{
		this.text3 = 2;
		this.number3 = 3;
		this.number4 = 4;
	}

	// Token: 0x06000858 RID: 2136 RVA: 0x0001C68E File Offset: 0x0001A88E
	public int GetNumber1149_1685()
	{
		return this.number3;
	}

	// Token: 0x06000859 RID: 2137 RVA: 0x0001C696 File Offset: 0x0001A896
	public int GetNumber1150_1686()
	{
		return this.number4;
	}

	// Token: 0x0600085A RID: 2138 RVA: 0x0001C69E File Offset: 0x0001A89E
	internal static 364 Method1687(139 1, string 2)
	{
		return 364.Method1687(1, 2, null);
	}

	// Token: 0x0600085B RID: 2139 RVA: 0x0001C6A8 File Offset: 0x0001A8A8
	internal static 364 Method1687(139 1, string 2, [241(2)] Exception 3)
	{
		return 364.Method1687(1 as 99, 1.Path, 2, 3);
	}

	// Token: 0x0600085C RID: 2140 RVA: 0x0001C6C0 File Offset: 0x0001A8C0
	internal static 364 Method1687([241(2)] 99 1, string 2, string 3, [241(2)] Exception 4)
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
		return new 364(3, 2, 5, 6, 4);
	}

	// Token: 0x040004B8 RID: 1208
	private readonly int number3;

	// Token: 0x040004B9 RID: 1209
	private readonly int number4;

	// Token: 0x040004BA RID: 1210
	[241(2)]
	private readonly string text3;
}
