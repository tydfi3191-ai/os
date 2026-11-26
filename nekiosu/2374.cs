using System;

// Token: 0x020005EE RID: 1518
public sealed class 2374 : 2387
{
	// Token: 0x06002EB6 RID: 11958 RVA: 0x00108342 File Offset: 0x00106542
	internal 2374(2440 1, 2450 2 = (2450)0) : base(1, 2)
	{
		base.2((2451)24);
	}

	// Token: 0x06002EB7 RID: 11959 RVA: 0x00108354 File Offset: 0x00106554
	internal override bool CaptureBackup()
	{
		if (!base.13((2450)1) && !base.13((2450)2))
		{
			throw new NotImplementedException();
		}
		return true;
	}

	// Token: 0x06002EB8 RID: 11960 RVA: 0x0001702D File Offset: 0x0001522D
	internal override bool HasChanged()
	{
		return true;
	}

	// Token: 0x06002EB9 RID: 11961 RVA: 0x00108370 File Offset: 0x00106570
	internal override void Apply(2457 1)
	{
		2263 2 = this.4.1;
		if (base.13((2450)1))
		{
			base.18(new 1189(2.74.FlipHorizontally));
			return;
		}
		base.18(new 1189(2.74.FlipVertically));
	}
}
