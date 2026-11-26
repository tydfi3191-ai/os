using System;
using System.Runtime.InteropServices;

// Token: 0x020001A9 RID: 425
[ComVisible(false)]
[241(0)]
[242(1)]
public sealed class 713 : EventArgs
{
	// Token: 0x170000C2 RID: 194
	// (get) Token: 0x06000DCF RID: 3535 RVA: 0x0002F714 File Offset: 0x0002D914
	[241(2)]
	public object Value8694
	{
		[242(2)]
		get
		{
			return this.value2;
		}
	}

	// Token: 0x06000DD0 RID: 3536 RVA: 0x0002F71C File Offset: 0x0002D91C
	public 713([241(2)] object 1, 236 2)
	{
		this.value2 = 1;
		this.errorContext2 = 2;
	}

	// Token: 0x06000DD1 RID: 3537 RVA: 0x0002F732 File Offset: 0x0002D932
	public 236 GetErrorContext8693_11023()
	{
		return this.errorContext2;
	}

	// Token: 0x040006A3 RID: 1699
	[241(2)]
	private readonly object value2;

	// Token: 0x040006A4 RID: 1700
	private readonly 236 errorContext2;
}
