using System;

// Token: 0x02000622 RID: 1570
public sealed class 2426 : 2435
{
	// Token: 0x06002FA9 RID: 12201 RVA: 0x0010D605 File Offset: 0x0010B805
	internal 2426(2447 1, 2450 2) : base(1, 2)
	{
		base.2((2451)8);
	}

	// Token: 0x06002FAA RID: 12202 RVA: 0x0001702D File Offset: 0x0001522D
	internal override bool CaptureBackup()
	{
		return true;
	}

	// Token: 0x06002FAB RID: 12203 RVA: 0x00108031 File Offset: 0x00106231
	internal override bool HasChanged()
	{
		return this.9.Count > 0;
	}

	// Token: 0x06002FAC RID: 12204 RVA: 0x0010D618 File Offset: 0x0010B818
	internal override void Apply(2457 1)
	{
		if (1 == (2457)1)
		{
			foreach (object obj in this.9)
			{
				1259 item = (1259)obj;
				1226.81().Remove(item);
			}
			1226.69();
			1226.70(false);
			return;
		}
		if (1 != (2457)2)
		{
			return;
		}
		foreach (object obj2 in this.9)
		{
			1259 item2 = (1259)obj2;
			1226.81().Add(item2);
		}
		1226.69();
		1226.70(true);
	}
}
