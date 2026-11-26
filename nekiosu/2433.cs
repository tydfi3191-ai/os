using System;
using System.Collections.Generic;

// Token: 0x02000629 RID: 1577
public sealed class 2433 : 2435
{
	// Token: 0x06002FCF RID: 12239 RVA: 0x0010DE9B File Offset: 0x0010C09B
	internal 2433(2447 1, 2450 2) : base(1, 2)
	{
		base.2((2451)3);
	}

	// Token: 0x06002FD0 RID: 12240 RVA: 0x0010DEAC File Offset: 0x0010C0AC
	internal override bool CaptureBackup()
	{
		if (!base.9())
		{
			throw new 2448.2449("Not enough objects to initiate backup data");
		}
		if (base.7())
		{
			this.13 = new List<1254>();
		}
		base.15(new 2435.2436(this.16));
		return true;
	}

	// Token: 0x06002FD1 RID: 12241 RVA: 0x0010DEE7 File Offset: 0x0010C0E7
	internal override void Release()
	{
		this.11.Add(this.13);
		base.Release();
	}

	// Token: 0x06002FD2 RID: 12242 RVA: 0x0010DF00 File Offset: 0x0010C100
	internal override bool HasChanged()
	{
		int num = 0;
		using (List<object>.Enumerator enumerator = this.8.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (((1259)enumerator.Current).4 != this.13[num])
				{
					return true;
				}
				num++;
			}
		}
		return false;
	}

	// Token: 0x06002FD3 RID: 12243 RVA: 0x0010DF70 File Offset: 0x0010C170
	internal override void Apply(2457 1)
	{
		int num = 0;
		foreach (object obj in this.8)
		{
			1259 2 = (1259)obj;
			177.Method12592<1254>(this.13, num, ref 2.4);
			num++;
		}
	}

	// Token: 0x06002FD4 RID: 12244 RVA: 0x0010DFDC File Offset: 0x0010C1DC
	private void 16(1259 1)
	{
		this.13.Add(1.4);
	}

	// Token: 0x04002265 RID: 8805
	private new List<1254> 13;
}
