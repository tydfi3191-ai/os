using System;
using System.Collections.Generic;

// Token: 0x020005EF RID: 1519
public sealed class 2375 : 2387
{
	// Token: 0x06002EBA RID: 11962 RVA: 0x001083C3 File Offset: 0x001065C3
	internal 2375(2440 1, 2450 2 = (2450)0) : base(1, 2)
	{
		base.2((2451)8);
	}

	// Token: 0x06002EBB RID: 11963 RVA: 0x0001702D File Offset: 0x0001522D
	protected override bool SelectsListByFlags()
	{
		return true;
	}

	// Token: 0x06002EBC RID: 11964 RVA: 0x001083D4 File Offset: 0x001065D4
	internal override bool CaptureBackup()
	{
		177.RemoveCommonItems<object>(this.9, this.10);
		return true;
	}

	// Token: 0x06002EBD RID: 11965 RVA: 0x00108031 File Offset: 0x00106231
	internal override bool HasChanged()
	{
		return this.9.Count > 0;
	}

	// Token: 0x06002EBE RID: 11966 RVA: 0x001083E8 File Offset: 0x001065E8
	internal override void Apply(2457 1)
	{
		this.4.1.74.65();
		if (1 != (2457)1)
		{
			if (1 != (2457)2)
			{
				goto IL_165;
			}
		}
		else
		{
			foreach (object obj in this.9)
			{
				2034 2 = (2034)obj;
				this.4.6.29(2, false);
			}
			if (this.10.Count <= 0)
			{
				goto IL_165;
			}
			using (List<object>.Enumerator enumerator = this.10.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					object obj2 = enumerator.Current;
					2034 3 = (2034)obj2;
					this.4.6.AddHitObject(3, false, true);
				}
				goto IL_165;
			}
		}
		if (this.10.Count > 0)
		{
			foreach (object obj3 in this.10)
			{
				2034 4 = (2034)obj3;
				this.4.6.29(4, false);
			}
		}
		foreach (object obj4 in this.9)
		{
			2034 5 = (2034)obj4;
			this.4.6.AddHitObject(5, false, true);
		}
		IL_165:
		this.4.1.74.16();
		this.4.6.2(true);
		this.4.6.74();
	}
}
