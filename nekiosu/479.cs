using System;
using System.Runtime.InteropServices;

// Token: 0x02000146 RID: 326
[ComVisible(false)]
public sealed class 479
{
	// Token: 0x06000B3D RID: 2877 RVA: 0x0002A210 File Offset: 0x00028410
	public 479()
	{
		this.SetFlag3606_4589(true);
	}

	// Token: 0x06000B3E RID: 2878 RVA: 0x0002A21F File Offset: 0x0002841F
	static 479()
	{
		479 <<EMPTY_NAME>> = new 479();
		<<EMPTY_NAME>>.SetFlag3606_4589(false);
		479._recoveredType08253605 = <<EMPTY_NAME>>;
	}

	// Token: 0x06000B3F RID: 2879 RVA: 0x0002A232 File Offset: 0x00028432
	public bool GetFlag3606_4588()
	{
		return this.flag2;
	}

	// Token: 0x06000B40 RID: 2880 RVA: 0x0002A23A File Offset: 0x0002843A
	public void SetFlag3606_4589(bool 1)
	{
		this.flag2 = 1;
	}

	// Token: 0x0400058B RID: 1419
	[241(1)]
	internal static readonly 479 _recoveredType08253605;

	// Token: 0x0400058C RID: 1420
	private bool flag2;
}
