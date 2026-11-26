using System;
using System.Collections.Generic;

// Token: 0x0200060E RID: 1550
public sealed class 2406 : 2421
{
	// Token: 0x06002F5B RID: 12123 RVA: 0x0010BDF8 File Offset: 0x00109FF8
	internal 2406(2445 1, 2450 2) : base(1, 2)
	{
		base.2((2451)9);
	}

	// Token: 0x06002F5C RID: 12124 RVA: 0x0001702D File Offset: 0x0001522D
	internal override bool CaptureBackup()
	{
		return true;
	}

	// Token: 0x06002F5D RID: 12125 RVA: 0x00108232 File Offset: 0x00106432
	internal override bool HasChanged()
	{
		return this.10.Count > 0;
	}

	// Token: 0x06002F5E RID: 12126 RVA: 0x0010BE0C File Offset: 0x0010A00C
	internal override void Apply(2457 1)
	{
		if (1 != (2457)1)
		{
			if (1 != (2457)2)
			{
				goto IL_97;
			}
		}
		else
		{
			using (List<object>.Enumerator enumerator = this.10.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					2647 2 = (2647)obj;
					this.4.7.9(2);
				}
				goto IL_97;
			}
		}
		foreach (object obj2 in this.10)
		{
			2647 3 = (2647)obj2;
			this.4.7.12(3);
		}
		IL_97:
		base.19();
	}
}
