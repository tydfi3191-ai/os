using System;
using System.Collections.Generic;

// Token: 0x02000623 RID: 1571
public sealed class 2427 : 2435
{
	// Token: 0x06002FAD RID: 12205 RVA: 0x0010D6E0 File Offset: 0x0010B8E0
	internal 2427(2447 1, 2450 2) : base(1, 2)
	{
		base.2((2451)18);
	}

	// Token: 0x06002FAE RID: 12206 RVA: 0x0010D6F2 File Offset: 0x0010B8F2
	internal override bool CaptureBackup()
	{
		if (!base.9())
		{
			throw new 2448.2449("Not enough objects to initiate backup data");
		}
		if (base.7())
		{
			this.13 = new List<double>();
		}
		base.15(new 2435.2436(this.16));
		return true;
	}

	// Token: 0x06002FAF RID: 12207 RVA: 0x0010D72D File Offset: 0x0010B92D
	internal override void Release()
	{
		this.11.Add(this.13);
		base.Release();
	}

	// Token: 0x06002FB0 RID: 12208 RVA: 0x0010D748 File Offset: 0x0010B948
	internal override bool HasChanged()
	{
		int num = 0;
		using (List<object>.Enumerator enumerator = this.8.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (((1259)enumerator.Current).1 != this.13[num])
				{
					return true;
				}
				num++;
			}
		}
		return false;
	}

	// Token: 0x06002FB1 RID: 12209 RVA: 0x0010D7B8 File Offset: 0x0010B9B8
	internal override void Apply(2457 1)
	{
		int num = 0;
		foreach (object obj in this.8)
		{
			1259 2 = (1259)obj;
			177.Method12592<double>(this.13, num, ref 2.1);
			2.2(2.1 >= 0.0);
			num++;
		}
	}

	// Token: 0x06002FB2 RID: 12210 RVA: 0x0010D83C File Offset: 0x0010BA3C
	private void 16(1259 1)
	{
		this.13.Add(1.1);
	}

	// Token: 0x04002260 RID: 8800
	private new List<double> 13;
}
