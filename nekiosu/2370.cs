using System;
using System.Collections.Generic;

// Token: 0x020005EA RID: 1514
public sealed class 2370 : 2373
{
	// Token: 0x06002EA9 RID: 11945 RVA: 0x00108020 File Offset: 0x00106220
	internal 2370(2439 1, 2450 2) : base(1, 2)
	{
		base.2((2451)8);
	}

	// Token: 0x06002EAA RID: 11946 RVA: 0x0001702D File Offset: 0x0001522D
	internal override bool CaptureBackup()
	{
		return true;
	}

	// Token: 0x06002EAB RID: 11947 RVA: 0x00108031 File Offset: 0x00106231
	internal override bool HasChanged()
	{
		return this.9.Count > 0;
	}

	// Token: 0x06002EAC RID: 11948 RVA: 0x00108044 File Offset: 0x00106244
	internal override void Apply(2457 1)
	{
		if (1 != (2457)1)
		{
			if (1 != (2457)2)
			{
				goto IL_A2;
			}
		}
		else
		{
			using (List<object>.Enumerator enumerator = this.9.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					int item = (int)obj;
					this.4.6.25.Remove(item);
				}
				goto IL_A2;
			}
		}
		foreach (object obj2 in this.9)
		{
			int item2 = (int)obj2;
			this.4.6.25.Add(item2);
		}
		IL_A2:
		this.4.6.25.Sort();
	}
}
