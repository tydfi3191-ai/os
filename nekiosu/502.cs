using System;
using System.Runtime.InteropServices;

// Token: 0x0200000F RID: 15
[ComVisible(false)]
[StructLayout(LayoutKind.Sequential)]
public sealed class 502
{
	// Token: 0x06000037 RID: 55 RVA: 0x00002A2F File Offset: 0x00000C2F
	public 502()
	{
		this._recoveredType03414498 = (371)(-1);
	}

	// Token: 0x06000038 RID: 56 RVA: 0x00002A3E File Offset: 0x00000C3E
	public 502(float 1, float 2, float 3, float 4)
	{
		this._recoveredType03414498 = (371)(-1);
		this.amount5 = 1;
		this.amount6 = 2;
		this.amount7 = 3;
		this.amount8 = 4;
	}

	// Token: 0x06000039 RID: 57 RVA: 0x00002A6A File Offset: 0x00000C6A
	public 502(float 1, float 2, float 3, float 4, 371 5)
	{
		this._recoveredType03414498 = (371)(-1);
		this.amount5 = 1;
		this.amount6 = 2;
		this.amount7 = 3;
		this.amount8 = 4;
		this._recoveredType03414498 = 5;
	}

	// Token: 0x0600003A RID: 58 RVA: 0x00002A9E File Offset: 0x00000C9E
	public void Method5669()
	{
		this.amount5 = 0.999f;
		this.amount6 = 0.999f;
		this.amount7 = 0f;
		this.amount8 = 0.2f;
	}

	// Token: 0x0600003B RID: 59 RVA: 0x00002ACC File Offset: 0x00000CCC
	public void Method5670()
	{
		this.amount5 = 0.999f;
		this.amount6 = 0.999f;
		this.amount7 = 0.7f;
		this.amount8 = 0.5f;
	}

	// Token: 0x0600003C RID: 60 RVA: 0x00002AFA File Offset: 0x00000CFA
	public void Method5671()
	{
		this.amount5 = 0.999f;
		this.amount6 = 0.999f;
		this.amount7 = -0.7f;
		this.amount8 = 0.8f;
	}

	// Token: 0x04000022 RID: 34
	public float amount5;

	// Token: 0x04000023 RID: 35
	public float amount6;

	// Token: 0x04000024 RID: 36
	public float amount7;

	// Token: 0x04000025 RID: 37
	public float amount8;

	// Token: 0x04000026 RID: 38
	public 371 _recoveredType03414498;
}
