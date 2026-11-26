using System;
using System.Collections.Generic;

// Token: 0x02000626 RID: 1574
public sealed class 2430 : 2435
{
	// Token: 0x06002FBF RID: 12223 RVA: 0x0010DB0B File Offset: 0x0010BD0B
	internal 2430(2447 1, 2450 2) : base(1, 2)
	{
		base.2((2451)0);
	}

	// Token: 0x06002FC0 RID: 12224 RVA: 0x0010DB1C File Offset: 0x0010BD1C
	internal override bool CaptureBackup()
	{
		if (!base.9())
		{
			throw new 2448.2449("Not enough objects to initiate backup data");
		}
		if (this.13 == null)
		{
			this.13 = new List<double>();
		}
		base.15(new 2435.2436(this.16));
		return true;
	}

	// Token: 0x06002FC1 RID: 12225 RVA: 0x0010DB57 File Offset: 0x0010BD57
	internal override void Release()
	{
		this.11.Add(this.13);
		base.Release();
	}

	// Token: 0x06002FC2 RID: 12226 RVA: 0x0010DB70 File Offset: 0x0010BD70
	internal override bool HasChanged()
	{
		int num = 0;
		using (List<object>.Enumerator enumerator = this.8.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (((1259)enumerator.Current).3 != this.13[num])
				{
					return true;
				}
				num++;
			}
		}
		return false;
	}

	// Token: 0x06002FC3 RID: 12227 RVA: 0x0010DBE0 File Offset: 0x0010BDE0
	internal override void Apply(2457 1)
	{
		int num = 0;
		foreach (object obj in this.8)
		{
			1259 2 = (1259)obj;
			177.Method12592<double>(this.13, num, ref 2.3);
			num++;
		}
		1226.69();
		1226.70(true);
	}

	// Token: 0x06002FC4 RID: 12228 RVA: 0x0010DC54 File Offset: 0x0010BE54
	private void 16(1259 1)
	{
		this.13.Add(1.3);
	}

	// Token: 0x04002263 RID: 8803
	private new List<double> 13;
}
