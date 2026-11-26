using System;
using System.Collections.Generic;

// Token: 0x020005EB RID: 1515
public sealed class 2371 : 2373
{
	// Token: 0x06002EAD RID: 11949 RVA: 0x00108124 File Offset: 0x00106324
	internal 2371(2439 1, 2450 2) : base(1, 2)
	{
		base.2((2451)0);
	}

	// Token: 0x06002EAE RID: 11950 RVA: 0x0001702D File Offset: 0x0001522D
	internal override bool CaptureBackup()
	{
		return true;
	}

	// Token: 0x06002EAF RID: 11951 RVA: 0x00108138 File Offset: 0x00106338
	internal override bool HasChanged()
	{
		int num = 0;
		using (List<object>.Enumerator enumerator = this.8.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if ((int)enumerator.Current != this.4.6.25[num])
				{
					return true;
				}
				num++;
			}
		}
		return false;
	}

	// Token: 0x06002EB0 RID: 11952 RVA: 0x001081B0 File Offset: 0x001063B0
	internal override void Apply(2457 1)
	{
		List<int> 2 = this.4.6.25;
		for (int i = 0; i < this.8.Count; i++)
		{
			int num = (int)this.8[i];
			if (2[i] != num)
			{
				this.8[i] = 2[i];
				2[i] = num;
			}
		}
	}
}
