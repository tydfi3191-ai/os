using System;

// Token: 0x020005FF RID: 1535
public sealed class 2391 : 2387
{
	// Token: 0x06002F0E RID: 12046 RVA: 0x0010AB81 File Offset: 0x00108D81
	internal 2391(2440 1, 2450 2 = (2450)0) : base(1, 2)
	{
		base.2((2451)26);
	}

	// Token: 0x06002F0F RID: 12047 RVA: 0x0001702D File Offset: 0x0001522D
	internal override bool CaptureBackup()
	{
		return true;
	}

	// Token: 0x06002F10 RID: 12048 RVA: 0x0010AB93 File Offset: 0x00108D93
	internal override bool HasChanged()
	{
		return this.8.Count > 0;
	}

	// Token: 0x06002F11 RID: 12049 RVA: 0x0010ABA3 File Offset: 0x00108DA3
	internal override void Apply(2457 1)
	{
		base.18(new 1189(this.4.1.74.75));
	}
}
