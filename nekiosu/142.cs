using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

// Token: 0x020000AE RID: 174
[ComVisible(false)]
[Serializable]
public sealed class 142 : 134
{
	// Token: 0x0600045A RID: 1114 RVA: 0x0000D7D8 File Offset: 0x0000B9D8
	public 142()
	{
	}

	// Token: 0x0600045B RID: 1115 RVA: 0x0000D7E0 File Offset: 0x0000B9E0
	public 142(string 1) : base(1)
	{
	}

	// Token: 0x0600045C RID: 1116 RVA: 0x0000D7E9 File Offset: 0x0000B9E9
	public 142(string 1, Exception 2) : base(1, 2)
	{
	}

	// Token: 0x0600045D RID: 1117 RVA: 0x0000D7F3 File Offset: 0x0000B9F3
	public 142(SerializationInfo 1, StreamingContext 2) : base(1, 2)
	{
	}

	// Token: 0x0600045E RID: 1118 RVA: 0x0000D7FD File Offset: 0x0000B9FD
	internal 142(string 1, Exception 2, string 3, int 4, int 5) : base(1, 2)
	{
		this.path = 3;
		this.lineNumber = 4;
		this.linePosition = 5;
	}

	// Token: 0x0600045F RID: 1119 RVA: 0x0000D81E File Offset: 0x0000BA1E
	public int GetLineNumber()
	{
		return this.lineNumber;
	}

	// Token: 0x06000460 RID: 1120 RVA: 0x0000D826 File Offset: 0x0000BA26
	public int GetLinePosition()
	{
		return this.linePosition;
	}

	// Token: 0x06000461 RID: 1121 RVA: 0x0000D82E File Offset: 0x0000BA2E
	public string GetPath()
	{
		return this.path;
	}

	// Token: 0x040003BE RID: 958
	private readonly int lineNumber;

	// Token: 0x040003BF RID: 959
	private readonly int linePosition;

	// Token: 0x040003C0 RID: 960
	private readonly string path;
}
