using System;
using System.Collections.Generic;

// Token: 0x0200062D RID: 1581
public sealed class 2437 : 2435
{
	// Token: 0x06002FE1 RID: 12257 RVA: 0x0010E189 File Offset: 0x0010C389
	internal 2437(2447 1, 2450 2) : base(1, 2)
	{
		base.2((2451)19);
	}

	// Token: 0x06002FE2 RID: 12258 RVA: 0x0010E19B File Offset: 0x0010C39B
	internal override bool CaptureBackup()
	{
		if (!base.9())
		{
			throw new 2448.2449("Not enough objects to initiate backup data");
		}
		if (base.7())
		{
			this.13 = new List<int>();
		}
		base.15(new 2435.2436(this.16));
		return true;
	}

	// Token: 0x06002FE3 RID: 12259 RVA: 0x0010E1D6 File Offset: 0x0010C3D6
	internal override void Release()
	{
		this.11.Add(this.13);
		base.Release();
	}

	// Token: 0x06002FE4 RID: 12260 RVA: 0x0010E1F0 File Offset: 0x0010C3F0
	internal override bool HasChanged()
	{
		int num = 0;
		using (List<object>.Enumerator enumerator = this.8.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (((1259)enumerator.Current).6 != this.13[num])
				{
					return true;
				}
				num++;
			}
		}
		return false;
	}

	// Token: 0x06002FE5 RID: 12261 RVA: 0x0010E260 File Offset: 0x0010C460
	internal override void Apply(2457 1)
	{
		int num = 0;
		foreach (object obj in this.8)
		{
			1259 2 = (1259)obj;
			177.Method12592<int>(this.13, num, ref 2.6);
			num++;
		}
	}

	// Token: 0x06002FE6 RID: 12262 RVA: 0x0010E2CC File Offset: 0x0010C4CC
	private void 16(1259 1)
	{
		this.13.Add(1.6);
	}

	// Token: 0x04002267 RID: 8807
	private new List<int> 13;
}
