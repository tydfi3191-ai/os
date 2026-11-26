using System;

// Token: 0x020005FD RID: 1533
public sealed class 2389 : 2390
{
	// Token: 0x06002F09 RID: 12041 RVA: 0x0010AB07 File Offset: 0x00108D07
	internal 2389(2444 1, 2450 2) : base(1, 2)
	{
		base.2((2451)0);
	}

	// Token: 0x06002F0A RID: 12042 RVA: 0x0001702D File Offset: 0x0001522D
	internal override bool CaptureBackup()
	{
		return true;
	}

	// Token: 0x06002F0B RID: 12043 RVA: 0x0010AB18 File Offset: 0x00108D18
	internal override bool HasChanged()
	{
		return 1272.5().78 != (int)this.8[0];
	}

	// Token: 0x06002F0C RID: 12044 RVA: 0x0010AB3C File Offset: 0x00108D3C
	internal override void Apply(2457 1)
	{
		int 2 = 1272.5().78;
		1272.5().78 = (int)this.8[0];
		this.8[0] = 2;
	}
}
