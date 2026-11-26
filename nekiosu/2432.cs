using System;
using System.Collections.Generic;

// Token: 0x02000628 RID: 1576
public sealed class 2432 : 2435
{
	// Token: 0x06002FC9 RID: 12233 RVA: 0x0010DD44 File Offset: 0x0010BF44
	internal 2432(2447 1, 2450 2) : base(1, 2)
	{
		base.2((2451)22);
	}

	// Token: 0x06002FCA RID: 12234 RVA: 0x0010DD56 File Offset: 0x0010BF56
	internal override bool CaptureBackup()
	{
		if (!base.9())
		{
			throw new 2448.2449("Not enough objects to initiate backup data");
		}
		if (base.7())
		{
			this.13 = new List<1253>();
		}
		base.15(new 2435.2436(this.16));
		return true;
	}

	// Token: 0x06002FCB RID: 12235 RVA: 0x0010DD91 File Offset: 0x0010BF91
	internal override void Release()
	{
		this.11.Add(this.13);
		base.Release();
	}

	// Token: 0x06002FCC RID: 12236 RVA: 0x0010DDAC File Offset: 0x0010BFAC
	internal override bool HasChanged()
	{
		int num = 0;
		using (List<object>.Enumerator enumerator = this.8.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (((1259)enumerator.Current).2 != this.13[num])
				{
					return true;
				}
				num++;
			}
		}
		return false;
	}

	// Token: 0x06002FCD RID: 12237 RVA: 0x0010DE1C File Offset: 0x0010C01C
	internal override void Apply(2457 1)
	{
		int num = 0;
		foreach (object obj in this.8)
		{
			1259 2 = (1259)obj;
			177.Method12592<1253>(this.13, num, ref 2.2);
			num++;
		}
	}

	// Token: 0x06002FCE RID: 12238 RVA: 0x0010DE88 File Offset: 0x0010C088
	private void 16(1259 1)
	{
		this.13.Add(1.2);
	}

	// Token: 0x04002264 RID: 8804
	private new List<1253> 13;
}
