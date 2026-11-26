using System;
using System.Collections.Generic;

// Token: 0x0200061C RID: 1564
public sealed class 2420 : 2421
{
	// Token: 0x06002F8F RID: 12175 RVA: 0x0010CFAC File Offset: 0x0010B1AC
	internal 2420(2445 1, 2450 2) : base(1, 2)
	{
		base.2((2451)31);
	}

	// Token: 0x06002F90 RID: 12176 RVA: 0x0001702D File Offset: 0x0001522D
	internal override bool CaptureBackup()
	{
		return true;
	}

	// Token: 0x06002F91 RID: 12177 RVA: 0x0010CFBE File Offset: 0x0010B1BE
	internal override bool HasChanged()
	{
		return this.15.Count > 0;
	}

	// Token: 0x06002F92 RID: 12178 RVA: 0x0010CFD0 File Offset: 0x0010B1D0
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
			using (List<2445.2446>.Enumerator enumerator = this.15.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					2445.2446 2 = enumerator.Current;
					2647 3 = 2.1;
					if (3 != null && 3.7 != null)
					{
						if (2.3 >= 3.7.3.Count)
						{
							3.7.3.Add(2.2);
						}
						else
						{
							3.7.3.Insert(2.3, 2.2);
						}
					}
				}
				return;
			}
		}
		foreach (2445.2446 4 in this.15)
		{
			2647 5 = 4.1;
			if (5 != null && 5.7 != null)
			{
				5.7.3.Remove(4.2);
			}
		}
	}
}
