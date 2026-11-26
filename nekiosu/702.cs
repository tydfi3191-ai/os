using System;
using System.Runtime.InteropServices;

// Token: 0x020000F9 RID: 249
[ComVisible(false)]
[AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
public sealed class 702 : 129
{
	// Token: 0x1700007B RID: 123
	// (get) Token: 0x06000882 RID: 2178 RVA: 0x0001CE94 File Offset: 0x0001B094
	// (set) Token: 0x06000883 RID: 2179 RVA: 0x0001CE9C File Offset: 0x0001B09C
	public bool Flag8459
	{
		get
		{
			return this.flag2;
		}
		set
		{
			this.flag2 = value;
		}
	}

	// Token: 0x06000884 RID: 2180 RVA: 0x0001CC67 File Offset: 0x0001AE67
	public 702()
	{
	}

	// Token: 0x06000885 RID: 2181 RVA: 0x0001CEA5 File Offset: 0x0001B0A5
	public 702(bool 1)
	{
		this.flag2 = 1;
	}

	// Token: 0x06000886 RID: 2182 RVA: 0x0001CC7E File Offset: 0x0001AE7E
	[242(1)]
	public 702(string 1) : base(1)
	{
	}

	// Token: 0x040004BF RID: 1215
	private bool flag2;
}
