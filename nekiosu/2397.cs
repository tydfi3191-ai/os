using System;

// Token: 0x02000605 RID: 1541
public sealed class 2397 : 2435
{
	// Token: 0x06002F32 RID: 12082 RVA: 0x0010B4C9 File Offset: 0x001096C9
	internal 2397(2447 1, 2450 2) : base(1, 2)
	{
		base.2((2451)16);
	}

	// Token: 0x06002F33 RID: 12083 RVA: 0x0000FF75 File Offset: 0x0000E175
	protected override bool UsesObjectLists()
	{
		return false;
	}

	// Token: 0x06002F34 RID: 12084 RVA: 0x0010B4DB File Offset: 0x001096DB
	internal override bool CaptureBackup()
	{
		this.13 = 1272.5().5;
		return true;
	}

	// Token: 0x06002F35 RID: 12085 RVA: 0x0010B4EE File Offset: 0x001096EE
	internal override void Release()
	{
		this.13 = 0.0;
		base.Release();
	}

	// Token: 0x06002F36 RID: 12086 RVA: 0x0010B505 File Offset: 0x00109705
	internal override bool HasChanged()
	{
		return this.13 != 1272.5().5;
	}

	// Token: 0x06002F37 RID: 12087 RVA: 0x0010B51C File Offset: 0x0010971C
	internal override void Apply(2457 1)
	{
		double 2 = 1272.5().5;
		1272.5().5 = this.13;
		this.13 = 2;
		this.4.6.RecalculateDifficulty(false, true, true);
	}

	// Token: 0x04002234 RID: 8756
	private new double 13;
}
