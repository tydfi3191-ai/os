using System;
using System.Runtime.InteropServices;

// Token: 0x0200019E RID: 414
[ComVisible(false)]
public sealed class 691 : EventArgs
{
	// Token: 0x06000D8A RID: 3466 RVA: 0x0002EF17 File Offset: 0x0002D117
	internal 691(142 1)
	{
		756.Method12216(1, "ex");
		this.jsonReaderPositionException2 = 1;
	}

	// Token: 0x06000D8B RID: 3467 RVA: 0x0002EF31 File Offset: 0x0002D131
	public 142 GetRecoveredType15018098_10353()
	{
		return this.jsonReaderPositionException2;
	}

	// Token: 0x06000D8C RID: 3468 RVA: 0x0002EF39 File Offset: 0x0002D139
	public string Method10354()
	{
		return this.jsonReaderPositionException2.GetPath();
	}

	// Token: 0x06000D8D RID: 3469 RVA: 0x0002EF46 File Offset: 0x0002D146
	public string Method10355()
	{
		return this.jsonReaderPositionException2.Message;
	}

	// Token: 0x04000677 RID: 1655
	private readonly 142 jsonReaderPositionException2;
}
