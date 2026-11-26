using System;
using System.Collections.Generic;

// Token: 0x0200061B RID: 1563
public sealed class 2419 : 2421
{
	// Token: 0x06002F8B RID: 12171 RVA: 0x0010CE69 File Offset: 0x0010B069
	internal 2419(2445 1, 2450 2) : base(1, 2)
	{
		base.2((2451)30);
	}

	// Token: 0x06002F8C RID: 12172 RVA: 0x0001702D File Offset: 0x0001522D
	internal override bool CaptureBackup()
	{
		return true;
	}

	// Token: 0x06002F8D RID: 12173 RVA: 0x0010CE7B File Offset: 0x0010B07B
	internal override bool HasChanged()
	{
		return this.14.Count > 0;
	}

	// Token: 0x06002F8E RID: 12174 RVA: 0x0010CE8C File Offset: 0x0010B08C
	internal override void Apply(2457 1)
	{
		if (1 != (2457)1)
		{
			if (1 != (2457)2)
			{
				return;
			}
		}
		else
		{
			using (List<2445.2446>.Enumerator enumerator = this.14.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					2445.2446 2 = enumerator.Current;
					2647 3 = 2.1;
					if (3 != null && 3.7 != null)
					{
						3.7.3.Remove(2.2);
					}
				}
				return;
			}
		}
		foreach (2445.2446 4 in this.14)
		{
			2647 5 = 4.1;
			if (5 != null && 5.7 != null)
			{
				if (4.3 >= 5.7.3.Count)
				{
					5.7.3.Add(4.2);
				}
				else
				{
					5.7.3.Insert(4.3, 4.2);
				}
			}
		}
	}
}
