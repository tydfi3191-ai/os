using System;

// Token: 0x02000600 RID: 1536
public sealed class 2392 : 2438
{
	// Token: 0x06002F12 RID: 12050 RVA: 0x0010ABC6 File Offset: 0x00108DC6
	internal 2392(2440 1, 2450 2 = (2450)0) : base(1, 2)
	{
		base.2((2451)25);
	}

	// Token: 0x06002F13 RID: 12051 RVA: 0x0010ABD8 File Offset: 0x00108DD8
	internal override bool CaptureBackup()
	{
		return !base.13((2450)16) || base.CaptureBackup();
	}

	// Token: 0x06002F14 RID: 12052 RVA: 0x0010ABEC File Offset: 0x00108DEC
	internal override bool HasChanged()
	{
		return !base.13((2450)16) || base.HasChanged();
	}

	// Token: 0x06002F15 RID: 12053 RVA: 0x0010AC00 File Offset: 0x00108E00
	internal override void Apply(2457 1)
	{
		2263 2 = this.4.1;
		if (base.13((2450)4))
		{
			if (1 == (2457)1)
			{
				base.18(new 1189(2.74.76));
				return;
			}
			if (1 != (2457)2)
			{
				return;
			}
			base.18(new 1189(2.74.77));
			return;
		}
		else
		{
			if (!base.13((2450)8))
			{
				if (base.13((2450)16))
				{
					base.Apply(1);
				}
				return;
			}
			if (1 == (2457)1)
			{
				base.18(new 1189(2.74.77));
				return;
			}
			if (1 != (2457)2)
			{
				return;
			}
			base.18(new 1189(2.74.76));
			return;
		}
	}
}
