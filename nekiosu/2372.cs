using System;

// Token: 0x020005EC RID: 1516
public sealed class 2372 : 2373
{
	// Token: 0x06002EB1 RID: 11953 RVA: 0x00108220 File Offset: 0x00106420
	internal 2372(2439 1, 2450 2) : base(1, 2)
	{
		base.2((2451)9);
	}

	// Token: 0x06002EB2 RID: 11954 RVA: 0x0001702D File Offset: 0x0001522D
	internal override bool CaptureBackup()
	{
		return true;
	}

	// Token: 0x06002EB3 RID: 11955 RVA: 0x00108232 File Offset: 0x00106432
	internal override bool HasChanged()
	{
		return this.10.Count > 0;
	}

	// Token: 0x06002EB4 RID: 11956 RVA: 0x00108244 File Offset: 0x00106444
	internal override void Apply(2457 1)
	{
		if (1 == (2457)1)
		{
			foreach (object obj in this.10)
			{
				int item = (int)obj;
				this.4.6.25.Add(item);
			}
			this.4.6.25.Sort();
			return;
		}
		if (1 != (2457)2)
		{
			return;
		}
		foreach (object obj2 in this.10)
		{
			int item2 = (int)obj2;
			this.4.6.25.Remove(item2);
		}
		this.4.6.25.Sort();
	}
}
