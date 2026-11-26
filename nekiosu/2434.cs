using System;
using System.Collections.Generic;

// Token: 0x0200062A RID: 1578
public sealed class 2434 : 2435
{
	// Token: 0x06002FD5 RID: 12245 RVA: 0x0010DFEF File Offset: 0x0010C1EF
	internal 2434(2447 1, 2450 2) : base(1, 2)
	{
		base.2((2451)21);
	}

	// Token: 0x06002FD6 RID: 12246 RVA: 0x0010E001 File Offset: 0x0010C201
	internal override bool CaptureBackup()
	{
		if (!base.9())
		{
			throw new 2448.2449("Not enough objects to initiate backup data");
		}
		if (base.7())
		{
			this.13 = new List<1257>();
		}
		base.15(new 2435.2436(this.16));
		return true;
	}

	// Token: 0x06002FD7 RID: 12247 RVA: 0x0010E03C File Offset: 0x0010C23C
	internal override void Release()
	{
		this.11.Add(this.13);
		base.Release();
	}

	// Token: 0x06002FD8 RID: 12248 RVA: 0x0010E058 File Offset: 0x0010C258
	internal override bool HasChanged()
	{
		int num = 0;
		using (List<object>.Enumerator enumerator = this.8.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (((1259)enumerator.Current).5 != this.13[num])
				{
					return true;
				}
				num++;
			}
		}
		return false;
	}

	// Token: 0x06002FD9 RID: 12249 RVA: 0x0010E0C8 File Offset: 0x0010C2C8
	internal override void Apply(2457 1)
	{
		int num = 0;
		foreach (object obj in this.8)
		{
			1259 2 = (1259)obj;
			177.Method12592<1257>(this.13, num, ref 2.5);
			num++;
		}
	}

	// Token: 0x06002FDA RID: 12250 RVA: 0x0010E134 File Offset: 0x0010C334
	private void 16(1259 1)
	{
		this.13.Add(1.5);
	}

	// Token: 0x04002266 RID: 8806
	private new List<1257> 13;
}
