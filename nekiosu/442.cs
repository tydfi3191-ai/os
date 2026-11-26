using System;
using System.Runtime.InteropServices;

// Token: 0x0200000C RID: 12
[ComVisible(false)]
[StructLayout(LayoutKind.Sequential)]
public sealed class 442
{
	// Token: 0x0600002B RID: 43 RVA: 0x0000281F File Offset: 0x00000A1F
	public 442()
	{
		this._recoveredType03412942 = (371)(-1);
	}

	// Token: 0x0600002C RID: 44 RVA: 0x0000282E File Offset: 0x00000A2E
	public 442(float 1, float 2)
	{
		this._recoveredType03412942 = (371)(-1);
		this.amount3 = 1;
		this.amount4 = 2;
	}

	// Token: 0x0600002D RID: 45 RVA: 0x0000284B File Offset: 0x00000A4B
	public 442(float 1, float 2, 371 3)
	{
		this._recoveredType03412942 = (371)(-1);
		this.amount3 = 1;
		this.amount4 = 2;
		this._recoveredType03412942 = 3;
	}

	// Token: 0x0600002E RID: 46 RVA: 0x0000286F File Offset: 0x00000A6F
	public void Method3734()
	{
		this.amount3 = -0.5f;
		this.amount4 = 0.5f;
	}

	// Token: 0x0600002F RID: 47 RVA: 0x00002887 File Offset: 0x00000A87
	public void Method3735()
	{
		this.amount3 = 0.799f;
		this.amount4 = 0.2f;
	}

	// Token: 0x06000030 RID: 48 RVA: 0x0000289F File Offset: 0x00000A9F
	public void Method3736()
	{
		this.amount3 = 0.6f;
		this.amount4 = 0.05f;
	}

	// Token: 0x06000031 RID: 49 RVA: 0x000028B7 File Offset: 0x00000AB7
	public void Method3737()
	{
		this.amount3 = 0.599f;
		this.amount4 = 1.3f;
	}

	// Token: 0x04000016 RID: 22
	public float amount3;

	// Token: 0x04000017 RID: 23
	public float amount4;

	// Token: 0x04000018 RID: 24
	public 371 _recoveredType03412942;
}
