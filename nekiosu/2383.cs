using System;
using System.Collections.Generic;

// Token: 0x020005F7 RID: 1527
public sealed class 2383 : 2387
{
	// Token: 0x06002EE8 RID: 12008 RVA: 0x00109A7D File Offset: 0x00107C7D
	internal 2383(2440 1, 2450 2 = (2450)0) : base(1, 2)
	{
		base.2((2451)9);
	}

	// Token: 0x06002EE9 RID: 12009 RVA: 0x00109A8F File Offset: 0x00107C8F
	internal override bool CaptureBackup()
	{
		177.RemoveCommonItems<object>(this.10, this.9);
		return true;
	}

	// Token: 0x06002EEA RID: 12010 RVA: 0x00108232 File Offset: 0x00106432
	internal override bool HasChanged()
	{
		return this.10.Count > 0;
	}

	// Token: 0x06002EEB RID: 12011 RVA: 0x00109AA4 File Offset: 0x00107CA4
	internal override void Apply(2457 1)
	{
		if (1 != (2457)1)
		{
			if (1 != (2457)2)
			{
				goto IL_9B;
			}
		}
		else
		{
			using (List<object>.Enumerator enumerator = this.10.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					2034 2 = (2034)obj;
					this.4.6.AddHitObject(2, false, true);
				}
				goto IL_9B;
			}
		}
		foreach (object obj2 in this.10)
		{
			2034 3 = (2034)obj2;
			this.4.6.29(3, false);
		}
		IL_9B:
		this.4.1.74.16();
		this.4.6.2(true);
		this.4.6.74();
	}
}
