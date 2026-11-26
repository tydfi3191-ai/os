using System;
using System.Collections.Generic;

// Token: 0x02000624 RID: 1572
public sealed class 2428 : 2435
{
	// Token: 0x06002FB3 RID: 12211 RVA: 0x0010D84F File Offset: 0x0010BA4F
	internal 2428(2447 1, 2450 2) : base(1, 2)
	{
		base.2((2451)1);
	}

	// Token: 0x06002FB4 RID: 12212 RVA: 0x0010D860 File Offset: 0x0010BA60
	internal override bool CaptureBackup()
	{
		if (!base.9())
		{
			throw new 2448.2449("Not enough objects to initiate backup data");
		}
		if (base.7())
		{
			this.13 = new List<1258>();
		}
		base.15(new 2435.2436(this.16));
		return true;
	}

	// Token: 0x06002FB5 RID: 12213 RVA: 0x0010D89B File Offset: 0x0010BA9B
	internal override void Release()
	{
		this.11.Add(this.13);
		base.Release();
	}

	// Token: 0x06002FB6 RID: 12214 RVA: 0x0010D8B4 File Offset: 0x0010BAB4
	internal override bool HasChanged()
	{
		int num = 0;
		using (List<object>.Enumerator enumerator = this.8.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (((1259)enumerator.Current).8 != this.13[num])
				{
					return true;
				}
				num++;
			}
		}
		return false;
	}

	// Token: 0x06002FB7 RID: 12215 RVA: 0x0010D924 File Offset: 0x0010BB24
	internal override void Apply(2457 1)
	{
		int num = 0;
		foreach (object obj in this.8)
		{
			1259 2 = (1259)obj;
			177.Method12592<1258>(this.13, num, ref 2.8);
			num++;
		}
	}

	// Token: 0x06002FB8 RID: 12216 RVA: 0x0010D990 File Offset: 0x0010BB90
	private void 16(1259 1)
	{
		this.13.Add(1.8);
	}

	// Token: 0x04002261 RID: 8801
	private new List<1258> 13;
}
