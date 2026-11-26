using System;

// Token: 0x02000607 RID: 1543
public sealed class 2399 : 2435
{
	// Token: 0x06002F3D RID: 12093 RVA: 0x0010B915 File Offset: 0x00109B15
	internal 2399(2447 1, 2450 2) : base(1, 2)
	{
		base.2((2451)17);
	}

	// Token: 0x06002F3E RID: 12094 RVA: 0x0000FF75 File Offset: 0x0000E175
	protected override bool UsesObjectLists()
	{
		return false;
	}

	// Token: 0x06002F3F RID: 12095 RVA: 0x0010B927 File Offset: 0x00109B27
	internal override bool CaptureBackup()
	{
		this.13 = 1272.5().6;
		return true;
	}

	// Token: 0x06002F40 RID: 12096 RVA: 0x0010B93A File Offset: 0x00109B3A
	internal override void Release()
	{
		this.13 = 0.0;
		base.Release();
	}

	// Token: 0x06002F41 RID: 12097 RVA: 0x0010B951 File Offset: 0x00109B51
	internal override bool HasChanged()
	{
		return this.13 != 1272.5().6;
	}

	// Token: 0x06002F42 RID: 12098 RVA: 0x0010B968 File Offset: 0x00109B68
	internal override void Apply(2457 1)
	{
		double 2 = 1272.5().6;
		1272.5().6 = this.13;
		this.13 = 2;
		this.4.6.RecalculateDifficulty(false, true, true);
	}

	// Token: 0x04002236 RID: 8758
	private new double 13;
}
