using System;

// Token: 0x02000627 RID: 1575
public sealed class 2431 : 2435
{
	// Token: 0x06002FC5 RID: 12229 RVA: 0x0010DC67 File Offset: 0x0010BE67
	internal 2431(2447 1, 2450 2) : base(1, 2)
	{
		base.2((2451)9);
	}

	// Token: 0x06002FC6 RID: 12230 RVA: 0x0001702D File Offset: 0x0001522D
	internal override bool CaptureBackup()
	{
		return true;
	}

	// Token: 0x06002FC7 RID: 12231 RVA: 0x00108232 File Offset: 0x00106432
	internal override bool HasChanged()
	{
		return this.10.Count > 0;
	}

	// Token: 0x06002FC8 RID: 12232 RVA: 0x0010DC7C File Offset: 0x0010BE7C
	internal override void Apply(2457 1)
	{
		if (1 == (2457)1)
		{
			foreach (object obj in this.10)
			{
				1259 item = (1259)obj;
				1226.81().Add(item);
			}
			1226.69();
			1226.70(true);
			return;
		}
		if (1 != (2457)2)
		{
			return;
		}
		foreach (object obj2 in this.10)
		{
			1259 item2 = (1259)obj2;
			1226.81().Remove(item2);
		}
		1226.69();
		1226.70(false);
	}
}
